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
using LOSA.Micro;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmOpcionesMicro frm = new frmOpcionesMicro();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdPesarOrden_Click(object sender, EventArgs e)
        {
            //Ejecutar pesaje
            xfrmDetalleOrdenesMicrosPesaje frm = new xfrmDetalleOrdenesMicrosPesaje();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }
    }
}