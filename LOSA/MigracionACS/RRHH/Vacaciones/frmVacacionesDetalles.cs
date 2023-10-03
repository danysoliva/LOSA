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

namespace LOSA.MigracionACS.RRHH.Vacaciones
{
    public partial class frmVacacionesDetalles : DevExpress.XtraEditors.XtraForm
    {
        int EmployeeId;
        public frmVacacionesDetalles(int pEmployeeId, string pNombre, string pdias)
        {
            InitializeComponent();
            lblNombre.Text = pNombre;
            lblTotalDias.Text = "Cantidad dias Pendientes: " + pdias;
            EmployeeId = pEmployeeId;
            LoadDetalle();
        }

        private void LoadDetalle()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd1 = new SqlCommand("dbo.sp_get_detalle_dias_vacaciones_acumulados", con);
                SqlCommand cmd2 = new SqlCommand("dbo.sp_get_detalle_dias_vacaciones_tomados_stand", con);
                SqlCommand cmd3 = new SqlCommand("dbo.sp_get_detalle_dias_vacaciones_tomados_odoo", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_employee", EmployeeId);
                cmd2.Parameters.AddWithValue("@id_employee", EmployeeId);
                cmd3.Parameters.AddWithValue("@id_employee", EmployeeId);
                
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);

                dsReportesVacaciones1.acumulados.Clear();
                dsReportesVacaciones1.tomados_stand.Clear();
                dsReportesVacaciones1.tomados_odoo.Clear();

                adapter1.Fill(dsReportesVacaciones1.acumulados);
                adapter2.Fill(dsReportesVacaciones1.tomados_stand);
                adapter3.Fill(dsReportesVacaciones1.tomados_odoo);
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
    }
}