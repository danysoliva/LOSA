using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Reportes
{
    public partial class rptLoteRotulo : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public int Id_detalle;
        public rptLoteRotulo(int pId)
        {
            InitializeComponent();
            Id_detalle = pId;
            load_data();

        }
        public void load_data()
        {
            string query = @"rpt_load_informacion_ingreso_lote";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddetalle", Id_detalle);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                     txtmp.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                     txtproveedor.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                     txtfechaIng.Text = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).ToString("dd/MM/yyyy");
                     txtingreso.Text = dr.IsDBNull(3) ? "" : dr.GetInt32(3).ToString();
                     txtsacos.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString(); 
                      txtfproduccion.Text = dr.IsDBNull(5) ? "" : dr.GetDateTime(5).ToString("dd/MM/yyyy");
                     txtfvencimiento.Text = dr.IsDBNull(6) ? "" : dr.GetDateTime(6).ToString("dd/MM/yyyy");
                    txtrack.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
                    txtlote.Text = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    txtCodigos.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex) 
            {

                CajaDialogo.Error(ex.Message);
            }

        }

    }
}
