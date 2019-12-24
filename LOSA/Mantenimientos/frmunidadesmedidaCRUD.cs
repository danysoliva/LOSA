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
    public partial class frmunidadesmedidaCRUD : DevExpress.XtraEditors.XtraUserControl
    {
        public frmunidadesmedidaCRUD()
        {
            InitializeComponent();
        }

        public int condicion;
        public int id;
        public string nombre_unidad, nomenclatura;

        SqlConnection cn = new SqlConnection("Server=(local);DataBase=LOSA;integrated security=true");


        private void frmunidades_medidaCRUD_Load(object sender, EventArgs e)
        {
            nombre_unidad.txt = nombre_unidad;
            nomenclatura.txt = nomenclatura;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("mante_unidades_medida", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre_unidad",nombre_unidad.text);
            cmd.Parameters.AddWithValue("@nomenclatura",nomenclatura.text);
            cmd.Parameters.AddWithValue("@enable",enable);
            cmd.Parameters.AddWithValue("@condicion",condicion);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Guardado Exitosamente");
            this.close();
        }
    }
}
