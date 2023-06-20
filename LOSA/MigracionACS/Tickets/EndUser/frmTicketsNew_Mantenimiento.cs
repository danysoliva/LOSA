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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmTicketsNew_Mantenimiento : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;


        

        public frmTicketsNew_Mantenimiento(UserLogin puserLogin)
        {
            InitializeComponent();
            usuarioLogueado = puserLogin;
        }

        private void tbSolcitudManto_ItemClick(object sender, TileItemEventArgs e)
        {
            frmTickets frm = new frmTickets(usuarioLogueado, frmTickets.TipoTicket.Manto,1, tbSolcitudManto.Text);

            frm.ShowDialog();
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            frmTickets frm = new frmTickets(usuarioLogueado, frmTickets.TipoTicket.Manto, 2, tbSolicitudProyecto.Text);

            frm.ShowDialog();
        }

        private void tbSolicitudMejora_ItemClick(object sender, TileItemEventArgs e)
        {
            frmTickets frm = new frmTickets(usuarioLogueado, frmTickets.TipoTicket.Manto, 3, tbSolicitudMejora.Text);

            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}