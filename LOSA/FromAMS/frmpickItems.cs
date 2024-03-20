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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;
using LOSA.FromAMS;

namespace AMS.Compras.ControlInv
{
    public partial class frmpickItems : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private string itemCode;
        private string itemName;
        public int existencia;

        public string ItemCode { get => itemCode; set => itemCode = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        int TipoRequisa;
        public frmpickItems(int pTipoRequisa)
        {
            InitializeComponent();

            load_data(pTipoRequisa);
        }
        

        public void load_data(int TipoRequisa)
        {
            switch (TipoRequisa)
            {
                case 1: //Requisa de Repuestos
                    string Query = @"[dbo].[sp_load_items_sap_V2]";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        dsControlInv_AMS1.items.Clear();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dsControlInv_AMS1.items);
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                case 2: //Requisa de Material de Empaque
                    string sql = @"[dbo].[sp_load_items_sap_material_empaque]";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        dsControlInv_AMS1.items.Clear();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dsControlInv_AMS1.items);
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    break;
                default:
                    break;
            }
            
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.itemsRow)gridView.GetFocusedDataRow();
                ItemCode = row.itemcode;
                ItemName = row.Itemname;
                existencia = row.existencia;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

               
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {

            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsControlInv_AMS.itemsRow)gridView.GetFocusedDataRow();
            ItemCode = row.itemcode;
            ItemName = row.Itemname;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}