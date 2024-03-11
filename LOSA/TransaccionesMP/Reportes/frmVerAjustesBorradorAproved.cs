using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
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

namespace LOSA.TransaccionesMP.Reportes
{
    public partial class frmVerAjustesBorradorAproved : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmVerAjustesBorradorAproved(UserLogin pUser)
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

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMP_AjusteLote.borradores_selectRow)gridView.GetFocusedDataRow();

            if(row.id_estado_borrador > 1)
            {
                CajaDialogo.Error("Solo se permite eliminar ajustes en estado: Pendiente!");
                return;
            }

            DialogResult r = CajaDialogo.Error("Esta seguro de cancelar este ajuste?");
            if(r != DialogResult.Yes)
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
    }
}