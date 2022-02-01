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
using ACS.Classes;
using LOSA.Clases;
using LOSA.Trazabilidad;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad;

namespace LOSA.Logistica
{
    public partial class frmReporteSeguimientoComprasTransito : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string Itemcode;
        public frmReporteSeguimientoComprasTransito()
        {
            InitializeComponent();
            get_mps();

        }

        public void get_mps()
        {
            string query = @"ps_obtener_mp_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLogistica21.Materia_prima_v2.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLogistica21.Materia_prima_v2);
                cn.Close();
                

            }
            catch (Exception ex)
            {

               CajaDialogo.Error(ex.Message);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grd_mps_EditValueChanged(object sender, EventArgs e)
        {

            Itemcode = grd_mps.EditValue.ToString();
            string query = @"sp_get_compras_en_transito";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemcode", Itemcode);
                dsLogistica2.OrdenesCompraTransito.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLogistica2.OrdenesCompraTransito);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnOc_Click(object sender, EventArgs e)
        {
            try
            {

                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsLogistica2.OrdenesCompraTransitoRow)gridView.GetFocusedDataRow();

                frmOC_SAP_View frm = new frmOC_SAP_View(row.DocNum);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsLogistica2.OrdenesCompraTransitoRow)gridView.GetFocusedDataRow();
                frmViewEntradas frm = new frmViewEntradas(row.DocEntry,22,row.LineNum);
                frm.Show();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}