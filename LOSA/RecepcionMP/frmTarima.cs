using ACS.Classes;
using Core.Clases.Herramientas;
using LOSA.Clases;
using System;
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
    public partial class frmTarima : Form
    {
        int IdSerie;
        int NumBoleta;
        int IdMP;
        string ItemCode;
        UserLogin UsuarioLogeado;
        public frmTarima(UserLogin pUser)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            dtFechaIngreso.EditValue = dp.dNow();
            dtFechaVencimiento.Properties.MinValue = dtFechaIngreso.Properties.MinValue = dp.Now();
            UsuarioLogeado = pUser;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdBoleta.Text = frm.NumBoleta.ToString();
                this.IdSerie = frm.IdSerie;
                this.NumBoleta = frm.NumBoleta;
                this.ItemCode = frm.ItemCode;
                LoadDatosBoleta();
            }
        }

        private void LoadDatosBoleta()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalles_boleta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SerieBoleta", this.IdSerie);
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodigoMP.Text = dr.GetString(1);
                    txtMP_Name.Text = dr.GetString(2);
                    txtCodigoProveedor.Text = dr.GetString(3);
                    txtProveedorName.Text = dr.GetString(4);

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmTarima_Activated(object sender, EventArgs e)
        {
            txtIdBoleta.Focus();
        }

        private void txtDescripcionCorta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int id_b = 0;
                try
                {
                    id_b = Convert.ToInt32(txtIdBoleta.Text);
                }
                catch{}

                this.IdSerie = id_b;
                Boleta bol1 = new Boleta();
                if (bol1.RecuperarRegistro(this.IdSerie))
                {
                    txtIdBoleta.Text = bol1.NumID.ToString();
                }
                LoadDatosBoleta();
            }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIdBoleta_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtProveedorName_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void frmTarima_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmTarima_Load(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (IdSerie <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima sin la boleta de bascula!");
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
            //
            //if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            //{
            //    CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
            //    return;
            //}
            
            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }

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
                cmd.Parameters.AddWithValue("@itemcode", this.ItemCode);
                cmd.Parameters.AddWithValue("@id_proveedor", txtCodigoProveedor.Text);
                cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@id_boleta", txtNumIngreso.Text);
                cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                cmd.Parameters.AddWithValue("@cant", txtCantidadT.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                //CajaDialogo.InformationAuto();
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtCantidadT_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtNumIngreso_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtLote_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtCantidadT_KeyPress(object sender, KeyPressEventArgs e)
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
