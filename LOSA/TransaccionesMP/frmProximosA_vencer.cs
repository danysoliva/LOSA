using ACS.Classes;
using DevExpress.XtraEditors;
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
    public partial class frmProximosA_vencer : DevExpress.XtraEditors.XtraForm
    {
        public frmProximosA_vencer(int pIdMP)
        {
            InitializeComponent();

            LoadLotes(pIdMP);
        }

        public frmProximosA_vencer(int pIdMP, string pLoteActual)
        {
            InitializeComponent();

            lblTitulo.Visible = false;
            lblMensaje.Visible = true;

            lblMensaje.Text = "Se intento escanear un Lote que no es el Proxima a Vencer!\nLote: "+pLoteActual;

            LoadLotes(pIdMP);
        }

        private void LoadLotes(int pId_mp)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_proximos_vencer_mp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pId_mp);
                dsLotesProxVencer1.lotes_mp_prox_vencer_id.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLotesProxVencer1.lotes_mp_prox_vencer_id);

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
    }
}