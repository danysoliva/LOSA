using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.Trazabilidad;
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

namespace LOSA.Logistica
{
    public partial class frmMateriaPrimaViewer : Form
    {
        DataOperations dp = new DataOperations();
        public frmMateriaPrimaViewer()
        {
            InitializeComponent();
            //cargarMateriaPrima();
            //cargarDatosTarimas();
            //cbMateriaPrima.Enabled = true;
        }

        public frmMateriaPrimaViewer(string SAPCODE_MP)
        {
            InitializeComponent();
            //cargarMateriaPrima();
            //cargarDatosTarimas();
            //cbMateriaPrima.Enabled = false;
            ////MateriaPrima mp = new MateriaPrima();
            ////if (mp.RecuperarRegistroFromCode(SAPCODE_MP))
            ////{
            //    cbMateriaPrima.EditValue = SAPCODE_MP;
            //cbMateriaPrima.Text = mp.Name;
            cargarDatosTarimas(SAPCODE_MP);
            cargarMateriaPrima(SAPCODE_MP);
            //}
        }

        public frmMateriaPrimaViewer(string SAPCODE_MP, string SAP_CARD_CODE)
        {
            InitializeComponent();
            //cargarMateriaPrima();
            //cargarDatosTarimas();
            //cbMateriaPrima.Enabled = false;
            ////MateriaPrima mp = new MateriaPrima();
            ////if (mp.RecuperarRegistroFromCode(SAPCODE_MP))
            ////{
            //    cbMateriaPrima.EditValue = SAPCODE_MP;
            //cbMateriaPrima.Text = mp.Name;
            cargarDatosTarimas(SAPCODE_MP, SAP_CARD_CODE);
            cargarMateriaPrima(SAPCODE_MP, SAP_CARD_CODE);
            //}
        }

        private void cargarDatosTarimas(string pCodeSAP)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_by_MP_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pCodeSAP);
                //cmd.Parameters.AddWithValue("@cardcode", pCardCode);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoTrazabilidad1.lista_lotes_mp.Clear();
                adat.Fill(dsMantoTrazabilidad1.lista_lotes_mp);
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void cargarDatosTarimas(string pCodeSAP,string pCardCode)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_by_MP_v5]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pCodeSAP);
                cmd.Parameters.AddWithValue("@cardcode", pCardCode);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoTrazabilidad1.lista_lotes_mp.Clear();
                adat.Fill(dsMantoTrazabilidad1.lista_lotes_mp);
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }



        private void cargarMateriaPrima(string pCodeSap)
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_get_header_resumen_materiaprima";

                dsLogistica.Materia_prima_v2.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codesap", pCodeSap);
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
        private void cargarMateriaPrima(string pCodeSap, string pCardCode)
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"[sp_get_header_resumen_materiaprimav3]";

                dsLogistica.Materia_prima_v2.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codesap", pCodeSap);
                cmd.Parameters.AddWithValue("@cardcode", pCardCode);
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
            this.Close();
        }

        private void frmLotesXMP_Load(object sender, EventArgs e)
        {
            //gvLotes.Columns[1].GroupIndex = 1;
        }

        private void cbMateriaPrima_EditValueChanged(object sender, EventArgs e)
        {
            //gvLotes.ActiveFilterString = "[itemcode] = '" + cbMateriaPrima.EditValue + "'";
            //cargarDatosTarimas();
        }

        private void cmdViewOC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcLotes.FocusedView;
            var row = (dsMantoTrazabilidad.lista_lotes_mpRow)gridView.GetFocusedDataRow();
            frmOC_SAP_View frm = new frmOC_SAP_View(row.Purchase_Order_SAP);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void cmdScaleDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var gridView = (GridView)gcLotes.FocusedView;
            var row = (dsMantoTrazabilidad.lista_lotes_mpRow)gridView.GetFocusedDataRow();
            frmViewBasculaBoleta frm = new frmViewBasculaBoleta(row.id_boleta);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void linkTRZ_HaciaAdelante_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Link hacia trazabilidad hacia adelante
            
            var gridView = (GridView)gcLotes.FocusedView;
            var row = (dsMantoTrazabilidad.lista_lotes_mpRow)gridView.GetFocusedDataRow();
            frmTrazabilidadHaciaAdelanteByMP_Lot frm = new frmTrazabilidadHaciaAdelanteByMP_Lot(row.Lot);
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
