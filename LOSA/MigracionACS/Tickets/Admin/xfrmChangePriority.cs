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
using System.Data.SqlClient;
using LOSA.MigracionACS.Tickets.Models;
using LOSA.Clases;

namespace LOSA.MigracionACS.Tickets.Admin
{
    public partial class xfrmChangePriority : DevExpress.XtraEditors.XtraForm
    {
        int idTicket;
        int id_Prioridad;
        int id_user;

        EmailTicketParams emailTcketParams = new EmailTicketParams();
        SecOps ops = new SecOps();
        TicketInfo ticketInfo = new TicketInfo();

        public xfrmChangePriority(int idPrioridad, int id_Ticket, int pIdUser)
        {
            InitializeComponent();
            id_Prioridad = idPrioridad;
            idTicket = id_Ticket;
            id_user = pIdUser;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void load_Priority()
        {
            string Query = @"dbo.sp_TK_get_prioridad";
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cnx.Open();
                //SqlCommand cmd = new SqlCommand(Query, cnx);
                //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tk.Id));
                SqlDataAdapter da = new SqlDataAdapter(Query, cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dsAdminT.Prioridad.Clear();
                da.Fill(dsAdminT.Prioridad);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmChangePriority_Load(object sender, EventArgs e)
        {
            load_Priority();
            luePrioridad.EditValue = id_Prioridad;
        }

        private void CambiarPrioridad()
        {

            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("[dbo].[sp_TK_update_prioridad]", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_ticket", SqlDbType.Int).Value = idTicket;
                    cmd.Parameters.Add("@id_prioridad", SqlDbType.Int).Value = luePrioridad.EditValue;
                    cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = id_user;
                    cmd.Parameters.Add("@prioridad_descripcion", SqlDbType.VarChar).Value = luePrioridad.Text;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

                //CajaDialogo.Information("Se ha cambiado la prioridad del ticket a " + luePrioridad.Text);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                //throw;
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CambiarPrioridad();

            //if (ticketInfo.RecuperaRegistro(idTicket))
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
                
            //    emailTcketParams.CorreosCC=copyMails;

            //    emailTcketParams.TicketID = ticketInfo.ID;
            //    emailTcketParams.IsHTML = true;
            //    emailTcketParams.Body = ticketInfo.Comentario;
            //    emailTcketParams.Subject = "El Ticket [#" + idTicket.ToString().PadLeft(9, '0') + "] ha cambiado de prioridad: ";
            //    emailTcketParams.Nombre = ticketInfo.UsuarioCreador;
            //    emailTcketParams.UsuarioAsignado = ticketInfo.UsuarioAsignado;
            //    emailTcketParams.Estado = ticketInfo.Estado;
            //    emailTcketParams.PrioridadTicket = ticketInfo.Prioridad;
            //    emailTcketParams.TituloTicket = ticketInfo.Titulo;

            //    ops.SendEmailTicketChangePrioridad(emailTcketParams);

            //}
            this.DialogResult = DialogResult.OK;
        }
    }
}