using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class FTP_Class
    {
        public string MensajeError { get; set; }
        public FTP_Class()
        {

        }

        public bool GuardarArchivo(UserLogin pUsuarioLogeado, string pFileName, string pathFile)
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Tickets_LOSA + pFileName);
                string pass = "Tempo1234";
                string user_op = "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (Stream fileStream = File.OpenRead(pathFile))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                    Guardado = true;
                }
            }
            catch(Exception ec)
            {
                throw new Exception(ec.Message);
            }

            return Guardado;
        }


        public bool GuardarArchivoCompras(UserLogin pUsuarioLogeado, string pFileName, string pathFile,int id_compra_detalle)
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();

                if (id_compra_detalle == 0)//Cuando se guarda un adjunto se le crea un identity, si el archivo es nuevo sera 0
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Tickets_LOSA_Compras + pFileName);
                    string pass = "Tempo1234";
                    string user_op = "operador";
                    if (pUsuarioLogeado != null)
                    {
                        if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                        {
                            user_op = pUsuarioLogeado.ADuser1;
                            pass = pUsuarioLogeado.Pass;
                        }
                    }

                    request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead(pathFile))
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                        Guardado = true;
                    }
                }
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }

            return Guardado;
        }

        public void DownloadFile(string pathSource, string pathDestination, UserLogin pUsuarioLogeado)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string pass = "Tempo1234";
                string user_op = "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                pathDestination=Path.Combine(pathDestination, "20042024091339.png");
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                //request.Credentials = new NetworkCredential(user_op, pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                //using (Stream fileStream = new FileStream(pathDestination, FileMode.Create)
                {
                    ftpStream.CopyTo(fileStream);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void OpenFile(string pathSource, string pathDestination, UserLogin pUsuarioLogeado)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string password = "";
                string puser = "";

                if (string.IsNullOrEmpty(pUsuarioLogeado.Password))
                {
                    puser = "operador";
                    password = "Tempo1234";
                }
                else
                {
                    puser = pUsuarioLogeado.AD_User;
                    password = pUsuarioLogeado.Password;
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

        public bool RemoveFile(string path_file)
        {  
                string ftpServer = path_file;
                string ftpUsername = "operador";
                string ftpPassword = "Tempo1234";

                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Console.WriteLine($"Archivo eliminado, status: {response.StatusDescription}");
                    response.Close();
                return true;
                }
                catch (Exception ex)
                {
                return false;
                }
            
        }

        static bool FtpFileExists(string filePath)
        {
            bool result = false;
            string username = "operador";
            string ftpPassword = "Tempo1234";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(filePath));
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.Credentials = new NetworkCredential(username, ftpPassword);

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                result = true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    result = false;
                }
            }

            return result;
        }

        public bool DownloadFileFromCompras(string pathSource, string pathDestination, UserLogin pUsuarioLogeado)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string pass = "Tempo1234";
                string user_op = "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                //pathDestination = Path.Combine(pathDestination, "20042024091339.png");
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())

                using (Stream fileStream = File.Create(pathDestination))
                {
                    ftpStream.CopyTo(fileStream);
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public bool OpenFile(string remote_file_path,string file_name)
        {
            try
            {


                DataOperations dp = new DataOperations();
                string pass = "Tempo1234";
                string user_op = "operador";

                string carpeta_adjuntos = @"C:\ordenes_compras_adjuntos";

                // Verificar si la carpeta no existe
                if (!Directory.Exists(carpeta_adjuntos))
                {
                    // Crear la carpeta
                    Directory.CreateDirectory(carpeta_adjuntos);
                }


                // Local file path to save the downloaded file
                string localFilePath = Path.Combine(carpeta_adjuntos, file_name);

                // Create FTP request
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(remote_file_path);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(user_op, pass);

                // Get FTP response
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                // Open file stream to write the downloaded file
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = File.Create(localFilePath))
                {
                    // Read response stream and write to file stream
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }
                }

                // Close FTP response
                response.Close();

                // Verificar si el archivo existe
                if (System.IO.File.Exists(localFilePath))
                {
                    // Abrir el archivo con la aplicación predeterminada asociada a su extensión
                    Process.Start(localFilePath);
                }

                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

    }
}
