using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Clases
{
    public class ItemMP_Lote
    {
        public string ItemCode;
        public string Card_Name;
        public string Lote;
        public int IdLote;
        public DateTime FechaProd;
        public DateTime FechaVence;
        public ItemMP_Lote()
        {
        }
        
        public bool RecuperarRegistro(int pId)
        {
            bool a = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();

                string SQL = @"sp_get_lote_activo_granel_from_id";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    FechaProd = dr.GetDateTime(8);
                    FechaVence = dr.GetDateTime(9);
                    a = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return a;
        }
    }
}
