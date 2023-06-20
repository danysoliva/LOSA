using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MigracionACS.Tickets.Models
{
   public class TicketInfo
    {
        public int ID { get; set; }
        public string UsuarioAsignado { get; set; }
        public string UsuarioAsignadoMail { get; set; }
        public string UsuarioCreador { get; set; }
        public string UsuarioCreadorMail { get; set; }
        public string Comentario { get; set; }
        public string Titulo { get; set; }
        public string Estado { get; set; }
        public string Informacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Boolean Recuperado { get; set; }
        public List<string> copiaCorreos { get; set; }
        public string Prioridad { get; set; }

        public string Proyecto { get; set; }

        public Boolean RecuperaRegistro(int id_ticket)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_get_TicketInfo",cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_ticket;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = dr.GetInt32(0);
                        UsuarioCreador = dr.GetString(1);
                        UsuarioAsignado = dr.GetString(2);
                        FechaCreacion = dr.GetDateTime(3);
                        Comentario = dr.GetString(4);
                        Prioridad = dr.GetString(5);
                        Titulo = dr.GetString(6);
                        Informacion = dr.GetString(7);
                        Estado = dr.GetString(8);
                        UsuarioCreadorMail = dr.GetString(9);
                        UsuarioAsignadoMail = dr.GetString(10);
                        Proyecto = dr.GetString(11);
                    }



                        Recuperado = true;
                    cnx.Close();
                }

                using (SqlConnection con =  new SqlConnection(dp.ConnectionStringCostos))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_get_copia_mails_TK", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ticket",id_ticket);

                    var copyCorreos = new List<string>();

                    SqlDataReader dr = cmd.ExecuteReader();

                    copiaCorreos = null;
                    while (dr.Read())
                    {
                        string str = dr.GetString(0);
                        copyCorreos.Add(str);
                    }

                    copiaCorreos = copyCorreos;


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
