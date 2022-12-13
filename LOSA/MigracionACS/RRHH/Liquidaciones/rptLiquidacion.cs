using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using ACS.Classes;
using System.Data;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;
using LOSA.Classes;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class rptLiquidacion : DevExpress.XtraReports.UI.XtraReport
    {
        int IdEmpleado;
        int id_liquidacion = 0;
        int anio;
        public rptLiquidacion(int pid_empleado, Liquidacion pliquidacion, int panio)
        {
            InitializeComponent();
            IdEmpleado = pid_empleado;
            anio = panio;
            ObtenerIDLiquidacion();

            //DERECHOS LIQUIDACION
            xrPreavisodias.Text = string.Format("{0:###,##0.00}", pliquidacion.Preaviso);
            xrPreavisototal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Preaviso_total);

            xrCesantiadias.Text = string.Format("{0:###,##0.00}", pliquidacion.Cesantia_dias);
            xrCesantiatotal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Cesantia_total);

            xrCesantiapropdias.Text = string.Format("{0:###,##0.00}", pliquidacion.Cesantia_prop_dias);
            xrCesantiaproptotal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Cesantia_prop_total);

            xrVacacionesdias.Text = string.Format("{0:###,##0.00}", pliquidacion.Vacaciones_dias);
            xrVacacionestotal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Vacaciones_total);

            xrVacacionespropdias.Text = string.Format("{0:###,##0.00}", pliquidacion.Vacaciones_prop_dias);
            xrVacacionesproptotal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Vacaciones_prop_total);

            xrDecimocuartodias.Text = string.Format("{0:###,##0.00}", pliquidacion.Decimo_cuarto_dias);
            xrDecimocuartototal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Decimo_cuarto_total);

            xrDecimotercerodias.Text = string.Format("{0:###,##0.00}", pliquidacion.Decimo_tercero_dias);
            xrDecimotercerototal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Decimo_tercero_total);

            xrTotalAsig.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total_derechos);

            

            #region Ultimos 6 Meses
            //Calculo de los Ultimos 6 Meses
            //Primer Mes
            //xrMes1.Text = pliquidacion.Mes1er;
            //xrSueldoMes1.Text = string.Format("{0:L###,##0.00}", pliquidacion.Sueldo1erMes);
            //xrComisionesMes1.Text = string.Format("{0:L###,##0.00}", pliquidacion.Comisiones1erMes);
            //xrBonoMes1.Text = string.Format("{0:L###,##0.00}", pliquidacion.Bono1erMes);
            //xrIncentivoMes1.Text = string.Format("{0:L###,##0.00}", pliquidacion.Incentivo1erMes);
            //xrHorasEMes1.Text = string.Format("{0:L###,##0.00}", pliquidacion.HorasE1Mes);
            //xrTotal1erMes.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total1erMes);
            

            ////Segundo Mes
            //xrMes2.Text = pliquidacion.Mes2do;
            //xrSueldoMes2.Text = string.Format("{0:L###,##0.00}", pliquidacion.Sueldo2doMes);
            //xrComisionesMes2.Text = string.Format("{0:L###,##0.00}", pliquidacion.Comisiones2doMes);
            //xrBonoMes2.Text = string.Format("{0:L###,##0.00}", pliquidacion.Bono2doMes);
            //xrIncentivoMes2.Text = string.Format("{0:L###,##0.00}", pliquidacion.Incentivo2doMes);
            //xrHorasEMes2.Text = string.Format("{0:L###,##0.00}", pliquidacion.HorasE2doMes);
            //xrTotal2doMes.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total2doMes);

            ////Tercer Mes
            //xrMes3.Text = pliquidacion.Mes3er;
            //xrSueldoMes3.Text = string.Format("{0:L###,##0.00}", pliquidacion.Sueldo3erMes);
            //xrComisionesMes3.Text = string.Format("{0:L###,##0.00}", pliquidacion.Comisiones3erMes);
            //xrBonoMes3.Text = string.Format("{0:L###,##0.00}", pliquidacion.Bono3erMes);
            //xrIncentivoMes3.Text = string.Format("{0:L###,##0.00}", pliquidacion.Incentivo3erMes);
            //xrHorasEMes3.Text = string.Format("{0:L###,##0.00}", pliquidacion.HorasE3erMes);
            //xrTotal3erMes.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total3erMes);

            ////Cuarto Mes
            //xrMes4.Text = pliquidacion.Mes4to;
            //xrSueldoMes4.Text = string.Format("{0:L###,##0.00}", pliquidacion.Sueldo4toMes);
            //xrComisionesMes4.Text = string.Format("{0:L###,##0.00}", pliquidacion.Comisiones4toMes);
            //xrBonoMes4.Text = string.Format("{0:L###,##0.00}", pliquidacion.Bono4toMes);
            //xrIncentivoMes4.Text = string.Format("{0:L###,##0.00}", pliquidacion.Incentivo4toMes);
            //xrHorasEMes4.Text = string.Format("{0:L###,##0.00}", pliquidacion.HorasE4toMes);
            //xrTotal4toMes.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total4toMes);

            ////Quinto Mes
            //xrMes5.Text = pliquidacion.Mes5to;
            //xrSueldoMes5.Text = string.Format("{0:L###,##0.00}", pliquidacion.Sueldo5toMes);
            //xrComisionesMes5.Text = string.Format("{0:L###,##0.00}", pliquidacion.Comisiones5toMes);
            //xrBonoMes5.Text = string.Format("{0:L###,##0.00}", pliquidacion.Bono5toMes);
            //xrIncentivoMes5.Text = string.Format("{0:L###,##0.00}", pliquidacion.Incentivo5toMes);
            //xrHorasEMes5.Text = string.Format("{0:L###,##0.00}", pliquidacion.HorasE5toMes);
            //xrTotal5toMes.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total5toMes);

            ////Sexto Mes
            //xrmes6.Text = pliquidacion.Mes6to;
            //xrSueldoMes6.Text = string.Format("{0:L###,##0.00}", pliquidacion.Sueldo6toMes);
            //xrComisionesMes6.Text = string.Format("{0:L###,##0.00}", pliquidacion.Comisiones6toMes);
            //xrBonoMes6.Text = string.Format("{0:L###,##0.00}", pliquidacion.Bono6toMes);
            //xrIncentivoMes6.Text = string.Format("{0:L###,##0.00}", pliquidacion.Incentivo6toMes);
            //xrHorasEMes6.Text = string.Format("{0:L###,##0.00}", pliquidacion.HorasE6toMes);
            //xrTotal6toMes.Text = string.Format("{0:L###,##0.00}", pliquidacion.Total6toMes);

            ////Total Calculo de 6 Meses
            //xrTotal6MesesNombre.Text = pliquidacion.Total6MesesNombre;
            //xrTotalSueldo.Text = string.Format("{0:L###,##0.00}", pliquidacion.Totalsueldo);
            //xrTotalComisiones.Text = string.Format("{0:L###,##0.00}", pliquidacion.Totalcomisiones);
            //xrTotalBono.Text = string.Format("{0:L###,##0.00}", pliquidacion.Totalbono);
            //xrTotalIncentivo.Text = string.Format("{0:L###,##0.00}", pliquidacion.Totalincentivo);
            //xrTotalHorasE.Text = string.Format("{0:L###,##0.00}", pliquidacion.Totalhorasextra);
            //xrTotalTotal.Text = string.Format("{0:L###,##0.00}", pliquidacion.Totaltotal);

            ////Promedio
            //xrPromedio6Meses.Text = pliquidacion.Promedio6MesesNombre;
            //xrPromedioSueldo.Text = string.Format("{0:L###,##0.00}", pliquidacion.Promediosueldobase);
            //xrPromedioComisiones.Text = string.Format("{0:L###,##0.00}", pliquidacion.Promediocomisiones);
            //xrPromedioBono.Text = string.Format("{0:L###,##0.00}", pliquidacion.Promediobono);
            //xrPromedioIncentivo.Text = string.Format("{0:L###,##0.00}", pliquidacion.Promedioincentivo);
            //xrPromedioHorasE.Text = string.Format("{0:L###,##0.00}",pliquidacion.Promediohorasextra);
            //xrPromedioTotal.Text = string.Format("{0:L###,##0.00}",pliquidacion.Promediototal);

            #endregion

            if (id_liquidacion > 0)
            {
                Liquidacion liqu = new Liquidacion();
                if (liqu.RecuperarHeaderLiquidacion(id_liquidacion))
                {
                    //ENCABEZADO DE LIQUIDACION
                    xrEmpleado.Text = liqu.empleado;
                    xrCodigo.Text = liqu.codigo;
                    xrPuesto.Text = liqu.puesto;
                    xrFechaEgreso.Text = string.Format("{0:MM/dd/yyyy}", liqu.fecha_egreso);
                    xrFechaIng.Text = string.Format("{0:MM/dd/yyyy}", liqu.fecha_ingreso);
                    xrAntiguedad.Text = liqu.antiguedad;
                    xrSalarioBase.Text = string.Format("{0:L###,##0.00}", liqu.salario_base);
                    xrPromedioBase.Text = string.Format("{0:L###,##0.00}", liqu.promedio_base);
                    xrPromedioMensual.Text = string.Format("{0:L###,##0.00}", liqu.salario_pro_mensual);
                    xrPromedioDiarioExtra.Text = string.Format("{0:L###,##0.00}", liqu.promedio_diario_extrpromedio_diario_extr);
                }
            }
            LoadDeduccionesForLiquidacion(id_liquidacion);

            decimal GDeducciones = 0;
            decimal GDerechos = 0;
            xrGranTotalDerecho.Text = xrTotalAsig.Text;
            GDerechos = pliquidacion.Total_derechos;
            
            xrGranTotalDerecho.Text = string.Format("{0:L###,##0.00}", GDerechos);


            foreach (dsRRHH_.deduccionesRow rowd in dsRRHH_1.deducciones)
            {
                GDeducciones += rowd.total;
            }

            xrTotalDeducciones.Text = string.Format("{0:L###,##0.00}", GDeducciones);

            xrGranTotalDeducciones.Text = xrTotalDeducciones.Text;
            //GDeducciones = Convert.ToDecimal(xrGranTotalDeducciones.Text);

            decimal netopagar;
            netopagar = GDerechos - GDeducciones;

            xrNetoAPagar.Text = string.Format("{0:L###,##0.00}", netopagar);

            

        }

        private void ObtenerIDLiquidacion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_RRHH_liquidacion_header_datos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", IdEmpleado);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    id_liquidacion = DR.GetInt32(0);
                }
                DR.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }


        private void LoadDeduccionesForLiquidacion(int pid_liquidacion)
        {
            string query = @"[sp_load_RRHH_deducciones_rpt]";

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_liquidacion", pid_liquidacion);
                dsRRHH_1.deducciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRRHH_1.deducciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        
        }
    }
}
