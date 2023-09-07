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
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Finanzas
{
    public partial class frmExoneracionDetalle : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        int id_header;
        public frmExoneracionDetalle(UserLogin pUserLogin, int pint_header)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;

            id_header = pint_header;
            cargar_detalle(id_header);
        }

        private void cargar_detalle(int id_header)
        {
            try
            {
                string query = @"sp_get_detalle_exoneracion";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header", id_header);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.detalle_exoneracion.Clear();
                adat.Fill(dsExoneracion1.detalle_exoneracion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmExoneracionOP frm = new frmExoneracionOP(frmExoneracionOP.TipoOperacion.insert, UsuarioLogueado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargar_detalle(id_header);
            }
        }
    }
}