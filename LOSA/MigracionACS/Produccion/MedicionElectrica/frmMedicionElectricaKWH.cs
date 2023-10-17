using ACS.Classes;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.Produccion.TemperaturaMaquinas;
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

namespace LOSA.MigracionACS.Produccion.MedicionElectrica
{
    public partial class frmMedicionElectricaKWH : DevExpress.XtraEditors.XtraForm
    {
        public frmMedicionElectricaKWH()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            load_data();
        }

        public void load_data()
        {
            //string query = @"sp_get_temperatura_extusora_log";
            string query = @"sp_get_turnos_registro_temperaturas";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                //cmd.Parameters.AddWithValue("@todos", tsVerTodosTickets.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMedicionElectrica1.turnos.Clear();
                da.Fill(dsMedicionElectrica1.turnos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMedicionElectrica.turnosRow)gridView1.GetFocusedDataRow();
            string query = @"sp_get_detalle_kw_from_dates";//por cada media hora
            //string query = @"sp_get_temperatura_extusora_log";//por cada hora
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                DateTime fechai = new DateTime(row.fecha_inicio.Year, row.fecha_inicio.Month, row.fecha_inicio.Day, row.fecha_inicio.Hour, row.fecha_inicio.Minute, 0);
                DateTime fechaf = fechai.AddHours(12);

                cmd.Parameters.AddWithValue("@fechai", fechai);
                cmd.Parameters.AddWithValue("@fechaf", fechaf);
                //cmd.Parameters.AddWithValue("@id_turno_horario", row.id_turno_horario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMedicionElectrica1.detalle_consumos_kwh.Clear();
                da.Fill(dsMedicionElectrica1.detalle_consumos_kwh);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl2.ExportToXlsx(dialog.FileName);
        }

        private void frmMedicionElectricaKWH_Load(object sender, EventArgs e)
        {

        }
    }
}