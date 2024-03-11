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

        public frmCopiarDeSolicitud()
        {
            InitializeComponent();

            dp = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-30);

            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);

            CargarSolicitudes();

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
            CargarSolicitudes();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsCompras.solicitudes_compraRow)gridview.GetFocusedDataRow();

            if (row.DocNum != 0)
            {
                IdSolicitudSeleccionado = row.DocNum;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}