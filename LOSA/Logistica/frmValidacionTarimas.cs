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

        }

        private void InfoMensaje(string pMensaje, int ptipo)
        {
            if (ptipo == 1) //Error
            {
                lblMensaje.Text = pMensaje;
            }
            else //Info
            {
                lblMensaje.Text = pMensaje;
            }
            
        
        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tarima tm = new Tarima();
                tm.RecuperarTarimaPorCodBarra(txtTarima.Text.Trim());
                id_tarima = tm.Id;
                id_estado_original_tarima = tm.Id_estado_tarima;
                if (id_estado_original_tarima == 11) //Retenida por Logistica
                {
                    LoadDatosTarima(id_tarima);
                }
                else
                {
                    Mensaje = "Esta Tarima no se encuentra en Estado: Retenida por Logistica";                  
                    InfoMensaje(Mensaje, 1);
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
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea guardar y activar la Tarima");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            if (tsEditarTarima.IsOn)
            {
                if (string.IsNullOrEmpty(txtLoteMP.Text))
                {
                    Mensaje = "No puede dejar vacio el Campo de Lote";
                    
                    InfoMensaje(Mensaje, 1);
                }
                if (true)
                {

                }


                //Vamos a Guardar con los Cambios, en tarima, vamos a guardar un log y vamos a insertar Kardex
            }
            else
            {
                //Vamos solo a Activar la Tarima
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

        private void grdPresentacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (string.IsNullOrEmpty(grdPresentacion.Text))
            {

            }
            else
            {
                
                if (grdPresentacion.Text != "")
                {
                    PresentacionX pres1 = new PresentacionX();

                    pres1.RecuperarRegistro(Convert.ToInt32(grdPresentacion.EditValue));
                    int Unidades = Convert.ToInt32(txtUnidades.EditValue);
                    decimal Peso = Convert.ToDecimal(txtPeso.EditValue);
                    


                }
            }
        }
    }
}