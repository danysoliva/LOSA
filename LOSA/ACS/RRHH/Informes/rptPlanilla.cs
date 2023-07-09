using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LOSA.ACS.RRHH.Informes
{
    public partial class rptPlanilla : DevExpress.XtraReports.UI.XtraReport
    {
        PlanillaHeader Planilla1;
        DetallePlanilla Detalle1;
        public rptPlanilla(Int64 pIdDetalle)
        {
            InitializeComponent();
            Planilla1 = new PlanillaHeader();
            Detalle1 = new DetallePlanilla();
            if (Detalle1.FillDetallePlanillaVariables(pIdDetalle))
            {
                if (Planilla1.FillEncabezadoPlanillaVariables(Detalle1.Id_h))
                {
                    lblTitulo2.Text = lblTitulo1.Text = Planilla1.Titulo;
                    lblNota2.Text = lblNota1.Text = Planilla1.nota;
                    lblNombre2.Text = lblNombre1.Text = Detalle1.Empleado;
                    lblCedula1.Text = lblCedula2.Text = Detalle1.Identidad;
                    lblPuesto_Cargo2.Text = lblPuesto_Cargo1.Text = Detalle1.Cargo;
                    lblCodigo2.Text = lblCodigo1.Text = Detalle1.Codigo;
                    lblFechaPago2.Text = lblFechaPago1.Text = string.Format("{0:dd/MMM/yyyy}", Planilla1.fecha_desde) + " al " + 
                                                              string.Format("{0:dd/MMM/yyyy}", Planilla1.fecha_hasta);
                    string stringFormatDecimal = "{0:"+ Planilla1.currency + " #,##0.00}";
                    string stringFormatInt = "{0: #,##0}";


                    lblDiasVacaciones1.Text = lblDiasVacaciones2.Text = string.Format(stringFormatInt, Detalle1.Dias_Vacaciones);
                    lblDiasFaltados1.Text = lblDiasFaltados2.Text = string.Format(stringFormatInt, Detalle1.Dias_Faltados);
                    lblDiasLaborados1.Text = lblDiasLaborados2.Text = string.Format(stringFormatInt, Detalle1.Dias_Laborados);
                    lblSalarioBasicoTotal1.Text = lblSalarioBasicoTotal2.Text = string.Format(stringFormatDecimal, Detalle1.Salario_basico_total);
                    lblPVacaciones1.Text = lblPVacaciones2.Text = string.Format(stringFormatDecimal, Detalle1.Vacaciones);
                    lblTransporte1.Text = lblTransporte2.Text = string.Format(stringFormatDecimal, Detalle1.Transporte);
                    lblTotalIngresos1.Text = lblTotalIngresos2.Text = string.Format(stringFormatDecimal, Detalle1.Total_Ingresos);
                    lblUsula1.Text = lblUsula2.Text = string.Format(stringFormatDecimal, Detalle1.USULA);
                    lblCafeteria1.Text = lblCafeteria2.Text = string.Format(stringFormatDecimal, Detalle1.Cafeteria);
                    lblPrestamoCoop1.Text = lblPrestamoCoop2.Text = string.Format(stringFormatDecimal, Detalle1.Prestamo_Coop);
                    lblAhorroFijoCoop1.Text = lblAhorroFijoCoop2.Text = string.Format(stringFormatDecimal, Detalle1.Ahorro_fijo_Coop);
                    lblAhorroRetCoop1.Text = lblAhorroRetCoop2.Text = string.Format(stringFormatDecimal, Detalle1.Ahorro_Ret_Coop);
                    lblIHSS_1.Text = lblIHSS_2.Text = string.Format(stringFormatDecimal, Detalle1.IHSS_T);
                    lblIncapacidades1.Text = lblIncapacidades2.Text = string.Format(stringFormatDecimal, Detalle1.INCAPACIDADES);
                    lbl_ISR1.Text = lbl_ISR2.Text = string.Format(stringFormatDecimal, Detalle1.ISR);

                    lblTotalEgresos1.Text = lblTotalEgresos2.Text = string.Format(stringFormatDecimal, Detalle1.Total_Egresos);
                    lblSalarioNeto1.Text = lblSalarioNeto2.Text = string.Format(stringFormatDecimal, Detalle1.Salario_neto);
                }
            }
            
        }

    }
}
