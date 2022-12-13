using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MigracionACS.RRHH.HorasExtra;
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

namespace ACS.RRHH.HorasExtra
{
    public partial class frmResumenHorasExtra : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public DateTime fecha;
        public int IdSemana;
        public int anio;
        public frmResumenHorasExtra(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            DataOperations dp = new DataOperations();
            DateTime now = dp.Now();
            txtYear.Text = now.Year.ToString();
            anio = now.Year;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtYear.Text))
            {
                dxErrorProvider1.SetError(txtYear, "No se permite dejar el año en Blanco!");
                return;    
            }

            if(spinNumSemana.EditValue == null)
            {
                dxErrorProvider1.SetError(txtYear, "No se permite dejar el # de semana en Blanco!");
                return;
            }

            LoadFechasSemana();

            fecha = Convert.ToDateTime(dateEditDesde.EditValue);
            IdSemana = Convert.ToInt32(spinNumSemana.EditValue);
            anio = Convert.ToInt32(txtYear.Text);

            GenerarDataSemana();
        }

        private void GenerarDataSemana()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_resumen_horas_extra_rrhh_user]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechai", dateEditDesde.EditValue);
                cmd.Parameters.AddWithValue("@fechaf", dateEditHasta.EditValue);
                cmd.Parameters.AddWithValue("@semana", IdSemana);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsHorasExtra1.horas_extra_user.Clear();
                adat.Fill(dsHorasExtra1.horas_extra_user);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void GetId_Semana_FromDate(DateTime pdatetime)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_num_semana_from_date]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechai", dateEditDesde.EditValue);
                //cmd.Parameters.AddWithValue("@fechaf", dateEditHasta.EditValue);
                //cmd.Parameters.AddWithValue("@semana", IdSemana);
                IdSemana = Convert.ToInt32(cmd.ExecuteScalar());
                spinNumSemana.EditValue = IdSemana;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadFechasSemana()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_inicio_and_fin_date_from_week]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@semana", IdSemana);
                cmd.Parameters.AddWithValue("@anio", anio);
                //dsPlanMantoPrev1.distribucion_prev_manto.Clear();
                SqlDataReader dr = cmd.ExecuteReader();
                int conta = 0;
                while (dr.Read())
                {
                    if (conta == 0)
                    {
                        dateEditDesde.EditValueChanged -= new EventHandler(dateEditDesde_EditValueChanged);
                        dateEditDesde.EditValue = dr.GetDateTime(0);
                        dateEditDesde.EditValueChanged += new EventHandler(dateEditDesde_EditValueChanged);

                    }
                    else
                    {
                        dateEditHasta.EditValueChanged -= new EventHandler(dateEditDesde_EditValueChanged);
                        dateEditHasta.EditValue = dr.GetDateTime(0);
                        dateEditHasta.EditValueChanged += new EventHandler(dateEditDesde_EditValueChanged);
                    }
                    conta++;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void dateEditDesde_EditValueChanged(object sender, EventArgs e)
        {
            GetId_Semana_FromDate(Convert.ToDateTime(dateEditDesde.EditValue));

        }

        private void spinNumSemana_EditValueChanged(object sender, EventArgs e)
        {
            IdSemana = Convert.ToInt32(spinNumSemana.EditValue);
        }

        private void cmdVerDetalles_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsHorasExtra.horas_extra_userRow)gridView.GetFocusedDataRow();

            frmDetalleSemanaEmpleadoRRHH frm = new frmDetalleSemanaEmpleadoRRHH(UsuarioLogeado, row.nombre, row.week_num, row.id_empleado);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }
    }
}