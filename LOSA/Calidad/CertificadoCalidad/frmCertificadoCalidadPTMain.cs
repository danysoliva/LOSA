using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Calidad.CertificadoCalidad
{
    public partial class frmCertificadoCalidadPTMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLog;
        public frmCertificadoCalidadPTMain(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLog = pUserLog;
            load_informacion_certificado();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCrearCertificado frm = new frmCrearCertificado(UsuarioLog);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_informacion_certificado();
            }
           
        }

        public void load_informacion_certificado()
        {
            string query = @"dbo.uspGetCertificadosPT_H";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@LotNumber", lote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCertificado.Certificado_PT_H.Clear();
                da.Fill(dsCertificado.Certificado_PT_H);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsCertificado.Certificado_PT_HRow)gridView1.GetFocusedDataRow();

            rptCertificadoCalidad report2 = new rptCertificadoCalidad(row.id,0);
            //xrpt2 report2 = new xrpt2(recibo, formato);
            report2.DisplayName = "Certificado Lote: "+row.lote_pt;

            using (ReportPrintTool printTool = new ReportPrintTool(report2))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA DESHABILITAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    var row = (dsCertificado.Certificado_PT_HRow)gridView1.GetFocusedDataRow();

                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                    string sql = @"UPDATE dbo.LOSA_Certificado_PT_h 
                                    SET enable=0
                                    WHERE id=" + row.id;

                    using (SqlCommand command = new SqlCommand(sql, cnx))
                    {
                        cnx.Open();
                        command.ExecuteNonQuery();
                        cnx.Close();

                        load_informacion_certificado();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            load_informacion_certificado();
        }
    }
}