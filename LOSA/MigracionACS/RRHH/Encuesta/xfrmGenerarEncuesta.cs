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

namespace LOSA.MigracionACS.RRHH.Encuesta
{
    public partial class xfrmGenerarEncuesta : DevExpress.XtraEditors.XtraForm
    {
        public xfrmGenerarEncuesta()
        {
            InitializeComponent();

            Cargar();
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
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAMS))
                {

                    cnx.Open();
                //Insert the code
                SqlCommand cmd1 = new SqlCommand("dbo.encuesta_insert_new_encuesta ", cnx);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@descripcion", txtNombre.Text);
                cmd1.Parameters.AddWithValue("@instrucciones", txtInstrucciones.Text);
                //cmd1.Parameters.AddWithValue("@fecha", codigo);
                cmd1.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd1.Parameters.AddWithValue("@anio_evaluar", txtAnio.Text);
                
                    
                    Boolean EncuestaYaExistia= Convert.ToBoolean( cmd1.ExecuteScalar());


                    if (EncuestaYaExistia==true)
                    {
                        CajaDialogo.Information("Ha ocurrido un error, vuelva a intentarlo");
                    }
                    else
                    {
                        CajaDialogo.Information("Se ha creado la encuesta satisfactoriamente");
                        this.Close();
                    }

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}