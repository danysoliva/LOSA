using ACS.Classes;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.SAP

{
    public partial class frmLoginSAP : Form
    {
         public string user;
        public string pasword;
        public frmLoginSAP()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdIniciar.Focus();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            DataOperations dp = new DataOperations();
            if (dp.CompanyIsconected(txtUsuario.Text, txtPassword.Text))
            {
                user = txtUsuario.Text;
                pasword = txtPassword.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Problema de conexion o usuario invalido");
            }
            SplashScreenManager.CloseForm();
        }
    }
}
