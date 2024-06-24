using DevExpress.XtraEditors;
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
using ACS.Classes;
using LOSA.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Compras
{
    public partial class frmKardexSaldosDisponible : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmKardexSaldosDisponible()
        {
            InitializeComponent();

            load_data();

        }

        private void load_data()
        {
            string query = @"sp_cm_get_saldo_disponible";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.kardex.Clear();
                adat.Fill(dsCompras1.kardex);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsCompras.kardexRow)gridview.GetFocusedDataRow();

            frmKardexDetalle frm = new frmKardexDetalle(row.capitulo, row.partida_arancelaria);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}