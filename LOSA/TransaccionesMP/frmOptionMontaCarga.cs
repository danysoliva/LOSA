using LOSA.Clases;
using LOSA.RecepcionMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.TransaccionesMP
{
    public partial class frmOptionMontaCarga : Form
    {
        UserLogin UsuarioLogeado;
        int TipoUso;
        public frmOptionMontaCarga(UserLogin pUser, int pTipoUsoVentana)
        {
            InitializeComponent();
            TipoUso = pTipoUsoVentana;
            switch(TipoUso)
            {
                case 1:
                    tabOpciones.SelectedTabPageIndex = 0;
                    tabOpciones.TabPages[0].PageVisible = true;
                    //tabOpciones.TabPages[1].PageVisible = false;
                    break;
                case 2:
                    tabOpciones.SelectedTabPageIndex = 1;
                    tabOpciones.TabPages[1].PageVisible = true;
                    break;
            }
            UsuarioLogeado = pUser;
        }

        private void cmdEntradaMP_Click(object sender, EventArgs e)
        {
            frmEntradaMP frm = new frmEntradaMP(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            frmCambiarUbicacionTarima frm = new frmCambiarUbicacionTarima();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmMantenimiento frm = new frmMantenimiento();
            //frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRequisiciones_Click(object sender, EventArgs e)
        {
            frmEntregaMontaCarga frm = new frmEntregaMontaCarga(this.UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdIngresoPT_Click(object sender, EventArgs e)
        {
            frmEntradaPT frm = new frmEntradaPT(this.UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void cmdCambiarUbicacionPT_Click(object sender, EventArgs e)
        {
            frmCambiarUbicacionTarimaPT frm = new frmCambiarUbicacionTarimaPT();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.Show();
        }

        private void cmdOrdenesCargaPT_Click(object sender, EventArgs e)
        {
            LOSA.Despachos.frmentregadeproductoT frm = new Despachos.frmentregadeproductoT(UsuarioLogeado);
            frm.Show();
        }
    }
}
