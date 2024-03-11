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

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class xfrmChangeUserAssigned : DevExpress.XtraEditors.XtraForm
    {
        int userID = 0;
        int idTicket = 0;
        int IduserActual;
        int IdTipoTicket;
        int IdUserNewAssigned;
        public xfrmChangeUserAssigned(int puserId, int pIdTicket, int pIduserActual, int pIdTipoTicket)
        {
            InitializeComponent();
            userID = puserId;
            idTicket = pIdTicket;
            IduserActual = pIduserActual;
            IdTipoTicket = pIdTipoTicket;
        }


        void load_Users()
        {
            string Query = @"[dbo].[sp_TK_load_usuarios_asignados]";
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_user_actual", IduserActual);
                da.SelectCommand.Parameters.AddWithValue("@id_tipo_ticket", IdTipoTicket);
                dsTickets.Usuario_Asignado.Clear();
                da.Fill(dsTickets.Usuario_Asignado);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmChangeUserAssigned_Load(object sender, EventArgs e)
        {
            load_Users();
        }

        private void AsignarUsuario(int pidUserNewAssigned)
        {

            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    UserLogin User = new UserLogin();
                    if (User.RecuperarRegistro(IdUserNewAssigned))
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("[dbo].[sp_TK_asignar_usuario]", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id_ticket", SqlDbType.Int).Value = idTicket;
                        cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = IdUserNewAssigned;
                        cmd.Parameters.Add("@usuario_nombre", SqlDbType.VarChar).Value = User.NombreUser;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }
                    
                }

                //CajaDialogo.Information("El ticket ha sido asignado el usuario "+ slueUsuario.Text);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            AsignarUsuario(IdUserNewAssigned);
            this.DialogResult = DialogResult.OK;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lueUser_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsTickets.Usuario_AsignadoRow)gridView.GetFocusedDataRow();

            //IdUserNewAssigned = row.id;
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionado")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsTickets.Usuario_AsignadoRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    IdUserNewAssigned = row.id;
                    row.seleccionado = true;
                }

                foreach (dsTickets.Usuario_AsignadoRow row1 in dsTickets.Usuario_Asignado)
                {
                    if (row1.id != IdUserNewAssigned)
                        row1.seleccionado = false;
                }
            }
                
        }
    }
}