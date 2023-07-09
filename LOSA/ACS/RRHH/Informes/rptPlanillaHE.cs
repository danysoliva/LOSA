using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LOSA.ACS.RRHH.Informes
{
    public partial class rptPlanillaHE : DevExpress.XtraReports.UI.XtraReport
    {
        PlanillaHeader Planilla1;
        DetallePlanillaHE Detalle1;
        public rptPlanillaHE(Int64 pIdDetalle)
        {
            InitializeComponent();
            Planilla1 = new PlanillaHeader();
            Detalle1 = new DetallePlanillaHE();
            if (Detalle1.FillDetallePlanillaVariables(pIdDetalle))
            {
                if (Planilla1.FillEncabezadoPlanillaVariables(Detalle1.id_h))
                {
                    lblTitulo2.Text = lblTitulo1.Text = Planilla1.Titulo;
                    lblNota2.Text = lblNota1.Text = Planilla1.nota;
                    lblNombre2.Text = lblNombre1.Text = Detalle1.empleado_nombre;
                    lblCedula1.Text = lblCedula2.Text = Detalle1.identidad;
                    lblPuesto_Cargo2.Text = lblPuesto_Cargo1.Text = Detalle1.cargo;
                    lblCodigo2.Text = lblCodigo1.Text = Detalle1.codigo;
                    lblFechaPago2.Text = lblFechaPago1.Text = string.Format("{0:dd/MMM/yyyy}", Planilla1.fecha_desde) + " al " + 
                                                              string.Format("{0:dd/MMM/yyyy}", Planilla1.fecha_hasta);
                    string stringFormatDecimal = "{0:"+ Planilla1.currency + " #,##0.00}";
                    string stringFormatInt = "{0: #,##0}";


                    lblSalarioBasicoTotalHE1.Text = lblSalarioBasicoTotalHE2.Text = string.Format(stringFormatDecimal, Detalle1.Salario_basico_total);
                    lblHE_25_1.Text = lblHE_25_2.Text = string.Format(stringFormatInt, Detalle1.HE_25);
                    lblHE_50_1.Text = lblHE_50_2.Text = string.Format(stringFormatInt, Detalle1.HE_50);
                    lblHE_75_1.Text = lblHE_75_2.Text = string.Format(stringFormatInt, Detalle1.HE_75);
                    lblHE_100_1.Text = lblHE_100_2.Text = string.Format(stringFormatInt, Detalle1.HE_100);

                    lbl_PHE_25_1.Text = lbl_PHE_25_2.Text = string.Format(stringFormatDecimal, Detalle1.PHE_25);
                    lbl_PHE_50_1.Text = lbl_PHE_50_2.Text = string.Format(stringFormatDecimal, Detalle1.PHE_50);
                    lbl_PHE_75_1.Text = lbl_PHE_75_2.Text = string.Format(stringFormatDecimal, Detalle1.PHE_75);
                    lbl_PHE_100_1.Text = lbl_PHE_100_2.Text = string.Format(stringFormatDecimal, Detalle1.PHE_100);

                    lblSalarioNeto1.Text = lblSalarioNeto2.Text = string.Format(stringFormatDecimal, Detalle1.Total_Horas_Extra);
                }
            }
            
        }

    }
}
