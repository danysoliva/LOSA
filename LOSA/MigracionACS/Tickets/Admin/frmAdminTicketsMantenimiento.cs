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
using static LOSA.MigracionACS.Tickets.Admin.frmAdminTicketscs;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using ACS.Tickets.EndUser;
using LOSA.MigracionACS.Tickets.Reportes;
using DevExpress.XtraReports.UI;
using LOSA.MigracionACS.Tickets.Models;
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.EndUser;

namespace LOSA.MigracionACS.Tickets.Admin
{
    public partial class frmAdminTicketsMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int TipoSoporte;
        DataOperations dp = new DataOperations();


        TicketInfo ticketInfo = new TicketInfo();
        EmailTicketParams emailTcketParams = new EmailTicketParams();
        SecOps ops = new SecOps();

        int abierto = 1;

        public enum TipoTicket
        {
            IT = 1,
            Manto = 2
        }

        public frmAdminTicketsMantenimiento( TipoTicket OpType, UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;

            TipoSoporte = Convert.ToInt32( OpType);

            load_informacionM();
        }

        public void load_informacionM()
        {
            string query = @"[dbo].[sp_tk_load_tickets_to_admin_mantenimiento_V2]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@user_online",SqlDbType.Int).Value= UsuarioLogeado.UserId;
                cmd.Parameters.Add("@abierto",SqlDbType.Bit).Value= abierto;
                cmd.Parameters.Add("@id_tipo",SqlDbType.Int).Value= TipoSoporte;
                //cmd.Parameters.Add("@todos", SqlDbType.Bit).Value = tsVerTodosTickets.EditValue;
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

        private void tsAbiertasCerradas_Toggled(object sender, EventArgs e)
        {
            if (tsAbiertasCerradas.IsOn)
            {
                abierto = 1;
            }
            else
                abierto = 0;

            
            load_informacionM();
        }


        private void btncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPrioridad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdStatus = (GridView)grd_data.FocusedView;

            var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

            xfrmChangePriority frm = new xfrmChangePriority(row.id_prioridad, row.id, UsuarioLogeado.UserId);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_informacionM();
            }
        }

        private void btnUsuarioAsignado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {


            var grdStatus = (GridView)grd_data.FocusedView;

            var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);

                int id_ticket_ = row.id;

            xfrmChangeUserAssigned frm = new xfrmChangeUserAssigned(row.user_asignado, row.id, row.id_user, 2);//1=IT     2=Manto

            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_informacionM();
            }


            if (ticketInfo.RecuperaRegistro(id_ticket_))
            {
                //AddressCC direccionCC = new AddressCC();
                //List<AddressCC> direccionesCC = new List<AddressCC>();

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
                emailTcketParams.Subject = "El Ticket [#" + id_ticket_.ToString().PadLeft(9, '0') + "] ha cambiado de prioridad: ";
                emailTcketParams.Nombre = ticketInfo.UsuarioCreador;
                emailTcketParams.UsuarioAsignado = ticketInfo.UsuarioAsignado;
                emailTcketParams.Estado = ticketInfo.Estado;
                emailTcketParams.PrioridadTicket = ticketInfo.Prioridad;
                emailTcketParams.TituloTicket = ticketInfo.Titulo;

                    ops.SendEmailTicketChangeUserAssigned(emailTcketParams);

            }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEstado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var grdStatus = (GridView)grd_data.FocusedView;

            var row = (dsAdminT.ticketsRow)grdv_data.GetDataRow(grdStatus.FocusedRowHandle);


            if (row.id_estado < 5)
            {

                xfrmChangeStatus frm = new xfrmChangeStatus(row.id_estado, row.id, UsuarioLogeado.UserId);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_informacionM();
                }
            }
            else
            {
                CajaDialogo.Error("Ticket ya está cerrado");
            }
        }

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsAdminT.ticketsRow)gv.GetDataRow(gv.FocusedRowHandle);

            rpt_Ticket_Manto report = new rpt_Ticket_Manto(row.id);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            load_informacionM();
        }
    }
}