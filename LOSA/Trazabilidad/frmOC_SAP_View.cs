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

namespace LOSA.Trazabilidad
{
    public partial class frmOC_SAP_View : DevExpress.XtraEditors.XtraForm
    {
        public frmOC_SAP_View(int pIdDocNum)
        {
            InitializeComponent();
            LoadLines(pIdDocNum);
        }

        private void LoadLines(int pDocNUM_)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_detalle_oc_sap_from_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocNum", pDocNUM_);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoTrazabilidad1.OC_SAP_View.Clear();
                adat.Fill(dsMantoTrazabilidad1.OC_SAP_View);
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}