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
using LOSA.Clases;
using ACS.Classes;
using LOSA.Calidad.LoteConfConsumo;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesPT;

namespace LOSA.Reportes
{
    public partial class frmHisotrialPTCodigo : DevExpress.XtraEditors.XtraForm
    {
        public frmHisotrialPTCodigo()
        {
            InitializeComponent();
        }

        private void btnSearchPTCamaron_Click(object sender, EventArgs e)
        {
            LoadPT();
        }

        private void LoadPT()
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.ProductoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataPT(frm.ItemSeleccionado.id);
                //textEdit1.Text = frm.ItemSeleccionado.ItemCode + " " + frm.ItemSeleccionado.ItemName;
                //MateriaPrimaAllBodegas.RecuperarRegistroFromID_RM(frm.ItemSeleccionado.id);
            }
        }


        private void LoadDataPT(int pid_pt)
        {
            string query = @"sp_get_pt_historico_por_codigo";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pid_pt);
                dsProductos1.historico_pt_kardex.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductos1.historico_pt_kardex);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"sp_get_despachado_por_lote_codigo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pid_pt);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos1.despachos_pt.Clear();
                adat.Fill(dsProductos1.despachos_pt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdv_inventario_camaron_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }
    }
}