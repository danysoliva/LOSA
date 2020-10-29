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

namespace LOSA.RecepcionMP
{
    public partial class frmUbicaciones_granel : DevExpress.XtraEditors.XtraForm
    {
        public int IdUbicacionSelected;
        public string UbicacionNombre;
        public string UbicacionCodigo;
        public frmUbicaciones_granel()
        {
            InitializeComponent();
            cargarDatosGranel();
        }


        void cargarDatosGranel()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"sp_get_lista_ubicaciones_granel";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_barra", "");
                dsRecepcionMPx1.ubicaciones_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.ubicaciones_granel);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //double click
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.ubicaciones_granelRow)gridView.GetFocusedDataRow();

            IdUbicacionSelected = row.id;
            UbicacionNombre = row.rack;
            UbicacionCodigo = row.codigo_barra;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}