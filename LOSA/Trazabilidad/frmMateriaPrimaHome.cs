using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.Logistica;
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

namespace LOSA.Trazabilidad
{
    public partial class frmMateriaPrimaHome : DevExpress.XtraEditors.XtraForm
    {
        public frmMateriaPrimaHome()
        {
            InitializeComponent();
            cargarMateriaPrima();
        }

        private void cargarMateriaPrima()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_get_header_resumen_materiaprimav2";

                //dsLogistica.Materia_prima_v2.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codesap", pCodeSap);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //DataTable table1 = new DataTable();
                dsMantoTrazabilidad1.view_mp.Clear();
                adat.Fill(dsMantoTrazabilidad1.view_mp);
                //vGridControl1.DataSource = table1;
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void LinkLotesMP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Link Lotes MP
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.view_mpRow)gridView.GetFocusedDataRow();
            MateriaPrima mp = new MateriaPrima();
            if (mp.RecuperarRegistroFromID_RM(row.id))
            {
                frmMateriaPrimaViewer frm = new frmMateriaPrimaViewer(mp.CodeMP_SAP);
                frm.Show();
            }
        }

        private void reposEditMp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.view_mpRow)gridView.GetFocusedDataRow();

            frmMateriaPrimaEdit frm = new frmMateriaPrimaEdit(row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarMateriaPrima();
            }
            

        }
    }
}