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
    public partial class PP_Production_Orders_Detail : DevExpress.XtraEditors.XtraForm
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

        public PP_Production_Orders_Detail(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
        }

        private void PP_Production_Orders_Detail_Load(object sender, EventArgs e)
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

                grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("RPT_Consumos_Ordenes_Produccion", cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToPdf(dialog.FileName);
            }
        }
    }
}