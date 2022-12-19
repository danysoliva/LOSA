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

namespace LOSA.MicroIngredientes
{
    public partial class xfrmMezclaMicroShow : DevExpress.XtraEditors.XtraForm
    {
        long order_id;
        int mp_id;
        int ami_id;
        string CodigoBarra;
        AlimentacionTolvaMicrosPesaje PesajeIndividualConf;

        public xfrmMezclaMicroShow(long order_id_p, int ami_id_p, string pCodigo, int pIdmp)
        {
            InitializeComponent();
            order_id = order_id_p;
            ami_id = ami_id_p;
            mp_id = pIdmp;
            CodigoBarra = pCodigo;
            //PesajeIndividualConf = new AlimentacionTolvaMicrosPesaje();
            //if(PesajeIndividualConf.RecuperaRegistro(pCodigo, pIdmp))
            //{

            //}
            Load_detalle();
        }

        private void xfrmMezclaMicroShow_Load(object sender, EventArgs e)
        {
            Load_detalle();
        }

        public void Load_detalle()
        {
            DataOperations dp = new DataOperations();

            string query = @"sp_get_class_micros_pesaje_individual_conf";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_barra", CodigoBarra);
                dsReportes.detalle_rpt_microsIndividual.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.detalle_rpt_microsIndividual);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}