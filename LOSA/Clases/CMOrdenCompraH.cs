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
        public char CurSource { get; set; }
        public string DocCur { get; set; }
        public decimal? DocRate { get; set; }
        public int DocNumSolicitud { get; set; }
        public bool PostedInSAP { get; set; }
        public int ContactCode { get; set; }
        public int IdEstado { get;  set; }
        public string EstadoName { get; set; }
        public int IdUsuarioCreate { get; set; }
        public string UsuarioName { get; set; }

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
                            State = Convert.ToChar("O");
                        else
                            State = reader.GetChar(reader.GetOrdinal("State"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocNum")))
                            DocNum = 0;
                        else
                            DocNum = reader.GetInt32(reader.GetOrdinal("DocNum"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocDate")))
                            DocDate = DateTime.MinValue;
                        else
                            DocDate = reader.GetDateTime(reader.GetOrdinal("DocDate"));


                        if (reader.IsDBNull(reader.GetOrdinal("DocDueDate")))
                            DocDueDate = reader.GetDateTime(reader.GetOrdinal("DocDueDate"));
                        else
                            DocDueDate = reader.GetDateTime(reader.GetOrdinal("DocDueDate"));


                        TaxDate = reader.GetDateTime(reader.GetOrdinal("TaxDate"));
                        U_TipoOrden = reader.GetInt32(reader.GetOrdinal("U_TipoOrden"));
                        U_AquaExoneracion = reader.GetString(reader.GetOrdinal("U_AquaExoneracion"));
                        U_FechaExoneracion = reader.GetDateTime(reader.GetOrdinal("U_FechaExoneracion"));
                        Comments = reader.GetString(reader.GetOrdinal("Comments"));
                        ISV = reader.GetDecimal(reader.GetOrdinal("ISV"));
                        DocTotal = reader.GetDecimal(reader.GetOrdinal("DocTotal"));
                        CurSource = reader.GetChar(reader.GetOrdinal("CurSource"));
                        DocCur = reader.GetString(reader.GetOrdinal("DocCur"));
                        DocRate = reader.GetDecimal(reader.GetOrdinal("DocRate"));
                        DocNumSolicitud = reader.GetInt32(reader.GetOrdinal("DocNumSolicitud"));
                        PostedInSAP = reader.GetBoolean(reader.GetOrdinal("posted_in_sap"));
                        ContactCode = reader.GetInt32(reader.GetOrdinal("ContactCode"));
                        IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));
                        IdUsuarioCreate = reader.GetInt32(reader.GetOrdinal("id_user_cre"));
                        UsuarioName = reader.GetString(reader.GetOrdinal("usuario_cre"));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message); return false;
            }
            return true;
            
            
        }
    }
}
