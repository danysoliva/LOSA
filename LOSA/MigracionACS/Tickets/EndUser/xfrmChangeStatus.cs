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
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.Models;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class xfrmChangeStatus : DevExpress.XtraEditors.XtraForm
    {
        int statusID = 0;
        int idTicket = 0;
        int id_user = 0;

        EmailTicketParams emailTcketParams = new EmailTicketParams();
        SecOps ops = new SecOps();
        TicketInfo ticketInfo = new TicketInfo();

        public xfrmChangeStatus(int pIdStatus, int pIdTicket, int pid_user)
        {
            InitializeComponent();
            load_status();
            statusID = pIdStatus;
            idTicket = pIdTicket;
            id_user = pid_user;
        }

        void load_status()
        {
            string Query = @"dbo.sp_TK_load_status";
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cnx.Open();
                //SqlCommand cmd = new SqlCommand(Query, cnx);
                //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tk.Id));
                SqlDataAdapter da = new SqlDataAdapter(Query, cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                dsTickets.Status.Clear();
                da.Fill(dsTickets.Status);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmChangeStatus_Load(object sender, EventArgs e)
        {
            lueStatus.EditValue = statusID;
        }

        private void bbCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void CambiarStatus()
        {

            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("sp_TK_update_status", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_ticket", SqlDbType.Int).Value = idTicket;
                    cmd.Parameters.Add("@id_estado", SqlDbType.Int).Value = lueStatus.EditValue;
                    cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = id_user;
                    cmd.Parameters.Add("@estado_descripcion", SqlDbType.VarChar).Value = lueStatus.Text;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

                //CajaDialogo.Information("El estado del ticket #"+idTicket+" ha sido cambiado exitosamente");

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void bbGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                CambiarStatus();

              
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}