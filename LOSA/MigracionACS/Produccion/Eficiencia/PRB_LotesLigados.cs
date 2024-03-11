using ACS.Classes;
using DevExpress.XtraEditors;
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
using LOSA.MigracionACS.DataSetx;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class PRB_LotesLigados : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public PRB_LotesLigados()
        {
            InitializeComponent();
            dtDesde.EditValue = dp.Now().AddMonths(-6);
            dtHasta.EditValue = dp.Now();
            cargar_lotes();
        }

        private void cargar_lotes()
        {
            try
            {
                string data = @"sp_get_lotes_producidos_y_registrados";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(data, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLotePick1.lotes_registrados.Clear();
                da.Fill(dsLotePick1.lotes_registrados);
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}