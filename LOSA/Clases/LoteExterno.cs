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
    public class LoteExterno
    {
        public LoteExterno() { }

        int IdLote = 0;
        int Unidades;
        string Lote;
        int Cantidad;
        //int id_detalle = 0;
        DateTime FechaProduccion;
        DateTime FechaVencimiento;


        public bool GuardarLoteExterno()
        {
            bool val = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("sp_insert_lote_almacenes_externos", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@unidades", Unidades);
                cmd.Parameters.AddWithValue("@id_detalle", 0);
                cmd.Parameters.AddWithValue("@lote", Lote);
                cmd.Parameters.AddWithValue("@fecha_vencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("@fecha_produccion", FechaProduccion);

                IdLote = Convert.ToInt32(cmd.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }
    }
}
