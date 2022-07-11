using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LOSA.Clases;

namespace LOSA.RecepcionMP
{
    public partial class rptReporteIngresoTarima : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReporteIngresoTarima(int idTarima)
        {
            InitializeComponent();
            Tarima tar1 = new Tarima();
            if (tar1.RecuperarRegistro(idTarima, ""))
            {
                //IdUnidadMedida = dr.GetInt32(1);
                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                //NombreTarima = dr.GetString(2);
                //TipoTarimaDescripcion = dr.GetString(3);
                lblProveedor.Text = tar1.Proveedor;
                lblLote.Text = tar1.LoteMP;
                lblCantidad.Text = tar1.Cantidad.ToString();
                lblNombreProducto.Text = tar1.MateriaPrima;
                lblFechaIngreso.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaIngreso);
                lblNumeroIngreso.Text = tar1.NumeroTransaccion.ToString();
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccion);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                txtcodigo.Text = tar1.ItemCode;
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
            }

        }

    }
}
