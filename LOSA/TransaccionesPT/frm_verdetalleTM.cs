using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.TransaccionesPT
{
    public partial class frm_verdetalleTM : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_ingreso;
        public frm_verdetalleTM(int Pid_ingreso)
        {
            InitializeComponent();
            id_ingreso = Pid_ingreso;
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_view_detalle_tarimas_programadas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_creado", id_ingreso);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.tm_pt.Clear();
                da.Fill(dsPT.tm_pt);
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

        private void btnduplicar_Click(object sender, EventArgs e)
        {

        }
    }
}