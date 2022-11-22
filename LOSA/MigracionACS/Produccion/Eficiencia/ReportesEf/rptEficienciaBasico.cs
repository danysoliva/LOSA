
using DevExpress.XtraReports.UI;
using LOSA.MigracionACS.Produccion.DashBoard;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LOSA.MigracionACS.Produccion.Eficiencia.ReportesEf
{
    public partial class rptEficienciaBasico : DevExpress.XtraReports.UI.XtraReport
    {
        //public dsReporteEficiencia DataSetRPT;
        public rptEficienciaBasico(DateTime desde, DateTime hasta, string user, dsReporteEficiencia ds, decimal pTotalReproceso)
        {
            InitializeComponent();
            this.dsReporteEficiencia1 = ds;
            lblDesde.Value = desde;
            lblHasta.Value = hasta;
            lblUsuario.Text = user;
            txtTotalReproceso.Text = string.Format("{0:###,##0.00}", pTotalReproceso);

            //this.DataSetRPT = ds;
        }

    }
}
