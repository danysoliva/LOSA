using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class Tarima
    {
        int _id;
        String _nombreTarima;
        int _id_materiaprima;
        int _cantidad;
        string _idProveedor;
        DateTime _FechaIngreso;
        int _numeroTransaccion;
        DateTime _fechaVencimiento;
        DateTime _fechaProduccion;
        string _LoteMP;
        int _LotePT;
        bool _Enable;
        int _idPresentacion;
        string _Descripcionpresentacion;
        int _idUsuario;
        int _tipotarimaid;
        string _tipoTarimaDescripcion;
        int _idProductoterminado;
        DateTime _fechaProductoTerminadoProduccion;
        int _idBoleta;
        string _CodigoBarra;
        int _idUnidadMedida;
        String _Proveedor;
        bool _Recuperad;

        public Tarima()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public int Id_materiaprima { get => _id_materiaprima; set => _id_materiaprima = value; }
        public int IdUnidadMedida { get => _idUnidadMedida; set => _idUnidadMedida = value; }
        public bool Recuperado { get => _Recuperad; set => _Recuperad = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Descripcionpresentacion { get => _Descripcionpresentacion; set => _Descripcionpresentacion = value; }
        public string TipoTarimaDescripcion { get => _tipoTarimaDescripcion; set => _tipoTarimaDescripcion = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string LoteMP { get => _LoteMP; set => _LoteMP = value; }
        public string NombreTarima { get => _nombreTarima; set => _nombreTarima = value; }
        public string CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }

        public bool RecuperarRegistro(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarima_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    IdUnidadMedida = dr.GetInt32(1);
                    Cantidad = 1;
                    NombreTarima = dr.GetString(2);
                    TipoTarimaDescripcion= dr.GetString(3);
                    Proveedor= dr.GetString(4);
                    LoteMP = dr.GetString(5);
                    Cantidad= dr.GetInt32(7);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }




    }
}
