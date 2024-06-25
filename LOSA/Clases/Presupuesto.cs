using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class Presupuesto
    {
        public Presupuesto()
        {
        }

        #region Presupuesto Header
        public int IdPresupuesto { get; set; }
        public int? Anio { get; set; }
        public string DescripcionH { get; set; }
        public int? IdEstado { get; set; }
        public string EstadoH { get; set; }
        public DateTime? FechaH { get; set; }
        public int? UserId { get; set; }
        public string usuarioH { get; set; }
        #endregion

        #region PresupuestoDetalle
        public int IdDetalle { get; set; }             // Maps to id_d
        public int Detalle_IdPresupuesto { get; set; }         // Maps to id_presupuesto
        public int IdDepartamento { get; set; }        // Maps to id_departamento
        public string DescripcionDepartamento { get; set; } // Maps to descripcion_departamento
        public string Detalle_Nombre { get; set; }             // Maps to nombre
        public int Detalle_UserId { get; set; }                // Maps to user_id
        public DateTime Detalle_Fecha { get; set; }
        #endregion

        public bool Recuperado { get; set; }



        DataOperations dp = new DataOperations();


        public bool RecuperarPresupuestoH(int PidPresupuesto)
        {
            Recuperado = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_presupuesto_header_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_presupuesto", PidPresupuesto);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdPresupuesto = dr.GetInt32(0);
                    Anio = dr.GetInt32(1);
                    DescripcionH = dr.GetString(2);
                    IdEstado = dr.GetInt32(3);
                    EstadoH = dr.GetString(4);
                    FechaH = dr.GetDateTime(5);
                    UserId = dr.GetInt32(6);
                    usuarioH = dr.GetString(7);
                    Recuperado = true;
                }
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }

        public bool RecuperarPresupuestoD(int Pid_detallePresupuesto)
        {
            Recuperado = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_presupuesto_detalle_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", Pid_detallePresupuesto);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdDetalle = dr.GetInt32(0);
                    Detalle_IdPresupuesto = dr.GetInt32(1);
                    IdDepartamento = dr.GetInt32(2);
                    DescripcionDepartamento = dr.GetString(3);
                    Detalle_Nombre = dr.GetString(4);
                    Detalle_UserId = dr.GetInt32(5);
                    Detalle_Fecha = dr.GetDateTime(6);
                    Recuperado = true;
                }
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }


        public bool InsertarDetalleLineaPresupuesto(int Pid_detallePresupuesto, string pDescripcionPresupuesto, decimal pMonto, int pUserId)
        {
            Recuperado = false;
            try
            {

                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_presupuesto_insert_detalle_lineas]", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_d", Pid_detallePresupuesto);
                cmd.Parameters.AddWithValue("@descripcion", pDescripcionPresupuesto);
                cmd.Parameters.AddWithValue("@monto", pMonto);
                cmd.Parameters.AddWithValue("@user_id", pUserId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Recuperado = false;
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }
    }
}
