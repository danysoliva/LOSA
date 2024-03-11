using ACS.Classes;
using DevExpress.XtraPrinting.Native.Lines;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class CMOrdenCompraH
    {
        public int Id { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Address { get; set; }
        public string NumAtCard { get; set; }
        public char State { get; set; }
        public int DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocDueDate { get; set; }
        public DateTime TaxDate { get; set; }
        public int U_TipoOrden { get; set; }
        public string U_AquaExoneracion { get; set; }
        public DateTime U_FechaExoneracion { get; set; }
        public string Comments { get; set; }
        public decimal ISV { get; set; }
        public decimal DocTotal { get; set; }
        public string CurSource { get; set; }
        public string DocCur { get; set; }
        public decimal? DocRate { get; set; }
        public int DocNumSolicitud { get; set; }
        public bool PostedInSAP { get; set; }
        public int ContactCode { get; set; }
        public int IdEstado { get;  set; }
        public string EstadoName { get; set; }
        public int IdUsuarioCreate { get; set; }
        public string UsuarioName { get; set; }
        public int idUserAprobo { get; set; }
        public string UserAprobo { get; set; }
        public bool Recuperado { get; set; }
        

        public CMOrdenCompraH() { }

        public bool RecuperarRegistro(int pIdOrdenH)
        {
            DataOperations dp = new DataOperations();
            try
            {
                string connectionString = dp.ConnectionStringLOSA;
                string query = @"sp_get_orden_compra_class";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_ordencompra", pIdOrdenH);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id"));
                        
                        if(reader.IsDBNull(reader.GetOrdinal("CardCode")))
                            CardCode = string.Empty; 
                        else
                            CardCode = reader.GetString(reader.GetOrdinal("CardCode"));


                        if (reader.IsDBNull(reader.GetOrdinal("CardName")))
                            CardName = string.Empty;
                        else
                            CardName = reader.GetString(reader.GetOrdinal("CardName"));


                        if (reader.IsDBNull(reader.GetOrdinal("Address")))
                            Address = string.Empty;
                        else
                            Address = reader.GetString(reader.GetOrdinal("Address"));


                        if (reader.IsDBNull(reader.GetOrdinal("NumAtCard")))
                            NumAtCard = string.Empty;
                        else
                            NumAtCard = reader.GetString(reader.GetOrdinal("NumAtCard"));


                        if (reader.IsDBNull(reader.GetOrdinal("State")))
                            State = 'O';
                        else
                            State = Convert.ToChar(reader.GetString(5));


                        if (reader.IsDBNull(reader.GetOrdinal("DocNum")))
                            DocNum = 0;
                        else
                            DocNum = reader.GetInt32(reader.GetOrdinal("DocNum"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocDate")))
                            DocDate = DateTime.MinValue;
                        else
                            DocDate = reader.GetDateTime(reader.GetOrdinal("DocDate"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocDueDate")))
                            DocDueDate = DateTime.MinValue;
                        else
                            DocDueDate = reader.GetDateTime(reader.GetOrdinal("DocDueDate"));


                        if (reader.IsDBNull(reader.GetOrdinal("TaxDate")))
                            TaxDate = DateTime.MinValue;
                        else
                            TaxDate = reader.GetDateTime(reader.GetOrdinal("TaxDate"));


                        if (reader.IsDBNull(reader.GetOrdinal("U_TipoOrden")))
                            U_TipoOrden = 0;
                        else
                            U_TipoOrden = reader.GetInt32(reader.GetOrdinal("U_TipoOrden"));


                        if (reader.IsDBNull(reader.GetOrdinal("U_AquaExoneracion")))
                            U_AquaExoneracion = string.Empty;
                        else
                            U_AquaExoneracion = reader.GetString(reader.GetOrdinal("U_AquaExoneracion"));

                        
                        if (reader.IsDBNull(reader.GetOrdinal("U_FechaExoneracion")))
                            U_FechaExoneracion = DateTime.MinValue;
                        else
                            U_FechaExoneracion = reader.GetDateTime(reader.GetOrdinal("U_FechaExoneracion"));


                        if (reader.IsDBNull(reader.GetOrdinal("Comments")))
                            Comments = string.Empty;
                        else
                            Comments = reader.GetString(reader.GetOrdinal("Comments"));


                        if (reader.IsDBNull(reader.GetOrdinal("ISV")))
                            ISV = 0;
                        else
                            ISV = reader.GetDecimal(reader.GetOrdinal("ISV"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocTotal")))
                            DocTotal = 0;
                        else
                            DocTotal = reader.GetDecimal(reader.GetOrdinal("DocTotal"));


                        //if (reader.IsDBNull(reader.GetOrdinal("CurSource")))
                        if (reader.IsDBNull(reader.GetOrdinal("CurSource")))
                            CurSource = string.Empty;
                        else
                            CurSource = reader.GetString(16);


                        if (reader.IsDBNull(reader.GetOrdinal("DocCur")))
                            DocCur = string.Empty;
                        else
                            DocCur = reader.GetString(17).Trim();


                        if (reader.IsDBNull(reader.GetOrdinal("DocRate")))
                            DocRate = 0;
                        else
                            DocRate = reader.GetDecimal(reader.GetOrdinal("DocRate"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocNumSolicitud")))
                            DocNumSolicitud = 0;
                        else
                            DocNumSolicitud = reader.GetInt32(reader.GetOrdinal("DocNumSolicitud"));


                        if (reader.IsDBNull(reader.GetOrdinal("posted_in_sap")))
                            PostedInSAP = false; 
                        else
                            PostedInSAP = reader.GetBoolean(reader.GetOrdinal("posted_in_sap"));


                        if (reader.IsDBNull(reader.GetOrdinal("ContactCode")))
                            ContactCode = 0;
                        else
                            ContactCode = reader.GetInt32(reader.GetOrdinal("ContactCode"));



                        if (reader.IsDBNull(reader.GetOrdinal("id_estado")))
                            IdEstado = 0;
                        else
                            IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));



                        if (reader.IsDBNull(reader.GetOrdinal("estado_name")))
                            EstadoName = string.Empty; 
                        else
                            EstadoName = reader.GetString(reader.GetOrdinal("estado_name"));



                        if (reader.IsDBNull(reader.GetOrdinal("id_user_cre")))
                            IdUsuarioCreate = 0;
                        else
                            IdUsuarioCreate = reader.GetInt32(reader.GetOrdinal("id_user_cre"));

                        

                        if (reader.IsDBNull(reader.GetOrdinal("usuario_cre")))
                            UsuarioName = string.Empty;
                        else
                            UsuarioName = reader.GetString(reader.GetOrdinal("usuario_cre"));


                        if (reader.IsDBNull(reader.GetOrdinal("id_user_aprobo")))
                            idUserAprobo = 0;
                        else
                            idUserAprobo = reader.GetInt32(reader.GetOrdinal("id_user_aprobo"));


                        if (reader.IsDBNull(reader.GetOrdinal("user_aprobo_name")))
                            UserAprobo = string.Empty;
                        else
                            UserAprobo = reader.GetString(reader.GetOrdinal("user_aprobo_name"));
                        Recuperado = true;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message); return false;
            }
            return Recuperado;


        }
    }
}
