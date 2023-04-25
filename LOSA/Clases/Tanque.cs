using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.Clases
{
    class Tanque
    {
        /// <summary>
        /// Crea una instancia de la clase Empleado
        /// </summary>
        /// <param name="numerodeTanque">Esta propiedad es para el id del tanque</param>
        /// <param name="keyMateriaPrima">Es el Id de la materia prima para el cual se usa el tanque</param>
        /// <param name="nombreMateriaP">El nombre de la materia prima para el cual se usa el tanque</param>  
        /// <param name="maximoCapacidad">La capacidad maxima del tanque</param>
        /// <param name="totalLleno">Segun el inventario, es lo que lleva de lleno el tanque</param>  
        /// <param name="vacioCapacidad">Segun el inventario, es lo que lleva de vacio el tanque</param>
        /// 

        int numerodeTanque;
        int keyMateriaPrima;
        string nombreMateriaP;
        decimal maximoCapacidad;
        decimal totalLleno;
        decimal vacioCapacidad;
        int id_tanque_prd;
        string itemcode;

        DataOperations dp = new DataOperations();



        public int NumerodeTanque { get => numerodeTanque; set => numerodeTanque = value; }
        public int KeyMateriaPrima { get => keyMateriaPrima; set => keyMateriaPrima = value; }
        public string NombreMateriaP { get => nombreMateriaP; set => nombreMateriaP = value; }
        public decimal MaximoCapacidad { get => maximoCapacidad; set => maximoCapacidad = value; }
        public decimal TotalLleno { get => totalLleno; set => totalLleno = value; }
        public decimal VacioCapacidad { get => vacioCapacidad; set => vacioCapacidad = value; }
        public int Id_tanque_prd { get => id_tanque_prd; set => id_tanque_prd = value; }
        public string Itemcode { get => itemcode; set => itemcode = value; }

        int Default_value = 0;


        public Tanque(int PNumerodeTanque)
        {
            NumerodeTanque = PNumerodeTanque;
            Load_Registros();
        }
        public void Load_Registros()
        {
            string query = @"sp_get_info_tanque_aceite_inventario_externo_by_id";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KeyTanque", NumerodeTanque);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    KeyMateriaPrima = dr.IsDBNull(0) ? Default_value : dr.GetInt32(0);
                    NombreMateriaP = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    MaximoCapacidad = dr.IsDBNull(2) ? Default_value : dr.GetDecimal(2);
                    TotalLleno = dr.IsDBNull(3) ? Default_value : dr.GetDecimal(3);
                    VacioCapacidad = dr.IsDBNull(4) ? Default_value : dr.GetDecimal(4);
                    numerodeTanque = dr.IsDBNull(7) ? Default_value : dr.GetInt32(7);
                    Id_tanque_prd = dr.IsDBNull(8) ? Default_value : dr.GetInt32(8);
                    Itemcode = dr.IsDBNull(9) ? "" : dr.GetString(9);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
