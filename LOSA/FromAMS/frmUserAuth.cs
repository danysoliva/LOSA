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
using System.Data.SqlClient;
using LOSA.Utileria;
using LOSA.Clases;
using Huellas;
using System.Threading;
using ACS.Classes;

namespace AMS.Compras.ControlInv
{
    public partial class frmUserAuth : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public UserLogin UserAuth;
        public frmUserAuth()
        {
            InitializeComponent();
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                Validar();
            }
        }
        public void Validar()
        {
            //login
            string user;
            string pass;
            string domian;
            if (txtusuario.Text != "")
            {
                user = txtusuario.Text;
            }
            else
            {
                // MessageBox.Show("Usuario Vacio.");
                frmMensaje frm = new frmMensaje(frmMensaje.TipoMsj.error, "No puede dejar el usuario vacio!");
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                return;
            }
            if (txtpassword.Text != "")
            {
                pass = txtpassword.Text;
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
                SqlConnection con = new SqlConnection(dp.ConnectionStringAMS);

                int TiempoP = 30;
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
                if (Log1.RecuperarRegistroFromUser(user.Trim()))
                {
                    //this.Hide();
                   
                    UserAuth = Log1;

                    if (UserAuth.ValidarNivelPermisos(52))
                    {

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene los niveles de permisos necesarios para realizar esta operacion.");
                        return;
                    }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Validar();
        }
    }
}