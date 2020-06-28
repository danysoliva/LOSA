using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Mantenimientos
{
    public partial class frmMantoOpciones : Form
    {
        public frmMantoOpciones()
        {
            InitializeComponent();
        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {
            frmBodega frm = new frmBodega();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdPresentaciones_Click(object sender, EventArgs e)
        {
            frmTipoPresentacion frm = new frmTipoPresentacion();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        {
            frmUbicaciones frm = new frmUbicaciones();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
