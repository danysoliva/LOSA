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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Tools;
using DevExpress.XtraReports.UI;
using LOSA.Produccion;
using LOSA.RecepcionMP;

namespace LOSA.TransaccionesPT
{
    public partial class frm_verdetalleTM : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_ingreso;
        UserLogin UsuarioLogeado;
        public frm_verdetalleTM(int Pid_ingreso, UserLogin Puser)
        {
            InitializeComponent();
            id_ingreso = Pid_ingreso;
            UsuarioLogeado = Puser;
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_view_detalle_tarimas_programadas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_creado", id_ingreso);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.tm_pt.Clear();
                da.Fill(dsPT.tm_pt);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnduplicar_Click(object sender, EventArgs e)
        {
            frmInputBox frm = new frmInputBox();
            frm.Text = "Duplicar Tarima";
            frm.lblInstrucciones.Text = "Ingrese la cantidad de tarimas a duplicar:";
            frm.txtValue.Text = "1";
            frm.ValidInteger = true;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                int cant = 0;
                try
                {
                    cant = Convert.ToInt32(frm.txtValue.Text);
                }
                catch { }

                if (cant <= 0)
                {
                    CajaDialogo.Error("No se puede duplicar la Tarima! El valor debe ser mayor a cero.");
                    return;
                }

                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.tm_ptRow)gridView.GetFocusedDataRow();

                ArrayList List1 = new ArrayList();

                Tarima tar1 = new Tarima();
                if (tar1.RecuperarRegistro(row.id))
                {

                    for (int i = 1; i <= cant; i++)
                    {
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

                            SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                            cmm.CommandType = CommandType.StoredProcedure;
                            cmm.Parameters.AddWithValue("@id", 1);
                            string barcode = cmm.ExecuteScalar().ToString();

                            string vItemCodeMP = "";
                            ProductoTerminado mpx = new ProductoTerminado(dp.ConnectionStringLOSA);
                            if (mpx.Recuperar_producto(row.id_producto_termiado))
                            {
                                vItemCodeMP = mpx.CodigoMP;
                            }


                            SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_lote_pt", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_tarima", row.id);
                            cmd.Parameters.AddWithValue("@codigo_tarima", barcode);
                            int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                            List1.Add(vid_tarima);

                            con.Close();
                            //this.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }//end for 

                    if (List1.Count > 0)
                    {
                        DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                        if (r == DialogResult.Yes)
                        {
                            foreach (int i in List1)
                            {
                                int id_tarimax = i;
                                rptReporteTarimaPT report = new rptReporteTarimaPT(id_tarimax);
                                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                ReportPrintTool printReport = new ReportPrintTool(report);
                                printReport.ShowPreview();
                            }
                        }
                        load_data();
                    }
                    List1.Clear();
                }//end if recuperar registro
            }//end dialog 
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.tm_ptRow)gridView.GetFocusedDataRow();
                rptReporteTarimaPT report = new rptReporteTarimaPT(row.id);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {
           
            }
        }
    }
}