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
using LOSA.RecepcionMP;
using LOSA.Clases;

namespace LOSA.TransaccionesMP
{
    public partial class frmAsjuteInventarioPorLote : DevExpress.XtraEditors.XtraForm
    {
        private string ItemCode;//Codigo MP de SAP
        private decimal factorValue;
        private int Id_MP, Id_Lote_Alosy, Id_Presentacion;
        private int Numero_transaccion; // Numero de Ingresp
        private string cardcode; //Codigo de Proveedor
        UserLogin UsuarioLogueado;
        private decimal FactorUnidades;
        public frmAsjuteInventarioPorLote(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;
            radioLoteExistente.Checked = true;
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
                dsRecepcionMPx.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        SqlTransaction transaction;
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMP_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
                return;
            }

            if (gridLookUpEditPresentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe Seleccionar el tipo de presentacion!");
                return;
            }

            if (Convert.ToDecimal(txtPesoKG.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
                return;
            }
            if (Convert.ToDecimal(txtCantidadUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
                return;
            }

            if (tsTipoTransaccion.IsOn) //ENTRADA EN EL KARDEX GENERAL
            {
                if (radioLoteExistente.Checked)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_ajuste_kardex_por_lote", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cant_entrada", txtPesoKG.Text);
                        cmd.Parameters.AddWithValue("@cant_salida", 0);
                        cmd.Parameters.AddWithValue("@ud_entrada", txtCantidadUnidades.Text);
                        cmd.Parameters.AddWithValue("@ud_salida", 0);
                        cmd.Parameters.AddWithValue("@id_referencia_operacion", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("@id_lote_alosy", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                        //cmd.Parameters.AddWithValue("@id_bodega");
                        cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
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
                if(radioLoteNuevo.Checked)
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    int id_lote_h = 0;

                    conn.Open();
                    transaction = conn.BeginTransaction("SampleTransaction");

                    try
                    {
                        //EN CASO DE SER UN LOTE NUEVO CREAMOS EL LOTE 

                        //INSERT DE ENCABEZADO
                        SqlCommand command = new SqlCommand("sp_insert_mp_lote_h_for_kardex", transaction.Connection);
                        command.Transaction = transaction;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
                        command.Parameters.AddWithValue("@itemcode", ItemCode);
                        command.Parameters.AddWithValue("@itemname", txtMP_Name.Text);
                        command.Parameters.AddWithValue("@usuario_creado", UsuarioLogueado.Id);
                        command.Parameters.AddWithValue("@cardname", buttonProveedores.Text);
                        command.Parameters.AddWithValue("@cardcode", cardcode);

                        id_lote_h = Convert.ToInt32(command.ExecuteScalar());

                        //INSERT DE DETALLE
                        SqlCommand cmd2 = new SqlCommand("sp_insert_mp_lote_d_for_kardex_ajuste",transaction.Connection);
                        cmd2.Transaction = transaction;
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@id_h", id_lote_h);
                        cmd2.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
                        cmd2.Parameters.AddWithValue("@lote", txtLoteNuevo.Text);
                        cmd2.Parameters.AddWithValue("@cantidadtotal", txtCantidadUnidades.Text);
                        cmd2.Parameters.AddWithValue("@cantidadportarima", dp.ValidateNumberInt32(txtUnidadsPorTarima.Text));
                        cmd2.Parameters.AddWithValue("@totaltarimas", dp.ValidateNumberInt32(txtCantidadTarimas));
                        cmd2.Parameters.AddWithValue("@id_unidadmedida", gridLookUpEditPresentacion.EditValue);
                        cmd2.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKG.Text));
                        cmd2.Parameters.AddWithValue("@id_mp", Id_MP);
                        //command.Parameters.AddWithValue("@id_lote_externo",);
                        cmd2.ExecuteNonQuery();

                        //REALIZAMOS EL INSERT DEL MOVIMIENTO EN KARDEX
                        SqlCommand cmd3 = new SqlCommand("sp_ajuste_kardex_por_lote", transaction.Connection);
                        cmd3.Transaction = transaction;
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@cant_entrada", txtPesoKG.Text);
                        cmd3.Parameters.AddWithValue("@cant_salida", 0);
                        cmd3.Parameters.AddWithValue("@ud_entrada", txtCantidadUnidades.Text);
                        cmd3.Parameters.AddWithValue("@ud_salida", 0);
                        cmd3.Parameters.AddWithValue("@id_referencia_operacion", id_lote_h);
                        cmd3.Parameters.AddWithValue("id_lote_alosy", id_lote_h);
                        cmd3.Parameters.AddWithValue("@lote", txtLoteNuevo.Text);
                        cmd3.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd3.Parameters.AddWithValue("@itemcode", ItemCode);
                        cmd3.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                        cmd3.ExecuteNonQuery();
                        //Attempt to commit the transaction.

                        transaction.Commit();
                        conn.Close();

                        CajaDialogo.Information("Transaccion de Lote Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        transaction.Rollback();
                    }
                }
               
            }
            if (tsTipoTransaccion.IsOn == false) //SALIDA EN EL KARDEX GENERAL
            {
                if (radioLoteExistente.Checked)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_ajuste_kardex_por_lote]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cant_entrada", 0);
                        cmd.Parameters.AddWithValue("@cant_salida", txtPesoKG.Text);
                        cmd.Parameters.AddWithValue("@ud_entrada", 0);
                        cmd.Parameters.AddWithValue("@ud_salida", txtCantidadUnidades.Text);
                        cmd.Parameters.AddWithValue("@id_referencia_operacion", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("id_lote_alosy", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                        //cmd.Parameters.AddWithValue("@id_bodega");
                        cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
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
            }
            
            
        }

        private void txtMP_Name_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (this.MdiParent != null)
            {
                //frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.MateriaPrima;
                ItemCode = frm.ItemCode;
                Id_MP = frm.id_mp;
                //txtCodigoProveedor.Text = frm.idProveedor;
                //txtProveedorName.Text = frm.NombreProveedor;
                //this.ItemCode = frm.ItemCode;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {
            //gridLookUpEditPresentacion.EditValue = Id_Presentacion;
            //if (gvLookUpEditPresentacion.RowCount <= 0)
            //{
            //    this.factorValue = 0;
            //}
            //else
            //{
            //    this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            //}

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
                txtPesoKG.Text = (factorValue * cantidad_).ToString();
            }
            else
                txtPesoKG.Text = (FactorUnidades * cantidad_).ToString();
        }

        private void radioLoteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtLoteNuevo.Enabled = true;
            txtLoteNuevo.Visible = true;
            buttonProveedores.Enabled = true;
            txtCantidadTarimas.Enabled = true;
            txtUnidadsPorTarima.Enabled = true;
            txtCantidadUnidades.Text = "";
            txtPesoKG.Text = "";
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cardcode = frm.Cardcode;
                buttonProveedores.Text = frm.pv;
                
            }
        }

        private void radioLoteExistente_CheckedChanged(object sender, EventArgs e)
        {
            txtLoteNuevo.Enabled = false;
            txtLoteNuevo.Visible = false;
            buttonProveedores.Enabled = false;
            buttonProveedores.Text = "";
        }

        private void gridLookUpEditPresentacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
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
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            txtPesoKG.Text = (factorValue * cantidad_).ToString();
        }

        private void txtNumLote_Click(object sender, EventArgs e)
        {
            frmLotePorMP frm = new frmLotePorMP(Id_MP);
            if (this.MdiParent != null)
            {
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                Id_Lote_Alosy = frm.Id_Lote;
                gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                Numero_transaccion = frm.Num_ingreso;
                FactorUnidades = frm.Factor;

                txtCantidadUnidades.Focus();
            }
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

        private void txtCantidadUnidades_Enter(object sender, EventArgs e)
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

            txtPesoKG.Text = (FactorUnidades * cantidad_).ToString();
        }

        private void txtNumLote_Enter(object sender, EventArgs e)
        {
            frmLotePorMP frm = new frmLotePorMP(Id_MP);
            if (this.MdiParent != null)
            {
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                Id_Lote_Alosy = frm.Id_Lote;
                gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                Numero_transaccion = frm.Num_ingreso;
               // gridLookUpEditPresentacion.EditValue = Id_Presentacion;
                FactorUnidades = frm.Factor;
                gridLookUpEditPresentacion.Enabled = false;
                txtCantidadUnidades.Focus();
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
            catch {}

            txtPesoKG.Text = (factorValue * cantidad_).ToString();
        }
    }
}