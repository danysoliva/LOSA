using DevExpress.XtraEditors;
using LOSA.RecepcionMP;
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
using System.Data.SqlClient;
using Core.Clases.Herramientas;

namespace LOSA.AlmacenesExterno.Salida_Almacen
{
    public partial class frmTipoIngreso_v2 : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        public int IdSerie;
        public string ItemCode;
        public string ItemName;
        public string CardCode;
        public string Proveedor;
        public DateTime f_ingreso;
        public int id_presentacion;
        public int N_Referencia;
        public DateTime f_vencimiento;
        public DateTime f_produccion;
        public string lote;
        public decimal PesoTraslado;
        public decimal factor=1;
        DataOperations dp = new DataOperations();
        public frmTipoIngreso_v2(int id_traslado)
        {
            InitializeComponent();
            id = id_traslado;
            load_salidoTraslado();
            LoadPresentaciones();
        }

        public void load_salidoTraslado() 
        {
            try
            {
                string query = @"sp_load_informacion_transporte_externo";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_transporte", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ItemCode = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    ItemName = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    CardCode = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    Proveedor = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    f_ingreso = dr.IsDBNull(4) ? DateTime.Now : dr.GetDateTime(4);
                    id_presentacion = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                    lote = dr.IsDBNull(6) ? "" : dr.GetString(6);
                    f_vencimiento = dr.IsDBNull(7) ? DateTime.Now : dr.GetDateTime(7);
                    f_produccion = dr.IsDBNull(8) ? DateTime.Now : dr.GetDateTime(8);
                    PesoTraslado = dr.IsDBNull(9) ? 0 : dr.GetDecimal(9);


                    txtCodigoMP.Text = ItemCode;
                    txtMP_Name.Text = ItemName;
                    txtCodigoProveedor.Text = CardCode;
                    txtProveedorName.Text = Proveedor;
                    gridLookUpEditPresentacion.EditValue = id_presentacion;
                    dtFechaIngreso.EditValue = f_ingreso;
                    dtFechaProduccion.EditValue = f_produccion;
                    dtFechaVencimiento.EditValue = f_vencimiento;
                    txtLote.Text = lote;
                    txtPesoTransferencia.Text = PesoTraslado.ToString();
                    txtMPCgranel.Text = ItemCode;
                    txtMPgranel.Text = ItemName;
                    dtIngresoGranel.EditValue = f_ingreso;
                    txtLoteGranel.Text = lote;
                    dtProduccionGranel.EditValue = f_produccion;
                    dtVencimientoGranel.EditValue = f_vencimiento;



                }

                dr.Close();
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
            btnsacos.Appearance.BackColor = Color.FromArgb(77, 201, 176);
            btngranel.Appearance.BackColor = Color.FromArgb(255, 255, 255);
            tb_opciones.TabIndex = 0;
            tb_opciones.TabPages[0].PageVisible  = true;
            tb_opciones.TabPages[1].PageVisible = false;
        }

        private void btngranel_Click(object sender, EventArgs e)
        {
            btngranel.Appearance.BackColor = Color.FromArgb(77, 201, 176);
            btnsacos.Appearance.BackColor = Color.FromArgb(255, 255, 255);
            tb_opciones.TabIndex = 1;
            tb_opciones.TabPages[1].PageVisible = true;
            tb_opciones.TabPages[0].PageVisible = false;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdBoleta.Text = frm.NumBoleta.ToString();
                this.IdSerie = frm.IdSerie;
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

        private void txtUnidades_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
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
    }
}