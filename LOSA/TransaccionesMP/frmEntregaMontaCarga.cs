using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaMontaCarga : Form
    {
        UserLogin UsuarioLogeado;
        public frmEntregaMontaCarga(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
        }
        
        private void cmdDetalleMP_Click(object sender, EventArgs e)
        {
            //entregar viendo el detalle de mp
            frmEntregaDeComponentesReq frm = new frmEntregaDeComponentesReq(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmEntregaMontaCarga_Load(object sender, EventArgs e)
        {

        }

        private void cmdEntrega_Click(object sender, EventArgs e)
        {
            //entregar tarima directamente
            //frmGestionUbicaciones frm = new frmGestionUbicaciones(UsuarioLogeado);
            frmEntregaTarimaReq_v2 frm = new frmEntregaTarimaReq_v2(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmviewrequisas frm = new frmviewrequisas();
            frm.Show();
        }
    }
}
