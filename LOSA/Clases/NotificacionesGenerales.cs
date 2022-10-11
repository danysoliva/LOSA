using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
   public class NotificacionesGenerales
    {
        public bool Recuperado { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }


        public bool ValidarVersionBuild(int major, int minor, int build, int revision )
        {
            try
            {
                string sql = "dbo.sp_get_versionBuild_notificaciones";
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand(sql, cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@major", System.Data.SqlDbType.Int).Value = major;
                    cmd.Parameters.Add("@minor", System.Data.SqlDbType.Int).Value = minor;
                    cmd.Parameters.Add("@build", System.Data.SqlDbType.Int).Value = build;
                    cmd.Parameters.Add("@revision", System.Data.SqlDbType.Int).Value = revision;

                    Recuperado = (bool)cmd.ExecuteScalar();
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
