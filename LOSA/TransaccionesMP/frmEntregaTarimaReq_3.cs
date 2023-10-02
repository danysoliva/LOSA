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
using LOSA.Produccion;
using SAPbobsCOM;

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
            txtTarima.Text = "";

            if (usuarioLogueado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtVentana.Visible = true;

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
            try
            {
                string query = @"sp_load_tarimas_escaneadas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsTransaccionesMP.viewTarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.viewTarimas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }



        }
        public void load_tarimas_scan_v2()
        {
            try
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
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarMensaje()
        {
            
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
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Esta Requisición está cerrada!");
                            if (frm.ShowDialog() == DialogResult.Cancel)
                            {
                                lblRequisicionEncontrada.BackColor = Color.Transparent;
                                lblRequisicionEncontrada.ResetText();
                                txtRequisicion.Focus();
                                txtRequisicion.Text = "";
                            }
                        }
                        else
                        {
                            switch(RequisicionActual.Id_estado)
                            {
                                case 1://Habilitada
                                case 2://Seleccion de Lotes
                                case 3://En Proceso
                                    lblRequisicionEncontrada.Text = RequisicionActual.IdRequisicion1.ToString() +
                                                                "    Estado: " + RequisicionActual.Descripcion_estado;
                                    lblRequisicionEncontrada.BackColor = Color.FromArgb(0, 204, 204);
                                    load_tarimas_scan_v2();
                                    xtraTabControl1.SelectedTabPage = xtraTabPage1;
                                    txtTarima.Focus();
                                    
                                    btnVerDetalleRequisa.Visible = true; 
                                    break;
                                case 4://Cerrada
                                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "La Requisición esta cerrada!");
                                    if (frm.ShowDialog() == DialogResult.Cancel)
                                    {
                                        lblRequisicionEncontrada.BackColor = Color.Transparent;
                                        lblRequisicionEncontrada.ResetText();
                                        txtRequisicion.Focus();
                                        txtRequisicion.Text = "";
                                    }
                                    break;
                                case 5://Nueva
                                    Utileria.frmMensajeCalidad frm2 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
                                                        "La Requisición NO esta habilitada o Disponible! Contacte a un Supervisor de Logística.");
                                    if (frm2.ShowDialog() == DialogResult.Cancel)
                                    {
                                        lblRequisicionEncontrada.BackColor = Color.Transparent;
                                        lblRequisicionEncontrada.ResetText();
                                        txtRequisicion.Focus();
                                        txtRequisicion.Text = "";
                                    }
                                    break;

                                case 6: //Cancelada
                                    Utileria.frmMensajeCalidad frm6 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
                                                        "La Requisicion Esta en Estado: Cancelada! Contacte al Planeador de Produccion o \nContacte a un Supervisor de Logística.");
                                    if (frm6.ShowDialog() == DialogResult.OK)
                                    {
                                        lblRequisicionEncontrada.BackColor = Color.Transparent;
                                        lblRequisicionEncontrada.ResetText();
                                        txtRequisicion.Focus();
                                        txtRequisicion.Text = "";
                                    }
                                    break;

                                case 7: //En Espera
                                    Utileria.frmMensajeCalidad frm7 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
                                                        "La Requisicion esta en Espera! Contacte al Planeador de Produccion o \nContacte a un Supervisor de Logística.");
                                    if (frm7.ShowDialog() == DialogResult.OK)
                                    {
                                        lblRequisicionEncontrada.BackColor = Color.Transparent;
                                        lblRequisicionEncontrada.ResetText();
                                        txtRequisicion.Focus();
                                        txtRequisicion.Text = "";
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "No se encontró la Requisición");
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {
                            lblRequisicionEncontrada.BackColor = Color.Transparent;
                            lblRequisicionEncontrada.ResetText();
                            txtRequisicion.Focus();
                            txtRequisicion.Text = "";
                        }
                    }
                }
                else
                {
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "Debe de escanear el codigo de Requisición");
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
                if (!string.IsNullOrEmpty(txtRequisicion.Text)) 
                {
                    if (RequisicionActual.Bit_finalizar == false)
                    {
                        Tarima tarRemanente = new Tarima();
                        tarRemanente.ValidarTarimaRemanenteMacro(txtTarima.Text.Trim());
                        if (tarRemanente.Tarima_existe)
                        {
                            EntregaRemanenteMacros(txtTarima.Text);
                            load_tarimas_scan_v2();
                            txtTarima.Text = "";
                            return;
                        }
                        EntregarTarima();
                        load_tarimas_scan_v2();
                    }
                }
                else
                {
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "El campo Requisicion esta vacio, Escanee nuevamente");
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        lblRequisicionEncontrada.BackColor = Color.Transparent;
                        lblRequisicionEncontrada.ResetText();
                        txtRequisicion.Text = "";
                        txtTarima.Text = "";
                        txtRequisicion.Focus();
                    }
                }
            }
        }

        private void EntregaRemanenteMacros(string pCodigo_barra)
        {

            if (!string.IsNullOrEmpty(pCodigo_barra))
            {
                decimal EntregadoRequisa = 0;
                decimal SolicitadoRequisa = 0;


                Tarima tarRemanente = new Tarima();
                tarRemanente.RecuperarTarimaRemanenteMacros(pCodigo_barra);

                if (tarRemanente.Id > 0)
                {
                    Requisicion req1 = new Requisicion();
                    req1.RecuperarRegistroFromBarcodeClass(txtRequisicion.Text.Trim());
                    //Vamos a Sacar Cuanto Se necesita segun la Requisa
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_get_solicitado_requisa_for_remanente", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_requisa", req1.IdRequisicion);
                        cmd.Parameters.AddWithValue("@id_mp",tarRemanente.Id_materiaprima);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            SolicitadoRequisa = dr.GetDecimal(0);
                            EntregadoRequisa = dr.GetDecimal(1);
                        }
                        dr.Close();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                    frmResumenToEntregar frmEntrega = new frmResumenToEntregar(tarRemanente.Id, tarRemanente.Peso, tarRemanente.Cantidad, EntregadoRequisa, SolicitadoRequisa);
                    if (frmEntrega.ShowDialog() == DialogResult.OK)
                    {
                        bool Guardar = false;
                        if (frmEntrega.pesoKg > 0)
                        {
                            
                            //Aqui va la MAGIA
                            try
                            {
                                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("sp_insert_tarima_requisa_entrega_remanente_macro", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_tarima",tarRemanente.Id);
                                cmd.Parameters.AddWithValue("@ud_entrega",tarRemanente.Cantidad);
                                cmd.Parameters.AddWithValue("@kg_entrega",frmEntrega.pesoKg);
                                cmd.Parameters.AddWithValue("@id_requisa",req1.IdRequisicion);
                                cmd.Parameters.AddWithValue("@id_usuario",usuarioLogueado.Id);
                                //cmd.Parameters.AddWithValue("",);
                                //cmd.Parameters.AddWithValue("",);
                                //cmd.Parameters.AddWithValue("",);
                                //cmd.Parameters.AddWithValue("",);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                Guardar = true;
                            }
                            catch (Exception ex)
                            {
                                lblMensaje.Text = ex.Message;
                                panelNotificacion.BackColor = Color.Red;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                            }
                        }

                        if (Guardar)
                        {
                            
                            //Mensaje de transaccion exitosa
                            lblMensaje.Text = "Transacción Exitosa!";
                            panelNotificacion.BackColor = Color.MediumSeaGreen;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                        }



                    }
                }

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

                    Tarima tarPT = new Tarima();
                    tarPT.RecuperarTarimaPorCodBarra(txtTarima.Text);

                    if (tarPT.Tipo_tarima == 2) //Tarima de Producto Terminado
                    {
                        switch (idEstadoTarima)
                        {

                            case 1://Virtual
                                Error = true;//No puede ser entregada
                                mensaje = "Esta tarima aun no ha sido ingresada a bodega de PT! Solo se genero el rotulo, es necesario activar y ubicar!.";
                                break;
                            case 2://Recepcion
                                Error = true;
                                mensaje = "Calidad no ha liberado esta tarima.!";
                                break;
                            case 3://Desactivado
                                Error = true;
                                mensaje = "Esta Tarima esta Desactivada!";
                                break;
                            case 4://Entregada
                                Error = true;
                                mensaje = "Esta tarima ya fue entregada!";
                                break;
                            case 5://En bodega
                                Error = false;//esta habilitada
                                              //mensaje = "Esta tarima ya fue entrega a Producción";
                                break;
                            case 6://Reproceso
                                Error = true;
                                mensaje = "Esta Tarima fue creada como Reproceso, no se puede entregar!";
                                break;
                            default:
                                break;
                        }
                    }
                    else //Tarima de Materia Prima
                    {
                        
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
                                mensaje = "Esta Tarima esta Retenida por Calidad!";
                                Error = true;
                                break;
                            case 4://Comprometido
                                mensaje = "Esta Tarima ya esta Comprometida!";
                                Error = true;
                                break;
                            case 5://En Produccion
                                mensaje = "Esta Tarima ya fue Entregada a Producción";
                                Error = true;
                                break;
                            case 6://Consumido
                                mensaje = "Esta Tarima ya fue Entregada y Consumida por producción!";
                                Error = true;
                                break;
                            case 8://Parcialmente Entregado
                                break;
                            case 9://Rechazado
                                mensaje = "Esta Tarima fue Rechazada!";
                                Error = true;
                                break;
                            case 10://Ajuste de Inventario
                                mensaje = "Esta Tarima tuvo salida por Ajuste de Inventario!";
                                Error = true;
                                break;
                        }

                    }

                    

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
            //Entrega de tarima
            bool Guardo = false;
            bool error = false;
            bool disponible = false;
            string mensaje = "";
            decimal ExistenciaTarimaKg = 0;
            decimal ExistenciaTarimaUnidades = 0;
            decimal PentregadoKg = 0;
            decimal PsolicitadoKg = 0;
            decimal factor = 0;

            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            Tarima tarimaPT = new Tarima();
            if (tarimaPT.RecuperarTarimaPorCodBarra(txtTarima.Text))
            {
                if (tarimaPT.Tipo_tarima == 2)
                {
                    datosTarimaPorCodBarra(cn);
                    tarimaEncontrada = tarimaPT;
                    #region Entrega de PT como MP para elaborar producto medicado
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

                    //Validar si el Lote de PT Solicitado en Requisa == Lote PT en Tarima Escaneada
                    //RequisicionActual.RecuperarRegistroFromBarcodeClass();
                    


                    //Validar Estaso de Tarima
                    switch (tarimaEncontrada.id_estado_pt)
                    {
                        case 1://Virtual
                            error = true;//No puede ser entregada
                            mensaje = "Esta tarima aun no ha sido ingresada a bodega de PT! Solo se genero el rotulo, es necesario activar y ubicar!.";
                            break;
                        case 2://Recepcion
                            error = true;
                            mensaje = "Calidad no ha liberado esta tarima.!";
                            break;
                        case 3://Desactivado
                            error = true;
                            mensaje = "Esta Tarima esta Desactivada!";
                            break;
                        case 4://Entregada
                            error = true;
                            mensaje = "Esta tarima ya fue entregada!";
                            break;
                        case 5://En bodega
                            error = false;//esta habilitada
                            //mensaje = "Esta tarima ya fue entrega a Producción";
                            break;
                        case 6://Reproceso
                            error = true;
                            mensaje = "Esta Tarima fue creada como Reproceso, no se puede entregar!";
                            break;
                        default:
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
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }


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


                    frmResumenToEntregar frms = new frmResumenToEntregar(ExistenciaTarimaKg
                                                                        , ExistenciaTarimaUnidades
                                                                        , PentregadoKg
                                                                        , PsolicitadoKg
                                                                        , DT_Tarima
                                                                        , tarimaPT.Id
                                                                        , factor);
                    if (frms.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

                            //SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_bodega_mp", con);
                            SqlCommand cmd = new SqlCommand("sp_insert_tarima_requisa_entrega_v10", con);
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
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }
                    #endregion
                }
                else
                {
                    #region Entrega MP
                    datosTarimaPorCodBarra(cn);

                    //Entrega de tarima
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
                                //Vamos a Validar si queda Remanente de la MP
                                RequisicionesValidaciones req_val = new RequisicionesValidaciones();
                                req_val.ExisteRemanenteMPSacos(tarimaEncontrada.Id_materiaprima);

                                if (req_val.CantidadPendiente > 0) //Existe un Remanente, Deben Entregarlo para continuar.
                                {
                                    mensaje = "Existe MP Pendiente de Entrega: " + tarimaEncontrada.MateriaPrima +
                                              "\nRemanente Pendiente: " + req_val.CantidadPendiente + " Kg." +
                                              "\nEntrege la MP pendiente: Materia Prima en Disponible PRD!";
                                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                                    frm.ShowDialog();

                                    txtTarima.Text = "";
                                    xtraTabControl1.SelectedTabPageIndex = 2;


                                    return;
                                }

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


                                frmResumenToEntregar frms = new frmResumenToEntregar(ExistenciaTarimaKg
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
                                        SqlCommand cmd = new SqlCommand("sp_insert_tarima_requisa_entrega_v10", con);
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
                                    frm.ShowDialog() ;
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
                            frm.ShowDialog();
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }
                    }
                    #endregion
                }

            }
            else
            {
                error = true;
                mensaje = "El codigo de barra leido no es correcto!";
                Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                frm.ShowDialog();
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
                return;
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
            //if (xtraTabControl1.SelectedTabPageIndex == 1)
            //{
            //    if (RequisicionActual != null)
            //    {
            //        if (RequisicionActual.Recuperado)
            //        {
            //            load_bines_disponiblesByReq(RequisicionActual.IdRequisicion);
            //        }
            //    }
            //}

            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 1:

                    if (RequisicionActual != null)
                    {
                        if (RequisicionActual.Recuperado)
                        {
                            load_bines_disponiblesByReq(RequisicionActual.IdRequisicion);
                        }
                    }

                    break;

                case 2:

                    if (RequisicionActual != null)
                    {
                        if (RequisicionActual.Recuperado)
                        {
                            load_mp_sacos_en_prd(RequisicionActual.IdRequisicion);
                        }
                    }

                    break;

                default:
                    break;
            }

        }

        private void load_mp_sacos_en_prd(int pIdRequisicion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_sacos_mp_disponible_produccion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisicion", pIdRequisicion);
                dsTransaccionesMP.mp_sacos_dispo_prd.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.mp_sacos_dispo_prd);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void reposEntregaMicros_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsTransaccionesMP.viewTarimasRow)gridView.GetFocusedDataRow();

            if (row.id_mp == 0)
            {
                string mensaje = "Esto no es un Micro Ingrediente, es Producto Terminado para Medicado!";
                lblMensaje.Text = mensaje;
                Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                frm.ShowDialog();
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
                return;
            }
            else
            {
                //Vamos a Validar si la MP esta considerada como Micros
                MateriaPrima mp = new MateriaPrima();
                mp.ValidarMPIsMicroIngrediente(row.id_mp);

                if (mp.Permitir)
                {

                    //TarimaMicroingrediente Tarx1 = new TarimaMicroingrediente();
                    //if (dp.ValidateNumberDecimal(row.cant_entregada_micros) >= dp.ValidateNumberDecimal(row.kg))
                    //decimal Kg_Entregados_Micros = Tarx1.GetKgEntregadosA_Micros_from_tarima_ALOSY(row.id_tarima, row.id_detalle_requisicion);
                    //if (Kg_Entregados_Micros >= dp.ValidateNumberDecimal(row.kg))
                    if (row.entregado_micros == true)
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

                    frm_entrega_tarima_micros frmx = new frm_entrega_tarima_micros(row.id_mp, row.id_tarima, row.lote, row.kg, dp.ValidateNumberInt32(row.cantidad));
                    //(int pidMP, int pIdTarima, string pLote,bool pMicros )
                    bool Guardo = false;
                    if (frmx.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Tarima tar1 = new Tarima();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("[sp_insert_tarima_micro_ing_out_tarima_v3]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            if (tar1.RecuperarRegistro(row.id_tarima))
                                cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
                            else
                                cmd.Parameters.AddWithValue("@numero_transaccion", 0);
                            cmd.Parameters.AddWithValue("@id_materia_prima", row.id_mp);
                            cmd.Parameters.AddWithValue("@lotemp", row.lote);
                            cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                            cmd.Parameters.AddWithValue("@cantidad_unidades", frmx.UdEnviar);
                            cmd.Parameters.AddWithValue("@cantidadkg", frmx.KgEnviar);
                            cmd.Parameters.AddWithValue("@id_req_detalle", row.id_detalle_requisicion);//Id requisicion detalle
                            cmd.Parameters.AddWithValue("@id_alimentacion", row.id_alimentacion);
                            cmd.Parameters.AddWithValue("@id_mp_entrega", row.id);
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
                        load_tarimas_scan_v2();
                        //LoadDataMicros();
                    }
                }
                else
                {
                    lblMensaje.Text = "La MP: " + row.mp + " no es un Micro Ingrediente!";
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                }
            }

            

            
        }



        private void btnEntregaBinesRequissa_Click(object sender, EventArgs e)
        {
            //if (txtRequisicion.Text != "")
            //{
            //    if (txtRequisicion.Text.Length >= 12)
            //    {
            //        string barcode_req = txtRequisicion.Text.Trim();
            //        frmWizardEntregaBinesRequisa frm = new frmWizardEntregaBinesRequisa(usuarioLogueado, barcode_req);
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            load_tarimas_scan();
            //            load_bines_disponibles();
            //            txtRequisicion.Text = "";
            //            txtRequisicion.Focus();
            //        }
            //    }
            //}
            //else
            //{
            //    CajaDialogo.Error("No se Encontro la Requisa! Escanee Nuevamente la Requisa!");
            //}
        }

        private void btnVerDetalleRequisa_Click(object sender, EventArgs e)
        {
            if (txtRequisicion.Text != "")
            {
                if (txtRequisicion.Text.Length >= 12) //tamaño de el cod bar requisa
                {
                    string barcode_req = txtRequisicion.Text;
                    Requisicion req1 = new Requisicion();
                    req1.RecuperarRegistroFromBarcodeClass(barcode_req);
                    frmviewrequisa_detalle frm = new frmviewrequisa_detalle(req1.IdRequisicion, usuarioLogueado, req1.Lote);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (txtRequisicion.Text == "")
                        {
                            load_tarimas_scan();
                        }
                        else
                        {
                            load_tarimas_scan_v2();
                        }
                        
                        load_bines_disponibles();
                        txtTarima.Focus();
                    }
                }
            }
            else
            {
                CajaDialogo.Error("No se Encontro la Requisa! Escanee Nuevamente la Requisa!");
            }
        }

        private void cmdEntregaMPSacosPrd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grdmp_sacos_prd.FocusedView;
                var row = (dsTransaccionesMP.mp_sacos_dispo_prdRow)gridView.GetFocusedDataRow();

                
                if (row.solicitada <= row.entregada)
                {
                    CajaDialogo.Error("Ya se ha entregado toda la materia prima de este producto.");
                    return;
                }
                if (row.disponibles_prd == 0)
                {
                    CajaDialogo.Error("No hay MP pendientes que consumir en produccion.");
                    return;
                }


                frmBinesEnPRD frm = new frmBinesEnPRD(RequisicionActual.IdRequisicion, row.id_materia_prima);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    load_tarimas_scan_v2();
                    load_mp_sacos_en_prd(RequisicionActual.IdRequisicion);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdLiquidosGranel_Click(object sender, EventArgs e)
        {
            //if (txtRequisicion.Text != "")
            //{
            //    if (txtRequisicion.Text.Length >= 12)
            //    {
            //        string barcode_req = txtRequisicion.Text.Trim();
            //        frmWizardSelectGranel_Liqu frm = new frmWizardSelectGranel_Liqu(usuarioLogueado, barcode_req);
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            load_tarimas_scan();
            //            txtRequisicion.Text = "";
            //            txtRequisicion.Focus();
            //        }
            //    }
            //}
            //else
            //{
            //    CajaDialogo.Error("No se Encontro la Requisa! Escanee Nuevamente la Requisa!");
            //}
        }
    }
}