using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class DetallePlanillaHE
    {

        public Int64 id { get; set; }
        public int id_h { get; set; }
        public string codigo { get; set; }
        public string empleado_nombre { get; set; }
        public string identidad { get; set; }
        public string cargo { get; set; }
        public decimal Salario_basico_total { get; set; }
        public decimal HE_25 { get; set; }
        public decimal HE_50 { get; set; }
        public decimal HE_75 { get; set; }
        public decimal HE_100 { get; set; }
        public decimal PHE_25 { get; set; }
        public decimal PHE_50 { get; set; }
        public decimal PHE_75 { get; set; }
        public decimal PHE_100 { get; set; }
        public decimal Total_Horas_Extra { get; set; }
        public bool Recuperado { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DetallePlanillaHE() { }

        public bool FillDetallePlanillaVariables(Int64 idParam)
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            string connectionString = dp.ConnectionStringLOSA; // Reemplaza con tu cadena de conexión
            string query = "SELECT [id], [id_h], [codigo], [empleado_nombre], [identidad]," +
                                " [cargo], [Salario_basico_total], [HE_25], [HE_50]," +
                                " [HE_75], [HE_100], [PHE_25], [PHE_50], [PHE_75], [PHE_100]," +
                                " [Total_Horas_Extra] " +
                            "FROM [LOSA].[dbo].[RRHH_Detalle_PlanillaHE] " +
                            "WHERE id = @idParam";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idParam", idParam);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        id = Convert.ToInt64(reader["id"]);
                        id_h = Convert.ToInt32(reader["id_h"]);
                        codigo = reader["codigo"].ToString();
                        empleado_nombre = reader["empleado_nombre"].ToString();
                        identidad = reader["identidad"].ToString();
                        cargo = reader["cargo"].ToString();
                        Salario_basico_total = Convert.ToDecimal(reader["Salario_basico_total"]);
                        HE_25 = Convert.ToDecimal(reader["HE_25"]);
                        HE_50 = Convert.ToDecimal(reader["HE_50"]);
                        HE_75 = Convert.ToDecimal(reader["HE_75"]);
                        HE_100 = Convert.ToDecimal(reader["HE_100"]);
                        PHE_25 = Convert.ToDecimal(reader["PHE_25"]);
                        PHE_50 = Convert.ToDecimal(reader["PHE_50"]);
                        PHE_75 = Convert.ToDecimal(reader["PHE_75"]);
                        PHE_100 = Convert.ToDecimal(reader["PHE_100"]);
                        Total_Horas_Extra = Convert.ToDecimal(reader["Total_Horas_Extra"]);
                        Recuperado = true;
                    }

                    reader.Close();
                }

                connection.Close();
            }
            return Recuperado;
        }

    }
}
