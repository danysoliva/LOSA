using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Calidad;
using LOSA.Clases;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Calidad
{
    public partial class frmRecientes : DevExpress.XtraEditors.XtraForm
    {
        public string path;
        public int id;
        public string file_name;
        public string Adjunto;
        DataOperations dp = new DataOperations();
        public frmRecientes()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_load_trz_documentos_adjuntos_recientes";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoC.recientes.Clear();
                da.Fill(dsMantenimientoC.recientes);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_docRecientes.FocusedView;
                var row = (dsMantenimientoC.recientesRow)gridView.GetFocusedDataRow();
                path = row.path;
                id = row.id;
                file_name = row.file_name;
                Adjunto = row.descripcion;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_recientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_docRecientes.FocusedView;
                var row = (dsMantenimientoC.recientesRow)gridView.GetFocusedDataRow();
                path = row.path;
                id = row.id;
                file_name = row.file_name;
                Adjunto = row.descripcion;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}