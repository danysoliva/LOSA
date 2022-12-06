using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.RecepcionMP;
using LOSA.Requisiciones;
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

namespace LOSA.Reportes
{
    public partial class frmVerTarimasVirtuales : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int lote_pt;
        public frmVerTarimasVirtuales(int plote)
        {
            InitializeComponent();
            lote_pt = plote;
            load_data();
        }

        private void load_data()
        {
            string sql = @"sp_load_report_tarimas_virtuales_por_lote";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@lote", lote_pt);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            dSReportes1.vertarimasv.Clear();
            adt.Fill(dSReportes1.vertarimasv);
            conn.Close();
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)grdTarimasV.FocusedView;
            int conta = dSReportes1.vertarimasv.Count;

            for (int i = 0; i < conta; i++)
            {
                dSReportes.vertarimasvRow row = (dSReportes.vertarimasvRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    if (row != null)
                    {
                        row.seleccion = checkBoxSelectAll.Checked;
                    }
                }
                else
                {
                    if (row != null)
                    {
                        row.seleccion = false;
                    }
                }
            }
        }

        private void btnPrintSeleccionados_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grdTarimasV.FocusedView;

            int contador_print = 0;
            rptReporteTarimaPT reportResumen = null;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var row = (dSReportes.vertarimasvRow)gridView.GetDataRow(i);

                if (row.seleccion == true)
                {
                    if (row.id > 0)
                    {
                        Tarima tar1 = new Tarima();
                        if (tar1.RecuperarRegistro(row.id))
                        {
                            if (contador_print == 0)
                            {
                                reportResumen = new rptReporteTarimaPT(row.id);
                                reportResumen.CreateDocument();
                                contador_print++;
                            }
                            else
                            {
                                // Create the second report and generate its document.
                                rptReporteTarimaPT report2 = new rptReporteTarimaPT(row.id);
                                report2.CreateDocument();

                                if (reportResumen != null)
                                {
                                    // Add all pages of the second report to the end of the first report.
                                    reportResumen.ModifyDocument(x => { x.AddPages(report2.Pages); });
                                }
                            }
                        }
                    }//if row.id>0
                }//if seleccionado is true
            }//For
            if (reportResumen != null)
            {
                reportResumen.ShowPrintMarginsWarning = false;

                using (ReportPrintTool printTool = new ReportPrintTool(reportResumen))
                {
                    printTool.ShowPreviewDialog();
                }
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}