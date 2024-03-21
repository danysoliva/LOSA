using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Compras
{
    public partial class frmListaOrdenesCompra : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmListaOrdenesCompra()
        {
            InitializeComponent();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-15);
            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);
            LoadOrdenAutorizadas();
            //LodOrdenesPendientes();
            //LoadOrdenesAll();
        }

        private void LodOrdenesPendientes()
        {
            try
            {
                string query = @"";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.ordenes_pendientes.Clear();
                adat.Fill(dsCompras1.ordenes_pendientes);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadOrdenAutorizadas()
        {
            try
            {
                string query = @"sp_CM_get_ordenes_compra_autorizada";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fDesde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@fFinal", dtFechaHastaDisponibles.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.ordenes_autorizadas.Clear();
                adat.Fill(dsCompras1.ordenes_autorizadas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadOrdenAutorizadas();
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            int conta = dsCompras1.ordenes_autorizadas.Count;

            for (int i = 0; i < conta; i++)
            {
                dsCompras.ordenes_autorizadasRow row = (dsCompras.ordenes_autorizadasRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    if (row != null)
                    {
                        row.seleccionar = checkBoxSelectAll.Checked;
                    }
                }
                else
                {
                    if (row != null)
                    {
                        row.seleccionar = false;
                    }
                }
            }
        }

        private void repostPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCompras.ordenes_autorizadasRow)gridView.GetFocusedDataRow();

            if (string.IsNullOrWhiteSpace(row.U_AquaExoneracion) || string.IsNullOrEmpty(row.U_AquaExoneracion)) //Solo exoneradas
            {
                rptOrdenCompraExo report = new rptOrdenCompraExo(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
            else
            {
                rptOrdenCompra report = new rptOrdenCompra(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.ShowPreview();
            }
             
        }

        private void btnPrintSeleccionados_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;

            int contador_print = 0;
            //rptReporteIngresoTarima reportResumen = null;
            //LOSA.Reproceso.rptTarimaReproceso reportResumenReproceso = null;



        }
    }
}