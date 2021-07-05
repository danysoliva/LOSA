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

namespace LOSA.RecepcionMP
{
    public partial class frmCambioIngreso : DevExpress.XtraEditors.XtraForm
    {
        int ingresoAnterior;
        int IngresoNuevo;
        int id_ingreso;
        DataOperations dp = new DataOperations();
        public frmCambioIngreso(int Pingreso, int Pid)
        {
            InitializeComponent();
            ingresoAnterior = Pingreso;
            txtanterior.Text = ingresoAnterior.ToString();
            id_ingreso = Pid;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            frm_select_numero_granel frm = new frm_select_numero_granel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IngresoNuevo = frm.Ingreso;
                txtnuevo.Text = IngresoNuevo.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnuevo.Text == "")
                {
                    CajaDialogo.Error("Debe seleccionar un nuevo ingreso.");
                    return;
                }
                string query = @"sp_update_registro_granel";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_ingreso);
                cmd.Parameters.AddWithValue("@ingreso", IngresoNuevo);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}