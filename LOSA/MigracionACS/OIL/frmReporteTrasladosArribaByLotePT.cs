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
    public partial class frmReporteTrasladosArribaByLotePT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        public frmReporteTrasladosArribaByLotePT()
        {
            InitializeComponent();
            dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-2);
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

                string sql = @"[sp_get_resumen_traslados_hacia_arriab_by_order_id_v2]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAceites1.reporte_tq_arriba_byOrden.Clear();
                adat.Fill(dsAceites1.reporte_tq_arriba_byOrden);
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