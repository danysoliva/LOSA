using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class CM_OrdenCompra_EstadosAprobacion
    {
        public CM_OrdenCompra_EstadosAprobacion() { }
        public int id;
        public string descripcion;
        public bool enable;
        public bool Recuperado;

        public bool RecuperarRegistro(int pIdEstado)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                string query = @"SELECT [id]
                                        ,[descripcion]
                                        ,[enable]
                                    FROM [LOSA].[dbo].[CM_OC_SolicitudAprobacion_Estados]
                                    where id = @id_estado";
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado", pIdEstado);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    descripcion = dr.GetString(1);  
                    enable = dr.GetBoolean(2);
                    Recuperado =true;
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
