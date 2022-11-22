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
using LOSA.MigracionACS.DataSetx;
using ACS.Classes;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Calidad : DevExpress.XtraEditors.XtraForm
    {
        int Varid;
        DataOperations dp;
        int SelectedId;
        public PRB_Calidad(int ParID, int SelectedId)
        {
            InitializeComponent();
            Varid = ParID;
            dp = new DataOperations();
            this.SelectedId = SelectedId;
        }

        private void txthumedad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtnoconf_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PRB_Calidad_Load(object sender, EventArgs e)
        {
            labelControl2.Text = Varid.ToString();
            load();
        }
        public void load()
        {
            try
            {
                string Query;
                Query = @"SELECT  [id]
                               ,coalesce([prod_noconf], 0) as prod_noconf
                               ,coalesce([humedad],0) as humedad
                          FROM [dbo].[PRB_Registro_D]
                          where id = " + Varid;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (Varid == dr.GetInt32(0))
                    {
                        decimal hum;
                        int noconf;
                        hum = dr.GetDecimal(2);
                        noconf = dr.GetInt32(1);
                        txthumedad.Text = Convert.ToString(hum);
                        txtnoconf.Text = Convert.ToString(noconf);
                    }
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si no se ha guardado los cambios se perderan","Se va cerrar el formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string humedad, noconf;
            if (txthumedad.Text == "")
            {
                MessageBox.Show("La seccion de humedad esta vacia.");
                txthumedad.Focus();
                return;
            }
            else
            {
                humedad = txthumedad.Text;
            }

            if (txtnoconf.Text == "")
            {
                MessageBox.Show("La seccion de sacos no conforme esta vacia");
                txtnoconf.Focus();
                return;

            }
            else
            {
                noconf = txtnoconf.Text;
            }

            string Query;
            Query = @"UPDATE [dbo].[PRB_Registro_D]
                           SET  [prod_noconf] = "+noconf+@"
                              ,[humedad] = "+humedad+@"
                         WHERE id = " +Varid;
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.ExecuteNonQuery();

            string queryup;
            queryup = @"UPDATE [dbo].[PRB_Registro_H]
                                    set
                                        [estatus] = 50
                                    where id = " + SelectedId;
            cmd = new SqlCommand(queryup, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cambio integrado.");
            this.DialogResult = DialogResult.Yes;
            this.Close();

        }
    }
}