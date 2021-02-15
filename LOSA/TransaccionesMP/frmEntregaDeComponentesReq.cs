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

                SqlCommand cmd = new SqlCommand("sp_load_tarimas_entregadas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dsTransaccionesMP.entregado.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP.entregado);

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

        private void timertick_Tick(object sender, EventArgs e)
        {
            int Nuevo = 0;
            if (timertick.Enabled)
            {
                string Query = @"sp_count_alimentacion_tarima";
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Nuevo = Convert.ToInt32(cmd.ExecuteScalar());
                    if (Nuevo > 0)
                    {
                        LoadData();
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }
    }
}
