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
using LOSA.Clases;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_FF_Select : DevExpress.XtraEditors.XtraForm
    {
        FMOP fmop = new FMOP();
        DataTable formulas;

        public int id_formula_format { get; set; }

        public FML_FF_Select()
        {
            InitializeComponent();
        }

        private void FML_FF_Select_Load(object sender, EventArgs e)
        {
            try
            {
                #region Load Main
                formulas = fmop.ext_formula_get_available_planning(40, 40);

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
            if (id_formula_format > 0) 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

        }

        private void grd_main_DoubleClick(object sender, EventArgs e)
        {
            if (id_formula_format > 0 && id_formula_format != null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

        }
    }
}