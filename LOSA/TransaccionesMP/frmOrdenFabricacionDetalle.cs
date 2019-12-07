using ACS.Classes;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmOrdenFabricacionDetalle : Form
    {
        public frmOrdenFabricacionDetalle(int pIdOrdenFabricacion)
        {
            InitializeComponent();
            LoadData(pIdOrdenFabricacion);
        }

        private void LoadData(int pIdOrdenFabricacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_orders_fabrication", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LastName", pIdOrdenFabricacion);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //dsTransaccionesMP1.ordenes_fabricacion_h.Clear();
                //adat.Fill(dsTransaccionesMP1.ordenes_fabricacion_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
