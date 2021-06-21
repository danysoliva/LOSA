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

namespace LOSA.TransaccionesPT
{
    public partial class frmRevisionDeActivaciondeTm : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmRevisionDeActivaciondeTm()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            string query = @"sp_load_lista_de_tarimas_activas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.loadtml.Clear();
                da.Fill(dsPT.loadtml);
                cn.Close();
                
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}