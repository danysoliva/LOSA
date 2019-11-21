using Core.Clases.Herramientas;
using DevExpress.Utils.TouchHelpers;
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
        int IdUser;
        public frmMain()
        {
            InitializeComponent();
            //TouchKeyboardSupport.EnableTouchKeyboard = true;
            //TouchKeyboardSupport.CheckEnableTouchSupport(this);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdButtonSaltarLogin_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            UserLogin Log1 = new UserLogin();
            if (Log1.RecuperarRegistro(1035))
            {
                Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            }
            else
            {
                Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Montacarga;
            }
            
            frmOpciones frm = new frmOpciones(Log1);
            frm.Show();
            //this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //login


            //Select del grupo al que pertenece el usuario


            //Iniciar la variable de sesion con el grupo activo.
            


        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}
