using ACS.Classes;
using Devart.Data.PostgreSql;
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

namespace LOSA.MigracionACS.RRHH.Reportes
{
    public partial class frmResumenVacaciones : DevExpress.XtraEditors.XtraForm
    {
        public frmResumenVacaciones()
        {
            InitializeComponent();
            //LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                PgSqlConnection con = new PgSqlConnection(dp.ConnectionStringODOO5);
                con.Open();

                PgSqlCommand cmd = new PgSqlCommand(@"SELECT 
                                                              A.id,
                                                              state,
                                                              holiday_status_id,
                                                              B.name as status,
                                                              employee_id,
                                                              C.name as employee_name,
                                                              A.department_id,
                                                              D.name as department,
                                                              date_from,
                                                              date_to,
                                                              number_of_days,
                                                              A.create_date
                                                            FROM 
                                                              public.hr_leave A left join
                                                              public.hr_leave_type B
                                                              on A.holiday_status_id = B.id left join
                                                              public.hr_employee C 
                                                              on A.employee_id = C.id left join
                                                              public.hr_department D
                                                              on A.department_id = D.id
                                                              where A.date_from::date between :pfechadesde and :fechahasta", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pfechadesde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("fechahasta", dtHasta.EditValue);
                dsReportesRRHH1.vacaciones.Clear();
                PgSqlDataAdapter adat = new PgSqlDataAdapter(cmd);
                adat.Fill(dsReportesRRHH1.vacaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl1.ExportToXlsx(dialog.FileName);
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}