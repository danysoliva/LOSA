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
using ACS.Classes;
using LOSA.Clases;
using LOSA.MigracionACS.PT;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class PT_Producto_Borrador : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        public PT_Producto_Borrador(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            toggleSwitchVerTodos.IsOn = true;
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                string FixedQuery = "[sp_get_borrador_solicitudes_portafolio_pt]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(FixedQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (toggleSwitchVerTodos.IsOn == true)
                    cmd.Parameters.AddWithValue("@estado", 1);
                else
                    cmd.Parameters.AddWithValue("@estado", 0);
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                dsTickets1.Productos.Clear();
                Da.Fill(dsTickets1.Productos);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCRUDProductoTerminado frm = new frmCRUDProductoTerminado(UsuarioLogueado, frmCRUDProductoTerminado.TipoOperacion.SolicitudInsert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void toggleSwitchVerTodos_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryRechazar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea Rechazar esta Solicitud de Producto Terminado?");
            if (r != DialogResult.Yes)
                return;

            var gridview = (GridView)grdProductoBorrador.FocusedView;
            var row = (dsTickets.ProductosRow)gridview.GetFocusedDataRow();

            int id_estado = 3; //Rechazado

            switch (row.id_estado_borrador)
            {
                case 1: //Pendiente

                    UpdateSolicitud(id_estado, row.id);
                    
                    break;

                case 2: //Aprobado

                    CajaDialogo.Error("Esta Solicitud ya se encuentra Aprobada!");

                    break;

                case 3:

                    CajaDialogo.Error("Esta Solicitud ya se encuenta Rechazada!");
                    break;

                case 4:
                  
                    CajaDialogo.Error("Esta Solicitud ya se encuentra Cancelada!");

                    break;
                default:
                    break;
            }

        }

        private void UpdateSolicitud(int id_estado, int id_solicitud)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_actualizar_solicitud_pt", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado_borrador", id_estado);
                cmd.Parameters.AddWithValue("@id_solicitud", id_solicitud);
                cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                cmd.ExecuteNonQuery();

                LoadData();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}