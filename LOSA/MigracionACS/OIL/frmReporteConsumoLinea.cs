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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.OIL
{
    public partial class frmReporteConsumoLinea : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        public frmReporteConsumoLinea()
        {
            InitializeComponent();
            dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now();
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

                string sql = @"EXEC	[dbo].[sp_load_oil_by_lot]
		                            @desde = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtDesde.EditValue) + "',"+
		                          " @hasta = N'" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", dtHasta.EditValue) + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAceites1.salida_aceite.Clear();
                adat.Fill(dsAceites1.salida_aceite);
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

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsAceites.reporteRow)gridView.GetFocusedDataRow();
            frmDetalleTraslados frm = new frmDetalleTraslados(Convert.ToDateTime(dtDesde.EditValue), Convert.ToDateTime(dtHasta.EditValue), row.id);
            //frm.Parent = this.MdiParent;
            frm.Show();
        }
    }
}