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
using LOSA.RecepcionMP;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System.Threading;

namespace LOSA.Reportes
{
    public partial class frm_print_TM_PT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frm_print_TM_PT()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string Query = @"sp_load_data_tarimas_to_print";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes.tmprint.Clear();
                da.Fill(dsReportes.tmprint);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnTodas_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Desea imprimir todas las tarimas de PT", "Pregunta",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)  == DialogResult.OK)
            {
                foreach (dsReportes.tmprint_ptRow row in dsReportes.tmprint_pt.Rows)
                {
                    rptReporteTarimaPT boleta = new rptReporteTarimaPT(row.id);
                    boleta.ShowPrintMarginsWarning = false;
                    ReportPrintTool printtool = new ReportPrintTool(boleta);
                    printtool.Print();
                }
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_tarimas.FocusedView;
                var row = (dsReportes.tmprint_ptRow)gridview.GetFocusedDataRow();
                rptReporteTarimaPT boleta = new rptReporteTarimaPT(row.id);
                boleta.ShowPrintMarginsWarning = false;
                ReportPrintTool printtool = new ReportPrintTool(boleta);
                printtool.Print();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_imprmir_por_lote_Click(object sender, EventArgs e)
        {
            try
            {
                int ingreso = 0;
                var gridview = (GridView)grd_tarimas.FocusedView;
                var row = (dsReportes.tmprint_ptRow)gridview.GetFocusedDataRow();
                ingreso = row.numero_transaccion;
                foreach (dsReportes.tmprint_ptRow row2 in dsReportes.tmprint.Rows)
                {
                    if (row.lote == row2.lote)
                    {
                        rptReporteTarimaPT boleta = new rptReporteTarimaPT(row2.id);
                        boleta.ShowPrintMarginsWarning = false;
                        ReportPrintTool printtool = new ReportPrintTool(boleta);
                        printtool.Print();
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}