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

namespace LOSA.MicroIngredientes
{
    public partial class xfrmMenuMicros : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMenuMicros()
        {
            InitializeComponent();
        }

        private void cmdMicros_Click(object sender, EventArgs e)
        {
            xfrmMicroIngredientes frm = new xfrmMicroIngredientes();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}