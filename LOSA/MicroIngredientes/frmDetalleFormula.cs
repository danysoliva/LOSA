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

namespace LOSA.MicroIngredientes
{
    public partial class frmDetalleFormula : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int LotePT;
        public int IdRM;
        public decimal PlanByBatch;
        public decimal PlanBatchTotal;
        public int CantBatch;
        int IdOrden;
        int TipoPesaje;

        public frmDetalleFormula(UserLogin pUser, int plote, int pIdOrden, int pTipoPesaje)
        {
            InitializeComponent();
            LotePT = plote;
            lblLote.Text = plote.ToString();
            UsuarioLogeado = pUser;
            IdOrden = pIdOrden;
            TipoPesaje = pTipoPesaje;
            LoadDatos();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_estructura_orden_fabricacion_for_micros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote_pt", LotePT);
                cmd.Parameters.AddWithValue("@tipo_pesaje", TipoPesaje);
                cmd.Parameters.AddWithValue("@orden_id", IdOrden);
                dsMicros1.detalle_formula.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicros1.detalle_formula);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdSelecionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMicros.detalle_formulaRow)gridView.GetFocusedDataRow();

            IdRM = row.mp;
            PlanByBatch = row.peso_batch;
            PlanBatchTotal = row.total;
            CantBatch = row.cant_paradas;

            this.DialogResult = DialogResult.OK;
        }
    }
}