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
    public partial class FML_NC_Structure_View : DevExpress.XtraEditors.XtraForm
    {
        FMOP fmop = new FMOP();
        int formula_id;
        Double peso;

        DataTable datos;

        public FML_NC_Structure_View(int formula_id, Double peso)
        {
            InitializeComponent();

            this.formula_id = formula_id;
            this.peso = peso;
        }

        private void FML_NC_Structure_View_Load(object sender, EventArgs e)
        {
            try
            {
                datos = fmop.local_formula_get_structure(formula_id);

                if (peso > 0) 
                {
                    foreach (DataColumn col in datos.Columns)
                    {
                        col.ReadOnly = false;
                    }

                    foreach (DataRow row in datos.Rows)
                    {
                        row["peso"] = (peso * Convert.ToDouble(row["inclusion"]));
                    }

                    datos.AcceptChanges();   
                }

                grd_data.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PrintWhere_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.ShowPrintPreview();
        }

        private void btn_PrintDirect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.Print();
        }

        private void btn_exportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo de Excel (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName.ToString());
            }
        }
    }
}