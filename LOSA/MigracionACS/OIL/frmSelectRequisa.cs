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
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesMP;

namespace LOSA.MigracionACS.OIL
{
    public partial class frmSelectRequisa : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Id_Requisa, LotePT;

        public frmSelectRequisa()
        {
            InitializeComponent();

            LoadDatos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadDatos()
        {
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_traslado_aceites", con);
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

        private void reposSelectRequ_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdRequisas.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                Id_Requisa = row.id;
                LotePT = row.Lote;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdRequisas.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridview.GetFocusedDataRow();

            if (row.id > 0)
            {
                Id_Requisa = row.id;
                LotePT = row.Lote;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}