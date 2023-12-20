using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Clases
{
    public class LotePT
    {
        public LotePT()
        {

        }

        public int LotePT_Num;
        public Int64 OrderNum_prd;
        public Int64 OrderId_prd;
        public string OrderCodePP;
        public string CodigoProducto;
        public string DescripcionProducto;
        public string DescripcionPresentacion;
        public int CantidadBatch;
        public decimal TotalKg;
        public int id_presentacion;
        public decimal FactorPresentacion;
        public bool Recuperado;
        public decimal Reproceso_kg;
        public decimal Unidades;
        public int id_pt;
        public int especie;
        public string CodigoUnite;
        public DateTime FechaProduccion;
        public DateTime FechaVence;

        public bool RecuperarRegistro(int pLotePT)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_producidos_por_pt_v3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pt_lote", pLotePT);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LotePT_Num = dr.GetInt32(0);
                    OrderNum_prd = dr.GetInt64(1);
                    if (OrderNum_prd==0)//Si es cero significa que no se envio a producir, por lo cual cortamos la asignacion de variables.
                    {
                        Recuperado = false;
                        return false;
                    }

                    OrderCodePP = dr.GetString(2);
                    CodigoProducto = dr.GetString(3);
                    DescripcionProducto = dr.GetString(4);
                    DescripcionPresentacion = dr.GetString(5);
                    TotalKg = dr.GetDecimal(6);
                    id_presentacion = dr.GetInt32(7);
                    FactorPresentacion = dr.GetDecimal(8);
                    Reproceso_kg = dr.GetDecimal(9);
                    Unidades = dr.GetDecimal(10);
                    CantidadBatch = dr.GetInt32(11);
                    OrderId_prd = dr.GetInt64(12);
                    id_pt = dr.GetInt32(13);
                    especie = dr.GetInt32(14);
                    CodigoUnite = dr.GetString(15);
                    FechaVence = dr.GetDateTime(16);
                    FechaProduccion = dr.GetDateTime(17);
                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                if(FechaVence.Year == 1)
                {
                    //throw new Exception("No se ha registrado Producto Terminado valido con este numero de Lote. No se pudo recuperar el dato de fecha de vencimiento. " +
                    //                    "Esto será posible hasta hacer la recepcion de producto terminado!");

                    CajaDialogo.Error("No se ha registrado Producto Terminado valido con este numero de Lote. No se pudo recuperar el dato de fecha de vencimiento. " +
                                        "Esto será posible hasta hacer la recepcion de producto terminado!");
                }
                else
                {
                    CajaDialogo.Error(ec.Message);
                }
                
            }
            return Recuperado;
        }


        public bool RecuperarRegistro(int pLotePT, string pOrderCode)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_sacos_producidos_por_pt_v3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pt_lote", pLotePT);
                cmd.Parameters.AddWithValue("@order_code", pOrderCode);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LotePT_Num = dr.GetInt32(0);
                    OrderNum_prd = dr.GetInt64(1);
                    OrderCodePP = dr.GetString(2);
                    CodigoProducto = dr.GetString(3);
                    DescripcionProducto = dr.GetString(4);
                    DescripcionPresentacion = dr.GetString(5);
                    TotalKg = dr.GetDecimal(6);
                    id_presentacion = dr.GetInt32(7);
                    FactorPresentacion = dr.GetDecimal(8);
                    Reproceso_kg = dr.GetDecimal(9);
                    Unidades = dr.GetDecimal(10);
                    CantidadBatch = dr.GetInt32(11);
                    OrderId_prd = dr.GetInt64(12);

                    Recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return Recuperado;
        }
    }
}
