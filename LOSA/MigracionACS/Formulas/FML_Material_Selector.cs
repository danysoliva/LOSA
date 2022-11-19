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
using LOSA.MigracionACS.Formulas;

namespace LOSA.MigracionACS. ACS.Formulas
{
    public partial class FML_Material_Selector : DevExpress.XtraEditors.XtraForm
    {
        #region Variables

        DataTable materials;

        int sel_id;
        string sel_code;
        string sel_name;
        string sel_mix;
        string sel_type;
        bool sel_nc_use;

        #endregion

        #region Constructors

        public FML_Material_Selector(DataTable materials)
        {
            InitializeComponent();
            this.materials = materials;
        }

        #endregion

        #region Form Events

        private void FML_Material_Selector_Load(object sender, EventArgs e)
        {
            grd_data.DataSource = materials;
        }

        private void grdv_data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                if (sel_type == "NC")
                    btnc_NCStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                else
                    btnc_NCStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["FML_NewFormula_v3"] != null)
            {
                int count = 0;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FML_NewFormula_v3")
                        count++;
                }

                int count2 = 0;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FML_NewFormula_v3")
                    {
                        count2++;
                        if (count2 == count)
                        {
                            (frm as FML_NewFormula_v3).add_item_to_grid(-1, sel_id, sel_code, sel_name, 1, sel_type, sel_mix, sel_nc_use);
                            //this.Close();
                        }
                    }
                }
                //(System.Windows.Forms.Application.OpenForms["FML_NewFormula_v3"] as FML_NewFormula_v3).add_item_to_grid(-1, sel_id, sel_code, sel_name, 1, sel_type, sel_mix, sel_nc_use);
            }
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                sel_id = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["id"].ToString());
                sel_code = grdv_data.GetDataRow(e.FocusedRowHandle)["code"].ToString();
                sel_name = grdv_data.GetDataRow(e.FocusedRowHandle)["name"].ToString();
                sel_mix = grdv_data.GetDataRow(e.FocusedRowHandle)["mix"].ToString();
                sel_type = grdv_data.GetDataRow(e.FocusedRowHandle)["type"].ToString();
                sel_nc_use = Convert.ToBoolean(grdv_data.GetDataRow(e.FocusedRowHandle)["type"].ToString());
            }
            catch { }
        }

        private void btn_addClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["FML_NewFormula_v3"] != null)
            {
                int count = 0;
                foreach (Form frm in Application.OpenForms) 
                {
                    if (frm.Name == "FML_NewFormula_v3")
                        count++;
                }

                int count2 = 0;
                foreach (Form frm in Application.OpenForms) 
                {
                    if (frm.Name == "FML_NewFormula_v3") 
                    {
                        count2++;
                        if (count2 == count) 
                        {
                            (frm as FML_NewFormula_v3).add_item_to_grid(-1, sel_id, sel_code, sel_name, 1, sel_type, sel_mix, sel_nc_use);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnc_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_add_ItemClick(sender, e);
        }

        private void btnc_addClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_addClose_ItemClick(sender, e);
        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnc_NCStructure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_NC_Structure_View form = new FML_NC_Structure_View(sel_id, -1);
            form.ShowDialog();
        }

        #endregion
    }
}