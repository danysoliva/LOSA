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

namespace LOSA.Reportes
{
    public partial class frmreport : DevExpress.XtraEditors.XtraForm
    {
        public frmreport()
        {
            InitializeComponent();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cmdHome_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {
            frmtarimasporbodega frm = new frmtarimasporbodega();
            frm.Show();
        }
    }
}