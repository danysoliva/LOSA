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

namespace LOSA.MicroIngredientes
{
    public partial class xfrmMezclaMicroShow : DevExpress.XtraEditors.XtraForm
    {
        long order_id;

        int ami_id;


        public xfrmMezclaMicroShow(long order_id_p, int ami_id_p)
        {
            InitializeComponent();
            order_id = order_id_p;
            ami_id = ami_id_p;
        }

        private void xfrmMezclaMicroShow_Load(object sender, EventArgs e)
        {
            Load_detalle();
        }

        public void Load_detalle()
        {
            DataOperations dp = new DataOperations();

            string query = @"sp_load_op_reporte_detalle_micro_ingrediente";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ami_id", ami_id);
                cmd.Parameters.AddWithValue("@id_orden", order_id);
                dsReportes.detalle_rpt_micros.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.detalle_rpt_micros);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}