using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.TemperaturaMaquinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.Produccion.Silos
{
    public partial class frmSilosReporteHumedades : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmSilosReporteHumedades(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            load_data();
        }

        public void load_data()
        {
            string query = @"dbo.[sp_get_turnos_registros_eficiencia]";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura1.turnos.Clear();
                da.Fill(dsTemperatura1.turnos);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dsTemperatura.turnosRow row = null;
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                row = (dsTemperatura.turnosRow)gridView.GetFocusedDataRow();
            }
            catch 
            {

            }
            LoadDetalleReporte(row.f_inicio, row.f_fin);
        }

        private void LoadDetalleReporte(DateTime pDesde, DateTime pHasta)
        {
            string query = @"dbo.sp_get_reporte_silos_kps";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", pDesde);
                cmd.Parameters.AddWithValue("@hasta", pHasta);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTemperatura1.detalle_silos.Clear();
                da.Fill(dsTemperatura1.detalle_silos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Detalle Silos";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl2.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Ex from ALOSY";

                    gridControl2.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}