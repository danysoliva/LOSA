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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_Manten : DevExpress.XtraEditors.XtraForm
    {
        int id;
        DataOperations dp;
        public FCT_Manten(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                dp = new DataOperations();
                string saveQuery;
                saveQuery = @"UPDATE [dbo].[FCT_Proyecciones_Ventas_v2]
                                       SET 
                                          [name] = '"+txtname.Text+@"'
                                     WHERE id ="+id;
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cemede = new SqlCommand(saveQuery, con);
                if (cemede.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Datos guardados", "¡Exito!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al actualizar contacte al administrador.","Error 1");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar contacte al administrador.","Error 2");
            }
        }

        private void FCT_Manten_Load(object sender, EventArgs e)
        {
            try
            {
                dp = new DataOperations();
                string Query;
                Query = @"SELECT [id]
                              ,[code]
                              ,[name]
                        FROM [dbo].[FCT_Proyecciones_Ventas_v2]
                        where id = "+id;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    txtCode.Text = re.GetString(1);
                    txtname.Text = re.GetString(2);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, es imposible cargar los datos. Contacte con el administrador", "Advertencia");

            }
           


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}