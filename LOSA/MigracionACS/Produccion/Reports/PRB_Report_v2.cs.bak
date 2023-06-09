using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using System.Data;

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class PRB_Report_v2 : DevExpress.XtraReports.UI.XtraReport
    {
        int Varid;
        DataOperations dp;
        public PRB_Report_v2(int Parid)
        {
            InitializeComponent();
            Varid = Parid;
            dp = new DataOperations();
            load_data();
        }
        public void load_data()
        {//===============================================Cargado de Header===============================

            try
            {
                string Query;
                Query = @"EXEC  [dbo].[PRB_load_data_of_report_H] @id = " + Varid;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cms = new SqlCommand(Query, cn);
                //SqlDataAdapter da = new SqlDataAdapter(cms);
                //prB_DATA1.Header.Clear();
                //da.Fill(prB_DATA1.Header);
                SqlDataReader dr = cms.ExecuteReader();
                if (dr.Read())
                {
                    xrLabel2.Text = dr.GetString(0);
                    xrLabel4.Text = dr.GetString(1);
                    xrLabel6.Text = Convert.ToString(dr.GetInt32(2));
                    xrLabel15.Text = Convert.ToString(dr.GetTimeSpan(3));
                    xrLabel8.Text = Convert.ToString(dr.GetDateTime(4));
                    xrLabel10.Text = Convert.ToString(dr.GetDateTime(5));

                }
                dr.Close();


                //==================================================== Cargado de Detalle===========================================
                string Data;
                Data = @"EXEC [dbo].[PRB_load_data_of_report] @id = " + Varid;
                SqlCommand cmd = new SqlCommand(Data, cn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                prB_DATA1.Descripcion.Clear();
                dap.Fill(prB_DATA1.Descripcion);
                string algo = "";
                cn.Close();
                int mix1 = 0, mix2 = 0, conformes = 0, noconformes = 0, producido = 0, flushing = 0, reproceso = 0, arranque = 0;
                decimal toneladProd =0, humedad = 0;


                foreach (DataRow row in prB_DATA1.Descripcion)
                {
                    mix1 = mix1 + Convert.ToInt32(row["mix1"].ToString());
                    mix2 = mix2 + Convert.ToInt32(row["mix2"].ToString());
                    conformes = conformes + Convert.ToInt32(row["bag_conf"].ToString());
                    noconformes = noconformes + Convert.ToInt32(row["prod_noconf"].ToString());
                    producido = producido + Convert.ToInt32(row["bag_prod"].ToString());
                    flushing = flushing + Convert.ToInt32(row["flushing"].ToString());
                    humedad = humedad + Convert.ToDecimal(row["humedad"].ToString());
                    reproceso = reproceso + Convert.ToInt32(row["reproceso"].ToString());
                    arranque = arranque + Convert.ToInt32(row["prod_arran"].ToString());
                    toneladProd = toneladProd +Convert.ToDecimal(row["Ton_Produc"].ToString());

                   



                }
                lblmix1.Text = mix1.ToString();
                lblmix2.Text = mix2.ToString();
                lblconf.Text = conformes.ToString();
                lblnoconf.Text = noconformes.ToString();
                lblbag_prod.Text = producido.ToString();
                lblflush.Text = flushing.ToString();
                lblhumedad.Text = humedad.ToString();
                lblrepro.Text = reproceso.ToString();
                lblarran.Text = arranque.ToString();
                lbltotal.Text = toneladProd.ToString();

            }
            catch (Exception ex)
            {

                lbltitle.Text = ex.Message;
            }
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
                    }
    }
}
