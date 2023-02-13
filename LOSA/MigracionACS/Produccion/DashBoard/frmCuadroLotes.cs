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
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    public partial class frmCuadroLotes : DevExpress.XtraEditors.XtraForm
    {
        DateTime FechaDesde;
        DateTime FechaHasta;
        int TurnoId;
        int LineaId;
        public frmCuadroLotes(DateTime vFechaDesde, DateTime vFechaHasta, int vLineaId, int vTurnoId)
        {
            InitializeComponent();
            dtDesde.EditValue = FechaDesde = vFechaDesde;
            dtHasta.EditValue = FechaHasta = vFechaHasta;
            TurnoId = vTurnoId;
            LineaId = vLineaId;
            LoadDetalle();
        }

        public frmCuadroLotes(int pLotePT)
        {
            InitializeComponent();
            //dtDesde.EditValue = FechaDesde = vFechaDesde;
            //dtHasta.EditValue = FechaHasta = vFechaHasta;
            //TurnoId = vTurnoId;
            //LineaId = vLineaId;
            dtDesde.Visible = dtHasta.Visible = lblFechaHasta.Visible = false;
            lblFechaDesde.Text = "Lote PT: " + pLotePT.ToString();
            LoadDetalle(pLotePT);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadDetalle();
        }

        private void LoadDetalle()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_cuadro_lotes_prd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechai", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fechaf", dtHasta.EditValue);
                //cmd.Parameters.AddWithValue("@filtro_maquina", LineaId);
                //cmd.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.cuadro_de_lotes.Clear();
                adat.Fill(dsDashBoard1.cuadro_de_lotes);
                cn.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalle(int pLotePT)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_cuadro_lotes_prd_by_lote_pt", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_pt", pLotePT);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.cuadro_de_lotes.Clear();
                adat.Fill(dsDashBoard1.cuadro_de_lotes);
                cn.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}