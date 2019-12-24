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
    public partial class frmTarimasHome : Form
    {
        UserLogin UsuarioLogeado;
        int IdLote;
        int idProducto;
        public frmTarimasHome(UserLogin pUsuarioLogeado, int pLote, string producto, int idProd)
        {
            InitializeComponent();
            IdLote = pLote;
            idProducto = idProd;
            UsuarioLogeado = pUsuarioLogeado;
            lblLote.Text = pLote.ToString();
            lblProducto.Text = producto;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_pt_sin_ubicacion_sacos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsProduccion1.tarima_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProduccion1.tarima_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsProduccion.tarima_listRow)gridView.GetFocusedDataRow();

            frmAddTarimaPT frm = new frmAddTarimaPT(UsuarioLogeado, IdLote, idProducto);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
