using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_reporte_bascula : Form
    {
        DataOperations dp = new DataOperations();
        public TT_reporte_bascula()
        {
            InitializeComponent();
            dtini.DateTime = DateTime.Now.AddDays(-1);
            dtfin.DateTime = DateTime.Now;
        }
        
        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btngenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }
        public void load()
        {
          
            if (dtfin.DateTime < dtfin.DateTime)
            {
                CajaDialogo.Error("La fecha final no puede ser menor que la fecha inicial.");
                dtfin.Focus();
                return;
            }
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                string query = @"EXEC [dbo].[rpt_bascula_new]
		                                @dtini = @dtinicial,
		                                @dtfin = @dtfinal";
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.Parameters.Add("@dtinicial", SqlDbType.DateTime).Value = dtini.DateTime;
                cmd.Parameters.Add("@dtfinal", SqlDbType.DateTime).Value = dtfin.DateTime;
                dSTtracer.rptbascula.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dSTtracer.rptbascula);
                cn.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_bascula.ExportToXlsx(dialog.FileName);
                //gridControl2.ExportToXlsx(dialog.FileName);
            }
        }
    }
}
