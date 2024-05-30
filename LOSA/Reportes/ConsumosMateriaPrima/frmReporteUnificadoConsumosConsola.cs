using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Reportes.ConsumosMateriaPrima
{
    public partial class frmReporteUnificadoConsumosConsola : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public frmReporteUnificadoConsumosConsola(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            DataOperations dp = new DataOperations();
            DateTime fechaActual = dp.Now();
            DateTime FechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, 1, 07, 0, 0);

            //DateTime FechaFinal = FechaInicial.AddHours(23);
            DateTime FechaFinal = new DateTime(fechaActual.Year, fechaActual.Month + 1, 1, 07, 0, 0);
            //FechaInicial = FechaInicial.AddDays(-30);
            FechaFinal = FechaFinal.AddDays(-1);

            dtDesde.EditValue = FechaInicial;
            dtHasta.EditValue = FechaFinal;
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_detalle_consumos_unificados_reales_y_teoricos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@incluir_nucleos", tggIncluirNucleos.IsOn);
                dsDatosReportesConsumosMP1.Resumen_unificado_consumoMP.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDatosReportesConsumosMP1.Resumen_unificado_consumoMP);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}