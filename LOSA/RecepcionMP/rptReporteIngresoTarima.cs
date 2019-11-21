using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace LOSA.RecepcionMP
{
    public partial class rptReporteIngresoTarima : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReporteIngresoTarima(int idTarima)
        {
            InitializeComponent();
            Tarima tar1 = new Tarima();
        }

    }
}
