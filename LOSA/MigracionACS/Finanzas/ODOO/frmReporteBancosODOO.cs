using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Finanzas.ODOO
{
    public partial class frmReporteBancosODOO : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        UserLogin UsuarioLogeado;
        public frmReporteBancosODOO(UserLogin pUserLogin)
        {
            InitializeComponent();
            dp = new DataOperations();
            UsuarioLogeado = pUserLogin;
            DateTime FechaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            DateTime FechaInicial = FechaFinal.AddMonths(-1);
            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;

            LoadDatosDetalle();
        }

        private void LoadDatosDetalle()
        {
            try
            {
                DataOperations dp = new DataOperations();
                PgSqlConnection con = new PgSqlConnection(dp.ConnectionStringODOO5);
                con.Open();

                PgSqlCommand cmd = new PgSqlCommand("select * from public.ft_get_tabla_deduccion_por_banco_rrhh (:p_fecha_i, :p_fecha_f);", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_fecha_i", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("p_fecha_f", dtHasta.EditValue);
                drReportesODOO_RRHH1.detalle_bancos.Clear();
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                adat.Fill(drReportesODOO_RRHH1.detalle_bancos);
                
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDatosDetalle();
        }
    }
}