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
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Produccion
{
    public partial class frm_seleccionarMPInorder : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Id_orden;
        public int id_mp;
        public string descripcion;
        public string itemcode;

        public frm_seleccionarMPInorder(int Pid)
        {
            InitializeComponent();
            Id_orden = Pid;
            load_data();
        }
        public void load_data() 
        {
            string query = @"sp_load_mp_to_add_manual";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req", Id_orden);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProduccion.MpList.Clear();
                da.Fill(dsProduccion.MpList);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsProduccion.MpListRow)gridView.GetFocusedDataRow();

                this.id_mp = row.id_mp;
                this.descripcion = row.descripcion;
                this.itemcode = row.itemcode;
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
                var row = (dsProduccion.MpListRow)gridView.GetFocusedDataRow();

                this.id_mp = row.id_mp;
                this.descripcion = row.descripcion;
                this.itemcode = row.itemcode;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}