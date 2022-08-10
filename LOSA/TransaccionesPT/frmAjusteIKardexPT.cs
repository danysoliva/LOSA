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
using LOSA.TransaccionesPT;
using System.Data.SqlClient;

namespace LOSA.TransaccionesPT
{
    public partial class frmAjusteIKardexPT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp1 = new DataOperations();
        UserLogin UsuarioLogeado;
        string code_sap; //Codigo de MP de SAP
        private decimal factorValue;
        private decimal FactorUnidades;
        int Id_PT; //ID de Producto Terminado - Tabla en AQFSVR003.ACS4
        int Id_Lote_PT; //Id de lote de Producto Terminado
        public frmAjusteIKardexPT(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            dtFechaDocumento.DateTime = dp1.Now();
            LoadPresentaciones();
            radioLoteExistente.Checked = true;
            txtNumLote.Visible = true;
            txtLoteNuevo.Visible = false;
            LoadMaestrosBodegas();
        }

        private void txtPT_Name_Click(object sender, EventArgs e)
        {
            frmPT frm = new frmPT();
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPT_Name.Text = frm.ProductoT;
                code_sap = frm.CodeSAP;
                Id_PT = frm.id_pt;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dsRecepcionMPx.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtNumLote_Click(object sender, EventArgs e)
        {
            //if (true)
            //{

            //}
            frmLotesxPT frm = new frmLotesxPT(Id_PT);
            frm.MdiParent = this.MdiParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = Convert.ToString(frm.lot_number);
                Id_Lote_PT = frm.id_Lote_PT;
            }
        }

        private void LoadMaestrosBodegas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_maestro_bodegas_ajuste_kardex", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsTarima1.bodega_origen.Clear();
                dsTarima1.bodega_destino.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTarima1.bodega_origen);
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTarima1.bodega_destino);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
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
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch { }

            spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(txtCantidadUnidades.Text);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (radioLoteNuevo.Checked)
            {
                spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
            }
            else
                spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPT_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el Producto Terminado!");
                return;
            }
            if (string.IsNullOrEmpty(txtNumLote.Text))
            {
                CajaDialogo.Error("Es Necesario seleccionar un Numero de Lote de Producto Terminado");
                return;
            }
            if (gridLookUpEditPresentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe Seleccionar el tipo de presentacion!");
                return;
            }
            if (Convert.ToDecimal(spinEditPesoKg.EditValue) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de producto terminado en cero (0)!");
                return;
            }
            if (Convert.ToDecimal(txtCantidadUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de producto terminado en cero (0)!");
                return;
            }
            if (!string.IsNullOrEmpty(dtFechaDocumento.Text))
            {
                if (dtFechaDocumento.DateTime.Year <= 2020)
                {
                    CajaDialogo.Error("Es necesario ingresar una fecha de documento valida!");
                    return;
                }
            }
            DataOperations dp = new DataOperations();

            if (tsTipoTransaccion.IsOn) //ENTRADA EN EL KARDEX GENERAL
            {
                if (radioLoteExistente.Checked)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_ajuste_kardex_pt", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cantidad_in", Convert.ToDecimal(txtCantidadUnidades.Text));
                        cmd.Parameters.AddWithValue("@cantidad_out", 0);
                        cmd.Parameters.AddWithValue("@tipo_op", 1);//Entrada
                        //cmd.Parameters.AddWithValue("@id_tarima", null); //No nos interesa la tarima
                        cmd.Parameters.AddWithValue("@peso_in", spinEditPesoKg.EditValue);
                        cmd.Parameters.AddWithValue("@peso_out", 0);
                        //cmd.Parameters.AddWithValue("@id_doc", null);//No tenemos un documento, por que es ajuste
                        cmd.Parameters.AddWithValue("@id_pt", Id_PT);
                        cmd.Parameters.AddWithValue("@lote_pt",txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@fecha_doc", dtFechaDocumento.EditValue);
                        cmd.Parameters.AddWithValue("@id_bodega_origen", gridLookUpEditOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@id_bodega_destino", gridLookUpEditDestino.EditValue);
                        cmd.Parameters.AddWithValue("@int_tipo_op", 1); // 1 Es Entrada
                        cmd.Parameters.AddWithValue("@id_lote_pt", Id_Lote_PT);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        CajaDialogo.Information("Transaccion Entrada Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
                if (radioLoteNuevo.Checked)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_ajuste_kardex_pt", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cantidad_in", Convert.ToDecimal(txtCantidadUnidades.Text));
                        cmd.Parameters.AddWithValue("@cantidad_out", 0);
                        cmd.Parameters.AddWithValue("@tipo_op", 1);//Entrada
                        //cmd.Parameters.AddWithValue("@id_tarima", null);
                        cmd.Parameters.AddWithValue("@peso_in", spinEditPesoKg.EditValue);
                        cmd.Parameters.AddWithValue("@peso_out", 0);
                        //cmd.Parameters.AddWithValue("@id_doc", null);
                        cmd.Parameters.AddWithValue("@id_pt", Id_PT);
                        cmd.Parameters.AddWithValue("@lote_pt", txtLoteNuevo.Text);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@fecha_doc", dtFechaDocumento.EditValue);
                        cmd.Parameters.AddWithValue("@id_bodega_origen", gridLookUpEditOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@id_bodega_destino", gridLookUpEditDestino.EditValue);
                        cmd.Parameters.AddWithValue("@int_tipo_op", 1); // 1 Es Entrada
                        cmd.ExecuteNonQuery();

                        CajaDialogo.Information("Transaccion de Entrada Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
            if (tsTipoTransaccion.IsOn == false) //SALIDA EN EL KARDEX GENERAL
            {
                if (radioLoteExistente.Checked)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_ajuste_kardex_pt", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cantidad_in", 0);
                        cmd.Parameters.AddWithValue("@cantidad_out", Convert.ToDecimal(txtCantidadUnidades.Text));
                        cmd.Parameters.AddWithValue("@tipo_op", 0); //Salida
                        //cmd.Parameters.AddWithValue("@id_tarima", null);
                        cmd.Parameters.AddWithValue("@peso_in", 0);
                        cmd.Parameters.AddWithValue("@peso_out", spinEditPesoKg.EditValue);
                        //cmd.Parameters.AddWithValue("@id_doc", null);
                        cmd.Parameters.AddWithValue("@id_pt", Id_PT);
                        cmd.Parameters.AddWithValue("@lote_pt", txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@fecha_doc", dtFechaDocumento.EditValue);
                        cmd.Parameters.AddWithValue("@id_bodega_origen", gridLookUpEditOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@id_bodega_destino", gridLookUpEditDestino.EditValue);
                        cmd.Parameters.AddWithValue("@int_tipo_op", 2); // 2 Es Salida
                        cmd.Parameters.AddWithValue("@id_lote_pt", Id_Lote_PT);
                        cmd.ExecuteNonQuery();

                        CajaDialogo.Information("Transaccion de Salida Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
        }

        private void radioLoteExistente_CheckedChanged(object sender, EventArgs e)
        {
            txtNumLote.Visible = true;
            txtLoteNuevo.Visible = false;
            
        }

        private void radioLoteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtNumLote.Visible = false;
            txtLoteNuevo.Visible = true;
            spinEditPesoKg.EditValue = 0;
            txtCantidadUnidades.Text = "0";
        }

        private void tsTipoTransaccion_Toggled(object sender, EventArgs e)
        {
            if (tsTipoTransaccion.IsOn == true)
            {
                radioLoteNuevo.Checked = true;
                radioLoteNuevo.Visible = true;
                radioLoteExistente.Checked = true;
            }
            else
            {
                radioLoteNuevo.Checked = false;
                radioLoteNuevo.Visible = false;
                radioLoteExistente.Checked = true;
            }
        }
    }
}