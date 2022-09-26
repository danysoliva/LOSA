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
using LOSA.Clases;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmMenuMicros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public xfrmMenuMicros(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void cmdMicros_Click(object sender, EventArgs e)
        {
            xfrmMicroIngredientes frm = new xfrmMicroIngredientes(this.UsuarioLogeado);
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