using ACS.Classes;
using LOSA.MigracionACS.RRHH.Encuesta.Model;
using DevExpress.XtraEditors;
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
using LOSA.Clases;

namespace LOSA.MigracionACS.RRHH.Encuesta
{
    public partial class xfrmGenerarEncuesta : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public xfrmGenerarEncuesta(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUsuarioLogeado;
            //Cargar();
        }

        public xfrmGenerarEncuesta(string pNombre, string pInstrucciones, string pCodigo, int pAnio, UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            txtNombre.Text = pNombre;   
            txtInstrucciones.Text = pInstrucciones;
            txtCodigo.Text = pCodigo;
            txtAnio.Text = pAnio.ToString();
            this.UsuarioLogeado = pUsuarioLogeado;

            errorProvider1.SetError(txtCodigo, "Es necesario revisar el codigo de la encuesta para evitar duplicados!");
            errorProvider2.SetError(txtAnio, "Considere revisar el año a evaluar para evitar inconsistencias.");
        }


        private void Cargar()
        {

            try
            {
                //DataOperations dp = new DataOperations();
                Encuesta_Master_Header encuesta_Master_Header = new Encuesta_Master_Header();


                if (encuesta_Master_Header.RecupeRaregistro()==true)
                {
                    txtCodigo.Text = encuesta_Master_Header.Codigo;
                    txtInstrucciones.Text = encuesta_Master_Header.Instrucciones;
                    txtAnio.Text = encuesta_Master_Header.AnioEvaluar.ToString();
                    txtNombre.Text = encuesta_Master_Header.Nombre;
                }
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

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();

            //    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAMS))
            //    {

            //        cnx.Open();
            //        //Insert the code
            //        SqlCommand cmd1 = new SqlCommand("dbo.encuesta_insert_new_encuesta ", cnx);
            //        cmd1.CommandType = CommandType.StoredProcedure;
            //        cmd1.Parameters.AddWithValue("@descripcion", txtNombre.Text);
            //        cmd1.Parameters.AddWithValue("@instrucciones", txtInstrucciones.Text);
            //        //cmd1.Parameters.AddWithValue("@fecha", codigo);
            //        cmd1.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            //        cmd1.Parameters.AddWithValue("@anio_evaluar", txtAnio.Text);

            //        cmd1.ExecuteNonQuery();

            //        CajaDialogo.Information("Se ha creado la encuesta satisfactoriamente");
            //        this.Close();

            //        cnx.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de crear esta encuesta?");
            if(r!= DialogResult.Yes)
            {
                return;
            }


            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringAMS))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "[dbo].[encuesta_insert_new_encuesta_v2]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@descripcion", txtNombre.Text);
                    command.Parameters.AddWithValue("@instrucciones", txtInstrucciones.Text);
                    command.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    command.Parameters.AddWithValue("@anio_evaluar", txtAnio.Text);
                    command.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error(ex2.Message);
                    }
                }
            }
        }

        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtAnio_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }
    }
}