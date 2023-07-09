using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
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

namespace LOSA.ACS.RRHH.Informes
{
    public partial class frmHomePrintVoucherPlanilla : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        UserLogin UsuarioLogeado;
        DataSet DataSet1;
        public frmHomePrintVoucherPlanilla(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            this.UsuarioLogeado = pUsuarioLogeado;
            dp = new DataOperations();
            LoadDatos();
        }

        private void LoadDatos()
        {

            string connectionString = dp.ConnectionStringLOSA; // Reemplaza con tu cadena de conexión
            string query = "SELECT [id], [Empresa], [Fecha], [Titulo], " +
                            "[fecha_desde], [fecha_hasta], [enable] " +
                            "FROM [LOSA].[dbo].[RRHH_Encabezado_Planilla]" +
                            " where [enable] = 1 ";//Quincenal
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adat = new SqlDataAdapter(command);
                        adat.Fill(dsNominasVoucher1.header_planilla);
                    }

                    connection.Close();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            PlanillaHeader PlanillaHeader1 = new PlanillaHeader();
            if (PlanillaHeader1.FillEncabezadoPlanillaVariables(dp.ValidateNumberInt32(gridLookUpEdit1.EditValue)))
            {
                string connectionString = dp.ConnectionStringLOSA; // Reemplaza con tu cadena de conexión
                string query;
                if (PlanillaHeader1.tipo ==1)//Quincenal
                {
                    query = "SELECT [id] as Id, [Codigo], [Empleado], [Identidad], [Cargo], [Dias_Vacaciones], [Dias_Faltados], " +
                               "[Dias_Laborados], [Salario_basico_total], [Vacaciones], [Transporte], [Otros_Ingresos], [Total_Ingresos], " +
                               "[Ahorro_fij_Coop], [Bancos], [Prestamo_Coop], [Cafeteria], [Ahorro_Ret_Coop], [Otras_deducciones_coop], " +
                               "[Plan_dental], [Seguro_Medico], [USULA], [IHSS_T], [INCAPACIDADES], [ISR], [Total_Egresos], [Salario_neto] " +
                               "FROM [LOSA].[dbo].[RRHH_Detalle_Planilla] " +
                               " where [id_h] = " + gridLookUpEdit1.EditValue.ToString() +
                               " order by [Empleado]";
                }
                else
                {
                    //Horas Extra
                    query = @"SELECT [id]
                                    ,[id_h]
                                    ,[codigo]
                                    ,[empleado_nombre]
                                    ,[identidad]
                                    ,[cargo]
                                    ,[Salario_basico_total]
                                    ,[HE_25]
                                    ,[HE_50]
                                    ,[HE_75]
                                    ,[HE_100]
                                    ,[PHE_25]
                                    ,[PHE_50]
                                    ,[PHE_75]
                                    ,[PHE_100]
                                    ,[Total_Horas_Extra]
                                FROM [LOSA].[dbo].[RRHH_Detalle_PlanillaHE]
                                where [id_h] = "+ gridLookUpEdit1.EditValue.ToString() +
                                " order by [empleado_nombre]";
                }
                
                try
                {
                    if (PlanillaHeader1.tipo == 1)//Quincenal
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                SqlDataAdapter adat = new SqlDataAdapter(command);
                                DataSet1 = new DataSet("DataSet1");

                                // Crear la DataTable "DetalleP"
                                DataTable DetalleP = new DataTable("DetalleP");

                                // Agregar las columnas a la DataTable
                                DetalleP.Columns.Add("id", typeof(Int64));
                                DetalleP.Columns.Add("id_h", typeof(int));
                                DetalleP.Columns.Add("Codigo", typeof(string));
                                DetalleP.Columns.Add("Empleado", typeof(string));
                                DetalleP.Columns.Add("Identidad", typeof(string));
                                DetalleP.Columns.Add("Cargo", typeof(string));
                                DetalleP.Columns.Add("Dias_Vacaciones", typeof(int));
                                DetalleP.Columns.Add("Dias_Faltados", typeof(int));
                                DetalleP.Columns.Add("Dias_Laborados", typeof(int));
                                DetalleP.Columns.Add("Salario_basico_total", typeof(decimal));
                                DetalleP.Columns.Add("Vacaciones", typeof(decimal));
                                DetalleP.Columns.Add("Transporte", typeof(decimal));
                                DetalleP.Columns.Add("Otros_Ingresos", typeof(decimal));
                                DetalleP.Columns.Add("Total_Ingresos", typeof(decimal));
                                DetalleP.Columns.Add("Ahorro_fij_Coop", typeof(decimal));
                                DetalleP.Columns.Add("Bancos", typeof(decimal));
                                DetalleP.Columns.Add("Prestamo_Coop", typeof(decimal));
                                DetalleP.Columns.Add("Cafeteria", typeof(decimal));
                                DetalleP.Columns.Add("Ahorro_Ret_Coop", typeof(decimal));
                                DetalleP.Columns.Add("Otras_deducciones_coop", typeof(decimal));
                                DetalleP.Columns.Add("Plan_dental", typeof(decimal));
                                DetalleP.Columns.Add("Seguro_Medico", typeof(decimal));
                                DetalleP.Columns.Add("USULA", typeof(decimal));
                                DetalleP.Columns.Add("IHSS_T", typeof(decimal));
                                DetalleP.Columns.Add("INCAPACIDADES", typeof(decimal));
                                DetalleP.Columns.Add("ISR", typeof(decimal));
                                DetalleP.Columns.Add("Total_Egresos", typeof(decimal));
                                DetalleP.Columns.Add("Salario_neto", typeof(decimal));
                                DataSet1.Tables.Add(DetalleP);

                                adat.Fill(DataSet1.Tables["DetalleP"]);
                                gridView1.Columns.Clear();
                                gridControl1.DataSource = DataSet1;
                                gridControl1.DataMember = "DetalleP";
                            }

                            connection.Close();
                        }
                    }
                    else
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                SqlDataAdapter adat = new SqlDataAdapter(command);
                                // Crear el DataSet "DataSet1"
                                DataSet DataSet1 = new DataSet("DataSet1");

                                // Crear la DataTable "DetalleP"
                                DataTable DetalleP = new DataTable("DetalleP");

                                // Agregar las columnas a la DataTable
                                DetalleP.Columns.Add("id", typeof(Int64));
                                DetalleP.Columns.Add("id_h", typeof(int));
                                DetalleP.Columns.Add("codigo", typeof(string));
                                DetalleP.Columns.Add("empleado_nombre", typeof(string));
                                DetalleP.Columns.Add("identidad", typeof(string));
                                DetalleP.Columns.Add("cargo", typeof(string));
                                DetalleP.Columns.Add("Salario_basico_total", typeof(decimal));
                                DetalleP.Columns.Add("HE_25", typeof(decimal));
                                DetalleP.Columns.Add("HE_50", typeof(decimal));
                                DetalleP.Columns.Add("HE_75", typeof(decimal));
                                DetalleP.Columns.Add("HE_100", typeof(decimal));
                                DetalleP.Columns.Add("PHE_25", typeof(decimal));
                                DetalleP.Columns.Add("PHE_50", typeof(decimal));
                                DetalleP.Columns.Add("PHE_75", typeof(decimal));
                                DetalleP.Columns.Add("PHE_100", typeof(decimal));
                                DetalleP.Columns.Add("Total_Horas_Extra", typeof(decimal));
                                
                                // Agregar la DataTable al DataSet
                                DataSet1.Tables.Add(DetalleP);

                                adat.Fill(DataSet1.Tables["DetalleP"]);
                                gridView1.Columns.Clear();


                                gridControl1.DataSource = DataSet1;
                                gridControl1.DataMember = "DetalleP";
                            }

                            connection.Close();
                        }
                    }
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void cmdPrintALL_Click(object sender, EventArgs e)
        {
            PlanillaHeader PlanillaHeader1 = new PlanillaHeader();
            if (PlanillaHeader1.FillEncabezadoPlanillaVariables(dp.ValidateNumberInt32(gridLookUpEdit1.EditValue)))
            {
                if (PlanillaHeader1.tipo == 1)//Quincenal
                {
                    int contador_print = 0;
                    rptPlanilla reportResumenReproceso = null;

                    foreach (DataRow row in DataSet1.Tables["DetalleP"].Rows)
                    {

                        if (contador_print == 0)
                        {
                            reportResumenReproceso = new rptPlanilla(Convert.ToInt64(row["id"]));
                            reportResumenReproceso.CreateDocument();
                            contador_print++;
                        }
                        else
                        {
                            // Create the second report and generate its document.
                            rptPlanilla report2 = new rptPlanilla(Convert.ToInt64(row["id"]));
                            report2.CreateDocument();


                            if (reportResumenReproceso != null)
                            {
                                // Add all pages of the second report to the end of the first report.
                                reportResumenReproceso.ModifyDocument(x => { x.AddPages(report2.Pages); });
                            }
                        }

                    }


                    if (reportResumenReproceso != null)
                    {
                        reportResumenReproceso.ShowPrintMarginsWarning = false;

                        using (ReportPrintTool printTool = new ReportPrintTool(reportResumenReproceso))
                        {
                            printTool.ShowPreviewDialog();
                        }
                    }
                }
                else //horas Extra
                {
                    int contador_print = 0;
                    rptPlanillaHE reportResumenReproceso = null;

                    foreach (DataRow row in DataSet1.Tables["DetalleP"].Rows)
                    {

                        if (contador_print == 0)
                        {
                            reportResumenReproceso = new rptPlanillaHE(Convert.ToInt64(row["id"]));
                            reportResumenReproceso.CreateDocument();
                            contador_print++;
                        }
                        else
                        {
                            // Create the second report and generate its document.
                            rptPlanillaHE report2 = new rptPlanillaHE(Convert.ToInt64(row["id"]));
                            report2.CreateDocument();


                            if (reportResumenReproceso != null)
                            {
                                // Add all pages of the second report to the end of the first report.
                                reportResumenReproceso.ModifyDocument(x => { x.AddPages(report2.Pages); });
                            }
                        }

                    }


                    if (reportResumenReproceso != null)
                    {
                        reportResumenReproceso.ShowPrintMarginsWarning = false;

                        using (ReportPrintTool printTool = new ReportPrintTool(reportResumenReproceso))
                        {
                            printTool.ShowPreviewDialog();
                        }
                    }
                }
            }
              
        }
    }
}