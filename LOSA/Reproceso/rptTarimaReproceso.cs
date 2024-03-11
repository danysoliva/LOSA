using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.RecepcionMP;

namespace LOSA.Reproceso
{
    public partial class rptTarimaReproceso : DevExpress.XtraReports.UI.XtraReport
    {
        int id_tarima_PT;
        public rptTarimaReproceso(int idTarima)
        {
            InitializeComponent();

            
            Tarima tar1 = new Tarima();
            if (tar1.RecuperarRegistro(idTarima, ""))
            {
                //IdUnidadMedida = dr.GetInt32(1);
                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                //NombreTarima = dr.GetString(2);
                //TipoTarimaDescripcion = dr.GetString(3);
                lblTipoReproceso.Text = tar1.MateriaPrima;
                lblLote.Text = Convert.ToString(tar1.LoteMP);
                lblCantidad.Text = tar1.Cantidad.ToString();
                //lblNombreProducto.Text = tar1.ProductoTerminadoName;
                lblFechaIngreso.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaIngreso);
                //lblNumeroIngreso.Text = tar1.NumeroTransaccion.ToString();
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccionMP);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                txtcodigo.Text = tar1.ItemCode;
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
                id_tarima_PT = tar1.Id_tarima_reproceso;
                xrlblTurno.Text = tar1.Turno;

                Tarima tar2 = new Tarima();
                tar2.RecuperarTarimaPT(id_tarima_PT);
                if (tar2.ProductoTerminadoName == null)
                {
                    LotePT PT = new LotePT();
                    if (PT.RecuperarRegistro(Convert.ToInt32(tar1.LoteMP)))
                    {
                        lblNombreProducto.Text = PT.DescripcionProducto;
                    }
                    else
                    {
                        lblNombreProducto.Text = tar1.MateriaPrima;
                    }
                }
                else
                {
                    lblNombreProducto.Text = tar2.ProductoTerminadoName;
                }
                
            }

            CargarCausasReproceso(idTarima, id_tarima_PT);


        }

        private void CargarCausasReproceso(int pidTarima, int pid_tarima_pt)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_get_causas_reproceso_for_tarima", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", pidTarima);
                cmd.Parameters.AddWithValue("@id_tarima_pt", pid_tarima_pt);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.causas_reproceso.Clear();
                adat.Fill(dsRecepcionMPx1.causas_reproceso);
                connection.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
