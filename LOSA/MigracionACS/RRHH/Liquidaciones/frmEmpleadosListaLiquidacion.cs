using Devart.Data.PostgreSql;
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

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class frmEmpleadosListaLiquidacion : Form
    {
        PgSqlConnection psConnection;
        private int idEmpleado;
        private string _NombreEmpleado;
        private string _CodigoEmpleado;
        private string _Pin;
        public frmEmpleadosListaLiquidacion(PgSqlConnection pConnection)
        {
            //constructor
            InitializeComponent();
            psConnection = pConnection;
            LoadData();
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => _NombreEmpleado; set => _NombreEmpleado = value; }
        public string CodigoEmpleado { get => _CodigoEmpleado; set => _CodigoEmpleado = value; }
        public string Pin { get => _Pin; set => _Pin = value; }

        private void LoadData()
        {
            string Query = @"select   hh.id as id
                                    , hh.barcode as Code
                                    , hh.name  as name
                                    , hh.pin
                            from public.hr_employee hh 
                                    join public.resource_resource rr on 
                                    hh.resource_id = rr.id
                            where --rr.active is true and 
                                    hh.id not in(1)
                            order by hh.name asc ";
            try
            {
                PgSqlCommand cmd = new PgSqlCommand(Query, psConnection);
                PgSqlDataAdapter da = new PgSqlDataAdapter(cmd);
                dSrrhh1.Empleados.Clear();
                da.Fill(dSrrhh1.Empleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Doble click en el row
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (DSrrhh.EmpleadosRow)gridView.GetFocusedDataRow();

            try
            {
                idEmpleado = Convert.ToInt32(row.id);
                CodigoEmpleado = row.Code;
                NombreEmpleado = row.name;
                Pin = row.pin;
            }
            catch (Exception)
            {

                
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (DSrrhh.EmpleadosRow)gridView.GetFocusedDataRow();
                if (row == null)
                {
                    return;
                }
                idEmpleado = Convert.ToInt32(row.id);
                CodigoEmpleado = row.Code;
                NombreEmpleado = row.name;
                Pin = row.pin;
            }
            catch (Exception)
            {

                
            }
        }

        private void frmEmpleadosListaLiquidacion_Enter(object sender, EventArgs e)
        {
            if (this.CodigoEmpleado != null)
            {
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
            
        }

        private void gridControl1_Enter(object sender, EventArgs e)
        {
            if (this.CodigoEmpleado != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
