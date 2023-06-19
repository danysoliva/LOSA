using ACS.Classes;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using System.Data.SqlClient;
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.EndUser;

namespace LOSA.MigracionACS.Tickets.Admin
{
    public partial class xfrmVerAdjuntosAdmin : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        int ticket_id;

        public xfrmVerAdjuntosAdmin(UserLogin userLogin,int pTicket_id)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;
            ticket_id = pTicket_id;

            GetAttachment();
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


                var gv = (GridView)grd_adjuntos.FocusedView;
                var row = (dsTickets.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);


                OpenFile(row.Path, dir + @"\" + row.FileName);
                //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);


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
                request.Credentials = new NetworkCredential(UsuarioLogueado.AD_User, UsuarioLogueado.Password);
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

        private void OpenFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string password = "";
                string puser = "";

                if (string.IsNullOrEmpty(UsuarioLogueado.Password))
                {
                    puser = "operador";
                    password = "Tempo1234";
                }
                else
                {
                    puser = UsuarioLogueado.AD_User;
                    password = UsuarioLogueado.Password;
                }

                request.Credentials = new NetworkCredential(puser, password, "AQUAFEEDHN.COM");
                //request.Credentials = new NetworkCredential(UsuarioLogueado.AD_User, UsuarioLogueado.Password);
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

        private void btnDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)grd_adjuntos.FocusedView;
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

        private void GetAttachment ()
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
            {
                cnx.Open();

                dsTickets.archivos.Clear();

                SqlDataAdapter da = new SqlDataAdapter("[dbo].[sp_tk_get_adjuntos]", cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@ticket_id", SqlDbType.Int).Value =ticket_id;

                da.Fill(dsTickets.archivos);
                cnx.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}