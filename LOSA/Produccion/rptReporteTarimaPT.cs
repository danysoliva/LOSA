using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.RecepcionMP
{
    public partial class rptReporteTarimaPT : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        int id_tm;
        public rptReporteTarimaPT(int idTarima)
        {
            InitializeComponent();
            Tarima tar1 = new Tarima();              
            id_tm = idTarima;
            load_printed_tm(); 
            if (tar1.RecuperarRegistro(idTarima, ""))
            {
                DataOperations dp = new DataOperations();
                ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                if (pt.Recuperar_producto(tar1.IdProductoterminado))
                {
                    lblNombreProducto.Text = pt.descripcion;

                    lblNumeroIngreso.Text = pt.Codigo;
                    BagsPT bag = new BagsPT();
                    if (bag.RecuperarRegistro_v2(tar1.IdPresentacion))
                    {
                        lblPresentacion.Text = bag.Descripcion;
                    }
                }

                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                //lblPresentacion.Text = tar1.Proveedor;
                lblLote.Text = tar1.LotePT.ToString();
                lblCantidad.Text = tar1.Cantidad.ToString();
                //lblNombreProducto.Text = tar1.MateriaPrima;
                lblFechaIngreso.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaIngreso);   
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccion);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                lblTurno.Text = tar1.Id_turno.ToString();
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
            }

        }
        public void load_printed_tm()
        {
            string query = @"sp_op_tarimas_inizialiar";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tm", id_tm);
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
