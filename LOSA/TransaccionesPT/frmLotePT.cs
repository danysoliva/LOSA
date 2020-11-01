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
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesPT
{
   
    public partial class frmLotePT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int lote;

        public frmLotePT()
        {
            InitializeComponent();
            Load_Data();
        }

        public int Lote { get => lote; set => lote = value; }

        public void Load_Data()
        {
            string Query = @"sp_get_pt_lote";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.producto.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.producto);
                cn.Close();

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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.productoRow)gridView.GetFocusedDataRow();
                Lote = row.lot_number;
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