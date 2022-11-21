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

namespace LOSA.MigracionACS.Produccion.Consumos
{
    public partial class frmsearchOrder : DevExpress.XtraEditors.XtraForm
    {
        public Int64 OrderID;
        public string CodePP;
        public int LotePT;
        public frmsearchOrder()
        {
            InitializeComponent();
            LotePT = 0;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd_h = new SqlCommand("sp_get_listado_orders_for_intake_view_arm", cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                //cmd_h.Parameters.AddWithValue("@order_number", porder_id);
                dsIntakeReportsPRD1.busqueda.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd_h);
                adat.Fill(dsIntakeReportsPRD1.busqueda);

                cn.Close();
            }
            catch (Exception EX)
            {
                //CajaDialogo.Error(EX.Message);
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsIntakeReportsPRD.busquedaRow)gridView.GetFocusedDataRow();

            OrderID = row.Order_Id;
            CodePP = row.Order_Code;
            LotePT = row.Lot;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}