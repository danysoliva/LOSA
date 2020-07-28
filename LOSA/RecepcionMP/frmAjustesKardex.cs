using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmAjustesKardex : Form
    {
        private string ItemCode;
        private UserLogin UsuarioLogueado = new UserLogin();
        private decimal factorValue;
        public frmAjustesKardex(UserLogin pUserLogueado)
        {
            InitializeComponent();
            LoadPresentaciones();
            LoadTipoTransaccion();
            LoadNumeroTransaccion();
        }

        private void TxtMP_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmMP frm = new frmMP();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.MateriaPrima;
                txtCodigoProveedor.Text = frm.idProveedor;
                txtProveedorName.Text = frm.NombreProveedor;
                this.ItemCode = frm.ItemCode;
            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
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

        private void LoadTipoTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tipo_transaccion_kardex", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx.Tipo_transacciones_kardex.Clear();
                adat.Fill(dsRecepcionMPx.Tipo_transacciones_kardex);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                txtNumIngreso.Text = num_ingreso;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMP_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
                return;
            }


            if (Convert.ToDecimal(txtCantidadT.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con cantidad de materia en cero (0)!");
                return;
            }

            if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                return;
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }


            int cantTarimas = 0;
            try
            {
                cantTarimas = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
            }

            if (cantTarimas <= 0)
            {
                CajaDialogo.Error("La cantidad minima de tarimas debe ser uno(1)!");
                return;
            }

            int CantGuardo = 0;
            //ArrayList Lista = new ArrayList();
            for (int i = 1; i <= cantTarimas; i++)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@id", 1);
                    string barcode = cmm.ExecuteScalar().ToString();

                    SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_sin_boleta", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                    cmd.Parameters.AddWithValue("@id_proveedor", txtCodigoProveedor.Text);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                    cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                    cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                    cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_tipo_transaccion_kardex", glTipoTransaccion.EditValue);
                    cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@cant", txtCantidadT.Text);
                    cmd.Parameters.AddWithValue("@peso", txtPeso.Text);
                    //Lista.Add(Convert.ToInt32(cmd.ExecuteScalar()));
                    cmd.ExecuteScalar();
                    CantGuardo++;
                    con.Close();
                    //CajaDialogo.InformationAuto();

                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

            
            

            if (CantGuardo>0)
            {
                CajaDialogo.Information("Datos guardados exitosamente!");
                this.Close();
            }
        }

        private void GridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {

            if (gvLookUpEditPresentacion.RowCount <= 0)
            {
                //CajaDialogo.Error("Debe seleccionar una presentación");
                //gridLookUpEditPresentacion.Focus();
                //return;
                this.factorValue = 0;
            }
            else
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());

            //if (Convert.ToDecimal(txtCantidadT.Text) > 0)
            txtPeso.Text = (factorValue * Convert.ToDecimal(txtCantidadT.Text)).ToString();
            //else
            //{
            //    CajaDialogo.Error("Debe ingresar unidades mayores que cero (0)");
            //    txtCantidadT.Focus();
            //}
        }

        private void TxtCantidadT_Leave(object sender, EventArgs e)
        {
            GridLookUpEditPresentacion_EditValueChanged(sender, e);
        }

        private void txtCantidadT_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void frmAjustesKardex_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        
        private void txtLote_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtCantidadTarimasTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
