using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Reportes
{
    
    public partial class rptIngresoHoja : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int Id;
            
        public rptIngresoHoja(int Pid)
        {
            InitializeComponent();
            Id = Pid;
            load_data();
            load_detalle();
            load_lote();
        }
        public void load_data()
        {
            string query = @"sp_load_informacion_ingreso";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_ingreso", Id );
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtoc.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                txtsap.Text = dr.IsDBNull(12) ? "" : dr.GetString(12).ToString();
                txtingreso.Text = dr.IsDBNull(1) ? "" : dr.GetInt32(1).ToString();
                dtingreso.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                txtUserIngreso.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                txtproveedor.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                txtboleta.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                txtfactura.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                txtunidades.Text = dr.IsDBNull(8) ? "" : dr.GetDecimal(8).ToString();
                txtransporte.Text = dr.IsDBNull(10) ? "" : dr.GetString(10).ToString();
                txtconductor.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                txtplaca.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
            }
            dr.Close();
            cn.Close();
        }
         public void load_detalle()
        {
            try
            {
                string query = @"sp_load_main_data_rpt_ingreso";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id);
                dsReportes1.IngresoDetalle.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes1.IngresoDetalle);
                cn.Close();
            }
            catch (Exception ex)
            {
              
            }

        }

        public void load_lote()
        {
            try
            {
                string query = @"sp_rpt_print_detalle_lote";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id);
                dsReportes1.Lote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes1.Lote);
                cn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void ReportHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
             

        }
    }
}
