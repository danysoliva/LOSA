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
    public partial class rptOrdenCompraExo : DevExpress.XtraReports.UI.XtraReport
    {
        int IdOrdenH;

        public rptOrdenCompraExo(int pIdOrdenH)
        {
            InitializeComponent();
            IdOrdenH = pIdOrdenH;
            CMOrdenCompraH oc = new CMOrdenCompraH();
            oc.RecuperarRegistro(IdOrdenH);
            lblDocNum.Text = "Orden Compra (Local) NO#:" + oc.DocNum.ToString();
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

            GetExoneracionVigente();

            string SimboloMoneda = "L.";
            switch (oc.DocCur)
            {
                case "LPS       ":
                    SimboloMoneda = "L.";
                    break;

                case "USD       ":
                    SimboloMoneda = "$";
                    break;

                default:
                    break;
            }

            lblTotal.Text = (SimboloMoneda + oc.DocTotal).ToString();
            CargarDetalleOrdenCompra();


            ConversorNumALetras conNum = new ConversorNumALetras(oc.DocTotal, oc.DocCur);

            lblAPagarLetras.Text = conNum.NumeroEnLetras;
        }

        private void GetExoneracionVigente()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_cm_exoneracion_active]", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblResolucion.Text = "Resolucion No. " + dr.GetString(3);
                    lblVigencia.Text = "Vigente del " + string.Format("{0:d}", dr.GetDateTime(1)) + " al " + string.Format("{0:d}", dr.GetDateTime(2));
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptOrdenCompraExo));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAprobadoPor = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblComentario = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.lblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAPagarLetras = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblVigencia = new DevExpress.XtraReports.UI.XRLabel();
            this.lblResolucion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDocNum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lblCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRTN = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDireccion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEncargado = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTerminoPago = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaVencimiento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaOrden = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTelefono = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMoneda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblContacto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReferencia = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 15.625F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10.87519F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0.7083257F;
            this.Detail.Name = "Detail";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel8,
            this.xrLine3,
            this.xrLine1,
            this.xrLabel3,
            this.lblAprobadoPor,
            this.xrLabel2,
            this.lblComentario,
            this.xrLabel7,
            this.xrLabel35,
            this.xrLine11,
            this.lblTotal,
            this.xrLabel4,
            this.lblAPagarLetras,
            this.xrLabel6});
            this.ReportFooter.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ReportFooter.HeightF = 222.9581F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.StylePriority.UseFont = false;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(412.3365F, 189.0414F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(246.8749F, 2.083328F);
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(412.3365F, 191.1248F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(246.8749F, 23.00002F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Firma Y Sello DGCFA";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(37.75317F, 189.0414F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(246.8749F, 2.083328F);
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(3.000132F, 95.66663F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(699.9999F, 2.083328F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0.8300781F, 45.16645F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(692.1699F, 50.50017F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = resources.GetString("xrLabel3.Text");
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblAprobadoPor
            // 
            this.lblAprobadoPor.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblAprobadoPor.LocationFloat = new DevExpress.Utils.PointFloat(106.035F, 97.74996F);
            this.lblAprobadoPor.Name = "lblAprobadoPor";
            this.lblAprobadoPor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAprobadoPor.SizeF = new System.Drawing.SizeF(364.8F, 17F);
            this.lblAprobadoPor.StylePriority.UseFont = false;
            this.lblAprobadoPor.StylePriority.UseTextAlignment = false;
            this.lblAprobadoPor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.8249919F, 97.74995F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(105.21F, 17F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Aprobado por:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblComentario
            // 
            this.lblComentario.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblComentario.LocationFloat = new DevExpress.Utils.PointFloat(95.62162F, 28.16645F);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblComentario.SizeF = new System.Drawing.SizeF(603.54F, 17F);
            this.lblComentario.StylePriority.UseFont = false;
            this.lblComentario.StylePriority.UseTextAlignment = false;
            this.lblComentario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0.8300781F, 28.16645F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(94.79F, 17F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Comentarios:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(513.5305F, 0F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(88.54F, 17F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "Total:";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine11
            // 
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(602.0657F, 0F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(97.09943F, 2F);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTotal.LocationFloat = new DevExpress.Utils.PointFloat(602.0656F, 0F);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTotal.SizeF = new System.Drawing.SizeF(97.1F, 17F);
            this.lblTotal.StylePriority.UseFont = false;
            this.lblTotal.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            this.lblTotal.Summary = xrSummary1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(71.54F, 17F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "A PAGAR:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblAPagarLetras
            // 
            this.lblAPagarLetras.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblAPagarLetras.LocationFloat = new DevExpress.Utils.PointFloat(71.54185F, 0F);
            this.lblAPagarLetras.Name = "lblAPagarLetras";
            this.lblAPagarLetras.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAPagarLetras.SizeF = new System.Drawing.SizeF(399.29F, 17F);
            this.lblAPagarLetras.StylePriority.UseFont = false;
            this.lblAPagarLetras.StylePriority.UseTextAlignment = false;
            this.lblAPagarLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(37.74834F, 191.1283F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(246.8749F, 23.00003F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Firma Y Nombre";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblVigencia,
            this.lblResolucion,
            this.xrLabel5,
            this.xrLabel17,
            this.xrLabel21,
            this.xrPictureBox1,
            this.xrLabel1,
            this.lblDocNum,
            this.xrLine2,
            this.lblCliente,
            this.xrLabel9,
            this.xrLabel15,
            this.lblRTN,
            this.lblDireccion,
            this.xrTable1,
            this.xrLabel12,
            this.xrLabel14,
            this.xrLabel16,
            this.lblEncargado,
            this.lblTerminoPago,
            this.lblFechaVencimiento,
            this.xrLabel40,
            this.lblFechaOrden,
            this.lblTelefono,
            this.xrLabel24,
            this.lblMoneda,
            this.xrLabel19,
            this.lblContacto,
            this.xrLabel18,
            this.lblReferencia,
            this.xrLabel22,
            this.xrLabel23});
            this.ReportHeader.HeightF = 306F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblVigencia
            // 
            this.lblVigencia.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblVigencia.LocationFloat = new DevExpress.Utils.PointFloat(0.8250732F, 103.625F);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblVigencia.SizeF = new System.Drawing.SizeF(698.34F, 17F);
            this.lblVigencia.StylePriority.UseFont = false;
            this.lblVigencia.StylePriority.UseTextAlignment = false;
            this.lblVigencia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblResolucion
            // 
            this.lblResolucion.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblResolucion.LocationFloat = new DevExpress.Utils.PointFloat(0.8300781F, 86.62503F);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblResolucion.SizeF = new System.Drawing.SizeF(698.33F, 17F);
            this.lblResolucion.StylePriority.UseFont = false;
            this.lblResolucion.StylePriority.UseTextAlignment = false;
            this.lblResolucion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(3.000132F, 246.3936F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.SizeF = new System.Drawing.SizeF(686.9965F, 39.58337F);
            this.xrLabel5.Text = resources.GetString("xrLabel5.Text");
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 178.3936F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(84.59F, 17F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Direccion:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 195.3936F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(84.59F, 17F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Telefono:";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(132.3101F, 132.3101F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Calibri", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(233.3333F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.SizeF = new System.Drawing.SizeF(237.5F, 19F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "AQUAFEED S.A. DE C.V.";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblDocNum
            // 
            this.lblDocNum.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblDocNum.LocationFloat = new DevExpress.Utils.PointFloat(0.8265178F, 120.625F);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.SizeF = new System.Drawing.SizeF(698.34F, 17F);
            this.lblDocNum.StylePriority.UseFont = false;
            this.lblDocNum.StylePriority.UseTextAlignment = false;
            this.lblDocNum.Text = "NO#:";
            this.lblDocNum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 142.3102F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(699.9999F, 2.083328F);
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblCliente.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 144.3936F);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCliente.SizeF = new System.Drawing.SizeF(340.62F, 17F);
            this.lblCliente.StylePriority.UseFont = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 144.3936F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(85.41667F, 16.99998F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Proveedor:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 161.3936F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(84.58659F, 17F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "RTN:";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblRTN
            // 
            this.lblRTN.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblRTN.LocationFloat = new DevExpress.Utils.PointFloat(84.58659F, 161.3936F);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRTN.SizeF = new System.Drawing.SizeF(341.4554F, 17F);
            this.lblRTN.StylePriority.UseFont = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblDireccion.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 178.3936F);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDireccion.SizeF = new System.Drawing.SizeF(340.62F, 17F);
            this.lblDireccion.StylePriority.UseFont = false;
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.Gray;
            this.xrTable1.BorderColor = System.Drawing.SystemColors.Desktop;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0.83F, 289F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(702.17F, 17F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell2,
            this.xrTableCell21,
            this.xrTableCell6});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Cant.";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.57052801184252933D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Descripcion";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 2.4016152407141482D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Item Resolucion";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 2.2966970485088831D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Cap.";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 0.77434186480127365D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "Prec. Unit";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell21.Weight = 0.96504894308790434D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "Total";
            this.xrTableCell6.Weight = 1.0234492074530894D;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 144.3936F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(114.03F, 17F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Fecha:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(426.0418F, 178.3936F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(114.03F, 17F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Termino. Pago:";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 195.3936F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(114.03F, 17F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Encargado:";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblEncargado
            // 
            this.lblEncargado.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblEncargado.ForeColor = System.Drawing.Color.Black;
            this.lblEncargado.LocationFloat = new DevExpress.Utils.PointFloat(540.0731F, 195.3936F);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEncargado.SizeF = new System.Drawing.SizeF(159.09F, 17F);
            this.lblEncargado.StylePriority.UseFont = false;
            this.lblEncargado.StylePriority.UseForeColor = false;
            this.lblEncargado.StylePriority.UseTextAlignment = false;
            this.lblEncargado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTerminoPago
            // 
            this.lblTerminoPago.BorderColor = System.Drawing.Color.Black;
            this.lblTerminoPago.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblTerminoPago.ForeColor = System.Drawing.Color.Black;
            this.lblTerminoPago.LocationFloat = new DevExpress.Utils.PointFloat(540.0729F, 178.3936F);
            this.lblTerminoPago.Name = "lblTerminoPago";
            this.lblTerminoPago.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTerminoPago.SizeF = new System.Drawing.SizeF(159.09F, 17F);
            this.lblTerminoPago.StylePriority.UseBorderColor = false;
            this.lblTerminoPago.StylePriority.UseFont = false;
            this.lblTerminoPago.StylePriority.UseForeColor = false;
            this.lblTerminoPago.StylePriority.UseTextAlignment = false;
            this.lblTerminoPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblFechaVencimiento.LocationFloat = new DevExpress.Utils.PointFloat(540.0731F, 161.3936F);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaVencimiento.SizeF = new System.Drawing.SizeF(159.09F, 17F);
            this.lblFechaVencimiento.StylePriority.UseFont = false;
            this.lblFechaVencimiento.StylePriority.UseTextAlignment = false;
            this.lblFechaVencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.lblFechaVencimiento.TextFormatString = "{0:d/M/yyyy}";
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 161.3936F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(114.03F, 17F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "Valida Hasta:";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblFechaOrden.LocationFloat = new DevExpress.Utils.PointFloat(540.0729F, 144.3936F);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaOrden.SizeF = new System.Drawing.SizeF(159.0936F, 16.99998F);
            this.lblFechaOrden.StylePriority.UseFont = false;
            this.lblFechaOrden.StylePriority.UseTextAlignment = false;
            this.lblFechaOrden.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.lblFechaOrden.TextFormatString = "{0:d/M/yyyy}";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblTelefono.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 195.3936F);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTelefono.SizeF = new System.Drawing.SizeF(339.7899F, 16.99998F);
            this.lblTelefono.StylePriority.UseFont = false;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(426.0419F, 212.3936F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(114.03F, 17F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Moneda:";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblMoneda
            // 
            this.lblMoneda.BorderColor = System.Drawing.Color.Black;
            this.lblMoneda.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblMoneda.ForeColor = System.Drawing.Color.Black;
            this.lblMoneda.LocationFloat = new DevExpress.Utils.PointFloat(540.0731F, 212.3935F);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMoneda.SizeF = new System.Drawing.SizeF(159.0887F, 17.00003F);
            this.lblMoneda.StylePriority.UseBorderColor = false;
            this.lblMoneda.StylePriority.UseFont = false;
            this.lblMoneda.StylePriority.UseForeColor = false;
            this.lblMoneda.StylePriority.UseTextAlignment = false;
            this.lblMoneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 212.3935F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(84.59F, 17F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Contacto:";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblContacto
            // 
            this.lblContacto.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblContacto.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 212.3935F);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblContacto.SizeF = new System.Drawing.SizeF(340.6253F, 17F);
            this.lblContacto.StylePriority.UseFont = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 229.3935F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(114.03F, 17F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Referencia:";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblReferencia
            // 
            this.lblReferencia.BorderColor = System.Drawing.Color.Black;
            this.lblReferencia.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblReferencia.ForeColor = System.Drawing.Color.Black;
            this.lblReferencia.LocationFloat = new DevExpress.Utils.PointFloat(540.0719F, 229.3936F);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReferencia.SizeF = new System.Drawing.SizeF(159.0898F, 17F);
            this.lblReferencia.StylePriority.UseBorderColor = false;
            this.lblReferencia.StylePriority.UseFont = false;
            this.lblReferencia.StylePriority.UseForeColor = false;
            this.lblReferencia.StylePriority.UseTextAlignment = false;
            this.lblReferencia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(197.0914F, 29.00001F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.SizeF = new System.Drawing.SizeF(342.98F, 17F);
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "ALIMENTO BALANCEADO PARA PECES Y CAMARONES";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(184.59F, 46.00001F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.SizeF = new System.Drawing.SizeF(377.285F, 40.62502F);
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Aldea Borboton, San Francisco de Yojoa, Depto .Cortes \r\nTel: 2650-4002, 2650-4123" +
    ", 2650-4124\r\nE-Mail : info@aquafeedhn.com";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "orden_compra_exo";
            this.DetailReport.DataSource = this.dsCompras1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail1.HeightF = 17.37502F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0.8300323F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(702.17F, 17F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell7,
            this.xrTableCell10,
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell8});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[oc_detalle_rpt].[cantidad]")});
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 0.5655493094075329D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[oc_detalle_rpt].[descripcion]")});
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.Weight = 2.3806636537792083D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[oc_detalle_rpt].[partida_arancelaria]")});
            this.xrTableCell10.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Text = "xrTableCell10";
            this.xrTableCell10.Weight = 2.276661257124692D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[oc_detalle_rpt].[capitulo]")});
            this.xrTableCell9.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.Weight = 0.76758650032261744D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[oc_detalle_rpt].[precio]")});
            this.xrTableCell11.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.Text = "xrTableCell11";
            this.xrTableCell11.Weight = 0.95663160218035426D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[oc_detalle_rpt].[total]")});
            this.xrTableCell8.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.Weight = 1.0145196027203232D;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptOrdenCompraExo
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.ReportHeader,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsCompras1});
            this.Font = new DevExpress.Drawing.DXFont("Arial; 9.75pt; 8.25pt; 8.25pt; 8.25pt; 8.25pt", 8.25F);
            this.Margins = new DevExpress.Drawing.DXMargins(76F, 73F, 15.625F, 10.87519F);
            this.Version = "23.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.Add(xrWatermark1);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
