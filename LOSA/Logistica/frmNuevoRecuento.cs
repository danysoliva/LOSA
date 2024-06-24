using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using LOSA.RecuentoInventario;
using System.Globalization;
using System.Data.OleDb;
using Huellas;
using System.Collections;

namespace LOSA.Logistica
{
    public partial class frmNuevoRecuento : DevExpress.XtraEditors.XtraForm
    {
        Recuento NuevoRecuento;
        UserLogin UsuarioLogeado;
        int tabActive;
        int DEFAULT_VALUE = 0;
        DataOperations dp = new DataOperations();
        public frmNuevoRecuento(UserLogin Puser)
        {
            InitializeComponent();
            tabActive = DEFAULT_VALUE;
            UsuarioLogeado = Puser;
            NuevoRecuento = new Recuento();
            get_years();
            get_bodegas();
            grdBodegas.EditValue = 2; //Bodega Produccion
            

            Inicializar_productos(Convert.ToInt32(grdBodegas.EditValue));
            foreach (dsCierreMes.Recuento_mpRow item in dsCierreMes1.Recuento_mp.Rows)
            {
                if (item.whs_equivalente == "N/D")
                {
                    item.id_bodega = Convert.ToInt32(grdBodegas.EditValue);
                }
            }

            dateEdit1.EditValue = dp.Now();

            grd_years.Text = Convert.ToString(dateEdit1.DateTime.Year);
            grd_meses_disponibles.Text = Convert.ToString(dateEdit1.DateTime.Month);
            grd_years.Enabled = true;
        }

        public void Inicializar_productos(int pid_bodega)
        {
            string query = @"sp_get_inizializar_grid_for_MP_ajusteV3";
            //string query = @"sp_get_inizializar_grid_for_MP_ajusteV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd2 = new SqlCommand(query, cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                dsCierreMes1.Recuento_mp.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                cmd2.Parameters.AddWithValue("@id_bodega", pid_bodega);
                da.Fill(dsCierreMes1.Recuento_mp);
                cn.Close();
            }
            catch (Exception ex)
            {
                dsCierreMes1.Recuento_mp.Clear();
                CajaDialogo.Error(ex.Message);
            }

            try
            {
                query = @"sp_get_inizializar_grid_for_ptV2";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.Recuento_pt.Clear();
                da.Fill(dsCierreMes1.Recuento_pt);
                cn.Close();
            }
            catch (Exception ex)
            {
                dsCierreMes1.Recuento_pt.Clear();
                CajaDialogo.Error(ex.Message);
            }
        }
            
        public void get_bodegas()
        {
            string query = @"sp_get_bodegas_id_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes1.bodegas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes1.bodegas);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void get_meses_by_year()
        {
            string query = @"sp_get_meses_disponible_por_ejercicio";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@year", NuevoRecuento.year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.meses.Clear();
                da.Fill(dsCierreMes1.meses);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void get_years()
        {
            string query = @"sp_obtener_años_disponibles";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.years.Clear();
                da.Fill(dsCierreMes1.years);
                cn.Close();
               
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Recuento
        {
            public int mes;
            public string mes_name;
            public int year;
            public string comentario;
            public DateTime date_counted;
            private int DEFAULT_VALUE = 0;

            public Recuento()
            {
                mes = DEFAULT_VALUE;
                mes_name = "";
                year = DEFAULT_VALUE;
                comentario = "";
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tabActive = xtraTabControl1.SelectedTabPageIndex;
        }

        private void grd_meses_disponibles_EditValueChanged(object sender, EventArgs e)
        {
            NuevoRecuento.mes = Convert.ToInt32(grd_meses_disponibles.EditValue);
            NuevoRecuento.mes_name = grd_meses_disponibles.Text;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            NuevoRecuento.year = Convert.ToInt32(grd_years.EditValue);
            if (NuevoRecuento.year != DEFAULT_VALUE)
            {
                grd_meses_disponibles.Enabled = true;
                get_meses_by_year();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_selecionarProducto frm = new frm_selecionarProducto(tabActive);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (tabActive == 0)
                {
                    DataRow dr = dsCierreMes1.Recuento_mp.NewRow();
                    dr["id_mp"] = frm.id;
                    dr["descripcion"] = frm.descripcion;
                    //dr["odoo"] = frm.codigo;
                    dr["code_sap"] = frm.itemcode;
                    dr["peso"] = DEFAULT_VALUE;
                    dr["diferencia"] = DEFAULT_VALUE;
                    dr["id_bodega"] = DEFAULT_VALUE;
                    dr["ExistenciaAprox"] = DEFAULT_VALUE;
                    dsCierreMes1.Recuento_mp.Rows.Add(dr);
                    dsCierreMes1.Recuento_mp.AcceptChanges();
                }
                else
                {
                    DataRow dr = dsCierreMes1.Recuento_pt.NewRow();
                    dr["id_mp"] = frm.id;
                    dr["descripcion"] = frm.descripcion;
                    //dr["odoo"] = frm.codigo;
                    dr["code_sap"] = frm.itemcode;
                    dr["peso"] = DEFAULT_VALUE;
                    dr["diferencia"] = DEFAULT_VALUE;
                    dr["id_bodega"] = DEFAULT_VALUE;
                    dr["ExistenciaAprox"] = DEFAULT_VALUE;
                    dsCierreMes1.Recuento_pt.Rows.Add(dr);
                    dsCierreMes1.Recuento_pt.AcceptChanges();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_dataMP.DeleteRow(grdv_dataMP.FocusedRowHandle);
                dsCierreMes1.Recuento_mp.AcceptChanges();
            }
            catch (Exception )
            {

            }
        }

        private void btneliminarpt_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_data_pt.DeleteRow(grdv_data_pt.FocusedRowHandle);
                dsCierreMes1.Recuento_pt.AcceptChanges();
            }
            catch (Exception)
            {

            }
        }

        private void grdv_dataMP_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            //GridView view = sender as GridView;
            //GridColumn colBodega = view.Columns["colid_bodega"];
            //var gridView = (GridView)grd_dataMp.FocusedView;
            //var RowSelecionada = (dsCierreMes.Recuento_mpRow)gridView.GetFocusedDataRow();
            ////Get the value of the first column
            ////Get the value of the second column
            ////Validity criterion
            //IEnumerable<DataRow> YaEstaLabodega = from row in dsCierreMes.Recuento_mp.AsEnumerable()
            //                                      where row.id_mp == RowSelecionada.id_mp && row.id_bodega == Convert.ToInt32(RowSelecionada.id_bodega)
            //                                      select row;

            //if (YaEstaLabodega.Count() > 1)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(colBodega, "Se ha seleccionado dos veces la misma bodega para una materia prima.",DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                
            //}

            ////Bueno si nos dejan... nos vamos a querer toda la bici... bueno vamo a calcular cuanto inventario tenemos 
            ////-- Siempre pongo las dos guiones como que si estuviera en SQL server
            //// Si lees esto me deben un cafe, sea quien seas. Hail Marathon. att Rodrigo  si ya me botaron 94388749   o mandame una captura de este
            //// Mensaje y dime que te parecio mi codigo, no es mucho pero es trabajo honesto es una broma muy famosa en el año 2021. 

            //int id_mp_selected = RowSelecionada.id_mp;
            //// vamos a consultar en el kardex el invenario de esta MP.
            //Kardex RegistroMP = new Kardex();
            //if (RegistroMP.GetTotalInventarioKgByMp(id_mp_selected,RowSelecionada.id_bodega))
            //{
            //    RowSelecionada.ExistenciaAprox = RegistroMP.TotalInventarioMP;
            //    RowSelecionada.diferencia = RowSelecionada.ExistenciaAprox - RowSelecionada.peso;
            //    RowSelecionada.AcceptChanges();   
            //}
            //else
            //{ 
            //    RowSelecionada.diferencia = 0 - RowSelecionada.peso;
            //    RowSelecionada.AcceptChanges();
            //}

        }

        private void grdv_dataMP_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            //e.ErrorText = "Una materia prima no puede ajustarse si se ha seleccionado dos veces la misma bodega.";
            //    e.WindowCaption = "Error en la configuracion.";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            //var list = dsCierreMes1.Recuento_mp.AsEnumerable();
            //if (list.Count(p => p.peso > 0) <= 0)
            //{
            //    CajaDialogo.Error("Debe de haber por lo menos una materia prima para modificar para poder crear el ajuste de inventario.");
            //    return;
            //}

            //var SelectedRows = from row in list
            //                   where row.peso > 0
            //                   select row;

            //DataTable tableOps = new DataTable();

            //tableOps = SelectedRows.CopyToDataTable<DataRow>();
            //frmSeleccionLoteCierre frm = new frmSeleccionLoteCierre(tableOps, UsuarioLogeado);
            //if (frm.ShowDialog()== DialogResult.OK)
            //{

            //}
            
        }

        private void grdv_dataMP_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var gridview1 = (GridView)grd_dataMp.FocusedView;
            var row = (dsCierreMes.Recuento_mpRow)gridview1.GetFocusedDataRow();

            switch (e.Column.FieldName)
            {
                //case "diferencia":
                case "toma_fisica":
                    //row.diferencia = row.ExistenciaAprox - row.toma_fisica;
                    if (row.toma_fisica == 0)
                        row.diferencia = row.ExistenciaAprox;

                    row.diferencia = row.ExistenciaAprox - row.toma_fisica;
                    row.peso = row.toma_fisica;

                    if (row.diferencia != 0)
                        row.seleccion = true;
                    else
                        row.seleccion = false;

                    

                    break;
                default:
                    break;
            }
           
        }

        private void CalculoExistencias()
        {
            foreach (dsCierreMes.Recuento_mpRow item in dsCierreMes1.Recuento_mp.Rows)
            {
                item.diferencia = item.ExistenciaAprox - item.toma_fisica;
                
                item.peso /* Nueva Cantidad */ = item.toma_fisica;
            }
        
        }

        private void cmdVerDetalle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grd_years.Text))
            {
                CajaDialogo.Error("Debe seleccionar el año!");
                return;
            }
            if (string.IsNullOrEmpty(grd_meses_disponibles.Text))
            {
                CajaDialogo.Error("Debe seleccionar el mes!");
                return;
            }

            

            int id_bodega = Convert.ToInt32(grdBodegas.EditValue);
            Boolean existe_recuento = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_validar_recuento_por_bodega", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                cmd.Parameters.AddWithValue("@years", grd_years.EditValue);
                cmd.Parameters.AddWithValue("@id_mes", grd_meses_disponibles.EditValue);
                //cmd.Parameters.AddWithValue("@id_header_recuento",);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    existe_recuento = dr.GetBoolean(0);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (existe_recuento)
            {
                Bodegas bod = new Bodegas();
                bod.RecuperarRegistro(id_bodega);
                CajaDialogo.Error("Ya Existe un Recuento ligado a la Bodega: "+bod.whs_equivalente);
                return;
            }


            var list = dsCierreMes1.Recuento_mp.AsEnumerable();
            if (list.Count(p => p.peso > 0) <= 0)
            {
                CajaDialogo.Error("Debe de haber por lo menos una materia prima para modificar para poder crear el ajuste de inventario.");
                return;
            }

            //var SelectedRows = from row in list
            //                   where row.seleccion = true /*|| row.peso > 0  row.diferencia > 0 || row.diferencia < 0*/
            //                   select row;
            dsCierreMes.Recuento_mpDataTable tableOps = new dsCierreMes.Recuento_mpDataTable();
            foreach (dsCierreMes.Recuento_mpRow row in dsCierreMes1.Recuento_mp)
            {
                if (row.diferencia < 0 || row.diferencia > 0)
                {
                    dsCierreMes.Recuento_mpRow row1 = tableOps.NewRecuento_mpRow();
                    row1.id_mp = row.id_mp;
                    row1.descripcion = row.descripcion;
                    row1.peso = row.peso;
                    row1.id_bodega = row.id_bodega;
                    row1.diferencia = row.diferencia;
                    row1.ExistenciaAprox = row.ExistenciaAprox;
                    row1.code_sap = row.code_sap;
                    //row1.lote = row.lote;
                    row1.toma_fisica = row.toma_fisica;
                    row1.whs_equivalente = row.whs_equivalente;
                    //row1.numero_transaccion = row.numero_transaccion;
                    tableOps.AddRecuento_mpRow(row1);
                    tableOps.AcceptChanges();
                }
            }

            //var SelectedRowsChecked = from row in list
            //                          where row.seleccion = true || row.toma_fisica == 0
            //                          select row;


            
            //tableOps = SelectedRows.CopyToDataTable<DataRow>();
            


            int id_year = Convert.ToInt32(grd_years.EditValue);
            int id_mese = Convert.ToInt32(grd_meses_disponibles.EditValue);
            DateTime fecha_recuento = Convert.ToDateTime(dateEdit1.EditValue);
            

            frmDetalleRecuento frm = new frmDetalleRecuento(tableOps, UsuarioLogeado, id_year, id_mese, fecha_recuento, id_bodega);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Inicializar_productos(Convert.ToInt32(grdBodegas.EditValue));
            }
        }

        private void grd_bodegas_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (xtraTabControl1.SelectedTabPageIndex == 0) //Si esta Seleccionada MP
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_dataMp.ExportToXlsx(dialog.FileName);
                    
                }
            }
            if (xtraTabControl1.SelectedTabPageIndex == 1) //Si esta Seleccionada PT
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data_pt.ExportToXlsx(dialog.FileName);
                }
            }
            if (xtraTabControl1.SelectedTabPageIndex == 2) //Si esta Seleccionada Reproceso
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_dataMp.ExportToXlsx(dialog.FileName);
                }
            }
        }

        private void btn_Import_Excel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (dsCierreMes.Recuento_mpRow row in dsCierreMes1.Recuento_mp.Rows)//DataTable
                {
                    row.loaded = false;
                    row.delete = false;
                }
                
                if (xtraTabControl1.SelectedTabPageIndex == 0)//Si estamos en MP
                {
                    string file_name = string.Empty;

                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                    dialog.Title = "Seleccione el archivo importado anteriormente";
                    dsCierreMes dsCierre = new dsCierreMes();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        file_name = @dialog.FileName.ToString();
                        string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                        OleDbConnection con = new OleDbConnection(Connection);
                        OleDbDataAdapter myCommand = new OleDbDataAdapter("Select * from [Sheet$]", con);
                        dsCierre.Recuento_mp.Clear();


                        SplashForm frm = new SplashForm();

                        try
                        {
                            myCommand.Fill(dsCierre.LoadExcel);
                            Bodegas bod1 = new Bodegas();
                            Bodegas bod2 = new Bodegas();
                            MateriaPrima mp1 = new MateriaPrima();


                            foreach (dsCierreMes.LoadExcelRow rowExcel in dsCierre.LoadExcel.Rows)//Excel
                            {
                                

                                //bod1.RecuperarRegistro(rowExcel.Bodega);
                                bod1.RecuperarRegistroPreLoaded(rowExcel.Bodega);
                                rowExcel.id_bodega = bod1.id;

                                //LoadExcel_work
                                dsCierreMes.LoadExcel_workRow rowWork = dsCierreMes1.LoadExcel_work.NewLoadExcel_workRow();
                                //if(mp1.RecuperarRegistroFromCode(rowExcel.Codigo))
                                if(mp1.RecuperarRegistroPreLoaded(rowExcel.Codigo))
                                    rowWork.descripcion = mp1.Name;
                                else
                                    rowWork.descripcion = "";

                                rowWork.peso = 0;// rowExcel.peso;
                                rowWork.diferencia = 0;// rowExcel.diferencia;
                                rowWork.ExistenciaAprox = 0;//rowExcel.ExistenciaAprox;
                                rowWork.seleccionado = rowExcel.seleccionado;
                                rowWork.count_id = rowExcel.count_id;
                                rowWork.Codigo = rowExcel.Codigo;
                                rowWork.Toma_Física_Kg = rowExcel.Toma_Física_Kg;
                                rowWork.Bodega = rowExcel.Bodega;
                                rowWork.id_bodega = bod1.id;
                                rowWork.seleccion = rowExcel.seleccion;
                                rowWork.id_mp = mp1.IdMP_ACS;
                                dsCierreMes1.LoadExcel_work.AddLoadExcel_workRow(rowWork);

                                foreach (dsCierreMes.Recuento_mpRow row in dsCierreMes1.Recuento_mp.Rows)//DataTable
                                {
                                    if (row.loaded)
                                        continue;

                                    try
                                    {
                                        bod2.whs_equivalente = row.whs_equivalente;
                                    }
                                    catch
                                    {
                                        bod2.whs_equivalente = "N/D";
                                        row.loaded = true;
                                        continue;
                                    }

                                    //if (row.code_sap == rowExcel.Codigo && row.whs_equivalente == rowExcel.Bodega)
                                    if (row.code_sap == rowExcel.Codigo && bod2.whs_equivalente == rowExcel.Bodega.Trim())
                                    {
                                        row.toma_fisica = rowExcel.Toma_Física_Kg;
                                        row.loaded = true;
                                        continue;
                                    }
                                }
                            }

                            ArrayList ListaMP_adicional = new ArrayList();
                            foreach (dsCierreMes.Recuento_mpRow row in dsCierreMes1.Recuento_mp.Rows)//DataTable
                            {   
                                try
                                {
                                    bod2.whs_equivalente = row.whs_equivalente;
                                    if (row.whs_equivalente != "N/D")
                                        continue;
                                }
                                catch
                                {
                                    bod2.whs_equivalente = "N/D";
                                }

                                //foreach (dsCierreMes.LoadExcelRow rowExcel in dsCierre.LoadExcel.Rows)//Excel
                                foreach (dsCierreMes.LoadExcel_workRow rowExcel in dsCierreMes1.LoadExcel_work.Rows)//Excel
                                {
                                    if (row.code_sap == rowExcel.Codigo)
                                    {
                                        row.delete = true;
                                        //rowExcel.Bodega
                                        dsCierreMes.Recuento_mpRow rowNew = dsCierreMes1.Recuento_mp.NewRecuento_mpRow();
                                        rowNew.id_mp = rowExcel.id_mp;
                                        rowNew.descripcion = rowExcel.descripcion;
                                        rowNew.peso = rowExcel.peso;
                                        rowNew.id_bodega = rowExcel.id_bodega;
                                        rowNew.diferencia = rowExcel.diferencia;
                                        rowNew.ExistenciaAprox = rowExcel.ExistenciaAprox;
                                        rowNew.seleccionado = rowExcel.seleccionado;
                                        rowNew.count_id = rowExcel.count_id;
                                        rowNew.code_sap = rowExcel.Codigo;
                                        rowNew.toma_fisica = rowExcel.Toma_Física_Kg;
                                        rowNew.whs_equivalente = rowExcel.Bodega;
                                        rowNew.seleccion = rowExcel.seleccion;
                                        //rowNew.id = rowExcel.id_mp;
                                        rowNew.contabilizado = false;
                                        rowNew.loaded = false;
                                        rowNew.delete = false;
                                        //dsCierreMes1.Recuento_mp.AddRecuento_mpRow(rowNew);
                                        ListaMP_adicional.Add(rowNew);
                                        //dsCierreMes1.AcceptChanges();
                                    }
                                }
                            }

                            foreach(dsCierreMes.Recuento_mpRow row in ListaMP_adicional)
                            {
                                dsCierreMes1.Recuento_mp.AddRecuento_mpRow(row);
                                dsCierreMes1.AcceptChanges();
                            }


                            int conta = 0;
                            foreach(dsCierreMes.Recuento_mpRow row in dsCierreMes1.Recuento_mp.Rows)
                            {
                                if (row.delete)
                                    conta++;
                            }

                            while (conta > 0)
                            {
                                for (int r = 0; r <= dsCierreMes1.Recuento_mp.Rows.Count - 1; r++)
                                {
                                    var gridView1 = (GridView)grd_dataMp.FocusedView;
                                    var row = (dsCierreMes.Recuento_mpRow)gridView1.GetDataRow(r);
                                    if (row != null)
                                    {
                                        if (row.delete)
                                        {
                                            try
                                            {
                                                gridView1.DeleteRow(r);
                                            }
                                            catch (Exception ec)
                                            {
                                                CajaDialogo.Error(ec.Message);
                                            }
                                        }
                                    }
                                }
                                conta--;
                            }
                            


                            dsCierreMes1.Recuento_mp.AcceptChanges();

                            CalculoExistencias();
                            
                            //CajaDialogo.Show(bodegas_);

                            CajaDialogo.Information("Plantilla Cargada con Exito!");
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                        //try
                        //{
                        //    myCommand.Fill(dsCierre.LoadExcel);
                        //    foreach (dsCierreMes.Recuento_mpRow row in dsCierreMes1.Recuento_mp.Rows)
                        //    {
                        //        foreach (dsCierreMes.LoadExcelRow row2 in dsCierre.LoadExcel.Rows)
                        //        {
                        //            if (row.code_sap == row2.Codigo && row.whs_equivalente == row2.Bodega)
                        //            {
                        //                row.toma_fisica = row2.Toma_Física_Kg;
                        //            }
                        //        }
                        //    }
                        //    dsCierreMes1.Recuento_mp.AcceptChanges();

                        //    CalculoExistencias();
                        //}
                        //catch (Exception ec)
                        //{
                        //    CajaDialogo.Error(ec.Message);
                        //}

                    }
                }
                if (xtraTabControl1.SelectedTabPageIndex == 1)//Si estamos en PT
                {

                }

            }
            catch (Exception ex) 
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdBodegas_EditValueChanged(object sender, EventArgs e)
        {
            Inicializar_productos(Convert.ToInt32(grdBodegas.EditValue));

            int conteo = 0;
            foreach (dsCierreMes.Recuento_mpRow item in dsCierreMes1.Recuento_mp.Rows)
            {
                if (item.ExistenciaAprox == 0)
                    conteo = conteo + 1;

                if (item.whs_equivalente == "N/D")
                {
                    item.id_bodega = Convert.ToInt32(grdBodegas.EditValue);
                }
            }

            if (grdv_dataMP.RowCount == conteo)
            {
                CajaDialogo.Error("Toda la Bodega tiene existencia 0 en Sistema!");
                dsCierreMes1.Recuento_mp.Clear();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (dsCierreMes.Recuento_mpRow item in dsCierreMes1.Recuento_mp.Rows)
            {
                if (item.toma_fisica == 0)
                    item.diferencia = item.ExistenciaAprox;

                item.diferencia = item.ExistenciaAprox - item.toma_fisica;
                item.peso = item.toma_fisica;



                //item.diferencia = item.ExistenciaAprox- item.toma_fisica;

            }
        }
    }
}