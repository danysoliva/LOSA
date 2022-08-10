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
        MateriaPrima MateriaPrimaActual;
        public frmAsjuteInventarioPorLote(UserLogin pUserLogin)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.Now();
            LoadMaestrosBodegas();
            UsuarioLogueado = pUserLogin;
            radioLoteExistente.Checked = true;
            LoadPresentaciones();
        }

        public frmAsjuteInventarioPorLote(UserLogin pUserLogin, int pIdMP, int id_lote_alosy, string pLote)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.Now();
            LoadMaestrosBodegas();
            MateriaPrima MateriaPrimaActual = new MateriaPrima();
            UsuarioLogueado = pUserLogin;
            radioLoteExistente.Checked = true;
            LoadPresentaciones();
            if (MateriaPrimaActual.RecuperarRegistroFromID_RM(pIdMP))
            {
                Id_MP = pIdMP;
                txtMP_Name.Text = MateriaPrimaActual.NameComercial;
                radioLoteExistente.Checked = true;
                radioLoteNuevo.Checked = false;
                SearchLoteAuto(pIdMP, pLote);

                //frmLotePorMP frm = new frmLotePorMP(Id_MP);
                //if (this.MdiParent != null)
                //{
                //    frm.FormBorderStyle = FormBorderStyle.Sizable;
                //}
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    txtNumLote.Text = frm.Lote;
                //    Id_Lote_Alosy = frm.Id_Lote;
                //    gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                //    Numero_transaccion = frm.Num_ingreso;
                //    FactorUnidades = frm.Factor;

                //    txtCantidadUnidades.Focus();
                //}
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

        void SearchLoteAuto(int pidmp, string plote_)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_lotes_for_mp_from_lot_and_id_mp", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pidmp);
                cmd.Parameters.AddWithValue("@plote", plote_);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_Lote_Alosy = dr.GetInt32(2);
                    if (Id_Lote_Alosy > 0)
                    {
                        //txtLoteNuevo.Enabled = true;
                        //txtNumLote.Enabled= false;
                        MateriaPrima mat1 = new MateriaPrima();
                        if (mat1.RecuperarRegistroFromID_RM(pidmp))
                        {
                            ItemCode = mat1.CodeMP_SAP;//Codigo MP de SAP
                            MateriaPrimaActual = mat1;
                        }
                        txtLoteNuevo.Text = txtNumLote.Text = dr.GetString(0);
                        Numero_transaccion = dr.GetInt32(1); // Numero de Ingresp

                        factorValue = dr.GetDecimal(5);
                        Id_Presentacion = dr.GetInt32(6);
                        Id_MP = pidmp;
                        //cardcode; //Codigo de Proveedor
                    }
                    else
                    {
                        //txtLoteNuevo.Enabled = false;
                        //txtNumLote.Enabled = true;
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
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

            //if (Convert.ToDecimal(txtPesoKG.Text) <= 0)
            if (Convert.ToDecimal(spinEditPesoKg.EditValue) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
                return;
            }

            if (Convert.ToDecimal(spinEditUnidades.Value) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
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
                        SqlCommand cmd = new SqlCommand("sp_ajuste_kardex_por_lote_v2", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@cant_entrada", txtPesoKG.Text);
                        cmd.Parameters.AddWithValue("@cant_entrada", spinEditPesoKg.EditValue);
                        cmd.Parameters.AddWithValue("@cant_salida", 0);
                        cmd.Parameters.AddWithValue("@ud_entrada", spinEditUnidades.EditValue);
                        cmd.Parameters.AddWithValue("@ud_salida", 0);
                        cmd.Parameters.AddWithValue("@id_referencia_operacion", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("@id_lote_alosy", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                        //cmd.Parameters.AddWithValue("@id_bodega");
                        cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.DateTime);
                        if(dp.ValidateNumberInt32(gridLookUpEditOrigen.EditValue)>0)
                            cmd.Parameters.AddWithValue("@bodega_origen", gridLookUpEditOrigen.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@bodega_origen", DBNull.Value);

                        if (dp.ValidateNumberInt32(gridLookUpEditDestino.EditValue) > 0)
                            cmd.Parameters.AddWithValue("@bodega_destino", gridLookUpEditDestino.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@bodega_destino", DBNull.Value);

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
                    //DataOperations dp = new DataOperations();
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
                        cmd2.Parameters.AddWithValue("@cantidadtotal", spinEditUnidades.EditValue);
                        cmd2.Parameters.AddWithValue("@cantidadportarima", dp.ValidateNumberInt32(txtUnidadsPorTarima.Text));
                        cmd2.Parameters.AddWithValue("@totaltarimas", dp.ValidateNumberInt32(txtCantidadTarimas));
                        cmd2.Parameters.AddWithValue("@id_unidadmedida", gridLookUpEditPresentacion.EditValue);
                        cmd2.Parameters.AddWithValue("@peso", spinEditPesoKg.EditValue);
                        cmd2.Parameters.AddWithValue("@id_mp", Id_MP);
                        //command.Parameters.AddWithValue("@id_lote_externo",);
                        cmd2.ExecuteNonQuery();

                        //REALIZAMOS EL INSERT DEL MOVIMIENTO EN KARDEX
                        SqlCommand cmd3 = new SqlCommand("sp_ajuste_kardex_por_lote", transaction.Connection);
                        cmd3.Transaction = transaction;
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@cant_entrada", spinEditPesoKg.EditValue);
                        cmd3.Parameters.AddWithValue("@cant_salida", 0);
                        cmd3.Parameters.AddWithValue("@ud_entrada", spinEditUnidades.EditValue);
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
                        //DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_ajuste_kardex_por_lote]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cant_entrada", 0);
                        cmd.Parameters.AddWithValue("@cant_salida", spinEditPesoKg.EditValue);
                        cmd.Parameters.AddWithValue("@ud_entrada", 0);
                        cmd.Parameters.AddWithValue("@ud_salida", spinEditUnidades.EditValue);
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
                else
                {
                    //spinEditUnidades.Enabled = true;
                    //spinEditPesoKg.Enabled = false;
                }

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
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
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
                spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
        }

        private void radioLoteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtLoteNuevo.Enabled = true;
            txtLoteNuevo.Visible = true;
            buttonProveedores.Enabled = true;
            txtCantidadTarimas.Enabled = true;
            txtUnidadsPorTarima.Enabled = true;
            spinEditUnidades.EditValue = 0;
            spinEditPesoKg.EditValue = 0;
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
            txtCantidadTarimas.Enabled = false;
            txtUnidadsPorTarima.Enabled = false;
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
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
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

                spinEditUnidades.Focus();
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
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
        }

        private void txtPesoKG_Validated(object sender, EventArgs e)
        {
            //decimal valor = 0;
            //errorProvider1.Clear();
            //try
            //{
            //    valor = Convert.ToDecimal(txtPesoKG.EditValue);
            //}
            //catch 
            //{
            //    errorProvider1.SetError(txtPesoKG, "Debe ingresar un numero Valido!");
            //}
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
            if (radioLoteNuevo.Checked)
            {
                spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
            }
            else
                spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
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
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch {}

            spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
        }
    }
}