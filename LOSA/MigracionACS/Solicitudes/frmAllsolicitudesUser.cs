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
using DevExpress.XtraGrid.Views.Grid;
using ACS.Classes;
using LOSA.MigracionACS.IT;

namespace LOSA.MigracionACS.Solicitudes
{
    public partial class frmAllsolicitudesUser : DevExpress.XtraEditors.XtraForm
    {
        string prueba;
        DataOperations dp = new DataOperations();
        public frmAllsolicitudesUser()
        {
            InitializeComponent();
            LoadSolicitudes();
        }
        private void LoadSolicitudes()
        {   //Cargar toda la data de solicitudes para usuarios
            try
            {
                string sql = @"SELECT [id]
                              ,[id_solicitante] 
	                          ,(select t2.nombre from [conf_usuarios]t2 where t2.id = t1.id_solicitante) as nombre_soli
                              ,[nombre_usuario]
                              ,[fecha_soli]
                              ,[fecha_eliminar]
                              ,[id_depar]
	                          ,(select t3.grupo from [conf_group]t3 where t3.id = t1.id_depar) as departamento
                              ,[otros_acceso_especial]
                              ,[razon]
                              ,[acceso_p]
                              ,[acceso_t]
                              ,[ticket]
                              ,[asignado_a]
                              ,[acceso_especial]
                              ,[enable]
                              ,[id_estado]
	                          ,(select t4.descripcion from [IT_Estado]t4 where t4.id = t1.id_estado) as estado
                          FROM [dbo].[IT_Solicitudes]t1
                          where [enable] = 1   
                          order by 1 desc";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsSolicitudes.solicitudes.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsSolicitudes.solicitudes);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddSoli_Click(object sender, EventArgs e)
        {
            IT_Solicitudes solicitudes = new IT_Solicitudes();
            if (solicitudes.ShowDialog() == DialogResult.OK)
            {
                LoadSolicitudes();
            }
        }
    }
}