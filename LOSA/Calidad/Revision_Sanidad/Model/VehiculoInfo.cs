using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Calidad.Revision_Sanidad.Model
{
   public class VehiculoInfo
    {
        public string Placa { get; set; }
        public string   Contenedor { get; set; }
        public string   Proveedor { get; set; }
        public string   CarCode { get; set; }
        public string Conductor { get; set; }
        public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal TemperaturaContenedor { get; set; }
        public string ProveedorTransporte { get; set; }
        public string Cliente { get; set; }
        public string PaisDestino { get; set; }
        public string SectorCliente_Destino { get; set; }
        public int ID { get; set; }
        public int Revision1 { get; set; }
        public int Revision2 { get; set; }
        public int Revision3 { get; set; }

        public Boolean RecuperaRegistro(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                SqlCommand cmd = new SqlCommand("dbo.rpt_get_sanidad_vehiculo_by_id", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id_h;
                cnx.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID = dr.GetInt32(0);
                    Placa = dr.GetString(2);
                    Contenedor= dr.GetString(3);
                    CarCode= dr.GetString(4);
                    Conductor= dr.GetString(6);
                    TemperaturaContenedor = dr.GetDecimal(7);
                    Revision1 = dr.GetInt32(8);
                    Revision2 = dr.GetInt32(9);
                    Revision3 = dr.GetInt32(10);
                    Fecha = dr.GetDateTime(11);
                    Hora = dr.GetTimeSpan(13).ToString();
                    ProveedorTransporte = dr.GetString(14);
                    SectorCliente_Destino = dr.GetString(15);
                    Cliente = dr.GetString(16);
                    PaisDestino = dr.GetString(20);
                }
                cnx.Close();
                    return true;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}
