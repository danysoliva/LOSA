using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad.InspeccionIngreso;
using LOSA.Clases;
using LOSA.Nir;
using LOSA.TransaccionesMP;
using LOSA.Trazabilidad;
using LOSA.Trazabilidad.Despachos;
using LOSA.Trazabilidad.ReportesTRZ;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LOSA.Calidad
{
    public partial class frmInspeccionCalidadPorIngresoLoteMP : DevExpress.XtraEditors.XtraForm
    {
        public int Id_ingreso, Id_boleta;
        UserLogin UsuarioLogeado;
        bool ChCalidad;
        //int id_materiaPrima;
        string full_pathImagen = "";
        string fileNameImagen = "";
        string code_sap;
        bool cambioImagen = false;
        string codigo = " ";
        string usercreadorIngreso;
        string Direccion = "";
        string phone;
        string CodeSAP_Proveedor;
        string NombreSAP_Proveedor;
        int idPlanta_Fabricante;
        string FabricantePlantaNombre;
        public int NumeroTransaccion;
        int IdMP;
        string Lote;
      

        DataOperations dp = new DataOperations();
        public frmInspeccionCalidadPorIngresoLoteMP(int pNumeroIngreso, int pIdMP, string pLote, UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            NumeroTransaccion = pNumeroIngreso;
            IdMP = pIdMP;
            Lote = pLote;
            LoadDataInicialIngresos();

            LoadDataTipoIngrediente();
            LaodCriterioAdicionales();
            foreach (dsMantenimientoC.Ingresos_Lote_detalleRow item in dsMantenimientoC.Ingresos_Lote_detalle.Rows)
            {
                if (item.numero_transaccion == NumeroTransaccion)
                {
                    
                    Id_ingreso = item.id_ingreso;
                    Id_boleta = item.id_boleta;

                    item.selected = true;
                }
            }

            tabPageLotesPT.Visible = false;
            load_data();
            load_data_ingreso();
            Load_cargas_nir();
            Inicializar_data_logistica();
            load_zonas();
            load_especie();
            load_tipo();
            load_paises();
            LoadLotesPT();
            LoadInventarioKardex();
       
            //Archivos Configurados
            Inicalizar_Archivo_configurados();
            Inicializar_data_logisticaRuta2(Lote);
            if (ChCalidad)
            {
                load_criterios_configurados();
                load_ingrediente_fabricante();
                get_imagen();
                //Inicalizar_Archivo_configurados();
                load_empaque_estado_Mp();
                load_trasporte_estado_transporte();
                
                
                if (full_pathImagen != "")
                {
                    //pc_Mp.Image = ByteToImage(GetImgByte(full_pathImagen));
                    pc_Mp1.Image = ByteToImage(GetImgByte(full_pathImagen));
                }
            }
            else
            {
                inicializar_criterios();
                //Inicalizar_Archivo();
            }
        }

        private void load_ingrediente_fabricante()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_load_trz_fabricante_ingrediente",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp",IdMP);
                cmd.Parameters.AddWithValue("@lote",Lote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idPlanta_Fabricante = dr.GetInt32(0);
                    txtFabricante.Text = dr.GetString(1);
                    grdTipoIngrediente.EditValue = dr.GetInt32(2);

                    if (Convert.ToInt32(grdTipoIngrediente.EditValue) == 1) //Marino
                    {
                        btnAdd.Enabled = true;
                        grdInfoAdicionalCalidad.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                        grdInfoAdicionalCalidad.Enabled = false;
                    }

                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LaodCriterioAdicionales()
        {
            string query = @"sp_trz_get_criterios_adicionales_for_ingreso";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp",IdMP);
                cmd.Parameters.AddWithValue("@lote",Lote);
                //cmd.Parameters.AddWithValue("@num_transaccion",NumeroTransaccion);
                dsMantenimientoC.info_adicional_marino.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.info_adicional_marino);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDataTipoIngrediente()
        {
            string query = @"sp_get_tipo_ingrediente";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMantenimientoC.tipo_ingrediente.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMantenimientoC.tipo_ingrediente);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }

        public frmInspeccionCalidadPorIngresoLoteMP(string pLoteMP,
                                  UserLogin Puser)
        {
            InitializeComponent();
            //Id_ingreso = 0;
            //UsuarioLogeado = Puser;
            ////tabControl1.TabPages[4]
            //load_data(pLoteMP);
            //load_data_ingreso(pLoteMP);
            //Load_cargas_nir(pLoteMP);
            //Inicializar_data_logistica(pLoteMP);
            //load_zonas();
            //load_especie();
            //load_tipo();
            //load_paises();
            //LoadLotesPT();
            //LoadInventarioKardex();
            ////Load_Despachos();
            //if (ChCalidad)
            //{
            //    load_criterios_configurados(pLoteMP);
            //    Inicalizar_Archivo_configurados(pLoteMP);
            //    get_imagen(pLoteMP);
            //    load_empaque_estado_Mp(pLoteMP);
            //    load_trasporte_estado_transporte(pLoteMP);
            //    load_criterios_adicionales(pLoteMP);

            //    if (full_pathImagen != "")
            //    {
            //        pc_Mp.Image = ByteToImage(GetImgByte(full_pathImagen));
            //    }
            //}
            //else
            //{
            //    inicializar_criterios();
            //    Inicalizar_Archivo();
            //}
        }


        public frmInspeccionCalidadPorIngresoLoteMP(int id_ingreso_lote, UserLogin Puser, int tipo_transaccion)
        {
            InitializeComponent();
            //Id_ingreso = id_ingreso_lote;
            //UsuarioLogeado = Puser;

            //tabPageLotesPT.Visible = false;
            ////tabControl1.TabPages[4]
            //load_data();
            //load_data_ingreso();
            //Load_cargas_nir();
            //Inicializar_data_logistica();
            //load_zonas();
            //load_especie();
            //load_tipo();
            //load_paises();
            //LoadLotesPT();
            //LoadInventarioKardex();
            ////Load_Despachos();
            //if (ChCalidad)
            //{
            //    load_criterios_configurados();
            //    Inicalizar_Archivo_configurados();
            //    get_imagen();
            //    load_empaque_estado_Mp();
            //    load_trasporte_estado_transporte();
            //    load_criterios_adicionales();

            //    if (full_pathImagen != "")
            //    {
            //        pc_Mp.Image = ByteToImage(GetImgByte(full_pathImagen));
            //    }
            //}
            //else
            //{
            //    inicializar_criterios();
            //    Inicalizar_Archivo();
            //}

            //btnGuardar.Visible = false;
            ////cmdHome.Visible = false;
            ////btnRevisarBoleta.Enabled = false;
            ////btnOC.Enabled = false;
            //simpleButton1.Enabled = false;
            //ColSeleccionar.OptionsColumn.AllowEdit = false;
            //colbit_subido.OptionsColumn.AllowEdit = false;
            //colAdjuntar.OptionsColumn.AllowEdit = false;
            ////colabrir.OptionsColumn.AllowEdit = false;
            //grd_origenespecie.Enabled = false;
            //grd_pesca.Enabled = false;
            //grd_origen.Enabled = false;
            //Desadjuntar.OptionsColumn.AllowEdit = false;
            //grd_tipo.Enabled = false;
            //btnAdjuntarImagen.Enabled = false;
            //spsustentable.Enabled = false;
            ////labelControl5.Visible = false;
            ////txtboleta.Visible = false;
            ////btnRevisarBoleta.Visible = false;
            ////btnOC.Visible = false;
            ////txtproveedor.Visible = false;
            ////txtoc.Visible = false;
            //txtnumtraslado.Visible = false;
            ////labelControl4.Visible = false;
            ////labelControl6.Visible=false;
            //labelControl7.Visible = false;
            ////txtreferencia.Visible = false;
            ////dtproduccion.Visible = false;
            ////dtvencimiento.Visible = false;
            ////dt_f_ingreso.Visible = false;
            ////txtdiasvencimiento.Visible = false;
            ////txtingresada.Visible = false;
            //txtinventarioActual.Visible = false;
            ////txtingresadaUD.Visible = false;
            //txtFacturas.Visible = false;
            ////labelControl8.Visible = false;
            ////labelControl9.Visible = false;
            ////labelControl10.Visible = false;
            ////labelControl11.Visible = false;
            ////labelControl12.Visible = false;
            //labelControl13.Visible = false;
            ////labelControl44.Visible = false;
            ////labelControl32.Visible = false;
            //labelControl15.Visible = false;
            //btnRecientes.Visible = false;

            //labelControl14.Location = new Point(labelControl14.Location.X, 167);
            //tabControl1.Location = new Point(tabControl1.Location.X, 200);

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
                cmd.Parameters.AddWithValue("@_lotemp", plotemp);
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


        private void Load_Despachos(int plote)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_destinos_lote_pt_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotept", plote);
                dsReportesTRZ1.detalle_destinos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.detalle_destinos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadLotesPT()
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_load_lotes_pt_trz_from_lote_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", Lote);
                dsReportesTRZ1.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadLotesPT(object idMP_Selected)
        {
            //[sp_load_lotes_pt_trz_from_lote_mp] @lotemp
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_lotes_pt_trz_from_lote_mpv2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", txtloteMP.Text);
                cmd.Parameters.AddWithValue("@idrm", idMP_Selected);
                dsReportesTRZ1.pt_list_trz.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.pt_list_trz);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadInventarioKardex()
        {
            //string query = @"sp_obtener_inventario_general_por_lote_trz";
            string query = @"[dbo].[sp_get_ingresos_lotes_mp_ruta_trz1]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lotemp", Lote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima1.ingresos_lote_mp.Clear();
                da.Fill(dsTarima1.ingresos_lote_mp);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_criterios_adicionales()
        {
            //string query = @"sp_load_trz_criterio_ingreso_calidad_adicionales";
            string query = @"[sp_load_trz_criterio_ingreso_calidad_adicionales_by_lotempv2]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numero_transaccion", NumeroTransaccion);
            cmd.Parameters.AddWithValue("@_lotemp", Lote);
            cmd.Parameters.AddWithValue("@idmp", IdMP);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //grd_origenespecie.EditValue = dr.IsDBNull(0) ? (object)DBNull.Value : dr.GetInt32(0);
                //grd_tipo.EditValue = dr.IsDBNull(1) ? (object)DBNull.Value : dr.GetInt32(1);
                //spTipoporcentaje.EditValue = dr.IsDBNull(2) ? (object)DBNull.Value : dr.GetDecimal(2);
                //grd_pesca.EditValue = dr.IsDBNull(3) ? (object)DBNull.Value : dr.GetInt32(3);
                //txtPLantaSenasa.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                //spsustentable.EditValue = dr.IsDBNull(5) ? (object)DBNull.Value : dr.GetDecimal(5);
                //grd_origen.EditValue = dr.IsDBNull(6) ? (object)DBNull.Value : dr.GetInt32(6);
                //hyfishsource.EditValue = dr.IsDBNull(7) ? "" : dr.GetString(7);
                //hyIUCN.EditValue = dr.IsDBNull(8) ? "" : dr.GetString(8);
                //txtusercalidad.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
            }
            dr.Close();
        }

        //public void load_criterios_adicionales(string plotemp)
        //{
        //    string query = @"sp_load_trz_criterio_ingreso_calidad_adicionales_by_lotemp";
        //    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@_lotemp", plotemp);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        grd_origenespecie.EditValue = dr.IsDBNull(0) ? (object)DBNull.Value : dr.GetInt32(0);
        //        grd_tipo.EditValue = dr.IsDBNull(1) ? (object)DBNull.Value : dr.GetInt32(1);
        //        spTipoporcentaje.EditValue = dr.IsDBNull(2) ? (object)DBNull.Value : dr.GetDecimal(2);
        //        grd_pesca.EditValue = dr.IsDBNull(3) ? (object)DBNull.Value : dr.GetInt32(3);
        //        txtPLantaSenasa.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
        //        spsustentable.EditValue = dr.IsDBNull(5) ? (object)DBNull.Value : dr.GetDecimal(5);
        //        grd_origen.EditValue = dr.IsDBNull(6) ? (object)DBNull.Value : dr.GetInt32(6);
        //        hyfishsource.EditValue = dr.IsDBNull(7) ? "" : dr.GetString(7);
        //        hyIUCN.EditValue = dr.IsDBNull(8) ? "" : dr.GetString(8);
        //        txtusercalidad.Text = dr.IsDBNull(9) ? "" : dr.GetString(9);
        //    }
        //    dr.Close();
        //}

        //public void load_empaque_estado_Mp()
        //{
        //    string query = @"sp_load_trz_criterio_ingreso_empaque";
        //    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {

        //        rdEmpaque1.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
        //        rdEmpaque2.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
        //        rdEmpaque3.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
        //        rdEmpaque4.EditValue = dr.IsDBNull(4) ? true : dr.GetBoolean(4);
        //        rdEstadomp.EditValue = dr.IsDBNull(6) ? true : dr.GetBoolean(6);
        //        txtObseracionesMP.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
        //    }
        //    dr.Close();
        //}
        public void load_empaque_estado_Mp()
        {
            string query = @"[sp_load_trz_criterio_ingreso_empaque_by_lotempv2]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", Lote);
            cmd.Parameters.AddWithValue("@numero_transaccion", NumeroTransaccion);
            cmd.Parameters.AddWithValue("@idmp", IdMP);
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

        //public void load_empaque_estado_Mp(string lotemp)
        //{
        //    //string query = @"sp_load_trz_criterio_ingreso_empaque_by_lotemp";
        //    //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
        //    //cn.Open();
        //    //SqlCommand cmd = new SqlCommand(query, cn);
        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.AddWithValue("@_lotemp", lotemp);
        //    //SqlDataReader dr = cmd.ExecuteReader();
        //    //if (dr.Read())
        //    //{

        //    //    rdEmpaque1.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
        //    //    rdEmpaque2.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
        //    //    rdEmpaque3.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
        //    //    rdEmpaque4.EditValue = dr.IsDBNull(4) ? true : dr.GetBoolean(4);
        //    //    rdEstadomp.EditValue = dr.IsDBNull(6) ? true : dr.GetBoolean(6);
        //    //    txtObseracionesMP.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
        //    //}
        //    //dr.Close();
        //}


        public void load_trasporte_estado_transporte()
        {
            //string query = @"sp_load_trz_criterio_ingreso_transporte";
            string query = @"[sp_load_trz_criterio_ingreso_transporte_by_lotempv2]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", Lote);
            cmd.Parameters.AddWithValue("@numero_transaccion", NumeroTransaccion);
            cmd.Parameters.AddWithValue("@idmp", IdMP);
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
                dsTarima.ultimas_cargasRow row1 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
                row1.descripcion = dr.IsDBNull(4) ? "" : dr.GetString(4);
                dsTarima1.ultimas_cargas.Addultimas_cargasRow(row1);
                dsTarima1.AcceptChanges();

                dsTarima.ultimas_cargasRow row2 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
                row2.descripcion = dr.IsDBNull(5) ? "" : dr.GetString(5);
                dsTarima1.ultimas_cargas.Addultimas_cargasRow(row2);
                dsTarima1.AcceptChanges();

                dsTarima.ultimas_cargasRow row3 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
                row3.descripcion = dr.IsDBNull(6) ? "" : dr.GetString(6);
                dsTarima1.ultimas_cargas.Addultimas_cargasRow(row3);
                dsTarima1.AcceptChanges();


                txtobservacionTras.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
            }
            dr.Close();
        }

        //public void load_trasporte_estado_transporte(string plotemp)
        //{
        //    string query = @"sp_load_trz_criterio_ingreso_transporte_by_lotemp";
        //    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@_lotemp", plotemp);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        rdTranporte1.EditValue = dr.IsDBNull(0) ? true : dr.GetBoolean(0);
        //        rdTranporte2.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
        //        rdTranporte3.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
        //        rdTranporte4.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
        //        //txtmp1.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
        //        //txtmp2.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
        //        //txtmp3.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);

        //        dsTarima.ultimas_cargasRow row1 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
        //        row1.descripcion = dr.IsDBNull(4) ? "" : dr.GetString(4);
        //        dsTarima1.ultimas_cargas.Addultimas_cargasRow(row1);
        //        dsTarima1.AcceptChanges();

        //        dsTarima.ultimas_cargasRow row2 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
        //        row2.descripcion = dr.IsDBNull(5) ? "" : dr.GetString(5);
        //        dsTarima1.ultimas_cargas.Addultimas_cargasRow(row2);
        //        dsTarima1.AcceptChanges();

        //        dsTarima.ultimas_cargasRow row3 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
        //        row3.descripcion = dr.IsDBNull(6) ? "" : dr.GetString(6);
        //        dsTarima1.ultimas_cargas.Addultimas_cargasRow(row3);
        //        dsTarima1.AcceptChanges();

        //        txtobservacionTras.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
        //    }
        //    dr.Close();
        //}


        //public void get_imagen()
        // {
        //        string query = @"sp_get_imagen_of_ingreso_calidad";
        //        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand(query, cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        fileNameImagen = dr.GetString(0);
        //        full_pathImagen = dr.GetString(1);
        //    }
        //    dr.Close();
        //}
        public void get_imagen()
        {
            string query = @"[sp_get_imagen_of_ingreso_calidad_by_lotempV3]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_lotemp", Lote);
            cmd.Parameters.AddWithValue("@idmp", IdMP);
            //cmd.Parameters.AddWithValue("@id_ingreso", NumeroTransaccion);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fileNameImagen = dr.GetString(0);
                full_pathImagen = dr.GetString(1);
            }
            dr.Close();
        }

        //public void get_imagen(string _lotemp)
        //{
        //    string query = @"sp_get_imagen_of_ingreso_calidad_by_lotemp";
        //    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@_lotemp", _lotemp);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        fileNameImagen = dr.GetString(0);
        //        full_pathImagen = dr.GetString(1);
        //    }
        //    dr.Close();
        //}

        public void Inicalizar_Archivo_configurados()
        {
            try
            {
                string query = "sp_load_trz_documentos_ingreso_for_loteV4";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_ingreso", NumeroTransaccion);
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
                cmd.Parameters.AddWithValue("@lote", Lote);
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

        public void Inicalizar_Archivo_configurados(string plotemp)
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

        public byte[] GetImgByte(string ftpFilePath)
        {
            DataOperations dp = new DataOperations();


            WebClient ftpClient = new WebClient();
            //ftpClient.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
            ftpClient.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);

            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        public void load_criterios_configurados()
        {
            #region Codigo Funcion Anterior
            //string query = @"sp_load_trz_criterio_ingreso_respuesta";
            //try
            //{
            //    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand(query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //    cmd.Parameters.AddWithValue("@id_mp", id_materiaPrima);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    dsMantenimientoC.parametros.Clear();
            //    da.Fill(dsMantenimientoC.parametros);
            //    cn.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            #endregion
            string query = @"[sp_load_trz_criterio_ingreso_respuesta_v2]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", NumeroTransaccion);
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
                cmd.Parameters.AddWithValue("@lotemp", Lote);
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

        public void load_criterios_configurados(string plotemp)
        {
            string query = @"sp_load_trz_criterio_ingreso_respuesta_bylotemp";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_lotemp", plotemp);
                cmd.Parameters.AddWithValue(@"@id_mp", IdMP);
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

        public void load_zonas()
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
        public void load_paises()
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
        public void load_especie()
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
        public void Inicializar_data_logistica()
        {
            try
            {
                string query = @"sp_obtener_datos_logistica_to_show_calidadV2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", NumeroTransaccion);
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
        public void Inicializar_data_logistica(string plotemp)
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

        public void Inicalizar_Archivo()
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



        public void Load_cargas_nir()
        {
            string query = @"sp_load_validaciones_del_nir_to_show_calidadV2";
            //string query = @"[sp_load_validaciones_del_nir_to_show_calidad_by_lote_v2]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
                //cmd.Parameters.AddWithValue("@_lotemp", Lote);
                //cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                cmd.Parameters.AddWithValue("@lote", Lote);
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

        public void Load_cargas_nir(string plotemp)
        {
            //string query = @"sp_load_validaciones_del_nir_to_show_calidad_by_lote";
            //try
            //{
            //    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand(query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue(@"@id_mp", id_materiaPrima);
            //    cmd.Parameters.AddWithValue(@"@_lotemp", plotemp);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    dsMantenimientoC.show_nir.Clear();
            //    da.Fill(dsMantenimientoC.show_nir);
            //    cn.Close();
            //}
            //catch (Exception ex)
            //{

            //    CajaDialogo.Error(ex.Message);
            //}
        }

        public void inicializar_criterios()
        {
            string query = @"sp_load_inicializacion_de_criterios_calidad";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
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
        public void load_data()
        {
            string query = @"[sp_get_informacion_get_to_show_calidad_v3]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_lote", Id_ingreso);
                cmd.Parameters.AddWithValue("@numero_transaccion", NumeroTransaccion);
                cmd.Parameters.AddWithValue("@idmp", IdMP);
                cmd.Parameters.AddWithValue("@lote", Lote);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtloteMP.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtnombreMP.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    txtboleta.Text = dr.IsDBNull(2) ? "" : dr.GetInt32(2).ToString();
                    //txtproveedor.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtnumtraslado.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    //txtoc.Text = dr.IsDBNull(6) ? "" : dr.GetString(5).ToString();
                    //txtreferencia.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                    ChCalidad = dr.IsDBNull(7) ? false : dr.GetBoolean(7);
                    code_sap = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    codigo = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    usercreadorIngreso = dr.IsDBNull(10) ? "" : dr.GetString(10);
                    txtuserlogistica.Text = usercreadorIngreso;
                    txtusercalidad.Text = UsuarioLogeado.NombreUser;
                    txttransporte.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                    txttransportista.Text = dr.IsDBNull(12) ? "" : dr.GetString(12);
                    phone = dr.IsDBNull(13) ? "" : dr.GetString(13);
                    Direccion = dr.IsDBNull(14) ? "" : dr.GetString(14);
                    txtTelefono.Text = phone;
                    txtdireccion.Text = Direccion;
                    txtFacturas.Text = dr.IsDBNull(15) ? "" : dr.GetString(15);
                    CodeSAP_Proveedor = dr.IsDBNull(16) ? "" : dr.GetString(16);
                    //NombreSAP_Proveedor = txtproveedor.Text;
                    idPlanta_Fabricante = dr.IsDBNull(17) ? 0 : dr.GetInt32(17);
                    txtFabricante.Text = FabricantePlantaNombre = dr.IsDBNull(18) ? "" : dr.GetString(18);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data(string pLotemp)
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
                    //txtboleta.Text = dr.IsDBNull(2) ? "" : dr.GetInt32(2).ToString();
                    //txtproveedor.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtnumtraslado.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                    //txtoc.Text = dr.IsDBNull(6) ? "" : dr.GetString(5).ToString();
                    //txtreferencia.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                    ChCalidad = dr.IsDBNull(7) ? false : dr.GetBoolean(7);
                    code_sap = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    codigo = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    usercreadorIngreso = dr.IsDBNull(10) ? "" : dr.GetString(10);
                    txtuserlogistica.Text = usercreadorIngreso;
                    txtusercalidad.Text = UsuarioLogeado.NombreUser;
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

        public void LoadDataInicialIngresos()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            //string query = @"sp_get_informacion_get_to_show_calidad_data_mp_v4";
            string query = @"[sp_get_informacion_get_to_show_calidad_data_mp_all]";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id_lote", Id_ingreso);
            //cmd.Parameters.AddWithValue("@numero_transaccion", NumeroTransaccion);
            cmd.Parameters.AddWithValue("@idmp", IdMP);
            cmd.Parameters.AddWithValue("@lote", Lote);
            dsMantenimientoC.Ingresos_Lote_detalle.Clear();
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            adat.Fill(dsMantenimientoC.Ingresos_Lote_detalle);

            cn.Close();
        }

        public void load_data_ingreso()
        {
            //string query = @"sp_get_informacion_get_to_show_calidad_inven_actual_por_lote_ingreso";
            string query = @"[dbo].[sp_get_inventario_kg_kardex]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_lote", Id_ingreso);
                //cmd.Parameters.AddWithValue("@numero_transaccion", NumeroTransaccion);
                cmd.Parameters.AddWithValue("@idmp", IdMP);
                cmd.Parameters.AddWithValue("@lote", Lote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //dtproduccion.EditValue = dr.IsDBNull(0) ? DateTime.Now : dr.GetDateTime(0);
                    //dtvencimiento.EditValue = dr.IsDBNull(1) ? DateTime.Now : dr.GetDateTime(1);
                    //dt_f_ingreso.EditValue = dr.IsDBNull(2) ? DateTime.Now : dr.GetDateTime(2);
                    //txtdiasvencimiento.Text = dr.IsDBNull(3) ? "0" : dr.GetInt32(3).ToString();
                    //txtingresada.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString();
                    //txtingresadaUD.Text = dr.IsDBNull(5) ? "" : dr.GetDecimal(5).ToString();
                    decimal Inv_kg = dr.IsDBNull(0) ? 0 : dr.GetDecimal(0);
                    txtinventarioActual.Text = string.Format("{0:###,##0.00}", Inv_kg);
                    txtTM_inventarioActual.Text = string.Format("{0:###,##0.00}", Inv_kg/1000);

                    //IdMP = dr.IsDBNull(1) ? 0 : dr.GetInt32(1);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data_ingreso(string pLotemp)
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
                    //dtproduccion.EditValue = dr.IsDBNull(0) ? DateTime.Now : dr.GetDateTime(0);
                    //dtvencimiento.EditValue = dr.IsDBNull(1) ? DateTime.Now : dr.GetDateTime(1);
                    //txtdiasvencimiento.Text = dr.IsDBNull(2) ? "0" : dr.GetInt32(2).ToString();
                    //txtingresada.Text = dr.IsDBNull(3) ? "" : dr.GetDecimal(3).ToString();
                    txtinventarioActual.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString();
                    IdMP = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_data_informacion_mp()
        {
            try
            {

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void labelControl29_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ResponderParametro_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnAdjuntarImagen_Click(object sender, EventArgs e)
        {
            frmAdjuntarImagen frm = new frmAdjuntarImagen();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                full_pathImagen =  frm.full_path;
                fileNameImagen = frm.fileName;
                cambioImagen = true;
                //Upload( full_path, fileName);
                //CajaDialogo.Information("ARCHIVO CARGADO SATISFACTORIAMENTE");
                //pc_Mp.Image = Image.FromFile(full_pathImagen);
                pc_Mp1.Image = Image.FromFile(full_pathImagen);

                if (fileNameImagen != "")
                {
                    
                    //string Path_2 = "Imagen" + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + fileNameImagen;
                    string Path_2 = string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + fileNameImagen;
                    //if (Upload(Path_2, full_pathImagen))
                    FTP_Class ftp1 = new FTP_Class();
                    if (ftp1.GuardarArchivo(UsuarioLogeado, Path_2, full_pathImagen))
                    {
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();
                        SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso_IMAGENV2]", con);
                        //cmd4.Transaction = transaction;
                        cmd4.CommandType = CommandType.StoredProcedure;

                        cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_Tickets_LOSA + Path_2;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                        cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = fileNameImagen;
                        cmd4.Parameters.AddWithValue("@id_config", (object)DBNull.Value);
                        cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                        //cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                        cmd4.Parameters.AddWithValue("@bit_pic", 1);
                        //cmd4.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                        cmd4.Parameters.AddWithValue("@id_mp", IdMP);
                        cmd4.Parameters.AddWithValue("@lote_mp", Lote);
                        cmd4.Parameters.AddWithValue("@cambio_imagen", cambioImagen);
                        cmd4.ExecuteNonQuery();
                        con.Close();
                    }
                    
                   
                }

            }
        }

        private void grdv_nir_RowStyle(object sender, RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_nir.FocusedView;
            var row = (dsMantenimientoC.show_nirRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {

                if (row.bit_validacion)
                {
                    e.Appearance.BackColor = Color.FromArgb(187, 235, 213);

                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(238, 173, 170);
                }
            }
        }

        private void pnParametros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdv_parametros_Click(object sender, EventArgs e)
        {

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_parametros.FocusedView;
                var row = (dsMantenimientoC.parametrosRow)gridView.GetFocusedDataRow();
                bool manual = false;
                if (row.definicion == row.descripcion)
                {
                    manual = true;
                }
                else
                {
                    manual = false;
                }
                frmRespuestasCalidad frm = new frmRespuestasCalidad(manual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.id_respuesta != 0)
                    {
                        row.id_respuestas = frm.id_respuesta;
                        row.respuesta = frm.Respuesta;
                    }
                    else
                    {

                        row.respuesta = frm.Respuesta;
                    }
                    row.AcceptChanges();
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_parametros_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_parametros.FocusedView;
                var row = (dsMantenimientoC.parametrosRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {  switch (row.respuesta)
                        {
                            case "Cumple":
                                    e.Appearance.BackColor = Color.FromArgb(187, 235, 213);
                                break;
                            case "No cumple":
                                 e.Appearance.BackColor = Color.FromArgb(238, 173, 170);
                            break;
                            case "N/A":
                                e.Appearance.BackColor = Color.FromArgb(254, 233, 206);
                            break;
                            case "":
                                  e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                        case " ":
                            e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                            break;

                        default:
                                e.Appearance.BackColor = Color.FromArgb(254, 233, 206);
                                break;
                        }
                    
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void btnAdjuntarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_adjuntos.FocusedView;
                var row = (dsMantenimientoC.adjuntosRow)gridView.GetFocusedDataRow();

                if (row.bit_subido)
                {
                    CajaDialogo.Error("Debe desadjuntar el archivo antes de Cargar un nuevo archivo.");
                    return;
                }
                openFileDialog1.InitialDirectory = "C:/";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    row.file_name = openFileDialog1.SafeFileName;
                    row.path = openFileDialog1.FileName;
                    DataOperations dp = new DataOperations();
                    string Path_ = row.id_conf + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + row.file_name;
                    FTP_Class fpt1 = new FTP_Class();
                    if (fpt1.GuardarArchivo(UsuarioLogeado, Path_, row.path))
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_archivo_adjunto_ingresoV3", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@path", Path_);
                        cmd.Parameters.AddWithValue("@file_name", row.file_name);
                        cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_config",row.id_conf);
                        cmd.Parameters.AddWithValue("@bit_pic",0);
                        cmd.Parameters.AddWithValue("@id_mp", IdMP);
                        cmd.Parameters.AddWithValue("@lote_mp", Lote);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    Inicalizar_Archivo_configurados();
                    //row.path = openFileDialog1.FileName;
                    //row.path_load = openFileDialog1.FileName;
                    //row.file_name = openFileDialog1.SafeFileName;
                    //row.bit_subido = true;
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_adjuntos_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_adjuntos.FocusedView;
                var row = (dsMantenimientoC.adjuntosRow)gridView.GetDataRow(e.RowHandle);
                if (e.RowHandle >= 0)
                {
                    if (row.bit_subido)
                    {
                        e.Appearance.BackColor = Color.FromArgb(187, 235, 213);
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
        private void DownloadFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {
                    ftpStream.CopyTo(fileStream);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnAbrirAdjunto_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_adjuntos.FocusedView;
                var row = (dsMantenimientoC.adjuntosRow)gridView.GetFocusedDataRow();
                if (row.bit_subido)
                {

                    //if (row.id_registro == 0)
                    //{
                    //    Process proceso = new Process();
                    //    proceso.StartInfo.FileName = row.path;
                    //    proceso.Start();
                    //}
                    //else
                    //{
                    //    if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    //    {
                    //        //DownloadFile(row.path_load, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.file_name);
                    //        FTP_Class ftp1 = new FTP_Class();
                    //        ftp1.DownloadFile(row.path_load, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.file_name, UsuarioLogeado);
                    //        Process proceso = new Process();
                    //        proceso.StartInfo.FileName = xtraFolderBrowserDialog1.SelectedPath + @"\" + row.file_name;
                    //        proceso.Start();
                    //        //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);
                    //    }
                    //}
                    string dir = @"C:\alosy_temp";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    DataOperations dp = new DataOperations();
                    string PathCompleto = dp.FTP_Tickets_LOSA + row.path_load;

                    OpenFile(PathCompleto, dir + @"\" + row.file_name);


                }
                else
                {
                    CajaDialogo.Error("Debe de cargar almenos un archivo.");
                    return;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void OpenFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string pass = "";
                string puser = "";

                if (string.IsNullOrEmpty(UsuarioLogeado.Password))
                {
                    puser = "operador";
                    pass = "Tempo1234";
                }
                else
                {
                    puser = UsuarioLogeado.ADuser1;
                    pass = UsuarioLogeado.Password;
                }

                request.Credentials = new NetworkCredential(puser, pass, "AQUAFEEDHN.COM");
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {
                    ftpStream.CopyTo(fileStream);
                    Process.Start(pathDestination);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                frmUnirLigaduras frm = new frmUnirLigaduras(UsuarioLogeado, code_sap, codigo, txtnombreMP.Text, Id_ingreso, txtloteMP.Text, NumeroTransaccion, IdMP);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    Load_cargas_nir();
                    Inicializar_data_logistica();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
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
                    request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Id_ingreso == 0)
            {
                CajaDialogo.Error("Seleccione un Ingreso!");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(grdTipoIngrediente.Text))
                {
                    CajaDialogo.Error("El Campo Tipo de Ingrediente se debe Completar.");
                    tabControl1.SelectedIndex = 1;
                    grdTipoIngrediente.Focus();
                    return;
                }

                //if (string.IsNullOrEmpty(txtFabricante.Text))
                //{
                //    CajaDialogo.Error("Debe indicar el Fabricante!");
                //    simpleButton2.Focus();
                //    return;
                //}

                if (Convert.ToInt32(grdTipoIngrediente.EditValue) == 1)
                {
                    if (gridView1.RowCount == 0)
                    {
                        CajaDialogo.Error("El Tipo de Ingrediente es Marino!\nDebe adicionar especficiaciones.");
                        tabControl1.SelectedIndex = 1;
                        btnAdd.Focus();
                        return;
                    }
                    else
                    {
                        foreach (dsMantenimientoC.info_adicional_marinoRow item in dsMantenimientoC.info_adicional_marino.Rows)
                        {
                            if (item.porce_tipo == Convert.ToDecimal(0.00))
                            {
                                CajaDialogo.Error("El Porcentaje no Puede ser Valor 0.00");
                                return;
                            }
                            string vacio = "";
                            if (Convert.ToString(item.id_especio) == vacio)
                            {
                                CajaDialogo.Error("Debe Seleccionar una Especie de Origen!");
                                return;
                            }
                        }
                    }
                }


                foreach (dsMantenimientoC.parametrosRow row in dsMantenimientoC.parametros.Rows)
                {
                    if (string.IsNullOrWhiteSpace(row.respuesta) || string.IsNullOrEmpty(row.respuesta))
                    {
                        CajaDialogo.Error("El Campo Resultado de los Parametros y Especificaciones no pueden quedar vacios!");
                        return;
                    }
                }

                string Query = @"sp_delete_criterio_ingreso_respuestaV2";       //Elimna todas las respuestas guardadas.
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                    cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote_mp", Lote);
                    cmd.ExecuteScalar();

                    foreach (dsMantenimientoC.parametrosRow row in dsMantenimientoC.parametros.Rows)
                    {
                        if (row.respuesta != "" || row.respuesta != " ")
                        {
                            Query = @"sp_insert_criterios_calidad_dataV2";
                            cmd = new SqlCommand(Query, cn);             //Inserta las respuestas del grid principal
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_definicion", row.id);
                            cmd.Parameters.AddWithValue("@definicion", row.definicion);
                            cmd.Parameters.AddWithValue("@id_criterio", row.id_criterio == 0 ? (object)DBNull.Value : row.id_criterio);
                            cmd.Parameters.AddWithValue("@id_respuesta", row.id_respuestas == 0 ? (object)DBNull.Value : row.id_respuestas);
                            if (string.IsNullOrEmpty(row.respuesta))
                                cmd.Parameters.AddWithValue("@respuesta", "");
                            else
                                cmd.Parameters.AddWithValue("@respuesta", row.respuesta);
                            cmd.Parameters.AddWithValue("@criterio", row.descripcion);
                            cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                            cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                            cmd.Parameters.AddWithValue("@id_mp", IdMP);
                            cmd.Parameters.AddWithValue("@lote_mp", Lote);
                            cmd.ExecuteNonQuery();

                        }
                    }

                    if (Convert.ToInt32(grdTipoIngrediente.EditValue) == 1) //1 Tipo Ingrediente Marino
                    {
                        foreach (dsMantenimientoC.info_adicional_marinoRow item in dsMantenimientoC.info_adicional_marino.Rows)
                        {
                            Query = @"[sp_insert_trz_criterio_ingreso_calidad_adicionalesV3]";
                            cmd = new SqlCommand(Query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                            cmd.Parameters.AddWithValue("@origen", item.id_especio);
                            cmd.Parameters.AddWithValue("@porcentajetipo", item.porce_tipo);
                            cmd.Parameters.AddWithValue("@zonapesca", item.id_zona_pesca);
                            cmd.Parameters.AddWithValue("@planta", item.planta_senasa ==""? (object)DBNull.Value : item.planta_senasa);
                            cmd.Parameters.AddWithValue("@porcentajesustentable", item.sustentable);
                            cmd.Parameters.AddWithValue("@paisorigen", item.pais_origen);
                            cmd.Parameters.AddWithValue("@fishsurse", item.fishsource == "" ? (object)DBNull.Value : item.fishsource);
                            cmd.Parameters.AddWithValue("@iucn", item.IUCN == "" ? (object)DBNull.Value : item.IUCN);
                            cmd.Parameters.AddWithValue("@tipo", item.tipo);
                            cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
                            //cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                            cmd.Parameters.AddWithValue("@id_mp", IdMP);
                            cmd.Parameters.AddWithValue("@lote_mp", Lote);
                            cmd.ExecuteNonQuery();

                            #region Codigo Viejo sin Ciclo Foreach
                            //Query = @"[sp_insert_trz_criterio_ingreso_calidad_adicionalesV3]";
                            //cmd = new SqlCommand(Query, cn);
                            //cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                            //cmd.Parameters.AddWithValue("@origen", grd_origenespecie.EditValue == null ? (object)DBNull.Value : grd_origenespecie.EditValue);
                            //cmd.Parameters.AddWithValue("@porcentajetipo", spTipoporcentaje.Text == "0" || spsustentable.Text == "" ? (object)DBNull.Value : spTipoporcentaje.Text);
                            //cmd.Parameters.AddWithValue("@zonapesca", grd_pesca.EditValue == null ? (object)DBNull.Value : grd_pesca.EditValue);
                            //cmd.Parameters.AddWithValue("@planta", txtPLantaSenasa.Text == "" ? (object)DBNull.Value : txtPLantaSenasa.Text);
                            //cmd.Parameters.AddWithValue("@porcentajesustentable", spsustentable.Text == "0" || spsustentable.Text == "" ? (object)DBNull.Value : spsustentable.Text);
                            //cmd.Parameters.AddWithValue("@paisorigen", grd_origen.EditValue == null ? (object)DBNull.Value : grd_origen.EditValue);
                            //cmd.Parameters.AddWithValue("@fishsurse", hyfishsource.Text == "" ? (object)DBNull.Value : hyfishsource.Text);
                            //cmd.Parameters.AddWithValue("@iucn", hyIUCN.Text == "" ? (object)DBNull.Value : hyIUCN.Text);
                            //cmd.Parameters.AddWithValue("@tipo", grd_tipo.EditValue == null ? (object)DBNull.Value : grd_tipo.EditValue);
                            //cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
                            //cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                            //cmd.Parameters.AddWithValue("@id_mp", IdMP);
                            //cmd.Parameters.AddWithValue("@lote_mp", Lote);
                            //cmd.ExecuteNonQuery();

                            #endregion
                        }
                    }

                    Query = @"sp_insert_trz_criterio_ingreso_empaqueV2";
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                    cmd.Parameters.AddWithValue("@empaque1", rdEmpaque1.EditValue);
                    cmd.Parameters.AddWithValue("@empaque2", rdEmpaque2.EditValue);
                    cmd.Parameters.AddWithValue("@empaque3", rdEmpaque3.EditValue);
                    cmd.Parameters.AddWithValue("@empaque4", rdEmpaque4.EditValue);
                    cmd.Parameters.AddWithValue("@aceptado", rdEstadomp.EditValue);
                    cmd.Parameters.AddWithValue("@observaciones_mp", txtObseracionesMP.Text);
                    cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote_mp", Lote);
                    cmd.ExecuteNonQuery();

                    Query = "sp_insert_update_trz_registros_adicionales_calidad";
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_fabricante_planta", idPlanta_Fabricante);
                    cmd.Parameters.AddWithValue("@id_tipo_ingrediente", Convert.ToInt32(grdTipoIngrediente.EditValue));
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote", Lote);
                    cmd.ExecuteNonQuery();

                    Query = @"sp_insert_trz_criterio_ingreso_transporteV2";
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                    cmd.Parameters.AddWithValue("@resp1 ", rdTranporte1.EditValue);
                    cmd.Parameters.AddWithValue("@resp2", rdTranporte2.EditValue);
                    cmd.Parameters.AddWithValue("@resp3", rdTranporte3.EditValue);
                    cmd.Parameters.AddWithValue("@resp4", rdTranporte4.EditValue);
                    int conta1 = 1;

                    foreach (dsTarima.ultimas_cargasRow row in dsTarima1.ultimas_cargas.Rows)
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
                    cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote_mp", Lote);
                    cmd.Parameters.AddWithValue("@observaciones", txtobservacionTras.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();

                    Query = @"sp_update_ingresos_lotes_calidadV2";
                    cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                    cmd.Parameters.AddWithValue("@num_transaccion", NumeroTransaccion);
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote_mp", Lote);
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

            


            #region Codigo Guardar Viejo
            //string Query = @"sp_delete_criterio_ingreso_respuesta";       //Elimna todas las respuestas guardadas.
            //SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            //try
            //{
            //    cn.Open();
            //    SqlCommand cmd;
            //    cmd = new SqlCommand(Query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //    cmd.ExecuteScalar();

            //    foreach (dsMantenimientoC.parametrosRow row in dsMantenimientoC.parametros.Rows)
            //    {
            //        if (row.respuesta != "" || row.respuesta != " ")
            //        {
            //            Query = @"sp_insert_criterios_calidad_data";
            //            cmd = new SqlCommand(Query, cn);             //Inserta las respuestas del grid principal
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.AddWithValue("@id_definicion", row.id);
            //            cmd.Parameters.AddWithValue("@definicion", row.definicion);
            //            cmd.Parameters.AddWithValue("@id_criterio", row.id_criterio == 0 ? (object)DBNull.Value : row.id_criterio);
            //            cmd.Parameters.AddWithValue("@id_respuesta", row.id_respuestas == 0 ? (object)DBNull.Value : row.id_respuestas);
            //            cmd.Parameters.AddWithValue("@respuesta", row.respuesta);
            //            cmd.Parameters.AddWithValue("@criterio", row.descripcion);
            //            cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //            cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
            //            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
            //            cmd.ExecuteNonQuery();

            //        }                                                                                                   
            //    }

            //    Query = @"sp_insert_trz_criterio_ingreso_calidad_adicionales";
            //    cmd = new SqlCommand(Query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //    cmd.Parameters.AddWithValue("@origen", grd_origenespecie.EditValue == null ? (object)DBNull.Value : grd_origenespecie.EditValue);
            //    cmd.Parameters.AddWithValue("@porcentajetipo", spTipoporcentaje.Text == "0" || spsustentable.Text == "" ? (object)DBNull.Value : spTipoporcentaje.Text);
            //    cmd.Parameters.AddWithValue("@zonapesca", grd_pesca.EditValue == null ? (object)DBNull.Value : grd_pesca.EditValue);
            //    cmd.Parameters.AddWithValue("@planta", txtPLantaSenasa.Text == "" ? (object)DBNull.Value : txtPLantaSenasa.Text);
            //    cmd.Parameters.AddWithValue("@porcentajesustentable", spsustentable.Text == "0" || spsustentable.Text == "" ? (object)DBNull.Value : spsustentable.Text);
            //    cmd.Parameters.AddWithValue("@paisorigen", grd_origen.EditValue == null ? (object)DBNull.Value : grd_origen.EditValue);
            //    cmd.Parameters.AddWithValue("@fishsurse", hyfishsource.Text == "" ? (object)DBNull.Value : hyfishsource.Text);
            //    cmd.Parameters.AddWithValue("@iucn", hyIUCN.Text == "" ? (object)DBNull.Value : hyIUCN.Text);
            //    cmd.Parameters.AddWithValue("@tipo", grd_tipo.EditValue == null ? (object)DBNull.Value : grd_tipo.EditValue);
            //    cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
            //    cmd.ExecuteNonQuery();

            //    Query = @"sp_insert_trz_criterio_ingreso_empaque";
            //    cmd = new SqlCommand(Query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //    cmd.Parameters.AddWithValue("@empaque1", rdEmpaque1.EditValue);
            //    cmd.Parameters.AddWithValue("@empaque2", rdEmpaque2.EditValue);
            //    cmd.Parameters.AddWithValue("@empaque3", rdEmpaque3.EditValue);
            //    cmd.Parameters.AddWithValue("@empaque4", rdEmpaque4.EditValue);
            //    cmd.Parameters.AddWithValue("@aceptado", rdEstadomp.EditValue);
            //    cmd.Parameters.AddWithValue("@observaciones_mp", txtObseracionesMP.Text);
            //    cmd.ExecuteNonQuery();

            //    Query = @"sp_insert_trz_criterio_ingreso_transporte";
            //    cmd = new SqlCommand(Query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //    cmd.Parameters.AddWithValue("@resp1 ", rdTranporte1.EditValue);
            //    cmd.Parameters.AddWithValue("@resp2", rdTranporte2.EditValue);
            //    cmd.Parameters.AddWithValue("@resp3", rdTranporte3.EditValue);
            //    cmd.Parameters.AddWithValue("@resp4", rdTranporte4.EditValue);
            //    int conta1 = 1;

            //    foreach(dsTarima.ultimas_cargasRow row in dsTarima1.ultimas_cargas.Rows)
            //    {
            //        switch (conta1)
            //        {
            //            case 1:
            //                cmd.Parameters.AddWithValue("@materia_prima1", row.descripcion);
            //                break;
            //            case 2:
            //                cmd.Parameters.AddWithValue("@materia_prima2", row.descripcion);
            //                break;
            //            case 3:
            //                cmd.Parameters.AddWithValue("@materia_prima3", row.descripcion);
            //                break;
            //        }
            //        conta1++;
            //        if (conta1 > 3)
            //            break;
            //    }

            //    if (conta1 < 4)
            //    {
            //        switch (conta1)
            //        {
            //            case 1:
            //                cmd.Parameters.AddWithValue("@materia_prima1", DBNull.Value);
            //                cmd.Parameters.AddWithValue("@materia_prima2", DBNull.Value);
            //                cmd.Parameters.AddWithValue("@materia_prima3", DBNull.Value);
            //                break;
            //            case 2:
            //                cmd.Parameters.AddWithValue("@materia_prima2", DBNull.Value);
            //                cmd.Parameters.AddWithValue("@materia_prima3", DBNull.Value);
            //                break;
            //            case 3:
            //                cmd.Parameters.AddWithValue("@materia_prima3", DBNull.Value);
            //                break;
            //        }
            //    }
            //    //cmd.Parameters.AddWithValue("@materia_prima1", txtmp1.Text);
            //    //cmd.Parameters.AddWithValue("@materia_prima2", txtmp2.Text);
            //    //cmd.Parameters.AddWithValue("@materia_prima3", txtmp3.Text);
            //    cmd.Parameters.AddWithValue("@observaciones", txtobservacionTras.Text);
            //    cmd.ExecuteNonQuery();
            //    cn.Close();

            //    // Importar archivos adjuntos.

            //    foreach (dsMantenimientoC.adjuntosRow row in dsMantenimientoC.adjuntos.Rows)
            //    {
            //        if (row.bit_subido)
            //        {
            //            if (row.path == "")
            //            {
            //                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //                con.Open();
            //                SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
            //                //cmd4.Transaction = transaction;
            //                cmd4.CommandType = CommandType.StoredProcedure;

            //                cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = row.path_load;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
            //                cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.file_name;
            //                cmd4.Parameters.AddWithValue("@id_config", row.id_conf);
            //                cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
            //                cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //                cmd4.Parameters.AddWithValue("@bit_pic", 0);
            //                cmd4.ExecuteNonQuery();
            //                con.Close();
            //            }
            //            else
            //            {
            //                string FileName = row.file_name;
            //                DataOperations dp = new DataOperations();
            //                //string Path_ = dp.FTP_Tickets_LOSA + row.id_conf + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + row.file_name;
            //                string Path_ =  row.id_conf + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + row.file_name;
            //                //if (Upload(Path_, row.path))
            //                FTP_Class ftp1 = new FTP_Class();

            //                if(ftp1.GuardarArchivo(UsuarioLogeado, Path_, row.path))
            //                {
            //                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //                    con.Open();
            //                    SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
            //                    //cmd4.Transaction = transaction;
            //                    cmd4.CommandType = CommandType.StoredProcedure;

            //                    cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = Path_;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
            //                    cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.file_name;
            //                    cmd4.Parameters.AddWithValue("@id_config", row.id_conf);
            //                    cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
            //                    cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //                    cmd4.Parameters.AddWithValue("@bit_pic", 0);
            //                    cmd4.ExecuteNonQuery();
            //                    con.Close();
            //                }
            //            }
            //        }


            //    }

            //    if (fileNameImagen != "")
            //    {
            //        if (cambioImagen)
            //        {
            //            //string Path_2 = dp.FTP_Tickets_LOSA + "Imagen" + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + fileNameImagen;
            //            string Path_2 = "Imagen" + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + fileNameImagen;
            //            //if (Upload(Path_2, full_pathImagen))
            //            FTP_Class ftp1 = new FTP_Class();
            //            if (ftp1.GuardarArchivo(UsuarioLogeado, Path_2, full_pathImagen))
            //            {
            //                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //                con.Open();
            //                SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
            //                //cmd4.Transaction = transaction;
            //                cmd4.CommandType = CommandType.StoredProcedure;

            //                cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = Path_2;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
            //                cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = fileNameImagen;
            //                cmd4.Parameters.AddWithValue("@id_config", (object)DBNull.Value);
            //                cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
            //                cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //                cmd4.Parameters.AddWithValue("@bit_pic", 1);
            //                cmd4.ExecuteNonQuery();
            //                con.Close();
            //            }
            //        }
            //        else
            //        {

            //            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //            con.Open();
            //            SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_ingreso]", con);
            //            //cmd4.Transaction = transaction;
            //            cmd4.CommandType = CommandType.StoredProcedure;

            //            cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = full_pathImagen;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
            //            cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = fileNameImagen;
            //            cmd4.Parameters.AddWithValue("@id_config", (object)DBNull.Value);
            //            cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
            //            cmd4.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //            cmd4.Parameters.AddWithValue("@bit_pic", 1);
            //            cmd4.ExecuteNonQuery();
            //            con.Close();
            //        }
            //    }

            //    cn.Open();

            //    Query = @"sp_update_ingresos_lotes_calidad";
            //    cmd = new SqlCommand(Query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            //    cmd.ExecuteNonQuery();

            //    cn.Close();
            //    CajaDialogo.Information("Se ha registrado toda la informacion");
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //    // Update Checked

            //}
            //catch (Exception ex)
            //{

            //    CajaDialogo.Error(ex.Message);
            //}

            #endregion



        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_adjuntos.FocusedView;
                var row = (dsMantenimientoC.adjuntosRow)gridView.GetFocusedDataRow();

                if (row.bit_subido)
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_desligar_archvio_ingreso_calidad", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_registro", row.id_registro);
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote", Lote);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    Inicalizar_Archivo_configurados();
                }
                else
                {
                    CajaDialogo.Error("Debe de cargar almenos un archivo.");
                    return;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnRevisarBoleta_Click(object sender, EventArgs e)
        {
            
            //frmViewBasculaBoleta frm = new frmViewBasculaBoleta(Convert.ToInt32(txtboleta.Text));
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.Show();
        }

        private void btnOC_Click(object sender, EventArgs e)
        {
            //frmOC_SAP_View frm = new frmOC_SAP_View(Convert.ToInt32(txtoc.Text));
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.Show();
        }

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

        private void btnNoConformidad_Click(object sender, EventArgs e)
        {
            frmNoConfirmidadMP frm = new frmNoConfirmidadMP(Id_ingreso, Lote, UsuarioLogeado, NumeroTransaccion);
            if (frm.ShowDialog()== DialogResult.OK)
            {

            }
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView4_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsReportesTRZ.pt_list_trzRow)gridView.GetFocusedDataRow();
            Load_Despachos(row.Lote_PT);
        }

        private void btnLinkBoletaView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();

            Boleta bol1 = new Boleta();
            if (bol1.RecuperarRegistroFromNumBoleta(row.NumID))
            {
                frmViewBasculaBoleta frm = new frmViewBasculaBoleta(bol1.Id);
                if (this.MdiParent != null)
                    frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
            }
        }

        private void cmdDespachoId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsReportesTRZ.detalle_destinosRow)gridView.GetFocusedDataRow();
            frmDetalleDespacho frm = new frmDetalleDespacho(row.Despacho);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void cmdSearchFabricantePrv_Click(object sender, EventArgs e)
        {
            frmListaFabricantes frm = new frmListaFabricantes(CodeSAP_Proveedor,NombreSAP_Proveedor);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                txtFabricante.Text = frm.NombreFabricanteSeleccionado;
                //frm.IdFabricanteSeleccionado;
                UpdateFabricante(Id_ingreso, frm.IdFabricanteSeleccionado);
            }
        }

        private void UpdateFabricante(int id_ingreso, int pIdPlantaFabricante)
        {
            try
            {
                

                #region Codigo Viejo
                //DataOperations dp = new DataOperations();
                //SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                //con.Open();

                //SqlCommand cmd = new SqlCommand("sp_set_id_fabricante_ingreso_lote_alosy", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_lote", id_ingreso);
                //cmd.Parameters.AddWithValue("@id_fabricante", pIdPlantaFabricante);
                //cmd.ExecuteNonQuery();

                //con.Close();
                #endregion

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmListaFabricantes frm = new frmListaFabricantes(CodeSAP_Proveedor, NombreSAP_Proveedor);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtFabricante.Text = frm.NombreFabricanteSeleccionado;
                idPlanta_Fabricante = frm.IdFabricanteSeleccionado;
                //UpdateFabricante(Id_ingreso, frm.IdFabricanteSeleccionado);
            }
        }

        private void frmInspeccionCalidadPorIngresoLoteMP_Load(object sender, EventArgs e)
        {
            LoteMP LoteMP_ = new LoteMP();
            if (LoteMP_.RecuperarRegistro(txtloteMP.Text))
            {
                    LoadLotesPT(LoteMP_.IdMPSingle);                
            }
        }

        private void cmdSelectUltimasCargas_Click(object sender, EventArgs e)
        {
            Boleta bol1 = new Boleta();
            if (bol1.RecuperarRegistro(dp.ValidateNumberInt32(Id_boleta)))
            {
                frmBuscarDatosBascula frm = new frmBuscarDatosBascula(bol1.Furgon, bol1.Id, bol1.Placa_vehiculo);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dsTarima1.ultimas_cargas.Clear();
                    foreach (string var_ in frm.ListaDatos)
                    {
                        dsTarima.ultimas_cargasRow row1 = dsTarima1.ultimas_cargas.Newultimas_cargasRow();
                        row1.descripcion = var_;
                        dsTarima1.ultimas_cargas.Addultimas_cargasRow(row1);
                        dsTarima1.AcceptChanges();
                    }
                }
            }
            else
            {
                CajaDialogo.Error("No hay una boleta asociada!");
            }
            //txtboleta

        }

        private void btnViewBoleta_Click(object sender, EventArgs e)
        {

            if (Id_ingreso == 0)
            {
                CajaDialogo.Error("Debe Seleccionar el Ingreso!");
            }
            else
            {
                frmViewBasculaBoleta frm = new frmViewBasculaBoleta(Id_boleta);
                frm.Show();
            }
            
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal PorcentajeMarino = 0;

            foreach (dsMantenimientoC.info_adicional_marinoRow row in dsMantenimientoC.info_adicional_marino.Rows)
            {
                PorcentajeMarino += row.porce_tipo;
            }

            frmIngresoTipoMarino frm = new frmIngresoTipoMarino(PorcentajeMarino);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = dsMantenimientoC.info_adicional_marino.NewRow();
                dr[0] = frm.IM.Origen;
                dr[1] = frm.IM.ZonaPesca;
                dr[2] = frm.IM.Planta;
                dr[3] = frm.IM.PorcentajeSustentable;
                dr[4] = frm.IM.PaisOrigen;
                dr[5] = frm.IM.FishSurse;
                dr[6] = frm.IM.IUCN;
                dr[7] = frm.IM.Tipo;
                dr[8] = frm.IM.PorcentajeTipo;
                dsMantenimientoC.info_adicional_marino.Rows.Add(dr);
                dsMantenimientoC.info_adicional_marino.AcceptChanges();

            }
        }

        private void grdTipoIngrediente_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grdTipoIngrediente.Text))
            {
                switch (grdTipoIngrediente.EditValue)
                {
                    case 1:

                        btnAdd.Enabled = true;
                        grdInfoAdicionalCalidad.Enabled = true;

                        break;
                    default:

                        btnAdd.Enabled = false;
                        grdInfoAdicionalCalidad.Enabled = false;
                        dsMantenimientoC.info_adicional_marino.Clear();


                        break;
                }
            }

        }

        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar este registro?\nDebera Guardar para efecturar los Cambios.");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridView1 = (GridView)grdInfoAdicionalCalidad.FocusedView;
            var row = (dsMantenimientoC.info_adicional_marinoRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                dsMantenimientoC.AcceptChanges();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void reposGrdOrigenEspecie_EditValueChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    if (reposGrdOrigenEspecie.ValueMember != null)
            //    {
            //        foreach (dsMantenimientoC.origen_especieRow row in dsMantenimientoC.origen_especie.Rows)
            //        {
            //            if (Convert.ToInt32(reposGrdOrigenEspecie.ValueMember) == row.id)
            //            {
            //                row.fishsource = row.fishsource;
            //                row.iucn = row.iucn;
            //                dsMantenimientoC.info_adicional_marino.AcceptChanges();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void gridView7_RowClick(object sender, RowClickEventArgs e)
        {
            var gridview = (GridView)grid_Header_ingresos.FocusedView;
            var row = (dsMantenimientoC.Ingresos_Lote_detalleRow)gridview.GetFocusedDataRow();

            //gridView7.Appearance.FocusedRow.BackColor = Color.DarkSeaGreen;
            NumeroTransaccion = row.numero_transaccion;
            Id_ingreso = row.id_ingreso;
            Id_boleta = row.id_boleta;

            foreach (dsMantenimientoC.Ingresos_Lote_detalleRow item in dsMantenimientoC.Ingresos_Lote_detalle.Rows)
            {
                item.selected = false;
                item.AcceptChanges();
            }
            row.selected = true;

            try
            {
               
                LoadDataTipoIngrediente();
                LaodCriterioAdicionales();

                load_data();
                load_data_ingreso();
                Load_cargas_nir();
                Inicializar_data_logistica();
                load_zonas();
                load_especie();
                load_tipo();
                load_paises();
                LoadLotesPT();
                LoadInventarioKardex();
                //Archivos Configurados
                Inicalizar_Archivo_configurados();
                if (ChCalidad)
                {
                    load_criterios_configurados();
                    load_ingrediente_fabricante();

                    //Inicalizar_Archivo_configurados();
                    get_imagen();
                    load_empaque_estado_Mp();
                    load_trasporte_estado_transporte();
                    load_criterios_adicionales();

                    if (full_pathImagen != "")
                    {
                        //pc_Mp.Image = ByteToImage(GetImgByte(full_pathImagen));
                        pc_Mp1.Image = ByteToImage(GetImgByte(full_pathImagen));
                    }
                }
                else
                {
                    inicializar_criterios();
                    //Inicalizar_Archivo();
                }
            }
            catch (Exception ex) 
            {
                CajaDialogo.Error(ex.Message);
            }
    
        }
    }
}