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

namespace LOSA.MigracionACS.Produccion.BannerTV
{
    public partial class frmMantoPhotosTV : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuariologeado;
        public frmMantoPhotosTV(UserLogin pUserlogeado)
        {
            InitializeComponent();
            usuariologeado = pUserlogeado;
            LoadTabs();
        }

        private void LoadTabs()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bannertv_list_tabs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsBanner1.bannerhome.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsBanner1.bannerhome);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsBanner.bannerhomeRow)gridView.GetFocusedDataRow();
            if (row.use_image)
            {
                frmAdjuntar frm = new frmAdjuntar(row.id, usuariologeado, frmAdjuntar.TipoAccion.Insert, row.caption);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTabs();
                }
            }
        }
        private void OpenFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                //request.Credentials = new NetworkCredential(usuariologeado.AD_User, usuariologeado.Password,"AQUAFEEDHN.COM");
                request.Credentials = new NetworkCredential("operador", "Tempo1234", "AQUAFEEDHN.COM");
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

        private void cmdVerImg_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView2 = (GridView)gridControl1.FocusedView;
            var row2 = (dsBanner.bannerhomeRow)gridView2.GetFocusedDataRow();
            if (row2.use_image)
            {
                if (row2.id_adjunto > 0)
                {
                    if(row2.Path == "N/D")
                    {
                        CajaDialogo.Error("No hay una imagen asociada!");
                        return;
                    }

                    try
                    {
                        string dir = @"C:\Banner_TMP";

                        // If directory does not exist, create it
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }


                        OpenFile(row2.Path, dir + @"\" + row2.FileName);
                        //openFileDialog1.OpenFile(
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
                else
                {
                    CajaDialogo.Error("No hay una imagen asociada!");
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "interval")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsBanner.bannerhomeRow)gridView.GetFocusedDataRow();

                int inter = Convert.ToInt32(e.Value);
                if (inter < 3)
                {
                    CajaDialogo.Error("No se permite una cantidad menor a 3 segundos!");
                    BannerTV_Tab tab = new BannerTV_Tab();
                    if (tab.RecuperarRegistro(row.id_tab))
                    {
                        row.interval = tab.Interval;
                    }
                    return;
                }
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                    con.Open();

                    

                    SqlCommand cmd = new SqlCommand("sp_set_update_interval_banner_tv", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.Parameters.AddWithValue("@inter", e.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }
    }
}