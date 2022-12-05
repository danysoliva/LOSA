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

namespace LOSA.Reportes
{
    public partial class frmrptarimasvirtuales : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmrptarimasvirtuales()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            string sql = @"sp_load_report_tarimas_virtuales";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            dSReportes1.tarimasvs.Clear();
            adt.Fill(dSReportes1.tarimasvs);
            conn.Close();
        }
    }
}