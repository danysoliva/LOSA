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
        private decimal factorValue;
        private int Id_MP, Id_Lote_Alosy, Id_Presentacion;
        private int Numero_transaccion; // Numero de Ingresp
        private string cardcode; //Codigo de Proveedor
        UserLogin UsuarioLogueado;
        private decimal FactorUnidades;
        MateriaPrima MateriaPrimaActual;
        private decimal existencia_bodega_selected;
        private string bodega_selected;

        public frmTrasladoKardexMP(UserLogin PuserLog)
        {
            InitializeComponent();
            UsuarioLogueado = PuserLog;
            DataOperations dp = new DataOperations();
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
            bool lotes_kardex = true;
            frmLotePorMP frm = new frmLotePorMP(Id_MP, lotes_kardex);
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
                
                spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
                    
            }
        }

        private void spinEditUnidades_EditValueChanged(object sender, EventArgs e)
        {

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