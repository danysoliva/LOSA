using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Calidad.LoteConfConsumo;
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
using ACS.Classes;
using LOSA.Finanzas;
using static LOSA.Accesos.AccesosUsuarios.AccesoUsuario;
using DevExpress.CodeParser;
using Microsoft.VisualBasic;
using static LOSA.Clases.BinGranel;
//using SAPbobsCOM;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using LOSA.Utileria;
using DevExpress.Utils;
using System.IO;
using DevExpress.Office.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils.CommonDialogs;
using System.Diagnostics;

namespace LOSA.Compras
{
    public partial class frmOrdenesCompraMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        TipoOperacion tipooperacion;
        int IdOrdenCompraActual, IdExoneracionVigente = 0;
        int IdEstadoOrdenCompra;
        int IdSolicitud = 0;
        string direccion;
        int ContactCode;
        char CurSource;
        decimal TasaCambio;
        bool EdicionEspecialActiva = false;
        
        public enum TipoOperacion
        {
            New = 1,
            Update = 2,
            View = 3
        }

        public frmOrdenesCompraMain(TipoOperacion ptipo, int pIdOrdenCompraH)
        {
            InitializeComponent();
            LoadTipoOrden();
            TsExoOIsv.IsOn = true;
            ObtenerExoneracionVigente();
            CargarCapitulos();
            CargarIVA();
            CargarTiposDocumentos();
            CargarBodegas();
            CargarRutasAprobacion();
            //CargarArchivos();
            cbxMoneda.Text = "Moneda local";
            //UsuarioLogueado = pUserLog;
            tipooperacion = ptipo;
            IdOrdenCompraActual = pIdOrdenCompraH;
            //TasaCambio = GetTasaCambio();

            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    break;
                case TipoOperacion.Update:
                    break;
                case TipoOperacion.View:
                    CargarInfoOrden(IdOrdenCompraActual);
                    SoloVista(IdOrdenCompraActual);
                    CargarArchivos();
                    break;
                default:
                    break;
            }
        }

        private void CargarTiposDocumentos()
        {
            try
            {
                string query = @"sp_compras_get_tipos_documentos_archivos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.tipo_docs.Clear();
                adat.Fill(dsCompras1.tipo_docs);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void SoloVista(int pIdOrdenCompraActual)
        {
            cmdBuscar.Enabled = false;
            cmdAnterior.Enabled = false;
            cmdSiguiente.Enabled = false;
            btnPrint.Enabled = true;
            cmdNuevo.Enabled = false;
            cmdGuardar.Enabled = false;
            txtNumAtCard.Enabled = false;
            btnCopiarDe.Enabled = true;
            cmdAddDetalle.Enabled = false;
            txtCodProv.Enabled = false;
            dtFechaContabilizacion.Enabled = false;
            grdTipoOrden.Enabled = false;
            TsExoOIsv.ReadOnly = true;
            glRutaAprobacionOC.Enabled = false;
            comboBoxIntercom.Enabled = false;
            comboBoxIntercom.Enabled = false;

            //Bloqueo Grid -- Archivos
            gvFiles.OptionsMenu.EnableColumnMenu = false;
            gvFiles.Columns["eliminar"].Visible = false;
            cmdGuardarArchivos.Enabled = false;

            //Bloqueo en Grid
            grdvDetalle.OptionsMenu.EnableColumnMenu = true;
            grdvDetalle.OptionsBehavior.Editable = false;
            grdvDetalle.Columns["eliminar"].Visible = false;
            //grdvDetalle.Columns["capitulo"].ColumnEdit.ReadOnly = true;
            //grdvDetalle.Columns["partida_arancelaria"].ColumnEdit.ReadOnly = true; 
            //grdvDetalle.Columns["Descripcion de Articulo"].ColumnEdit.ReadOnly = true;
            //grdvDetalle.Columns["cantidad"].ColumnEdit.ReadOnly = true;
            //grdvDetalle.Columns["precio_por_unidad"].ColumnEdit.ReadOnly = true;
            //grdvDetalle.Columns["indicador_impuesto"].ColumnEdit.ReadOnly = true;
            //grdvDetalle.Columns["bodega"].ColumnEdit.ReadOnly = true;
            txtComentarios.Enabled = false;
            btnPresupuesto.Enabled = false;
            tipooperacion = TipoOperacion.View;

        }

        public frmOrdenesCompraMain(UserLogin pUserLog, TipoOperacion ptipo)
        {
            InitializeComponent();
            LoadTipoOrden();
            TsExoOIsv.IsOn = true;
            ObtenerExoneracionVigente();
            CargarCapitulos();
            CargarTiposDocumentos();
            CargarIVA();
            CargarBodegas();
            CargarRutasAprobacion();
            cbxMoneda.Text = "Moneda local";
            UsuarioLogueado = pUserLog;
            tipooperacion = ptipo;
            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    txtUsuarioCreador.Text = UsuarioLogueado.NombreUser;
                    txtDocNum.Text = "0";
                    txtEstado.Text = "Pendiente (Creada)";
                    cmdNuevo.Enabled = false;
                    dtFechaContabilizacion.EditValue = dp.dNow();
                    break;
                case TipoOperacion.Update:
                    break;

                case TipoOperacion.View:
                    CargarInfoOrden(IdOrdenCompraActual);
                    SoloVista(IdOrdenCompraActual);

                    break;
                default:
                    break;
            }

            ValidarAccesosSegunUsuario();
            btnPrint.Enabled = true;
            //btnShowPopu.Enabled = true;
            btnCopiarDe.Enabled = true;
        }

        private void CargarBodegas()
        {
            try
            {
                string query = @"CM_sp_get_all_bodegas";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.bodegas.Clear();
                adat.Fill(dsCompras1.bodegas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarRutasAprobacion()
        {
            try
            {
                string query = @"CM_get_rutas_aprobacion";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.rutas_aprobacion.Clear();
                adat.Fill(dsCompras1.rutas_aprobacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarIVA()
        {
            try
            {
                string query = @"CM_sp_get_IVA";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.iva.Clear();
                adat.Fill(dsCompras1.iva);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarCapitulos()
        {
            try
            {
                string query = @"[sp_cm_orden_compra_capitulos_codigos]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.capitulos.Clear();
                adat.Fill(dsExoneracion1.capitulos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadTipoOrden()
        {
            string query = @"CM_sp_tipo_ordenes_compra";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.tipo_orden.Clear();
                adat.Fill(dsCompras1.tipo_orden);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ValidarAccesosSegunUsuario()
        {
            int i = Convert.ToInt32(UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo);

            switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Administradores:
                    lblSucursal.Enabled = true;
                    break;
                case GrupoUser.GrupoUsuario.Contabilidad:

                    //lblSucursal.Visible = false;
                    break;
                case GrupoUser.GrupoUsuario.Compras:
                    //lblSucursal.Visible = false;
                    break;
                default:
                    break;
            }

        }


        private void txtCodProv_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BuscarProveedor();
           
        }

        private void BuscarProveedor()
        {
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.Proveedores);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodProv.Text = frm.ItemSeleccionado.ItemCode;
               
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroWithRTN(frm.ItemSeleccionado.ItemCode);
                txtProveedor.Text = prov.Nombre;
                direccion = prov.Direccion;
                txtDireccion.Text = direccion;
                txtContactoPerson.Text = prov.ContactName;
                txtMoneda.Text = prov.Moneda;
                ContactCode = prov.ContactCode;
                
                if (txtMoneda.Text == "USD")
                {
                    //TasaCambioActual();
                    GetTasaCambio();
                    txtTasaCambio.Visible = true;
                    cbxMoneda.Text = "Moneda SN";
                }
                else
                {
                    GetTasaCambio();
                    cbxMoneda.Text = "Moneda local";
                    txtTasaCambio.Visible = false;
                }

                cmdNuevo.Enabled = true;
                //btnShowPopu.Enabled = true;
                btnCopiarDe.Enabled = true;
            }
        }

        private void TasaCambioActual()
        {
            bool ExisteTasa = true;
            string Mensaje = "";

            try
            {
                string query = @"CM_get_tasa_cambio";

                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_conta", dtFechaContabilizacion.EditValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ExisteTasa = dr.GetBoolean(0);
                    txtTasaCambio.EditValue = dr.GetDecimal(1);
                }
                dr.Close();
                conn.Close();

                if (ExisteTasa == false)
                {
                    Mensaje = "No se a Definido la Tasa de Cambio de este dia!\nContacte al Dpto. de Finanzas";
                    CajaDialogo.Error(Mensaje);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnShowPopu_Click(object sender, EventArgs e)
        {

        }

        private void CargarOrdenCompraFromSolicitud(int idSolicitudSeleccionado)
        {
            try
            {
                //Encabezado Tabla OPRQ
                SolicitudesCompraSAP soliSAP = new SolicitudesCompraSAP();
                soliSAP.RecuperarInfoHeaderSolicitud(idSolicitudSeleccionado);
                grdTipoOrden.EditValue = soliSAP.TipoOrden;
                txtComentarios.Text = soliSAP.Comentarios;

                //Detalle PRQ1
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmdD = new SqlCommand("sp_CM_get_detalle_solicitud_for_docnum", conn);
                cmdD.CommandType = CommandType.StoredProcedure;
                cmdD.Parameters.AddWithValue("@DocNum", idSolicitudSeleccionado);
                SqlDataReader dr = cmdD.ExecuteReader();
                dsCompras1.oc_detalle_exonerada.Clear();
                while (dr.Read())
                {
                    DataRow row = dsCompras1.oc_detalle_exonerada.NewRow();
                    row[0] = 0;
                    row[1] = 0;
                    row[2] = " ";//Capitulo
                    row[3] = " "; //Partida
                    row[4] = dr.GetString(0); //ItemCode
                    row[5] = dr.GetString(1); //DescripcionArticulo
                    row[6] = dr.GetDecimal(2); //Cantidad
                    row[7] = dr.GetDecimal(3); //PrecioPorUnidad
                    if (TsExoOIsv.IsOn)
                        row[8] = "EXO";
                    else
                        row[8] = "ISO";
                    row[12] = 0.00;
                    row[9] = dr.GetString(4); //Almacen
                    row[10] = 0.00; //Total
                    row[11] = dr.GetInt32(5); //BaseRef - Id de solicitud de compra
                    row[12] = 0.00; //ISV
                    row[13] = dr.GetInt32(6);//LienNum - Linea base
                    dsCompras1.oc_detalle_exonerada.Rows.Add(row);
                }
                //SqlDataAdapter adat = new SqlDataAdapter(cmdD);
                //dsCompras1.oc_detalle_exonerada.Clear();
                //adat.Fill(dsCompras1.oc_detalle_exonerada);
                conn.Close();

                CalcularTotal();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDetalleOrdenCompra(int idSolicitudSeleccionado, int TipoUso)
        {
            CargarPartidasArancelarias();
            try
            {
                string query = @"[sp_get_compras_ordenes_detalleV3]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", idSolicitudSeleccionado);
                cmd.Parameters.AddWithValue("@TipoUso", TipoUso);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle_exonerada.Clear();
                adat.Fill(dsCompras1.oc_detalle_exonerada);
                conn.Close();

                switch (tipooperacion)
                {
                    case TipoOperacion.New:
                        CalcularTotal();
                        break;
                    case TipoOperacion.Update:
                        CalcularTotal();
                        break;
                    case TipoOperacion.View:
                        //CalcularTotal();
                        break;
                    default:
                        CalcularTotal();
                        break;
                }

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void ReCalculoImpuesto()
        {
            decimal impuesto = 0;
            foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
            {
                impuesto += item.isv;
            }

            txtImpuesto.EditValue = string.Format("{0:##,###,##0.##}", impuesto);
        }

        private void grdvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalle_exoneradaRow)gridView.GetFocusedDataRow();

            try
            {
                switch (e.Column.FieldName)
                {
                    case "cantidad":

                        row.total = row.cantidad * row.precio_por_unidad;
                        if (TsExoOIsv.IsOn)//Exonerada
                            row.isv = 0;
                        else
                            row.isv = (row.cantidad * row.precio_por_unidad) * Convert.ToDecimal(0.15);

                        //row.total += row.isv;
                        CalcularTotal();
                        break;
                    case "precio_por_unidad":

                        row.total = row.cantidad * row.precio_por_unidad;
                        if (TsExoOIsv.IsOn)//Exonerada
                            row.isv = 0;
                        else
                            row.isv = (row.cantidad * row.precio_por_unidad) * Convert.ToDecimal(0.15);

                        //row.total += row.isv;
                        CalcularTotal();
                        break;
                    case "capitulo":
                        var gridview = (GridView)grDetalle.FocusedView;
                        //var row = (dsExoneracion.capitulosRow)gridview.GetFocusedDataRow();
                        var rowz = (dsCompras.oc_detalle_exoneradaRow)gridview.GetFocusedDataRow();

                        if (!rowz.IscapituloNull())
                        {
                            CargarPartidasArancelarias(rowz.capitulo);
                        }
                        else
                        {
                            //string a = row.capitulo;
                        }
                        break;

                    //case "indicador_impuesto": //EXO EXE ISV

                    //    var gridviewiva = (GridView)grDetalle.FocusedView;
                    //    var rowiva = (dsCompras.oc_detalle_exoneradaRow)gridviewiva.GetFocusedDataRow();
                    //    string valor_ = row.indicador_impuesto;
                    //    switch (rowiva.indicador_impuesto)
                    //    {
                    //        case "EXE"://EXENTO

                    //            rowiva.isv = 0;
                    //            //txtImpuesto.EditValue = 0.00;
                    //            ReCalculoImpuesto();
                    //            CalcularTotal();
                                
                    //            break;

                    //        case "EXO":

                    //            rowiva.isv = 0;
                    //            CalcularTotal();

                    //            break;

                    //        case "ISV"://0.15

                    //            rowiva.isv = rowiva.total * 0.15M;
                    //            string.Format("{0:0,0.00}", rowiva.isv);
                    //            rowiva.capitulo = " ";
                    //            rowiva.partida_arancelaria = " ";
                    //            ReCalculoImpuesto();
                    //            CalcularTotal();

                    //            break;

                    //        case "ISVE"://0.18

                    //            rowiva.isv = rowiva.total * 0.18M;
                    //            string.Format("{0:0,0.00}", rowiva.isv);
                    //            rowiva.capitulo = " ";
                    //            rowiva.partida_arancelaria = " ";
                    //            ReCalculoImpuesto();
                    //            CalcularTotal();

                    //            break;
                    //    }

                    //    break;

                }

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAddDetalle_Click(object sender, EventArgs e)
        {
            if (TsExoOIsv.IsOn) //Es Exonerado!
            {

                frmAddNewItemOC frm = new frmAddNewItemOC();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool Agregar = true;

                    //foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada.Rows)
                    //{
                    //    if (item.itemcode == frm.ItemCode)
                    //    {
                    //        item.cantidad = item.cantidad + 1;
                    //        Agregar = false;
                    //    }

                    //}

                    if (frm.Partida.Length > 0)
                    {
                        CargarPartidasArancelarias(frm.Capitulo);
                    }

                    if (Agregar)
                    {
                        ItemsSAP items = new ItemsSAP();
                        items.RecuperarRegistroItemSAP(frm.ItemCode);

                        DataRow dr = dsCompras1.oc_detalle_exonerada.NewRow();
                        dr[0] = 0;
                        dr[1] = 0;
                        dr[2] = frm.Capitulo;
                        dr[3] = frm.Partida;
                        dr[4] = items.ItemCode;
                        dr[5] = items.DescripcionArticulo;
                        dr[6] = frm.Unidades; //Cantidad
                        dr[7] = string.Format("{0:###,##0.00}", frm.PrecioUnitario); //Precio por Unidad
                        dr[8] = frm.CodeISV;
                        dr[9] = items.Bodega;
                        dr[10] = string.Format("{0:###,##0.00}", frm.Total); //Total
                        dr[11] = 0;
                        dr[12] = 0.00; //ISV
                        dr[13] = 0; //Linea Base

                        dsCompras1.oc_detalle_exonerada.Rows.Add(dr);
                    }

                }
            }
            else
            {
                frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.Items);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool Agregar = true;

                    //foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada.Rows)
                    //{
                    //    if (item.itemcode == frm.ItemSeleccionado.ItemCode)
                    //    {
                    //        item.cantidad = item.cantidad + 1;
                    //        Agregar = false;
                    //    }


                    //}

                    if (Agregar)
                    {
                        ItemsSAP items = new ItemsSAP();
                        items.RecuperarRegistroItemSAP(frm.ItemSeleccionado.ItemCode);

                        DataRow dr = dsCompras1.oc_detalle_exonerada.NewRow();
                        dr[0] = 0; //IdDetalleOrden
                        dr[1] = 0; //IdHeaderOrden
                        dr[2] = " ";
                        dr[3] = " ";
                        dr[4] = items.ItemCode;
                        dr[5] = items.DescripcionArticulo;
                        dr[6] = 1; //Cantidad
                        dr[7] = 0; //Precio por Unidad
                        dr[8] = "ISV";
                        dr[9] = items.Bodega;
                        dr[10] = 0; //Total
                        dr[11] = 0;
                        dr[12] = 0.00;
                        dr[13] = 0; //Linea Base
                        dsCompras1.oc_detalle_exonerada.Rows.Add(dr);
                    }

                }
            }

            CalcularTotal();

        }

        private void ButtonDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {


            bool Proceder = false;
            if (EdicionEspecialActiva)
            {
                Proceder = true;
            }
            else
            {
                switch (IdEstadoOrdenCompra)
                {
                    case 1://Pendiente de Aprobacion
                        Proceder = false;
                        break;

                    case 2://Autorizado
                        CajaDialogo.Error("No se pueden realizar modificaciones en una Orden de Compra ya Autorizada!");
                        Proceder = false;
                        break;

                    case 3://Rechazado
                        CajaDialogo.Error("No se pueden realizar modificaciones en una Orden de Compra ya Rechazada!");
                        Proceder = false;
                        break;

                    case 5://Creada (Borrador)
                        Proceder = true;
                        break;

                    default:
                        Proceder = true;
                        break;
                }

            }

            var grdvDetalle = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalle_exoneradaRow)grdvDetalle.GetFocusedDataRow();

            if (Proceder)
            {
                DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
                if (r != DialogResult.Yes)
                {
                    return;
                }

                if (row.id_d_orden > 0 || string.IsNullOrEmpty(row.id_d_orden.ToString()))
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_cm_delete_linea_detalle", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalle_oc", row.id_d_orden);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                        cmd.ExecuteNonQuery();

                        grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                        dsCompras1.AcceptChanges();
                        CalcularTotal();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        grdvDetalle.DeleteRow(grdvDetalle.FocusedRowHandle);
                        dsCompras1.AcceptChanges();
                        CalcularTotal();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }
        }

        private void CalcularTotal()
        {
            decimal SubTotal = 0;
            decimal valor_impuesto = 0;
            string TipoISV = "";
            double isv15 = 0.15;

            if (TsExoOIsv.IsOn == true) //Si, Exonerado
            {
                var gridview = (GridView)grDetalle.FocusedView;
                for (int i = 0; i < gridview.DataRowCount; i++)
                {
                    DataRow row = gridview.GetDataRow(i);

                    SubTotal = SubTotal + (Convert.ToDecimal(row["total"]));
                }

                txtSubtotal.EditValue = string.Format("{0:##,###,##0.##}", SubTotal);// decimal.Round(SubTotal, 2, MidpointRounding.AwayFromZero));
                txtImpuesto.EditValue = 0.00;
                txtTotal.EditValue = string.Format("{0:##,###,##0.##}", SubTotal + Convert.ToDecimal(txtImpuesto.EditValue)); //decimal.Round(SubTotal + Convert.ToDecimal(txtImpuesto.EditValue), 2, MidpointRounding.AwayFromZero);
            }
            else //Con Impuesto o Exenta
            {
                var gridview = (GridView)grDetalle.FocusedView;
                for (int i = 0; i < gridview.DataRowCount; i++)
                {
                    DataRow row = gridview.GetDataRow(i);

                    SubTotal = SubTotal + (Convert.ToDecimal(row["total"]));
                    TipoISV = Convert.ToString(row["indicador_impuesto"]);
                }


                txtSubtotal.EditValue = string.Format("{0:##,###,##0.##}", SubTotal);// decimal.Round(SubTotal, 2, MidpointRounding.AwayFromZero));

                //Impuesto isv = new Impuesto();
                //if (isv.RecuperarRegistro(1))
                //{
                //    valor_impuesto = isv.Valor;
                //}
                //else
                //valor_impuesto = Convert.ToDecimal(isv15);
                switch (TipoISV)
                {
                    case "EXE":

                        valor_impuesto = 0;
                        ReCalculoImpuesto();
                        break;

                    case "EXO":
                        valor_impuesto = 0;
                        ReCalculoImpuesto();
                        break;

                    case "ISV":
                        valor_impuesto = 0.15M;
                        ReCalculoImpuesto();
                        break;

                    case "ISVE":
                        valor_impuesto = 0.18M;
                        ReCalculoImpuesto();
                        break;
                    default:
                        break;
                }
                

                //txtImpuesto.EditValue = string.Format("{0:##,###,##0.##}", SubTotal * valor_impuesto);// decimal.Round(SubTotal * valor_impuesto, 2, MidpointRounding.AwayFromZero);
                txtTotal.EditValue = string.Format("{0:##,###,##0.##}", SubTotal + Convert.ToDecimal(txtImpuesto.EditValue)); //decimal.Round(SubTotal + Convert.ToDecimal(txtImpuesto.EditValue), 2, MidpointRounding.AwayFromZero);
            }

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            //ValidarAccesosSegunUsuario();
        }

        private void LimpiarControles()
        {
            tipooperacion = TipoOperacion.New;
            dtFechaContabilizacion.EditValue = dp.Now();
            dtFechaRegistro.Value = dp.Now();
            txtEstado.Text = "Nueva";
            IdEstadoOrdenCompra = 5;
            IdSolicitud = 0;
            IdOrdenCompraActual = 0;
            txtComentarios.Clear();
            txtComentarios.Enabled = true;
            grDetalle.Enabled = true;
            dtFechaContabilizacion.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdAddDetalle.Enabled = true;
            txtCodProv.Enabled = true;
            txtUsuarioCreador.Text = UsuarioLogueado.Nombre;
            dsCompras1.oc_detalle_exonerada.Clear();
            txtCodProv.Clear();
            txtProveedor.Clear();
            txtDocNum.Clear();
            btnPrint.Enabled = false;
            ContactCode = 0;
            glRutaAprobacionOC.EditValue = 0;
            grdTipoOrden.EditValue = 0;
            txtContactoPerson.Text = string.Empty;
            txtNumAtCard.Text = string.Empty;
            txtSubtotal.EditValue = 0;
            txtImpuesto.EditValue = 0;
            txtTotal.EditValue = 0;
            txtDireccion.Text = string.Empty;
            comboBoxIntercom.Text = string.Empty;
            
            txtNumAtCard.Enabled = true;
            grdTipoOrden.Enabled = true;
            glRutaAprobacionOC.Enabled = true;
            comboBoxIntercom.Enabled = true;
            TsExoOIsv.ReadOnly = false;
            btnEditar.Enabled = false;
            btnCopiarDe.Enabled = true;
            EdicionEspecialActiva = false;

            cmdGuardarArchivos.Enabled = true;
            gvFiles.OptionsMenu.EnableColumnMenu = true;
            gvFiles.Columns["eliminar"].Visible = true;
            dsCompras1.ordenes_compras_archivos.Clear();
            TasaCambio = GetTasaCambio();
            btnPresupuesto.Text = "";
            btnPresupuesto.Enabled = true;
            //GetSigID();

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchOrdenC frm = new frmSearchOrdenC(frmSearchOrdenC.FiltroOrdenesCompra.Todas, UsuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tipooperacion = TipoOperacion.Update;
                //CargarSolicitud(frm.IdSolicitudSeleccionado);
                CargarInfoOrden(frm.IdOrdenesSeleccionado);
                CargarArchivos();
                EdicionEspecialActiva = false;
            }

            cmdNuevo.Enabled = true;
        }

        private void CargarInfoOrden(int pidOrdenesSeleccionado)
        {
            CMOrdenCompraH oc = new CMOrdenCompraH();
            if (oc.RecuperarRegistro(pidOrdenesSeleccionado))
            {
                txtUsuarioCreador.Text = oc.UsuarioName;
                txtDocNum.Text = oc.DocNum.ToString();
                IdOrdenCompraActual = oc.Id;
                txtID.Text = IdOrdenCompraActual.ToString();
                txtEstado.Text = oc.EstadoName;
                dtFechaRegistro.Value = oc.TaxDate;
                dtFechaContabilizacion.EditValue = oc.DocDate;
                txtComentarios.Text = oc.Comments;
                IdEstadoOrdenCompra = oc.IdEstado;
                txtCodProv.Text = oc.CardCode;
                txtProveedor.Text = oc.CardName;
                txtNumAtCard.Text = oc.NumAtCard;
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroWithRTN(oc.CardCode);
                txtContactoPerson.Text = prov.ContactName;
                direccion = oc.Address;
                txtDireccion.Text = oc.Address;
                txtSubtotal.EditValue = (oc.DocTotal - oc.ISV);
                txtImpuesto.EditValue = oc.ISV;
                if (string.IsNullOrWhiteSpace(oc.U_AquaExoneracion) || string.IsNullOrEmpty(oc.U_AquaExoneracion))//ISV o EX
                    TsExoOIsv.IsOn = false;
                else
                    TsExoOIsv.IsOn = true; //EXO
                //if (oc.ISV > 0)
                //    TsExoOIsv.IsOn = false;
                //else
                //    TsExoOIsv.IsOn = true;
                txtTotal.EditValue = oc.DocTotal;
                grdTipoOrden.EditValue = oc.U_TipoOrden;
                glRutaAprobacionOC.EditValue = oc.idRutaAprobacion;
                comboBoxIntercom.Text = oc.U_incoterm;
                //C=BP Currency, L=Local Currency, S=System Currency
                switch (oc.CurSource)
                {
                    case "C":
                        cbxMoneda.Text = "Moneda SN";
                        txtMoneda.Text = "USD";
                        TasaCambio = GetTasaCambio();
                        txtTasaCambio.Text = string.Format("{0:##0.0000}", TasaCambio);
                        break;

                    case "S":
                        cbxMoneda.Text = "Moneda del sistema";
                        txtMoneda.Text = "USD";
                        TasaCambio = GetTasaCambio();
                        txtTasaCambio.Text = string.Format("{0:##0.0000}", TasaCambio);
                        break;

                    case "L":
                        cbxMoneda.Text = "Moneda local";
                        txtMoneda.Text = "LPS";
                        TasaCambio = 1;
                        break;
                    default:
                        break;
                }

                CargarDetalleOrdenCompra(IdOrdenCompraActual,1);

                //switch (tipooperacion)
                //{
                //    case TipoOperacion.New:
                //        break;
                //    case TipoOperacion.Update:
                //        break;
                //    case TipoOperacion.View:
                //        break;
                //    default:
                //        tipooperacion = TipoOperacion.Update;
                //        break;
                //}
                

                switch (IdEstadoOrdenCompra)
                {
                    case 1://Pendiente de Aprobacion
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        gcFiles.Enabled = true;
                        cmdGuardarArchivos.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        cmdGuardar.Enabled = true;
                        //btnPrint.Enabled = false;
                        break;

                    case 2://Autorizado
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        gcFiles.Enabled = true;
                        cmdGuardarArchivos.Enabled = false;

                        dtFechaContabilizacion.Enabled = false;
                        btnPrint.Enabled = true;
                        cmdGuardar.Enabled = false;
                        TsExoOIsv.ReadOnly = true;
                        btnCopiarDe.Enabled = false;
                        grdTipoOrden.Enabled = false;
                        glRutaAprobacionOC.Enabled = false;
                        comboBoxIntercom.Enabled = false;
                        txtNumAtCard.Enabled = false;
                        btnEditar.Enabled = true;
                        
                        break;

                    case 3://Rechazada
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        gcFiles.Enabled = true;
                        cmdGuardarArchivos.Enabled = false;

                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        TsExoOIsv.ReadOnly = true;
                        //btnShowPopu.Enabled = false;
                        btnCopiarDe.Enabled = false;
                        btnEditar.Enabled = true;
                        break;

                    case 4://Cancelado
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false ;
                        gcFiles.Enabled = true;
                        cmdGuardarArchivos.Enabled=false;

                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        TsExoOIsv.ReadOnly = true;
                        //btnShowPopu.Enabled = false;
                        btnCopiarDe.Enabled = false;
                        break;

                    case 5: //Creada (Borrador) 
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        gcFiles.Enabled = true;
                        cmdGuardarArchivos.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        cmdGuardar.Enabled = true;

                        break;
                    default:
                        break;
                }

            }
        }

        private void txtCodProv_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
            
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    if (txtCodProv.Text.Length > 0 || grdvDetalle.RowCount > 0 || gvFiles.RowCount > 0)
                    {
                        DialogResult r = CajaDialogo.Pregunta("Esta seguro que desea salir sin Guardar?");
                        if (r != System.Windows.Forms.DialogResult.Yes)
                            return;

                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }

                   

                    break;
                case TipoOperacion.Update:
                    DialogResult rU = CajaDialogo.Pregunta("Esta seguro que desea salir sin Guardar?");
                    if (rU != System.Windows.Forms.DialogResult.Yes)
                        return;

                    this.Close();

                    break;
                case TipoOperacion.View:

                    this.Close();

                    break;
                default:
                    break;
            }
            
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;
            EdicionEspecialActiva = false;
            if (IdOrdenCompraActual == 0)//vamos a mostrar el ultimo
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);//Ordenes de Compra
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoOrden(IdOrdenCompraActual);
                    CargarArchivos();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else//vamos a mostrar el anteior al actual
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdOrdenCompraActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                        IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    CargarInfoOrden(IdOrdenCompraActual);
                    CargarArchivos();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }

        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;
            EdicionEspecialActiva = false;
            if (IdOrdenCompraActual == 0)//vamos a mostrar el primero
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[sp_get_last_or_first_solicitud_and_oc]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 4);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    CargarInfoOrden(IdOrdenCompraActual);
                    CargarArchivos();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
            else//vamos a mostrar el posterior al actual
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_get_navigation_ordenes_compra", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case", 3);
                    cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                    IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());

                    if (IdOrdenCompraActual == 0)
                    {
                        //Si es cero debemos cargar el primero
                        cmd = new SqlCommand("[sp_get_navigation_ordenes_compra]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@case", 4);
                        cmd.Parameters.AddWithValue("@idactual", IdOrdenCompraActual);
                        IdOrdenCompraActual = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    CargarInfoOrden(IdOrdenCompraActual);
                    CargarArchivos();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }


        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada.Rows)
                    {
                        ConsolidacionSaldos(item.capitulo, item.partida_arancelaria, item.cantidad, item.total);
                    }

                    break;
                case TipoOperacion.Update:

                    if (!EdicionEspecialActiva)
                    {
                        switch (IdEstadoOrdenCompra)
                        {
                            case 1://Pendiente (Creada)

                                DialogResult r = CajaDialogo.Pregunta("Se va Actualizar esta Orden de Compra.\nEsta Seguro?");
                                if (r != System.Windows.Forms.DialogResult.Yes)
                                    return;

                                break;

                            case 2://Autorizado
                                CajaDialogo.Error("La Orden ya fue Aprobada, no se puede Editar!");
                                return;

                                break;

                            case 3://Rechazado
                                CajaDialogo.Error("La Orden fue Rechazada, no se puede Editar!");

                                break;

                            case 4: //Cancelada por el Usuario Creador
                                CajaDialogo.Error("Orden Cancelada por el Usuario!");

                                break;

                            default:
                                break;
                        }
                    }

                    

                    break;
                default:
                    break;
            }

            if (string.IsNullOrEmpty(txtCodProv.Text))
            {
                CajaDialogo.Error("Debe Agregar un Proveedor!");
                return;
            }

            if (string.IsNullOrEmpty(glRutaAprobacionOC.Text))
            {
                CajaDialogo.Error("Debe seleccionar el departamento que aprobará la orden de compra!");
                return;
            }

            if (string.IsNullOrEmpty(grdTipoOrden.Text))
            {
                CajaDialogo.Error("Debe seleccionar el tipo de orden de Compra!");
                return;
            }
 
            if (string.IsNullOrEmpty(cbxMoneda.Text))
            {
                CajaDialogo.Error("Debe seleccionar la moneda para la orden de Compra!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaContabilizacion.Text))
            {
                CajaDialogo.Error("Debe seleccionar la fecha de contabilizacion de la Orden de Compra!");
                return;
            }

            if (string.IsNullOrEmpty(txtComentarios.Text))
            {
                CajaDialogo.Error("Debe agregar un comentario!");
                return;
            }

            if (Convert.ToDecimal(txtTotal.EditValue) == 0)
            {
                CajaDialogo.Error("El Valor Total de la Orden no puede ser  (0)!");
                return;
            }

            if (grdvDetalle.RowCount == 0)
            {
                CajaDialogo.Error("Debe seleccionar 1 Producto!");
                return;
            }

            foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada.Rows)
            {
                if (item.cantidad <= 0)
                {
                    CajaDialogo.Error("Cantidad debe ser Mayor que (0)!");
                    return;
                }

                if (item.indicador_impuesto == null)
                {
                    CajaDialogo.Error("Debe seleccionar un Indicador de Impuesto!");
                    return;
                }

                if (string.IsNullOrEmpty(item.descripcion_articulo) || string.IsNullOrWhiteSpace(item.descripcion_articulo))
                {
                    CajaDialogo.Error("No puede dejar vacio la Descripcion del Articulo");
                    return;
                }

                if (item.precio_por_unidad <= 0)
                {
                    CajaDialogo.Error("El Precio Unitario no puede ser 0 o menor");
                    return;
                }

                if (item.itemcode.StartsWith("MP"))
                {
                    if (string.IsNullOrEmpty(comboBoxIntercom.Text))
                    {
                        CajaDialogo.Error("Debe seleccionar el INCOTERM!\nYa que es una Orden con una Materia Prima.");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(item.bodega) || string.IsNullOrWhiteSpace(item.bodega))
                {
                    CajaDialogo.Error("Debe Seleccionar el Almacen para los Articulos!");
                    return;
                }

                if (item.total <= 0)
                {
                    CajaDialogo.Error("No puede dejar el Total (doc.) en 0");
                    return;
                }

            }

            if (TsExoOIsv.IsOn) //Exonerada
            {
                if (string.IsNullOrEmpty(txtExoneracion.Text))
                {
                    CajaDialogo.Error("No existe una Exoneracion Vigente!");
                    return;
                }

                foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada.Rows)
                {
                    if (item.indicador_impuesto == "EXO")
                    {
                        if (item.capitulo == "")
                        {
                            CajaDialogo.Error("Debe Seleccionar el Capitulo!");
                            return;
                        }

                    }

                    if (item.indicador_impuesto == "EXE")
                    {
                        CajaDialogo.Error("Una Linea del Detalle tiene un Registro Exento!\nLa Orden que se esta creando es Exonerada!");
                        return;
                    }
                    if (item.indicador_impuesto == "ISV")
                    {
                        CajaDialogo.Error("Una Linea del Detalle tiene un Registro con Impuesto!\nLa Orden que se esta creando es Exonerada!");
                        return;
                    }
                }

            }
            else//Impuesto o Exenta
            {
                foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                {
                    if (!string.IsNullOrWhiteSpace(item.capitulo) || !string.IsNullOrWhiteSpace(item.partida_arancelaria))
                    {
                        if (item.capitulo.Length > 0)
                        {
                            CajaDialogo.Error("La Orden de Compra no es Exonerada!\nNo pueden tener Capitulos Arancelarias Seleccionados!");
                            item.capitulo = " ";
                            return;
                        }
                        if (item.partida_arancelaria.Length > 0)
                        {
                            CajaDialogo.Error("La Orden de Compra no es Exonerada!\nNo pueden tener Partidas Arancelarias Seleccionados!");
                            item.partida_arancelaria = " ";
                            return;
                        }
                    }

                    if (item.indicador_impuesto == "EXO")
                    {
                        CajaDialogo.Error("La Orden de Compra no es Exonerada!\nNo puede haber un detalle con Indicador de Impuesto: EXO");
                        return;
                    }
                }
            }

            bool CotizacionSelected = false;
            decimal TotalCotizacionSelected = 0;
            //NUEVO: COTIZACIONES
            foreach (dsCompras.ordenes_compras_archivosRow item in dsCompras1.ordenes_compras_archivos)
            {
                if (item.id_tipo_doc == 1) //Cotizaciones
                {
                    if (item.total <= 0)
                    {
                        CajaDialogo.Error("Las Cotizaciones adjuntadas, deben tener su Monto de Cotizacion");
                        xtraTabControl1.SelectedTabPage = tabArchivosAdjuntos;
                        return;
                    }

                    if (item.selected)
                    {
                        CotizacionSelected = true;
                        TotalCotizacionSelected = item.total;
                    }


                }

                if (item.id_tipo_doc == 2)//RESUMEN DE COTIZACIONES
                {
                    if (item.selected)
                    {
                        CajaDialogo.Error("No puede Seleccionar el Resumen de Cotizaciones!");
                        xtraTabControl1.SelectedTabPage = tabArchivosAdjuntos;
                        return;
                    }
                }
            }

            if (gvFiles.RowCount > 1)
            {
                if (!CotizacionSelected)
                {
                    CajaDialogo.Error("Debe marcar la cotizacion utilizada!");
                    return;
                }
            }

            //if (TotalCotizacionSelected != Convert.ToDecimal(txtTotal.EditValue))
            //{
            //    CajaDialogo.Error("La Cotizacion seleccionada, no coincide con el Monto de la Orden de Compra!");
            //    return;
            //}
           

            //Consolidados de Saldos por Capitulo y Rubro

            bool PermitirGuardar = false;

    
            DataTable MyTable = new DataTable(); 
            DataTable MyTableByName = new DataTable("MyTableName"); 
            MyTable.Columns.Add("capitulo", typeof(string));
            MyTable.Columns.Add("partida", typeof(string));
            MyTable.Columns.Add("tipo", typeof(int));//1=SoloCapitulo, 2=Capitulo & Partida
            MyTable.Columns.Add("monto_disponible", typeof(decimal));
            MyTable.Columns.Add("unidades_disponible", typeof(decimal));

            MyTable.Columns.Add("monto_consumo", typeof(decimal));
            MyTable.Columns.Add("unidades_consumo", typeof(decimal));

            //DataRow row = MyTable.NewRow();
            //row["Id"] = 1;
            //row["Name"] = "John";
            //MyTable.Rows.Add(row);

            #region validacion new
            foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
            {
                string Capitulo = "";
                string Partida = "";
                decimal SaldoDisponible = 0;
                decimal UnidadesDisponibles = 0;

                if (item.indicador_impuesto == "EXO")
                {
                    if (string.IsNullOrEmpty(item.partida_arancelaria) || string.IsNullOrWhiteSpace(item.partida_arancelaria))
                    {//Capitulo y partida

                        //Acumularemos los saldos agrupado por capitulo
                        
                        if(MyTable.Rows.Count > 0)
                        {
                            //Validaremos si existe, para sumar el saldo o insertar un nuevo row
                            bool EncontroRow = false;
                            foreach(DataRow rowTMP in MyTable.Rows)
                            {
                                if (rowTMP["capitulo"].ToString() == item.capitulo && dp.ValidateNumberInt32(rowTMP["tipo"]) == 1)//1=SoloCapitulo, 2=Capitulo & Partida
                                {
                                    //Acumularemos el saldo consumido
                                    decimal MontoActual_ = dp.ValidateNumberDecimal(rowTMP["monto_consumo"]);
                                    decimal CantidadActual_ = dp.ValidateNumberDecimal(rowTMP["unidades_consumo"]);

                                    rowTMP["monto_consumo"] = MontoActual_ + item.total;
                                    rowTMP["unidades_consumo"] = CantidadActual_ + item.cantidad;
                                    //rowT["monto_disponible"] = SaldoDisponible;
                                    //rowT["unidades_disponible"] = 0;
                                    
                                    EncontroRow = true;
                                    break;
                                }
                            }
                            if(!EncontroRow)//Insertamos un nuevo registro
                            {
                                decimal valor_disponibleForCapitulo = GetSaldoCapitulo(item.total, item.capitulo);
                                DataRow row = MyTable.NewRow();
                                row["capitulo"] = item.capitulo;
                                row["partida"] = item.partida_arancelaria;
                                row["tipo"] = 1;//1=SoloCapitulo, 2=Capitulo & Partida
                                row["monto_consumo"] = item.total;
                                row["unidades_consumo"] = item.cantidad;
                                //row["monto_disponible"] = SaldoDisponible;
                                row["monto_disponible"] = valor_disponibleForCapitulo;
                                row["unidades_disponible"] = 0;
                                MyTable.Rows.Add(row);
                            }
                        }
                        else
                        {
                            //Es el primer row para agregar
                            decimal valor_disponibleForCapitulo = GetSaldoCapitulo(item.total, item.capitulo);
                            DataRow row = MyTable.NewRow();
                            row["capitulo"] = item.capitulo;
                            row["partida"] = item.partida_arancelaria;
                            row["tipo"] = 1;//1=SoloCapitulo, 2=Capitulo & Partida
                            row["monto_consumo"] = item.total;
                            row["unidades_consumo"] = item.cantidad;
                            //row["monto_disponible"] = SaldoDisponible;
                            row["monto_disponible"] = valor_disponibleForCapitulo;
                            row["unidades_disponible"] = 0;
                            MyTable.Rows.Add(row);
                        }
                    }
                    else
                    {
                        //Acumularemos los saldos agrupado por capitulo y partida
                        if (MyTable.Rows.Count > 0)
                        {
                            //Validaremos si existe, para sumar el saldo o insertar un nuevo row
                            bool EncontroRow = false;
                            foreach (DataRow rowTMP in MyTable.Rows)
                            {
                                if (rowTMP["capitulo"].ToString() == item.capitulo
                                    && dp.ValidateNumberInt32(rowTMP["tipo"]) == 2)//1=SoloCapitulo, 2=Capitulo & Partida
                                {
                                    if (!string.IsNullOrEmpty(item.partida_arancelaria) || !string.IsNullOrWhiteSpace(item.partida_arancelaria))
                                    {
                                        if (rowTMP["partida"].ToString() == item.partida_arancelaria
                                            && dp.ValidateNumberInt32(rowTMP["tipo"]) == 2)//1=SoloCapitulo, 2=Capitulo & Partida
                                        {
                                            //Acumularemos el saldo consumido
                                            decimal MontoActual_ = dp.ValidateNumberDecimal(rowTMP["monto_consumo"]);
                                            decimal CantidadActual_ = dp.ValidateNumberDecimal(rowTMP["unidades_consumo"]);

                                            rowTMP["monto_consumo"] = MontoActual_ + item.total;
                                            rowTMP["unidades_consumo"] = CantidadActual_ + item.cantidad;

                                            EncontroRow = true;
                                            break;
                                        }
                                    }
                                    
                                }
                            }
                            if (!EncontroRow)//Insertamos un nuevo registro
                            {
                                decimal[] valor_disponibleForCapitulo = GetSaldoCapituloPartida(item.total, item.cantidad, item.capitulo, item.partida_arancelaria);

                                DataRow row = MyTable.NewRow();
                                row["capitulo"] = item.capitulo;
                                row["partida"] = item.partida_arancelaria;
                                row["tipo"] = 2;//1=SoloCapitulo, 2=Capitulo & Partida
                                row["monto_consumo"] = item.total;
                                row["unidades_consumo"] = item.cantidad;
                                row["monto_disponible"] = valor_disponibleForCapitulo[0];
                                row["unidades_disponible"] = valor_disponibleForCapitulo[1];
                                MyTable.Rows.Add(row);
                            }
                        }
                        else
                        {
                            //Es el primer row para agregar
                            decimal[] valor_disponibleForCapitulo = GetSaldoCapituloPartida(item.total, item.cantidad, item.capitulo, item.partida_arancelaria);
                            DataRow row = MyTable.NewRow();
                            row["capitulo"] = item.capitulo;
                            row["partida"] = item.partida_arancelaria;
                            row["tipo"] = 2;//1=SoloCapitulo, 2=Capitulo & Partida
                            row["monto_consumo"] = item.total;
                            row["unidades_consumo"] = item.cantidad;
                            row["monto_disponible"] = valor_disponibleForCapitulo[0];
                            row["unidades_disponible"] = valor_disponibleForCapitulo[1];
                            MyTable.Rows.Add(row);
                        }
                    }
                }
            }
            #endregion

            //VALIDACION de saldos total
            bool LineaExcedeSaldo = false;
            string ValiCapitulo = string.Empty;
            string ValiPartida = string.Empty;
            int Tipo = 0;
            foreach (DataRow rowTMP in MyTable.Rows)
            {
                if (dp.ValidateNumberInt32(rowTMP["tipo"]) == 1)//1=SoloCapitulo, 2=Capitulo & Partida
                {
                    decimal MontoActual_ = dp.ValidateNumberDecimal(rowTMP["monto_consumo"]);
                    //decimal CantidadActual_ = dp.ValidateNumberDecimal(rowTMP["unidades_consumo"]);
                    decimal MontoDisponible_ = dp.ValidateNumberDecimal(rowTMP["monto_disponible"]);
                    //decimal CantidadDisponible_ = dp.ValidateNumberDecimal(rowTMP["unidades_disponible"]);
                    if ((MontoActual_ > MontoDisponible_))
                    {
                        ValiCapitulo = rowTMP["capitulo"].ToString();
                        Tipo = 1; //SoloCapitulo
                        LineaExcedeSaldo = true;
                        break;
                    }
                }
                else
                {
                    decimal MontoActual_ = dp.ValidateNumberDecimal(rowTMP["monto_consumo"]);
                    decimal CantidadActual_ = dp.ValidateNumberDecimal(rowTMP["unidades_consumo"]);
                    decimal MontoDisponible_ = dp.ValidateNumberDecimal(rowTMP["monto_disponible"]);
                    decimal CantidadDisponible_ = dp.ValidateNumberDecimal(rowTMP["unidades_disponible"]);
                    
                    if (MontoActual_ > MontoDisponible_ || CantidadActual_ > CantidadDisponible_)
                    {
                        ValiCapitulo = rowTMP[0].ToString();
                        ValiPartida = rowTMP[1].ToString();
                        Tipo = 2; //Capitulo & Partida
                        LineaExcedeSaldo = true;
                        break;
                    }
                }
            }

            if (LineaExcedeSaldo)
            {
                if (Tipo == 1) ////SoloCapitulo
                {
                    CajaDialogo.Error("Hay una linea en la orden de compra que excede el valor de saldo disponible para exonerar!\nCapitlo: "+ValiCapitulo);
                    return;
                }
                else
                {
                    CajaDialogo.Error("Hay una linea en la orden de compra que excede el valor de saldo disponible para exonerar!\nCapitulo: "+ ValiCapitulo +" Partida Arancelaria: " + ValiPartida);
                    return;
                }
                
            }

            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    bool Guardar = false;
                    SqlTransaction transaction = null;
                    
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_CM_insert_ordencompra_h_v4]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CardCode", txtCodProv.Text.Trim());
                        cmd.Parameters.AddWithValue("@CardName", txtProveedor.Text);
                        cmd.Parameters.AddWithValue("@Address", direccion);

                        if (string.IsNullOrWhiteSpace(txtNumAtCard.Text))
                            cmd.Parameters.AddWithValue("@NumAtCard", "N/D");
                        else
                            cmd.Parameters.AddWithValue("@NumAtCard", txtNumAtCard.Text);

                        cmd.Parameters.AddWithValue("@DocDate", dtFechaRegistro.Value);
                        cmd.Parameters.AddWithValue("@DocDueDate", dtFechaContabilizacion.DateTime.AddDays(15));
                        cmd.Parameters.AddWithValue("@TaxDate", dtFechaContabilizacion.EditValue);
                        cmd.Parameters.AddWithValue("@U_TipoOrden", grdTipoOrden.EditValue);
                        cmd.Parameters.AddWithValue("@U_AquaExoneracion", txtExoneracion.Text);
                        cmd.Parameters.AddWithValue("@U_FechaExoneracion", dtFechaRegistro.Value);
                        cmd.Parameters.AddWithValue("@Comments", txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@ISV", Convert.ToDecimal(txtImpuesto.EditValue));
                        cmd.Parameters.AddWithValue("@DocTotal", Convert.ToDecimal(txtTotal.EditValue));
                        cmd.Parameters.AddWithValue("@CurSource", CurSource);//C=BP Currency, L=Local Currency, S=System Currency
                        cmd.Parameters.AddWithValue("@DocCur", txtMoneda.Text.Trim());
                        cmd.Parameters.AddWithValue("@DocRate", TasaCambio);

                        if (IdSolicitud == 0)
                            cmd.Parameters.AddWithValue("@DocNumSolicitud", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@DocNumSolicitud", IdSolicitud);

                        cmd.Parameters.AddWithValue("@posted_in_sap", 0);
                        cmd.Parameters.AddWithValue("@ContactCode", ContactCode);
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@id_ruta", glRutaAprobacionOC.EditValue);

                        if (string.IsNullOrEmpty(comboBoxIntercom.Text) || comboBoxIntercom.Text == "Ninguno")
                            cmd.Parameters.AddWithValue("@U_incoterm", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@U_incoterm", comboBoxIntercom.Text.Trim());
                        cmd.Parameters.AddWithValue("@TasaCambio", Convert.ToDecimal(txtTasaCambio.EditValue));

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsCompras.oc_detalle_exoneradaRow row in dsCompras1.oc_detalle_exonerada.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_insert_detalle_orden_compra_SAPV2]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_orden_h", id_header);
                            cmd.Parameters.AddWithValue("@ItemCode", row.itemcode);
                            cmd.Parameters.AddWithValue("@Description", row.descripcion_articulo);
                            if (string.IsNullOrWhiteSpace(row.capitulo))
                                cmd.Parameters.AddWithValue("@Capitulo_Codigo", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@Capitulo_Codigo", row.capitulo);
                            if (string.IsNullOrWhiteSpace(row.partida_arancelaria))
                                cmd.Parameters.AddWithValue("@Partida_Arancelaria", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@Partida_Arancelaria", row.partida_arancelaria);
                            cmd.Parameters.AddWithValue("@Quantity", row.cantidad);
                            cmd.Parameters.AddWithValue("@Unite_Price", row.precio_por_unidad);
                            cmd.Parameters.AddWithValue("@Currency", txtMoneda.Text.Trim());
                            cmd.Parameters.AddWithValue("@DiscPrcnt", 0);
                            cmd.Parameters.AddWithValue("@TaxCode", row.indicador_impuesto);
                            cmd.Parameters.AddWithValue("@WhsCode", row.bodega.Trim());
                            cmd.Parameters.AddWithValue("@isv", row.isv);
                            cmd.Parameters.AddWithValue("@base_ref", row.referencia_base);//Referencia de Solicitud de Compra
                            cmd.Parameters.AddWithValue("@num_linea_solicitud_d", row.num_linea_solicitud_d);
                            cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                            if (row.id_detalle_presupuesto == 0)
                            {
                                cmd.Parameters.AddWithValue("@presupuesto_id_detalle", DBNull.Value);
                                cmd.Parameters.AddWithValue("@presupuesto_descrip", DBNull.Value);
                                cmd.Parameters.AddWithValue("@TasaCambioActual", TasaCambio);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@presupuesto_id_detalle", row.id_detalle_presupuesto);
                                cmd.Parameters.AddWithValue("@presupuesto_descrip", row.presupuesto_descripcion);
                                cmd.Parameters.AddWithValue("@TasaCambioActual", TasaCambio);
                            }
                                
                            cmd.ExecuteNonQuery();
                        }

                        //Seccion para agregar los archivos
                        foreach (var row in dsCompras1.ordenes_compras_archivos)
                        {
                            string ext = Path.GetExtension(row.file_name);
                            string file_name = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                            //Luego de subir el archivo al FTP, que se guarde el registro
                            if (Upload(row.path, file_name,row.id))
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "usp_UploadFileFromOrdenesComprasV2";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_orden_compra_h", id_header);
                                cmd.Parameters.AddWithValue("@path", dp.FTP_Tickets_LOSA_Compras+ file_name);
                                cmd.Parameters.AddWithValue("@file_name", row.file_name);
                                cmd.Parameters.AddWithValue("@id_user", UsuarioLogueado.Id);
                                cmd.Parameters.AddWithValue("@id", row.id);
                                cmd.Parameters.AddWithValue("@id_tipo_doc",row.id_tipo_doc);
                                cmd.Parameters.AddWithValue("@monto_cotizacion",row.monto_cotizacion);
                                cmd.Parameters.AddWithValue("@descuento",row.descuento);
                                cmd.Parameters.AddWithValue("@selected",row.selected);
                                cmd.ExecuteNonQuery();
                            }

                        }

                        transaction.Commit();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Orden de Compra Creada!");
                        LimpiarControles();
                    }


                    break;
                case TipoOperacion.Update:

                    SqlTransaction transactionUpdate = null;

                    SqlConnection connUpdate = new SqlConnection(dp.ConnectionStringLOSA);
                    bool GuardarUpdate = false;

                    try
                    {
                        connUpdate.Open();
                        transactionUpdate = connUpdate.BeginTransaction("Transaction Order");
                        SqlCommand cmdUpdate = connUpdate.CreateCommand();
                        cmdUpdate.CommandText = "[sp_CM_update_ordencompra_hV3]";
                        cmdUpdate.Connection = connUpdate;
                        cmdUpdate.Transaction = transactionUpdate;
                        cmdUpdate.CommandType = CommandType.StoredProcedure;
                        cmdUpdate.Parameters.AddWithValue("@idOrdenCompraH", IdOrdenCompraActual);
                        cmdUpdate.Parameters.AddWithValue("@CardCode", txtCodProv.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@CardName", txtProveedor.Text);
                        cmdUpdate.Parameters.AddWithValue("@Address", direccion);
                        if (string.IsNullOrEmpty(txtNumAtCard.Text))
                            cmdUpdate.Parameters.AddWithValue("@NumAtCard", "N/D");
                        else
                            cmdUpdate.Parameters.AddWithValue("@NumAtCard", txtNumAtCard.Text);

                        cmdUpdate.Parameters.AddWithValue("@DocDate", dtFechaRegistro.Value);
                        cmdUpdate.Parameters.AddWithValue("@DocDueDate", dtFechaContabilizacion.DateTime.AddDays(15));
                        cmdUpdate.Parameters.AddWithValue("@TaxDate", dtFechaContabilizacion.EditValue);
                        cmdUpdate.Parameters.AddWithValue("@U_TipoOrden", grdTipoOrden.EditValue);
                        cmdUpdate.Parameters.AddWithValue("@U_AquaExoneracion", txtExoneracion.Text);
                        cmdUpdate.Parameters.AddWithValue("@U_FechaExoneracion", dtFechaRegistro.Value);
                        cmdUpdate.Parameters.AddWithValue("@Comments", txtComentarios.Text);
                        cmdUpdate.Parameters.AddWithValue("@ISV", Convert.ToDecimal(txtImpuesto.EditValue));
                        cmdUpdate.Parameters.AddWithValue("@DocTotal", Convert.ToDecimal(txtTotal.EditValue));
                        cmdUpdate.Parameters.AddWithValue("@CurSource", CurSource);//C=BP Currency, L=Local Currency, S=System Currency
                        cmdUpdate.Parameters.AddWithValue("@DocCur", txtMoneda.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@DocRate", TasaCambio);
                        if (IdSolicitud == 0)
                            cmdUpdate.Parameters.AddWithValue("@DocNumSolicitud", DBNull.Value);
                        else
                            cmdUpdate.Parameters.AddWithValue("@DocNumSolicitud", IdSolicitud);
                        cmdUpdate.Parameters.AddWithValue("@ContactCode", ContactCode);
                        cmdUpdate.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                        cmdUpdate.Parameters.AddWithValue("@id_ruta", glRutaAprobacionOC.EditValue);

                        if (string.IsNullOrEmpty(comboBoxIntercom.Text) || comboBoxIntercom.Text == "Ninguno")
                            cmdUpdate.Parameters.AddWithValue("@U_incoterm", DBNull.Value);
                        else
                            cmdUpdate.Parameters.AddWithValue("@U_incoterm", comboBoxIntercom.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@idEstadoCompra", IdEstadoOrdenCompra);
                        cmdUpdate.Parameters.AddWithValue("@TasaCambio", Convert.ToDecimal(txtTasaCambio.EditValue));

                        cmdUpdate.ExecuteNonQuery();

                        foreach (dsCompras.oc_detalle_exoneradaRow row in dsCompras1.oc_detalle_exonerada.Rows)
                        {
                            cmdUpdate.Parameters.Clear();
                            cmdUpdate.CommandText = "[sp_compras_ordenes_detalle_update_insertV2]";
                            cmdUpdate.Connection = connUpdate;
                            cmdUpdate.Transaction = transactionUpdate;
                            cmdUpdate.CommandType = CommandType.StoredProcedure;
                            cmdUpdate.Parameters.AddWithValue("@id_detalle", row.id_d_orden);
                            cmdUpdate.Parameters.AddWithValue("@id_orden_h", IdOrdenCompraActual);
                            cmdUpdate.Parameters.AddWithValue("@ItemCode", row.itemcode);
                            cmdUpdate.Parameters.AddWithValue("@Description", row.descripcion_articulo);
                            if (string.IsNullOrWhiteSpace(row.capitulo))
                                cmdUpdate.Parameters.AddWithValue("@Capitulo_Codigo", DBNull.Value);
                            else
                                cmdUpdate.Parameters.AddWithValue("@Capitulo_Codigo", row.capitulo);
                            if (string.IsNullOrWhiteSpace(row.partida_arancelaria))
                                cmdUpdate.Parameters.AddWithValue("@Partida_Arancelaria", DBNull.Value);
                            else
                                cmdUpdate.Parameters.AddWithValue("@Partida_Arancelaria", row.partida_arancelaria);
                            cmdUpdate.Parameters.AddWithValue("@Quantity", row.cantidad);
                            cmdUpdate.Parameters.AddWithValue("@Unite_Price", row.precio_por_unidad);
                            cmdUpdate.Parameters.AddWithValue("@Currency", txtMoneda.Text.Trim());
                            cmdUpdate.Parameters.AddWithValue("@DiscPrcnt", 0);
                            cmdUpdate.Parameters.AddWithValue("@TaxCode", row.indicador_impuesto);
                            cmdUpdate.Parameters.AddWithValue("@WhsCode", row.bodega.Trim());
                            cmdUpdate.Parameters.AddWithValue("@isv", row.isv);
                            cmdUpdate.Parameters.AddWithValue("@base_ref", row.referencia_base);
                            cmdUpdate.Parameters.AddWithValue("@num_linea_solicitud_d", row.num_linea_solicitud_d);
                            cmdUpdate.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                            if (row.id_detalle_presupuesto == 0)
                            {
                                cmdUpdate.Parameters.AddWithValue("@presupuesto_id_detalle", 0);
                                cmdUpdate.Parameters.AddWithValue("@presupuesto_descrip",DBNull.Value);
                                cmdUpdate.Parameters.AddWithValue("@TasaCambioActual",TasaCambio);
                                cmdUpdate.Parameters.AddWithValue("@EdicionEspecialSAP", EdicionEspecialActiva);
                            }
                            else
                            {
                                cmdUpdate.Parameters.AddWithValue("@presupuesto_id_detalle",row.id_detalle_presupuesto);
                                cmdUpdate.Parameters.AddWithValue("@presupuesto_descrip",row.presupuesto_descripcion);
                                cmdUpdate.Parameters.AddWithValue("@TasaCambioActual",TasaCambio);
                                cmdUpdate.Parameters.AddWithValue("@EdicionEspecialSAP", EdicionEspecialActiva);
                            }
                            cmdUpdate.ExecuteNonQuery();
                        }

                        string file_name;
                        //Seccion para agregar los archivos
                        foreach (var row in dsCompras1.ordenes_compras_archivos)
                        {

                            if (row.id > 0)
                                ActualizarArchivosSelected(row.id, row.selected);

                            string ext = Path.GetExtension(row.file_name);
                            file_name = DateTime.Now.ToString("ddMMyyyyhhmmss") + '_'+ row.file_name;//+ext;
                            //Luego de subir el archivo al FTP, que se guarde el registro
                            if (Upload(row.path, file_name,row.id))
                            {
                                cmdUpdate.Parameters.Clear();
                                cmdUpdate.CommandText = "[usp_UploadFileFromOrdenesComprasV2]";
                                cmdUpdate.Connection = connUpdate;
                                cmdUpdate.Transaction = transactionUpdate;
                                cmdUpdate.CommandType = CommandType.StoredProcedure;
                                cmdUpdate.Parameters.AddWithValue("@id_orden_compra_h", IdOrdenCompraActual);
                                cmdUpdate.Parameters.AddWithValue("@path", dp.FTP_Tickets_LOSA_Compras + file_name);
                                cmdUpdate.Parameters.AddWithValue("@file_name", row.file_name);
                                cmdUpdate.Parameters.AddWithValue("@id_user", UsuarioLogueado.Id);
                                cmdUpdate.Parameters.AddWithValue("@id", row.id);
                                cmdUpdate.Parameters.AddWithValue("@id_tipo_doc", row.id_tipo_doc);
                                cmdUpdate.Parameters.AddWithValue("@monto_cotizacion", row.monto_cotizacion);
                                cmdUpdate.Parameters.AddWithValue("@descuento", row.descuento);
                                cmdUpdate.Parameters.AddWithValue("@selected", row.selected);
                                cmdUpdate.ExecuteNonQuery();
                            }

                        }

                        transactionUpdate.Commit();
                        GuardarUpdate = true;

                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                        GuardarUpdate = false;
                    }

                    if (GuardarUpdate)
                    {
                        CajaDialogo.Information("Orden de Compra Modificada!");
                        LimpiarControles();
                    }

                    break;
                default:
                    CajaDialogo.Error("No se pudo definir una Operacion de Tipo(INSERT-UPDATE)\nContacte al Dpto. IT");
                    break;
            }

        }

        decimal[] GetSaldoCapituloPartida(decimal pTotal, decimal pCantidad, string pCapitulo, string pPartida)
        {
            decimal[] SaldoDisponible = { 0, 0};
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CM_validacion_saldos_por_capitulo_y_partida", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Monto", pTotal);
                cmd.Parameters.AddWithValue("@Unidades", pCantidad);
                cmd.Parameters.AddWithValue("@Capitulo", pCapitulo);
                cmd.Parameters.AddWithValue("@PartidaArancelaria", pPartida);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //PermitirGuardar = dr.GetBoolean(0);
                    //Capitulo = dr.GetString(1);
                    //Partida = dr.GetString(2);
                    SaldoDisponible[0] = dr.GetDecimal(3);
                    //UnidadesDisponibles = dr.GetDecimal(4);
                    SaldoDisponible[1] = dr.GetDecimal(4);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return SaldoDisponible;
        }


        decimal GetSaldoCapitulo(decimal pMontoConsumido, string pCapitulo)
        {
            decimal SaldoDisponible=0;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CM_validacion_saldos_por_capitulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Monto", pMontoConsumido);//Valor a consumir
                cmd.Parameters.AddWithValue("@Capitulo", pCapitulo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //PermitirGuardar = dr.GetBoolean(0);
                    SaldoDisponible = dr.GetDecimal(1);
                    //Capitulo = dr.GetString(2);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return SaldoDisponible;
        }

        private void ConsolidacionSaldos(string capitulo, string partida_arancelaria, decimal cantidad, decimal total)
        {

            bool PrimeraIteracion = true;            

            if (PrimeraIteracion == true)
            {
                DataRow drow = dsCompras1.SaldosMemoria.NewRow();
                drow[0] = capitulo;
                drow[1] = partida_arancelaria;
                drow[2] = cantidad;
                drow[3] = total;

                dsCompras1.SaldosMemoria.Rows.Add(drow);
                dsCompras1.SaldosMemoria.AcceptChanges();
                PrimeraIteracion = false;
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtFechaContabilizacion_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaRegistro.Value > dtFechaContabilizacion.DateTime)
            {
                CajaDialogo.Error("La Fecha de Contabilizacion no puede ser menor a la de Registro!");
                dtFechaContabilizacion.EditValue = dtFechaRegistro.Value;
                return;
            }

            TasaCambioActual();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (IdOrdenCompraActual > 0)
            {
                if (TsExoOIsv.IsOn) //Solo exoneradas
                {
                    
                    rptOrdenCompraExo report = new rptOrdenCompraExo(IdOrdenCompraActual);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool reportPrint = new ReportPrintTool(report);
                    ActualizarConteoPrint(IdOrdenCompraActual);
                    reportPrint.ShowPreview();
                }
                else
                {
                    rptOrdenCompra report = new rptOrdenCompra(IdOrdenCompraActual);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool reportPrint = new ReportPrintTool(report);
                    ActualizarConteoPrint(IdOrdenCompraActual);
                    reportPrint.ShowPreview();
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar una Orden de Compra!");
                return;
            }
        }

        private void ActualizarConteoPrint(int pIdOC)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CM_update_count_print_oc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOC", pIdOC);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return;
            }
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdOrdenCompraActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void grDetalle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdOrdenCompraActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void panelControl2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (IdOrdenCompraActual > 0)
                {
                    popupMenu1.ShowPopup(Cursor.Position);
                }
            }
        }

        private void barbtnCancelOrden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DialogResult r = CajaDialogo.Pregunta("¿Confirma que desea Cancelar esta Orden de Compra?");
            if (r != DialogResult.Yes)
                return;

            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    break;
                case TipoOperacion.Update:
                    CancelarOrdenCompra(IdOrdenCompraActual);
                    break;
                case TipoOperacion.View:
                    CancelarOrdenCompra(IdOrdenCompraActual);

                    break;
                default:
                    break;
            }
        }

        private void CancelarOrdenCompra(int pidOrdenCompraActual)
        {
            CMOrdenCompraH oc = new CMOrdenCompraH();
            oc.RecuperarRegistro(pidOrdenCompraActual);

            bool Proceder;
            string mensaje = "";

            switch (oc.IdEstado)
            {
                case 1: //Pendiente (Creada)
                    Proceder = true;
                    break;

                case 2: //Autorizada
                    Proceder = true;
                            if (ValidarEstadoOrdenSAP(oc.DocNum))
                            {
                                CajaDialogo.Error("Antes de Cerrar la Orden en ALOSY\nDebe Cancelar la Orden en SAP.");
                                return;
                            }       
                    break;

                case 3: //Rechazada
                    Proceder = false;
                    mensaje = "No se puede Cancelar\nLa Orden de Compra fue Rechazada por el Aprobador!";
                    break;

                case 4: //Cancelada
                    Proceder = false;
                    mensaje = "La Orden de Compra se encuentra Cancelada!";
                    break;

                case 5: //Creada (Se debe Enviar a Aprobacion)
                    Proceder = true;

                    break;
                default:
                    Proceder = false;
                    break;
            }

            popupMenu1.HidePopup();

            if (Proceder)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_CM_cancelar_orden_compra", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_OrdenCompra", pidOrdenCompraActual);
                    cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogueado.Id);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    CajaDialogo.Information("Orden de Compra Cancelada!");

                    cmdNuevo.Enabled = false;
                    cmdAddDetalle.Enabled = false;
                    txtComentarios.Enabled = false;
                    grDetalle.Enabled = false;
                    dtFechaContabilizacion.Enabled = false;
                    //txtComentarios.Text = "Cancelado";
                    txtEstado.Text = "Cancelado";
                    IdEstadoOrdenCompra = 4; //Cancelado
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error(mensaje);
                return;
            }
        }

        private bool ValidarEstadoOrdenSAP(int pDocNum)
        {
            bool OCAbierta = false;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CM_get_status_OC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocNum", pDocNum);
                OCAbierta = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return OCAbierta;
        }

        private void grdSucursales_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void TsExoOIsv_Toggled(object sender, EventArgs e)
        {
            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    if (TsExoOIsv.IsOn) //Exonerado
                    {
                        txtExoneracion.Visible = true;
                        lblExoneracion.Visible = true;
                        ObtenerExoneracionVigente();

                        foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                        {
                            item.isv = 0;
                            item.indicador_impuesto = "EXO";
                        }
                        CalcularTotal();

                    }
                    else //Impuesto
                    {
                        txtExoneracion.Text = "";
                        txtExoneracion.Visible = false;
                        lblExoneracion.Visible = false;
                        foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                        {
                            item.capitulo = " ";
                            item.partida_arancelaria = " ";
                            item.isv = (item.total * 0.15M);
                            item.indicador_impuesto = "ISV";

                        }
                        ReCalculoImpuesto();
                        CalcularTotal();
                    }
                    break;
                case TipoOperacion.Update:
                    if (TsExoOIsv.IsOn) //Exonerado
                    {
                        txtExoneracion.Visible = true;
                        lblExoneracion.Visible = true;
                        ObtenerExoneracionVigente();

                        foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                        {
                            item.isv = 0;
                            item.indicador_impuesto = "EXO";
                        }
                        CalcularTotal();

                    }
                    else //Impuesto
                    {
                        txtExoneracion.Text = "";
                        txtExoneracion.Visible = false;
                        lblExoneracion.Visible = false;
                        foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                        {
                            item.capitulo = " ";
                            item.partida_arancelaria = " ";
                            item.isv = (item.total * 0.15M);
                            item.indicador_impuesto = "ISV";

                        }
                        ReCalculoImpuesto();
                        CalcularTotal();
                    }
                    break;
                case TipoOperacion.View:
                    break;
                default:
                    if (TsExoOIsv.IsOn) //Exonerado
                    {
                        txtExoneracion.Visible = true;
                        lblExoneracion.Visible = true;
                        ObtenerExoneracionVigente();

                        foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                        {
                            item.isv = 0;
                            item.indicador_impuesto = "EXO";
                        }
                        CalcularTotal();

                    }
                    else //Impuesto
                    {
                        txtExoneracion.Text = "";
                        txtExoneracion.Visible = false;
                        lblExoneracion.Visible = false;
                        foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                        {
                            item.capitulo = " ";
                            item.partida_arancelaria = " ";
                            item.isv = (item.total * 0.15M);
                            item.indicador_impuesto = "ISV";

                        }
                        ReCalculoImpuesto();
                        CalcularTotal();
                    }
                    break;
            }

            
        }

        private void ObtenerExoneracionVigente()
        {
            try
            {
                string query = @"sp_get_exoneracion_vigente";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", 1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtExoneracion.Text = dr.GetString(0);
                }
                dr.Close();
                conn.Close();

                if (string.IsNullOrEmpty(txtExoneracion.Text))
                {
                    CajaDialogo.Error("No existe una Exoneracion Vigente!\nContacte al Dpto. de IT");
                    return;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void reposGrdCapitulo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarPartidasArancelarias(string pCode)
        {
            try
            {
                string query = @"[sp_cm_exoneracion_partida_arancelaria]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", pCode.Trim());
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.partida_arancelaria.Clear();
                adat.Fill(dsExoneracion1.partida_arancelaria);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarPartidasArancelarias()
        {
            try
            {
                string query = @"[sp_cm_exoneracion_partida_arancelaria_v2]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Code", pCode.Trim());
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsExoneracion1.partida_arancelaria.Clear();
                adat.Fill(dsExoneracion1.partida_arancelaria);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void comboBoxEdit1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxMoneda.Text))
                return;

            //C=BP Currency, L=Local Currency, S=System Currency
            switch (cbxMoneda.EditValue.ToString()) 
            {
                case "Moneda SN":
                    txtMoneda.Text = "USD";
                    CurSource = 'C';
                    TasaCambio = GetTasaCambio();
                    txtTasaCambio.Text = string.Format("{0:##0.0000}", TasaCambio);
                    break;
                case "Moneda del sistema":
                    txtMoneda.Text = "USD";
                    TasaCambio = GetTasaCambio();
                    CurSource = 'S';
                    txtTasaCambio.Text = string.Format("{0:##0.0000}", TasaCambio);
                    break;
                case "Moneda local":
                    txtMoneda.Text = "LPS";
                    TasaCambio = 1;
                    CurSource = 'L';
                    break;
                default:
                    break;
            }
        }

        private decimal GetTasaCambio()
        {
            decimal ret = 0;
            
            try
            {
                string query = @"[sp_get_tasa_cambio_by_date]";
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", dtFechaContabilizacion.EditValue);
                ret= Convert.ToDecimal(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return ret;
        }

      
        private void btnCopiarDe_Click(object sender, EventArgs e)
        {
            popupMenu2.ShowPopup(Cursor.Position);
        }

        private void btnCopiarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    frmCopiarDeSolicitud frm = new frmCopiarDeSolicitud(frmCopiarDeSolicitud.TipoDocumento.SolicitudCompra);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        IdSolicitud = frm.IdSolicitudSeleccionado;
                        CargarOrdenCompraFromSolicitud(IdSolicitud);

                    }

                    cmdNuevo.Enabled = true;

                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }

        private void btnOrdenCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdOrdenCompraSoloDetalle = 0;
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    frmCopiarDeSolicitud frm = new frmCopiarDeSolicitud(frmCopiarDeSolicitud.TipoDocumento.OrdenCompra);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        IdOrdenCompraSoloDetalle = frm.IdOrdenCompra;
                        CargarOrdenCompraFromOrdenCompra(IdOrdenCompraSoloDetalle);

                    }

                    cmdNuevo.Enabled = true;

                    break;
                case TipoOperacion.Update:
                    break;
                default:
                    break;
            }
        }

        private void grdTipoOrden_EditValueChanged(object sender, EventArgs e)
        {
            switch (tipooperacion)
            {
                case TipoOperacion.New:
                    if (Convert.ToInt32(grdTipoOrden.EditValue) > 0)
                    {
                        switch (Convert.ToInt32(grdTipoOrden.EditValue))
                        {
                            case 1: //Materia Prima
                                glRutaAprobacionOC.EditValue = 1;//Materia Prima
                                break;

                            case 2://Gastos Produccion
                                glRutaAprobacionOC.EditValue = 2;//Gastos Produccion
                                break;

                            case 3://Gastos Mantenimiento
                                glRutaAprobacionOC.EditValue = 3;//Gastos Mantenimiento
                                break;

                            case 4://Gastos Calidad
                                glRutaAprobacionOC.EditValue = 4;//Gastos Calidad
                                break;

                            case 5://Gastos Logistica
                                glRutaAprobacionOC.EditValue = 5;
                                break;

                            case 6:
                                glRutaAprobacionOC.EditValue = 6;
                                break;

                            case 7:
                                glRutaAprobacionOC.EditValue = 0;
                                break;

                            case 8:
                                glRutaAprobacionOC.EditValue = 7;
                                break;

                            default:
                                break;
                        }
                    }
                    break;
                case TipoOperacion.Update:
                    break;
                case TipoOperacion.View:
                    break;
                default:
                    break;
            }
        }

        private void grdvDetalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalle_exoneradaRow)gridView.GetFocusedDataRow();

            try
            {
                switch (e.Column.FieldName)
                {
                    //case "cantidad":

                    //    row.total = row.cantidad * row.precio_por_unidad;
                    //    if (TsExoOIsv.IsOn)//Exonerada
                    //        row.isv = 0;
                    //    else
                    //        row.isv = (row.cantidad * row.precio_por_unidad) * Convert.ToDecimal(0.15);

                    //    //row.total += row.isv;
                    //    CalcularTotal();
                    //    break;
                    //case "precio_por_unidad":

                    //    row.total = row.cantidad * row.precio_por_unidad;
                    //    if (TsExoOIsv.IsOn)//Exonerada
                    //        row.isv = 0;
                    //    else
                    //        row.isv = (row.cantidad * row.precio_por_unidad) * Convert.ToDecimal(0.15);

                    //    //row.total += row.isv;
                    //    CalcularTotal();
                    //    break;
                    //case "capitulo":
                    //    var gridview = (GridView)grDetalle.FocusedView;
                    //    //var row = (dsExoneracion.capitulosRow)gridview.GetFocusedDataRow();
                    //    var rowz = (dsCompras.oc_detalle_exoneradaRow)gridview.GetFocusedDataRow();

                    //    if (!rowz.IscapituloNull())
                    //    {
                    //        CargarPartidasArancelarias(rowz.capitulo);
                    //    }
                    //    else
                    //    {
                    //        //string a = row.capitulo;
                    //    }
                    //    break;

                    case "indicador_impuesto": //EXO EXE ISV

                        var gridviewiva = (GridView)grDetalle.FocusedView;
                        var rowiva = (dsCompras.oc_detalle_exoneradaRow)gridviewiva.GetFocusedDataRow();
                        string valor_ = row.indicador_impuesto;
                        valor_ = e.Value.ToString();
                        switch (valor_)
                        {
                            case "EXE"://EXENTO

                                rowiva.isv = 0;
                                row.isv = 0;
                                dsCompras1.AcceptChanges();
                                //txtImpuesto.EditValue = 0.00;
                                //ReCalculoImpuesto();
                                CalcularTotal();

                                break;

                            case "EXO":

                                rowiva.isv = 0;
                                CalcularTotal();

                                break;

                            case "ISV"://0.15

                                rowiva.isv = rowiva.total * 0.15M;
                                string.Format("{0:0,0.00}", rowiva.isv);
                                rowiva.capitulo = " ";
                                rowiva.partida_arancelaria = " ";
                                ReCalculoImpuesto();
                                CalcularTotal();

                                break;

                            case "ISVE"://0.18

                                rowiva.isv = rowiva.total * 0.18M;
                                string.Format("{0:0,0.00}", rowiva.isv);
                                rowiva.capitulo = " ";
                                rowiva.partida_arancelaria = " ";
                                ReCalculoImpuesto();
                                CalcularTotal();

                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CMOrdenCompraH oc = new CMOrdenCompraH();
            oc.RecuperarRegistro(IdOrdenCompraActual);

            bool Proceder = false;

            switch (oc.IdEstado)
            {
                case 1: //Pendiente (Creada)
                    Proceder = true;
                    break;

                case 2: //Autorizada
                    //Proceder = true;
                    if (ValidarEstadoOrdenSAP(oc.DocNum))
                    {
                        CajaDialogo.Error("Antes de Editar esta Orden Autorizada.\nDebe Cancelar la Orden en SAP.");
                        return;
                    }
                    else
                        Proceder = true;
                    break;

                case 3: //Rechazada
                    Proceder = true;
                    break;
                default:
                    Proceder = false;
                    break;
            }
           
            if(Proceder)
            {
                cmdNuevo.Enabled = true;
                cmdAddDetalle.Enabled = true;
                txtComentarios.Enabled = true;
                grDetalle.Enabled = true;
                dtFechaContabilizacion.Enabled = false;
                btnPrint.Enabled = false;
                cmdGuardar.Enabled = true;
                TsExoOIsv.ReadOnly = false;
                btnCopiarDe.Enabled = false;
                grdTipoOrden.Enabled = false;
                glRutaAprobacionOC.Enabled = false;
                comboBoxIntercom.Enabled = true;
                txtNumAtCard.Enabled = true;
                EdicionEspecialActiva = true;
                btnCopiarDe.Enabled = false;
                cmdGuardarArchivos.Enabled = true;
            }
                
            
            
        }

        int contador = 0;
        private void cmdGuardarArchivos_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;*.pdf;*.xlsx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    contador = 0;
            

                    foreach (var item in openFileDialog1.SafeFileNames)
                    {
                        // Create a new DataRow
                        DataRow newRow = dsCompras1.ordenes_compras_archivos.NewRow();

                        // Populate the DataRow with values
                        newRow["fecha_registro"] = DateTime.Now;
                        newRow["file_name"] = item;
                        newRow["user"] = UsuarioLogueado.NombreUser;
                        newRow["path"] = openFileDialog1.FileNames[contador];
                        newRow["id_tipo_doc"] = 1;
                        newRow["monto_cotizacion"] = 0.00;
                        newRow["descuento"] = 0.00;
                        newRow["total"] = 0.00;

                        if (gvFiles.RowCount == 0)
                            newRow["selected"] = true;
                        else
                            newRow["selected"] = false;

                        if (IdOrdenCompraActual!=0)
                            {
                                newRow["id_orden_compra_h"] = IdOrdenCompraActual;

                            }                      

                        // Add the DataRow to the DataTable
                        dsCompras1.ordenes_compras_archivos.Rows.Add(newRow);
                        contador++;

                    }
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Show(ex.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCompras.ordenes_compras_archivosRow)gvFiles.GetFocusedDataRow();

                if (row.id == 0)//No existe detalle, solo como memoria
                {
                    gvFiles.DeleteRow(gvFiles.FocusedRowHandle);
                    dsCompras1.AcceptChanges();
                }
                else
                {
                    bool Proceder = false;

                    switch (IdEstadoOrdenCompra)
                    {

                        case 1://Pendiente de Aprobacion
                            Proceder = true;
                            break;

                        case 2://Autorizado
                            Proceder = false;
                            break;

                        case 3://Rechazado
                            Proceder = false;
                            break;

                        case 4://Cancelado
                            Proceder = false;
                            break;

                        case 5://Creada (Borrador)
                            Proceder = true;
                            break;

                        default:
                            Proceder = false;

                            break;
                    }


                        if (Proceder)
                        {
                            FTP_Class fTP = new FTP_Class();


                            fTP.RemoveFile(row.path);

                            DataOperations dp = new DataOperations();
                            SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                            cnx.Open();

                            SqlCommand cmd = new SqlCommand("dbo.CM_delete_archivos_adjuntos", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                            cmd.ExecuteNonQuery();


                            gvFiles.DeleteRow(gvFiles.FocusedRowHandle);
                            dsCompras1.AcceptChanges();

                        }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Show(ex.Message);
            }



        }

        private void CargarOrdenCompraFromOrdenCompra(int idOrdenCompraSoloDetalle)
        {

            CMOrdenCompraH oc = new CMOrdenCompraH();
            if (oc.RecuperarRegistro(idOrdenCompraSoloDetalle))
            {
                //mmm si falta algo lo vemos luego, asi arrancaremos.
                txtComentarios.Text = oc.Comments;

                CargarDetalleOrdenCompra(idOrdenCompraSoloDetalle,2);//2: Detalle OC para crear Otra OC
            }

            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private bool Upload(string pathFile, string fileName,int id_compra_detalle)
        {

            try
            {

                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó el archivo");
                    return false;
                }
                else
                {
                    FTP_Class ftp1 = new FTP_Class();
                    return ftp1.GuardarArchivoCompras(UsuarioLogueado, fileName, pathFile, id_compra_detalle);
                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void btnDownload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FTP_Class ftp_claass = new FTP_Class();
                var row = (dsCompras.ordenes_compras_archivosRow)gvFiles.GetFocusedDataRow();

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (row.id != 0)
                    {

                        if (ftp_claass.DownloadFileFromCompras(row.path, Path.Combine(folderBrowserDialog1.SelectedPath, row.file_name), UsuarioLogueado))
                        {
                            CajaDialogo.Information("Archivo descargado en la ruta: " + folderBrowserDialog1.SelectedPath);

                        }

                    }
                }

               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmOrdenesCompraMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FTP_Class ftp = new FTP_Class();
                var row = (dsCompras.ordenes_compras_archivosRow) gvFiles.GetFocusedDataRow();

                if (row.id != 0)
                {
                    ftp.OpenFile(row.path, row.file_name);
                }
                else
                {
                    if (System.IO.File.Exists(row.path))
                    {
                        Process.Start(row.path);
                    }
                }

                

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposLigarPresupuesto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalle_exoneradaRow)gridview.GetFocusedDataRow();

            frmSeleccionPresupuestoLocal frm = new frmSeleccionPresupuestoLocal();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                row.id_detalle_presupuesto = frm.ItemSeleccionado.id;
                row.presupuesto_descripcion = frm.ItemSeleccionado.ItemName;
                dsCompras1.AcceptChanges();
            }

        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if (grdvDetalle.RowCount == 0)
            {
                CajaDialogo.Error("No existe detalle en la Orden de Compra!");
                return;
            }
            else
            {
                frmSeleccionPresupuestoLocal frm = new frmSeleccionPresupuestoLocal();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnPresupuesto.Text = frm.ItemSeleccionado.ItemName;

                    foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
                    {
                        item.id_detalle_presupuesto = frm.ItemSeleccionado.id;
                        item.presupuesto_descripcion = frm.ItemSeleccionado.ItemName;
                        dsCompras1.AcceptChanges();
                    }
                }
            }

            
        }

        private void gvFiles_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gcFiles.FocusedView;
            var row = (dsCompras.ordenes_compras_archivosRow)gridView.GetFocusedDataRow();

            try
            {
                switch (e.Column.FieldName)
                {
                    case "monto_cotizacion":

                        if (row.Ismonto_cotizacionNull())
                            row.monto_cotizacion = 0;

                        row.total = row.monto_cotizacion - row.descuento;
                        break;

                    case "descuento":

                        if (row.IsdescuentoNull())
                            row.monto_cotizacion = 0;
                        row.total = row.monto_cotizacion - row.descuento;
                        break;

                    default:
                        break;
                }

                if (row.id > 0)
                {
                    ActualizarDetalleArchivos(row.monto_cotizacion, row.descuento, row.id, row.id_tipo_doc);
                }
              
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ActualizarDetalleArchivos(decimal monto_cotizacion, decimal descuento, int id, int idtipoDoc)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_compras_set_update_archivos_detalle_cotizaciones", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@monto_cotizacion", monto_cotizacion);
                cmd.Parameters.AddWithValue("@descuento", descuento);
                cmd.Parameters.AddWithValue("@id_tipo_doc", idtipoDoc);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvFiles_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gcFiles.FocusedView;
            var row = (dsCompras.ordenes_compras_archivosRow)gridView.GetFocusedDataRow();

            try
            {
                switch (e.Column.FieldName)
                {
                    case "selected":

                        foreach (dsCompras.ordenes_compras_archivosRow item in dsCompras1.ordenes_compras_archivos)
                        {
                            if (item.selected)
                                item.selected = false;
                        }

                        row.selected = Convert.ToBoolean(e.Value);

                        break;


                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ActualizarArchivosSelected(int pid, bool pselected)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_compras_set_update_archivos_detalle_cotizaciones_selected]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pid);
                cmd.Parameters.AddWithValue("@selected", pselected);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarArchivos()
        {
            try
            {
                string query = @"[dbo].[usp_GetArchivosFromOrdenesCompras]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_compra_h", SqlDbType.Int).Value = IdOrdenCompraActual;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.ordenes_compras_archivos.Clear();
                adat.Fill(dsCompras1.ordenes_compras_archivos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}