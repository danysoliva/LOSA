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

namespace LOSA.MigracionACS.OIL
{
    public partial class frmDetalleTraslados : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        DateTime Desde, Hasta;
        int idRM;
        public frmDetalleTraslados(DateTime pDesde, DateTime pHasta, int pIdRM)
        {
            InitializeComponent();
            dp = new DataOperations();
            Desde = pDesde;
            Hasta = pHasta;
            idRM = pIdRM;
            CargarDatos_();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos_();
        }

        private void CargarDatos_()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();

                string sql = @"EXEC	[dbo].[sp_detalle_transferencias_to_produccion]
		                            @desde = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", Desde) + "'," +
                                  " @hasta = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", Hasta) + "'," +
                                  " @id_rm = " + idRM;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAceites1.reporte_d.Clear();
                adat.Fill(dsAceites1.reporte_d);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}