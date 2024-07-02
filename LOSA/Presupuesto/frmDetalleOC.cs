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
using LOSA.Presupuesto;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace LOSA.Presupuesto
{
    public partial class frmDetalleOC : DevExpress.XtraEditors.XtraForm
    {
        int IDDetalle = 0;
        DataOperations dp = new DataOperations();
        public frmDetalleOC(int idLinea)
        {
            InitializeComponent();
            IDDetalle = idLinea;
            LoadDataDetalle();
        }

        private void LoadDataDetalle()
        {
            try
            {
                //string query = @"";
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                //conn.Open();
                //SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("", );
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsPresupuesto1.rpt_consumo_saldos.Clear();
                //adat.Fill(dsPresupuesto1.rpt_consumo_saldos);
                //conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}