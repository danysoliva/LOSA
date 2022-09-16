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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Logistica;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.RecepcionMP;

namespace LOSA.Reproceso
{
    public partial class frmReprocesoPrint : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmReprocesoPrint(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            radioGroup1.EditValue = 1110;
            
            LoadData();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("[sp_get_tarimas_PT_reproceso]", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id_mp", radioGroup1.EditValue);
                dsLogistica21.PT_Reproceso_Tarimas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                adat.Fill(dsLogistica21.PT_Reproceso_Tarimas);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void btnPrintSeleccionados_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;

            int contador_print = 0;
            rptTarimaReproceso reportResumen = null;
            //for (int i = 0; i < gridView.RowCount; i++)
            foreach(dsLogistica2.PT_Reproceso_TarimasRow row in dsLogistica21.PT_Reproceso_Tarimas)
            {
                //var row = (dsLogistica2.PT_Reproceso_TarimasRow)gridView.GetDataRow(i);

                //bool Error = false;
                //string mensaje = " ";
                //switch (row.id_estado_tarima)
                //{
                //    case 1://Recepcionado
                //        Error = false;
                //        break;
                //    case 2://En Bodega
                //        Error = false;
                //        //mensaje = "Calidad tiene En Observación ésta tarima.!";
                //        break;
                //    case 3://Retenido
                //        Error = false;
                //        break;
                //    case 4://Comprometido
                //        Error = true;
                //        mensaje = "Algunas tarima ya esta comprometida!";
                //        break;
                //    case 5://En Produccion
                //        Error = true;
                //        mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                //        break;
                //    case 6://Consumido
                //        Error = true;
                //        mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                //        break;
                //    //case 7://
                //    //    error = true;
                //    //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                //    //    break;
                //    case 8://Parcialmente Entregado
                //        Error = false;
                //        //mensaje = "Calidad ha Rechazado ésta tarima.!";
                //        break;
                //    case 9://Rechazado
                //        Error = true;
                //        mensaje = "Esta tarima fue Rechazada!";
                //        break;
                //    case 10://Ajuste de Inventario
                //        Error = true;
                //        mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                //        break;
                //}

                //if (Error)
                //{
                //    CajaDialogo.Error(mensaje);
                //    return;
                //}

                if (row.seleccionado == true)
                {
                    if (row.id > 0)
                    {
                        Tarima tar1 = new Tarima();
                        if (tar1.RecuperarRegistro(row.id))
                        {
                            if (contador_print == 0)
                            {
                                reportResumen = new rptTarimaReproceso(row.id);
                                reportResumen.CreateDocument();
                                contador_print++;
                            }
                            else
                            {
                                // Create the second report and generate its document.
                                rptTarimaReproceso report2 = new rptTarimaReproceso(row.id);
                                report2.CreateDocument();

                                if (reportResumen != null)
                                {
                                    // Add all pages of the second report to the end of the first report.
                                    reportResumen.ModifyDocument(x => { x.AddPages(report2.Pages); });
                                }
                            }
                        }
                    }//if row.id>0
                }//if seleccionado is true
            }//For
            if (reportResumen != null)
            {
                using (ReportPrintTool printTool = new ReportPrintTool(reportResumen))
                {
                    printTool.ShowPreviewDialog();
                }
            }
        }

      

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void repositoryItemButtonImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsLogistica2.PT_Reproceso_TarimasRow)gridview.GetFocusedDataRow();

            DateTime dtFechaNull = Convert.ToDateTime("1/1/1901 15:00:00");

            if (row.fecha_produccion_materia_prima == dtFechaNull)
            {
                CajaDialogo.Error("La fecha de Produccion Materia Prima debe ser cambiada! Solicite a Calidad el Cambio de la Fecha de Produccion");
                return;
            }

            rptTarimaReproceso report = new rptTarimaReproceso(row.id);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void gvPT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "seleccionado")
            {
                if (Convert.ToBoolean(e.Value))
                {
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsLogistica2.PT_Reproceso_TarimasRow)gridView.GetFocusedDataRow();

                    if(row.fecha_produccion_materia_prima.Date.Year <= 1901)
                    {
                        CajaDialogo.Error("La fecha de Producción no es valida! Es necesario actualizar este Dato...");
                        row.seleccionado = false;
                        return;
                    }

                    if (row.fecha_vencimiento.Date.Year <= 1901)
                    {
                        CajaDialogo.Error("La fecha de Vencimiento no es valida! Es necesario actualizar este Dato...");
                        row.seleccionado = false;
                        return;
                    }
                }
            }
        }

        private void repositoryEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsLogistica2.PT_Reproceso_TarimasRow)gridView.GetFocusedDataRow();

           

            switch (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Logistica:
                    CajaDialogo.Error("No esta autorizado, Solo Calidad puede Editar Tarimas de Reproceso");
                    break;

                case GrupoUser.GrupoUsuario.Calidad:
                    //Ventana de Editar Tarima
                    frmEditarTarimaReproceso frm = new frmEditarTarimaReproceso(row.id, this.UsuarioLogeado);
                    //frmEditTarima frm = new frmEditTarima(row.id, this.UsuarioLogeado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                   
                    break;

                default:
                    break;

            }
        }
    }
}