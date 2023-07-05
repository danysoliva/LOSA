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
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using LOSA.Produccion;
using LOSA.RecepcionMP;
using DevExpress.XtraPrinting;

namespace LOSA.Produccion
{
    public partial class frmPrintTarimasRemanente : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmPrintTarimasRemanente()
        {
            InitializeComponent();
            get_existencia_remanante();
        }

        private void get_existencia_remanante()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_existencia_remanente_mp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion2.remanente_tarimas.Clear();
                adat.Fill(dsProduccion2.remanente_tarimas);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            get_existencia_remanante();
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void reposPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsProduccion.remanente_tarimasRow)gridView.GetFocusedDataRow();

            rptReporteIngresoTarima rpttarima = new rptReporteIngresoTarima(row.id_tarima_origen, row.unidades, row.existencia_kg);
            rpttarima.ShowPrintMarginsWarning = false;
            rpttarima.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            rpttarima.ShowPreviewDialog();
        }

       
    }
}