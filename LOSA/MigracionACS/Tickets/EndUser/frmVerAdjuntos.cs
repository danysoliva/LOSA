using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using System.Net;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.EndUser;

namespace ACS.Tickets.EndUser
{
    public partial class frmVerAdjuntos : DevExpress.XtraEditors.XtraForm
    {
        int id_seguimiento;

        UserLogin UsuarioLogueado;
        public frmVerAdjuntos(int pid_seguimiento, UserLogin pUser)
        {
            InitializeComponent();
            id_seguimiento = pid_seguimiento;
            load_adjuntos();
            UsuarioLogueado = pUser;
        }

        private void load_adjuntos()
        {
            string Query = @"sp_TK_get_adjuntos_seguimiento";
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_seguimiento", Convert.ToInt32(id_seguimiento));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTickets.archivos.Clear();
                da.Fill(dsTickets.archivos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void repositoryItemHyperLinkEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        
            try
            {
                var gv = (GridView)grd_seguimiento.FocusedView;
                var row = (dsTickets.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(row.Path, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.FileName);
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
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                request.Credentials = new NetworkCredential(UsuarioLogueado.AD_User, UsuarioLogueado.Password);
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

        private void btnDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)grd_seguimiento.FocusedView;
                var row = (dsTickets.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);

                if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(row.Path, xtraFolderBrowserDialog1.SelectedPath + @"\" + row.FileName);
                    //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnOpen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string dir = @"C:\tickets_temp";

                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }


                var gv = (GridView)grd_seguimiento.FocusedView;
                var row = (dsTickets.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);


                OpenFile(row.Path, dir + @"\" + row.FileName);

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
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                string username_ = "";
                string pass_ = "";
                if (string.IsNullOrEmpty(UsuarioLogueado.Password))
                {
                    username_ = "operador@aquafeedhn.com";
                    pass_ = "Tempo1234";
                }
                else
                {
                    username_ = UsuarioLogueado.AD_User;
                    pass_ = UsuarioLogueado.Password;
                }

                request.Credentials = new NetworkCredential(username_, pass_);
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}