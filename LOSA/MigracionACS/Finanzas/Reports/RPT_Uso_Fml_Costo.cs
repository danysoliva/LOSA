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
using System.IO;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using LOSA.Clases;

namespace LOSA.MigracionACS.Finanzas.Reports
{
    public partial class Rep_Fml_Uso : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Globales
        // string ActiveUserCode;
        DataOperations dp = new DataOperations();
        DataTable dtDatos;
        
        FMOP fmop = new FMOP();
        #endregion

        public Rep_Fml_Uso()
        {
            InitializeComponent();

            #region Screen Selection
            if (Screen.AllScreens.Count() > 1)
            {
                switch (Screen.AllScreens.Count())
                {
                    case 2:
                        this.Location = Screen.AllScreens[1].WorkingArea.Location;
                        break;
                    case 3:
                        this.Location = Screen.AllScreens[2].WorkingArea.Location;
                        break;
                    case 4:
                        this.Location = Screen.AllScreens[3].WorkingArea.Location;
                        break;
                    case 5:
                        this.Location = Screen.AllScreens[5].WorkingArea.Location;
                        break;
                    case 6://Configuración Actual Consola
                        this.Location = Screen.AllScreens[4].WorkingArea.Location;
                        break;
                }
            }
            #endregion
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_GenReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue)) {
                MessageBox.Show("Rango de fecha no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //grd_data.DataSource = null;
            //grdv_data.Columns.Clear();
            //cargar_grid();
            //---------------------------
            pnl_barra.Visible = true; btn_GenReport.Enabled = btn_Exportar.Enabled = btn_Impresion.Enabled = pnl_parametros.Enabled = false;
            //---------------------------
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
            //---------------------------
        }


        void cargar_grid(){
            if (dt_desde.EditValue == null || dt_hasta.EditValue == null) return;
            try
            {
                #region Parametros_SP_Entrada
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.DateTime));
                cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                #endregion

                dtDatos = dp.ACS_Exec_SP_Get_Data("RPT_FIN_Uso_Formulas_Cost_v2", cmd);
                //grd_data.DataSource = dtDatos;
                //grid_autoajustar();
            }
            catch (Exception) { throw; }       
        }

        private void btn_bajarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }

        }


        private void btn_bajarPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToPdf(dialog.FileName);
            }
        }
        

        private void btn_Imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.PrintDialog();
        }

        private void btn_ImprimirPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.ShowPrintPreview();
        }

        void grid_autoajustar() {
            grdv_data.OptionsView.ColumnAutoWidth = false;
            grdv_data.BestFitColumns();
            GridViewInfo viewInfo = grdv_data.GetViewInfo() as GridViewInfo;
            if (viewInfo.ViewRects.ColumnTotalWidth < viewInfo.ViewRects.ColumnPanelWidth)
                grdv_data.OptionsView.ColumnAutoWidth = true;        
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        //-----------------------
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            cargar_grid();
            //Thread.Sleep(10000);
        }
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnl_barra.Visible = false; btn_GenReport.Enabled = btn_Exportar.Enabled = btn_Impresion.Enabled = pnl_parametros.Enabled = true;
            grd_data.DataSource = dtDatos;
            grid_autoajustar();
        }
        //-----------------------

    }
}