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

namespace LOSA.Calidad
{
    public partial class xfrmWizardConfCalidad : DevExpress.XtraEditors.XtraForm
    {
        public int Id_ingreso;
        UserLogin UsuarioLogeado;
        int NumeroIngreso;
        int IdMP;
        string Lote;

        enum TipoTransaccion
        {
            Ver = 4
        }

        public xfrmWizardConfCalidad(int id_ingreso_lote, UserLogin Puser)
        {
            InitializeComponent();

            Id_ingreso = id_ingreso_lote;
            UsuarioLogeado = Puser;
        }

        public xfrmWizardConfCalidad(int pNumeroIngreso, UserLogin Puser, int pIdMP, string pLote)
        {
            InitializeComponent();
            NumeroIngreso = pNumeroIngreso;
            IdMP = pIdMP;
            Lote = pLote;
            UsuarioLogeado = Puser;
        }

        //cmdVerConfExistente
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //rdEstadoTransporte frm = new rdEstadoTransporte(Id_ingreso,UsuarioLogeado, Convert.ToInt32(TipoTransaccion.Ver));
            //frm.Show();
            frmInspeccionCalidadPorIngresoLoteMP frm = new frmInspeccionCalidadPorIngresoLoteMP(NumeroIngreso, IdMP, Lote, UsuarioLogeado);
            frm.Show();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}