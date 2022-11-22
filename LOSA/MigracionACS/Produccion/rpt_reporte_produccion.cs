using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraReports.UI;
using System.Data;

namespace LOSA.MigracionACS.Produccion
{
    public partial class rpt_reporte_produccion : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public int id_encabezado;
        public int id_linea;
        string NameLinea = "";
            
        public rpt_reporte_produccion(int id_h, int linea)
        {
            InitializeComponent();
            id_encabezado = id_h;
            id_linea = linea;
            switch (linea)
            {
                case 1:
                    NameLinea = "Pellet 1";
                    break;
                case 2:
                    NameLinea = "Pellet 2";
                    break;
                case 3:
                    NameLinea = "Extrusora";
                    break;
                default:
                    break;
            }

            load_data();
            LoadDetalleParos_(id_encabezado, id_linea);
            LoadDetalleLinea(id_encabezado, id_linea);
            LoadReproceso(id_encabezado, id_linea);
            LoadRendimiento();
        }
        public void load_data()
        {
            string query = @"EXEC  [dbo].[PRB_load_data_of_report_H] @id = " + id_encabezado + ";";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblrespontasable.Text = lblrespontasable.Text + " " + dr[0].ToString();
                    lblturno.Text = lblturno.Text + " " + dr[1].ToString();
                    lblini.Text = lblini.Text + " " + Convert.ToDateTime(dr[4].ToString()).ToString("dd/MM/yyyy");
                    lblfin.Text = lblfin.Text = "Fecha final: " + Convert.ToDateTime(dr[5].ToString()).ToString("dd/MM/yyyy");
                    lblhoras.Text = lblhoras.Text = "Horas: " + dr[3].ToString();
                    xrLabel5.Text = "N. Registro: " + id_encabezado + " linea: " + NameLinea;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadDetalleParos_(int varid, int vIdLinea)
        {
            try
            {
                string query = @"[sp_get_lista_transaccion_causas_tipo_paro_PRB]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idreg", id_encabezado);
                cmd.Parameters.AddWithValue("@linea", id_linea);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                prBdata1.causas_transact.Clear();
                da.Fill(prBdata1.causas_transact);
                //SumHoras();
            }
            catch (Exception)
            {
                CajaDialogo.Error("Error al cargar los datos, contacte con el administrador");
            }
        }
        private void LoadDetalleLinea(int varid, int idLinea)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalles_linea_prb_reporte_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", id_encabezado);
                cmd.Parameters.AddWithValue("@idlinea", id_linea);
                prBdata1.data_resumen.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(prBdata1.data_resumen);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadReproceso(int idh, int idLinea)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_reproceso_registro_prb_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", id_encabezado);
                cmd.Parameters.AddWithValue("@idlinea", id_linea);
                prBdata1.reproceso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(prBdata1.reproceso);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadRendimiento()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_eficiencia_prd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", id_encabezado);
                cmd.Parameters.AddWithValue("@idlinea", id_linea);
                prBdata1.rendimiento.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(prBdata1.rendimiento);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
