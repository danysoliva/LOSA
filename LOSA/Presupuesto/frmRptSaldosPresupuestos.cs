using DevExpress.XtraEditors;
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
using LOSA.Presupuesto;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Presupuesto
{
    public partial class frmRptSaldosPresupuestos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        
        public frmRptSaldosPresupuestos()
        {
            InitializeComponent();
            ObtenerPresupuestoActivos();

        }
        private void ObtenerPresupuestoActivos()
        {
            try
            {
                string query = @"sp_presupuesto_get_presupuesto_en_proceso";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.PresupuestoActivo.Clear();
                adat.Fill(dsPresupuesto1.PresupuestoActivo);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repoVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdConsumo.FocusedView;
            var row = (dsPresupuesto.rpt_consumo_saldosRow)gridview.GetFocusedDataRow();

            if(row.id_d_linea > 0)
            {
                frmDetalleOC frm = new frmDetalleOC(row.id_d_linea);
                frm.ShowDialog();
            }
        }

        private void ObtenerDetallePresupuestos()
        {
            try
            {
                string query = @"sp_presupuesto_saldo_existencia";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPresupuesto", grdPresipuesto.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPresupuesto1.rpt_consumo_saldos.Clear();
                adat.Fill(dsPresupuesto1.rpt_consumo_saldos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCargarInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdPresipuesto.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Periodo!");
                return;
            }
            else
            {
                ObtenerDetallePresupuestos();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdConsumo.ExportToXlsx(dialog.FileName);
            }
        }
    }
}