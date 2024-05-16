using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;
using System.Data.SqlClient;
namespace LOSA.Clases
{
    public class Aprobaciones
    {
        DataOperations dp = new DataOperations();
        public long IdH { get; set; }
        public int IdRequisa { get; set; }
        public string Solicitante { get; set; }
        public int TipoRequiso { get; set; }
        public string TipoDescripcion { get; set; }
        public int IdSolicitante { get; set; }
        public string Ruta { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Comentario { get; set; }
        public string Barcode { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(long idSolicitud)
        {
            Recuperado = false;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_solicitudes_aprobacion_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdH = dr.GetInt64(0); // id_h
                    IdRequisa = dr.GetInt32(1);// id_requisa
                    Solicitante = dr.GetString(2); // solicitante
                    TipoRequiso = dr.GetInt32(3); // tipo_requiso
                    TipoDescripcion = dr.GetString(4); // tipo_descripcion
                    IdSolicitante = dr.GetInt32(5); // id_solicitante
                    Ruta = dr.GetString(6); // ruta
                    FechaSolicitud = dr.GetDateTime(7); // fecha_solicitud
                    Comentario = dr.IsDBNull(8) ? null : dr.GetString(8);// comentario
                    Barcode = dr.IsDBNull(9) ? null : dr.GetString(9); // barcode
                    IdEstado = dr.GetInt32(10); // id_estado
                    Estado = dr.GetString(11); // estado
                    Recuperado = true;
                }

                dr.Close();
                conn.Close();
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                Recuperado = false;
            }

            return Recuperado;
        }
    }
}
