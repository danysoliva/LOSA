using ACS.Classes;
using DevExpress.XtraSpreadsheet.Import.Xls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class CMRuta_Aprobacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Enable { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int pIdRute)
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
            {
                string query = @"SELECT [id]
                                        ,[descripcion]
                                        ,[enable]
                                    FROM [LOSA].[dbo].[CM_Rutas_de_aprobacion]
                                    where [id] = @id_ruta";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_ruta", pIdRute);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    Id = Convert.ToInt32(reader["id"]);
                    Descripcion = Convert.ToString(reader["descripcion"]);
                    Enable = Convert.ToBoolean(reader["enable"]);
                    //IdRutaSuperior = reader["id_ruta_superior"] != DBNull.Value ? Convert.ToInt32(reader["id_ruta_superior"]) : (int?)null;
                    Recuperado = true;
                }
                else
                {
                    CajaDialogo.Error("No rows returned from the query.");
                }

                reader.Close();
            }
            return Recuperado;
        }
    }
}
