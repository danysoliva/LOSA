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
        public int IdMPSingle;

        public bool     RecuperarRegistro(string pLotemp)
        {
            bool rec = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_recupera_registro_lotemp_list", con);
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
