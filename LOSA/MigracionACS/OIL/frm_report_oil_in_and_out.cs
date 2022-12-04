using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.OIL
{
    public partial class frm_report_oil_in_and_out : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frm_report_oil_in_and_out()
        {
            InitializeComponent();
            dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now();
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grd_data.ExportToXlsx(dialog.FileName);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatoss();
        }
        public void CargarDatoss()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();

                string sql = @"sp_resumen_ultimate_aceites_v2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60000;
                cmd.Parameters.AddWithValue("@desde", string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtDesde.EditValue));
                cmd.Parameters.AddWithValue("@hasta", string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtHasta.EditValue));
                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                dsAceites.oilmaster.Clear();
                adat.Fill(dsAceites.oilmaster);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}