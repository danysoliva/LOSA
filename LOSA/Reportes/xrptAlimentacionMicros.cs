using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Reportes
{
    public partial class xrptAlimentacionMicros : DevExpress.XtraReports.UI.XtraReport
    {
        int Pid;
        int Pencabezado;
        DataOperations dp = new DataOperations();
        public xrptAlimentacionMicros(int idm, int id_encabezado)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            Pid = idm;
            Pencabezado = id_encabezado;
            Load_detalle();
            load_Encabezado();
            load_cantidades();
        }

        public void load_cantidades() 
        {
            try
            {
                string query = @"sp_load_op_reporte_detalle_micro_ingrediente";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ami_id", Pid);
                cmd.Parameters.AddWithValue("@id_orden", Pencabezado);
                dsReportes2.detalle_rpt_5toNivel.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes2.detalle_rpt_5toNivel);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void Load_detalle() 
        {
            string query = @"sp_load_op_reporte_detalle_micro_ingrediente";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ami_id", Pid);
                cmd.Parameters.AddWithValue("@id_orden", Pencabezado);
                dsReportes2.detalle_rpt_micros.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes2.detalle_rpt_micros);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_Encabezado()
        {
            string query = @"sp_load_encabezado_reporte_micros";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ami_id", Pid);
                cmd.Parameters.AddWithValue("@id_orden", Pencabezado);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtFecha.Text = string.Format("{0:dd/MM/yyyy}", dr.GetDateTime(1));
                    txtlote.Text = dr.GetInt32(2).ToString();
                    txtcodigoPT.Text = dr.GetString(5);
                    txtturno.Text = dr.GetString(7);
                    txtformula.Text = dr.GetString(6);
                    txtproducto.Text = dr.GetString(4);
                    txt_barcode.Text = dr.GetInt32(9).ToString();
                    batchpesados.Text = dr.GetInt32(8).ToString();
                    txtnumero.Text = Pid.ToString();

                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

       

    }
}
