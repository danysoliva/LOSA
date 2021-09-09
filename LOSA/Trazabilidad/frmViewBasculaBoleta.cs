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
    public partial class frmViewBasculaBoleta : DevExpress.XtraEditors.XtraForm
    {
        public frmViewBasculaBoleta(int pIdSerial)
        {
            InitializeComponent();
            LoadLines(pIdSerial);
        }

        private void LoadLines(int pIdSerial_)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_load_data_boleta_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Serie", pIdSerial_);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                DataTable Table_ = new DataTable();
                adat.Fill(Table_);
                this.vGridControl1.DataSource = Table_;
                con.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}