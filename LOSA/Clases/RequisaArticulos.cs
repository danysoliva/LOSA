using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
  public  class RequisaArticulos
    {
        public int ID { get; set; }
        public string Solicitante { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Barcode { get; set; }
        public string Comentario { get; set; }
        public bool Recuperado { get; set; }


        public bool RecuperarRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringAMS);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("dbo.usp_GetReqRepuestoById", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID = id;
                    Solicitante = dr.GetString(1);
                    FechaSolicitud = dr.GetDateTime(4);
                    Comentario = dr.GetString(6);
                    Barcode = dr.GetString(7);
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
