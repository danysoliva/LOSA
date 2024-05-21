using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Clases
{
    public class MaterialEmpaque
    {
        #region Miembros
        public int id_requisa_h { get; set; }
        public string solicitante_prd { get; set; }
        public DateTime date_solicitud { get; set; }
        public bool abierta { get; set; }
        public string comentario { get; set; }
        public string codigo_barra { get; set; }
        public string turno { get; set; }
        public string requ_creador { get; set; }
        public bool Recuperado { get; set; }
        public int id_estado { get; set; }
        public string estado { get; set; }
        #endregion

        public MaterialEmpaque()
        {

        }

        public bool RecuperarRequisaH_ME(int pId_H)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisa_h_class", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pId_H);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id_requisa_h = pId_H;
                    solicitante_prd = dr.GetString(1);
                    date_solicitud = dr.GetDateTime(2);
                    abierta = dr.GetBoolean(3);
                    comentario = dr.GetString(4);
                    codigo_barra = dr.GetString(5);
                    turno = dr.GetString(6);
                    requ_creador = dr.GetString(7);
                    id_estado = dr.GetInt32(8);
                    estado = dr.GetString(9);
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }



    }

    
}
