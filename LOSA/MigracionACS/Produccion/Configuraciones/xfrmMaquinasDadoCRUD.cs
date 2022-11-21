using ACS.Classes;
using LOSA.MigracionACS.Produccion.Configuraciones.Model;
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

namespace LOSA.MigracionACS.Produccion.Configuraciones
{
    public partial class xfrmMaquinasDadoCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoTransaccion
        {
            Nuevo=1,
                Editar=2
        }

        int transaccion;
        MaquinaDado maquinaDado;

        public xfrmMaquinasDadoCRUD(int p_transaccion,MaquinaDado maquinaDado_p)
        {
            InitializeComponent();
            LoadTipo();
            Load_EQ_Maquinas();

            transaccion = p_transaccion;
            maquinaDado = maquinaDado_p;
        }




        private void LoadTipo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    dsConfiguraciones.MaquinaDadoTipo.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_maquinas_dado_tipo", cnx);
                    da.Fill(dsConfiguraciones.MaquinaDadoTipo);
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void Load_EQ_Maquinas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    dsConfiguraciones.EQ_Maquina.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_EQ_Maquinas", cnx);
                    da.Fill(dsConfiguraciones.EQ_Maquina);
                    cnx.Close();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();


                switch (transaccion)
                {
                    case (int)TipoTransaccion.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_insert_EQ_Maquina_Dado", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id_tipo", SqlDbType.Int).Value = lueTipo.EditValue;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@id_maquina", SqlDbType.Int).Value = lueMaquina.EditValue;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS GUARDADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();

                        }
                        break;


                    case (int)TipoTransaccion.Editar:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                        {
                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.sp_update_EQ_maquinda_dado", cnx);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = maquinaDado.ID;
                            cmd.Parameters.Add("@id_tipo", SqlDbType.Int).Value = lueTipo.EditValue;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@id_maquina", SqlDbType.Int).Value = lueMaquina.EditValue;

                            cmd.ExecuteNonQuery();

                            CajaDialogo.Information("DATOS ACTUALIZADOS");
                            this.DialogResult = DialogResult.OK;
                            cnx.Close();

                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmMaquinasDadoCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                if (transaccion==(int)TipoTransaccion.Editar)
                {
                    txtDescripcion.Text = maquinaDado.Descripcion;
                    lueMaquina.EditValue = maquinaDado.MaquinaID;
                    lueTipo.EditValue = maquinaDado.Tipo;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}