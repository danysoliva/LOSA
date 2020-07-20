using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System.Threading;
using LOSA.Clases;

namespace LOSA.RecepcionMP
{
    public partial class frmGestionIngresosTarimas : DevExpress.XtraEditors.XtraForm
    {
        public frmGestionIngresosTarimas(int pIngreso)
        {
            InitializeComponent();
            txtNumeroIngreso.Text = pIngreso.ToString();
            LoadData();
        }

        private void LoadData()
        {
            //if (dtFechaDesde.EditValue != null && dtFechaHasta.EditValue != null)
            //{
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_get_detalle_tarimas_by_numero_transaccion", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id_ingreso", txtNumeroIngreso.Text);
                    //cmm2.Parameters.AddWithValue("@fhasta", dtFechaHasta.EditValue);

                    dsRecepcionMPx1.lista_tarimas.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsRecepcionMPx1.lista_tarimas);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            //}
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            //impresion de todas las hojas de ingreso
            DialogResult r = CajaDialogo.Pregunta("Realmente desea Imprimir todas las horas de las tarimas de este Ingreso?");
            if (r != DialogResult.Yes)
            {
                return;
            }


            int conta = 0;
            foreach(dsRecepcionMPx.lista_tarimasRow row in dsRecepcionMPx1.lista_tarimas.Rows)
            {
                Thread.Sleep(300);
                rptReporteIngresoTarima report = new rptReporteIngresoTarima(row.id);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.Print();
                conta++;
            }

            CajaDialogo.Information("Se enviaron correctamente las " + conta + " hojas de ingreso a Imprimir!");
            //var gridView = (GridView)grd_ingreso.FocusedView;
            //var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            //rptReporteIngresoTarima report = new rptReporteIngresoTarima(row.id);
            //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //ReportPrintTool printReport = new ReportPrintTool(report);
            //printReport.ShowPreview();
        }

        private void cmdAnular_Click(object sender, EventArgs e)
        {
            //Anular ingreso
            int contador = 0;
            foreach (dsRecepcionMPx.lista_tarimasRow row in dsRecepcionMPx1.lista_tarimas.Rows)
            {
                Ubicacion_Tarima ubt = new Ubicacion_Tarima();
                if (ubt.RecuperarRegistro(row.id,""))
                {
                    //Vamos a verificar el id de la bodega
                    if(ubt.IdBodega != 9)//El id 9 es la bodega 500
                    {
                        contador++;
                    }
                }
            }

            //Si hay al menos una tarima distinta a la bodega 500 no podemos permitir la anulacion.
            if (contador > 0)
            {
                CajaDialogo.Error("Solo se puede anular un ingreso si todas las tarimas aun estan en la bodega 500!");
                return;
            }

            //Si pasa esa validacion podemos continuar con la anulacion de las tarimas y el ingreso.
            DialogResult r = CajaDialogo.Pregunta("Realmente desea Anular este ingreso y todas sus Tarimas?");
            if(r!= DialogResult.Yes)
            {
                return;
            }

            //Anulacion de tarimas y de ingreso.
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_update_anular_tarimas_e_ingresos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_ingreso", txtNumeroIngreso.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                CajaDialogo.Information("El Ingreso, Lotes y Tarimas fueron Anulados con Exito!");
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


        }








    }//end public partial class
}