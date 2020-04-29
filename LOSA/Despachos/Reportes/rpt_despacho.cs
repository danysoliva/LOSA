using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using System.Data;

namespace LOSA.Despachos.Reportes
{
    public partial class rpt_despacho : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int ParId;
        public rpt_despacho(int idDespacho)
        {
            InitializeComponent();
            ParId = idDespacho;
            load_informacio();
        }
        public void load_informacio()
        {
            string Query = @"EXEC	[dbo].[sp_load_despacho_header]
		                            @iddespacho = @ID";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ParId;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCardCode.Text = dr.GetString(1);
                    txtCardName.Text = dr.GetString(2);
                    txtItemCode.Text = dr.GetString(3);
                    txtItemName.Text = dr.GetString(4);
                    txtcantidad.Text = dr.GetInt32(7).ToString();
                    txtplaca.Text    = dr.GetString(9);
                    txtfurgon.Text   = dr.GetString(10);
                }
                dr.Close();
                cn.Close();

                Query  = @"EXEC [dbo].[sp_load_despacho_detalle]
		                        @iddespacho = @ID";
                SqlConnection Conexion = new SqlConnection(dp.ConnectionStringLOSA);
                Conexion.Open();
                SqlCommand Comando = new SqlCommand(Query, cn);
                Comando.Parameters.Add("@ID", SqlDbType.Int).Value = ParId;
                SqlDataAdapter da  = new SqlDataAdapter(Comando);
                ds_despachos1.despachos.Clear();
                da.Fill(ds_despachos1.despachos);
                Conexion.Close();

            }
            catch (Exception ex)
            {
                
            }
         

        }

    }
}
