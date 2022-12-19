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
using System.Diagnostics;
using System.Data.OleDb;



namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_Details : Form
    {
        string ParRubro = "0";
        DateTime Parinicio;
        DateTime Parfinal;
        public SAR_Details(string Rubro, DateTime inicio, DateTime final)
        {
            InitializeComponent();
            ParRubro = Rubro;
            Parinicio = inicio;
            Parfinal = final;
            load_data();
        }
        DataOperations dp = new DataOperations();
        public void load_data()
        {
            string Query = @"sp_load_ordenes_de_compra";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rubro" , SqlDbType.NChar).Value = ParRubro;
            cmd.Parameters.Add("@dtinicial", SqlDbType.DateTime).Value = Parinicio;
            cmd.Parameters.Add("@dtfinal", SqlDbType.DateTime).Value = Parfinal;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dS_SAR.detalle.Clear();
            da.Fill(dS_SAR.detalle);
            
          }
        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_detalle.ExportToXlsx(dialog.FileName);
                OpenMicrosoftExcel(dialog.FileName);
            }
        }
        static void OpenMicrosoftExcel(string f)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = f;
            Process.Start(startInfo);
        }
    }
}
