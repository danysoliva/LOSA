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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using System.Data;
using ACS.Classes;

namespace LOSA.RecepcionMP
{
    public partial class frmSelectMP : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        public string ItemCode = @"";
        public string ItemName = @"";
        public frmSelectMP()
        {
            InitializeComponent();
            load_mp();
        }
        public void load_mp()
        {
            string query = @"ps_obtener_mp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecepcionMPx.mp.Clear();
                da.Fill(dsRecepcionMPx.mp);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_mp.FocusedView;
                var row = (dsRecepcionMPx.mpRow)gridview.GetFocusedDataRow();
                ItemCode = row.itemcode;
                ItemName = row.descripcion;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}