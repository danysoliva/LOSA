using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MicroIngredientes.Models
{
    public class FuncionesMicroI
    {
        public FuncionesMicroI()
        {

        }

        public decimal GetValorPesadoPorRM(int  pIdRM, int pIdOrdenH)
        {
            decimal valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_valor_pesado_rm_by_micros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_RM", pIdRM);
                cmd.Parameters.AddWithValue("@id_ordenPesajeH", pIdOrdenH);
                valor = dp.ValidateNumberDecimal(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }

        public bool SetEnableRM_and_order(int pIdRM, int pIdOrdenH, bool penable)
        {
            bool valor = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_mp_in_detalle_pesajes_microsI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enable", penable);
                cmd.Parameters.AddWithValue("@id_orden", pIdOrdenH);
                cmd.Parameters.AddWithValue("@id_rm", pIdRM);
                if (dp.ValidateNumberInt32(cmd.ExecuteScalar()) > 0)
                    valor = true;
                
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }
        public bool SetEnableRM_pesajeIndividual(int p_id, bool penable)
        {
            bool valor = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_enable_pesaje_individual_micros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enable", penable);
                //cmd.Parameters.AddWithValue("@id_orden", pIdOrdenH);
                cmd.Parameters.AddWithValue("@id", p_id);
                if (dp.ValidateNumberInt32(cmd.ExecuteScalar()) > 0)
                    valor = true;

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }








    }
}
