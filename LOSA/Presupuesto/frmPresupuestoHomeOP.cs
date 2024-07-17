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
using ACS.Classes;
using LOSA.Clases;
using LOSA.Presupuesto;
using System.Data.SqlClient;

namespace LOSA.Presupuesto
{
    public partial class frmPresupuestoHomeOP : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado = new UserLogin();
        public enum Operacion
        { 
            Nuevo = 1,
            Editar =  2
        }
        Operacion tipoOP;
        DataOperations dp = new DataOperations();
        public frmPresupuestoHomeOP(frmPresupuestoHomeOP.Operacion ptipo, UserLogin userLogin)
        {
            InitializeComponent();

            tipoOP = ptipo;
            UsuarioLogeado = userLogin;

            switch (tipoOP)
            {
                case Operacion.Nuevo:
                    grdEstados.EditValue = 1;//Creado
                    break;
                case Operacion.Editar:
                    break;
                default:
                    break;
            }

            ObtenerEstados();
            
        }

        private void ObtenerEstados()
        {
            try
            {
                string query = @"sp_get_prespupuesto_estados";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto.presupuesto_estados.Clear();
                adat.Fill(dsPresupuesto.presupuesto_estados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboAnio.Text))
            {
                CajaDialogo.Error("Debe seleccionar el Año");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe colocar una descripcion");
                return;
            }

            if (string.IsNullOrEmpty(grdEstados.Text))
            {
                CajaDialogo.Error("Debe seleccionar el estado");
                return;
            }



            bool Guardar = false;

            switch (tipoOP)
            {
                case Operacion.Nuevo:


                    if (!ValidarExistenciaAnio(Convert.ToInt32(comboAnio.EditValue)))
                    {
                        CajaDialogo.Error("Ya existe el Presupuesto del Año seleccionado!");
                        return;
                    }

                    if(Convert.ToInt32(grdEstados.EditValue) == 2)
                    {
                        if (!ValidacionPresupuestoActivo(Convert.ToInt32(grdEstados.EditValue)))
                        {
                            DialogResult r = CajaDialogo.Pregunta("Ya existe un Presupuesto Activo!\nDesea Crearlo como Estado: Creado?");
                            if (r != DialogResult.Yes)
                                return;

                            grdEstados.EditValue = 1;
                        }
                    }

                   


                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_presupuesto_h", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@anio",Convert.ToInt32(comboAnio.Text));
                        cmd.Parameters.AddWithValue("@descripcion",txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@id_estado",grdEstados.EditValue);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Guardar = true;
                    }
                    catch (Exception EX)
                    {
                        Guardar = false;
                        CajaDialogo.Error(EX.Message);
                    }

                    break;
                case Operacion.Editar:
                    break;
                default:
                    break;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Informacion Guardada!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private bool ValidacionPresupuestoActivo(int v)
        {
            bool Proceder = false;

            try
            {
                string query = @"sp_presupuesto_valdiacion_presupuesto_activo";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstado", v);
                Proceder = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Proceder;
        }

        private bool ValidarExistenciaAnio(int pAnio)
        {
            bool Proceder = false;

            try
            {
                string query = @"sp_presupuesto_valdiacion_creacion_h";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pAnio", pAnio);
                Proceder = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Proceder;
        }
    }
}