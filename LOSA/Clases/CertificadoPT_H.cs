using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
   public class CertificadoPT_H
    {
        //public int ParametroId { get; set; }
        public int ID { get; set; }
        public int IdPT { get; set; }
        public int Lote_PT { get; set; }
        //public string Parametro { get; set; }
        public string ItemCode { get; set; }
        public string FFIF { get; set; }
        public string Alimento { get; set; }
        public DateTime FechaAnalisis { get; set; }
        public DateTime FechaProduccion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        //public decimal  MinPlan { get; set; }
        //public decimal  MaxPlan { get; set; }
        //public decimal  Resultado { get; set; }
        //public string Especificaciones { get; set; }
        public bool Recuperado { get; set; }


        public bool RecuperaRegistro(int id_h)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand("uspGetCertificadoPT_H_ByID", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_h",id_h);

                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ItemCode = dr["itemcode"].ToString();
                    FFIF = dr["FFIF"].ToString();
                    Alimento = dr["alimento"].ToString();
                    IdPT = Convert.ToInt32( dr["id_pt"].ToString());
                    ID= Convert.ToInt32( dr["id"].ToString());
                    Lote_PT =  Convert.ToInt32( dr["lote_pt"].ToString());
                    FechaAnalisis = Convert.ToDateTime( dr["fecha_analisis"].ToString());
                    FechaProduccion = Convert.ToDateTime( dr["fecha_produccion"].ToString());
                    FechaVencimiento = Convert.ToDateTime( dr["fecha_vencimiento"].ToString());
                    ItemCode = dr["itemcode"].ToString();

                    Recuperado = true;
                }

                cnx.Close();
                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }


        public bool RecuperaRegistroPorLote(int lote)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand("uspGetCertificadoPT_H_ByLote", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@lote", lote);

                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ItemCode = dr["itemcode"].ToString();
                    FFIF = dr["FFIF"].ToString();
                    Alimento = dr["alimento"].ToString();
                    IdPT = Convert.ToInt32(dr["id_pt"].ToString());
                    ID = Convert.ToInt32(dr["id"].ToString());
                    Lote_PT = Convert.ToInt32(dr["lote_pt"].ToString());
                    FechaAnalisis = Convert.ToDateTime(dr["fecha_analisis"].ToString());
                    FechaProduccion = Convert.ToDateTime(dr["fecha_produccion"].ToString());
                    FechaVencimiento = Convert.ToDateTime(dr["fecha_vencimiento"].ToString());
                    ItemCode = dr["itemcode"].ToString();

                    Recuperado = true;
                }

                cnx.Close();
                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}
