using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
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
        UserLogin UsuarioLogueado;
        public frmListaOrdenesCompra(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-15);
            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);

            dtDesdeHist.DateTime = dp.Now().AddDays(-20);
            dtHastaHist.DateTime = dp.Now().AddDays(1);

            LoadOrdenAutorizadas();
            //LodOrdenesPendientes();
            //LoadOrdenesAll();
        }

        private void LodOrdenesPendientes()
        {
            try
            {
                string query = @"[sp_CM_get_ordenes_compra_pendientes]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.ordenes_pendiente_autorizacion.Clear();
                adat.Fill(dsCompras1.ordenes_pendiente_autorizacion);
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

        private void LoadOrdenHistorico()
        {
            try
            {
                string query = @"[sp_CM_get_ordenes_compra_historico]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fDesde", dtDesdeHist.DateTime);
                cmd.Parameters.AddWithValue("@fFinal", dtHastaHist.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.ordenes_compras_historico.Clear();
                adat.Fill(dsCompras1.ordenes_compras_historico);
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
            var gridView = (GridView)grdPendientesAutorizacion.FocusedView;
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
            var gridView = (GridView)grdAutorizadas.FocusedView;
            var row = (dsCompras.ordenes_autorizadasRow)gridView.GetFocusedDataRow();

            if (!string.IsNullOrWhiteSpace(row.U_AquaExoneracion) || !string.IsNullOrEmpty(row.U_AquaExoneracion)) //Solo exoneradas
            {
                rptOrdenCompraExo report = new rptOrdenCompraExo(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.Print();
                ActualizarConteoPrint(row.id_h);
                
            }
            else
            {
                rptOrdenCompra report = new rptOrdenCompra(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                reportPrint.Print();
                ActualizarConteoPrint(row.id_h);
                
            }
        }

        private void btnPrintSeleccionados_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grdPendientesAutorizacion.FocusedView;

            int contador_print = 0;

        }

        private void reposPrinVistaPrevia_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdAutorizadas.FocusedView;

            var row = (dsCompras.ordenes_autorizadasRow)gridView.GetFocusedDataRow();

            if (!string.IsNullOrWhiteSpace(row.U_AquaExoneracion) || !string.IsNullOrEmpty(row.U_AquaExoneracion)) //Solo exoneradas
            {
                rptOrdenCompraExo report = new rptOrdenCompraExo(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                ActualizarConteoPrint(row.id_h);
                reportPrint.ShowPreview();
            }
            else
            {
                rptOrdenCompra report = new rptOrdenCompra(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                ActualizarConteoPrint(row.id_h);
                reportPrint.ShowPreview();
            }
        }

        private void ActualizarConteoPrint(int pIdOC)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CM_update_count_print_oc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOC", pIdOC);
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadOrdenAutorizadas();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return;
            }
        }

        private void btnExcelAuto_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdAutorizadas.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnExcelHistorico_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdOCHistorico.ExportToXlsx(dialog.FileName);
            }
        }

        private void reposVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdPendientesAutorizacion.FocusedView;
            var row = (dsCompras.ordenes_pendiente_autorizacionRow)gridView.GetFocusedDataRow();

            frmOrdenesCompraMain frm = new frmOrdenesCompraMain(frmOrdenesCompraMain.TipoOperacion.View, row.id_h);
            frm.ShowDialog();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabOrdenesC.SelectedTabPageIndex)
            {
                case 0: //Ordenes Autorizadas

                    if (grdvAutorizadas.RowCount == 0)
                    {
                        LoadOrdenAutorizadas();
                    }

                    break;

                case 1: //Ordenes Pendientes de Aprobacion

                    if (grdvPendientes.RowCount == 0)
                    {
                        LodOrdenesPendientes();
                    }

                    break;

                case 2: //Historico de Ordenes

                    if (grdvHistorico.RowCount == 0)
                    {
                        LoadOrdenHistorico();
                    }

                    break;

                default:
                    break;
            }
        }

        private void btnRefreshPendientes_Click(object sender, EventArgs e)
        {
            LodOrdenesPendientes();
        }

        private void reposEnviarAprobacion1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdPendientesAutorizacion.FocusedView;
            var row = (dsCompras.ordenes_pendiente_autorizacionRow)gridview.GetFocusedDataRow();

            bool Proceder = false;

            if (row.id_h > 0)
            {
                CMOrdenCompraH oc = new CMOrdenCompraH();
                oc.RecuperarRegistro(row.id_h);

                switch (row.id_estado)
                {
                    case 1://Pendiente de Aprobacion
                        Proceder = false;
                        CajaDialogo.Information("La Orden ya se encuentra en espera de aprobacion!");

                        break;

                    case 2: //Autorizado
                        Proceder = false;
                        CajaDialogo.Information("La Orden ya fue Autorizada!");

                        break;
                    case 3: //Rechazado
                        Proceder = false;
                        CajaDialogo.Information("La Orden se encuentra Rechazada!");

                        break;

                    case 4: //Cancelado
                        Proceder = false;
                        CajaDialogo.Information("La Orden fue Cancelada!");

                        break;

                    case 5: //Creada (Se debe Enviar a Aprobacion)
                        Proceder = true;
                        break;

                    default:
                        break;
                }

                if (Proceder)
                {
                    try
                    {
                        string query = @"sp_CM_enviar_aprobacion_orden_compra";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_h", row.id_h);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    CajaDialogo.Information("Orden de Compra enviada a aprobacion!");
                    LodOrdenesPendientes();

                }
            }

        }

        private void reposHistoricoVistaPrevia_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdOCHistorico.FocusedView;

            var row = (dsCompras.ordenes_compras_historicoRow)gridView.GetFocusedDataRow();

            if (!string.IsNullOrWhiteSpace(row.U_AquaExoneracion) || !string.IsNullOrEmpty(row.U_AquaExoneracion)) //Solo exoneradas
            {
                rptOrdenCompraExo report = new rptOrdenCompraExo(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                ActualizarConteoPrint(row.id_h);
                reportPrint.ShowPreview();
            }
            else
            {
                rptOrdenCompra report = new rptOrdenCompra(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                ActualizarConteoPrint(row.id_h);
                reportPrint.ShowPreview();
            }
        }

        private void reposHistoDirecta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdOCHistorico.FocusedView;
            var row = (dsCompras.ordenes_compras_historicoRow)gridView.GetFocusedDataRow();

            if (!string.IsNullOrWhiteSpace(row.U_AquaExoneracion) || !string.IsNullOrEmpty(row.U_AquaExoneracion)) //Solo exoneradas
            {
                rptOrdenCompraExo report = new rptOrdenCompraExo(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                ActualizarConteoPrint(row.id_h);
                reportPrint.Print();
            }
            else
            {
                rptOrdenCompra report = new rptOrdenCompra(row.id_h);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool reportPrint = new ReportPrintTool(report);
                ActualizarConteoPrint(row.id_h);
                reportPrint.Print();
            }
        }
    }
}