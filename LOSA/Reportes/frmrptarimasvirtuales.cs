using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Requisiciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Reportes
{
    public partial class frmrptarimasvirtuales : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int contador = 0;
        public frmrptarimasvirtuales()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            string sql = @"sp_load_report_tarimas_virtuales";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            dSReportes1.tarimasvs.Clear();
            adt.Fill(dSReportes1.tarimasvs);
            conn.Close();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposbuttonVerVirtuales_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdTarimasV.FocusedView;
            var row = (dSReportes.tarimasvsRow)gridview.GetFocusedDataRow();

            

            validar_tarimasvirtuales(row.lote_pt);

            if (contador == 0)
            {
                CajaDialogo.Error("No existen tarimas virtuales de este Lote");
            }
            else
            {
                frmVerTarimasVirtuales frm = new frmVerTarimasVirtuales(row.lote_pt);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                load_data();
            }

            
        }

        private void validar_tarimasvirtuales(int plote)
        {
            string sql = @"[sp_count_tarimas_virtuales_por_lote]";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@lote", plote);
            contador = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdTarimasV.ExportToXlsx(dialog.FileName);
            }
        }
    }
}