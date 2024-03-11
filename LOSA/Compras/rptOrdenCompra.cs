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
            lblFechaOrden.Text = oc.DocDate.ToString();
            lblFechaVencimiento.Text = oc.DocDueDate.ToString();
            lblTerminoPago.Text = prov.TerminoPago;
            lblEncargado.Text = oc.UsuarioName;
            lblMoneda.Text = oc.DocCur;
            lblReferencia.Text = oc.NumAtCard;
            lblComentario.Text = oc.Comments;


            //lblTotal.Text = string.Format("{0:$."+oc.DocTotal +" }");
            lblIsv15.Text = oc.ISV.ToString();
            lblSub.Text = Convert.ToString(oc.DocTotal - oc.ISV);
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptOrdenCompra));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblReferencia = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblContacto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMoneda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTelefono = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaOrden = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaVencimiento = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTerminoPago = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEncargado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDireccion = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRTN = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lblDocNum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblDescuento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGastosAdicionales = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblisv18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAPagarLetras = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSub = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine11 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIsv15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblComentario = new DevExpress.XtraReports.UI.XRLabel();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 6.25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 8.333333F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLabel22,
            this.lblReferencia,
            this.xrLabel18,
            this.lblContacto,
            this.xrLabel19,
            this.lblMoneda,
            this.xrLabel24,
            this.lblTelefono,
            this.lblFechaOrden,
            this.xrLabel40,
            this.lblFechaVencimiento,
            this.lblTerminoPago,
            this.lblEncargado,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel12,
            this.xrTable1,
            this.lblDireccion,
            this.lblRTN,
            this.xrLabel15,
            this.xrLabel9,
            this.lblCliente,
            this.xrLine2,
            this.lblDocNum,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPictureBox1,
            this.xrLabel21,
            this.xrLabel17});
            this.ReportHeader.HeightF = 308.6667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel23
            // 
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(184.59F, 61.45833F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.SizeF = new System.Drawing.SizeF(377.285F, 51.04167F);
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Aldea Borboton, San Francisco de Yojoa, Depto .Cortes \r\nTel: 2650-4002, 2650-4123" +
    ", 2650-4124\r\nE-Mail : info@aquafeedhn.com";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(197.0915F, 42.29167F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.SizeF = new System.Drawing.SizeF(342.9817F, 19.16666F);
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "ALIMENTO BALANCEADO PARA PECES Y CAMARONES";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblReferencia
            // 
            this.lblReferencia.BorderColor = System.Drawing.Color.Black;
            this.lblReferencia.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblReferencia.ForeColor = System.Drawing.Color.Black;
            this.lblReferencia.LocationFloat = new DevExpress.Utils.PointFloat(540.0717F, 259.3751F);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReferencia.SizeF = new System.Drawing.SizeF(159.0936F, 23F);
            this.lblReferencia.StylePriority.UseBorderColor = false;
            this.lblReferencia.StylePriority.UseFont = false;
            this.lblReferencia.StylePriority.UseForeColor = false;
            this.lblReferencia.StylePriority.UseTextAlignment = false;
            this.lblReferencia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 259.375F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(114.0301F, 23F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Referencia:";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblContacto
            // 
            this.lblContacto.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblContacto.LocationFloat = new DevExpress.Utils.PointFloat(84.58659F, 236.375F);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblContacto.SizeF = new System.Drawing.SizeF(341.4551F, 22.99998F);
            this.lblContacto.StylePriority.UseFont = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 236.375F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(84.58659F, 22.99998F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Contacto:";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblMoneda
            // 
            this.lblMoneda.BorderColor = System.Drawing.Color.Black;
            this.lblMoneda.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblMoneda.ForeColor = System.Drawing.Color.Black;
            this.lblMoneda.LocationFloat = new DevExpress.Utils.PointFloat(540.0718F, 236.375F);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblMoneda.SizeF = new System.Drawing.SizeF(159.0936F, 23F);
            this.lblMoneda.StylePriority.UseBorderColor = false;
            this.lblMoneda.StylePriority.UseFont = false;
            this.lblMoneda.StylePriority.UseForeColor = false;
            this.lblMoneda.StylePriority.UseTextAlignment = false;
            this.lblMoneda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(426.0419F, 236.375F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(114.0298F, 23.00002F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Moneda:";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblTelefono.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 213.375F);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTelefono.SizeF = new System.Drawing.SizeF(340.6252F, 23.00002F);
            this.lblTelefono.StylePriority.UseFont = false;
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblFechaOrden.LocationFloat = new DevExpress.Utils.PointFloat(540.0729F, 144.375F);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaOrden.SizeF = new System.Drawing.SizeF(159.0936F, 23F);
            this.lblFechaOrden.StylePriority.UseFont = false;
            this.lblFechaOrden.StylePriority.UseTextAlignment = false;
            this.lblFechaOrden.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.lblFechaOrden.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 167.375F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(114.0315F, 23F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "Valida Hasta:";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblFechaVencimiento.LocationFloat = new DevExpress.Utils.PointFloat(540.0731F, 167.375F);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaVencimiento.SizeF = new System.Drawing.SizeF(159.0934F, 23F);
            this.lblFechaVencimiento.StylePriority.UseFont = false;
            this.lblFechaVencimiento.StylePriority.UseTextAlignment = false;
            this.lblFechaVencimiento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.lblFechaVencimiento.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // lblTerminoPago
            // 
            this.lblTerminoPago.BorderColor = System.Drawing.Color.Black;
            this.lblTerminoPago.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblTerminoPago.ForeColor = System.Drawing.Color.Black;
            this.lblTerminoPago.LocationFloat = new DevExpress.Utils.PointFloat(540.0729F, 190.375F);
            this.lblTerminoPago.Name = "lblTerminoPago";
            this.lblTerminoPago.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTerminoPago.SizeF = new System.Drawing.SizeF(159.0936F, 23F);
            this.lblTerminoPago.StylePriority.UseBorderColor = false;
            this.lblTerminoPago.StylePriority.UseFont = false;
            this.lblTerminoPago.StylePriority.UseForeColor = false;
            this.lblTerminoPago.StylePriority.UseTextAlignment = false;
            this.lblTerminoPago.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblEncargado
            // 
            this.lblEncargado.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblEncargado.ForeColor = System.Drawing.Color.Black;
            this.lblEncargado.LocationFloat = new DevExpress.Utils.PointFloat(540.0731F, 213.375F);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEncargado.SizeF = new System.Drawing.SizeF(159.0936F, 23.00002F);
            this.lblEncargado.StylePriority.UseFont = false;
            this.lblEncargado.StylePriority.UseForeColor = false;
            this.lblEncargado.StylePriority.UseTextAlignment = false;
            this.lblEncargado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 213.375F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(114.0313F, 23.00002F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Encargado:";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(426.0418F, 190.375F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(114.0312F, 23.00002F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Termino. Pago:";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(426.0417F, 144.375F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(114.0314F, 23F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Fecha:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0.83F, 283.6667F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(699.1665F, 25F);
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
            this.xrTableCell21,
            this.xrTableCell6});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Cantidad";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.85404014956566576D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Descripcion";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 2.35640190359286D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Unidad";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 1.0410487908974413D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "Prec. Unit";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell21.Weight = 1.3581293012992175D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "Total";
            this.xrTableCell6.Weight = 1.381011380155202D;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblDireccion.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 190.375F);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDireccion.SizeF = new System.Drawing.SizeF(340.625F, 23F);
            this.lblDireccion.StylePriority.UseFont = false;
            // 
            // lblRTN
            // 
            this.lblRTN.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblRTN.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 167.375F);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRTN.SizeF = new System.Drawing.SizeF(340.625F, 23F);
            this.lblRTN.StylePriority.UseFont = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 167.375F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(85.41667F, 23F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "RTN:";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 144.375F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(85.41667F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Proveedor:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblCliente.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 144.375F);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCliente.SizeF = new System.Drawing.SizeF(340.625F, 23F);
            this.lblCliente.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 142.2917F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(699.9999F, 2.083328F);
            // 
            // lblDocNum
            // 
            this.lblDocNum.Font = new DevExpress.Drawing.DXFont("Arial", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblDocNum.LocationFloat = new DevExpress.Utils.PointFloat(561.875F, 30.83334F);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.SizeF = new System.Drawing.SizeF(114.58F, 20.83F);
            this.lblDocNum.StylePriority.UseFont = false;
            this.lblDocNum.Text = "NO#:";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(537.7781F, 10.00001F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.SizeF = new System.Drawing.SizeF(152.2219F, 20.83333F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Orden Compra";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Calibri", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(233.3333F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.SizeF = new System.Drawing.SizeF(237.5F, 32.29166F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "AQUAFEED S.A. DE C.V.";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(132.3101F, 132.3101F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0.8300781F, 213.375F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(84.58659F, 23F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Telefono:";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 190.375F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(85.41667F, 23F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Direccion:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportFooter});
            this.DetailReport.DataMember = "oc_detalle_rpt";
            this.DetailReport.DataSource = this.dsCompras1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel3});
            this.Detail1.HeightF = 23F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel28.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(321.9217F, 0F);
            this.xrLabel28.Multiline = true;
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(104.1203F, 23F);
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total]")});
            this.xrLabel27.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(561.8749F, 0F);
            this.xrLabel27.Multiline = true;
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(137.2903F, 23F);
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "xrLabel27";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[precio]")});
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(426.0419F, 0F);
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(135.833F, 23F);
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[descripcion]")});
            this.xrLabel25.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(86.24665F, 0F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(235.675F, 23F);
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.Text = "xrLabel25";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cantidad]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0.8300781F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(85.41657F, 23F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDescuento,
            this.xrLabel13,
            this.lblGastosAdicionales,
            this.xrLabel11,
            this.lblisv18,
            this.xrLabel8,
            this.lblAPagarLetras,
            this.xrLabel4,
            this.lblSub,
            this.lblTotal,
            this.xrLabel32,
            this.xrLine11,
            this.xrLabel33,
            this.lblIsv15,
            this.xrLabel35,
            this.xrLabel7,
            this.lblComentario});
            this.ReportFooter.HeightF = 155.1665F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblDescuento.LocationFloat = new DevExpress.Utils.PointFloat(602.0664F, 74.16649F);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDescuento.SizeF = new System.Drawing.SizeF(97.09894F, 23F);
            this.lblDescuento.StylePriority.UseFont = false;
            this.lblDescuento.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            this.lblDescuento.Summary = xrSummary1;
            this.lblDescuento.Text = "0.00";
            this.lblDescuento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 74.16649F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(120.8163F, 23.00002F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Descuento";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblGastosAdicionales
            // 
            this.lblGastosAdicionales.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblGastosAdicionales.LocationFloat = new DevExpress.Utils.PointFloat(602.0664F, 97.1665F);
            this.lblGastosAdicionales.Name = "lblGastosAdicionales";
            this.lblGastosAdicionales.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGastosAdicionales.SizeF = new System.Drawing.SizeF(97.09943F, 23.00001F);
            this.lblGastosAdicionales.StylePriority.UseFont = false;
            this.lblGastosAdicionales.StylePriority.UseTextAlignment = false;
            xrSummary2.IgnoreNullValues = true;
            this.lblGastosAdicionales.Summary = xrSummary2;
            this.lblGastosAdicionales.Text = "0.00";
            this.lblGastosAdicionales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 97.1665F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(120.8163F, 23.00002F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Gastos Adicionales";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblisv18
            // 
            this.lblisv18.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblisv18.LocationFloat = new DevExpress.Utils.PointFloat(602.0664F, 51.16647F);
            this.lblisv18.Name = "lblisv18";
            this.lblisv18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblisv18.SizeF = new System.Drawing.SizeF(97.09943F, 23F);
            this.lblisv18.StylePriority.UseFont = false;
            this.lblisv18.StylePriority.UseTextAlignment = false;
            xrSummary3.IgnoreNullValues = true;
            this.lblisv18.Summary = xrSummary3;
            this.lblisv18.Text = "0.00";
            this.lblisv18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 51.16647F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(120.8163F, 23.00002F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Impuesto 18%";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblAPagarLetras
            // 
            this.lblAPagarLetras.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.lblAPagarLetras.LocationFloat = new DevExpress.Utils.PointFloat(71.54177F, 122.1664F);
            this.lblAPagarLetras.Name = "lblAPagarLetras";
            this.lblAPagarLetras.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAPagarLetras.SizeF = new System.Drawing.SizeF(399.2916F, 23.00002F);
            this.lblAPagarLetras.StylePriority.UseFont = false;
            this.lblAPagarLetras.StylePriority.UseTextAlignment = false;
            this.lblAPagarLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 122.1664F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(71.54177F, 23.00002F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "A PAGAR:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblSub
            // 
            this.lblSub.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblSub.LocationFloat = new DevExpress.Utils.PointFloat(602.0664F, 5.166435F);
            this.lblSub.Name = "lblSub";
            this.lblSub.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSub.SizeF = new System.Drawing.SizeF(97.1001F, 23F);
            this.lblSub.StylePriority.UseFont = false;
            this.lblSub.StylePriority.UseTextAlignment = false;
            xrSummary4.IgnoreNullValues = true;
            this.lblSub.Summary = xrSummary4;
            this.lblSub.Text = "0.00";
            this.lblSub.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lblSub.TextFormatString = "{0:L.0.00}";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTotal.LocationFloat = new DevExpress.Utils.PointFloat(602.0663F, 120.1665F);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTotal.SizeF = new System.Drawing.SizeF(97.09949F, 22.99998F);
            this.lblTotal.StylePriority.UseFont = false;
            this.lblTotal.StylePriority.UseTextAlignment = false;
            xrSummary5.IgnoreNullValues = true;
            this.lblTotal.Summary = xrSummary5;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 5.166435F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(120.8163F, 23F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Sub Total";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine11
            // 
            this.xrLine11.LocationFloat = new DevExpress.Utils.PointFloat(602.0664F, 120.1665F);
            this.xrLine11.Name = "xrLine11";
            this.xrLine11.SizeF = new System.Drawing.SizeF(97.09943F, 2F);
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 28.16645F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(120.8163F, 23.00002F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "Impuesto 15%";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblIsv15
            // 
            this.lblIsv15.Font = new DevExpress.Drawing.DXFont("Calibri", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblIsv15.LocationFloat = new DevExpress.Utils.PointFloat(602.0663F, 28.16645F);
            this.lblIsv15.Name = "lblIsv15";
            this.lblIsv15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblIsv15.SizeF = new System.Drawing.SizeF(97.10016F, 23F);
            this.lblIsv15.StylePriority.UseFont = false;
            this.lblIsv15.StylePriority.UseTextAlignment = false;
            xrSummary6.IgnoreNullValues = true;
            this.lblIsv15.Summary = xrSummary6;
            this.lblIsv15.Text = "0.00";
            this.lblIsv15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 120.1665F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(120.8163F, 22.99998F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "TOTAL:";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0.8300781F, 5.166372F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23.00002F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Comentarios:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblComentario
            // 
            this.lblComentario.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblComentario.LocationFloat = new DevExpress.Utils.PointFloat(0.8299987F, 28.16645F);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblComentario.SizeF = new System.Drawing.SizeF(470.0034F, 80.08321F);
            this.lblComentario.StylePriority.UseFont = false;
            this.lblComentario.StylePriority.UseTextAlignment = false;
            this.lblComentario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptOrdenCompra
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsCompras1});
            this.Font = new DevExpress.Drawing.DXFont("Arial; 9.75pt; 8.25pt; 8.25pt; 8.25pt; 8.25pt", 8.25F);
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 50F, 6.25F, 8.333333F);
            this.Version = "23.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.Add(xrWatermark1);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
