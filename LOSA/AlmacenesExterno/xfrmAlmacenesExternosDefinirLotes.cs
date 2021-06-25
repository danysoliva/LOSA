using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LOSA.AlmacenesExterno.Models;
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;
using LOSA.AlmacenesExterno.Reporteria;
using DevExpress.XtraReports.UI;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmAlmacenesExternosDefinirLotes : DevExpress.XtraEditors.XtraForm
    {
        List<Conf_MP_Ingresada> lista = new List<Conf_MP_Ingresada>();
        OrdenCompra_H oc_h = new OrdenCompra_H();
        decimal totalPeso, totalUnidades;
        UserLogin UsuarioLogueado;

        public xfrmAlmacenesExternosDefinirLotes(List<Conf_MP_Ingresada> pLista, OrdenCompra_H pOC_h,UserLogin pUser)
        {
            InitializeComponent();
            lista = pLista;
            LoadLotes();
            oc_h = pOC_h;
            UsuarioLogueado = pUser;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void xfrmAlmacenesExternosDefinirLotes_Load(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                DataRow workRow = dsAlmacenesExternos.Conf_MP_Ingresadas.NewRow();
                workRow[0] = item.ItemCode;
                workRow[1] = item.CantIngresada;
                workRow[2] = item.Descripcion;
                workRow[3] = item.UnidadesIngresadas;
                //workRow[4] = ;
                workRow[5] = item.LineNum;
                workRow[6] = item.MPID;
                dsAlmacenesExternos.Conf_MP_Ingresadas.Rows.Add(workRow);

                totalPeso = totalPeso + item.CantIngresada;
                totalUnidades = totalUnidades + item.UnidadesIngresadas;
            }

        }

          List<Ingreso_Externo_Lote> lotes = new List<Ingreso_Externo_Lote>();
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xfrmLoteCRUD frm = new xfrmLoteCRUD();

            var gvConfMP = (GridView)gcIngreso.FocusedView;
            //var row = (dsAlmacenesExternos.Conf_MP_IngresadasRow)gvConfMP.GetDataRow(gvConfMP.FocusedRowHandle);

            

            if (frm.ShowDialog()== DialogResult.OK)
            {
                frm.lote.Row_ = lotes.Count + 1;
                lotes.Add(frm.lote);
                int counterRows=1;
                dsAlmacenesExternos.Lote.Clear();

                var lotesDisponibles = lotes.Where(x => x.NumLine == -1);

                foreach (var item in lotesDisponibles)
                {
                    DataRow workRow = dsAlmacenesExternos.Lote.NewRow();

                    workRow[0] = item.ID;
                    workRow[1] = item.Cantidad;
                    workRow[2] = item.Unidades;
                    workRow[3] = 0;
                    workRow[4] = item.Lote;
                    workRow[7] = item.NumLine;
                    workRow[8] = item.Row_ ;
                    workRow["fecha_vencimiento"] = item.FechaVencimiento;
                    workRow["fecha_produccion"] = item.FechaProduccion;
                    counterRows++;

                    dsAlmacenesExternos.Lote.Rows.Add(workRow);

                }
            }
        }




        private void gvLote_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcLote.FocusedView;
            var row = (dsAlmacenesExternos.LoteRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (e.Column.FieldName == "Seleccionar")
            {
                if (row.num_line == -1)
                {
                    row.num_line = Convert.ToInt32(gvIngreso.GetFocusedRowCellValue(colLineNum).ToString());
                    //lotes.Find(x => x.Row_ == e.RowHandle + 1).NumLine = Convert.ToInt32(gvIngreso.GetFocusedRowCellValue(colLineNum).ToString());
                }
            }


            if (e.Column.FieldName == "CantSeleccionada")
            {

                if (row != null)
                {
                    if (row.CantSeleccionada > row.cantidad)
                    {
                        CajaDialogo.Error("DEBES SELECCIONAR UNA CANTIDAD MENOR O IGUAL A LA DISPONIBLE");
                        row.CantSeleccionada = 0;
                    }
                }
                gvIngreso.PostEditor();
            }
        }

        List<Ingreso_Externo_Lote_Seleccionado> list_lotes_seleccionados = new List<Ingreso_Externo_Lote_Seleccionado>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {



                var gv = (GridView)gcLote.FocusedView;
                var row = (dsAlmacenesExternos.LoteRow)gv.GetDataRow(gv.FocusedRowHandle);



                int contadorRepetidos = 0;
                int counterGrid = 0;

                foreach (var item in dsAlmacenesExternos.Lote)
                {

                    counterGrid++;
                    if (item.Seleccionar == true)
                    {
                            if (item.CantSeleccionada==0)
                            {
                                CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD");
                                return;
                            }
                        if (item.CantSeleccionada == 0)
                        {
                            return;
                        }

                        contadorRepetidos = 0;
                        foreach (var item2 in dsAlmacenesExternos.Lote_Seleccionados)
                        {
                            if (item.id == item2.id)
                            {
                                contadorRepetidos++;
                            }
                        }

                        if (contadorRepetidos == 0)
                        {
                            DataRow workRow = dsAlmacenesExternos.Lote_Seleccionados.NewRow();
                            Ingreso_Externo_Lote_Seleccionado lote = new Ingreso_Externo_Lote_Seleccionado();

                            workRow[0] = item.id;
                            workRow[1] = item.cantidad;
                            workRow[2] = item.unidades;
                            workRow[3] = 0;
                            workRow[4] = item.lote;
                            workRow[5] = item.CantSeleccionada;
                            workRow[7] = item.num_line;
                            workRow[8] = item.row_;
                            workRow[9] = item.fecha_vencimiento;
                            workRow["fecha_produccion"] = item.fecha_produccion;

                            dsAlmacenesExternos.Lote_Seleccionados.Rows.Add(workRow);


                            ///Guardar en lista los lotes
                            lote.ID = item.id;
                            lote.Cantidad = item.cantidad;
                            lote.Unidades = item.unidades;
                            lote.Lote = "";
                            lote.Lote = item.lote;
                            lote.Cantidad = item.CantSeleccionada;
                            lote.NumLine = item.num_line;
                            lote.Row_ = item.row_;
                            lote.FechaVencimiento = item.fecha_vencimiento;
                            lote.FechaProduccion = item.fecha_produccion;

                            list_lotes_seleccionados.Add(lote);

                            lotes.Find(x => x.Row_ == item.row_).NumLine = Convert.ToInt32(gvIngreso.GetFocusedRowCellValue(colLineNum).ToString());

                        }
                    }
                }
                ceSeleccionar_Click(null, null);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("sp_get_lote_almacenes_externos",cnx);
                    dsAlmacenesExternos.Lote.Clear();
                    da.Fill(dsAlmacenesExternos.Lote);

                    cnx.Close();
                }


                foreach (var item in dsAlmacenesExternos.Lote)
                {
                    Ingreso_Externo_Lote lote = new Ingreso_Externo_Lote();

                    lote.ID = item.id;
                    lote.NumLine = item.num_line;
                    lote.Lote = item.lote;
                    lote.Unidades = item.unidades;
                    lote.Cantidad = item.cantidad;
                    lote.Row_ = item.row_;

                    lotes.Add(lote);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var gv = (GridView)gcLoteSelecionados.FocusedView;
                var row = (dsAlmacenesExternos.Lote_SeleccionadosRow)gv.GetDataRow(gv.FocusedRowHandle);

                
                lotes.Find(x => x.Row_ == row.row_).NumLine = -1;

                var loteSeleccionadoDelete = list_lotes_seleccionados.Find(x => x.Row_ == row.row_);


                var tmpList = lotes.Where(x => x.NumLine == -1);

                dsAlmacenesExternos.Lote.Clear();
                foreach (var item in tmpList)
                {
                    DataRow workRow = dsAlmacenesExternos.Lote.NewRow();

                    workRow[0] = item.ID;
                    workRow[1] = item.Cantidad;
                    workRow[2] = item.Unidades;
                    workRow[3] = 0;
                    workRow[4] = item.Lote;
                    workRow[7] = item.NumLine;
                    workRow[8] = item.Row_;

                    dsAlmacenesExternos.Lote.Rows.Add(workRow);
                    list_lotes_seleccionados.Remove(loteSeleccionadoDelete);
                }

                row.Delete();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        SqlTransaction transaction;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //var test = 
                //CajaDialogo.Information(dsAlmacenesExternos.Conf_MP_Ingresadas.Select("LineNum=0").ToString());

                var SumCantSeleccionados = list_lotes_seleccionados.Sum(x => x.Cantidad);
                var SumUnidadesSeleccionados = list_lotes_seleccionados.Sum(x => x.Unidades);

                if (totalPeso!= SumCantSeleccionados || totalUnidades != SumUnidadesSeleccionados)
                {
                    CajaDialogo.Error("LA CANTIDAD DE LOTES SELECCIONADOS NO COINCIDEN CON LA MATERIA PRIMA");
                    return;
                }

                //foreach (var item in dsAlmacenesExternos.Conf_MP_Ingresadas)
                //{
                //    if (item.fecha_vencimiento.Year == 1900 && item.fecha_vencimiento.Month==1 && item.fecha_vencimiento.Day==1)
                //    {
                //        CajaDialogo.Error("DEBE DE INGRESAR LA FECHA DE VENCIMIENTO");
                //        return;
                //    }
                //}
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);
                int id_h = 0;
                int id_d = 0;


                cnx.Open();
                transaction = cnx.BeginTransaction("SampleTransaction");

                SqlCommand cmd = new SqlCommand("sp_insert_almacenes_externos_h", transaction.Connection);
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_bodega", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = totalPeso;
                cmd.Parameters.Add("@cardcode", SqlDbType.VarChar).Value = oc_h.CodProv;
                cmd.Parameters.Add("@fecha_ingreso", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@id_user_creador", SqlDbType.Int).Value = UsuarioLogueado.Id;
                //cmd.Parameters.Add("@id_user_creador", SqlDbType.Int).Value = 1104;
                cmd.Parameters.Add("@enable", SqlDbType.Bit).Value = 1;
                cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@fecha_documento", SqlDbType.Date).Value = oc_h.FechaDocumento;
                cmd.Parameters.Add("@DocEntrySAP", SqlDbType.Int).Value = oc_h.DocNum;
                cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = totalUnidades;


                id_h = Convert.ToInt32(cmd.ExecuteScalar());


                foreach (var item in dsAlmacenesExternos.Conf_MP_Ingresadas)
                {


                    SqlCommand cmd2 = new SqlCommand("sp_insert_almacenes_externos_d", transaction.Connection);
                    cmd2.Transaction = transaction;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.CantidadIngresada;
                    cmd2.Parameters.Add("@enable", SqlDbType.Bit).Value = 1;
                    cmd2.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item.UnidadesIngresar;
                    cmd2.Parameters.Add("@itemcode", SqlDbType.VarChar).Value = item.ItemCode;
                    cmd2.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.id_mp;
                    cmd2.Parameters.Add("@NumLine", SqlDbType.Int).Value = item.LineNum;
                    cmd2.Parameters.Add("@id_ingreso_h", SqlDbType.Int).Value = id_h;
                    cmd2.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime).Value = item.fecha_vencimiento;

                    id_d = Convert.ToInt32(cmd2.ExecuteScalar());

                    var tmpLotesSeleccionados = list_lotes_seleccionados.Where(x => x.NumLine == item.LineNum).ToList();

                    foreach (var item2 in tmpLotesSeleccionados)
                    {
                        SqlCommand cmd3 = new SqlCommand("sp_almacenes_externos_asignar_lotes_seleccionados ", transaction.Connection);
                        cmd3.Transaction = transaction;
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = item2.Cantidad;
                        cmd3.Parameters.Add("@unidades", SqlDbType.Decimal).Value = item2.Unidades;
                        cmd3.Parameters.Add("@id_detalle", SqlDbType.Int).Value = id_d;
                        cmd3.Parameters.Add("@id", SqlDbType.Int).Value = item2.ID;
                        cmd3.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime).Value = item2.FechaVencimiento;
                        cmd3.Parameters.Add("@fecha_produccion", SqlDbType.DateTime).Value = item2.FechaProduccion;

                        cmd3.ExecuteNonQuery();

                    }

                }


                transaction.Commit();
                cnx.Close();

                CajaDialogo.Information("SE HA GUARDADO EL REGISTRO EXITOSAMENTE");

                xrptAlmacenesExternos report = new xrptAlmacenesExternos(id_h);

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private void gvLote_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcLote.FocusedView;
            var row = (dsAlmacenesExternos.LoteRow)gv.GetDataRow(gv.FocusedRowHandle);

        }

     
        private void ceSeleccionar_Click(object sender, EventArgs e)
        {

            try
            {

                var gv = (GridView)gcIngreso.FocusedView;
                var row = (dsAlmacenesExternos.Conf_MP_IngresadasRow)gv.GetDataRow(gv.FocusedRowHandle);

                foreach (var item in dsAlmacenesExternos.Conf_MP_Ingresadas)
                {
                    item.seleccionar = false;
                }

                if (row != null)
                {
                    row.seleccionar = true;

                }


                //var gv = (GridView)gcIngreso.FocusedView;
                //var row = (dsAlmacenesExternos.Conf_MP_IngresadasRow)gv.GetDataRow(gv.FocusedRowHandle);

                var lotesMPSelecionada = list_lotes_seleccionados.Where(p => p.NumLine == row.LineNum).ToList();

                var lotesMP = lotes.Where(p => p.NumLine == -1).ToList();

                dsAlmacenesExternos.Lote_Seleccionados.Clear();
               
                foreach (var item in lotesMPSelecionada)
                {
                    DataRow workRow = dsAlmacenesExternos.Lote_Seleccionados.NewRow();

                    workRow[0] = item.ID;
                    workRow[1] = item.Cantidad;
                    workRow[2] = item.Unidades;
                    workRow[3] = 0;
                    workRow[4] = item.Lote;
                    workRow[5] = item.Cantidad;
                    workRow[7] = item.NumLine;
                    workRow[8] = item.Row_;
                    workRow["fecha_vencimiento"] = item.FechaVencimiento;
                    workRow["fecha_produccion"] = item.FechaProduccion;

                    dsAlmacenesExternos.Lote_Seleccionados.Rows.Add(workRow);
                }



                dsAlmacenesExternos.Lote.Clear();
                //int counterRows = 1;

                foreach (var item in lotesMP)
                {
                    DataRow workRow = dsAlmacenesExternos.Lote.NewRow();

                    workRow[0] = item.ID;
                    workRow[1] = item.Cantidad;
                    workRow[2] = item.Unidades;
                    workRow[3] = 0;
                    workRow[4] = item.Lote;
                    //workRow[7] = row.LineNum;
                    workRow[8] = item.Row_;
                    //counterRows++;

                    dsAlmacenesExternos.Lote.Rows.Add(workRow);
                }








            }
            catch (Exception exx)
            {
                CajaDialogo.Error(exx.Message);
            }
        }

        private void gvIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           


        }

       
    }
}