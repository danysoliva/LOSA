using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS.Produccion.TemperaturaMaquinas.Model
{
    class Transaccion_H
    {
        public Int64 ID { get; set; }
        public Int64 OrdenID { get; set; }
        public int Estado { get; set; }
        public Int64 NumOrden { get; set; }
        public string CodeOrdenPRD { get; set; }
        public Int64 LotePT { get; set; }
        public string ProductoTerminado { get; set; }
        public int FormulaCod { get; set; }
        public int VersionFormula { get; set; }
        public DateTime FechaCreacion { get; set; }
        Boolean Recuperado;


        public Boolean RecuperaRegistro(Int64 id)
        {
            try
            {
            DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

                SqlCommand cmd = new SqlCommand("dbo.sp_get_transaccion_temperatura_maquinas_by_id", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;

                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ID = id;
                    OrdenID = dr.GetInt64(0);
                    Estado = dr.GetInt32(1);
                    NumOrden = dr.GetInt64(2);
                    CodeOrdenPRD = dr.GetString(3);
                    LotePT = dr.GetInt64(4);
                    ProductoTerminado = dr.GetString(5);
                    FormulaCod = dr.GetInt32(6);
                    VersionFormula = dr.GetInt32(7);
                    FechaCreacion = dr.GetDateTime(8);
                    Recuperado = true;
                }


                cnx.Close();

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
