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

namespace LOSA.MigracionACS.Finanzas.Reports
{
    public partial class frmConsumoConsolaReal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        public frmConsumoConsolaReal()
        {
            InitializeComponent();

            dp = new DataOperations();
            dtDesde.EditValue = DateTime.Today;
            dtHasta.EditValue = DateTime.Today;


        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos_();
        }

        private void CargarDatos_()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();

                string sql = @"sp_get_detalle_consumos_reales_consola_rev_conta";
                if (toggleSwitch1.IsOn)
                {
                    sql = @"sp_get_detalle_consumos_reales_consola_rev_conta_mix2";
                }
                else
                {
                    sql = @"sp_get_detalle_consumos_reales_consola_rev_conta";
                }
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechai",dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fechaf",dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                table.TableName = "table1";

                //dsAceites1.reporte.Clear();
                adat.Fill(table);
                gridControl1.DataSource = table;
                //gridControl1.DataMember = "table1";
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
    }
}