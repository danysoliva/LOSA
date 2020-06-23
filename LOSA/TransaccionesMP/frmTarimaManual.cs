using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.TransaccionesMP
{


    public partial class frmTarimaManual : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int IdSerie;
        int NumBoleta;
        int IdMP;
        int idUbicacionNueva;
        string ItemCode;
        decimal factor;
        int idloteInserted;

        public frmTarimaManual(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            dtFechaIngreso.EditValue = dp.dNow();
            dtFechaVencimiento.Properties.MinValue = dtFechaIngreso.Properties.MinValue = dp.Now();
            load_provedores();
            load_productos();
            LoadPresentaciones();
        }

        public void load_provedores()
        {
            string query = @"Select CardCode, CardName FROM dbo.OCRD T0";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                dsTarima.proveedores.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTarima.proveedores);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_productos()
        {
            string query = @"sp_load_mp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsTarima.MP.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTarima.MP);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtUnidades_TextChanged(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (grdProducto.EditValue.ToString() == "")
            {
                CajaDialogo.Error("Debe seleccionar un producto");
                return;
            }
            if (grdproveedores.EditValue.ToString() == "")
            {
                CajaDialogo.Error("Debe seleccionar un Proveedor");
                return;
            }
            if (Convert.ToDecimal(txtUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
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

            int idMP;
            string Itemcode, descripcion, cardcode, cardname, tarimaCode;
            Itemcode = "";
            descripcion = "";
            cardcode = "";
            cardname = "";
            tarimaCode = "";
            cardcode = grdproveedores.EditValue.ToString();
            cardname = grdproveedores.Text;
            idMP = Convert.ToInt32(grdProducto.EditValue);
            foreach (DataRow row in dsTarima.MP.Rows)
            {
                if (idMP.ToString() == row["id"].ToString())
                {
                    Itemcode = row["itemcode"].ToString();
                    descripcion = row["descripcion"].ToString();
                }
            }
            

            for (int i = 0; i < cant; i++)
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

                    SqlCommand cmd = new SqlCommand("sp_insert_new_tarima", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@itemcode", Itemcode);
                    cmd.Parameters.AddWithValue("@id_proveedor", cardcode);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                    cmd.Parameters.AddWithValue("@numero_transaccion", DBNull.Value);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                    cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                    cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                    cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_boleta", DBNull.Value);
                    cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmd.Parameters.AddWithValue("@cant", txtUnidades.Text);
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKg.Text));
                    cmd.Parameters.AddWithValue("@idlotes", DBNull.Value);
                    int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                    SqlCommand cmdx = new SqlCommand("sp_insert_ubicacion_default", con);// ahora recibe el parametro de ubicacion para poder guardarlo automatico en todas las tarimas
                    cmdx.CommandType = CommandType.StoredProcedure;
                    cmdx.Parameters.AddWithValue("@id_tarima", vid_tarima);
                    cmdx.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                    cmdx.Parameters.AddWithValue("@codigo_barra", barcode);
                    cmdx.Parameters.AddWithValue("@id_ubicacion", 131);// Es la bodega 500
                    cmdx.ExecuteNonQuery();

                    con.Close();
                    //CajaDialogo.InformationAuto();
                    CajaDialogo.Information("Ingreso Exitoso!");
                    this.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }

        private void txtCantidadTarimasTotal_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}