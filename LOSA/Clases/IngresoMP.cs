using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class IngresoMP
    {
        public IngresoMP()
        {
        }

        public int NumeroTransaccion;
        public int IdIngresoLote;
        public bool Recuperado;

        public bool RecuperarRegistroIdLote_fromNumTransaccion(int pNumTransaccion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_id_ingreso_from_num_transaccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numTransaccion", pNumTransaccion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdIngresoLote = dr.GetInt32(0);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

    }
}
