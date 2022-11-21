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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.DashBoard;

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    public partial class frmDashBoard : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmDashBoard(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            dtDesde.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtHasta.EditValue = DateTime.Now;
        }

        private void Turno_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("dsb_get_resumen_fallas_por_maquina", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaini", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@fechafin", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@filtro_maquina", barEditMaquinas.EditValue);
                cmd.Parameters.AddWithValue("@filtro_turno", Turno.EditValue);
                dsDashBoard1.Extru_1.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDashBoard1.Extru_1);

                con.Close();
                int filtromaquina_ = Convert.ToInt32(barEditMaquinas.EditValue);
                LoadDetalleHoras(filtromaquina_);
                Load_Totales(filtromaquina_);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void barEditMaquinas_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtDesde_EditValueChanged_1(object sender, EventArgs e)
        {
            if(dtHasta.EditValue!=null)
                LoadData();
        }
        public void Load_Totales(int filtroMaquina)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_tm_producidas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_i", SqlDbType.Date).Value = dtDesde.EditValue;
                cmd.Parameters.Add("@fecha_f", SqlDbType.Date).Value = dtHasta.EditValue;
                cmd.Parameters.Add("@filtro_maquina", SqlDbType.Int).Value = filtroMaquina;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.producidas.Clear();
                adat.Fill(dsDashBoard1.producidas);
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        void LoadDetalleHoras(int filtro_maquina)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_resumen_horas_efectivas_on_y_paro_v2", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_i", SqlDbType.Date).Value = dtDesde.EditValue;
                cmd.Parameters.Add("@fecha_f", SqlDbType.Date).Value = dtHasta.EditValue;
                cmd.Parameters.Add("@filtro_maquina", SqlDbType.Int).Value = filtro_maquina;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDashBoard1.header_causes.Clear();
                adat.Fill(dsDashBoard1.header_causes);
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnver3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_extru.FocusedView;
                var row = (dsDashBoard.Extru_1Row)gridview.GetFocusedDataRow();

                PRB_Causas_de_paro data = new PRB_Causas_de_paro(Convert.ToDateTime(dtDesde.EditValue), 
                                                                 Convert.ToDateTime(dtHasta.EditValue), 
                                                                 row.id_causa, 
                                                                 row.id_maquina,//id maquina 
                                                                 Convert.ToInt32(Turno.EditValue));
                if (data.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
} 