using ACS.Classes;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmSeleccionLote : Form
    {
        UserLogin UsuarioLogeado;
        int IdRequisicionDetalle;
        MateriaPrima MP;
        decimal CantidadPendiente;
        int id_unidad;

        public frmSeleccionLote(UserLogin pUsuarioLogeado, int pIdRequisicionDetalle, int IdRM, decimal pCantidad, int pIdUnidad, string pUnidadName)
        {
            InitializeComponent();
            MP = new MateriaPrima();
            UsuarioLogeado = pUsuarioLogeado;
            IdRequisicionDetalle = pIdRequisicionDetalle;
            CantidadPendiente = pCantidad;
            txtCantidadPendiente.Text = string.Format("{0:###,##0.00}", CantidadPendiente);
            id_unidad = pIdUnidad;
            lblUnidad.Text = pUnidadName;

            if (MP.RecuperarRegistroFromID_RM(IdRM))
            {
                txtCodigoMP.Text = MP.Codigo;
                txtMP_Name.Text = MP.Name;
            }

            LoadDetalleLotes();
        }

        private void LoadDetalleLotes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_lotes_mp_req", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmp", MP.IdMP_ACS);
                dsTransaccionesMP1.detalle_lote_mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.detalle_lote_mp);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkAutoSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSelect.Checked)
            {

            }
        }
    }
}
