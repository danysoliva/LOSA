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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frmview : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int Parid;
        UserLogin UsuarioLogeado;
        public frmview(int id_tarima, string producto, UserLogin Paruser)
        {
            InitializeComponent();
            UsuarioLogeado = Paruser;
            lblnumero.Text = id_tarima.ToString();
            lblproducto.Text = producto;
            Parid = id_tarima;
            load_data();
        }
        public void load_data()
        {
            string query = @"[dbo].[sp_load_calidad_tarimas]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", Parid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.causas_guardadas.Clear();
                da.Fill(dsCalidad.causas_guardadas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsCalidad.causas_guardadasRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.Estado == "Bloqueado")
                        e.Appearance.BackColor = Color.FromArgb(232, 170, 170);
                    else
                        e.Appearance.BackColor = Color.FromArgb(180, 253, 165);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_asiganacion_causas frm = new frm_asiganacion_causas(UsuarioLogeado, Parid);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }
    }
}