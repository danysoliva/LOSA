using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using LOSA.Despachos.Reportes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using DevExpress.XtraReports.UI;

namespace LOSA.Despachos
{
    public partial class frm_generar_despacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int DocEntry;
        private int LineNum;
        private int Id_despacho;
        UserLogin UsuarioLogeado;
        string codigo_selected;
        private int destino_id, id_presentacion, estiba_id;
        private decimal sacos_totales;
        string DestinoTxt;
        string TipoTxt;
        decimal PresentacionTxt;
        public enum OpType
        {
            Update = 1,
            Nuevo = 2
        }
        OpType Operacion;
        public frm_generar_despacho(int DocEntry, int LineNum, UserLogin Puser)
        {
            InitializeComponent();
            Operacion = OpType.Nuevo;

            this.DocEntry = DocEntry;
            this.LineNum = LineNum;
            UsuarioLogeado = Puser;
            LoadPresentaciones();
            load_informacion();
            LoadPresentacionesHabilitadas();

        }

        public frm_generar_despacho(int id_Despacho, UserLogin Puser)
        {
            InitializeComponent();
            if (id_Despacho > 0)
                txtNumDespacho.Text = id_Despacho.ToString();
            else
                txtNumDespacho.Text = "";

            Operacion = OpType.Update;
            this.Id_despacho = id_Despacho;
            grd_destino.Enabled = true;
            LoadPresentaciones();
            LoadPresentacionesHabilitadas();
            load_informacion();
            LoadPresentacionesHabilitadas();
            
            btn_guardar.Text = "Guardar Cambios";
        }

        private void LoadPresentacionesGuardada(decimal psacos_totales , int pestiba_id, int pid_present,  int pDestinoID)
        {
            try
            {
                string query = @"sp_get_grid_lista_destinos_config_despacho_pt_guardada";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SacosTotal", psacos_totales);
                cmd.Parameters.AddWithValue("@destino_id", pDestinoID);
                cmd.Parameters.AddWithValue("@estiba_id", pestiba_id);
                cmd.Parameters.AddWithValue("@id_presentacion", pid_present);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos.destinos_empaques_pt.Clear();
                adat.Fill(dsProductos.destinos_empaques_pt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadPresentacionesHabilitadas()
        {
            try
            {
                string query = @"sp_get_grid_lista_destinos_config_despacho_pt_";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@cantidad", pcantidad_Ud_Despachos);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProductos.destinos_empaques_pt.Clear();
                adat.Fill(dsProductos.destinos_empaques_pt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas_v5", con);
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

        public void load_informacion()
        {
            try
            {
                string query = @"";

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd;
                switch (Operacion)
                {
                    case OpType.Update:
                        query = @"sp_load_info_despacho_boleta_config";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_despacho", Id_despacho);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txtboleta.Text = dr.IsDBNull(0) ? "" : dr.GetInt32(0).ToString();
                            txtvehiculo.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                            txtconductor.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                            DocEntry = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                            grd_destino.EditValue = dr.IsDBNull(6) ? 0 : dr.GetInt32(6);
                            codigo_selected = dr.IsDBNull(7) ? "" : dr.GetString(7);
                            sacos_totales = dr.IsDBNull(8) ? 0 : dr.GetDecimal(8);
                            estiba_id = dr.IsDBNull(9) ? 0 : dr.GetInt32(9);
                            id_presentacion = dr.IsDBNull(10) ? 0 : dr.GetInt32(10);
                            destino_id = dr.IsDBNull(11) ? 0 : dr.GetInt32(11);
                            load_destinos(codigo_selected);
                            if (sacos_totales != 0)
                            {
                                LoadPresentacionesGuardada(sacos_totales, estiba_id, id_presentacion, destino_id);
                                grd_conf_filas.EditValue = destino_id;

                                try
                                {
                                    
                                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                                    conn.Open();
                                    SqlCommand cmd2 = new SqlCommand("sp_get_grid_lista_destinos_config_despacho_pt_clase", conn);
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Parameters.AddWithValue("@destino_id", destino_id);
                                    cmd2.Parameters.AddWithValue("@estiba_id", estiba_id);
                                    cmd2.Parameters.AddWithValue("@id_presentacion", id_presentacion);
                                    SqlDataReader dr2 = cmd2.ExecuteReader();
                                    if (dr2.Read())
                                    {
                                        TipoTxt = dr2.IsDBNull(2) ? "" : dr2.GetString(2).ToString();
                                        DestinoTxt = dr2.IsDBNull(3) ? "" : dr2.GetString(3).ToString();
                                        PresentacionTxt = dr2.IsDBNull(4) ? 0 : dr2.GetDecimal(4);
                                    }

                                    txtInfoConFilas.Text = "Destino: " + DestinoTxt + " - Tipo: " + TipoTxt + " - Presentacion: " + PresentacionTxt;

                                    dr2.Close();
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    CajaDialogo.Error(ex.Message);
                                }
                            }
                        }
                        dr.Close();
                        cn.Close();

                        cn.Open();

                        query = @"sp_load_info_despacho_complete";
                        cmd = new SqlCommand(query, cn);   
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", Id_despacho);

                        break;
                    case OpType.Nuevo:
                        query = @"sp_get_data_of_orden_venta_detalle_por_crear";  
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DocEntry", DocEntry);
                        cmd.Parameters.AddWithValue("@LineNum", LineNum);

                        break;
                    default:
                        query = @"sp_get_data_of_orden_venta_detalle_por_crear";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DocEntry", DocEntry);
                        cmd.Parameters.AddWithValue("@LineNum", LineNum);
                        break;
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.detalle_despachosComplete.Clear();
                da.Fill(ds_despachos.detalle_despachosComplete);
                cn.Close();

                Sumar_totales();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
      

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void load_destinos(string cod)
        {
            try
            {
                string query = @"sp_load_clientes_clientes_to_select";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliente", cod);
                ds_despachos.cliente_despacho.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds_despachos.cliente_despacho);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_pickboleta frm = new frm_pickboleta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtboleta.Text = Convert.ToString(frm.id_serie);
                txtvehiculo.Text = frm.Vehiculo;
                txtconductor.Text = frm.conductor;
                codigo_selected = frm.codigo;
                if (frm.codigo == "CL00009" || frm.codigo == "CL00002" || frm.codigo == "CL00001")
                {
                    load_destinos(frm.codigo);
                    labelControl8.Enabled = true;
                    grd_destino.Enabled = true;
                }
                else
                {
                    labelControl8.Enabled = false;
                    grd_destino.Enabled = false;
                }
                
            }
        }
         
        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.detalle_despachosCompleteRow)gridView.GetFocusedDataRow();
                if (row.id == 0)
                {
                    grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                }
                else
                {

                }
                ds_despachos.detalle_despachosComplete.AcceptChanges();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frm_mostar_otros_detalles frm = new frm_mostar_otros_detalles(DocEntry);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (ds_despachos.detalle_despachosCompleteRow row in ds_despachos.detalle_despachosComplete.Rows)
                    {
                        if (row.DocEntry == frm.DocEntry && row.id == frm.LineNUm)
                        {
                            CajaDialogo.Error("Ya se ha agregado este articulo de esta orden de venta a este despacho. Por favor selecionar otro");
                            return;
                        }
                    }
                    string query = @"";

                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd;
                    query = @"sp_get_data_of_orden_venta_detalle_por_crear";
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DocEntry", frm.DocEntry);
                    cmd.Parameters.AddWithValue("@LineNum", frm.LineNUm);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds_despachos.detalle_despachosComplete);
                    cn.Close();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
        }
        public void Sumar_totales()
        {
            decimal totalKg = 0;
            int totalUd =0;
            //foreach (ds_despachos.detalle_despachosRow row in ds_despachos.detalle_despachos.Rows)
            //{
            //    totalKg = totalKg + row.peso;
            //    totalUd = totalUd + row.unidades;
            //}

            foreach (ds_despachos.detalle_despachosCompleteRow row in ds_despachos.detalle_despachosComplete.Rows)
            {
                //totalKg = totalKg + row.Kg_linea;
                //totalUd = totalUd + row.cantidad;
            }

            txtunidades.Text = totalUd.ToString();
            txtKg.Text = totalKg.ToString();

        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{

            //    if (e.Column.Name == "colunidades")
            //    {
            //        var gridView = (GridView)grd_data.FocusedView;
            //        var row = (ds_despachos.detalle_despachosCompleteRow)gridView.GetFocusedDataRow();
            //        decimal factor = 1;
            //        if (row.id_presentacion != 0)
            //        {
            //            foreach (dsRecepcionMPx.presentacionesRow pres in dsRecepcionMPx.presentaciones.Rows)
            //            {

            //                if (row.id_presentacion == pres.id)
            //                {
            //                    factor = Convert.ToDecimal(pres.factor);
            //                }
            //            }
            //            row.cantidad = Convert.ToInt32(e.Value);
            //            //row.unidades = Convert.ToInt32(e.Value);
            //            //decimal prese = dp.ValidateNumberDecimal(row.presentacion);
            //            //row.peso = factor * Convert.ToInt32(e.Value);
            //            row.Kg_linea = factor * row.cantidad;
            //            row.tm_linea = row.Kg_linea / 1000;
            //            row.AcceptChanges();
            //            Sumar_totales();

            //        }
            //    }
            //    if (e.Column.Name == "colpresentacion")
            //    {
            //        var gridView = (GridView)grd_data.FocusedView;
            //        var row = (ds_despachos.detalle_despachosCompleteRow)gridView.GetFocusedDataRow();
            //        decimal factor = 1;

            //        row.id_presentacion = Convert.ToInt32(e.Value);
            //        if (row.id_presentacion != 0)
            //        {
            //            foreach (dsRecepcionMPx.presentacionesRow pres in dsRecepcionMPx.presentaciones.Rows)
            //            {

            //                if (row.id_presentacion == pres.id)
            //                {
            //                    factor = Convert.ToDecimal(pres.factor);
            //                }
            //            }
            //            //row.peso = factor * row.unidades;
            //            row.cantidad = Convert.ToInt32(e.Value);
            //            //row.unidades = Convert.ToInt32(e.Value);
            //            //decimal prese = dp.ValidateNumberDecimal(row.presentacion);
            //            //row.peso = factor * Convert.ToInt32(e.Value);
            //            row.Kg_linea = factor * row.cantidad;
            //            row.tm_linea = row.Kg_linea / 1000;
            //            row.AcceptChanges();
            //            Sumar_totales();
            //        }
            //    }
                                   

            //}
            //catch (Exception ex)
            //{

                
            //}
        }

        private void grd_conf_filas_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit lookup = sender as GridLookUpEdit;
            DataRowView datarowView = lookup.GetSelectedDataRow() as DataRowView;
            

            if (datarowView != null)
            {
                DataRow row = datarowView.Row;

                destino_id =Convert.ToInt32(row[0]);
                sacos_totales = Convert.ToDecimal(row.ItemArray[1]);
                estiba_id = Convert.ToInt32(row.ItemArray[5]);
                id_presentacion = Convert.ToInt32(row.ItemArray[6]);
                txtInfoConFilas.Text = "Destino: " +row[3] +" - Tipo: "+ row[2] +" - Presentacion: "+row[4];
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
                ds_despachos.detalle_despachosComplete.AcceptChanges();
            if (txtboleta.Text == "")
            {
                if (MessageBox.Show("Desea crear la orden de carga sin ligar una boleta? Se puede ligar en cualquier momento del proceso.", "Mensaje del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    
                }
                else
                {
                    return;
                }
                

            }

            int count = 0;
            string producto = "";

            foreach (ds_despachos.detalle_despachosCompleteRow row in ds_despachos.detalle_despachosComplete.Rows)
            {
                if (row.id_presentacion == 0)
                {
                    count = count + 1;
                    producto = row.itemname;
                }
            }

            if (count > 0)
            {
                CajaDialogo.Error("No se ha configurado correctamente el producto: " + producto + " Falta presentacion de producto");
                return;
            }

            if (ds_despachos.detalle_despachosComplete.Count == 0)
            {
                CajaDialogo.Error("Debo de colocar por lo menos un Producto Terminado en la orden de carga.");
                return;
            }


            // Aqui va la seleccion de lote.
            if (grd_conf_filas.Text == "")
            {
                CajaDialogo.Error("Debe seleccionar una configuracion de Filas y Destino!");
            }



            int SeAsingna = 0;
            string query = @"";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd;
            switch (Operacion)
            {    
                case OpType.Update:

                    query = @"sp_update_despacho_headerv2";//insert heades     
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_despacho", Id_despacho);
                    cmd.Parameters.AddWithValue("@id_direccion", grd_destino.EditValue);
                    if (txtboleta.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@boleta", DBNull.Value);
                        SeAsingna = 0;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@boleta", txtboleta.Text);
                        SeAsingna = 1;
                    }
                    cmd.Parameters.AddWithValue("@sacos_totales", sacos_totales);
                    cmd.Parameters.AddWithValue("@estiba_id", estiba_id);
                    cmd.Parameters.AddWithValue("@id_presentacion", id_presentacion);
                    cmd.Parameters.AddWithValue("@destino_id",destino_id);
                    cmd.ExecuteNonQuery();
                    foreach (ds_despachos.detalle_despachosCompleteRow row in ds_despachos.detalle_despachosComplete.Rows)
                    {
                        if (row.id == 0) //nuevo
                        {
                            query = @"sp_insert_orden_de_venta_detalle";//insert heades    
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@peso", row.Kg_linea);
                            cmd.Parameters.AddWithValue("@linenum", row.id);
                            cmd.Parameters.AddWithValue("@DocEntry", row.DocEntry);
                            cmd.Parameters.AddWithValue("@unidades", row.cantidad);
                            cmd.Parameters.AddWithValue("@Id_despacho", Id_despacho);
                            cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            cmd.ExecuteNonQuery();

                        }
                        else
                        {
                            // Aqui hay que validar si ya se entrego algo y que cantidad se entrego.
                            query = @"sp_validar_detalla_de_despacho";
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_detalle", row.id);
                            cmd.Parameters.AddWithValue("@pesoIn", row.Kg_linea);
                            cmd.Parameters.AddWithValue("@unidadesIn", row.cantidad);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@DocEntry", row.DocEntry);
                            cmd.Parameters.AddWithValue("@lineNum", row.id);
                            SqlDataReader dr = cmd.ExecuteReader();
                            bool error = false;
                            string Msj = "";
                            if (dr.Read())
                            {
                                error = dr.GetBoolean(0);
                                Msj = dr.GetString(1);
                            }
                            dr.Close();
                            cn.Close();
                            if (error)
                            {
                                CajaDialogo.Error(Msj);
                            }
                            cn.Open();


                            query = @"sp_update_despacho_detalle";//insert heades    
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@peso", row.Kg_linea);
                            cmd.Parameters.AddWithValue("@lineNum", row.id);
                            cmd.Parameters.AddWithValue("@docentry", row.DocEntry);
                            cmd.Parameters.AddWithValue("@unidades", row.cantidad);
                            cmd.Parameters.AddWithValue("@id_detalle", row.id);
                            cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    cn.Close();

                    frmSeleccionAnden frm = new frmSeleccionAnden(Id_despacho);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CajaDialogo.Information("Transaccion exitosa.");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    
                    break;
                case OpType.Nuevo:


                    if (codigo_selected == "CL00009" || codigo_selected == "CL00002")
                    {
                        if (grd_destino.EditValue == null)
                        {
                            CajaDialogo.Error("Debe seleccionar el destino antes del vehiculo para generar el arribo.");
                            return;
                        }
                    }
                    frm_seleccion_lote_pt frrm = new frm_seleccion_lote_pt(ds_despachos.detalle_despachosComplete);
                    if (frrm.ShowDialog() == DialogResult.OK)
                    {

                        DataTable dt = frrm.dt;


                        //query = @"sp_insert_orden_venta_h_v2";//insert heades
                        query = @"sp_insert_orden_venta_h_v3";                                     
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", UsuarioLogeado.Id);
                        if (txtboleta.Text == "")
                        {
                            cmd.Parameters.AddWithValue("@id_serie", DBNull.Value);
                            SeAsingna = 1;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id_serie", txtboleta.Text);
                            SeAsingna = 0;
                        }
                        cmd.Parameters.AddWithValue("@DocEntry", DocEntry);
                        cmd.Parameters.AddWithValue("@id_destino", grd_destino.EditValue == null ? 0 : grd_destino.EditValue);
                        cmd.Parameters.AddWithValue("@sacos_totales", sacos_totales);
                        cmd.Parameters.AddWithValue("@estiba_id", estiba_id);
                        cmd.Parameters.AddWithValue("@id_presentacion", id_presentacion);
                        cmd.Parameters.AddWithValue("@destino_id", destino_id);

                        Id_despacho = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();
                        cn.Open();

                        foreach (ds_despachos.detalle_despachosCompleteRow row in ds_despachos.detalle_despachosComplete.Rows)
                        {


                            query = @"sp_insert_orden_de_venta_detalle";//insert heades    
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@peso", row.Kg_linea);
                            cmd.Parameters.AddWithValue("@linenum", row.id);
                            cmd.Parameters.AddWithValue("@DocEntry", row.DocEntry);
                            cmd.Parameters.AddWithValue("@unidades", row.cantidad);
                            cmd.Parameters.AddWithValue("@Id_despacho", Id_despacho);
                            cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            int id_detalle = Convert.ToInt32(cmd.ExecuteScalar());
                            foreach (DataRow rowLote in dt.Rows )
                            {
                                if (Convert.ToString(rowLote["itemcode"]) == row.itemcode)
                                {
                                    cmd = new SqlCommand("sp_insert_orden_de_venta_detalle_lote", cn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@lote", rowLote["lote_producto_termiado"]);
                                    cmd.Parameters.AddWithValue("@itemcode", rowLote["itemcode"]);
                                    cmd.Parameters.AddWithValue("@enable", 1);
                                    cmd.Parameters.AddWithValue("@cantidad", rowLote["seleccionada"]);
                                    cmd.Parameters.AddWithValue("@id_detalle", id_detalle);
                                    cmd.Parameters.AddWithValue("@id_pt", 0);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        cn.Close();
                        frmSeleccionAnden frms = new frmSeleccionAnden(Id_despacho);
                        if (frms.ShowDialog() == DialogResult.OK)
                        {


                            frm_plan cp = new frm_plan(Id_despacho, this.UsuarioLogeado);

                            cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(cp);
                            printReport.ShowPreview();
                            CajaDialogo.Information("Transaccion exitosa.");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }


                  
                    break;
                default:
                    break;
            }


        }

        private void grdv_data_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "colcantidad")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (ds_despachos.detalle_despachosCompleteRow)gridView.GetFocusedDataRow();
                    decimal factor = 1;
                    if (row.id_presentacion != 0)
                    {
                        //foreach (dsRecepcionMPx.presentacionesRow pres in dsRecepcionMPx.presentaciones.Rows)
                        //{

                        //    if (row.id_presentacion == pres.id)
                        //    {
                        //        factor = Convert.ToDecimal(pres.factor);
                        //    }
                        //}
                        PresentacionX pres1 = new PresentacionX();
                        if (pres1.RecuperarRegistro(row.id_presentacion))
                        {
                            row.cantidad = Convert.ToInt32(e.Value);
                            row.Kg_linea = pres1.Factor * row.cantidad;
                            row.tm_linea = row.Kg_linea / 1000;
                            
                        }
                        else
                        {
                            row.Kg_linea = Convert.ToDecimal(row.presentacion) * row.cantidad;
                            row.tm_linea = row.Kg_linea / 1000;
                        }
                        row.AcceptChanges();
                        Sumar_totales();

                    }
                }
                if (e.Column.Name == "colpresentacion")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (ds_despachos.detalle_despachosCompleteRow)gridView.GetFocusedDataRow();
                    decimal factor = 1;

                    row.id_presentacion = Convert.ToInt32(e.Value);
                    if (row.id_presentacion != 0)
                    {
                        //foreach (dsRecepcionMPx.presentacionesRow pres in dsRecepcionMPx.presentaciones.Rows)
                        //{

                        //    if (row.id_presentacion == pres.id)
                        //    {
                        //        factor = Convert.ToDecimal(pres.factor);
                        //    }
                        //}
                        //row.peso = factor * row.unidades;
                        //row.cantidad = Convert.ToInt32(e.Value);
                        ////row.unidades = Convert.ToInt32(e.Value);
                        ////decimal prese = dp.ValidateNumberDecimal(row.presentacion);
                        ////row.peso = factor * Convert.ToInt32(e.Value);
                        //row.Kg_linea = factor * row.cantidad;
                        //row.tm_linea = row.Kg_linea / 1000;
                        //row.AcceptChanges();
                        //Sumar_totales();
                        PresentacionX pres1 = new PresentacionX();
                        if (pres1.RecuperarRegistro(row.id_presentacion))
                        {
                            row.cantidad = Convert.ToInt32(e.Value);
                            row.Kg_linea = pres1.Factor * row.cantidad;
                            row.tm_linea = row.Kg_linea / 1000;

                        }
                        else
                        {
                            row.Kg_linea = Convert.ToDecimal(row.presentacion) * row.cantidad;
                            row.tm_linea = row.Kg_linea / 1000;
                        }
                        row.AcceptChanges();
                        Sumar_totales();
                    }
                }


            }
            catch (Exception ex)
            {


            }
        }
    }
}