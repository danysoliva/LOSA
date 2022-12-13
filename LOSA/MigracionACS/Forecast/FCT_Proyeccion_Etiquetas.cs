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
using ACS.Forecast;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_Proyeccion_Etiquetas : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables

        DataOperations dp = new DataOperations();
        DataSet Proyeccion = new DataSet();

        public string ActiveUserCode;

        string SelectedProID;

        string selectedID;

        #endregion

        #region Developer Defined Methods

        private void LoadProyecciones() 
        {
            try
            {
                cmb_proyecciones.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT [id]
                                                                                    ,[code]
                                                                                    ,[name]
                                                                              FROM [dbo].[FCT_Proyecciones_Ventas_v2]
                                                                              WHERE [status] >= 40 AND [status] < 80 ").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadDetails()
        {
            try
            {

                string sql = @" EXEC [dbo].[FCT_proyeccion_etiquetas] @id_proyeccion = " + SelectedProID;


               DataOperations dp = new DataOperations();
               SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
               Conn.Open();

               SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
               dsProyeccionesVentas1.proy_etiquetas.Clear();
               adapter.Fill(dsProyeccionesVentas1.proy_etiquetas);

               Conn.Close();

               if (dsProyeccionesVentas1.proy_etiquetas.Rows.Count > 0) 
                {
                    foreach (DataRow row in dsProyeccionesVentas1.proy_etiquetas.Rows) 
                    {
                        row["total"] = (Convert.ToDecimal(row["ene"].ToString()) + 
                                        Convert.ToDecimal(row["feb"].ToString()) + 
                                        Convert.ToDecimal(row["mar"].ToString()) + 
                                        Convert.ToDecimal(row["abr"].ToString()) + 
                                        Convert.ToDecimal(row["may"].ToString()) + 
                                        Convert.ToDecimal(row["jun"].ToString()) + 
                                        Convert.ToDecimal(row["jul"].ToString()) + 
                                        Convert.ToDecimal(row["ago"].ToString()) + 
                                        Convert.ToDecimal(row["sep"].ToString()) + 
                                        Convert.ToDecimal(row["oct"].ToString()) + 
                                        Convert.ToDecimal(row["nov"].ToString()) + 
                                        Convert.ToDecimal(row["dic"].ToString()));
                    }
                }


                //grd_proyeccion.DataSource = Proyeccion.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Constructors

        public FCT_Proyeccion_Etiquetas()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private void FCT_Proyeccion_Etiquetas_Load(object sender, EventArgs e)
        {
            LoadProyecciones();
        }

        private void btn_NuevaProyeccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_Proyecciones_Ventas_New proy = new FCT_Proyecciones_Ventas_New();
            proy.ActiveUserCode = ActiveUserCode;
            if (proy.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                //SelectedProID = proy.SelectedProID;
                LoadProyecciones();
            }
        }

        private void cmb_proyecciones_EditValueChanged(object sender, EventArgs e)
        {
            //btn_addFormula.Enabled = true;
            //btn_RemoveFormula.Enabled = true;
            //btn_SaveData.Enabled = true;
            btn_saveChanges.Enabled = true;
            btn_AddNewFormula.Enabled = true;
            btn_deleteFormuNew.Enabled = true;
            SelectedProID = cmb_proyecciones.EditValue.ToString();
            LoadDetails();
        }

        private void btn_addFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string query = @"   SELECT [id]
                                      ,[codigo] AS col1
                                      ,[nombre] AS col2
                                      ,[estado]
                                  FROM [dbo].[FML_Formulas]";

                Item_Selecction sel = new Item_Selecction();
                sel.col1Header = "Codigo";
                sel.col2Header = "Nombre Formula";
                sel.FormHeader = "Selección de Formula";
                sel.Query = query;

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                {
                    query = @"INSERT INTO [dbo].[FCT_Proyecciones_Venta_D_v2]
			                            ([id_proy]
				                        ,[id_form]
				                        ,[ene]
				                        ,[feb]
				                        ,[mar]
				                        ,[abr]
				                        ,[may]
				                        ,[jun]
				                        ,[jul]
				                        ,[ago]
				                        ,[sep]
				                        ,[oct]
				                        ,[nov]
				                        ,[dic])
		                         VALUES (" + SelectedProID + @"
				                        ," + sel.SVid + @"
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0);";

                    dp.ACS_DoSmallDBOperation(query);

                    LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SaveData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                foreach (DataRow row in Proyeccion.Tables[0].Rows)
                {
                    string query = @" UPDATE [dbo].[FCT_Proyecciones_Venta_D_v2]
	                                 SET [ene] = " + row["ene"] + @"
		                                ,[feb] = " + row["feb"] + @"
		                                ,[mar] = " + row["mar"] + @"
		                                ,[abr] = " + row["abr"] + @"
		                                ,[may] = " + row["may"] + @"
		                                ,[jun] = " + row["jun"] + @"
		                                ,[jul] = " + row["jul"] + @"
		                                ,[ago] = " + row["ago"] + @"
		                                ,[sep] = " + row["sep"] + @"
		                                ,[oct] = " + row["oct"] + @"
		                                ,[nov] = " + row["nov"] + @"
		                                ,[dic] = " + row["dic"] + @"
                                   WHERE [id] = " + row["id"] + @";";

                    dp.ACS_DoSmallDBOperation(query);

                    LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RemoveFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dp.ACS_DoSmallDBOperation(string.Format(@"DELETE FROM [dbo].[FCT_Proyecciones_Venta_D_v2] WHERE [id] = {0}", selectedID));

                LoadDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la informacion.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdv_proyeccion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedID = grdv_proyeccion.GetRowCellValue(e.FocusedRowHandle, "id").ToString();
            }
            catch { }
        }

        private void btn_copy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_Proyeccion_Copy copy = new FCT_Proyeccion_Copy();
            copy.ActiveUserCode = ActiveUserCode;
            copy.datos = Proyeccion;
            if (copy.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                MessageBox.Show("Proyección Generada Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProyecciones();
            }
        }

        private void btn_UpdateProyeccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                string query = @" SELECT A.[id]
                                        ,A.[name] AS col1
                                        ,B.[nombre] AS col2
                                    FROM [dbo].[FCT_Proyecciones_Ventas_v2] A
                                    INNER JOIN [dbo].[conf_usuarios] B ON A.[created_by] = B.[id]
                                    WHERE A.[status] >= 10 AND A.[status] < 90
                                      AND A.[id] <> " + SelectedProID + @"";

                Item_Selecction sel = new Item_Selecction();
                sel.col1Header = "Proyeccion de Ventas";
                sel.col2Header = "Creada Por";
                sel.FormHeader = "Seleccione la Proyeccion a Actualizar";
                sel.action = "proy";
                sel.ProyDetail = Proyeccion;
                sel.Query = query;

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Proyección de Ventas Actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Proyeccion de Ventas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo de Excel (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_proyeccion.ExportToXlsx(dialog.FileName.ToString());
            }
        }

        private void grdv_proyeccion_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void btnc_addFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string query = @"SELECT [id]
                                      ,[src_formula_code] AS col1
                                      ,[src_formula_name] AS col2
                                      ,[status]
                                  FROM [dbo].[FML_Fomulas_FF_H]
                                 WHERE [status] >= 40 AND [status] < 80";

                Item_Selecction sel = new Item_Selecction();
                sel.col1Header = "Código";
                sel.col2Header = "Nombre Formula";
                sel.FormHeader = "Selecciona la Formula";
                sel.Query = query;

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    query = @"INSERT INTO [dbo].[FCT_Proyecciones_Venta_D_v2]
			                            ([id_proy]
				                        ,[id_form]
				                        ,[ene]
				                        ,[feb]
				                        ,[mar]
				                        ,[abr]
				                        ,[may]
				                        ,[jun]
				                        ,[jul]
				                        ,[ago]
				                        ,[sep]
				                        ,[oct]
				                        ,[nov]
				                        ,[dic])
		                         VALUES (" + SelectedProID + @"
				                        ," + sel.SVid + @"
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0);";

                    dp.ACS_DoSmallDBOperation(query);

                    LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_deleteFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dp.ACS_DoSmallDBOperation(string.Format(@"DELETE FROM [dbo].[FCT_Proyecciones_Venta_D_v2] WHERE [id] = {0}", selectedID));

                LoadDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la informacion.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_saveChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in Proyeccion.Tables[0].Rows)
                {
                    string query = @" UPDATE [dbo].[FCT_Proyecciones_Venta_D_v2]
	                                 SET [ene] = " + row["ene"] + @"
		                                ,[feb] = " + row["feb"] + @"
		                                ,[mar] = " + row["mar"] + @"
		                                ,[abr] = " + row["abr"] + @"
		                                ,[may] = " + row["may"] + @"
		                                ,[jun] = " + row["jun"] + @"
		                                ,[jul] = " + row["jul"] + @"
		                                ,[ago] = " + row["ago"] + @"
		                                ,[sep] = " + row["sep"] + @"
		                                ,[oct] = " + row["oct"] + @"
		                                ,[nov] = " + row["nov"] + @"
		                                ,[dic] = " + row["dic"] + @"
                                   WHERE [id] = " + row["id"] + @";";

                    dp.ACS_DoSmallDBOperation(query);

                    LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnt_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo de Excel (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_proyeccion.ExportToXlsx(dialog.FileName.ToString());
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string query = @" SELECT A.[id]
                                        ,A.[name] AS col1
                                        ,B.[nombre] AS col2
                                    FROM [dbo].[FCT_Proyecciones_Ventas_v2] A
                                    INNER JOIN [dbo].[conf_usuarios] B ON A.[created_by] = B.[id]
                                    WHERE A.[status] >= 10 AND A.[status] < 90
                                      AND A.[id] <> " + SelectedProID + @"";

                Item_Selecction sel = new Item_Selecction();
                sel.col1Header = "Proyeccion de Ventas";
                sel.col2Header = "Creada Por";
                sel.FormHeader = "Seleccione la Proyeccion a Actualizar";
                sel.action = "proy";
                sel.ProyDetail = Proyeccion;
                sel.Query = query;

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Proyección de Ventas Actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Proyeccion de Ventas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_Proyeccion_Copy copy = new FCT_Proyeccion_Copy();
            copy.ActiveUserCode = ActiveUserCode;
            copy.datos = Proyeccion;
            if (copy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Proyección Generada Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProyecciones();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FCT_Proyecciones_Ventas_New proy = new FCT_Proyecciones_Ventas_New();
            proy.ActiveUserCode = ActiveUserCode;
            if (proy.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //SelectedProID = proy.SelectedProID;
                LoadProyecciones();
            }
        }

        private void btn_saveChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in Proyeccion.Tables[0].Rows)
                {
                    string query = @" UPDATE [dbo].[FCT_Proyecciones_Venta_D_v2]
	                                 SET [ene] = " + row["ene"] + @"
		                                ,[feb] = " + row["feb"] + @"
		                                ,[mar] = " + row["mar"] + @"
		                                ,[abr] = " + row["abr"] + @"
		                                ,[may] = " + row["may"] + @"
		                                ,[jun] = " + row["jun"] + @"
		                                ,[jul] = " + row["jul"] + @"
		                                ,[ago] = " + row["ago"] + @"
		                                ,[sep] = " + row["sep"] + @"
		                                ,[oct] = " + row["oct"] + @"
		                                ,[nov] = " + row["nov"] + @"
		                                ,[dic] = " + row["dic"] + @"
                                   WHERE [id] = " + row["id"] + @";";

                    dp.ACS_DoSmallDBOperation(query);

                    LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
//                string query = @"SELECT [id]
//                                      ,[src_formula_code] AS col1
//                                      ,[src_formula_name] AS col2
//                                      ,[status]
//                                  FROM [dbo].[FML_Fomulas_FF_H]
//                                 WHERE [status] >= 40 AND [status] < 80";

//                Item_Selecction sel = new Item_Selecction();
//                sel.col1Header = "Código";
//                sel.col2Header = "Nombre Formula";
//                sel.FormHeader = "Selecciona la Formula";
//                sel.Query = query;

                FCT_FF_Select sel = new FCT_FF_Select(int.Parse(SelectedProID));

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string query = @"INSERT INTO [dbo].[FCT_Proyecciones_Venta_D_v2]
			                            ([id_proy]
				                        ,[id_form]
				                        ,[ene]
				                        ,[feb]
				                        ,[mar]
				                        ,[abr]
				                        ,[may]
				                        ,[jun]
				                        ,[jul]
				                        ,[ago]
				                        ,[sep]
				                        ,[oct]
				                        ,[nov]
				                        ,[dic])
		                         VALUES (" + SelectedProID + @"
				                        ," + sel.id_formula_format + @"
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0
				                        ,0);";

                    dp.ACS_DoSmallDBOperation(query);

                    LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El proceso ha fallado por completo.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteFormuNew_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dp.ACS_DoSmallDBOperation(string.Format(@"DELETE FROM [dbo].[FCT_Proyecciones_Venta_D_v2] WHERE [id] = {0}", selectedID));

                LoadDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la informacion.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        
    }
}