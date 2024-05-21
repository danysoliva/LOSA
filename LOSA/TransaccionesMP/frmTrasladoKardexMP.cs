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
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.RecepcionMP;
using LOSA.Clases;
using LOSA.Calidad.LoteConfConsumo;

namespace LOSA.TransaccionesMP
{
    public partial class frmTrasladoKardexMP : DevExpress.XtraEditors.XtraForm
    {
        private string ItemCode;//Codigo MP de SAP
        DataOperations dp = new DataOperations();
        private decimal factorValue;
        private int Id_MP;
        UserLogin UsuarioLogueado;
        private decimal FactorUnidades;
        MateriaPrima MateriaPrimaActual;
        private decimal existencia_bodega_selected;
        private string bodega_selected;

        public frmTrasladoKardexMP(UserLogin PuserLog)
        {
            InitializeComponent();
            UsuarioLogueado = PuserLog;
            
            dtFechaDocumento.EditValue = dp.Now();
            LoadPresentaciones();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtNumLote_Click(object sender, EventArgs e)
        {
            
            frmTrasladoKardexLotesExistencia frm = new frmTrasladoKardexLotesExistencia(Id_MP);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                FactorUnidades = frm.Factor;

                spinEditUnidades.Focus();
            }
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (gvLookUpEditPresentacion.RowCount <= 0)
            {
                this.factorValue = 0;
            }
            else
            {
                PresentacionX pres1 = new PresentacionX();
                pres1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue));

                this.factorValue = pres1.Factor;
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch { }

            spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
        }

        private void spinEditUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal cantidad_ = 0;
                try
                {
                    cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
                PresentacionX pres1 = new PresentacionX();
                pres1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue));
                spinEditPesoKg.EditValue = (pres1.Factor * cantidad_).ToString();
                    
            }
        }

        private void spinEditUnidades_EditValueChanged(object sender, EventArgs e)
        {
            
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            PresentacionX pres1 = new PresentacionX();
            pres1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue));
            spinEditPesoKg.EditValue = (pres1.Factor * cantidad_).ToString();


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Id_MP < 0)
            {
                CajaDialogo.Error("Debe seleccionar una Materia Prima!");
                return;
            }

            if (dp.ValidateNumberInt32(gridLookUpEditOrigen.EditValue) <= 0)
            {
                CajaDialogo.Error("Es necesario seleccionar una bodega de Origen correcta! Esta efectuando un traslado...");
                return;
            }

            if (dp.ValidateNumberInt32(gridLookUpEditDestino.EditValue) <= 0)
            {
                CajaDialogo.Error("Es necesario seleccionar una bodega de destino correcta! Esta efectuando un traslado...");
                return;
            }

            if (gridLookUpEditOrigen.EditValue == gridLookUpEditDestino.EditValue)
            {
                CajaDialogo.Error("No puede seleccionar la misma Bodega!");
                return;
            }

            if (Convert.ToDecimal(spinEditUnidades.Value) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
                return;
            }

            if (Convert.ToDecimal(spinEditPesoKg.Value) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
                return;
            }


            //Aqui Guardaremos el Traslado

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_ajuste_kardex_por_lote_traslado]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cant_entrada", spinEditPesoKg.EditValue);
                cmd.Parameters.AddWithValue("@cant_salida", 0);
                cmd.Parameters.AddWithValue("@ud_entrada", spinEditUnidades.EditValue);
                cmd.Parameters.AddWithValue("@ud_salida", 0);
                cmd.Parameters.AddWithValue("@id_referencia_operacion", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_lote_alosy", DBNull.Value);
                cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                cmd.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.DateTime);
                cmd.Parameters.AddWithValue("@bodega_origen", gridLookUpEditOrigen.EditValue);
                cmd.Parameters.AddWithValue("@bodega_destino", gridLookUpEditDestino.EditValue);
                if (Convert.ToInt32(gridLookUpEditPresentacion.EditValue) == 0)
                    cmd.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                cmd.Parameters.AddWithValue("@tipo_operacion", 0); //En el SP 0: Traslado.
                cmd.Parameters.AddWithValue("@Operacion", 16);
                cmd.ExecuteNonQuery();
                conn.Close();

                CajaDialogo.Information("Transaccion Exitosa!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtMP_Name_Click(object sender, EventArgs e)
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if (this.MdiParent != null)
            {
                //frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.ItemSeleccionado.ItemName;
                ItemCode = frm.ItemSeleccionado.ItemCode;
                Id_MP = frm.ItemSeleccionado.id;
                if (MateriaPrimaActual == null)
                    MateriaPrimaActual = new MateriaPrima();
                if (MateriaPrimaActual.RecuperarRegistroFromID_RM(frm.ItemSeleccionado.id))
                    LoadMaestrosBodegas();
                MateriaPrima mp = new MateriaPrima();
                if (mp.Get_if_mp_is_granel(Id_MP))
                {
                    //Cancelamos los eventos de unidades para que no se dispare y no recalcule los Kg.
                    spinEditUnidades.EditValueChanged -= new EventHandler(spinEditUnidades_EditValueChanged);
                    spinEditUnidades.EditValue = 1;
                    spinEditUnidades.EditValueChanged += new EventHandler(spinEditUnidades_EditValueChanged);
                    //spinEditUnidades.Enabled = false;
                    //spinEditPesoKg.Enabled = true;
                }
            }
        }

        private void LoadMaestrosBodegas()
        {
            bool MostrarExterno = false; //Si es Ajuste Entrada y Salida o Traslado no debe mostrar las Bodegas Externas

            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            con.Open();

            //SqlCommand cmd = new SqlCommand("sp_get_maestro_bodegas_ajuste_kardexV2", con);
            SqlCommand cmd = new SqlCommand("sp_get_maestro_bodegas_ajuste_kardexV2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MostrarExterno", MostrarExterno);
            if (MateriaPrimaActual != null)
            {
                if (MateriaPrimaActual.Recuperado)
                    cmd.Parameters.AddWithValue("@id_mp", MateriaPrimaActual.IdMP_ACS);
                else
                    cmd.Parameters.AddWithValue("@id_mp", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@id_mp", 0);
            }
            dsTarima1.bodega_origen.Clear();
            dsTarima1.bodega_destino.Clear();
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            adat.Fill(dsTarima1.bodega_origen);
            adat = new SqlDataAdapter(cmd);
            adat.Fill(dsTarima1.bodega_destino);

            con.Close();
        }
    }
}