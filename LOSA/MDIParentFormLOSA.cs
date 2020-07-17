using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA
{
    public partial class MDIParentFormLOSA : Form
    {
        private int childFormNumber = 0;

        public MDIParentFormLOSA()
        {
            InitializeComponent();
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        
    }
}
