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

namespace LOSA.Despachos
{
    public partial class frm_seleccionUD : DevExpress.XtraEditors.XtraForm
    {
      public int Ud;
        int Max;
        public frm_seleccionUD(int Pud)
        {
            InitializeComponent();
            Ud = Pud;
            Ud = Pud;
            Max = Pud;
            txtUnidades.Text = Ud.ToString();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            if ((Ud + 1 ) > Max)
            {

            }
            else
            {
                Ud = Ud + 1;
                txtUnidades.Text = Ud.ToString();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int temp = Ud - 1;
            if (temp == 0)
            {

            }
            else
            {
                Ud = Ud - 1;
                txtUnidades.Text = Ud.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Ud = Convert.ToInt32(txtUnidades.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}