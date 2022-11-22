using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;
using System.Data;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Report_v2 : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int id;
        public PRB_Report_v2(int id)
        {
            InitializeComponent();
            this.id = id;
            load_data();
            LoadResumenProduccion();
            LoadCausas();
        }

        private void LoadCausas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("PRB_get_causas_reporte_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                ds_reportprod1.lista_paros.Clear();
                adat.Fill(ds_reportprod1.lista_paros);

                cmd = new SqlCommand("PRB_get_causas_reporte_produccion_total", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.id);
                adat = new SqlDataAdapter(cmd);
                adat.Fill(ds_reportprod1.lista_paros);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadResumenProduccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("PRB_load_data_resumen_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.Parameters.AddWithValue("@idmaq", 1);//Pellet 1
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p1Rendimiento.Text = string.Format("{0:0.00}", dr.GetDecimal(0));
                    p1TM.Text = string.Format("{0:0.00}", dr.GetDecimal(1));
                    p1Horas.Text = string.Format("{0:0.00}", dr.GetDecimal(2));
                }
                dr.Close();


                cmd = new SqlCommand("PRB_load_data_resumen_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.Parameters.AddWithValue("@idmaq", 2);//Pellet 2
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p2Rendimiento.Text = string.Format("{0:0.00}", dr.GetDecimal(0));
                    p2TM.Text = string.Format("{0:0.00}", dr.GetDecimal(1));
                    p2Horas.Text = string.Format("{0:0.00}", dr.GetDecimal(2));
                }
                dr.Close();


                cmd = new SqlCommand("PRB_load_data_resumen_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.Parameters.AddWithValue("@idmaq", 3);//Extruder
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    exRendimiento.Text = string.Format("{0:0.00}", dr.GetDecimal(0));
                    exTM.Text = string.Format("{0:0.00}", dr.GetDecimal(1));
                    exHoras.Text = string.Format("{0:0.00}", dr.GetDecimal(2));
                }
                dr.Close();

                totalHoras.Text = string.Format("{0:0.00}", (Convert.ToDecimal(p1Horas.Text) + Convert.ToDecimal(p2Horas.Text) + Convert.ToDecimal(exHoras.Text)));
                totalTM.Text = string.Format("{0:0.00}", (Convert.ToDecimal(p1TM.Text) + Convert.ToDecimal(p2TM.Text) + Convert.ToDecimal(exTM.Text)));
                decimal horas = Convert.ToDecimal(totalHoras.Text);

                if (horas > 0)
                    totalRendimiento.Text = string.Format("{0:0.00}", (Convert.ToDecimal(totalTM.Text) / Convert.ToDecimal(totalHoras.Text)));
                else
                    totalRendimiento.Text = "";

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void load_data()
        {
            string query = @"EXEC  [dbo].[PRB_load_data_of_report_H] @id = " + id + ";";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblrespontasable.Text = lblrespontasable.Text + " " + dr[0].ToString();
                    lblturno.Text = lblturno.Text + " " + dr[1].ToString();
                    lblini.Text = lblini.Text + " " + Convert.ToDateTime(dr[4].ToString()).ToString("dd/MM/yyyy");
                    lblfin.Text = lblfin.Text = "Fecha final: " + Convert.ToDateTime(dr[5].ToString()).ToString("dd/MM/yyyy");
                    lblhoras.Text = lblhoras.Text = "Horas: " + dr[3].ToString();
                    cn.Close();
                }
                //tilapia
                cn.Open();
                string querydata = @"EXEC	[dbo].[PRB_load_data_of_report_v2] @id = "+id+", @especie = 1";
                cmd = new SqlCommand(querydata, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_reportprod1.tilapia.Clear();
                da.Fill(ds_reportprod1.tilapia);
                
                //camaron
                querydata = @"EXEC	[dbo].[PRB_load_data_of_report_v2] @id = " + id + ", @especie = 2";
                cmd = new SqlCommand(querydata, cn);
                da = new SqlDataAdapter(cmd);
                ds_reportprod1.camaron.Clear();
                da.Fill(ds_reportprod1.camaron);
                cn.Close();
                int canTil = 0;
                int canCam = 0;
                foreach (DataRow row in ds_reportprod1.tilapia.Rows)
                {
                    canTil = canTil + 1;
                }
                foreach (DataRow row in ds_reportprod1.camaron.Rows)
                {
                    canCam = canCam + 1;
                }
                if (canTil >= 1)
                {
                    DetailReport.Visible = true;
                }
                else
                {
                    DetailReport.Visible = false;
                }

                if (canCam >= 1)
                {
                    DetailReport2.Visible = true;
                }
                else
                {
                    DetailReport2.Visible = false;

                }
                decimal mix1 = 0;
                decimal mix2 = 0;
                decimal flus = 0;
                decimal noconf = 0;
                decimal humedad = 0;
                decimal horas = 0;
                decimal rendimiento = 0;
                decimal repro = 0;
                decimal arrem = 0;
                decimal ton = 0;
                decimal bagprod = 0;

                foreach (DataRow  row in ds_reportprod1.tilapia)
                {
                    mix1 = mix1 + Convert.ToDecimal(row["mix1"].ToString());
                     mix2 = mix2 + Convert.ToDecimal(row["mix2"].ToString());
                     flus = flus + Convert.ToDecimal(row["flushing"].ToString());
                     noconf = noconf + Convert.ToDecimal(row["prod_noconf"].ToString());
                     humedad = humedad + Convert.ToDecimal(row["humedad"].ToString());
                     horas = horas + Convert.ToDecimal(row["horasMa"].ToString());
                     rendimiento = rendimiento + Convert.ToDecimal(row["rendimiento"].ToString());
                     repro = repro + Convert.ToDecimal(row["reproceso"].ToString());
                     arrem = arrem + Convert.ToDecimal(row["prod_arran"].ToString());
                    ton = ton + Convert.ToDecimal(row["Ton_produc"].ToString());
                    bagprod = bagprod + Convert.ToDecimal(row["bag_prod"].ToString());
                }
                lblmix1til.Text = mix1.ToString();
                lblmix2til.Text = mix2.ToString();
                lblflus1til.Text = flus.ToString();
                lblhum1til.Text = humedad.ToString();
                lblhor1til.Text = horas.ToString();
                lblren1til.Text = rendimiento.ToString();
                lblrep1til.Text = repro.ToString();
                lblarran1til.Text = arrem.ToString();
                lblton1til.Text = ton.ToString();
                txtbagprodTilapia.Text = bagprod.ToString();
                 mix1 = 0;
                 mix2 = 0;
                 flus = 0;
                 noconf = 0;
                 humedad = 0;
                 horas = 0;
                 rendimiento = 0;
                 repro = 0;
                 arrem = 0;
                 ton = 0;
                bagprod = 0;
                foreach (DataRow row in ds_reportprod1.camaron)
                {
                    mix1 = mix1 + Convert.ToDecimal(row["mix1"].ToString());
                    mix2 = mix2 + Convert.ToDecimal(row["mix2"].ToString());
                    flus = flus + Convert.ToDecimal(row["flushing"].ToString());
                    noconf = noconf + Convert.ToDecimal(row["prod_noconf"].ToString());
                    humedad = humedad + Convert.ToDecimal(row["humedad"].ToString());
                    horas = horas + Convert.ToDecimal(row["horasMa"].ToString());
                    rendimiento = rendimiento + Convert.ToDecimal(row["rendimiento"].ToString());
                    repro = repro + Convert.ToDecimal(row["reproceso"].ToString());
                    arrem = arrem + Convert.ToDecimal(row["prod_arran"].ToString());
                    ton = ton + Convert.ToDecimal(row["Ton_produc"].ToString());

                    bagprod = bagprod + Convert.ToDecimal(row["bag_prod"].ToString());
                }
                lblmix1cam.Text = mix1.ToString();
                lblmix2cam.Text = mix2.ToString();
                lblflucam.Text = flus.ToString();
                lblhumcam.Text = humedad.ToString();
                lblhorcam.Text = horas.ToString();
                lblrencam.Text = rendimiento.ToString();
                lblrepcam.Text = repro.ToString();
                lblarrancam.Text = arrem.ToString();
                lbltoncam.Text = ton.ToString();
                txtbagprodcamaron.Text = bagprod.ToString();
            }
            catch (Exception ex)
            {

                xrLabel1.Text = ex.Message;
            }
        }
    }
}
