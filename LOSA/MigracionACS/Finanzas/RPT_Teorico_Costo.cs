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
using ACS.Classes;

namespace LOSA.MigracionACS.Finanzas
{
    public partial class RPT_Teorico_Costo : Form
    {
        string SP;
        DataOperations dp = new DataOperations();
        
        public RPT_Teorico_Costo()
        {
            InitializeComponent();
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void load_data()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
            
            SP = @"EXEC [dbo].[RPT_FIN_FML_Teorico_Cost_V2] @fecha_desde = @fecha_desdee ,
		    @fecha_hasta = @fecha_hastaa";
            SqlCommand cmd = new SqlCommand(SP, cn);
            cmd.Parameters.Add(new SqlParameter("@fecha_desdee", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@fecha_hastaa", SqlDbType.DateTime));
            cmd.Parameters["@fecha_desdee"].Value = Convert.ToDateTime(dtdesde.EditValue);
            cmd.Parameters["@fecha_hastaa"].Value = Convert.ToDateTime(dthasta.EditValue);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSRPT.RPT_Teorico.Clear();
                da.Fill(dSRPT.RPT_Teorico);
                try
                {
                    foreach (DataRow row in dSRPT.RPT_Teorico.Rows)
                    {
                        row["inclusionCal"] = Convert.ToDecimal(row["s_batch_kg"]) / 2500;

                    }
                }
                catch (Exception ex)
                {

                   
                }
                dSRPT.RPT_Teorico.AcceptChanges();
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtdesde.EditValue ==  DBNull.Value)
            {
                MessageBox.Show("La fecha de inicio no puede estar vacia");
                dtdesde.Focus();
                return;
            }
            if (dthasta.EditValue == DBNull.Value)
            {
                MessageBox.Show("Le fecha final no puede estar vacia");
                dthasta.Focus();
                return;
            }
            load_data();
        }

        private void btnexport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_teorico_cost.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnexportexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_teorico_cost.ExportToXlsx(dialog.FileName);
            }
        }
    }
}
