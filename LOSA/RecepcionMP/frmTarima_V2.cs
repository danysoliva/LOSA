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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno;
using Core.Clases.Herramientas;

namespace LOSA.RecepcionMP
{
    public partial class frmTarima_V2 : DevExpress.XtraEditors.XtraForm
    {
        public bool Istraslado;
        UserLogin UsuarioLogeado;
        public int id_Traslado_a_Ingresar;
        int IdSerie;
        int NumBoleta;
        int IdMP;
        int idUbicacionNueva;
        string ItemCode;
        decimal factor;
        int id_transferencia;
        decimal peso_boleta;
        public int Id_ingreso;
        public string Dscripcion;
        public string pv;
        public string cardcode;
        public Decimal LimiteKgloteportraslado;

        public frmTarima_V2(bool PIstraslado,
                            UserLogin Puser,
                            int Pid_traslado)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Istraslado = PIstraslado;
            id_Traslado_a_Ingresar = Pid_traslado;
            if (Istraslado)
            {
                btnSeleccionarLote.Visible = true;
                btnSelecciondeMp.Visible = false;
                btnSelccionarProveedor.Visible = false;
                txtLote.Enabled = false;
            }
            else
            {
                btnSeleccionarLote.Visible = false;
            }
            LoadPresentaciones();
            LoadNumeroTransaccion();
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
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea crear el ingreso con esta configuracion?. Debe definir los lotes que se han generado.",
                "Desea crear el ingreso con esta configuracion?.Debe definir los lotes que se han generado",
                MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (dsWizard.informacionIngreso.Rows.Count ==0)
                {
                    CajaDialogo.Error("Debe de haber añadido al menos un lote.");
                    return;
                }
                foreach (dsWizard.informacionIngresoRow row in dsWizard.informacionIngreso.Rows)
                {

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdBoleta.Text = frm.NumBoleta.ToString();
                this.IdSerie = frm.IdSerie;
                this.NumBoleta = frm.NumBoleta;
                // this.ItemCode = frm.ItemCode;
                txtoc.Text = frm.OC;
                txtfactura.Text = frm.Factura;
                this.peso_boleta = frm.Peso_Bascula;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pv = frm.pv;
                cardcode = frm.Cardcode;
                txtProveedorName.Text = pv;
                txtCodigoProveedor.Text = cardcode;
            }
        }

        private void btnSelecciondeMp_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ItemCode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtMP_Name.Text = Dscripcion;
                txtCodigoMP.Text = frm.ItemCode; 
            }
        }

        private void btnGuardarLote_Click(object sender, EventArgs e)
        {
            int idloteInserted;
            if (IdSerie <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima sin la boleta de bascula!");
                return;
            }
            //if (gvNuevaUbicacion.RowCount <= 0)
            //{
            //    CajaDialogo.Error("Debe seleccionar una ubicacion predeterminada para todas las tarimas.");
            //    return;
            //}

            if (Convert.ToDecimal(txtUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
                return;
            }

            if (!Tg_presentacion_promedio.IsOn)
            {
                if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
                {
                    CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de producción!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }
            if (string.IsNullOrEmpty(txtoc.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la orden de compra!");
                return;
            }
            if (string.IsNullOrEmpty(txtfactura.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la factura!");
                return;
            }

            int cant = 0;
            try
            {
                cant = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
                cant = 0;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("No se puede registrar menos de una (1) tarima!");
                return;
            }
            DataRow row = dsWizard.informacionIngreso.NewRow();
            row["id"] = 0;
            row["id_traslado"] = id_Traslado_a_Ingresar;
            row["itemcode"] = txtCodigoMP.Text;
            row["itemname"] = txtMP_Name.Text;
            row["pv"] = txtProveedorName.Text;
            row["cardname"] = txtCodigoProveedor.Text;
            row["fechaIngreso"] = dtFechaIngreso.Text;
            row["udxtarima"] = txtUnidades.Text;
            row["pesokgxtarima"] = txtPesoKg.Text;
            row["fvencimiento"] = dtFechaVencimiento.Text;
            row["fproduccion"] = dtFechaProduccion.Text;
            row["presentacion"] = Tg_presentacion_promedio.IsOn ? txtpresentacionPromedio.Text : gridLookUpEditPresentacion.Text;
            row["factor"] = factor;
            row["lote"] = txtLote.Text;
            row["canttarimas"] = txtCantidadTarimasTotal.Text;
            row["oc"] = txtoc.Text;
            row["factura"] = txtfactura.Text;
            row["bit_promedio"] = Tg_presentacion_promedio.IsOn;
            row["id_presentacion"] = gridLookUpEditPresentacion.EditValue;
            decimal CantidadDeUd = 0;
            decimal CantidadDeKG = 0;
            CantidadDeUd = Convert.ToInt32(txtCantidadTarimasTotal.Text) * Convert.ToInt32(txtUnidades.Text);
            CantidadDeKG = Convert.ToInt32(txtCantidadTarimasTotal.Text) * Convert.ToDecimal(txtPesoKg.Text);

            row["totalKgLote"] = CantidadDeKG;
            row["TotalUdlote"] = CantidadDeUd;
            dsWizard.informacionIngreso.Rows.Add(row);
            dsWizard.informacionIngreso.AcceptChanges();

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
        private void Tg_presentacion_promedio_Toggled(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)          // Data
            {
                try
                {
                    txtpresentacionPromedio.Visible = true;
                    gridLookUpEditPresentacion.Visible = false;
                    factor = 0;
                    labelControl12.Text = "Peso total KG";
                    txtPesoKg.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                txtpresentacionPromedio.Visible = false;
                gridLookUpEditPresentacion.Visible = true;
                txtPesoKg.Enabled = false;
                labelControl12.Text = "Peso Kg por tarima";

                try
                {
                    PresentacionX pre1 = new PresentacionX();
                    if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                    {
                        factor = pre1.Factor;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));

                    }
                }
                catch (Exception ex)
                {


                }
            }
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

        private void txtCantidadTarimasTotal_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)
            {
                try
                {
                    CalculodelPromedio();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {

            }
        }

        private void txtPesoKg_TextChanged(object sender, EventArgs e)
        {
            CalculodelPromedio();
        }
        public void CalculodelPromedio()
        {
            try
            {
                int unidades_Tarimas = Convert.ToInt32(txtUnidades.Text);
                int cantidad_tariams = Convert.ToInt32(txtCantidadTarimasTotal.Text);
                decimal Unidades_totales = unidades_Tarimas * cantidad_tariams;
                decimal total_pesoKg = Convert.ToDecimal(txtPesoKg.Text);
                factor = total_pesoKg / Unidades_totales;
                txtpresentacionPromedio.Text = string.Format("{0:###,##0.00}", (factor));


            }
            catch (Exception ex)
            {
            }
        }
        private void txtUnidades_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn) // 
            {
                CalculodelPromedio();
            }
            else
            {
                try
                {
                    txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
                }
                catch
                {
                    txtPesoKg.Text = "0";
                }
            }
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSeleccionarLote_Click(object sender, EventArgs e)
        {
            frmSeleccionrLoteExterno frm = new frmSeleccionrLoteExterno(id_Traslado_a_Ingresar);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtLote.Text = frm.lote;
                txtCodigoMP.Text = frm.Itemcode;
                txtMP_Name.Text = frm.Itemname;
                txtProveedorName.Text = frm.cardname;
                txtCodigoProveedor.Text = frm.cardcode;
                dtFechaProduccion.EditValue = frm.fproduccion;
                dtFechaVencimiento.EditValue = frm.fvencimiento;
                LimiteKgloteportraslado = frm.LimiteKG;
            }
        }
    }
}