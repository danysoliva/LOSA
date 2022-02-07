using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica
{
    public partial class frmSeleccionLoteCierre : DevExpress.XtraEditors.XtraForm
    {
        public frmSeleccionLoteCierre()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}