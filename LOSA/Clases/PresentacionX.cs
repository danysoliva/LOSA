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
    public class PresentacionX
    {
        public PresentacionX()
        {

        }

        int id;
        string descripcion;
        bool enable;
        DateTime fecha;
        decimal factor;
        bool Recuperado;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Enable { get => enable; set => enable = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Factor { get => factor; set => factor = value; }

        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentacion_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = pId;
                    descripcion = dr.GetString(1);
                    enable = dr.GetBoolean(2);
                    fecha = dr.GetDateTime(3);
                    factor = dr.GetDecimal(4);
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
