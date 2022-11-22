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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PBR_Reimpresion : Form
    {
        DataOperations dp = new DataOperations();
        public PBR_Reimpresion()
        {
            InitializeComponent();
            load_data();
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void load_data()
        {
            string query = @"SELECT T0.[id]
                                      ,T0.[fecha_ini]
                                      ,T0.[fecha_fin]
                                      ,T2.descripcion
                                      ,T1.nombre
                                  FROM [dbo].[PRB_Registro_H] T0 join dbo.[conf_usuarios] T1 on T0.user_code = T1.id
										                                join dbo.[PRB_Turno] T2 on T2.id = T0.idturno
                                  WHERE T0.enable = 1
                                  order by fecha_ini desc";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_reportprod.Reimpresion.Clear();
                da.Fill(ds_reportprod.Reimpresion);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnreimprimir_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)grd_main.FocusedView;
            var row = (ds_reportprod.ReimpresionRow)GridView.GetFocusedDataRow();

            PRB_Report_v2 cp = new PRB_Report_v2(row.id);
            cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(cp);
            printReport.ShowPreview();
        }
    }
}
