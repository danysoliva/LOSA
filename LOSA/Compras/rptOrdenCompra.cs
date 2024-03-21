using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using LOSA.Clases;
using LOSA.ACS;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Compras;

namespace LOSA.Compras
{
    public partial class rptOrdenCompra : DevExpress.XtraReports.UI.XtraReport
    {
        int IdOrdenH;

        public rptOrdenCompra(int pIdOrdenH)
        {
            InitializeComponent();

            IdOrdenH = pIdOrdenH;
            CMOrdenCompraH oc = new CMOrdenCompraH();
            oc.RecuperarRegistro(IdOrdenH);
            lblDocNum.Text = "NO#:" + oc.DocNum.ToString();
            lblCliente.Text = oc.CardName;

            Proveedor prov = new Proveedor();
            prov.RecuperarRegistroWithRTN(oc.CardCode);
            lblRTN.Text = prov.RTN;
            lblDireccion.Text = oc.Address;
            lblTelefono.Text = prov.Telefono1;
            lblContacto.Text = prov.ContactName;
            lblFechaOrden.Text = string.Format("{0:d}", oc.DocDate); //oc.DocDate.ToString();
            lblFechaVencimiento.Text = string.Format("{0:d}", oc.DocDueDate);
            lblTerminoPago.Text = prov.TerminoPago;
            lblEncargado.Text = oc.UsuarioName;
            lblMoneda.Text = oc.DocCur;
            lblReferencia.Text = oc.NumAtCard;
            lblComentario.Text = oc.Comments;

            switch (oc.IdEstado)
            {
                case 1://Pendiente de Aprobacion
                    lblEstado.Visible = true;
                    lblEstado.Text = "OC Pendiente de Aprobacion\nBORRADOR";

                    break;

                case 2: //Autorizado
                    lblEstado.Visible = false;
                    //lblEstado.Text = "OC Pendiente de Aprobacion";
                    break;

                case 3: //Rechazado
                    lblEstado.Visible = true;
                    lblEstado.Text = "OC Rechazada\nBORRADOR";
                    break;
                default:
                    break;
            }

            string SimboloMoneda = "L.";
            switch (oc.DocCur)
            {
                case "LPS":
                    SimboloMoneda = "L.";
                    break;

                case "USD":
                    SimboloMoneda = "$";
                    break;

                default:
                    break;
            }

            lblTotal.Text = (SimboloMoneda + oc.DocTotal).ToString();
            lblIsv15.Text = (SimboloMoneda + oc.ISV).ToString();
            lblSub.Text = (SimboloMoneda + (oc.DocTotal - oc.ISV)).ToString();
            CargarDetalleOrdenCompra();

            
            ConversorNumALetras conNum = new ConversorNumALetras(oc.DocTotal, oc.DocCur);
            
            lblAPagarLetras.Text = conNum.NumeroEnLetras;
        }

        private void CargarDetalleOrdenCompra()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand("sp_CM_rpt_orden_compra_detalle", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrdenH", IdOrdenH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle_rpt.Clear();
                adat.Fill(dsCompras1.oc_detalle_rpt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
