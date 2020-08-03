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
    public class Requisicion
    {
        public Requisicion()
        {
            Recuperado = false;
            IdRequisicion = 0;
        }

        public bool Recuperado;
        public int IdRequisicion;
        public string Barcode;


        public bool RecuperarRegistroFromBarcode(string barcode)
        {
            try
            {
                Recuperado = false;
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_datos_requisicion_from_barcode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                IdRequisicion = Convert.ToInt32(cmd.ExecuteScalar());
                if (IdRequisicion > 0)
                {
                    Barcode = barcode;
                    Recuperado = true;
                }

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
