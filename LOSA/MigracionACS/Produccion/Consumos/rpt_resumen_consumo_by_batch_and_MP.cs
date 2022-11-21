using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LOSA.MigracionACS.Produccion.Consumos
{
    public partial class rpt_resumen_consumo_by_batch_and_MP : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_resumen_consumo_by_batch_and_MP( string pOrdenHeader,
                                                    string plote,
                                                    string pproducto,
                                                    string ppresentacion,
                                                    string pcodigo,
                                                    string pformula,
                                                    string pversion,
                                                    string porder_num)
        {
            InitializeComponent();
            lblOrden_header.Text = pOrdenHeader;
            lblLote.Text = plote;
            lblProducto.Text = pproducto;
            lblpresentacion.Text = ppresentacion;
            lblcodigo.Text = pcodigo;
            lblformula.Text = pformula;
            lblversion.Text = pversion;
            lblorder_num.Text = porder_num;
        }

    }
}
