using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MigracionACS.RRHH.Encuesta.Model
{
   public class Encuesta_Master_Header
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Instrucciones { get; set; }
        public DateTime Fecha { get; set; }
        public int AnioEvaluar { get; set; }
        public Boolean Recuperado { get; set; }


        public Boolean RecupeRaregistro()
        {
            try
            {
                DataOperations dp = new DataOperations();

                string query = @"SELECT id,
                                   descripcion,
                                   instrucciones,
                                   enable,
                                   fecha,
                                   codigo,
	                               anio_evaluar
                            FROM dbo.encuesta_master_header WHERE enable = 1";

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAMS))
                {
                  SqlCommand cmd = new SqlCommand(query,cnx);

                    cnx.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ID = dr.GetInt32(0);
                        Nombre = dr.GetString(1);
                        Instrucciones = dr.GetString(2);
                        Codigo = dr.GetString(5);
                        AnioEvaluar = dr.GetInt32(6);
                        Recuperado = true;
                    }

                    cnx.Close();


                }


                return Recuperado;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

                return false;
            }

        }
    }
}
