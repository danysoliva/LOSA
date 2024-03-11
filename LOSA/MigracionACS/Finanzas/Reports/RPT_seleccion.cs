using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using LOSA.MigracionACS.Finanzas;
using ACS.Classes;

namespace LOSA.MigracionACS.Finanzas.Reports
{
    public partial class RPT_seleccion : Form
    {
        DataOperations dp = new DataOperations();
        int Desde;
        int Hasta;
        public int PDesde { get => Desde; set => Desde = value; }
        public int PHasta { get => Hasta; set => Hasta = value; }

        public RPT_seleccion()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            try
            {
                PgSqlConnection cn = new PgSqlConnection(dp.ConnectionStringODOO);
                cn.Open();
                string Query;
                Query = @"SELECT id as id
                            , date_start as date_start
                            , name as name
                    FROM public.hr_payslip_run
                    where name not similar to 'Planilla Hrs%%' and name not similar to 'Planilla horas extr%%'
                        and name not similar to 'Planilla Horas%%' and name not similar to 'Planilla de horas extras%%'
                        and name not similar to 'Planilla de horas extras%%' and name not similar to 'Planilla de Horas Extras %%'
                        and name not similar to 'Planilla hrs%%'
                    order by id desc;";
                PgSqlCommand cmd = new PgSqlCommand(Query, cn);
                PgSqlDataAdapter da = new PgSqlDataAdapter(cmd);
                datarpt.rpt.Clear();
                da.Fill(datarpt.rpt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void RPT_seleccion_Load(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            PDesde = Convert.ToInt32(gridLookUpEdit1.EditValue.ToString());
           
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            PHasta = Convert.ToInt32(gridLookUpEdit2.EditValue.ToString());
        }
    }
}
