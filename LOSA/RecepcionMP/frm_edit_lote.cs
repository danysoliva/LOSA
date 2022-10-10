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
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    public partial class frm_edit_lote : DevExpress.XtraEditors.XtraForm
    {
        string lote_viejo;
        UserLogin UsuarioLogeado;
        public frm_edit_lote(string plote, int pingreso, UserLogin pUserLogin)
        {
            InitializeComponent();
            txtNumIngreso.Text = Convert.ToString(pingreso);
            lote_viejo = plote;
            txtLoteMP.Text = plote;
            UsuarioLogeado = pUserLogin;

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoteMP.Text))
            {
                CajaDialogo.Error("No puede dejar vacio el campo de lote!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_update_mp_lotes_and_tarimas", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_transaccion",Convert.ToInt32(txtNumIngreso.Text));
                //cmd.Parameters.AddWithValue("@id_ingreso_header",);
                cmd.Parameters.AddWithValue("@lote_nuevo",txtLoteMP.Text);
                cmd.Parameters.AddWithValue("@lote_viejo", lote_viejo);
                cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();

                CajaDialogo.Information("Maestro de Lotes y Tarimas Actualizadas!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}