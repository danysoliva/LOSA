using DevExpress.XtraEditors;
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
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.TransaccionesMP
{
    public partial class frmMontaCargaTarimaResumen : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string ItemCode;
        public int Id_MP;

        public frmMontaCargaTarimaResumen()
        {
            InitializeComponent();
            
        }

        private void LoadTarimas()
        {
            string SqlCommandSp = @"[sp_obtener_tarimas_por_materia_prima]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SqlCommandSp, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_materia_prima",Id_MP);
                dsRecepcionMPx1.lista_tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsRecepcionMPx1.lista_tarimas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtMP_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (this.MdiParent != null)
            {
                //frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.MateriaPrima;
                ItemCode = frm.ItemCode;
                Id_MP = frm.id_mp;
            }
            LoadTarimas();
        }

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //IMPRIMIR A LOGISTICA
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            bool Error = false;
            string mensaje = " ";
            switch (row.id_estado_tarima)
            {
                case 1://Recepcionado
                    Error = false;
                    break;
                case 2://En Bodega
                    Error = false;
                    //mensaje = "Calidad tiene En Observación ésta tarima.!";
                    break;
                case 3://Retenido
                    Error = false;
                    break;
                case 4://Comprometido
                    Error = true;
                    mensaje = "Esta tarima ya esta comprometida!";
                    break;
                case 5://En Produccion
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                    break;
                case 6://Consumido
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                    break;
                //case 7://
                //    error = true;
                //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                //    break;
                case 8://Parcialmente Entregado
                    Error = false;
                    //mensaje = "Calidad ha Rechazado ésta tarima.!";
                    break;
                case 9://Rechazado
                    Error = true;
                    mensaje = "Esta tarima fue Rechazada!";
                    break;
                case 10://Ajuste de Inventario
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                    break;
            }

            if (Error)
            {
                CajaDialogo.Error(mensaje);
                return;
            }
            rptReporteIngresoTarima tarimaprint = new rptReporteIngresoTarima(row.id);
            tarimaprint.ShowPrintMarginsWarning = false;
            //boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            tarimaprint.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            Tarima tari1 = new Tarima();
            tarimaprint.PrinterName = tari1.GetPrinterNameLogistica();//Falta el SP 
            ReportPrintTool printTool = new ReportPrintTool(tarimaprint);
            printTool.Print();

            CajaDialogo.Information("IMPRESION ENVIADA A IMPRESORA DE LOGISTICA TARIMA CON CODIGO:" + row.codigo_barra);
        }

        private void btnImprimirConsola_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //IMPRIMIR A CONSOLA
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            bool Error = false;
            string mensaje = " ";
            switch (row.id_estado_tarima)
            {
                case 1://Recepcionado
                    Error = false;
                    break;
                case 2://En Bodega
                    Error = false;
                    //mensaje = "Calidad tiene En Observación ésta tarima.!";
                    break;
                case 3://Retenido
                    Error = false;
                    break;
                case 4://Comprometido
                    Error = true;
                    mensaje = "Esta tarima ya esta comprometida!";
                    break;
                case 5://En Produccion
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                    break;
                case 6://Consumido
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                    break;
                //case 7://
                //    error = true;
                //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                //    break;
                case 8://Parcialmente Entregado
                    Error = false;
                    //mensaje = "Calidad ha Rechazado ésta tarima.!";
                    break;
                case 9://Rechazado
                    Error = true;
                    mensaje = "Esta tarima fue Rechazada!";
                    break;
                case 10://Ajuste de Inventario
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                    break;
            }

            if (Error)
            {
                CajaDialogo.Error(mensaje);
                return;
            }

            rptReporteIngresoTarima tarimaprint = new rptReporteIngresoTarima(row.id);
            tarimaprint.ShowPrintMarginsWarning = false;
            //boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            tarimaprint.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            Tarima tari1 = new Tarima();
            tarimaprint.PrinterName = tari1.GetPrinterNameConsola();
            ReportPrintTool printTool = new ReportPrintTool(tarimaprint);
            printTool.Print();

            CajaDialogo.Information("IMPRESION ENVIADA A IMPRESORA DE CONSOLA TARIMA CON CODIGO:" + row.codigo_barra);
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}