using ACS.Classes;
using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Classes
{
    public class MoveLineODOO
    {
        #region Miembros
        int _idLine;
        string _code;
        decimal _credit;
        decimal _debit;
        string _cuenta;
        int _id_cuenta;
        int _idType;
        string _CodeCECO;
        #endregion

        public MoveLineODOO()
        {
        }

        #region Propiedades
        /// <summary>
        /// int32 Get/Set Propiedad Id de la tabla MoveLine de ODOO
        /// </summary>
        public int IdLine { get => _idLine; set => _idLine = value; }
        
        /// <summary>
        /// String Get/Set Propiedad Codigo de Cuenta en SAP desde la tabla AccountAccount de ODOO
        /// </summary>
        public string Code { get => _code; set => _code = value; }
        
        /// <summary>
        /// decimal Get/Set Propiedad Credit de la tabla MoveLine de ODOO
        /// </summary>
        public decimal Credit { get => _credit; set => _credit = value; }

        /// <summary>
        /// decimal Get/Set Propiedad Debit de la tabla MoveLine de ODOO
        /// </summary>
        public decimal Debit { get => _debit; set => _debit = value; }


        public string Cuenta { get => _cuenta; set => _cuenta = value; }

        public int Id_cuenta { get => _id_cuenta; set => _id_cuenta = value; }
        public int IdType { get => _idType; set => _idType = value; }
        public string CodeCECO { get => _CodeCECO; set => _CodeCECO = value; }
        #endregion

        #region Metodos
        public bool RecuperarRegistro(int pMoveLineId)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                string sql = @"select * from public.ft_recupera_move_linev2(:p_id_move_line);";
                PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnection.Open();
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                cmd.Parameters.Add("p_id_move_line", PgSqlType.Int).Value = pMoveLineId;
                PgSqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdLine = dr.GetInt32(0);
                    Debit = dr.GetDecimal(1);
                    Credit = dr.GetDecimal(2);
                    Code = dr.GetString(3);
                    Cuenta = dr.GetString(4);
                    Id_cuenta = dr.GetInt32(5);
                    IdType = dr.GetInt32(6);
                    CodeCECO = dr.GetString(7);
                    r = true;
                    psConnection.Close();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error en la Clase MoveLineODOO. Funcion Recuperar Registro. Transacción: Select",ec);
            }
            return r;
        }


        public bool UpdateAccountMoveLine(int pMoveLineId, int pNewAccountID)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                string sql = @"UPDATE public.account_move_line
	                                SET  account_id=:id_account
	                                WHERE id=:id;";
                PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnection.Open();
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("id_account", pNewAccountID);
                cmd.Parameters.AddWithValue("id", pMoveLineId);

                cmd.ExecuteNonQuery();
                r= true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error en la Clase MoveLineODOO. Funcion Recuperar Registro. Transacción: Select", ec);
            }
            return r;
        }
        public bool UpdateDebitMoveLine(int pMoveLineId, decimal pDebit)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                string sql = @"UPDATE public.account_move_line
	                            SET debit = :debit
	                            WHERE id=:id;";
                PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnection.Open();
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("debit", pDebit);
                cmd.Parameters.AddWithValue("id", pMoveLineId);

                cmd.ExecuteNonQuery();
                r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error en la Clase MoveLineODOO. Funcion Recuperar Registro. Transacción: Select", ec);
            }
            return r;
        }

        public bool UpdateCreditMoveLine(int pMoveLineId, decimal pCredit)
        {
            bool r = false;
            try
            {
                DataOperations dp = new DataOperations();
                string sql = @"UPDATE public.account_move_line
	                              SET credit = :credit
	                            WHERE id = :id;";
                PgSqlConnection psConnection = new PgSqlConnection(dp.ConnectionStringODOO5);
                psConnection.Open();
                PgSqlCommand cmd = new PgSqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("credit", pCredit);
                cmd.Parameters.AddWithValue("id", pMoveLineId);

                cmd.ExecuteNonQuery();
                r = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error("Error en la Clase MoveLineODOO. Funcion Recuperar Registro. Transacción: Select", ec);
            }
            return r;
        }




        #endregion
    }
}
