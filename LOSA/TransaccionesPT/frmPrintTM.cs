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
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using DevExpress.XtraReports.UI;
using LOSA.Produccion;

namespace LOSA.TransaccionesPT
{
    public partial class frmPrintTM : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmPrintTM(UserLogin Puser)
        {
            InitializeComponent();

            Loda_data();
            UsuarioLogeado = Puser;
        }

        public void Loda_data()
        {
            string Query = @"sp_load_plan_produccion";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.loadplanes.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.loadplanes);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string error ="";
            try
            {
                if (MessageBox.Show("Desea imprimir las hojas de esta orden de entrega", "Desea imprimir las hojas de esta orden de entrega?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.loadplanesRow)gridView.GetFocusedDataRow();

                error = "Get data row from view grid control";
                string query = @"sp_first_20_to_print";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Alimentacion", row.id);
                dsPT.load_tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.load_tarimas);
                cn.Close();


                if (dsPT.load_tarimas.Rows.Count < 0)
                {
                    CajaDialogo.Error("Ya se han impreso todas las teorias.");
                    return;
                }
                error = "Before foreach";
                foreach (dsPT.load_tarimasRow row2 in dsPT.load_tarimas.Rows)
                {
                    error = "In Foreach";
                    rptReporteTarimaPT boleta = new rptReporteTarimaPT(row2.id);
                    boleta.ShowPrintMarginsWarning = false;
                    ReportPrintTool printtool = new ReportPrintTool(boleta);
                    printtool.Print();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message + " Ademas considera el error en: " + error);
            }
        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnver_Click(object sender, EventArgs e)
        {

            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.loadplanesRow)gridView.GetFocusedDataRow();
            frm_vertarimas_pt frm = new frm_vertarimas_pt(UsuarioLogeado, row.id);
            frm.ShowDialog();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.loadplanesRow)gridView.GetFocusedDataRow();
                frmGenerarTarimas frm = new frmGenerarTarimas(row.id);
                frm.Show();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}