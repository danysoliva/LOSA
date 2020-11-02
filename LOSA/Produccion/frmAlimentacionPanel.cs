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

namespace LOSA.Produccion
{
    public partial class frmAlimentacionPanel : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmAlimentacionPanel()
        {
            InitializeComponent();
            Load_data();
        }
         public void Load_data()
        {
            string Query = @"sp_obtener_tarimas_alimentacion";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion.panelalimentacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion.panelalimentacion);
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