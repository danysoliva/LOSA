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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Classes;

namespace LOSA.Produccion
{
    public partial class frmConsumoRealPRD : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmConsumoRealPRD()
        {
            InitializeComponent();
            dtDesde.EditValue = dp.Now().AddDays(-15);
            dtHasta.EditValue = dp.Now();
            cargar_datos();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargar_datos();

        }

        private void cargar_datos()
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_report_consumo_real_ALOSY", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@lote_pt", 0);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(tabla);
                gridControl1.DataSource = tabla;
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }
    }
}