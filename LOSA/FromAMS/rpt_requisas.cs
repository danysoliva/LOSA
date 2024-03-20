using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using AMS.Clases;

namespace AMS.Compras.ControlInv
{
    public partial class rpt_requisas : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public long id;
        public rpt_requisas(long Pid)
        {
            InitializeComponent();
            id = Pid;
            load_Data();
        }
        public void load_Data()
        {
            string query = @"sp_rpt_req_header";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcodigo.Text = dr.GetString(0);
                    lblfecha.Text = dr.GetDateTime(1).ToString("yyyy-MM-dd");
                    txtcomentario.Text = dr.GetString(2);
                    txtnumero.Text = dr.GetString(3);
                    lblcodigo.Text = dr.GetString(0);
                }
                dr.Close();
                cn.Close();

                cn.Open();
                query = @"sp_rpt_req_details";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", id);
                dsControlInv1.red_rpt_d.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv1.red_rpt_d);
                cn.Close();
                cn.Open();
                query = @"sp_rpt_req_details_nacionales";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", id);
                dsControlInv1.red_rpt_d_nacionales.Clear();
                 da = new SqlDataAdapter(cmd);
                da.Fill(dsControlInv1.red_rpt_d_nacionales);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
