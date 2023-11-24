using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Clases
{
    public class AlimentacionBasculas
    {
        int id;
        int id_detalle_requisicion;
        int num_Requisa;
        int id_Tarima;
        string mp;
        DateTime fecha_Ingreso;
        string usuario;
        decimal unidades;
        decimal peso;
        string lote;
        decimal peso_Bruto;
        decimal peso_Tara;
        decimal peso_Prd;
        string estado;
        int bascula;
        string codio_Barra;
        bool recuperado;
        bool enProceso;

        public int Id { get => id; set => id = value; }
        public int Id_detalle_requisicion { get => id_detalle_requisicion; set => id_detalle_requisicion = value; }
        public int Num_Requisa { get => num_Requisa; set => num_Requisa = value; }
        public int Id_Tarima { get => id_Tarima; set => id_Tarima = value; }
        public string Mp { get => mp; set => mp = value; }
        public DateTime Fecha_Ingreso { get => fecha_Ingreso; set => fecha_Ingreso = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public decimal Unidades { get => unidades; set => unidades = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public string Lote { get => lote; set => lote = value; }
        public decimal Peso_Bruto { get => peso_Bruto; set => peso_Bruto = value; }
        public decimal Peso_Tara { get => peso_Tara; set => peso_Tara = value; }
        public decimal Peso_Prd { get => peso_Prd; set => peso_Prd = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Bascula { get => bascula; set => bascula = value; }
        public string Codio_Barra { get => codio_Barra; set => codio_Barra = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public bool EnProceso { get => enProceso; set => enProceso = value; }

        public bool RecuperarRegistros(int pid)
        {
            Recuperado = false;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_tarimas_en_proceso_bascula_class]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", pid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_detalle_requisicion = dr.GetInt32(1);
                    Num_Requisa = dr.GetInt32(2);
                    Id_Tarima = dr.GetInt32(3);
                    Mp = dr.GetString(4);
                    Fecha_Ingreso = dr.GetDateTime(5);
                    Usuario = dr.GetString(6);
                    Unidades = dr.GetDecimal(7);
                    Peso = dr.GetDecimal(8);
                    Lote = dr.GetString(9);
                    Peso_Bruto = dr.GetDecimal(10);
                    Peso_Tara = dr.GetDecimal(11);
                    Peso_Prd = dr.GetDecimal(12);
                    Estado = dr.GetString(13);
                    Bascula = dr.GetInt32(14);
                    Codio_Barra = dr.GetString(15);
                    EnProceso = dr.GetBoolean(16);
                    Recuperado = true;
                }
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
                
            }

            return Recuperado;
        
        }
    }
}
