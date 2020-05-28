using Core.Clases.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Tools
{
    public partial class frmInputBox : Form
    {
        public bool ValidInteger;
        public frmInputBox()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidInteger)
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
        }

        private void txtValue_Click(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void frmInputBox_Activated(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
            txtValue.Text = "1";
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            //subir
            int subir;
           subir = Convert.ToInt32(txtValue.Text);
            subir = subir + 1;
            txtValue.Text = subir.ToString();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "1")
            {

            }
            else
            {
                int bajar;
                bajar = Convert.ToInt32(txtValue.Text);
                bajar = bajar - 1;
                txtValue.Text = bajar.ToString();

            }
        }
    }
}
