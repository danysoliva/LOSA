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
using LOSA.Reportes;
using DevExpress.XtraReports.UI;

namespace LOSA.RecepcionMP
{
    public partial class frmverlotes : DevExpress.XtraEditors.XtraForm
    {
        private int id_ingreso;
        DataOperations dp = new DataOperations();
        public frmverlotes(int Pingreso)
        {                   
            InitializeComponent();
            Id_ingreso = Pingreso;
            load_data();
        }
            public void load_data()
        {
            string Query = @"sp_load_lotes_to_print";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", Id_ingreso);
                dsingresos.lote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsingresos.lote);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }
        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_data.FocusedView;
                var row = (dsingresos.loteRow)gridview.GetFocusedDataRow();
                rpt_cartilla report = new rpt_cartilla(row.id);               
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception)
            {

                
            }
        }

        private void btnImprimirTodas_Click(object sender, EventArgs e)
        {
            foreach (dsingresos.loteRow row in dsingresos.lote.Rows)
            {
             
              

                rptLoteRotulo boleta = new rptLoteRotulo(row.id);
                boleta.ShowPrintMarginsWarning = false;
                boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint); 
                boleta.Print(); 
            }
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }
    }
}