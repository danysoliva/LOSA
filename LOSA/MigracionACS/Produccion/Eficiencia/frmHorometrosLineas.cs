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

namespace LOSA.MigracionACS.Produccion.Eficiencia
{
    public partial class frmHorometrosLineas : DevExpress.XtraEditors.XtraForm
    {
        public frmHorometrosLineas()
        {
            InitializeComponent();
            LoadDatos();
            timer1.Start();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_avance_horas_motor_por_linea", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                DataTable tablex = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(tablex);
                gridControl1.DataSource = tablex;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDatos();
        }
    }
}