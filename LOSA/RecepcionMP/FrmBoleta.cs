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
using LOSA.Clases;
using LOSA.RecepcionMP;
using ACS.Classes;

namespace LOSA.RecepcionMP
{
    public partial class FrmBoleta : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        SqlConnection cnn1 = new SqlConnection();
        public FrmBoleta()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

       void cargarDatos()
        {
            try

            {
              
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA_LOCAL_RE);
                               
                string SQL = @"exec sp_getBoletasBascula";

               dsRecepcionMP.Bascula.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsRecepcionMP.Bascula);              



            }

            catch (Exception ec)

            {

               MessageBox.Show(ec.Message);

            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}