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
using LOSA.AlmacenesExterno;
using Core.Clases.Herramientas;
using System.Collections;
using DevExpress.XtraReports.UI;
using LOSA.Reportes;

namespace LOSA.RecepcionMP
{
    public partial class frmTarima_V2 : DevExpress.XtraEditors.XtraForm
    {
        public bool Istraslado;
        UserLogin UsuarioLogeado;

        /// <summary>
        ///Id Ingreso externo
        /// </summary>
        public int id_Traslado_a_Ingresar;

        int IdSerie;
        int NumBoleta;
        int IdMP;
        int idUbicacionNueva;
        int DEFAULT_VALUE = 0;
        string ItemCode;
        decimal factor;

        /// <summary>
        /// Id Salida Externo H
        /// </summary>
        int id_transferencia;

        int DocEntry;
        int id_mp;

        decimal peso_boleta;
        public int Id_ingreso;
        public string Dscripcion;
        public string pv;
        public string cardcode;
        public Decimal LimiteKgloteportraslado;

        /// <summary>
        /// [LOSA_ingreso_mp_h].id
        /// </summary>
        int IdHeaderInserted;

        /// <summary>
        /// ID Lote Alosy [LOSA_ingreso_mp_lotes].id
        /// </summary>
        int IdLoteInserted ;

        int idLoteExterno;
        string Bodega_Externa;
        int id_detalle_inserted;


        DataOperations dp = new DataOperations();
        public frmTarima_V2(bool PIstraslado,UserLogin Puser, int Pid_traslado)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Istraslado = PIstraslado;
            IdLoteInserted = DEFAULT_VALUE;
            idLoteExterno = DEFAULT_VALUE;
            id_Traslado_a_Ingresar = Pid_traslado;
            if (Istraslado)
            {
                btnSeleccionarLote.Visible = true;
                btnSelecciondeMp.Visible = false;
                btnSelccionarProveedor.Visible = false;
                txtLote.Enabled = false;
                txtid_lote.Enabled = false;
                Transferencia trans = new Transferencia();
                trans.RecuperarHeaderTransf_for_id_transfer(id_transferencia);
                Bodega_Externa = trans.Bodega_in;
            }
            else
            {
                btnSeleccionarLote.Visible = false;
            }
            LoadPresentaciones();
            LoadNumeroTransaccion();
        }
        public frmTarima_V2(bool PIstraslado, UserLogin Puser, int Pid_traslado, int Pid_transferencia, int pDocEntry, int pId_mp)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            Istraslado = PIstraslado;
            IdLoteInserted = DEFAULT_VALUE;
            idLoteExterno = DEFAULT_VALUE;
            id_transferencia = Pid_transferencia;//Id Salida Externo H
            id_Traslado_a_Ingresar = Pid_traslado;//Id Ingreso externo
            DocEntry = pDocEntry;
            id_mp = pId_mp;

            if (Istraslado)
            {
                btnSeleccionarLote.Visible = true;
                btnSelecciondeMp.Visible = false;
                btnSelccionarProveedor.Visible = false;
                txtLote.Enabled = false;
                txtid_lote.Enabled = false;
                Transferencia trans = new Transferencia();
                trans.RecuperarHeaderTransf_for_id_transfer(id_transferencia);
                Bodega_Externa = trans.Bodega_in;
            }
            else
            {
                btnSeleccionarLote.Visible = false;
            }

            LoadPresentaciones();
            LoadNumeroTransaccion();
        }

        private void LoadNumeroTransaccion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmm2 = new SqlCommand("sp_generar_codigo_from_tables_id", con);
                cmm2.CommandType = CommandType.StoredProcedure;
                cmm2.Parameters.AddWithValue("@id", 2);
                string num_ingreso = cmm2.ExecuteScalar().ToString();
                txtNumIngreso.Text = num_ingreso;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int id_salida_h =0;
            if (MessageBox.Show("Desea crear el ingreso con esta configuracion?. Debe definir los lotes que se han generado.",
                                "Confirmación",
                MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (dsWizard.informacionIngreso.Rows.Count ==0)
                {
                    CajaDialogo.Error("Debe de haber añadido al menos un lote.");
                    return;
                }

                decimal totakud = 0;
                decimal totaltarimas =0;
                decimal totalpeso=0;
                foreach (dsWizard.informacionIngresoRow row in dsWizard.informacionIngreso.Rows)
                {
                    totakud = totakud + row.TotalUdlote;
                    totaltarimas = totaltarimas + row.canttarimas;
                    totalpeso = totalpeso + row.totalKgLote;
                }




                SqlTransaction TransactionIngreso = null;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                bool Guardo = false;
                ArrayList List = new ArrayList();
                try
                {
                    cn.Open();
                    TransactionIngreso = cn.BeginTransaction("Transction Order");

                    foreach (dsWizard.informacionIngresoRow row in dsWizard.informacionIngreso.Rows)
                    {
                        //SqlCommand cmd = new SqlCommand("sp_insert_ingresos_v2", TransactionIngreso.Connection);
                        SqlCommand cmd = cn.CreateCommand();
                        cmd.CommandText = "sp_insert_ingresos_v2";
                        cmd.Connection = cn;
                        cmd.Transaction = TransactionIngreso;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", row.itemcode);//
                        cmd.Parameters.AddWithValue("@itemname", row.itemname);//
                        cmd.Parameters.AddWithValue("@cardcode", row.cardname);//
                        cmd.Parameters.AddWithValue("@cardname", row.pv);  //
                        cmd.Parameters.AddWithValue("@fecha_ingreso", row.fechaIngreso);
                        cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text); //
                        cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote);//  
                        cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);//
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);//
                        cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);//
                        cmd.Parameters.AddWithValue("@cant", totakud);//
                        cmd.Parameters.AddWithValue("@TotalTarimas", totaltarimas);//
                        cmd.Parameters.AddWithValue("@pesotaria", totalpeso);//   
                        cmd.Parameters.AddWithValue("@traslado", Istraslado ? Convert.ToDecimal(row.id_traslado) : 0);//
                        IdHeaderInserted = Convert.ToInt32(cmd.ExecuteScalar());
                        break;
                    }
                    //Update Salida Externa H, Insert Salida Externa Detalle y Detalle Lote
                    #region Codigo Viejo
                    //Insert salida H en Almacen externo
                    //IngresoExternoD ingExD = new IngresoExternoD();

                    //ingExD.RecuperaRegistroInFromIdIngresoH_and_MP_Code(id_Traslado_a_Ingresar);

                    //SqlCommand cmdh = new SqlCommand("sp_salida_almacenes_externos_h_insert", cn);
                    //cmdh.CommandType = CommandType.StoredProcedure;
                    ////cmdh.Transaction = transaction;
                    //cmdh.Parameters.Add("@bodega_in", SqlDbType.VarChar).Value = "BG001";
                    //if(string.IsNullOrEmpty(ingExD.BodegaIn))
                    //    cmdh.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = DBNull.Value;
                    //else
                    //    cmdh.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = ingExD.BodegaIn;

                    //cmdh.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.Now();

                    //if(ingExD.DocEntrySAP>0)
                    //    cmdh.Parameters.Add("@DocEntry", SqlDbType.Int).Value = ingExD.DocEntrySAP;
                    //else
                    //    cmdh.Parameters.Add("@DocEntry", SqlDbType.Int).Value = DBNull.Value;

                    //cmdh.Parameters.Add("@user_creador", SqlDbType.Int).Value = this.UsuarioLogeado.Id;
                    //cmdh.Parameters.Add("@numero_transaccion", SqlDbType.Int).Value = 0;
                    //cmdh.Parameters.Add("@id_ingreso", SqlDbType.Int).Value = DBNull.Value;

                    //id_salida_h = Convert.ToInt32(cmdh.ExecuteScalar());
                    #endregion

                    if (Istraslado)
                    {
                        //Rebajemos de Externo Detalle
                        string query = @"sp_insert_detlle_salida_externo_d";
                        //SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        //conn.Open();
                        //SqlCommand cmdy = new SqlCommand(query, TransactionIngreso.Connection);
                        SqlCommand cmdy = cn.CreateCommand();
                        cmdy.CommandText = query;
                        cmdy.Connection = cn;
                        cmdy.Transaction = TransactionIngreso;
                        cmdy.CommandType = CommandType.StoredProcedure;
                        cmdy.Parameters.AddWithValue("@is_traslado_externo", Istraslado);
                        //cmdy.Parameters.AddWithValue("@idlotes", IdLoteInserted);
                        cmdy.Parameters.AddWithValue("@id_materia_prima", id_mp);
                        cmdy.Parameters.AddWithValue("@peso", 0);
                        cmdy.Parameters.AddWithValue("@cant", 0);
                        cmdy.Parameters.AddWithValue("@line_num", 0);
                        cmdy.Parameters.AddWithValue("@DocEntry", DocEntry);
                        cmdy.Parameters.AddWithValue("@id_inserted_LOSA_salida_externa_h", id_transferencia);
                        id_detalle_inserted = Convert.ToInt32(cmdy.ExecuteScalar());
                        //conn.Close();

                        foreach (dsWizard.informacionIngresoRow rowy in dsWizard.informacionIngreso.Rows)
                        {
                            //Rebajemos de Externo Detalle Lote
                            string query2 = @"sp_insert_salida_externo_d_loteV2";
                            //SqlConnection conn2 = new SqlConnection(dp.ConnectionStringLOSA);
                            //conn2.Open();
                            //SqlCommand cmd2 = new SqlCommand(query2, TransactionIngreso.Connection);
                            SqlCommand cmd2 = cn.CreateCommand();
                            cmd2.CommandText = query2;
                            cmd2.Connection = cn;
                            cmd2.Transaction = TransactionIngreso;
                            cmd2.CommandType = CommandType.StoredProcedure;
                            //cmdy.Parameters.AddWithValue("@idlotes", IdLoteInserted);
                            cmd2.Parameters.AddWithValue("@peso", rowy.totalKgLote);
                            cmd2.Parameters.AddWithValue("@cant", rowy.TotalUdlote);
                            cmd2.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmd2.Parameters.AddWithValue("@id_boleta", this.IdSerie);
                            //cmd2.Parameters.AddWithValue("@DocEntry", DocEntry);
                            cmd2.Parameters.AddWithValue("@id_materia_prima", id_mp);
                            cmd2.Parameters.AddWithValue("@id_detalle_inserted", id_detalle_inserted);
                            cmd2.Parameters.AddWithValue("@id_presentacion", rowy.id_presentacion);
                            cmd2.Parameters.AddWithValue("@lote_materia_prima", rowy.lote);
                            cmd2.Parameters.AddWithValue("@id_traslado", id_Traslado_a_Ingresar);
                            cmd2.Parameters.AddWithValue("@IdHeaderInserted", IdHeaderInserted);
                            cmd2.Parameters.AddWithValue("@id_lote_ingreso_externo", rowy.id_lote_externo);
                            cmd2.ExecuteNonQuery();
                            //conn2.Close();
                        }//End foreach
                    }//if (Istraslado)

                    foreach (dsWizard.informacionIngresoRow row in dsWizard.informacionIngreso.Rows)
                    {
                        //SqlCommand cmd = new SqlCommand("sp_insert_ingresos_lote_v2", TransactionIngreso.Connection);
                        SqlCommand cmd = cn.CreateCommand();
                        cmd.CommandText = "sp_insert_ingresos_lote_v2";
                        cmd.Connection = cn;
                        cmd.Transaction = TransactionIngreso;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", row.itemcode);////
                        cmd.Parameters.AddWithValue("@itemname", row.itemname);//    //
                        cmd.Parameters.AddWithValue("@cardcode", row.cardname);//        //
                        cmd.Parameters.AddWithValue("@cardname", row.pv);  //     //
                        cmd.Parameters.AddWithValue("@fecha_ingreso", row.fechaIngreso);      // //
                        cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text); //  //
                        cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote);//        //
                        cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);//     //
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);//   //
                        cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);//     //
                        cmd.Parameters.AddWithValue("@cant", row.udxtarima);//        //
                        cmd.Parameters.AddWithValue("@TotalTarimas", row.canttarimas);//    //
                        cmd.Parameters.AddWithValue("@pesotaria", Convert.ToDecimal(row.pesokgxtarima));//   //
                        cmd.Parameters.AddWithValue("@lote_externo", Istraslado ? Convert.ToDecimal(row.id_Externo) : 0);//   //
                        cmd.Parameters.AddWithValue("@idheader", IdHeaderInserted);//    //

                        IdLoteInserted = Convert.ToInt32(cmd.ExecuteScalar());

                        int vid_tarima = 0;

                        for (int i = 1; i <= row.canttarimas; i++)
                        {
                            //SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", TransactionIngreso.Connection);
                            SqlCommand cmm = cn.CreateCommand();
                            cmm.CommandText = "sp_generar_codigo_from_tables_id";
                            cmm.Connection = cn;
                            cmm.Transaction = TransactionIngreso;
                            cmm.CommandType = CommandType.StoredProcedure;
                            cmm.Parameters.AddWithValue("@id", 1);
                            string barcode = cmm.ExecuteScalar().ToString();

                            //cmd = new SqlCommand("sp_insert_new_tarima_v4", TransactionIngreso.Connection);
                            cmd = cn.CreateCommand();
                            cmd.CommandText = "sp_insert_new_tarima_v5";
                            cmd.Connection = cn;
                            cmd.Transaction = TransactionIngreso;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", row.itemcode);
                            cmd.Parameters.AddWithValue("@id_proveedor", row.cardname);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", row.fechaIngreso);
                            cmd.Parameters.AddWithValue("@numero_transaccion", txtNumIngreso.Text);
                            cmd.Parameters.AddWithValue("@fecha_vencimiento", row.fvencimiento);
                            cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", row.fproduccion);
                            cmd.Parameters.AddWithValue("@lote_materia_prima", row.lote);
                            cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                            cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@id_boleta", this.IdSerie);
                            cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmd.Parameters.AddWithValue("@cant", row.udxtarima);

                            int CantUnidadesTarima = 0;
                            try
                            {
                                CantUnidadesTarima = dp.ValidateNumberInt32(row.udxtarima);
                            }
                            catch { }

                            PresentacionX pres1 = new PresentacionX();
                            decimal PesoTotalTarima = 0;
                            decimal pres_factor_actual = 0;
                            try
                            {
                                if (pres1.RecuperarRegistro(row.id_presentacion))
                                {
                                    PesoTotalTarima = dp.ValidateNumberDecimal(pres1.Factor) * CantUnidadesTarima;
                                    pres_factor_actual = pres1.Factor;
                                }
                            }
                            catch { }

                            cmd.Parameters.AddWithValue("@peso", PesoTotalTarima);
                            cmd.Parameters.AddWithValue("@idlotes", IdLoteInserted);
                            cmd.Parameters.AddWithValue("@factor", pres_factor_actual);
                            cmd.Parameters.AddWithValue("@bit_promedio", Tg_presentacion_promedio.IsOn ? 1 : 0);
                            cmd.Parameters.AddWithValue("@is_traslado_externo", Istraslado);
                            cmd.Parameters.AddWithValue("@id_salida_h", id_transferencia);
                            //Parametros para la salida de tarima de externo
                            cmd.Parameters.AddWithValue("@id_d_salida_lote", id_detalle_inserted);
                            cmd.Parameters.AddWithValue("@id_lote_ingreso_externo", idLoteExterno);

                            vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                            string query = @"";
                            if (Istraslado)
                                query = @"sp_insert_ubicacion_default_v2";
                            else
                                query = @"sp_insert_ubicacion_default";

                            //SqlCommand cmdx = new SqlCommand(query, TransactionIngreso.Connection);// ahora recibe el parametro de ubicacion para poder guardarlo automatico en todas las tarimas
                            SqlCommand cmdx = cn.CreateCommand();
                            cmdx.CommandText = query;
                            cmdx.Connection = cn;
                            cmdx.Transaction = TransactionIngreso;
                            cmdx.CommandType = CommandType.StoredProcedure;
                            cmdx.Parameters.AddWithValue("@id_tarima", vid_tarima);
                            cmdx.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmdx.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmdx.Parameters.AddWithValue("@id_ubicacion", 131); //bodega c500 predeterminada
                            cmdx.ExecuteNonQuery();

                            List.Add(vid_tarima);

                            //Guardo = true;
                            //con.Close();
                        }

                        
                    }//foreach (dsWizard.informacionIngresoRow row in dsWizard.informacionIngreso.Rows)

                    

                    TransactionIngreso.Commit();
                    Guardo = true;
                }
                catch(Exception ec)
                {
                    TransactionIngreso.Rollback();
                    CajaDialogo.Error(ec.Message);
                    Guardo = false;
                }


                cn.Close();


                if (Guardo)
                {
                    DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
                    if (r == DialogResult.Yes)
                    {
                        for (int i = 0; i <= (List.Count - 1); i++)
                        {
                            int id_tarimax = Convert.ToInt32(List[i]);
                            rptReporteIngresoTarima report = new rptReporteIngresoTarima(id_tarimax);
                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            report.ShowPrintMarginsWarning = false;
                            report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                            report.Print();
                        }
                    }
                    rptLoteRotulo boleta = new rptLoteRotulo(IdLoteInserted);
                    boleta.ShowPrintMarginsWarning = false;
                    boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    boleta.Print();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
        private void LoadDatosBoleta(int idserie)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalles_boleta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SerieBoleta", idserie);
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodigoMP.Text = dr.GetString(1);
                    txtMP_Name.Text = dr.GetString(2);
                    txtCodigoProveedor.Text = dr.GetString(3);
                    txtProveedorName.Text = dr.GetString(4);
                    NumBoleta = dr.GetInt32(0);

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmBoleta frm = new FrmBoleta();
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtIdBoleta.Text = frm.NumBoleta.ToString();
                this.IdSerie = frm.IdSerie;
                this.NumBoleta = frm.NumBoleta;
                if (!Istraslado)
                {
                    this.ItemCode = frm.ItemCode;
                    txtCodigoMP.Text = frm.ItemCode;
                    LoadDatosBoleta(IdSerie);
                }
                txtoc.Text = frm.OC;
                txtfactura.Text = frm.Factura;
                this.peso_boleta = frm.Peso_Bascula;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pv = frm.pv;
                cardcode = frm.Cardcode;
                txtProveedorName.Text = pv;
                txtCodigoProveedor.Text = cardcode;
            }
        }

        private void btnSelecciondeMp_Click(object sender, EventArgs e)
        {
            frmMP frm = new frmMP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ItemCode = frm.ItemCode;
                Dscripcion = frm.MateriaPrima;
                txtMP_Name.Text = Dscripcion;
                txtCodigoMP.Text = frm.ItemCode; 
            }
        }

        public void clear_data()
        {
            txtCodigoMP.Text = "";
            txtMP_Name.Text = "";
            txtCodigoProveedor.Text = "";
            txtProveedorName.Text = "";
            dtFechaIngreso.EditValue = null;
            dtFechaProduccion.EditValue = null;
            dtFechaVencimiento.EditValue = null;
            txtLote.Text = "";
            gridLookUpEditPresentacion.EditValue = null;
            txtpresentacionPromedio.Text = "";
            txtUnidades.Text = "";
            txtPesoKg.Text = "";
            txtCantidadTarimasTotal.Text = "";
            txtfactura.Text = "";
            txtoc.Text = "";
        }
        private void btnGuardarLote_Click(object sender, EventArgs e)
        {
            int idloteInserted;
            if (IdSerie <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima sin la boleta de bascula!");
                return;
            }
            //if (gvNuevaUbicacion.RowCount <= 0)
            //{
            //    CajaDialogo.Error("Debe seleccionar una ubicacion predeterminada para todas las tarimas.");
            //    return;
            //}

            if (Convert.ToDecimal(txtUnidades.Text) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una tarima con unidades de materia en cero (0)!");
                return;
            }

            if (!Tg_presentacion_promedio.IsOn)
            {
                if (string.IsNullOrEmpty(gridLookUpEditPresentacion.Text))
                {
                    CajaDialogo.Error("Es necesario seleccionar la presentacion de la Materia Prima!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar el lote para la tarima!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de producción!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }
            if (string.IsNullOrEmpty(txtoc.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la orden de compra!");
                return;
            }
            if (string.IsNullOrEmpty(txtfactura.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la factura!");
                return;
            }

            int cant = 0;
            try
            {
                cant = Convert.ToInt32(txtCantidadTarimasTotal.Text);
            }
            catch
            {
                cant = 0;
            }

            if (cant <= 0)
            {
                CajaDialogo.Error("No se puede registrar menos de una (1) tarima!");
                return;
            }

            int id_presentacion = dp.ValidateNumberInt32(gridLookUpEditPresentacion.EditValue);
            PresentacionX pres2 = new PresentacionX();
            if (pres2.RecuperarRegistro(id_presentacion))
                factor = pres2.Factor;

            DataRow row = dsWizard.informacionIngreso.NewRow();
            row["id"] = 0;
            row["id_traslado"] = id_Traslado_a_Ingresar;
            row["itemcode"] = txtCodigoMP.Text;
            row["itemname"] = txtMP_Name.Text;
            row["pv"] = txtProveedorName.Text;
            row["cardname"] = txtCodigoProveedor.Text;
            row["fechaIngreso"] = dtFechaIngreso.Text;
            row["udxtarima"] = txtUnidades.Text;
            row["pesokgxtarima"] = txtPesoKg.Text;
            row["fvencimiento"] = dtFechaVencimiento.Text;
            row["fproduccion"] = dtFechaProduccion.Text;
            row["presentacion"] = Tg_presentacion_promedio.IsOn ? txtpresentacionPromedio.Text : gridLookUpEditPresentacion.Text;
            row["factor"] = factor;
            row["lote"] = txtLote.Text;
            row["canttarimas"] = txtCantidadTarimasTotal.Text;
            row["oc"] = txtoc.Text;
            row["factura"] = txtfactura.Text;
            row["bit_promedio"] = Tg_presentacion_promedio.IsOn;
            row["id_presentacion"] = gridLookUpEditPresentacion.EditValue;
            row["id_Externo"] = idLoteExterno;
            if (Istraslado)
                row["id_lote_externo"] = txtid_lote.EditValue;
            else
                row["id_lote_externo"] = 0;

            idLoteExterno = DEFAULT_VALUE;
            decimal CantidadDeUd = 0;
            decimal CantidadDeKG = 0;
            CantidadDeUd = Convert.ToInt32(txtCantidadTarimasTotal.Text) * Convert.ToInt32(txtUnidades.Text);
            CantidadDeKG = Convert.ToInt32(txtCantidadTarimasTotal.Text) * Convert.ToDecimal(txtPesoKg.Text);

            row["totalKgLote"] = CantidadDeKG;
            row["TotalUdlote"] = CantidadDeUd;
            dsWizard.informacionIngreso.Rows.Add(row);
            dsWizard.informacionIngreso.AcceptChanges();
            clear_data();

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
        private void Tg_presentacion_promedio_Toggled(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)          // Data
            {
                try
                {
                    txtpresentacionPromedio.Visible = true;
                    gridLookUpEditPresentacion.Visible = false;
                    labelControl12.Text = "Peso total KG";
                    txtPesoKg.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                txtpresentacionPromedio.Visible = false;
                gridLookUpEditPresentacion.Visible = true;
                txtPesoKg.Enabled = false;
                labelControl12.Text = "Peso Kg por tarima";

                try
                {
                    PresentacionX pre1 = new PresentacionX();
                    if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                    {
                        factor = pre1.Factor;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));

                    }
                }
                catch (Exception ex)
                {


                }
            }
        }

        private void txtCantidadTarimasTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidadTarimasTotal_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn)
            {
                try
                {
                    CalculodelPromedio();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {

            }
        }

        private void txtPesoKg_TextChanged(object sender, EventArgs e)
        {
            CalculodelPromedio();
        }
        public void CalculodelPromedio()
        {
            try
            {
                int unidades_Tarimas = Convert.ToInt32(txtUnidades.Text);
                int cantidad_tariams = Convert.ToInt32(txtCantidadTarimasTotal.Text);
                decimal Unidades_totales = unidades_Tarimas * cantidad_tariams;
                decimal total_pesoKg = Convert.ToDecimal(txtPesoKg.Text);
                factor = total_pesoKg / Unidades_totales;
                txtpresentacionPromedio.Text = string.Format("{0:###,##0.00}", (factor));


            }
            catch (Exception ex)
            {
            }
        }
        private void txtUnidades_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
            if (Tg_presentacion_promedio.IsOn) // 
            {
                CalculodelPromedio();
            }
            else
            {
                try
                {
                    PresentacionX pre1 = new PresentacionX();
                    if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                    {
                        factor = pre1.Factor;
                        txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
                    }
                }
                catch
                {
                    txtPesoKg.Text = "0";
                }
            }
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                PresentacionX pre1 = new PresentacionX();
                if (pre1.RecuperarRegistro(Convert.ToInt32(gridLookUpEditPresentacion.EditValue)))
                {
                    factor = pre1.Factor;
                    txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUnidades.Text)));
                }
            }
            catch (Exception)
            {

                txtPesoKg.Text = "0";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSeleccionarLote_Click(object sender, EventArgs e)
        {
            frmSeleccionrLoteExterno frm = new frmSeleccionrLoteExterno(id_Traslado_a_Ingresar, id_mp, Bodega_Externa);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtLote.Text = frm.lote;
                txtCodigoMP.Text = frm.Itemcode;
                txtMP_Name.Text = frm.Itemname;
                txtProveedorName.Text = frm.cardname;
                txtCodigoProveedor.Text = frm.cardcode;
                dtFechaProduccion.EditValue = frm.fproduccion;
                dtFechaVencimiento.EditValue = frm.fvencimiento;
                LimiteKgloteportraslado = frm.LimiteKG;
                idLoteExterno = frm.id_lote_externo;
                txtid_lote.EditValue = frm.id_lote_externo;
            }
        }

        private void txtIdBoleta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int id_b = 0;
                try
                {
                    id_b = Convert.ToInt32(txtIdBoleta.Text);
                }
                catch { }

                this.IdSerie = id_b;
                Boleta bol1 = new Boleta();
                if (bol1.RecuperarRegistro(this.IdSerie))
                {
                    // txtIdBoleta.Text = bol1.NumID.ToString();
                }
                LoadDatosBoleta(this.IdSerie);
            }
        }
    }
}