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

namespace LOSA.MigracionACS.RRHH.HorasExtra
{
    public partial class frmDetalleSemanaEmpleadoRRHH : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalleSemanaEmpleadoRRHH(UserLogin puser, string pName, int pIdweek, int pIdEmp)
        {
            InitializeComponent();
            this.Text = "Detalle Semana Empleado: " + pName;
            LoadDetalleHoras(pIdEmp, pIdweek);
        }

        private void LoadDetalleHoras(int pIdemp, int pIdweek)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_resumen_by_empleado_by_week", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idweek", pIdweek);
                cmd.Parameters.AddWithValue("@idemp", pIdemp);
                dsHorasExtra1.detalle_semana.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsHorasExtra1.detalle_semana);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}