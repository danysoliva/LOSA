using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Trazabilidad.ReportesTRZ;
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
    public partial class frmDetalleIngresoTRZ : DevExpress.XtraEditors.XtraForm
    {
        int IdIngreso;
        public frmDetalleIngresoTRZ(int pIdIngreso)
        {
            InitializeComponent();
            IdIngreso = pIdIngreso;
            txtNumIngreso.Text = pIdIngreso.ToString();
            LoadIngreso();
        }

        private void LoadIngreso()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[ps_load_ingresos_from_tarimas_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                dsReportesTRZ1.ingreso_view.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.ingreso_view);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {

            txtNumIngreso.Text = "";
            txtNumIngreso.Focus();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            LoadIngreso();
        }

        private void txtNumIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IdIngreso = Convert.ToInt32(txtNumIngreso.Text);
                LoadIngreso();
            }
        }

        private void btnViewBoletaBascula_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsReportesTRZ.ingreso_viewRow)gridView.GetFocusedDataRow();

            frmViewBasculaBoleta frm = new frmViewBasculaBoleta(row.idboleta);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}