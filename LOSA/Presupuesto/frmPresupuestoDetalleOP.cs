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
using LOSA.Classes;
using LOSA.Presupuesto;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Presupuesto
{
    public partial class frmPresupuestoDetalleOP : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado = new UserLogin();
        int IdPresupuesto; bool Admin = false;

        public frmPresupuestoDetalleOP(UserLogin userLog, int pIdPresupuesto)
        {
            InitializeComponent();
            UsuarioLogeado = userLog;
            IdPresupuesto = pIdPresupuesto;
            LOSA.Clases.Presupuesto presupuesto = new Clases.Presupuesto();
            presupuesto.RecuperarPresupuestoH(IdPresupuesto);
            comboAnio.Text = presupuesto.Anio.ToString();
            txtDescripcion.Text = presupuesto.DescripcionH;

            
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    Admin = true;
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            try
            {
                string query = @"sp_presupuesto_get_departamento_by_user";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId",UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@IsAdmin", Admin);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.departamentos.Clear();
                adat.Fill(dsPresupuesto1.departamentos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validacion que ya exista ese departamento con ese presupuesto
            try
            {
                int contadorExistencia = 0;

                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_presupuesto_validacion_detalle_by_departamento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPresupuesto",IdPresupuesto);
                cmd.Parameters.AddWithValue("@idDepart", grdDepartamentos.EditValue);
                contadorExistencia = Convert.ToInt32(cmd.ExecuteScalar());

                if (contadorExistencia > 0)
                {
                    CajaDialogo.Error("Solo puede existir un Detalle de Presupuesto por Departamento!");
                    return;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            if (string.IsNullOrEmpty(grdDepartamentos.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Departamento");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_presupuesto_detalle_insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_presupuesto",IdPresupuesto);
                cmd.Parameters.AddWithValue("@id_departamento", grdDepartamentos.EditValue);
                cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Detalle Guardado!");

            }
            catch (Exception er)
            {
                CajaDialogo.Error(er.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}