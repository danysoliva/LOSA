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
using LOSA.Classes;
using ACS.Classes;

namespace LOSA.TransaccionesMP.EntregaMP
{
    public partial class frmShowTarimasEnBascula : DevExpress.XtraEditors.XtraForm
    {
        public frmShowTarimasEnBascula()
        {
            InitializeComponent();
            load_date();
        }

        private void load_date()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_tarimas_en_proceso_bascula";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.tarimas_bascula.Clear();
                adat.Fill(dsTransaccionesMP1.tarimas_bascula);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}