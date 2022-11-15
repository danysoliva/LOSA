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
using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Despachos;
using System.Data.SqlClient;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho_detalle_estiba_step_2 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_despacho;
        int estiba = 0;
        public frmdespacho_detalle_estiba_step_2(int pid_despacho_h)
        {
            InitializeComponent();

            id_despacho = pid_despacho_h;
            grdPresentacion.Enabled = false;

            LoadPresentaciones();
            LoadPresentacion(id_despacho);

            estiba = 1; //1 = Embalado 
            LoadDestinos(estiba);
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

            //if (string.IsNullOrEmpty(grdPresentacion.Text))
            //{
            //    CajaDialogo.Error("Debe seleccionar una Presentacion");
            //    grdPresentacion.Focus();
            //}

            try
            {
                //Reporte con Filas
                LOSA.Despachos.Reportes.frm_despacho_con_filas rpt = new LOSA.Despachos.Reportes.frm_despacho_con_filas(id_despacho, estiba, Convert.ToInt32(grdDestinos.EditValue), Convert.ToInt32(grdPresentacion.EditValue));
                rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(rpt);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadPresentaciones()
        {
            try
            {
                string query = @"sp_get_presentacion_sacos_for_destino_load";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@estiba", estiba);
                //cmd.Parameters.AddWithValue("@desinto_id", grdDestinos.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos.presentacion_filas.Clear();
                adat.Fill(dsProductos.presentacion_filas);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadPresentacion(int id_despacho_h)
        {
            string query = @"sp_get_presentacion_sacos_for_destino";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_despacho_h", id_despacho_h);
            //cmd.Parameters.AddWithValue("@estiba", estiba);
            //cmd.Parameters.AddWithValue("@desinto_id", grdDestinos.EditValue);
            //SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //dsProductos.presentacion_filas.Clear();
            //adat.Fill(dsProductos.presentacion_filas);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                grdPresentacion.EditValue = dr.GetInt32(0);
            }

        }

        private void LoadDestinos(int pestiba)
        {

            try
            {
                string query = @"sp_get_destinos_conf_despachos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@estiba", pestiba);
                cmd.Parameters.AddWithValue("@id_presentacion", grdPresentacion.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos.conf_filas_destinos.Clear();
                adat.Fill(dsProductos.conf_filas_destinos);
                dsProductos.conf_filas_destinos.AcceptChanges();
                conn.Close();
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
                estiba = 1; //1 = Embalado 
                LoadDestinos(this.estiba);
            }
            else
            {
                estiba = 2;//2 = Granel
                LoadDestinos(this.estiba);
            }
        }
    }
}