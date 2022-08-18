using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using LOSA.Logistica;

namespace LOSA.Reproceso
{
    public partial class frmEleccionReproceso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmEleccionReproceso(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            xfrmMP_Reproceso_Tarimas frm = new xfrmMP_Reproceso_Tarimas(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnReprocesoIngreso_Click(object sender, EventArgs e)
        {
            xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDetaleTarimaReproceso_Click(object sender, EventArgs e)
        {
            Reproceso.frmReprocesoPrint frm = new Reproceso.frmReprocesoPrint(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}