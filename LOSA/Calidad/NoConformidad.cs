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
        

        private int Id_Ingreso { get; set; }
        private int Numero_transaccion { get; set; }
        private string Lote { get; set; }
        public DateTime Fecha_documento { get; set; }
        public string Proveedor { get; set; }
        public string Cardcode { get; set; }
        public string Placa { get; set; }
        public string Trasportistas { get; set; }
        public string Trasporte { get; set; }
        public decimal Cantidad_sacos { get; set; }
        public decimal Cantidad_kg { get; set; }
        public int Numero_referencia { get; set; }
        public string Oc { get; set; }
        public int No_correlativo { get; set; }
        public string Motivo { get; set; }
        public string acciones { get; set; }
        public int idUser { get; set; }
        public string NameUser { get; set; }
        public int ID { get; set; }
        public string MaterialMp { get; set; }
        public int Id_TipoIngreso { get; set; }
        public int Id_Tipo_OP { get; set; }
        public int Id_Boleta { get; set; }
        enum TypeForm
        {
            Editar = 1,
            Nuevo = 2
        }

        TypeForm Tipo;
        DataOperations dp = new DataOperations();
        public NoConformidad(int Pid_ingreso, string PLote, int pnumero_transaccion)
        {
            Id_Ingreso = Pid_ingreso;
            Lote = PLote;
            Numero_transaccion = pnumero_transaccion;
            Tipo = TypeForm.Nuevo;
            load_data();
        }

        public NoConformidad(int Pid_ingreso, string PLote, int PDoc, int pnumero_transaccion)
        {
            Id_Ingreso = Pid_ingreso;
            Lote = PLote;
            ID = PDoc;
            Tipo = TypeForm.Editar;
        }

        public void load_data()
        {
            try
            {
                string query = @"sp_get_info_of_lot_to_no_conformidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ingreso", Id_Ingreso);
                cmd.Parameters.AddWithValue("@Lote", Lote);
                cmd.Parameters.AddWithValue("@num_transaccion", Numero_transaccion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Fecha_documento = dr.IsDBNull(0) ? DateTime.Now : dr.GetDateTime(0);
                    Proveedor = dr.IsDBNull(1) ? "" :  dr.GetString(1);
                    Placa = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    Trasporte = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    Trasportistas = dr.IsDBNull(4) ? "" : dr.GetString(4);
                    Cantidad_sacos = 0;
                    Cantidad_kg = 0;
                    Numero_referencia = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                    Oc = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    No_correlativo = dr.IsDBNull(7) ? 0 : dr.GetInt32(7);
                    Motivo = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    acciones = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    MaterialMp = dr.IsDBNull(10) ? "" : dr.GetString(10);
                    Id_TipoIngreso = dr.GetInt32(11);
                    ID = dr.GetInt32(12);
                    Id_Tipo_OP = dr.GetInt32(13);
                    Cardcode = dr.GetString(14);
                    Id_Boleta = dr.GetInt32(15);

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

    }
}
