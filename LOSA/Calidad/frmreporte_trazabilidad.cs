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

namespace LOSA.Calidad
{
    public partial class frmreporte_trazabilidad : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public int lote_fp;
        public frmreporte_trazabilidad(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            txtlote.Focus();
        }                
        public void load_header()
        {
            string sql_h = @"[dbo].[RPT_PRD_Trazabilidad_header_lote]";

            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
       
            try
            {
                cn.Open();
                SqlCommand cmd_h = new SqlCommand(sql_h, cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@num_lote",txtlote.Text);
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

        public void load_data()
        {
            
            string query = @"[sp_load_report_trazabilitadad_lote]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.trazabilitad.Clear();
                da.Fill(dsCalidad.trazabilitad);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
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
            load_data();
            load_header(); 
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
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
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

        }
    }
}