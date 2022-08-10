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
    public partial class frmPT : DevExpress.XtraEditors.XtraForm
    {
        public string ProductoT, CodeSAP;
        public int id_pt;
        public frmPT()
        {
            InitializeComponent();
            cargardatos();
        }

        private void cargardatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_get_pt_id_codigo_descripcionv2";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT1.producto_terminado.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsPT1.producto_terminado);
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

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcMP.FocusedView;
            var row = (dsPT.producto_terminadoRow)gridView.GetFocusedDataRow();

            this.ProductoT = row.producto;
            this.CodeSAP = row.code_sap;
            id_pt = row.id;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvMP_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gcMP.FocusedView;
            var row = (dsPT.producto_terminadoRow)gridView.GetFocusedDataRow();

            this.ProductoT = row.producto;
            this.CodeSAP = row.code_sap;
            id_pt = row.id;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}