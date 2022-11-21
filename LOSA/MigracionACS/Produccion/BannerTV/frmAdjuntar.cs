using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;


namespace LOSA.MigracionACS.Produccion.BannerTV
{
    public partial class frmAdjuntar : DevExpress.XtraEditors.XtraForm
    {
        int  vIdTab;
        string PathArchivoOrigen;
        UserLogin usuariologeado;
        public enum TipoAccion
        {
            Insert = 1,
            Update = 2
        }
        private TipoAccion TipoAccionActual = TipoAccion.Insert;
        public frmAdjuntar(int pIdTab, UserLogin pUser, TipoAccion pTipoAccion, string  pCaption)
        {
            InitializeComponent();
            vIdTab = pIdTab;
            txtDescripcion.Text = pCaption;
            TipoAccionActual = pTipoAccion;
            usuariologeado = pUser;
            LoadtiposArchivos();
        }

        private void LoadtiposArchivos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();
                
                SqlCommand cmd = new SqlCommand("sp_get_tipos_archivos_trz_prv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                //dsMantoTrazabilidad1.tipos_archivos_prv.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsMantoTrazabilidad1.tipos_archivos_prv);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:/";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;...";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //path = Dialog.SafeFileName;
                //DataRow row = dsMantoTrazabilidad1.archivos.NewRow();
                //row["path"] = openFileDialog1.FileName;
                //row["FileName"] = openFileDialog1.SafeFileName;
                lblArchivoName.Text = openFileDialog1.SafeFileName;
                PathArchivoOrigen = openFileDialog1.FileName;

                //dsMantoTrazabilidad1.archivos.Rows.Add(row);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //Insertar archivos
            //var gvArchivos = (GridView)grd_data.FocusedView;
            //if (string.IsNullOrEmpty(gridLookUpEdit1.Text))
            //{
            //    CajaDialogo.Error("Debe seleccionar el tipo de Archivo que está adjuntando!");
            //    return;
            //}

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe escribir una descripción del archivo que está adjuntando!");
                return;
            }

            try
            {
                string FileName = PathArchivoOrigen;
                DataOperations dp = new DataOperations();
                if (toggleSwitchVisible.IsOn)
                {
                    string Path_ = dp.FTP_BannerTv_PRD + vIdTab + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + lblArchivoName.Text;
                    if (Upload(Path_, FileName))
                    {
                        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                        con.Open();
                        SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_bannertv]", con);
                        //cmd4.Transaction = transaction;
                        cmd4.CommandType = CommandType.StoredProcedure;

                        cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = Path_;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                        cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = lblArchivoName.Text;
                        //cmd4.Parameters.AddWithValue("@proveedor", vProveedorCodigo);
                        cmd4.Parameters.AddWithValue("@idtipo", DBNull.Value);
                        cmd4.Parameters.AddWithValue("@descrip", txtDescripcion.Text);
                        cmd4.Parameters.AddWithValue("@id_user", usuariologeado.UserId);
                        cmd4.Parameters.AddWithValue("@visible", toggleSwitchVisible.IsOn);
                        cmd4.Parameters.AddWithValue("@idtab", vIdTab);
                        cmd4.ExecuteNonQuery();
                        con.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    string Path_ = "N/D";

                    
                    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("[sp_insert_archivo_adjunto_bannertv]", con);
                    //cmd4.Transaction = transaction;
                    cmd4.CommandType = CommandType.StoredProcedure;

                    cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = Path_;//dp.FTP_Tickets_LOSA + vProveedorCodigo + "_" + lblArchivoName.Text;
                    cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = "N/D";
                    //cmd4.Parameters.AddWithValue("@proveedor", vProveedorCodigo);
                    cmd4.Parameters.AddWithValue("@idtipo", DBNull.Value);
                    cmd4.Parameters.AddWithValue("@descrip", txtDescripcion.Text);
                    cmd4.Parameters.AddWithValue("@id_user", usuariologeado.UserId);
                    cmd4.Parameters.AddWithValue("@visible", toggleSwitchVisible.IsOn);
                    cmd4.Parameters.AddWithValue("@idtab", vIdTab);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ec)
            {
                CajaDialogo.Error(ec.Message);
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
                    request.Credentials = new NetworkCredential("operador", "Tempo1234");
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
    }
}