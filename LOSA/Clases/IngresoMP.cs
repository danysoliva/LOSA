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
    public class IngresoMP
    {
        public IngresoMP()
        {
        }

        private int numeroTransaccion;
        public int IdIngresoLote;
        public string LoteMP;
        private int id_ingreso;
        private string itemcode;
        private string itemname;
        private DateTime fechacreacion;
        private int usuario_creado;
        private string cardname;
        private string carcode;
        private int idboleto;
        private int idtraslado;
        private string observacion;

        public bool Recuperado;

        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public string Itemcode { get => itemcode; set => itemcode = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public DateTime Fechacreacion { get => fechacreacion; set => fechacreacion = value; }
        public int Usuario_creado { get => usuario_creado; set => usuario_creado = value; }
        public string Cardname { get => cardname; set => cardname = value; }
        public string Carcode { get => carcode; set => carcode = value; }
        public int Idboleto { get => idboleto; set => idboleto = value; }
        public int Idtraslado { get => idtraslado; set => idtraslado = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int NumeroTransaccion { get => numeroTransaccion; set => numeroTransaccion = value; }

        public bool RecuperarRegistroIdLote_fromNumTransaccion(int pNumTransaccion, string  pLoteMP)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_id_ingreso_from_num_transaccion_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numTransaccion", pNumTransaccion);
                cmd.Parameters.AddWithValue("@lotemp", pLoteMP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdIngresoLote = dr.GetInt32(0);
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

        public bool RecuperarRegistrosIngreso(int pNumTransaccion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_data_ingreso_mp_Class", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numTransaccion", pNumTransaccion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_ingreso = dr.GetInt32(0);
                    NumeroTransaccion = dr.GetInt32(1);
                    Itemcode = dr.GetString(2);
                    Itemname = dr.GetString(3);
                    Fechacreacion = dr.GetDateTime(4);
                    Usuario_creado = dr.GetInt32(5);
                    Cardname = dr.GetString(6);
                    Carcode = dr.GetString(7);
                    Idboleto = dr.GetInt32(8);
                    Idtraslado = dr.IsDBNull(9) ? 0 : dr.GetInt32(9);
                    Observacion = dr.IsDBNull(10) ? "" : dr.GetString(10);
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

    }
}
