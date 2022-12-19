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

namespace LOSA.MigracionACS.ADVD.DeveloperTools
{
    public partial class Select_Items_v3 : DevExpress.XtraEditors.XtraForm
    {
        #region Variables_Globales
        DataOperations dp = new DataOperations();
        DataSet datos;

        //gets
        public int getID;
        public String getCol1, getCol2, getCol3;

        //sets
        public String setQuery, Sistema= "";
        #endregion

        /// <summary>
        /// -- Seleccionar Parametrizable --
        /// </summary>
        /// <param name="Query"> Query </param>
        /// <param name="Col1"> El título de 2da columna  </param>
        /// <param name="Col2"> El título de 2da columna (opcional) </param>
        /// <returns></returns>
        public Select_Items_v3(String Query)
        {
            InitializeComponent();
            //gridView1.Columns[1].Caption = Col1;
            //gridView1.Columns[2].Caption = Col2;
            //    if (Col2== "") gridView1.Columns[2].Visible = false;
                
            this.setQuery = Query;
            Load_Data();
        }


        /// <summary>
        /// -- Seleccionar Parametrizable --
        /// </summary>
        /// <param name="Sistema"> Sistema: ACS, ODOO, APMS</param>
        /// <param name="Query"> Query deberá traer: ID, Col1, Col2 (Opcional) </param>
        /// <param name="Col1"> El título de 2da columna  </param>
        /// <param name="Col2"> El título de 2da columna (opcional) </param>
        /// <returns></returns>
        public Select_Items_v3(String Sistema, String Query)
        {
            InitializeComponent();
            //gridView1.Columns[1].Caption = Col1;
            //gridView1.Columns[2].Caption = Col2;
                //if (Col2 == "") gridView1.Columns[2].Visible = false;

            this.setQuery = Query;
            this.Sistema  = Sistema;
            Load_Data();
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Seleccionando_Registro..
            if (getID <= 0) return;
            //int lin = gridView1.GetVisibleIndex(gridView1.FocusedRowHandle);
            //if (lin < 0) return;
            //    getID   = Convert.ToInt32(datos.Tables[0].Rows[lin]["id"].ToString());
            //    getCol1 = datos.Tables[0].Rows[lin][1].ToString();
            //    getCol2 = gridView1.Columns[2].Visible==true ? datos.Tables[0].Rows[lin][2].ToString() : "" ;
            #endregion

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region AutorRow_Color_Diferente
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
            #endregion
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Load_Data();
            }
            catch (Exception ex)
            {
                #region Try-Catch_Mensaje-Error
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());
                dialog.Text = "Error";
                dialogType.GetProperty("Message").SetValue(dialog, "Error: Paramatros errorneos en Select_Items_v3 \n " + ex.Message, null);
                dialogType.GetProperty("Details").SetValue(dialog, ex.StackTrace, null);
                var result = dialog.ShowDialog();
                #endregion
            }          
        }

        void Load_Data()
        {
            //datos = dp.ACS_GetSelectData(setQuery);
            if (Sistema.ToLower() == "acs") datos = dp.ACS_GetSelectData(setQuery);
            else if (Sistema.ToLower() == "odoo") datos = dp.ODOO_GetSelectData(setQuery);
            else if (Sistema.ToLower() == "apms") datos = dp.APMS_GetSelectData(setQuery);
            else datos = dp.ACS_GetSelectData(setQuery);

            gridControl1.DataSource = datos.Tables[0];
            grid_autoajustar();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnSeleccionar.PerformClick();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                getID   = int.Parse(gridView1.GetDataRow(e.FocusedRowHandle)[0].ToString());
                getCol1 = gridView1.GetDataRow(e.FocusedRowHandle)[1].ToString();

                //--------------
                GridViewInfo ViewInfo = (GridViewInfo)gridView1.GetViewInfo();
                getCol2 = ViewInfo.ColumnsInfo.ColumnsCount > 2 ? gridView1.GetDataRow(e.FocusedRowHandle)[2].ToString() : "";
                getCol3 = ViewInfo.ColumnsInfo.ColumnsCount > 3 ? gridView1.GetDataRow(e.FocusedRowHandle)[3].ToString() : "";
             
                //getCol2 = gridView1.Columns[2].Visible == true ? gridView1.GetDataRow(e.FocusedRowHandle)[2].ToString() : "";
                //getCol3 = gridView1.Columns[3].Visible == true ? gridView1.GetDataRow(e.FocusedRowHandle)[3].ToString() : "";
                //--------------
            }
        }


        void grid_autoajustar()
        {
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            GridViewInfo viewInfo = gridView1.GetViewInfo() as GridViewInfo;
            if (viewInfo.ViewRects.ColumnTotalWidth < viewInfo.ViewRects.ColumnPanelWidth)
                gridView1.OptionsView.ColumnAutoWidth = true;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnSeleccionar.PerformClick();
        }


    }
}