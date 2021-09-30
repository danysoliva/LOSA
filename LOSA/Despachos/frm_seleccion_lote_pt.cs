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
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace LOSA.Despachos
{
    public partial class frm_seleccion_lote_pt : DevExpress.XtraEditors.XtraForm
    {
        DataTable Productos;
        int selected = 0;
        int deseleccioanr = 0;
        int Ud_selected = 0;
        string itemcode;
        public DataTable dt;
        public frm_seleccion_lote_pt(DataTable pdt)
        {
            InitializeComponent();
            Productos = pdt;
            grd_data.DataSource = Productos;
            LoadPresentaciones();
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void load_data(string itemcode) 
        {

            DataOperations dp = new DataOperations();
            string query = @"sp_load_disponible_seleccion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Close();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itemcode", itemcode);
            ds_despachos.existencia_seleccion.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds_despachos.existencia_seleccion);
            cn.Close();
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = gridView.GetFocusedDataRow();
                 itemcode = row["itemcode"].ToString();
                load_data(itemcode);
                Ud_selected = Convert.ToInt32(row["unidades"]);
                chautoseleccion.Checked = false;
                if (ds_despachos.lotes_selected_all.Count > 0)
                {
                    ds_despachos.lotes_selected.Clear();
                    foreach (ds_despachos.lotes_selected_allRow Cof in ds_despachos.lotes_selected_all.Rows)
                    {
                        if (itemcode == Cof.itemcode)
                        {
                            DataRow dr = ds_despachos.lotes_selected.NewRow();
                            dr[0] = Cof.lote_producto_termiado;
                            dr[1] = Cof.vencimiento;
                            dr[2] = Cof.Cantidad;
                            dr[3] = Cof.seleccionada;
                            dr[4] = false;
                            dr[5] = Cof.itemcode;
                            dr[6] = Cof.restante;


                            ds_despachos.lotes_selected.Rows.Add(dr);
                            ds_despachos.lotes_selected.AcceptChanges();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

              
            }
        }
        private bool IsNotActive(GridView view, int row)
        {
            GridColumn col = view.Columns["selected"];
            bool val = Convert.ToBoolean(view.GetRowCellValue(row, col));
            if (val)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void grdv_existencia_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;

                if (view.FocusedColumn.FieldName == "seleccionada" && IsNotActive(view, view.FocusedRowHandle))
                {
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message) ;
            }
        }

        


        private void chautoseleccion_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chautoseleccion.Checked)
                {
                    decimal aux = Ud_selected;
                    foreach (ds_despachos.existencia_seleccionRow row in ds_despachos.existencia_seleccion.Rows)
                    {
                        if (aux > 0)
                        {
                            if (row.Cantidad > aux)
                            {
                                row.selected = true;
                                row.seleccionada = aux;
                                row.restante = row.Cantidad - aux;
                                aux = 0;
                                selected = selected + 1;
                            }
                            else
                            {
                                row.selected = true;
                                row.seleccionada = row.Cantidad;
                                row.restante = 0;
                                aux = aux - row.Cantidad;
                                selected = selected + 1;
                            }
                        }
                    }
                }
                else
                {
                    foreach (ds_despachos.existencia_seleccionRow row in ds_despachos.existencia_seleccion.Rows)
                    {
                        row.restante = row.Cantidad;
                        row.seleccionada = 0;
                        row.selected = false;

                        selected = 0;
                    }
                }
                if (selected > 0)
                {
                    btnSeleccionar.Enabled = true;
                }
                else
                {
                    btnSeleccionar.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_existencia_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_existencia.FocusedView;
                var row = (ds_despachos.existencia_seleccionRow)gridView.GetFocusedDataRow();

                if (e.Column.Name == "colselected")
                {
                    row.selected = Convert.ToBoolean(e.Value);
                    if (Convert.ToBoolean(e.Value))
                    {
                        row.seleccionada = 1;
                        row.restante = row.Cantidad - 1;
                        selected = selected + 1;
                        
                    }
                    else
                    {
                        row.seleccionada = 0;
                        row.restante = row.Cantidad;
                        selected = selected - 1;
                    }

                    row.AcceptChanges();
                    if (selected > 0)
                    {
                        btnSeleccionar.Enabled = true;
                    }
                    else
                    {
                        btnSeleccionar.Enabled = false;
                    }
                }

                if (e.Column.Name == "colseleccionada")
                {
                    row.restante = row.Cantidad - Convert.ToDecimal(e.Value);
                    row.seleccionada = Convert.ToDecimal(e.Value);
                    row.AcceptChanges();
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal aux = 0;
                foreach (ds_despachos.existencia_seleccionRow row in ds_despachos.existencia_seleccion.Rows)
                {
                    if (row.selected == true)
                    {
                        aux = aux + row.seleccionada;
                    }
                }
                if (aux > Ud_selected)
                {
                    CajaDialogo.Error("No se puede enviar mas unidades de este producto, por favor rebaje la candidad seleccionada.");
                    return;
                }

                ds_despachos.lotes_selected.Clear();
                foreach (ds_despachos.existencia_seleccionRow Cof in ds_despachos.existencia_seleccion.Rows)
                {
                    if (Cof.selected)
                    {
                        DataRow dr = ds_despachos.lotes_selected.NewRow();
                        dr[0] = Cof.lote_producto_termiado;
                        dr[1] = Cof.vencimiento;
                        dr[2] = Cof.Cantidad;
                        dr[3] = Cof.seleccionada;
                        dr[4] = false;
                        dr[5] = Cof.itemcode;
                        dr[6] = Cof.restante;

                       
                        ds_despachos.lotes_selected.Rows.Add(dr);
                        ds_despachos.lotes_selected.AcceptChanges();
                    }
                      
                }

                foreach (ds_despachos.lotes_selected_allRow item in ds_despachos.lotes_selected_all.Rows)
                {
                    if (item.itemcode == itemcode)
                    {
                        item.Delete();
                    }
                }
                ds_despachos.lotes_selected_all.AcceptChanges();

                foreach (ds_despachos.existencia_seleccionRow Cof in ds_despachos.existencia_seleccion.Rows)
                {
                    if (Cof.selected)
                    {
                        DataRow dr = ds_despachos.lotes_selected_all.NewRow();
                        dr[0] = Cof.lote_producto_termiado;
                        dr[1] = Cof.vencimiento;
                        dr[2] = Cof.Cantidad;
                        dr[3] = Cof.seleccionada;
                        dr[4] = false;
                        dr[5] = Cof.itemcode;
                        dr[6] = Cof.restante;


                        ds_despachos.lotes_selected_all.Rows.Add(dr);
                        ds_despachos.lotes_selected_all.AcceptChanges();
                    }

                }


            }
            catch (Exception ex)
            {

               
            }
        }

        private void frm_seleccion_lote_pt_Load(object sender, EventArgs e)
        {

        }

        private void grdv_requerido_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                var gridView = (GridView)grv_requerido.FocusedView;
                var row = (ds_despachos.lotes_selectedRow)gridView.GetFocusedDataRow();

                if (e.Column.Name == "colselected1")
                {
                    row.selected = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();

                    if (Convert.ToBoolean(e.Value))
                    {
                        deseleccioanr = deseleccioanr + 1;
                    }
                    else
                    {
                        deseleccioanr = deseleccioanr - 1;
                    }

                    if (deseleccioanr > 0)
                    {
                        btnQuitar.Enabled = true;
                    }
                    else
                    {
                        btnQuitar.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ds_despachos.lotes_selected.Count; i++)
            {
                DataRow dr = ds_despachos.lotes_selected.Rows[i];
                if (Convert.ToBoolean(dr["selected"]))
                {
                    for (int j = 0; j < ds_despachos.lotes_selected_all.Count; j++)
                    {
                        DataRow all = ds_despachos.lotes_selected_all.Rows[j];
                        if (Convert.ToInt32(all["lote_producto_termiado"]) == Convert.ToInt32(dr["lote_producto_termiado"]) && Convert.ToDateTime(all["vencimiento"]) == Convert.ToDateTime(dr["vencimiento"]))
                        {
                            ds_despachos.lotes_selected_all.Rows.RemoveAt(j);
                            ds_despachos.lotes_selected_all.AcceptChanges();
                        }
                    }
                    ds_despachos.lotes_selected.Rows.RemoveAt(i);
                    ds_despachos.lotes_selected.AcceptChanges();
                }
            }
            deseleccioanr = 0;
            btnQuitar.Enabled = false;  

          
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
            dt = ds_despachos.lotes_selected_all;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}