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

namespace LOSA.Despachos
{
    public partial class frm_generar_despacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int DocEntry;
        private int LineNum;
        private int Id_despacho;
        UserLogin UsuarioLogeado; 
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

        }

        public frm_generar_despacho(int id_Despacho)
        {
            InitializeComponent();
            Operacion = OpType.Update;
            this.Id_despacho = id_Despacho; 
            LoadPresentaciones();
            load_informacion();

            btn_guardar.Text = "Guardar Cambios";
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
                        }
                        dr.Close();
                        cn.Close();

                        cn.Open();

                        query = @"sp_load_info_despacho";
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
                ds_despachos.detalle_despachos.Clear();
                da.Fill(ds_despachos.detalle_despachos);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_pickboleta frm = new frm_pickboleta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtboleta.Text = Convert.ToString(frm.id_serie);
                txtvehiculo.Text = frm.Vehiculo;
                txtconductor.Text = frm.conductor;
                
            }
        }
         
        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.detalle_despachosRow)gridView.GetFocusedDataRow();
                if (row.id == 0)
                {
                    grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                }
                else
                {

                }
                ds_despachos.detalle_despachos.AcceptChanges();

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
                    foreach (ds_despachos.detalle_despachosRow row in ds_despachos.detalle_despachos.Rows)
                    {
                        if (row.docentry == frm.DocEntry && row.linenum == frm.LineNUm)
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
                    da.Fill(ds_despachos.detalle_despachos);
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
            foreach (ds_despachos.detalle_despachosRow row in ds_despachos.detalle_despachos.Rows)
            {
                totalKg = totalKg + row.peso;
                totalUd = totalUd + row.unidades;
            }

            txtunidades.Text = totalUd.ToString();
            txtKg.Text = totalKg.ToString();

        }

        private void grdv_data_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "colunidades")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (ds_despachos.detalle_despachosRow)gridView.GetFocusedDataRow();
                    decimal factor = 1;
                    if (row.id_presentacion != 0)
                    {
                        foreach (dsRecepcionMPx.presentacionesRow pres in dsRecepcionMPx.presentaciones.Rows)
                        {

                            if (row.id_presentacion == pres.id)
                            {
                                factor = Convert.ToDecimal(pres.factor);
                            }
                        }
                        row.unidades = Convert.ToInt32(e.Value);
                        row.peso = factor * Convert.ToInt32(e.Value);
                        row.AcceptChanges();
                        Sumar_totales();

                    }
                }
                if (e.Column.Name == "colid_presentacion")
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (ds_despachos.detalle_despachosRow)gridView.GetFocusedDataRow();
                    decimal factor = 1;

                    row.id_presentacion = Convert.ToInt32(e.Value);
                    if (row.id_presentacion != 0)
                    {
                        foreach (dsRecepcionMPx.presentacionesRow pres in dsRecepcionMPx.presentaciones.Rows)
                        {

                            if (row.id_presentacion == pres.id)
                            {
                                factor = Convert.ToDecimal(pres.factor);
                            }
                        }  
                        row.peso = factor * row.unidades;
                        row.AcceptChanges();
                        Sumar_totales();
                    }
                }
                                   

            }
            catch (Exception ex)
            {

                
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ds_despachos.detalle_despachos.AcceptChanges();
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

            foreach (ds_despachos.detalle_despachosRow row in ds_despachos.detalle_despachos.Rows)
            {
                if (row.id_presentacion == 0)
                {
                    count = count + 1;
                    producto = row.dscripcion;
                }
            }

            if (count > 0)
            {
                CajaDialogo.Error("No se ha configurado correctamente el producto: " + producto + " Falta presentacion de producto");
                return;
            }

            if (ds_despachos.detalle_despachos.Count == 0)
            {
                CajaDialogo.Error("Debo de colocar por lo menos un Producto Terminado en la orden de carga.");
                return;
            }
            string query = @"";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd;
            switch (Operacion)
            {    
                case OpType.Update:
                    query = @"sp_update_despacho_header";//insert heades     
                    cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_despacho", Id_despacho);
                    if (txtboleta.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@boleta", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@boleta", txtboleta.Text);
                    }
                    cmd.ExecuteNonQuery();
                    foreach (ds_despachos.detalle_despachosRow row in ds_despachos.detalle_despachos.Rows)
                    {
                        if (row.id == 0) //nuevo
                        {
                            query = @"sp_insert_orden_de_venta_detalle";//insert heades    
                            cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@peso", row.peso);
                            cmd.Parameters.AddWithValue("@linenum", row.linenum);
                            cmd.Parameters.AddWithValue("@DocEntry", row.docentry);
                            cmd.Parameters.AddWithValue("@unidades", row.unidades);
                            cmd.Parameters.AddWithValue("@Id_despacho", Id_despacho);
                            cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            cmd.ExecuteNonQuery();

                        }
                        else
                        {
                            // Aqui hay que validar si ya se entrego algo y que cantidad se entrego.
                            query = @"sp_validar_detalla_de_despacho";
                            cmd = new SqlCommand(query,cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_detalle", row.id);
                            cmd.Parameters.AddWithValue("@pesoIn", row.peso);
                            cmd.Parameters.AddWithValue("@unidadesIn", row.unidades);
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@DocEntry", row.docentry);
                            cmd.Parameters.AddWithValue("@lineNum", row.linenum);
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
                            cmd.Parameters.AddWithValue("@peso", row.peso);
                            cmd.Parameters.AddWithValue("@lineNum", row.linenum);
                            cmd.Parameters.AddWithValue("@docentry", row.docentry);
                            cmd.Parameters.AddWithValue("@unidades", row.unidades);
                            cmd.Parameters.AddWithValue("@id_detalle", row.id);
                            cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    cn.Close();
                    CajaDialogo.Information("Transaccion exitosa.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case OpType.Nuevo:
                   
                    query = @"sp_insert_orden_venta_h";//insert heades     
                    cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UsuarioLogeado.Id);
                    if (txtboleta.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@id_serie", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id_serie", txtboleta.Text);
                    }
                    cmd.Parameters.AddWithValue("@DocEntry", DocEntry);

                    Id_despacho = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.Close();
                    cn.Open();

                    foreach (ds_despachos.detalle_despachosRow row in ds_despachos.detalle_despachos.Rows)
                    {
                        query = @"sp_insert_orden_de_venta_detalle";//insert heades    
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                        cmd.Parameters.AddWithValue("@peso", row.peso);
                        cmd.Parameters.AddWithValue("@linenum", row.linenum);
                        cmd.Parameters.AddWithValue("@DocEntry", row.docentry);
                        cmd.Parameters.AddWithValue("@unidades", row.unidades);
                        cmd.Parameters.AddWithValue("@Id_despacho", Id_despacho);
                        cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    CajaDialogo.Information("Transaccion exitosa.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                default:
                    break;
            }


        }
    }
}