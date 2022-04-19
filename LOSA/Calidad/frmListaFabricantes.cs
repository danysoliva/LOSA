using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.Calidad
{
    public partial class frmListaFabricantes : DevExpress.XtraEditors.XtraForm
    {
        public int IdFabricanteSeleccionado;
        public string NombreFabricanteSeleccionado;
        public frmListaFabricantes(string pproveedor, string provName)
        {
            InitializeComponent();
            txtproveedor.Text = pproveedor + " - " + provName;
            LoadFabricantes(pproveedor);
        }

        private void LoadFabricantes(string pProveedor)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lista_plantas_prv_trz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", pProveedor);
                dsTRZ_Reports1.plantas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTRZ_Reports1.plantas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsTRZ_Reports.plantasRow)gridView.GetFocusedDataRow();
            IdFabricanteSeleccionado = row.id;
            NombreFabricanteSeleccionado = row.nombre;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsTRZ_Reports.plantasRow)gridView.GetFocusedDataRow();
            IdFabricanteSeleccionado = row.id;
            NombreFabricanteSeleccionado = row.nombre;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}