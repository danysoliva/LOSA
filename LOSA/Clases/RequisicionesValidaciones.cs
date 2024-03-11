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
    public class RequisicionesValidaciones
    {
        public Boolean PermitirCerrar;
        public int IdMP;
        public string NameMP;
        public decimal CantidadPendiente;

        public RequisicionesValidaciones()
        {

        }

        public Boolean PermitirCerrarRequisicionMP(int pIdReqH)
        {
            bool Result = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_permitir_cerrar_requisicion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_reqh", pIdReqH);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("allow_close")))
                        Result = dr.GetBoolean(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("idmp")))
                        IdMP = dr.GetInt32(1);
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("ItemName")))
                        NameMP = dr.GetString(2);
                    else
                        NameMP = "N/D";

                    if (!dr.IsDBNull(dr.GetOrdinal("kgpendientes")))
                        CantidadPendiente = dr.GetDecimal(3);
                    else
                        CantidadPendiente = 0;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Result;
        }

        public Boolean ExisteRemanenteMPSacos(int pIdMP)
        {
            bool Result = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                connection.Open();
                //SqlCommand cmd = new SqlCommand("sp_get_disponible_prd_mp_sacos_remanente", connection);
                SqlCommand cmd = new SqlCommand("sp_get_disponible_prd_mp_sacos_remanenteV2", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", pIdMP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("kg_pendientes")))
                        CantidadPendiente = dr.GetDecimal(0);
                    else
                        CantidadPendiente = 0;
                }
                dr.Close();
                connection.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Result;
        
        }


    }
}
