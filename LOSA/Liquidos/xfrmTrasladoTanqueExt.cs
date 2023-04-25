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
using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Liquidos.Models;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Liquidos
{
    public partial class xfrmTrasladoTanqueExt : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado = new UserLogin();
        decimal Capacidad_tanque_entrada = 0;
        int id_mp_salida = 0;
        int id_mp_entrada = 0;
        int id_tanque_prd = 0;
        public xfrmTrasladoTanqueExt(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            load_tanques();
        }

        private void load_tanques()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_tanques_conf", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsLiquidos_1.Tanque.Clear();
                adat.Fill(dsLiquidos_1.Tanque);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (grdTanqueSalida.Text == grdTanqueEntrada.Text)
            {
                CajaDialogo.Error("No puede hacer un Traslado entre los mismos Tanques");
                return;
            } 

            DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea realizar este Traslado del Tanque: "+grdTanqueSalida.EditValue +" al Tanque: "+grdTanqueEntrada.EditValue);
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;


            if (string.IsNullOrEmpty(grdTanqueSalida.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Tanque de Salida!");
                return;
            }

            if (string.IsNullOrEmpty(grdTanqueEntrada.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Tanque de Entrada!");
                return;
            }



            if (Convert.ToDecimal(txtCantidaSalida.EditValue) + Convert.ToDecimal(txtCantidadEntrada.EditValue) > Capacidad_tanque_entrada)
            {
                CajaDialogo.Error("El Traslado excede la maxima Capacidad del Tanque");
                return;
            }



            try
            {
                //Vamos a realizar la Salida del Tanque Relacionado!
                //Osea una Transferencia como Traslado!
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_traslado_aceite_ingreso_requisa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp_salida", id_mp_salida);
                cmd.Parameters.AddWithValue("@id_tanque_prd", id_tanque_prd);
                cmd.Parameters.AddWithValue("@cantidad_trasladada",txtCantidaSalida.EditValue);
                cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@user_name", UsuarioLogeado.ADuser1);
                cmd.Parameters.AddWithValue("@id_tanque_salida", grdTanqueSalida.EditValue);
                cmd.Parameters.AddWithValue("@id_tanque_entrada", grdTanqueEntrada.EditValue);
                cmd.ExecuteNonQuery();


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void grdTanqueSalida_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id_tanque_salida = 0;
                id_tanque_salida = Convert.ToInt32(grdTanqueSalida.EditValue);

                if (id_tanque_salida > 0)
                {
                    Tanque tanq1 = new Tanque(Convert.ToInt32(id_tanque_salida));
                    txtCantidaSalida.EditValue = tanq1.TotalLleno;
                    lblSalida.Text = "Tanque "+tanq1.NumerodeTanque+ ": "+ tanq1.NombreMateriaP;
                    id_mp_salida = tanq1.KeyMateriaPrima;
                    id_tanque_prd = tanq1.Id_tanque_prd;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdTanqueEntrada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id_tanque_entrada = 0;
                id_tanque_entrada = Convert.ToInt32(grdTanqueEntrada.EditValue);

                if (id_tanque_entrada > 0)
                {
                    Tanque tanq1 = new Tanque(Convert.ToInt32(id_tanque_entrada));
                    txtCantidadEntrada.EditValue = tanq1.TotalLleno;
                    Capacidad_tanque_entrada = tanq1.MaximoCapacidad;
                    lblEntrada.Text = "Tanque " + tanq1.NumerodeTanque + ": " + tanq1.NombreMateriaP;
                    id_mp_entrada = tanq1.KeyMateriaPrima;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}