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

namespace LOSA.Produccion.CierreLote
{
    public partial class frmCierreLoteMain : Form
    {
        UserLogin UsuarioLogeado;
        public frmCierreLoteMain(UserLogin pUser)
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

                SqlCommand cmd = new SqlCommand("sp_get_cierres_main_view", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsCierreLotesPT1.cierres_main.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCierreLotesPT1.cierres_main);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNewCierreLotePT frm = new frmNewCierreLotePT(this.UsuarioLogeado);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
