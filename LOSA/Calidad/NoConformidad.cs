using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using System.Data.Linq;

namespace LOSA.Calidad
{
    class NoConformidad
    {
        

        private int Id_lote { get; set; }
        public DateTime Fecha_documento { get; set; }
        public string Proveedor { get; set; }
        public string Placa { get; set; }
        public string Trasportistas { get; set; }
        public string Trasporte { get; set; }
        public decimal Cantidad_sacos { get; set; }
        public decimal Cantidad_kg { get; set; }
        public int Numero_referencia { get; set; }
        public int Oc { get; set; }
        public int No_correlativo { get; set; }
        public string Motivo { get; set; }
        public string acciones { get; set; }
        public int idUser { get; set; }
        public string NameUser { get; set; }
        public int ID { get; set; }

        DataOperations dp = new DataOperations();
        public NoConformidad(int Pid_lote)
        {
            Id_lote = Pid_lote;
        }

        public void load_data()
        {
            try
            {
                string query = @"";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Close();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", Id_lote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

    }
}
