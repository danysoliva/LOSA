using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class Boleta
    {
        int id;
        int _NumID;
        bool recuperado;
        public Boleta()
        {
        }

        public int Id { get => id; set => id = value; }
        public int NumID { get => _NumID; set => _NumID = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }

        public bool RecuperarRegistro(int pIdSerial)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                string sql = @"SELECT [id]
                                     ,[NumID]
                                FROM [BASCULA_DEV].[dbo].[TS_in_and_out]tt
                                where tt.id = " + pIdSerial;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this._NumID = dr.GetInt32(1);
                }
                dr.Close();
                con.Close();
                recuperado = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return recuperado;
        }

    }
}
