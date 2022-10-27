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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Logistica
{
    public partial class frmSeleccionLoteCierre : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        //DataTable MpList;
        decimal NuevaCantidad = 0;
        int id_count_selected;
        decimal sum = 0;
        int bodega;
        int IdMpSelected = 0;
        public int id_bodegaMP;
        decimal existencia_anterior;
        decimal existencia_nueva;
        decimal diferenciaMP;
        int id_detalle_recuento;
        decimal acumulado;
        bool IsExterno;

        public frmSeleccionLoteCierre(UserLogin puserLogin, DataTable pdata, int pid_detalle_recuento)
        {
            InitializeComponent();
            UsuarioLogeado = puserLogin;
            id_detalle_recuento = pid_detalle_recuento;
            get_bodegas();
            //enumerar_rows();
            grd_mps.DataSource = pdata;

            btnConfirmar.Enabled = false;
            CalculoAcumuladoPendiente();
        }

        private void CalculoAcumuladoPendiente()
        {
            try
            {
                for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
                {
                    DataRow row2 = grdv_mps.GetDataRow(i);

                    decimal existencia_sistema = Convert.ToDecimal(row2["ExistenciaAprox"]);
                    decimal existencia_fisica = Convert.ToDecimal(row2["toma_fisica"]);

                    if (existencia_sistema > existencia_fisica)
                    {
                        acumulado = (existencia_sistema - existencia_fisica);
                        lblAjuste.Text = "Pendiente de Ajustar en Salida";
                    }
                    else
                    {
                        acumulado = (existencia_fisica - existencia_sistema);
                        lblAjuste.Text = "Pendiente de Ajustar en Entrada";
                    }
                }
                txtPendiente.EditValue = acumulado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        public void enumerar_rows()
        {
            //int enumerador = 0;
            //foreach (DataRow row in MpList)
            //{
            //    row["count_id"] = enumerador;
               
            //    enumerador++;
            //}

            //MpList.AcceptChanges();
        }

        public void get_lotes(int id_mp, int id_bodega )
        {

            dsCierreMes.SeleccionLote.Clear();

            if (dsCierreMes.memory_config.Count(x => x.id_lote_count == id_count_selected)==0)
            {

                string query = @"sp_get_existencia_lote_mp";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_bodega", id_bodega);
                    cmd.Parameters.AddWithValue("@id_mp", id_mp);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsCierreMes.SeleccionLote);
                    cn.Close();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                foreach (dsCierreMes.SeleccionLoteRow row in dsCierreMes.SeleccionLote.Rows)
                {
                    foreach (dsCierreMes.memory_configRow rows in dsCierreMes.memory_config.Rows)
                    {
                        if (row.lote== rows.lote)
                        {

                        }
                    }
                }
            }
        }

        public void getlotes_ext(int id_mp, int id_bodega)
        {
            dsCierreMes.SeleccionLote.Clear();

            if (dsCierreMes.memory_config.Count(x => x.id_lote_count == id_count_selected)==0)
            {
                string query = @"sp_load_lotes_bodega_externa_inventario_final";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_bodega",id_bodega);
                    cmd.Parameters.AddWithValue("@id_mp", id_mp);
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsCierreMes.SeleccionLote);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }
        public void get_bodegas()
        {
            string query = @"sp_get_bodegas_id_descripcion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCierreMes.bodegas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCierreMes.bodegas);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void grdv_mps_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var SelectedrOWS = grdv_mps.GetDataRow(e.RowHandle);

                IdMpSelected = Convert.ToInt32(SelectedrOWS["id_mp"]);
                bodega = Convert.ToInt32(SelectedrOWS["id_bodega"]);
                id_count_selected = Convert.ToInt32(SelectedrOWS["count_id"]);
                NuevaCantidad = Convert.ToDecimal(SelectedrOWS["toma_fisica"]);
                sum = 0;
                if (bodega == 17 || bodega == 18 || bodega == 19 || bodega == 20 || bodega == 21 || bodega == 28)
                {
                    getlotes_ext(IdMpSelected, bodega);
                }
                else
                {
                    get_lotes(IdMpSelected, bodega);
                }
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_existencia_lote_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {  
            try
            {
                if (e.Column.FieldName == "seleccionar")
                {
                    var gridView = (GridView)grd_existencia_lote.FocusedView;
                    var row = (dsCierreMes.SeleccionLoteRow)gridView.GetFocusedDataRow();
                    row.seleccionar = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();
                    var list = dsCierreMes.SeleccionLote.AsEnumerable();
                    if (list.Count(p => p.seleccionar == true) > 0)
                    {
                        btnDerecha.Enabled = true;
                    }
                    else
                    {
                        btnDerecha.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            var list = dsCierreMes.SeleccionLote.AsEnumerable();
            if (list.Count(p => p.seleccionar == true && p.utilizado == 0) > 0)
            {
                CajaDialogo.Error("Hay lotes seleccionado sin configurar la cantidad a utilizar.");
                return;
            }

            decimal ValorUtilizado = list.Sum(p => p.utilizado);

            foreach (dsCierreMes.SeleccionLoteRow item in dsCierreMes.SeleccionLote.Rows)
            {
                if (item.seleccionar == true)
                {
                    if (item.utilizado > item.ExistenciaAprox)
                    {
                        CajaDialogo.Error("A un Lote seleccionado se le esta asignando una cantidad mayor a lo que contiene en existencia!");
                        return;
                    }
                }
            }

            var Row = from row in list
                      where row.seleccionar == true
                      select row;

            for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
            {
                DataRow row2 = grdv_mps.GetDataRow(i);

                //id_mp = Convert.ToInt32(row2["id_mp"]);
                id_bodegaMP = Convert.ToInt32(row2["id_bodega"]);
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_tipo_ajuste", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", id_bodegaMP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IsExterno = Convert.ToBoolean(dr.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (IsExterno)
            {
                foreach (var recorrido in Row)
                {
                    DataRow dr = dsCierreMes.Aceptado_lote.NewRow();
                    dr["id_mp"] = recorrido.id_mp;
                    dr["descripcion"] = recorrido.descripcion;
                    dr["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                    dr["lote"] = recorrido.lote;
                    dr["seleccionar"] = false;
                    dr["utilizado"] = recorrido.utilizado;
                    dr["id_lote_alosy"] = recorrido.id_lote_alosy;
                    dr["id_bodega"] = bodega;
                    dr["id_lote_count"] = id_count_selected;
                    dr["OC"] = recorrido.OC;
                    dr["factura"] = recorrido.factura;
                    dr["id_ingreso_lote"] = recorrido.id_ingreso_lote;
                    dr["bodega_in"] = recorrido.bodega_in;
                    dr["id_detalle"] = recorrido.id_detalle;
                    dr["id_presentacion"] = recorrido.id_presentacion;

                    dsCierreMes.Aceptado_lote.Rows.Add(dr);
                    DataRow drw = dsCierreMes.memory_config.NewRow();
                    drw["id_mp"] = recorrido.id_mp;
                    drw["descripcion"] = recorrido.descripcion;
                    drw["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                    drw["lote"] = recorrido.lote;
                    drw["seleccionar"] = false;
                    drw["utilizado"] = recorrido.utilizado;
                    drw["id_lote_alosy"] = recorrido.id_lote_alosy;
                    drw["id_bodega"] = bodega;
                    drw["id_lote_count"] = id_count_selected;
                    drw["OC"] = recorrido.OC;
                    drw["factura"] = recorrido.factura;
                    drw["id_ingreso_lote"] = recorrido.id_ingreso_lote;
                    drw["bodega_in"] = recorrido.bodega_in;
                    drw["id_detalle"] = recorrido.id_detalle;
                    drw["id_presentacion"] = recorrido.id_presentacion;
                    dsCierreMes.memory_config.Rows.Add(drw);
                    btnDerecha.Enabled = false;
                    // +
                    btnConfirmar.Enabled = true;
                }
            }
            else
            {
                foreach (var recorrido in Row)
                {
                    DataRow dr = dsCierreMes.Aceptado_lote.NewRow();
                    dr["id_mp"] = recorrido.id_mp;
                    dr["descripcion"] = recorrido.descripcion;
                    dr["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                    dr["lote"] = recorrido.lote;
                    dr["seleccionar"] = false;
                    dr["utilizado"] = recorrido.utilizado;
                    dr["id_lote_alosy"] = recorrido.id_lote_alosy;
                    dr["id_bodega"] = bodega;
                    dr["id_lote_count"] = id_count_selected;
          
                    dsCierreMes.Aceptado_lote.Rows.Add(dr);
                    DataRow drw = dsCierreMes.memory_config.NewRow();
                    drw["id_mp"] = recorrido.id_mp;
                    drw["descripcion"] = recorrido.descripcion;
                    drw["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                    drw["lote"] = recorrido.lote;
                    drw["seleccionar"] = false;
                    drw["utilizado"] = recorrido.utilizado;
                    drw["id_lote_alosy"] = recorrido.id_lote_alosy;
                    drw["id_bodega"] = bodega;
                    drw["id_lote_count"] = id_count_selected;             
                    dsCierreMes.memory_config.Rows.Add(drw);
                    btnDerecha.Enabled = false;
                    // +
                    btnConfirmar.Enabled = true;
                }
            }
        }

        private void grdv_existencia_lote_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "utilizado")
                {
                    var gridView = (GridView)grd_existencia_lote.FocusedView;
                    var row = (dsCierreMes.SeleccionLoteRow)gridView.GetFocusedDataRow();
                    if ((sum + row.utilizado) > NuevaCantidad)
                    {
                        CajaDialogo.Error("La cantidad configurada en los lotes es mayor a la nueva cantidad.");
                        return;
                    }
                    var list = dsCierreMes.SeleccionLote.AsEnumerable();
                    sum = list.Sum(x => x.utilizado);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void chauto_CheckedChanged(object sender, EventArgs e)
        {
            if (chauto.Checked == true)
            {
                decimal Auxiliar = NuevaCantidad;
                decimal operador = 0;
                foreach (dsCierreMes.SeleccionLoteRow row in dsCierreMes.SeleccionLote.Rows)
                {
                    operador = 0;
                    if (Auxiliar != 0)
                    {
                        if (row.ExistenciaAprox <= Auxiliar)
                        {
                            operador = operador + row.ExistenciaAprox;
                            Auxiliar = Auxiliar - operador;
                        }
                        else
                        {
                            operador = operador + Auxiliar;
                            Auxiliar = 0;
                        }

                        row.utilizado = operador;
                        row.seleccionar = true;
                       
                    }

                }
                dsCierreMes.SeleccionLote.AcceptChanges();
                btnDerecha.Enabled = true;
            }
            else
            {
                foreach (dsCierreMes.SeleccionLoteRow row in dsCierreMes.SeleccionLote.Rows)
                {
                    row.utilizado = 0;
                    row.seleccionar = false;
                }
                dsCierreMes.SeleccionLote.AcceptChanges();
                btnDerecha.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (grdv_efectiva.RowCount == 0)
            {
                CajaDialogo.Error("No hay Materia Prima que aplicar en Kardex!");
                return;
            }

            foreach (dsCierreMes.Aceptado_loteRow row in dsCierreMes.Aceptado_lote.Rows)
            {
                if (row.utilizado == 0)
                {
                    CajaDialogo.Error("No se puede ajustar valor 0 al Lote" + row.lote);
                    return;
                }
            }
            
            
            for (int i = 0; i < grdv_mps.SelectedRowsCount; i++)
            {
                DataRow row2 = grdv_mps.GetDataRow(i);

                //id_mp = Convert.ToInt32(row2["id_mp"]);
                id_bodegaMP = Convert.ToInt32(row2["id_bodega"]);
                existencia_anterior = Convert.ToDecimal(row2["ExistenciaAprox"]);//Existencia en Bodega al momento del Recuento-Contabilizado
                existencia_nueva = Convert.ToDecimal(row2["toma_fisica"]);//Nueva Cantidad - Toma Fisica
                diferenciaMP = Convert.ToDecimal(row2["diferencia"]);//Diferencia = Existencia - Toma Fisica

            }
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_tipo_ajuste", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", id_bodegaMP);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IsExterno = Convert.ToBoolean(dr.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            dsCierreMes.Aceptado_lote.Clear();
            foreach (dsCierreMes.Aceptado_loteRow row in dsCierreMes.Aceptado_lote.Rows)
            {
                try
                {
                    if (IsExterno == true) //Ajuste en Bodega Externa
                    {
                        string query = @"sp_set_insert_ajuste_mp_almacen_externo_for_contabilizacion_inventario";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@peso", row.utilizado);
                        //cmd.Parameters.AddWithValue("@unidades", );
                        cmd.Parameters.AddWithValue("@user_creador", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_mp",IdMpSelected);
                        cmd.Parameters.AddWithValue("@id_lote_externo", row.id_lote_alosy);
                        cmd.Parameters.AddWithValue("@id_detalle", row.id_detalle);
                        cmd.Parameters.AddWithValue("@bodega_in", row.bodega_in);
                        cmd.Parameters.AddWithValue("@id_ingreso_lote", row.id_ingreso_lote);
                        cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                        cmd.Parameters.AddWithValue("@existencia_anterior", existencia_anterior);
                        cmd.Parameters.AddWithValue("@existencia_nueva", existencia_nueva);
                        cmd.Parameters.AddWithValue("@lote", row.lote);
                        cmd.ExecuteNonQuery();
                    }
                    else //Ajuste en Planta
                    {

                        string query = @"sp_insert_kardex_general_inventario_final";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_mp", IdMpSelected);
                        cmd.Parameters.AddWithValue("@id_bodega", id_bodegaMP);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@existencia_anterior", existencia_anterior);
                        cmd.Parameters.AddWithValue("@existencia_nueva", existencia_nueva);
                        cmd.Parameters.AddWithValue("@diferenciaMP", diferenciaMP);
                        cmd.Parameters.AddWithValue("@id_detalle_recuento", id_detalle_recuento);
                        cmd.Parameters.AddWithValue("@lote", row.lote);
                        cmd.Parameters.AddWithValue("@id_lote_alosy", row.id_lote_alosy);
                        cmd.Parameters.AddWithValue("@id_bodega", row.id_bodega);

                        cmd.Parameters.AddWithValue("@utilizado", row.utilizado); //Esto es el valor de lo que se va dar Salida/Entrada en Kardex
                        
                        //AcumuladoCentinela = row.utilizado;
                        //AcumuladoUtilizado = AcumuladoUtilizado + AcumuladoCentinela;
                        //cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            CajaDialogo.Information("Materia Prima ajustada");
            this.DialogResult = DialogResult.OK;
            this.Close();

            //if (AcumuladoUtilizado < 0)
            //{

            //}
            //DialogResult r = CajaDialogo.Pregunta("No se a ajustado al Kardex la Diferencia configurada, desde seguir ajustando?");
            //if (r == System.Windows.Forms.DialogResult.No)
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            var list = dsCierreMes.Aceptado_lote.AsEnumerable();
            if (list.Count(p => p.seleccionar == true) > 0)
            {
                CajaDialogo.Error("Hay lotes seleccionado sin configurar la cantidad a utilizar.");
                return;
            }
            var Row = from row in list
                      where row.seleccionar == true
                      select row;
            foreach (var recorrido in Row)
            {
                DataRow dr = dsCierreMes.Aceptado_lote.NewRow();
                dr["id_mp"] = recorrido.id_mp;
                dr["descripcion"] = recorrido.descripcion;
                dr["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                dr["lote"] = recorrido.lote;
                dr["seleccionar"] = false;
                dr["utilizado"] = recorrido.utilizado;
                dr["id_lote_alosy"] = recorrido.id_lote_alosy;
                dr["id_bodega"] = bodega;
                dr["id_lote_count"] = id_count_selected;

                dsCierreMes.Aceptado_lote.Rows.Add(dr);
                DataRow drw = dsCierreMes.memory_config.NewRow();
                drw["id_mp"] = recorrido.id_mp;
                drw["descripcion"] = recorrido.descripcion;
                drw["ExistenciaAprox"] = recorrido.ExistenciaAprox;
                drw["lote"] = recorrido.lote;
                drw["seleccionar"] = false;
                drw["utilizado"] = recorrido.utilizado;
                drw["id_lote_alosy"] = recorrido.id_lote_alosy;
                drw["id_bodega"] = bodega;
                drw["id_lote_count"] = id_count_selected;
                dsCierreMes.memory_config.Rows.Add(drw);
                //btnDerecha.Enabled = false;
                btnIzquierda.Enabled = true;
                // +

            }
        }

        private void grdv_efectiva_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            try
            {
                if (e.Column.FieldName == "seleccionar")
                {
                    var gridView = (GridView)grd_efectiva.FocusedView;
                    var row = (dsCierreMes.Aceptado_loteRow)grdv_efectiva.GetFocusedDataRow();
                    row.seleccionar = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();
                    var list = dsCierreMes.Aceptado_lote.AsEnumerable();
                    if (list.Count(p => p.seleccionar == true) > 0)
                    {
                        btnDerecha.Enabled = true;
                    }
                    else
                    {
                        btnDerecha.Enabled = false;
                    }
                }
            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
            }
        }

        private void repositorybtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar este detalle?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView1 = (GridView)grd_efectiva.FocusedView;
            var row = (dsCierreMes.Aceptado_loteRow)grdv_efectiva.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                //dsCierreMes.Aceptado_lote.Clear();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}