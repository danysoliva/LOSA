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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using ACS.Tickets.EndUser;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmVerSeguimiento : DevExpress.XtraEditors.XtraForm
    {
        int id_ticket;
        UserLogin UsuarioLogeado;

        public frmVerSeguimiento(int pId_ticket, UserLogin pUser)
        {
            InitializeComponent();
            id_ticket = pId_ticket;
            LoadData();

            UsuarioLogeado = pUser;
        }

        private void LoadData()
        {
            try
            {

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    dsTickets.Seguimiento.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_TK_get_seguimiento_by_ticket", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.AddWithValue("@id_ticket",id_ticket);
                    da.Fill(dsTickets.Seguimiento);

                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnArchivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_seguimiento.FocusedView;
            var row = (dsTickets.SeguimientoRow)gv.GetDataRow(gv.FocusedRowHandle);

            frmVerAdjuntos frm = new frmVerAdjuntos(row.id, UsuarioLogeado);

            frm.ShowDialog();
        }
    }
}