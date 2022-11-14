using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Despachos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using LOSA.Despachos.Reportes;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho_tipo_detalle_carga : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_despacho;
        int estiba;
        public frmdespacho_tipo_detalle_carga(int pid_despacho)
        {
            InitializeComponent();

            id_despacho = pid_despacho;
            estiba = 1;
            LoadDestinos();
            //LoadPresentacion();
            
            navigationFrame1.SelectedPageIndex = 0;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintNormal_Click(object sender, EventArgs e)
        {
            try
            {

                rpt_despacho frm = new rpt_despacho(id_despacho);
                frm.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(frm);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnPrintEmbalaje_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPageIndex = 1;
        }


        private void LoadDestinos()
        {
            
            string query = @"sp_get_destinos_conf_despachos";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            dsProductos.conf_filas_destinos.Clear();
            adat.Fill(dsProductos.conf_filas_destinos);
        }

        private void LoadPresentacion()
        {
            string query = @"sp_get_presentacion_sacos_for_destino";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estiba", estiba);
            cmd.Parameters.AddWithValue("@desinto_id", grdDestinos.EditValue);
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            dsProductos.presentacion_filas.Clear();
            adat.Fill(dsProductos.presentacion_filas);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdDestinos.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Destino!");
                grdDestinos.Focus();
            }

            if (string.IsNullOrEmpty(grdPresentacion.Text))
            {
                CajaDialogo.Error("Debe seleccionar una Presentacion");
                grdPresentacion.Focus();
            }

            try
            {
                //Reporte con Filas
                LOSA.Despachos.Reportes.frm_despacho_con_filas rpt = new LOSA.Despachos.Reportes.frm_despacho_con_filas(id_despacho, estiba, Convert.ToInt32(grdDestinos.EditValue),Convert.ToInt32(grdPresentacion.EditValue));
                rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(rpt);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsTipo_Toggled(object sender, EventArgs e)
        {
            if (tsTipo.IsOn)
            {
                estiba = 1;
                LoadPresentacion();
            }
            else
            {
                estiba = 2;
                LoadPresentacion();
            }

        }

        private void grdDestinos_EditValueChanged(object sender, EventArgs e)
        {
            grdPresentacion.Enabled = true;
            LoadPresentacion();
        }
    }
}