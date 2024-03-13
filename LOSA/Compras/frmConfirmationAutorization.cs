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

namespace LOSA.Compras
{
    public partial class frmConfirmationAutorization : Form
    {
        CMOrdenCompraH OrdenActual;
        public bool IsApproved;
        public frmConfirmationAutorization(CMOrdenCompraH pOrdenActual)
        {
            InitializeComponent();
            IsApproved = false;
            OrdenActual = pOrdenActual; 
            txtUsuarioSolicita.Text = pOrdenActual.UsuarioName;
            txtEstado.Text = pOrdenActual.EstadoName;
            
            if(pOrdenActual.DocNum == 0)
                txtNumDoc.Text = pOrdenActual.Id.ToString();
            else
                txtNumDoc.Text = pOrdenActual.DocNum.ToString();

            txtComentarios.Text =   pOrdenActual.Comments;
            CMRuta_Aprobacion RutaActual = new CMRuta_Aprobacion();
            if (RutaActual.RecuperarRegistro(OrdenActual.idRutaAprobacion))
                txtRutaAprobacion.Text = RutaActual.Descripcion;
            else
                txtRutaAprobacion.Text = "N/D";

            txtFechaDocumento.Text = string.Format("{0:dd/MM/yyyy}", OrdenActual.TaxDate);

            if(string.IsNullOrEmpty( OrdenActual.U_AquaExoneracion))
                txtTipoOrden.Text = "Normal (con ISV)";
            else
                txtTipoOrden.Text = "Exonerada";

            txtCardName.Text = OrdenActual.CardName;
            txtCardCode.Text = OrdenActual.CardCode;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdRechazar_Click(object sender, EventArgs e)
        {
            IsApproved = false;
            txtDecisionCase.Text = "Rechazado";
        }

        private void cmdAprobar_Click(object sender, EventArgs e)
        {
            IsApproved = true;
            txtDecisionCase.Text = "Autorizado";
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
