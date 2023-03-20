using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace LOSA.Calidad
{
    public partial class rptReporteAlimentacionTarimasMP : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime dtDesde, dtHasta;
        public rptReporteAlimentacionTarimasMP(DateTime pdtDesde, DateTime pdthasta)
        {
            InitializeComponent();

            dtDesde = pdtDesde;
            dtHasta = pdthasta;
            lblFecha.Text = Convert.ToString(dtDesde +" a "+ dtHasta); 
            LoadDataAliemntacionTarima(dtDesde, dtHasta);
        }

        private void xrPanel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void LoadDataAliemntacionTarima(DateTime pdtDesde, DateTime pdtHasta)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_cola_lote_consumido_rpt]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dtDesde", pdtDesde);
                cmd.Parameters.AddWithValue("@dtHasta", pdtHasta);
                dsCalidad1.Consumido.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCalidad1.Consumido);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
