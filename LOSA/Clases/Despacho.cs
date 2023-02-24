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
    public class Despacho
    {

        private int id_despacho;
        private int num_id;
        private bool recuperado;
        private DateTime fecha_creacion;
        private string usuario_cre;
        private string cardcode;
        private bool abierto;
        private int id_serie;
        private int id_destino_cliente;
        private string cliente;
        private decimal sacos_totales;
        private int estiba_id;
        private int destino_id;
        private int id_presentacion;

        DataOperations dp = new DataOperations();

        public int Id_despacho { get => id_despacho; set => id_despacho = value; }
        public int Num_id { get => num_id; set => num_id = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Usuario_cre { get => usuario_cre; set => usuario_cre = value; }
        public string Cardcode { get => cardcode; set => cardcode = value; }
        public bool Abierto { get => abierto; set => abierto = value; }
        public int Id_serie { get => id_serie; set => id_serie = value; }
        public int Id_destino_cliente { get => id_destino_cliente; set => id_destino_cliente = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public decimal Sacos_totales { get => sacos_totales; set => sacos_totales = value; }
        public int Estiba_id { get => estiba_id; set => estiba_id = value; }
        public int Destino_id { get => destino_id; set => destino_id = value; }
        public int Id_presentacion { get => id_presentacion; set => id_presentacion = value; }

        public bool RecuperarRegistroDespacho(int pId)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_info_despacho_for_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", pId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_despacho = dr.GetInt32(0);
                    Num_id = dr.GetInt32(1);
                    Fecha_creacion = dr.GetDateTime(2);
                    Usuario_cre = dr.GetString(3);
                    Cardcode = dr.GetString(4);
                    abierto = dr.GetBoolean(5);
                    Id_serie = dr.GetInt32(6);
                    id_destino_cliente = dr.GetInt32(7);
                    Cliente = dr.GetString(8);
                    Sacos_totales = dr.GetDecimal(9);
                    Estiba_id = dr.GetInt32(10);
                    Id_presentacion = dr.GetInt32(11);
                    Destino_id = dr.GetInt32(12);
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
