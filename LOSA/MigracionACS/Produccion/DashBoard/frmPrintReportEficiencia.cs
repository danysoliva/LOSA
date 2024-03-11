using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.DashBoard;
using LOSA.MigracionACS.Produccion.Eficiencia.ReportesEf;
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

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    public partial class frmPrintReportEficiencia : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        UserLogin UsuarioLogeado;
        decimal TotalReproceso = 0;
        decimal TotalExtruder = 0;
        decimal TotalPellet = 0;
        decimal TotalPellet1 = 0;
        decimal TotalPellet2 = 0;
        decimal EficienciaExtruder = 0;
        decimal EficienciaPellet = 0;
        decimal EficienciaPellet1 = 0;
        decimal EficienciaPellet2 = 0;
        public bool CerrarForm;
        public frmPrintReportEficiencia(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            ValidatePermisos();
            dp = new DataOperations();
            dtDesde_.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now();
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(61))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(61))
            {
                //btnc_VerifyReach.Enabled = true;
                AccesoPrevio = true;
            }

            //Si no se consiguio acceso previo vamos a validar niveles permanentes
            if (!AccesoPrevio)
            {
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);//7=ALOSY, 9=AMS
                switch (idNivel)
                {
                    case 1://Basic View
                    case 2://Basic No Autorization
                        //btnc_VerifyReach.Enabled = false;
                        AccesoPrevio = true;
                        break;
                    case 3://Medium Autorization
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        //btnc_VerifyReach.Enabled = true;
                        AccesoPrevio = true;
                        break;
                    default:
                        break;
                }
            }

            if (!AccesoPrevio)
            {
                CerrarForm = true;
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #61");
            }
            else
            {

            }
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            TotalExtruder = 0;
            TotalPellet = 0;
            EficienciaExtruder = 0;
            EficienciaPellet = 0;

            LoadPellet_vsExtruder();
            GenerateHeader();
            LoadDetalleTM_Turnos();
            LoadDetalleTM_MaquinaTurno();
            LoadDatosEficienciaGroup();
            LoadTablesEficienciaMaquinas();
            LoadHumedades();
            LoadDatosReproceso();
            LoadDatosReprocesoGrupos();
            LoadtablaTiemposTrabajadosv2();
            LoadTablaTiempos_Grafico();

            rptEficienciaBasico report = new rptEficienciaBasico(Convert.ToDateTime(dtDesde_.EditValue),
                                                                 Convert.ToDateTime(dtHasta.EditValue), 
                                                                 UsuarioLogeado.Nombre, dsReporteEficiencia1, TotalReproceso) 
            { 
                DataSource = dsReporteEficiencia1, /*DataMember = "detail",*/ ShowPrintMarginsWarning = false 
            };
            
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void LoadTablaTiempos_Grafico()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_tabla_horas_rpt_eficienciav3";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporteEficiencia1.tabla_tiempos.Clear();
                adat.Fill(dsReporteEficiencia1.tabla_tiempos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        //private void LoadtablaTiemposTrabajados()
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
        //        conn.Open();

        //        string sql = @"[sp_get_tabla_horas_rpt_eficienciav2]";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
        //        cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        dsReporteEficiencia1.tabla_tiempos_turno.Clear();
        //        adat.Fill(dsReporteEficiencia1.tabla_tiempos_turno);

        //        decimal TotalHoras = 0;
        //        int count = 0;
        //        decimal turno1 = 0;
        //        decimal turno2 = 0;
        //        decimal turno3 = 0;
        //        foreach (dsReporteEficiencia.tabla_tiempos_turnoRow row in dsReporteEficiencia1.tabla_tiempos_turno)
        //        {
        //            TotalHoras += row.horas;
        //            if (row.turno == "1")
        //                turno1 = row.horas;
        //            if (row.turno == "2")
        //                turno2 = row.horas;
        //            if (row.turno == "3")
        //                turno3 = row.horas;
        //            count++;
        //        }

        //        dsReporteEficiencia.tabla_tiempos_turnoRow rowt;

        //        rowt = dsReporteEficiencia1.tabla_tiempos_turno.Newtabla_tiempos_turnoRow();
        //        rowt["horas1"] = turno1;
        //        rowt["horas2"] = turno2;
        //        rowt["horas3"] = turno3;
        //        rowt["total"] = TotalHoras;
        //        dsReporteEficiencia1.tabla_tiempos_turno.Addtabla_tiempos_turnoRow(rowt);

        //        conn.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}
        private void LoadtablaTiemposTrabajadosv2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_tabla_horas_rpt_eficienciav2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@id_turno", 1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporteEficiencia1.tmp_horas_turno.Clear();
                adat.Fill(dsReporteEficiencia1.tmp_horas_turno);

                decimal TotalHoras = 0;
                int count = 0;
                decimal Extruder = 0;
                decimal Pellet1 = 0;
                decimal Pellet2 = 0;
              
                foreach (dsReporteEficiencia.tmp_horas_turnoRow row in dsReporteEficiencia1.tmp_horas_turno)
                {
                    switch (row.maquina)
                    {
                        case "Extrusora":
                            Extruder = row.horas;
                            break;
                        case "Pellet 1":
                            Pellet1 = row.horas;
                            break;
                        case "Pellet 2":
                            Pellet2 = row.horas;
                            break;
                    }
                }

                dsReporteEficiencia.tabla_tiempos_turno1Row rowt;

                rowt = dsReporteEficiencia1.tabla_tiempos_turno1.Newtabla_tiempos_turno1Row();
                rowt["extruder"] = Extruder;
                rowt["pellet1"] = Pellet1;
                rowt["pellet2"] = Pellet2;
                rowt["total"] = Extruder + Pellet1 + Pellet2;
                dsReporteEficiencia1.tabla_tiempos_turno1.Addtabla_tiempos_turno1Row(rowt);



                //Turno 2
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd2.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd2.Parameters.AddWithValue("@id_turno", 2);
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsReporteEficiencia1.tmp_horas_turno.Clear();
                adat2.Fill(dsReporteEficiencia1.tmp_horas_turno);

                TotalHoras = 0;
                Extruder = 0;
                Pellet1 = 0;
                Pellet2 = 0;

                foreach (dsReporteEficiencia.tmp_horas_turnoRow row in dsReporteEficiencia1.tmp_horas_turno)
                {
                    switch (row.maquina)
                    {
                        case "Extrusora":
                            Extruder = row.horas;
                            break;
                        case "Pellet 1":
                            Pellet1 = row.horas;
                            break;
                        case "Pellet 2":
                            Pellet2 = row.horas;
                            break;
                    }
                }

                dsReporteEficiencia.tabla_tiempos_turno2Row rowt2;

                rowt2 = dsReporteEficiencia1.tabla_tiempos_turno2.Newtabla_tiempos_turno2Row();
                rowt2["extruder"] = Extruder;
                rowt2["pellet1"] = Pellet1;
                rowt2["pellet2"] = Pellet2;
                rowt2["total"] = Extruder + Pellet1 + Pellet2;
                dsReporteEficiencia1.tabla_tiempos_turno2.Addtabla_tiempos_turno2Row(rowt2);



                //Turno 3
                SqlCommand cmd3 = new SqlCommand(sql, conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd3.Parameters.AddWithValue("@id_turno", 3);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsReporteEficiencia1.tmp_horas_turno.Clear();
                adat3.Fill(dsReporteEficiencia1.tmp_horas_turno);

                TotalHoras = 0;
                Extruder = 0;
                Pellet1 = 0;
                Pellet2 = 0;

                foreach (dsReporteEficiencia.tmp_horas_turnoRow row in dsReporteEficiencia1.tmp_horas_turno)
                {
                    switch (row.maquina)
                    {
                        case "Extrusora":
                            Extruder = row.horas;
                            break;
                        case "Pellet 1":
                            Pellet1 = row.horas;
                            break;
                        case "Pellet 2":
                            Pellet2 = row.horas;
                            break;
                    }
                }

                dsReporteEficiencia.tabla_tiempos_turno3Row rowt3;

                rowt3 = dsReporteEficiencia1.tabla_tiempos_turno3.Newtabla_tiempos_turno3Row();
                rowt3["extruder"] = Extruder;
                rowt3["pellet1"] = Pellet1;
                rowt3["pellet2"] = Pellet2;
                rowt3["total"] = Extruder + Pellet1 + Pellet2;
                dsReporteEficiencia1.tabla_tiempos_turno3.Addtabla_tiempos_turno3Row(rowt3);

                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosReproceso()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                TotalReproceso = 0;

                //Tilapia
                SqlCommand cmd3 = new SqlCommand("sp_get_reproceso_reporte_eficiencia_prd_print", cn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd3.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                cmd3.Parameters.AddWithValue("@filtro_maquina", 3);
                //cmd3.Parameters.AddWithValue("@filtro_turno", TurnoId);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsReporteEficiencia1.reproceso_tilapia.Clear();
                adat3.Fill(dsReporteEficiencia1.reproceso_tilapia);
                foreach (dsReporteEficiencia.reproceso_tilapiaRow row in dsReporteEficiencia1.reproceso_tilapia)
                {
                    TotalReproceso += row.total;
                }


                //camaron
                SqlCommand cmd4 = new SqlCommand("sp_get_reproceso_reporte_eficiencia_prd_print", cn);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd4.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                cmd4.Parameters.AddWithValue("@filtro_maquina", 1);
                //cmd4.Parameters.AddWithValue("@filtro_turno", TurnoId);
                SqlDataAdapter adat4 = new SqlDataAdapter(cmd4);
                dsReporteEficiencia1.reproceso_cam.Clear();
                adat4.Fill(dsReporteEficiencia1.reproceso_cam);

                foreach (dsReporteEficiencia.reproceso_camRow row in dsReporteEficiencia1.reproceso_cam)
                {
                    TotalReproceso += row.total;
                }

                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
        }
        private void LoadDatosReprocesoGrupos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                TotalReproceso = 0;

                //
                SqlCommand cmd3 = new SqlCommand("sp_get_reproceso_reporte_eficiencia_prd_print_group", cn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd3.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                //cmd3.Parameters.AddWithValue("@filtro_maquina", 3);
                //cmd3.Parameters.AddWithValue("@filtro_turno", TurnoId);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsReporteEficiencia1.reproceso_grupos.Clear();
                adat3.Fill(dsReporteEficiencia1.reproceso_grupos);
                //foreach (dsReporteEficiencia.reproceso_tilapiaRow row in dsReporteEficiencia1.reproceso_tilapia)
                //{
                //    TotalReproceso += row.total;
                //}
                SqlCommand cmd1 = new SqlCommand("[sp_get_detalle_tm_prd_por_particula_print]", cn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd1.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                //dsReporteEficiencia1.turnos_group_eficiencia.Clear();
                adat1.Fill(dsReporteEficiencia1.reproceso_grupos);


                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void LoadHumedades()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_humedades_dashboard_print_x_turno";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporteEficiencia1.humedades.Clear();
                adat.Fill(dsReporteEficiencia1.humedades);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTablesEficienciaMaquinas()
        {
            try
            {
                EficienciaPellet2 = 0;
                EficienciaPellet1 = 0;
                EficienciaExtruder = 0;
                TotalExtruder = TotalPellet1 = TotalPellet2 = 0;
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();

                //Extruder
                SqlCommand cmd2 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd_print", cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd2.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                cmd2.Parameters.AddWithValue("@idlinea", 4);
                cmd2.Parameters.AddWithValue("@id_turno", 4);
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsReporteEficiencia1.eficiencia_detalle.Clear();
                adat2.Fill(dsReporteEficiencia1.eficiencia_detalle);

                foreach (dsReporteEficiencia.eficiencia_detalleRow rowx in dsReporteEficiencia1.eficiencia_detalle.Rows)
                {
                    TotalExtruder = rowx.tm;
                    EficienciaExtruder = rowx.rendimiento;
                }

                //pellet 1
                SqlCommand cmd3 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd_print", cn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd3.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                cmd3.Parameters.AddWithValue("@idlinea", 1);
                cmd3.Parameters.AddWithValue("@id_turno", 4);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsReporteEficiencia1.eficiencia_detalle1.Clear();
                adat3.Fill(dsReporteEficiencia1.eficiencia_detalle1);

                
                foreach (dsReporteEficiencia.eficiencia_detalle1Row rowx in dsReporteEficiencia1.eficiencia_detalle1.Rows)
                {
                    TotalPellet1 += rowx.tm;
                    EficienciaPellet1 += rowx.rendimiento;
                }
                TotalPellet += TotalPellet1;

                //pellet 2
                SqlCommand cmd4 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd_print", cn);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd4.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                cmd4.Parameters.AddWithValue("@idlinea", 2);
                cmd4.Parameters.AddWithValue("@id_turno", 4);
                SqlDataAdapter adat4 = new SqlDataAdapter(cmd4);
                dsReporteEficiencia1.eficiencia_detalle2.Clear();
                adat4.Fill(dsReporteEficiencia1.eficiencia_detalle2);

                foreach (dsReporteEficiencia.eficiencia_detalle2Row rowx in dsReporteEficiencia1.eficiencia_detalle2.Rows)
                {
                    TotalPellet2 += rowx.tm;
                    EficienciaPellet2 += rowx.rendimiento;
                }
                TotalPellet += TotalPellet2;

                decimal por_tmExtruder = (TotalExtruder / (TotalExtruder + TotalPellet)) * 100;
                decimal por_tmPellet1 = (TotalPellet1 / (TotalExtruder + TotalPellet)) * 100;
                decimal por_tmPellet2 = (TotalPellet2 / (TotalExtruder + TotalPellet)) * 100;

                decimal por_efiExtruder = (EficienciaExtruder / 10) * 100;
                decimal por_efiPellet1 = (EficienciaPellet1 / 5) * 100;
                decimal por_efiPellet2 = (EficienciaPellet2 / 5) * 100;

                decimal por_efi_global_extruder = (por_tmExtruder * por_efiExtruder) / 100;
                decimal por_efi_global_pellet1 = (por_tmPellet1 * por_efiPellet1) / 100;
                decimal por_efi_global_pellet2 = (por_tmPellet2 * por_efiPellet2) / 100;
                decimal por_efi_global_planta = por_efi_global_extruder + por_efi_global_pellet1 + por_efi_global_pellet2;


                dsReporteEficiencia1.eficiencia_global.Clear();

                dsReporteEficiencia.eficiencia_globalRow rowy = dsReporteEficiencia1.eficiencia_global.Neweficiencia_globalRow();
                rowy.efi_ext = EficienciaExtruder;
                rowy.efi_pel = EficienciaPellet1;
                rowy.tm_ext = TotalExtruder;
                rowy.tm_pel = TotalPellet1;
                rowy.por_efi_ext = por_efiExtruder;
                rowy.por_efi_pel = por_efiPellet1;
                rowy.por_tm_ext = por_tmExtruder;
                rowy.por_tm_pel = por_tmPellet1;
                rowy.por_efi_total_ext = por_efi_global_extruder;
                rowy.por_efi_total_pel = por_efi_global_pellet1;
                rowy.efi_global_planta = por_efi_global_planta;
                rowy.por_efi_pel2 = por_efiPellet2;
                rowy.efi_pel2 = EficienciaPellet2;
                rowy.tm_pel2 = TotalPellet2;
                rowy.por_efi_total_pel2 = por_efi_global_pellet2;
                rowy.por_tm_pel2 = por_tmPellet2;

                dsReporteEficiencia1.eficiencia_global.Addeficiencia_globalRow(rowy);

                //dsReporteEficiencia1.AcceptChanges();



                ////Tabla total
                //SqlCommand cmd5 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd_print", cn);
                //cmd5.CommandType = CommandType.StoredProcedure;
                //cmd5.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                //cmd5.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                //cmd5.Parameters.AddWithValue("@idlinea", 5);
                //cmd5.Parameters.AddWithValue("@id_turno", 4);
                //SqlDataAdapter adat5 = new SqlDataAdapter(cmd5);
                //dsReporteEficiencia1.eficiencia_detalle_total.Clear();
                //adat5.Fill(dsReporteEficiencia1.eficiencia_detalle_total);



            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosEficienciaGroup()
        {
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_get_eficiencia_segun_horas_reales", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue); 
            cmd.Parameters.AddWithValue("@filtro_maquina", 5);
            cmd.Parameters.AddWithValue("@id_turno", 4);
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            dsReporteEficiencia1.turnos_group_eficiencia.Clear();
            adat.Fill(dsReporteEficiencia1.turnos_group_eficiencia);

            cn.Close();
        }

        private void LoadDetalleTM_MaquinaTurno()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_detalle_tm_producidas_x_turno_group_report_print_lines";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@id_turno", 3);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporteEficiencia1.turnos_group_ext_linea.Clear();
                adat.Fill(dsReporteEficiencia1.turnos_group_ext_linea);

                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd2.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd2.Parameters.AddWithValue("@id_turno", 1);
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsReporteEficiencia1.turnos_group_pel1_linea.Clear();
                adat2.Fill(dsReporteEficiencia1.turnos_group_pel1_linea);

                SqlCommand cmd3 = new SqlCommand(sql, conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd3.Parameters.AddWithValue("@id_turno", 2);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsReporteEficiencia1.turnos_group_pel2_linea.Clear();
                adat3.Fill(dsReporteEficiencia1.turnos_group_pel2_linea);

                //dsReporteEficiencia1.header.AddheaderRow(row);
                conn.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void GenerateHeader()
        {
         
            dsReporteEficiencia.headerRow row;

            row = dsReporteEficiencia1.header.NewheaderRow();
            row["desde"] = dtDesde_.EditValue;
            row["hasta"] = dtHasta.EditValue;
            row["usuario"] = UsuarioLogeado.Nombre;
            dsReporteEficiencia1.header.AddheaderRow(row);
        }

        private void LoadPellet_vsExtruder()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_eficiencia_detalle_pellet_vs_extruder_report";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechai", dtDesde_.EditValue);
                cmd.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporteEficiencia1.pellet_vs_extruder.Clear();
                adat.Fill(dsReporteEficiencia1.pellet_vs_extruder);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleTM_Turnos()
        {
            //[sp_get_detalle_tm_producidas_x_turno_group_report_print]
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_detalle_tm_producidas_x_turno_group_report_print";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@maquina", 3);//extruder
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReporteEficiencia1.turnos_group_ext.Clear();
                adat.Fill(dsReporteEficiencia1.turnos_group_ext);

                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd2.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd2.Parameters.AddWithValue("@maquina", 1);//Pellet 1
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsReporteEficiencia1.turnos_group_pel.Clear();
                adat2.Fill(dsReporteEficiencia1.turnos_group_pel);

                SqlCommand cmd3 = new SqlCommand(sql, conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
                cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
                cmd3.Parameters.AddWithValue("@maquina", 2);//Pellet 2
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsReporteEficiencia1.turnos_group_pel2.Clear();
                adat3.Fill(dsReporteEficiencia1.turnos_group_pel2);

                dsReporteEficiencia1.tabla_turnos.Clear();
                GenerarTablesTM_Turno();


                //dsReporteEficiencia1.header.AddheaderRow(row);
                conn.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void GenerarTablesTM_Turno()
        {
            //Tablas TM
            SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
            conn.Open();


            #region Turno 1
            SqlCommand cmd3 = new SqlCommand("sp_get_detalle_tm_producidas_x_turno_group_report_print_table", conn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 3);//ext
            cmd3.Parameters.AddWithValue("@id_turno", 1);
            decimal valore = 0;
            decimal valorp = 0;
            decimal valorp2 = 0;
            dsReporteEficiencia.tabla_turnosRow row;
            row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();

            try
            {
                valore = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valore > 0)
            {
                //Turno 1 Ext
                row["ext1"] = valore;
            }

            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 1);//Pellet
            cmd3.Parameters.AddWithValue("@id_turno", 1);
            try
            {
                valorp = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valorp > 0)
            {
                //Turno 1 Ext
                //row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();
                row["pel1"] = valorp;
            }
            //row["total1"] = valorp + valore;

            //***********PELLET 2************//
            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 2);//Pellet2
            cmd3.Parameters.AddWithValue("@id_turno", 1);
            try
            {
                valorp2 = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valorp2 > 0)
            {
                //Turno 1 Ext
                //row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();
                row["pel2t1"] = valorp2;
            }
            row["total1"] = valorp + valore + valorp2;

            #endregion


            #region Turno 2
            cmd3 = new SqlCommand("sp_get_detalle_tm_producidas_x_turno_group_report_print_table", conn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 3);//ext
            cmd3.Parameters.AddWithValue("@id_turno", 2);
            valore = 0;
            valorp = 0;
            valorp2 = 0;
            
            try
            {
                valore = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valore > 0)
            {
                //Turno 2 Ext
                row["ext2"] = valore;
            }

            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 1);//Pellet1
            cmd3.Parameters.AddWithValue("@id_turno", 2);
            try
            {
                valorp = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valorp > 0)
            {
                //Turno 2 Ext
                //row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();
                row["pel2"] = valorp;
            }
            //row["total2"] = valorp + valore;

            //***********PELLET 2************//
            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 2);//Pellet2
            cmd3.Parameters.AddWithValue("@id_turno", 2);
            try
            {
                valorp2 = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valorp2 > 0)
            {
                //Turno 1 Ext
                //row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();
                row["pel2t2"] = valorp2;
            }
            row["total2"] = valorp + valore + valorp2;

            #endregion


            #region Turno 3
            cmd3 = new SqlCommand("sp_get_detalle_tm_producidas_x_turno_group_report_print_table", conn);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 3);//ext
            cmd3.Parameters.AddWithValue("@id_turno", 3);
            valore = 0;
            valorp = 0;
            valorp2 = 0;

            try
            {
                valore = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valore > 0)
            {
                //Turno 3 Ext
                row["ext3"] = valore;
            }

            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 1);//Pellet
            cmd3.Parameters.AddWithValue("@id_turno", 3);
            try
            {
                valorp = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valorp > 0)
            {
                //Turno 3 Ext
                //row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();
                row["pel3"] = valorp;
            }

            //row["total3"] = valorp + valore;


            //***********PELLET 2************//
            cmd3.Parameters.Clear();
            cmd3.Parameters.AddWithValue("@fecha_i", dtDesde_.EditValue);
            cmd3.Parameters.AddWithValue("@fecha_f", dtHasta.EditValue);
            cmd3.Parameters.AddWithValue("@maquina", 2);//Pellet2
            cmd3.Parameters.AddWithValue("@id_turno", 3);
            try
            {
                valorp2 = Convert.ToDecimal(cmd3.ExecuteScalar());
            }
            catch { }

            if (valorp2 > 0)
            {
                //Turno 1 Ext
                //row = dsReporteEficiencia1.tabla_turnos.Newtabla_turnosRow();
                row["pel2t3"] = valorp2;
            }
            row["total3"] = valorp + valore + valorp2;


            dsReporteEficiencia1.tabla_turnos.Addtabla_turnosRow(row);
            conn.Close();
            #endregion
        }



    }
}