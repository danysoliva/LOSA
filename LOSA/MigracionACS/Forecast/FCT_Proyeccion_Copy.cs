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

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_Proyeccion_Copy : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        /*Para Actualizacion de Proyeccion*/
        public string action;
        public string textBoxData;
        public Double Porcentaje { get; set; }



        public string ActiveUserCode;

        public string SelectedProID;

        public DataSet datos;

        public FCT_Proyeccion_Copy()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_descripcion.Text.ToString() != "")
                {
                    if (action != "proy")
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

                        string query = @"INSERT INTO [dbo].[FCT_Proyecciones_Ventas_v2]
			                                                        ([code]
			                                                        ,[name]
			                                                        ,[created_date]
			                                                        ,[created_by]
			                                                        ,[status])
		                                                     VALUES ('" + forecastcode + @"'
			                                                        ,'" + txt_descripcion.Text.ToString() + @"'
			                                                        ,SYSDATETIME()
			                                                        ," + ActiveUserCode + @"
			                                                        ,40);
                                                                SELECT SCOPE_IDENTITY();";

                        SelectedProID = dp.ACS_InsertAndReturnID(query).ToString();

                        foreach (DataRow row in datos.Tables[0].Rows)
                        {
                            query = @"INSERT INTO [dbo].[FCT_Proyecciones_Venta_D_v2]
			                            ([id_proy]
				                        ,[id_form]
				                        ,[ene]
				                        ,[feb]
				                        ,[mar]
				                        ,[abr]
				                        ,[may]
				                        ,[jun]
				                        ,[jul]
				                        ,[ago]
				                        ,[sep]
				                        ,[oct]
				                        ,[nov]
				                        ,[dic])
		                         VALUES (" + SelectedProID + @"
				                        ," + row["id_form"].ToString() + @"
				                        ," + (Convert.ToDecimal(row["ene"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["feb"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["mar"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["abr"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["may"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["jun"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["jul"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["ago"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["sep"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["oct"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["nov"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @"
				                        ," + (Convert.ToDecimal(row["dic"].ToString()) * (Convert.ToDecimal(txt_porcentaje.Text.ToString()) / 100)).ToString() + @");";

                            dp.ACS_DoSmallDBOperation(query);
                        }

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;

                        this.Close();
                    }
                    else 
                    {
                        Porcentaje = Convert.ToDouble(txt_porcentaje.Text.ToString());

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;

                        this.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Debe indicar un nombre para la copia de la proyección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FCT_Proyeccion_Copy_Load(object sender, EventArgs e)
        {
            if (action == "proy") 
            {
                txt_descripcion.Text = textBoxData;
                txt_descripcion.Enabled = false;
            }
        }
    }
}