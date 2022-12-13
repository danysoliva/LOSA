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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using LOSA.Clases;
using ACS.Forecast;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_FF_Select : DevExpress.XtraEditors.XtraForm
    {
        FMOP fmop = new FMOP();
        DataTable formulas;

        DataOperations dp = new DataOperations();

        public int id_formula_format { get; set; }

        int SelectedProID;

        public FCT_FF_Select(int SelectedProID)
        {
            InitializeComponent();
            this.SelectedProID = SelectedProID;
        }

        private void FML_FF_Select_Load(object sender, EventArgs e)
        {
            try
            {
                int pEspecie = Convert.ToInt32(radioBtnEspecie.EditValue);
                #region Load Main
                formulas = fmop.ext_formula_get_by_status(1, 95, pEspecie);

                grd_main.DataSource = formulas;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdv_main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (formulas.Rows.Count > 0)
                {
                    id_formula_format = int.Parse(grdv_main.GetRowCellValue(e.FocusedRowHandle, "id").ToString());
                    grd_structure.DataSource = fmop.ext_formula_get_structure(id_formula_format);
                }
            }
            catch { }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_Select_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (id_formula_format > 0 && id_formula_format != null) 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void grdv_main_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e)
        {
            GridView View = sender as GridView;
            GridColumn column = View.GroupedColumns[e.Level];
            if (column == null) return;
            e.LevelAppearance.Combine(column.AppearanceHeader);
        }

        private void btnc_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Add_ItemClick(sender, e);
        }

        private void btnc_addAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (id_formula_format > 0 && id_formula_format != null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (id_formula_format > 0 && id_formula_format != null)
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
				                        ," + id_formula_format + @"
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

                if (System.Windows.Forms.Application.OpenForms["FCT_Proyeccion_Ventas"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["FCT_Proyeccion_Ventas"] as FCT_Proyeccion_Ventas).LoadDetails();
                }
            }
        }

        private void grdv_main_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenu.ShowPopup(Cursor.Position);
            }
        }
    }
}