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
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;

namespace  LOSA.MigracionACS.Produccion
{
    public partial class PP_seleccionLote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id;
        public int lote;
        public PP_seleccionLote()
        {
            InitializeComponent();
            load_lotes();
        }
         public void load_lotes()
        {
            string query = @"sp_load_lotes_reservados";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion1.lotes_select.Clear();
                da.Fill(dsProduccion1.lotes_select);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close(); 
        }

        private void grdv_data_Click(object sender, EventArgs e)
        {

        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsProduccion.lotes_selectRow)gridView.GetFocusedDataRow();
                id = row.id;
                lote = row.lotefp;
                this.DialogResult = DialogResult.OK;


            }
            catch (Exception ex)
            {
                      
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsProduccion.lotes_selectRow)gridView.GetFocusedDataRow();
                id = row.id;
                lote = row.lotefp;
                this.DialogResult = DialogResult.OK;


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}