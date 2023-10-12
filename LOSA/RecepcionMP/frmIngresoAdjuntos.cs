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
using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace LOSA.RecepcionMP
{
    public partial class frmIngresoAdjuntos : DevExpress.XtraEditors.XtraForm
    {
        int Id_ingreso = 0;
        int id_mp, numero_transaccion = 0;

        UserLogin UsuarioLogeado;

        public frmIngresoAdjuntos(int pid_ingreso, string pitemcode, int pnum_trans, UserLogin pUserLogin)
        {
            InitializeComponent();
            Id_ingreso = pid_ingreso;
            MateriaPrima mp = new MateriaPrima();
            mp.RecuperarRegistroFromCode(pitemcode);
            id_mp = mp.IdMP_ACS;
            numero_transaccion = pnum_trans;
            Inicalizar_Archivo_configurados();
            UsuarioLogeado = pUserLogin;


            IngresoMP ingreso = new IngresoMP();
            ingreso.RecuperarRegistrosIngreso(numero_transaccion);
            if (ingreso.Observacion.Length > 0)
            {
                txtObservacion.Text = ingreso.Observacion;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdVerImg_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.adjuntosRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (row.bit_subido)
                {
                    string dir = @"C:\alosy_temp";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    DataOperations dp = new DataOperations();
                    string pathCompleto = dp.FTP_Tickets_LOSA + row.path_load;

                    OpenFile(pathCompleto, dir + @"\" + row.file_name);
                }
                else
                {
                    CajaDialogo.Error("No Existe un Archivo Cargado!");
                    return;
                }
                
            
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void OpenFile(string pathSource, string pathDestintation)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string pass = "";
                string puser = "";

                if (string.IsNullOrEmpty(UsuarioLogeado.Pass))
                {
                    puser = "operador";
                    pass = "Tempo1234";
                }
                else
                {
                    puser = UsuarioLogeado.ADuser1;
                    pass = UsuarioLogeado.Pass;
                }

                request.Credentials = new NetworkCredential(puser, pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestintation))
                {
                    ftpStream.CopyTo(fileStream);

                    Process.Start(pathDestintation);
                    //CajaDialogo.Information("Archivo descargado con exito!");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.adjuntosRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (row.bit_subido)
            {
                DialogResult r = CajaDialogo.Pregunta("Se eliminara el archivo de forma permanente! esta seguro?");
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        if (row.bit_subido)
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            SqlCommand cmd = new SqlCommand("[sp_desligar_archvio_ingreso_logistica]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@num_transaccion", numero_transaccion);
                            cmd.Parameters.AddWithValue("@id_conf", row.id_conf);
                            //cmd.Parameters.AddWithValue("@id_archivo", row.id_registro);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            Inicalizar_Archivo_configurados();
                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
            else
            {
                CajaDialogo.Error("No se Cargado ningun archivo!");
                return;
            }
           
        }

        private void cmdDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);

                DataOperations dp = new DataOperations();

                if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string pathCompleto = dp.FTP_ALOSY_LOGISTICA + row.Path;
                    DownloadFile(pathCompleto, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.FileName);
                    //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposCargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.adjuntosRow)gridView.GetFocusedDataRow();

                if (row.bit_subido)
                {
                    CajaDialogo.Error("Debe desadjuntar el archivo antes de Cargar un nuevo archivo.");
                    return;
                }
                Dialog.InitialDirectory = "C:/";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    row.file_name = Dialog.SafeFileName;
                    row.path = Dialog.FileName;
                    DataOperations dp = new DataOperations();
                    string Path_ = row.id_conf + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + row.file_name;
                    FTP_Class ftp1 = new FTP_Class();
                    if (ftp1.GuardarArchivo(UsuarioLogeado, Path_, row.path))
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("[sp_insert_archivo_adjunto_ingreso_logistica]", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@path", Path_);
                        cmd.Parameters.AddWithValue("@file_name", row.file_name);
                        cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_config", row.id_conf);
                        cmd.Parameters.AddWithValue("@bit_pic", 0);
                        //cmd.Parameters.AddWithValue("@id_mp", id_mp);
                        cmd.Parameters.AddWithValue("@num_transaccion", numero_transaccion);
                        //cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                Inicalizar_Archivo_configurados();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void Inicalizar_Archivo_configurados()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();

                //SqlCommand cmd = new SqlCommand("sp_load_archivos_adjuntos_log", conn);
                SqlCommand cmd = new SqlCommand("[sp_load_trz_documentos_ingreso_for_lote_logistica]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                cmd.Parameters.AddWithValue("@num_transaccion", numero_transaccion);
                dsRecepcionMPx1.adjuntos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.adjuntos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ingreso_mp_update_observacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                cmd.Parameters.AddWithValue("@numero_transaccion", numero_transaccion);
                if (txtObservacion.Text == "")
                    cmd.Parameters.AddWithValue("@observacion", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@observacion", txtObservacion.Text);
                cmd.ExecuteNonQuery();

                CajaDialogo.Information("Observacion Guardada con Exito");

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void DownloadFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string pass = "";
                string puser = "";

                if (string.IsNullOrEmpty(UsuarioLogeado.Pass))
                {
                    puser = "operador";
                    pass = "Tempo1234";
                }
                else
                {
                    puser = UsuarioLogeado.ADuser1;
                    pass = UsuarioLogeado.Pass;
                }
                request.Credentials = new NetworkCredential(puser, pass);
                //request.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
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
    }
}