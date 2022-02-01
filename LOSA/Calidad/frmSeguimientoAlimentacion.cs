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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frmSeguimientoAlimentacion : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmSeguimientoAlimentacion(UserLogin Puser)
        {
            InitializeComponent();
            timertick.Enabled = true;
            UsuarioLogeado = Puser;
            load_data();
            load_data_v2();
        }

        public void load_data()
        {
            try
            {
                string query = @"sp_inventario_en_produccion_antes_del_consumo";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.alimentacion.Clear();
                da.Fill(dsCalidad.alimentacion);
                cn.Close();
            }
            catch (Exception ex)
            {
                                                        
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data_v2()
        {
            try
            {
                string query = @"sp_get_cola_lote_consumido";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCalidad.Consumido.Clear();
                da.Fill(dsCalidad.Consumido);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                DateTime date_1;
                DateTime date_2; 

               
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsCalidad.alimentacionRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {
                    date_1 = row.fecha;
                    date_2 = DateTime.Now;
                    double Diff = date_2.Subtract(date_1).TotalMinutes;
                    if (Diff <= 5)
                    {
                        e.Appearance.BackColor = Color.FromArgb(148, 213, 181);
                    }
                    if (Diff > 5 && Diff < 10)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 214, 214);
                    }
                    if (Diff >= 10 && Diff < 20)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 179, 179);
                    }
                    if (Diff >= 20)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 143, 143);
                    }
                }

            }
            catch (Exception )
            {

            }
        }

        private void timertick_Tick(object sender, EventArgs e)
        {
            int Nuevo = 0;                             
            if (timertick.Enabled)
            {
                string Query = @"sp_count_alimentacion_tarima";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Nuevo = Convert.ToInt32(cmd.ExecuteScalar());
                    if (Nuevo > 0)
                    {
                        load_data();
                        load_data_v2();
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmIntarioColaLote frm = new frmIntarioColaLote(UsuarioLogeado);
            frm.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            load_data();
            load_data_v2();
        }

        private void grd_consumido_Click(object sender, EventArgs e)
        {

        }
    }
}