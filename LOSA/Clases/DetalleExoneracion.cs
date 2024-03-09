using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class DetalleExoneracion
    {
        public DetalleExoneracion()
        {
        }

        int id_detalle;
        string capitulo;
        string rubro;
        int id_presupuesto;
        decimal monto;
        bool recuperado;

        int id_header;
        int anio;
        DateTime fInicio;
        DateTime fFinal;
        int id_user;
        bool enable;
        bool cerrado;

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Capitulo { get => capitulo; set => capitulo = value; }
        public int Id_presupuesto { get => id_presupuesto; set => id_presupuesto = value; }
        public string Rubro { get => rubro; set => rubro = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public int Id_header { get => id_header; set => id_header = value; }
        public int Anio { get => anio; set => anio = value; }
        public DateTime FInicio { get => fInicio; set => fInicio = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public DateTime FFinal { get => fFinal; set => fFinal = value; }
        public bool Enable { get => enable; set => enable = value; }
        public bool Cerrado { get => cerrado; set => cerrado = value; }
        public string Resolucion_Ex { get => resolucion_Ex; set => resolucion_Ex = value; }

        string resolucion_Ex;

        public bool RecuperarRegistro(int pid_detalle)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionSAP_ACS);
                con.Open();
                string sql = @"sp_get_detalle_exoneracion_class";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalle_exon", pid_detalle);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_detalle = dr.GetInt32(0);
                    Capitulo = dr.GetString(1);
                    Rubro = dr.GetString(2);
                    Id_presupuesto = dr.GetInt32(3);
                    Monto = dr.GetDecimal(4);
                }
                dr.Close();
                con.Close();
                Recuperado = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarHedaer(int pid_h)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                string sql = @"sp_cm_exoneracion_class";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", pid_h);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_header = dr.GetInt32(0);
                    Anio = dr.GetInt32(1);
                    FInicio = dr.GetDateTime(2);
                    FFinal= dr.GetDateTime(3);
                    Id_user = dr.GetInt32(4);
                    Enable = dr.GetBoolean(5);
                    Cerrado = dr.GetBoolean(6);
                    Resolucion_Ex = dr.GetString(7);
                }
                dr.Close();
                con.Close();
                Recuperado = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;

        }

    }
}
