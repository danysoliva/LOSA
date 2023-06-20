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
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using ACS.Tickets.EndUser;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmNotificaciones : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmNotificaciones(UserLogin Puser)
        {
            
            InitializeComponent();
            Point p = new Point();
            p.X = MousePosition.X;
            p.Y = MousePosition.Y;
            this.Location = p;
            UsuarioLogeado = Puser;
            load_Data();
            update_notification();
        }
        public void load_Data()
        {
            string Query = @"sp_TK_load_notificaciones";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                dsTickets._Notificaciones.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTickets._Notificaciones);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void update_notification()
        {
            string query = @"sp_TK_update_notificaciones";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }   
        private void frmNotificaciones_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsTickets._NotificacionesRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {
                
                if (row.bit_mostrar)
                {
                    e.Appearance.BackColor = Color.FromArgb(202, 202, 202);
                   
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(158, 219, 149);
                }
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
               try
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsTickets._NotificacionesRow)gridView.GetFocusedDataRow();

                    frmTickets frm = new frmTickets(UsuarioLogeado, frmTickets.TipoTicket.Manto, row.id_ticket);
                    frm.Show();

                }
                catch (Exception ex)
                {


                }
           
        }

        private void tsLeidos_Toggled(object sender, EventArgs e)
        {
            grdv_data.ActiveFilterString = "[bit_mostrar] = " + tsLeidos.EditValue;
        }
    }
}