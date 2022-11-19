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

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Formulas : DevExpress.XtraEditors.XtraForm
    {
        string selID = null;
        string selFormula = null;

        public string ActiveUSerCode { get; set; }
        public string ActiveUSerType { get; set; }

        DataOperations dp = new DataOperations();

        //public string selectedID = null;

        #region Developer Defined Functions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        private void UpdateStatus(string status)
        {
            try
            {
                string Query = @"   UPDATE [FML_Formulas]
                                       SET [estado] = '" + status + @"'
                                     WHERE [id] = " + selID + "";

                DataOperations dp = new DataOperations();

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string FixedQuery = @"  SELECT A.[id]
		                                      ,A.[codigo]
		                                      ,A.[version]
		                                      ,A.[nombre]
		                                      ,B.[Descripcion]
		                                      ,A.[fechaC]
		                                      ,C.[nombre]
		                                      ,(CASE A.[estado] WHEN 'a' THEN 'Activo' WHEN 'f' THEN 'Forecast' WHEN 'p' THEN 'Produccion' ELSE 'Inactivo' END) AS 'estado'
                                          FROM [FML_Formulas] A
                                    INNER JOIN [Conf_Especies] B ON A.[Especie] = B.[id]
                                    INNER JOIN [Conf_Usuarios] C ON A.[CreadoX] = C.[id]";

                if (ActiveUSerType == "ca" || ActiveUSerType == "cu") 
                {
                    FixedQuery += " WHERE A.[estado] <> 'f' AND A.[estado] <> 'p'";
                }
                else if (ActiveUSerType == "fa") 
                {
                    FixedQuery += " WHERE A.[estado] = 'f'";
                }
                else if (ActiveUSerType == "pr")
                {
                    FixedQuery += " WHERE A.[estado] = 'p'";
                }
                grd_formula.DataSource = dp.ACS_GetSelectData(FixedQuery).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnEdit() 
        {
            FML_NewFormula fm = new FML_NewFormula();
            fm.action = "edit";
            fm.selectedID = selID;
            fm.ActiveUSerCode = ActiveUSerCode;
            fm.ActiveUSerType = ActiveUSerType;
            if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadData();
            }
        }

        #endregion

        public FML_Formulas()
        {
            InitializeComponent();
        }

        private void btn_inactivate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatus("i");
            LoadData();
        }

        private void btn_activate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateStatus("a");
            LoadData();
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_NewFormula fm = new FML_NewFormula();
            fm.action = "new";
            fm.ActiveUSerCode = ActiveUSerCode;
            fm.ActiveUSerType = ActiveUSerType;
            if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                LoadData();
            }
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnEdit();
        }

        private void FML_Formulas_Load(object sender, EventArgs e)
        {
            LoadData();
            if (ActiveUSerType == "fa" || ActiveUSerType == "pr") 
            {
                btn_activate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_inactivate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (selID == null) 
            {
                btn_edit.Enabled = false;
                btn_activate.Enabled = false;
                btn_inactivate.Enabled = false;
                btn_copy.Enabled = false;
            }
        }

        private void grdv_formula_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try 
            {
                if (grdv_formula.GetDataRow(e.FocusedRowHandle)["estado"].ToString() == "Activo")
                {
                    btn_inactivate.Enabled = true;
                    btn_activate.Enabled = false;
                }
                else
                {
                    btn_activate.Enabled = true;
                    btn_inactivate.Enabled = false;
                }

                selID = grdv_formula.GetDataRow(e.FocusedRowHandle)["id"].ToString();
                selFormula = grdv_formula.GetDataRow(e.FocusedRowHandle)["nombre"].ToString();

                if (selID != null)
                    btn_edit.Enabled = true; btn_copy.Enabled = true;
            }
            catch
            {
            
            }
        }

        private void grdv_formula_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void btn_copy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea hacer una copia de la formula " + selFormula + "?\n\nLa información de esta podra ser modificada a excepción de la especie a la cual pertenece.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
            {
                try
                {
                    string InsertedID = "";
                    DataSet header = new DataSet();
                    DataSet pt = new DataSet();
                    DataSet mp = new DataSet();

                    /*************************Get the header of the selected formula****************************/
                    string FixedQuery = @"  SELECT [codigo]
                                                  ,[nombre]
                                                  ,[especie]
                                                  ,[comentario]
                                              FROM [FML_Formulas]
                                             WHERE [id] = " + selID + "";
                    header = dp.ACS_GetSelectData(FixedQuery);

                    /*******************Get the end product related to the selected formula********************/
                    FixedQuery = @" SELECT [pt]
                                      FROM [FML_PT]
                                     WHERE [formula] = " + selID + "";
                    pt = dp.ACS_GetSelectData(FixedQuery);


                    /*******************Get the raw material related to the selected formula********************/
                    FixedQuery = @" SELECT [mp]
                                          ,[pesokg]
                                      FROM [FML_Ingredientes]
                                     WHERE [formula] = " + selID + "";
                    mp = dp.ACS_GetSelectData(FixedQuery);

                    /**************************Creates the copy of the formula header*************************/
                    string status = "a";
                    if (ActiveUSerType == "fa")
                    {
                        status = "f";
                    }
                    else if (ActiveUSerType == "pr") 
                    {
                        status = "p";
                    }
                    FixedQuery = @"INSERT INTO [FML_Formulas] 
			                                ([codigo]
			                                ,[nombre]
			                                ,[especie]
			                                ,[fechaC]
			                                ,[horaC]
			                                ,[fechaM]
			                                ,[horaM]
			                                ,[creadoX]
			                                ,[modifiX]
			                                ,[comentario]
                                            ,[estado]
                                            ,[version])
	                                 VALUES ('" + "(COPIA)" + /* + header.Tables[0].Rows[0]["codigo"].ToString() + */@"'
			                                ,'" + header.Tables[0].Rows[0]["nombre"].ToString() + @"'
			                                ," + header.Tables[0].Rows[0]["especie"].ToString() + @"
			                                ,SYSDATETIME()
			                                ,SYSDATETIME()
			                                ,SYSDATETIME()
			                                ,SYSDATETIME()
			                                ," + ActiveUSerCode + @"
			                                ," + ActiveUSerCode + @"
			                                ,'" + header.Tables[0].Rows[0]["comentario"].ToString() + @"'
                                            ,'" + status + @"'
			                                ,0);
                                SELECT SCOPE_IDENTITY()";

                    InsertedID = dp.ACS_InsertAndReturnID(FixedQuery).ToString();

                    foreach (DataRow row in pt.Tables[0].Rows) 
                    {
                        FixedQuery = @"  INSERT INTO [FML_PT] ([formula],[pt])
	                                             VALUES (" + InsertedID + "," + row["pt"].ToString() + ")";

                        dp.ACS_DoSmallDBOperation(FixedQuery);
                    }

                    foreach (DataRow row in mp.Tables[0].Rows) 
                    {
                        string Query = @"INSERT INTO [FML_Ingredientes] ([formula],[mp],[pesokg])
                                                          VALUES (" + InsertedID + ", " + row["mp"].ToString() + ", " + row["pesokg"].ToString() + ")";

                        dp.ACS_DoSmallDBOperation(Query);
                    }

                    MessageBox.Show("La copia ha sido realizada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al hacer la copia de la formula\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}