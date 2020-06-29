using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Mantenimientos.Modelos;
using LOSA.RecepcionMP;
using LOSA.Reportes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LOSA.Mantenimientos
{
    public partial class frmUbicaciones : Form
    {
        int IdBodega;
        string BodegaNombre;
        DataOperations dp = new DataOperations();
       public frmUbicaciones()
        {
            InitializeComponent();
            CargarDatos();
        }

        void CargarDatos()
        {
            try
            {
                IdBodega = 0;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                string SQL = @"exec sp_get_bodegas_enable";

                dsRecepcionMPx1.bodegas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);
                adat.Fill(dsRecepcionMPx1.bodegas);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUbicacionesCRUD frm = new frmUbicacionesCRUD(IdBodega);
            frm.WindowState = FormWindowState.Maximized;
            frm.lblBodegaActual.Text = lblBodegaActual.Text;
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //TipoPresentacion tipoPresentacion = new TipoPresentacion
            //{
            //    Id = Convert.ToInt32(gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), colid)),
            //    Descripcion = gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), coldescripcion).ToString(),
            //    Enable = Convert.ToBoolean(gvTiposPresentaciones.GetRowCellValue(gvTiposPresentaciones.GetRowHandle(gvTiposPresentaciones.GetSelectedRows()[0]), colenable)),
            //    Factor = Convert.ToDecimal(gvTiposPresentaciones.GetFocusedRowCellValue(gvTiposPresentaciones.Columns[3]).ToString())
            //};

            //frmUbicacionesCRUD frm = new frmUbicacionesCRUD(tipoPresentacion);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    CargarDatos();
            //}
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            //bodega seleccionada
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.bodegasRow)gridView.GetFocusedDataRow();

            IdBodega = row.id;
            lblBodegaActual.Text = "Bod. " + row.descripcion;
            //BodegaNombre = row.descripcion;

            if (IdBodega > 0)
            {
                LoadRacks();
                this.navigationFrame1.SelectNextPage();
                btnAgregar.Visible = true;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //bodega seleccionada
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.bodegasRow)gridView.GetFocusedDataRow();

            IdBodega = row.id;
            lblBodegaActual.Text = "Bod. " + row.descripcion;
            //BodegaNombre = "Bod. " + row.descripcion;

            if (IdBodega > 0)
            {
                LoadRacks();
                this.navigationFrame1.SelectNextPage();
            }
        }

        private void LoadRacks()
        {
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string sql = "sp_get_racks_enable_from_pasillo_v2";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idbodega", IdBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.Clear();
                adat.Fill(dsRecepcionMPx1.racks);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);   
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();
            navigationFrame1.SelectPrevPage();
            btnAgregar.Visible = false;
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcTiposPresentaciones.FocusedView;
            var row = (dsRecepcionMPx.racksRow)gridView.GetFocusedDataRow();
            rptUbicacionRotulo report = new rptUbicacionRotulo(row.descripcion, row.barcode);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }
    }
}
