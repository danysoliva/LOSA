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
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;
using System.Net;
using System.IO;
using System.Diagnostics;
using LOSA.Nir;

namespace LOSA.Calidad
{
    public partial class rdEstadoTransporte : DevExpress.XtraEditors.XtraForm
    {
        public int Id_ingreso;
        UserLogin UsuarioLogeado;
        bool ChCalidad;
        int id_materiaPrima;
        string full_pathImagen;
        string fileNameImagen;
        string code_sap;
        string codigo;
        string usercreadorIngreso;

        DataOperations dp = new DataOperations();
        public rdEstadoTransporte(int id_ingreso_lote,
                                    UserLogin Puser )
        {
            InitializeComponent();
            Id_ingreso = id_ingreso_lote;
            UsuarioLogeado = Puser;
            load_data();
            load_data_ingreso();
            Load_cargas_nir();
            Inicializar_data_logistica();
            load_zonas(); 
            load_especie();
            load_tipo();
            load_paises();
            if (ChCalidad)
            {

            }
            else
            {
                inicializar_criterios();
                Inicalizar_Archivo();
            }
        }

        public void load_zonas()
        {
            string query = @"sp_load_zona_pesca_calidad";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
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
            string query = @"sp_load_validaciones_del_nir_to_show_calidad";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@id_mp", id_materiaPrima);
                cmd.Parameters.AddWithValue(@"@id_ingreso", Id_ingreso);
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

        public void inicializar_criterios()
        {
            string query = @"sp_load_inicializacion_de_criterios_calidad";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@id_mp", id_materiaPrima);
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

            string query = @"sp_get_informacion_get_to_show_calidad";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", Id_ingreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtloteMP.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtnombreMP.Text = dr.IsDBNull(1) ? "" : dr.GetString(1);
                    txtboleta.Text = dr.IsDBNull(2) ? "" : dr.GetInt32(2).ToString();
                    txtproveedor.Text = dr.IsDBNull(3) ? "" : dr.GetString(3);
                    txtnumtraslado.Text = !dr.IsDBNull(5) ? "" : dr.GetInt32(5).ToString();
                    txtoc.Text = dr.IsDBNull(6) ? "" : dr.GetString(5).ToString();
                    txtreferencia.Text = dr.IsDBNull(6) ? "" : dr.GetInt32(6).ToString();
                    ChCalidad = dr.IsDBNull(7) ? false : dr.GetBoolean(7);
                    code_sap = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    code_sap = dr.IsDBNull(8) ? "" : dr.GetString(8);
                    codigo = dr.IsDBNull(9) ? "" : dr.GetString(9);
                    usercreadorIngreso = dr.IsDBNull(10) ? "" : dr.GetString(10);
                    txtuserlogistica.Text = usercreadorIngreso;
                    txtusercalidad.Text = UsuarioLogeado.NombreUser;
                    txttransporte.Text = dr.IsDBNull(11) ? "" : dr.GetString(11);
                    txttransportista.Text = dr.IsDBNull(12) ? "" : dr.GetString(12);

                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data_ingreso()
        {

            string query = @"sp_get_informacion_get_to_show_calidad_data_mp";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", Id_ingreso);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtproduccion.EditValue = dr.IsDBNull(0) ? DateTime.Now : dr.GetDateTime(0);
                    dtvencimiento.EditValue = dr.IsDBNull(1) ? DateTime.Now : dr.GetDateTime(1);
                    txtdiasvencimiento.Text = dr.IsDBNull(2) ? "0" : dr.GetInt32(2).ToString();
                    txtingresada.Text = dr.IsDBNull(3) ? "" : dr.GetDecimal(3).ToString();
                    txtinventarioActual.Text = dr.IsDBNull(4) ? "" : dr.GetDecimal(4).ToString();
                    id_materiaPrima = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
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
                //Upload( full_path, fileName);
                //CajaDialogo.Information("ARCHIVO CARGADO SATISFACTORIAMENTE");
                pc_Mp.Image = Image.FromFile(full_pathImagen);
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

            }
        }

        private void btnAdjuntarDocumento_Click(object sender, EventArgs e)
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
                    if (row.id_registro == 0)
                    {
                        Process proceso = new Process();
                        proceso.StartInfo.FileName = row.path;
                        proceso.Start();
                    }
                    else
                    {
                        if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            DownloadFile(row.path, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.file_name);
                            //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);
                        }
                    }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
             

                frmUnirLigaduras frm = new frmUnirLigaduras(UsuarioLogeado, code_sap, codigo, txtnombreMP.Text,Id_ingreso, txtloteMP.Text, Convert.ToInt32(txtreferencia.Text));
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

        private void grd_origenespecie_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (grd_origenespecie.EditValue != null)
                {
                    foreach (dsMantenimientoC.origen_especieRow row in dsMantenimientoC.origen_especie.Rows)
                    {
                        if (Convert.ToInt32(grd_origenespecie.EditValue) == row.id)
                        {
                            hyfishsource.EditValue = row.fishsource;
                            hyIUCN.EditValue = row.iucn;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (grd_origenespecie.EditValue == null)
            {

            }
            

            try
            {
                string Query = @"sp_insert_criterios_calidad_data";
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}