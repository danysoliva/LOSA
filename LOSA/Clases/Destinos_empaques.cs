using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Classes;

namespace LOSA.Clases
{
    public class Destinos_empaques
    {
        private int id;
        private int estiba_id;
        private int destino_id;
        private string destino;
        private string estiba;
        private int id_presentacion;
        private decimal presentacion;
        private bool enable;
        private bool recuperado;

        DataOperations dp = new DataOperations();
        public int Id { get => id; set => id = value; }
        public int Estiba_id { get => estiba_id; set => estiba_id = value; }
        public int Destino_id { get => destino_id; set => destino_id = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Estiba { get => estiba; set => estiba = value; }
        public int Id_presentacion { get => id_presentacion; set => id_presentacion = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public bool Enable { get => enable; set => enable = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }

        //[sp_get_lista_destinos_config_despacho_pt_CLASE]

        public bool RecuperarRegistro(string pId)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lista_destinos_config_despacho_pt_CLASE]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    destino_id = dr.GetInt32(1);
                    estiba = dr.GetString(2);
                    destino = dr.GetString(3);
                    presentacion = dr.GetDecimal(4);
                    id_presentacion = dr.GetInt32(5);
                    estiba_id = dr.GetInt32(6);
                    enable = dr.GetBoolean(7);
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
