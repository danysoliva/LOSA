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

namespace LOSA.Compras
{
    public partial class frmOrdenesCompraMain : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        TipoOperacion tipooperacion;
        int IdOrdenCompraActual;
        int IdEstadoOrdenCompra;
        int IdSolicitud = 0;
        string direccion;
        int ContactCode;
        char CurSource;
        decimal TasaCambio;
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
            CargarBodegas();
            CargarRutasAprobacion();
            cbxMoneda.Text = "Moneda local";
            //UsuarioLogueado = pUserLog;
            tipooperacion = ptipo;
            IdOrdenCompraActual = pIdOrdenCompraH;

            switch (tipooperacion)
            {
                case TipoOperacion.New:
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
            btnShowPopu.Enabled = false;
            cmdAddDetalle.Enabled = false;
            txtCodProv.Enabled = false;
            dtFechaContabilizacion.Enabled = false;
            grdTipoOrden.Enabled = false;
            TsExoOIsv.ReadOnly = true;
            glRutaAprobacionOC.Enabled = false;
            comboBoxIntercom.Enabled = false;
            comboBoxIntercom.Enabled = false;

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

        }

        public frmOrdenesCompraMain(UserLogin pUserLog, TipoOperacion ptipo)
        {
            InitializeComponent();
            LoadTipoOrden();
            TsExoOIsv.IsOn = true;
            ObtenerExoneracionVigente();
            CargarCapitulos();
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
                default:
                    break;
            }

            ValidarAccesosSegunUsuario();
            btnPrint.Enabled = true;
            btnShowPopu.Enabled = true;
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

                    lblSucursal.Visible = false;
                    break;
                case GrupoUser.GrupoUsuario.Compras:
                    lblSucursal.Visible = false;
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
                txtProveedor.Text = frm.ItemSeleccionado.ItemName;
                Proveedor prov = new Proveedor();
                prov.RecuperarRegistroWithRTN(frm.ItemSeleccionado.ItemCode);
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
                    cbxMoneda.Text = "Moneda local";
                    txtTasaCambio.Visible = false;
                }

                cmdNuevo.Enabled = true;
                btnShowPopu.Enabled = true;
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
            switch (tipooperacion)
            {
                case TipoOperacion.New:

                    frmCopiarDeSolicitud frm = new frmCopiarDeSolicitud();
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

        private void CargarDetalleOrdenCompra(int idSolicitudSeleccionado)
        {
            CargarPartidasArancelarias();
            try
            {
                string query = @"[sp_get_compras_ordenes_detalle]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_header_orden", idSolicitudSeleccionado);
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

                    case "indicador_impuesto": //EXO EXE ISV

                        var gridviewiva = (GridView)grDetalle.FocusedView;
                        var rowiva = (dsCompras.oc_detalle_exoneradaRow)gridviewiva.GetFocusedDataRow();

                        switch (rowiva.indicador_impuesto)
                        {
                            case "EXE"://EXENTO

                                rowiva.isv = 0;
                                txtImpuesto.EditValue = 0.00;
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
                                CalcularTotal();

                                break;

                            case "ISVE"://0.18

                                rowiva.isv = rowiva.total * 0.18M;
                                string.Format("{0:0,0.00}", rowiva.isv);
                                rowiva.capitulo = " ";
                                rowiva.partida_arancelaria = " ";
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

            switch (IdEstadoOrdenCompra)
            {
                case 1://Pendiente (Creada)
                    break;

                case 2://Autorizado
                    CajaDialogo.Error("No se pueden realizar modificaciones en una Orden de Compra ya Autorizada!");
                    break;
                case 3://Rechazado
                    CajaDialogo.Error("No se pueden realizar modificaciones en una Orden de Compra ya Rechazada!");
                    break;
                default:
                    break;
            }

            DialogResult r = CajaDialogo.Pregunta("Confirma que desea elminar este registro?");
            if (r != DialogResult.Yes)
            {
                return;
            }

            var grdvDetalle = (GridView)grDetalle.FocusedView;
            var row = (dsCompras.oc_detalle_exoneradaRow)grdvDetalle.GetFocusedDataRow();

            if (row.id_d_orden > 0 || string.IsNullOrEmpty(row.id_d_orden.ToString()))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_cm_delete_linea_detalle", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalle_oc", row.id_d_orden);
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
                        break;

                    case "EXO":
                        valor_impuesto = 0;
                        break;

                    case "ISV":
                        valor_impuesto = 0.15M;

                        break;

                    case "ISVE":
                        valor_impuesto = 0.18M;
                        break;
                    default:
                        break;
                }

                txtImpuesto.EditValue = string.Format("{0:##,###,##0.##}", SubTotal * valor_impuesto);// decimal.Round(SubTotal * valor_impuesto, 2, MidpointRounding.AwayFromZero);
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
            glRutaAprobacionOC.Text = string.Empty;
            grdTipoOrden.Text = string.Empty;
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
            //GetSigID();

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchOrdenC frm = new frmSearchOrdenC(frmSearchOrdenC.FiltroOrdenesCompra.Todas, UsuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //CargarSolicitud(frm.IdSolicitudSeleccionado);
                CargarInfoOrden(frm.IdOrdenesSeleccionado);
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

                CargarDetalleOrdenCompra(IdOrdenCompraActual);
                tipooperacion = TipoOperacion.Update;

                switch (IdEstadoOrdenCompra)
                {
                    case 1://Pendiente(Creada)
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = true;
                        txtComentarios.Enabled = true;
                        grDetalle.Enabled = true;
                        dtFechaContabilizacion.Enabled = true;
                        cmdGuardar.Enabled = true;
                        //btnPrint.Enabled = false;
                        break;

                    case 2://Autorizado
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        btnPrint.Enabled = true;
                        cmdGuardar.Enabled = false;
                        TsExoOIsv.ReadOnly = true;
                        btnShowPopu.Enabled = false;
                        grdTipoOrden.Enabled = false;
                        glRutaAprobacionOC.Enabled = false;
                        comboBoxIntercom.Enabled = false;
                        txtNumAtCard.Enabled = false;
                        
                        break;

                    case 3://Rechazada
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        TsExoOIsv.ReadOnly = true;
                        btnShowPopu.Enabled = false;
                        break;

                    case 4:
                        cmdNuevo.Enabled = true;
                        cmdAddDetalle.Enabled = false;
                        txtComentarios.Enabled = false;
                        grDetalle.Enabled = false ;
                        dtFechaContabilizacion.Enabled = false;
                        cmdGuardar.Enabled = false;
                        TsExoOIsv.ReadOnly = true;
                        btnShowPopu.Enabled = false;
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
            this.Close();
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            tipooperacion = TipoOperacion.Update;
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
                    break;
                case TipoOperacion.Update:

                    switch (IdEstadoOrdenCompra)
                    {
                        case 1://Pendiente (Creada)

                            DialogResult r = CajaDialogo.Pregunta("Se va Actualizar esta Orden de Compra.\nEsta Seguro?");
                            if (r != System.Windows.Forms.DialogResult.Yes)
                                return;

                            break;

                        case 2://Autorizado
                            CajaDialogo.Error("La Orden ya fue Aprobada, no se puede Editar!");
                            
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
                CajaDialogo.Error("Debe seleccionar el tipo de orden de compra!");
                return;
            }

 
            if (string.IsNullOrEmpty(cbxMoneda.Text))
            {
                CajaDialogo.Error("Debe seleccionar la moneda para la orden de compra!");
                return;
            }

            if (string.IsNullOrEmpty(dtFechaContabilizacion.Text))
            {
                CajaDialogo.Error("Debe seleccionar la fecha de contabilizacion de la orden de compra!");
                return;
            }

            if (Convert.ToInt32(grdTipoOrden.EditValue) == 1) //Orden de Compra de Materia Prima
            {
                if (string.IsNullOrEmpty(comboBoxIntercom.Text))
                {
                    CajaDialogo.Error("La Orden es de Materia Prima.\nNo puede dejar vacio el campo Incoterm!");
                    comboBoxIntercom.Focus();
                    return;
                }
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
                    
                }
            }

            //if (TsExoOIsv.IsOn)
            //{
            //    dsCompras1.SaldosMemoria.Clear();
            //    bool PrimeraIteracion = true;
            //    foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
            //    {
            //        foreach (dsCompras.SaldosMemoriaRow rowMemoria in dsCompras1.SaldosMemoria)
            //        {
            //            PrimeraIteracion = false;

            //            if (rowMemoria.existe)
            //            {
            //                rowMemoria.total += item.total;
            //            }
            //            else
            //            {
            //                if (item.capitulo == rowMemoria.capitulo)
            //                {
            //                    if (item.partida_arancelaria == rowMemoria.partida_arancelaria)
            //                    {
            //                        DataRow drow = dsCompras1.SaldosMemoria.NewRow();
            //                        drow[0] = item.capitulo;
            //                        drow[1] = item.partida_arancelaria;
            //                        drow[2] = item.itemcode;
            //                        drow[3] = item.cantidad;
            //                        drow[4] = item.precio_por_unidad;
            //                        drow[5] = item.indicador_impuesto;
            //                        drow[6] = item.total;

            //                        dsCompras1.SaldosMemoria.Rows.Add(drow);
            //                        dsCompras1.SaldosMemoria.AcceptChanges();
            //                    }
            //                }
            //                else
            //                {
            //                    DataRow drow = dsCompras1.SaldosMemoria.NewRow();
            //                    drow[0] = item.capitulo;
            //                    drow[1] = item.partida_arancelaria;
            //                    drow[2] = item.itemcode;
            //                    drow[3] = item.cantidad;
            //                    drow[4] = item.precio_por_unidad;
            //                    drow[5] = item.indicador_impuesto;
            //                    drow[6] = item.total;

            //                    dsCompras1.SaldosMemoria.Rows.Add(drow);
            //                    dsCompras1.SaldosMemoria.AcceptChanges();
            //                }
            //            }

                        
            //        }

            //        if (PrimeraIteracion)
            //        {
            //            DataRow drow = dsCompras1.SaldosMemoria.NewRow();
            //            drow[0] = item.capitulo;
            //            drow[1] = item.partida_arancelaria;
            //            drow[2] = item.itemcode;
            //            drow[3] = item.cantidad;
            //            drow[4] = item.precio_por_unidad;
            //            drow[5] = item.indicador_impuesto;
            //            drow[6] = item.total;

            //            dsCompras1.SaldosMemoria.Rows.Add(drow);
            //            dsCompras1.SaldosMemoria.AcceptChanges();
            //        }
            //    }
            //}

            //Consolidados de Saldos por Capitulo y Rubro
           
            bool PermitirGuardar = false;

            //#region VALIDACION FINAL : EN PROCESO

            //foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
            //{
            //    //Cada vez que pase por aqui, guardaremos en memoria el Detalle
            //    //Para validar el Saldo Disponible en Kardex - Saldo de la Linea - Saldo de la Linea en Memoria que compartan Capitulo o Capitulo y Partida!


            //    string Capitulo = "";
            //    string Partida = "";
            //    decimal SaldoDisponible = 0;
            //    decimal UnidadesDisponibles = 0;
            //    decimal NuevoSaldo = 0;

            //    if (item.indicador_impuesto == "EXO")
            //    {
            //        if (string.IsNullOrEmpty(item.partida_arancelaria) || string.IsNullOrWhiteSpace(item.partida_arancelaria))
            //        {
            //            //Validemos el Capitulo
            //            try
            //            {
            //                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //                conn.Open();
            //                SqlCommand cmd = new SqlCommand("sp_CM_validacion_saldos_por_capitulo", conn);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@Monto", item.total);
            //                cmd.Parameters.AddWithValue("@Capitulo", item.capitulo);
            //                SqlDataReader dr = cmd.ExecuteReader();
            //                if (dr.Read())
            //                {
            //                    PermitirGuardar = dr.GetBoolean(0);
            //                    SaldoDisponible = dr.GetDecimal(1);
            //                    Capitulo = dr.GetString(2);
            //                }
            //                dr.Close();
            //                conn.Close();

            //                if (PermitirGuardar == false)
            //                {
            //                    string mensaje = "No hay suficiente Saldo Disponible en el Capitulo: " + Capitulo + "\n Saldo Disponible para Exoneracion: " + SaldoDisponible + "\n";
            //                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
            //                    return;
            //                }
            //                else //Si hay Saldo, Vamos a Validar si en Memoria hay algun Coincidencia
            //                {
            //                    foreach (dsCompras.SaldosMemoriaRow rowMemoria in dsCompras1.SaldosMemoria.Rows)
            //                    {
            //                        if (rowMemoria.capitulo == item.capitulo)
            //                        {
            //                            if (rowMemoria.partida_arancelaria == item.partida_arancelaria)
            //                            {
            //                                NuevoSaldo = SaldoDisponible - rowMemoria.total;
            //                                if (NuevoSaldo <= 0)
            //                                {
            //                                    string mensaje = "No hay suficiente Saldo Disponible en el Capitulo: " + Capitulo + "\n Saldo Disponible para Exoneracion: " + SaldoDisponible + "\n";
            //                                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
            //                                    return;
            //                                }
            //                            }
            //                        }
            //                    }
            //                }

            //            }
            //            catch (Exception ex)
            //            {
            //                CajaDialogo.Error(ex.Message);
            //            }
            //        }
            //        else
            //        {
            //            //Validemos el Capitulo y la Partida

            //        }
            //    }
            //}

            //#endregion

            #region VALIDACION DE SALDO: SOLO FUNCIONA LINEA POR LINEA

            //foreach (dsCompras.oc_detalle_exoneradaRow item in dsCompras1.oc_detalle_exonerada)
            //{
            //    string Capitulo = "";
            //    string Partida = "";
            //    decimal SaldoDisponible = 0;
            //    decimal UnidadesDisponibles = 0;


            //    if (item.indicador_impuesto == "EXO")
            //    {
            //        if (string.IsNullOrEmpty(item.partida_arancelaria) || string.IsNullOrWhiteSpace(item.partida_arancelaria))
            //        {
            //            try
            //            {
            //                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //                conn.Open();
            //                SqlCommand cmd = new SqlCommand("sp_CM_validacion_saldos_por_capitulo", conn);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@Monto", item.total);
            //                cmd.Parameters.AddWithValue("@Capitulo", item.capitulo);
            //                SqlDataReader dr = cmd.ExecuteReader();
            //                if (dr.Read())
            //                {
            //                    PermitirGuardar = dr.GetBoolean(0);
            //                    SaldoDisponible = dr.GetDecimal(1);
            //                    Capitulo = dr.GetString(2);
            //                }
            //                dr.Close();
            //                conn.Close();

            //                if (PermitirGuardar == false)
            //                {
            //                    string mensaje = "No hay suficiente Saldo Disponible en el Capitulo: " + Capitulo + "\n Saldo Disponible para Exoneracion: " + SaldoDisponible + "\n";
            //                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
            //                    return;
            //                }

            //            }
            //            catch (Exception ex)
            //            {
            //                CajaDialogo.Error(ex.Message);
            //            }
            //        }
            //        else
            //        {
            //            try
            //            {
            //                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //                conn.Open();
            //                SqlCommand cmd = new SqlCommand("sp_CM_validacion_saldos_por_capitulo_y_partida", conn);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@Monto", item.total);
            //                cmd.Parameters.AddWithValue("@Unidades", item.cantidad);
            //                cmd.Parameters.AddWithValue("@Capitulo", item.capitulo);
            //                cmd.Parameters.AddWithValue("@PartidaArancelaria", item.partida_arancelaria);
            //                SqlDataReader dr = cmd.ExecuteReader();
            //                if (dr.Read())
            //                {
            //                    PermitirGuardar = dr.GetBoolean(0);
            //                    Capitulo = dr.GetString(1);
            //                    Partida = dr.GetString(2);
            //                    SaldoDisponible = dr.GetDecimal(3);
            //                    UnidadesDisponibles = dr.GetDecimal(4);
            //                }
            //                dr.Close();
            //                conn.Close();

            //                if (PermitirGuardar == false)
            //                {
            //                    string mensaje = "No hay suficiente Saldo Disponible en el Capitulo: " + Capitulo + " con la Partida Arancelaria #: " + Partida + "\n Saldo Disponible para Exoneracion: " + SaldoDisponible + "\n Unidades Disponibles para Exoneracion: " + UnidadesDisponibles;
            //                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
            //                    frm.ShowDialog();
            //                    return;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                CajaDialogo.Error(ex.Message);
            //            }
            //        }
            //    }
            //}

            #endregion


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
                        cmd.CommandText = "[sp_CM_insert_ordencompra_h_v2]";
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
                        if (string.IsNullOrEmpty(comboBoxIntercom.Text))
                            cmd.Parameters.AddWithValue("@U_incoterm", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@U_incoterm", comboBoxIntercom.Text.Trim());

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsCompras.oc_detalle_exoneradaRow row in dsCompras1.oc_detalle_exonerada.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_insert_detalle_orden_compra_SAP";
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
                            cmd.ExecuteNonQuery();
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
                        cmdUpdate.CommandText = "sp_CM_update_ordencompra_h";
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
                        if (string.IsNullOrEmpty(comboBoxIntercom.Text))
                            cmdUpdate.Parameters.AddWithValue("@U_incoterm", DBNull.Value);
                        else
                            cmdUpdate.Parameters.AddWithValue("@U_incoterm", comboBoxIntercom.Text.Trim());

                        cmdUpdate.ExecuteNonQuery();

                        foreach (dsCompras.oc_detalle_exoneradaRow row in dsCompras1.oc_detalle_exonerada.Rows)
                        {
                            cmdUpdate.Parameters.Clear();
                            cmdUpdate.CommandText = "sp_compras_ordenes_detalle_update_insert";
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
                            cmdUpdate.ExecuteNonQuery();
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
                    CajaDialogo.Error("No se pudo definir una Operacion de Tipo(INSERT-UPDATE)");
                    break;
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
                    reportPrint.ShowPreview();
                }
                else
                {
                    rptOrdenCompra report = new rptOrdenCompra(IdOrdenCompraActual);
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool reportPrint = new ReportPrintTool(report);
                    reportPrint.ShowPreview();
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar una Orden de Compra!");
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
                case 1: //Nueva 
                    Proceder = true;
                    break;

                case 2: //Autorizada
                    Proceder = false;
                    mensaje = "No se puede Cancelar\nLa Orden Compra ya fue Autorizada!";
                    break;

                case 3: //Rechazada
                    Proceder = false;
                    mensaje = "No se puede Cancelar\nLa Orden de Compra fue Rechazada!";
                    break;

                case 4: //Cancelada
                    Proceder = false;
                    mensaje = "La Orden de Compra se encuentra Cancelada!";
                    break;

                default:
                    Proceder = false;
                    break;
            }

            popupMenu1.HidePopup();

            //if (Proceder)
            //{
            //    try
            //    {
            //        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand("sp_compras_cancelar_orden", conn);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@id_OrdenCompra", pidOrdenCompraActual);
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        CajaDialogo.Information("Orden de Compra Cancelada!");

            //        cmdNuevo.Enabled = false;
            //        cmdAddDetalle.Enabled = false;
            //        txtComentarios.Enabled = false;
            //        grDetalle.Enabled = false;
            //        dtFechaContabilizacion.Enabled = false;
            //        txtComentarios.Text = "Cancelada";

            //    }
            //    catch (Exception ex)
            //    {
            //        CajaDialogo.Error(ex.Message);
            //    }
            //}
            //else
            //{
            //    CajaDialogo.Error(mensaje);
            //    return;
            //}
        }

        private void grdSucursales_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void TsTipoOrden_Toggled(object sender, EventArgs e)
        {

        }

        private void TsExoOIsv_Toggled(object sender, EventArgs e)
        {
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

                CalcularTotal();
            }
        }

        private void ObtenerExoneracionVigente()
        {
            try
            {
                string query = @"SELECT top 1 [resolucion_exonerada]
                                  FROM [LOSA].[dbo].[CM_exoneracion_h]
                                  where enable = 1 and cerrado = 0
                                  order by 1 desc";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
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
                cmd.Parameters.AddWithValue("@fecha", dp.dNow());
                ret= Convert.ToDecimal(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return ret;
        }

       

        private void reposGrdIndicadorIVA_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenesCompraMain));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxIntercom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barbtnCancelOrden = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNumAtCard = new System.Windows.Forms.TextBox();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaContabilizacion = new DevExpress.XtraEditors.DateEdit();
            this.glRutaAprobacionOC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bsRutaAprobacion = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtExoneracion = new System.Windows.Forms.TextBox();
            this.lblExoneracion = new DevExpress.XtraEditors.LabelControl();
            this.txtTasaCambio = new DevExpress.XtraEditors.TextEdit();
            this.txtMoneda = new DevExpress.XtraEditors.TextEdit();
            this.cbxMoneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TsExoOIsv = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.grdTipoOrden = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipoordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtContactoPerson = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblSucursal = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodProv = new DevExpress.XtraEditors.ButtonEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAddDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsuarioCreador = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.grdvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_d_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposGrdCapitulo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_AQUA_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartida_arancelaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposPartidaArancelaria = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.partidaarancelariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_por_unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindicador_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposGrdIndicadorIVA = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.ivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposGrdBodega = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWhsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia_base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.btnShowPopu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDetalleOrden = new DevExpress.XtraTab.XtraTabPage();
            this.tabArchivosAdjuntos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxIntercom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaContabilizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaContabilizacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glRutaAprobacionOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRutaAprobacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TsExoOIsv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdCapitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPartidaArancelaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdIndicadorIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabDetalleOrden.SuspendLayout();
            this.tabArchivosAdjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.comboBoxIntercom);
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Controls.Add(this.txtID);
            this.panelControl1.Controls.Add(this.txtNumAtCard);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.dtFechaContabilizacion);
            this.panelControl1.Controls.Add(this.glRutaAprobacionOC);
            this.panelControl1.Controls.Add(this.labelControl15);
            this.panelControl1.Controls.Add(this.txtDireccion);
            this.panelControl1.Controls.Add(this.labelControl14);
            this.panelControl1.Controls.Add(this.txtExoneracion);
            this.panelControl1.Controls.Add(this.lblExoneracion);
            this.panelControl1.Controls.Add(this.txtTasaCambio);
            this.panelControl1.Controls.Add(this.txtMoneda);
            this.panelControl1.Controls.Add(this.cbxMoneda);
            this.panelControl1.Controls.Add(this.TsExoOIsv);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.grdTipoOrden);
            this.panelControl1.Controls.Add(this.txtContactoPerson);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.lblSucursal);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.txtCodProv);
            this.panelControl1.Controls.Add(this.txtProveedor);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dtFechaRegistro);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtEstado);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtDocNum);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cmdClose);
            this.panelControl1.Controls.Add(this.cmdGuardar);
            this.panelControl1.Controls.Add(this.cmdNuevo);
            this.panelControl1.Controls.Add(this.cmdBuscar);
            this.panelControl1.Controls.Add(this.cmdSiguiente);
            this.panelControl1.Controls.Add(this.cmdAnterior);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Location = new System.Drawing.Point(4, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1564, 208);
            this.panelControl1.TabIndex = 51;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // comboBoxIntercom
            // 
            this.comboBoxIntercom.Location = new System.Drawing.Point(1164, 183);
            this.comboBoxIntercom.MenuManager = this.barManager1;
            this.comboBoxIntercom.Name = "comboBoxIntercom";
            this.comboBoxIntercom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxIntercom.Properties.Appearance.Options.UseFont = true;
            this.comboBoxIntercom.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxIntercom.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxIntercom.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxIntercom.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboBoxIntercom.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxIntercom.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboBoxIntercom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxIntercom.Properties.Items.AddRange(new object[] {
            "FOB",
            "EXW",
            "CIF",
            "CFR",
            "FCA",
            "CPT",
            "CIP",
            "DPU",
            "DAP",
            "DDP",
            "FAS",
            "DAT"});
            this.comboBoxIntercom.Size = new System.Drawing.Size(189, 22);
            this.comboBoxIntercom.TabIndex = 95;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnCancelOrden});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1571, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 885);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1571, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 844);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1571, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 844);
            // 
            // barbtnCancelOrden
            // 
            this.barbtnCancelOrden.Caption = "Cancelar";
            this.barbtnCancelOrden.Id = 0;
            this.barbtnCancelOrden.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelOrden.ImageOptions.Image")));
            this.barbtnCancelOrden.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnCancelOrden.ImageOptions.LargeImage")));
            this.barbtnCancelOrden.Name = "barbtnCancelOrden";
            this.barbtnCancelOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCancelOrden_ItemClick);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(994, 189);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(209, 16);
            this.labelControl17.TabIndex = 94;
            this.labelControl17.Text = "INCOTERM__________________";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtID.Location = new System.Drawing.Point(220, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(49, 16);
            this.txtID.TabIndex = 93;
            this.txtID.Visible = false;
            // 
            // txtNumAtCard
            // 
            this.txtNumAtCard.BackColor = System.Drawing.Color.White;
            this.txtNumAtCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAtCard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNumAtCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumAtCard.Location = new System.Drawing.Point(220, 160);
            this.txtNumAtCard.Name = "txtNumAtCard";
            this.txtNumAtCard.Size = new System.Drawing.Size(336, 16);
            this.txtNumAtCard.TabIndex = 92;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(48, 161);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(299, 16);
            this.labelControl16.TabIndex = 91;
            this.labelControl16.Text = "No. Ref. del Acreedor____________________";
            // 
            // dtFechaContabilizacion
            // 
            this.dtFechaContabilizacion.EditValue = null;
            this.dtFechaContabilizacion.Location = new System.Drawing.Point(1164, 52);
            this.dtFechaContabilizacion.MenuManager = this.barManager1;
            this.dtFechaContabilizacion.Name = "dtFechaContabilizacion";
            this.dtFechaContabilizacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtFechaContabilizacion.Properties.Appearance.Options.UseFont = true;
            this.dtFechaContabilizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaContabilizacion.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaContabilizacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaContabilizacion.Size = new System.Drawing.Size(189, 22);
            this.dtFechaContabilizacion.TabIndex = 90;
            // 
            // glRutaAprobacionOC
            // 
            this.glRutaAprobacionOC.Location = new System.Drawing.Point(1164, 159);
            this.glRutaAprobacionOC.MenuManager = this.barManager1;
            this.glRutaAprobacionOC.Name = "glRutaAprobacionOC";
            this.glRutaAprobacionOC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.glRutaAprobacionOC.Properties.Appearance.Options.UseFont = true;
            this.glRutaAprobacionOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glRutaAprobacionOC.Properties.DataSource = this.bsRutaAprobacion;
            this.glRutaAprobacionOC.Properties.DisplayMember = "descripcion";
            this.glRutaAprobacionOC.Properties.NullText = "";
            this.glRutaAprobacionOC.Properties.PopupView = this.gridView3;
            this.glRutaAprobacionOC.Properties.ValueMember = "id";
            this.glRutaAprobacionOC.Size = new System.Drawing.Size(189, 22);
            this.glRutaAprobacionOC.TabIndex = 89;
            // 
            // bsRutaAprobacion
            // 
            this.bsRutaAprobacion.DataMember = "rutas_aprobacion";
            this.bsRutaAprobacion.DataSource = this.dsCompras1;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(994, 165);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(262, 16);
            this.labelControl15.TabIndex = 88;
            this.labelControl15.Text = "Depto Aprobación__________________";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDireccion.Location = new System.Drawing.Point(220, 140);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(336, 16);
            this.txtDireccion.TabIndex = 87;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(48, 141);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(212, 16);
            this.labelControl14.TabIndex = 86;
            this.labelControl14.Text = "Dirección___________________";
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.BackColor = System.Drawing.Color.White;
            this.txtExoneracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExoneracion.Enabled = false;
            this.txtExoneracion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtExoneracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExoneracion.Location = new System.Drawing.Point(1164, 141);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.Size = new System.Drawing.Size(189, 16);
            this.txtExoneracion.TabIndex = 85;
            this.txtExoneracion.Text = "E2023002421";
            // 
            // lblExoneracion
            // 
            this.lblExoneracion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExoneracion.Appearance.Options.UseFont = true;
            this.lblExoneracion.Location = new System.Drawing.Point(994, 141);
            this.lblExoneracion.Name = "lblExoneracion";
            this.lblExoneracion.Size = new System.Drawing.Size(204, 16);
            this.lblExoneracion.TabIndex = 84;
            this.lblExoneracion.Text = "# Exoneracion______________";
            // 
            // txtTasaCambio
            // 
            this.txtTasaCambio.Enabled = false;
            this.txtTasaCambio.Location = new System.Drawing.Point(326, 181);
            this.txtTasaCambio.MenuManager = this.barManager1;
            this.txtTasaCambio.Name = "txtTasaCambio";
            this.txtTasaCambio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTasaCambio.Properties.Appearance.Options.UseFont = true;
            this.txtTasaCambio.Size = new System.Drawing.Size(122, 22);
            this.txtTasaCambio.TabIndex = 83;
            // 
            // txtMoneda
            // 
            this.txtMoneda.Enabled = false;
            this.txtMoneda.Location = new System.Drawing.Point(220, 181);
            this.txtMoneda.MenuManager = this.barManager1;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMoneda.Properties.Appearance.Options.UseFont = true;
            this.txtMoneda.Size = new System.Drawing.Size(100, 22);
            this.txtMoneda.TabIndex = 82;
            // 
            // cbxMoneda
            // 
            this.cbxMoneda.Enabled = false;
            this.cbxMoneda.Location = new System.Drawing.Point(48, 181);
            this.cbxMoneda.MenuManager = this.barManager1;
            this.cbxMoneda.Name = "cbxMoneda";
            this.cbxMoneda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxMoneda.Properties.Appearance.Options.UseFont = true;
            this.cbxMoneda.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxMoneda.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxMoneda.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxMoneda.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cbxMoneda.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbxMoneda.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMoneda.Properties.Items.AddRange(new object[] {
            "Moneda local",
            "Moneda del sistema",
            "Moneda SN"});
            this.cbxMoneda.Size = new System.Drawing.Size(170, 22);
            this.cbxMoneda.TabIndex = 81;
            this.cbxMoneda.SelectedValueChanged += new System.EventHandler(this.comboBoxEdit1_SelectedValueChanged);
            // 
            // TsExoOIsv
            // 
            this.TsExoOIsv.EditValue = true;
            this.TsExoOIsv.Location = new System.Drawing.Point(1164, 119);
            this.TsExoOIsv.MenuManager = this.barManager1;
            this.TsExoOIsv.Name = "TsExoOIsv";
            this.TsExoOIsv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.TsExoOIsv.Properties.Appearance.Options.UseFont = true;
            this.TsExoOIsv.Properties.OffText = "No";
            this.TsExoOIsv.Properties.OnText = "Si";
            this.TsExoOIsv.Size = new System.Drawing.Size(189, 20);
            this.TsExoOIsv.TabIndex = 76;
            this.TsExoOIsv.Toggled += new System.EventHandler(this.TsExoOIsv_Toggled);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(994, 121);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(238, 16);
            this.labelControl13.TabIndex = 80;
            this.labelControl13.Text = "OC Exonerada __________________";
            // 
            // grdTipoOrden
            // 
            this.grdTipoOrden.Location = new System.Drawing.Point(1164, 95);
            this.grdTipoOrden.MenuManager = this.barManager1;
            this.grdTipoOrden.Name = "grdTipoOrden";
            this.grdTipoOrden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdTipoOrden.Properties.Appearance.Options.UseFont = true;
            this.grdTipoOrden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoOrden.Properties.DataSource = this.tipoordenBindingSource;
            this.grdTipoOrden.Properties.DisplayMember = "descripcion";
            this.grdTipoOrden.Properties.NullText = "";
            this.grdTipoOrden.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoOrden.Properties.ValueMember = "id";
            this.grdTipoOrden.Size = new System.Drawing.Size(189, 22);
            this.grdTipoOrden.TabIndex = 79;
            // 
            // tipoordenBindingSource
            // 
            this.tipoordenBindingSource.DataMember = "tipo_orden";
            this.tipoordenBindingSource.DataSource = this.dsCompras1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion,
            this.colconcat_});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // colconcat_
            // 
            this.colconcat_.Caption = "Seleccione el Tipo";
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.Visible = true;
            this.colconcat_.VisibleIndex = 0;
            // 
            // txtContactoPerson
            // 
            this.txtContactoPerson.BackColor = System.Drawing.Color.White;
            this.txtContactoPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactoPerson.Enabled = false;
            this.txtContactoPerson.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtContactoPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtContactoPerson.Location = new System.Drawing.Point(220, 119);
            this.txtContactoPerson.Name = "txtContactoPerson";
            this.txtContactoPerson.Size = new System.Drawing.Size(336, 16);
            this.txtContactoPerson.TabIndex = 78;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(47, 120);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(225, 16);
            this.labelControl12.TabIndex = 77;
            this.labelControl12.Text = "Persona de Contacto___________";
            // 
            // lblSucursal
            // 
            this.lblSucursal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.Appearance.Options.UseFont = true;
            this.lblSucursal.Location = new System.Drawing.Point(994, 101);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(234, 16);
            this.lblSucursal.TabIndex = 75;
            this.lblSucursal.Text = "Tipo de Orden__________________";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(275, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 33);
            this.btnPrint.TabIndex = 73;
            this.btnPrint.ToolTip = "Impirmir";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtCodProv
            // 
            this.txtCodProv.Location = new System.Drawing.Point(220, 69);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCodProv.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.txtCodProv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtCodProv.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCodProv.Properties.ReadOnly = true;
            this.txtCodProv.Size = new System.Drawing.Size(336, 22);
            this.txtCodProv.TabIndex = 69;
            this.txtCodProv.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCodProv_ButtonClick);
            this.txtCodProv.Click += new System.EventHandler(this.txtCodProv_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(220, 94);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Size = new System.Drawing.Size(336, 22);
            this.txtProveedor.TabIndex = 70;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(994, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(226, 16);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Fecha Contabilizacion___________";
            // 
            // dtFechaRegistro
            // 
            this.dtFechaRegistro.Enabled = false;
            this.dtFechaRegistro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRegistro.Location = new System.Drawing.Point(1164, 28);
            this.dtFechaRegistro.Name = "dtFechaRegistro";
            this.dtFechaRegistro.Size = new System.Drawing.Size(189, 23);
            this.dtFechaRegistro.TabIndex = 63;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(994, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(185, 16);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Fecha Registro___________";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEstado.Location = new System.Drawing.Point(1164, 77);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(189, 16);
            this.txtEstado.TabIndex = 61;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(994, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(189, 16);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Estado__________________";
            // 
            // txtDocNum
            // 
            this.txtDocNum.BackColor = System.Drawing.Color.White;
            this.txtDocNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocNum.Enabled = false;
            this.txtDocNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDocNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDocNum.Location = new System.Drawing.Point(222, 48);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(148, 16);
            this.txtDocNum.TabIndex = 57;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(48, 48);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(200, 16);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Num Doc__________________";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdClose.Location = new System.Drawing.Point(1509, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(47, 33);
            this.cmdClose.TabIndex = 52;
            this.cmdClose.ToolTip = "Cerrar Ventana";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(222, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(47, 33);
            this.cmdGuardar.TabIndex = 51;
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.ImageOptions.Image")));
            this.cmdNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdNuevo.Location = new System.Drawing.Point(169, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(47, 33);
            this.cmdNuevo.TabIndex = 50;
            this.cmdNuevo.ToolTip = "Nuevo";
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdBuscar.ImageOptions.SvgImage")));
            this.cmdBuscar.Location = new System.Drawing.Point(116, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(47, 33);
            this.cmdBuscar.TabIndex = 49;
            this.cmdBuscar.ToolTip = "Buscar";
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSiguiente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdSiguiente.ImageOptions.SvgImage")));
            this.cmdSiguiente.Location = new System.Drawing.Point(63, 12);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(47, 33);
            this.cmdSiguiente.TabIndex = 48;
            this.cmdSiguiente.ToolTip = "Siguiente";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAnterior.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAnterior.ImageOptions.SvgImage")));
            this.cmdAnterior.Location = new System.Drawing.Point(10, 12);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(47, 33);
            this.cmdAnterior.TabIndex = 47;
            this.cmdAnterior.ToolTip = "Anterior";
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 71);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(181, 16);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Proveedor______________";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(186, 16);
            this.labelControl6.TabIndex = 72;
            this.labelControl6.Text = "Nombre_________________";
            // 
            // cmdAddDetalle
            // 
            this.cmdAddDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddDetalle.ImageOptions.Image")));
            this.cmdAddDetalle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAddDetalle.Location = new System.Drawing.Point(27, 0);
            this.cmdAddDetalle.Name = "cmdAddDetalle";
            this.cmdAddDetalle.Size = new System.Drawing.Size(33, 28);
            this.cmdAddDetalle.TabIndex = 67;
            this.cmdAddDetalle.Tag = "Agregar Item o Servicio";
            this.cmdAddDetalle.ToolTip = "Guardar";
            this.cmdAddDetalle.Click += new System.EventHandler(this.cmdAddDetalle_Click);
            // 
            // txtUsuarioCreador
            // 
            this.txtUsuarioCreador.BackColor = System.Drawing.Color.White;
            this.txtUsuarioCreador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCreador.Enabled = false;
            this.txtUsuarioCreador.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioCreador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUsuarioCreador.Location = new System.Drawing.Point(154, 8);
            this.txtUsuarioCreador.Name = "txtUsuarioCreador";
            this.txtUsuarioCreador.Size = new System.Drawing.Size(228, 16);
            this.txtUsuarioCreador.TabIndex = 59;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 16);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Usuario___________";
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataMember = "sucursales";
            this.sucursalesBindingSource.DataSource = this.dsCompras1;
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataMember = "oc_detalle_exonerada";
            this.grDetalle.DataSource = this.dsCompras1;
            this.grDetalle.Location = new System.Drawing.Point(3, 29);
            this.grDetalle.MainView = this.grdvDetalle;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonDeleteRow,
            this.reposGrdCapitulo,
            this.reposPartidaArancelaria,
            this.reposGrdIndicadorIVA,
            this.reposGrdBodega});
            this.grDetalle.Size = new System.Drawing.Size(1504, 504);
            this.grDetalle.TabIndex = 52;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalle});
            this.grDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grDetalle_MouseDown);
            // 
            // grdvDetalle
            // 
            this.grdvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.Row.Options.UseFont = true;
            this.grdvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_d_orden,
            this.colid_h,
            this.colcapitulo,
            this.colpartida_arancelaria,
            this.colitemcode,
            this.coldescripcion_articulo,
            this.colcantidad,
            this.colprecio_por_unidad,
            this.colindicador_impuesto,
            this.colbodega,
            this.coltotal,
            this.colreferencia_base,
            this.colisv,
            this.gridColumn1,
            this.gridColumn2});
            this.grdvDetalle.CustomizationFormBounds = new System.Drawing.Rectangle(774, 457, 260, 282);
            this.grdvDetalle.GridControl = this.grDetalle;
            this.grdvDetalle.Name = "grdvDetalle";
            this.grdvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.grdvDetalle.OptionsView.ShowFooter = true;
            this.grdvDetalle.OptionsView.ShowGroupPanel = false;
            this.grdvDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdvDetalle_CellValueChanged);
            // 
            // colid_d_orden
            // 
            this.colid_d_orden.FieldName = "id_d_orden";
            this.colid_d_orden.Name = "colid_d_orden";
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.ColumnEdit = this.reposGrdCapitulo;
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 0;
            this.colcapitulo.Width = 130;
            // 
            // reposGrdCapitulo
            // 
            this.reposGrdCapitulo.AutoHeight = false;
            this.reposGrdCapitulo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposGrdCapitulo.DataSource = this.capitulosBindingSource;
            this.reposGrdCapitulo.DisplayMember = "Code";
            this.reposGrdCapitulo.Name = "reposGrdCapitulo";
            this.reposGrdCapitulo.NullText = "";
            this.reposGrdCapitulo.PopupFormSize = new System.Drawing.Size(500, 300);
            this.reposGrdCapitulo.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.reposGrdCapitulo.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.reposGrdCapitulo.ValueMember = "Code";
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "capitulos";
            this.capitulosBindingSource.DataSource = this.dsExoneracion1;
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode1,
            this.colU_AQUA_Desc,
            this.colconcat_2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCode1
            // 
            this.colCode1.Caption = "Capitulo";
            this.colCode1.FieldName = "Code";
            this.colCode1.Name = "colCode1";
            // 
            // colU_AQUA_Desc
            // 
            this.colU_AQUA_Desc.FieldName = "U_AQUA_Desc";
            this.colU_AQUA_Desc.Name = "colU_AQUA_Desc";
            // 
            // colconcat_2
            // 
            this.colconcat_2.FieldName = "concat_";
            this.colconcat_2.MinWidth = 60;
            this.colconcat_2.Name = "colconcat_2";
            this.colconcat_2.Visible = true;
            this.colconcat_2.VisibleIndex = 0;
            // 
            // colpartida_arancelaria
            // 
            this.colpartida_arancelaria.Caption = "Partida Arancelaria";
            this.colpartida_arancelaria.ColumnEdit = this.reposPartidaArancelaria;
            this.colpartida_arancelaria.FieldName = "partida_arancelaria";
            this.colpartida_arancelaria.Name = "colpartida_arancelaria";
            this.colpartida_arancelaria.Visible = true;
            this.colpartida_arancelaria.VisibleIndex = 1;
            this.colpartida_arancelaria.Width = 176;
            // 
            // reposPartidaArancelaria
            // 
            this.reposPartidaArancelaria.AutoHeight = false;
            this.reposPartidaArancelaria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposPartidaArancelaria.DataSource = this.partidaarancelariaBindingSource;
            this.reposPartidaArancelaria.DisplayMember = "Partida_arancelaria";
            this.reposPartidaArancelaria.Name = "reposPartidaArancelaria";
            this.reposPartidaArancelaria.NullText = "";
            this.reposPartidaArancelaria.PopupFormSize = new System.Drawing.Size(500, 300);
            this.reposPartidaArancelaria.PopupView = this.gridView1;
            this.reposPartidaArancelaria.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.reposPartidaArancelaria.ValueMember = "Partida_arancelaria";
            // 
            // partidaarancelariaBindingSource
            // 
            this.partidaarancelariaBindingSource.DataMember = "partida_arancelaria";
            this.partidaarancelariaBindingSource.DataSource = this.dsExoneracion1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Numero de Articulo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 2;
            this.colitemcode.Width = 118;
            // 
            // coldescripcion_articulo
            // 
            this.coldescripcion_articulo.Caption = "Descripcion de Articulo";
            this.coldescripcion_articulo.FieldName = "descripcion_articulo";
            this.coldescripcion_articulo.Name = "coldescripcion_articulo";
            this.coldescripcion_articulo.Visible = true;
            this.coldescripcion_articulo.VisibleIndex = 3;
            this.coldescripcion_articulo.Width = 301;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.DisplayFormat.FormatString = "n2";
            this.colcantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            this.colcantidad.Width = 82;
            // 
            // colprecio_por_unidad
            // 
            this.colprecio_por_unidad.Caption = "Precio por Ud.";
            this.colprecio_por_unidad.DisplayFormat.FormatString = "n2";
            this.colprecio_por_unidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprecio_por_unidad.FieldName = "precio_por_unidad";
            this.colprecio_por_unidad.Name = "colprecio_por_unidad";
            this.colprecio_por_unidad.Visible = true;
            this.colprecio_por_unidad.VisibleIndex = 5;
            this.colprecio_por_unidad.Width = 98;
            // 
            // colindicador_impuesto
            // 
            this.colindicador_impuesto.Caption = "Indicador de Impuestos";
            this.colindicador_impuesto.ColumnEdit = this.reposGrdIndicadorIVA;
            this.colindicador_impuesto.FieldName = "indicador_impuesto";
            this.colindicador_impuesto.Name = "colindicador_impuesto";
            this.colindicador_impuesto.Visible = true;
            this.colindicador_impuesto.VisibleIndex = 7;
            this.colindicador_impuesto.Width = 153;
            // 
            // reposGrdIndicadorIVA
            // 
            this.reposGrdIndicadorIVA.AutoHeight = false;
            this.reposGrdIndicadorIVA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposGrdIndicadorIVA.DataSource = this.ivaBindingSource;
            this.reposGrdIndicadorIVA.DisplayMember = "Code";
            this.reposGrdIndicadorIVA.Name = "reposGrdIndicadorIVA";
            this.reposGrdIndicadorIVA.NullText = "";
            this.reposGrdIndicadorIVA.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.reposGrdIndicadorIVA.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.reposGrdIndicadorIVA.ValueMember = "Code";
            // 
            // ivaBindingSource
            // 
            this.ivaBindingSource.DataMember = "iva";
            this.ivaBindingSource.DataSource = this.dsCompras1;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colRate});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Descripcion";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colRate
            // 
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Almacen";
            this.colbodega.ColumnEdit = this.reposGrdBodega;
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 8;
            this.colbodega.Width = 98;
            // 
            // reposGrdBodega
            // 
            this.reposGrdBodega.AutoHeight = false;
            this.reposGrdBodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposGrdBodega.DataSource = this.bodegasBindingSource;
            this.reposGrdBodega.DisplayMember = "bodega";
            this.reposGrdBodega.Name = "reposGrdBodega";
            this.reposGrdBodega.PopupView = this.gridView2;
            this.reposGrdBodega.ValueMember = "bodega";
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataMember = "bodegas";
            this.bodegasBindingSource.DataSource = this.dsCompras1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbodega1,
            this.colWhsName,
            this.colconcat_1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colbodega1
            // 
            this.colbodega1.Caption = "Bodega";
            this.colbodega1.FieldName = "bodega";
            this.colbodega1.Name = "colbodega1";
            this.colbodega1.Visible = true;
            this.colbodega1.VisibleIndex = 0;
            // 
            // colWhsName
            // 
            this.colWhsName.FieldName = "WhsName";
            this.colWhsName.Name = "colWhsName";
            // 
            // colconcat_1
            // 
            this.colconcat_1.FieldName = "concat_";
            this.colconcat_1.Name = "colconcat_1";
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total (doc.)";
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 9;
            this.coltotal.Width = 79;
            // 
            // colreferencia_base
            // 
            this.colreferencia_base.Caption = "Referencia Base";
            this.colreferencia_base.FieldName = "referencia_base";
            this.colreferencia_base.Name = "colreferencia_base";
            this.colreferencia_base.OptionsColumn.ReadOnly = true;
            this.colreferencia_base.Visible = true;
            this.colreferencia_base.VisibleIndex = 10;
            this.colreferencia_base.Width = 94;
            // 
            // colisv
            // 
            this.colisv.DisplayFormat.FormatString = "n2";
            this.colisv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisv.FieldName = "isv";
            this.colisv.Name = "colisv";
            this.colisv.OptionsColumn.ReadOnly = true;
            this.colisv.Visible = true;
            this.colisv.VisibleIndex = 6;
            this.colisv.Width = 78;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.ButtonDeleteRow;
            this.gridColumn1.FieldName = "eliminar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            this.gridColumn1.Width = 86;
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.ButtonDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonDeleteRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonDeleteRow_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Linea Base";
            this.gridColumn2.FieldName = "num_linea_solicitud_d";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.txtComentarios);
            this.panelControl2.Controls.Add(this.txtTotal);
            this.panelControl2.Controls.Add(this.txtImpuesto);
            this.panelControl2.Controls.Add(this.txtSubtotal);
            this.panelControl2.Controls.Add(this.btnShowPopu);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtUsuarioCreador);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(4, 745);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1564, 155);
            this.panelControl2.TabIndex = 53;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            this.panelControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl2_MouseDown);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(154, 51);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtComentarios.Properties.Appearance.Options.UseFont = true;
            this.txtComentarios.Size = new System.Drawing.Size(448, 96);
            this.txtComentarios.TabIndex = 85;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.EditValue = "0.00";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1228, 67);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "n");
            this.txtTotal.Properties.NullText = "0.00";
            this.txtTotal.Properties.NullValuePrompt = "0.00";
            this.txtTotal.Size = new System.Drawing.Size(108, 22);
            this.txtTotal.TabIndex = 81;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImpuesto.EditValue = "0.00";
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(1228, 37);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtImpuesto.Properties.Appearance.Options.UseFont = true;
            this.txtImpuesto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtImpuesto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtImpuesto.Properties.MaskSettings.Set("mask", "n");
            this.txtImpuesto.Properties.NullText = "0.00";
            this.txtImpuesto.Size = new System.Drawing.Size(108, 22);
            this.txtImpuesto.TabIndex = 80;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubtotal.EditValue = "0.00";
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1228, 8);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubtotal.Properties.MaskSettings.Set("mask", "n");
            this.txtSubtotal.Properties.NullText = "0.00";
            this.txtSubtotal.Size = new System.Drawing.Size(108, 22);
            this.txtSubtotal.TabIndex = 79;
            // 
            // btnShowPopu
            // 
            this.btnShowPopu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowPopu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowPopu.Appearance.Options.UseFont = true;
            this.btnShowPopu.Enabled = false;
            this.btnShowPopu.Location = new System.Drawing.Point(1249, 105);
            this.btnShowPopu.Name = "btnShowPopu";
            this.btnShowPopu.Size = new System.Drawing.Size(248, 29);
            this.btnShowPopu.TabIndex = 78;
            this.btnShowPopu.Text = "Copiar de Solicitud de Compra";
            this.btnShowPopu.Click += new System.EventHandler(this.btnShowPopu_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 52);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(138, 16);
            this.labelControl11.TabIndex = 77;
            this.labelControl11.Text = "Comentarios_______";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(1126, 14);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(113, 16);
            this.labelControl10.TabIndex = 84;
            this.labelControl10.Text = "SubTotal_______";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(1126, 72);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(153, 16);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "Total_______________";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(1126, 44);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(118, 16);
            this.labelControl9.TabIndex = 83;
            this.labelControl9.Text = "Impuesto_______";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnCancelOrden)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 209);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabDetalleOrden;
            this.xtraTabControl1.Size = new System.Drawing.Size(1564, 538);
            this.xtraTabControl1.TabIndex = 96;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDetalleOrden,
            this.tabArchivosAdjuntos});
            // 
            // tabDetalleOrden
            // 
            this.tabDetalleOrden.Controls.Add(this.cmdAddDetalle);
            this.tabDetalleOrden.Controls.Add(this.grDetalle);
            this.tabDetalleOrden.Name = "tabDetalleOrden";
            this.tabDetalleOrden.Size = new System.Drawing.Size(1510, 536);
            this.tabDetalleOrden.Text = "Detalle";
            // 
            // tabArchivosAdjuntos
            // 
            this.tabArchivosAdjuntos.Controls.Add(this.gridControl1);
            this.tabArchivosAdjuntos.Name = "tabArchivosAdjuntos";
            this.tabArchivosAdjuntos.PageVisible = false;
            this.tabArchivosAdjuntos.Size = new System.Drawing.Size(1510, 536);
            this.tabArchivosAdjuntos.Text = "Achivos";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 3);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(963, 530);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // frmOrdenesCompraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 905);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmOrdenesCompraMain";
            this.Text = "Ordenes de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxIntercom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaContabilizacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaContabilizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glRutaAprobacionOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRutaAprobacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TsExoOIsv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoordenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdCapitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPartidaArancelaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdIndicadorIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabDetalleOrden.ResumeLayout(false);
            this.tabArchivosAdjuntos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}