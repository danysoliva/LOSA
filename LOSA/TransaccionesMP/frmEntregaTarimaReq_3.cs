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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using LOSA.TransaccionesMP.Liquidos;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesMP.VentanasMensajes;
using LOSA.MicroIngredientes;

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaTarimaReq_3 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        private int IsMicro = 0;
        UserLogin usuarioLogueado = new UserLogin();
        Tarima tarimaEncontrada;
        Requisicion RequisicionActual = new Requisicion();
        DataTable DT_Tarima;
        public frmEntregaTarimaReq_3(UserLogin Puser)
        {
            InitializeComponent();
            usuarioLogueado = Puser;
            load_tarimas_scan();
            load_bines_disponibles();
            txtRequisicion.Focus();
        }

        private void load_bines_disponibles()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bines_disponibles_liquidos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsTransaccionesMP.bines_disponibles.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.bines_disponibles);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void load_bines_disponiblesByReq(int pIdRequisicion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bines_con_disponible_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisicion", pIdRequisicion);
                dsTransaccionesMP.bines_dispo_prd.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.bines_dispo_prd);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void load_tarimas_scan()
        {
            string query = @"sp_load_tarimas_escaneadas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsTransaccionesMP.viewTarimas.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsTransaccionesMP.viewTarimas);
            cn.Close();

            
        }
        public void load_tarimas_scan_v2()
        {
            string query = @"sp_load_tarimas_escaneadas_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_requisa", RequisicionActual.IdRequisicion);
            dsTransaccionesMP.viewTarimas.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsTransaccionesMP.viewTarimas);
            cn.Close();

        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            //txtCantidadT.Text = txtPeso.Text = "0";
            txtTarima.Text = "";
            gcTarima.DataSource = null;
            lblMensaje.Text = "";
            txtTarima.Focus();
            //pictureBoxIndicadorOk.Visible = false;
            //txtentrega.Text = string.Format("{0:###,##0.00}", 0);
            //txtpesoendregadas.Text = string.Format("{0:###,##0.00}", 0);
            //txtsolicitada.Text = string.Format("{0:###,##0.00}", 0);
            //txtdevueltas.Text = string.Format("{0:###,##0.00}", 0);
            //txtrequeridas.Text = string.Format("{0:###,##0.00}", 0);

            //txtacumualdo.Text = string.Format("{0:###,##0.00}", 0);
        }

        private void txtRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtRequisicion.Text))
                {
                    if (RequisicionActual.RecuperarRegistroFromBarcodeClass(txtRequisicion.Text.Trim()))
                    {
                        if (RequisicionActual.Bit_finalizar)
                        {
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Esta Requisicion está cerrada!");
                            if (frm.ShowDialog() == DialogResult.Cancel)
                            {
                                lblRequisicionEncontrada.BackColor = Color.Transparent;
                                lblRequisicionEncontrada.ResetText();
                                txtRequisicion.Focus();
                            }
                        }
                        else
                        {
                            lblRequisicionEncontrada.Text = RequisicionActual.IdRequisicion1.ToString() + 
                                                            "    Estado: " + RequisicionActual.Descripcion_estado;
                            lblRequisicionEncontrada.BackColor = Color.FromArgb(0, 204, 204);
                            load_tarimas_scan_v2();
                            txtTarima.Focus();
                            cmdLiquidosGranel.Visible = true;
                        }
                    }
                    else
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "No se encontró la requisa");
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {
                            lblRequisicionEncontrada.BackColor = Color.Transparent;
                            lblRequisicionEncontrada.ResetText();
                            txtRequisicion.Focus();
                        }
                    }
                }
                else
                {
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Debe de escanear el codigo de Requisa");
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        txtRequisicion.Focus();
                    }
                }
            }

        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntregarTarima();
                load_tarimas_scan_v2();
            }
        }
        //private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion, string codigoSAP, string MP)
        //{
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        dt.Columns.Add("Detalle", typeof(string));
        //        dt.Columns.Add("Valor", typeof(string));


        //        dt.Rows.Add("TARIMA", idTarima);
        //        dt.Rows.Add("PROVEEDOR", pProveedor);
        //        dt.Rows.Add("LOTE", pLote);
        //        dt.Rows.Add("PRESENTACION", pPpresentacion);

        //        dt.Rows.Add("Codigo", codigoSAP);
        //        dt.Rows.Add("Materia Prima", MP);

        //        return dt;
        //    }
        //    catch (Exception error)
        //    {
        //        CajaDialogo.Information(error.Message);
        //        return dt;
        //    }
        //}

        private DataTable CreateDataTarima(Tarima pTarima)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", pTarima.Id);
                dt.Rows.Add("PROVEEDOR", pTarima.Proveedor);
                dt.Rows.Add("LOTE", pTarima.LoteMP);
                dt.Rows.Add("PRESENTACION", pTarima.Descripcionpresentacion);

                dt.Rows.Add("Codigo", pTarima.ItemCode);
                dt.Rows.Add("Materia Prima", pTarima.MateriaPrima);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }
        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    //string SQL = "exec sp_getTarimas_without_filters_v4 @codigo_barra";
                    //SqlCommand cmd = new SqlCommand();
                    //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    //cmd.Connection = connection;
                    //cmd.CommandText = SQL;

                    //cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);

                    //connection.Open();


                    //SqlDataReader dr = cmd.ExecuteReader();

                    //if (dr.HasRows)
                    //{
                    //    while (dr.Read())
                    //    {
                    //        idTarima = dr.GetInt32(0);

                    //        if (InfoTarima.RecuperarRegistro_v3(idTarima, ""))
                    //        {
                    //            factorPresentacion = InfoTarima.Factor;
                    //            tarimaEncontrada = InfoTarima;

                    //        }
                    //        //gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), 
                    //        //                                       dr.GetString(2), 
                    //        //                                       dr.GetString(1), 
                    //        //                                       dr.GetString(5), 
                    //        //                                       dr.GetString(6), 
                    //        //                                       dr.GetString(11), 
                    //        //                                       dr.GetString(12));
                    //        Tarima vTarima = new Tarima();
                    //        if (vTarima.RecuperarRegistro_v3(idTarima, "")) 
                    //        {
                    //            Tarima = CreateDataTarima(vTarima);
                    //            gcTarima.DataSource = Tarima;
                    //            //Tarima = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6), dr.GetString(11), dr.GetString(12));
                    //            //Tarima = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6), dr.GetString(11), dr.GetString(12));
                    //            Tarima.AcceptChanges();
                    //            //gvTarima.InitNewRow += GridView1_InitNewRow;
                    //            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    CajaDialogo.Error("TARIMA NO ENCONTRADA");
                    //    tarimaEncontrada = null;
                    //    gcTarima.DataSource = null;
                    //    txtTarima.Text = "";
                    //}

                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    string LocalBarcode = txtTarima.Text;


                    //Get id Estado Tarima
                    SqlCommand cmd = new SqlCommand("sp_getTarimas_without_filters_v4", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    cmd.Parameters.AddWithValue("@tipo_query", 1);
                    SqlDataReader dr = cmd.ExecuteReader();
                    int idEstadoTarima = 0;
                    if (dr.Read())
                    {
                        idEstadoTarima = dp.ValidateNumberInt32(dr.GetValue(0));
                    }
                    dr.Close();

                    bool Error = false;
                    string mensaje = " ";
                    switch (idEstadoTarima)
                    {
                        case 0:
                        default:
                            mensaje = "TARIMA NO ENCONTRADA";
                            Error = true;
                            break;
                        case 1://Recepcionado
                            mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                            Error = true;
                            break;
                        case 2://En Bodega
                            break;
                        case 3://Retenido
                            mensaje = "Esta Tarima esta Retenida!";
                            Error = true;
                            break;
                        case 4://Comprometido
                            mensaje = "Esta tarima ya esta comprometida!";
                            Error = true;
                            break;
                        case 5://En Produccion
                            mensaje = "Esta tarima ya fue entrega a Producción";
                            Error = true;
                            break;
                        case 6://Consumido
                            mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
                            Error = true;
                            break;
                        case 8://Parcialmente Entregado
                            break;
                        case 9://Rechazado
                            mensaje = "Esta tarima fue Rechazada!";
                            Error = true;
                            break;
                        case 10://Ajuste de Inventario
                            mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                            Error = true;
                            break;
                    }

                    //if (Error)
                    //{
                    //    tarimaEncontrada = null;
                    //    gcTarima.DataSource = null;
                    //    txtTarima.Text = "";
                    //    return;
                    //}

                    if (Error)
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.FromArgb(255,102,102);
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        tarimaEncontrada = new Tarima();
                        tarimaEncontrada.RecuperarRegistro_v3(0, LocalBarcode);
                        return;
                    }


                    cmd = new SqlCommand("sp_getTarimas_without_filters_v4", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    cmd.Parameters.AddWithValue("@tipo_query", 2);//Get Data de la tarima
                    DT_Tarima = new DataTable();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(DT_Tarima);
                    //Sacamos el id de la tarima
                    foreach (DataRow row in DT_Tarima.Rows)
                    {
                        idTarima = dp.ValidateNumberInt32(row[0]);
                        break;
                    }

                    tarimaEncontrada = new Tarima();
                    tarimaEncontrada.RecuperarRegistro_v3(idTarima, "");

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }
        public void EntregarTarima()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            datosTarimaPorCodBarra(cn);

            //Entrega de tarima
            bool Guardo = false;
            bool error = false;
            bool disponible = false;
            string mensaje = "";
            decimal ExistenciaTarimaKg = 0;
            decimal ExistenciaTarimaUnidades = 0;
            decimal PentregadoKg = 0;
            decimal PsolicitadoKg  = 0;
            decimal factor = 0;
            //tarimaEncontrada = new Tarima();
            //tarimaEncontrada.RecuperarRegistro(0, txtTarima.Text);
            if (tarimaEncontrada != null)
            {
                //Validar si es una requisicion valida esta cargada.
                if (!RequisicionActual.Recuperado)
                {
                    error = true;
                    lblMensaje.Text = "Debe indicar la requisicion que esta entregando!";

                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {

                    }
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }

                //Validar si la tarima escaneada es valida
                if (tarimaEncontrada.Recuperado)
                {
                    //Validar el estado de la tarima basado con el criterio del Depto de Calidad

                    //if (tarimaEncontrada.Id_estadoCalidad > 1)
                    //{
                    //    error = true;
                    //    mensaje = "Calidad tiene retenido esta tarima.!";
                    //    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    //    if (frm.ShowDialog() == DialogResult.Cancel)
                    //    {

                    //    }
                    //    panelNotificacion.BackColor = Color.Red;
                    //    timerLimpiarMensaje.Enabled = true;
                    //    timerLimpiarMensaje.Start();
                    //    return;
                    //}

                    //Validar Estaso de Tarima
                    switch (tarimaEncontrada.Id_estado_tarima)
                    {
                        case 1://Recepcionado
                            error = true;//No tien ubicacion
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
                            mensaje = "Esta tarima ya fue entrega a Producción";
                            break;
                        case 6://Consumido
                            error = true;
                            mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
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
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }
                    //if (tarimaEncontrada.Id_estado_tarima == 1) //1 Recepcionado - 2 En Bodega
                    //{
                    //    error = true;
                    //    mensaje = "La tarima no esta activada!";
                    //    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    //    if (frm.ShowDialog() == DialogResult.Cancel)
                    //    {

                    //    }
                    //    panelNotificacion.BackColor = Color.Red;
                    //    timerLimpiarMensaje.Enabled = true;
                    //    timerLimpiarMensaje.Start();
                    //    return;
                    //}



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

                    if(error)
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }


                    //Si no se ha generado ninguna validacion previa de bloqueo el programa permitira seguir ejecutando.
                    if (!error)
                    {
                        //Validar la disponibilidad de la tarima para poder efectuar la entrega
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

                            SqlCommand cmd = new SqlCommand("[dbo].[sp_verifica_diponibilidad_tarima_entrega_v7]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", tarimaEncontrada.Id);
                            cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {
                                disponible = dr.GetBoolean(0);
                                ExistenciaTarimaUnidades = dr.GetDecimal(2);
                                PentregadoKg = dr.GetDecimal(3);
                                PsolicitadoKg = dr.GetDecimal(4);
                                factor = dr.GetDecimal(5);
                                ExistenciaTarimaKg = dr.GetDecimal(6);
                            }
                            dr.Close();

                            if (ExistenciaTarimaKg <= 0)
                            {
                                mensaje = "Esta tarima ya fue entregada en Alimentación!" +
                                          "\nSi tiene la tarima en fisico, significa que ubico dos rotulos iguales \nen varias tarimas" +
                                          "\nTip: Debe generar un nuevo rotulo para esta Tarima...";
                                frmVentanaMsjTarimaAlimentacion frm =
                                    new frmVentanaMsjTarimaAlimentacion(mensaje, tarimaEncontrada.CodigoBarra);
                                frm.ShowDialog();
                                lblMensaje.Text = mensaje;
                                panelNotificacion.BackColor = Color.Red;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                                return;
                            }

                            con.Close();

                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }

                        ////Validar Lotes proximos a vencer
                        //LoteMP_ProximoVencer LoteMp1 = new LoteMP_ProximoVencer();
                        //if (LoteMp1.RecuperarRegistro(tarimaEncontrada.Id_materiaprima))
                        //{
                        //    if (tarimaEncontrada.LoteMP.Trim() != LoteMp1.LoteMP.Trim())
                        //    {
                        //        mensaje = "Solo se puede entregar el siguiente lote de MP a vencer!" +
                        //                      "\nPor favor consulte la lista de lotes proximos a vencer en la seccion de arriba." +
                        //                      " En caso de requerir entregar un lote distinto al proximo a vencer, debe contactar al departamento de Calidad...";
                        //        //frmVentanaMsjTarimaAlimentacion frm =
                        //        //    new frmVentanaMsjTarimaAlimentacion(mensaje, tarimaEncontrada.CodigoBarra);
                        //        //frm.ShowDialog();
                        //        lblMensaje.Text = mensaje;
                        //        panelNotificacion.BackColor = Color.Red;
                        //        timerLimpiarMensaje.Enabled = true;
                        //        timerLimpiarMensaje.Start();
                        //        return;
                        //    }
                        //}
                        

                        frmResumenToEntregar frms = new frmResumenToEntregar( ExistenciaTarimaKg
                                                                            , ExistenciaTarimaUnidades
                                                                            , PentregadoKg
                                                                            , PsolicitadoKg
                                                                            , DT_Tarima
                                                                            , idTarima
                                                                            , factor);
                        if (frms.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {

                                DataOperations dp = new DataOperations();
                                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                                con.Open();

                                //SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_bodega_mp", con);
                                SqlCommand cmd = new SqlCommand("sp_insert_tarima_requisa_entrega_v9", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@idtarima", tarimaEncontrada.Id);
                                cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                                cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                                cmd.Parameters.AddWithValue("@cantidad", frms.ud_enviar);
                                cmd.Parameters.AddWithValue("@peso", frms.pesoKg);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                    Guardo = dr.GetInt32(4) == 1 ? true : false;
                                }
                                dr.Close();
                                con.Close();

                            }
                            catch (Exception ec)
                            {
                                //CajaDialogo.Error(ec.Message);
                                lblMensaje.Text = ec.Message;
                                panelNotificacion.BackColor = Color.Red;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                            }
                            if (Guardo)
                            {
                                //Mensaje de transaccion exitosa
                                lblMensaje.Text = "Transacción Exitosa!";
                                panelNotificacion.BackColor = Color.MediumSeaGreen;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                            }
                        }
                        else
                        {
                            lblMensaje.Text = mensaje;
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Transaccion Cancelada.");
                            if (frm.ShowDialog() == DialogResult.Cancel)
                            {

                            }
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }




                    }
                    else
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {

                        }
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }
                }
                else
                {
                    error = true;
                    mensaje = "El codigo de barra leido no es correcto!";
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {

                    }
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }


            }
        }

        private void frmEntregaTarimaReq_3_Activated(object sender, EventArgs e)
        {
            txtRequisicion.Focus();
        }

        private void frmEntregaTarimaReq_3_Load(object sender, EventArgs e)
        {

            txtRequisicion.Focus();
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //seleccionar materia prima en planta

            try
            {
                var gridView = (GridView)grd_bines.FocusedView;
                var row = (dsTransaccionesMP.bines_dispo_prdRow)gridView.GetFocusedDataRow();

                if (row.disponibles_prd == 0)
                {
                    CajaDialogo.Error("No hay bines pendientes que consumir en produccion.");
                    return;
                }
                if (row.solicitada == row.entregada)
                {
                    CajaDialogo.Error("Ya se ha entregado toda la materia prima de este producto.");
                    return;
                }


                frmBinesEnPRD frm = new frmBinesEnPRD(RequisicionActual.IdRequisicion, row.id_materia_prima);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    load_tarimas_scan_v2();
                    load_bines_disponiblesByReq(RequisicionActual.IdRequisicion);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdLotesProximosVencerMP_Click(object sender, EventArgs e)
        {
            if(tarimaEncontrada != null)
            {
                if(tarimaEncontrada.Id_materiaprima >0)
                {
                    frmProximosA_vencer frm = new frmProximosA_vencer(tarimaEncontrada.Id_materiaprima);
                    frm.ShowDialog();
                }
            }
            
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                if (RequisicionActual != null)
                {
                    if (RequisicionActual.Recuperado)
                    {
                        load_bines_disponiblesByReq(RequisicionActual.IdRequisicion);
                    }
                }
            }
        }

        private void reposEntregaMicros_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsTransaccionesMP.viewTarimasRow)gridView.GetFocusedDataRow();

            if(dp.ValidateNumberDecimal(row.cant_entregada_micros)>= dp.ValidateNumberDecimal(row.kg))
            {
                string mensaje = "La tarima ya fue entregada en Micro Ingredientes!";
                lblMensaje.Text = mensaje;
                Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                frm.ShowDialog();
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
                return;
            }

            frm_entrega_tarima_micros frmx = new frm_entrega_tarima_micros(row.id_mp, row.id_tarima, row.lote, row.kg,dp.ValidateNumberInt32( row.cantidad));
            //(int pidMP, int pIdTarima, string pLote,bool pMicros )
            bool Guardo = false;
            if (frmx.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Tarima tar1 = new Tarima();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[sp_insert_tarima_micro_ing_out_tarima]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if(tar1.RecuperarRegistro(row.id_tarima))
                        cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
                    else
                        cmd.Parameters.AddWithValue("@numero_transaccion", 0);
                    cmd.Parameters.AddWithValue("@id_materia_prima", row.id_mp);
                    cmd.Parameters.AddWithValue("@lotemp", row.lote);
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@cantidad_unidades", frmx.UdEnviar);
                    cmd.Parameters.AddWithValue("@cantidadkg", frmx.KgEnviar);


                    //cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Guardo = dr.GetInt32(0) == 1 ? true : false;
                    }
                    dr.Close();
                    con.Close();

                }
                catch (Exception ec)
                {
                    //CajaDialogo.Error(ec.Message);
                    lblMensaje.Text = ec.Message;
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                }

            }
            else
            {
                txtTarima.Text = "";
                txtTarima.Focus();
            }
            if (Guardo)
            {
                //Mensaje de transaccion exitosa
                lblMensaje.Text = "Transacción Exitosa!";
                panelNotificacion.BackColor = Color.MediumSeaGreen;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
                load_tarimas_scan();
                //LoadDataMicros();
            }
        }

        private void cmdLiquidosGranel_Click(object sender, EventArgs e)
        {
            if (txtRequisicion.Text != "")
            {
                if (txtRequisicion.Text.Length >= 12) //tamaño de el cod bar requisa
                {
                    string barcode_req = txtRequisicion.Text;
                    frmWizardSelectGranel_Liqu frm = new frmWizardSelectGranel_Liqu(usuarioLogueado, barcode_req);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        load_tarimas_scan();
                        load_bines_disponibles();
                        txtRequisicion.Text = "";
                        txtRequisicion.Focus();
                    }
                }
            }
            else
            {
                CajaDialogo.Error("No se Encontro la Requisa! Escanee Nuevamente la Requisa!");
            }
        }
    }
}