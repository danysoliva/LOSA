using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using LOSA.Clases;
using LOSA.Reportes;

namespace LOSA.Mantenimientos
{
    public partial class frmMantoOpciones : Form
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado = new UserLogin();
        
        public frmMantoOpciones(UserLogin User)
        {
            InitializeComponent();
            UsuarioLogeado = User;
        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {
            frmBodega frm = new frmBodega();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdPresentaciones_Click(object sender, EventArgs e)
        {
            frmTipoPresentacion frm = new frmTipoPresentacion();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdUbicaciones_Click(object sender, EventArgs e)
        {
            frmUbicaciones frm = new frmUbicaciones();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmRecuento frm = new frmRecuento(UsuarioLogeado);
            frm.Show();
        }

      
    }
}
