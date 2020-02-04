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
    public partial class frmunidadesmedida : DevExpress.XtraEditors.XtraUserControl
    {
        public frmunidadesmedida()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection("Server=(local);DataBase=LOSA; integrated security=true");
        

        private void unidadesmedidas_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("listar_unidades_medida", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            object imagen = "/Resources/edit.png";
            dataGridView1.Rows.Add(imagen);
        }

        private void frmunidades_medida_Load(object sender, EventArgs e)
        {
            dataGridView1 btnclm = new dataGridView1();
            btnclm.editar = "Editar";

        }



        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmunidadesmedidaCRUD objForm = new frmunidadesmedidaCRUD();
            objForm.condicion = 1;
            try { objForm.id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.tostring()); }
            catch { objForm.id = 0; }
            objForm.Show();
        }

        private void frmunidadesmedida_Activated(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("listar_unidades_medida", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmunidadesmedidaCRUD objForm = new frmunidadesmedidaCRUD();
            objForm.condicion = 2;
            objForm.id = int.Parse (dataGridView1.CurrentRow.Cells[0].Value.ToString());

            objForm.nombre_unidad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            objForm.nomenclatura = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            objForm.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Editar":
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;
            }
        }
    }
}
