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
    public partial class frmEficiencia : DevExpress.XtraEditors.XtraForm
    {
        DateTime FechaDesde;
        DateTime FechaHasta;
        int TurnoId;
        int LineaId;
        public frmEficiencia(DateTime vFechaDesde, DateTime vFechaHasta, int vLineaId, int vTurnoId)
        {
            InitializeComponent();
            FechaDesde = vFechaDesde;
            FechaHasta = vFechaHasta;
            TurnoId = vTurnoId;
            LineaId = vLineaId;
            LoadDatosEficienciaReal();
        }

        private void LoadDatosEficienciaReal()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_eficiencia_segun_horas_reales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_i", FechaDesde);
                cmd.Parameters.AddWithValue("@fecha_f", FechaHasta);
                cmd.Parameters.AddWithValue("@filtro_maquina", LineaId);
                cmd.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.turnos_group_eficiencia.Clear();
                adat.Fill(dsDashBoard1.turnos_group_eficiencia);


                //Extruder
                SqlCommand cmd2 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd", cn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd2.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd2.Parameters.AddWithValue("@idlinea", 4);
                cmd2.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsDashBoard1.eficiencia_detalle.Clear();
                adat2.Fill(dsDashBoard1.eficiencia_detalle);

                //pellet 1
                SqlCommand cmd3 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd", cn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd3.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd3.Parameters.AddWithValue("@idlinea", 1);
                cmd3.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                dsDashBoard1.eficiencia_detalle1.Clear();
                adat3.Fill(dsDashBoard1.eficiencia_detalle1);

                //pellet 2
                SqlCommand cmd4 = new SqlCommand("sp_get_detalle_eficiencia_dashboard_prd", cn);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd4.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd4.Parameters.AddWithValue("@idlinea", 2);
                cmd4.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat4= new SqlDataAdapter(cmd4);
                dsDashBoard1.eficiencia_detalle2.Clear();
                adat4.Fill(dsDashBoard1.eficiencia_detalle2);


                //Detalle de particulas
                SqlCommand cmd5 = new SqlCommand("sp_get_detalle_tm_prd_por_particula", cn);
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd5.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd5.Parameters.AddWithValue("@idlinea", LineaId);
                cmd5.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat5 = new SqlDataAdapter(cmd5);
                dsDashBoard1.detalle_particulas.Clear();
                adat5.Fill(dsDashBoard1.detalle_particulas);

                //Detalle de particulas
                SqlCommand cmd6 = new SqlCommand(@"sp_get_detalle_eficiencia_dashboard_prd_paro_vs_motor", cn);
                cmd6.CommandType = CommandType.StoredProcedure;
                cmd6.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd6.Parameters.AddWithValue("@fechaf", FechaHasta);
                cmd6.Parameters.AddWithValue("@idlinea", LineaId);
                cmd6.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat6 = new SqlDataAdapter(cmd6);
                dsDashBoard1.motor_vs_paro.Clear();
                adat6.Fill(dsDashBoard1.motor_vs_paro);


                //Detalle de eficiencia por Dado
                SqlCommand cmd7 = new SqlCommand(@"sp_get_eficiencia_por_dado", cn);
                cmd7.CommandType = CommandType.StoredProcedure;
                cmd7.Parameters.AddWithValue("@fechai", FechaDesde);
                cmd7.Parameters.AddWithValue("@fechaf", FechaHasta);
                SqlDataAdapter adat7 = new SqlDataAdapter(cmd7);
                dsDashBoard1.dado_resumen.Clear();
                adat7.Fill(dsDashBoard1.dado_resumen);

                cn.Close();
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