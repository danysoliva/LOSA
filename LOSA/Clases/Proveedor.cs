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
    class Proveedor
    {
        public string Codigo;
        public string Nombre;
        public bool Recuperado;
        public Proveedor()
        {
        }

        public bool RecuperarRegistro(string pCodigo)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_datos_proveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", pCodigo);
                Codigo = pCodigo;
                Nombre = cmd.ExecuteScalar().ToString();
                Recuperado = true;
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
