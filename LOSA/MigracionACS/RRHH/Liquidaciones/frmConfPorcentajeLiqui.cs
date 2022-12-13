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
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmConfPorcentajeLiqui : DevExpress.XtraEditors.XtraForm
    {
        public frmConfPorcentajeLiqui()
        {
            InitializeComponent();
            loaddata();
        }

        private void loaddata()
        {
            string query = @"sp_load_RRHH_porcentaje_liq";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adar = new SqlDataAdapter(cmd);
                dsRRHH_1.porcentajes_liquidacion.Clear();
                adar.Fill(dsRRHH_1.porcentajes_liquidacion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}