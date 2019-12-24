using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace LOSA.Mantenimientos
{
    public partial class ubicacionesCRUD : DevExpress.XtraEditors.XtraUserControl
    {
        public ubicacionesCRUD()
        {
            InitializeComponent();
        }

        public int condicion;
        public int id;
        public string pasillo, rack;

        SqlConnection cn = new SqlConnection("Server=(local);DataBase=LOSA;integrated security=true");


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmunidades_medidaCRUD_Load(object sender, EventArgs e)
        {
            pasillo.txt = pasillo;
            rack.txt = rack;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("mante_unbicaiones", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pasillo", pasillo.text);
            cmd.Parameters.AddWithValue("@rack", rack.text);
            cmd.Parameters.AddWithValue("@enable", enable);
            cmd.Parameters.AddWithValue("@condicion", condicion);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Guardado Exitosamente");
            this.close();
        }
    }
}
