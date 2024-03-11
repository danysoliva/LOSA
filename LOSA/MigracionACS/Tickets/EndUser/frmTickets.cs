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
using System.IO;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Net;
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.Models;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmTickets : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        Clases.Ticket tk;
        
        TicketInfo ticketInfo = new TicketInfo();
        EmailTicketParams emailTcketParams = new EmailTicketParams();
        SecOps ops = new SecOps();

        public enum TipoTicket
        {
            IT = 1,
            Manto = 2
        }

        public TipoTicket TipoTicketActual = TipoTicket.IT;

        public  frmTickets(UserLogin Puser, TipoTicket pTipoticket, int PidTicket)
        {
            InitializeComponent();
            TipoTicketActual = pTipoticket;
            UsuarioLogeado = Puser;
            tk = new Clases.Ticket(PidTicket);
            grd_proyectoPrimerNivel.EditValue = tk.Id_proyecto;
            txtSolicitudSegundoNivel.Text = tk.Titulo;
            txtusuario.Text = tk.Name_user_issue;
            txtcomentario.Text = tk.Comentario;
            grd_titulosSegundoNivel.Visible = false;
            grd_proyectoPrimerNivel.Enabled = false;

            grd_usuario.Visible = false;
            chusuario.Visible = false;
            chsolicitudSegundoNivel.Visible = false;
            btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            txtcomentario.Enabled = false;
            if (tk.Id_tipo == 1)
            {
                TipoTicketActual = TipoTicket.IT;
            }
            else
            {
                TipoTicketActual = TipoTicket.Manto;
            }

            switch (TipoTicketActual)
            {
                case TipoTicket.IT:
                            this.Text = "Solicitud de Asistencia de IT";
                            lblTitulo.Text = "Enviar una solicitud de soporte para IT";
                            this.BackColor = Color.FromArgb(235, 236, 239);
                            //grd_proyectoPrimerNivel.Visible = lblPrimerNivel.Visible = true;
                            lblPrimerNivel.Text = "¿Qué tipo de sistema necesita ayuda?";
                            chsolicitudSegundoNivel.Enabled = grd_titulosSegundoNivel.Enabled = true;
                            //chsolicitudSegundoNivel.Visible = grd_titulosSegundoNivel.Visible = txtSolicitudSegundoNivel.Visible = lblSegundoNivel.Visible = true;
                    break;
                case TipoTicket.Manto:
                   
                            //grd_proyectoPrimerNivel.Visible = lblPrimerNivel.Visible = false;
                            lblPrimerNivel.Text = "Indique el tipo de Requerimiento: ";
                            chsolicitudSegundoNivel.Enabled = grd_titulosSegundoNivel.Enabled = txtSolicitudSegundoNivel.Enabled = false;
                            //chsolicitudSegundoNivel.Visible = grd_titulosSegundoNivel.Visible = txtSolicitudSegundoNivel.Visible = lblSegundoNivel.Visible = false;
                            this.Text = "Solicitud de Asistencia de Mantenimiento";
                            lblTitulo.Text = "Enviar una solicitud de soporte para Mantenimiento";
                            this.BackColor = Color.FromName("MediumAquamarine");
                            grd_usuario.EditValue = UsuarioLogeado.UserId;
                    break;
                default:
                    break;
            }
             UsuarioLogeado = Puser;
            load_Data();
            if (grd_proyectoPrimerNivel.EditValue == null)
            {

            }
            else
            {

                load_preguntas();
            }
            load_usuarios();
            LoadCorreos();
            load_adjuntos();
            btnAgregarCopia.Enabled = false;
            coleliminar.Visible = false;
            grd_info.Enabled = false;
        }
        public frmTickets(UserLogin Puser, TipoTicket pTipoticket, int iOpcion, string pOpcion)
        {
            InitializeComponent();
            try
            {
                TipoTicketActual = pTipoticket;
                UsuarioLogeado = Puser;
                switch (TipoTicketActual)
                {
                    case TipoTicket.IT:
                        this.Text = "Solicitud de Asistencia de IT";
                        lblTitulo.Text = "Enviar una solicitud de soporte para IT";
                        this.BackColor = Color.FromArgb(235, 236, 239);
                        //grd_proyectoPrimerNivel.Visible = lblPrimerNivel.Visible = true;
                        lblPrimerNivel.Text = "¿Qué tipo de sistema necesita ayuda?";
                        chsolicitudSegundoNivel.Enabled = grd_titulosSegundoNivel.Enabled = true;
                        chsolicitudSegundoNivel.Visible = grd_titulosSegundoNivel.Visible = txtSolicitudSegundoNivel.Visible = lblSegundoNivel.Visible = true;
                        lblSelecccion.Visible = false;
                        break;
                    case TipoTicket.Manto:
                        //grd_proyectoPrimerNivel.Visible = lblPrimerNivel.Visible = false;
                        lblPrimerNivel.Text = "Indique el tipo de Requerimiento: ";
                        chsolicitudSegundoNivel.Enabled = grd_titulosSegundoNivel.Enabled = txtSolicitudSegundoNivel.Enabled = false;
                        chsolicitudSegundoNivel.Visible = grd_titulosSegundoNivel.Visible = txtSolicitudSegundoNivel.Visible = lblSegundoNivel.Visible = false;
                        this.Text = "Solicitud de Asistencia de Mantenimiento";
                        lblTitulo.Text = "Enviar una solicitud de soporte para Mantenimiento";
                        this.BackColor = Color.FromName("MediumAquamarine");
                        grd_usuario.EditValue = UsuarioLogeado.UserId;
                        lblSelecccion.Text = pOpcion;
                        lblSelecccion.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            load_Data();
            if (grd_proyectoPrimerNivel.EditValue == null)
            {

            }
            else
            {

                load_preguntas();
            }
            load_usuarios();
            colDescargar.Visible = false;
        }
        public void load_Data()
        {
            string Query = @"sp_TK_load_proyectos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(TipoTicketActual));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTickets.sp_TK_load_proyectos.Clear();
                da.Fill(dsTickets.sp_TK_load_proyectos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        } 
        private string getFileName( string file)
        {
            return Path.GetFileNameWithoutExtension(file);
        }


        private void frmTickets_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in dropfiles)
            {
                string filename = getFileName(file);
                CajaDialogo.Information("Se ha adjuntado con exito el archivo: " + filename);
                DataRow row = dsTickets.archivos.NewRow();
                row[0] = file;
                row[1] = filename;
                dsTickets.archivos.Rows.Add(row);

            }
        }

        private void frmTickets_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                
                        e.Effect = DragDropEffects.All;
                
            }
        }
        public void load_usuarios()
        {
            string Query = @"[dbo].[sp_load_user]";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsTickets.sp_load_user.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTickets.sp_load_user);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_preguntas()
        {
            string Query = @"sp_TK_load_preguntas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proyecto", grd_proyectoPrimerNivel.EditValue);
                cmd.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(TipoTicketActual));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTickets.sp_TK_load_preguntas.Clear();
                da.Fill(dsTickets.sp_TK_load_preguntas);
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void grd_proyecto_EditValueChanged(object sender, EventArgs e)
        {
            load_preguntas();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //string path;
            //Dialog.InitialDirectory = "C:/";
            //if (Dialog.ShowDialog() == DialogResult.OK)
            //{
            //    path = Dialog.FileName;
            //    DataRow row = dsTickets.archivos.NewRow();
            //    row[0] = path;
            //    row[1] = getFileName(path);
            //    dsTickets.archivos.Rows.Add(row);
            //    //CajaDialogo.Information("Se ha adjuntado con exito el archivo: " + getFileName(path));

            //}

            Dialog.InitialDirectory = "C:/";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                //path = Dialog.SafeFileName;
                DataRow row = dsTickets.archivos.NewRow();
                row["path"] = Dialog.FileName;
                row["FileName"] = Dialog.SafeFileName;
                dsTickets.archivos.Rows.Add(row);
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (LOSA.MigracionACS.Tickets.EndUser.dsTickets.archivosRow)gridView.GetFocusedDataRow();
                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
                dsTickets.archivos.AcceptChanges();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);   
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chsolicitudSegundoNivel.Checked)
            {
                txtSolicitudSegundoNivel.Enabled = true;
                txtSolicitudSegundoNivel.Text = "";
                grd_titulosSegundoNivel.Enabled = false;
                grd_titulosSegundoNivel.EditValue = null;
            }
            else
            {
                txtSolicitudSegundoNivel.Enabled = false;
                txtSolicitudSegundoNivel.Text = "";
                grd_titulosSegundoNivel.Enabled = true;  
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chusuario.Checked)
            {
                grd_usuario.Enabled = false;
                txtusuario.Enabled = true;
                txtusuario.Text = "";
                grd_usuario.EditValue = null;
            }
            else
            {
                grd_usuario.Enabled = true;
                txtusuario.Enabled = false;
                txtusuario.Text = "";
            }
        }

        private void btnAgregarCopia_Click(object sender, EventArgs e)
        {
            frmCopiarCorreo frm = new frmCopiarCorreo(dsTickets.end_user);
            int Encontrado = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {

                //borrar los encontrados
                for (int p = 0; p < grdv_info.RowCount; p++)
                {
                    var row = (dsTickets.end_userRow)grdv_info.GetDataRow(p);
                    var copiaCorreo = frm.list.Find(x => x.ID == row.id);
                    frm.list.Remove(copiaCorreo);
                }


                foreach (var item in frm.list)
                {

                    DataRow dr = dsTickets.end_user.NewRow();
                    dr[0] = item.Correo;
                    dr[1] = item.CC;
                    dr[2] = item.ID;
                    dsTickets.end_user.Rows.Add(dr);
                    dsTickets.end_user.AcceptChanges();
                }
                //foreach (DataRow row1 in frm.Result.Rows)
                //{
                //    Encontrado = 0;
                //    if (Convert.ToBoolean(row1["selecionado"]))
                //    {

                //        foreach (ACS.Tickets.EndUser.dsTickets.end_userRow row2 in dsTickets.end_user.Rows)
                //        {
                //            if (row1["id"].ToString() == row2.id.ToString())
                //            {
                //                Encontrado = 1;
                //                row2.CC = Convert.ToBoolean(row1["CC"]);
                //                row2.corro = row1["corro"].ToString();
                //                row2.id = Convert.ToInt32(row1["id"]);

                //            }
                //        }
                //        if (Encontrado == 0)
                //        {
                //            DataRow dr = dsTickets.end_user.NewRow();
                //            dr[0] = row1["corro"].ToString();
                //            dr[1] = row1["CC"];
                //            dr[2] = row1["id"];
                //            dsTickets.end_user.Rows.Add(dr);
                //            dsTickets.end_user.AcceptChanges();
                //        }

                //    }
                //    else
                //    {
                //        foreach (ACS.Tickets.EndUser.dsTickets.end_userRow row2 in dsTickets.end_user.Rows)
                //        {
                //            if (row1["id"].ToString() == row2.id.ToString())
                //            {
                //                row2.Delete();
                //                row2.AcceptChanges();
                //                break;

                //            }
                //        }
                //    }

                //}

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
               
                grdv_info.DeleteRow(grdv_info.FocusedRowHandle);
                dsTickets.end_user.AcceptChanges();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {

        }

        SqlTransaction transaction;
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (TipoTicketActual)
            {
                case TipoTicket.IT:

                    break;
                case TipoTicket.Manto:
                    break;
            }

            if (txtcomentario.Text == "")
            {
                CajaDialogo.Error("Debe especificar la informacion del comentario para obtener un soporte mas eficaz.");
                txtcomentario.Focus();
                return;
            }
            if (grd_proyectoPrimerNivel.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar un proyecto para asignar el ticket.");
                grd_proyectoPrimerNivel.ShowPopup();
                return;
            }

            if (TipoTicketActual == TipoTicket.IT)
            {
                if (chusuario.Checked)
                {

                    if (txtSolicitudSegundoNivel.Text == "")
                    {
                        CajaDialogo.Error("Debe especificar el titulo de la solicitud.");
                        txtSolicitudSegundoNivel.Focus();
                        return;
                    }

                }
                else
                {
                    if (!chsolicitudSegundoNivel.Checked)
                    {
                        if (grd_titulosSegundoNivel.EditValue == null)
                        {
                            CajaDialogo.Error("Debe especificar el titulo de la solicitud.");
                            grd_titulosSegundoNivel.ShowPopup();
                            return;
                        }
                    }
                }
            }

            if (chusuario.Checked)
            {
                if (txtusuario.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el usuario el cual esta haciendo la solicitud.");
                    if (TipoTicketActual == TipoTicket.IT)
                    {
                        txtSolicitudSegundoNivel.Focus();
                    }
                    else
                    {
                        txtusuario.Focus();
                    }
                    return;
                }
                else
                {
                    if (grd_usuario.EditValue == null)
                    {
                        CajaDialogo.Error("Debe especificar el usuario el cual esta haciendo la solicitud.");
                        grd_usuario.ShowPopup();
                        return;
                    }
                }
            }



            try
            {
                string query = @"[dbo].[sp_Tk_insert_ticket_Mantenimiento]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                transaction = cn.BeginTransaction("SampleTransaction");

                SqlCommand cmd = new SqlCommand(query, transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                cmd.Parameters.AddWithValue("@name", chsolicitudSegundoNivel.Checked ? txtusuario.Text : grd_usuario.Text);
                cmd.Parameters.AddWithValue("@id_proyecto", grd_proyectoPrimerNivel.EditValue);
                cmd.Parameters.AddWithValue("@comentario2", txtcomentario.Text);

                if (TipoTicketActual == TipoTicket.Manto)
                    cmd.Parameters.AddWithValue("@tittle", "Requerimiento");
                else
                    cmd.Parameters.AddWithValue("@tittle", chsolicitudSegundoNivel.Checked ? txtSolicitudSegundoNivel.Text : grd_titulosSegundoNivel.Text);

                cmd.Parameters.AddWithValue("@id_tipo",Convert.ToInt32(TipoTicketActual));
                int id_inserted = Convert.ToInt32(cmd.ExecuteScalar());      // Se sube el ticket




                string query2 = @"sp_TK_insert_mensaje";
                SqlCommand cmd2 = new SqlCommand(query2, transaction.Connection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Transaction = transaction;

                cmd2.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                cmd2.Parameters.AddWithValue("@comentario", txtcomentario.Text);

                if (TipoTicketActual == TipoTicket.Manto)
                    cmd2.Parameters.AddWithValue("@tittle", "Requerimiento");
                else
                    cmd2.Parameters.AddWithValue("@tittle", chsolicitudSegundoNivel.Checked ? txtSolicitudSegundoNivel.Text : grd_titulosSegundoNivel.EditValue);

                cmd2.Parameters.AddWithValue("@id_ticket", id_inserted);
                cmd2.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(TipoTicketActual));
                int id_mensaje = Convert.ToInt32(cmd2.ExecuteScalar());


                //Guardar Detalle copia correo
                var gv = (GridView)grd_info.FocusedView;

                for (int i = 0; i < gv.RowCount; i++)
                {
                    var row = (dsTickets.end_userRow)grdv_info.GetDataRow(i);

                    SqlCommand cmd3 = new SqlCommand("sp_tk_insert_mensaje_destino", transaction.Connection);
                    cmd3.Transaction = transaction;
                    cmd3.CommandType = CommandType.StoredProcedure;

                    cmd3.Parameters.AddWithValue("@id_destino", SqlDbType.Int).Value = row.id;
                    cmd3.Parameters.AddWithValue("@copia", SqlDbType.Bit).Value = row.CC;
                    cmd3.Parameters.AddWithValue("@bit_copia", SqlDbType.Bit).Value = row.CC;
                    cmd3.Parameters.AddWithValue("@correo", SqlDbType.VarChar).Value = row.corro;
                    cmd3.Parameters.AddWithValue("@id_mensaje", SqlDbType.Int).Value = id_mensaje;
                    cmd3.Parameters.AddWithValue("@id_tipo", SqlDbType.Int).Value = TipoTicketActual;

                    cmd3.ExecuteNonQuery();
                }



                //Insertar archivos
                var gvArchivos = (GridView)grd_data.FocusedView;

                for (int i = 0; i < gvArchivos.RowCount; i++)
                {
                    var row = (dsTickets.archivosRow)gvArchivos.GetDataRow(i);

                    SqlCommand cmd4 = new SqlCommand("dbo.sp_tk_insert_archivo_adjunto", transaction.Connection);
                    cmd4.Transaction = transaction;
                    cmd4.CommandType = CommandType.StoredProcedure;

                    cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_Tickets_ACS + row.FileName;
                    cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.FileName;
                    cmd4.Parameters.Add("@ticket_id", SqlDbType.Int).Value = id_inserted;

                    cmd4.ExecuteNonQuery();

                }


                transaction.Commit();
                cn.Close();

                //Subir los archivos luego de pasar el commit
                foreach (var item in dsTickets.archivos)
                {
                    Upload(item.Path, item.FileName);
                }

                if (ticketInfo.RecuperaRegistro(id_inserted))
                {

                    emailTcketParams.Destinatario = ticketInfo.UsuarioCreadorMail;

                    List<string> copyMails = new List<string>();

                    if (ticketInfo.copiaCorreos != null)
                    {

                        foreach (var email in ticketInfo.copiaCorreos)
                        {
                            copyMails.Add(email);
                        }
                    }

                    emailTcketParams.CorreosCC = copyMails;


                    emailTcketParams.TicketID = ticketInfo.ID;
                    emailTcketParams.IsHTML = true;
                    emailTcketParams.Body = ticketInfo.Comentario;
                    emailTcketParams.Subject = "Ticket de Mantenimiento:" + ticketInfo.Titulo;
                    emailTcketParams.Nombre = ticketInfo.UsuarioCreador;
                    emailTcketParams.UsuarioAsignado = ticketInfo.UsuarioAsignado;
                    emailTcketParams.Estado = ticketInfo.Estado;

                    ops.SendEmailTicketCreated(emailTcketParams);

                }


                CajaDialogo.Information("Solicitud enviada con exito!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }


        }//end function guardar

        private bool Upload(string pathFile, string fileName)
        {

            try
            {

                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó la imagen");
                    return false;
                }
                else
                {
                    //DataOperations dp = new DataOperations();

                    //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Tickets_ACS + fileName);
                    //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                    ////request.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
                    //request.Method = WebRequestMethods.Ftp.UploadFile;

                    //using (Stream fileStream = File.OpenRead(pathFile))
                    //using (Stream ftpStream = request.GetRequestStream())
                    //{
                    //    fileStream.CopyTo(ftpStream);
                    //}
                    //return true;
                    FTP_Class ftp1 = new FTP_Class();
                    return ftp1.GuardarArchivo(UsuarioLogeado, fileName, pathFile);
                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void LoadCorreos()
        {
            string Query = @"dbo.sp_TK_get_correos_copia";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(tk.Id));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTickets.end_user.Clear();
                da.Fill(dsTickets.end_user);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void load_adjuntos()
        {
            string Query = @"dbo.sp_tk_get_adjuntos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(tk.Id));
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

        private void DownloadFile(string pathSource, string pathDestination)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();

            //    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
            //    request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
            //    //request.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
            //    request.Method = WebRequestMethods.Ftp.DownloadFile;

            //    using (Stream ftpStream = request.GetResponse().GetResponseStream())
            //    using (Stream fileStream = File.Create(pathDestination))
            //    {
            //        ftpStream.CopyTo(fileStream);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            FTP_Class ftp1 = new FTP_Class();
            ftp1.DownloadFile(pathSource, pathDestination,  UsuarioLogeado);
        }

        private void btnDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsTickets.archivosRow)gridView.GetDataRow(grdv_data.FocusedRowHandle);

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}