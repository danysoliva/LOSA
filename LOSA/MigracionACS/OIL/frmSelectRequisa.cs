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
        public int Id_Requisa, LotePT, id_mp;

        public frmSelectRequisa(int pid_mp)
        {
            InitializeComponent();
            id_mp = pid_mp;
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
                cmd.Parameters.AddWithValue("@id_mp", id_mp);
                dsTransaccionesMP1.requisiciones_aceites.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_aceites);
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
            var row = (dsTransaccionesMP.requisiciones_aceitesRow)gridview.GetFocusedDataRow();

            if (row.id_requisa > 0)
            {
                Id_Requisa = row.id_requisa;
                LotePT = row.Lote;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)grdRequisas.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_aceitesRow)gridview.GetFocusedDataRow();

            if (row.id_requisa > 0)
            {
                Id_Requisa = row.id_requisa;
                LotePT = row.Lote;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}