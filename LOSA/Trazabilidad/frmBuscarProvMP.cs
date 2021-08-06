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

namespace LOSA.Trazabilidad
{
    public partial class frmBuscarProvMP : DevExpress.XtraEditors.XtraForm
    {
        public Proveedor ProveedorRow;
        public frmBuscarProvMP()
        {
            InitializeComponent();
            LoadProveedores();
        }

        private void LoadProveedores()
        {
            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_get_lista_proveedores_mp_trazabilidad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@idbodega", idBodega);
            dsMantoTrazabilidad1.proveedores_master.Clear();
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            adat.Fill(dsMantoTrazabilidad1.proveedores_master);

            con.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.proveedores_masterRow)gridView.GetFocusedDataRow();

            ProveedorRow = new Proveedor();
            if (ProveedorRow.RecuperarRegistroWithRTN(row.Codigo_de_Proveedor))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}