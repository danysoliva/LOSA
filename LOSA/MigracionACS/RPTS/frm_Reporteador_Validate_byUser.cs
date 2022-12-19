using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;

namespace LOSA.MigracionACS.RPTS
{
    public partial class frm_Reporteador_Validate_byUser : Form
    {
        public frm_Reporteador_Validate_byUser(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();
            CargarFiltros();
        }


        public void CargarFiltros()
        {
            try
            {
                string sql = @"SELECT
                                      [id_value] as 'id_cuenta'
                                      ,[descripcion] 
                                  FROM [dbo].[conf_function_filters] ff
                                  where ff.id_function = 1";
                DataOperations dp = new DataOperations();

                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                dsReportes21.filtro_cuentas.Clear();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportes21.filtro_cuentas);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT * from public.x_ft_cta_x_cobrar_empleado (
                                                                              :p_cuenta_id,
                                                                              :p_fecha_d,
                                                                              :p_fecha_h);";
                DataOperations dp = new DataOperations();

                PgSqlConnection Conn = new PgSqlConnection(dp.ConnectionStringODOO);
                Conn.Open();

                PgSqlCommand cmd = new PgSqlCommand(sql, Conn);
                cmd.Parameters.Add("p_cuenta_id", PgSqlType.Int).Value = gridLookUpEdit1.EditValue;
                cmd.Parameters.Add("p_fecha_d", PgSqlType.Date).Value = dt_desde.EditValue;
                cmd.Parameters.Add("p_fecha_h", PgSqlType.Date).Value = dt_hasta.EditValue;
                DataTable tablita = new DataTable();
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                adat.Fill(tablita);
                gridControl1.DataSource = tablita;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExportExcel_Click(object sender, EventArgs e)
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
