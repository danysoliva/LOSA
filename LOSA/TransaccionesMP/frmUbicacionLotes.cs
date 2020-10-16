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
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;
namespace LOSA.TransaccionesMP
{
    public partial class frmUbicacionLotes : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        string Lote;
        int Ingreso;
        public frmUbicacionLotes(UserLogin Puser, string Plote_mp, int Pingreso)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Lote = Plote_mp;
            Ingreso = Pingreso;
            load_data();
        }

        public void load_data()
        {
            string Query = @"sp_load_ubicaciones_from_lote_ingreso";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_mp", Lote);
                cmd.Parameters.AddWithValue("@ingreso", Ingreso);
                dsTransaccionesMP.UbicacionesLote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.UbicacionesLote);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void beIdTarima_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void beIdTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                frmEntregaTarimaReq frm = new frmEntregaTarimaReq(UsuarioLogeado, beIdTarima.Text);
                beIdTarima.Text = "";
                beIdTarima.Focus();
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();

            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}