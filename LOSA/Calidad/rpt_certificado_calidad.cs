using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Calidad
{
    public partial class rpt_certificado_calidad : DevExpress.XtraReports.UI.XtraReport
    {
        public int NumberLote;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public rpt_certificado_calidad(int PLote, UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            NumberLote = PLote;
            GetLoteInfo();
            GetLoteParametros();
            xrUsuario.Text = UsuarioLogueado.NombreUser;
        }
        public void GetLoteInfo()
        {
            try
            {
                string query = @"sp_get_lote_informacion_certificado_calidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@LotNumber", NumberLote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                drReporteCetificado1.DetalleLote.Clear();
                da.Fill(drReporteCetificado1.DetalleLote);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void GetLoteParametros()
        {
            try
            {
                string query = @"sp_get__parametro_promedio_certificado_calidad_PT";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LotNumber", NumberLote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                drReporteCetificado1.ParametrosLotes.Clear();
                da.Fill(drReporteCetificado1.ParametrosLotes);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
