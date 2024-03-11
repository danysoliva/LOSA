using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LOSA.Clases;

namespace LOSA.Clases
{
    public class SolicitudesCompraSAP
    {
        bool recuperado;
        int docNum;
        DateTime fechaContabilizacion;
        string solicitante;
        string comentarios;
        DateTime fechaVencimiento;
        int tipoOrden;
        DataOperations dp = new DataOperations();

        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public DateTime FechaContabilizacion { get => fechaContabilizacion; set => fechaContabilizacion = value; }
        public string Solicitante { get => solicitante; set => solicitante = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public int TipoOrden { get => tipoOrden; set => tipoOrden = value; }
        public int DocNum { get => docNum; set => docNum = value; }

        public bool RecuperarInfoHeaderSolicitud(int pDocNum)
        {
            Recuperado = false;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand("CM_sp_get_solicitud_compra_for_docnum", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocNum", pDocNum);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DocNum = dr.GetInt32(0);
                    FechaContabilizacion = dr.GetDateTime(1);
                    Solicitante = dr.GetString(2);
                    Comentarios = dr.GetString(3);
                    FechaVencimiento = dr.GetDateTime(4);
                    TipoOrden = dr.GetInt32(5);
                    Recuperado = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                Recuperado = false;
            }

            return Recuperado;
        }


    }
}
