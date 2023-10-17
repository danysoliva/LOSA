using ACS.Classes;
using DevExpress.XtraEditors;
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
using LOSA.Utileria;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frmDevolucionMicros : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private int id_tarima_origen, lote_pt;
        private int unidades_maximas = 0;
        private decimal factorPresentacion;
        UserLogin usuarioLogueado = new UserLogin();

        public frmDevolucionMicros(UserLogin pUserLogin)
        {
            InitializeComponent();
            usuarioLogueado = pUserLogin;
            beTarima.Focus();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void beTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                //Validaciones 
                string mensaje = "";
                //Existencia en Tarima de Micros
                TarimaMicroingrediente TmMicro = new TarimaMicroingrediente();
                if (TmMicro.RecuperarRegistroTarimaMicros(0, beTarima.Text.Trim()))
                {
                    TarimaMicroingrediente GetExtisenciaMicro = new TarimaMicroingrediente();
                    decimal existencia_kg = GetExtisenciaMicro.GetKgExistenciaEnMicros(Convert.ToInt32(TmMicro.Id));

                    if (existencia_kg < TmMicro.Factor)
                    {
                        mensaje = "La Tarima de Micro Ingredientes no contiene una Unidad Completa en KG\nNo se puede realizar una devolucion con esta Tarima.\nExistencia en Tarima " + existencia_kg + " Kg.\n Presentacion en Tarima: " + TmMicro.Factor + " Kg.";
                        frmMensajeCalidad frmMensaje = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
                        frmMensaje.ShowDialog();
                        beTarima.Clear();
                        beTarima.Focus();
                        id_tarima_origen = 0;
                        idTarima = 0;
                        return;
                    }
                    id_tarima_origen = TmMicro.IdTarimaOrigen;

                    Tarima tarimaEncontrada = new Tarima();
                    tarimaEncontrada.RecuperarRegistro_v3(id_tarima_origen, "");

                    bool error = false;

                    //Validar Estaso de Tarima
                    switch (tarimaEncontrada.Id_estado_tarima)
                    {
                        case 1://Recepcionado
                            error = true;//No tiene ubicacion
                            mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                            break;
                        case 2://En Bodega
                            error = false;
                            //mensaje = "Calidad tiene En Observación ésta tarima.!";
                            break;
                        case 3://Retenido
                            error = true;
                            mensaje = "Esta Tarima esta Retenida!";
                            break;
                        case 4://Comprometido
                            error = true;
                            mensaje = "Esta tarima ya esta comprometida!";
                            break;
                        case 5://En Produccion
                            error = true;//esta habilitada
                            mensaje = "Esta tarima ya fue entregada a Producción en su Totalidad";
                            break;
                        case 6://Consumido
                            error = true;
                            mensaje = "Esta Tarima ya fue entregada y consumida por producción en su Totalidad!";
                            break;
                        //case 7://
                        //    error = true;
                        //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                        //    break;
                        case 8://Parcialmente Entregado
                            error = false;
                            //mensaje = "Calidad ha Rechazado ésta tarima.!";
                            break;
                        case 9://Rechazado
                            error = true;
                            mensaje = "Esta tarima fue Rechazada!";
                            break;
                        case 10://Ajuste de Inventario
                            error = true;
                            mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                            break;
                    }

                    if (error)
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        beTarima.Clear();
                        beTarima.Focus();
                        id_tarima_origen = 0;
                        idTarima = 0;
                        return;
                    }

                    //Validacion Estados de Calidad
                    switch (tarimaEncontrada.Id_estadoCalidad)
                    {
                        case 1://Habilitado
                            error = false;//esta habilitada
                            break;
                        case 2://En Observacion
                            error = true;
                            mensaje = "Calidad tiene En Observación ésta tarima.!";
                            break;
                        case 3://Retenido
                            error = true;
                            mensaje = "Calidad tiene Retenida ésta tarima.!";
                            break;
                        case 4://Rechazado
                            error = true;
                            mensaje = "Calidad ha Rechazado ésta tarima.!";
                            break;
                        default:
                            error = true;//esta habilitada
                            mensaje = "Esta tarima un no ha sido inspeccionada por Calidad!";
                            break;
                    }

                    if (error)
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        beTarima.Clear();
                        beTarima.Focus();
                        id_tarima_origen = 0;
                        idTarima = 0;
                        return;
                    }

                    //Existencia en Tarima Origen
                    //Para Realizar la Devolucion debe Haber aunque sea 1 Unidad en Existencia.
                    Tarima tar1 = new Tarima();
                    tar1.RecuperarExistenciaTarima(id_tarima_origen);

                    if (tar1.Ud_existencia <= 0)
                    {
                        mensaje = "La Tarima: " + tarimaEncontrada.CodigoBarra + " en BG001 se Entrego en su Totalidad no se puede Devolver.";
                        frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        beTarima.Clear();
                        beTarima.Focus();
                        id_tarima_origen = 0;
                        idTarima = 0;
                        return;
                    }

                    datosTarimaPorCodBarra(cn);
                }
                else
                {
                    mensaje = "Solo se pueden escanear Tarimas de Micro Ingredientes\nEje. MI000000021";
                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
                    frm.ShowDialog();
                    beTarima.Clear();
                    beTarima.Focus();
                }
               

            }
        }

        private void datosTarimaPorCodBarra(SqlConnection cn)
        {
            TarimaMicroingrediente InfoTarima = new TarimaMicroingrediente();

            try
            {
                string SQL = "sp_getTarimas_without_filters_micro_ingredientes";
                SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                connection.Open();
                SqlCommand cmd = new SqlCommand(SQL, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idTarima = dr.GetInt32(0);

                        if (InfoTarima.RecuperarRegistroTarimaMicros(idTarima,""))
                        {
                            factorPresentacion = InfoTarima.Factor;
                            id_tarima_origen = InfoTarima.IdTarimaOrigen;
                            lote_pt = InfoTarima.Lotept;
                            unidades_maximas = dr.GetInt32(7);
                        }

                        gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetString(4), dr.GetString(5), dr.GetDecimal(6), dr.GetInt32(7));
                        gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    }
                }
                else
                {
                    CajaDialogo.Error("TARIMA NO ENCONTRADA");
                    gcTarima.DataSource = null;
                    beTarima.Text = "";
                    id_tarima_origen = 0;
                    idTarima = 0;
                }

                cn.Close();
                GET_InventoryEntregado();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        public void GET_InventoryEntregado()
        {
            try
            {
                string Query = @"sp_set_cantidad_devolucion_inventario_micros";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", id_tarima_origen);
                cmd.Parameters.AddWithValue("@lote_pt", lote_pt);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsDevoluciones1.mp_micros.Clear();
                da.Fill(dsDevoluciones1.mp_micros);

                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private DataTable CreateDataTarima(int idTarima, string pmp, string pfecha_creado, int pnum_tran, string plote, string ppresentacion, decimal pexistencia, int punidades)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                //dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("MATERIA PRIMA", pmp);
                dt.Rows.Add("NUM. TRANSACCION", pnum_tran);
                dt.Rows.Add("LOTE", plote);
                dt.Rows.Add("PRESENTACION", ppresentacion);
                dt.Rows.Add("EXISTENCIA KG", pexistencia );
                dt.Rows.Add("EXISTENCIA UNIDADES", punidades);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }

        private void reposCantidadMaxima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd_requisa.FocusedView;
            var row = (dsDevoluciones.mp_microsRow)gridview.GetFocusedDataRow();

            

            TarimaMicroingrediente tarmic = new TarimaMicroingrediente();
            tarmic.RecuperarRegistroTarimaMicros(idTarima,"");
            if (row.cantidad_unidades > 0)
            {
                row.unidades_devolucion = unidades_maximas;
                row.kg_devolucion = tarmic.Factor * unidades_maximas;
                row.unidades_devolucion = unidades_maximas;
            }

        }

        private void reposUP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd_requisa.FocusedView;
            var row = (dsDevoluciones.mp_microsRow)gridview.GetFocusedDataRow();

            if (row.unidades_devolucion == unidades_maximas)
            {
                //No puede sumar mas
            }
            else
            {
                if (row.cantidad_unidades <= row.unidades_devolucion)
                {

                }
                else
                {
                    row.unidades_devolucion = row.unidades_devolucion + 1;

                    row.kg_devolucion = row.unidades_devolucion * factorPresentacion;
                }
                
            }
        }

        private void reposDown_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grd_requisa.FocusedView;
            var row = (dsDevoluciones.mp_microsRow)gridview.GetFocusedDataRow();

            if (row.unidades_devolucion == 0)
            {
                //No puede sumar mas
            }
            else
            {
                row.unidades_devolucion = row.unidades_devolucion - 1;

                row.kg_devolucion = row.unidades_devolucion * factorPresentacion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(beTarima.Text.Trim()))
            {
                string mensaje = "No se a Escaneado una Tarima de Micro Ingredientes!";
                frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
                frm.ShowDialog();

                beTarima.Focus();
                gcTarima.DataSource = null;
                dsDevoluciones1.mp_micros.Clear();
            }

            foreach (dsDevoluciones.mp_microsRow item in dsDevoluciones1.mp_micros.Rows)
            {
                if (item.unidades_devolucion <= 0)
                {
                    string mensaje = "Debe seleccionar 1 unidad por lo menos!";
                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
                    frm.ShowDialog();

                    beTarima.Text = "";
                    beTarima.Focus();
                    gcTarima.DataSource = null;
                    dsDevoluciones1.mp_micros.Clear();
                    return;
                }
            }

            try
            {
                foreach (dsDevoluciones.mp_microsRow item in dsDevoluciones1.mp_micros)
                {
                    if (item.unidades_devolucion > 0)
                    {
                        //Vamos a validar el mensaje antes para evitarnos erroes luego del guardado

                        Tarima tm = new Tarima();
                        tm.RecuperarRegistro(id_tarima_origen, "");

                        Ubicacion_Tarima ubi = new Ubicacion_Tarima();
                        ubi.RecuperarRegistro_2(0, tm.CodigoBarra);

                        decimal diferencia_peso_kg = 0;

                        diferencia_peso_kg = item.cantidad_entregada - item.kg_devolucion;

                        string sql = @"sp_micros_devolucion_por_tarima";
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idTarimaMicro", idTarima);
                        cmd.Parameters.AddWithValue("@id_tarima_origen", id_tarima_origen);
                        cmd.Parameters.AddWithValue("@id_requ_h", item.id_requisa_header);
                        cmd.Parameters.AddWithValue("@kg_devolucion", item.kg_devolucion);
                        cmd.Parameters.AddWithValue("@ud_devolucion", item.unidades_devolucion);
                        cmd.Parameters.AddWithValue("@diferencia_peso_kg", diferencia_peso_kg);
                        cmd.Parameters.AddWithValue("@user_id", usuarioLogueado.Id);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        string mensaje = "Devolucion Exitosa!\nDevolver la MP a la Tarima: " + tm.CodigoBarra + "\nUbicada en BG001 - Rack: " + ubi.Rack;

                        frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.info, mensaje);
                        frm.ShowDialog();
                        beTarima.Text = "";
                        gcTarima.DataSource = null;
                        //dsDevoluciones1.mp_micros.Clear();
                        beTarima.Focus();

                    }
                    

                }
                dsDevoluciones1.mp_micros.Clear();
            }
            catch (Exception ex)
            {
                beTarima.Text = "";
                beTarima.Focus();
                gcTarima.DataSource = null;
                dsDevoluciones1.mp_micros.Clear();
                CajaDialogo.Error(ex.Message);
            }

        }

        private void beTarima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gcTarima.DataSource = null;
            beTarima.Text = "";
            id_tarima_origen = 0;
            dsDevoluciones1.mp_micros.Clear();
        }
    }
}