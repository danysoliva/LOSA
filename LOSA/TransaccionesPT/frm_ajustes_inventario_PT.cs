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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesPT
{
    public partial class frm_ajustes_inventario_PT : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frm_ajustes_inventario_PT(UserLogin pUSER)
        {
            InitializeComponent();
            UsuarioLogeado = pUSER;
            load_data();
        }

        public void load_data() 
        {
            try
            {
                string query = @"sp_load_ajuste_inventario_pt";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.AjustesInventario.Clear();
                da.Fill(dsPT.AjustesInventario);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.AjustesInventarioRow)gridView.GetFocusedDataRow();
                if (row.realizado)
                {
                    CajaDialogo.Error("No se puede Editar un ajuste de inventario ya realizado.");
                    return;
                }
                // Mas codigo soon

                frm_ajustes_inventario_PT_def frm = new frm_ajustes_inventario_PT_def(UsuarioLogeado, frm_ajustes_inventario_PT_def.TipoOp.Editar, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_ajustes_inventario_PT_def frm = new frm_ajustes_inventario_PT_def(UsuarioLogeado, frm_ajustes_inventario_PT_def.TipoOp.Nuevo,0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.AjustesInventarioRow)gridView.GetFocusedDataRow();
            if (row.realizado)
            {
                CajaDialogo.Error("Ya se realizo este ajuste de inventario. No se puede volver a correr.");
                return;
            }
            frmdetalle_de_salida frm = new frmdetalle_de_salida(row.id, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }





        }
    }
}