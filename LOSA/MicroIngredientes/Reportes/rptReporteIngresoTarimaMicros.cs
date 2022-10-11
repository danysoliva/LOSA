using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.MicroIngredientes.Reportes
{
    public partial class rptReporteIngresoTarimaMicros : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReporteIngresoTarimaMicros(int idTarima)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            lblVersion.Text = dp.AssemblyVersion;

            TarimaMicroingrediente tar1 = new TarimaMicroingrediente();
            if (tar1.RecuperarRegistroTarimaMicros(idTarima, ""))
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
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccionMP);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                txtcodigo.Text = tar1.ItemCode;
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
                
            }

        }

    }
}
