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
using LOSA.MigracionACS.Tickets.Reportes;
using DevExpress.XtraReports.UI;
using LOSA.Clases;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmTicketSeguimiento_TI : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado = new UserLogin();
        public frmTicketSeguimiento_TI(UserLogin puserLogin)
        {
            InitializeComponent();
            usuarioLogueado = puserLogin;

            if (usuarioLogueado.IsSuperUser)
            {
                grdv_data.OptionsMenu.EnableColumnMenu = true;
                grdv_data.Columns["agregar"].Visible = true;
            }
            else
            {
                grdv_data.OptionsMenu.EnableColumnMenu = false;
                grdv_data.Columns["agregar"].Visible = false;
            }
            load_data();
        }

    public void load_data()
    {
        string Query = @"[dbo].[sp_TK_get_tickets_by_seguimiento_TI]";
        try
        {
                if (tsAbiertasCerradas.IsOn)
                {
                    DataOperations dp = new DataOperations();

                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_user_asignado", 0);
                    dsTickets.tickets.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsTickets.tickets);
                    cn.Close();
                }
                else
                {
                    DataOperations dp = new DataOperations();

                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_user_asignado", usuarioLogueado.UserId);
                    dsTickets.tickets.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsTickets.tickets);
                    cn.Close();
                }

                



            }
        catch (Exception ex)
        {
            CajaDialogo.Error(ex.Message);
        }
    }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

 

        private void btnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsTickets.ticketsRow)gv.GetDataRow(gv.FocusedRowHandle);

            frmTicketSeguimiento_TI_CRUD frm = new frmTicketSeguimiento_TI_CRUD(row.id,row.user_asignado, usuarioLogueado.UserId, usuarioLogueado);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {


                var gv = (GridView)grd_data.FocusedView;
                var row = (dsTickets.ticketsRow)gv.GetDataRow(gv.FocusedRowHandle);

                frmVerSeguimiento frm = new frmVerSeguimiento(row.id,usuarioLogueado);

                frm.ShowDialog();
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

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_data.FocusedView;
            var row = (dsTickets.ticketsRow)gv.GetDataRow(gv.FocusedRowHandle);

            rpt_Ticket_Manto report = new rpt_Ticket_Manto(row.id);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void tsAbiertasCerradas_Toggled(object sender, EventArgs e)
        {
            load_data();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}