using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.DataSet_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad.Parametros
{
    public partial class FrmSeleccionarRegistroProduccion : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        public int pIdRowPRB_H;
        UserLogin UsuarioLogeado;
        public bool CerrarForm;

        public FrmSeleccionarRegistroProduccion()
        {
            InitializeComponent();
            dp = new DataOperations();
            pIdRowPRB_H = 0;
            
            dtDesde.EditValue = dp.Now().AddDays(-1);
            dtHasta.EditValue = dp.Now();
            LoadRegistros();
        }

        private void LoadRegistros()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();

                string sql = @"sp_get_detalle_datos_turno_brom";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsReportesPRD1.header_brom.Clear();
                adat.Fill(dsReportesPRD1.header_brom);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            LoadRegistros();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsReportesPRD.header_bromRow)gridview.GetFocusedDataRow();

            pIdRowPRB_H = row.id;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}