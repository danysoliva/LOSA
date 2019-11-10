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

namespace LOSA
{
    public partial class frmOpciones : Form
    {
        public frmOpciones(UserLogin pUser)
        {
            InitializeComponent();
            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            tabOpciones.TabPages[i].PageVisible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMantenimiento frm = new frmMantenimiento();
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecepcionMPLogistica_Click(object sender, EventArgs e)
        {

        }
    }
}
