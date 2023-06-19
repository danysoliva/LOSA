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
using LOSA.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.Tickets.EndUser;
using LOSA.MigracionACS.Tickets.Reportes;
using DevExpress.XtraReports.UI;
using LOSA.MigracionACS.Tickets.Models;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.MigracionACS.Tickets.Admin
{
    public partial class frmAdminTicketscs : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;
        TipoTicket TipoSoporte;
        DataOperations dp = new DataOperations();

        EmailTicketParams emailTcketParams = new EmailTicketParams();
        SecOps ops = new SecOps();
        TicketInfo ticketInfo = new TicketInfo();

        int abierto = 1;


        public enum TipoTicket
        {
            IT = 1,
            Manto = 2
        }


        public frmAdminTicketscs(TipoTicket OpType, UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            TipoSoporte = OpType;
            if (TipoSoporte == TipoTicket.IT)
            {
                this.Text = "Administracion y respuestas de tickets (Sistemas).";
            }
            else
            {
                this.Text = "Administracion y respuestas de tickets (Mantenimiento).";
            }
            load_informacionI();
        }

        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void load_informacionI()
        {
            string query = @"[dbo].[sp_tk_load_tickets_to_admin_TI]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user_online", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@abierto", abierto);
                cmd.Parameters.AddWithValue("@id_tipo", TipoSoporte);
                //cmd.Parameters.AddWithValue("@todos", tsVerTodosTickets.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsAdminT.tickets.Clear();
                da.Fill(dsAdminT.tickets);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void frmAdminTicketscs_Load(object sender, EventArgs e)
        {


        }
        public void load_all_tickets()
        {
            string query = @"sp_tk_load_tickets_to_admin_all_tickets";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsAdminT.tickets.Clear();
                da.Fill(dsAdminT.tickets);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

 

        private void btnEstado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {


                var grdStatus = (GridView)grd_data.FocusedView;

                var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

                int _idTicket = row.id;

                if (row.id_estado < 5)
                {

                    xfrmChangeStatus frm = new xfrmChangeStatus(row.id_estado, row.id, UsuarioLogeado.UserId);

                    //_idTicket = row.id;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        load_informacionI();
                        //}
                        //else
                        //{
                        if (ticketInfo.RecuperaRegistro(_idTicket))
                        {

                            emailTcketParams.Destinatario = ticketInfo.UsuarioCreadorMail;

                            List<string> copyMails = new List<string>();


                            if (ticketInfo.copiaCorreos != null)
                            {

                                foreach (var email in ticketInfo.copiaCorreos)
                                {
                                    copyMails.Add(email);
                                }
                            }

                            //Agregar a las copias de correo al usuario asignado
                            copyMails.Add(ticketInfo.UsuarioAsignadoMail);

                            emailTcketParams.CorreosCC = copyMails;


                            emailTcketParams.TicketID = ticketInfo.ID;
                            emailTcketParams.IsHTML = true;
                            emailTcketParams.Body = ticketInfo.Comentario;
                            emailTcketParams.Subject = "El Ticket [#" + _idTicket.ToString().PadLeft(9, '0') + "] ha cambiado de estado: ";
                            emailTcketParams.Nombre = ticketInfo.UsuarioCreador;
                            emailTcketParams.UsuarioAsignado = ticketInfo.UsuarioAsignado;
                            emailTcketParams.Estado = ticketInfo.Estado;
                            emailTcketParams.PrioridadTicket = ticketInfo.Prioridad;
                            emailTcketParams.TituloTicket = ticketInfo.Titulo;

                            ops.SendEmailTicketChangeStatus(emailTcketParams);

                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("Ticket ya está cerrado");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnUsuarioAsignado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {


                var grdStatus = (GridView)grd_data.FocusedView;

                var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

                int id_ticket_ = row.id;
                xfrmChangeUserAssigned frm = new xfrmChangeUserAssigned(row.user_asignado, row.id, row.user_asignado, 1);//1=IT    2=Manto


                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_informacionI();



                    //if (ticketInfo.RecuperaRegistro(id_ticket_))
                    //{
                    //    emailTcketParams.Destinatario = ticketInfo.UsuarioCreadorMail;

                    //    List<string> copyMails = new List<string>();


                    //    if (ticketInfo.copiaCorreos != null)
                    //    {

                    //        foreach (var email in ticketInfo.copiaCorreos)
                    //        {
                    //            copyMails.Add(email);
                    //        }
                    //    }

                    //    //Agregar a las copias de correo al usuario asignado
                    //    copyMails.Add(ticketInfo.UsuarioAsignadoMail);

                    //    emailTcketParams.CorreosCC = copyMails;

                    //    //emailTcketParams.DireccionesCC = direccionesCC;


                    //    emailTcketParams.TicketID = ticketInfo.ID;
                    //    emailTcketParams.IsHTML = true;
                    //    emailTcketParams.Body = ticketInfo.Comentario;
                    //    emailTcketParams.Subject = "El Ticket [#" + id_ticket_.ToString().PadLeft(9, '0') + "] ha cambiado de prioridad: ";
                    //    emailTcketParams.Nombre = ticketInfo.UsuarioCreador;
                    //    emailTcketParams.UsuarioAsignado = ticketInfo.UsuarioAsignado;
                    //    emailTcketParams.Estado = ticketInfo.Estado;
                    //    emailTcketParams.PrioridadTicket = ticketInfo.Prioridad;
                    //    emailTcketParams.TituloTicket = ticketInfo.Titulo;

                    //    ops.SendEmailTicketChangeUserAssigned(emailTcketParams);

                    //}
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnPrioridad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdStatus = (GridView)grd_data.FocusedView;

            var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

            xfrmChangePriority frm = new xfrmChangePriority(row.id_prioridad, row.id, UsuarioLogeado.UserId);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_informacionI();
            }
        }


        private void tsAbiertasCerradas_Toggled(object sender, EventArgs e)
        {

            if (tsAbiertasCerradas.IsOn)
            {
                abierto = 1;
            }
            else
                abierto = 0;

            load_informacionI();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnConfi_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsAdminT.ticketsRow)gv.GetDataRow(gv.FocusedRowHandle);

            rpt_Ticket_TI report = new rpt_Ticket_TI(row.id);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void btnAdjuntos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdv_data.FocusedRowHandle);
            xfrmVerAdjuntosAdmin frm = new xfrmVerAdjuntosAdmin(UsuarioLogeado, row.id);

            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            load_informacionI();
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsAdminT.ticketsRow)gv.GetDataRow(gv.FocusedRowHandle);

            frmViewInfoTicket frm = new frmViewInfoTicket(row.id);
            frm.ShowDialog();
        }
    }
}