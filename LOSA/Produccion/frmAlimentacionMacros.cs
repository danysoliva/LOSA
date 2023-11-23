using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.TransaccionesMP.EntregaMP;
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

namespace LOSA.Produccion
{
    public partial class frmAlimentacionMacros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int Id_registro_bascula1;
        int Id_registro_bascula2;
        decimal pesoBascula1;
        decimal pesoBascula2;

        enum Bascula 
        { 
            Bascula1 = 1,
            Bascula2 = 2
        }

        public frmAlimentacionMacros(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            timerBascula.Start();
        }

        private void cmdSelectTarima_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 == 0 && pesoBascula2 == 0)
            {
                CajaDialogo.Error("No se Detecta Peso en las Basculas!");
            }
            else
            {
                frmShowTarimasEnBascula frm = new frmShowTarimasEnBascula(frmShowTarimasEnBascula.TipoVentana.Seleccion);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    switch (frm.BascuilaID)
                    {
                        case 1:
                            Id_registro_bascula1 = frm.Id_RegistroBascula;
                            CargarDetalleBascula1(Id_registro_bascula1);
                            btnBascula1ON.Enabled = true;

                            break;

                        case 2:
                            Id_registro_bascula2 = frm.Id_RegistroBascula;
                            CargarDetalleBascula2(Id_registro_bascula2);
                            btnBascula2ON.Enabled = true;
                            break;
                        default:
                            break;
                    }
                }

            }
        }


        private void CargarDetalleBascula1(int pid_registro_bascula)
        {
            DataOperations dp = new DataOperations();
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

        private void CargarDetalleBascula2(int pid_registro_bascula)
        {
            DataOperations dp = new DataOperations();
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

        private void timerBascula_Tick(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            pesoBascula1 = 0;
            pesoBascula2 = 0;

            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_basculas_value_alimentacion]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pesoBascula1 = dr.GetDecimal(0);
                    pesoBascula2 = dr.GetDecimal(1);
                }
                dr.Close();
                conn.Close();
            }

            lblValorBascula1.Text = "Valor en Báscula: " + pesoBascula1.ToString("N2") + " Kg";
            lblValorBascula2.Text = "Valor en Báscula: " + pesoBascula2.ToString("N2") + " Kg";
        }

        private void btnBascula1ON_Click(object sender, EventArgs e)
        {
            if (pesoBascula1 <= 0)
            {
                CajaDialogo.Error("No hay Peso en la Bascula 1");
                return;
            }

            GuardarPesoBruto(Bascula.Bascula1);
        }

        private void GuardarPesoBruto(Bascula BasculaSelected)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_alimentacion_macros_inicio_pesaje", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                switch (BasculaSelected)
                {
                    case Bascula.Bascula1:
                        cmd.Parameters.AddWithValue("@pid_registro", Id_registro_bascula1);
                        cmd.Parameters.AddWithValue("@peso_bruto", pesoBascula1);
                        break;
                    case Bascula.Bascula2:
                        cmd.Parameters.AddWithValue("@pid_registro", Id_registro_bascula2);
                        cmd.Parameters.AddWithValue("@peso_bruto", pesoBascula2);
                        break;
                    default:
                        break;
                }
                cmd.ExecuteNonQuery();
                conn.Close();

                switch (BasculaSelected)
                {
                    case Bascula.Bascula1:
                        CargarDetalleBascula2(Id_registro_bascula1);
                        btnBascula1Off.Enabled = true;
                        break;
                    case Bascula.Bascula2:
                        CargarDetalleBascula2(Id_registro_bascula2);
                        btnBascula2Off.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void btnBascula2ON_Click(object sender, EventArgs e)
        {
            if (pesoBascula2 <= 0)
            {
                CajaDialogo.Error("No hay Peso en la Bascula 2");
                return;
            }

            GuardarPesoBruto(Bascula.Bascula1);
        }
    }
}