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
    public class MateriaPrima
    {
        public MateriaPrima()
        {

        }


        int _IdMP_ACS;
        string _CodeMP_SAP;
        string _CodigoODOO;
        string _Name;
        bool _Recuperado;

        public int IdMP_ACS { get => _IdMP_ACS; set => _IdMP_ACS = value; }
        public string CodeMP_SAP { get => _CodeMP_SAP; set => _CodeMP_SAP = value; }
        public string Codigo { get => _CodigoODOO; set => _CodigoODOO = value; }
        public string Name { get => _Name; set => _Name = value; }
        public bool Recuperado { get => _Recuperado; set => _Recuperado = value; }

        public bool RecuperarRegistroFromID_RM(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    //name sap = dr.GetString(3);
                    CodeMP_SAP = dr.GetString(4);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
        public bool RecuperarRegistroFromID_RM_PT_ONLY(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_pt_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    CodeMP_SAP = dr.GetString(3);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
        public bool RecuperarRegistroFromID_RM_Despachos(int pIdRM)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_id_rm", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idrm", pIdRM);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    CodeMP_SAP = dr.GetString(3);
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }


        public bool RecuperarRegistroFromCode(string pCodeSAP)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_clase_mp_from_sap_code", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", pCodeSAP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMP_ACS = dr.GetInt32(0);
                    Codigo = dr.GetString(1);
                    Name = dr.GetString(2);
                    CodeMP_SAP = pCodeSAP;
                }
                dr.Close();
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }








    }
}
