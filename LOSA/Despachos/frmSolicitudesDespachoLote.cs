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
using System.Data;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Despachos
{
    public partial class frmSolicitudesDespachoLote : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado = new UserLogin();
        public frmSolicitudesDespachoLote(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLog;
            LoadData();

            switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Logistica:
                    btnAddSolicitud.Visible = true;
                    grd_data.OptionsMenu.EnableColumnMenu = false;
                    grd_data.OptionsFilter.AllowFilterEditor = false;
                    //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    grd_data.Columns["Gestionar"].Visible = false;
                    //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
                    break;

                case GrupoUser.GrupoUsuario.Calidad:

                    int idNivelCalidad = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);
                    switch (idNivelCalidad)
                    {
                        case 1://Basic View
                            btnAddSolicitud.Visible = false;
                            grd_data.OptionsMenu.EnableColumnMenu = false;
                            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                            grd_data.Columns["Gestionar"].Visible = false;
                            grd_data.OptionsFilter.AllowFilterEditor = false;
                            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
                            break;
                        case 2://Basic No Autorization
                        case 3://Medium Autorization                           
                        case 4://Depth With Delta
                        case 5://Depth Without Delta
                            btnAddSolicitud.Visible = false;
                            grd_data.OptionsMenu.EnableColumnMenu = false;
                            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                            grd_data.Columns["Gestionar"].Visible = true;
                            grd_data.OptionsFilter.AllowFilterEditor = false;
                            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
                            break;
                        default:
                            
                            break;
                    }

                    break;

                case GrupoUser.GrupoUsuario.Contabilidad:
                    int idNivelContabilidad = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);
                    switch (idNivelContabilidad)
                    {
                        case 1://Basic View
                            btnAddSolicitud.Visible = false;
                            grd_data.OptionsMenu.EnableColumnMenu = false;
                            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                            grd_data.Columns["Gestionar"].Visible = false;
                            grd_data.OptionsFilter.AllowFilterEditor = false;
                            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
                            break;
                        case 2://Basic No Autorization
                        case 3://Medium Autorization                           
                        case 4://Depth With Delta
                        case 5://Depth Without Delta
                            btnAddSolicitud.Visible = false;
                            grd_data.OptionsMenu.EnableColumnMenu = false;
                            //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                            grd_data.Columns["Gestionar"].Visible = true;
                            grd_data.OptionsFilter.AllowFilterEditor = false;
                            //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets
                            break;
                        default:

                            break;
                    }



                 
                    break;

                case GrupoUser.GrupoUsuario.Administradores:
                    btnAddSolicitud.Visible = true;
                    grd_data.OptionsMenu.EnableColumnMenu = true;
                    //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    grd_data.Columns["Gestionar"].Visible = true;
                    //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el datasets

                    break;

                default:

                    break;

            }
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_solicitudes_despacho_lote_with_filtro]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@filtro", tsFiltro.IsOn);

                    dsTransaccionesDespacho1.solicitudes_lote_despachos.Clear();

                    //da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                    da.Fill(dsTransaccionesDespacho1.solicitudes_lote_despachos);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsFiltro_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddSolicitud_Click(object sender, EventArgs e)
        {
            frmCrearSolicitudAutorizacionLotePT frm = new frmCrearSolicitudAutorizacionLotePT(UsuarioLogueado, frmCrearSolicitudAutorizacionLotePT.Operacion.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnGestionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsTransaccionesDespacho.solicitudes_lote_despachosRow)gridview.GetFocusedDataRow();

            switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Calidad:
                    if (row.status_calidad == true)
                    {
                        CajaDialogo.Error("La Solicitud ya fue Aprobada por Calidad");
                        return;
                    }
                        
                    break;

                case GrupoUser.GrupoUsuario.Administradores:
                    break;

                case GrupoUser.GrupoUsuario.Contabilidad:
                    if (row.status_finanzas == true)
                    {
                        CajaDialogo.Error("La Solicitud ya fue Aprobada por Contabalidad");
                        return;
                    }
                        
                    break;

                default:
                    break;
            }

            frmCrearSolicitudAutorizacionLotePT frm = new frmCrearSolicitudAutorizacionLotePT(UsuarioLogueado, frmCrearSolicitudAutorizacionLotePT.Operacion.Update, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_update_solicitud_despacho_lote", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_solicitud", row.id);
                    cmd.Parameters.AddWithValue("@id_usuario_aprob", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@bit_status", frm.Status);
                    cmd.Parameters.AddWithValue("@grupo_alosy", UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo);
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                CajaDialogo.Information("Solicitud Actualizada!");
                LoadData();
            }

           
        }
    }
}