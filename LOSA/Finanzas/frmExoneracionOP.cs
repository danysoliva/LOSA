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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Finanzas
{
    public partial class frmExoneracionOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        int id_detalle_exo;

        public enum TipoOperacion
        { 
            insert = 1,
            update = 2
        }

        TipoOperacion tipo_operacion;

        public frmExoneracionOP(frmExoneracionOP.TipoOperacion ptipoOperacion, UserLogin pUserLogin, int pid_detalle_exo)
        {
            InitializeComponent();

            UsuarioLogueado = pUserLogin;
            id_detalle_exo = pid_detalle_exo;
            tipo_operacion = ptipoOperacion;

            CargarRubros();
            CargarCapitulos();

            switch (tipo_operacion)
            {
                case TipoOperacion.insert:


                    break;
                case TipoOperacion.update:
                    DetalleExoneracion dE = new DetalleExoneracion();
                    dE.RecuperarRegistro(id_detalle_exo);


                    break;
                default:
                    break;
            }

        }

        private void CargarCapitulos()
        {
            try
            {
                string query = @"";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1..Clear();
                adat.Fill(dsExoneracion1.);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarRubros()
        {
            try
            {
                string query = @"sp_get_all_rubros";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.rubros.Clear();
                adat.Fill(dsExoneracion1.rubros);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}