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

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    public partial class frmResumenBrom : DevExpress.XtraEditors.XtraForm
    {
        DateTime FechaDesde;
        DateTime FechaHasta;
        int TurnoId;
        int LineaId;
        public frmResumenBrom(DateTime vFechaDesde, DateTime vFechaHasta, int vLineaId, int vTurnoId)
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


                //Extruder
                SqlCommand cmd3 = new SqlCommand("sp_get_detalle_datos_bromatologicos_for_dashboard_eficiencia", cn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@datei", FechaDesde);
                cmd3.Parameters.AddWithValue("@datef", FechaHasta);
                cmd3.Parameters.AddWithValue("@linea", 3);
                cmd3.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat3 = new SqlDataAdapter(cmd3);
                DataTable table1 = new DataTable();
                adat3.Fill(table1);
                gridControl1.DataSource = table1;

                //pellets
                SqlCommand cmd4 = new SqlCommand("sp_get_detalle_datos_bromatologicos_for_dashboard_eficiencia", cn);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@datei", FechaDesde);
                cmd4.Parameters.AddWithValue("@datef", FechaHasta);
                cmd4.Parameters.AddWithValue("@linea", 1);
                cmd4.Parameters.AddWithValue("@id_turno", TurnoId);
                SqlDataAdapter adat4 = new SqlDataAdapter(cmd4);
                DataTable table2 = new DataTable();
                adat4.Fill(table2);
                gridControl2.DataSource = table2;

                LoadDatosGraficos();

                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        void LoadDatosGraficos()
        {
            DataOperations dp = new DataOperations();
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            cn.Open();

            int especie = 1;
            if (toggleSwitchEspecie.IsOn)
                especie = 3;
            //Grafico Proteina
            SqlCommand cmd5 = new SqlCommand("sp_get_detalle_datos_bromatologicos_for_dashboard_eficiencia_grafico", cn);
            cmd5.CommandType = CommandType.StoredProcedure;
            cmd5.Parameters.AddWithValue("@datei", FechaDesde);
            cmd5.Parameters.AddWithValue("@datef", FechaHasta);
            cmd5.Parameters.AddWithValue("@linea", especie);
            cmd5.Parameters.AddWithValue("@id_turno", TurnoId);
            cmd5.Parameters.AddWithValue("@id_tipo_medicion", 1);//Proteina

            SqlDataAdapter adat5 = new SqlDataAdapter(cmd5);
            dsDashBoard1.brom_prot.Clear();
            adat5.Fill(dsDashBoard1.brom_prot);
           

            //Grafico Humedad
            SqlCommand cmd6 = new SqlCommand("sp_get_detalle_datos_bromatologicos_for_dashboard_eficiencia_grafico", cn);
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.Parameters.AddWithValue("@datei", FechaDesde);
            cmd6.Parameters.AddWithValue("@datef", FechaHasta);
            cmd6.Parameters.AddWithValue("@linea", especie);
            cmd6.Parameters.AddWithValue("@id_turno", TurnoId);
            cmd6.Parameters.AddWithValue("@id_tipo_medicion", 2);//Humedad

            SqlDataAdapter adat6 = new SqlDataAdapter(cmd6);
            dsDashBoard1.brom_hum.Clear();
            adat6.Fill(dsDashBoard1.brom_hum);
            

            //Grafico Grasa
            SqlCommand cmd7 = new SqlCommand("sp_get_detalle_datos_bromatologicos_for_dashboard_eficiencia_grafico", cn);
            cmd7.CommandType = CommandType.StoredProcedure;
            cmd7.Parameters.AddWithValue("@datei", FechaDesde);
            cmd7.Parameters.AddWithValue("@datef", FechaHasta);
            cmd7.Parameters.AddWithValue("@linea", especie);
            cmd7.Parameters.AddWithValue("@id_turno", TurnoId);
            cmd7.Parameters.AddWithValue("@id_tipo_medicion", 3);//Grasa

            SqlDataAdapter adat7 = new SqlDataAdapter(cmd7);
            dsDashBoard1.brom_grasa.Clear();
            adat7.Fill(dsDashBoard1.brom_grasa);
            cn.Close();
        }

        private void toggleSwitchEspecie_Toggled(object sender, EventArgs e)
        {
            LoadDatosGraficos();
        }
    }
}