using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MicroIngredientes.Models
{
   public class OrdenH_Info
    {
        public int ID { get; set; }
        public Int64 Order_ID { get; set; }
        public string OrderCode { get; set; }
        public DateTime Date { get; set; }
        public int Lot { get; set; }
        public int Cant_Batch { get; set; }
        public string State { get; set; }
        public int BatchReal { get; set; }
        public int CodeState { get; set; }
        public Boolean Recuperado { get; set; }

        public Boolean RecuperaRegistro(int id)
        {

            try
            {

           

            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
            {
                cnx.Open();

                SqlCommand cmd = new SqlCommand("dbo.get_orden_pesaje_manual_by_id",cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                SqlDataReader dr = cmd.ExecuteReader() ;

                if (dr.Read())
                {
                    ID = dr.GetInt32(0);
                    Order_ID = dr.GetInt64(1);
                    OrderCode= dr.GetString(2);
                    Date = dr.GetDateTime(3);
                    Lot = dr.GetInt32(4);
                    Cant_Batch= dr.GetInt32(5);
                    CodeState = dr.GetInt32(6);
                    BatchReal = dr.GetInt32(8);
                    Recuperado = true;
                }

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
