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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using LOSA.Reportes;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frm_detalle_liquidos_tarima : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int numero_ingreso;
        UserLogin UsuarioLogeado;
        string itemcode;

        public frm_detalle_liquidos_tarima(int pnumero_ingreso, UserLogin pUserLogin, string pItemcode)
        {
            InitializeComponent();
            numero_ingreso = pnumero_ingreso;
            UsuarioLogeado = pUserLogin;
            itemcode = pItemcode;

            load_data();
            LoadTarimas();
        }
        public void LoadTarimas()
        {
            string SqlCommandSp = @"[ps_obtener_tarimas_de_ingreso_liquidos]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SqlCommandSp, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_referencia", numero_ingreso);
                //cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
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

        private void load_data()
        {
            //string Query = @"sp_load_resumen_ingreso_granel
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand("[sp_load_resumen_ingreso_liquidos]", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_ingreso", numero_ingreso);
                dsingresos1.ingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsingresos1.ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repostPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd_data.FocusedView;
            var row = (dsingresos.ingresoRow)gridview.GetFocusedDataRow();
            bool is_tarima_liquido = false;
            int id_tipo_ingreso = 4;

            if (is_tarima_liquido == true)
            {
                //Vamos a Imprimir Rotulo de Tarima
            }
            else
            {
                //Vamos a Imprimir Rotulo de Lote por el Ingreso
                try
                {
                    rptLoteRotulo report = new rptLoteRotulo(numero_ingreso, is_tarima_liquido, id_tipo_ingreso);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);
                    printReport.ShowPreview();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }

            

        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //imprimir
            var gridView = (GridView)grd_data_tarima.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            bool Error = false;
            string mensaje = " ";

            if (row.id_materia_prima == 1101 || row.id_materia_prima == 1110)
            {
                Reproceso.rptTarimaReproceso boleta = new Reproceso.rptTarimaReproceso(row.id);
                boleta.ShowPrintMarginsWarning = false;
                boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                boleta.ShowPreviewDialog();
            }
            else
            {
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

                rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(row.id);
                boleta.ShowPrintMarginsWarning = false;
                boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                boleta.Print();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void reportPrinCartilla_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_data.FocusedView;
                var row = (dsingresos.ingresoRow)gridview.GetFocusedDataRow();
                rpt_cartilla report = new rpt_cartilla(row.ingreso, row.lote);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}