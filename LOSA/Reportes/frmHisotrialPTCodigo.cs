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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using LOSA.Calidad.LoteConfConsumo;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesPT;
using DevExpress.XtraPrintingLinks;

namespace LOSA.Reportes
{
    public partial class frmHisotrialPTCodigo : DevExpress.XtraEditors.XtraForm
    {
        public frmHisotrialPTCodigo()
        {
            InitializeComponent();
            LoadKardexPT();
        }

        private void btnSearchPTCamaron_Click(object sender, EventArgs e)
        {
            //LoadPT();
        }

        private void LoadPT()
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.ProductoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //LoadDataPT(frm.ItemSeleccionado.id);
                //textEdit1.Text = frm.ItemSeleccionado.ItemCode + " " + frm.ItemSeleccionado.ItemName;
                //MateriaPrimaAllBodegas.RecuperarRegistroFromID_RM(frm.ItemSeleccionado.id);
            }
        }
        private void LoadKardexPT()
        {
            string query = @"sp_get_kardex_pt_existencia";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_pt", pid_pt);
                dsProductos1.kardex_pt_existencia.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductos1.kardex_pt_existencia);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }


        private void LoadDataPT(int pid_pt)
        {
            string query = @"sp_get_pt_historico_por_codigo";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", pid_pt);
                dsProductos1.historico_pt_kardex.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsProductos1.historico_pt_kardex);
                con.Close();
           
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(@"sp_get_despachado_por_lote_codigo", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_pt", pid_pt);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd1);
                dsProductos1.despachos_pt.Clear();
                adat1.Fill(dsProductos1.despachos_pt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdv_inventario_camaron_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdvDespachos.ExportToXlsx(dialog.FileName);
            }
        }

        private void grdVKardexPtExistencia_RowClick(object sender, RowClickEventArgs e)
        {
            var gridview = (GridView)grdKardexPtExistencia.FocusedView;
            var row = (dsProductos.kardex_pt_existenciaRow)grdVKardexPtExistencia.GetFocusedDataRow();


            LoadDataPT(row.id_pt);
        }

        private void reposCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var gv = (GridView)grdKardexPtExistencia.FocusedView;
                var row = (dsProductos.kardex_pt_existenciaRow)gv.GetDataRow(gv.FocusedRowHandle);


                foreach (var item in dsProductos1.kardex_pt_existencia)
                {
                    item.seleccion = false;
                }

                row.seleccion = true;

                LoadDataPT(row.id_pt);



            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}