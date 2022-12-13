using ACS.Classes;
using LOSA.MigracionACS.Forecast.Models;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.MigracionACS.Forecast.Models;
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

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_Proyecccion_CRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;

        public enum Transacciones
            {
             Nuevo=1,
                Editar=2
            }

        int transacciones;
        Proyeccion_Ventas proyeccion_ventas = new Proyeccion_Ventas();

        public FCT_Proyecccion_CRUD(UserLogin user,int p_transaccion,Proyeccion_Ventas proyeccion)
        {
            InitializeComponent();
            UsuarioLogueado = user;

            transacciones = p_transaccion;
            proyeccion_ventas = proyeccion;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (transacciones)
                {
                    case 1:


                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("dbo.sp_insert_FCT_Proyecciones_Ventas_general", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = "V" + Convert.ToDateTime(deAnio.Text).Year;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                        cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@created_by", SqlDbType.Int).Value = UsuarioLogueado.UserId;
                        cmd.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = txtComentario.Text;
                        cmd.Parameters.Add("@anio", SqlDbType.Int).Value = Convert.ToDateTime(deAnio.EditValue).Year;

                        Boolean Existe_Proyeccion = Convert.ToBoolean(cmd.ExecuteScalar());


                        if (Existe_Proyeccion == true)
                        {
                            CajaDialogo.Error("Ya existe una proyección para este año, debe de deshabilitar la proyección actual para poder crear una nueva");
                        }
                        else
                        {
                            CajaDialogo.Information("Datos creados exitosamente");
                            this.DialogResult = DialogResult.OK;
                        }
                        cnx.Close();
                        break;
                    case 2:
                        DataOperations dp2 = new DataOperations();
                        SqlConnection cnx2 = new SqlConnection(dp2.ConnectionStringCostos);

                        cnx2.Open();

                        SqlCommand cmd2 = new SqlCommand("dbo.sp_update_FCT_Proyecciones_Ventas_general", cnx2);
                        cmd2.CommandType = CommandType.StoredProcedure;


                        //cmd2.Parameters.Add("@code", SqlDbType.VarChar).Value = "V" + Convert.ToDateTime(deAnio.Text).Year;
                        cmd2.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                        //cmd2.Parameters.Add("@created_date", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd2.Parameters.Add("@id", SqlDbType.Int).Value = proyeccion_ventas.ID;
                        cmd2.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = txtComentario.Text;
                        //cmd2.Parameters.Add("@anio", SqlDbType.Int).Value = Convert.ToDateTime(deAnio.EditValue).Year;

                        cmd2.ExecuteNonQuery();

                        CajaDialogo.Information("Datos actualizados");


                        cnx2.Close();
                        this.DialogResult = DialogResult.OK;

                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void FCT_Proyecccion_CRUD_Load(object sender, EventArgs e)
        {
            if (transacciones==2)
            {
                txtNombre.Text = proyeccion_ventas.Nombre;
                txtComentario.Text = proyeccion_ventas.Comentario;
                deAnio.EditValue = "01-"+"01-"+proyeccion_ventas.Anio;

                deAnio.Enabled = false;
            }
        }
    }
}