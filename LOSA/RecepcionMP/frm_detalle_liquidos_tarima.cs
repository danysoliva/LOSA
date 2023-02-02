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
using ACS.Classes;
using LOSA.Clases;
using LOSA.Reportes;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frm_detalle_liquidos_tarima : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int numero_ingreso;
        UserLogin UsuarioLogeado;
        string itemcode;

        public frm_detalle_liquidos_tarima(int pnumero_ingreso, UserLogin pUserLogin, string pItemcode)
        {
            InitializeComponent();
            numero_ingreso = pnumero_ingreso;
            UsuarioLogeado = pUserLogin;
            itemcode = pItemcode;

            load_data();
        }

        private void load_data()
        {
            //string Query = @"sp_load_resumen_ingreso_granel
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand("[sp_load_resumen_ingreso_liquidos]", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_ingreso", numero_ingreso);
                dsingresos1.ingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsingresos1.ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repostPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd_data.FocusedView;
            var row = (dsingresos.ingresoRow)gridview.GetFocusedDataRow();

            try
            {
                rptLoteRotulo report = new rptLoteRotulo(numero_ingreso, true);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }
    }
}