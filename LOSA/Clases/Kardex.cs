using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Clases
{
    class Kardex
    {
        DataOperations dp = new DataOperations();
        public decimal TotalInventarioMP;
        int DEFAULT_VALUE = 0;
        public Kardex()
        {

        }

        public bool GetTotalInventarioKgByMp(int KeyMp, int KeyBodega)
        {
            bool PudimosObtenerElInventario = false;

            string query = @"sp_get_inventario_por_keymp_and_whs";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keymp", KeyMp);
                cmd.Parameters.AddWithValue("@keyBodega", KeyBodega);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TotalInventarioMP = dr.GetDecimal(0);
                    PudimosObtenerElInventario = true;
                }
                dr.Close();
                cn.Close();
                return PudimosObtenerElInventario;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
           
        }
    }
}
