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

namespace LOSA.Logistica
{
    public partial class frmCierreMensual : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();


        public frmCierreMensual()
        {
            InitializeComponent();
        }

        public void load_data()
        {
            string query = @"sp_get_inventario_final_encabezados";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCierreMes.recuentos_h.Clear();
                da.Fill(dsCierreMes.recuentos_h);
                cn.Close();

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}