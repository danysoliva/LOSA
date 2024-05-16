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
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.FromAMS
{
    public partial class frmAprobacionesSalidaMercancia : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;

        public frmAprobacionesSalidaMercancia(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            LoadSolicitudes();
        }

        private void LoadSolicitudes()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_solicitudes_aprobacion_salidas_mercancia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario",UsuarioLogueado.Id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsAprobacionDocumentos1.SolicitudDocumentos_.Clear();
                adat.Fill(dsAprobacionDocumentos1.SolicitudDocumentos_);
                conn.Close();

                SqlConnection conn2 = new SqlConnection(dp.ConnectionStringAMS);
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("[sp_get_solicitudes_aprobacion_salidas_mercancia_all]", conn2);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@IdUsuario", UsuarioLogueado.Id);
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsAprobacionDocumentos1.SolicitudDocumentos_all.Clear();
                adat2.Fill(dsAprobacionDocumentos1.SolicitudDocumentos_all);
                conn2.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGestionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsAprobacionDocumentos.SolicitudDocumentos_Row)gridview.GetFocusedDataRow();

           
            frmAprobacionesConfirmacion frm = new frmAprobacionesConfirmacion(row.id_h);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bool IsCommit = false;
                int idEstadoNew = 0;

                string EstadoNameNew = string.Empty;


                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_set_solicitud_aprobacion_requisas", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (frm.IsApproved)
                        idEstadoNew = 4;
                    else
                        idEstadoNew = 3;

                    cmd.Parameters.AddWithValue("@id_estado", idEstadoNew);
                    cmd.Parameters.AddWithValue("@id_user_aprobo", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_soilicitud_aprobacion", row.id_h);
                    if (string.IsNullOrEmpty(frm.Comentario))
                        cmd.Parameters.AddWithValue("@comentario", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@comentario", frm.Comentario);
                    cmd.Parameters.AddWithValue("@id_requisa", row.id_requisa);
                    cmd.ExecuteNonQuery();

                    row.id_estado = idEstadoNew;
                    Aprobaciones EstadoActual = new Aprobaciones();
                    if (EstadoActual.RecuperarRegistro(idEstadoNew))
                    {
                        row.estado = EstadoActual.Estado;
                    }
                }
                catch (Exception EX)
                {
                    CajaDialogo.Error(EX.Message);
                }

            }
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadSolicitudes();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}