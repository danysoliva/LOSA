using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.Utils.TouchHelpers;
using Huellas;
using LOSA.Clases;
using LOSA.Utileria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            if (Log1.RecuperarRegistro(1067))
            {
                Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
            }
            else
            {
                Log1.Id = 1067;
                Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Produccion;
            }
            
            frmOpciones frm = new frmOpciones(Log1);
            frm.Show();
            //this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //login
            string user;
            string pass;
            string domian;
            if (txtUsuario.Text != "")
            {
                user = txtUsuario.Text;
            }
            else
            {
                // MessageBox.Show("Usuario Vacio.");
                frmMensaje frm = new frmMensaje( frmMensaje.TipoMsj.error, "No puede dejar el usuario vacio!");
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                return;
            }
            if (txtClave.Text != "")
            {
                pass = txtClave.Text;
            }
            else
            {
                //MessageBox.Show("Contraseña Vacia.");
                frmMensaje frm = new frmMensaje(frmMensaje.TipoMsj.error, "No puede dejar la contraseña vacia!");
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                return;
            }

            Security sc = new Security();
            domian = "AQUAFEEDHN";
            if (sc.Validate_Account(domian, user, pass))
            {

                //MessageBox.Show("Exito");
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);

                int TiempoP = 300;
                //administracion.Huellas.frmProcesando frmProceso = new administracion.Huellas.frmProcesando();
                SplashForm frmProceso = new SplashForm();
                try
                {
                    con.Open();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                frmProceso.ShowDialog();
                Thread.Sleep(TiempoP);
                frmProceso.Close();

                //Teclado.cerrarTeclado();
                UserLogin Log1 = new UserLogin();
                if (Log1.RecuperarRegistroFromUser(user))
                {
                    Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
                    frmOpciones frm = new frmOpciones(Log1);
                    frm.Show();

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            else
            {
                //MessageBox.Show("Datos de login incorrectos!");
                frmMensaje frm = new frmMensaje(frmMensaje.TipoMsj.error, "Usuario y contraseña son invalidos!");
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(new object(), new EventArgs());
            }
        }
    }
}
