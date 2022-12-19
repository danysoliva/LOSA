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
using DevExpress.XtraSplashScreen;
using ACS.Classes;
using System.Threading;

using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Costeo_Formulas : DevExpress.XtraEditors.XtraForm
    {
        #region Variables_Globales
        DataOperations dp = new DataOperations();
        //DataSet CurrentFor = null;
        #endregion

        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        private Double GetCostoPrimo(string FormulaID)
        {
            try
            {
                Double CostoPrimo = 0;
                Double PesoFormula = 0;
                string FixedQuery = @"	SELECT A.[id]
                                              ,A.[mp] AS 'mpid'
		                                      ,B.[codigo]
		                                      ,B.[material]
		                                      ,C.[tipo]
		                                      --,A.[pesokg]
                                              ,A.peso_batch pesokg
	                                      FROM [FML_Ingredientes_v2] A
                                    INNER JOIN [MP_MateriasPrimas] B ON A.[mp] = B.[id]
                                    INNER JOIN [MP_TipoMateriaPrima] C ON B.[tipo] = C.[id]
	                                     WHERE [formula] = " + FormulaID + "";

                DataSet mp = new DataSet();
                mp = dp.ACS_GetSelectData(FixedQuery);

                foreach (DataRow row1 in mp.Tables[0].Rows)
                {
                    PesoFormula += Convert.ToDouble(row1["pesokg"].ToString());
                }

                foreach (DataRow row in mp.Tables[0].Rows)
                {
                    Double Percentage = (Convert.ToDouble(row["pesokg"].ToString()) / PesoFormula);

                    FixedQuery = @" SELECT [valor_tm] AS 'precio'
                                      FROM [MP_UltimoCosto]
                                     WHERE [idMP] = " + row["mpid"].ToString() + "";

                    DataSet Price = new DataSet();
                    Price = dp.ACS_GetSelectData(FixedQuery);

                    Double PrecioMaterial = 0;

                    if (Price.Tables[0].Rows.Count <= 0)
                    {
                        PrecioMaterial = 0;
                    }
                    else if (Price.Tables[0].Rows.Count > 0)
                    {
                        PrecioMaterial = Convert.ToDouble(Price.Tables[0].Rows[0]["precio"].ToString());
                    }

                    CostoPrimo += (PrecioMaterial * Percentage);
                }

                return CostoPrimo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void LoadData()
        {
            try
            {
                DataSet costos = new DataSet();
                DataSet formulas = new DataSet();
                string query = String.Format(@"   
                                    SELECT A.[id]
	                                      ,D.[Descripcion] AS 'especie'
                                          ,CONCAT(A.[codigo], '.', A.[version]) AS 'codigo_formula'
                                          ,A.[nombre] AS 'nombre_formula'
                                          ,Coalesce(C.Codigo,'') AS 'codigo_pt'
		                                  ,Coalesce(C.[Descripcion],'') AS 'nombre_pt'
		                                  ,0.0000 AS 'costo_primo'
		                                  ,Coalesce(C.[Costo],0) AS 'costo_produccion'
		                                  ,0.0000 AS 'costo_total'
                                      FROM [FML_Formulas_v2] A
                                LEFT JOIN [FML_PT] B ON  A.[id] = B.[formula]
                                LEFT JOIN (SELECT A.[id]
			                                      ,A.[Codigo]
			                                      ,A.[Descripcion]
				                                  ,SUM(B.[costo]) AS 'Costo'
		                                      FROM [PT_Productos] A
                                   LEFT OUTER JOIN [PT_Gastos_Valor] B ON A.[id] = B.[idProducto]
			                                 /*WHERE A.[Estado] = 'a'*/
	                                      GROUP BY A.[id]
				                                  ,A.[Codigo]
				                                  ,A.[Descripcion]) C ON B.[pt] = C.[id]
                                INNER JOIN [Conf_Especies] D ON A.especie = D.[id]
                                     WHERE  --[estado] = 'a'
                                            A.id in
                                                (SELECT DISTINCT B.[ext_fml_id]
									                FROM [AQFSVR008\AQFSVR008].[APMS].[dbo].[OP_Batch_Intake_Data_RM] A
									                INNER JOIN [AQFSVR008\AQFSVR008].[APMS].[dbo].[OP_Production_Orders_Main] B
									                ON A.[order_id] = B.[id]
									                WHERE A.[batch_start] Between '{0}' AND '{1}'
								                ) 
                                ", dt_desde.Text.ToString() , dt_hasta.Text.ToString() );
                costos = dp.ACS_GetSelectData(query);

                query = String.Format(@"SELECT [id]
                            FROM [dbo].[FML_Formulas_v2]
                            WHERE  --[estado] = 'a'
                                id in
                                    (SELECT DISTINCT B.[ext_fml_id]
									    FROM [AQFSVR008\AQFSVR008].[APMS].[dbo].[OP_Batch_Intake_Data_RM] A
									    INNER JOIN [AQFSVR008\AQFSVR008].[APMS].[dbo].[OP_Production_Orders_Main] B
									    ON A.[order_id] = B.[id]
									    WHERE A.[batch_start] Between '{0}' AND '{1}'
								    )
                                ", dt_desde.Text.ToString() , dt_hasta.Text.ToString() 
                                );
                formulas = dp.ACS_GetSelectData(query);

                foreach (DataRow row in formulas.Tables[0].Rows) 
                {
                    Double CostoPrimo = GetCostoPrimo(row["id"].ToString());

                    foreach (DataRow frow in costos.Tables[0].Rows) 
                    {
                        if (frow["id"].ToString() == row["id"].ToString()) 
                        {
                            frow["costo_primo"] = CostoPrimo.ToString();
                            frow["costo_total"] = (Convert.ToDouble(frow["costo_produccion"].ToString()) + CostoPrimo).ToString();
                        }
                    }
                }
                grd_data.DataSource = costos.Tables[0];

                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FML_Costeo_Formulas()
        {
            InitializeComponent();
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
        }

        private void btn_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.ShowRibbonPrintPreview();
        }

        private void FML_Costeo_Formulas_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        //-------------------------------------------------------------------------------------------
        private void btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_pdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToPdf(dialog.FileName);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            #region Reservadao para los que pidan rango fecha..
                if ((Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue) ||
                    (dt_desde.EditValue == null || dt_hasta.EditValue == null))) {
                        MessageBox.Show("Rango de fecha no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    } 
            #endregion
            //LoadData();
            LoadData_v2();
        }
        //-------------------------------------------------------------------------------------------


        private void LoadData_v2()
        {
            DataTable dtCostos; // = new DataTable();
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

                dtCostos = dp.ACS_Exec_SP_Get_Data("RPT_FIN_FML_Costeo_Formulas", cmd);
                grd_data.DataSource = dtCostos;
                //grdv_data.DataSource = dtCostos.table;
                grid_autoajustar();
            }
            catch (Exception) { throw; }
        }

        void grid_autoajustar()
        {
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

    }
}