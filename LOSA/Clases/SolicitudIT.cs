using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ACS.Classes;

namespace  LOSA.MigracionACS.Classes
{
    public class SolicitudIT
    {
        DataOperations dp = new DataOperations();
        public SolicitudIT()
        {
        }

        #region Miembros
        //Solcitudes
        public bool recuperado;
        public bool recuperadoAcc;
        public int id;
        public int id_solicitante;
        public string nombre_usuario;
        public DateTime fecha_soli;
        public DateTime fecha_eliminar;
        public int id_depar;
        public string otros_acceso_especial;
        public string razon;
        public bool acceso_p;
        public bool acceso_t;
        public int ticket;
        public string asignado_a;
        public bool acceso_especial;
        public bool enable;
        public int id_estado;

        public int id_acceso;
        public int id_soli;
        #endregion

        #region Funciones
        public bool RecuperarRegistro(int pid)
        {
            recuperado = false;
            try
            {   //Seleccionar la informacion solicitud
                string sql = @"SELECT [id] --0
                      ,[id_solicitante] --1
                      ,[nombre_usuario] --2
                      ,[fecha_soli] --3
                      ,[fecha_eliminar] --4 
                      ,[id_depar] --5
                      ,[otros_acceso_especial] --6
                      ,coalesce([razon],'') --7
                      ,[acceso_p] --8
                      ,[acceso_t] --9
                      ,coalesce([ticket],0) --10
                      ,coalesce([asignado_a],'') --11
                      ,[acceso_especial] --12
                      ,[id_estado] --13
                        FROM[dbo].[IT_Solicitudes]
                        where[id] = " + pid;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //id = dr[0].ToString();
                    if ((dr[4] == DBNull.Value))
                    {
                        fecha_eliminar = new DateTime();
                    }
                    else
                    {
                        fecha_eliminar = Convert.ToDateTime(dr[4]);
                    }

                    id_solicitante = dr.GetInt32(1);
                    nombre_usuario = dr.GetString(2);
                    fecha_soli = dr.GetDateTime(3);
                    id_depar = dr.GetInt32(5);
                    otros_acceso_especial = dr.GetString(6);
                    razon = dr.GetString(7);
                    acceso_p = dr.GetBoolean(8);
                    acceso_t = dr.GetBoolean(9);
                    ticket = dr.GetInt32(10);
                    asignado_a = dr.GetString(11);
                    acceso_especial = dr.GetBoolean(12);
                    id_estado = dr.GetInt32(13);    

                    //id_estado = Convert.ToInt32(dr[13].ToString());
                    recuperado = true;
                    dr.Close();
                    conn.Close();
                }
                
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }
        

        public bool ActualizarRegistros(int pid)
        {
            bool actualizar;
            id = pid;
            
            actualizar = false;

            try
            {

                //String SPUpdate = @"IT_UpdateSolicitudes";
                string sql = @"UPDATE [dbo].[IT_Solicitudes]
                                   SET [id_solicitante] = @id_solicitante
                                      ,[nombre_usuario] = @nombre_usuario
                                      ,[fecha_soli] = @fecha_soli
                                      ,[fecha_eliminar] = @fecha_eliminar
                                      ,[id_depar] = @id_depar
                                      ,[otros_acceso_especial] = @otros_acceso_especial
                                      ,[razon] = @razon
                                      ,[acceso_p] = @acceso_p
                                      ,[acceso_t] = @acceso_t
                                      ,[ticket] = @ticket
                                      ,[asignado_a] = @asignado_a
                                      ,[acceso_especial] = @acceso_especial
                                      ,[id_estado] = @id_estado   
                                       WHERE [id] = @id";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                //SqlCommand cmd = new SqlCommand(SPUpdate, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = pid;
                cmd.Parameters.AddWithValue("@id_solicitante", SqlDbType.Int).Value = id_solicitante;
                cmd.Parameters.AddWithValue("@nombre_usuario", SqlDbType.VarChar).Value = nombre_usuario ; 
                cmd.Parameters.AddWithValue("@fecha_soli", SqlDbType.DateTime).Value = fecha_soli;
                if (acceso_p)
                {
                    cmd.Parameters.AddWithValue("@fecha_eliminar", SqlDbType.DateTime).Value = DBNull.Value; 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fecha_eliminar", SqlDbType.DateTime).Value = fecha_eliminar;
                }
                
                cmd.Parameters.AddWithValue("@id_depar", SqlDbType.Int).Value = id_depar;
                cmd.Parameters.AddWithValue("@otros_acceso_especial", SqlDbType.VarChar).Value = otros_acceso_especial;
                cmd.Parameters.AddWithValue("@razon", SqlDbType.VarChar).Value = razon;
                cmd.Parameters.AddWithValue("@acceso_p", SqlDbType.Bit).Value = acceso_p;
                cmd.Parameters.AddWithValue("@acceso_t", SqlDbType.Bit).Value = acceso_t;
                cmd.Parameters.AddWithValue("@ticket", SqlDbType.Int).Value = ticket;
                cmd.Parameters.AddWithValue("@asignado_a", SqlDbType.VarChar).Value = asignado_a;
                cmd.Parameters.AddWithValue("@acceso_especial", SqlDbType.Bit).Value = acceso_especial;
                cmd.Parameters.AddWithValue("@id_estado", SqlDbType.Int).Value = id_estado;
                cmd.ExecuteScalar();
                actualizar = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return actualizar;
        }
        #endregion
    }
}
