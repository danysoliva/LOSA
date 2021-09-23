using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Despachos.Reportes
{
    public partial class frm_plan : DevExpress.XtraReports.UI.XtraReport
    {
        public int Id_despachos;
        DataOperations dp = new DataOperations();
        public frm_plan(int Pid_despacho)
        {
            InitializeComponent();
            Id_despachos = Pid_despacho;
            load_header();
            load_detalle();
        }

        public void load_header() 
        {
            string query = @"sp_data_load_rpt_plan_v1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id_despachos);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtid_documento.Text = Id_despachos.ToString();
                    txtfecha.Text = string.Format("{0:dd/MM/yyyy}", dr.GetDateTime(2));
                    txtvehiculo.Text = dr.GetString(5);
                    txtboleta.Text = dr.GetInt32(3).ToString();
                    txtfurgon.Text = dr.GetString(6);
                    txtcodigoCLiente.Text = dr.GetString(7);
                    txtcliente.Text = dr.GetString(9);

                }
               
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_detalle() 
        {
            string query = @"sp_data_load_rpt_plan_detalle_v1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id_despachos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporte1.detalle.Clear();
                da.Fill(dsReporte1.detalle);
                cn.Close();
            }
            catch (Exception ex )
            {

                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
