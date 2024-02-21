using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.EndUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MicroIngredientes.Tickets.EndUser
{
    public partial class frmTicketsNew : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogeado;
        int Hardware = 2;
        int Software = 1;
        public frmTicketsNew(UserLogin pUser)
        {
            InitializeComponent();
            usuarioLogeado = pUser;
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = 0;
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = 1;
        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frmTicketsNew_IT frm = new frmTicketsNew_IT(usuarioLogeado, 0, Software, 1);//1 es la primera opcion
            frm.Size = new Size(950, 790);
            frm.Show();
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            //Software
            //Solicitud de cambio
            frmTicketsNew_IT frm = new frmTicketsNew_IT(usuarioLogeado, 0, Software, 2);//1 es la primera opcion
            frm.Size = new Size(950, 790);
            frm.Show();

        }

        private void tileBarItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            //Software
            //Solicitud de acceso
            frmTicketsNew_IT frm = new frmTicketsNew_IT(usuarioLogeado, 0, Software, 3);//1 es la primera opcion
            frm.Size = new Size(950, 790);
            frm.Show();

        }

        private void tileBarItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            //Hardware 
            //reportar problemas con un equipo
            frmTicketsNew_IT frm = new frmTicketsNew_IT(usuarioLogeado, 0, Hardware, 1);//1 es la Segunda opcion
            frm.Size = new Size(950, 790);
            frm.Show();

        }

        private void tileBarItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            //Hardware 
            //Solicitud de asignacion
            frmTicketsNew_IT frm = new frmTicketsNew_IT(usuarioLogeado, 0, Hardware, 2);//2 es la Segunda opcion
            frm.Size = new Size(950, 790);
            frm.Show();

        }

        private void tileBarItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            //Hardware 
            //Problemas de Conexion.
            frmTicketsNew_IT frm = new frmTicketsNew_IT(usuarioLogeado, 0, Hardware, 3);//3 es la Segunda opcion
            frm.Size = new Size(950, 790);
            frm.Show();

        }

        private void frmTicketsNew_Load(object sender, EventArgs e)
        {

        }
    }
}