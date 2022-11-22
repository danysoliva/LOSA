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

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    public partial class frmReprocesoDashboard : DevExpress.XtraEditors.XtraForm
    {
        DateTime FechaDesde;
        DateTime FechaHasta;
        int TurnoId;
        int LineaId;
        public frmReprocesoDashboard(DateTime vFechaDesde, DateTime vFechaHasta, int vLineaId, int vTurnoId)
        {
            InitializeComponent();

            FechaDesde = vFechaDesde;
            FechaHasta = vFechaHasta;
            TurnoId = vTurnoId;
            LineaId = vLineaId;

            LoadDatos();
        }

        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();

                //Tilapia
                SqlCommand cmd3 = new SqlCommand("sp_get_reproceso_reporte_eficiencia_prd", cn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd3.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd3.Parameters.AddWithValue("@filtro_maquina", 3);
                cmd3.Parameters.AddWithValue("@filtro_turno", TurnoId);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsEficiencia1.reproceso.Clear();
                adat3.Fill(dsEficiencia1.reproceso);

                //camaron
                SqlCommand cmd4 = new SqlCommand("sp_get_reproceso_reporte_eficiencia_prd", cn);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd4.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd4.Parameters.AddWithValue("@filtro_maquina", 1);
                cmd4.Parameters.AddWithValue("@filtro_turno", TurnoId);
                SqlDataAdapter adat4 = new SqlDataAdapter(cmd4);
                dsEficiencia1.reproceso1.Clear();
                adat4.Fill(dsEficiencia1.reproceso1);

                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }



    }
}