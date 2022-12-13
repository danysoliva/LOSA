using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;

namespace ACS.Forecast
{
    public partial class FCT_Proyecciones_Ventas_New : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public string ActiveUserCode;

        public string SelectedProID;

        public FCT_Proyecciones_Ventas_New()
        {
            InitializeComponent();
            LoadTipos();
        }

        private void LoadTipos()
        {
            try
            {
                string sql = "sp_get_fct_tipo_proyeccion";
                dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsForecast_1.tipos_proyeccion.Clear();
                adat.Fill(dsForecast_1.tipos_proyeccion);
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txt_Descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Descripcion.Text))
            {
                CajaDialogo.Error("Debe ingresar una descripcion valida!");
                return;
            }

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                CajaDialogo.Error("Debe seleccionar una especie valida!");
                return;
            }

            try
            {
                //if (e.KeyCode == Keys.Enter)
                {
                    string forecastcode = dp.ACS_GetSelectData(@"SELECT COUNT([id]) FROM [dbo].[FCT_Proyecciones_Ventas_v2]").Tables[0].Rows[0][0].ToString();

                    if (forecastcode.Length == 1)
                        forecastcode = ("FCT-00000" + forecastcode);
                    else if (forecastcode.Length == 2)
                        forecastcode = ("FCT-0000" + forecastcode);
                    else if (forecastcode.Length == 3)
                        forecastcode = ("FCT-000" + forecastcode);
                    else if (forecastcode.Length == 4)
                        forecastcode = ("FCT-00" + forecastcode);
                    else if (forecastcode.Length == 5)
                        forecastcode = ("FCT-0" + forecastcode);
                    else if (forecastcode.Length >= 6)
                        forecastcode = ("FCT-" + forecastcode);
                    else
                        forecastcode = ("FCT-" + forecastcode);

                    int id_especie = 1;
                    if (comboBox1.Text.Trim() == "1 - Regal")
                        id_especie = 1;
                    else
                        id_especie = 2;

                    string query = @"INSERT INTO [dbo].[FCT_Proyecciones_Ventas_v2]
			                                                        ([code]
                                                                    ,[name]
			                                                        ,[created_date]
			                                                        ,[created_by]
			                                                        ,[status]
                                                                    ,[id_especie]
                                                                    ,[anio]
                                                                    ,[id_tipo_proyeccion])
		                                                     VALUES ('" + forecastcode + @"'
			                                                        ,'" + txt_Descripcion.Text.ToString() + @"'
			                                                        ,SYSDATETIME()
			                                                        ," + ActiveUserCode + @"
			                                                        ,'40'
                                                                    ," + id_especie + 
                                                                    ","+ spinEditAnio.EditValue +
                                                                    ","+ gridLookUpTipoProyeccion.EditValue + @");
                                                                SELECT SCOPE_IDENTITY();";

                    SelectedProID = dp.ACS_InsertAndReturnID(query).ToString();

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}