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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesMP
{
    public partial class frmviewrequisas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmviewrequisas()
        {
            InitializeComponent();
            LoadDatos();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDatos()
        {
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsTransaccionesMP1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnVerD_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grRequisicoinesMP.FocusedView;
                var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();
                frmviewrequisadetallecs frm = new frmviewrequisadetallecs(row.id);
                frm.Show();
            }
            catch (Exception ex)
            {

               
            }
        }
    }
}