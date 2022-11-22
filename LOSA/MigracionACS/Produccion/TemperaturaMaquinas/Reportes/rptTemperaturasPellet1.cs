using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ACS.Produccion.TemperaturaMaquinas.Reportes
{
    public partial class rptTemperaturasPellet1 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTemperaturasPellet1(string PName)
        {
            InitializeComponent();
            lblEquipoName.Text = PName;
        }

    }
}
