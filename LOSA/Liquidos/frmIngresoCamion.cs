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
 

        public frmIngresoCamion(UserLogin pUsuarioLogeado/*, ArrayList pArray,*/, ItemMP_Lote pItem,int pId_Tanque)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            //pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.ItemCode;
            txtMP_Name.Text = pItem.Card_Name;
            id_tanque = pId_Tanque;
            UsuarioLogeado = pUsuarioLogeado;
            //txtLote.Text = pItem.Lote;
            //IdLoteSelected = pItem.IdLote;
            //LoadBarcos();
            LoadUbicaciones();
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
            UsuarioLogeado = pUsuarioLogeado;
            //pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.CodeMP_SAP;
            txtMP_Name.Text = pItem.Name;
            id_tanque = pId_Tanque;
            UsuarioLogeado = pUsuarioLogeado;
            //txtLote.Text = pItem.Lote;
            //IdLoteSelected = pItem.IdLote;
            //LoadBarcos();
            LoadUbicaciones();
            obtener_ingreso();


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


            //Guardar Ingresos
            //if (idUbicacionSelected == 0)
            //{
            //    CajaDialogo.Error("Es necesario seleccionar una Ubicación Valida!");
            //    return;
            //}

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

            //if(dtFechaVencimiento.EditValue == null)
            //{
            //    CajaDialogo.Error("Es necesario seleccionar una fecha de Vencimiento!");
            //    return;
            //}

            //if (dtFechaProduccion.EditValue == null)
            //{
            //    CajaDialogo.Error("Es necesario seleccionar una fecha de Producción!");
            //    return;
            //}


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

           
            //Validar ingreso si es necesario
            bool Guardo = false;
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar estos ingresos de Materia Prima Líquidos?");
            if (r != DialogResult.Yes)
                return;

            decimal sumar_Kg = 0;
            foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
            {
                sumar_Kg = sumar_Kg + row.PesoProd;

            }

            string query = @"[dbo].[sp_insert_ingreso_mp_h_liquidos]";
            //SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //con.Open();
            SqlCommand Comnd = new SqlCommand(query, transaction.Connection);
            Comnd.CommandType = CommandType.StoredProcedure;
            Comnd.Transaction = transaction;

            Comnd.Parameters.AddWithValue("@entrada", sumar_Kg);
            Comnd.Parameters.AddWithValue("@lote", txtLote.Text);
            Comnd.Parameters.AddWithValue("@id_ingreso", ingreso);
            Comnd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
            Comnd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
            Comnd.Parameters.AddWithValue("@count_trailetas", dsLiquidos_.Camiones_IN.Count);

            int Id_lote_generado = Convert.ToInt32(Comnd.ExecuteScalar());

            foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
            {
                //
                try
                {
                    DataOperations dp = new DataOperations();
                    //cn = new SqlConnection(dp.ConnectionStringLOSA);
                    //cn.Open();

                    string SQL = @"[dbo].[sp_set_insert_ingreso_liquidos]";
                    SqlCommand cmd2 = new SqlCommand(SQL, transaction.Connection);
                    cmd2.Transaction = transaction;

                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id_boleta", row.NBoleta);
                    cmd2.Parameters.AddWithValue("@entrada", row.PesoProd);
                    cmd2.Parameters.AddWithValue("@item_code", row.itemcode);
                    cmd2.Parameters.AddWithValue("@lote", txtLote.Text);
                    cmd2.Parameters.AddWithValue("@id_lote", IdLoteSelected);
                    cmd2.Parameters.AddWithValue("@id", row.id);
                    cmd2.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);
                    cmd2.Parameters.AddWithValue("@id_ingreso", ingreso);
                    cmd2.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    cmd2.Parameters.AddWithValue("@id_lote_alosy", Id_lote_generado);
                    cmd2.Parameters.AddWithValue("@fecha_vencimiento", row.fecha_vencimiento);
                    cmd2.Parameters.AddWithValue("@fecha_produccion", row.fecha_produccion);
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

        private void grdUbicaciones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount >= 1)
                {

                    int idUbicaciones = Convert.ToInt32(grdUbicaciones.EditValue);
                    foreach (dsLiquidos_.Camiones_INRow row in dsLiquidos_.Camiones_IN.Rows)
                    {
                        row.id_ubicacion = idUbicaciones;
                    }

                    dsLiquidos_.Camiones_IN.AcceptChanges();
                }
                else
                {
                    CajaDialogo.Error("No hay registros seleccionados");
                    grdUbicaciones.EditValue = null;
                }
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
                foreach (var item in frm.camiones)
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
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
