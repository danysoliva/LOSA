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

namespace LOSA.TransaccionesMP.VentanasMensajes
{
    public partial class frmVentanaMsjTarimaAlimentacion : DevExpress.XtraEditors.XtraForm
    {
        public frmVentanaMsjTarimaAlimentacion(string msj, string pBarcode)
        {
            InitializeComponent();
            lblMensaje.Text = msj;
            LoadDatos(pBarcode);
        }

        private void LoadDatos(string pBarcode_)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_tarima_entregada_alimentacion_tarimas_prd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", pBarcode_);
                dsMensajesTransaccionMP1.tarima_alimentacion_tarimas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMensajesTransaccionMP1.tarima_alimentacion_tarimas);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}