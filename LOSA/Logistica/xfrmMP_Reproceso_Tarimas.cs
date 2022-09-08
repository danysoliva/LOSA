using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Logistica.Models;
using LOSA.RecepcionMP;
using LOSA.Reportes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica
{
    public partial class xfrmMP_Reproceso_Tarimas : DevExpress.XtraEditors.XtraForm
    {
        UserLogin userLogin;
        public xfrmMP_Reproceso_Tarimas(UserLogin pUser)
        {
            InitializeComponent();
            userLogin = pUser;

            dtFechaDesde.DateTime = DateTime.Now.AddDays(-15);
            dtFechaHasta.DateTime = DateTime.Now;
            LoadData();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            if (dtFechaDesde.EditValue != null && dtFechaHasta.EditValue != null)
            {

                productoTerminado_List = new List<Producto_Terminado>();
                labelControl1.Text = "Seleccionado(s): " + productoTerminado_List.Count();
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmm2 = new SqlCommand("dbo.sp_get_pt_tarima_reproceso", con);
                    cmm2.CommandType = CommandType.StoredProcedure;
                    cmm2.Parameters.AddWithValue("@fdesde", dtFechaDesde.EditValue);
                    cmm2.Parameters.AddWithValue("@fhasta", dtFechaHasta.EditValue);
                    cmm2.Parameters.AddWithValue("@id_especie", rdespecie.EditValue);

                    dsLogistica2.PT_Reproceso.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsLogistica2.PT_Reproceso);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        List< Producto_Terminado> productoTerminado_List = new List<Producto_Terminado>();
        private void gvPT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "seleccionar")
                {
                    var row = (dsLogistica2.PT_ReprocesoRow)gvPT.GetFocusedDataRow();
                    Producto_Terminado productoTerminado = new Producto_Terminado();
                    productoTerminado.ID = row.id;
                    productoTerminado.TarimaID = row.id_tarima;
                    productoTerminado.CodigoBarra = row.codigo_barra;
                    productoTerminado.lote = row.lote_producto_termiado;
                    productoTerminado.cantidad = Convert.ToInt32(row.cantidad_in);
                    productoTerminado.peso = row.peso_in;
                    productoTerminado.id_Presentacion = row.id_presentacion;

                    if (row.seleccionar == true)
                    {
                        //Se agrega elemento a la clase
                        productoTerminado_List.Add(productoTerminado);
                        gvPT.UpdateCurrentRow();
                        labelControl1.Text = "Seleccionado(s): " + productoTerminado_List.Count();
                        gvPT.PostEditor();
                    }
                    else
                    {
                        //count--;

                        var item = productoTerminado_List.Single(x => x.ID == row.id);
                        productoTerminado_List.Remove(item);
                        labelControl1.Text = "Seleccionado(s): " + productoTerminado_List.Count();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvPT_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void ceSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            //hace refresh del grid despues que cambia el valor de la celda
            gvPT.PostEditor();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaDesde_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtFechaHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private string LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                
                con.Close();
                return num_ingreso;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                return "";
            }
        }

        private string LoadNumeroReproceso()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("dbo.sp_generar_codigo_from_tables_id_V2", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 7);
                string num_ingreso = cmm2.ExecuteScalar().ToString();

                con.Close();
                return num_ingreso;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                return "";
            }
        }
        
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
            SqlTransaction transaction = null;
            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();
            }
            catch(Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                return;
            }


            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    transaction = conexion.BeginTransaction();
                }

                SqlCommand cmd = new SqlCommand("dbo.sp_insert_kardex_PT_reproceso", transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.Now();
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = userLogin.Id;

                int id_inserted = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (var item in productoTerminado_List)
                {
                    SqlCommand cmd2 = new SqlCommand("dbo.sp_insert_kardex_PT_reproceso_d", transaction.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;

                    cmd2.Parameters.Add("@id_h", SqlDbType.Int).Value = id_inserted;
                    cmd2.Parameters.Add("@id_tarima", SqlDbType.Int).Value = item.TarimaID;

                    cmd2.ExecuteNonQuery();

                }

                var LotesSeleccionados = (from row in productoTerminado_List
                             select row.lote).Distinct();
                List<Lote> Lotes = new List<Lote>();
                foreach (var item in LotesSeleccionados)
                {
                    Lote ojbLote = new Lote();
                    ojbLote.No_lote = item;
                    ojbLote.presentacion = Convert.ToInt32((from lot in productoTerminado_List
                                            where lot.lote == item
                                            select  lot.id_Presentacion ).First());

                    ojbLote.cantidad = Convert.ToInt32((from lot in productoTerminado_List
                                                       where lot.lote == item
                                                       select lot).Sum(x=> x.cantidad));

                    ojbLote.total = Convert.ToInt32((from lot in productoTerminado_List
                                                        where lot.lote == item
                                                        select lot).Sum(x => x.peso));

                    ojbLote.cant_tarimas = Convert.ToInt32((from lot in productoTerminado_List
                                                            where lot.lote == item
                                                            select lot).Count());
                    Lotes.Add(ojbLote);


                }

                SqlCommand cmd3 = new SqlCommand("sp_insert_ingresos_reproceso_v3", transaction.Connection);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Transaction = transaction;
                Ingreso setIngreso = new Ingreso();
                setIngreso.numero_referencia = LoadNumeroTransaccion();
                setIngreso.Numero_reproceso = LoadNumeroReproceso();
                setIngreso.especie = Convert.ToInt32(rdespecie.EditValue);
                cmd3.Parameters.AddWithValue("@numero_transaccion",setIngreso.numero_referencia);
                cmd3.Parameters.AddWithValue("@numero_reproceso",setIngreso.Numero_reproceso);
                cmd3.Parameters.AddWithValue("@id_usuario", userLogin.Id);
                cmd3.Parameters.AddWithValue("@id_especie", setIngreso.especie);
                
                int id_header = Convert.ToInt32(cmd3.ExecuteScalar());

                int id_lote = 0;

                foreach (var Lote in Lotes)
                {
                    cmd3 = new SqlCommand("sp_insert_nuevo_ingreso_mp_reproceso_V2", transaction.Connection);
                    cmd3.Transaction = transaction;
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@idh",id_header);
                    cmd3.Parameters.AddWithValue("@especie", rdespecie.EditValue);
                    cmd3.Parameters.AddWithValue("@unidades", Lote.cantidad);
                    cmd3.Parameters.AddWithValue("@cantidad_tarimas", Lote.cant_tarimas);
                    cmd3.Parameters.AddWithValue("@id_presentacion", Lote.presentacion);
                    cmd3.Parameters.AddWithValue("@peso", Lote.total);
                    cmd3.Parameters.AddWithValue("@lotemp", Lote.No_lote);
                    cmd3.Parameters.AddWithValue("@numero_transaccion", setIngreso.numero_referencia);
                    cmd3.Parameters.AddWithValue("@numero_reproceso", setIngreso.Numero_reproceso);
                    id_lote = Convert.ToInt32(cmd3.ExecuteScalar());
                    bool Guardo = false;
                    int vid_tarima = 0;
                    ArrayList List = new ArrayList();

                    foreach (var tarima in (from tarimas in productoTerminado_List
                                            where tarimas.lote == Lote.No_lote
                                            select tarimas))
                    {

                        //SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        //con.Open();

                        SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", transaction.Connection);
                        cmm.CommandType = CommandType.StoredProcedure;
                        cmm.Transaction = transaction;
                        cmm.Parameters.AddWithValue("@id", 1);
                        string barcode = cmm.ExecuteScalar().ToString();

                        cmd3 = new SqlCommand("sp_insert_new_tarima_pt_to_mp_V3", transaction.Connection);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Transaction = transaction;
                        cmd3.Parameters.AddWithValue("@numero_transaccion", setIngreso.numero_referencia);
                        cmd3.Parameters.AddWithValue("@numero_reproceso", setIngreso.Numero_reproceso);
                        cmd3.Parameters.AddWithValue("@lote_materia_prima",Lote.No_lote);
                        cmd3.Parameters.AddWithValue("@id_presentacion", tarima.id_Presentacion);
                        cmd3.Parameters.AddWithValue("@cant", tarima.cantidad);
                        cmd3.Parameters.AddWithValue("@peso", tarima.peso);
                        cmd3.Parameters.AddWithValue("@id_usuario", userLogin.Id);
                        cmd3.Parameters.AddWithValue("@codigo_barra", barcode);
                        //cmd3.Parameters.AddWithValue("@idlotes", null);
                        cmd3.Parameters.AddWithValue("@id_Tarima",tarima.ID );
                        cmd3.Parameters.AddWithValue("@id_especie", setIngreso.especie);
                        cmd3.Parameters.AddWithValue("@id_tarima_reproceso", tarima.TarimaID);
                        cmd3.Parameters.AddWithValue("@bit_promedio", 0);
                        cmd3.Parameters.AddWithValue("@id_proveedor", DBNull.Value);

                        vid_tarima = Convert.ToInt32(cmd3.ExecuteScalar());

                        string query = @"";
                        query = @"sp_insert_ubicacion_default";
                        SqlCommand cmdx = new SqlCommand(query, transaction.Connection);// ahora recibe el parametro de ubicacion para poder guardarlo automatico en todas las tarimas
                        cmdx.CommandType = CommandType.StoredProcedure;
                        cmdx.Transaction = transaction;
                        cmdx.Parameters.AddWithValue("@id_tarima", vid_tarima);
                        cmdx.Parameters.AddWithValue("@id_usuario", userLogin.Id);
                        cmdx.Parameters.AddWithValue("@codigo_barra", barcode);
                        cmdx.Parameters.AddWithValue("@id_ubicacion", 131); //bodega c500 predeterminada
                        cmdx.ExecuteNonQuery();

                        List.Add(vid_tarima);

                        Guardo = true;
                        //con.Close();
                    }
                    //if (Guardo)
                    //{
                    //    DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                    //    if (r == DialogResult.Yes)
                    //    {
                    //        for (int i = 0; i <= (List.Count - 1); i++)
                    //        {
                    //            int id_tarimax = Convert.ToInt32(List[i]);
                    //            Reproceso.rptTarimaReproceso report = new Reproceso.rptTarimaReproceso(id_tarimax);
                    //            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    //            report.ShowPrintMarginsWarning = false;
                    //            report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    //            report.Print();


                    //        }
                    //    }
                    //    rptLoteRotulo boleta = new rptLoteRotulo(id_lote);
                    //    boleta.ShowPrintMarginsWarning = false;
                    //    boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    //    boleta.Print();
                    //}
                }
                transaction.Commit();
                conexion.Close();

                CajaDialogo.Information("DATOS GUARDADOS");
                this.DialogResult = DialogResult.OK;

                LoadData();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                CajaDialogo.Error(ex.Message);
            }
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            e.PrintDocument.PrinterSettings.Copies = 1;
        }


        private void xfrmMP_Reproceso_Tarimas_Load(object sender, EventArgs e) { }

        private void rdespecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

    public class Lote
    {
        public string No_lote { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public int presentacion { get; set; }
        public int cant_tarimas { get; set; }
    }

    public class Ingreso
    {
        public string numero_referencia { get; set; }
        public decimal cantidad { get; set; }
        public decimal peso { get; set; }
        public int especie { get; set; }
        public string Numero_reproceso { get; set; }
    }


} 