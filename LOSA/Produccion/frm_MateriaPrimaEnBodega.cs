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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;
using LOSA.Calidad.LoteConfConsumo;


namespace LOSA.Produccion
{
    public partial class frm_MateriaPrimaEnBodegaPRd : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UserLogin;

        public frm_MateriaPrimaEnBodegaPRd(UserLogin pUserLogin)
        {
            InitializeComponent();
            UserLogin = pUserLogin;
            load_dataPRD();
        }

        public void load_dataPRD()
        {
            string query = @"sp_get_detalle_lotes_entregados_a_prd";
            try
            {
                DataOperations dp1 = new DataOperations();
                SqlConnection cn = new SqlConnection(dp1.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTarima1.informacionPRD.Clear();
                da.Fill(dsTarima1.informacionPRD);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            //backgroundWorkerPRD.CancelAsync();
            //backgroundWorkerPRD.Dispose();
        }
    }
}