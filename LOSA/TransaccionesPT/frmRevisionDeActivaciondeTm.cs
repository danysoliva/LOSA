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

        public void load_data()//Cargaremos la lista de las Activadas y las No Activadas
        {
            string query = @"[sp_load_lista_de_tarimas_activas_v2]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                //Tarimas Activadas
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cant_rows", spinEdit1.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsPT.loadtml.Clear();
                da.Fill(dsPT.loadtml);

                //Tarimas No Activadas
                query = @"[sp_load_lista_de_tarimas_activas_v3]";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cant_rows", spinEdit1.EditValue);
                da = new SqlDataAdapter(cmd);
                dsPT.loadtml_no_activadas.Clear();
                da.Fill(dsPT.loadtml_no_activadas);

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}