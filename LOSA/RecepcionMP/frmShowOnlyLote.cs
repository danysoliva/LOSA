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
using LOSA.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System.Collections;
using LOSA.Tools;  

namespace LOSA.RecepcionMP
{
    public partial class frmShowOnlyLote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_lote;
        UserLogin UsuarioLogeado;
        public frmShowOnlyLote(int Pid_lote, UserLogin Puser)
        {
            InitializeComponent();
            id_lote = Pid_lote;
            UsuarioLogeado = Puser;
            LoadTarimas();
        }

        public void LoadTarimas()
        {
            string SqlCommandSp = @"ps_obtener_tarimas_de_ingreso_lote";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SqlCommandSp, cn);
                cmd.CommandType = CommandType.StoredProcedure;                  
                cmd.Parameters.AddWithValue("@id_lote", id_lote);
                dsRecepcionMPx.lista_tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsRecepcionMPx.lista_tarimas);
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();
            rptReporteIngresoTarima report = new rptReporteIngresoTarima(row.id);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void cmdDuplicar_Click(object sender, EventArgs e)
        {
            //Duplicar la tarima
            //frmInputBox frm = new frmInputBox();
            //frm.Text = "Duplicar Tarima";
            //frm.lblInstrucciones.Text = "Ingrese la cantidad de tarimas a duplicar:";
            //frm.txtValue.Text = "1";
            //frm.ValidInteger = true;

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    int cant = 0;
            //    try
            //    {
            //        cant = Convert.ToInt32(frm.txtValue.Text);
            //    }
            //    catch { }

            //    if (cant <= 0)
            //    {
            //        CajaDialogo.Error("No se puede duplicar la Tarima! El valor debe ser mayor a cero.");
            //        return;
            //    }

            //    var gridView = (GridView)gridControl1.FocusedView;
            //    var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            //    ArrayList List1 = new ArrayList();

            //    Tarima tar1 = new Tarima();
            //    if (tar1.RecuperarRegistro(row.id))
            //    {

            //        for (int i = 1; i <= cant; i++)
            //        {
            //            try
            //            {
            //                DataOperations dp = new DataOperations();
            //                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //                con.Open();

            //                SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
            //                cmm.CommandType = CommandType.StoredProcedure;
            //                cmm.Parameters.AddWithValue("@id", 1);
            //                string barcode = cmm.ExecuteScalar().ToString();

            //                string vItemCodeMP = "";
            //                MateriaPrima mpx = new MateriaPrima();
            //                if (mpx.RecuperarRegistroFromID_RM(row.id_materia_prima))
            //                {
            //                    vItemCodeMP = mpx.CodeMP_SAP;
            //                }


            //                SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_lote", con);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@itemcode", vItemCodeMP);
            //                cmd.Parameters.AddWithValue("@id_proveedor", tar1.IdProveedor);
            //                cmd.Parameters.AddWithValue("@fecha_ingreso", tar1.FechaIngreso);
            //                cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
            //                cmd.Parameters.AddWithValue("@fecha_vencimiento", tar1.FechaVencimiento);
            //                cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", tar1.FechaProduccionMP);
            //                cmd.Parameters.AddWithValue("@lote_materia_prima", tar1.LoteMP);
            //                cmd.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);
            //                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
            //                cmd.Parameters.AddWithValue("@id_boleta", tar1.IdBoleta);
            //                cmd.Parameters.AddWithValue("@codigo_barra", barcode);
            //                cmd.Parameters.AddWithValue("@cant", tar1.Cantidad);
            //                cmd.Parameters.AddWithValue("@peso", tar1.Peso);
            //                cmd.Parameters.AddWithValue("@idlotes", tar1.Id_ingreso);
            //                int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

            //                List1.Add(vid_tarima);

            //                con.Close();
            //                //this.Close();
            //            }
            //            catch (Exception ec)
            //            {
            //                CajaDialogo.Error(ec.Message);
            //            }
            //        }//end for 

            //        if (List1.Count > 0)
            //        {
            //            DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
            //            if (r == DialogResult.Yes)
            //            {
            //                foreach (int i in List1)
            //                {
            //                    int id_tarimax = i;
            //                    rptReporteIngresoTarima report = new rptReporteIngresoTarima(id_tarimax);
            //                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //                    ReportPrintTool printReport = new ReportPrintTool(report);
            //                    printReport.ShowPreview();
            //                }
            //            }
            //            LoadTarimas();
            //        }
            //        List1.Clear();
            //    }//end if recuperar registro
            //}//end d
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            //frmEditTarima frm = new frmEditTarima(row.id, this.UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void btnEliminarTm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar la tarima?", "Desea eliminar la tarima?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();
                string query = @"sp_deshabilitar_tm_por_id_v2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtm", row.id);
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Se he eliminado correctamente la tarima.");
                LoadTarimas();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}