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
using ACS.Tickets;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using ACS.Tickets.EndUser;
using LOSA.MigracionACS.Tickets.Clases;
using LOSA.MicroIngredientes.Tickets.EndUser;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmMainUser : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int id_tipo;
        int MostrarTodos = 0;
        frmTickets.TipoTicket TipoSoporte;

        public frmMainUser(UserLogin Puser , int Pid_tipo)
        {
            InitializeComponent();
             UsuarioLogeado = Puser;   
            id_tipo = Pid_tipo;
            load_data();
            TimerN.Enabled = true;  
            if (id_tipo == 1)
            {
                TipoSoporte = frmTickets.TipoTicket.IT;
            }
            else
            {
                TipoSoporte = frmTickets.TipoTicket.Manto;

            }


     
        }

        public void load_data()
        {
            string Query = @"sp_tk_load_tickets_V5";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);   
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_online", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@abierto", MostrarTodos);
                cmd.Parameters.AddWithValue("@id_tipo", id_tipo);
                dsTickets.tickets.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTickets.tickets);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (MostrarTodos == 0)
            {
                btnHistorial.Text = "Ocultar Cerrados";
                MostrarTodos = 1;
                load_data();
            }
            else
            {
                btnHistorial.Text = "Mis Solicitudes";
                MostrarTodos = 0;
                load_data();
            }
        }
        public int contar_notificaciones()
        {
            string Query = @"sp_TK_count_notificaciones";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            SqlCommand cmd = new SqlCommand(Query,cn);
            int Cantidad = 0;
            try
            {
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                Cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                return Cantidad;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return Cantidad;
            }
        }

        private void TimerN_Tick(object sender, EventArgs e)
        {
            int Notificaciones = contar_notificaciones();
            if (Notificaciones != 1)
            {
                btnNotificaciones.Text = "Notificaciones";

            }
            else
            {
                btnNotificaciones.Text = "Notificaciones" + " (" + Notificaciones + ")";
            }
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            frmNotificaciones frm = new frmNotificaciones(UsuarioLogeado);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
        }

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            //frmTickets frm = new frmTickets(UsuarioLogeado, TipoSoporte);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    load_data();
            //}
            switch (id_tipo)
            {
                case 1:
                    frmTicketsNew frm = new frmTicketsNew (UsuarioLogeado);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        load_data();
                    }
                    break;

                case 2:
                    frmTicketsNew_Mantenimiento frm2 = new frmTicketsNew_Mantenimiento(UsuarioLogeado);
                    if (frm2.ShowDialog() == DialogResult.OK)
                    {
                        load_data();
                    }
                    break;
            }

            if (true)
            {

            }

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsTickets.ticketsRow)gridView.GetFocusedDataRow();

                Ticket ticket = new Ticket(row.id);

                ////frmTickets frm = new frmTickets(UsuarioLogeado, TipoSoporte, row.id);
                //frmTicketsNew_IT frm = new frmTicketsNew_IT(UsuarioLogeado, row.id,row.id_cat_it, 1);
                //frm.Size = new Size(950, 790);

                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    load_data();
                //}

                switch (id_tipo)
                {
                    case 1:
                        frmTickets form = new frmTickets(UsuarioLogeado, frmTickets.TipoTicket.IT, row.id);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            load_data();
                        }
                        break;

                    case 2:
                        frmTickets frm = new frmTickets(UsuarioLogeado, frmTickets.TipoTicket.Manto,row.id);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            load_data();
                        }
                        break;
                }

            }
            catch (Exception ex )
            {

                
            } 
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if(toggleSwitch1.IsOn)
            {
                //Solo activos
                MostrarTodos = 1;
                load_data();
            }
            else
            {
                //Mostrar todos.
                MostrarTodos = 0;
                load_data();
            }
        }

        private void btnEstado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdStatus = (GridView)grd_data.FocusedView;

            var row = (dsTickets.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

            xfrmChangeStatus frm = new xfrmChangeStatus(row.id_estado,row.id, UsuarioLogeado.UserId);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnUserAssigned_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdStatus = (GridView)grd_data.FocusedView;

            var row = (dsTickets.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

            xfrmChangeUserAssigned frm = new xfrmChangeUserAssigned(row.user_asignado,row.id, row.user_asignado,1);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}                                