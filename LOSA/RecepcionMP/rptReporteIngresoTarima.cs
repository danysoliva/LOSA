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
            if (tar1.RecuperarRegistro(idTarima, null))
            {
                //IdUnidadMedida = dr.GetInt32(1);
                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                 NombreTarima = dr.GetString(2);
                TipoTarimaDescripcion = dr.GetString(3);
                Proveedor = dr.GetString(4);
                LoteMP = dr.GetString(5);
                Cantidad = dr.GetInt32(7);
            }

        }

    }
}
