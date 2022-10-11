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
   public class TarimaMicroingrediente
    {

        int _id;
        int _id_materiaprima;
        decimal _cantidad;
        decimal _cantidadKg;
        decimal _peso;
        string _idProveedor;
        DateTime _FechaIngreso;
        int _numeroTransaccion;
        DateTime _fechaVencimiento;
        DateTime _fechaProduccion;
        string _LoteMP;
        bool _Enable;
        bool _Recuperad;
        int _idPresentacion;
        int _idUsuario;
        int _tipotarimaid;
        int _idBoleta;
        string _CodigoBarra;
        int _id_ingreso;
        String _Proveedor;
        String _MateriaPrimaName;
        string Itemcode;
        string _MateriaPrima;
        int _idTarimaOrigen;



        public int Id { get => _id; set => _id = value; }
        public int Id_materiaprima { get => _id_materiaprima; set => _id_materiaprima = value; }
        public bool Recuperado { get => _Recuperad; set => _Recuperad = value; }
        public string CardCode { get => _idProveedor; set => _idProveedor = value; }
        public DateTime FechaIngreso { get => _FechaIngreso; set => _FechaIngreso = value; }
        public int NumeroTransaccion { get => _numeroTransaccion; set => _numeroTransaccion = value; }
        public DateTime FechaProduccionMP { get => _fechaProduccion; set => _fechaProduccion = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public bool Enable { get => _Enable; set => _Enable = value; }
        public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }
        public int IdBoleta { get => _idBoleta; set => _idBoleta = value; }
        public string CodigoBarra { get => _CodigoBarra; set => _CodigoBarra = value; }
        public decimal Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal CantidadKg { get => _cantidadKg; set => _cantidadKg = value; }
        public int Id_ingreso { get => _id_ingreso; set => _id_ingreso = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string LoteMP { get => _LoteMP; set => _LoteMP = value; }
        public string NombreTarima { get => _MateriaPrimaName; set => _MateriaPrimaName = value; }
        public string ItemCode { get => Itemcode; set => Itemcode = value; }
        public string MateriaPrima { get => _MateriaPrima; set => _MateriaPrima = value; }
        public int IdTarimaOrigen { get => _idTarimaOrigen; set => _idTarimaOrigen = value; }

        public TarimaMicroingrediente()
        {

        }

        public bool RecuperarRegistroTarimaMicros(int pIdTarima, string pCodigoBarra)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_row_tarima_micros_from_id_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdTarima);
                cmd.Parameters.AddWithValue("@barcode", pCodigoBarra);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Id_materiaprima = dr.GetInt32(1);
                    if (!dr.IsDBNull(dr.GetOrdinal("CardCode")))
                        CardCode = dr.GetString(2);
                    else
                        CardCode = null;

                    FechaIngreso = dr.GetDateTime(3);

                    if (!dr.IsDBNull(dr.GetOrdinal("numero_transaccion")))
                        NumeroTransaccion = dr.GetInt32(4);
                    else
                        NumeroTransaccion = 0;

                    FechaVencimiento = dr.GetDateTime(5);
                    _fechaProduccion = dr.GetDateTime(6);

                    if (!dr.IsDBNull(dr.GetOrdinal("lote_materia_prima")))
                        _LoteMP = dr.GetString(7);
                    else
                        _LoteMP = null;

                    Enable = dr.GetBoolean(8);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_presentacion")))
                        IdPresentacion = dr.GetInt32(9);
                    else
                        IdPresentacion = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_usuario")))
                        _idUsuario = dr.GetInt32(10);
                    else
                        _idUsuario = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("codigo_barra")))
                        CodigoBarra = dr.GetString(11);
                    else
                        CodigoBarra = null;

                    Cantidad = dr.GetDecimal(12);//ó unidades
                    CantidadKg = dr.GetDecimal(13);

                    if (!dr.IsDBNull(dr.GetOrdinal("id_tarima_origen")))
                        IdTarimaOrigen = dr.GetInt32(14);
                    else
                        IdTarimaOrigen = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("itemcode")))
                        ItemCode = dr.GetString(15);
                    else
                        ItemCode = null;

                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                Recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
    }
}
