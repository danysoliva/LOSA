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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.FromAMS
{
    public partial class frmAprobacionesConfirmacion : DevExpress.XtraEditors.XtraForm
    {
        public bool IsApproved;
        public string Comentario;
        DataOperations dp = new DataOperations();
        public long IdSolicitudAprobacion;

        public frmAprobacionesConfirmacion(int pIdRequisa)
        {
            InitializeComponent();
            Aprobaciones apro = new Aprobaciones();
            apro.RecuperarRegistro(pIdRequisa);
            IdSolicitudAprobacion = apro.IdH;
            txtTipoOrden.Text = apro.TipoDescripcion;
            IsApproved = false;
            txtUsuarioSolicita.Text = apro.Solicitante;
            txtEstado.Text = apro.Estado;

            if (string.IsNullOrEmpty(apro.Barcode))
                txtNumDoc.Text = apro.IdRequisa.ToString();
            else
                txtNumDoc.Text = apro.Barcode;
            txtComentarios.Text = apro.Comentario;
            txtFechaDocumento.Text = apro.FechaSolicitud.ToString();
            txtRutaAprobacion.Text = apro.Ruta;

            //CMRuta_Aprobacion RutaActual = new CMRuta_Aprobacion();
            //if (RutaActual.RecuperarRegistro(OrdenActual.idRutaAprobacion))
            //    txtRutaAprobacion.Text = RutaActual.Descripcion;
            //else
            //    txtRutaAprobacion.Text = "N/D";



        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            frmVerDetalleSolicitud frm = new frmVerDetalleSolicitud(IdSolicitudAprobacion);
            frm.ShowDialog();
        }

        private void cmdAprobar_Click(object sender, EventArgs e)
        {
            IsApproved = true;
            txtDecisionCase.Text = "Autorizado";
        }

        private void cmdRechazar_Click(object sender, EventArgs e)
        {
            IsApproved = false;
            txtDecisionCase.Text = "Rechazado";
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCommentsAprobador.Text))
            {
                Comentario = txtCommentsAprobador.Text;
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}