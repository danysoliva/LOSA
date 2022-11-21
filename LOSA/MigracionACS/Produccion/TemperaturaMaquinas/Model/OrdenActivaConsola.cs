using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS.Produccion.TemperaturaMaquinas.Model
{
    class OrdenActivaConsola
    {
        public Int64 OrdenID { get; set; }
        public int Estado { get; set; }
        public Int64 NumOrden { get; set; }
        public string CodeOrdenPRD { get; set; }
        public Int64 LotePT { get; set; }
        public string ProductoTerminado { get; set; }
        public int FormulaCod { get; set; }
        public int VersionFormula { get; set; }
        Boolean Recuperado;


        public Boolean RecuperaRegistro(int order_id)
        {
            try
            {
            DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);

                SqlCommand cmd = new SqlCommand("dbo.sp_get_Ordenes_activas_consola_by_id_orden", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("id", System.Data.SqlDbType.Int).Value = order_id;

                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    OrdenID = dr.GetInt64(0);
                    Estado = dr.GetInt32(1);
                    NumOrden = dr.GetInt64(2);
                    CodeOrdenPRD = dr.GetString(3);
                    LotePT = dr.GetInt64(4);
                    ProductoTerminado = dr.GetString(5);
                    FormulaCod = dr.GetInt32(6);
                    VersionFormula = dr.GetInt32(7);
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
