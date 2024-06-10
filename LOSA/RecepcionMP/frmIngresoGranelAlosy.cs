using ACS.Classes;
using LOSA.AlmacenesExterno;
using LOSA.Clases;
using LOSA.Utileria;
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

namespace LOSA.RecepcionMP
{
    public partial class frmIngresoGranelAlosy : Form
    {
        UserLogin UsuarioLogeado;
        ArrayList pLista;
        DataOperations dp = new DataOperations();
        int idUbicacionSelected;
        string Rack;
        string Codigo_Barra_ubicacion;
        int IdLoteSelected;
        int ingreso;
        bool Istraslado = false;
        int id_externo_ingreso = 0;
        int id_transferencia_h;
        public frmIngresoGranelAlosy(UserLogin pUsuarioLogeado, ArrayList pArray, ItemMP_Lote pItem)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtVentana.Visible = true;
            //if (pItem.ItemCode == "MP00003" || pItem.ItemCode == "MP00004")
            //{
            //    txtCodigoMP.Text = "MP00002";
            //    txtMP_Name.Text = "Harina de Soya";
            //}
            //else
            //{
            //    txtCodigoMP.Text = pItem.ItemCode;
            //    txtMP_Name.Text = pItem.Card_Name;
            //}
            txtLote.Text = pItem.Lote;
            txtCodigoMP.Text = pItem.ItemCode;
            txtMP_Name.Text = pItem.Card_Name;
            IdLoteSelected = pItem.IdLote;
            LoadBarcos();
            LoadUbicaciones();

            if (pItem.RecuperarRegistro(pItem.IdLote))
            {
                dtFechaProduccion.EditValue = pItem.FechaProd;
                dtFechaVencimiento.EditValue = pItem.FechaVence;
                
            }
            else
            {
                dtFechaProduccion.Enabled = true;
                dtFechaVencimiento.Enabled = true;
            }

            foreach (dsRecepcionMPx.granelRow rowg in pArray)
            {
                dsRecepcionMPx.granelRow row1 = dsRecepcionMPx1.granel.NewgranelRow();
                //row1 = rowg;
                //row1.itemcode = item.ItemCode;
                //row1.card_name = item.Card_Name;
                //pendiente agregar el valor de lote
                row1.id = rowg.id;
                row1.comentarios = rowg.comentarios;
                row1.EmpresaTrans = rowg.EmpresaTrans;
                row1.fechaEntra= rowg.fechaEntra;
                row1.FechaFin= rowg.FechaFin;

                try
                {
                    row1.shipid = rowg.shipid;
                }
                catch { row1.shipid = 0; }

                try
                {
                    row1.barco = rowg.barco;
                }
                catch { row1.barco = ""; }
                
                row1.NBoleta= rowg.NBoleta;
                row1.numero_factura= rowg.numero_factura;
                row1.Operador= rowg.Operador;
                row1.PesoBruto= rowg.PesoBruto;
                row1.PesonetoIn= rowg.PesonetoIn;
                row1.PesoProd= rowg.PesoProd;
                row1.pesoSalida= rowg.pesoSalida;
                row1.peso_factura= rowg.peso_factura;
                row1.conductorin= rowg.conductorin;
                row1.vehiculo= rowg.vehiculo;
                row1.furgon = rowg.furgon;
                row1.TipoBoleta = rowg.TipoBoleta;
                row1.id_tipo_boleta = rowg.id_tipo_boleta;
                row1.SNegocio = rowg.SNegocio;
                row1.Producto = rowg.Producto;
                row1.itemcode = rowg.itemcode;
                row1.seleccionar = rowg.seleccionar;
                try
                {
                    row1.id_ubicacion = rowg.id_ubicacion;
                }
                catch {  }
               
                dsRecepcionMPx1.granel.AddgranelRow(row1);
                dsRecepcionMPx1.AcceptChanges();
            }
        }


        public frmIngresoGranelAlosy(UserLogin pUsuarioLogeado, ArrayList pArray, ItemMP_Lote pItem, bool istraslado, int id_ingreso, int pid_transferencia_h)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtVentana.Visible = true;
            pLista = pArray;
            dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", dp.Now());
            txtCodigoMP.Text = pItem.ItemCode;
            txtMP_Name.Text = pItem.Card_Name;
            txtLote.Text = pItem.Lote;
            IdLoteSelected = pItem.IdLote;
            Istraslado = istraslado;
            id_externo_ingreso = id_ingreso;
            txtIngresoExterno.Text = id_ingreso.ToString();
            id_transferencia_h = pid_transferencia_h;
            LoadBarcos();
            LoadUbicaciones();

            if (pItem.RecuperarRegistroForID_Lote_Externo(pItem.IdLote))
            {
                dtFechaProduccion.EditValue = pItem.FechaProd;
                dtFechaVencimiento.EditValue = pItem.FechaVence;
            }

            foreach (dsRecepcionMPx.granelRow rowg in pArray)
            {
                dsRecepcionMPx.granelRow row1 = dsRecepcionMPx1.granel.NewgranelRow();
                //row1 = rowg;
                //row1.itemcode = item.ItemCode;
                //row1.card_name = item.Card_Name;
                //pendiente agregar el valor de lote
                row1.id = rowg.id;
                row1.comentarios = rowg.comentarios;
                row1.EmpresaTrans = rowg.EmpresaTrans;
                row1.fechaEntra = rowg.fechaEntra;
                row1.FechaFin = rowg.FechaFin;

                try
                {
                    row1.shipid = rowg.shipid;
                }
                catch { row1.shipid = 0; }

                try
                {
                    row1.barco = rowg.barco;
                }
                catch { row1.barco = ""; }

                row1.NBoleta = rowg.NBoleta;
                row1.numero_factura = rowg.numero_factura;
                row1.Operador = rowg.Operador;
                row1.PesoBruto = rowg.PesoBruto;
                row1.PesonetoIn = rowg.PesonetoIn;
                row1.PesoProd = rowg.PesoProd;
                row1.pesoSalida = rowg.pesoSalida;
                row1.peso_factura = rowg.peso_factura;
                row1.conductorin = rowg.conductorin;
                row1.vehiculo = rowg.vehiculo;
                row1.furgon = rowg.furgon;
                row1.TipoBoleta = rowg.TipoBoleta;
                row1.id_tipo_boleta = rowg.id_tipo_boleta;
                row1.SNegocio = rowg.SNegocio;
                row1.Producto = rowg.Producto;
                row1.itemcode = rowg.itemcode;
                row1.seleccionar = rowg.seleccionar;
                try
                {
                    row1.id_ubicacion = rowg.id_ubicacion;
                }
                catch { }


                dsRecepcionMPx1.granel.AddgranelRow(row1);
                dsRecepcionMPx1.AcceptChanges();
            }

        }

        private void LoadUbicaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"sp_get_lista_ubicaciones_granel";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_barra", "");
                dsRecepcionMPx1.ubicaciones_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.ubicaciones_granel);

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

                SqlCommand cmd = new SqlCommand("sp_get_ships_active_for_losa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.barcos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.barcos);

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
            frmUbicaciones_granel frm = new frmUbicaciones_granel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int idUbicacionNueva = frm.IdUbicacionSelected;
                beNuevaUbicacion.Text = frm.UbicacionCodigo + " - "+ frm.UbicacionNombre;
                idUbicacionSelected = idUbicacionNueva;
                Rack = frm.UbicacionNombre;
                Codigo_Barra_ubicacion = frm.UbicacionCodigo;
            }
        }

        private void cmdGenerarIngreso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoMP.Text))
            {
                CajaDialogo.Error("Es necesario saber la Materia Prima que se Registrara");
                return;
            }

            if(dtFechaVencimiento.EditValue == null)
            {
                CajaDialogo.Error("Es necesario seleccionar una fecha de Vencimiento!");
                return;
            }

            if (dtFechaProduccion.EditValue == null)
            {
                CajaDialogo.Error("Es necesario seleccionar una fecha de Producción!");
                return;
            }

            bool PuedeContinuar = false;
            //Buscamos que al menos haya una linea con ubicacion
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
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

            //Buscamos que al menos haya una linea con Barco Asignado
            PuedeContinuar = false;
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                try
                {
                    int a = row.shipid;
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
                CajaDialogo.Error("Debe seleccionar una barco valido!");
                return;
            }

            //VALIDACION DE NOMBRE DE LOTE!
            try
            {
                bool permitir = false;
                string mensaje = "";

                MateriaPrima mp1 = new MateriaPrima();
                mp1.RecuperarRegistroFromCode(txtCodigoMP.Text);

                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("sp_validar_existencia_lote_granel", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@lote", txtLote.Text.Trim());
                cmd1.Parameters.AddWithValue("@fecha_prod", dtFechaProduccion.DateTime);
                cmd1.Parameters.AddWithValue("@fecha_vencimiento", dtFechaVencimiento.DateTime);
                cmd1.Parameters.AddWithValue("@id_mp", mp1.IdMP_ACS);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    permitir = dr.GetBoolean(0);
                    mensaje = dr.GetString(1);

                }
                dr.Close();
                conn.Close();

                if (!permitir)
                {
                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, mensaje);
                    frm.ShowDialog();
                    return;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            //SqlConnection cn;
            SqlCommand cmd;
            SqlTransaction transaction = null;

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar estos ingresos de Materia Prima Granel?");
            if (r != DialogResult.Yes)
                return;

            if (!tggNuevoIngreso.IsOn)//Es un nuevo ingreso
            {
                if (string.IsNullOrEmpty(txtingreso.Text))
                {
                    CajaDialogo.Error("No tiene un ingreso seleccionado para poder ligar. Debe seleccionar uno antes de crear los documentos.");
                    return;
                }
            }

            bool Guardo = false;
            try
            {
                cnx.Open();
                transaction = cnx.BeginTransaction("SampleTransaction");

                if (tggNuevoIngreso.IsOn)//Es un nuevo ingreso
                {
                    cmd = cnx.CreateCommand();
                    cmd.CommandText = "sp_obtener_numero_ingreso";
                    cmd.Connection = cnx;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    ingreso = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else//Es ingreso existente
                {
                    ingreso = Convert.ToInt32(txtingreso.Text);
                }

                //Validar ingreso si es necesario
                decimal sumar_Kg = 0;
                foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                {
                    sumar_Kg = sumar_Kg + row.PesoProd;
                }

                int Id_lote_ALOSY = 0;
                if (tggNuevoIngreso.IsOn)//Ingreso nuevo
                {
                    if (Istraslado)
                    {
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_insert_ingreso_granel-v4";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@entrada", sumar_Kg);
                        cmd.Parameters.AddWithValue("@lote", txtLote.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_ingreso", ingreso);
                        cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                        cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@count_trailetas", dsRecepcionMPx1.granel.Count);
                        cmd.Parameters.AddWithValue("@id_traslado", id_externo_ingreso);
                        cmd.Parameters.AddWithValue("@fecha_prod", dtFechaProduccion.EditValue);
                        cmd.Parameters.AddWithValue("@fecha_venc", dtFechaVencimiento.EditValue);

                        Id_lote_ALOSY = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    else
                    {
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_insert_ingreso_granel_directo";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@entrada", sumar_Kg);
                        cmd.Parameters.AddWithValue("@lote", txtLote.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_ingreso", ingreso);
                        cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                        cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@count_trailetas", dsRecepcionMPx1.granel.Count);
                        cmd.Parameters.AddWithValue("@fecha_prod", dtFechaProduccion.EditValue);
                        cmd.Parameters.AddWithValue("@fecha_venc", dtFechaVencimiento.EditValue);

                        Id_lote_ALOSY = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                else//Ingreso existente
                {
                    cmd = cnx.CreateCommand();
                    cmd.CommandText = "sp_validar_si_ya_existe_este_ingresoV2";
                    cmd.Connection = cnx;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@entrada", sumar_Kg);
                    cmd.Parameters.AddWithValue("@lote", txtLote.Text.Trim());
                    cmd.Parameters.AddWithValue("@id_ingreso", ingreso);
                    cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                    cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@count_trailetas", dsRecepcionMPx1.granel.Count);
                    cmd.Parameters.AddWithValue("@fecha_prod", dtFechaProduccion.EditValue);
                    cmd.Parameters.AddWithValue("@fecha_venc", dtFechaVencimiento.EditValue);
                    Id_lote_ALOSY = Convert.ToInt32(cmd.ExecuteScalar());
                }

                //Registro de Salida Externa H
                //es el equivalente a una transferencia desde almacen externo
                int id_salida_h = 0;
                IngresoExternoH IngresoExterno1 = new IngresoExternoH();
                IngresoExternoD DetalleExterno1 = new IngresoExternoD();

                if (IngresoExterno1.RecuperarRegistro(id_externo_ingreso))
                {
                    if (DetalleExterno1.RecuperaRegistroInFromIdIngresoH_and_MP_Code(id_externo_ingreso))
                    {
                        //SqlCommand cmdh = new SqlCommand("sp_salida_almacenes_externos_h_insert", transaction.Connection);
                        //SqlCommand cmdh = new SqlCommand("sp_salida_almacenes_externos_h_insertV2", transaction.Connection);
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_salida_almacenes_externos_h_insertV2";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmdh.Parameters.Add("@bodega_in", SqlDbType.VarChar).Value = DetalleExterno1.BodegaIn;
                        //cmdh.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = "BG001";//Id bodega MP
                        //cmdh.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.Now();
                        //cmdh.Parameters.Add("@DocEntry", SqlDbType.Int).Value = DetalleExterno1.DocEntrySAP;
                        //cmdh.Parameters.Add("@user_creador", SqlDbType.Int).Value = this.UsuarioLogeado.Id;
                        //cmdh.Parameters.Add("@numero_transaccion", SqlDbType.Int).Value = ingreso;
                        //cmdh.Parameters.Add("@id_ingreso", SqlDbType.Int).Value = id_externo_ingreso;
                        cmd.Parameters.AddWithValue("@numero_transaccion", ingreso);
                        cmd.Parameters.AddWithValue("@id_transferencia", id_transferencia_h);
                        //id_salida_h = Convert.ToInt32(cmdh.ExecuteScalar());
                        cmd.ExecuteNonQuery();
                        id_salida_h = id_transferencia_h;
                    }
                }

                MateriaPrima mp1 = new MateriaPrima();
                mp1.RecuperarRegistroFromCode(txtCodigoMP.Text);
                decimal TotalKg = 0;
                foreach (dsRecepcionMPx.granelRow rowx in dsRecepcionMPx1.granel)
                {
                    TotalKg += rowx.PesoProd;
                }
                int id_linea_d = 0;
                int id_salida_d = 0;

                if (tggNuevoIngreso.IsOn)//Ingreso nuevo)
                {
                    //SqlCommand cmd2 = new SqlCommand("sp_salida_almacenes_externos_d_insert", transaction.Connection);
                    cmd = cnx.CreateCommand();
                    cmd.CommandText = "sp_salida_almacenes_externos_d_insert";
                    cmd.Connection = cnx;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_mp", SqlDbType.Int).Value = mp1.IdMP_ACS;
                    cmd.Parameters.Add("@id_h", SqlDbType.Int).Value = id_transferencia_h;// id_salida_h;
                    cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = TotalKg;
                    cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = 1;
                    cmd.Parameters.Add("@LineNum", SqlDbType.Int).Value = id_linea_d;
                    cmd.Parameters.Add("@DocEntry", SqlDbType.Int).Value = DetalleExterno1.DocEntrySAP;

                    id_salida_d = Convert.ToInt32(cmd.ExecuteScalar());

                    //Insertar detalle de salida de almacen
                    foreach (dsRecepcionMPx.granelRow item2 in dsRecepcionMPx1.granel)
                    {
                        id_linea_d++;
                        //SqlCommand cmd3 = new SqlCommand("sp_salida_almacenes_externos_lotes_insert ", transaction.Connection);
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_salida_almacenes_externos_lotes_insert";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = item2.PesoProd;
                        cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = 1;
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.Now();
                        cmd.Parameters.Add("@user_creador", SqlDbType.Int).Value = UsuarioLogeado.Id;
                        cmd.Parameters.Add("@id_serie", SqlDbType.Int).Value = item2.id;
                        cmd.Parameters.Add("@DocEntry", SqlDbType.Int).Value = DetalleExterno1.DocEntrySAP;
                        cmd.Parameters.Add("@id_mp", SqlDbType.Int).Value = mp1.IdMP_ACS;
                        cmd.Parameters.Add("@id_lote_externo", SqlDbType.Int).Value = IdLoteSelected;
                        cmd.Parameters.Add("@id_detalle", SqlDbType.Int).Value = id_salida_d;
                        cmd.Parameters.Add("@id_presentacio", SqlDbType.Int).Value = DBNull.Value;
                        cmd.Parameters.Add("@bodega_in", SqlDbType.VarChar).Value = DetalleExterno1.BodegaIn;
                        cmd.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = "BG001";//Id bodega MP
                        cmd.Parameters.Add("@LineNum", SqlDbType.Int).Value = id_linea_d;
                        //cmd3.Parameters.Add("@id_ingreso_lote", SqlDbType.Int).Value = ingreso_h.ID;
                        cmd.Parameters.Add("@id_ingreso_lote", SqlDbType.Int).Value = Id_lote_ALOSY;

                        cmd.ExecuteNonQuery();
                    }

                    foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                    {

                        //string SQL = @"sp_set_insert_tarimas_graneles_v4";
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_set_insert_tarimas_graneles_v4";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_boleta", row.NBoleta);
                        cmd.Parameters.AddWithValue("@entrada", row.PesoProd);
                        cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                        cmd.Parameters.AddWithValue("@lote", txtLote.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_lote", IdLoteSelected);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);
                        cmd.Parameters.AddWithValue("@id_ingreso", ingreso);
                        cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_lote_alosy", Id_lote_ALOSY);

                        cmd.ExecuteNonQuery();

                        //cn.Close();

                    }
                }
                else
                {
                    id_salida_d = 0;
                    //Insertar detalle de salida de almacen
                    foreach (dsRecepcionMPx.granelRow item2 in dsRecepcionMPx1.granel)
                    {
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_salida_almacenes_externos_lotes_insertV3";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@peso", SqlDbType.Decimal).Value = item2.PesoProd;
                        cmd.Parameters.Add("@unidades", SqlDbType.Decimal).Value = 1;
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.Now();
                        cmd.Parameters.Add("@user_creador", SqlDbType.Int).Value = UsuarioLogeado.Id;
                        cmd.Parameters.Add("@id_serie", SqlDbType.Int).Value = item2.id;
                        cmd.Parameters.Add("@DocEntry", SqlDbType.Int).Value = DetalleExterno1.DocEntrySAP;
                        cmd.Parameters.Add("@id_mp", SqlDbType.Int).Value = mp1.IdMP_ACS;
                        cmd.Parameters.Add("@id_lote_externo", SqlDbType.Int).Value = IdLoteSelected;
                        cmd.Parameters.Add("@id_detalle", SqlDbType.Int).Value = id_salida_d;
                        cmd.Parameters.Add("@id_presentacio", SqlDbType.Int).Value = DBNull.Value;
                        cmd.Parameters.Add("@bodega_in", SqlDbType.VarChar).Value = DetalleExterno1.BodegaIn;
                        cmd.Parameters.Add("@bodega_out", SqlDbType.VarChar).Value = "BG001";//Id bodega MP
                        cmd.Parameters.Add("@LineNum", SqlDbType.Int).Value = id_linea_d;
                        //cmd3.Parameters.Add("@id_ingreso_lote", SqlDbType.Int).Value = ingreso_h.ID;
                        cmd.Parameters.Add("@id_ingreso_lote", SqlDbType.Int).Value = Id_lote_ALOSY;
                        cmd.Parameters.AddWithValue("@ingreso", ingreso);

                        cmd.ExecuteNonQuery();
                    }

                    foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
                    {

                        //string SQL = @"sp_set_insert_tarimas_graneles_v4";
                        cmd = cnx.CreateCommand();
                        cmd.CommandText = "sp_set_insert_tarimas_graneles_v4";
                        cmd.Connection = cnx;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_boleta", row.NBoleta);
                        cmd.Parameters.AddWithValue("@entrada", row.PesoProd);
                        cmd.Parameters.AddWithValue("@item_code", txtCodigoMP.Text);
                        cmd.Parameters.AddWithValue("@lote", txtLote.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_lote", IdLoteSelected);
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.Parameters.AddWithValue("@id_ubicacion", row.id_ubicacion);
                        cmd.Parameters.AddWithValue("@id_ingreso", ingreso);
                        cmd.Parameters.AddWithValue("@id_user", this.UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_lote_alosy", Id_lote_ALOSY);

                        cmd.ExecuteNonQuery();

                        //cn.Close();

                    }
                }

                Guardo = true;
                transaction.Commit();
                cnx.Close();
            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
            }

            if (Guardo)
            {
                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void ValidarExistenciaLote()
        {
            
        }

        private void grdbarco_EditValueChanged(object sender, EventArgs e)
        {
            int idbarco = Convert.ToInt32(grdbarco.EditValue);
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                row.shipid = idbarco;
            }
            dsRecepcionMPx1.granel.AcceptChanges();
        }

        private void grdUbicaciones_EditValueChanged(object sender, EventArgs e)
        {
            int idUbicaciones = Convert.ToInt32(grdUbicaciones.EditValue);
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                row.id_ubicacion = idUbicaciones;
            }
            dsRecepcionMPx1.granel.AcceptChanges();
        }

        private void chnuevoIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chnuevoIngreso.Checked)
            {
                lblingresoRotulo.Visible = false;
                txtingreso.Visible = false;
                btningreso.Visible = false;
            }
            else
            {
                lblingresoRotulo.Visible = true;
                txtingreso.Visible = true;
                btningreso.Visible = true;
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            frm_select_numero_granel frm = new frm_select_numero_granel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtingreso.Text = frm.Ingreso.ToString();
            }
        }

        private void frmIngresoGranelAlosy_Load(object sender, EventArgs e)
        {

        }

        private void tggNuevoIngreso_Toggled(object sender, EventArgs e)
        {
            if (tggNuevoIngreso.IsOn)//Es nuevo ingreso
            {
                //lblingresoRotulo.Visible = 
                //txtingreso.Visible = 
                btningreso.Visible = 
                btningreso.Enabled = false;
            }
            else//Es un ingreso existente, debe permitir buscarlo
            {
                //lblingresoRotulo.Visible = true;
                //txtingreso.Visible = true;
                btningreso.Visible = true;
                btningreso.Enabled = true;
            }

            //if (tggNuevoIngreso.IsOn)
            //{
            //    lblingresoRotulo.Visible = true;
            //    txtingreso.Visible = true;
            //    btningreso.Visible = true;
            //    btningreso.Enabled = true;
            //}
            //else
            //{
            //    btningreso.Enabled = false;
            //}
        }

        private void cmdBuscarIngresoExterno_Click(object sender, EventArgs e)
        {
            xfrmBuscarIngresosAlmacen frm = new xfrmBuscarIngresosAlmacen();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                id_externo_ingreso = frm.ingreso_h.ID;
            }
        }
    }
}
