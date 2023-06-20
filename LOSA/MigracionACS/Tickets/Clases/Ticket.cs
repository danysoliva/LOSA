using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ACS.Classes;


namespace LOSA.MigracionACS.Tickets.Clases
{
    class Ticket
    {
        #region V A R I A B L E S 
        private int id;
        private int user_creador;
        private bool enable;
        private int user_asignado;
        private DateTime fecha_creacion;
        private DateTime fecha_cerrado;
        private string comentario;
        private int prioridad;
        private string informacion;
        private string name_user_issue;
        private bool activo;
        private int id_estado;
        private int id_proyecto;
        private string titulo;
        private int user_cerrado;
        private DataTable mensajes;
        private DataTable archivos;
        private DataTable destino;
        private int id_tipo;


        public int Id { get => id; set => id = value; }
        public int User_creador { get => user_creador; set => user_creador = value; }
        public bool Enable { get => enable; set => enable = value; }
        public int User_asignado { get => user_asignado; set => user_asignado = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public DateTime Fecha_cerrado { get => fecha_cerrado; set => fecha_cerrado = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }
        public string Informacion { get => informacion; set => informacion = value; }
        public string Name_user_issue { get => name_user_issue; set => name_user_issue = value; }
        public bool Activo { get => activo; set => activo = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int User_cerrado { get => user_cerrado; set => user_cerrado = value; }
        public DataTable Mensajes { get => mensajes; set => mensajes = value; }
        public DataTable Archivos { get => archivos; set => archivos = value; }
        public DataTable Destino { get => destino; set => destino = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
         public Operacion Op;
        DataOperations dp = new DataOperations();

        #endregion

        public enum Operacion
        {
                Nuevo =1,
                Editar = 2
        }
        public Ticket(Operacion Pop)
        {   //nuevo

        }
        public Ticket(int IdTicket)
        {
            //cargar
            Id = IdTicket;
            Op = Operacion.Editar;
            Load_informacion();
        }

        public void Load_informacion()
        {
            string query = @"sp_TK_load_informacion_ticket";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    User_asignado = dr.GetInt32(1);
                    Comentario = dr.GetString(2);
                    Id_proyecto = dr.GetInt32(3);
                    Titulo = dr.GetString(4);
                    Id_tipo = dr.GetInt32(5);
                    Name_user_issue = dr.GetString(8);

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);     
            }
        }
    }
}
