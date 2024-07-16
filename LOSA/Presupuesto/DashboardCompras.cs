using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Presupuesto;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;


namespace LOSA.Presupuesto
{
    public partial class DashboardCompras : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataOperations dp = new DataOperations();
        DateTime Mes;
        DateTime Anio;
        public DashboardCompras()
        {
            InitializeComponent();

            barEditItemAnio.EditValue = barEditItemMes.EditValue = dp.Now();
            Mes = Convert.ToDateTime(barEditItemMes.EditValue);
            Anio = Convert.ToDateTime(barEditItemAnio.EditValue);
        }

        private void btnCargarDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (barEditItemAnio.EditValue == null)
            {
                CajaDialogo.Error("Debe Seleccionar un Año!");
                return;
            }

            CargarGraficas();
            
        }

        private void CargarGraficas()
        {

            #region CargarPie - %OCconCotizaciones
            try
            {
                

                string query = @"sp_get_dashboard_cotizaciones";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", Anio.Year);
                cmd.Parameters.AddWithValue("@mes", Mes.Month);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.conteo_cotizacionesxoc.Clear();
                adat.Fill(dsPresupuesto1.conteo_cotizacionesxoc);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            #endregion

            #region CargarDash - Ahorros Generados - Descuentos
            try
            {
                //DateTime Mes = Convert.ToDateTime(barEditItemMes.EditValue);
                //DateTime Anio = Convert.ToDateTime(barEditItemAnio.EditValue);

                string query = @"sp_ahorros_get_ahorros_generados_Descuentos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", Anio.Year);
                cmd.Parameters.AddWithValue("@mes", Mes.Month);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.ahorros_generados.Clear();
                adat.Fill(dsPresupuesto1.ahorros_generados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            #endregion
        }

        private void barButtonDetalleOC_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRptSaldosPresupuestos frm = new frmRptSaldosPresupuestos(frmRptSaldosPresupuestos.TipoReporte.AhorrosGenerados,Anio.Year, Mes.Month);
            frm.ShowDialog();
        }

        private void barbtnConsumoSaldos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRptSaldosPresupuestos frm = new frmRptSaldosPresupuestos(frmRptSaldosPresupuestos.TipoReporte.SaldosPresupuestos, Anio.Year, Mes.Month);
            frm.ShowDialog();
        }
    }
}