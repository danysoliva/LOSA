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
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Logistica
{
    public partial class frmRecuentoInventario : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        Recuento NuevoRecuento;
        int DEFAULT_VALUE = 0;
        DataOperations dp = new DataOperations();

        public frmRecuentoInventario(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            NuevoRecuento = new Recuento();
            get_years();
            get_meses_by_year();
            
            GetInventarioExistente();
        }

        public class Recuento
        {
            public int mes;
            public string mes_name;
            public int year;
            public string comentario;
            public DateTime date_counted;
            private int DEFAULT_VALUE = 0;

            public Recuento()
            {
                mes = DEFAULT_VALUE;
                mes_name = "";
                year = DEFAULT_VALUE;
                comentario = "";
            }
        }

        public void GetInventarioExistente()
        {
            string query = @"sp_get_inventario_por_bodega";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.Recuento_mpV2.Clear();
                da.Fill(dsCierreMes1.Recuento_mpV2);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void get_years()
        {
            string query = @"sp_obtener_años_disponibles";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.years.Clear();
                da.Fill(dsCierreMes1.years);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_meses_by_year()
        {
            string query = @"sp_get_meses_disponible_por_ejercicio";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@year", NuevoRecuento.year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes1.meses.Clear();
                da.Fill(dsCierreMes1.meses);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_years_EditValueChanged(object sender, EventArgs e)
        {
            NuevoRecuento.year = Convert.ToInt32(grd_years.EditValue);
            if (NuevoRecuento.year != DEFAULT_VALUE)
            {
                grd_meses_disponibles.Enabled = true;
                get_meses_by_year();
            }
        }

        private void grd_meses_disponibles_EditValueChanged(object sender, EventArgs e)
        {
            NuevoRecuento.mes = Convert.ToInt32(grd_meses_disponibles.EditValue);
            NuevoRecuento.mes_name = grd_meses_disponibles.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositoryEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar en memoria los productos seleccionados
            var gridView1 = (GridView)grdRecuento.FocusedView;
            var row = (dsCierreMes.Recuento_mpV2Row)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(grdRecuentoVista.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAddArticulo_Click(object sender, EventArgs e)
        {
            //frm_selecionarProducto frm = new frm_selecionarProducto(tabActive);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    if (tabActive == 0)
            //    {
            //        DataRow dr = dsCierreMes.Recuento_mp.NewRow();
            //        dr["id_mp"] = frm.id;
            //        dr["descripcion"] = frm.descripcion;
            //        dr["odoo"] = frm.codigo;
            //        dr["peso"] = DEFAULT_VALUE;
            //        dr["diferencia"] = DEFAULT_VALUE;
            //        dr["id_bodega"] = DEFAULT_VALUE;
            //        dr["ExistenciaAprox"] = DEFAULT_VALUE;
            //        dsCierreMes.Recuento_mp.Rows.Add(dr);
            //        dsCierreMes.Recuento_mp.AcceptChanges();
            //    }
            //    else
            //    {
            //        DataRow dr = dsCierreMes.Recuento_pt.NewRow();
            //        dr["id_mp"] = frm.id;
            //        dr["descripcion"] = frm.descripcion;
            //        dr["odoo"] = frm.codigo;
            //        dr["peso"] = DEFAULT_VALUE;
            //        dr["diferencia"] = DEFAULT_VALUE;
            //        dr["id_bodega"] = DEFAULT_VALUE;
            //        dr["ExistenciaAprox"] = DEFAULT_VALUE;
            //        dsCierreMes.Recuento_pt.Rows.Add(dr);
            //        dsCierreMes.Recuento_pt.AcceptChanges();
            //    }
            //}
        }

        private void grdRecuentoVista_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridview1 = (GridView)grdRecuento.FocusedView;
            var row = (dsCierreMes.Recuento_mpV2Row)gridview1.GetFocusedDataRow();

            foreach (dsCierreMes.Recuento_mpV2Row row2 in dsCierreMes1.Recuento_mpV2.Rows)
            {
                row2.diferencia = row2.existencia - row2.toma_fisica;
                row2.nueva_cantidad = row2.toma_fisica;
            }
        }
    }


}