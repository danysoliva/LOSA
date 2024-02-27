using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Trazabilidad;
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

namespace LOSA.Calidad.GestionLotesMP
{
    public partial class frmLotesFinalizados : DevExpress.XtraEditors.XtraForm
    {
        public frmLotesFinalizados()
        {
            InitializeComponent();

            DataOperations dp = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-30);

            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);
            loadata();
        }

        private void loadata()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_list_lotes_finalizados]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsInventarioPT1.lotes_finalizados.Clear();
                adat.Fill(dsInventarioPT1.lotes_finalizados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            loadata();
        }

        private void reposHaciaRuta1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsInventarioPT.lotes_finalizadosRow)gridview.GetFocusedDataRow();

            if (!string.IsNullOrEmpty(row.lote_mp))
            {
                frmRutasTrazabilidad frm = new frmRutasTrazabilidad(row.lote_mp);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}