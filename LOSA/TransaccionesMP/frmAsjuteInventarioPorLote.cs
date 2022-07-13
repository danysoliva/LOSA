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
        private string ItemCode;
        private decimal factorValue;
        private int Id_MP, Id_Lote_Alosy, Id_Presentacion;
        private UserLogin UsuarioLogueado = new UserLogin();
        public frmAsjuteInventarioPorLote()
        {
            InitializeComponent();
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMP_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
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

            DataOperations dp = new DataOperations();
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_ajsute_kardex_por_lote]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (tsTipoTransaccion.IsOn == true) //Entrada 
                {
                    cmd.Parameters.AddWithValue("@cant_entrada",txtPesoKG.Text);
                    cmd.Parameters.AddWithValue("@cant_salida",0);
                    cmd.Parameters.AddWithValue("@ud_entrada",txtCantidadUnidades.Text);
                    cmd.Parameters.AddWithValue("@ud_salida",0);
                }
                if (tsTipoTransaccion.IsOn == false) //Salida
                {                                   
                    cmd.Parameters.AddWithValue("@cant_entrada",0);
                    cmd.Parameters.AddWithValue("@cant_salida",txtPesoKG.Text);
                    cmd.Parameters.AddWithValue("@ud_entrada",0);
                    cmd.Parameters.AddWithValue("@ud_salida",txtCantidadUnidades.Text);
                }
                cmd.Parameters.AddWithValue("id_lote_alosy",Id_Lote_Alosy);
                cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                //cmd.Parameters.AddWithValue("@id_bodega");
                cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                //cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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

        private void tsTipoTransaccion_Toggled(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void txtCantidadUnidades_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {
            gridLookUpEditPresentacion_EditValueChanged(sender, e);
        }

        private void txtNumLote_Enter(object sender, EventArgs e)
        {
            frmLotePorMP frm = new frmLotePorMP();
            if (this.MdiParent != null)
            {
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                Id_Lote_Alosy = frm.Id_Lote;
                Id_Presentacion = frm.Id_UnidadMedida;
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
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            txtPesoKG.Text = (factorValue * cantidad_).ToString();
        }
    }
}