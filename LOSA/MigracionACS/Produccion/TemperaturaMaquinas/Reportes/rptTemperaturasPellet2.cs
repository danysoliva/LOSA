using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ACS.Produccion.TemperaturaMaquinas.Reportes
{
    public partial class rptTemperaturasPellet2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTemperaturasPellet2(string PName)
        {
            InitializeComponent();
            lblEquipoName.Text = PName;
        }

        private void xrLabel9_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
