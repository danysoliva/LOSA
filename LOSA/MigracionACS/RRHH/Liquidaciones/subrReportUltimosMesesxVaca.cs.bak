using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using ACS.Classes;
using System.Data;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;
using LOSA.Classes;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class subrReportUltimosMesesxVaca : DevExpress.XtraReports.UI.XtraReport
    {
        int Id_Empleado, anio;
        decimal diasTomados;

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell1_EvaluateBinding(object sender, BindingEventArgs e)
        {
            string val = e.Value.ToString();
            switch (val)
            {
                case "Total":
                    xrTable1.Rows[xrTableCell1.Index].BackColor = Color.Gainsboro;
                    xrTableCell1.BackColor = Color.Gainsboro;
                    break;
                case "Promedio":
                    xrTable1.Rows[xrTableCell1.Index].BackColor = Color.Gainsboro;
                    xrTableCell1.BackColor = Color.Gainsboro;
                    break;
                default:
                       xrTableCell1.BackColor = Color.White;
                    break;
            } 
        }

        public subrReportUltimosMesesxVaca(int pId_Empleado, int panio, Decimal pdiasTomados)
        {
            InitializeComponent();

            Id_Empleado = pId_Empleado;
            pp_anios.Value = anio = panio;
            pp_dias_tomados.Value = diasTomados = pdiasTomados;

            Liquidacion liqui = new Liquidacion();
            liqui.RecuperarHeaderLiquidacionForEmpleado(Id_Empleado);
            lblSalarioPrMensual.Text = Convert.ToString(liqui.salario_pro_mensual);

            //LoadVacaciones();
            //foreach (dsRRHH_.LiquiUltimosMesesRow row in dsRRHH_1.LiquiUltimosMeses)
            //{
            //    string.Format("{0:0.00}", row.sueldo_recibido);
            //    string.Format("{0:0.00}", row.bono);
            //    string.Format("{0:0.00}", row.comisiones);
            //    string.Format("{0:0.00}", row.horas_extra);
            //    string.Format("{0:0.00}", row.incentivo);
            //    string.Format("{0:0.00}", row.total);
            //}
        }
    }
}
