using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.TransaccionesMP.TrzMP_fromLote;
using LOSA.Trazabilidad.Despachos;
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

namespace LOSA.Trazabilidad.ReportesTRZ
{
    public partial class frmTrazabilidadHaciaAdelanteByMP_Lot : DevExpress.XtraEditors.XtraForm
    {
        public frmTrazabilidadHaciaAdelanteByMP_Lot(string pLoteMateriaPrima, string NameMateriaPrima)
        {
            InitializeComponent();
            txtlote.Text = pLoteMateriaPrima;
            lblMateriaPrimaName.Text = NameMateriaPrima;
            LoadLotesPT();                                                         
        }


        public frmTrazabilidadHaciaAdelanteByMP_Lot()
        {
            InitializeComponent();
        }

        private void LoadLotesPT()
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_load_lotes_pt_trz_from_lote_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtlote.Text);
                dsReportesTRZ1.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtlote_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadLotesPT();
            }
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            txtlote.Text = "";
            txtlote.Focus();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            LoteMP LoteMP_ = new LoteMP();
            if (LoteMP_.RecuperarRegistro(txtlote.Text))
            {
                if (LoteMP_.CantidadMP > 1)
                {
                    //Mostrar Ventana
                    frmMP_WithSameLot frm = new frmMP_WithSameLot(LoteMP_);
                    if(frm.ShowDialog()== DialogResult.OK)
                    {
                        LoadLotesPT(frm.IdMP_Selected);
                        lblMateriaPrimaName.Text = frm.NameMaterialselected;
                    }
                }
                else
                {
                    LoadLotesPT(LoteMP_.IdMPSingle);
                    lblMateriaPrimaName.Text = LoteMP_.NombreComercialSingle;
                }
            }
        }

        private void LoadLotesPT(object idMP_Selected)
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_lotes_pt_trz_from_lote_mpv2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtlote.Text);
                cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ1.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsReportesTRZ.pt_list_trzRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_destinos_lote_pt_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", row.Lote_PT);
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

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLinkBoletaView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();

            Boleta bol1 = new Boleta();
            if(bol1.RecuperarRegistroFromNumBoleta(row.NumID))
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