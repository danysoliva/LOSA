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

    public partial class frm_buscar_req : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private string barcode;
        private int id_req;

        public string Barcode { get => barcode; set => barcode = value; }
        public int Id_req { get => id_req; set => id_req = value; }
        public frm_buscar_req()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            try
            {
                string query = @"sp_load_req_to_select_V2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv_AMS1.req_select);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_selectRow)gridView.GetFocusedDataRow();
                Barcode = row.barcode;
                Id_req = row.id_h;
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsControlInv_AMS.req_selectRow)gridView.GetFocusedDataRow();
                Barcode = row.barcode;
                Id_req = row.id_h;
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void frm_buscar_req_Load(object sender, EventArgs e)
        {

        }
    }
}