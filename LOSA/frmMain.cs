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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdButtonSaltarLogin_Click(object sender, EventArgs e)
        {
            UserLogin Log1 = new UserLogin();
            Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Calidad;
            frmOpciones frm = new frmOpciones(Log1);
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //login


            //Select del grupo al que pertenece el usuario


            //Iniciar la variable de sesion con el grupo activo.
            


        }
    }
}
