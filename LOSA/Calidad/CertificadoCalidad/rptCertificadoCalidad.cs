using ACS.Classes;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace LOSA.Calidad.CertificadoCalidad
{
    public partial class rptCertificadoCalidad : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCertificadoCalidad(int id_certificado,int lote)
        {
            InitializeComponent();

            CertificadoPT_H certificado = new CertificadoPT_H();

            if (id_certificado!= 0)
            {
                if (certificado.RecuperaRegistro(id_certificado))
                {
                    tcAlimento.Text = certificado.Alimento;
                    tcFechaAnalisis.Text = certificado.FechaAnalisis.ToShortDateString();
                    tcFechaElaboracion.Text = certificado.FechaProduccion.ToShortDateString();
                    tcFechaVencimiento.Text = certificado.FechaVencimiento.ToShortDateString();
                    tcFFIF.Text = certificado.FFIF;
                    tcLote.Text = certificado.Lote_PT.ToString();
                    xrUsuarioC.Text = certificado.Nombre_usuario;
                }
            }
            else
            {
                if (certificado.RecuperaRegistroPorLote(lote))
                {
                    tcAlimento.Text = certificado.Alimento;
                    tcFechaAnalisis.Text = certificado.FechaAnalisis.ToShortDateString();
                    tcFechaElaboracion.Text = certificado.FechaProduccion.ToShortDateString();
                    tcFechaVencimiento.Text = certificado.FechaVencimiento.ToShortDateString();
                    tcFFIF.Text = certificado.FFIF;
                    tcLote.Text = certificado.Lote_PT.ToString();
                    xrUsuarioC.Text = certificado.Nombre_usuario;

                }
            }

            load_certificado_detalle(certificado.ID);
        }




        public void load_certificado_detalle(int lote)
        {
            string query = @"dbo.uspGetDetailCertificatePTFromRPT";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_h", lote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCertificado1.rptCertificadoDetalle.Clear();
                da.Fill(dsCertificado1.rptCertificadoDetalle);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }



    }
}
