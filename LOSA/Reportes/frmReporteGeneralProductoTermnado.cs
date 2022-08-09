using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Reportes
{
    public partial class frmReporteGeneralProductoTermnado : DevExpress.XtraEditors.XtraForm
    {
       
        int Especie;
        DataOperations dp = new DataOperations();
        
        public frmReporteGeneralProductoTermnado()
        {
            InitializeComponent();
            Especie = 2;
            get_inventario();
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void get_inventario()
        {
            try
            {
                string query = @"sp_get_inventario_existencia_pt_by_especie";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Especie", Especie);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario.inventario.Clear();
                da.Fill(dsReportesInventario.inventario);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0) // Camaron
            {
                Especie = 2;
            }
            else
            {
                Especie = 1;
            }
            get_inventario();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (Especie == 2)
                    {
                        grd_inventario_camaron.ExportToXlsx(dialog.FileName);
                    }
                    else
                    {
                        grd_inventario_Tilapia.ExportToXlsx(dialog.FileName);
                    }
                   
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void cmdAjuste_Click(object sender, EventArgs e)
        {

        }
    }
}