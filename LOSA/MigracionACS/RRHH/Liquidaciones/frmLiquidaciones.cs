using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmLiquidaciones : DevExpress.XtraEditors.XtraForm
    {
        public frmLiquidaciones()
        {
            InitializeComponent();
            LoadLiquidaciones();
        }

        private void LoadLiquidaciones()
        {
            string query = @"sp_load_RRHH_lquidaciones_h";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dSrrhh1.liquidaciones_h.Clear();
                adat.Fill(dSrrhh1.liquidaciones_h);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            var gridview1 = (GridView)gridControl1.FocusedView;
            var row = (DSrrhh.liquidaciones_hRow)gridview1.GetFocusedDataRow();

            frmLiquidacionesOP frm = new frmLiquidacionesOP(row.id_liquidacion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadLiquidaciones();
            }

        }
    }
}