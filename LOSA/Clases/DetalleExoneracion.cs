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

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Capitulo { get => capitulo; set => capitulo = value; }
        public int Id_presupuesto { get => id_presupuesto; set => id_presupuesto = value; }
        public string Rubro { get => rubro; set => rubro = value; }
        public decimal Monto { get => monto; set => monto = value; }

        public bool RecuperarRegistro(int pid_detalle)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
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

    }
}
