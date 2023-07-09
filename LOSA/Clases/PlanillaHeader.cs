using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Clases
{
    public class PlanillaHeader
    {
        public Int64 id;
        public string Empresa;
        public DateTime Fecha;
        public string Titulo;
        public DateTime fecha_desde;
        public DateTime fecha_hasta;
        public bool enable;
        public string currency;
        public string nota;
        public int tipo;
        public bool Recuperado;
        DataOperations dp;

        public PlanillaHeader()
        {
            dp = new DataOperations();
            Recuperado = false;
        }

        public bool FillEncabezadoPlanillaVariables(Int64 pid)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringLOSA; // Reemplaza con tu cadena de conexión
            string query = "SELECT [id], [Empresa], [Fecha], [Titulo], " +
                            "[fecha_desde], [fecha_hasta], [enable], [currency], [nota], [tipo] " +
                            "FROM [LOSA].[dbo].[RRHH_Encabezado_Planilla]" +
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
                            id = Convert.ToInt32(reader["id"]);
                            Empresa = reader["Empresa"].ToString();
                            Fecha = Convert.ToDateTime(reader["Fecha"]);
                            Titulo = reader["Titulo"].ToString();
                            fecha_desde = Convert.ToDateTime(reader["fecha_desde"]);
                            fecha_hasta = Convert.ToDateTime(reader["fecha_hasta"]);
                            enable = Convert.ToBoolean(reader["enable"]);
                            currency = reader["currency"].ToString();
                            nota = reader["nota"].ToString();
                            tipo = Convert.ToInt32(reader["tipo"]);
                            // Realiza la lógica deseada con los valores obtenidos

                            Recuperado = true;
                        }

                        reader.Close();
                    }

                    connection.Close();
                }
            }
            catch(Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return this.Recuperado;
        }
        
    }
}
