using ACS.Classes;
using Devart.Data.PostgreSql;
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

namespace LOSA.MigracionACS.RRHH.Reportes
{
    public partial class frmResumenNominas : DevExpress.XtraEditors.XtraForm
    {
        public frmResumenNominas()
        {
            InitializeComponent();
            //LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                PgSqlConnection con = new PgSqlConnection(dp.ConnectionStringODOO5);
                con.Open();

                PgSqlCommand cmd = new PgSqlCommand("select * from public.ft_get_detalle_planillas_rango_fecha (:pfechadesde, :fechahasta)", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pfechadesde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("fechahasta", dtHasta.EditValue);
                DataTable Table1 = new DataTable();
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                adat.Fill(Table1);
                gridControl1.DataSource = Table1;

                con.Close();
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
            LoadData();
        }
    }
}