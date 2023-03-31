using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Tools;
using LOSA.Reproceso;

namespace LOSA.RecepcionMP
{
    public partial class frm_ingresos_lotes : DevExpress.XtraEditors.XtraForm
    {
        int id_ingreso;
        int numero_transaccion;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado; 
        public int Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public int Numero_transaccion { get => numero_transaccion; set => numero_transaccion = value; }
        int Id_traslado;
        string ItemCode;

        public frm_ingresos_lotes(int Pid_ingreso, int Pnumero_transaccion, UserLogin Puser, bool Finalizado, int id_traslado, string pItemCode)
        {
            InitializeComponent();
            

            Numero_transaccion = Pnumero_transaccion;
            Id_ingreso = Pid_ingreso;
            UsuarioLogeado = Puser;
            //btnFinalizar.Visible = !Finalizado && id_traslado !=0 ? true : false;
            ItemCode = pItemCode;
            LoadTarimas();
            Id_traslado = id_traslado;
            if (Id_traslado == 0)
            {
                btnAgregar.Visible = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        

        public void LoadTarimas()
        {
            string SqlCommandSp = @"ps_obtener_tarimas_de_ingresoV2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SqlCommandSp, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_referencia", Numero_transaccion);
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                dsRecepcionMPx.lista_tarimas.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsRecepcionMPx.lista_tarimas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //imprimir
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            bool Error = false;
            string mensaje = " ";

            if (row.id_materia_prima == 1101 || row.id_materia_prima == 1110)
            {
                Reproceso.rptTarimaReproceso boleta = new Reproceso.rptTarimaReproceso(row.id);
                boleta.ShowPrintMarginsWarning = false;
                boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                boleta.ShowPreviewDialog();
            }
            else
            {
                switch (row.id_estado_tarima)
                {
                    case 1://Recepcionado
                        Error = false;
                        break;
                    case 2://En Bodega
                        Error = false;
                        mensaje = "Calidad tiene En Observación ésta tarima.!";
                        break;
                    case 3://Retenido
                        Error = false;
                        break;
                    case 4://Comprometido
                        Error = true;
                        mensaje = "Esta tarima ya esta comprometida!";
                        break;
                    case 5://En Produccion
                        Error = true;
                        mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                        break;
                    case 6://Consumido
                        Error = true;
                        mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                        break;
                    case 7://Retenido por Calidad
                        Error = true;
                        mensaje = "Calidad tiene Retenida ésta tarima.!";
                        break;
                    case 8://Parcialmente Entregado
                        Error = false;
                        mensaje = "Calidad ha Rechazado ésta tarima.!";
                        break;
                    case 9://Rechazado
                        Error = true;
                        mensaje = "Esta tarima fue Rechazada!";
                        break;
                    case 10://Ajuste de Inventario
                        Error = true;
                        mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                        break;
                }

                if (Error)
                {
                    CajaDialogo.Error(mensaje);
                    return;
                }

                rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(row.id);
                boleta.ShowPrintMarginsWarning = false;
                boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                boleta.Print();
            }

            
        }

        private void cmdDuplicar_Click(object sender, EventArgs e)
        {
            //Duplicar la tarima
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            if (row.id_materia_prima == 1101 || row.id_materia_prima == 1110)
            {
                CajaDialogo.Error("No puede duplicar Tarimas de Reproceso, Genere un Ingreso Nuevo!");
                return;
            }

            Transferencia trans = new Transferencia();
            trans.RecuIsTraslado(numero_transaccion);

            int traslado = trans.IsTraslado1;

            Tarima tar1x = new Tarima();
            int idLoteExterno = 0;
            if (tar1x.RecuperarRegistro(row.id))
            {
                idLoteExterno = tar1x.Id_lote_externo;
            }
            
            frmInputBox frm = new frmInputBox(numero_transaccion, row.id, idLoteExterno);
            frm.Text = "Duplicar Tarima";
            frm.lblInstrucciones.Text = "Ingrese la cantidad de tarimas a duplicar:";
            frm.txtValue.Text = "1";
            frm.ValidInteger = true;
            
            decimal acumulado_kg_temp = 0;
            decimal acumulado_ud_temp = 0;
            decimal TotalKg = 0;
            decimal TotalUd = 0;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                int unidades = frm.unidades_x_tarima;
                decimal peso = frm.peso_x_tarima;
                int cant = 0;
                try
                {
                    //Cantidad de Tarimas
                    cant = Convert.ToInt32(frm.txtValue.Text);
                }
                catch { }

                if (cant <= 0)
                {
                    CajaDialogo.Error("No se puede duplicar la Tarima! El valor debe ser mayor a cero.");
                    return;
                }

                

                ArrayList List1 = new ArrayList();

                Tarima tar1 = new Tarima();
                if (tar1.RecuperarRegistro(row.id))
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        //Insert a [LOSA].[dbo].[LOSA_ingreso_mp_lotes]
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "sp_insert_ingresos_lote_v2";
                        cmd.Connection = con;

                        //cmd.Transaction = TransactionIngreso;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", tar1.ItemCode);////
                        cmd.Parameters.AddWithValue("@itemname", tar1.MateriaPrima);//
                        cmd.Parameters.AddWithValue("@cardcode", tar1.IdProveedor);//        //
                        cmd.Parameters.AddWithValue("@cardname", tar1.Proveedor);  //     //
                        cmd.Parameters.AddWithValue("@fecha_ingreso", tar1.FechaIngreso);      // //
                        cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
                        if(!string.IsNullOrEmpty(frm.LoteMP))
                            cmd.Parameters.AddWithValue("@lote_materia_prima", frm.LoteMP);//        //
                        else
                            cmd.Parameters.AddWithValue("@lote_materia_prima", tar1.LoteMP);
                        cmd.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);//     //
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);//   //
                        cmd.Parameters.AddWithValue("@id_boleta", tar1.IdBoleta);//     //
                        cmd.Parameters.AddWithValue("@cant", unidades);//        //
                        cmd.Parameters.AddWithValue("@TotalTarimas", cant);//    //
                        cmd.Parameters.AddWithValue("@pesotaria", peso);//   //
                        cmd.Parameters.AddWithValue("@lote_externo", frm.id_lote_externo);//   //
                        cmd.Parameters.AddWithValue("@idheader", tar1.Id_ingresoH);//    //

                        int IdLoteInserted = Convert.ToInt32(cmd.ExecuteScalar());

                        for (int i = 1; i <= cant; i++)
                        {
                            SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                            cmm.CommandType = CommandType.StoredProcedure;
                            cmm.Parameters.AddWithValue("@id", 1);
                            string barcode = cmm.ExecuteScalar().ToString();

                            string vItemCodeMP = "";
                            MateriaPrima mpx = new MateriaPrima();
                            if (mpx.RecuperarRegistroFromID_RM(row.id_materia_prima))
                            {
                                vItemCodeMP = mpx.CodeMP_SAP;
                            }

                            //SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_lote", con);
                            //cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@itemcode", vItemCodeMP);
                            //cmd.Parameters.AddWithValue("@id_proveedor", tar1.IdProveedor);
                            //cmd.Parameters.AddWithValue("@fecha_ingreso", tar1.FechaIngreso);
                            //cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
                            //cmd.Parameters.AddWithValue("@fecha_vencimiento", tar1.FechaVencimiento);
                            //cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", tar1.FechaProduccionMP);
                            //cmd.Parameters.AddWithValue("@lote_materia_prima", tar1.LoteMP);
                            //cmd.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);
                            //cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            //cmd.Parameters.AddWithValue("@id_boleta", tar1.IdBoleta);
                            //cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                            //cmd.Parameters.AddWithValue("@cant", unidades);
                            //cmd.Parameters.AddWithValue("@peso", peso);
                            //cmd.Parameters.AddWithValue("@idlotes", tar1.Id_ingreso);
                            //int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                            //MateriaPrima MP1 = new MateriaPrima();
                            //MP1.RecuperarRegistroFromCode(tar1.)

                            SqlCommand cmd2 = new SqlCommand("sp_insert_new_tarima_lote", con);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@itemcode", vItemCodeMP);
                            cmd2.Parameters.AddWithValue("@id_proveedor", tar1.IdProveedor);
                            cmd2.Parameters.AddWithValue("@fecha_ingreso", tar1.FechaIngreso);
                            cmd2.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
                            cmd2.Parameters.AddWithValue("@fecha_vencimiento", tar1.FechaVencimiento);
                            cmd2.Parameters.AddWithValue("@fecha_produccion_materia_prima", tar1.FechaProduccionMP);
                            if (!string.IsNullOrEmpty(frm.LoteMP))
                                cmd2.Parameters.AddWithValue("@lote_materia_prima", frm.LoteMP);
                            else
                                cmd2.Parameters.AddWithValue("@lote_materia_prima", tar1.LoteMP);
                            cmd2.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);
                            cmd2.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmd2.Parameters.AddWithValue("@id_boleta", tar1.IdBoleta);
                            cmd2.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmd2.Parameters.AddWithValue("@cant", unidades);
                            cmd2.Parameters.AddWithValue("@peso", peso);
                            cmd2.Parameters.AddWithValue("@idlotes", IdLoteInserted);
                            int vid_tarima = Convert.ToInt32(cmd2.ExecuteScalar());

                            //Se debe validar si procede de un transferencia de externo
                            if (traslado == 1) //Existe una Transferencia Ligada al Ingreso
                            {
                                int id_lote_externo = frm.id_lote_externo;
                                //Vamos a darle Salida Externa Detalle Lote

                                Transferencia trans2 = new Transferencia();
                                trans2.RecuperarRegistro(numero_transaccion);

                                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                                conn.Open();
                                SqlCommand cmd3 = new SqlCommand(@"sp_insert_salida_externo_d_lote_duplicar_tarimaV2", conn);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.AddWithValue("@peso", peso);
                                cmd3.Parameters.AddWithValue("@cant", unidades);
                                cmd3.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                                cmd3.Parameters.AddWithValue("@id_boleta", trans2.Id_serie);
                                cmd3.Parameters.AddWithValue("@DocEntry", trans2.DocEntry1);
                                cmd3.Parameters.AddWithValue("@id_materia_prima", trans2.Id_mp);
                                cmd3.Parameters.AddWithValue("@id_lote_ingreso_externo", frm.id_lote_externo);
                                cmd3.Parameters.AddWithValue("@id_detalle_inserted", trans2.Id_detalle);
                                cmd3.Parameters.AddWithValue("@id_presentacion", trans2.Id_presentacio);
                                cmd3.Parameters.AddWithValue("@bodega_out", trans2.Bodega_out);
                                cmd3.Parameters.AddWithValue("@id_ingreso_ext", trans2.Id_ingreso_lote);
                                cmd3.Parameters.AddWithValue("@id_tarima", vid_tarima);
                                cmd3.ExecuteNonQuery();

                            }
                            //pues nada..


                            List1.Add(vid_tarima);
                            acumulado_kg_temp = peso;
                            acumulado_ud_temp = unidades;
                            
                            //this.Close();
                            //Total de Kg y Ud por registro.

                            TotalKg = acumulado_kg_temp + TotalKg;
                            TotalUd = acumulado_ud_temp + TotalUd;

                        }//end for 

                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    if (List1.Count > 0)
                    {
                        DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                        if (r == DialogResult.Yes)
                        {
                            foreach (int i in List1)
                            {
                                int id_tarimax = i;
                                rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(id_tarimax);
                                boleta.ShowPrintMarginsWarning = false;
                                boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                                boleta.Print();
                            }
                        }
                        LoadTarimas();
                    }
                    List1.Clear();
                }//end if recuperar registro
            }//end dialog 
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            //TimeSpan diasaprox = dp.Now() - row.fecha_ingreso;

            //int Dias = Convert.ToInt32(diasaprox.Days);

            //if (Dias > 3)//Si es mayor que 3, la tarima lleve mas de dos dias en la bodega.
            //{
            //    CajaDialogo.Error("No puede editar tarimas que tengan mas de dos dias de ingreso.");
            //    return;
            //}

            string mensaje = "";
            bool Error = false;
            switch (row.id_estado_tarima)
            {
                case 1://Recepcionado
                    Error = false;
                    break;
                case 2://En Bodega
                    Error = false;
                    //mensaje = "No puede Editar la Tarima por que ya se encuentra en Bodgea!";
                    break;
                case 3://Retenido
                    Error = false;
                    break;
                case 4://Comprometido
                    Error = true;
                    mensaje = "No se puede Editar la tarima por que se encuentra Comprometida";
                    break;
                case 5://En Produccion
                    Error = true;
                    mensaje = "Esta tarima no se puede editar por que ya fue entregada a Produccion";
                    break;
                case 6://Consumido
                    Error = true;
                    mensaje = "Esta tarima no se puede editar por que ya fue entregada y consumida por producción!";
                    break;
                //case 7://
                //    error = true;
                //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                //    break;
                case 8://Parcialmente Entregado
                    Error = true;
                    mensaje = "Esta Tarima ya fue parcialemente entregada no se puede editar!";
                    break;
                case 9://Rechazado
                    Error = true;
                    mensaje = "Esta tarima fue Rechazada!";
                    break;
                case 10://Ajuste de Inventario
                    Error = true;
                    mensaje = "Esta tarima no se puede editar por que ya se le dio salida por ajuste de inventario!";
                    break;
            }

            if (Error)
            {
                CajaDialogo.Error(mensaje);
                return;
            }

            if (ItemCode == "MP00080" || ItemCode == "MP00081")
            {
                switch (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo)
                {
                    case GrupoUser.GrupoUsuario.Logistica:
                        CajaDialogo.Error("No esta autorizado, Solo Calidad puede Editar Tarimas de Reproceso");
                        break;

                    case GrupoUser.GrupoUsuario.Calidad:
                        //Ventana de Editar Tarima
                        frmEditarTarimaReproceso frmRP = new frmEditarTarimaReproceso(row.id, this.UsuarioLogeado);
                        //frmEditTarima frm = new frmEditTarima(row.id, this.UsuarioLogeado);
                        if (frmRP.ShowDialog() == DialogResult.OK)
                        {
                            LoadTarimas();
                        }

                        break;

                    default:
                        break;
                }
            }
            else
            {
                frmEditTarima frm = new frmEditTarima(row.id, this.UsuarioLogeado, Id_traslado);
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Debemos validar si es compra puede agregar mas tarimas
            //if () //Es Compra
            //{
                frmagregarlote frm = new frmagregarlote(Id_ingreso, Numero_transaccion, UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTarimas();
                }
            //}
            //else
            //{
            //    CajaDialogo.Error("No puede agregar otro lote si es traslado de MP");
            //}

            //Si es traslado pues no.

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmverlotes frm = new frmverlotes(id_ingreso , UsuarioLogeado);
            frm.Show();
        }

        private void ValidarConsumoAlimentacion(int pIdTarima)
        {
            try
            {
                string sql = @"SELECT count(*)
                               FROM [LOSA].[dbo].[LOSA_alimentacion_tarimas] A
                                    where enable = 1 and id_tarima =" + pIdTarima;
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int RegistrosConsumo = (int)cmd.ExecuteScalar();

                if (RegistrosConsumo > 0)
                {
                    CajaDialogo.Error("No puede editar esta tarima ya que fue entregada parcial o completamente a produccion!");
                    return;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btneliminarTm_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            

            try
            {
                if (MessageBox.Show("Desea eliminar la tarima?", "Desea eliminar la tarima?",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }

                string sql = "sp_validacion_tarima_alimentacion";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_tarima", row.id);
                int RegistrosConsumo = (int)cmd1.ExecuteScalar();

                //Si RegistrosConsumo es mayor!
                if (RegistrosConsumo > 0)
                {
                    CajaDialogo.Error("No puede ELIMINAR esta tarima ya que fue entregada parcial o completamente a produccion!");
                    return;
                }
                else
                {
                    string query = @"sp_deshabilitar_tm_por_id_v3";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idtm", row.id);
                    cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Information("Se he eliminado correctamente la tarima.");
                    LoadTarimas();
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            } 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                
            }
        }

        private void btnPrintSeleccionados_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;

            int contador_print = 0;
            rptReporteIngresoTarima reportResumen = null;
            LOSA.Reproceso.rptTarimaReproceso reportResumenReproceso = null;

            if (ItemCode == "MP00080" || ItemCode == "MP00081")
            {
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetDataRow(i);

                    bool Error = false;
                    string mensaje = " ";
                    switch (row.id_estado_tarima)
                    {
                        case 1://Recepcionado
                            Error = false;
                            break;
                        case 2://En Bodega
                            Error = false;
                            //mensaje = "Calidad tiene En Observación ésta tarima.!";
                            break;
                        case 3://Retenido
                            Error = false;
                            break;
                        case 4://Comprometido
                            Error = true;
                            mensaje = "Algunas tarima ya esta comprometida!";
                            break;
                        case 5://En Produccion
                            Error = true;
                            mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                            break;
                        case 6://Consumido
                            Error = true;
                            mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                            break;
                        //case 7://
                        //    error = true;
                        //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                        //    break;
                        case 8://Parcialmente Entregado
                            Error = false;
                            //mensaje = "Calidad ha Rechazado ésta tarima.!";
                            break;
                        case 9://Rechazado
                            Error = true;
                            mensaje = "Esta tarima fue Rechazada!";
                            break;
                        case 10://Ajuste de Inventario
                            Error = true;
                            mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                            break;
                    }

                    if (Error)
                    {
                        CajaDialogo.Error(mensaje);
                        return;
                    }

                    if (row.seleccionado == true)
                    {
                        if (row.id > 0)
                        {
                            Tarima tar1 = new Tarima();
                            if (tar1.RecuperarRegistro(row.id))
                            {
                                if (contador_print == 0)
                                {
                                    reportResumenReproceso = new LOSA.Reproceso.rptTarimaReproceso(row.id);
                                    reportResumenReproceso.CreateDocument();
                                    contador_print++;
                                }
                                else
                                {
                                    // Create the second report and generate its document.
                                    LOSA.Reproceso.rptTarimaReproceso report2 = new LOSA.Reproceso.rptTarimaReproceso(row.id);
                                    report2.CreateDocument();

                                    if (reportResumenReproceso != null)
                                    {
                                        // Add all pages of the second report to the end of the first report.
                                        reportResumenReproceso.ModifyDocument(x => { x.AddPages(report2.Pages); });
                                    }
                                }
                            }
                        }//if row.id>0
                    }//if seleccionado is true
                }//For
                if (reportResumenReproceso != null)
                {
                    reportResumenReproceso.ShowPrintMarginsWarning = false;

                    using (ReportPrintTool printTool = new ReportPrintTool(reportResumenReproceso))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
            }
            else
            {
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetDataRow(i);

                    bool Error = false;
                    string mensaje = " ";
                    switch (row.id_estado_tarima)
                    {
                        case 1://Recepcionado
                            Error = false;
                            break;
                        case 2://En Bodega
                            Error = false;
                            //mensaje = "Calidad tiene En Observación ésta tarima.!";
                            break;
                        case 3://Retenido
                            Error = false;
                            break;
                        case 4://Comprometido
                            Error = true;
                            mensaje = "Algunas tarima ya esta comprometida!";
                            break;
                        case 5://En Produccion
                            Error = true;
                            mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                            break;
                        case 6://Consumido
                            Error = true;
                            mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                            break;
                        //case 7://
                        //    error = true;
                        //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                        //    break;
                        case 8://Parcialmente Entregado
                            Error = false;
                            //mensaje = "Calidad ha Rechazado ésta tarima.!";
                            break;
                        case 9://Rechazado
                            Error = true;
                            mensaje = "Esta tarima fue Rechazada!";
                            break;
                        case 10://Ajuste de Inventario
                            Error = true;
                            mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                            break;
                    }

                    if (Error)
                    {
                        CajaDialogo.Error(mensaje);
                        return;
                    }

                    if (row.seleccionado == true)
                    {
                        if (row.id > 0)
                        {
                            Tarima tar1 = new Tarima();
                            if (tar1.RecuperarRegistro(row.id))
                            {
                                if (contador_print == 0)
                                {
                                    reportResumen = new rptReporteIngresoTarima(row.id);
                                    reportResumen.CreateDocument();
                                    contador_print++;
                                }
                                else
                                {
                                    // Create the second report and generate its document.
                                    rptReporteIngresoTarima report2 = new rptReporteIngresoTarima(row.id);
                                    report2.CreateDocument();

                                    if (reportResumen != null)
                                    {
                                        // Add all pages of the second report to the end of the first report.
                                        reportResumen.ModifyDocument(x => { x.AddPages(report2.Pages); });
                                    }
                                }
                            }
                        }//if row.id>0
                    }//if seleccionado is true
                }//For
                if (reportResumen != null)
                {
                    reportResumen.ShowPrintMarginsWarning = false;

                    using (ReportPrintTool printTool = new ReportPrintTool(reportResumen))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
            }

            

        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            int conta = dsRecepcionMPx.lista_tarimas.Count;

            for (int i = 0; i < conta; i++)
            {
                dsRecepcionMPx.lista_tarimasRow row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    if (row != null)
                    {
                        row.seleccionado = checkBoxSelectAll.Checked;
                    }
                }
                else
                {
                    if (row != null)
                    {
                        row.seleccionado = false;
                    }
                }
            }
        }
    }
}