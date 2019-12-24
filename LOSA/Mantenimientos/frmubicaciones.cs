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
    public partial class frmubicaciones : DevExpress.XtraEditors.XtraUserControl
    {
        public frmubicaciones()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Server=(local);DataBase=LOSA; integrated security=true");

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void gcBodegas_Click(object sender, EventArgs e)
        {

        }

        private void frmubicaciones_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("listar_ubicaciones", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            object imagen = "/Resources/edit.png";
            dataGridView2.Rows.Add(imagen);

            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ubicacionesCRUD objForm = new ubicacionesCRUD();
            objForm.condicion = 1;
            try { objForm.id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.tostring()); }
            catch { objForm.id = 0; }
            objForm.Show();
        }


        private void frmubicaciones_Activated(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("listar_ubicaiones", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ubicacionesCRUD objForm = new ubicacionesCRUD();
            objForm.condicion = 2;
            objForm.id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            objForm.pasillo = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            objForm.rack = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            objForm.Show();
        }


        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dataGridView2.Columns[e.ColumnIndex].Name)
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
