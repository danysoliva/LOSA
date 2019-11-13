using LOSA.Clases;
using LOSA.Mantenimientos;
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

namespace LOSA
{
    public partial class frmOpciones : Form
    {
        public frmOpciones(UserLogin pUser)
        {
            InitializeComponent();
            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            tabOpciones.SelectedTabPageIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
            tabOpciones.TabPages[i].PageVisible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMantenimiento frm = new frmMantenimiento();
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRecepcionMPLogistica_Click(object sender, EventArgs e)
        {
            //
            frmRecepcionMP frm = new frmRecepcionMP();
            frm.Show();
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            frmBodega frm = new frmBodega();
            frm.Show();
        }

        private void BtnTiposPresentaciones_Click(object sender, EventArgs e)
        {
            frmTipoPresentacion frm = new frmTipoPresentacion();
            frm.Show();
        }

        private void BtnEstadosProgramacionesRequisiciones_Click(object sender, EventArgs e)
        {
            frmEstadoProgramacionRequisicion frm = new frmEstadoProgramacionRequisicion();
            frm.Show();
        }

        private void BtnKardexTiposTransacciones_Click(object sender, EventArgs e)
        {
            frmKardexTipoTransaccion frm = new frmKardexTipoTransaccion();
            frm.Show();
        }

        private void BtnEstadosRequisiciones_Click(object sender, EventArgs e)
        {
            frmEstadoRequisicion frm = new frmEstadoRequisicion();
            frm.Show();
        }
    }
}
