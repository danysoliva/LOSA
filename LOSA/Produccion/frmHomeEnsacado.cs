using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
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

namespace LOSA.Produccion
{
    public partial class frmHomeEnsacado : Form
    {
        UserLogin UsuarioLogeado;
        public frmHomeEnsacado(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_activos_produccion_sacos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsProduccion1.home_sacos_pt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProduccion1.home_sacos_pt);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnTarimas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsProduccion.home_sacos_ptRow)gridView.GetFocusedDataRow();

            frmTarimasHome frm = new frmTarimasHome(UsuarioLogeado, row.fp_lot_number, row.finish_product, row.acs_id);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
