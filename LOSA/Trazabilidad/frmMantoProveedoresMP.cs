using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Trazabilidad
{
    public partial class frmMantoProveedoresMP : DevExpress.XtraEditors.XtraForm
    {
        Proveedor vProveedorActual;
        UserLogin UsuarioLogeado;
        public frmMantoProveedoresMP(UserLogin pUser)
        {
            InitializeComponent();
            vProveedorActual = new Proveedor();
            LoadTiposArchivos();
            UsuarioLogeado = pUser;
            LoadAdjuntosRows();
        }

        private void cmdBuscarProveedores_Click(object sender, EventArgs e)
        {
            frmBuscarProvMP frm = new frmBuscarProvMP();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                txtCodigo.Text = frm.ProveedorRow.Codigo;
                txtNombre.Text = frm.ProveedorRow.Nombre;
                txtNombreF.Text = frm.ProveedorRow.NombreF;
                txtRTN.Text = frm.ProveedorRow.RTN;
                vProveedorActual = frm.ProveedorRow;
                txtContacto.Text= frm.ProveedorRow.Contacto;
                txtTel1.Text = frm.ProveedorRow.Telefono1;
                txtTel2.Text = frm.ProveedorRow.Telefono2;
                txtTel3.Text = frm.ProveedorRow.Telefono3;
                txtDireccion.Text = frm.ProveedorRow.Direccion;
                txtCorreo.Text = frm.ProveedorRow.Correo;
                LoadAdjuntosRows();
                LoadPlantas();
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!vProveedorActual.Recuperado)
            {
                CajaDialogo.Error("Debe seleccionar un proveedor para poder relacionar un archivo Adjunto!");
                return;
            }
            frmAdjuntar frm = new frmAdjuntar(vProveedorActual.Codigo, UsuarioLogeado);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadAdjuntosRows();
            }
        }

        private void LoadAdjuntosRows()
        {
            //
            if(vProveedorActual.Codigo == null)
            {
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_adjuntos_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", vProveedorActual.Codigo);
                dsMantoTrazabilidad1.archivos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.archivos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadTiposArchivos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tipos_archivos_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMantoTrazabilidad1.tipos_archivos_prv.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.tipos_archivos_prv);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEliminarRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar este Archivo?");
            if (r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                SqlCommand cmd = new SqlCommand("sp_set_disable_archivo_adjunto_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadAdjuntosRows();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "descripcion":
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                        SqlCommand cmd = new SqlCommand("sp_set_update_description_archivo_adjunto_trz_prv", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.Parameters.AddWithValue("@descrip", row.descripcion);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //LoadAdjuntosRows();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case "id_tipo":
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        var gridView = (GridView)gridControl2.FocusedView;
                        var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

                        SqlCommand cmd = new SqlCommand("sp_set_update_type_archivo_adjunto_trz_prv", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.Parameters.AddWithValue("@id_type", row.id_tipo);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //LoadAdjuntosRows();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
            }
            
        }

        private void cmdAbrir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string dir = @"C:\ALOSY_TMP";

                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }


                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();


                OpenFile(row.Path, dir + @"\" + row.FileName);
                //openFileDialog1.OpenFile(
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
                request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
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

        private void cmdDownload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMantoTrazabilidad.archivosRow)gridView.GetFocusedDataRow();

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
                request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1,UsuarioLogeado.Pass);
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

        private void cmdDelete__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Delete
            DialogResult r = CajaDialogo.Pregunta("Realmente desea eliminar esta registro?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.plantasRow)gridView.GetFocusedDataRow();
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_disable_planta_prv_trz", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.ExecuteNonQuery();

                con.Close();
                LoadPlantas();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmCRUD_PlantasPRV frm = new frmCRUD_PlantasPRV(vProveedorActual.Codigo, 0, frmCRUD_PlantasPRV.TipoAccion.Insert, UsuarioLogeado.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPlantas();
            }
        }

        private void LoadPlantas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lista_plantas_prv_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode",vProveedorActual.Codigo);
                dsMantoTrazabilidad1.plantas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMantoTrazabilidad1.plantas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.plantasRow)gridView.GetFocusedDataRow();

            frmCRUD_PlantasPRV frm = new frmCRUD_PlantasPRV(vProveedorActual.Codigo, row.id, frmCRUD_PlantasPRV.TipoAccion.Update, UsuarioLogeado.Id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadPlantas();
            }
        }
    }
}