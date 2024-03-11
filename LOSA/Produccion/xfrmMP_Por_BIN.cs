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

namespace LOSA.Produccion
{
    public partial class xfrmMP_Por_BIN : DevExpress.XtraEditors.XtraForm
    {
        public xfrmMP_Por_BIN()
        {
            InitializeComponent();
            LoadData();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.usp_get_List_MP_BIN",cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dsProduccion.List_MP_BIN.Clear();

                    da.Fill(dsProduccion.List_MP_BIN);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}