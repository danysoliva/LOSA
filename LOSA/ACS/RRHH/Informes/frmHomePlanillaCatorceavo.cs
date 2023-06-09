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

namespace LOSA.ACS.RRHH.Informes
{
    public partial class frmHomePlanillaCatorceavo : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmHomePlanillaCatorceavo(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_pago_catorceavo_tmp_to_print_all", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@code", CodigoEmpleado);
                dsInformesRRHH1.catorceavo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInformesRRHH1.catorceavo);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdPrintButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsInformesRRHH.catorceavoRow)gridView.GetFocusedDataRow();

            rptVoucher14vo rpt = new rptVoucher14vo(row.Codigo);
            rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(rpt);
            printReport.ShowPreview();
        }

        private void cmdPrintAll_Click(object sender, EventArgs e)
        {
            int contador_print = 0;
            rptVoucher14vo reportResumen = null;
            rptVoucher14vo reportResumenReproceso = null;

            foreach(dsInformesRRHH.catorceavoRow row in dsInformesRRHH1.catorceavo)
            {
                
                if (contador_print == 0)
                {
                    reportResumenReproceso = new rptVoucher14vo(row.Codigo);
                    reportResumenReproceso.CreateDocument();
                    contador_print++;
                }
                else
                {
                    // Create the second report and generate its document.
                    rptVoucher14vo report2 = new rptVoucher14vo(row.Codigo);
                    report2.CreateDocument();


                    if (reportResumenReproceso != null)
                    {
                        // Add all pages of the second report to the end of the first report.
                        reportResumenReproceso.ModifyDocument(x => { x.AddPages(report2.Pages); });
                    }
                }
               
            }
            
                
            if (reportResumenReproceso != null)
            {
                reportResumenReproceso.ShowPrintMarginsWarning = false;

                using (ReportPrintTool printTool = new ReportPrintTool(reportResumenReproceso))
                {
                    printTool.ShowPreviewDialog();
                }
            }
        }//private void cmdPrintAll_Click(object sender, EventArgs e)



    }
}