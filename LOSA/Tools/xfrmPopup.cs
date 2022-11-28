using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.TransaccionesMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Tools
{
    public partial class xfrmPopup : DevExpress.XtraEditors.XtraForm
    {
        //int userId;

        UserLogin usuarioLogueado = new UserLogin();
        
        enum TipoNotificacion
        {
            NuevaActualizacion=1,
            NuevaSolicitudAutorizacion=2,
            ProcesoSolicitud=3,
            MateriaPrimaPorVencer=4
        }

        public xfrmPopup(UserLogin pUserLogin)
        {
            usuarioLogueado = pUserLogin;

            InitializeComponent();
            LoadNotificacionesLeidas(usuarioLogueado.Id);
            LoadNotificacionesSinLeer(usuarioLogueado.Id);
        }

        public void LoadNotificacionesSinLeer(int id_user)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_ALOSY_getnotificaciones",cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.Add("@id_user",SqlDbType.Int).Value=id_user;
                    da.SelectCommand.Parameters.Add("@leidos",SqlDbType.Bit).Value=0;

                    dsTools.Notificaciones.Clear();

                    da.Fill(dsTools.Notificaciones);
                    
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void LoadNotificacionesLeidas(int id_user)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_ALOSY_getnotificaciones", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.Add("@id_user", SqlDbType.Int).Value = id_user;
                    da.SelectCommand.Parameters.Add("@leidos", SqlDbType.Bit).Value = 1;

                   dsTools.NotificacionesLeidas.Clear();

                    da.Fill(dsTools.NotificacionesLeidas);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvSinLeer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                NotificacionesGenerales notifications = new NotificacionesGenerales();
                DataOperations dp = new DataOperations();

                var row = (dsTools.NotificacionesRow)gvSinLeer.GetFocusedDataRow();

                if (row!= null)
                {
                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("dbo.sp_set_notificaciones_marcar_como_leido", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();

                        row.leida = true;

                        cnx.Close();
                    }

                    LoadNotificacionesLeidas(usuarioLogueado.Id);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnIr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsTools.NotificacionesRow)gvSinLeer.GetFocusedDataRow();
                DataOperations dp = new DataOperations();

                if (row != null)
                {


                    switch (row.id_tipo_notificacion)
                    {
                        case (int)TipoNotificacion.NuevaActualizacion:
                            CajaDialogo.Information(row.Descripcion);
                            break;

                        case (int)TipoNotificacion.MateriaPrimaPorVencer:

                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                            {
                                cnx.Open();

                                SqlCommand cmd = new SqlCommand("dbo.sp_set_notificaciones_marcar_como_leido", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                                cmd.ExecuteNonQuery();

                                row.leida = true;

                                cnx.Close();
                            }

                            LoadNotificacionesLeidas(usuarioLogueado.Id);


                            frmReporteKardexGeneralVencimiento frm = new frmReporteKardexGeneralVencimiento(usuarioLogueado);
                            if (this.MdiParent != null)
                                frm.MdiParent = this.MdiParent;
                            frm.Show();

                            this.Close();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (tpLeidas.SelectedPageIndex == 0)
            {
                foreach (dsTools.NotificacionesRow row in dsTools.Notificaciones)
                {
                    try
                    {
                        NotificacionesGenerales notifications = new NotificacionesGenerales();
                        DataOperations dp = new DataOperations();
                        if (row != null)
                        {
                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                            {
                                cnx.Open();
                                SqlCommand cmd = new SqlCommand("dbo.sp_set_notificaciones_marcar_como_leido", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                                cmd.ExecuteNonQuery();
                                row.leida = true;
                                cnx.Close();
                            }
                            LoadNotificacionesLeidas(usuarioLogueado.Id);
                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
        }
    }
}