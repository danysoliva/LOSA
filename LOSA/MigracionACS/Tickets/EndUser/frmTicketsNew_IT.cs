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
    public partial class frmTicketsNew_IT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public int ItemSeleccionado = 0;
        
        Clases.Ticket tk;
        int IdCategoria;
        int IdOpcion;
        int TipoSoftoHard;

        TicketInfo ticketInfo = new TicketInfo();
        EmailTicketParams emailTcketParams = new EmailTicketParams();
        SecOps ops = new SecOps();

        public enum TipoTicket
        {
            IT = 1,
            Manto = 2
        }

        public TipoTicket TipoTicketActual = TipoTicket.IT;

        public frmTicketsNew_IT(UserLogin Puser, int PidTicket, int pTipoSoftoHard, int pOpcion)
        {
            InitializeComponent();
            TipoSoftoHard = pTipoSoftoHard;

            if (pTipoSoftoHard == 1)
            {
                navigationFrame1.SelectedPage = navigationPage1;
            }
            else
            {
                if (pOpcion < 3)
                {
                    navigationFrame1.SelectedPage = navigationPage2;
                }
                else
                {
                    //Problemas de conexion

                }
            }

            TipoTicketActual = TipoTicket.IT;
            
            tk = new Clases.Ticket(PidTicket);
            lblUserName.Caption = Puser.Nombre;
            txtcomentario.Text = tk.Comentario;
            IdCategoria = pTipoSoftoHard;
            IdOpcion = pOpcion;
            txtTitulo.Text = tk.Titulo;

            UsuarioLogeado = Puser;

            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtNameVentana.Visible = true;

            load_Data();
            LoadEquiposHardware();
            //LoadProyectosSeleccionados();
        }




        private void LoadEquiposHardware()
        {
            string Query = @"sp_get_detalle_equipos_tk_hardware";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(TipoTicketActual));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTickets.equipos_hardware.Clear();
                da.Fill(dsTickets.equipos_hardware);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_Data()
        {
            string Query = @"sp_TK_load_proyectos_IT";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(TipoTicketActual));
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
       

        private void grd_proyecto_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //string path;
            //Dialog.InitialDirectory = "C:/";

            //if (Dialog.ShowDialog() == DialogResult.OK)
            //{
            //    path = Dialog.SafeFileName;
            //    DataRow row = dsTickets.archivos.NewRow();
            //    row[0] = path;
            //    row[1] = getFileName(path);
            //    dsTickets.archivos.Rows.Add(row);
            //    CajaDialogo.Information("Se ha adjuntado con exito el archivo: " + getFileName(path));

            //}

            xtraOpenFileDialog1.InitialDirectory = "C:/";

            if (xtraOpenFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //path = Dialog.SafeFileName;
                DataRow row = dsTickets.archivos.NewRow();
                row["path"] = xtraOpenFileDialog1.FileName ;
                row["FileName"] = xtraOpenFileDialog1.SafeFileName;
                dsTickets.archivos.Rows.Add(row);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Deseas eliminar este registro?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    //Sacaos el row seleccionado
                    var gridView = (GridView)grd_archivos.FocusedView;
                    var row = (dsTickets.archivosRow)gridView.GetFocusedDataRow();

                    //Si el row seleccionado el id = 0 significa que solo existe en memoria el adjunto.
                    if(row.id == 0)
                    {
                        //Borramos unicamente el row en memoria
                        row.Delete();
                        return;
                    }

                    DataOperations dp = new DataOperations();
                    SqlConnection connectionBD = new SqlConnection(dp.ConnectionStringCostos);

                    using (SqlCommand command = new SqlCommand("dbo.sp_tk_delete_adjunto", connectionBD))
                    {
                        connectionBD.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(grdv_archivos.GetFocusedRowCellValue(ColID_).ToString());
                        command.Parameters.AddWithValue("@id", row.id);

                        command.ExecuteNonQuery();
                        connectionBD.Close();

                        load_adjuntos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnAgregarCopia_Click(object sender, EventArgs e)
        {
            frmCopiarCorreo frm = new frmCopiarCorreo(dsTickets.end_user);


            //int Encontrado = 0;
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
            if (TipoSoftoHard == 1)
            {
                LoadProyectosSeleccionados();
            }
            else
                LoadHardwareEquipoSeleccionados();

            load_adjuntos();
            if (tk.Id>=1)
            {
                colDescarga.Visible = true;
                txtcomentario.ReadOnly = true;
                txtTitulo.ReadOnly = true;
                btnAgregarCopia.Enabled = false;
                btnExaminar.Enabled = false;
                coleliminar.Visible = false;
                colseleccionado.OptionsColumn.AllowEdit = false;
                colseleccionado1.OptionsColumn.AllowEdit = false;
                LoadCorreos();
                btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ColEliminar2.Visible = false;
            }

        }

        SqlTransaction transaction;
        Boolean guardaDatos;
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (string.IsNullOrEmpty(txtcomentario.Text))
            {
                CajaDialogo.Error("Debe especificar la informacion del problema para obtener un soporte mas eficaz.");
                txtcomentario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTitulo .Text))
            {
                CajaDialogo.Error("Debe especificar el título para el ticket.");
                txtcomentario.Focus();
                return;
            }

            bool ProyectoOK = false;
            string mensaje_error = "";
            //Validar que al menos selecciono un proyecto
            if (TipoSoftoHard == 1)
            {
                foreach (dsTickets.sp_TK_load_proyectosRow row in dsTickets.sp_TK_load_proyectos.Rows)
                {
                    if (row.seleccionado == true)
                    {
                        ProyectoOK = true;
                        break;
                    }
                    else 
                    {
                        ProyectoOK = false;
                    }
                }
                if (ProyectoOK == false)
                {
                    CajaDialogo.Error("Debe seleccionar un Sistema Afectado!");
                    return;
                }
            }
            if (TipoSoftoHard > 1)
            {
                foreach (dsTickets.equipos_hardwareRow row in dsTickets.equipos_hardware.Rows)
                {
                    if (row.seleccionado == true)
                    {
                        ProyectoOK = true;
                        break;
                    }
                    else
                    {
                        ProyectoOK = false;
                    }
                }
                if (ProyectoOK == false)
                {
                    CajaDialogo.Error("Debe seleccionar un Equipo Afectado!");
                    return;
                }
            }

            try
            {
                string query = @"sp_Tk_insert_ticket_IT_V2";
                //SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

                cnx.Open();
                transaction = cnx.BeginTransaction("SampleTransaction");

                //cn.Open();

                SqlCommand cmd = new SqlCommand(query, transaction.Connection);
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                cmd.Parameters.AddWithValue("@name", UsuarioLogeado.NombreUser);
                /*cmd.Parameters.AddWithValue("@id_proyecto", );*/
                cmd.Parameters.AddWithValue("@comentario2", txtcomentario.Text);


                cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
                cmd.Parameters.AddWithValue("@id_opcion", IdOpcion);
                cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                int id_inserted = Convert.ToInt32(cmd.ExecuteScalar());      // Se sube el ticket



                //Guarda el mensaje o notificacion
                query = @"sp_TK_insert_mensaje";
                cmd = new SqlCommand(query, transaction.Connection);
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);

                cmd.Parameters.AddWithValue("@tittle", "Requerimiento");

                cmd.Parameters.AddWithValue("@id_ticket", id_inserted);
                cmd.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(TipoTicketActual));
                int id_mensaje = Convert.ToInt32(cmd.ExecuteScalar());



                //Guardar proyectos
                if (TipoSoftoHard == 1)
                {
                    var gvPoyecto = (GridView)gcProyectos.FocusedView;

                    for (int i = 0; i < gvPoyecto.RowCount; i++)
                    {
                        var row = (dsTickets.sp_TK_load_proyectosRow)gvPoyecto.GetDataRow(i);

                        if (row.seleccionado == true)
                        {
                            SqlCommand cmdProyecto = new SqlCommand("sp_tk_insert_proyectos_selected", transaction.Connection);
                            cmdProyecto.Transaction = transaction;
                            cmdProyecto.CommandType = CommandType.StoredProcedure;

                            cmdProyecto.Parameters.AddWithValue("@id_ticket", SqlDbType.Int).Value = id_inserted;
                            cmdProyecto.Parameters.AddWithValue("@id_proyecto", SqlDbType.Bit).Value = row.ID;

                            cmdProyecto.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    //Guardar Hardware
                    if (TipoSoftoHard > 1)
                    {
                        var grdHardware = (GridView)gcEquipo.FocusedView;

                        for (int i = 0; i < grdHardware.RowCount; i++)
                        {
                            var row = (dsTickets.equipos_hardwareRow)grdHardware.GetDataRow(i);

                            if (row.seleccionado == true)
                            {
                                SqlCommand cmdProyecto = new SqlCommand("sp_TK_insert_equipo_hardware_selected", transaction.Connection);
                                cmdProyecto.Transaction = transaction;
                                cmdProyecto.CommandType = CommandType.StoredProcedure;

                                cmdProyecto.Parameters.AddWithValue("@id_ticket", SqlDbType.Int).Value = id_inserted;
                                cmdProyecto.Parameters.AddWithValue("@id_equipo", SqlDbType.Bit).Value = row.id;
                                cmdProyecto.Parameters.AddWithValue("@id_tipo", SqlDbType.Bit).Value = 1;

                                cmdProyecto.ExecuteNonQuery();
                            }
                        }
                    }


                }






                //Guardar detalle de destinatarios de correo electronico
                var gv = (GridView)grd_info.FocusedView;

                for (int i = 0; i < gv.RowCount; i++)
                {
                    var row = (dsTickets.end_userRow)grdv_info.GetDataRow(i);

                    SqlCommand cmd2 = new SqlCommand("sp_tk_insert_mensaje_destino", transaction.Connection);
                    cmd2.Transaction = transaction;
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@id_destino", SqlDbType.Int).Value = row.id;
                    cmd2.Parameters.AddWithValue("@copia", SqlDbType.Bit).Value = row.CC;
                    cmd2.Parameters.AddWithValue("@bit_copia", SqlDbType.Bit).Value = row.CC;
                    cmd2.Parameters.AddWithValue("@correo", SqlDbType.VarChar).Value = row.corro;
                    cmd2.Parameters.AddWithValue("@id_mensaje", SqlDbType.Int).Value = id_mensaje;
                    cmd2.Parameters.AddWithValue("@id_tipo", SqlDbType.Int).Value = IdOpcion;

                    cmd2.ExecuteNonQuery();

                }

                //Insertar archivos
                var gvArchivos = (GridView)grd_archivos.FocusedView;

                for (int i = 0; i < gvArchivos.RowCount; i++)
                {
                    var row = (dsTickets.archivosRow)gvArchivos.GetDataRow(i);

                    SqlCommand cmd3 = new SqlCommand("dbo.sp_tk_insert_archivo_adjunto", transaction.Connection);
                    cmd3.Transaction = transaction;
                    cmd3.CommandType = CommandType.StoredProcedure;

                    cmd3.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_Tickets_ACS+ row.FileName;
                    cmd3.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.FileName;
                    cmd3.Parameters.Add("@ticket_id", SqlDbType.Int).Value = id_inserted;

                    cmd3.ExecuteNonQuery(); 

                }




                if (gvArchivos.RowCount>0)
                {

                    //Subir los archivos luego de pasar el commit
                    for (int i = 0; i < gvArchivos.RowCount; i++)
                    {
                        var row = (dsTickets.archivosRow)gvArchivos.GetDataRow(i);

                        if (Upload(row.Path, row.FileName))
                        {
                            guardaDatos = true;
                        }
                        else
                        {
                            guardaDatos = false;
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
                    if (ticketInfo.RecuperaRegistro(id_inserted))
                    {

                        emailTcketParams.Destinatario = ticketInfo.UsuarioCreadorMail;
                        emailTcketParams.CorreosCC = null;

                        List<string> copyMails = new List<string>();


                        if (ticketInfo.copiaCorreos != null)
                        {
                            copyMails = ticketInfo.copiaCorreos;
                            copyMails.Add("ruben.garcia@aquafeedhn.com");
                            copyMails.Add("ever.erazo@aquafeedhn.com");
                            //foreach (var email in ticketInfo.copiaCorreos)
                            //{
                            //    copyMails.Add(email);
                            //}
                        }

                        emailTcketParams.CorreosCC = copyMails;

                        emailTcketParams.TicketID = ticketInfo.ID;
                        emailTcketParams.IsHTML = true;
                        emailTcketParams.Body = ticketInfo.Comentario;
                        emailTcketParams.Subject = "Ticket de IT: " + ticketInfo.Titulo;
                        emailTcketParams.Nombre = ticketInfo.UsuarioCreador;
                        emailTcketParams.UsuarioAsignado = ticketInfo.UsuarioAsignado;
                        emailTcketParams.Estado = ticketInfo.Estado;
                        emailTcketParams.PrioridadTicket = ticketInfo.Prioridad;
                        emailTcketParams.TituloTicket = ticketInfo.Titulo;

                        ops.SendEmailTicketCreated(emailTcketParams);

                    }

                    cnx.Close();
                    CajaDialogo.Information("Solicitud enviada con exito!");
                    this.Close();


                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }


        }//end function guardar

        private void DownloadFile(string pathSource, string pathDestination)
        {
            //try
            //{
            //    DataOperations dp = new DataOperations();

            //    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
            //    //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
            //    request.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
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
            ftp1.DownloadFile(pathSource, pathDestination, UsuarioLogeado);
        }

        private void btnDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_archivos.FocusedView;
                var row = (dsTickets.archivosRow)gridView.GetDataRow(grdv_archivos.FocusedRowHandle);

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

        void load_adjuntos()
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
                    ////request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                    //string pass = "Tempo1234";
                    //string user_op = "operador";
                    //if (UsuarioLogeado != null)
                    //{
                    //    if(!string.IsNullOrEmpty(UsuarioLogeado.Password))
                    //    {
                    //        user_op = UsuarioLogeado.AD_User;
                    //        pass = UsuarioLogeado.Password;
                    //    }
                    //}

                    //request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                    //request.Method = WebRequestMethods.Ftp.UploadFile;
                    //request.EnableSsl = false;

                    //using (Stream fileStream = File.OpenRead(pathFile))
                    //using (Stream ftpStream = request.GetRequestStream())
                    //{
                    //    fileStream.CopyTo(ftpStream);
                    //}

                    FTP_Class ftp1 = new FTP_Class();
                    return ftp1.GuardarArchivo(UsuarioLogeado,fileName,pathFile);

                }
            }

            catch (Exception ex)
            {

                transaction.Rollback();
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void LoadProyectosSeleccionados()
        {
            string Query = @"dbo.sp_tk_get_proyectos_selected ";
            //SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {


                DataOperations dp = new DataOperations();
                List<ProyectoSelected> lstproyectoSelected = new List<ProyectoSelected>();
                var grdvProyecto = (GridView)gcProyectos.FocusedView;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {

                    cnx.Open();
                    SqlCommand cmd = new SqlCommand(Query, cnx);
                    cmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(tk.Id));
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ProyectoSelected proyectoSelected = new ProyectoSelected();

                        proyectoSelected.ProyectoID = dr.GetInt32(0);

                        lstproyectoSelected.Add(proyectoSelected);

                    }

                    cnx.Close();
                }


                for (int i = 0; i < grdvProyecto.RowCount; i++)
                {
                    var row = (dsTickets.sp_TK_load_proyectosRow)grdvProyecto.GetDataRow(i);
                    for (int p = 0; p < lstproyectoSelected.Count; p++)
                    {
                        if (lstproyectoSelected.Find(l => l.ProyectoID == row.ID)!=null)
                        {
                            row.seleccionado = true;
                            lstproyectoSelected.Remove(lstproyectoSelected.Find(l => l.ProyectoID == row.ID));
                        }
                        
                    }
                }
                

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadHardwareEquipoSeleccionados()
        {
            string Query = @"[dbo].[sp_tk_get_equipo_hardware_selected]";
            //SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);

            try
            {


                DataOperations dp = new DataOperations();
                List<EquipoHardwareSelected> lstEquipoHardwareSelected = new List<EquipoHardwareSelected>();
                var grdvHardware = (GridView)gcEquipo.FocusedView;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {

                    cnx.Open();
                    SqlCommand cmd = new SqlCommand(Query, cnx);
                    cmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(tk.Id));
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        EquipoHardwareSelected equipoSelected = new EquipoHardwareSelected();

                        equipoSelected.EquipoID = dr.GetInt32(0);

                        lstEquipoHardwareSelected.Add(equipoSelected);

                    }

                    cnx.Close();
                }

                for (int i = 0; i < grdvHardware.RowCount; i++)
                {
                    var row = (dsTickets.equipos_hardwareRow)grdvHardware.GetDataRow(i);
                    for (int p = 0; p < lstEquipoHardwareSelected.Count; p++)
                    {
                        if (lstEquipoHardwareSelected.Find(l => l.EquipoID == row.id)!=null)
                        {
                            row.seleccionado = true;
                            lstEquipoHardwareSelected.Remove(lstEquipoHardwareSelected.Find(l => l.EquipoID == row.id));
                        }
                        
                    }
                }
                

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
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

        private void gvEquipo_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gcEquipo.FocusedView;
            var row = (dsTickets.equipos_hardwareRow)gridView.GetFocusedDataRow();

            if (Convert.ToBoolean(e.Value))
            {
                ItemSeleccionado = row.id;
                row.seleccionado = true;
            }

            foreach (dsTickets.equipos_hardwareRow row1 in dsTickets.equipos_hardware.Rows)
            {
                if (row1.id != ItemSeleccionado)
                    row1.seleccionado = false;
            }
        }

        private void gvProyectos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gcProyectos.FocusedView;
            var row = (dsTickets.sp_TK_load_proyectosRow)gridView.GetFocusedDataRow();

            if (Convert.ToBoolean(e.Value))
            {
                ItemSeleccionado = row.ID;
                row.seleccionado = true;
            }

            foreach (dsTickets.sp_TK_load_proyectosRow row1 in dsTickets.sp_TK_load_proyectos.Rows)
            {
                if (row1.ID != ItemSeleccionado)
                    row1.seleccionado = false;
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}