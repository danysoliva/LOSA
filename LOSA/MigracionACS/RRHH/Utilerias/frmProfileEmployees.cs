using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.RRHH.Utilerias
{
    public partial class frmProfileEmployees : DevExpress.XtraEditors.XtraForm
    {
        public frmProfileEmployees()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string sql = @"SELECT A.id, A.name, barcode
                                FROM public.hr_employee A
                                join public.resource_resource B
                                on A.resource_id = B.id
                                where A.x_update is false
	                                  and B.active
	                                  order by A.name";
                PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO4);
                conn.Open();
                PgSqlCommand command = new PgSqlCommand(sql, conn);
                //command.Parameters.AddWithValue("", 0);
                PgSqlDataAdapter adat = new PgSqlDataAdapter(command);
                dsUtilerias1.employees_old.Clear();
                adat.Fill(dsUtilerias1.employees_old);


                sql = @"SELECT A.id, A.name, barcode
                                FROM public.hr_employee A
                                join public.resource_resource B
                                on A.resource_id = B.id
                                where A.x_update is true
	                                  and B.active
	                                  order by A.name";
               
                command = new PgSqlCommand(sql, conn);
                //command.Parameters.AddWithValue("", 0);
                adat = new PgSqlDataAdapter(command);
                dsUtilerias1.employees_new.Clear();
                adat.Fill(dsUtilerias1.employees_new);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdUpdated_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UpdateEmployeeTMP tmp = new UpdateEmployeeTMP();
            var row = (dsUtilerias.employees_oldRow)gridView1.GetFocusedDataRow();
            if(tmp.RecuperarRegistro(row.id))
            {
                tmp.UpdateEmployee(row.id);
            }
        }
    }
}