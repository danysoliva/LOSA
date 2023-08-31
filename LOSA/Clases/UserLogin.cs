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
    public class UserLogin
    {
        public GrupoUser GrupoUsuario;
        private bool recuperado;
        private int id;
        private int idGrupo;
        private string nombreUser;
        private string ADuser;
        private string pass;
        private int idnivel;
        private string tipo;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id { get => id; set => id = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NombreUser { get => nombreUser; set => nombreUser = value; }
        public string ADuser1 { get => ADuser; set => ADuser = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Idnivel { get => idnivel; set => idnivel = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string HostNameConnected { get; set; }

        //Migracion ACS

        #region Members
        //int vUserid;
        string vNombre;
        string vAlias;
        bool vRecuperado;
        //DataOperations dp;
        bool vSuperUser;
        string vPassword;
        #endregion

        #region Properties
        //public bool Recuperado
        //{
        //    get { return vRecuperado; }
        //    set { vRecuperado = value; }
        //}
        public int UserId
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return vNombre; }
            set { vNombre = value; }
        }
        public string AD_User
        {
            get { return vAlias; }
            set { vAlias = value; }
        }
        /// <summary>
        /// Set or Get bool if the user login is Super User
        /// </summary>
        public bool IsSuperUser
        {
            get { return vSuperUser; }
            set { vSuperUser = value; }
        }

        public string Password { get => vPassword; set => vPassword = value; }
        #endregion

        public UserLogin()
        {
            GrupoUsuario = new GrupoUser();
        }

        public bool RecuperarRegistroFromUser(string pUser)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                string sql = @"SELECT top 1 id, 
                                       nombre, 
	                                   id_grupo_losa,
                                       ADUser
                                FROM [ACS].dbo.conf_usuarios 
                                where [ADUser] ='" + pUser + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    ADuser = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }


        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                string sql = @"SELECT id, 
                                       nombre, 
	                                   id_grupo_losa,
                                       tipo
                                FROM [ACS].dbo.conf_usuarios 
                                where id ="+ pId;
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    Tipo = dr.GetString(3);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public int idNivelAcceso(int Iduser, int idSistema)
        {
            int id = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                string sql = "sp_get_nivel_acceso_for_user";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_sistema", idSistema);
                cmd.Parameters.AddWithValue("@id_user", Iduser);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                //recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return id;
        }

        internal bool ValidarNivelPermisos(int pIdVentana)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();
                string sql = @"SELECT count(*)
                                FROM [dbo].conf_usuario_ventanas vv 
                                where vv.id_ventana = " + pIdVentana.ToString() +
                                      "and vv.id_usuario = " + UserId.ToString();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                int v = Convert.ToInt32(cmd.ExecuteScalar());
                if (v > 0)
                    r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return r;
        }


        //Vamos a cargar desde sql toda la data del usuario
        public bool RecuperarRegistro(string pUserID)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();
                string sql = @"SELECT [id]
                                      ,[nombre]
                                      ,[ADUser]
                                      ,[super_user]
                                  FROM [dbo].[conf_usuarios]
                                  where id = " + pUserID;
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserId = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    AD_User = dr.GetString(2);
                    IsSuperUser = dr.GetBoolean(3);
                }
                vRecuperado = true;
                Conn.Close();
            }
            catch (Exception ec)
            {
                vRecuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return vRecuperado;
        }

        internal bool ValidarNivelPermisosTemporal(int pIdNIvelVentana)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();
                string sql = @"sp_get_validacion_permisos_temporales_usuarios";
                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ventana", pIdNIvelVentana);
                int v1 = Convert.ToInt32(cmd.ExecuteScalar());
                if (v1 > 0)
                    r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error situado en Class: UserLogin, Function: ValidarNivelPermisosTemporal. Msj Erro: " + ec.Message);
            }
            return r;
        }
    }
}
