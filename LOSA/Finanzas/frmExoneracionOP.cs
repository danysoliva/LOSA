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
        int id_detalle_exo = 0;
        int id_header;

        string RubroOLD;
        string CapituloOLD;
        public enum TipoOperacion
        { 
            insert = 1,
            update = 2
        }

        TipoOperacion tipo_operacion;

        public frmExoneracionOP(frmExoneracionOP.TipoOperacion ptipoOperacion, UserLogin pUserLogin, int pId_header ,int pid_detalle_exo)
        {
            InitializeComponent();

            UsuarioLogueado = pUserLogin;
            id_detalle_exo = pid_detalle_exo;
            tipo_operacion = ptipoOperacion;
            id_header = pId_header;
            CargarRubros();
            CargarCapitulos();

            switch (tipo_operacion)
            {
                case TipoOperacion.insert:


                    break;
                case TipoOperacion.update:
                    DetalleExoneracion dE = new DetalleExoneracion();
                    dE.RecuperarRegistro(id_detalle_exo);
                    grdRubros.Enabled = false;
                    grdCapitulos.Enabled = false;

                    RubroOLD = dE.Rubro;
                    CapituloOLD = dE.Capitulo;

                    grdRubros.EditValue = dE.Rubro;
                    grdCapitulos.EditValue = dE.Capitulo;
                    txtValorPresupuesto.EditValue = dE.Monto;

                    break;
                default:
                    break;
            }

        }

        private void CargarCapitulos()
        {
            try
            {
                string query = @"sp_get_all_capitulos";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.capitulos.Clear();
                adat.Fill(dsExoneracion1.capitulos);
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
                //cmd.Parameters.AddWithValue("",);
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

        private void cmdConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdRubros.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Rubro!");
                grdRubros.Focus();
            }

            if (string.IsNullOrEmpty(grdCapitulos.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Capitulo!");
                grdCapitulos.Focus();
            }

            if (Convert.ToDecimal(txtValorPresupuesto.EditValue) <= 0)
            {
                CajaDialogo.Error("Se debe colocar un Valor mayor que Cero (0)!");
                txtValorPresupuesto.Focus();
            }
            
            bool Permitir = false;
            switch (tipo_operacion)
            {
                case TipoOperacion.insert:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_detalle_exoneracion", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_header", id_header);
                        cmd.Parameters.AddWithValue("@rubro", grdRubros.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@capitulo", grdCapitulos.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@monto", txtValorPresupuesto.EditValue);
                        cmd.Parameters.AddWithValue("@user_creator", UsuarioLogueado.Id);
                        Permitir = Convert.ToBoolean(cmd.ExecuteScalar());
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    break;

                case TipoOperacion.update:


                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionSAP_ACS);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_update_detalle_exoneracion]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_header", id_header);
                        cmd.Parameters.AddWithValue("@rubro", grdRubros.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@capitulo", grdCapitulos.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@monto", txtValorPresupuesto.EditValue);
                        cmd.Parameters.AddWithValue("@id_detalle", id_detalle_exo);
                        cmd.Parameters.AddWithValue("@user_creator", UsuarioLogueado.Id);
                        Permitir = Convert.ToBoolean(cmd.ExecuteScalar());
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;

                default:
                    break;
            }

            if (Permitir)
            {
                CajaDialogo.Information("Detalle Guardado con Exito!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CajaDialogo.Error("Ya existe un Registro con el mismo Num. de Rubro y Capitulo!\nRubro: "+ grdRubros.EditValue.ToString() +" - Capitulo: " + grdCapitulos.EditValue.ToString());
                return;
            }



        }
    }
}