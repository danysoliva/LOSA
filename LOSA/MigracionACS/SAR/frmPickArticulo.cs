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
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.SAR
{
    public partial class frmPickArticulo : DevExpress.XtraEditors.XtraForm
    {
        public string Itemcode;
        public string Descripcion;
        DataOperations dp = new DataOperations();
        public frmPickArticulo()
        {
            InitializeComponent();
            load_informacion();
        }


        public void load_informacion()
        {
            string query = @"sp_load_articulos";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dS_SAR.articulos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dS_SAR.articulos);
                cn.Close();
            }
            catch (Exception ex)
            {
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dS_SAR.articulosRow)gridView.GetFocusedDataRow();
                Itemcode = row.itemcode;
                Descripcion = row.dscripcion;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dS_SAR.articulosRow)gridView.GetFocusedDataRow();
                Itemcode = row.itemcode;
                Descripcion = row.dscripcion;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

            }
        }
    }
}