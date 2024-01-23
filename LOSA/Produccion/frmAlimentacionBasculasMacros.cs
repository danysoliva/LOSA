using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Clases;
using LOSA.Classes;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Produccion
{
    public partial class frmAlimentacionBasculasMacros : DevExpress.XtraEditors.XtraForm
    {
        public frmAlimentacionBasculasMacros()
        {
            InitializeComponent();

            DataOperations dp = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-1);

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
                SqlCommand cmd = new SqlCommand("sp_get_registros_bascula_alimentacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos1.alimentacion_macros.Clear();
                adat.Fill(dsProductos1.alimentacion_macros);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            loadata();
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

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;

            if (e.RowHandle >= 0)
            {
                decimal Porcentaje = Convert.ToDecimal(View.GetRowCellDisplayText(e.RowHandle, View.Columns["diffporcentaje"]));

                if (Porcentaje > 2 || Porcentaje < -2)
                {

                    e.Appearance.BackColor = Color.FromArgb(255, 102, 102); //Color.Red;
                    e.HighPriority = true;
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(153, 255, 153);
                }

            }


        }
    }
}