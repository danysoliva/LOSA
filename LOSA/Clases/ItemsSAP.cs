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
    public class ItemsSAP
    {
        bool recuperado;
        string itemCode;
        string descripcionArticulo;
        string bodega;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public string DescripcionArticulo { get => descripcionArticulo; set => descripcionArticulo = value; }
        public string ItemCode { get => itemCode; set => itemCode = value; }
        public string Bodega { get => bodega; set => bodega = value; }

        public bool RecuperarRegistroItemSAP(string pItemCode)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                con.Open();

                SqlCommand cmd = new SqlCommand("CM_sp_get_item_class", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", pItemCode.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ItemCode = dr.GetString(0);
                    DescripcionArticulo = dr.GetString(1);
                    Bodega = dr.GetString(2);
                    Recuperado = true;
                }
                con.Close();
                dr.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }


            return Recuperado;
        }
    }
}
