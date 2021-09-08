using DevExpress.XtraEditors;
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

namespace LOSA.Trazabilidad
{
    public partial class frmTrazabilidadOpciones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmTrazabilidadOpciones(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            frmMantoProveedoresMP frm = new frmMantoProveedoresMP(this.UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMateriaPrimaHome frm = new frmMateriaPrimaHome();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}