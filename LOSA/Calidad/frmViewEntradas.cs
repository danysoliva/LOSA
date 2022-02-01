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
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Calidad
{
    public partial class frmViewEntradas : DevExpress.XtraEditors.XtraForm
    {

        int DocEntry;
        int BaseType;
        int Linenum;
        DataOperations dp = new DataOperations();
        
        public frmViewEntradas(int PDocEntry, int pBaseType, int pLineNum)
        {
            InitializeComponent();
            DocEntry = PDocEntry;
            BaseType = pBaseType;
            Linenum = pLineNum;
            load_data();
        }
        public void load_data()
        {
            string query = @"sp_get_entradas_mercancias";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@baseEntry", DocEntry);
                cmd.Parameters.AddWithValue("@BaseType", BaseType);
                cmd.Parameters.AddWithValue("@baseLine", Linenum);
                dsLogistica2.EntradasMescancias.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLogistica2.EntradasMescancias);
                cn.Close();

            }
            catch (Exception ex)
            {
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}