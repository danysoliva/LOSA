using DevExpress.XtraEditors;
using LOSA.RecepcionMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.AlmacenesExterno
{
    public partial class frmReporteExterno : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string itemcode = "";
        public string wshcode = "";
        public string namewhs = "";

        public frmReporteExterno()
        {
            InitializeComponent();
            load_Almacenes_ext_init();
        }
       

        public void load_ordenes_en_transito()
        {
            string query = @"sp_load_oc_transito";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.comprasTransito.Clear();
                da.Fill(dsReporteAlmacenExterno.comprasTransito);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_InventarioAlmacenExterno_x_MP()
        {

            string query = @"sp_get_existencia_almacen_externo";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.InventarioEx.Clear();
                da.Fill(dsReporteAlmacenExterno.InventarioEx);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_Almacenes_ext_init()
        {

            string query = @"sp_get_existencia_almacen_externo_init";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.InventarioEx.Clear();
                da.Fill(dsReporteAlmacenExterno.InventarioEx);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtcodigoMP.Text = frm.ItemCode;
                txtmp.Text = frm.MateriaPrima;
                itemcode = frm.ItemCode;
                load_InventarioAlmacenExterno_x_MP();
                load_ordenes_en_transito();
                load_data_con_parametro();
            }
        }

        private void frmReporteExterno_Load(object sender, EventArgs e)
        {
        
        }

        private void grdv_resumen_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_resumen.FocusedView;
                var row = (dsReporteAlmacenExterno.InventarioExRow)gridView.GetFocusedDataRow();
                wshcode = row.codigobog;
                namewhs = row.descripcionbog;
                foreach  (var RowBodega in dsReporteAlmacenExterno.InventarioEx)
                {
                    RowBodega.selected = false;
                }
                dsReporteAlmacenExterno.InventarioEx.AcceptChanges();
                row.selected = true;
                row.AcceptChanges();
                txtBodega.Text = wshcode;
                txtbodegaName.Text = namewhs;
                load_data_con_parametro();

            }
            catch (Exception ex)
            {

            }
        }
        public void load_data_con_parametro()
        {
            if (itemcode == "" || wshcode == "")
            {
                return;
            }
            string query = @"sp_load_lotes_bodega_externa_con_parametro";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bodega", wshcode);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.controlBodegaExterna.Clear();
                da.Fill(dsReporteAlmacenExterno.controlBodegaExterna);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void grdv_resumen_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_resumen.FocusedView;
                var row = (dsReporteAlmacenExterno.InventarioExRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {

                    if (row.selected)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0, 178, 148);

                    }
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private void btnvertodas_Click(object sender, EventArgs e)
        {
            if (wshcode == "")
            {
                CajaDialogo.Error("Seleccione de Inventario de Boodegas Externas una bodega externa.");
            }
            frmvertodasMPinbodega frm = new frmvertodasMPinbodega(namewhs, wshcode);
            frm.Show();
        }
    }
}