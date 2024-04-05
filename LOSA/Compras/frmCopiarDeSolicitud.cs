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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using ACS.Classes;
using LOSA.Compras;
using System.Data.SqlClient;

namespace LOSA.Compras
{
    public partial class frmCopiarDeSolicitud : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int IdSolicitudSeleccionado = 0;
        public int IdOrdenCompra = 0;

        public enum TipoDocumento
        { 
            SolicitudCompra = 1,
            OrdenCompra = 2
        }

        TipoDocumento tipoDoc;

        public frmCopiarDeSolicitud(frmCopiarDeSolicitud.TipoDocumento tipo)
        {
            InitializeComponent();
            tipoDoc = tipo;

            dp = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-30);

            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);

            switch (tipoDoc)
            {
                case TipoDocumento.SolicitudCompra:
                    navigationFrame1.SelectedPageIndex = 0;
                    lblTipoDocumento.Text = "Seleccione la Solicitud de Compra";
                    CargarSolicitudes();

                    break;
                case TipoDocumento.OrdenCompra:
                    navigationFrame1.SelectedPageIndex = 1;
                    lblTipoDocumento.Text = "Seleccione la Orden de Compra";
                    CargarOrdenesCompra();

                    break;
                default:
                    break;
            }

        }

        private void CargarOrdenesCompra()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_get_ordenes_compra_fechas]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Desde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.orden_compra_exo.Clear();
                adat.Fill(dsCompras1.orden_compra_exo);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarSolicitudes()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand("CM_sp_get_all_solicitud_compra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Desde", dtFechaDesdeDisponibles.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.solicitudes_compra.Clear();
                adat.Fill(dsCompras1.solicitudes_compra);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            switch (tipoDoc)
            {
                case TipoDocumento.SolicitudCompra:

                    CargarSolicitudes();

                    break;
                case TipoDocumento.OrdenCompra:
                    
                    CargarOrdenesCompra();

                    break;
                default:
                    break;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdSolicitudesCompra.FocusedView;
            var row = (dsCompras.solicitudes_compraRow)gridview.GetFocusedDataRow();

            if (row.DocNum != 0)
            {
                IdSolicitudSeleccionado = row.DocNum;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdOrdenesCompra.FocusedView;
            var row = (dsCompras.orden_compra_exoRow)gridview.GetFocusedDataRow();

            if (row.id_h != 0)
            {
                IdOrdenCompra = row.id_h;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}