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
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class frmReporteEnsacadora : DevExpress.XtraEditors.XtraForm
    {
        public frmReporteEnsacadora()
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-3);
            dtHasta.EditValue = dp.Now();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                //dtDesde.EditValue = dp.Now().AddDays(-3);
                //dtHasta.EditValue = dp.Now();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_resumen_ensacadora_camaron", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                DataTable table1 = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(table1);
                grDetalle.DataSource = table1;

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grDetalle.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }
    }
}