using ACS.Classes;
using DevExpress.XtraEditors;
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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaBines : DevExpress.XtraEditors.XtraForm
    {
        int id_mp1, id_mp2, id_mp3, id_mp4;
        UserLogin UsuarioLogeado;

        public frmEntregaBines(UserLogin pUserLogin)
        {
            InitializeComponent();
            GetsName();
            UsuarioLogeado = pUserLogin;
        }

        private void GetsName()
        {
            id_mp1 = 1209;  //MP00135 Cloruro de colina Liquida
            id_mp2 = 1096;  //MP00036 Hacienda 66
            id_mp3 = 3;     //MP00031 Lecitina de Soya
            id_mp4 = 6;     //MP00032 Hidolizado de Atún Actipal HL

            lblMP1.Text = LoadMPBG001(id_mp1);
            txtMP1.Text = Convert.ToString(load_existencia(id_mp1));
            
            lblMP2.Text = LoadMPBG001(id_mp2);
            txtMP2.Text = Convert.ToString(load_existencia(id_mp2));
            
            lblMP3.Text = LoadMPBG001(id_mp3);
            txtMP3.Text = Convert.ToString(load_existencia(id_mp3));

            lblMP4.Text = LoadMPBG001(id_mp4);
            txtMP4.Text = Convert.ToString(load_existencia(id_mp4));
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        public Decimal load_existencia(int pid_mp)
        {
            decimal existencia = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_obtener_inventario_for_MP_bines_existencia]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pid_mp);
                existencia = Convert.ToDecimal(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return existencia;
        }

        public string LoadMPBG001(int pid_mp)
        {
            string MP1 = " ";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_obtener_inventario_for_MP_bines", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pid_mp);
                MP1 = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return MP1;
        }
    }
}