using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using LOSA.Clases;
using System.Data.SqlClient;

namespace LOSA.Calidad.Parametros
{
    public partial class frmAdjuntos_PT : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        int id_pt;
        int lote_pt;
        public frmAdjuntos_PT(UserLogin pUserLog)
        {
            InitializeComponent();
        }

        private void btnAdjuntarDocumento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_adjuntos.FocusedView;
            var row = (dsTRZ_Reports.adjuntos_ptRow)gridView.GetFocusedDataRow();

            if (row.bit_subido)
            {
                CajaDialogo.Error("Debe desadjuntar el archivo antes de Cargar un nuevo archivo.");
                return;
            }
            openFileDialog1.InitialDirectory = "C:/";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                row.file_name = openFileDialog1.SafeFileName;
                row.path = openFileDialog1.FileName;
                DataOperations dp = new DataOperations();
                string Path_ = row.id_conf + "_" + string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + row.file_name;
                FTP_Class fpt1 = new FTP_Class();
                if (fpt1.GuardarArchivo(UsuarioLogueado, Path_, row.path))
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_insert_archivo_adjunto_ingresoV3", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@path", Path_);
                    cmd.Parameters.AddWithValue("@file_name", row.file_name);
                    cmd.Parameters.AddWithValue("@id_user", UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@id_config", row.id_conf);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                Inicalizar_Archivo_configurados();
                //row.path = openFileDialog1.FileName;
                //row.path_load = openFileDialog1.FileName;
                //row.file_name = openFileDialog1.SafeFileName;
                //row.bit_subido = true;
            }

        }

        private void Inicalizar_Archivo_configurados()
        {
            try
            {
                string query = "sp_load_trz_documentos_ingreso_for_loteV4";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_ingreso", NumeroTransaccion);
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                //cmd.Parameters.AddWithValue("@lote", Lote);
                dsTRZ_Reports1.adjuntos_pt.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTRZ_Reports1.adjuntos_pt);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}