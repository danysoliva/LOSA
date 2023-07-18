using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MigracionACS.IT.Model
{
   public class IT_Solicitud_Info
    {

        public int ID_Solicitud { get; set; }
        public string NombreSolicitante { get; set; }
        public string MailSolicitante { get; set; }
        public string NombreUsuarioAccceso { get; set; }
        public string Departamento { get; set; }
        public string Estado { get; set; }
        public string Razon { get; set; }
        public string AsignadoA { get; set; }
        public List<string> Accesos { get; set; }
        public Boolean Recuperado { get; set; }


        public Boolean RecuperaRegistro(int id_solicitud)
    {
        try
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
            {
                cnx.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_IT_Solicitud_Info_by_ID", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_solicitud;

                SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID_Solicitud = dr.GetInt32(0);
                        NombreSolicitante = dr.GetString(1);
                        MailSolicitante = dr.GetString(2);
                        NombreUsuarioAccceso = dr.GetString(3);
                        Departamento = dr.GetString(4);
                        Razon = dr.GetString(5);
                        Estado = dr.GetString(6);
                        AsignadoA = dr.GetString(7);
                    }



                    Recuperado = true;
                cnx.Close();
            }

                using (SqlConnection con = new SqlConnection(dp.ConnectionStringCostos))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_get_accesos_solicitados", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_solicitud", SqlDbType.Int).Value = id_solicitud;

                    var access = new List<string>();

                    SqlDataReader dr = cmd.ExecuteReader();

                    Accesos = null;

                    while (dr.Read())
                    {
                        string str = dr.GetString(0);
                        access.Add(str);
                    }

                    Accesos = access;


                    con.Close();
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
