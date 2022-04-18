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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Trazabilidad;
using LOSA.Logistica;
using LOSA.Trazabilidad.ReportesTRZ;
using LOSA.Trazabilidad.Despachos;

namespace LOSA.Calidad
{
    public partial class frmreporte_trazabilidad : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public int lote_fp;
        LotePT LoteActual;
        public frmreporte_trazabilidad(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            txtlote.Focus();
        }    
        
        public void load_header()
        {
            if (!string.IsNullOrEmpty(txtlote.Text))
            {
                LotePT ptProducido = new LotePT();
                if (ptProducido.RecuperarRegistro(Convert.ToInt32(txtlote.Text)))
                {
                    LoteActual = ptProducido;
                    txtTotalKgSacosLiberados.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.TotalKg);
                    txtSacosLiberados.Text = string.Format("{0:###,##0 Sacos}", ptProducido.Unidades);
                    txtReprocesoKg.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.Reproceso_kg);
                    txtTotalProducido.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.Reproceso_kg + ptProducido.TotalKg);
                    txtPresentacion.Text = ptProducido.DescripcionPresentacion;
                    txtCantidadBatch.Text = string.Format("{0:###,##0}", ptProducido.CantidadBatch);
                    txtOrderNum.Text = ptProducido.OrderNum_prd.ToString();
                    txtCodigoPP.Text = ptProducido.OrderCodePP;
                }

                string sql_h = @"[dbo].[RPT_PRD_Trazabilidad_header_lote]";

                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);

                try
                {
                    cn.Open();
                    SqlCommand cmd_h = new SqlCommand(sql_h, cn);
                    cmd_h.CommandType = CommandType.StoredProcedure;
                    cmd_h.Parameters.AddWithValue("@num_lote", txtlote.Text);
                    SqlDataReader dr_h = cmd_h.ExecuteReader();

                    Int64 AcsId = 0;
                    if (dr_h.Read())
                    {
                        txtcodigo.Text = dr_h.GetString(0);
                        txtProducto.Text = dr_h.GetString(1);
                        txtformula.Text = dr_h.GetInt32(3).ToString();
                        txtversion.Text = dr_h.GetInt32(4).ToString();
                    }
                    dr_h.Close();
                }
                catch (Exception EX)
                {
                    CajaDialogo.Error(EX.Message);
                }
            }
        }

        public void load_data()
        {
            if (!string.IsNullOrEmpty(txtlote.Text))
            {
                string query = @"[sp_load_report_trazabilitadad_lotev2]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCalidad.trazabilitad.Clear();
                    da.Fill(dsCalidad.trazabilitad);
                    cn.Close();
                    if (dsCalidad.trazabilitad.Rows.Count == 0)
                    {
                        errorProvider1.SetError(txtlote, "Este lote aun no tiene materias primas utilizadas!");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                //Calcular el total MP utilizada
                decimal TotalMP_kg = 0;
                foreach (dsCalidad.trazabilitadRow row in dsCalidad.trazabilitad.Rows)
                {
                    TotalMP_kg += row.Contado;
                }
                txtTotalMP_Utilizada_kg.Text = string.Format("{0:###,##0.00 Kg}", TotalMP_kg);
                if (LoteActual != null)
                {
                    if (LoteActual.Recuperado)
                    {
                        if (TotalMP_kg > 0)
                            txtEficiencia.Text = string.Format("{0:###,##0.00}", ((LoteActual.Reproceso_kg + LoteActual.TotalKg) / TotalMP_kg) *100);
                        else
                            txtEficiencia.Text = string.Format("{0:###,##0.00}", 0);
                    }
                }
            }
        }
         
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            lote_fp = 0;
            txtlote.Text = "";
            dsCalidad.trazabilitad.Clear();
            txtversion.Text = "";
            txtformula.Text = "";
            txtProducto.Text = "";
            txtcodigo.Text = "";

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (txtlote.Text == "")
            {
                CajaDialogo.Error("Debe de especificar el lote que desea encontrar resultados.");
            }
            load_data();//Detalle de materias primas usadas en lote de PT
            load_header();
            Load_Despachos();
            load_informacion_de_inventario();
            load_tarimas_rechazadas();
            load_MuestreoPT();
        }
        public void load_informacion_de_inventario()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_inventory_trasaccion_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.transacciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.transacciones);



                cmd = new SqlCommand("sp_get_inventorio_habilitado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.libres.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.libres);

                cmd = new SqlCommand("sp_get_inventorio_observacion_retenido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.retenidos.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.retenidos);

                cmd = new SqlCommand("sp_get_resumen_pt_transaccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.resumen.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.resumen);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        public void load_tarimas_rechazadas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_tarimas_rechazadas_pt_for_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                dsReportesTRZ1.tarimas_rechazadas_pt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.tarimas_rechazadas_pt);


                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        public void load_MuestreoPT()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_muestreo_y_parametro_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsTrazabilidadReports1.muestreo_lote.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTrazabilidadReports1.muestreo_lote);


                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void Load_Despachos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_destinos_lote_pt_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                dsReportesTRZ1.detalle_destinos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.detalle_destinos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtlote_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (txtlote.Text == "")
                {
                    CajaDialogo.Error("Debe de especificar el lote que desea encontrar resultados.");
                }
                load_header();
                load_data();
                Load_Despachos();
                load_informacion_de_inventario();
                load_tarimas_rechazadas();
                load_MuestreoPT();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //Preguntar cual grid se va a exportar.
            //1 Detalle MP
            //2 Clientes que Recibieron el Lote PT
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnLinkProveedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Link hacia master de proveedores
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsCalidad.trazabilitadRow)gridView.GetFocusedDataRow();

            frmMantoProveedoresMP frm = new frmMantoProveedoresMP(this.UsuarioLogeado, row.card_code);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnLinkIngreso_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Abrir detalle de ingreso MP
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsCalidad.trazabilitadRow)gridView.GetFocusedDataRow();
            //frmDetalleIngresoTRZ frm = new frmDetalleIngresoTRZ(row.ingreso);
            IngresoMP ingreso = new IngresoMP();
            int IngresoActual = 0;
            try
            {
                IngresoActual = Convert.ToInt32(row.ingreso);
            }
            catch { }

            if (IngresoActual > 0)
            {
                if (ingreso.RecuperarRegistroIdLote_fromNumTransaccion(row.ingreso, row.lote_mp))
                {
                    rdEstadoTransporte frm = new rdEstadoTransporte(ingreso.IdIngresoLote, this.UsuarioLogeado);
                    if (this.MdiParent != null)
                        frm.MdiParent = this.MdiParent;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
            }
            else
            {
                CajaDialogo.Information("Este Lote no posee datos de Ingreso de Materia Prima!");
            }
            
        }

        private void btnLinkMateriaPrima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //rmMateriaPrimaViewer(string SAPCODE_MP, string SAP_CARD_CODE)
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsCalidad.trazabilitadRow)gridView.GetFocusedDataRow();
            frmMateriaPrimaViewer frm = new frmMateriaPrimaViewer(row.code_sap, row.card_code);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmreporte_trazabilidad_Activated(object sender, EventArgs e)
        {
            txtlote.Focus();
        }

        private void frmreporte_trazabilidad_Load(object sender, EventArgs e)
        {
            txtlote.Focus();
        }

        private void btnTrazabilidadLoteMP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Abrir trazabilidad Lote MP
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsCalidad.trazabilitadRow)gridView.GetFocusedDataRow();

            //frmTrazabilidadHaciaAdelanteByMP_Lot frm = new frmTrazabilidadHaciaAdelanteByMP_Lot(row.lote_mp, row.nombre_comercial);
            rdEstadoTransporte frm = new rdEstadoTransporte(row.lote_mp, UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnLinkBoletaView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();

            Boleta bol1 = new Boleta();
            if (bol1.RecuperarRegistroFromNumBoleta(row.NumID))
            {
                frmViewBasculaBoleta frm = new frmViewBasculaBoleta(bol1.Id);
                if (this.MdiParent != null)
                    frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
            }
        }

        private void cmdDespachoId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();
            frmDetalleDespacho frm = new frmDetalleDespacho(row.Despacho);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
    }
}