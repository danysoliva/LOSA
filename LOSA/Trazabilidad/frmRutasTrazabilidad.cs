using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Calidad;
using LOSA.Clases;
using LOSA.Logistica;
using LOSA.TransaccionesMP;
using LOSA.TransaccionesMP.TrzMP_fromLote;
using LOSA.Trazabilidad.Despachos;
using LOSA.Trazabilidad.ReportesTRZ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Trazabilidad
{
    public enum BotonCerrarDespacho
    {
        Ruta1 = 1,
        Ruta3 = 3,

    }
    public partial class frmRutasTrazabilidad : DevExpress.XtraEditors.XtraForm
    {
        UserLogin login = new UserLogin();
       
        
        //Varibles de Ruta 3
        LotePT LoteActual;
        public int lote_fp;
        DataOperations dp = new DataOperations();
        

        //Variables Ruta 2
        bool ChCalidad;
        public int Id_ingreso;
        string full_pathImagen = "";
        string fileNameImagen = "";
        string code_sap;
        string codigoRuta2;
        string usercreadorIngreso;
        string Direccion;
        string phone;
        int id_materiaPrimaRuta2;
        bool cambioImagen = false;
        string CodeSAP_Proveedor;
        string NombreSAP_Proveedor;

        int navigationPageSeleccionado;

       

        public frmRutasTrazabilidad(UserLogin log)
        {
            InitializeComponent();
            //LoadClientes();
            this.navigationFrame1.SelectedPage = npMain;
            txtLoteRuta1.Text = "";
        }

        private void acordionRuta1_Click(object sender, EventArgs e)
        {
            acordionRuta1.Appearance.Normal.BackColor=   Color.FromName("DeepSkyBlue");
            acordionRuta1.Appearance.Normal.ForeColor=   Color.White; //242,242,242

            acordionRuta2.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta2.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta3.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta3.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta4.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta4.Appearance.Normal.ForeColor = Color.FromArgb(80, 80,80);


            if (this.rutaActiva!=1)
            {
            dsReportesTRZ.pt_list_trz.Clear();
            }


            this.rutaActiva = 1;


            //lote_fp = 0;
            //txtlote.Text = "";
            //dsCalidad.trazabilitad.Clear();
            //dsInventarioPT.transacciones.Clear();
            //dsInventarioPT.despachos.Clear();
            //txtversion.Text = "";
            //txtformula.Text = "";
            //txtProducto.Text = "";
            //txtPresentacion.Text = "";
            //txtOrderNum.Text = "";
            //txtCodigoPP.Text = "";
            //txtSacosLiberados.Text = "";
            //txtTotalMP_Utilizada_kg.Text = "";
            //txtCantidadBatch.Text = "";
            //txtcodigo.Text = "";
            //txtTotalKgSacosLiberados.Text = "";
            //txtOrderNum.Text = "";
            //txtCodigoPP.Text = "";
            //txtPresentacion.Text = "";
            //txtCantidadBatch.Text = "";
            //txtEficiencia.Text = "";
            //txtReprocesoKg.Text = "";
            //txtTotalProducido.Text = "";

            //btnBack.Text = "Inicio";
            //btnBack.Visible = true;

            //dsReportesTRZ.detalle_destinos.Clear();
            lblMateriaPrimaName.Text = "";

            navigationFrame1.SelectedPage = npRuta1;
        }

        private void acordionRuta2_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            acordionRuta2.Appearance.Normal.BackColor = Color.FromName("DeepSkyBlue");
            acordionRuta2.Appearance.Normal.ForeColor = Color.White; //242,242,242

            acordionRuta1.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta1.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta3.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta3.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta4.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta4.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);


            if (this.rutaActiva != 2)
            {
                dsReportesTRZ.pt_list_trz.Clear();
                dsReportesTRZ.detalle_destinos.Clear();
                lblMateriaPrimaName.Text = "";
            }

            this.rutaActiva = 2;


            //dsReportesTRZ.pt_list_trz.Clear();

            navigationFrame1.SelectedPage = npRuta2;
        }

        private void acordionRuta3_Click(object sender, EventArgs e)
        {
            acordionRuta3.Appearance.Normal.BackColor = Color.FromName("DeepSkyBlue");
            acordionRuta3.Appearance.Normal.ForeColor = Color.White; //242,242,242

            acordionRuta2.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta2.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta1.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta1.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta4.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta4.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            this.rutaActiva = 3;

            btnBack.Text = "Back";


            navigationFrame1.SelectedPage = navigationPage3;
        }

        private void acordionRuta4_Click(object sender, EventArgs e)
        {
            acordionRuta4.Appearance.Normal.BackColor = Color.FromName("DeepSkyBlue");
            acordionRuta4.Appearance.Normal.ForeColor = Color.White; //242,242,242

            acordionRuta2.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta2.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta3.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta3.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            acordionRuta1.Appearance.Normal.BackColor = Color.FromArgb(242, 242, 242);
            acordionRuta1.Appearance.Normal.ForeColor = Color.FromArgb(80, 80, 80);

            this.rutaActiva = 4;


            lote_fp = 0;
            txtlote.Text = "";
            dsCalidad.trazabilitad.Clear();
            dsInventarioPT.transacciones.Clear();
            dsInventarioPT.despachos.Clear();
            txtversion.Text = "";
            txtformula.Text = "";
            txtProducto.Text = "";
            txtPresentacion.Text = "";
            txtOrderNum.Text = "";
            txtCodigoPP.Text = "";
            txtSacosLiberados.Text = "";
            txtTotalMP_Utilizada_kg.Text = "";
            txtCantidadBatch.Text = "";
            txtcodigo.Text = "";
            txtTotalKgSacosLiberados.Text = "";
            txtOrderNum.Text = "";
            txtCodigoPP.Text = "";
            txtPresentacion.Text = "";
            txtCantidadBatch.Text = "";
            txtEficiencia.Text = "";
            txtReprocesoKg.Text = "";
            txtTotalProducido.Text = "";
            btnBack.Visible = true;

            navigationFrame1.SelectedPage = navigationFrame1.SelectedPage = npReporteTrazabilidad;
        }


        #region Ruta 3

        #endregion
        private void LoadClientes()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.sp_get_Direccion_Clientes", cnx);
                    dsCalidad.Direccion_Clientes.Clear();

                    da.Fill(dsCalidad.Direccion_Clientes);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void slueCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("sp_DespachadoClientes_V2", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = slueCliente.EditValue;

                    dsCalidad.DespachadoClientes.Clear();

                    da.Fill(dsCalidad.DespachadoClientes);

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnVer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCalidad.DespachadoClientesRow)gvDespachado.GetFocusedDataRow();
                              navigationFrame1.SelectedPage = npReporteTrazabilidad;
                txtlote.Text = row.lote_producto_termiado;

                this.btnBack.Visible = true;

                load_header();
                load_data(); 
                Load_Despachos();
                load_informacion_de_inventario();
                load_tarimas_rechazadas();
                load_MuestreoPT();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_header()
        {
            try
            {


                if (!string.IsNullOrEmpty(txtlote.Text))
                {
                    LotePT ptProducido = new LotePT();
                    if (ptProducido.RecuperarRegistro(Convert.ToInt32(txtlote.Text)))
                    {
                        LoteActual = ptProducido;
                        txtTotalKgSacosLiberados.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.TotalKg);
                        txtSacosLiberados.Text = string.Format("{0:###,##0 Sacos}", ptProducido.Unidades);
                        txtReprocesoKg.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.Reproceso_kg);
                        txtTotalProducido.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.Reproceso_kg + ptProducido.TotalKg);
                        txtPresentacion.Text = ptProducido.DescripcionPresentacion;
                        txtCantidadBatch.Text = string.Format("{0:###,##0}", ptProducido.CantidadBatch);
                        txtOrderNum.Text = ptProducido.OrderNum_prd.ToString();
                        txtCodigoPP.Text = ptProducido.OrderCodePP;
                    }

                    string sql_h = @"[dbo].[RPT_PRD_Trazabilidad_header_lote]";

                    SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);

                    try
                    {
                        cn.Open();
                        SqlCommand cmd_h = new SqlCommand(sql_h, cn);
                        cmd_h.CommandType = CommandType.StoredProcedure;
                        cmd_h.Parameters.AddWithValue("@num_lote", txtlote.Text);
                        SqlDataReader dr_h = cmd_h.ExecuteReader();

                        Int64 AcsId = 0;
                        if (dr_h.Read())
                        {
                            txtcodigo.Text = dr_h.GetString(0);
                            txtProducto.Text = dr_h.GetString(1);
                            txtformula.Text = dr_h.GetInt32(3).ToString();
                            txtversion.Text = dr_h.GetInt32(4).ToString();
                        }
                        dr_h.Close();
                    }
                    catch (Exception EX)
                    {
                        CajaDialogo.Error(EX.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data()
        {
            if (!string.IsNullOrEmpty(txtlote.Text))
            {
                string query = @"[sp_load_report_trazabilitadad_lotev2_group_by_mp]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCalidad.trazabilitad.Clear();
                    da.Fill(dsCalidad.trazabilitad);
                    cn.Close();
                    if (dsCalidad.trazabilitad.Rows.Count == 0)
                    {
                        errorProvider1.SetError(txtlote, "Este lote aun no tiene materias primas utilizadas!");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                //Calcular el total MP utilizada
                decimal TotalMP_kg = 0;
                foreach (dsCalidad.trazabilitadRow row in dsCalidad.trazabilitad.Rows)
                {
                    TotalMP_kg += row.Contado;
                }
                txtTotalMP_Utilizada_kg.Text = string.Format("{0:###,##0.00 Kg}", TotalMP_kg);
                if (LoteActual != null)
                {
                    if (LoteActual.Recuperado)
                    {
                        if (TotalMP_kg > 0)
                            txtEficiencia.Text = string.Format("{0:###,##0.00}", ((LoteActual.Reproceso_kg + LoteActual.TotalKg) / TotalMP_kg) * 100);
                        else
                            txtEficiencia.Text = string.Format("{0:###,##0.00}", 0);
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           

            if (rutaActiva==1 || rutaActiva == 4)
            {
                this.navigationFrame1.SelectedPage = npMain;
            }
            else
                navigationFrame1.SelectedPage = navigationPage3;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (txtlote.Text == "")
            {
                CajaDialogo.Error("Debe de especificar el lote que desea encontrar resultados.");
            }
            load_data();//Detalle de materias primas usadas en lote de PT
            load_header();
            Load_Despachos();
            load_informacion_de_inventario();
            load_tarimas_rechazadas();
            load_MuestreoPT();
        }

        private void Load_Despachos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_destinos_lote_pt_trz_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                dsReportesTRZ.detalle_destinos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.detalle_destinos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void load_informacion_de_inventario()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_inventory_trasaccion_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.transacciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.transacciones);



                cmd = new SqlCommand("sp_get_inventorio_habilitado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.libres.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.libres);

                cmd = new SqlCommand("sp_get_inventorio_observacion_retenido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.retenidos.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.retenidos);

                cmd = new SqlCommand("sp_get_resumen_pt_transaccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                dsInventarioPT.resumen.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInventarioPT.resumen);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        public void load_tarimas_rechazadas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_tarimas_rechazadas_pt_for_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", txtlote.Text);
                dsReportesTRZ.tarimas_rechazadas_pt.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.tarimas_rechazadas_pt);


                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        public void load_MuestreoPT()
        {
            try
            {


                if (tggMuestras.IsOn)
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_detalle_muestreo_y_parametro_trz_all", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                    dsTrazabilidadReports.muestreo_lote.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsTrazabilidadReports.muestreo_lote);

                    con.Close();
                }
                else
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_detalle_muestreo_y_parametro_trz", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lote", txtlote.Text);
                    dsTrazabilidadReports.muestreo_lote.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(dsTrazabilidadReports.muestreo_lote);

                    con.Close();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            lote_fp = 0;
            txtlote.Text = "";
            dsCalidad.trazabilitad.Clear();
            txtversion.Text = "";
            txtformula.Text = "";
            txtProducto.Text = "";
            txtcodigo.Text = "";
            txtTotalMP_Utilizada_kg.Text = "";
            txtReprocesoKg.Text = "";
            txtTotalProducido.Text = "";
            txtSacosLiberados.Text = "";
            txtTotalKgSacosLiberados.Text = "";
            txtOrderNum.Text = "";
            txtCodigoPP.Text = "";
            txtPresentacion.Text = "";
            txtCantidadBatch.Text = "";
            txtEficiencia.Text = "";
            
        }

        private void btnCertidicado_Click(object sender, EventArgs e)
        {
            if (txtlote.Text == "")
            {
                CajaDialogo.Error("Debe tener seleccionado un lote de PT para imprimir el certificado de calidad.");
                return;
            }
            rpt_certificado_calidad report = new rpt_certificado_calidad(LoteActual.LotePT_Num);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void tggMuestras_Toggled(object sender, EventArgs e)
        {
            load_MuestreoPT();
        }


        //Navega al NavigationPage NPRuta3MP

        private void btnLinkMateriaPrima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //rmMateriaPrimaViewer(string SAPCODE_MP, string SAP_CARD_CODE)
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsCalidad.trazabilitadRow)gridView.GetFocusedDataRow();
            //frmMateriaPrimaViewer frm = new frmMateriaPrimaViewer(row.code_sap, row.lote_mp, 0);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            cargarDatosTarimas(row.code_sap);
            cargarMateriaPrima(row.code_sap);
            navigationFrame1.SelectedPage = npRuta3MP;
        }


        private void cargarDatosTarimas(string pCodeSAP)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_by_MP_v3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pCodeSAP);
                //cmd.Parameters.AddWithValue("@cardcode", pCardCode);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoTrazabilidad.lista_lotes_mp.Clear();
                adat.Fill(dsMantoTrazabilidad.lista_lotes_mp);
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }



        private void cargarMateriaPrima(string pCodeSap)
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_get_header_resumen_materiaprima";

                //dsLogistica.Materia_prima_v2.Clear();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codesap", pCodeSap);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //DataTable table1 = new DataTable();
                dsMantoTrazabilidad.view_mp.Clear();
                adat.Fill(dsMantoTrazabilidad.view_mp);
                //vGridControl1.DataSource = table1;
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = npReporteTrazabilidad;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (rutaActiva == 1)
            {
                navigationFrame1.SelectedPage = npRuta2;
            }
            else
                navigationFrame1.SelectedPage = npReporteTrazabilidad;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void cmdDespachoId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcClientesRecibieronLotePT.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();

            navigationFrame1.SelectedPage = npRuta3DetalleDespacho;

            LoadDatosDetalleDespacho(row.Despacho);
        }

        private void LoadDatosDetalleDespacho(int despachoId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_despacho", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numid", despachoId);
                dsReportesTRZ.detalle_despachos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.detalle_despachos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnGenerarRuta1_Click(object sender, EventArgs e)
        {
            LoteMP LoteMP_ = new LoteMP();
            if (LoteMP_.RecuperarRegistro(txtLoteRuta1.Text))
            {
                if (LoteMP_.CantidadMP > 1)
                {
                    //Mostrar Ventana
                    frmMP_WithSameLot frm = new frmMP_WithSameLot(LoteMP_);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadLotesPT_Ruta2(frm.IdMP_Selected);
                        lblMateriaPrimaName.Text = frm.NameMaterialselected;
                    }
                }
                else
                {
                    LoadLotesPT_Ruta2(LoteMP_.IdMPSingle);
                    lblMateriaPrimaName.Text = LoteMP_.NombreComercialSingle;
                }
            }
        }


        private void LoadLotesPT_Ruta1(object idMP_Selected)
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_lotes_pt_trz_from_lote_mpv3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtLoteMPRuta1.Text);
                cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadLotesPT_Ruta2(object idMP_Selected)
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_lotes_pt_trz_from_lote_mpv3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtLoteRuta1.Text);
                cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            txtLoteRuta1.Text = "";
            txtLoteRuta1.Focus();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            LoteMP LoteMP_ = new LoteMP();
            if (LoteMP_.RecuperarRegistro(txtlote.Text))
            {
                if (LoteMP_.CantidadMP > 1)
                {
                    //Mostrar Ventana
                    frmMP_WithSameLot frm = new frmMP_WithSameLot(LoteMP_);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadLotesPT_Ruta2(frm.IdMP_Selected);
                        lblMateriaPrimaName.Text = frm.NameMaterialselected;
                    }
                }
                else
                {
                    LoadLotesPT_Ruta2(LoteMP_.IdMPSingle);
                    lblMateriaPrimaName.Text = LoteMP_.NombreComercialSingle;
                }
            }
        }

        private void gridView6_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gcLotePT.FocusedView;
            var row = (dsReportesTRZ.pt_list_trzRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                
                if (row!=null)
                {
                con.Open();



                SqlCommand cmd = new SqlCommand("sp_get_detalle_destinos_lote_pt_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", row.Lote_PT);
                dsReportesTRZ.detalle_destinos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.detalle_destinos);

                con.Close();
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtlote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtlote.Text == "")
                {
                    CajaDialogo.Error("Debe de especificar el lote que desea encontrar resultados.");
                }
                load_header();
                load_data();
                Load_Despachos();
                load_informacion_de_inventario();
                load_tarimas_rechazadas();
                load_MuestreoPT();
            }
        }

        private void btnTrazabilidadLoteMP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsCalidad.trazabilitadRow)gridView.GetFocusedDataRow();


            navigationFrame1.SelectedPage = npInfoLote;
            Id_ingreso = 0;
            //UsuarioLogeado = Puser;
            //tabControl1.TabPages[4]
            load_dataRuta2(row.lote_mp);
            load_data_ingresoRuta2(row.lote_mp);
            Load_cargas_niRuta2(row.lote_mp);
            Inicializar_data_logisticaRuta2(row.lote_mp);
            load_zonasRuta2();
            load_especieRuta2();
            load_tipo();
            load_paisesRuta2();
            LoadLotesPT_Ruta2();
            LoadInventarioKardexRuta2();
            //Load_Despachos();
            if (ChCalidad)
            {
                load_criterios_configuradosRuta2(row.lote_mp);
                Inicalizar_Archivo_configuradosRuta2(row.lote_mp);
                get_imagenRuta2(row.lote_mp);
                load_empaque_estado_MpRuta2(row.lote_mp);
                load_trasporte_estado_transporteRuta2(row.lote_mp);
                load_criterios_adicionalesRuta2(row.lote_mp);

                if (full_pathImagen != "")
                {
                    pc_Mp.Image = ByteToImageRuta2(GetImgByteRuta2(full_pathImagen));
                }
            }
            else
            {
                inicializar_criteriosRuta2();
                Inicalizar_ArchivoRuta2();
            }


            //frmTrazabilidadHaciaAdelanteByMP_Lot frm = new frmTrazabilidadHaciaAdelanteByMP_Lot(row.lote_mp, row.nombre_comercial);
            //rdEstadoTransporte frm = new rdEstadoTransporte(row.lote_mp, logue);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        #region Ruta2
        public void load_dataRuta2(string pLotemp)
        {
            string query = @"sp_get_informacion_get_to_show_calidad_by_lotemp";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_lote", pLotemp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtloteMP.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtnombreMP.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    txtboleta.Text = dr.IsDBNull(2) ? "" : dr.GetInt32(2).ToString();
                    txtproveedor.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtnumtraslado.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    txtoc.Text = dr.IsDBNull(6) ? "" : dr.GetString(5).ToString();
                    txtreferencia.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                    ChCalidad = dr.IsDBNull(7) ? false : dr.GetBoolean(7);
                    code_sap = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    codigoRuta2 = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    usercreadorIngreso = dr.IsDBNull(10) ? "" : dr.GetString(10);
                    txtuserlogistica.Text = usercreadorIngreso;
                    txtusercalidad.Text = login.NombreUser;
                    txttransporte.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                    txttransportista.Text = dr.IsDBNull(12) ? "" : dr.GetString(12);
                    phone = dr.IsDBNull(13) ? "" : dr.GetString(13);
                    Direccion = dr.IsDBNull(14) ? "" : dr.GetString(14);
                    txtTelefono.Text = phone;
                    txtdireccion.Text = Direccion;
                    txtFacturas.Text = dr.IsDBNull(15) ? "" : dr.GetString(15);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data_ingresoRuta2(string pLotemp)
        {
            string query = @"sp_get_informacion_get_to_show_calidad_data_mp_by_lote";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_lotemp", pLotemp);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtproduccion.EditValue = dr.IsDBNull(0) ? DateTime.Now : dr.GetDateTime(0);
                    dtvencimiento.EditValue = dr.IsDBNull(1) ? DateTime.Now : dr.GetDateTime(1);
                    txtdiasvencimiento.Text = dr.IsDBNull(2) ? "0" : dr.GetInt32(2).ToString();
                    txtingresada.Text = dr.IsDBNull(3) ? "" : dr.GetDecimal(3).ToString();
                    txtinventarioActual.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString();
                    id_materiaPrimaRuta2 = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void Load_cargas_niRuta2(string plotemp)
        {
            string query = @"sp_load_validaciones_del_nir_to_show_calidad_by_lote";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@id_mp", id_materiaPrimaRuta2);
                cmd.Parameters.AddWithValue(@"@_lotemp", plotemp);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.show_nir.Clear();
                da.Fill(dsMantenimientoC.show_nir);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void Inicializar_data_logisticaRuta2()
        {
            try
            {
                string query = @"sp_obtener_datos_logistica_to_show_calidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@id_ingreso", Id_ingreso);
                dsMantenimientoC.logisticaInformacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.logisticaInformacion);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void Inicializar_data_logisticaRuta2(string plotemp)
        {
            try
            {
                string query = @"sp_obtener_datos_logistica_to_show_calidad_by_lote";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@_lotemp", plotemp);
                dsMantenimientoC.logisticaInformacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.logisticaInformacion);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_zonasRuta2()
        {
            string query = @"sp_load_zona_pesca_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.zonaPesca.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.zonaPesca);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_tipo()
        {
            string query = @"sp_load_tipo_ingreso_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.tipoingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.tipoingreso);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_paisesRuta2()
        {
            string query = @"sp_load_paises_de_origen_calidad_ingreso";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.paises.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.paises);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_especieRuta2()
        {
            string query = @"sp_select_especies_origen";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.origen_especie.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.origen_especie);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadLotesPT_Ruta2()
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_load_lotes_pt_trz_from_lote_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtloteMP.Text);
                dsReportesTRZ.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadInventarioKardexRuta2()
        {
            string query = @"sp_obtener_inventario_general_por_lote_trz";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtloteMP.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima.informacion.Clear();
                da.Fill(dsTarima.informacion);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_criterios_configuradosRuta2(string plotemp)
        {
            string query = @"sp_load_trz_criterio_ingreso_respuesta_bylotemp";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_lotemp", plotemp);
                cmd.Parameters.AddWithValue(@"@id_mp", id_materiaPrimaRuta2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.parametros.Clear();
                da.Fill(dsMantenimientoC.parametros);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void Inicalizar_Archivo_configuradosRuta2(string plotemp)
        {
            try
            {
                string query = @"sp_load_trz_documentos_ingreso_by_lote_mp";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_lotemp", plotemp);
                dsMantenimientoC.adjuntos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.adjuntos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_imagenRuta2(string _lotemp)
        {
            string query = @"sp_get_imagen_of_ingreso_calidad_by_lotemp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", _lotemp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fileNameImagen = dr.GetString(0);
                full_pathImagen = dr.GetString(1);
            }
            dr.Close();
        }

        public void load_trasporte_estado_transporteRuta2(string plotemp)
        {
            string query = @"sp_load_trz_criterio_ingreso_transporte_by_lotemp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", plotemp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rdTranporte1.EditValue = dr.IsDBNull(0) ? true : dr.GetBoolean(0);
                rdTranporte2.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
                rdTranporte3.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
                rdTranporte4.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
                //txtmp1.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                //txtmp2.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                //txtmp3.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);

                dsTarima.ultimas_cargasRow row1 = dsTarima.ultimas_cargas.Newultimas_cargasRow();
                row1.descripcion = dr.IsDBNull(4) ? "" : dr.GetString(4);
                dsTarima.ultimas_cargas.Addultimas_cargasRow(row1);
                dsTarima.AcceptChanges();

                dsTarima.ultimas_cargasRow row2 = dsTarima.ultimas_cargas.Newultimas_cargasRow();
                row2.descripcion = dr.IsDBNull(5) ? "" : dr.GetString(5);
                dsTarima.ultimas_cargas.Addultimas_cargasRow(row2);
                dsTarima.AcceptChanges();

                dsTarima.ultimas_cargasRow row3 = dsTarima.ultimas_cargas.Newultimas_cargasRow();
                row3.descripcion = dr.IsDBNull(6) ? "" : dr.GetString(6);
                dsTarima.ultimas_cargas.Addultimas_cargasRow(row3);
                dsTarima.AcceptChanges();

                txtobservacionTras.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
            }
            dr.Close();
        }

        public void load_criterios_adicionalesRuta2()
        {
            string query = @"sp_load_trz_criterio_ingreso_calidad_adicionales";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                grd_origenespecie.EditValue = dr.IsDBNull(0) ? (object)DBNull.Value : dr.GetInt32(0);
                grd_tipo.EditValue = dr.IsDBNull(1) ? (object)DBNull.Value : dr.GetInt32(1);
                spTipoporcentaje.EditValue = dr.IsDBNull(2) ? (object)DBNull.Value : dr.GetDecimal(2);
                grd_pesca.EditValue = dr.IsDBNull(3) ? (object)DBNull.Value : dr.GetInt32(3);
                txtPLantaSenasa.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                spsustentable.EditValue = dr.IsDBNull(5) ? (object)DBNull.Value : dr.GetDecimal(5);
                grd_origen.EditValue = dr.IsDBNull(6) ? (object)DBNull.Value : dr.GetInt32(6);
                hyfishsource.EditValue = dr.IsDBNull(7) ? "" : dr.GetString(7);
                hyIUCN.EditValue = dr.IsDBNull(8) ? "" : dr.GetString(8);
                txtusercalidad.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
            }
            dr.Close();
        }

        public void load_criterios_adicionalesRuta2(string plotemp)
        {
            string query = @"sp_load_trz_criterio_ingreso_calidad_adicionales_by_lotemp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", plotemp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                grd_origenespecie.EditValue = dr.IsDBNull(0) ? (object)DBNull.Value : dr.GetInt32(0);
                grd_tipo.EditValue = dr.IsDBNull(1) ? (object)DBNull.Value : dr.GetInt32(1);
                spTipoporcentaje.EditValue = dr.IsDBNull(2) ? (object)DBNull.Value : dr.GetDecimal(2);
                grd_pesca.EditValue = dr.IsDBNull(3) ? (object)DBNull.Value : dr.GetInt32(3);
                txtPLantaSenasa.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                spsustentable.EditValue = dr.IsDBNull(5) ? (object)DBNull.Value : dr.GetDecimal(5);
                grd_origen.EditValue = dr.IsDBNull(6) ? (object)DBNull.Value : dr.GetInt32(6);
                hyfishsource.EditValue = dr.IsDBNull(7) ? "" : dr.GetString(7);
                hyIUCN.EditValue = dr.IsDBNull(8) ? "" : dr.GetString(8);
                txtusercalidad.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
            }
            dr.Close();
        }

        public void load_empaque_estado_MpRuta2()
        {
            string query = @"sp_load_trz_criterio_ingreso_empaque";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                rdEmpaque1.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
                rdEmpaque2.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
                rdEmpaque3.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
                rdEmpaque4.EditValue = dr.IsDBNull(4) ? true : dr.GetBoolean(4);
                rdEstadomp.EditValue = dr.IsDBNull(6) ? true : dr.GetBoolean(6);
                txtObseracionesMP.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
            }
            dr.Close();
        }

        public void load_empaque_estado_MpRuta2(string lotemp)
        {
            string query = @"sp_load_trz_criterio_ingreso_empaque_by_lotemp";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", lotemp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                rdEmpaque1.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
                rdEmpaque2.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
                rdEmpaque3.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
                rdEmpaque4.EditValue = dr.IsDBNull(4) ? true : dr.GetBoolean(4);
                rdEstadomp.EditValue = dr.IsDBNull(6) ? true : dr.GetBoolean(6);
                txtObseracionesMP.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
            }
            dr.Close();
        }

        public byte[] GetImgByteRuta2(string ftpFilePath)
        {
            DataOperations dp = new DataOperations();


            WebClient ftpClient = new WebClient();
            //ftpClient.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
            ftpClient.Credentials = new NetworkCredential(login.ADuser1, login.Pass);

            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;
        }

        public static Bitmap ByteToImageRuta2(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public void inicializar_criteriosRuta2()
        {
            string query = @"sp_load_inicializacion_de_criterios_calidad";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@id_mp", id_materiaPrimaRuta2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.parametros.Clear();
                da.Fill(dsMantenimientoC.parametros);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void Inicalizar_ArchivoRuta2()
        {
            try
            {
                string query = @"sp_load_inizializar_data";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.adjuntos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.adjuntos);
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }


        }

        private void UpdateFabricante(int id_ingreso, int pIdPlantaFabricante)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_id_fabricante_ingreso_lote_alosy", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", id_ingreso);
                cmd.Parameters.AddWithValue("@id_fabricante", pIdPlantaFabricante);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private bool Upload(string pathFile, string fileName)
        {
            bool r = false;

            try
            {

                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó el archivo!");
                    return false;
                }
                else
                {
                    DataOperations dp = new DataOperations();

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathFile);//crear el archivo en el server
                    request.Credentials = new NetworkCredential(login.ADuser1, login.Pass);
                    //request.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead(fileName))//del pc local la ruta
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                    }
                    r = true;

                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return r;
        }
        #endregion

        private void btnRecientes_Click(object sender, EventArgs e)
        {
            frmRecientes frm = new frmRecientes();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                foreach (dsMantenimientoC.adjuntosRow rw in dsMantenimientoC.adjuntos.Rows)
                {
                    if (rw.id_conf == frm.id)
                    {
                        rw.bit_subido = true;
                        rw.path_load = frm.path;
                        rw.file_name = frm.file_name;
                    }
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationFrame1.SelectedPage = npReporteTrazabilidad;
        }

        private void cmdSelectUltimasCargas_Click(object sender, EventArgs e)
        {
            Boleta bol1 = new Boleta();
            if (bol1.RecuperarRegistro(dp.ValidateNumberInt32(txtboleta.Text)))
            {
                frmBuscarDatosBascula frm = new frmBuscarDatosBascula(bol1.Furgon, bol1.Id, bol1.Placa_vehiculo);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dsTarima.ultimas_cargas.Clear();
                    foreach (string var_ in frm.ListaDatos)
                    {
                        dsTarima.ultimas_cargasRow row1 = dsTarima.ultimas_cargas.Newultimas_cargasRow();
                        row1.descripcion = var_;
                        dsTarima.ultimas_cargas.Addultimas_cargasRow(row1);
                        dsTarima.AcceptChanges();
                    }
                }
            }
            else
            {
                CajaDialogo.Error("No hay una boleta asociada!");
            }
            //txtboleta
        }

        private void btnAdjuntarImagen_Click(object sender, EventArgs e)
        {
            frmAdjuntarImagen frm = new frmAdjuntarImagen();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                full_pathImagen = frm.full_path;
                fileNameImagen = frm.fileName;
                cambioImagen = true;
                //Upload( full_path, fileName);
                //CajaDialogo.Information("ARCHIVO CARGADO SATISFACTORIAMENTE");
                pc_Mp.Image = Image.FromFile(full_pathImagen);
            }
        }

        private void btnAdjuntarDocumento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_adjuntos.FocusedView;
                var row = (dsMantenimientoC.adjuntosRow)gridView.GetFocusedDataRow();
                openFileDialog1.InitialDirectory = "C:/";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //path = Dialog.SafeFileName;
                    row.path = openFileDialog1.FileName;
                    row.path_load = openFileDialog1.FileName;
                    row.file_name = openFileDialog1.SafeFileName;
                    row.bit_subido = true;
                }
                row.AcceptChanges();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSearchFabricantePrv_Click(object sender, EventArgs e)
        {
            frmListaFabricantes frm = new frmListaFabricantes(CodeSAP_Proveedor, NombreSAP_Proveedor);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtFabricante.Text = frm.NombreFabricanteSeleccionado;
                //frm.IdFabricanteSeleccionado;
                UpdateFabricante(Id_ingreso, frm.IdFabricanteSeleccionado);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Query = @"sp_delete_criterio_ingreso_respuesta";       //Elimna todas las respuestas guardadas.
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.ExecuteScalar();

                foreach (dsMantenimientoC.parametrosRow row in dsMantenimientoC.parametros.Rows)
                {
                    if (row.respuesta != "" || row.respuesta != " ")
                    {
                        Query = @"sp_insert_criterios_calidad_data";
                        cmd = new SqlCommand(Query, cn);             //Inserta las respuestas del grid principal
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_definicion", row.id);
                        cmd.Parameters.AddWithValue("@definicion", row.definicion);
                        cmd.Parameters.AddWithValue("@id_criterio", row.id_criterio == 0 ? (object)DBNull.Value : row.id_criterio);
                        cmd.Parameters.AddWithValue("@id_respuesta", row.id_respuestas == 0 ? (object)DBNull.Value : row.id_respuestas);
                        cmd.Parameters.AddWithValue("@respuesta", row.respuesta);
                        cmd.Parameters.AddWithValue("@criterio", row.descripcion);
                        cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                        cmd.Parameters.AddWithValue("@user_register", login.Id);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }
                }

                Query = @"sp_insert_trz_criterio_ingreso_calidad_adicionales";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.Parameters.AddWithValue("@origen", grd_origenespecie.EditValue == null ? (object)DBNull.Value : grd_origenespecie.EditValue);
                cmd.Parameters.AddWithValue("@porcentajetipo", spTipoporcentaje.Text == "0" || spsustentable.Text == "" ? (object)DBNull.Value : spTipoporcentaje.Text);
                cmd.Parameters.AddWithValue("@zonapesca", grd_pesca.EditValue == null ? (object)DBNull.Value : grd_pesca.EditValue);
                cmd.Parameters.AddWithValue("@planta", txtPLantaSenasa.Text == "" ? (object)DBNull.Value : txtPLantaSenasa.Text);
                cmd.Parameters.AddWithValue("@porcentajesustentable", spsustentable.Text == "0" || spsustentable.Text == "" ? (object)DBNull.Value : spsustentable.Text);
                cmd.Parameters.AddWithValue("@paisorigen", grd_origen.EditValue == null ? (object)DBNull.Value : grd_origen.EditValue);
                cmd.Parameters.AddWithValue("@fishsurse", hyfishsource.Text == "" ? (object)DBNull.Value : hyfishsource.Text);
                cmd.Parameters.AddWithValue("@iucn", hyIUCN.Text == "" ? (object)DBNull.Value : hyIUCN.Text);
                cmd.Parameters.AddWithValue("@tipo", grd_tipo.EditValue == null ? (object)DBNull.Value : grd_tipo.EditValue);
                cmd.Parameters.AddWithValue("@user_register", login.Id);
                cmd.ExecuteNonQuery();

                Query = @"sp_insert_trz_criterio_ingreso_empaque";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.Parameters.AddWithValue("@empaque1", rdEmpaque1.EditValue);
                cmd.Parameters.AddWithValue("@empaque2", rdEmpaque2.EditValue);
                cmd.Parameters.AddWithValue("@empaque3", rdEmpaque3.EditValue);
                cmd.Parameters.AddWithValue("@empaque4", rdEmpaque4.EditValue);
                cmd.Parameters.AddWithValue("@aceptado", rdEstadomp.EditValue);
                cmd.Parameters.AddWithValue("@observaciones_mp", txtObseracionesMP.Text);
                cmd.ExecuteNonQuery();

                Query = @"sp_insert_trz_criterio_ingreso_transporte";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.Parameters.AddWithValue("@resp1 ", rdTranporte1.EditValue);
                cmd.Parameters.AddWithValue("@resp2", rdTranporte2.EditValue);
                cmd.Parameters.AddWithValue("@resp3", rdTranporte3.EditValue);
                cmd.Parameters.AddWithValue("@resp4", rdTranporte4.EditValue);
                int conta1 = 1;
                foreach (dsTarima.ultimas_cargasRow row in dsTarima.ultimas_cargas.Rows)
                {
                    switch (conta1)
                    {
                        case 1:
                            cmd.Parameters.AddWithValue("@materia_prima1", row.descripcion);
                            break;
                        case 2:
                            cmd.Parameters.AddWithValue("@materia_prima2", row.descripcion);
                            break;
                        case 3:
                            cmd.Parameters.AddWithValue("@materia_prima3", row.descripcion);
                            break;
                    }
                    conta1++;
                    if (conta1 > 3)
                        break;
                }

                if (conta1 < 4)
                {
                    switch (conta1)
                    {
                        case 1:
                            cmd.Parameters.AddWithValue("@materia_prima1", DBNull.Value);
                            cmd.Parameters.AddWithValue("@materia_prima2", DBNull.Value);
                            cmd.Parameters.AddWithValue("@materia_prima3", DBNull.Value);
                            break;
                        case 2:
                            cmd.Parameters.AddWithValue("@materia_prima2", DBNull.Value);
                            cmd.Parameters.AddWithValue("@materia_prima3", DBNull.Value);
                            break;
                        case 3:
                            cmd.Parameters.AddWithValue("@materia_prima3", DBNull.Value);
                            break;
                    }
                }
                //cmd.Parameters.AddWithValue("@materia_prima1", txtmp1.Text);
                //cmd.Parameters.AddWithValue("@materia_prima2", txtmp2.Text);
                //cmd.Parameters.AddWithValue("@materia_prima3", txtmp3.Text);
                cmd.Parameters.AddWithValue("@observaciones", txtobservacionTras.Text);
                cmd.ExecuteNonQuery();
                cn.Close();

                // Importar archivos adjuntos.

                foreach (dsMantenimientoC.adjuntosRow row in dsMantenimientoC.adjuntos.Rows)
                {
                    if (row.bit_subido)
                    {
                        if (row.path == "")
                        {
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
                            //cmd4.Transaction = transaction;
                            cmd4.CommandType = CommandType.StoredProcedure;

                            cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = row.path_load;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                            cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.file_name;
                            cmd4.Parameters.AddWithValue("@id_config", row.id_conf);
                            cmd4.Parameters.AddWithValue("@id_user", login.Id);
                            cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                            cmd4.Parameters.AddWithValue("@bit_pic", 0);
                            cmd4.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            string FileName = row.file_name;
                            DataOperations dp = new DataOperations();
                            string Path_ = dp.FTP_Tickets_LOSA + row.id_conf + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + row.file_name;
                            if (Upload(Path_, row.path))
                            {
                                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                                con.Open();
                                SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
                                //cmd4.Transaction = transaction;
                                cmd4.CommandType = CommandType.StoredProcedure;

                                cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = Path_;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                                cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.file_name;
                                cmd4.Parameters.AddWithValue("@id_config", row.id_conf);
                                cmd4.Parameters.AddWithValue("@id_user", login.Id);
                                cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                                cmd4.Parameters.AddWithValue("@bit_pic", 0);
                                cmd4.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }


                }

                if (fileNameImagen != "")
                {
                    if (cambioImagen)
                    {
                        string Path_2 = dp.FTP_Tickets_LOSA + "Imagen" + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + fileNameImagen;
                        if (Upload(Path_2, full_pathImagen))
                        {
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
                            //cmd4.Transaction = transaction;
                            cmd4.CommandType = CommandType.StoredProcedure;

                            cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = Path_2;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                            cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = fileNameImagen;
                            cmd4.Parameters.AddWithValue("@id_config", (object)DBNull.Value);
                            cmd4.Parameters.AddWithValue("@id_user", login.Id);
                            cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                            cmd4.Parameters.AddWithValue("@bit_pic", 1);
                            cmd4.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                    {

                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();
                        SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
                        //cmd4.Transaction = transaction;
                        cmd4.CommandType = CommandType.StoredProcedure;

                        cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = full_pathImagen;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                        cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = fileNameImagen;
                        cmd4.Parameters.AddWithValue("@id_config", (object)DBNull.Value);
                        cmd4.Parameters.AddWithValue("@id_user", login.Id);
                        cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                        cmd4.Parameters.AddWithValue("@bit_pic", 1);
                        cmd4.ExecuteNonQuery();
                        con.Close();
                    }
                }

                cn.Open();

                Query = @"sp_update_ingresos_lotes_calidad";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.ExecuteNonQuery();

                cn.Close();
                CajaDialogo.Information("Se ha registrado toda la informacion");
                this.DialogResult = DialogResult.OK;
                this.Close();
                // Update Checked

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }




        }

        private void btnRevisarBoleta_Click(object sender, EventArgs e)
        {

            frmViewBasculaBoleta frm = new frmViewBasculaBoleta(Convert.ToInt32(txtboleta.Text));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnOC_Click(object sender, EventArgs e)
        {
            frmOC_SAP_View frm = new frmOC_SAP_View(Convert.ToInt32(txtoc.Text));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        #region Ruta1
        int rutaActiva = 0;
        private void cmdDespachoIdRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcDespachoRuta2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();
            //frmDetalleDespacho frm = new frmDetalleDespacho(row.Despacho);
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.WindowState = FormWindowState.Normal;
            //frm.Show();

            navigationFrame1.SelectedPage = npRuta3DetalleDespacho;
            rutaActiva = 1;
            LoadDatosDetalleDespacho(row.Despacho);
        }

        private void btnLinkBoletaView__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcDespachoRuta2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();

            Boleta bol1 = new Boleta();
            if (bol1.RecuperarRegistroFromNumBoleta(row.NumID))
            {

                //frmViewBasculaBoleta frm = new frmViewBasculaBoleta(bol1.Id);
                LoadLines(bol1.Id);
                navigationFrame1.SelectedPage = npBoletaView;
                //if (this.MdiParent != null)
                //    frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Normal;
                //frm.Show();
            }
        }


        private void LoadLines(int pIdSerial_)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_data_boleta_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Serie", pIdSerial_);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                DataTable Table_ = new DataTable();
                adat.Fill(Table_);
                this.vGridControl2.DataSource = Table_;
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBackRuta1_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = npRuta2;
        }
        #endregion

        private void btnLinkBoletaView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gcClientesRecibieronLotePT.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();

            Boleta bol1 = new Boleta();
            if (bol1.RecuperarRegistroFromNumBoleta(row.NumID))
            {
                frmViewBasculaBoleta frm = new frmViewBasculaBoleta(bol1.Id);
                //if (this.MdiParent != null)
                //    frm.MdiParent = this.MdiParent;
                //frm.WindowState = FormWindowState.Normal;
                frm.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRuta3Home_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npMain;
            slueCliente.Text = "";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npMain;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar cliente seleccionado
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsCalidad.Direccion_ClientesRow)gridView.GetFocusedDataRow();

            bool deleted = false;
            try
            {
                gridView2.DeleteRow(gridView.FocusedRowHandle);
                deleted = true;
                dsCalidad.Direccion_Clientes.AcceptChanges();
            }
            catch (Exception ec)
            {
                //CajaDialogo.Error(ec.Message);
            }

            if (deleted)
                LoadDataClientes();

        }

        private void LoadDataClientes()
        {
            dsCalidad.DespachadoClientes.Clear();
            try
            {
                DataOperations dp = new DataOperations();
                if (dsCalidad.Direccion_Clientes.Count > 0)
                {
                    foreach (dsCalidad.Direccion_ClientesRow row in dsCalidad.Direccion_Clientes)
                    {
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                        {
                            cnx.Open();

                            SqlDataAdapter da = new SqlDataAdapter("sp_DespachadoClientes_V2", cnx);
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = row.id;

                            //dsCalidad.DespachadoClientes.Clear();

                            da.Fill(dsCalidad.DespachadoClientes);

                            cnx.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdBuscarCliente__Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                foreach(dsCalidad.Direccion_ClientesRow row in frm.dsCalidad1.Direccion_Clientes)
                {
                    if (row.seleccionado)
                    {
                        dsCalidad.Direccion_ClientesRow row1 = dsCalidad.Direccion_Clientes.NewDireccion_ClientesRow();
                        row1.id = row.id;
                        row1.codigo = row.codigo;
                        row1.nombre = row.nombre;
                        row1.codigo_pais = row.codigo_pais;
                        row1.direccion1 = row.direccion1;
                        row1.direccion2 = row.direccion2;
                        row1.ciudad = row.ciudad;
                        row1.pais = row.pais;
                        row1.cliente_aqua = row.cliente_aqua;
                        //dsCompras.oc_d_normalRow row1 = dsCompras.oc_d_normal.Newoc_d_normalRow();
                        //dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
                        dsCalidad.Direccion_Clientes.AddDireccion_ClientesRow(row1);
                        dsCalidad.AcceptChanges();
                        //dsCompras.AcceptChanges();
                    }
                }
                LoadDataClientes();
            }
        }

        private void btnGenerateRuta1_Click(object sender, EventArgs e)
        {
            LoteMP LoteMP_ = new LoteMP();

            if (LoteMP_.RecuperarRegistro(txtLoteMPRuta1.Text))
            {
                if (LoteMP_.CantidadMP > 1)
                {
                    //Mostrar Ventana
                    frmMP_WithSameLot frm = new frmMP_WithSameLot(LoteMP_);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadLotesPT_Ruta1(frm.IdMP_Selected);
                        lblLoteNameRuta1.Text = frm.NameMaterialselected;
                        LoadInventarioLotesRuta1();
                        LoadRegistroIngresosLotesRuta1();
                        lblLoteNameRuta1_Rotulo.Visible = lblLoteNameRuta1.Visible = true;
                        errorProvider1.Clear();
                    }
                }
                else
                {
                    LoadLotesPT_Ruta1(LoteMP_.IdMPSingle);
                    lblLoteNameRuta1.Text = LoteMP_.NombreComercialSingle;
                    LoadInventarioLotesRuta1();
                    LoadRegistroIngresosLotesRuta1();
                    lblLoteNameRuta1_Rotulo.Visible = lblLoteNameRuta1.Visible = true;
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.SetError(txtLoteMPRuta1, "No se encontro ningun PT que haya utilizado este lote!");
                lblLoteNameRuta1_Rotulo.Visible = lblLoteNameRuta1.Visible = false;
            }
        }


        void LoadInventarioLotesRuta1()
        {
            //sp_get_kardex_by_lot_trz
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_kardex_by_lot_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtLoteMPRuta1.Text);
                //cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ.Inventario_mp_lote_ruta1.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.Inventario_mp_lote_ruta1);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        void LoadRegistroIngresosLotesRuta1()
        {
            //sp_get_kardex_by_lot_trz
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_ingresos_lotes_mp_ruta_trz1]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtLoteMPRuta1.Text);
                //cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ.ingresos_mp_lote_ruta1.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.ingresos_mp_lote_ruta1);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnHome_Ruta1_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npMain;
            this.dsReportesTRZ.pt_list_trz.Clear();
        }

        private void btnBorrarRuta1_Click(object sender, EventArgs e)
        {
            txtLoteMPRuta1.Text = "";
            txtLoteMPRuta1.Focus();
        }

        private void cmdExportExcelClientes_lotes_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grDetalle.ExportToXlsx(dialog.FileName);
        }

        private void gvPT_Ruta1_RowClick(object sender, RowClickEventArgs e)
        {
            var gridView = (GridView)gcPT_Ruta1.FocusedView;
            var row = (dsReportesTRZ.pt_list_trzRow)gridView.GetFocusedDataRow();

            if (row.Lote_PT > 0)
                LoadDetalleReproceso_lotePT_Ruta1(row.Lote_PT);
        }

        private void LoadDetalleReproceso_lotePT_Ruta1(int pt_lote)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_detalle_inv_reproces_trz_ruta1]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_pt", pt_lote);
                //cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ.reproceso_lote_pt_ruta1.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ.reproceso_lote_pt_ruta1);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}