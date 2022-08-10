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

namespace LOSA.TransaccionesPT
{
    public partial class frmLotesxPT : DevExpress.XtraEditors.XtraForm
    {
        public string code_sap, Descripcion;
        public int id_pt, lot_number;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridLotePT.FocusedView;
            var row = (dsPT.lote_ptRow)gridView.GetFocusedDataRow();

            this.code_sap = row.code_sap;
            this.Descripcion = row.producto;
            this.lot_number = row.lot_number;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvLotePT_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridLotePT.FocusedView;
            var row = (dsPT.lote_ptRow)gridView.GetFocusedDataRow();

            this.code_sap = row.code_sap;
            this.Descripcion = row.producto;
            this.lot_number = row.lot_number;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public frmLotesxPT(int pid_pt)
        {
            InitializeComponent();
            id_pt = pid_pt;
            //Load_Data();
        }

        public void Load_Data()
        {
            string Query = @"sp_get_pt_lote_ajuste";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsPT1.lote_pt.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT1.lote_pt);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}