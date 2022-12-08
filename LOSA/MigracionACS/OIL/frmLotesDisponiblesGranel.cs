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
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.OIL
{
    public partial class frmLotesDisponiblesGranel : DevExpress.XtraEditors.XtraForm
    {
        public frmLotesDisponiblesGranel()
        {
            InitializeComponent();
            LoadDatos();
        }

        public int IdLoteActivo;
        public string Lote;
        public string MP;

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_activos_granel_LOSA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_ubicacion", (int)pBin);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsGranelesLOSA1.lotes_graneles_disponibles.Clear();
                adat.Fill(dsGranelesLOSA1.lotes_graneles_disponibles);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Doble click
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsGranelesLOSA.lotes_graneles_disponiblesRow)gridView.GetFocusedDataRow();

            IdLoteActivo = row.id_lote;
            Lote = row.lote;
            MP = row.MP;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}