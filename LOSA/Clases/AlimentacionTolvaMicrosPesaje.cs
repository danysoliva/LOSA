using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    class AlimentacionTolvaMicrosPesaje
    {
        public string CodigoPT { get; set; }
        public string Fecha { get; set; }
        public int BatchReal { get; set; }
        public int BatchPesados { get; set; }
        public int Lot { get; set; }
        public string Turno { get; set; }
        public string FML_Code { get; set; }
        public string Producto { get; set; }
        public int CodigoPesaje { get; set; }
        public int AMI_ID { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int ami_id, int order_id)
        {

            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx =  new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    string query = @"sp_load_op_reporte_detalle_micro_ingrediente";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ami_id", ami_id);
                    //cmd.Parameters.AddWithValue("@id_orden", order_id);
                    cmd.Parameters.AddWithValue("@id_orden", 1169);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        AMI_ID= dr.GetInt32(0);
                        //Fecha = string.Format("{0:dd/MM/yyyy}", dr.GetDateTime(1));
                        //Lot = dr.GetInt32(2);
                        //CodigoPT= dr.GetString(5);
                        //Turno = dr.GetString(7);
                        //FML_Code = dr.GetString(6);
                        //Producto = dr.GetString(4);
                        //CodigoPesaje = dr.GetInt32(9);
                        //BatchPesados = dr.GetInt32(8);
                        //txtnumero.Text = Pid.ToString();
                        Recuperado = true;
                    }

                    cnx.Close();
                }
            return Recuperado;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                Recuperado = false;
                return Recuperado;

            }

        }
    }


}
