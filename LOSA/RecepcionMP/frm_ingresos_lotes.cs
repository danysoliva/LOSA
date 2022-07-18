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

        public frm_ingresos_lotes(int Pid_ingreso, int Pnumero_transaccion, UserLogin Puser, bool Finalizado, int id_traslado)
        {
            InitializeComponent();
            Numero_transaccion = Pnumero_transaccion;
            Id_ingreso = Pid_ingreso;
            UsuarioLogeado = Puser;
            btnFinalizar.Visible = !Finalizado && id_traslado !=0 ? true : false;
            LoadTarimas();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        

        public void LoadTarimas()
        {
            string SqlCommandSp = @"ps_obtener_tarimas_de_ingreso";
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

                throw;
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
                    mensaje = "Esta tarima ya esta comprometida!";
                    break;
                case 5://En Produccion
                    Error = true;//esta habilitada
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

            rptReporteIngresoTarima boleta = new rptReporteIngresoTarima(row.id);
            boleta.ShowPrintMarginsWarning = false;
            boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            boleta.Print();
        }

        private void cmdDuplicar_Click(object sender, EventArgs e)
        {
            //Duplicar la tarima
            frmInputBox frm = new frmInputBox();
            frm.Text = "Duplicar Tarima";
            frm.lblInstrucciones.Text = "Ingrese la cantidad de tarimas a duplicar:";
            frm.txtValue.Text = "1";
            frm.ValidInteger = true;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                int cant = 0;
                try
                {
                    cant = Convert.ToInt32(frm.txtValue.Text);
                }
                catch { }

                if (cant <= 0)
                {
                    CajaDialogo.Error("No se puede duplicar la Tarima! El valor debe ser mayor a cero.");
                    return;
                }

                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

                ArrayList List1 = new ArrayList();

                Tarima tar1 = new Tarima();
                if (tar1.RecuperarRegistro(row.id))
                {

                    for (int i = 1; i <= cant; i++)
                    {
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

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


                            SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_lote", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", vItemCodeMP);
                            cmd.Parameters.AddWithValue("@id_proveedor", tar1.IdProveedor);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", tar1.FechaIngreso);
                            cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
                            cmd.Parameters.AddWithValue("@fecha_vencimiento", tar1.FechaVencimiento);
                            cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", tar1.FechaProduccion);
                            cmd.Parameters.AddWithValue("@lote_materia_prima", tar1.LoteMP);
                            cmd.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);
                            cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@id_boleta", tar1.IdBoleta);
                            cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmd.Parameters.AddWithValue("@cant", tar1.Cantidad);
                            cmd.Parameters.AddWithValue("@peso", tar1.Peso);
                            cmd.Parameters.AddWithValue("@idlotes", tar1.Id_ingreso);
                            int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                            List1.Add(vid_tarima);

                            con.Close();
                            //this.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }
                    }//end for 

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

            frmEditTarima frm = new frmEditTarima(row.id, this.UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmagregarlote frm = new frmagregarlote(Id_ingreso,Numero_transaccion, UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                LoadTarimas();
                
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmverlotes frm = new frmverlotes(id_ingreso , UsuarioLogeado);
            frm.Show();
        }

        private void btneliminarTm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar la tarima?", "Desea eliminar la tarima?",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();
                string query = @"sp_deshabilitar_tm_por_id_v2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtm", row.id);
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                CajaDialogo.Information("Se he eliminado correctamente la tarima.");  
                LoadTarimas();

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
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetDataRow(i);

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
                                    reportResumen.ModifyDocument(x => 
                                    { 
                                        x.AddPages(report2.Pages); 
                                    });
                                }
                            }
                        }
                    }//if row.id>0
                }//if seleccionado is true
            }//For
            if (reportResumen != null)
            {
                using (ReportPrintTool printTool = new ReportPrintTool(reportResumen))
                {
                    printTool.ShowPreviewDialog();
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