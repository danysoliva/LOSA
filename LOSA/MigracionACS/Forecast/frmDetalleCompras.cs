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

namespace ACS.Forecast
{
    public partial class frmDetalleCompras : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoConsulta 
        {
            Transito =1,
            Normales=2
        }

        TipoConsulta TipoConsultaActual;
        int IdMP;
        int Month_;

        public frmDetalleCompras(TipoConsulta pTipo, int pmonth, int pidmp)
        {
            InitializeComponent();
            TipoConsultaActual = pTipo;
            Month_ = pmonth;
            IdMP = pidmp;
            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_oc_for_mrp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@month", Month_);
                cmd.Parameters.AddWithValue("@idmp", IdMP);
                cmd.Parameters.AddWithValue("@idtipo", Convert.ToInt32(TipoConsultaActual));
                dsForecast_1.detalle_oc_sap.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsForecast_1.detalle_oc_sap);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}