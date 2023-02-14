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
        UserLogin UsuarioLogeado;

        public frmIngresoAdjuntos(int pid_ingreso, UserLogin pUserLogin)
        {
            InitializeComponent();
            Id_ingreso = pid_ingreso;
            UsuarioLogeado = pUserLogin;
            LoadArchivosAdj();
        }

        private void LoadArchivosAdj()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_load_archivos_adjuntos_log", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                dsRecepcionMPx1.archivos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.archivos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlTransaction transaction;
        Boolean guardaDatos;

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            Dialog.InitialDirectory = "C:/";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                DataRow row = dsRecepcionMPx1.archivos.NewRow();
                row["Path"] = Dialog.FileName;
                row["FileName"] = Dialog.SafeFileName;
                dsRecepcionMPx1.archivos.Rows.Add(row);
                //dsRecepcionMPx1.archivos.AcceptChanges();
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                transaction = conn.BeginTransaction("SampleTransaction");

                var gvArchivos = (GridView)gridControl1.FocusedView;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    var roww = (dsRecepcionMPx.archivosRow)gridView1.GetDataRow(i);

                    if (roww.subido == false)
                    {
                        SqlCommand cmd = new SqlCommand(@"[dbo].[sp_insert_archivos_adj_ingresos]", transaction.Connection);
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@descripcion", roww.FileName);
                        cmd.Parameters.AddWithValue("@path", string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + roww.FileName);
                        cmd.Parameters.AddWithValue("@file_name", roww.FileName);
                        cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.UserId);
                        cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                        cmd.Parameters.AddWithValue("@subido", 1);
                        cmd.ExecuteNonQuery();
                    }

                }

                if (gridView1.RowCount > 0)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        var rowww = (dsRecepcionMPx.archivosRow)gridView1.GetDataRow(i);

                        if (rowww.subido == false)
                        {
                            if (Upload(rowww.Path, rowww.FileName))
                            {
                                guardaDatos = true;
                                CajaDialogo.Information("Archivo cargado con Exito!");
                            }
                            else
                            {
                                guardaDatos = false;
                            }
                        }
                    }
                }
                else
                {
                    guardaDatos = true;
                }

                if (guardaDatos == true)
                {
                    transaction.Commit();
                    conn.Close();
                    
                }

                LoadArchivosAdj();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private bool Upload(string pathFile, string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargo el archivo!");
                    return false;
                }
                else
                {
                    DataOperations dp = new DataOperations();

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_ALOSY_LOGISTICA + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_"  + fileName);//crear el archivo en el server

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
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead(pathFile))//del pc local la ruta
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void cmdVerImg_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)gridControl1.FocusedView;
                var row = (dsRecepcionMPx.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);

                string dir = @"C:\\ALOSY";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                DataOperations dp = new DataOperations();
                string pathCompleto = dp.FTP_ALOSY_LOGISTICA + row.Path;

                OpenFile(pathCompleto, dir + @"\" + row.FileName);
            
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
            var row = (dsRecepcionMPx.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);

            DialogResult r = CajaDialogo.Pregunta("Se eliminara el archivo de forma permanente! esta seguro?");
            if (r == DialogResult.Yes)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_update_archivos_adjuntos_deshabilitar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_ingreso", Id_ingreso);
                    cmd.Parameters.AddWithValue("@id_archivo", row.id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    LoadArchivosAdj();
                }
                catch (Exception)
                {

                    throw;
                }
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