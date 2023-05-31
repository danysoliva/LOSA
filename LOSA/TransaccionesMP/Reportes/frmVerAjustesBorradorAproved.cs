using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.TransaccionesMP.Reportes
{
    public partial class frmVerAjustesBorradorAproved : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmVerAjustesBorradorAproved(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_borradores_ajustes_inventario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", toggleSwitchVerTodos.IsOn);
                dsRecepcionMP_AjusteLote1.borradores_select.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP_AjusteLote1.borradores_select);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void toggleSwitchVerTodos_Toggled(object sender, EventArgs e)
        {
            LoadDatos();
        }
    }
}