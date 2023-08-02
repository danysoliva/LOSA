using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.Trazabilidad
{
    public partial class frmDetallePorBatchRutasTRZ : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public int LotePT;
        int IdMP;
        public frmDetallePorBatchRutasTRZ(UserLogin puser, int pLotePT, int pIdMP)
        {
            InitializeComponent();
            UsuarioLogeado = puser;
            LotePT = pLotePT;
            IdMP = pIdMP;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_batch_ruta_4", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", IdMP);
                cmd.Parameters.AddWithValue("@lote_pt", LotePT);
                dsReportesTRZ1.detalle_batch_ruta_4.Clear(); 
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesTRZ1.detalle_batch_ruta_4);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}