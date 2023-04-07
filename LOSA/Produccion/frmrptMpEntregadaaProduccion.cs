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
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Calidad;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace LOSA.Produccion
{
    public partial class frmrptMpEntregadaaProduccion : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        DateTime FInicial;
        DateTime FFinal;
        public frmrptMpEntregadaaProduccion()
        {
            InitializeComponent();

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void load_data()
        {
            try
            {
                string query = @"sp_get_report_mp_entregada_a_produccion";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_ini", dtdesde.EditValue);
                cmd.Parameters.AddWithValue("@fecha_fin", dthasta.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion.reporteP.Clear();
                da.Fill(dsProduccion.reporteP);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtdesde.EditValue == DBNull.Value)
            {
                MessageBox.Show("La fecha de inicio no puede estar vacia");
                dtdesde.Focus();
                return;
            }
            if (dthasta.EditValue == DBNull.Value)
            {
                MessageBox.Show("Le fecha final no puede estar vacia");
                dthasta.Focus();
                return;
            }
            load_data();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnImprimirRPT_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtdesde.EditValue == DBNull.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede estar vacia");
                    dtdesde.Focus();
                    return;
                }
                if (dthasta.EditValue == DBNull.Value)
                {
                    MessageBox.Show("Le fecha final no puede estar vacia");
                    dthasta.Focus();
                    return;
                }

                FInicial = Convert.ToDateTime(dtdesde.EditValue);
                FFinal = Convert.ToDateTime(dthasta.EditValue);
                rptReporteAlimentacionTarimasMP rpt = new rptReporteAlimentacionTarimasMP(FInicial, FFinal);
                rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(rpt);
                printReport.ShowPreview();


                //rptReporteAlimentacionTarimasMP rpt = new rptReporteAlimentacionTarimasMP(dtDesde, dtHasta);
                //using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                //{
                //    printTool.ShowPreview();
                //}

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}