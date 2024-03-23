using ACS.Classes;
using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Classes
{
    public class CuentaContableODOO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool  Recuperado { get; set; }
        DataOperations dp;

        public CuentaContableODOO()
        {
            dp = new DataOperations();
        }

        public bool RecuperarRegistro(int pIdCuenta)
        {
            //List<Account> accounts = new List<Account>();
            Recuperado = false;
            try
            {
                string connectionString = dp.ConnectionStringODOO5; // Reemplaza esto con tu cadena de conexión PostgreSQL
                using (PgSqlConnection connection = new PgSqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT id, (coalesce(code,'N/D')) AS cuenta_descripcion, name as nombre
                                     FROM public.account_account
                                     WHERE id = :id
                                     ORDER BY code ASC";

                    using (PgSqlCommand command = new PgSqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("id", pIdCuenta);
                        using (PgSqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Id = Convert.ToInt32(reader["id"]);
                                Codigo = reader["cuenta_descripcion"].ToString();
                                Nombre = reader["nombre"].ToString();
                                Recuperado = true;
                            }
                        }
                    }
                }
            }
            catch  (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }
    }
}
