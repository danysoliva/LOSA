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

namespace LOSA.TransaccionesMP
{
    public partial class frmDevoluciones : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmDevoluciones()
        {
            InitializeComponent();
            load_informe();
        }

        public void load_informe()
        {
            string query = @"sp_load_reporte_devuluciones";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsTransaccionesMP.devoluciones.Clear();
                da.Fill(dsTransaccionesMP.devoluciones);
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