using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using System.Data.SqlClient;
using System.Data;

namespace LOSA.MigracionACS.Produccion
{
    public partial class ProgramaProduccion : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp;
        int varPedido;
        public ProgramaProduccion(int PId_Pedido, string pUser)
        {
            InitializeComponent();
            try
            {
                varPedido = PId_Pedido;
                dp = new DataOperations();
                string ObtenerDates;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                lblImpreso.Text = pUser + " - " + string.Format("{0:MM/dd/yyyy HH:mm}", dp.Now());
                cn.Open();
                ObtenerDates = @"SELECT 
                                   coalesce((SELECT CONVERT (char(10), [dbo].[PT_Pedido].fecha_ini, 110)), ' ') as fecha_ini
                                   ,coalesce((SELECT CONVERT (char(10), [dbo].[PT_Pedido].fecha_fin, 110)), ' ') as fecha_fin 
                            FROM [dbo].[PT_Pedido]
                            Where id_Pedido = " + varPedido;
                SqlCommand cmdate = new SqlCommand(ObtenerDates, cn);
                SqlDataReader dr = cmdate.ExecuteReader();
                if (dr.Read())
                {
                    xrLabelDesde.Text = dr.GetString(0);
                    xrLabelHasta.Text = dr.GetString(1);
                }
                cn.Close();


                cn.Open();
                string QryCam;
                QryCam = @"EXEC	[dbo].[Reporteloadbyspice] @IdPedido = " + varPedido + ",@Especie = 2";

                SqlCommand cmmd = new SqlCommand(QryCam, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmmd);
                dsProductos1.ReporteCamaron.Clear();
                da.Fill(dsProductos1.ReporteCamaron);

                SqlCommand cmd;
                string Querys;
                Querys = @"EXEC [dbo].[Reporteloadbyspice] @IdPedido = " + varPedido + ",@Especie = 1";
                cmd = new SqlCommand(Querys, cn);
                SqlDataAdapter sqld = new SqlDataAdapter(cmd);
                dsProductos1.ReporteTilapia.Clear();
                sqld.Fill(dsProductos1.ReporteTilapia);
                cn.Close();
                Decimal sum = 0;
                decimal sacos = 0;
                decimal batch = 0;
                foreach (DataRow row in dsProductos1.ReporteCamaron.Rows)
                {
                    if (row["Peso_pedido"] != DBNull.Value)
                    {
                        sum = sum + Convert.ToDecimal(dp.Isnulldata(row["Peso_pedido"]));
                        sacos = sacos + Convert.ToDecimal(dp.Isnulldata(row["Sacos"]));
                        batch = batch + Convert.ToDecimal(dp.Isnulldata(row["batch"]));
                    }
                }
                xrLabel149.Text = " " + string.Format("{0:###,##0.0 TM} ", sum);
                xrLabel23.Text  = " " + string.Format("{0:###,##0.0 } ", batch);
                xrLabel20.Text = " " + string.Format("{0:###,##0.0 Ud.} ", sacos);
                sum = 0;
                batch = 0;
                sacos = 0;
                foreach (DataRow drr in dsProductos1.ReporteTilapia.Rows)
                {
                    if (drr["Peso_pedido"] != DBNull.Value)
                    { 
                        sum = sum + Convert.ToDecimal(dp.Isnulldata(drr["Peso_pedido"]));
                        sacos = sacos + Convert.ToDecimal(dp.Isnulldata(drr["Sacos"]));
                        batch = batch + Convert.ToDecimal(dp.Isnulldata(drr["batch"]));
                    }
                    //xrLabel150.Text = sum.ToString() + " TON." ;
                }
                xrLabel18.Text = " " + string.Format("{0:###,##0.0 TM} ", sum);
                xrLabel22.Text = " " + string.Format("{0:###,##0.0 } ", batch);
                xrLabel21.Text = " " + string.Format("{0:###,##0.0 Ud.} ", sacos);


            }
            catch (Exception)
            {
               // "Error en el proceso revise los datos."
                CajaDialogo.Error("Error en el proceso revise los datos.");
            } 
           
            


        }

        private void xrLine6_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void ReportFooter_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
