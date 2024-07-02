using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;

using System.Data.SqlClient;
using System.IO;
using System.Reflection;

using Devart.Data.PostgreSql;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Threading;
using DevExpress.XtraGrid.Columns;
using LOSA.Clases;

/* NOTA:
 *  Para adicionar un nuevo reporte se debe condicionar y ejecutar en respectivamente: 
 *  - cmb_reports_SelectedIndexChanged()
 *  - cargar_grid()
 */

namespace LOSA.MigracionACS.Finanzas.Reports
{
    public partial class RPT_Conta_Varios : DevExpress.XtraEditors.XtraForm
    {
        #region Variables Globales
        int id_seleccionado= 0;
        DataOperations dp = new DataOperations();
        DataTable dtDatos;
        DataTable UserGroups;
        
        FMOP fmop = new FMOP();

        string ActiveUserCode;
        string ActiveUserType;
        string ActiveADUser;
        UserLogin UsuarioLogeado;
        int Desde;
        int Hasta;
        #endregion

        public RPT_Conta_Varios(string ActiveUserCode, string ActiveUserType, string ActiveADUser, DataTable UserGroups, UserLogin pUser)
        {
            InitializeComponent();
            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserType = ActiveUserType;
            this.ActiveADUser   = ActiveADUser;
            this.UserGroups = UserGroups;
            this.UsuarioLogeado = pUser;
            //if (user_has_access("app_acs_rpt_finance"))
            //{
            //    btnteoric.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //}
            //else
            //{
            //    btnteoric.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}
            if (UsuarioLogeado.ValidarNivelPermisos(87))
            {
                btnteoric.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnteoric.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            cargarPeriodos_acs();
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_GenReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            #region Validando Datos Ingresados en Pantalla
            String msg = "";
            #region (Sub tipo de reporte)
                //if (cmb_reports.SelectedIndex == 0) {
                if (radGrupo.Visible== true) {
                    if (radGrupo.SelectedIndex == null) msg = "Marque el tipo de reporte (Maestro, del periodo, baja o de alta";
                    if (radGrupo.SelectedIndex!=0 & (spn_anio.Value <= 0 || (spn_mes.Value <= 0 || spn_mes.Value > 12))) msg = "Año o mes no válido.";
                }
            #endregion
            #region Validando Periodo
                // NOTA: cmb_reports=4 (Reporte de Compras, permite -1 "No contabilizados"
                if (cmb_reports.SelectedIndex == 4) {
                    if (chkContabilizado.Checked && int.Parse(cmb_Period.EditValue.ToString()) ==-1) 
                            msg = "Si marca 'Contabilizados y No Contabilizados', debe seleccionar periodo.";               
                    //else if(cmb_Period.EditValue == null) msg = "Seleccione el periodo.";
                }
            else if (cmb_Period.Visible == true & cmb_Period.EditValue == null) msg = "Debe seleccionar periodo.";
            #endregion
            #region Validando Rango fechas
            //if ((cmb_reports.SelectedIndex == 2 || cmb_reports.SelectedIndex == 3) &
            if (cmb_reports.SelectedIndex != 30)
            {
                if (pnl_fechas.Visible == true & (
                       (Convert.ToDateTime(dt_hasta.EditValue) < Convert.ToDateTime(dt_desde.EditValue) ||
                       (dt_desde.EditValue == null || dt_hasta.EditValue == null))
                   )
               ) msg = "Rango de fecha no es válido.";
            }
            else
            {
                if (dt_desde.EditValue == null)
                {
                    msg = "Rango de fecha no es válido.";
                }
            }
            #endregion
            #region Validando Textbox
            if (pnl_Textbox.Visible == true)
            {
                if (btn_Seleccionar.Visible == true) {
                    if (id_seleccionado == 0)
                    { msg = "Debe seleccionar el criterio de busqueda para el reporte."; txt_Textbox.Focus(); }               
                }
                else if (txt_Textbox.Text.Trim() == "") { msg = "Debe ingresar el valor a buscar"; txt_Textbox.Focus(); }
            }
            #endregion
            //----------------------------------------------------------------------------------------------------
                if (msg != "") { MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            #endregion
            if (cmb_reports.SelectedIndex != 30)
            {
                inicializar_grid();
            }
            else
            {
                inicializar_grid_v2();
            }

            //---------------------------
            pnl_barra.Visible = true; btn_GenReport.Enabled = btn_Exportar.Enabled = btn_Impresion.Enabled = pnl_parametros.Enabled= false;
            //---------------------------
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
            //---------------------------
        }


        // Botones --------------------------------------------------------------------------------------
        private void btn_bajarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_bajarPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToPdf(dialog.FileName);
            }
        }
       
        private void btn_Imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.PrintDialog();
        }

        private void btn_ImprimirPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_data.ShowPrintPreview();
        }
        //-----------------------------------------------------------------------------------------------


        // Funciones ------------------------------------------------------------------------------------
        void cargar_grid()
        {
            //pnl_barra.Visible = true;
            String DBMS = "";
            String SP   = "";
            String qry  = "";
            try
            {
                #region Armando_Parametros Segun Tipo-Reporte
                //-------------------------------------------
                SqlCommand cmd     = new SqlCommand();
                PgSqlCommand cmd2 = new PgSqlCommand();
                cmd.CommandType    = CommandType.StoredProcedure;
                //___________________________________________
                if (cmb_reports.SelectedIndex == 0)
                {
                    #region Parametros - Activos (Odoo)
                    if (radGrupo.SelectedIndex == 0) {
                        #region Parametros - Activos (Maestro)
                        qry  = "Select * From x_view_Activos_Maestro";
                        DBMS = "ODOO";
                        #endregion                                      
                    }
                    if (radGrupo.SelectedIndex == 1)
                    {
                        #region Parametros - Activos (xPeriodo)
                        qry = String.Format(@" Select * From x_view_Activos_xPeriodo WHERE 
                                                date_part('year', depreciation_date) = {0} AND date_part('month', depreciation_date) = {1}
                                                AND state = 'open' "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        //qry = String.Format(@" Select * From x_view_Activos_xPeriodo WHERE state = 'open'");
                        DBMS = "ODOO";
                        #endregion                   
                    }
                    if (radGrupo.SelectedIndex == 2)
                    {
                        #region Parametros - Activos (de baja)
                        qry = String.Format(@" Select * From x_view_activos_xperiodo_debaja WHERE asset_id
                                            NOT IN (
                                                SELECT A.id AS asset_id
                                                 FROM public.account_asset_asset A
                                                INNER JOIN public.account_asset_category B 
                                                   ON A.category_id = B.id
                                                 LEFT JOIN (SELECT asset_id
                                                                    ,SUM(amount) AS dep_acum
                                                               FROM public.account_asset_depreciation_line
                                                              WHERE move_check = true /*AND COALESCE(move_id, -1) >= 0*/
                                                             GROUP BY asset_id) C
                                                   ON A.id = C.asset_id
                                                INNER JOIN public.res_users D
                                                   ON A.create_uid = D.id
                                                INNER JOIN public.res_partner E
                                                   ON D.partner_id = E.id
                                                INNER JOIN public.res_users F
                                                   ON A.write_uid = F.id
                                                INNER JOIN public.res_partner G
                                                   ON F.partner_id = G.id
                                                INNER JOIN public.account_asset_depreciation_line H
                                                   ON H.asset_id = A.id
                                                INNER JOIN public.account_analytic_account I
                                                   ON A.account_analytic_id = I.id
                                                WHERE date_part('year', H.depreciation_date) = {0}
                                                  AND date_part('month', H.depreciation_date) = {1}
                                                  AND A.state = 'open'
                                            )
                                            "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 3)
                    {
                        #region Parametros - Activos (de alta)
                        qry = String.Format(@" Select * From x_view_Activos_xPeriodo WHERE 
                                                date_part('year', ""Fecha Compra"" ) = {0} AND date_part('month', ""Fecha Compra"") = {1}
                                                AND state = 'open' "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO";
                        #endregion
                    }
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 1)
                {
                    #region Parametros -  Inventarios (ACS)
                    cmd.Parameters.Add(new SqlParameter("@periodoII", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@periodoHC", SqlDbType.Int));
                    cmd.Parameters["@periodoII"].Value = int.Parse(cmb_Period.EditValue.ToString());
                    cmd.Parameters["@periodoHC"].Value = chkContabilizado.Checked ? int.Parse(cmb_Period.EditValue.ToString()) : 0;

                    DBMS = "ACS";
                    SP = "RPT_Inventario_CostoPromedio";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 2)
                {
                    #region Parametros -  Consumos MP (ACS)
                    cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.DateTime));
                    cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.DateTime));
                    cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);

                    DBMS = "ACS";
                    SP = "RPT_FIN_ConsumoMP_Costo_v2";
                    //if (cmb_reports.SelectedIndex == 2) SP = "RPT_FIN_ConsumoMP_Costo"; //--else SP = "RPT_FIN_Formula_Resumen";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 3)
                {
                    #region Parametros -  Productos Terminados (ACS)
                    DBMS = "ACS";
                    SP = "RPT_FIN_ProdTerminado";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 4)
                {
                    if (!btn_periodo_fecha.IsOn)
                    {
                        #region Parametros -  Compras MP    ** Caso Especial ** (ACS) xPeriodo
                        cmd.Parameters.Add(new SqlParameter("@periodo_id", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@todo", SqlDbType.Bit));
                        cmd.Parameters["@periodo_id"].Value = int.Parse(cmb_Period.EditValue.ToString());
                        cmd.Parameters["@todo"].Value = chkContabilizado.Checked;

                        DBMS = "ACS";
                        SP = "RPT_FIN_ComprasMP";
                        #endregion
                    }
                    else
                    {
                        #region Parametros -  Compras MP    ** Caso Especial ** (ACS) xFechas
                        cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
                        cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
                        cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                        cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);

                        DBMS = "ACS";
                        SP = "RPT_FIN_ComprasMP_xFecha";
                        #endregion
                    }
                }
                if (cmb_reports.SelectedIndex == 5)
                {
                    #region Parametros -  Formula Teorico-Costo (ACS)
                    cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.DateTime));
                    cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.DateTime));
                    cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                    DBMS = "ACS";
                    SP = "RPT_FIN_FML_Teorico_Cost";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 6)
                {
                    #region Parametros -  Reporte de Compras General (Odoo)
                    DBMS = "ODOO";
                    qry  = qryDeclaMensCompras() ;
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 7)
                {
                    #region Parametros -  Por Orden Produccion (ACS)
                    cmd.Parameters.Add(new SqlParameter("@pp_code", SqlDbType.Text));
                    cmd.Parameters["@pp_code"].Value = "PP-"+ txt_Textbox.Text.PadLeft(7,'0') ;

                    DBMS = "ACS";
                    SP = "RPT_FIN_byOrden";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 8) // Compras DMC - CAI
                {
                    #region Parametros -  Compras DMC - CAI
                    DBMS = "ODOO2";
                    cmd2.Parameters.Add(new PgSqlParameter(":fecha_desde", DbType.Date));
                    cmd2.Parameters.Add(new PgSqlParameter(":fecha_hasta", DbType.Date));
                    cmd2.Parameters[":fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd2.Parameters[":fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                    SP = "x_sp_RPT_FIN_Compras_DMC_CAI";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 9) // Compras DMC - Otros
                {
                    #region Parametros -  Compras DMC - CAI (Otros)
                    DBMS = "ODOO2";
                    cmd2.Parameters.Add(new PgSqlParameter(":fecha_desde", DbType.Date));
                    cmd2.Parameters.Add(new PgSqlParameter(":fecha_hasta", DbType.Date));
                    cmd2.Parameters[":fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd2.Parameters[":fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                    SP = "x_sp_RPT_FIN_Compras_DMC_Otros";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 10)    // Compras Materias Primas + Gastos
                {
                    #region Compras Materias Primas + Gastos
                    if (!btn_periodo_fecha.IsOn)
                    {
                        #region Parametros -  Compras MP    ** Caso Especial ** (ACS) xPeriodo
                        cmd.Parameters.Add(new SqlParameter("@periodo_id", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@todo", SqlDbType.Bit));
                        cmd.Parameters["@periodo_id"].Value = int.Parse(cmb_Period.EditValue.ToString());
                        cmd.Parameters["@todo"].Value = chkContabilizado.Checked;

                        DBMS = "ACS";
                        SP = "RPT_FIN_ComprasMP_DetGasto";
                        #endregion
                    }
                    else
                    {
                        #region Parametros -  Compras MP    ** Caso Especial ** (ACS) xFechas
                        cmd.Parameters.Add(new SqlParameter("@fecha_desde", SqlDbType.Date));
                        cmd.Parameters.Add(new SqlParameter("@fecha_hasta", SqlDbType.Date));
                        cmd.Parameters["@fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                        cmd.Parameters["@fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);

                        DBMS = "ACS";
                        SP = "RPT_FIN_ComprasMP_xFecha_DetGasto";
                        #endregion

                    }
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 11)
                {
                    #region CxP Antiguedad de saldos (facturas abiertas) (Odoo)
                    DBMS = "ODOO";
                    qry = "Select * From x_view_AP_antiguedad_saldos ";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 12)
                {
                    #region CxP Antiguedad de saldos (facturas abiertas) - HIST (Odoo)
                    DBMS = "ODOO";
                    qry = String.Format("Select * From x_view_ap_invoice_report where fecha_fact between '{0}' and '{1}'", Convert.ToDateTime(dt_desde.EditValue).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt_hasta.EditValue).ToString("yyyy-MM-dd"));
                    #endregion
                }
                #endregion
                if (cmb_reports.SelectedIndex == 13) // Rep Pólizas de Contables (Odoo)
                {
                    #region Parametros -   Rep Pólizas de Contables (Odoo)
                    DBMS = "ODOO2";
                    cmd2.Parameters.Add(new PgSqlParameter(":fecha_desde", DbType.Date));
                    cmd2.Parameters.Add(new PgSqlParameter(":fecha_hasta", DbType.Date));
                    cmd2.Parameters[":fecha_desde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd2.Parameters[":fecha_hasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);
                    SP = "x_sp_RPT_FIN_Polizas_xFch";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 14) // Reporte Consolidado x CeCo Nomina (Odoo)
                {
                    #region Parametros -   Reporte Consolidado x CeCo Nomina (Odoo)
                    DBMS = "ODOO2";
                    cmd2.Parameters.AddWithValue(":par_id", id_seleccionado);
                    //cmd2.Parameters[":par_id"].Value = id_seleccionado;
                    SP = "x_sp_Rep_Cons_CeCo_xNomina";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 15)
                {
                    #region Reporte de información de empleados
                    DBMS = "ODOO";
                    //qry = @"   set client_encoding = 'UTF8';
                    //            SELECT  
                    //                a.x_noreferencia AS cod_Empleado
                    //                ,to_char(x_fechain::date, 'DD/MM/YYYY') AS fecha_contratacion
                    //                ,CASE WHEN a.country_id=97 THEN translate(identification_id, '-', '') ELSE passport_id END AS identificacion
                    //                ,name_related AS nombre
                    //                ,d.name AS puesto
                    //                ,e.name As departamento
                    //                ,g.wage AS salario
                    //                ,h.name AS tipo_planilla
                    //                ,COALESCE(f.bank_name,'Banco Atlántida') AS banco
                    //                ,f.acc_number AS cuenta_banco
                    //                ,c.code AS codigo_ceco
                    //                ,c.name AS centro_costo
                    //                ,CASE x_estadovicil WHEN '' THEN 'S' ELSE SUBSTRING(x_estadovicil,1,1) END AS estado_civil
                    //                ,CASE a.country_id WHEN 97 THEN 'HN' WHEN 64 THEN 'EC' ELSE '??' END AS pais
                    //                ,to_char(birthday::date, 'DD/MM/YYYY') AS fecha_nacimiento
                    //                ,upper(left(gender,1)) AS sexo
                    //                ,a.x_telefono AS no_telefono
                    //                ,a.x_numeroemer AS no_emergencia
                    //                ,a.x_contactoref AS contacto_emergencia
                    //                ,a.x_direccion
                    //                ,g.x_dependientes as dependientes
                    //                ,g.x_claseg as clase_seguro
                    //                ,g.medical_insurance as seguro_medico
                    //        FROM    hr_employee a
                    //                left join (SELECT  row_number() over(partition by employee_id order by date_start desc) as orden, * FROM hr_contract x) b on b.employee_id= a.id and b.orden=1
                    //                left join account_analytic_account c on b.analytic_account_id= c.id
                    //                left join hr_job d on a.job_id = d.id 
                    //                left join hr_department e on a.department_id = e.id
                    //                left join res_partner_bank f on a.bank_account_id = f.id
                    //                left join hr_contract g on a.id = g.employee_id AND g.x_status = true
                    //                left join hr_payroll_structure h on g.struct_id = h.id
                    //        WHERE   
                    //                x_fechain is not null and
                    //                b.date_end is null or b.date_end > current_date";
                    qry = "select * from admon.ft_resumen_general_empleados();";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 16) // Reporte Consolidado x Empleado Nomina (Odoo)
                {
                    #region Parametros -   Reporte Consolidado x CeCo Nomina (Odoo)
                    DBMS = "ODOO2";
                    cmd2.Parameters.AddWithValue(":par_id", id_seleccionado);
                    //cmd2.Parameters[":par_id"].Value = id_seleccionado;
                    SP = "x_sp_Rep_Cons_CeCo_xNomina_detail";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 17) // Reporte Acumulado de Compras por Rubros
                {
                    #region Parametros - Reporte Acumulado de Compras por Rubros

                    qry = String.Format("Select * From x_sp_rpt_acumulado_compras_rubros('{0}', '{1}');", Convert.ToDateTime(dt_desde.EditValue).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt_hasta.EditValue).ToString("yyyy-MM-dd"));
                    DBMS = "ODOO";
                    //SP = "x_sp_rpt_acumulado_compras_rubros";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 18)
                {
                    #region Reporte por Linea de Compra
                    DBMS = "ODOO";
                    qry = QueryStringDetalleCompraPorLinea();
                    #endregion  
                }
                if (cmb_reports.SelectedIndex == 19)
                {
                    #region Parametros - Activos (Odoo2)
                    if (radGrupo.SelectedIndex == 0)
                    {
                        #region Parametros - Activos (Maestro)
                        qry = "Select * From x_view_Activos_Maestro";
                        DBMS = "ODOO3";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 1)
                    {
                        #region Parametros - Activos (xPeriodo)
                        qry = String.Format(@" Select * From x_view_Activos_xPeriodo WHERE 
                                                date_part('year', depreciation_date) = {0} AND date_part('month', depreciation_date) = {1}
                                                AND state = 'open' "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO3";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 2)
                    {
                        #region Parametros - Activos (de baja)
                        qry = String.Format(@" Select * From x_view_activos_xperiodo_debaja WHERE asset_id
                                            NOT IN (
                                                SELECT A.id AS asset_id
                                                 FROM public.account_asset_asset A
                                                INNER JOIN public.account_asset_category B 
                                                   ON A.category_id = B.id
                                                 LEFT JOIN (SELECT asset_id
                                                                    ,SUM(amount) AS dep_acum
                                                               FROM public.account_asset_depreciation_line
                                                              WHERE move_check = true /*AND COALESCE(move_id, -1) >= 0*/
                                                             GROUP BY asset_id) C
                                                   ON A.id = C.asset_id
                                                INNER JOIN public.res_users D
                                                   ON A.create_uid = D.id
                                                INNER JOIN public.res_partner E
                                                   ON D.partner_id = E.id
                                                INNER JOIN public.res_users F
                                                   ON A.write_uid = F.id
                                                INNER JOIN public.res_partner G
                                                   ON F.partner_id = G.id
                                                INNER JOIN public.account_asset_depreciation_line H
                                                   ON H.asset_id = A.id
                                                INNER JOIN public.account_analytic_account I
                                                   ON A.account_analytic_id = I.id
                                                WHERE date_part('year', H.depreciation_date) = {0}
                                                  AND date_part('month', H.depreciation_date) = {1}
                                                  AND A.state = 'open'
                                            )
                                            "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO3";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 3)
                    {
                        #region Parametros - Activos (de alta)
                        qry = String.Format(@" Select * From x_view_Activos_xPeriodo WHERE 
                                                date_part('year', ""Fecha Compra"" ) = {0} AND date_part('month', ""Fecha Compra"") = {1}
                                                AND state = 'open' "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO3";
                        #endregion
                    }
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 20)
                {
                    #region Consumo Teorico MP
                    cmd.Parameters.Add(new SqlParameter("@DateDesde", SqlDbType.DateTime));
                    cmd.Parameters.Add(new SqlParameter("@Datehasta", SqlDbType.DateTime));
                    //cmd.Parameters["@DateDesde"].Value = string.Format("{0:MM/dd/yyyy HH:mm:ss}",dt_desde.EditValue);
                    //cmd.Parameters["@Datehasta"].Value = string.Format("{0:MM/dd/yyyy HH:mm:ss}",dt_hasta.EditValue);
                    cmd.Parameters["@DateDesde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd.Parameters["@Datehasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);

                    DBMS = "APMS";
                    SP = "RPT_PRD_Consumo_Teorico_MP";

                    #endregion
                }

                if (cmb_reports.SelectedIndex == 21)
                {
                    #region Parametros - Activos (Odoo3)
                    if (radGrupo.SelectedIndex == 0)
                    {
                        #region Parametros - Activos (Maestro)
                        qry = "Select * From x_view_activos_maestro_general";
                        DBMS = "ODOO";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 1)
                    {
                        #region Parametros - Activos (xPeriodo)
                        qry = String.Format(@" Select * 
                                               From x_view_Activos_xPeriodo 
                                               WHERE date_part('year', depreciation_date) = {0} AND date_part('month', depreciation_date) = {1} "
                                                //AND state = 'open' "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 2)
                    {
                        #region Parametros - Activos (de baja)
                        qry = String.Format(@" Select * 
                                               From x_view_activos_xperiodo_debaja 
                                               WHERE asset_id NOT IN (
                                                                        SELECT A.id AS asset_id
                                                                         FROM public.account_asset_asset A
                                                                        INNER JOIN public.account_asset_category B 
                                                                           ON A.category_id = B.id
                                                                         LEFT JOIN (SELECT asset_id
                                                                                            ,SUM(amount) AS dep_acum
                                                                                       FROM public.account_asset_depreciation_line
                                                                                      WHERE move_check = true /*AND COALESCE(move_id, -1) >= 0*/
                                                                                     GROUP BY asset_id) C
                                                                           ON A.id = C.asset_id
                                                                        INNER JOIN public.res_users D
                                                                           ON A.create_uid = D.id
                                                                        INNER JOIN public.res_partner E
                                                                           ON D.partner_id = E.id
                                                                        INNER JOIN public.res_users F
                                                                           ON A.write_uid = F.id
                                                                        INNER JOIN public.res_partner G
                                                                           ON F.partner_id = G.id
                                                                        INNER JOIN public.account_asset_depreciation_line H
                                                                           ON H.asset_id = A.id
                                                                        INNER JOIN public.account_analytic_account I
                                                                           ON A.account_analytic_id = I.id
                                                                        WHERE date_part('year', H.depreciation_date) = {0}
                                                                          AND date_part('month', H.depreciation_date) = {1}
                                                                    )
                                                                    "
                                                                        , spn_anio.Value
                                                                        , spn_mes.Value);
                        DBMS = "ODOO";
                        #endregion
                    }
                    if (radGrupo.SelectedIndex == 3)
                    {
                        #region Parametros - Activos (de alta)
                        qry = String.Format(@" Select * 
                                               From x_view_Activos_xPeriodo 
                                               WHERE date_part('year', ""Fecha Compra"" ) = {0} AND date_part('month', ""Fecha Compra"") = {1} "
                                                , spn_anio.Value
                                                , spn_mes.Value);
                        DBMS = "ODOO";
                        #endregion
                    }
                    #endregion
                }

                if (cmb_reports.SelectedIndex == 23)
                {
                    #region Parametros - Activos ALL DATA 
                   
                        #region Parametros - Activos (Maestro)
                        qry = "Select * From x_view_activos_maestro_general";
                        DBMS = "ODOO";
                        #endregion
                   
                    #endregion
                }

                if (cmb_reports.SelectedIndex == 24)
                {
                    #region Parametros -   Reporte Consolidado x CeCo Nomina (Odoo) Detalle por Empleado
                    qry = "select * from public.ft_recupera_detalle_cecos_planilla (:p_desde, :p_hasta);";

                    DataOperations dp1 = new DataOperations();
                    PgSqlConnection conn = new PgSqlConnection(dp1.ConnectionStringODOO);
                    PgSqlCommand cmdx = new PgSqlCommand(qry, conn);
                    cmdx.Parameters.Add("p_desde", PgSqlType.Date).Value = dt_desde.EditValue;
                    cmdx.Parameters.Add("p_hasta", PgSqlType.Date).Value = dt_hasta.EditValue;
                    if (dtDatos == null)
                        dtDatos = new DataTable();
                    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmdx);
                        adapter.Fill(dtDatos);
                    
                    //DBMS = "ODOO";
                    #endregion
                }
                if (cmb_reports.SelectedIndex == 25)
                {
                    
                    #region Parametros -   Reporte por rango de fechas de nominas pagadas
                        
                    qry = "select * from x_sp_rep_cons_ceco_xnomina_det_range (:p_desde, :p_hasta);";

                    DataOperations dp1 = new DataOperations();
                    PgSqlConnection conn = new PgSqlConnection(dp1.ConnectionStringODOO);
                    PgSqlCommand cmdx = new PgSqlCommand(qry, conn);
                    cmdx.Parameters.Add("p_desde", PgSqlType.Int).Value = Desde;
                    cmdx.Parameters.Add("p_hasta", PgSqlType.Int).Value = Hasta;
                    if (dtDatos == null)
                        dtDatos = new DataTable();
                    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmdx);
                    adapter.Fill(dtDatos);

                    //DBMS = "ODOO";
                    #endregion
                }

                //**** Reporte RRHH Oddo nuevo
                if (cmb_reports.SelectedIndex == 26)
                {

                    #region Parametros - Fecha Inicial y Final. reporte de devengado por CECO odoo nuevo

                    qry = "select * from public.fn_return_detail_ceco_devengado (:fechai, :fechaf);";

                    DataOperations dp1 = new DataOperations();
                    PgSqlConnection conn = new PgSqlConnection(dp1.ConnectionStringODOO5);
                    conn.Unicode = true;
                    PgSqlCommand cmdx = new PgSqlCommand(qry, conn);
                    cmdx.Parameters.Add("fechai", PgSqlType.Date).Value = dt_desde.EditValue;
                    cmdx.Parameters.Add("fechaf", PgSqlType.Date).Value = dt_hasta.EditValue;
                    if (dtDatos == null)
                        dtDatos = new DataTable();

                    dtDatos.Clear();
                    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmdx);
                    adapter.Fill(dtDatos);
                    //DBMS = "ODOO";
                    #endregion
                }

                //**** Reporte RRHH Oddo nuevo, detalle de deducciones por cuenta
                if (cmb_reports.SelectedIndex == 27)
                {

                    #region Parametros - Fecha Inicial y Final. reporte de detalle deducido por cuenta contable y empleado

                    qry = @"SELECT --MIN(pll.id) as id,
                                    --pl.id as payslip_id,
                                    pl.date_from as date_from,
                                    pl.date_to as date_to,
                                    --hc.type_id as contract_type,
                                    --pl.employee_id as employee_id,
				                    (select name
				                     from hr_employee
				                     where id = pl.employee_id) as empleado,
									emp.barcode,
                                    --plr.currency_id as currency_id,
				                    (SELECT name
				                     FROM public.res_currency
				                     where id = plr.currency_id),
                                    --plr.id as payslip_run_id,
                                    plr.state as state,
                                    --pll.salary_rule_id as salary_rule_id,
                                    pll.name as name,
                                    pll.total as total,
                                    --src.patronal as patronal,
                                    --pll.appears_on_payslip as appears_on_payslip,
                                    --emp.department_id as department_id,

                                    CASE WHEN src.patronal=True
                                        THEN (SELECT account_id from hr_accounting where salary_rule_id=pll.salary_rule_id and department_id=emp.department_id)
                                        ELSE pll.account_id
                                    END AS account_id,
									(select a1.name
									 from account_account a1 
									where a1.id = (
									
										CASE WHEN src.patronal=True
                                        THEN (SELECT account_id from hr_accounting where salary_rule_id=pll.salary_rule_id and department_id=emp.department_id)
                                        ELSE pll.account_id
                                    END 
									))as cuenta,
                                    /*CASE WHEN src.patronal=True
                                        THEN 
                                            (select aaa.id from hr_accounting ha,account_analytic_account aaa  where ha.salary_rule_id=pll.salary_rule_id and ha.department_id=emp.department_id 
                                            and 
                                            CASE 
                                            WHEN ha.analytic_type='analytic_by_department' 
                                                THEN (select analytic_department_account_id from hr_department where id=ha.department_id)
                                            WHEN ha.analytic_type='analytic_by_employee'
                                                THEN (select id from account_analytic_account where employee_id=emp.id)
                                            WHEN ha.analytic_type='analytic_by_contract_type'
                                                THEN (select id from account_analytic_account where contract_type=hc.type_id)
                                            END
                                            =aaa.id)

                                        ELSE
                                            pll.analytic_account_id
                                    END AS analytic_account_id,*/
				                    pll.note as descripcion
                    from hr_payslip_line pll
	                    join hr_payslip pl on pll.slip_id=pl.id
	                    left join hr_contract hc on pl.contract_id= hc.id
	                    left join hr_payslip_run plr on pl.payslip_run_id= plr.id 
	                    left join hr_employee emp on pl.employee_id=emp.id
	                    left join hr_salary_rule_category src on pll.category_id=src.id	
                    Where pll.code in( 'OTD','Apoyo Educat')
	                      and date_from Between :fechai and :fechaf
                    GROUP BY pll.id,
		                     pll.name,
		                     pl.id,
		                     pl.employee_id,
		                     emp.id,
		                     emp.department_id,
		                     hc.type_id,
		                     plr.currency_id,
		                     plr.id,
		                     plr.state,
		                     pll.total,
		                     pll.salary_rule_id,
		                     src.patronal,
		                     pll.appears_on_payslip
                    order by pll.name desc";

                    DataOperations dp1 = new DataOperations();
                    PgSqlConnection conn = new PgSqlConnection(dp1.ConnectionStringODOO5);
                    conn.Unicode = true;
                    PgSqlCommand cmdx = new PgSqlCommand(qry, conn);
                    cmdx.Parameters.Add("fechai", PgSqlType.Date).Value = dt_desde.EditValue;
                    cmdx.Parameters.Add("fechaf", PgSqlType.Date).Value = dt_hasta.EditValue;
                    if (dtDatos == null)
                        dtDatos = new DataTable();

                    dtDatos.Clear();
                    PgSqlDataAdapter adapter = new PgSqlDataAdapter(cmdx);
                    adapter.Fill(dtDatos);
                    //DBMS = "ODOO";
                    #endregion
                }


                if (cmb_reports.SelectedIndex == 28 )
                {
                    #region Reporte de Gastos 2023
                    qry = @"sp_reporte_de_gastos";
                  

                    DataOperations dp1 = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp1.ConnectionSAP_OnlySELECT);
                    conn.Open();
                    cmd = new SqlCommand(qry, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dt_inicial", dt_desde.EditValue);
                    cmd.Parameters.AddWithValue("@dt_final", dt_hasta.EditValue);
                    if (dtDatos == null)
                        dtDatos = new DataTable();
                    DBMS = "SAP";
                    dtDatos.Clear();
                    cmd.CommandTimeout = 500000;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtDatos);

                    #endregion
                }

                if (cmb_reports.SelectedIndex == 29)
                {
                    #region Consumo Teorico MP
                    cmd.Parameters.Add(new SqlParameter("@DateDesde", SqlDbType.DateTime));
                    cmd.Parameters.Add(new SqlParameter("@Datehasta", SqlDbType.DateTime));
                    //cmd.Parameters["@DateDesde"].Value = string.Format("{0:MM/dd/yyyy HH:mm:ss}",dt_desde.EditValue);
                    //cmd.Parameters["@Datehasta"].Value = string.Format("{0:MM/dd/yyyy HH:mm:ss}",dt_hasta.EditValue);
                    cmd.Parameters["@DateDesde"].Value = Convert.ToDateTime(dt_desde.EditValue);
                    cmd.Parameters["@Datehasta"].Value = Convert.ToDateTime(dt_hasta.EditValue);

                    DBMS = "ACS";
                    SP = "sp_reporte_de_ordenes_de_produccion";

                    #endregion
                }


                if (cmb_reports.SelectedIndex == 30)
                {
                    #region Consumo Teorico MP
                    cmd.Parameters.Add(new SqlParameter("@DateDesde", SqlDbType.DateTime));
                    //cmd.Parameters["@DateDesde"].Value = string.Format("{0:MM/dd/yyyy HH:mm:ss}",dt_desde.EditValue);
                    //cmd.Parameters["@Datehasta"].Value = string.Format("{0:MM/dd/yyyy HH:mm:ss}",dt_hasta.EditValue);
                    cmd.Parameters["@DateDesde"].Value = Convert.ToDateTime(dt_desde.EditValue);

                    DBMS = "ACS";
                    SP = "sp_get_reporte_of_inventory_sap";

                    #endregion
                }

                #region Ejecutando SP
                if (DBMS == "ACS")  dtDatos = dp.ACS_Exec_SP_Get_Data(SP, cmd);
                if (DBMS == "APMS") dtDatos = dp.APMS_Exec_SP_Get_Data(SP, cmd);
                if (DBMS == "ODOO") dtDatos = dp.ODOO_GetSelectData(qry).Tables[0];
                if (DBMS == "ODOO2") dtDatos = dp.ODOO_GetSP_Results(SP, cmd2).Tables[0];
                if (DBMS == "ODOO3") dtDatos = dp.ODOO2_GetSP_Results(qry, cmd2).Tables[0];
              //  if (DBMS == "SAP") dtDatos = dp.SAP_Exec_SP_Get_Data(qry, cmd);
                #endregion

                generar_totales_grid();
                //grd_data.DataSource = dtDatos;
                //grid_autoajustar();
                //pnl_barra.Visible = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private string QueryStringDetalleCompraPorLinea()
        {
            string sql = @"SELECT A.id
                                    ,A.partner_id AS id_proveedor
                                    ,C.vat AS RTN_proveedor
                                    ,C.name AS nombre_proveedor
                                    ,A.date_invoice AS fecha_factura_prov
                                    ,A.supplier_invoice_number AS numero_factura_prov
                                    ,E.name AS orden_compra_Interno
                                    ,COALESCE(E.x_dei,0) AS orden_compra_DEI
                                    ,'DGCFA-RNO-EISV-032-2016' AS resolucion
                                    ,'EV-RNO-326-2015' AS expediente
                                    ,'01/28/2016' AS fecha_resolucion
                                    ,A.amount_untaxed AS importe_excento
                                    ,COALESCE(A.amount_tax,0) AS importe_ISV15
                                    ,0.00 AS importe_ISV18
                                    ,(CASE COALESCE(E.x_dei, 0) WHEN 0 THEN 0 ELSE (A.amount_untaxed * 0.15) END) AS Credito_Fiscal_ISV15
                                    ,0 AS Credito_Fiscal_ISV18
                                    ,(L.quantity * L.price_unit) as total_linea
                                    ,A.currency_id AS id_moneda
                                    ,B.name AS moneda_factura
                                    ,COALESCE(G.x_fecha,A.date_invoice) AS fecha_tasa
                                    ,COALESCE(G.rate, -1) AS tasa_cambio_segun_fecha
                                    ,(CASE A.currency_id WHEN 45 THEN 1 ELSE COALESCE(G.rate, -1) END) AS tasa_cambio_factura
                                    ,A.number AS numero_factura_interno
                                    ,A.comment AS comentario_factura
                                    ,A.date_due AS fecha_vencimiento
                                    ,A.origin AS origen_factura
                                    ,D.origin AS origen_picking
                                    ,A.period_id AS periodo_id
                                    ,F.name AS periodo_contable
                                    ,(CASE A.state WHEN 'paid' THEN 'Pagada' WHEN 'open' THEN 'Abierta' ELSE 'N/A' END) AS estado_factura,
                                    L.quantity,
                                    L.price_unit,
                                    p.name_template
                               FROM public.account_invoice A
                                    INNER JOIN public.res_currency B
                                       ON A.currency_id = B.id
                                    INNER JOIN public.res_partner C
                                       ON A.partner_id = C.id
                                    INNER JOIN public.stock_picking D
                                       ON D.invoice_id = A.id
                                    INNER JOIN public.purchase_order E
                                       ON D.origin = E.name
                                    INNER JOIN public.account_period F
                                       ON A.period_id = F.id
                                     LEFT OUTER JOIN public.res_currency_rate G
                                       ON (A.date_invoice = G.x_fecha) 
                                    join public.account_invoice_line L 
                                        on A.id = L.invoice_id 
                                    join public.product_product p 
                                        on p.id = L.product_id
                                    WHERE A.journal_id IN (2,21,33)
                                      AND A.date_invoice between '" + Convert.ToDateTime(dt_desde.EditValue).ToString("yyyy-MM-dd") + "' and '"+ Convert.ToDateTime(dt_hasta.EditValue).ToString("yyyy-MM-dd")+ "' " +
                                      "AND A.state in ('open','paid') "+
                                      "AND D.reception_to_invoice = true " +

                                    "UNION ALL "+

                                    @"SELECT A.id
                                           ,A.partner_id AS id_proveedor
                                           ,C.vat AS RTN_proveedor
                                           ,C.name AS nombre_proveedor
                                           ,A.date_invoice AS fecha_factura_prov
                                           ,A.supplier_invoice_number AS numero_factura_prov
                                           ,'N/A' AS orden_compra_Interno
                                           ,0 AS orden_compra_DEI
                                           ,'DGCFA-RNO-EISV-032-2016' AS resolucion
                                           ,'EV-RNO-326-2015' AS expediente
                                           ,'01/28/2016' AS fecha_resolucion
                                           ,A.amount_untaxed AS importe_excento
                                           ,COALESCE(A.amount_tax,0) AS importe_ISV15
                                           ,0.00 AS importe_ISV18
                                           ,0 AS Credito_Fiscal_ISV15
                                           ,0 AS Credito_Fiscal_ISV18
                                           ,A.amount_total AS total_factura
                                           ,A.currency_id AS id_moneda
                                           ,B.name AS moneda_factura
                                           ,COALESCE(G.x_fecha,A.date_invoice) AS fecha_tasa
                                           ,COALESCE(G.rate, -1) AS tasa_cambio_segun_fecha
                                           ,(CASE A.currency_id WHEN 45 THEN 1 ELSE COALESCE(G.rate, -1) END) AS tasa_cambio_factura
                                           ,A.number AS numero_factura_interno
                                           ,A.comment AS comentario_factura
                                           ,A.date_due AS fecha_vencimiento
                                           ,COALESCE(A.origin,'N/A') AS origen_factura
                                           ,'N/A' AS origen_picking
                                           ,A.period_id AS periodo_id
                                           ,D.name AS periodo_contable
                                           ,(CASE A.state WHEN 'paid' THEN 'Pagada' WHEN 'open' THEN 'Abierta' ELSE 'N/A' END) AS estado_factura,
                                           L.quantity,
                                           L.price_unit,
                                           p.name_template
                                      FROM public.account_invoice A
                                     INNER JOIN public.res_currency B
                                        ON A.currency_id = B.id
                                     INNER JOIN public.res_partner C
                                        ON A.partner_id = C.id
                                     INNER JOIN public.account_period D
                                        ON A.period_id = D.id
                                      LEFT OUTER JOIN public.res_currency_rate G
                                        ON (A.date_invoice = G.x_fecha)
                                    join public.account_invoice_line L 
                                        on A.id = L.invoice_id 
                                    join public.product_product p 
                                        on p.id = L.product_id
                                     WHERE A.journal_id IN (2,21,33)
                                       AND A.date_invoice between '"+ Convert.ToDateTime(dt_desde.EditValue).ToString("yyyy-MM-dd") + "' and '"+ Convert.ToDateTime(dt_hasta.EditValue).ToString("yyyy-MM-dd")+ "' " +
                                       @"AND A.state in ('open','paid')
                                       AND A.id NOT IN (SELECT A.id
                                                            FROM public.account_invoice A
                                                           INNER JOIN public.res_currency B
                                                              ON A.currency_id = B.id
                                                           INNER JOIN public.res_partner C
                                                              ON A.partner_id = C.id
                                                           INNER JOIN public.stock_picking D
                                                              ON D.invoice_id = A.id
                                                           INNER JOIN public.purchase_order E
                                                              ON D.origin = E.name
                                                           INNER JOIN public.account_period F
                                                              ON A.period_id = F.id
                                                            LEFT OUTER JOIN public.res_currency_rate G
                                                              ON (A.date_invoice = G.x_fecha)
                                                           WHERE A.journal_id IN (2,21,33)
                                                             AND A.date_invoice between '"+ Convert.ToDateTime(dt_desde.EditValue).ToString("yyyy-MM-dd") + "' and '"+ Convert.ToDateTime(dt_hasta.EditValue).ToString("yyyy-MM-dd")+ "'" +
                                                             @"AND A.state in ('open','paid')
                                                               AND D.reception_to_invoice = true)";

            return sql;
        }

        private bool user_has_access(string access_group) 
        {
            try
            {
                bool has_access = false;
                foreach(DataRow row in UserGroups.Rows) 
                {
                    if (row["GroupName"].ToString() == access_group)
                    {
                        has_access = true;
                        break;
                    }
                    else
                    {
                        CajaDialogo.Error("No tiene el acceso: access_rpt_finance");
                    }
                }

                return has_access;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(string.Format("Error\n\nDetalle: {0}\n\nStacktrace: {1}", ex.Message, ex.StackTrace), "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void cargarPeriodos()
        {
            //Comentado Danys Oliva 29 julio 2021
            //Ya no necesitamos nada de odoo
            //try
            //{
            //    cmb_Period.Properties.DataSource = dp.ODOO_GetSelectData(@"SELECT * 
            //                                                            FROM (SELECT A.id
            //                                                            , A.NAME AS period
            //                                                            , B.NAME AS fiscalyear 
            //                                                            FROM PUBLIC.account_period A INNER JOIN PUBLIC.account_fiscalyear B ON A.fiscalyear_id = B.id order
            //                                                            by a.date_stop desc limit 15) t order by fiscalyear desc, period desc").Tables[0];
            //    cmb_Period.ItemIndex = 0;
            //}
            //catch (Exception ex) { MessageBox.Show(string.Format("Error\n\nDetalle: {0}\n\nStacktrace: {1}", ex.Message, ex.StackTrace), "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void cargarPeriodos_acs()
        {
            try
            {
                cmb_Period.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT DISTINCT COALESCE(A.[period_id], -1) AS id, COALESCE(A.[period_name], 'No Contabilizadas') AS period FROM [dbo].[FIN_Costos_HC_Header] A").Tables[0];
                cmb_Period.ItemIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(string.Format("Error\n\nDetalle: {0}\n\nStacktrace: {1}", ex.Message, ex.StackTrace), "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void inicializar_grid()
        {
            grd_data.DataSource = null;
            grdv_data.Columns.Clear();
            lbl_desde.Text = "Desde";

            lbl_hasta.Visible = true;
            dt_hasta.Visible = true;
        }
        void inicializar_grid_v2()
        {
            grd_data.DataSource = null;
            grdv_data.Columns.Clear();
        }

        void grid_autoajustar()
        {
            grdv_data.OptionsView.ColumnAutoWidth = false;
            grdv_data.BestFitColumns();
            GridViewInfo viewInfo = grdv_data.GetViewInfo() as GridViewInfo;
            if (viewInfo.ViewRects.ColumnTotalWidth < viewInfo.ViewRects.ColumnPanelWidth)
                grdv_data.OptionsView.ColumnAutoWidth = true;
        }

        //-----------------------------------------------------------------------------------------------


        // Metodos --------------------------------------------------------------------------------------
        private void RPT_Conta_Varios_Load(object sender, EventArgs e)
        {
            cargarPeriodos();
            //pnl_Textbox.Dock = DockStyle.Fill;
            //pnl_fechas.Dock  = DockStyle.Fill;
            //grdv_data.Editable = false;
        }

        private void cmb_reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Ocultando todo...
            id_seleccionado = 0;

            radGrupo.Visible = false;                                                                            // Datos: Año y Mes
            chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = false;                         // Datos: Periodo
                                                                                                                 //lbl_anio.Visible = spn_anio.Visible = spn_mes.Visible = true;                                        // Año y Mes
            pnl_anio_mes.Visible = false;
            pnl_fechas.Visible = false;                                                                          // Rango de Fechas
            dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            pnl_Textbox.Visible = false;
            cargarPeriodos();
            chkContabilizado.Text = "Contabilizado";
            pnl_periodo_fecha.Visible = false;
            btn_Seleccionar.Visible = false;
            txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btn_GenReport.Enabled = true;
            #endregion
            txt_ErrorMessage.Caption = "No tienes acceso al reporte seleccionado.";
            #region Habilitando Parametros Segun Tipo-Reporte
            if (cmb_reports.SelectedIndex == 0) // Reporte Activos Fijos
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        radGrupo.Visible = true; //Datos: Año y Mes
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        radGrupo.Visible = true; //Datos: Año y Mes
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 1)   // Reporte Inventarios MP
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = true; // Datos: Periodo
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = true; // Datos: Periodo
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 2)  // Reporte Consumo MP
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true;  // Rango de Fechas
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }

                
            }
            else if (cmb_reports.SelectedIndex == 3)  // Reporte Producto Terminado
            {

                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        // Producto terminado no pide parametros
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        // Producto terminado no pide parametros
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
               
            }
            else if (cmb_reports.SelectedIndex == 4 || cmb_reports.SelectedIndex == 10) //Reporte de Compra Materia Prima & Reporte Compra Materia Prima con detalle de gastos.
            {

                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        #region Compra Materia Prima
                        if (!btn_periodo_fecha.IsOn)
                        {
                            #region porPeriodo
                            chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = true;                          // Datos: Periodo
                            chkContabilizado.Text = "Todo";
                            chkContabilizado.ToolTip = "Contabilizado y No contabilizado.";
                            cargarPeriodos_acs();
                            #endregion
                        }
                        #endregion
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_periodo_fecha.Visible = true;

                        #region Compra Materia Prima
                        if (!btn_periodo_fecha.IsOn)
                        {
                            #region porPeriodo
                            chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = true;                          // Datos: Periodo
                            chkContabilizado.Text = "Todo";
                            chkContabilizado.ToolTip = "Contabilizado y No contabilizado.";
                            cargarPeriodos_acs();
                            #endregion
                        }
                        #endregion
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }

            }
            else if (cmb_reports.SelectedIndex == 5) // Reporte Formula Teorico-Costo
            {
                //if (user_has_access("app_acs_rpt_finance"))
                //if (UsuarioLogeado.ValidarNivelPermisos(87))
                //{
                //    pnl_fechas.Visible = true; // Rango de Fechas
                //}
                //else
                //{
                //    btn_GenReport.Enabled = false;
                //    txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //    CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                //}

                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true; // Rango de Fechas  
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        //accesoprevio = true;
                        pnl_fechas.Visible = true; // Rango de Fechas 
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                    
                }
            }
            else if (cmb_reports.SelectedIndex == 6)  // Declaración Mensual Compras
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        break;
                    default:
                        break;
                }
                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                    
                 
            }
            else if (cmb_reports.SelectedIndex == 7)  // Reporte por No. Orden (TextBox)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        #region Por Ordene de Produccion
                        pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                        lbl_Textbox.Text = "Orden de Producción:";                                          // Por Orden de Produccion
                        txt_Textbox.Properties.Mask.EditMask = "0000000";
                        txt_Textbox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txt_Textbox.ReadOnly = false;
                        //txt_Textbox.Properties.Mask.EditMask = "PP-0000000";
                        //txt_Textbox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx; // .Numeric; // MaskType.Numeric;
                        #endregion
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        #region Por Ordene de Produccion
                        pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                        lbl_Textbox.Text = "Orden de Producción:";                                          // Por Orden de Produccion
                        txt_Textbox.Properties.Mask.EditMask = "0000000";
                        txt_Textbox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txt_Textbox.ReadOnly = false;
                        //txt_Textbox.Properties.Mask.EditMask = "PP-0000000";
                        //txt_Textbox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx; // .Numeric; // MaskType.Numeric;
                        #endregion
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }

                //if (user_has_access("app_acs_rpt_finance"))
                
            }
            else if (cmb_reports.SelectedIndex == 8 || cmb_reports.SelectedIndex == 9)   // "Compras DMC - CAI" o "Compras DMC - Otros"
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true; // Rango de Fechas
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true; // Rango de Fechas
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }

                
            }
            else if (cmb_reports.SelectedIndex == 11)  // Reporte CxP Antiguedad de saldos (facturas abiertas) **  Sin parametros ***
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        //Reporte no pide parametros
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        //Reporte no pide parametros
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
            }
            else if (cmb_reports.SelectedIndex == 12)  // Reporte CxP Antiguedad de saldos (facturas abiertas) Historico
            {

                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }
                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 13)  // Rep Pólizas de Contables
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 14)    // Reporte Consolidado x CeCo Nomina (Odoo)
            {

                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        #region Reporte Consolidado x CeCo Nomina (Odoo)
                        pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                        lbl_Textbox.Text = "Seleccione Nomina:";
                        txt_Textbox.Text = "";
                        txt_Textbox.ReadOnly = true;

                        btn_Seleccionar.Visible = true;
                        #endregion
                        break;
                    default:
                        break;
                }

                //if (user_has_access("app_acs_rpt_hr"))
                if (UsuarioLogeado.ValidarNivelPermisos(5))
                {
                    #region Reporte Consolidado x CeCo Nomina (Odoo)
                    pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                    lbl_Textbox.Text = "Seleccione Nomina:";
                    txt_Textbox.Text = "";
                    txt_Textbox.ReadOnly = true;

                    btn_Seleccionar.Visible = true;
                    #endregion
                }
                else
                {

                    //Boton de Facturacion Grupo
                    if (UsuarioLogeado.ValidarNivelPermisos(5) || UsuarioLogeado.IsSuperUser)
                    {
                        #region Reporte Consolidado x CeCo Nomina (Odoo)
                        pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                        lbl_Textbox.Text = "Seleccione Nomina:";
                        txt_Textbox.Text = "";
                        txt_Textbox.ReadOnly = true;

                        btn_Seleccionar.Visible = true;
                        #endregion
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 5");
                    }
                }
            }
            else if (cmb_reports.SelectedIndex == 15)  // Reporte Información Empleados
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        // Este reporte no requiere parametros
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_hr"))
                    if (UsuarioLogeado.ValidarNivelPermisos(5))
                    {
                        // Este reporte no requiere parametros
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 5");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 16)    // Reporte Consolidado x Empleado Nomina (Odoo)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        #region Reporte Consolidado x CeCo Nomina (Odoo)
                        pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                        lbl_Textbox.Text = "Seleccione Nomina:";
                        txt_Textbox.Text = "";
                        txt_Textbox.ReadOnly = true;

                        txt_Textbox.Visible = lbl_Textbox.Visible = btn_Seleccionar.Visible = true;
                        #endregion
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_hr"))
                    if (UsuarioLogeado.ValidarNivelPermisos(5))
                    {
                        #region Reporte Consolidado x CeCo Nomina (Odoo)
                        pnl_Textbox.Visible = true; pnl_Textbox.Dock = DockStyle.Fill;
                        lbl_Textbox.Text = "Seleccione Nomina:";
                        txt_Textbox.Text = "";
                        txt_Textbox.ReadOnly = true;

                        txt_Textbox.Visible = lbl_Textbox.Visible = btn_Seleccionar.Visible = true;
                        #endregion
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 5");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 17)// Reporte Acumulado de Compras por Rubros (Odoo)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_procurement"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 18)// Reporte Acumulado de Compras por Rubros (Odoo)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        pnl_fechas.Visible = true;  // Rango de Fechas
                        dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                        dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;    // Ocultando la hora..
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
            }
            else if (cmb_reports.SelectedIndex == 19) // Reporte Activos Fijos Fiscales
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        radGrupo.Visible = true; //Datos: Año y Mes
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        radGrupo.Visible = true; //Datos: Año y Mes
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 20) //Consumos teoricos MP
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(18))
                    {
                        /*radGrupo.Visible = true*//*; *///Datos: Año y Mes
                        pnl_fechas.Visible = true;

                    }
                    else
                    {
                        pnl_fechas.Visible = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 18");
                    }
                }
            }
            else if (cmb_reports.SelectedIndex == 21) // Reporte Activos Fijos Fiscales
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        radGrupo.Visible = true; //Datos: Año y Mes
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        radGrupo.Visible = true; //Datos: Año y Mes
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 22) // Reporte Activos Fijos Fiscales
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        Formulas.FML_Costeo_Formulas cf = new Formulas.FML_Costeo_Formulas();
                        cf.Show();
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        Formulas.FML_Costeo_Formulas cf = new Formulas.FML_Costeo_Formulas();
                        cf.Show();
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 23) // Reporte Activos Fijos Fiscales
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        //radGrupo.Visible = true; //Datos: Año y Mes
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    //if (user_has_access("app_acs_rpt_finance"))
                    if (UsuarioLogeado.ValidarNivelPermisos(87))
                    {
                        //radGrupo.Visible = true; //Datos: Año y Mes
                    }
                    else
                    {
                        btn_GenReport.Enabled = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 87");
                    }
                }
                
            }
            else if (cmb_reports.SelectedIndex == 24) // Reporte Activos Fijos Fiscales
            {

                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(21) || UsuarioLogeado.IsSuperUser)
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        pnl_fechas.Visible = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 21");
                    }
                }

            }
            else if (cmb_reports.SelectedIndex == 25)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        RPT_seleccion SEL = new RPT_seleccion();
                        if (SEL.ShowDialog() == DialogResult.OK)
                        {
                            Desde = SEL.PDesde;
                            Hasta = SEL.PHasta;

                        }
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(24) || UsuarioLogeado.IsSuperUser)
                    {
                        if (cmb_reports.SelectedIndex == 25)
                        {
                            RPT_seleccion SEL = new RPT_seleccion();
                            if (SEL.ShowDialog() == DialogResult.OK)
                            {
                                Desde = SEL.PDesde;
                                Hasta = SEL.PHasta;

                            }
                        }
                    }
                    else
                    {
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 24");
                    }
                }

                #endregion
                inicializar_grid();
            }
            else if (cmb_reports.SelectedIndex == 26)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {

                    if (UsuarioLogeado.ValidarNivelPermisos(59) || UsuarioLogeado.IsSuperUser)
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        pnl_fechas.Visible = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 59");
                    }
                }

                inicializar_grid();
            }
            else if (cmb_reports.SelectedIndex == 27)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(59) || UsuarioLogeado.IsSuperUser)
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        pnl_fechas.Visible = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 59");
                    }
                }

                inicializar_grid();
            }
            else if(cmb_reports.SelectedIndex == 28) //Reporte de Gastos SAP
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(62) || UsuarioLogeado.IsSuperUser)
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        pnl_fechas.Visible = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 62");
                    }
                }

                
                inicializar_grid();
            }
            else if (cmb_reports.SelectedIndex == 29)
            {
                bool accesoprevio = false;
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                switch (idNivel)
                {
                    case 1://Basic View
                        break;
                    case 2://Basic No Autorization
                        break;
                    case 3://Medium Autorization
                        break;
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        accesoprevio = true;
                        pnl_fechas.Visible = true;
                        break;
                    default:
                        break;
                }

                if (!accesoprevio)
                {
                    if (UsuarioLogeado.ValidarNivelPermisos(63) || UsuarioLogeado.IsSuperUser)
                    {
                        pnl_fechas.Visible = true;
                    }
                    else
                    {
                        pnl_fechas.Visible = false;
                        txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 63");
                    }
                }

                
                inicializar_grid();
            }
            else if (cmb_reports.SelectedIndex == 30)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(79) || UsuarioLogeado.IsSuperUser)
                {
                    pnl_fechas.Visible = true;
                    lbl_hasta.Visible = false;
                    dt_hasta.Visible = false;
                    lbl_desde.Text = "Hasta";
                }
                else
                {
                    pnl_fechas.Visible = false;
                    txt_ErrorMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    CajaDialogo.Error("Usted no cuenta con los privilegios para generar este reporte! Permiso requerido Standar #: 79");
                }
                inicializar_grid_v2();
            }
        }

        private void radGrupo_EditValueChanged(object sender, EventArgs e)
        {
            if(radGrupo.Visible= true & radGrupo.SelectedIndex > 0) pnl_anio_mes.Visible = false;
        }

        private void radGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radGrupo.Visible == true)
            {
                pnl_anio_mes.Visible = radGrupo.SelectedIndex > 0 ? true : false;
                inicializar_grid();
            }
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
                #region AutorRow_Color_Diferente
                if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                {
                    e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
                }
                #endregion
        }
        //-----------------------------------------------------------------------------------------------




        //--------------------------------------  ++++ ---- ++++ --------------------------------------//
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            cargar_grid();
            //Thread.Sleep(10000);
        }
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnl_barra.Visible = false; 
            btn_GenReport.Enabled = btn_Exportar.Enabled = btn_Impresion.Enabled = pnl_parametros.Enabled= true;
            grd_data.DataSource = dtDatos;
            grid_autoajustar();

            generar_totales_grid();
            //GridViewOptionsBehavior.ReadOnly 
        }
        //--------------------------------------  ++++ ---- ++++ --------------------------------------//


        String qryDeclaMensCompras()
        {
            // Porque lo hice así?, porque no he encontrado como hacer un "SP" un query como este. JV.
            String qry = String.Format(@"
                        SELECT A.id
                               ,A.partner_id AS id_proveedor
                               ,C.vat AS RTN_proveedor
                               ,C.name AS nombre_proveedor
                               ,A.date_invoice AS fecha_factura_prov
                               --,'N/A' AS CAI
                               ,A.supplier_invoice_number AS numero_factura_prov
                               ,E.name AS orden_compra_Interno
                               ,COALESCE(E.x_dei,0) AS orden_compra_DEI
                               ,'DGCFA-RNO-EISV-032-2016' AS resolucion
                               ,'EV-RNO-326-2015' AS expediente
                               ,'01/28/2016' AS fecha_resolucion
                               ,A.amount_untaxed AS importe_excento
                               ,COALESCE(A.amount_tax,0) AS importe_ISV15
                               ,0.00 AS importe_ISV18
                               ,(CASE COALESCE(E.x_dei, 0) WHEN 0 THEN 0 ELSE (A.amount_untaxed * 0.15) END) AS Credito_Fiscal_ISV15
                               ,0 AS Credito_Fiscal_ISV18
                               ,A.amount_total AS total_factura
                               ,A.currency_id AS id_moneda
                               ,B.name AS moneda_factura
                               ,COALESCE(G.x_fecha,A.date_invoice) AS fecha_tasa
                               ,COALESCE(G.rate, -1) AS tasa_cambio_segun_fecha
                               ,(CASE A.currency_id WHEN 45 THEN 1 ELSE COALESCE(G.rate, -1) END) AS tasa_cambio_factura
                               ,A.number AS numero_factura_interno
                               ,A.comment AS comentario_factura
                               ,A.date_due AS fecha_vencimiento
                               ,A.origin AS origen_factura
                               ,D.origin AS origen_picking
                               ,A.period_id AS periodo_id
                               ,F.name AS periodo_contable
                               ,(CASE A.state WHEN 'paid' THEN 'Pagada' WHEN 'open' THEN 'Abierta' ELSE 'N/A' END) AS estado_factura
                          FROM public.account_invoice A
                         INNER JOIN public.res_currency B
                            ON A.currency_id = B.id
                         INNER JOIN public.res_partner C
                            ON A.partner_id = C.id
                         INNER JOIN public.stock_picking D
                            ON D.invoice_id = A.id
                         INNER JOIN public.purchase_order E
                            ON D.origin = E.name
                         INNER JOIN public.account_period F
                            ON A.period_id = F.id
                          LEFT OUTER JOIN public.res_currency_rate G
                            ON (A.date_invoice = G.x_fecha)
                         WHERE A.journal_id IN (2,21,33)
                           AND A.date_invoice between '{0}' and '{1}'   --->= to_date('2016-03-16','yyyy-MM-dd') and A.date_invoice <= to_date('2016-03-31','yyyy-MM-dd')
                           AND A.state in ('open','paid')
                           AND D.reception_to_invoice = true
                        UNION ALL
                        SELECT A.id
                               ,A.partner_id AS id_proveedor
                               ,C.vat AS RTN_proveedor
                               ,C.name AS nombre_proveedor
                               ,A.date_invoice AS fecha_factura_prov
                               --,'N/A' AS CAI
                               ,A.supplier_invoice_number AS numero_factura_prov
                               ,'N/A' AS orden_compra_Interno
                               ,0 AS orden_compra_DEI
                               ,'DGCFA-RNO-EISV-032-2016' AS resolucion
                               ,'EV-RNO-326-2015' AS expediente
                               ,'01/28/2016' AS fecha_resolucion
                               ,A.amount_untaxed AS importe_excento
                               ,COALESCE(A.amount_tax,0) AS importe_ISV15
                               ,0.00 AS importe_ISV18
                               ,0 AS Credito_Fiscal_ISV15
                               ,0 AS Credito_Fiscal_ISV18
                               ,A.amount_total AS total_factura
                               ,A.currency_id AS id_moneda
                               ,B.name AS moneda_factura
                               ,COALESCE(G.x_fecha,A.date_invoice) AS fecha_tasa
                               ,COALESCE(G.rate, -1) AS tasa_cambio_segun_fecha
                               ,(CASE A.currency_id WHEN 45 THEN 1 ELSE COALESCE(G.rate, -1) END) AS tasa_cambio_factura
                               ,A.number AS numero_factura_interno
                               ,A.comment AS comentario_factura
                               ,A.date_due AS fecha_vencimiento
                               ,COALESCE(A.origin,'N/A') AS origen_factura
                               ,'N/A' AS origen_picking
                               ,A.period_id AS periodo_id
                               ,D.name AS periodo_contable
                               ,(CASE A.state WHEN 'paid' THEN 'Pagada' WHEN 'open' THEN 'Abierta' ELSE 'N/A' END) AS estado_factura
                          FROM public.account_invoice A
                         INNER JOIN public.res_currency B
                            ON A.currency_id = B.id
                         INNER JOIN public.res_partner C
                            ON A.partner_id = C.id
                         INNER JOIN public.account_period D
                            ON A.period_id = D.id
                          LEFT OUTER JOIN public.res_currency_rate G
                            ON (A.date_invoice = G.x_fecha)
                         WHERE A.journal_id IN (2,21,33)
                           AND A.date_invoice between '{0}' and '{1}'   -->= to_date('2016-03-16','yyyy-MM-dd') and A.date_invoice <= to_date('2016-03-31','yyyy-MM-dd')
                           AND A.state in ('open','paid')
                           AND A.id NOT IN (SELECT A.id
                                                FROM public.account_invoice A
                                               INNER JOIN public.res_currency B
                                                  ON A.currency_id = B.id
                                               INNER JOIN public.res_partner C
                                                  ON A.partner_id = C.id
                                               INNER JOIN public.stock_picking D
                                                  ON D.invoice_id = A.id
                                               INNER JOIN public.purchase_order E
                                                  ON D.origin = E.name
                                               INNER JOIN public.account_period F
                                                  ON A.period_id = F.id
                                                LEFT OUTER JOIN public.res_currency_rate G
                                                  ON (A.date_invoice = G.x_fecha)
                                               WHERE A.journal_id IN (2,21,33)
                                                 AND A.date_invoice between '{0}' and '{1}'     -->= to_date('2016-03-16','yyyy-MM-dd') and A.date_invoice <= to_date('2016-03-31','yyyy-MM-dd')
                                                 AND A.state in ('open','paid')
                                                 AND D.reception_to_invoice = true)
                ", Convert.ToDateTime(dt_desde.EditValue).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt_hasta.EditValue).ToString("yyyy-MM-dd"));
            return qry;
        }

        private void lbl_desde_Click(object sender, EventArgs e)
        {

        }

        private void btn_periodo_fecha_EditValueChanged(object sender, EventArgs e)
        {
            if (btn_periodo_fecha.IsOn)
            {
                pnl_fechas.Visible        = true;
                //pnl_periodo_fecha.Dock = DockStyle.Left;
                chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = false;
            }
            else {
                pnl_fechas.Visible        = false;
                chkContabilizado.Visible = cmb_Period.Visible = lbl_periodo.Visible = true;
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if (cmb_reports.SelectedIndex == 14 || cmb_reports.SelectedIndex == 16)    // Reporte Consolidado x CeCo Nomina (Odoo)
            {
                #region Reporte Consolidado x CeCo Nomina (Odoo) -- Seleccionar --
                //string query = "SELECT id as ID, name as Nomina FROM hr_payslip_run where name not like '%extras%' order by date_end desc limit 24;";
                string query = "SELECT id as ID, name as Nomina FROM hr_payslip_run order by date_end desc;";
                MigracionACS.ADVD.DeveloperTools.Select_Items_v3 form = new MigracionACS.ADVD.DeveloperTools.Select_Items_v3("ODOO", query);

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    id_seleccionado = form.getID;
                    txt_Textbox.Text = Convert.ToString(form.getCol1);
                }

                #endregion
            }

        }

        void generar_totales_grid() {
            //grdv_data.Columns["basico"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "basico", "{0:#.##}");
            //grdv_data.OptionsView.ShowFooter = true;
            
            if (cmb_reports.SelectedIndex == 14) // Reporte Consolidado x CeCo Nomina (Odoo)
                foreach (GridColumn item in grdv_data.Columns)
                {
                    //if (item == gridView1.Columns["<SomeColumnName>"])
                    if (item.AbsoluteIndex > 1) // Index de Columna
                    {
                        grdv_data.Columns[item.FieldName].Summary.Add(DevExpress.Data.SummaryItemType.Sum, item.FieldName, "{0:#.##}");
                        grdv_data.OptionsView.ShowFooter = true;
                    }
                }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void cmb_Period_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_reports_Click(object sender, EventArgs e)
        {
            //if (cmb_reports.Text == "Formulas Resumen")
            //{
            //    Formulas.FML_Costeo_Formulas cf = new Formulas.FML_Costeo_Formulas();
            //    cf.Show();
            //}
        }

        private void cmb_reports_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_reports.Text == "Formulas Resumen")
            {
                Formulas.FML_Costeo_Formulas cf = new Formulas.FML_Costeo_Formulas();
                cf.Show();
            }
        }

        private void bar_BarraProgreso_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pnl_parametros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnteoric_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RPT_Teorico_Costo RPT = new RPT_Teorico_Costo();
            RPT.Show();
        }
    }
}