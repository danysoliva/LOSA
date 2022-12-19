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
using DevExpress.XtraSplashScreen;
using LOSA.Clases;

namespace LOSA.MigracionACS.Finanzas.Reports
{
    public partial class RPT_FML_FL_FF_CostVar_MasterDetailReport : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        DataSet datos = new DataSet();
        FMOP fmop = new FMOP();
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string selectedType;
        int selected_local;
        int selected_parent;
        string selected_code;
        DataTable UserGroups;

        #region Developer Defined Methods

        private void load_grid() 
        {
            if (dt_desde.EditValue == null || dt_hasta.EditValue == null) return;
                        try
                        {
                            datos = new DataSet();

                            #region Get Summary
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
            
                            cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.DateTime));
                            cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.DateTime));
                            cmd.Parameters.Add(new SqlParameter("@presicion", SqlDbType.Decimal));
                            cmd.Parameters.Add(new SqlParameter("@ind_costo_ext", SqlDbType.Int));
                            cmd.Parameters.Add(new SqlParameter("@ind_costo_lcl", SqlDbType.Int));
                            cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                            cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                            cmd.Parameters["@presicion"].Value = Convert.ToDouble(txt_Precision.EditValue);
                            cmd.Parameters["@ind_costo_ext"].Value = int.Parse(cmb_CostType_External.SelectedIndex.ToString());
                            cmd.Parameters["@ind_costo_lcl"].Value = int.Parse(cmb_CostType_Local.SelectedIndex.ToString());

                            datos.Tables.Add(dp.ACS_Exec_SP_Get_Data("FM_BI_FL_FF_get_cost_compare_Summary_v2", cmd));
                            #endregion

                            #region Get Detail Structure Only

                            cmd = new SqlCommand();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@local_formula", SqlDbType.BigInt));
                            cmd.Parameters.Add(new SqlParameter("@parent_formula", SqlDbType.BigInt));
                            cmd.Parameters.Add(new SqlParameter("@ind_costo_ext", SqlDbType.Int));
                            cmd.Parameters.Add(new SqlParameter("@ind_costo_lcl", SqlDbType.Int));
                            cmd.Parameters["@local_formula"].Value = -1;
                            cmd.Parameters["@parent_formula"].Value = -1;
                            cmd.Parameters["@ind_costo_ext"].Value = int.Parse(cmb_CostType_External.SelectedIndex.ToString());
                            cmd.Parameters["@ind_costo_lcl"].Value = int.Parse(cmb_CostType_Local.SelectedIndex.ToString());

                            datos.Tables.Add(dp.ACS_Exec_SP_Get_Data("FM_BI_FL_FF_get_cost_compare_Detail_v2", cmd));

                            #endregion

                            #region Generate Detail Data

                            foreach (DataRow row in datos.Tables[0].Rows) 
                            {
                                cmd = new SqlCommand();
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add(new SqlParameter("@local_formula", SqlDbType.BigInt));
                                cmd.Parameters.Add(new SqlParameter("@parent_formula", SqlDbType.BigInt));
                                cmd.Parameters.Add(new SqlParameter("@ind_costo_ext", SqlDbType.Int));
                                cmd.Parameters.Add(new SqlParameter("@ind_costo_lcl", SqlDbType.Int));
                                cmd.Parameters["@local_formula"].Value = int.Parse(row["local_id"].ToString());
                                cmd.Parameters["@parent_formula"].Value = int.Parse(row["parent_id"].ToString());
                                cmd.Parameters["@ind_costo_ext"].Value = int.Parse(cmb_CostType_External.SelectedIndex.ToString());
                                cmd.Parameters["@ind_costo_lcl"].Value = int.Parse(cmb_CostType_Local.SelectedIndex.ToString());

                                DataTable table = dp.ACS_Exec_SP_Get_Data("FM_BI_FL_FF_get_cost_compare_Detail_v2", cmd);

                                foreach(DataRow row2 in table.Rows)
                                {
                                    datos.Tables[1].Rows.Add(row2.ItemArray);
                                }

                                datos.Tables[1].AcceptChanges();
                            }

                            #endregion

                            datos.Tables[0].TableName = "Summary";
                            datos.Tables[1].TableName = "Detail";

                            //datos.Tables["Summary"].Columns["local_id"].DataType = System.Type.GetType("System.Int32");
                            //datos.Tables["Detail"].Columns["formula_id"].DataType = System.Type.GetType("System.Int32");

                            DataColumn idcolumn = datos.Tables["Summary"].Columns["local_id"];
                            DataColumn foreingcolumn = datos.Tables["Detail"].Columns["formula_id"];
                            datos.Relations.Add("FKSummaryDetail", idcolumn, foreingcolumn);

                            //datos.Relations.Add(datos.Tables["NC_Summary"].Columns["h_material_id"], datos.Tables["NC_Detail"].Columns["h_material_id"]);

                            grd_data.DataSource = datos.Tables["Summary"];
                            grd_data.ForceInitialize();

                            grd_data.LevelTree.Nodes.Add("FKSummaryDetail", grdv_Detail);
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Error en carga de datos\nDetalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }  
        }

        #endregion

        public RPT_FML_FL_FF_CostVar_MasterDetailReport(string ActiveUserCode, string ActiveUserName, string ActiveUserType, DataTable UserGroups)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.UserGroups = UserGroups;
        }

        private void btn_generate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue))
            {
                MessageBox.Show("Rango de fecha no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            grd_data.DataSource = null;
            //grdv_Summary.Columns.Clear();
            //grdv_Detail.Columns.Clear();
            load_grid();

            SplashScreenManager.CloseForm();
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

        private void btn_ViewFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formulas.FML_NewFormula_v3 fm = new Formulas.FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "view_cost", selected_local, selected_parent, "FB", UserGroups);
            fm.ShowDialog();
            fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "EVT", "Formula Visualizada");
        }

        private void grdv_Summary_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                ContexMenu.ShowPopup(Cursor.Position);
            }
        }

        private void grdv_Summary_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selected_local = int.Parse(grdv_Summary.GetDataRow(e.FocusedRowHandle)["local_id"].ToString());
                selected_parent = int.Parse(grdv_Summary.GetDataRow(e.FocusedRowHandle)["parent_id"].ToString());
            }
            catch { }
        }
    }
}