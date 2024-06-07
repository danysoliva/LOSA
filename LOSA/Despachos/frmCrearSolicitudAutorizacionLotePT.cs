using ACS.Classes;
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
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.Despachos
{
    public partial class frmCrearSolicitudAutorizacionLotePT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public bool Status;

        public enum Operacion 
        {   
            Insert = 1,
            Update = 2
        }

        Operacion TipoOP;

        public frmCrearSolicitudAutorizacionLotePT(UserLogin pUserLogin, Operacion pTipOP, int pid_solicitud)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            LoadLotes();
            LoadTipoSolicitud();

            TipoOP = pTipOP;

            switch (TipoOP)
            {
                case Operacion.Insert:
                    rdAprobar.Visible = false;
                    rdRechazar.Visible = false;

                    break;
                case Operacion.Update:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_get_info_solicitud_autorizacion_despacho_lote", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_solicitud", pid_solicitud);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            memoComentario.Text = dr.GetString(0);
                            grdLotePT.EditValue = dr.GetInt32(1);
                            grdTipoSoli.EditValue = dr.GetInt32(2);
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    rdAprobar.Visible = true;
                    rdAprobar.Checked = true;
                    rdRechazar.Visible = true;
                    memoComentario.Enabled = false;
                    grdTipoSoli.Enabled = false;
                    grdLotePT.Enabled = false;

                    break;
                default:
                    break;
            }

        }

        private void LoadTipoSolicitud()
        {
            try
            {
                string query = @"sp_get_tipo_notificacion";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesDespacho.tipo_solicitud.Clear();
                adat.Fill(dsTransaccionesDespacho.tipo_solicitud);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadLotes()
        {
            try
            {
                string query = @"sp_get_lotes_from_kardex";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesDespacho.lotes_pt.Clear();
                adat.Fill(dsTransaccionesDespacho.lotes_pt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            switch (TipoOP)
            {
                case Operacion.Insert:

                    bool LoteExiste = true;

                    if (string.IsNullOrEmpty(grdTipoSoli.Text))
                    {
                        CajaDialogo.Error("Debe seleccionar Tipo Solicitud!");
                        return;
                    }

                    if (string.IsNullOrEmpty(grdLotePT.Text))
                    {
                        CajaDialogo.Error("Debe seleccionar el Lote!");
                        return;
                    }

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_validar_existencia_solicitudV2]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_pt", grdLotePT.EditValue);
                        cmd.Parameters.AddWithValue("@tipo_soli", grdTipoSoli.EditValue);
                        LoteExiste = Convert.ToBoolean(cmd.ExecuteScalar());
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    if (LoteExiste == true)
                    {
                        CajaDialogo.Error("Ya existe la Solicitud de este Lote de PT");
                        return;
                    }

                    

                    if (string.IsNullOrEmpty(memoComentario.Text))
                    {
                        CajaDialogo.Error("Debe Agregar un Comentario!");
                        return;
                    }

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_solicitud_despacho_lote", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_usuario_solicitante", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@comentario", memoComentario.Text);
                        cmd.Parameters.AddWithValue("@lote_pt", grdLotePT.EditValue);
                        cmd.Parameters.AddWithValue("@tipo_solicitud_despacho", grdTipoSoli.EditValue);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    CajaDialogo.Information("Solicitud de Autorizacion Creada!\nDebe esperar la Aprobacion del Dpt. Calidad y Finanzas!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    break;
                case Operacion.Update:

                    if (rdAprobar.Checked)
                        Status = true; //Aprobado
                    else
                        Status = false; //Rechazado

                    this.DialogResult = DialogResult.OK;
                    this.Close();


                    break;
                default:
                    break;
            }

           

        }


    }
}