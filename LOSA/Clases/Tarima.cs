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
        decimal _cantidad;
        decimal _peso;
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
        string _MateriaPrima;
        decimal _factor;

        public Tarima()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public int Id_materiaprima { get => _id_materiaprima; set => _id_materiaprima = value; }
        public int IdUnidadMedida { get => _idUnidadMedida; set => _idUnidadMedida = value; }
        public bool Recuperado { get => _Recuperad; set => _Recuperad = value; }
        public decimal Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Descripcionpresentacion { get => _Descripcionpresentacion; set => _Descripcionpresentacion = value; }
        public string TipoTarimaDescripcion { get => _tipoTarimaDescripcion; set => _tipoTarimaDescripcion = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string LoteMP { get => _LoteMP; set => _LoteMP = value; }
        public string NombreTarima { get => _nombreTarima; set => _nombreTarima = value; }
        public string CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }
        public string MateriaPrima { get => _MateriaPrima; set => _MateriaPrima = value; }
        public DateTime FechaIngreso { get => _FechaIngreso; set => _FechaIngreso = value; }
        public int NumeroTransaccion { get => _numeroTransaccion; set => _numeroTransaccion = value; }
        public DateTime FechaProduccion { get => _fechaProduccion; set => _fechaProduccion = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public int IdBoleta { get => _idBoleta; set => _idBoleta = value; }
        public decimal Peso { get => _peso; set => _peso = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }
        public decimal Factor { get => _factor; set => _factor = value; }

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
                    //Cantidad = 1;
                    _nombreTarima = dr.GetString(2);
                    TipoTarimaDescripcion = dr.GetString(3);
                    IdProveedor = dr.GetString(4);
                    LoteMP = dr.GetString(5);
                    Cantidad = dr.GetDecimal(7);
                    Id_materiaprima = dr.GetInt32(8);
                    MateriaPrima = dr.GetString(9);
                    FechaIngreso = dr.GetDateTime(10);
                    NumeroTransaccion = dr.GetInt32(11);
                    FechaProduccion = dr.GetDateTime(12);
                    FechaVencimiento = dr.GetDateTime(13);
                    IdBoleta = dr.GetInt32(14);
                    CodigoBarra = dr.GetString(15);
                    Factor = dr.GetDecimal(16);
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


        public bool RecuperarRegistro(int pIdTarima)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_from_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                //cmd.Parameters.AddWithValue("@codigo_barra", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_materiaprima = dr.GetInt32(1);
                    IdProveedor = dr.GetString(2);
                    FechaIngreso = dr.GetDateTime(3);
                    NumeroTransaccion = dr.GetInt32(4);
                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);
                    _LoteMP = dr.GetString(7);
                    _LotePT = dr.GetInt32(8);
                    _Enable = dr.GetBoolean(9);
                    IdPresentacion = dr.GetInt32(10);
                    _idUsuario = dr.GetInt32(11);
                    _tipotarimaid = dr.GetInt32(12);
                    _idProductoterminado = dr.GetInt32(13);
                    _fechaProductoTerminadoProduccion = dr.GetDateTime(14);
                    IdBoleta = dr.GetInt32(15);
                    CodigoBarra = dr.GetString(16);
                    Cantidad = dr.GetDecimal(17);//ó unidades
                    IdUnidadMedida = dr.GetInt32(18);
                    _peso = dr.GetDecimal(19);


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
