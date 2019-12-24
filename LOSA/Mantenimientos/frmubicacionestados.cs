using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;


namespace LOSA.Mantenimientos
{
    public partial class frmubicacionestados : DevExpress.XtraEditors.XtraUserControl
    {
        public frmubicacionestados()
        {
            InitializeComponent();
        }

        private void gcBodegas_Click(object sender, EventArgs e)
        {
            gcBodegas.Rows.Remove(gcBodegas.Rows(gcBodegas.Rows(0)));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmubicaionestados objForm = new frmunidadesmedidaCRUD();
            objForm.condicion = 1;
            try { objForm.id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.tostring()); }
            catch { objForm.id = 0; }
            objForm.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            frmunidadesmedidaCRUD objForm = new frmunidadesmedidaCRUD();
            objForm.condicion = 2;
            objForm.id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            objForm.nombre_unidad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            objForm.nomenclatura = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            objForm.Show();
        }
    }
}
