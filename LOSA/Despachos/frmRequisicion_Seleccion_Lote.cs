using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.Despachos
{
    public partial class frmRequisicion_Seleccion_Lote : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionDetalle;
        MateriaPrima MP;
        decimal CantidadPendiente;
        decimal id_unidad;
        public frmRequisicion_Seleccion_Lote(UserLogin pUsuarioLogeado, int pIdRequisicionDetalle, int IdRM, decimal pCantidad, decimal pIdUnidad, string pUnidadName)
        {
            InitializeComponent();
            MP = new MateriaPrima();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionDetalle = pIdRequisicionDetalle;
            CantidadPendiente = pCantidad;
            txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
            txtSolicitada.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
            id_unidad = pIdUnidad;
            lblUnidad.Text = pUnidadName;

            if (MP.RecuperarRegistroFromID_RM_PT_ONLY(IdRM))
            {
                txtCodigoMP.Text = MP.Codigo;
                txtMP_Name.Text = MP.Name;
            }

            LoadDetalleLotes();
        }

        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_pt_requisicion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpt", MP.IdMP_ACS);
                cmd.Parameters.AddWithValue("@idDetalle", IdRequisicionDetalle);

                ds_despachos.detalle_lote_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(ds_despachos.detalle_lote_mp);

                con.Close();

                CalculoTotales();
                seterror();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void seterror()
        {
            decimal val = 0;
            try
            {
                val = Convert.ToDecimal(txtCantidadPendiente.Text);
            }
            catch { }

            if (val != 0)
            {
                errorProvider1.SetError(txtCantidadPendiente, "Hay Producto terminado pendiente de asignar lote!!");
                //dxErrorProvider1.SetError(txtCantidadPendiente, 
                //                          "Hay materia prima pendiente de asignar lote!!", 
                //                          DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
            }
            else
            {
                //dxErrorProvider1.ClearErrors();
                errorProvider1.Clear();
            }
        }
        private void CalculoTotales()
        {
            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            decimal cantidad_conseguida = 0;
            foreach (ds_despachos.detalle_lote_mpRow row in ds_despachos.detalle_lote_mp.Rows)
            {
                //if (row.peso_total == cantidaPendiente)
                //{
                //    row.seleccionado = true;
                //    cantidaPendiente = 0;
                //    row.cants = row.peso_total;
                //    break;
                //}
                if (row.peso_total > cantidaPendiente && cantidaPendiente > 0)
                {
                    //if (row.peso_total > cantidaPendiente)
                    //    row.cants = cantidaPendiente;
                    //else
                    //    row.cants = total_solicitado - cantidaPendiente;

                    //row.cants = row.peso_total - cantidaPendiente;
                    cantidaPendiente -= row.cants;
                    //row.seleccionado = true;
                    break;
                }
                else
                {
                    //en el row tenemos un valor menor que el solicitado
                    //Necesitaremos mas de un row para satisfaser la cantidad requerida.
                    if (row.peso_total < cantidaPendiente && cantidaPendiente > 0)
                    {
                        //seleccionamos la cantidad total del row para acumular el valor solictado.
                        //row.cants = row.peso_total;

                        //Restamos la cantidad conseguida o asignada.
                        cantidaPendiente -= row.cants;

                        //Marcamos el row seleccionado porque se utilizaria dicho lote para la requisicion.
                        //row.seleccionado = true;
                    }
                }

                //Calculo de totales.
                if (row.seleccionado)
                    cantidad_conseguida += row.cants;

                txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                //end block foreach
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int Seleccionados = 0;
            foreach (ds_despachos.detalle_lote_mpRow row in ds_despachos.detalle_lote_mp.Rows)
            {
                if (row.seleccionado)
                {
                    Seleccionados++;
                    break;
                }
            }

            if (Seleccionados <= 0)
            {
                CajaDialogo.Error("Debe seleccionar al menos un lote");
                return;
            }

            decimal pendiente = 0;
            if (Convert.ToDecimal(txtCantidadPendiente.Text) > 0)
            {
                DialogResult r = CajaDialogo.Pregunta("Las cantidades seleccionadas no abastecen el total requerido!!\nDesea Guardar el avance seleccionado?");
                if (r != DialogResult.Yes)
                    return;
            }


            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd1 = new SqlCommand("sp_set_delete_seleccion_lote_pt", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);
                cmd1.ExecuteNonQuery();

                foreach (ds_despachos.detalle_lote_mpRow row in ds_despachos.detalle_lote_mp.Rows)
                {
                    if (row.seleccionado)
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_insert_lotes_req_pt", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_mp", row.lote_mp);
                        cmd.Parameters.AddWithValue("@id_detalle_req", IdRequisicionDetalle);
                        cmd.Parameters.AddWithValue("@cantidad", row.cants);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void grdv_lotes_RowStyle(object sender, RowStyleEventArgs e)
        {

        }

        private void chkAutoSelect_CheckedChanged(object sender, EventArgs e)
        {

            decimal total_solicitado = CantidadPendiente;
            decimal cantidaPendiente = CantidadPendiente;
            decimal cantidad_conseguida = 0;
            if (chkAutoSelect.Checked)
            {
                //var gridView = (GridView)grRequisicoinesMP.FocusedView;
                //var row = (dsTransaccionesMP.detalle_lote_mpRow)gridView.GetFocusedDataRow();

                foreach (ds_despachos.detalle_lote_mpRow row in ds_despachos.detalle_lote_mp.Rows)
                {
                    if (row.cantidad == cantidaPendiente)
                    {
                        row.seleccionado = true;
                        cantidaPendiente = 0;
                        row.cants = row.cantidad;
                        break;
                    }
                    if (row.cantidad > cantidaPendiente && cantidaPendiente > 0)
                    {
                        if (row.cantidad > cantidaPendiente)
                            row.cants = cantidaPendiente;
                        else
                            row.cants = total_solicitado - cantidaPendiente;

                        //row.cants = row.peso_total - cantidaPendiente;
                        cantidaPendiente -= row.cants;
                        row.seleccionado = true;
                        break;
                    }
                    else
                    {
                        //en el row tenemos un valor menor que el solicitado
                        //Necesitaremos mas de un row para satisfaser la cantidad requerida.
                        if (row.peso_total < cantidaPendiente && cantidaPendiente > 0)
                        {
                            if (row.peso_total > 0)
                            {
                                //seleccionamos la cantidad total del row para acumular el valor solictado.
                                row.cants = row.cantidad;

                                //Restamos la cantidad conseguida o asignada.
                                cantidaPendiente -= row.cants;

                                //Marcamos el row seleccionado porque se utilizaria dicho lote para la requisicion.
                                row.seleccionado = true;
                            }
                        }
                    }

                    //Calculo de totales.
                    if (row.seleccionado)
                        cantidad_conseguida += row.cants;

                    txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                    txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                    //end block foreach
                }
            }
            else
            {
                foreach (ds_despachos.detalle_lote_mpRow row in ds_despachos.detalle_lote_mp.Rows)
                {
                    row.seleccionado = false;
                    row.cants = 0;
                    if (row.seleccionado)
                        cantidad_conseguida += row.cants;

                    txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente - cantidad_conseguida);
                    txtAsignada.Text = string.Format("{0:###,##0.00}", cantidad_conseguida);
                }
            }
        }
    }
}