using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frm_ingresos : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;
        public frm_ingresos(UserLogin User)
        {
            InitializeComponent();
            UsuarioLogeado = User;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTarima frm = new frmTarima(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}