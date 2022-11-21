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
    public partial class FML_NewFormula : DevExpress.XtraEditors.XtraForm
    {
        public string action = "";
        public string selectedID = "";

        string SelPTid = "";
        string SelMPid = "";

        int imdeleting = 0;

        DataSet PTFormula = new DataSet();
        DataSet MPFormula = new DataSet();

        DataOperations dp = new DataOperations();

        public string ActiveUSerCode { get; set; }
        public string ActiveUSerType { get; set; }

        #region Developer Defined Fuctions

        //For Desingn to be inherited
        protected override bool GetAllowSkin()
        {
            if (this.DesignMode) return false;
            return true;
        }

        private void GetEspecies()
        {
            try
            {
                string query = @"SELECT [id]
                                       ,[Descripcion]
                                   FROM [Conf_Especies]";

                cmb_especie.Properties.DataSource = dp.ACS_GetSelectData(query).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetPT()
        {
            try
            {
                string FixedQuery = @"  SELECT [id]
                                              ,[Codigo]
                                              ,[Descripcion]
                                          FROM [PT_Productos]
                                         WHERE [Estado] = 'a'
                                           AND [Especie] = " + cmb_especie.EditValue.ToString() + "";

                cmb_pt.Properties.DataSource = dp.ACS_GetSelectData(FixedQuery).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMP()
        {
            try
            {
                string FixedQuery = @"  SELECT [id]
                                              ,[codigo]
                                              ,[material]
                                          FROM [MP_MateriasPrimas]
                                          WHERE estado= 'a'";

                cmb_mp.Properties.DataSource = dp.ACS_GetSelectData(FixedQuery).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFormulaHeader() 
        {
            try
            {

                string estado = "a";

                if (ActiveUSerType == "fa") 
                {
                    estado = "f";
                }
                if (ActiveUSerType == "pr")
                {
                    estado = "p";
                }

                string Query = @"INSERT INTO [FML_Formulas] 
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
	                                 VALUES ('" + txt_Codigo.Text.ToString() + @"'
			                                ,'" + txt_descripcion.Text.ToString() + @"'
			                                ," + cmb_especie.EditValue.ToString() + @"
			                                ,SYSDATETIME()
			                                ,SYSDATETIME()
			                                ,SYSDATETIME()
			                                ,SYSDATETIME()
			                                ," + ActiveUSerCode + @"
			                                ," + ActiveUSerCode + @"
			                                ,'" + txt_comment.Text.ToString() + @"'
                                            ,'" + estado + @"'
			                                ," + txt_versionFormula.EditValue.ToString() + @");
                                SELECT SCOPE_IDENTITY()";

                selectedID = dp.ACS_InsertAndReturnID(Query).ToString();

                grp_MP.Enabled = true;
                grp_PT.Enabled = true;
                btn_GuardarCambios.Enabled = true;
                btn_guardar.Enabled = false;
                btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                cmb_especie.Enabled = false;
                //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFormulaInfo() 
        {
            try
            {
                string FixedQuery = @"  SELECT A.[codigo]
                                              ,A.[nombre]
                                              ,A.[especie]
                                              ,B.[Descripcion]
                                              ,A.[comentario]
                                              ,A.[version]
                                          FROM [FML_Formulas] A
                                    INNER JOIN [Conf_Especies] B ON A.[especie] = B.[id]
                                         WHERE A.[id] = " + selectedID + "";

                DataSet FormulaData = new DataSet();
                FormulaData = dp.ACS_GetSelectData(FixedQuery);

                cmb_especie.Text = FormulaData.Tables[0].Rows[0]["Descripcion"].ToString();
                cmb_especie.EditValue = FormulaData.Tables[0].Rows[0]["especie"].ToString();
                txt_Codigo.Text = FormulaData.Tables[0].Rows[0]["codigo"].ToString();
                txt_descripcion.Text = FormulaData.Tables[0].Rows[0]["nombre"].ToString();
                txt_comment.Text = FormulaData.Tables[0].Rows[0]["comentario"].ToString();
                txt_versionFormula.Text = FormulaData.Tables[0].Rows[0]["version"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
        {
            try
            {
                string Query = @"   UPDATE [FML_Formulas]
                                       SET [codigo] = '" + txt_Codigo.Text.ToString() + @"'
                                          ,[nombre] = '" + txt_descripcion.Text.ToString() + @"'
                                          ,[especie] = " + cmb_especie.EditValue.ToString() + @"
                                          ,[fechaM] = SYSDATETIME()
                                          ,[horaM] = SYSDATETIME()
                                          ,[creadoX] = " + ActiveUSerCode + @"
                                          ,[modifiX] = " + ActiveUSerCode + @"
                                          ,[comentario] = '" + txt_comment.Text.ToString() + @"'
                                          ,[version] = " + txt_versionFormula.EditValue.ToString() + @"
                                     WHERE [id] = " + selectedID + "";

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPT() 
        {
            try
            {
                string FixedQuery = @"	SELECT A.[id]
		                                      ,B.[Codigo] AS 'codigo'
		                                      ,B.[Descripcion] AS 'descripcion'
                                          FROM [FML_PT] A
                                    INNER JOIN [PT_Productos] B ON A.[pt] = b.[id]
                                          WHERE [formula] = " + selectedID + "";

                grd_pt.DataSource = dp.ACS_GetSelectData(FixedQuery).Tables[0];
                imdeleting = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPT()
        {
            try
            {
                string Query = @"  INSERT INTO [FML_PT] ([formula],[pt])
	                                             VALUES (" + selectedID + "," + cmb_pt.EditValue.ToString() + ")";

                dp.ACS_DoSmallDBOperation(Query);

                cmb_especie.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePT()
        {
            try
            {
                string Query = @"DELETE FROM [FML_PT] WHERE ID = " + SelPTid +"";

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el dato\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMP()
        {
            try
            {
                decimal PesoFormula = 0;
                string FixedQuery = @"	SELECT A.[id]
                                              ,A.[mp] AS 'mpid'
		                                      ,B.[codigo]
		                                      ,B.[material]
		                                      ,C.[tipo]
		                                      ,A.[pesokg]
		                                      ,0.0000 AS 'parte_formula'
                                              ,0.0000 AS 'actual_cost'
		                                      ,0.0000 AS 'precio_primo'
	                                      FROM [FML_Ingredientes] A
                                    INNER JOIN [MP_MateriasPrimas] B ON A.[mp] = B.[id]
                                    INNER JOIN [MP_TipoMateriaPrima] C ON B.[tipo] = C.[id]
	                                     WHERE [formula] = " + selectedID + "";

                DataSet mp = new DataSet();
                mp = dp.ACS_GetSelectData(FixedQuery);

                foreach (DataRow row in mp.Tables[0].Rows) 
                {
                    PesoFormula += Convert.ToDecimal(row["pesokg"].ToString());
                }

                foreach (DataRow row in mp.Tables[0].Rows)
                {
                    decimal Percentage = (Convert.ToDecimal(row["pesokg"].ToString()) / PesoFormula);
                    row["parte_formula"] = Percentage.ToString();

                    FixedQuery = @" SELECT [valor_tm] AS 'precio'
                                      FROM [MP_UltimoCosto]
                                     WHERE [idMP] = " + row["mpid"].ToString() + "";

                    DataSet Price = new DataSet();
                    Price = dp.ACS_GetSelectData(FixedQuery);

                    decimal PrecioMaterial = 0;

                    if (Price.Tables[0].Rows.Count <= 0) 
                    {
                        PrecioMaterial = 0;
                    }
                    else if (Price.Tables[0].Rows.Count > 0) 
                    {
                       PrecioMaterial = Convert.ToDecimal(Price.Tables[0].Rows[0]["precio"].ToString());
                    }

                    row["actual_cost"] = PrecioMaterial.ToString();
                    row["precio_primo"] = (PrecioMaterial * Percentage).ToString();
                }
                grd_mp.DataSource = mp.Tables[0];
                imdeleting = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMP()
        {
            try
            {
                string PesoI = txt_pesomp.Value.ToString();

                if (ActiveUSerType == "fa") 
                {
                    PesoI = (2500 * (Convert.ToDecimal(txt_pesomp.Value.ToString()) / 100)).ToString();
                }

                string Query = @"INSERT INTO [FML_Ingredientes] ([formula],[mp],[pesokg])
                                                          VALUES (" + selectedID + ", " + cmb_mp.EditValue.ToString() + ", " + PesoI + ")";

                dp.ACS_DoSmallDBOperation(Query);

                txt_pesomp.Text = ".0001";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMP()
        {
            try
            {
                string Query = @"DELETE FROM [FML_Ingredientes] WHERE ID = " + SelMPid + "";

                dp.ACS_DoSmallDBOperation(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el dato\nDetalle del Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public FML_NewFormula()
        {
            InitializeComponent();
            GetAllowSkin();
        }

        private void FML_NewFormula_Load(object sender, EventArgs e)
        {
            GetEspecies();
            GetMP();

            if (ActiveUSerType == "fa") 
            {
                lbl_peso.Text = "%";
            }

            if (action == "new") 
            {
                grp_MP.Enabled = false;
                grp_PT.Enabled = false;
                btn_guardar.Enabled = true;
                btn_GuardarCambios.Enabled = false;
            }
            else if (action == "edit") 
            {
                grp_MP.Enabled = true;
                grp_PT.Enabled = true;
                btn_GuardarCambios.Enabled = true;
                btn_guardar.Enabled = false;
                btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                cmb_especie.Enabled = false;

                LoadFormulaInfo();

                LoadPT();
                LoadMP();
            }
            else if (action == "view")
            {
                this.Text = "Verificar Información de Formula";
                //grp_MP.Enabled = false;
                //grp_PT.Enabled = false;
                grp_datosFormula.Enabled = false;
                grp_agregarMP.Enabled = false;
                groupControl2.Enabled = false;
                btn_GuardarCambios.Enabled = false;
                btn_GuardarCambios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_guardar.Enabled = false;
                btn_guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                cmb_especie.Enabled = false;

                LoadFormulaInfo();

                LoadPT();
                LoadMP();
            }
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFormulaHeader();
        }

        private void btn_Cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FML_NewFormula_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (action != "view")
            {
                if (this.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    if (MessageBox.Show("¿Seguro que desea Cancelar?, todo cambio realizado se perdera.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            else 
            {
                this.Close();
            }
        }

        private void cmb_especie_EditValueChanged(object sender, EventArgs e)
        {
            GetPT();
        }

        private void btn_GuardarCambios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btn_addPT_Click(object sender, EventArgs e)
        {
            AddPT();
            LoadPT();
        }

        private void btn_addMP_Click(object sender, EventArgs e)
        {
            AddMP();
            LoadMP();
            cmb_mp.Focus();
        }

        private void grdv_pt_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(imdeleting == 0)
            SelPTid = grdv_pt.GetDataRow(e.FocusedRowHandle)["id"].ToString();
        }

        private void grdv_mp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(imdeleting == 0)
            SelMPid = grdv_mp.GetDataRow(e.FocusedRowHandle)["id"].ToString();
        }

        private void btn_RemovePT_Click(object sender, EventArgs e)
        {
            imdeleting = 1;
            DeletePT();
            LoadPT();
        }

        private void btn_RemoveMP_Click(object sender, EventArgs e)
        {
            imdeleting = 1;
            DeleteMP();
            LoadMP();
        }

        private void txt_pesomp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                AddMP();
                LoadMP();
                cmb_mp.Focus();
            }
        }

        private void btn_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_mp.ExportToXlsx(dialog.FileName);
            }
        }

        private void grd_mp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
            {
                grdv_mp.ShowPrintPreview();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E) 
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grdv_mp.ExportToXlsx(dialog.FileName);
                }
            }
        }
    }
}