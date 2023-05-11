using ACS.Classes;
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
using LOSA.Reportes;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using LOSA.Classes;
using LOSA.Produccion;

namespace LOSA.Produccion
{
    public partial class frmDetalleEntregadoRequisa : DevExpress.XtraEditors.XtraForm
    {
        int id_requisa = 0;
        public frmDetalleEntregadoRequisa(int pid_requisa)
        {
            InitializeComponent();
            id_requisa = pid_requisa;

            load_data(id_requisa);
        }

        private void load_data(int pid_requisa)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();

                string sql = "sp_get_rpt_detalle_requisa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisa", pid_requisa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMaterialEmpaque1.requisa_detalle.Clear();
                da.Fill(dsMaterialEmpaque1.requisa_detalle);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
