using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using ACS.Classes;
using System.Data;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class subReportCalculoMeses : DevExpress.XtraReports.UI.XtraReport
    {
        public int anio;  
        public subReportCalculoMeses()
        {
            InitializeComponent();

            //LoadVacaciones();
        }


        private void subReportCalculoMeses_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRSubreport xrSubReport = (XRSubreport)sender;
           
            //DetailReport subRep = xrSubReport.ReportSource as DetailReport;
            //subRep.Parameters["CatID"].Value = Convert.ToInt32(GetCurrentColumnValue("CategoryID"));
            
        }

        private void LoadVacaciones()
        {
            try
            {

                DataOperations dp = new DataOperations();
                string query = @"public.ft_get_vacaciones_liquidacion";
                PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                conn.Open();
                PgSqlCommand cmd = new PgSqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pyears", PgSqlType.Int).Value = anio;
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                //dsRRHH_1.liquidacion_vac.Clear();
                //adat.Fill(dsRRHH_1.liquidacion_vac);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
