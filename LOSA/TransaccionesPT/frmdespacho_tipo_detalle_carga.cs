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
using DevExpress.XtraGrid.Views.Grid;
//using LOSA.Despachos.Reportes;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho_tipo_detalle_carga : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_despacho;
        int estiba = 0;
        int Cantidad_Ud_Despachos;

        public frmdespacho_tipo_detalle_carga(int pid_despacho)
        {
            InitializeComponent();

            id_despacho = pid_despacho;
            grdPresentacion.Enabled = false;

            LoadCantidadCargadaDespacho(pid_despacho);

            //LoadPresentaciones();
            //LoadPresentacion(id_despacho);

            //navigationFrame1.SelectedPageIndex = 0;
            //if (tsTipo.IsOn)
            //{
            //    estiba = 1; //1 = Embalado 
            //    LoadDestinos(estiba);
            //}
            //else
            //{
            //    estiba = 2;//2 = Granel
            //    LoadDestinos(estiba);
            //}

            LoadPresentacionesHabilitadas(Cantidad_Ud_Despachos);

            
        }

        private void LoadPresentacionesHabilitadas(int pcantidad_Ud_Despachos)
        {
            try
            {
                string query = @"sp_get_grid_lista_destinos_config_despacho_pt";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cantidad", pcantidad_Ud_Despachos);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos.destinos_empaques_pt.Clear();
                adat.Fill(dsProductos.destinos_empaques_pt);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadCantidadCargadaDespacho(int pid_despacho)
        {
            //Cantidad_Ud_Despachos
            try
            {
                string query = @"sp_get_cantidad_cargada_despacho_pt";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", pid_despacho);
                //cmd.Parameters.AddWithValue("@desinto_id", grdDestinos.EditValue);
                Cantidad_Ud_Despachos = Convert.ToInt32(cmd.ExecuteScalar());
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
            //frmdespacho_detalle_estiba_step_2 frm = new frmdespacho_detalle_estiba_step_2(id_despacho);
            //frm.Show();
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
                conn.Close();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            if (gridView2.DataRowCount == 0)
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
            
            //if (string.IsNullOrEmpty(grdDestinos.Text))
            //{
            //    CajaDialogo.Error("Debe seleccionar un Destino!");
            //    grdDestinos.Focus();
            //}

            //try
            //{
            //    //Reporte con Filas
            //    LOSA.Despachos.Reportes.frm_despacho_con_filas rpt = 
            //        new LOSA.Despachos.Reportes.frm_despacho_con_filas(id_despacho, estiba, Convert.ToInt32(grdDestinos.EditValue),Convert.ToInt32(grdPresentacion.EditValue));
            //    rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //    ReportPrintTool printReport = new ReportPrintTool(rpt);
            //    printReport.ShowPreview();
            //}
            //catch (Exception ex)
            //{

            //    CajaDialogo.Error(ex.Message);
            //}
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

        private void grdDestinos_EditValueChanged(object sender, EventArgs e)
        {
            grdPresentacion.Enabled = true;
            //LoadPresentacion();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void grdPresentacion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)grid_lista_destinos.FocusedView;
            var row = (dsProductos.destinos_empaques_ptRow)gridView.GetFocusedDataRow();

            //if (string.IsNullOrEmpty(grdDestinos.Text))
            //{
            //    CajaDialogo.Error("Debe seleccionar un Destino!");
            //    grdDestinos.Focus();
            //}

            try
            {
                //Reporte con Filas
                LOSA.Despachos.Reportes.frm_despacho_con_filas rpt =
                    //new LOSA.Despachos.Reportes.frm_despacho_con_filas(id_despacho, estiba, Convert.ToInt32(grdDestinos.EditValue), Convert.ToInt32(grdPresentacion.EditValue));
                    new LOSA.Despachos.Reportes.frm_despacho_con_filas(id_despacho, row.estiba_id, row.destino_id, row.id_presentacion);
                rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(rpt);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }
    }
}