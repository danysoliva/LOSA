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
using LOSA.TransaccionesMP;

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmEntregaTarimaMicros frm = new frmEntregaTarimaMicros(UsuarioLogeado);
            if (this.MdiParent != null)
            {
                frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            xfrmAlimentacionTarimaArriba frm = new xfrmAlimentacionTarimaArriba();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdAdicionEnMezcla_Click(object sender, EventArgs e)
        {
            xfrmAlimentacionTarimaArriba frm = new xfrmAlimentacionTarimaArriba();
            //xfrmAdiciones3erNivel frm = new xfrmAdiciones3erNivel();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdTolvasWL__Click(object sender, EventArgs e)
        {

        }
    }
}