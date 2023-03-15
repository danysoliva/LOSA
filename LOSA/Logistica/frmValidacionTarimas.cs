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
using System.Data.SqlClient;
using LOSA.Clases;
using LOSA.Logistica;

namespace LOSA.Logistica
{
    public partial class frmValidacionTarimas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_tarima;
        string codigo_barra;
        int id_estado_original_tarima;
        UserLogin UsuarioLogeado;
        string Mensaje = "";
        
        public frmValidacionTarimas(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            LoadPresentaciones();
            LimpiarControles();
            DeshabilitarControles();
        }

        private void InfoMensaje(string pMensaje, int ptipo)
        {
            if (ptipo == 1) //Error
            {
                lblMensaje.Text = pMensaje;
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();

            }
            else //Guardado
            {
                lblMensaje.Text = pMensaje;
                panelNotificacion.BackColor = Color.MediumSeaGreen;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
            }
            
        
        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tarima tm = new Tarima();
                tm.RecuperarRegistro_v3(0,txtTarima.Text.Trim());
                id_tarima = tm.Id;
                id_estado_original_tarima = tm.Id_estado_tarima;

                switch (id_estado_original_tarima)
                {
                    case 1: //Recepcionado
                        Mensaje = "Esta Tarima no a sido Activada por parte del Monta Carguista, Estado Tarima: Recepcionada";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 2: //En Bodega
                        Mensaje = "Estado de Tarima: En Bodega, Tarima Activada!";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 4: //Comprometido
                        Mensaje = "Estado de Tarima: Comprometida";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 5://En Produccion
                        Mensaje = "Tarima Duplicada, Esta Tarima ya fue Entregada a Produccion!";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 6: //Consumido por el depto de Produccion
                        Mensaje = "Tarima Consumida por el Depto. de Produccion!";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 8: //Parcialmente Entregado
                        Mensaje = "Estado de Tarima: Parcialmente Entregado, Tarima Activada!";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 9: //Rechazado
                        Mensaje = "Estado Tarima: Rechazada!";
                        InfoMensaje(Mensaje, 1);
                        break;

                    case 11: //Retenida por Logistica
                        LoadDatosTarima(id_tarima);
                        break;

                    default:
                        Mensaje = "La Tarima no tiene ninguno estado configurado, Contactar al Dpto de IT";
                        InfoMensaje(Mensaje, 1);

                        break;
                }


            }
        }

        private void LoadPresentaciones()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLogistica21.presentaciones.Clear();
                da.Fill(dsLogistica21.presentaciones);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void LoadDatosTarima(int id_tarima)
        {
           
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_load_data_tarima_mp_validacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", id_tarima);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLogistica21.validacion_tarimas.Clear();
                da.Fill(dsLogistica21.validacion_tarimas);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void LimpiarControles()
        {
            txtLoteMP.Text = "";
            txtUnidades.EditValue = 0;
            txtPeso.EditValue = 0;
            grdPresentacion.Text = "";
        }

        private void HabilitarControles()
        {
            txtLoteMP.Enabled = true;
            txtUnidades.Enabled = true;
            grdPresentacion.Enabled = true;
        }
        private void DeshabilitarControles()
        {
            txtLoteMP.Enabled = false;
            txtUnidades.Enabled = false;
            grdPresentacion.Enabled = false;
        }


        private void tsEditarTarima_Toggled(object sender, EventArgs e)
        {
            if (tsEditarTarima.IsOn)
            {

                HabilitarControles();

                foreach (dsLogistica2.validacion_tarimasRow row in dsLogistica21.validacion_tarimas.Rows)
                {
                    if (gridLookUpEdit1View.RowCount == 0)
                    {
                        txtLoteMP.Text = row.lote_materia_prima;
                        txtUnidades.EditValue = Convert.ToInt32(row.cantidad);
                        txtPeso.EditValue = row.peso;
                        grdPresentacion.EditValue = row.id_presentacion;
                    }
                }
            }
            else
            {
                LimpiarControles();
                DeshabilitarControles();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea guardar y activar la Tarima?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            if (string.IsNullOrEmpty(txtTarima.Text))
            {
                Mensaje = "Escanee una Tarima";
                InfoMensaje(Mensaje, 1);
            }
            else
            {
                bool Guardar;

                if (tsEditarTarima.IsOn)//Vamos a Actualizar la Tarima, Validemos los Campos
                {
                    if (string.IsNullOrEmpty(txtLoteMP.Text))
                    {
                        Mensaje = "No puede dejar vacio el Campo de Lote";

                        InfoMensaje(Mensaje, 1);
                    }
                    if (string.IsNullOrEmpty(grdPresentacion.Text))
                    {
                        Mensaje = "Debe seleccionar una Presentacion.";
                        InfoMensaje(Mensaje, 1);
                    }
                    if (Convert.ToInt32(txtPeso.EditValue) <= 0)
                    {
                        Mensaje = "El Peso no puede ser (0)";
                        InfoMensaje(Mensaje, 1);
                    }
                    if (Convert.ToInt32(txtUnidades.EditValue) <= 0)
                    {
                        Mensaje = "Las Unidadres no pueden ser menor o igual que (0)";
                        InfoMensaje(Mensaje, 1);
                    }

                    //Vamos a Guardar con los Cambios en tarima, vamos a guardar un log y vamos a insertar Kardex

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_tarima_and_insert_kardex", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tarima", id_tarima);
                        cmd.Parameters.AddWithValue("@loteMP", txtLoteMP.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_presentacion", Convert.ToInt32(grdPresentacion.EditValue));
                        cmd.Parameters.AddWithValue("@unidades", txtUnidades.EditValue);
                        cmd.Parameters.AddWithValue("@peso", txtPeso.EditValue);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        //cmd.ExecuteNonQuery();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        Guardar = false;
                        CajaDialogo.Error(ec.Message);
                    }

                }
                else
                {
                    //Vamos solo a Activar la Tarima

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_update_tarima_and_insert_kardex_activacion", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tarima", id_tarima);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        //cmd.ExecuteNonQuery();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        Guardar = false;
                        CajaDialogo.Error(ec.Message);
                    }

                }

                if (Guardar)
                {
                    Mensaje = "Tarima Activada!";
                    InfoMensaje(Mensaje, 2);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTarima.Text = "";
            LimpiarControles();
            DeshabilitarControles();
            tsEditarTarima.IsOn = false;
            //vGridDatosTarima.DataSource = null;
            //vGridDatosTarima.DataBindings();
        }


        private void CalculoPeso()
        {
            PresentacionX pres1 = new PresentacionX();

            pres1.RecuperarRegistro(Convert.ToInt32(grdPresentacion.EditValue));
            int Unidades = Convert.ToInt32(txtUnidades.EditValue);

            txtPeso.EditValue = Unidades * pres1.Factor;

        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(grdPresentacion.Text))
            {
                //nada.. hasta que seleccione una presentacion.
            }
            else
            {
                CalculoPeso();
            }
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            txtTarima.Text = "";
            vGridDatosTarima.DataSource = null;
            lblMensaje.Text = "";
            txtTarima.Focus();
        }

        private void grdPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdPresentacion.Text))
            {

            }
            else
            {

                if (grdPresentacion.Text != "")
                {
                    CalculoPeso();
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}