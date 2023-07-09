using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Clases
{
    public class DetallePlanilla
    {
        public Int64 id;
        public int Id_h;
        public string Codigo;
        public string Empleado;
        public string Identidad;
        public string Cargo;
        public int Dias_Vacaciones;
        public int Dias_Faltados;
        public int Dias_Laborados;
        public decimal Salario_basico_total;
        public decimal Vacaciones;
        public decimal Transporte;
        public decimal Otros_Ingresos;
        public decimal Total_Ingresos;
        public decimal Ahorro_fijo_Coop;
        public decimal Bancos;
        public decimal Prestamo_Coop;
        public decimal Cafeteria;
        public decimal Ahorro_Ret_Coop;
        public decimal Otras_deducciones_coop;
        public decimal Plan_dental;
        public decimal Seguro_Medico;
        public decimal USULA;
        public decimal IHSS_T;
        public decimal INCAPACIDADES;
        public decimal ISR;
        public decimal Total_Egresos;
        public decimal Salario_neto;
        DataOperations dp;
        public bool Recuperado;


        public DetallePlanilla()
        {
            dp = new DataOperations();
            Recuperado = false;
        }



        public bool FillDetallePlanillaVariables(Int64 pid)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringLOSA; // Reemplaza con tu cadena de conexión
            string query = "SELECT [id], [id_h], [Codigo], [Empleado], [Identidad], [Cargo], [Dias_Vacaciones], [Dias_Faltados], " +
                           "[Dias_Laborados], [Salario_basico_total], [Vacaciones], [Transporte], [Otros_Ingresos], [Total_Ingresos], " +
                           "[Ahorro_fij_Coop], [Bancos], [Prestamo_Coop], [Cafeteria], coalesce([Ahorro_Ret_Coop],0)as [Ahorro_Ret_Coop], [Otras_deducciones_coop], " +
                           "[Plan_dental], [Seguro_Medico], [USULA], [IHSS_T], [INCAPACIDADES], [ISR], [Total_Egresos], [Salario_neto] " +
                           "FROM [LOSA].[dbo].[RRHH_Detalle_Planilla] " +
                           " where [id] = " + pid.ToString();
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            id = Convert.ToInt64(reader["id"]);
                            Id_h = Convert.ToInt32(reader["id_h"]);
                            Codigo = reader["Codigo"].ToString();
                            Empleado = reader["Empleado"].ToString();
                            Identidad = reader["Identidad"].ToString();
                            Cargo = reader["Cargo"].ToString();
                            Dias_Vacaciones = Convert.ToInt32(reader["Dias_Vacaciones"]);
                            Dias_Faltados = Convert.ToInt32(reader["Dias_Faltados"]);
                            Dias_Laborados = Convert.ToInt32(reader["Dias_Laborados"]);
                            Salario_basico_total = Convert.ToDecimal(reader["Salario_basico_total"]);
                            Vacaciones = Convert.ToDecimal(reader["Vacaciones"]);
                            Transporte = Convert.ToDecimal(reader["Transporte"]);
                            Otros_Ingresos = Convert.ToDecimal(reader["Otros_Ingresos"]);
                            Total_Ingresos = Convert.ToDecimal(reader["Total_Ingresos"]);
                            Ahorro_fijo_Coop = Convert.ToDecimal(reader["Ahorro_fij_Coop"]);
                            Bancos = Convert.ToDecimal(reader["Bancos"]);
                            Prestamo_Coop = Convert.ToDecimal(reader["Prestamo_Coop"]);
                            Cafeteria = Convert.ToDecimal(reader["Cafeteria"]);
                            Ahorro_Ret_Coop = Convert.ToDecimal(reader["Ahorro_Ret_Coop"]);
                            Otras_deducciones_coop = Convert.ToDecimal(reader["Otras_deducciones_coop"]);
                            Plan_dental = Convert.ToDecimal(reader["Plan_dental"]);
                            Seguro_Medico = Convert.ToDecimal(reader["Seguro_Medico"]);
                            USULA = Convert.ToDecimal(reader["USULA"]);
                            IHSS_T = Convert.ToDecimal(reader["IHSS_T"]);
                            INCAPACIDADES = Convert.ToDecimal(reader["INCAPACIDADES"]);
                            ISR = Convert.ToDecimal(reader["ISR"]);
                            Total_Egresos = Convert.ToDecimal(reader["Total_Egresos"]);
                            Salario_neto = Convert.ToDecimal(reader["Salario_neto"]);
                            Recuperado = true;
                        }

                        reader.Close();
                    }

                    connection.Close();
                }
            }
            catch(Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }





    }

}
