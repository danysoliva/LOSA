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
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.Calidad.Parametros
{
    public partial class FrmRegistroMuestreo : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        string Lote;
        DataTable Tarimas;
        int id_pt;
        public FrmRegistroMuestreo(DataTable ParametroTarimas, string ParametroLote)
        {
            InitializeComponent();
            Lote = ParametroLote;
            Tarimas = ParametroTarimas;
            load_data();
            load_turno();
            load_parametros_fisicos_cumplo_no_cumple();
            load_parametros_fisicos_min_max();
        }


        public void load_turno()
        {
            string query = @"sp_load_turnos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsParametros.turno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.turno);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_parametros_fisicos_cumplo_no_cumple()
        {
            string query = @"sp_get_parametros_protuctos_revision_fisica";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsParametros.parametros_decision.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.parametros_decision);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_parametros_fisicos_min_max()
        {
            string query = @"sp_get_parametros_protuctos_revision_fisica_min_max";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pt", id_pt);
                dsParametros.parametros_decision.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsParametros.parametros_decision);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_data()
        {
            string Query = @"sp_get_orden_informacion_lot_by_tarima_id";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_lote", Lote);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnombre.Text = dr.IsDBNull(0) ? "" : dr.GetString(0);
                    txtlote.Text = dr.IsDBNull(1) ? 0.ToString() : dr.GetInt32(1).ToString();
                    txtformula.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                    dt_fecharegistro.EditValue = DateTime.Now;
                    id_pt = dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistroMuestreo_Load(object sender, EventArgs e)
        {

        }
    }
}