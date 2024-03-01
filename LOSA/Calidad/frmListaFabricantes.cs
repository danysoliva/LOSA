using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
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
        public int IdMp;
        public frmListaFabricantes(string pproveedor, string provName, int PidMP)
        {
            InitializeComponent();
            Proveedor prov = new Proveedor();
            prov.RecuperarRegistroWithRTN(pproveedor);

            txtproveedor.Text = pproveedor + " - " + prov.Nombre;
            LoadFabricantes(pproveedor, PidMP);
        }

        private void LoadFabricantes(string pProveedor, int pid_mp)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lista_plantas_prv_trzV2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cardcode", pProveedor);
                cmd.Parameters.AddWithValue("@id_mp", pid_mp);
                dsTRZ_Reports1.plantas_por_materia_prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTRZ_Reports1.plantas_por_materia_prima);

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
            var row = (dsTRZ_Reports.plantas_por_materia_primaRow)gridView.GetFocusedDataRow();
            IdFabricanteSeleccionado = row.id_planta;

            NombreFabricanteSeleccionado = row.nombre;

            txtFabricante.Text = row.nombre;
            txtTipo.Text = row.tipo_gmo;
            if (row.aprobado_asc == "Si")
                tsAprobadoASC.IsOn = true;
            else
                tsAprobadoASC.IsOn = false;

            navigationFrame1.SelectedPageIndex = 1;
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsTRZ_Reports.plantas_por_materia_primaRow)gridView.GetFocusedDataRow();

            if (gridView1.RowCount != 0)
            {
                IdFabricanteSeleccionado = row.id_planta;
                NombreFabricanteSeleccionado = row.nombre;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

           
        }
    }
}