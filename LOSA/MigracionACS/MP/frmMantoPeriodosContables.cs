using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace ACS.MP
{
    public partial class frmMantoPeriodosContables : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmMantoPeriodosContables(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            DataOperations dp = new DataOperations();
            DateTime Fecha = dp.Now();
            DateTime Fechai = new DateTime(Fecha.Year, Fecha.Month, 1);  
            DateTime FechaF = Fechai.AddMonths(1).AddDays(-1);
            dateEdit1.EditValue = Fechai;
            dateEdit2.EditValue = FechaF;

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("No se permite dejar en blanco la Descripción!");
                return;
            }
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_insert_new_periodo_inv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_user", UsuarioLogeado.UserId);
                cmd.Parameters.AddWithValue("@fechai", dateEdit1.EditValue);
                cmd.Parameters.AddWithValue("@fechaf", dateEdit2.EditValue);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}