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

namespace LOSA.Calidad.Parametros
{
    public partial class frmAdjuntos_PT : DevExpress.XtraEditors.XtraForm
    {
        public frmAdjuntos_PT()
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
                if (fpt1.GuardarArchivo(UsuarioLogeado, Path_, row.path))
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_insert_archivo_adjunto_ingresoV3", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@path", Path_);
                    cmd.Parameters.AddWithValue("@file_name", row.file_name);
                    cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                    cmd.Parameters.AddWithValue("@id_config", row.id_conf);
                    cmd.Parameters.AddWithValue("@bit_pic", 0);
                    cmd.Parameters.AddWithValue("@id_mp", IdMP);
                    cmd.Parameters.AddWithValue("@lote_mp", Lote);
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
    }
}