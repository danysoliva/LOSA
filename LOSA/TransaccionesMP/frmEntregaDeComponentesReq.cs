using ACS.Classes;
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
    public partial class frmEntregaDeComponentesReq : Form
    {
        UserLogin UsuarioLogeado;
        public frmEntregaDeComponentesReq(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_verifica_diponibilidad_tarima_entrega_listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsTransaccionesMP1.entregacomp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.EntregaLotes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void beIdTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                frmEntregaTarimaReq frm = new frmEntregaTarimaReq(UsuarioLogeado, beIdTarima.Text);
                beIdTarima.Text = "";
                beIdTarima.Focus();
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                
            }
        }

        private void beIdTarima_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beIdTarima.Text = "";
        }
    }
}
