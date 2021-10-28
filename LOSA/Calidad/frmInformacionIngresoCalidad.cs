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
        string full_pathImagen = "";
        string fileNameImagen = "";
        string code_sap;
        string codigo;
        string usercreadorIngreso;
        bool cambioImagen = false;

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
                load_criterios_configurados();
                Inicalizar_Archivo_configurados();
                get_imagen();
                load_empaque_estado_Mp();
                load_trasporte_estado_transporte();
                load_criterios_adicionales();

                pc_Mp.Image= ByteToImage(GetImgByte(full_pathImagen));
            }
            else
            {
                inicializar_criterios();
                Inicalizar_Archivo();
            }
        }

        public void load_criterios_adicionales()
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

        public void load_empaque_estado_Mp()
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


        public void load_trasporte_estado_transporte()
        {
            string query = @"sp_load_trz_criterio_ingreso_transporte";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rdTranporte1.EditValue = dr.IsDBNull(0) ? true : dr.GetBoolean(0);
                rdTranporte2.EditValue = dr.IsDBNull(1) ? true : dr.GetBoolean(1);
                rdTranporte3.EditValue = dr.IsDBNull(2) ? true : dr.GetBoolean(2);
                rdTranporte4.EditValue = dr.IsDBNull(3) ? true : dr.GetBoolean(3);
                txtmp1.Text = dr.IsDBNull(4) ? "" : dr.GetString(4);
                txtmp2.Text = dr.IsDBNull(5) ? "" : dr.GetString(5);
                txtmp3.Text = dr.IsDBNull(6) ? "" : dr.GetString(6);
                txtobservacionTras.Text = dr.IsDBNull(7) ? "" : dr.GetString(7);
            }
            dr.Close();
        }


        public void get_imagen()
         {
                string query = @"sp_get_imagen_of_ingreso_calidad";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fileNameImagen = dr.GetString(0);
                full_pathImagen = dr.GetString(1);
            }
            dr.Close();
        }
        public void Inicalizar_Archivo_configurados()
        {
            try
            {
                string query = @"sp_load_trz_documentos_ingreso";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
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
            ftpClient.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);

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
            string query = @"sp_load_trz_criterio_ingreso_respuesta";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
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
                cambioImagen = true;
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
                                DownloadFile(row.path_load, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.file_name);

                                        Process proceso = new Process();
                                        proceso.StartInfo.FileName = xtraFolderBrowserDialog1.SelectedPath + @"\" + row.file_name;
                                        proceso.Start();
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
                        cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }                                                                                                   
                }

                Query = @"sp_insert_trz_criterio_ingreso_calidad_adicionales";
                cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.Parameters.AddWithValue("@origen", grd_origenespecie.EditValue == null ? (object)DBNull.Value : grd_origenespecie.EditValue);
                cmd.Parameters.AddWithValue("@porcentajetipo", spTipoporcentaje.Text == "0" ? (object)DBNull.Value : spTipoporcentaje.Text);
                cmd.Parameters.AddWithValue("@zonapesca", grd_pesca.EditValue == null ? (object)DBNull.Value : grd_pesca.EditValue);
                cmd.Parameters.AddWithValue("@planta", txtPLantaSenasa.Text == "" ? (object)DBNull.Value : txtPLantaSenasa.Text);
                cmd.Parameters.AddWithValue("@porcentajesustentable", spsustentable.Text == "0" ? (object)DBNull.Value : spsustentable.Text);
                cmd.Parameters.AddWithValue("@paisorigen", grd_origen.EditValue == null ? (object)DBNull.Value : grd_origen.EditValue);
                cmd.Parameters.AddWithValue("@fishsurse", hyfishsource.Text == "" ? (object)DBNull.Value : hyfishsource.Text);
                cmd.Parameters.AddWithValue("@iucn", hyIUCN.Text == "" ? (object)DBNull.Value : hyIUCN.Text);
                cmd.Parameters.AddWithValue("@tipo", grd_tipo.EditValue == null ? (object)DBNull.Value : grd_tipo.EditValue);
                cmd.Parameters.AddWithValue("@user_register", UsuarioLogeado.Id);
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
                cmd.Parameters.AddWithValue("@materia_prima1", txtmp1.Text);
                cmd.Parameters.AddWithValue("@materia_prima2", txtmp2.Text);
                cmd.Parameters.AddWithValue("@materia_prima3", txtmp3.Text);
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
                            cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
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
                                cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
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
                            cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
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
                        cmd4.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
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

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_adjuntos.FocusedView;
                var row = (dsMantenimientoC.adjuntosRow)gridView.GetFocusedDataRow();
                if (row.bit_subido)
                {
                    row.bit_subido = false;
                    row.path = "";
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
    }
}