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

namespace LOSA.Calidad
{
    public partial class frmVerHistorialEstadoTarima : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        int id_tarima;
        public frmVerHistorialEstadoTarima(int pid_tarima)
        {
            InitializeComponent();
            id_tarima = pid_tarima;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_get_historial_mov_estado_tarima";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_tarima", id_tarima);
                dsCalidad1.historialestados.Clear();
                adat.Fill(dsCalidad1.historialestados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}