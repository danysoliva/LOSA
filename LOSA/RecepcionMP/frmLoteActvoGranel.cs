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

namespace LOSA.RecepcionMP
{
    public partial class frmLoteActvoGranel : Form
    {
        UserLogin UsuarioLogeado;
        public frmLoteActvoGranel(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadDataActivos();
            LoadDataDesactivados();
        }

        private void LoadDataActivos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_activos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@case", 1);
                dsRecepcionMPx1.lote_activo_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.lote_activo_granel);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadDataDesactivados()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_activos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@case", 2);
                dsRecepcionMPx2.lote_activo_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx2.lote_activo_granel);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdNuevoLote_Click(object sender, EventArgs e)
        {
            frmAddLoteActivo frm = new frmAddLoteActivo(UsuarioLogeado);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataActivos();
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton Editar Lote
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lote_activo_granelRow)gridView.GetFocusedDataRow();

            frmEditLoteActivo frm = new frmEditLoteActivo(UsuarioLogeado, row.lote, row.id, row.fecha);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataActivos();
            }
        }

        private void cmdDesactivar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //BOton desactivar lote
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.lote_activo_granelRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_transaccion_lote_granel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@case", 1);
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                LoadDataActivos();
                LoadDataDesactivados();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdActivar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton ACTIVAR Lote
            try
            {
                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsRecepcionMPx.lote_activo_granelRow)gridView.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_transaccion_lote_granel", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@case", 2);
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                LoadDataActivos();
                LoadDataDesactivados();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
