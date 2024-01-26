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
using LOSA.Clases;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad.Parametros
{
    
    public partial class frmParametrosProducto : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id;
        string Descripcion;
        string Codigo;
        public frmParametrosProducto(int ParametroID,
                                    string ParametroDesripcion,
                                    string ParametroCodigo)
        {
            id = ParametroID;
            Descripcion = ParametroDesripcion;
            Codigo = ParametroCodigo;
            InitializeComponent();
            txtproducto.Text = "(" + Codigo + ") -" + Descripcion;
            load_data();
            load_grupos();
        }

        public void load_grupos()
        {
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string Query = @"sp_get_grupos_parametros";
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dsParametros1.grupos.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsParametros1.grupos);
                    cn.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_data()
        {
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string Query = @"sp_get_parametros_and_producto";
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_pt",id);
                    dsParametros1.parametroProducto.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsParametros1.parametroProducto);
                    cn.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmPickParametrs frm = new frmPickParametrs(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea borrar este parametro?", "Desea borrar este parametro?" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        var gridView = (GridView)grd_data.FocusedView;
                        var row = (dsParametros.parametroProductoRow)gridView.GetFocusedDataRow();
                        string query = @"sp_delete_parametros_productos";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                    }
                    catch (Exception ex)
                    {

                        CajaDialogo.Error(ex.Message);
                    }


                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void grdv_data_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsParametros.parametroProductoRow)gridView.GetFocusedDataRow();
                if (row.tipo_rep  != 1 && (grdv_data.FocusedColumn.FieldName == "min"
                    || grdv_data.FocusedColumn.FieldName == "maximo"))
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsParametros.parametroProductoRow)gridView.GetFocusedDataRow();
                if (e.Column.FieldName == "min")
                {
                    row.min = Convert.ToDecimal(e.Value);
                    row.AcceptChanges();
                }

                if (e.Column.FieldName == "maximo")
                {
                    row.maximo = Convert.ToDecimal(e.Value);
                    row.AcceptChanges();
                }
                if (e.Column.FieldName == "id_printed_cef")
                {
                    row.id_printed_cef = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();
                }
                if (e.Column.FieldName == "ficha_tecnica")
                {
                    row.especificaciones = Convert.ToString(e.Value);
                    row.AcceptChanges();
                }
                string query = @"sp_update_producto_parametro";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_parametros_producto", row.id);
                cmd.Parameters.AddWithValue("@min", row.min);
                cmd.Parameters.AddWithValue("@max", row.maximo);
                cmd.Parameters.AddWithValue("@id_grupo", row.id_grupo);
                cmd.Parameters.AddWithValue("@is_printed_cef", row.id_printed_cef ? 1 : 0);
                cmd.Parameters.AddWithValue("@especificaciones ", row.especificaciones);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}