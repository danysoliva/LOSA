using ACS.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class LoteMP
    {
        public LoteMP() 
        { 
        }

        public bool Recuperado;
        public int CantidadMP;
        public string Lote_MP;
        public ArrayList MateriaPrimasList;
        public string NombreMPSingle;
        public string NombreComercialSingle;
        public int IdPresentacion;
        public int IdMPSingle;
        public string ItemCode;


        public bool RecuperarRegistro(int pIdLoteALOSY)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_datos_lote_from_id_lote_ALOSY_clase", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote_ALOSY", pIdLoteALOSY);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdPresentacion = dr.GetInt32(0);
                    if (IdPresentacion > 0)
                        Recuperado = true;
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

        public int RecuperarCant_MP_porLote(string pLoteMP) 
        {
            int conta = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_materias_primas_que_comparten_mismo_lote_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_mp", pLoteMP);
                conta = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return conta;
        }

        public bool RecuperarMateriaPrimaFromLOTE_MP_and_ITEMCODE(string pLoteMP)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_materia_prima_from_lote_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_mp", pLoteMP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdMPSingle = dr.GetInt32(0);
                    NombreComercialSingle = NombreMPSingle = dr.GetString(1);
                    ItemCode = dr.GetString(2);
                    Recuperado = true;
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

        public bool     RecuperarRegistro(string pLotemp)
        {
            bool rec = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_recupera_registro_lotemp_listv2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", pLotemp);
                SqlDataReader dr = cmd.ExecuteReader();
                MateriaPrimasList = new ArrayList();
                CantidadMP = 0;
                while (dr.Read())
                {
                    rec = true;
                    MateriaPrimasList.Add(dr.GetInt32(0));
                    CantidadMP++;
                    Lote_MP = pLotemp;
                }
                dr.Close();
                con.Close();

                if (CantidadMP == 1)
                {
                    foreach(int idmp in MateriaPrimasList)
                    {
                        MateriaPrima MP = new MateriaPrima();
                        if (MP.RecuperarRegistroFromID_RM(idmp))
                        {
                            NombreComercialSingle = NombreMPSingle = MP.Name;
                            IdMPSingle = idmp;
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return rec;
        }
    }
}
