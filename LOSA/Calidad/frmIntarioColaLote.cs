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
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.Calidad
{
    public partial class frmIntarioColaLote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmIntarioColaLote()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            string query = @"sp_get_cola_de_lotes";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsCalidad.ViewCola.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsCalidad.ViewCola);
                cn.Close();
               

            }
            catch (Exception ex)
            {
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}