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

namespace LOSA.MigracionACS.IT
{
    public partial class frmEditarAcceso : DevExpress.XtraEditors.XtraForm
    {
        int id;
        public frmEditarAcceso(int pid, string pname)
        {
            InitializeComponent();
            id = pid;
            txtAcceso.Text = pname;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //guardar la edicion del acceso
            if (string.IsNullOrEmpty(txtAcceso.Text))
            {
                CajaDialogo.Error("No puede dejar este campo vacio!");
                txtAcceso.Focus();
                return;
            }
            try
            {
                string sql = @"UPDATE [dbo].[IT_Acceso]
                                           SET [nombre] = '"+ txtAcceso.Text+@"' 
                                         WHERE [id] = "+ id.ToString();
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
                CajaDialogo.Error("Error al guardar el acceso",ec);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}