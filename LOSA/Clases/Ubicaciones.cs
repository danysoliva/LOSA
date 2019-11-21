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
    class Ubicaciones
    {
        int _id;
        string _pasillo;
        string _rack;
        string _altura;
        string _profundidad;
        bool _Recuperado;
        public Ubicaciones()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Pasillo { get => _pasillo; set => _pasillo = value; }
        public string Altura { get => _altura; set => _altura = value; }
        public string Profundidad { get => _profundidad; set => _profundidad = value; }
        public bool Recuperado { get => _Recuperado; set => _Recuperado = value; }
        public string Rack { get => _rack; set => _rack = value; }

        public bool RecuperarRegistro(int pIdUbicacion, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ubicaciones_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUbicacion", pIdUbicacion);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Pasillo= dr.GetString(1);
                    Rack= dr.GetString(2);
                    Altura= dr.GetString(3);
                    Profundidad= dr.GetString(4);
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
