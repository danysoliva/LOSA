using ACS.Classes;
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

namespace LOSA.Produccion
{
    public partial class frmCantidadMP : Form
    {
        DataOperations dp = new DataOperations();
        public frmCantidadMP()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_cantidad_materia_prima";

                dsLogistica.cantidad_materia_prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsLogistica.cantidad_materia_prima);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
