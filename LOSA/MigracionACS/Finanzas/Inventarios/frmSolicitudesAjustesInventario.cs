using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.Mantenimientos;
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
        UserLogin UsuarioLogeado;
        public frmSolicitudesAjustesInventario(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
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

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de cancelar este ajuste?");
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
            catch// (Exception ec)
            {
                //Console.WriteLine(ec.Message);
                //CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAprobar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMP_AjusteLote.borradores_selectRow)gridView.GetFocusedDataRow();

            if (row.id_estado_borrador != 1)
            {
                CajaDialogo.Error("Solo se permite aprobar ajustes en estado: Pendiente.");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de aprobar este ajuste?");
            if (r != DialogResult.Yes)
                return;

            DataOperations dp = new DataOperations();
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA))
            {
                SqlTransaction transaction;

                conn.Open();
                transaction = conn.BeginTransaction("SampleTransaction");

                try
                {
                    SqlCommand cmd3 = new SqlCommand("sp_insert_mp_lote_h_for_kardex_ajuste_aprobado", transaction.Connection);
                    cmd3.Transaction = transaction;
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@id_borrador", row.id);
                    cmd3.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);

                    cmd3.ExecuteNonQuery();

                    transaction.Commit();
                    conn.Close();

                    //CajaDialogo.Information("Transaccion de Lote Exitosa!");
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    CajaDialogo.Error(ex.Message);
                }


                //Eliminar row del grid
                try
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
                catch 
                {
                    //CajaDialogo.Error(ec.Message);
                }
            }
        }
    }
}