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

namespace LOSA.MigracionACS.IT
{
    public partial class frmNuevoAcceso : DevExpress.XtraEditors.XtraForm
    {
        public frmNuevoAcceso()
        {
            InitializeComponent();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (string.IsNullOrEmpty(txtAccesoNuevo.Text))
                {
                    CajaDialogo.Error("Debe agregar un acceso!");
                    txtAccesoNuevo.Focus();
                    return;
                }

                string sql = @"INSERT INTO [dbo].[IT_Acceso]
                                                   ([nombre])
                                             VALUES
                                                   ('" + txtAccesoNuevo.Text + "')";
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}