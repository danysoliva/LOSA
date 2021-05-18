using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Micro
{
    public partial class frmOpcionesMicro : DevExpress.XtraEditors.XtraForm
    {
        //UserLogin UsuarioLogeado;

        public frmOpcionesMicro()
        {
            InitializeComponent();
            LoadLotes();
            DataOperations dp = new DataOperations();
            dtFechaDesde.EditValue = dp.Now().AddDays(-1);
            dtFechaHasta.EditValue = dp.Now();
            LoadHeader();
        }

        private void LoadLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_micro_ingredientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMicro1.lotes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.lotes);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnNavegacionLote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMicro.lotesRow)gridView.GetFocusedDataRow();

            //rpt_cartillaMicro report = new rpt_cartillaMicro(row.lote_materia_prima);
            //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //ReportPrintTool printReport = new ReportPrintTool(report);
            //printReport.ShowPreview();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadHeader();
        }

        private void LoadHeader()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_generados_micros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHasta.EditValue);
                dsMicro1.sacosh.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.sacosh);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            //Row
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsMicro.sacoshRow)gridView.GetFocusedDataRow();

            LoadDetalle(row.id, row.id_code);
        }

        private void LoadDetalle(int pIdh, int pCode)
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_micros_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pIdh);
                cmd.Parameters.AddWithValue("@idcode", pCode);
                dsMicro1.sacosd.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.sacosd);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}