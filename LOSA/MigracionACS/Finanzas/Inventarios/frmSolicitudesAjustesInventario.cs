using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesMP.DataSet;
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

namespace LOSA.MigracionACS.Finanzas.Inventarios
{
    public partial class frmSolicitudesAjustesInventario : DevExpress.XtraEditors.XtraForm
    {
        public frmSolicitudesAjustesInventario()
        {
            InitializeComponent();
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_borradores_ajustes_inventario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_todos", toggleSwitchVerTodos.IsOn);
                dsRecepcionMP_AjusteLote1.borradores_select.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMP_AjusteLote1.borradores_select);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void toggleSwitchVerTodos_Toggled(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void btnEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMP_AjusteLote.borradores_selectRow)gridView.GetFocusedDataRow();

            if (row.id_estado_borrador > 1)
            {
                CajaDialogo.Error("Solo se permite eliminar ajustes en estado: Pendiente!");
                return;
            }

            DialogResult r = CajaDialogo.Error("Esta seguro de cancelar este ajuste?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_update_solicitud_ajuste_kardex_inventario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                //CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAprobar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsRecepcionMP_AjusteLote.borradores_selectRow)gridView.GetFocusedDataRow();

            //if (row.id_estado_borrador != 1)
            //{
            //    CajaDialogo.Error("Solo se permite aprobar ajustes en estado: Pendiente.");
            //    return;
            //}

            //DialogResult r = CajaDialogo.Error("Esta seguro de aprobar este ajuste?");
            //if (r != DialogResult.Yes)
            //    return;

            //try
            //{
            //    SqlTransaction transaction;
            //    DataOperations dp = new DataOperations();
            //    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //    int id_lote_h = 0;

            //    conn.Open();
            //    transaction = conn.BeginTransaction("SampleTransaction");

            //    try
            //    {
            //        ////EN CASO DE SER UN LOTE NUEVO CREAMOS EL LOTE 

            //        ////INSERT DE ENCABEZADO
            //        //SqlCommand command = new SqlCommand("sp_insert_mp_lote_h_for_kardex", transaction.Connection);
            //        //command.Transaction = transaction;
            //        //command.CommandType = CommandType.StoredProcedure;
            //        //command.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
            //        //command.Parameters.AddWithValue("@itemcode", ItemCode);
            //        //command.Parameters.AddWithValue("@itemname", txtMP_Name.Text);
            //        //command.Parameters.AddWithValue("@usuario_creado", UsuarioLogueado.Id);
            //        //if (ItemCode == "MP00080" || ItemCode == "MP00081")//Reproceso Tilapia - Camaron
            //        //{
            //        //    command.Parameters.AddWithValue("@cardname", DBNull.Value);
            //        //    command.Parameters.AddWithValue("@cardcode", DBNull.Value);
            //        //}
            //        //else
            //        //{
            //        //    command.Parameters.AddWithValue("@cardname", buttonProveedores.Text);
            //        //    command.Parameters.AddWithValue("@cardcode", cardcode);
            //        //}

            //        //id_lote_h = Convert.ToInt32(command.ExecuteScalar());

            //        ////INSERT DE DETALLE
            //        //SqlCommand cmd2 = new SqlCommand("sp_insert_mp_lote_d_for_kardex_ajuste",transaction.Connection);
            //        //cmd2.Transaction = transaction;
            //        //cmd2.CommandType = CommandType.StoredProcedure;
            //        //cmd2.Parameters.AddWithValue("@id_h", id_lote_h);
            //        //cmd2.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
            //        //cmd2.Parameters.AddWithValue("@lote", txtLoteNuevo.Text);
            //        //cmd2.Parameters.AddWithValue("@cantidadtotal", spinEditUnidades.EditValue);
            //        //cmd2.Parameters.AddWithValue("@cantidadportarima", dp.ValidateNumberInt32(txtUnidadsPorTarima.Text));
            //        //cmd2.Parameters.AddWithValue("@totaltarimas", dp.ValidateNumberInt32(txtCantidadTarimas));
            //        //cmd2.Parameters.AddWithValue("@id_unidadmedida", gridLookUpEditPresentacion.EditValue);
            //        //cmd2.Parameters.AddWithValue("@peso", spinEditPesoKg.EditValue);
            //        //cmd2.Parameters.AddWithValue("@id_mp", Id_MP);
            //        //cmd2.ExecuteNonQuery();


            //        //REALIZAMOS EL INSERT DEL MOVIMIENTO EN KARDEX
            //        SqlCommand cmd3 = new SqlCommand("sp_ajuste_kardex_por_lote_v5", transaction.Connection);
            //        cmd3.Transaction = transaction;
            //        cmd3.CommandType = CommandType.StoredProcedure;
            //        cmd3.Parameters.AddWithValue("@cant_entrada", spinEditPesoKg.EditValue);
            //        cmd3.Parameters.AddWithValue("@cant_salida", 0);
            //        cmd3.Parameters.AddWithValue("@ud_entrada", spinEditUnidades.EditValue);
            //        cmd3.Parameters.AddWithValue("@ud_salida", 0);
            //        cmd3.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.EditValue);

            //        cmd3.Parameters.AddWithValue("@bodega_origen", gridLookUpEditOrigen.EditValue);

            //        //Ponemos el mismo valor, esto es por que es un ajuste a una sola bodega, entrada o salida
            //        cmd3.Parameters.AddWithValue("@bodega_destino", gridLookUpEditOrigen.EditValue);

            //        cmd3.Parameters.AddWithValue("@id_referencia_operacion", DBNull.Value);
            //        cmd3.Parameters.AddWithValue("id_lote_alosy", DBNull.Value);
            //        cmd3.Parameters.AddWithValue("@lote", txtLoteNuevo.Text);
            //        cmd3.Parameters.AddWithValue("@id_mp", Id_MP);
            //        cmd3.Parameters.AddWithValue("@itemcode", ItemCode);
            //        cmd3.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
            //        cmd3.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
            //        cmd3.Parameters.AddWithValue("@tipo_operacion", 1);
            //        cmd3.Parameters.AddWithValue("@justificacion", txtJustificacion.Text);
            //        cmd3.Parameters.AddWithValue("@es_nuevo_lote", 1);
            //        cmd3.ExecuteNonQuery();
            //        //Attempt to commit the transaction.

            //        transaction.Commit();
            //        conn.Close();

            //        CajaDialogo.Information("Transaccion de Lote Exitosa!");
            //        this.DialogResult = DialogResult.OK;
            //        this.Close();

            //    }
            //    catch (Exception ex)
            //    {
            //        CajaDialogo.Error(ex.Message);
            //        transaction.Rollback();
            //    }
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }
    }
}