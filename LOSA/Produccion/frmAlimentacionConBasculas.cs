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
using LOSA.Produccion;
using LOSA.TransaccionesMP.EntregaMP;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Produccion
{
    public partial class frmAlimentacionConBasculas : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int Id_registro_bascula;
        DataOperations dp = new DataOperations();
        public frmAlimentacionConBasculas(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
        }

        private void btnSelectedTarimas_Click(object sender, EventArgs e)
        {
            frmShowTarimasEnBascula frm = new frmShowTarimasEnBascula(frmShowTarimasEnBascula.TipoVentana.Seleccion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Id_registro_bascula = frm.Id_RegistroBascula;

                AlimentacionBasculas ali = new AlimentacionBasculas();
                ali.RecuperarRegistros(Id_registro_bascula);

                switch (ali.Bascula)
                {
                    case 1:
                        CargarDetalleBascula1(Id_registro_bascula);
                        btnBascula1ON.Enabled = true;
                        break;

                    case 2:
                        CargarDetalleBascula2(Id_registro_bascula);
                        btnBascula2ON.Enabled = true;
                        break;

                    default:

                        break;
                }

            }

        }

        private void CargarDetalleBascula2(int pid_registro_bascula)
        {
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid_registro_bascula);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula2.Clear();
                adat.Fill(dsProduccion1.Bascula2);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDetalleBascula1(int pid_registro_bascula)
        {
            try
            {
                string query = @"[sp_get_tarimas_en_proceso_bascula_for_id]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid_registro_bascula);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.Bascula1.Clear();
                adat.Fill(dsProduccion1.Bascula1);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}