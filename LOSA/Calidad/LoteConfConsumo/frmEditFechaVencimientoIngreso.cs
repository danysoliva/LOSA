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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmEditFechaVencimientoIngreso : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int id_mp;
        public int id_lote_alosy;
        public DateTime fecha_anterior;
        UserLogin UsuarioLogeado;
        public frmEditFechaVencimientoIngreso(int pid_mp, int pnumero_transaccion, string plote, DateTime pfecha_venceVieja, int pid_lote_alosy, UserLogin puser)
        {
            InitializeComponent();
            id_mp = pid_mp;
            txtNumIngreso.Text = pnumero_transaccion.ToString();
            txtLoteMP.Text = plote;

            fecha_anterior = pfecha_venceVieja;
            dtFechaVencimiento.EditValue = fecha_anterior;

            id_lote_alosy = pid_lote_alosy;
            UsuarioLogeado = puser;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (dtFechaVencimiento.EditValue == null)
            {
                CajaDialogo.Error("La Fecha no puede quedar vacia!");
                return;
            }

            if (dtFechaVencimiento.DateTime.Year < 2020)
            {
                CajaDialogo.Error("La fecha de vencimiento debe ser una fecha valida");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_update_fecha_venc_ingresos2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ingreso", Convert.ToInt32(txtNumIngreso.Text));
                cmd.Parameters.AddWithValue("@id_lote_alosy",id_lote_alosy);
                cmd.Parameters.AddWithValue("@id_mp",id_mp);
                cmd.Parameters.AddWithValue("@fecha_anterior", Convert.ToDateTime(fecha_anterior));
                cmd.Parameters.AddWithValue("@fecha_nueva",dtFechaVencimiento.EditValue);
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@lote",txtLoteMP.Text);
                cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }
    }
}