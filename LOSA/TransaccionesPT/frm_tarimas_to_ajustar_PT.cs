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
    
    public partial class frm_tarimas_to_ajustar_PT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_ajuste;
        UserLogin UsuarioLogeado;
        public decimal factor;
        public enum TipoOp
        {
                Nuevo,
                Editar
        }
        TipoOp Op;
        public frm_tarimas_to_ajustar_PT(UserLogin Puser, int Pid, TipoOp Pop)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            id_ajuste = Pid;
            Op = Pop;
            load_presentacion();
            load_informacion();

            if (Op == TipoOp.Nuevo)
            {
                load_data();

            }
            else
            {
                load_prev_confi();
            }

        }
        
        public void load_presentacion() 
        {
            string query = @"sp_get_presentaciones_activas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.presentacion.Clear();
                da.Fill(dsPT.presentacion);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_informacion() 
        {
            string query = @"sp_obtener_pt_in_inventario";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.ProductoPT.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.ProductoPT);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_prev_confi()
        {
            string query = @"sp_load_tarimas_pt_to_ajustar_edit";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.AjusteInv_Detalle.Clear();
                da.Fill(dsPT.AjusteInv_Detalle);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }
        public  void load_data() 
        {
            string query = @"sp_load_tarimas_pt_to_ajustar_new";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.AjusteInv_Detalle.Clear();
                da.Fill(dsPT.AjusteInv_Detalle);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message) ;
            }
        }
        private void frm_tarimas_to_ajustar_PT_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grdv_data.FindFilterText = txtubicacion.Text;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoOp.Editar == Op)
                {
                    string query = @"sp_desactivar_ajustes_after_edit";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                    cmd.ExecuteNonQuery();

                    query = @"sp_insert_into_ajuste_inventario";
                    foreach (dsPT.AjusteInv_DetalleRow item in dsPT.AjusteInv_Detalle.Rows)
                    {
                        if (item.editado)
                        {
                            cmd = new SqlCommand(query,cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            if (item.cantidad < item.cantidad_rep)
                            {          //Esto quiere decir que estamos sacando Inventario..

                                cmd.Parameters.AddWithValue("@cantidad_in", DBNull.Value);
                                cmd.Parameters.AddWithValue("@cantidad_out", item.cantidad_rep - item.cantidad);
                                cmd.Parameters.AddWithValue("@peso_in", DBNull.Value);
                                cmd.Parameters.AddWithValue("@peso_out", item.peso_rep - item.peso);
                                cmd.Parameters.AddWithValue("@id_tm", item.id);
                                cmd.Parameters.AddWithValue("@id_tipo", 2); // El dos es salida supongo
                                cmd.Parameters.AddWithValue("@id_presentacion", item.id_presentacion);
                                cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@cantidad_out", DBNull.Value);
                                cmd.Parameters.AddWithValue("@cantidad_in", item.cantidad - item.cantidad_rep);
                                cmd.Parameters.AddWithValue("@peso_out", DBNull.Value);
                                cmd.Parameters.AddWithValue("@peso_in", item.peso - item.peso_rep);
                                cmd.Parameters.AddWithValue("@id_tm", item.id);
                                cmd.Parameters.AddWithValue("@id_tipo", 1); // El 1 es salida supongo  
                                cmd.Parameters.AddWithValue("@id_presentacion", item.id_presentacion);
                                cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    CajaDialogo.Information("Ajuste guardado satisfactoriamente. En espera para ser Ejecutado.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();



                }
                else
                {
                    string query = @"sp_insert_into_ajuste_inventario";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd;


                    foreach (dsPT.AjusteInv_DetalleRow item in dsPT.AjusteInv_Detalle.Rows)
                    {
                        if (item.editado)
                        {
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            if (item.cantidad < item.cantidad_rep)
                            {          //Esto quiere decir que estamos sacando Inventario..

                                cmd.Parameters.AddWithValue("@cantidad_in", DBNull.Value);
                                cmd.Parameters.AddWithValue("@cantidad_out", item.cantidad_rep - item.cantidad);
                                cmd.Parameters.AddWithValue("@peso_in", DBNull.Value);
                                cmd.Parameters.AddWithValue("@peso_out", item.peso_rep - item.peso);
                                cmd.Parameters.AddWithValue("@id_tm", item.id);
                                cmd.Parameters.AddWithValue("@id_tipo", 2); // El dos es salida supongo 
                                cmd.Parameters.AddWithValue("@id_presentacion", item.id_presentacion);
                                cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@cantidad_out", DBNull.Value);
                                cmd.Parameters.AddWithValue("@cantidad_in", item.cantidad - item.cantidad_rep);
                                cmd.Parameters.AddWithValue("@peso_out", DBNull.Value);
                                cmd.Parameters.AddWithValue("@peso_in", item.peso - item.peso_rep);
                                cmd.Parameters.AddWithValue("@id_tm", item.id);
                                cmd.Parameters.AddWithValue("@id_tipo", 1); // El 1 es salida supongo  
                                cmd.Parameters.AddWithValue("@id_presentacion", item.id_presentacion);
                                cmd.Parameters.AddWithValue("@id_ajuste", id_ajuste);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    CajaDialogo.Information("Ajuste guardado satisfactoriamente. En espera para ser Ejecutado.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            grdv_data.FindFilterText = txtubicacion.Text;
        }

        private void grd_producto_EditValueChanged(object sender, EventArgs e)
        {
            //grdv_data.FindFilterText = grd_producto.EditValue.ToString();
        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                int id_presentacion = 0;

                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.AjusteInv_DetalleRow)gridView.GetFocusedDataRow();
                switch (e.Column.Name)
                {
                    case "colid_presentacion":    //presentacion
                        foreach (dsPT.presentacionRow item in dsPT.presentacion.Rows)
                        {
                            if (Convert.ToInt32(e.Value) == item.id)
                            {
                                factor = item.factor;
                                row.id = item.id;
                            }
                        }
                        row.peso = row.cantidad * factor;
                        row.AcceptChanges();
                        row.editado = true;
                        break;
                    case "coldel":                                    //eliminar

                        foreach (dsPT.presentacionRow item in dsPT.presentacion.Rows)
                        {
                            if (row.id_presentacion == item.id)
                            {
                                factor = item.factor;
                            }
                        }
                        row.cantidad = Convert.ToBoolean(e.Value) ? 0 : row.cantidad_rep;
                        row.peso = Convert.ToBoolean(e.Value) ? 0 : row.cantidad_rep * factor;
                        row.del = Convert.ToBoolean(e.Value) ? true : false;

                        row.editado = true;
                        if (row.Por_lote)
                        {
                            row.Por_lote = false;

                        }
                        row.AcceptChanges();
                        break;
                    case "colPor_lote":
                        foreach (dsPT.AjusteInv_DetalleRow rows in dsPT.AjusteInv_Detalle.Rows)
                        {
                            if (row.lote_producto_termiado == rows.lote_producto_termiado)
                            {
                                foreach (dsPT.presentacionRow item in dsPT.presentacion.Rows)
                                {
                                    if (rows.id_presentacion == item.id)
                                    {
                                        factor = item.factor;
                                    }
                                }

                                rows.editado = true;
                                rows.cantidad = Convert.ToBoolean(e.Value) ? 0 : rows.cantidad_rep;
                                rows.peso = Convert.ToBoolean(e.Value) ? 0 : rows.cantidad_rep * factor;
                                rows.del = Convert.ToBoolean(e.Value) ? true : false;
                                rows.Por_lote = Convert.ToBoolean(e.Value) ? true : false;
                            }
                        }
                        dsPT.AjusteInv_Detalle.AcceptChanges();
                        break;
                    case "colcantidad":
                        foreach (dsPT.presentacionRow item in dsPT.presentacion.Rows)
                        {
                            if (Convert.ToInt32(row.id_presentacion) == item.id)
                            {
                                factor = item.factor;
                            }
                        }
                        row.cantidad = Convert.ToInt32(e.Value);
                        row.peso = Convert.ToInt32(e.Value) * factor;
                        row.editado = true;
                        row.AcceptChanges();
                        break;
                    case "colpeso":
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}