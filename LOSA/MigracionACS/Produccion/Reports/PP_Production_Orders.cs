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

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class PP_Production_Orders : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();

        float mix1Reach = 0;
        float mix2Reach = 0;
        float generalReach = 0;
        float batch_t = 0;

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string selectedType;
        int selectedFML_ID;

        public PP_Production_Orders(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
        }

        private void PP_Production_Orders_Load(object sender, EventArgs e)
        {
            try
            {
                string format = "yyyy-MM-dd";
                dt_desde.Text = DateTime.Now.ToString(format) + " 00:00:00";
                dt_hasta.Text = DateTime.Now.ToString(format) + " 23:59:59";
            }
            catch { }
        }

        private void btn_generate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@start_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@end_date", SqlDbType.DateTime));

                cmd.Parameters["@start_date"].Value = dt_desde.EditValue;
                cmd.Parameters["@end_date"].Value = dt_hasta.EditValue;

                grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("RPT_Resumen_Ordenes_Produccion", cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.ShowRibbonPrintPreview();
        }

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

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedFML_ID = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["form_id"].ToString());

                mix1Reach = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["batch_MA"].ToString());
                mix2Reach = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["batch_MB"].ToString());
                batch_t = Convert.ToInt32(grdv_data.GetDataRow(e.FocusedRowHandle)["batch_T"].ToString());

                mix1Reach = (mix1Reach / batch_t);
                mix2Reach = (mix2Reach / batch_t);
                generalReach = (float)((mix1Reach + mix2Reach) / 2);

                gc_ScaleMix1.Value = (mix1Reach * 100);
                gc_ScaleMix2.Value = (mix2Reach * 100);
                gc_ReachLinearScaleComp.Value = (generalReach * 100);

                grp_mix1.Text = "Primer Mezclado " + gc_ScaleMix1.Value.ToString() + "%";
                grp_mix2.Text = "Segundo Mezclado " + gc_ScaleMix2.Value.ToString() + "%";
                grp_general.Text = "General " + gc_ReachLinearScaleComp.Value.ToString() + "%";
            }
            catch { }
        }

        private void btn_Formula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formulas.FML_NewFormula_v2 fm = new Formulas.FML_NewFormula_v2(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", selectedFML_ID, "FB");
            fm.ShowDialog();
        }
    }
}