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
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Produccion.DashBoard
{
    public partial class frmReprocesoDetalleRuta4 : DevExpress.XtraEditors.XtraForm
    {
        
        string LoteMP;

        public frmReprocesoDetalleRuta4(string pLotePTReproceso)
        {
            InitializeComponent();
            LoteMP = pLotePTReproceso;
            CargarDetalleTarimas();
        }

        private void CargarDetalleTarimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loteMP", LoteMP);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.detalle_reproceso_lote.Clear();
                adat.Fill(dsDashBoard1.detalle_reproceso_lote);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}