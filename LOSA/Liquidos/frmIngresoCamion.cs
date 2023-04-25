using ACS.Classes;
using LOSA.Clases;
using LOSA.RecepcionMP;
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
using System.Linq;
using DevExpress.XtraReports.UI;
using LOSA.Reportes;

namespace LOSA.Liquidos
{
    public partial class frmIngresoCamion : Form
    {
        UserLogin UsuarioLogeado;
        ArrayList pLista;
        DataOperations dp = new DataOperations();
        int idUbicacionSelected;
        string Rack;
        string Codigo_Barra_ubicacion;
        int IdLoteSelected;
        int ingreso;
        int id_tanque;
        decimal factor;
        int Default_value = 0;
        Tanque Tanque;
        bool Istrans = false;
        int id_lote_externo = 0;
        int idSelectedLoteDetalle = 0;
        public frmIngresoCamion(UserLogin pUsuarioLogeado/*, ArrayList pArray,*/, ItemMP_Lote pItem,int pId_Tanque)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadPresentaciones();
            //pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.ItemCode;
            txtMP_Name.Text = pItem.Card_Name;
            id_tanque = pId_Tanque;
            UsuarioLogeado = pUsuarioLogeado;
            Tanque = new Tanque(pId_Tanque);
            Inicializar_Informacion();
            //txtLote.Text = pItem.Lote;
            //IdLoteSelected = pItem.IdLote;
            //LoadBarcos();
            LoadUbicaciones();
            grdUbicaciones.EditValue = id_tanque;
            obtener_ingreso();


            //if (pItem.RecuperarRegistro(pItem.IdLote))
            //{
            //    dtFechaProduccion.EditValue = pItem.FechaProd;
            //    dtFechaVencimiento.EditValue = pItem.FechaVence;
            //}

            ////foreach (dsRecepcionMPx.granelRow rowg in pArray)
            //{
            //    dsRecepcionMPx.granelRow row1 = dsRecepcionMPx1.granel.NewgranelRow();
            //    //row1 = rowg;
            //    //row1.itemcode = item.ItemCode;
            //    //row1.card_name = item.Card_Name;
            //    //pendiente agregar el valor de lote
            //    row1.id = rowg.id;
            //    row1.comentarios = rowg.comentarios;
            //    row1.EmpresaTrans = rowg.EmpresaTrans;
            //    row1.fechaEntra= rowg.fechaEntra;
            //    row1.FechaFin= rowg.FechaFin;

            //    try
            //    {
            //        row1.shipid = rowg.shipid;
            //    }
            //    catch { row1.shipid = 0; }

            //    try
            //    {
            //        row1.barco = rowg.barco;
            //    }
            //    catch { row1.barco = ""; }

            //    row1.NBoleta= rowg.NBoleta;
            //    row1.numero_factura= rowg.numero_factura;
            //    row1.Operador= rowg.Operador;
            //    row1.PesoBruto= rowg.PesoBruto;
            //    row1.PesonetoIn= rowg.PesonetoIn;
            //    row1.PesoProd= rowg.PesoProd;
            //    row1.pesoSalida= rowg.pesoSalida;
            //    row1.peso_factura= rowg.peso_factura;
            //    row1.conductorin= rowg.conductorin;
            //    row1.vehiculo= rowg.vehiculo;
            //    row1.furgon = rowg.furgon;
            //    row1.TipoBoleta = rowg.TipoBoleta;
            //    row1.id_tipo_boleta = rowg.id_tipo_boleta;
            //    row1.SNegocio = rowg.SNegocio;
            //    row1.Producto = rowg.Producto;
            //    row1.itemcode = rowg.itemcode;
            //    row1.seleccionar = rowg.seleccionar;
            //    try
            //    {
            //        row1.id_ubicacion = rowg.id_ubicacion;
            //    }
            //    catch {  }


            //    dsRecepcionMPx1.granel.AddgranelRow(row1);
            //    dsRecepcionMPx1.AcceptChanges();
            //}

        }



        public frmIngresoCamion(UserLogin pUsuarioLogeado, MateriaPrima pItem, int pId_Tanque)
        {
            InitializeComponent();
            LoadPresentaciones();
            UsuarioLogeado = pUsuarioLogeado;
            //pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.CodeMP_SAP;
            txtMP_Name.Text = pItem.Name;
            id_tanque = pId_Tanque;
            UsuarioLogeado = pUsuarioLogeado;
            Tanque = new Tanque(pId_Tanque);
            grdUbicaciones.EditValue = pId_Tanque;
            Inicializar_Informacion();
            //txtLote.Text = pItem.Lote;
            //IdLoteSelected = pItem.IdLote;
            //LoadBarcos();
            LoadUbicaciones();
            obtener_ingreso();

            simpleButton1.Visible = false;

        }

        public frmIngresoCamion(UserLogin pUsuarioLogeado, MateriaPrima pItem, int pId_Tanque, bool istraslado, int id_traslado)
        {
            InitializeComponent();
            LoadPresentaciones();
            Istrans = istraslado;
            id_lote_externo = id_traslado;
            UsuarioLogeado = pUsuarioLogeado;
            //pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.CodeMP_SAP;
            txtMP_Name.Text = pItem.Name;
            id_tanque = pId_Tanque;
            UsuarioLogeado = pUsuarioLogeado;
            Tanque = new Tanque(pId_Tanque);
            grdUbicaciones.EditValue = pId_Tanque;
            Inicializar_Informacion();
            //txtLote.Text = pItem.Lote;
            //IdLoteSelected = pItem.IdLote;
            //LoadBarcos();
            LoadUbicaciones();
            obtener_ingreso(); 



        }
        public void Inicializar_Informacion()
        {
            txtcapacidad.Text = Tanque.MaximoCapacidad.ToString();
            txtEspacioOcupado.Text = Tanque.TotalLleno.ToString();
            txtDisponible.Text = Tanque.VacioCapacidad.ToString();

        }

        public void obtener_ingreso()
        {
            try
            {
                string quer = @"sp_obtener_numero_ingreso_v2";
                SqlConnection cn;
                cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(quer, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                ingreso = Convert.ToInt32(cmd.ExecuteScalar());
                txtingreso.Text = ingreso.ToString();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadUbicaciones()
         {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);

                string SQL = @"dbo.sp_get_lista_ubicaciones_liquidos";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsLiquidos_.Ubicacion_Liquidos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLiquidos_.Ubicacion_Liquidos);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void LoadBarcos()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                //SqlCommand cmd = new SqlCommand("sp_get_ships_active_for_losa", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //dsRecepcionMPx1.barcos.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsRecepcionMPx1.barcos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            //Seleccionar Ubicacion
            //frmUbicaciones_granel frm = new frmUbicaciones_granel();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    int idUbicacionNueva = frm.IdUbicacionSelected;
            //    beNuevaUbicacion.Text = frm.UbicacionCodigo + " - "+ frm.UbicacionNombre;
            //    idUbicacionSelected = idUbicacionNueva;
            //    Rack = frm.UbicacionNombre;
            //    Codigo_Barra_ubicacion = frm.UbicacionCodigo;
            //}
        }


        private void cmdGenerarIngreso_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction;
            if (string.IsNullOrEmpty(dtFechaProduccion.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de producción!");
                return;
            }
            string CodigoProveedor = "";
            string Proveedor = "";

            if (string.IsNullOrEmpty(dtFechaVencimiento.Text))
            {
                CajaDialogo.Error("Es obligatorio llenar la fecha de vencimiento de la materia prima!");
                return;
            }

            if (gridView1.RowCount<1)
            {
                CajaDialogo.Error("Ingrese registros de boletas");
                return;
            }

            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("Ingrese el lote");
                return;
            }


            foreach (var item in dsLiquidos_.Camiones_IN)
            {
                if (item.fecha_produccion == null)
                {
                    CajaDialogo.Error("Ingrese la fecha de producción a los registros");
                    return;
                }
            }


            foreach (var item in dsLiquidos_.Camiones_IN)
            {
                if (item.fecha_vencimiento == null)
                {
                    CajaDialogo.Error("Ingrese la fecha de vencimiento a los registros");
                    return;
                }
            }

            bool PuedeContinuar = false;
            foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
            {

                try
                {
                    int a = row.id_ubicacion;
                    if (a > 0)
                        PuedeContinuar = true;

                }
                catch
                {
                    PuedeContinuar = false;
                    break;
                }
            }

            if (!PuedeContinuar)
            {
                CajaDialogo.Error("Debe seleccionar una ubicacion valida!");
                return;
            }

            PuedeContinuar = false;


            SqlConnection cn;
            SqlCommand cmd;

            cn = new SqlConnection(dp.ConnectionStringLOSA);

            cn.Open();

            transaction = cn.BeginTransaction();

            if (chnuevoIngreso.Checked)
            {
                string quer = @"sp_updata_numero_ingreso_tables_id";
                cmd = new SqlCommand(quer, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
            }
            else
            {

                if (txtingreso.Text == "")
                {
                    CajaDialogo.Error("No tiene un ingreso seleccionado para poder ligar. Debe seleccionar uno antes de crear los documentos.");
                    return;
                }
                ingreso = Convert.ToInt32(txtingreso.Text);
            }                                   

            bool Guardo = false;
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar estos ingresos de Materia Prima Líquidos?");
            if (r != DialogResult.Yes)
                return;

            decimal sumar_Kg = 0;

            foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
            {
                sumar_Kg = sumar_Kg + row.PesoProd;

            }
            string query = @"[dbo].[sp_insert_ingreso_mp_h_liquidos_mp_loteV2]";
            if (Istrans)
            {

            }
            else
            {
                query = "[sp_insert_ingreso_mp_h_liquidos_compra_loteV2]";
            }

            SqlCommand Comnd = new SqlCommand(query, transaction.Connection);
            Comnd.CommandType = CommandType.StoredProcedure;
            Comnd.Transaction = transaction;

            Comnd.Parameters.AddWithValue("@entrada", sumar_Kg);
            Comnd.Parameters.AddWithValue("@lote", txtLote.Text);
            Comnd.Parameters.AddWithValue("@id_ingreso", ingreso);
            Comnd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
            Comnd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
            Comnd.Parameters.AddWithValue("@count_trailetas", dsLiquidos_.Camiones_IN.Count);
            foreach (dsLiquidos_.Camiones_INRow item in dsLiquidos_.Camiones_IN.Rows)
            {
                Comnd.Parameters.AddWithValue("@cardcode", item.cardcode);
                Comnd.Parameters.AddWithValue("@cardname", item.cardname);
            }

            if (!Istrans)
            {
                Comnd.Parameters.AddWithValue("@Id_Externo", id_lote_externo);
            }
            Comnd.Parameters.AddWithValue("@fecha_produccion", dtFechaProduccion.EditValue);
            Comnd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);

            int Id_lote_generado = Convert.ToInt32(Comnd.ExecuteScalar());

            foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
            {
                //
                try
                {
                    CodigoProveedor = row.cardcode;
                    Proveedor = row.cardname;
                    DataOperations dp = new DataOperations();
                    //cn = new SqlConnection(dp.ConnectionStringLOSA);
                    //cn.Open();

                    string SQL = @"[dbo].[sp_set_insert_ingreso_liquidos]";
                    SqlCommand cmd2 = new SqlCommand(SQL, transaction.Connection);
                    cmd2.Transaction = transaction;

                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id_boleta", row.id);
                    cmd2.Parameters.AddWithValue("@entrada", row.PesoProd);
                    cmd2.Parameters.AddWithValue("@item_code", row.itemcode);
                    cmd2.Parameters.AddWithValue("@lote", txtLote.Text);
                    cmd2.Parameters.AddWithValue("@id_lote", IdLoteSelected);
                    cmd2.Parameters.AddWithValue("@id", row.id);
                    cmd2.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);
                    cmd2.Parameters.AddWithValue("@id_ingreso", ingreso);
                    cmd2.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    cmd2.Parameters.AddWithValue("@id_lote_alosy", Id_lote_generado);
                    cmd2.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                    cmd2.Parameters.AddWithValue("@fecha_produccion", dtFechaProduccion.EditValue);
                    cmd2.Parameters.AddWithValue("@id_tanque", id_tanque);
                    cmd2.Parameters.AddWithValue("@cardcode", row.cardcode);
                    cmd2.Parameters.AddWithValue("@cardname", row.cardname);

                    cmd2.ExecuteNonQuery();

                    
                    Guardo = true;
                    //cn.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            try
            {
                string SQL = @"[dbo].[sp_insert_into_the_tank_v2]";
                SqlCommand cmd2 = new SqlCommand(SQL, transaction.Connection);
                cmd2.Transaction = transaction;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@id_lote_ingreso", Id_lote_generado);
                cmd2.Parameters.AddWithValue("@entrada", txtAltanque.Text);
                cmd2.Parameters.AddWithValue("@id_tanque", id_tanque);
                cmd2.Parameters.AddWithValue("@salida", 0);
                cmd2.Parameters.AddWithValue("@id_tarima", DBNull.Value);
                cmd2.Parameters.AddWithValue("@date_ingreso", dp.Now());
                cmd2.Parameters.AddWithValue("@lote", txtLote.Text);
                cmd2.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                cmd2.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                cmd2.ExecuteNonQuery();

                int vid_tarima = Default_value;
                ArrayList List = new ArrayList();
                if (Convert.ToInt32(txtCantidaddeTarimas.Text) != 0)
                {
                    for (int i = 1; i <= Convert.ToInt32(txtCantidaddeTarimas.Text); i++)
                    {
                        
                            DataOperations dp = new DataOperations();

                            SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", transaction.Connection);
                            cmm.CommandType = CommandType.StoredProcedure;
                            cmm.Parameters.AddWithValue("@id", 1);
                            string barcode = cmm.ExecuteScalar().ToString();

                            cmd = new SqlCommand("sp_insert_new_tarima_for__liqud", transaction.Connection);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@itemcode", txtCodigoMP.Text);
                            cmd.Parameters.AddWithValue("@id_proveedor", CodigoProveedor);
                            cmd.Parameters.AddWithValue("@fecha_ingreso", dtFechaIngreso.EditValue);
                            cmd.Parameters.AddWithValue("@numero_transaccion", ingreso);
                            cmd.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.EditValue);
                            cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", dtFechaProduccion.EditValue);
                            cmd.Parameters.AddWithValue("@lote_materia_prima", txtLote.Text);
                            cmd.Parameters.AddWithValue("@id_presentacion", grd_presentaciones.EditValue);
                            cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@id_boleta", DBNull.Value);
                            cmd.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmd.Parameters.AddWithValue("@cant", txtUdporTarima.Text);
                            cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPesoKg.Text));
                            cmd.Parameters.AddWithValue("@idlotes", Id_lote_generado);
                            cmd.Parameters.AddWithValue("@factor", factor);
                            cmd.Parameters.AddWithValue("@bit_promedio",  0);
                             vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

                            SqlCommand cmdx = new SqlCommand("sp_insert_ubicacion_default", transaction.Connection);// ahora recibe el parametro de ubicacion para poder guardarlo automatico en todas las tarimas
                            cmdx.CommandType = CommandType.StoredProcedure;
                            cmdx.Parameters.AddWithValue("@id_tarima", vid_tarima);
                            cmdx.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                            cmdx.Parameters.AddWithValue("@codigo_barra", barcode);
                            cmdx.Parameters.AddWithValue("@id_ubicacion", 131); //bodega c500 predeterminada
                            cmdx.ExecuteNonQuery();

                            List.Add(vid_tarima);

                            Guardo = true;
                       
                         
                    }
                    Guardo = true;
                    if (CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?") == DialogResult.Yes)
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
                    rptLoteRotulo boleta = new rptLoteRotulo(Id_lote_generado);
                    boleta.ShowPrintMarginsWarning = false;
                    boleta.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    boleta.Print();
                    //CajaDialogo.InformationAuto();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }   

            if (Guardo)
            {
                transaction.Commit();
                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                transaction.Rollback();
            }


        }

        private void grdbarco_EditValueChanged(object sender, EventArgs e)
        {
            //int idbarco = Convert.ToInt32(grdbarco.EditValue);
            //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            //{
            //    row.shipid = idbarco;
            //}
            //dsRecepcionMPx1.granel.AcceptChanges();
        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void grdUbicaciones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              
                int idUbicaciones = Convert.ToInt32(grdUbicaciones.EditValue);
                foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
                {
                    row.id_ubicacion = idUbicaciones;
                }

                dsLiquidos_.Camiones_IN.AcceptChanges();
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void chnuevoIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chnuevoIngreso.Checked)
            {
               
                btningreso.Visible = false;
                obtener_ingreso();

            }
            else
            {
              
                btningreso.Visible = true;
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
             frm_select_numero_liquidos frm = new frm_select_numero_liquidos();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtingreso.Text = frm.Ingreso.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            xfrm_select_camiones frm = new xfrm_select_camiones(txtCodigoMP.Text);
     
            if (frm.ShowDialog()== DialogResult.OK)
            {
                var CamionesSeleccionados = from Camion in dsLiquidos_.Camiones_IN.AsEnumerable()
                                                    select Camion.id;

                var PermitidosParaAgregar = from CamionPermitido in frm.camiones
                                            where (!CamionesSeleccionados.Contains(CamionPermitido.ID))
                                            select CamionPermitido;

                foreach (var item in PermitidosParaAgregar)
                {

                   gridView1.AddNewRow();
                    var row = (dsLiquidos_.Camiones_INRow)gridView1.GetFocusedDataRow();
                    //DataTable dt = gridControl1.DataSource as DataTable;

                    ////DataRow row = dt.NewRow();
                    //item.
                    ////int d = gridView1.new NewItemRowHandle;
                    ////var row1=(dsLiquidos_.Camiones_INRow)gridView1.GetFocusedDataRow();


                    ////row1 = rowg;
                    row.itemcode = item.ItemCode;
                    ////row1.card_name = item.Card_Name;
                    ////pendiente agregar el valor de lote
                    row.id = item.ID;
                    row.comentarios = item.Comentarios;
                    row.empresaTrans = item.EmpresaTransporte;
                    row.fechaEntra = item.FechaEntra;
                    //row1.FechaFin = rowg.FechaFin;

                    //try
                    //{
                    //    row1.shipid = rowg.shipid;
                    //}
                    //catch { row1.shipid = 0; }

                    //try
                    //{
                    //    row1.barco = rowg.barco;
                    //}
                    //catch { row1.barco = ""; }

                    row.NBoleta = item.Nboleta;
                    //row1.numero_factura = rowg.numero_factura;
                    //row1.Operador = rowg.Operador;
                    row.PesoBruto = item.PesoBruto;
                    row.PesonetoIn = item.PesoNetoIN;
                    row.PesoProd = item.PesoProd;
                    row.pesoSalida = item.PesoSalida;
                    row.peso_factura = item.PesoFactura;
                    //row1.conductorin = rowg.conductorin;
                    //row1.vehiculo = rowg.vehiculo;
                    //row1.furgon = rowg.furgon;
                    //row1.TipoBoleta = rowg.TipoBoleta;
                    //row1.id_tipo_boleta = rowg.id_tipo_boleta;
                    row.SNegocio = item.SNegocio;
                    row.Producto = item.Producto;
                    row.cardcode = item.CardCode;
                    row.cardname = item.CardName;
                    row.itemcode = item.ItemCode;
                    row.fecha_produccion = DateTime.Now;
                    row.fecha_vencimiento = DateTime.Now;
                    //row1.seleccionar = rowg.seleccionar;
                    //try
                    //{
                    //    row1.id_ubicacion = rowg.id_ubicacion;
                    //}
                    //catch { }
                    dsLiquidos_.Camiones_IN.AddCamiones_INRow(row);
                    dsLiquidos_.AcceptChanges();
                    //dsRecepcionMPx1.granel.AddgranelRow(row1);
                    //dsRecepcionMPx1.AcceptChanges();
                }
                Calcular_Ingreso();


            }
        }

        public decimal SumarSeleccionado()
        {
            return dsLiquidos_.Camiones_IN.Sum(x => x.PesoProd);
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Calcular_Ingreso()
        {
            decimal SumaTotal = SumarSeleccionado();
            decimal ParaEltanque = Default_value;
            decimal ParaBines = Default_value;
            //if (Tanque.TotalLleno + SumaTotal >= Tanque.MaximoCapacidad)
            //{
            //    grupoTarima.Enabled = true;
            //    pnTarimas.Enabled = true;
            //    ParaBines = SumaTotal - Tanque.VacioCapacidad;
            //    ParaEltanque = Tanque.VacioCapacidad;
            //    txtAltanque.Text = ParaEltanque.ToString();
            //    txtEnTarimas.Text = ParaBines.ToString();
            //    txtTotalIngreso.Text = SumaTotal.ToString();
            //    grd_presentaciones.EditValue = 8;
            //}
            //else
            //{
            //    ParaEltanque = SumaTotal;
            //    pnTarimas.Enabled = false;
            //    txtAltanque.Text = ParaEltanque.ToString();
            //    txtEnTarimas.Text = ParaBines.ToString();
            //    txtTotalIngreso.Text = SumaTotal.ToString();
            //    txtDisponibleConIngresoActual.Text = Convert.ToString(Convert.ToDecimal(txtcapacidad.Text) - (Convert.ToDecimal(txtEspacioOcupado.Text) + Convert.ToDecimal(txtAltanque.Text)));
            //}

            //Siempre dejaremos la opcion de agregar tarimas
            ParaBines = SumaTotal - Tanque.VacioCapacidad;
            ParaEltanque = Tanque.VacioCapacidad;
            txtAltanque.Text = ParaEltanque.ToString();
            txtEnTarimas.Text = ParaBines.ToString();
            txtTotalIngreso.Text = SumaTotal.ToString();
            grd_presentaciones.EditValue = 8;

            try
            {
                if (Convert.ToDecimal(txtAltanque.Text) != 0)
                {
                    calculoTarimas();
                }
            }
            catch (Exception)
            {

               
            }

        }
        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas_onli_liquidos", con);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsLiquidos_.Camiones_IN.AcceptChanges();
                Calcular_Ingreso();


            }
            catch (Exception ex)
            {

            }
        }

        private void txtUdporTarima_KeyPress(object sender, KeyPressEventArgs e)
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
        public void calculoTarimas()
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(grd_presentaciones.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUdporTarima.Text)));
                decimal TarimasCalculo = Default_value;
                TarimasCalculo = Convert.ToDecimal(txtEnTarimas.Text) / Convert.ToDecimal(txtPesoKg.Text);
                int TotalTarimas = Convert.ToInt32(TarimasCalculo);
                TotalTarimas = TarimasCalculo > TotalTarimas ? TotalTarimas++ : TotalTarimas;
                txtCantidaddeTarimas.Text = TotalTarimas.ToString();
            }
        }

        private void grd_presentaciones_EditValueChanged(object sender, EventArgs e)
        {
            PresentacionX pre1 = new PresentacionX();
            if (pre1.RecuperarRegistro(Convert.ToInt32(grd_presentaciones.EditValue)))
            {
                factor = pre1.Factor;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUdporTarima.Text)));
                decimal TarimasCalculo = Default_value;
                TarimasCalculo =  Convert.ToDecimal(txtEnTarimas.Text) / Convert.ToDecimal(txtPesoKg.Text);
                int TotalTarimas = Convert.ToInt32(TarimasCalculo);
                TotalTarimas = TarimasCalculo > TotalTarimas ? TotalTarimas++ : TotalTarimas; 
                txtCantidaddeTarimas.Text = TotalTarimas.ToString();
            }
        }

        private void txtUdporTarima_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal TarimasCalculo = Default_value;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", (factor * Convert.ToDecimal(txtUdporTarima.Text)));
                TarimasCalculo = Convert.ToDecimal(txtEnTarimas.Text) / Convert.ToDecimal(txtPesoKg.Text);
                int TotalTarimas = Convert.ToInt32(TarimasCalculo);
                TotalTarimas = TarimasCalculo > TotalTarimas ? TotalTarimas++ : TotalTarimas;
                txtCantidaddeTarimas.Text = TotalTarimas.ToString();
            }
            catch
            {
                txtPesoKg.Text = "0";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmSeleccionrLoteExterno frm = new frmSeleccionrLoteExterno(id_lote_externo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtLote.Text = frm.lote;
                txtCodigoMP.Text = frm.Itemcode;
                txtMP_Name.Text = frm.Itemname;
                dtFechaProduccion.EditValue = frm.fproduccion;
                dtFechaVencimiento.EditValue = frm.fvencimiento;
                idSelectedLoteDetalle = frm.id_lote_externo;
            }
        }

        private void txtCantidaddeTarimas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calcular_Ingreso();
        }
    }
}
