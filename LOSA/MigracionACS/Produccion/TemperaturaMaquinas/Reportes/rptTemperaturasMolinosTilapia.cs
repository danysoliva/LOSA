using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ACS.Produccion.TemperaturaMaquinas.Reportes
{
    public partial class rptTemperaturasMolinosTilapia : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTemperaturasMolinosTilapia(string PName)
        {
            InitializeComponent();
            lblEquipoName.Text = PName;
        }

    }
}
