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
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Finanzas.Reports
{
    public partial class RPT_FML_NC_MasterDetailReport : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        DataSet datos = new DataSet();

        #region Developer Defined Methods

        private void load_grid() 
        {
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

                            datos = new DataSet();

                            datos.Tables.Add(dp.ACS_Exec_SP_Get_Data("RPT_FIN_NC_Summary", cmd));
                            datos.Tables.Add(dp.ACS_Exec_SP_Get_Data("RPT_FIN_NC_Detail", cmd));

                            datos.Tables[0].TableName = "NC_Summary";
                            datos.Tables[1].TableName = "NC_Detail";

                            DataColumn idcolumn = datos.Tables["NC_Summary"].Columns["h_material_id"];
                            DataColumn foreingcolumn = datos.Tables["NC_Detail"].Columns["h_material_id"];
                            datos.Relations.Add("FKSummaryDetail", idcolumn, foreingcolumn);

                            //datos.Relations.Add(datos.Tables["NC_Summary"].Columns["h_material_id"], datos.Tables["NC_Detail"].Columns["h_material_id"]);

                            grd_data.DataSource = datos.Tables["NC_Summary"];
                            grd_data.ForceInitialize();

                            grd_data.LevelTree.Nodes.Add("FKSummaryDetail", grdv_Detail);
                        }
                        catch (Exception) { throw; }  
        }

        #endregion

        public RPT_FML_NC_MasterDetailReport()
        {
            InitializeComponent();
        }

        private void btn_generate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue))
            {
                MessageBox.Show("Rango de fecha no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            grd_data.DataSource = null;
            //grdv_Summary.Columns.Clear();
            //grdv_Detail.Columns.Clear();
            load_grid();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            //if (repositoryItemToggleSwitch1)
            //{
            //    grdv_Summary.OptionsPrint.ExpandAllDetails = false;
            //}
            //else 
            //{
            //    grdv_Summary.OptionsPrint.ExpandAllDetails = true;
            //}
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //grd_data.ExportToXlsx(dialog.FileName);
                grdv_Summary.OptionsPrint.PrintDetails = true;
                grdv_Summary.OptionsPrint.ExpandAllDetails = true;
                grdv_Summary.ZoomView();
                //grdv_Detail.OptionsPrint.PrintDetails = true;
                //grd_data.ExportToXlsx(dialog.FileName);
                grdv_Summary.ExportToXlsx(dialog.FileName);
                //grdv_Detail.ExportToXlsx(dialog.FileName);

                grdv_Summary.OptionsPrint.ExpandAllDetails = false;
                grdv_Summary.NormalView();
            }
        }

        private void btn_exporWYSIWYG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_Summary.OptionsPrint.PrintDetails = true;
                grdv_Summary.ExportToXlsx(dialog.FileName);
            }
        }

        private void grdv_Summary_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }
    }
}