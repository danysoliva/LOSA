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
                    cmd.Parameters.AddWithValue("@id_pt",id );
                    dsParametros.parametroProducto.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsParametros.parametroProducto);
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
    }
}