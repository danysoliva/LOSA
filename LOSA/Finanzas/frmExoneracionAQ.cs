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
using LOSA.Finanzas;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Finanzas
{
    public partial class frmExoneracionAQ : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public frmExoneracionAQ(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            cargarheader();
        }

        private void cargarheader()
        {
            try
            {
                string query = @"";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.lista_exoneracion.Clear();
                adat.Fill(dsExoneracion1.lista_exoneracion);
                conn.Close();
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
    }
}