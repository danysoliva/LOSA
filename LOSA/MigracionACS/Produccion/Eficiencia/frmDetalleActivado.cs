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


namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frmDetalleActivado : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public string lote;
        public frmDetalleActivado(string Plote)
        {
            InitializeComponent();
            lote = Plote;
            load_data();
            txtlote.Text = lote.ToString();
            load_reporteUtilizado();
            load_tarimas_utilizadas();
        }


        public void load_tarimas_utilizadas() 
        {

            try
            {
                string Qry = @"sp_load_data_prb_view_lote_tarimas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                dsLotePick.tarimas_prb.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLotePick.tarimas_prb);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_reporteUtilizado() 
        {
            try
            {
                string Qry = @"sp_load_data_prb_view_lote";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Qry,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote",lote);
                dsLotePick.prblote.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLotePick.prblote);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            try
            {
                string query = @"sp_load_lote_pt_view";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                dsLotePick.tm_activas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLotePick.tm_activas);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data_pendientes()
        {
            try
            {
                string query = @"sp_load_lote_pt_view_pendientes";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", lote);
                dsLotePick.tm_activas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLotePick.tm_activas);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tggPendientes_Toggled(object sender, EventArgs e)
        {
            if (tggPendientes.IsOn)
            {
                load_data_pendientes();
            }
            else
            {
                load_data();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }
    }
}