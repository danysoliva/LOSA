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

namespace LOSA.Logistica
{
    public partial class xfrmReprocesoMenu : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;

        public xfrmReprocesoMenu(UserLogin pUser)
        {
            InitializeComponent();

            UsuarioLogeado = pUser;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xfrmIngresosMP_Reproceso frm = new xfrmIngresosMP_Reproceso(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
           xfrmPT_Reproceso frm = new xfrmPT_Reproceso(UsuarioLogeado);

            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}