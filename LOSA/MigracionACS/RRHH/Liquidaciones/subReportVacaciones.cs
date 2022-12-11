using DevExpress.XtraReports.UI;
using System.IO;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using ACS.Classes;
using System.Data;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;
using LOSA.Classes;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class subReportVacaciones : DevExpress.XtraReports.UI.XtraReport
    {
        public int IdEmpleadoVar;
        int IdEmpleado;
        int id_liquidacion = 0;
        int anio;
        int dias_tomados;
        decimal diaspendiente = 0;
        int id_liquiObtenido;
        DateTime dtInicio;
        DateTime dtEgreso;
        public subReportVacaciones(int pid_empleado, Liquidacion pliquidacion, int panio)
        {
            //@Id_empleado_par = new DevExpress.XtraReports.Parameters.Parameter();
            
            InitializeComponent();
           

            IdEmpleado = pid_empleado;
            anio = panio;

            LoadIDLIQ(IdEmpleado);


            Liquidacion liqu = new Liquidacion();
            liqu.RecuperarHeaderLiquidacion(id_liquiObtenido);
            dtInicio = liqu.fecha_ingreso;
            dtEgreso = liqu.fecha_egreso;
            //@Id_empleado_par.Value = pid_empleado;
            //@fechai_par.Value = liqu.fecha_ingreso;
            //@fechaf_par.Value = liqu.fecha_egreso;
            CalculoUltimosMeses();

        }

        private void CalculoUltimosMeses()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_salarios_promedios_liquidacion";
                PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                conn.Open();
                PgSqlCommand cmd = new PgSqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pid_empleado", PgSqlType.Int).Value = IdEmpleado;
                cmd.Parameters.Add("fdesde", PgSqlType.Date).Value = dtInicio;
                cmd.Parameters.Add("fhasta", PgSqlType.Date).Value = dtEgreso;
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsRRHH_1.LiquiUltimosMeses.Clear();
                adat.Fill(dsRRHH_1.LiquiUltimosMeses);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
            

        private void LoadIDLIQ(int id_liquidacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_RRHH_liquidacion_header_datos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", IdEmpleado);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    id_liquidacion = DR.GetInt32(0);
                }
                id_liquiObtenido = id_liquidacion;
                DR.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadUltimos6Meses(int IdEmpleado, DateTime dtInicio, DateTime dtEgreso)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_salarios_promedios_liquidacion";
                PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                conn.Open();
                PgSqlCommand cmd = new PgSqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pid_empleado", PgSqlType.Int).Value = IdEmpleado;
                cmd.Parameters.Add("fdesde", PgSqlType.Date).Value = dtInicio;
                cmd.Parameters.Add("fhasta", PgSqlType.Date).Value = dtEgreso;
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsRRHH_1.LiquiUltimosMeses.Clear();
                adat.Fill(dsRRHH_1.LiquiUltimosMeses);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
