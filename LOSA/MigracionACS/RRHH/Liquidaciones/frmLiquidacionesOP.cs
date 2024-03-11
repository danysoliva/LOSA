using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Classes;
using DevExpress.XtraReports.UI;
using DevExpress.DashboardCommon;
using LOSA.Clases;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmLiquidacionesOP : DevExpress.XtraEditors.XtraForm
    {
        private int Id_liquidacion_ = 0;
        private int idEmpleado;
        private string _NombreEmpleado;
        private string _CodigoEmpleado;
        private string _Pin;
        public double DiasA_pagar_en_liquidacion;
        public decimal DiasTomados;
        public decimal Porcentaje;
        public decimal DiasVacaciones_A_pagar_en_liquidacion;
        public decimal SueldoBasePromedio;
        public decimal SueldoBasePromedioDiario;
        public decimal SueldoPromedioMensualTotal;
        public decimal SueldoBasePromedioDiarioMasExtraOrdinario;
        public decimal TotalDeducciones;
        public decimal TotalDerechos;
        public int Dias_Trabajados;
        int IdPorcentajeSelected = 0;
        Liquidacion liqui = new Liquidacion();
        /// <summary>
        /// Indica la moneda del Salario. Ejemplo: 1=Lempiras     2=USD
        /// </summary>
        int IdCurrencyActual = 0;
        

        public DateTime FechaInicio;
        public DateTime FechaFin;

        UserLogin UsuarioLogeado;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => _NombreEmpleado; set => _NombreEmpleado = value; }
        public string CodigoEmpleado { get => _CodigoEmpleado; set => _CodigoEmpleado = value; }
        DataOperations dp;

        public int Dia;
        public int Mes;
        public int Anio;

        public enum tipotrans
        {
            insert = 1,
            update = 2
        }
        tipotrans vtipotrans;

        public frmLiquidacionesOP(UserLogin pUserLogin)
        {
            InitializeComponent();
            vtipotrans = tipotrans.insert;
            LoadPorcentajes();
            LoadDeducciones();
            dp = new DataOperations();
            dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
            dtEgreso.EditValue = dp.Now();
            dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);
            UsuarioLogeado = pUserLogin;
            DiasA_pagar_en_liquidacion = 0;
            TotalDerechos = 0;
            TotalDeducciones = 0;
            txtTotal.Text = "0";
        }
        
        public frmLiquidacionesOP(int pid)
        {
            InitializeComponent();
            vtipotrans = tipotrans.update;
            LoadPorcentajes();
            //dp = new DataOperations();
            //dtEgreso.EditValue = dp.Now();
        }

        private void cmdBuscarEmpleado_Click(object sender, EventArgs e)
        {
            //dtEgreso.Text = "";
            tsAplicaCesantia.Toggled -= new EventHandler(tsAplicaPreaviso_Toggled);
            tsAplicaCesantia.IsOn = true;
            tsAplicaCesantia.Toggled += new EventHandler(tsAplicaPreaviso_Toggled);

            tsAplicaPreaviso.Toggled -= new EventHandler(tsAplicaPreaviso_Toggled);
            tsAplicaPreaviso.IsOn = true;
            tsAplicaPreaviso.Toggled += new EventHandler(tsAplicaPreaviso_Toggled);
            cmdBuscarEmpleadoFN();
            CargarLiquidacionHeader(idEmpleado);
            //CalcularEdad();
            CargarDetalleSalarios();
            CalculoDeDerechos();
            if (Id_liquidacion_ == 0)
            {
                LoadDeducciones();
            }
            //LoadDeducciones();
            //CargarLiquidacionHeader(idEmpleado);


            decimal TotalRecalculo = 0;
            foreach (dsRRHH_.derechos_calculo_liqRow rowd in dsRRHH_1.derechos_calculo_liq.Rows)
            {
                if (rowd.id == 9)
                {
                    TotalDerechos = TotalRecalculo;
                    rowd.total = TotalRecalculo;
                }
                else
                {
                    TotalRecalculo += Convert.ToDecimal(rowd.total);
                }
            }
            txtTDerechos.Text = string.Format("{0:###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);
            if(Id_liquidacion_ == 0)
            {
                dtEgreso.EditValue = dp.dNow();
            }


        }

        private void CargarLiquidacionHeader(int pIdEmpleado)
        {

            //foreach (dsRRHH_.liquidacion_vacRow row in dsRRHH_1.liquidacion_vac)
            //{
            //    if (row.id == -2)
            //        DiasTomados = row.dias;6
            //}
            int IdLiqLocal = 0;
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_RRHH_liquidacion_header_datos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", pIdEmpleado);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    IdLiqLocal = DR.GetInt32(0);
                }
                DR.Close();
                conn.Close();

                
                if (IdLiqLocal > 0)
                {
                    Liquidacion Liq1 = new Liquidacion();
                    if (Liq1.RecuperarHeaderLiquidacion(IdLiqLocal))
                    {
                        this.liqui = Liq1;
                        DiasVacaciones_A_pagar_en_liquidacion = Liq1.dias_a_pagar;
                        DiasTomados = Liq1.DiasTomados;
                        tsAplicaCesantia.IsOn = Liq1.aplica_cesantia;
                        Porcentaje = Liq1.Porcentaje;
                        IdPorcentajeSelected = Liq1.id_porcentaje;
                        dtEgreso.EditValue = liqui.fecha_egreso;
                        tsAplicaPreaviso.IsOn = liqui.Aplica_preaviso;
                        Dias_Trabajados = liqui.Dias_trabajados;
                        //Setear porcentaje guardado
                        foreach (dsRRHH_.porcentajes_liquidacionRow rowi in dsRRHH_1.porcentajes_liquidacion)
                        {
                            
                            if (rowi.id == Liq1.id_porcentaje)
                                rowi.seleccionado = true;
                            else
                                rowi.seleccionado = false;

                        }
                        
                        decimal diaspendiente = 0;
                        //Set dias tomados
                        foreach (dsRRHH_.liquidacion_vacRow rowi in dsRRHH_1.liquidacion_vac)
                        {
                            if (rowi.id == -1)
                                diaspendiente = rowi.dias;

                            if (rowi.id == -2)
                                rowi.dias = Liq1.DiasTomados;

                            if (rowi.id == -3)
                                rowi.dias = diaspendiente - Liq1.DiasTomados;

                            
                        }

                        //Recalculamos Cesantia
                        CalculoDeDerechosSoloCesantia();

                        if (Liq1.Porcentaje < 100)
                        {
                            //Aplicar el porcenta de pago
                            foreach (dsRRHH_.derechos_calculo_liqRow rowj in dsRRHH_1.derechos_calculo_liq)
                            {
                                if (rowj.id == 2 || rowj.id == 3)
                                {
                                    rowj.dias = (rowj.dias * Liq1.Porcentaje) / 100;
                                    rowj.total = (rowj.total * Liq1.Porcentaje) / 100;
                                }
                            }
                        }
                        Id_liquidacion_ = IdLiqLocal;

                        CargarDeducciones(IdLiqLocal);

                        TotalDeducciones = 0;

                        foreach (dsRRHH_.deduccionesRow dr in dsRRHH_1.deducciones.Rows)
                        {
                            TotalDeducciones += Convert.ToDecimal(dr.total);
                        }

                        txtTDeducciones.Text = string.Format("{0:###,##0.00}", TotalDeducciones);// Convert.ToString(TotalDeducciones);

                         
                        foreach (dsRRHH_.derechos_calculo_liqRow item in dsRRHH_1.derechos_calculo_liq.Rows)
                        {
                            TotalDerechos += Convert.ToDecimal(item.total);    
                        }
                        txtTDerechos.Text = string.Format("{0:###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);

                        CalcularTotales();
                        CalculoDeTotalResumen();

                        //LGetDeduccionesForId_Liqu();
                    }
                }
                else
                {
                    Id_liquidacion_ = 0;
                }
                
               
                //TotalDeducciones = Convert.ToDecimal(txtTDeducciones.Text);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        

        private void CargarDeducciones(int pid_liquidacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_liquidacion_deducciones";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_liquidacion", pid_liquidacion);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRRHH_1.deducciones.Clear();
                adat.Fill(dsRRHH_1.deducciones);
                conn.Close();

                //TotalDeducciones = Convert.ToDecimal(txtTDeducciones.Text);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDeducciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_load_liquidacion_deducciones";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRRHH_1.deducciones.Clear();
                adat.Fill(dsRRHH_1.deducciones);
                conn.Close();

                //TotalDeducciones = Convert.ToDecimal(txtTDeducciones.Text);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CalculoDeDerechos()
        {
            try
            {
                DateTime FechaInicioCat;// = new DateTime(FechaFin.AddYears(-1).Year, 07, 01);
                DateTime FechaInicioTre = new DateTime(FechaFin.AddYears(-1).Year, 07, 01);
                if (FechaFin.Month >= 7 && FechaFin.Day > 1)
                    FechaInicioCat = new DateTime(FechaFin.Year, 07, 01);//el presente año
                else
                    FechaInicioCat = new DateTime(FechaFin.AddYears(-1).Year, 07, 01);// el año anterior

                if (FechaFin.Month >= 1 && FechaFin.Day > 1)
                    FechaInicioTre = new DateTime(FechaFin.Year, 01, 01);//el presente año


                //TimeSpan Diff_dates = fhasta.Subtract(FechaEgresoTyped);
                //TimeSpan Diff_dates = dtEgreso.DateTime.Subtract(FechaInicioCat);
                //double DiasCat = Diff_dates.TotalDays;
                //decimal dDiasCat = Convert.ToDecimal(DiasCat);
                decimal dDiasCat = Math.Abs((FechaFin.Month - FechaInicioCat.Month) + 12 * (FechaFin.Year - FechaInicioCat.Year));
                //if (FechaFin.Day > 1)//sacamos los dias proporcionales de catorceavo
                //    dDiasCat = (dDiasCat * 30) + (FechaFin.Day -1);
                //else 
                dDiasCat = (dDiasCat * 30) + (FechaFin.Day);

                decimal dDiastre = Math.Abs((FechaFin.Month - FechaInicioTre.Month) + 12 * (FechaFin.Year - FechaInicioTre.Year));
                //if (FechaFin.Day > 1)//sacamos los dias proporcionales de catorceavo
                //    dDiastre = (dDiastre * 30) + (FechaFin.Day - 1);
                //else
                dDiastre = (dDiastre * 30) + (FechaFin.Day);

                //Diff_dates = dtEgreso.DateTime.Subtract(FechaInicioTre);
                //double DiasTre = Diff_dates.TotalDays;
                //decimal dDiastre = Convert.ToDecimal(DiasTre);

                //string query = @"public.ft_get_calculo_derechos_liquidacion";
                string query = @"sp_rrhh_get_calculo_derechos_liquidacion";
                //PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                //PgSqlCommand cmd = new PgSqlCommand(query, conn);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pyear", Anio);
                cmd.Parameters.AddWithValue("@pmes", Mes);
                cmd.Parameters.AddWithValue("@pdia", Dia);
                cmd.Parameters.AddWithValue("@ppprom_diario_extraor", SueldoBasePromedioDiarioMasExtraOrdinario);
                cmd.Parameters.AddWithValue("@pdias_catorceavo", dDiasCat);
                cmd.Parameters.AddWithValue("@pdias_treceavo", dDiastre);
                cmd.Parameters.AddWithValue("@psalario_base_diario",SueldoBasePromedioDiario);
                //PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRRHH_1.derechos_calculo_liq.Clear();
                adat.Fill(dsRRHH_1.derechos_calculo_liq);
                conn.Close();

                foreach (dsRRHH_.derechos_calculo_liqRow item in dsRRHH_1.derechos_calculo_liq.Rows)
                {
                    if (item.id == 4)
                    {
                        item.dias = DiasVacaciones_A_pagar_en_liquidacion;
                        item.total = decimal.Round(DiasVacaciones_A_pagar_en_liquidacion * SueldoBasePromedioDiarioMasExtraOrdinario, 2, MidpointRounding.AwayFromZero);
                    }

                    if (item.id == 8) //Dias Trabajados
                    {
                        item.dias = Dias_Trabajados;
                        item.total = decimal.Round(Dias_Trabajados * SueldoBasePromedioDiario, 2, MidpointRounding.AwayFromZero);
                    }

                }

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void CalculoDeDerechosSoloCesantia()
        {
            try
            {
                DateTime FechaInicioCat;// = new DateTime(FechaFin.AddYears(-1).Year, 07, 01);
                DateTime FechaInicioTre = new DateTime(FechaFin.AddYears(-1).Year, 07, 01);
                if (FechaFin.Month >= 7 && FechaFin.Day > 1)
                    FechaInicioCat = new DateTime(FechaFin.Year, 07, 01);//el presente año
                else
                    FechaInicioCat = new DateTime(FechaFin.AddYears(-1).Year, 07, 01);// el año anterior

                if (FechaFin.Month >= 1 && FechaFin.Day > 1)
                    FechaInicioTre = new DateTime(FechaFin.Year, 01, 01);//el presente año


                //TimeSpan Diff_dates = fhasta.Subtract(FechaEgresoTyped);
                //TimeSpan Diff_dates = dtEgreso.DateTime.Subtract(FechaInicioCat);
                //double DiasCat = Diff_dates.TotalDays;
                //decimal dDiasCat = Convert.ToDecimal(DiasCat);
                decimal dDiasCat = Math.Abs((FechaFin.Month - FechaInicioCat.Month) + 12 * (FechaFin.Year - FechaInicioCat.Year));
                //if (FechaFin.Day > 1)//sacamos los dias proporcionales de catorceavo
                //    dDiasCat = (dDiasCat * 30) + (FechaFin.Day -1);
                //else 
                dDiasCat = (dDiasCat * 30) + (FechaFin.Day);

                decimal dDiastre = Math.Abs((FechaFin.Month - FechaInicioTre.Month) + 12 * (FechaFin.Year - FechaInicioTre.Year));
                //if (FechaFin.Day > 1)//sacamos los dias proporcionales de catorceavo
                //    dDiastre = (dDiastre * 30) + (FechaFin.Day - 1);
                //else
                dDiastre = (dDiastre * 30) + (FechaFin.Day);

                //Diff_dates = dtEgreso.DateTime.Subtract(FechaInicioTre);
                //double DiasTre = Diff_dates.TotalDays;
                //decimal dDiastre = Convert.ToDecimal(DiasTre);

                //string query = @"public.ft_get_calculo_derechos_liquidacion";
                string query = @"sp_rrhh_get_calculo_derechos_liquidacion";
                //PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                //PgSqlCommand cmd = new PgSqlCommand(query, conn);
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pyear", Anio);
                cmd.Parameters.AddWithValue("@pmes", Mes);
                cmd.Parameters.AddWithValue("@pdia", Dia);
                cmd.Parameters.AddWithValue("@ppprom_diario_extraor", SueldoBasePromedioDiarioMasExtraOrdinario);
                cmd.Parameters.AddWithValue("@pdias_catorceavo", dDiasCat);
                cmd.Parameters.AddWithValue("@pdias_treceavo", dDiastre);
                cmd.Parameters.AddWithValue("@psalario_base_diario", SueldoBasePromedioDiario);
                //PgSqlDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr = cmd.ExecuteReader();
                decimal CesantiaDiasTMP = 0;
                decimal CesantiaDiasProTMP = 0;
                decimal CesantiaTMP = 0;
                decimal CesantiaProTMP = 0;
                decimal PreAvisoDias = 0;
                decimal PreAvisoTotal = 0;
                while (dr.Read())
                {
                    if (dr.GetInt32(0) == 2)//Cesantia
                    {
                        CesantiaDiasTMP = dr.GetDecimal(2);
                        CesantiaTMP = dr.GetDecimal(3);
                    }
                    if (dr.GetInt32(0) == 3)//Cesantia Proporcional
                    {
                        CesantiaDiasProTMP = dr.GetDecimal(2);
                        CesantiaProTMP = dr.GetDecimal(3);
                    }
                    if (dr.GetInt32(0) == 1)//Pre aviso
                    {
                        PreAvisoDias = dr.GetDecimal(2);
                        PreAvisoTotal = dr.GetDecimal(3);
                    }

                    
                }

                foreach(dsRRHH_.derechos_calculo_liqRow row in dsRRHH_1.derechos_calculo_liq)
                {
                    if (tsAplicaCesantia.IsOn)
                    {
                        if (row.id == 2)//Cesantia
                        {
                            row.dias = CesantiaDiasTMP;
                            row.total = CesantiaTMP;
                        }
                        if (row.id == 3)//Cesantia Proporcional
                        {
                            row.dias = CesantiaDiasProTMP;
                            row.total = CesantiaProTMP;
                        }
                    }
                    if (tsAplicaPreaviso.IsOn)
                    {
                        if (row.id == 1)//Pre aviso
                        {
                            row.dias = PreAvisoDias;
                            row.total = PreAvisoTotal;
                        }
                    }
                    
                    if (row.id == 8) //Dias Trabajados
                    {
                        row.dias = Dias_Trabajados;
                        row.total =decimal.Round(Dias_Trabajados * SueldoBasePromedioDiario, 2, MidpointRounding.AwayFromZero);
                        
                    }
                }

                
                
                
               
                CalcularTotales();
                dr.Close();
                //PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                //dsRRHH_1.derechos_calculo_liq.Clear();
                //adat.Fill(dsRRHH_1.derechos_calculo_liq);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void LoadPorcentajes()
        {
            string query = @"sp_load_RRHH_porcentaje_liq";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adar = new SqlDataAdapter(cmd);
                dsRRHH_1.porcentajes_liquidacion.Clear();
                adar.Fill(dsRRHH_1.porcentajes_liquidacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void CargarDetalleSalarios()
        {
            DateTime fdesde = dtIngreso.DateTime;
            
            DateTime fhasta = dtEgreso.DateTime;//dp.Now();

            if (dtEgreso.DateTime.Year < 2000)
                return;

            DateTime FechaEgresoTyped = dtEgreso.DateTime;

            //Fecha FIN
            if (fhasta.Day < 15)//Significa que haremos calculo con meses enteros.
            {
                int mes = fhasta.Month;
                int año = fhasta.Year;
                //Obtener el primer dia del mes, sabiendo el mes y el año, es muy fácil:
                DateTime primerDia = new DateTime(año, mes, 1);
                //Para obtener el último día del mes, puedes recurrir al truco de sumar 1 mes y restar 1 día:
                DateTime ultimoDia = primerDia.AddDays(-1);
                fhasta = ultimoDia;
            }
            else
            {
                //Se hara el calculo con quincenas partidas.
                int mes = fhasta.Month;
                int año = fhasta.Year;
                //Obtener el primer dia del mes, sabiendo el mes y el año, es muy fácil:
                DateTime primerDia = new DateTime(año, mes, 15);
                //Para obtener el último día del mes, puedes recurrir al truco de sumar 1 mes y restar 1 día:
                //DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);
                fhasta = primerDia;
            }

            //Calculamos los dias que se pagaran dentro de la liquidacion
            TimeSpan Diff_dates = fhasta.Subtract(FechaEgresoTyped);
            DiasA_pagar_en_liquidacion = Diff_dates.TotalDays;

            //Fecha Inicio
            if (fhasta.Day > 15)//Significa que haremos calculo con meses enteros.
            {
                int mes = fhasta.Month;
                int año = fhasta.Year;
                //Obtener el primer dia del mes, sabiendo el mes y el año, es muy fácil:
                DateTime primerDia = new DateTime(año, mes, 1);
                //Para obtener el último día del mes pasado, puedes recurrir al truco de restar 1 día:
                //DateTime ultimoDia = primerDia.AddDays(-1);
                //ultimoDia = primerDia.AddMonths(-6);//Nos vamos 6 meses atras.
                fdesde = primerDia.AddMonths(-5);
            }
            else
            {
                //Se hara el calculo con quincenas partidas.
                int mes = fhasta.Month;
                int año = fhasta.Year;
                //Obtener el primer dia del mes, sabiendo el mes y el año, es muy fácil:
                DateTime primerDia = new DateTime(año, mes, 15);
                //Para obtener el último día del mes, puedes recurrir al truco de sumar 1 mes y restar 1 día:
                DateTime ultimoDia = primerDia.AddMonths(-6);//Nos vamos 6 meses atras.
                fdesde = ultimoDia;
            }

            FechaInicio = dtIngreso.DateTime;
            FechaFin = dtEgreso.DateTime;
            //DateTime FechaCalculo;
            //FechaCalculo = fhasta;

            //FechaCalculo = DateTime.Now.AddMonths(-6);

            //Try catch de llenar tabla de promedio de salarios

            if (idEmpleado > 0)
            {

                try
                {
                    string query = @"sp_get_salarios_promedios_liquidacion";
                    PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                    conn.Open();
                    PgSqlCommand cmd = new PgSqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("pid_empleado", PgSqlType.Int).Value = idEmpleado;
                    cmd.Parameters.Add("fdesde", PgSqlType.Date).Value = fdesde;
                    cmd.Parameters.Add("fhasta", PgSqlType.Date).Value = fhasta;
                    PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                    dsRRHH_1.LiquiUltimosMeses.Clear();
                    adat.Fill(dsRRHH_1.LiquiUltimosMeses);
                    conn.Close();

                    //decimal Total6Meses = 0;

                    //dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
                    //dtEgreso.EditValue = fhasta;
                    //dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);
                    //dtIngreso.EditValue = fdesde;


                    foreach (dsRRHH_.LiquiUltimosMesesRow row in dsRRHH_1.LiquiUltimosMeses.Rows)
                    {
                        //Total6Meses += dp.ValidateNumberDecimal(row.total);
                        if (row.mes == -2)
                        {
                            SueldoBasePromedio = (row.total * 14) / 12;
                            SueldoPromedioMensualTotal = row.total;
                            SueldoBasePromedioDiario = row.sueldo_recibido / 30;
                            SueldoBasePromedioDiarioMasExtraOrdinario = SueldoBasePromedio / 30;

                            txtSalarioBaseDiario.EditValue = SueldoBasePromedioDiario;
                            txtSalarioPromedioMensual.EditValue = SueldoBasePromedio;
                            txtPromedioDiarioOrdinario.EditValue = SueldoBasePromedioDiarioMasExtraOrdinario;
                        }
                    }



                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void cmdBuscarEmpleadoFN()
        {
            try
            {
                DataOperations dp = new DataOperations();
                PgSqlConnection con = new PgSqlConnection(dp.ConnectionStringODOO5);
                con.Open();

                frmEmpleadosListaLiquidacion frm = new frmEmpleadosListaLiquidacion(con);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    IdEmpleado = frm.IdEmpleado;
                    txtNombre.Text = NombreEmpleado = frm.NombreEmpleado;
                    txtCodigo.Text = CodigoEmpleado = frm.CodigoEmpleado;
                    Empleado emp1 = new Empleado();
                    if (emp1.RecuperarDatosForLiquidacion(IdEmpleado))
                    {
                        int idContract = emp1._idcontrato;
                        txtPuesto.Text = emp1._puesto;
                        dtIngreso.EditValue = emp1._FechaInicio;
                        if (emp1._FechaFin < dp.Now())
                        {
                            dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
                            dtEgreso.EditValue = emp1._FechaFin;
                            dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);

                        }
                        else
                        {
                            dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
                            dtEgreso.EditValue = dp.Now();
                            dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);
                            
                        }

                        txtSalarioMensual.EditValue = emp1._Salario;
                        txtAntiguedad.Text = emp1._antiguedad;
                        txtSalarioBaseDiario.EditValue = emp1._salarioBaseDiario;
                        txtSalarioPromedioMensual.EditValue = emp1._salarioBaseMensual;
                        txtPromedioDiarioOrdinario.EditValue = emp1._SalarioDiarioOrdinario;
                        IdCurrencyActual = emp1.IdCurrency;

                        if (string.IsNullOrEmpty(dtEgreso.Text))
                        {
                            dp = new DataOperations();
                            dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
                            dtEgreso.EditValue = dp.Now();
                            dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);
                        }
                        else
                        {
                            if (dtEgreso.DateTime.Year < 2000)
                            {
                                dp = new DataOperations();
                                dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
                                dtEgreso.EditValue = dp.Now();
                                dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);
                            }
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdBuscarLiquidaciones_Click(object sender, EventArgs e)
        {
        }

        private void cmdBuscarLiquidacioness_Click(object sender, EventArgs e)
        {
            frmLiquidaciones frm = new frmLiquidaciones();
            frm.Show();
        }

        private void dtEgreso_EditValueChanged(object sender, EventArgs e)
        {
            CalcularEdad();
            CargarDetalleSalarios();
            CalculoDeDerechos();
        }

        private void CalcularEdad()
        {

            if (dtIngreso.DateTime == null)
                return;

            if (dtIngreso.DateTime.Year < 2000)
                return;

            try
            {
                string query = @"public.ft_get_calculo_segmentado_edad_fechas";
                PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                conn.Open();
                PgSqlCommand cmd = new PgSqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("pid_empleado", PgSqlType.Int).Value = idEmpleado;
                cmd.Parameters.Add("pdesde", PgSqlType.Date).Value = dtIngreso.DateTime;
                cmd.Parameters.Add("phasta", PgSqlType.Date).Value = dtEgreso.DateTime;
                PgSqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Anio = dr.GetInt32(0);
                    Mes = dr.GetInt32(1);
                    Dia = dr.GetInt32(2);
                    txtAntiguedad.Text = dr.GetString(3);
                    GetVacacionesCantidadDias(Anio);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void GetVacacionesCantidadDias(int anio)
        {
            try
            {
                string query = @"public.ft_get_vacaciones_liquidacion";
                PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
                conn.Open();
                PgSqlCommand cmd = new PgSqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("pid_empleado", PgSqlType.Int).Value = idEmpleado;
                cmd.Parameters.Add("pyears", PgSqlType.Int).Value = anio;
                //cmd.Parameters.Add("phasta", PgSqlType.Date).Value = dtEgreso.DateTime;
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                dsRRHH_1.liquidacion_vac.Clear();
                adat.Fill(dsRRHH_1.liquidacion_vac);

                //string descripcion;

                foreach (dsRRHH_.liquidacion_vacRow item in dsRRHH_1.liquidacion_vac.Rows)
                {
                    if (item.id == 0)
                    {
                        //descripcion = item.descripcion;

                        //string query2 = @"Utf8ToUcs";
                        //SqlConnection con = new SqlConnection(dp.ConnectionStringACS);
                        //con.Open();
                        //SqlCommand cmd2 = new SqlCommand(query2, con);
                        //cmd2.CommandType = CommandType.StoredProcedure;
                        //cmd2.Parameters.AddWithValue("@src", descripcion);
                        //string descripcioncorregido = Convert.ToString(cmd2.ExecuteScalar());

                        //item.descripcion = descripcioncorregido;

                        //Parcho..
                        string str = item.descripcion;

                        str = str.Replace("AÃ±o", "Año");
                        item.descripcion = str;
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView4_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            if (liqui != null)
            {
                if (liqui.id_liquidacion <= 0)
                {
                    CajaDialogo.Error("Es necesario guardar los datos antes de Imprimir!!");
                    cmdGuardar.Focus();
                    return;
                }
            }
            else
            {

                CajaDialogo.Error("Es necesario guardar los datos antes de Imprimir!!");
                cmdGuardar.Focus();
                return;
            }

            if (IdEmpleado == 0)
            {
                CajaDialogo.Error("No esta cargado ningun empleado");
                return;
            }
            if (txtNombre.Text == "")
            {
                CajaDialogo.Error("Seleccione un colaborador!");
                cmdBuscarEmpleado.Focus();
                return;
            }

            if (IdPorcentajeSelected <= 0)
            {
                CajaDialogo.Error("Debe especificar el porcentaje de Cesantia a Pagar!");
                return;
            }

            foreach (dsRRHH_.liquidacion_vacRow row1 in dsRRHH_1.liquidacion_vac)
            {
                if (row1.id == -3)
                {
                    if (row1.dias < 0)
                    {
                        CajaDialogo.Error("El calculo de vacaciones no puede ser menor que 0!");
                        return;
                    }
                }
            }
            GuardarLiquidacion();

            //GuardarLiquidacion();
            //DialogResult r = CajaDialogo.Pregunta("Al imprimir, se guardaran los cambios realizados!");
            //if (r != DialogResult.Yes)
            //    //return;

            foreach (dsRRHH_.derechos_calculo_liqRow row in dsRRHH_1.derechos_calculo_liq)
            {
                switch (row.id)
                {
                    case 1: //preaviso
                        liqui.Preaviso = row.dias;
                        liqui.Preaviso_total = row.total;
                        break;

                    case 2://cesantia
                        liqui.Cesantia_dias = row.dias;
                        liqui.Cesantia_total = row.total;
                        break;

                    case 3://cesantia proporcional
                        liqui.Cesantia_prop_dias = row.dias;
                        liqui.Cesantia_prop_total = row.total;
                        break;

                    case 4://vacaciones
                        liqui.Vacaciones_dias = row.dias;
                        liqui.Vacaciones_total = row.total;
                        break;

                    case 5://vacaciones proporcionales
                        liqui.Vacaciones_prop_dias = row.dias;
                        liqui.Vacaciones_prop_total = row.total;
                        break;

                    case 6: //decimo cuarto
                        liqui.Decimo_cuarto_dias = row.dias;
                        liqui.Decimo_cuarto_total = row.total;
                        break;

                    case 7://decimo tercero
                        liqui.Decimo_tercero_dias = row.dias;
                        liqui.Decimo_tercero_total = row.total;
                        break;

                    case 8://Dias Trabajados

                        break;

                    case 9://total asignacion
                        liqui.Total_derechos = row.total;
                        break;

                    default:
                        break;
                }
            }

            //foreach (dsRRHH_.LiquiUltimosMesesRow row2 in dsRRHH_1.LiquiUltimosMeses)
            //{
            //    //Asignaremos el valor de la tabla Calculo de los ultimos 6 meses de salario, a la clase liquidacion!
            //    switch (row2.mes)
            //    {
            //        case 1: //1er Mes
            //            liqui.Mes1er = row2.mes_name;
            //            liqui.Sueldo1erMes = row2.sueldo_recibido;
            //            liqui.Comisiones1erMes = row2.comisiones;
            //            liqui.Bono1erMes = row2.bono;
            //            liqui.Incentivo1erMes = row2.incentivo;
            //            liqui.HorasE1Mes = row2.horas_extra;
            //            liqui.Total1erMes = row2.total;
            //            break;

            //        case 2: //2do Mes
            //            liqui.Mes2do = row2.mes_name;
            //            liqui.Sueldo2doMes = row2.sueldo_recibido;
            //            liqui.Comisiones2doMes = row2.comisiones;
            //            liqui.Bono2doMes = row2.bono;
            //            liqui.Incentivo2doMes= row2.incentivo;
            //            liqui.HorasE2doMes = row2.horas_extra;
            //            liqui.Total2doMes = row2.total;
            //            break;

            //        case 3: //3er Mes

            //            liqui.Mes3er = row2.mes_name;
            //            liqui.Sueldo3erMes = row2.sueldo_recibido;
            //            liqui.Comisiones3erMes = row2.comisiones;
            //            liqui.Bono3erMes = row2.bono;
            //            liqui.Incentivo3erMes = row2.incentivo;
            //            liqui.HorasE3erMes = row2.horas_extra;
            //            liqui.Total3erMes = row2.total;
            //            break;

            //        case 4: //4to Mes
            //            liqui.Mes4to = row2.mes_name;
            //            liqui.Sueldo4toMes = row2.sueldo_recibido;
            //            liqui.Comisiones4toMes= row2.comisiones;
            //            liqui.Bono4toMes = row2.bono;
            //            liqui.Incentivo4toMes = row2.incentivo;
            //            liqui.HorasE4toMes= row2.horas_extra;
            //            liqui.Total4toMes = row2.total;
            //            break;

            //        case 5: //5to Mes
            //            liqui.Mes5to = row2.mes_name;
            //            liqui.Sueldo5toMes = row2.sueldo_recibido;
            //            liqui.Comisiones5toMes = row2.comisiones;
            //            liqui.Bono5toMes = row2.bono;
            //            liqui.Incentivo5toMes= row2.incentivo;
            //            liqui.HorasE5toMes= row2.horas_extra;
            //            liqui.Total5toMes = row2.total;
            //            break;

            //        case 6: //6to Mes
            //            liqui.Mes6to = row2.mes_name;
            //            liqui.Sueldo6toMes = row2.sueldo_recibido;
            //            liqui.Comisiones6toMes= row2.comisiones;
            //            liqui.Bono6toMes = row2.bono;
            //            liqui.Incentivo6toMes = row2.incentivo;
            //            liqui.HorasE6toMes = row2.horas_extra;
            //            liqui.Total6toMes = row2.total;
            //            break;

            //        case -1: //Total
            //            liqui.Total6MesesNombre = row2.mes_name;
            //            liqui.Totalsueldo = row2.sueldo_recibido;
            //            liqui.Totalcomisiones = row2.comisiones;
            //            liqui.Totalbono = row2.bono;
            //            liqui.Totalincentivo = row2.incentivo;
            //            liqui.Totalhorasextra = row2.horas_extra;
            //            liqui.Totaltotal = row2.total;
            //            break;

            //        case -2: //Promedio
            //            liqui.Promedio6MesesNombre = row2.mes_name;
            //            liqui.Promediosueldobase = row2.sueldo_recibido;
            //            liqui.Promediocomisiones = row2.comisiones;
            //            liqui.Promediobono = row2.bono;
            //            liqui.Promedioincentivo = row2.incentivo;
            //            liqui.Promediohorasextra = row2.horas_extra;
            //            liqui.Promediototal = row2.total;

            //            break;
            //        default:
            //            break;
            //    }

            //}



            try
            {
                //rptLiquidacion report = new rptLiquidacion(IdEmpleado, dsRRHH_1.derechos_calculo_liq, dsRRHH_1.deducciones );
                //using (ReportPrintTool printTool = new ReportPrintTool(report))
                //{
                //    printTool.ShowPreviewDialog();
                //}

                rptLiquidacion report = new rptLiquidacion(IdEmpleado, liqui, Anio) { DataSource = dsRRHH_1, DataMember = "deducciones", ShowPrintMarginsWarning = false };
                report.CreateDocument();
                for (int i = 0; i < 1; i++)
                {
                    subrReportUltimosMesesxVaca report2 = new subrReportUltimosMesesxVaca(IdEmpleado, Anio, DiasTomados)
                    { DataSource = dsRRHH_1, DataMember = "LiquiUltimosMeses", ShowPrintMarginsWarning = false };
                    
                    report2.CreateDocument();
                    report.Pages.AddRange(report2.Pages);

                }
                report.PrintingSystem.ContinuousPageNumbering = true;
                new ReportPrintTool(report).ShowPreview();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView3_ShowingEditor(object sender, CancelEventArgs e)
        {
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsRRHH_.liquidacion_vacRow)gridView.GetFocusedDataRow();
            if (row.id != -2)
            {
                e.Cancel = true;
            }
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsRRHH_.liquidacion_vacRow)gridView.GetFocusedDataRow();

            if (row.id == -2)
            {
                var gridView2 = (GridView)gridControl3.FocusedView;
                var row2 = (dsRRHH_.liquidacion_vacRow)gridView2.GetDataRow(e.RowHandle - 1);

                var gridView3 = (GridView)gridControl3.FocusedView;
                var row3 = (dsRRHH_.liquidacion_vacRow)gridView3.GetDataRow(e.RowHandle + 1);

                row3.dias = row2.dias - dp.ValidateNumberInt32(e.Value);
                DiasTomados = dp.ValidateNumberInt32(e.Value);
                DiasVacaciones_A_pagar_en_liquidacion = row2.dias - DiasTomados;// dp.ValidateNumberInt32(e.Value);

                //decimal acumulado = 0;
                //foreach (dsRRHH_.derechos_calculo_liqRow rowd in dsRRHH_1.derechos_calculo_liq.Rows)
                //{
                //    if (rowd.id == 4)
                //    {
                //        rowd.dias = DiasVacaciones_A_pagar_en_liquidacion;
                //        rowd.total = decimal.Round(DiasVacaciones_A_pagar_en_liquidacion * SueldoBasePromedioDiarioMasExtraOrdinario, 2, MidpointRounding.AwayFromZero);
                //    }
                //    if (rowd.id < 8)
                //        acumulado += rowd.total;
                //    if (rowd.id == 8)
                //        rowd.total = acumulado;
                //        TotalDerechos = rowd.total;
                //}
                CalcularTotales();

                txtTDerechos.Text = string.Format("{0:#,###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);
                //txtDiasPago.Text = Convert.ToString(DiasVacaciones_A_pagar_en_liquidacion);
            }
            CalculoDeTotalResumen();
        }


        private void frmLiquidacionesOP_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRRHH_.derechos_calculo_liqRow)gridView.GetFocusedDataRow();
            e.Cancel = true;
            //if (row.id != 4)//Si es vacaciioens
            //{
            //    e.Cancel = true;
            //}
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //var gridView = (GridView)gridDeducciones.FocusedView;
            //var row1 = (dsRRHH_.derechos_calculo_liqRow)gridView.GetFocusedDataRow();

          


        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridDeducciones.FocusedView;
            var row = (dsRRHH_.deduccionesRow)gridView.GetFocusedDataRow();

            TotalDeducciones = 0;

            foreach (dsRRHH_.deduccionesRow dr in dsRRHH_1.deducciones.Rows)
            {
                TotalDeducciones += Convert.ToDecimal(dr.total);
            }

            txtTDeducciones.Text = string.Format("{0:#,###,##0.00}", TotalDeducciones);// Convert.ToString(TotalDeducciones);

            CalculoDeTotalResumen();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmConfDeducciones frm = new frmConfDeducciones(Id_liquidacion_);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Id_liquidacion_ == 0)
                {
                    LoadDeducciones();
                }
                else
                {
                    CargarDeducciones(Id_liquidacion_);
                }
                
                
            }
        }

        private void GuardarLiquidacion()
        {

            bool TransaccionExitosa = false;

            DataOperations dp = new DataOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringCostos))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    //Guardemos el Encabezado
                    command.CommandText = "sp_insert_RRHH_liquidacion_h";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id_empleado", IdEmpleado);
                    command.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    command.Parameters.AddWithValue("@puesto", txtPuesto.Text);
                    command.Parameters.AddWithValue("@fecha_ingreso", dtIngreso.DateTime);
                    command.Parameters.AddWithValue("@fecha_egreso", dtEgreso.DateTime);
                    command.Parameters.AddWithValue("@antiguedad", txtAntiguedad.Text);
                    command.Parameters.AddWithValue("@salario_base", Convert.ToDecimal(txtSalarioMensual.Text));
                    command.Parameters.AddWithValue("@promedio_base", Convert.ToDecimal(txtSalarioBaseDiario.Text));
                    command.Parameters.AddWithValue("@salario_pro_mensual", Convert.ToDecimal(txtSalarioPromedioMensual.Text));
                    command.Parameters.AddWithValue("@promedio_diario_extrpromedio_diario_extr", Convert.ToDecimal(txtPromedioDiarioOrdinario.Text));
                    command.Parameters.AddWithValue("@id_user_creador", UsuarioLogeado.UserId);
                    command.Parameters.AddWithValue("@dias_a_pagar", DiasVacaciones_A_pagar_en_liquidacion);
                    command.Parameters.AddWithValue("@bit_aplica_cesantia", tsAplicaCesantia.IsOn);
                    command.Parameters.AddWithValue("@dias_tomados", DiasTomados);
                    command.Parameters.AddWithValue("@id_porcentaje", IdPorcentajeSelected);
                    command.Parameters.AddWithValue("@bit_aplica_preaviso", tsAplicaPreaviso.IsOn);
                    command.Parameters.AddWithValue("@Dias_Trabajados", Dias_Trabajados);

                    SqlDataReader dr1 = command.ExecuteReader();
                    int Id_Liquidacion = 0;
                    if (dr1.Read())
                    {
                        Id_Liquidacion = dr1.GetInt32(0);
                    }
                    dr1.Close();
                    Id_liquidacion_ = Id_Liquidacion;

                    if (Id_Liquidacion > 0)
                    {
                        foreach (dsRRHH_.deduccionesRow row2 in dsRRHH_1.deducciones.Rows)
                        {
                            int id_ = dp.ValidateNumberInt32(row2.id);
                            command.CommandText = "sp_insert_RRHH_liquidacion_d_deducciones";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_atributo", row2.id_atributo);
                            command.Parameters.AddWithValue("@id_liquidacion", Id_Liquidacion);
                            command.Parameters.AddWithValue("@total", row2.total);
                            command.Parameters.AddWithValue("@comentario", row2.comentario);
                            command.Parameters.AddWithValue("@id", id_);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    TransaccionExitosa = true;
                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error(ex2.Message);
                    }
                }
            }
            if (TransaccionExitosa)
            {
                CajaDialogo.Information("Guardado con exito!");
                //LimpiarControles();
                //CargarLiquidacionHeader(idEmpleado);
                
                CargarDeducciones(Id_liquidacion_);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            

            if (txtNombre.Text == "")
            {
                CajaDialogo.Error("Seleccione un colaborador!");
                cmdBuscarEmpleado.Focus();
                return;
            } 


            if (IdPorcentajeSelected <= 0)
            {
                CajaDialogo.Error("Debe especificar el porcentaje de Cesantia a Pagar!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar esta liquidacion?");
            if (r != DialogResult.Yes)
                return;

           

            //Validaciones
            foreach (dsRRHH_.liquidacion_vacRow row1 in dsRRHH_1.liquidacion_vac)
            {
                if (row1.id == -3)
                {
                    if (row1.dias < 0)
                    {
                        CajaDialogo.Error("El calculo de vacaciones no puede ser menor que 0!");
                        return;
                    }
                }
            }
            GuardarLiquidacion();
            //if (dtIngreso > dtEgreso)
            //{
            //    CajaDialogo.Error("La Fecha de Egreso, no debe ser menor la Fecha de Ingreso!");
            //    return;
            //}

        }

   

        private void LimpiarControles()
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            dtIngreso.Text = "";
            dtEgreso.EditValueChanged -= new EventHandler(dtEgreso_EditValueChanged);
            dtEgreso.EditValue = dp.Now();
            dtEgreso.EditValueChanged += new EventHandler(dtEgreso_EditValueChanged);
            txtSalarioBaseDiario.Text = "";
            txtSalarioMensual.Text = "";
            txtSalarioPromedioMensual.Text = "";
            txtPromedioDiarioOrdinario.Text = "";
            txtPuesto.Text = "";
            txtAntiguedad.Text = "";
            dsRRHH_1.derechos_calculo_liq.Clear();
            dsRRHH_1.LiquiUltimosMeses.Clear();
            dsRRHH_1.liquidacion_vac.Clear();
            dsRRHH_1.deducciones.Clear();
            txtTDerechos.Text = "0";
            txtTDeducciones.Text = "0";
            txtTotal.Text = "0";
        }

        public void CalculoDeTotalResumen()
        {            
            decimal TotalGeneral;
            TotalGeneral = TotalDerechos - TotalDeducciones;
            txtTotal.Text = string.Format("{0:#,###,##0.00}", TotalGeneral);// Convert.ToString(TotalGeneral);
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridDeducciones.FocusedView;
            var row1 = (dsRRHH_.derechos_calculo_liqRow)gridView.GetFocusedDataRow();

            decimal totaltemp = 0;
            foreach (dsRRHH_.derechos_calculo_liqRow row in dsRRHH_1.derechos_calculo_liq.Rows)
            {
                totaltemp += row.total;
            }

        }

        private void btnSettingsPorcentaje_Click(object sender, EventArgs e)
        {
            frmConfPorcentajeLiqui frm = new frmConfPorcentajeLiqui();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPorcentajes();
            }
        }

        private void tsAplicaPreaviso_Toggled(object sender, EventArgs e)
        {            

        
        }

        private void CalcularTotales()
        {
            decimal acumulado = 0;
            foreach (dsRRHH_.derechos_calculo_liqRow rowd in dsRRHH_1.derechos_calculo_liq.Rows)
            {
                if (rowd.id == 4)
                {
                    rowd.dias = DiasVacaciones_A_pagar_en_liquidacion;
                    rowd.total = decimal.Round(DiasVacaciones_A_pagar_en_liquidacion * SueldoBasePromedioDiarioMasExtraOrdinario, 2, MidpointRounding.AwayFromZero);
                }
                if (rowd.id < 9)
                    acumulado += rowd.total;
                if (rowd.id == 9)
                    rowd.total = acumulado;
                TotalDerechos = rowd.total;
                txtTDerechos.Text = string.Format("{0:#,###,##0.00}", TotalDerechos);
            }
        }

        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          

        }

        private void gridView5_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            var gridView = (GridView)gridPorcentaje.FocusedView;
            var row = (dsRRHH_.porcentajes_liquidacionRow)gridView.GetDataRow(e.RowHandle);
            IdPorcentajeSelected = row.id;
            decimal porcentajeAplica = row.porcentaje;

            //Des-seleccionar totas las otras filas
            foreach (dsRRHH_.porcentajes_liquidacionRow rowi in dsRRHH_1.porcentajes_liquidacion)
            {
                if (rowi.id != row.id)
                {
                    rowi.seleccionado = false;
                }
            }

            CalculoDeDerechosSoloCesantia();
            if (porcentajeAplica < 100)
            {
                //Aplicar el porcenta de pago
                foreach (dsRRHH_.derechos_calculo_liqRow rowj in dsRRHH_1.derechos_calculo_liq)
                {
                    if (rowj.id == 2 || rowj.id == 3)
                    {
                        rowj.dias = (rowj.dias * porcentajeAplica) / 100;
                        rowj.total = (rowj.total * porcentajeAplica) / 100;
                    }
                }
            }
            CalcularTotales();

            txtTDerechos.Text = string.Format("{0:#,###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);
            CalculoDeTotalResumen();
        }

        private void tsAplicaPreaviso_Toggled_1(object sender, EventArgs e)
        {
            foreach (dsRRHH_.derechos_calculo_liqRow row in dsRRHH_1.derechos_calculo_liq)
            {
                if (row.id == 1)
                {
                    if (tsAplicaPreaviso.IsOn)
                    {
                        CalculoDeDerechosSoloCesantia();//Pendiente
                    }
                    else
                    {
                        row.dias = 0;
                        row.total = 0;
                    }
                }
                else
                    break;
                CalcularTotales();
                txtTDerechos.Text = string.Format("{0:###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);
                CalculoDeTotalResumen();
            }
        }

        private void tsAplicaCesantia_Toggled(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridPorcentaje.FocusedView;
            //var row = (dsRRHH_.porcentajes_liquidacionRow)gridView.GetDataRow(e.RowHandle);
            //IdPorcentajeSelected = row.id;

            foreach (dsRRHH_.derechos_calculo_liqRow rowi in dsRRHH_1.derechos_calculo_liq)
            {
                if (rowi.id == 3 || rowi.id == 2)
                {
                    if (tsAplicaCesantia.IsOn)
                    {

                        CalculoDeDerechosSoloCesantia();
                    }
                    else
                    {
                        rowi.dias = 0;
                        rowi.total = 0;
                    }
                }
            }

            CalcularTotales();
            txtTDerechos.Text = string.Format("{0:###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);
            CalculoDeTotalResumen();


        }

        private void gridView3_ShowingEditor_1(object sender, CancelEventArgs e)
        {
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsRRHH_.liquidacion_vacRow)gridView.GetFocusedDataRow();
            if (row.id != -2)
            {
                e.Cancel = true;
            }

        }

        private void gridView3_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gridView3_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl3.FocusedView;
            var row = (dsRRHH_.liquidacion_vacRow)gridView.GetFocusedDataRow();

            if (row.id == -2)
            {
                var gridView2 = (GridView)gridControl3.FocusedView;
                var row2 = (dsRRHH_.liquidacion_vacRow)gridView2.GetDataRow(e.RowHandle - 1);

                var gridView3 = (GridView)gridControl3.FocusedView;
                var row3 = (dsRRHH_.liquidacion_vacRow)gridView3.GetDataRow(e.RowHandle + 1);

                row3.dias = row2.dias - dp.ValidateNumberInt32(e.Value);
                DiasTomados = dp.ValidateNumberInt32(e.Value);
                DiasVacaciones_A_pagar_en_liquidacion = row2.dias - DiasTomados;// dp.ValidateNumberInt32(e.Value);

                //decimal acumulado = 0;
                //foreach (dsRRHH_.derechos_calculo_liqRow rowd in dsRRHH_1.derechos_calculo_liq.Rows)
                //{
                //    if (rowd.id == 4)
                //    {
                //        rowd.dias = DiasVacaciones_A_pagar_en_liquidacion;
                //        rowd.total = decimal.Round(DiasVacaciones_A_pagar_en_liquidacion * SueldoBasePromedioDiarioMasExtraOrdinario, 2, MidpointRounding.AwayFromZero);
                //    }
                //    if (rowd.id < 8)
                //        acumulado += rowd.total;
                //    if (rowd.id == 8)
                //        rowd.total = acumulado;
                //        TotalDerechos = rowd.total;
                //}
                CalcularTotales();

                txtTDerechos.Text = string.Format("{0:###,##0.00}", TotalDerechos);// Convert.ToString(TotalDerechos);
                //txtDiasPago.Text = Convert.ToString(DiasVacaciones_A_pagar_en_liquidacion);
            }
            CalculoDeTotalResumen();
        }

        private void gridView2_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridDeducciones.FocusedView;
            var row = (dsRRHH_.deduccionesRow)gridView.GetFocusedDataRow();

            TotalDeducciones = 0;

            foreach (dsRRHH_.deduccionesRow dr in dsRRHH_1.deducciones.Rows)
            {
                TotalDeducciones += Convert.ToDecimal(dr.total);
            }

            txtTDeducciones.Text = string.Format("{0:###,##0.00}", TotalDeducciones);// Convert.ToString(TotalDeducciones);

            CalculoDeTotalResumen();
        }

        private void gridView4_RowStyle_1(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl4.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsRRHH_.LiquiUltimosMesesRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    switch (row.mes)
                    {
                        case -2:
                            e.Appearance.BackColor = Color.FromArgb(153, 255, 153);
                            break;
                        case -1:
                            e.Appearance.BackColor = Color.FromArgb(204, 153, 255);
                            break;
                        default:
                            e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                    }
                }
            }
        }

        private void gridView1_RowStyle_1(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsRRHH_.derechos_calculo_liqRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        switch (row.id)
                        {
                            case 9:
                                e.Appearance.BackColor = Color.FromArgb(153, 255, 153);
                                break;
                            case -8:
                                e.Appearance.BackColor = Color.FromArgb(204, 153, 255);
                                break;
                            default:
                                e.Appearance.BackColor = Color.FromArgb(255, 255, 255);//blanco
                                break;
                        }
                    }
                }
            }
        }

        private void AddDeduccion_Click(object sender, EventArgs e)
        {
            if (Id_liquidacion_ > 0)
            {

            }

        }


        private void gridView1_ShowingEditor_1(object sender, CancelEventArgs e)
        {
           
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRRHH_.derechos_calculo_liqRow)gridView.GetFocusedDataRow();
            if (row.id != 8)
            {
                e.Cancel = true;
            }
        }

        private void gridView1_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRRHH_.derechos_calculo_liqRow)gridView.GetFocusedDataRow();

          

            if (row.id == 8)
            {
                row.total = decimal.Round(row.dias * SueldoBasePromedioDiario,2, MidpointRounding.AwayFromZero);
                Dias_Trabajados = Convert.ToInt32(row.dias);
            }

            CalcularTotales();
            CalculoDeTotalResumen();
        }

        private void gridView1_CellValueChanging_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRRHH_.derechos_calculo_liqRow)gridView.GetFocusedDataRow();



            if (row.id == 8)
            {
                row.total = decimal.Round(row.dias * SueldoBasePromedioDiario, 2, MidpointRounding.AwayFromZero);
                Dias_Trabajados = Convert.ToInt32(row.dias);
            }

            CalcularTotales();
            CalculoDeTotalResumen();
        }
    }
}