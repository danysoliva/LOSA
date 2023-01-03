using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.MigracionACS.Ttracer.Reportes
{
    public partial class frmDetalleDesechos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public frmDetalleDesechos(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            dp = new DataOperations();

            dtDesde.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now();

        }

        private void CargarDatos_()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"EXEC	[dbo].[sp_get_resumen_desechos_bascula]
		                            @desde = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtDesde.EditValue) + "'," +
                                  " @hasta = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtHasta.EditValue) + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesTtrace1.rpt_desechos.Clear();
                adat.Fill(dsReportesTtrace1.rpt_desechos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos_();
        }
    }
}