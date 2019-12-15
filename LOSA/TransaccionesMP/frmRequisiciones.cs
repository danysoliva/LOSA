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

namespace LOSA.TransaccionesMP
{
    public partial class frmRequisiciones : Form
    {
        UserLogin UsuarioLogeado;
        public frmRequisiciones(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsTransaccionesMP1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnVerD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton ver
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

            frmRequisicionesDetalle frm = new frmRequisicionesDetalle(UsuarioLogeado, row.id);
            frm.WindowState = FormWindowState.Maximized;
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
