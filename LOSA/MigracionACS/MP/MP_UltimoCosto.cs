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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.OleDb;
using System.Threading;
using LOSA.MigracionACS.MP;

namespace ACS.MP
{
    public partial class MP_UltimoCosto : DevExpress.XtraEditors.XtraForm
    {
        DataSet CostData;
        string file_name;

        #region Developer Defined Fuctions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        private void LoadData()
        {
            try
            {
                string Query = @"	SELECT A.[id]
		                                  ,A.[idMP]
		                                  ,B.[codigo]
										  ,coalesce(B.code_sap, 'No configurado en SAP') as code_sap
		                                  ,B.[material]
		                                  ,A.[mes]
		                                  ,A.[anio]
		                                  ,/*A.[cant_tm]*/ 1 AS 'cant_tm'
		                                  ,A.[valor_tm]
		                                  ,A.[costoxtm]
		                                  ,A.[cant_kg]
		                                  ,A.[costoxkg]
		                                  ,A.[tasa]
                                      FROM [MP_UltimoCosto] A
                                INNER JOIN [MP_MateriasPrimas] B ON B.[id] = A.[idMP]
                                INNER JOIN [MP_TipoMateriaPrima] C ON B.[tipo] = C.[id]
							where b.estado = 'a' ";
                DataOperations dp = new DataOperations();
                CostData = new DataSet();

                CostData = dp.ACS_GetSelectData(Query);

                grd_Costos.DataSource = CostData.Tables[0];

                grid_autoajustar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateInfo() 
        {
            try
            {
                DataOperations dp = new DataOperations();
                string doaction = "";

                if (CostData.Tables[0].Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Seguro que desea cargar una nueva plantilla?\n\nEsta acción eliminara la informacion anterior del costo de la materia prima.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        dp.ACS_DoSmallDBOperation("DELETE FROM [MP_UltimoCosto]");
                        doaction = "yes";
                    }
                }
                else 
                {
                    if (MessageBox.Show("¿Seguro que desea cargar una nueva plantilla?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        doaction = "yes";
                    }
                }

                if (doaction == "yes") 
                {
                    string Query = @"SELECT [id]
                                       FROM [MP_MateriasPrimas]
                                       WHERE estado= 'a' ";
                    DataSet materials = new DataSet();
                    
                    int progress = 0;

                    materials = dp.ACS_GetSelectData(Query);

                    repositoryItemProgressBar1.Maximum = materials.Tables[0].Rows.Count;
                    repositoryItemProgressBar1.Minimum = 0;

                    foreach (DataRow row in materials.Tables[0].Rows) 
                    {
                        string fixedquery = @"INSERT INTO [MP_UltimoCosto]
			                                              ([idMP]
			                                              ,[mes]
			                                              ,[anio]
			                                              ,[cant_tm]
			                                              ,[valor_tm]
			                                              ,[costoxtm]
			                                              ,[cant_kg]
			                                              ,[costoxkg]
			                                              ,[tasa])
		                                            VALUES (" + row[0].ToString() + @"
			                                               ," + txt_Mes.EditValue.ToString() + @"
			                                               ," + txt_Anio.EditValue.ToString() + @"
			                                               ,0.0000
			                                               ,0.0000
			                                               ,0.0000
			                                               ,0.0000
			                                               ,0.0000
			                                               ," + txt_tasaCambio.EditValue.ToString() + ")";

                        dp.ACS_DoSmallDBOperation(fixedquery);

                        progress++;
                        bar_progress.EditValue = progress.ToString();
                        txt_status.Caption = progress.ToString() + " de " + materials.Tables[0].Rows.Count.ToString() + " registros procesados";
                    }

                    txt_status.Caption = "Listo...";
                    btnt_save.Enabled = true;
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInfo() 
        {
            try
            {
                DataOperations dp = new DataOperations();

                if (MessageBox.Show("¿Seguro que desea guardar los datos?\n\nEstos afectan el costo primo de las formulas y precio del producto terminado.", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) 
                {
                    foreach(DataRow row in CostData.Tables[0].Rows) 
                    {
                        string UpdateQuery = @" UPDATE [MP_UltimoCosto]
                                                   SET [cant_tm] = " + row["cant_tm"].ToString() + @"
		                                              ,[valor_tm] = " + row["valor_tm"].ToString() + @"
		                                              ,[costoxtm] = " + row["costoxtm"].ToString() + @"
		                                              ,[cant_kg] = " + row["cant_kg"].ToString() + @"
		                                              ,[costoxkg] = " + row["costoxkg"].ToString() + @"
                                                 WHERE [id] = " + row["id"].ToString() + @"";

                        dp.ACS_DoSmallDBOperation(UpdateQuery);
                    }

                    MessageBox.Show("Operacion Finalizada sin problemas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidFields() 
        {
            if (txt_Anio.EditValue != null && txt_Mes.EditValue != null && txt_tasaCambio.EditValue != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        #endregion

        public MP_UltimoCosto()
        {
            InitializeComponent();
            GetAllowSkin();
        }

        private void MP_UltimoCosto_Load(object sender, EventArgs e)
        {
            LoadData();

            if (CostData.Tables[0].Rows.Count == 0)
            {
                btn_loadPlantilla.Enabled = false;
                btnt_save.Enabled = false;
            }
            else 
            {
                txt_Mes.EditValue = CostData.Tables[0].Rows[0]["mes"].ToString();
                txt_Anio.EditValue = CostData.Tables[0].Rows[0]["anio"].ToString();
                txt_tasaCambio.EditValue = CostData.Tables[0].Rows[0]["tasa"].ToString();
            }

            if (ValidFields())
            {
                btn_loadPlantilla.Enabled = true;
                //btnt_save.Enabled = true;
            }
        }

        private void txt_Mes_EditValueChanged(object sender, EventArgs e)
        {
            if (ValidFields()) 
            {
                btn_loadPlantilla.Enabled = true;
                //btnt_save.Enabled = true;
            }
        }

        private void txt_Anio_EditValueChanged(object sender, EventArgs e)
        {
            if (ValidFields())
            {
                btn_loadPlantilla.Enabled = true;
                //btnt_save.Enabled = true;
            }
        }

        private void txt_tasaCambio_EditValueChanged(object sender, EventArgs e)
        {
            if (ValidFields())
            {
                btn_loadPlantilla.Enabled = true;
                btnt_save.Enabled = true;
            }
        }

        private void grdv_Costos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRow row = grdv_Costos.GetDataRow(e.RowHandle);
            if (decimal.Parse(row["cant_tm"].ToString()) > 0)
            {
                row["costoxtm"] = (decimal.Parse(row["valor_tm"].ToString()) / decimal.Parse(row["cant_tm"].ToString()));
            }
            else 
            {
                row["costoxtm"] = (decimal.Parse(row["valor_tm"].ToString()) / 1);
            }
            row["cant_kg"] = (decimal.Parse(row["cant_tm"].ToString()) * 1000);
            row["costoxkg"] = (decimal.Parse(row["costoxtm"].ToString()) / 1000);
        }

        private void btnt_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateInfo();
            LoadData();
        }

        private void btn_NewList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //GenerateInfo();
            MP_MnY datarequest = new MP_MnY();
            datarequest.ShowDialog();
        }

        private void btn_ActualizarCostProm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MP.MP_UltimoCosto_Prompt frm = new MP.MP_UltimoCosto_Prompt();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LoadData();
        }

        private void btn_ExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_Costos.ExportToXlsx(dialog.FileName);
            }

        }

        void grid_autoajustar()
        {
            grdv_Costos.OptionsView.ColumnAutoWidth = false;
            grdv_Costos.BestFitColumns();
            GridViewInfo viewInfo = grdv_Costos.GetViewInfo() as GridViewInfo;
            if (viewInfo.ViewRects.ColumnTotalWidth < viewInfo.ViewRects.ColumnPanelWidth)
                grdv_Costos.OptionsView.ColumnAutoWidth = true;
        }

        private void grdv_Costos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Seleccione el archivo importado anteriormente";
                DSMP dSMP1 = new DSMP();
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Sheet$]", con);
                    dSMP1.LoadExcel.Clear();
                   
                    SplashForm frmProceso = new SplashForm();
                    try
                    {
                        myCommand.Fill(dSMP1.LoadExcel);
                        foreach (DataRow row in CostData.Tables[0].Rows)
                        {
                            foreach (DataRow row2 in dSMP1.LoadExcel.Rows)
                            {
                                if (row["id"].ToString() == row2["ID"].ToString())
                                {
                                    row["valor_tm"] = row2["Costo Promedio"];
                                }
                            }
                        }
                        CostData.Tables[0].AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                    int TiempoP = 450;
                    frmProceso.ShowDialog();
                    Thread.Sleep(TiempoP);
                    frmProceso.Close();


                }


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}