using ACS.Classes;
using LOSA.MigracionACS.Forecast.Models;
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
using static LOSA.MigracionACS.Forecast.FCT_Proyecccion_CRUD;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_Proyeccion_Admin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        public FCT_Proyeccion_Admin(UserLogin user)
        {
            InitializeComponent();
            loadData(true);
            UsuarioLogueado = user;
        }


      private void  loadData(Boolean habilitado)
        {
            try
            {
                DataOperations dp = new DataOperations();

                string sql = "dbo.sp_get_FCT_Proyecciones_Ventas_General";
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);


                cnx.Open();
                dsForecast_.Proyeccion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(sql,cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@habilitados", SqlDbType.Bit).Value = habilitado ;
                da.Fill(dsForecast_.Proyeccion);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            loadData(Convert.ToBoolean( toggleSwitch1.EditValue));

            if (toggleSwitch1.IsOn==true)
            {
                colEditar.Visible = true;
                colDeshabilitar.Visible = true;
            }
            else
            {
                colEditar.Visible = false;
                colDeshabilitar.Visible = false;
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                //var row = (dsForecast_.ProyeccionRow)gvProyeccion.GetFocusedDataRow();
                Proyeccion_Ventas item = null;

                //item.ID = row.id;
                //item.Anio = row.anio;
                //item.Comentario = row.Comentario;
                //item.Nombre = row.name;

                FCT_Proyecccion_CRUD frm = new FCT_Proyecccion_CRUD(UsuarioLogueado,Convert.ToInt32(Transacciones.Nuevo),item);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadData(Convert.ToBoolean(toggleSwitch1.EditValue));
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsForecast_.ProyeccionRow)gvProyeccion.GetFocusedDataRow();
                Proyeccion_Ventas item = new Proyeccion_Ventas();

                item.ID = row.id;
                item.Anio = row.anio;
                item.Comentario = row.Comentario;
                item.Nombre = row.name;

                FCT_Proyecccion_CRUD frm = new FCT_Proyecccion_CRUD(UsuarioLogueado, Convert.ToInt32(Transacciones.Editar), item);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadData(Convert.ToBoolean(toggleSwitch1.EditValue));
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void btnDeshabilitar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA DESHABILITAR ESTE REGISTRO?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection dbConnection = new SqlConnection(dp.ConnectionStringCostos);

                    var row = (dsForecast_.ProyeccionRow)gvProyeccion.GetFocusedDataRow();


                    using (SqlCommand command = new SqlCommand("dbo.sp_bloquear_FCT_Proyecciones_Ventas_general", dbConnection))
                    {
                        dbConnection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = row.id;

                        command.ExecuteNonQuery();
                        dbConnection.Close();

                        loadData(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}