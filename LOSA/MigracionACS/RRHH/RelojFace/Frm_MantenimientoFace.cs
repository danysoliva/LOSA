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
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.RRHH.RelojFace
{
    public partial class Frm_MantenimientoFace : DevExpress.XtraEditors.XtraForm
    {
        public DateTime inicial;
        public DateTime final;
        public int SelectedPage;
        public int id_empleado;
        int tipoBusqueda;
        DataOperations dp = new DataOperations();
        public Frm_MantenimientoFace()
        {
            InitializeComponent();
            dt_inicial.EditValue = DateTime.Now.AddDays(-1);
            dt_final.EditValue = DateTime.Now;
            tabPane1.SelectedPageIndex = 0;
            load_administracion();
        }
        public void load_administracion()
        {
            string query = @"sp_load_empleados_administracion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsFaceReloj.Empleados.Clear();
                da.Fill(dsFaceReloj.Empleados);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_turnos()
        {
            string query = @"sp_load_empleados_turnos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsFaceReloj.Empleados.Clear();
                da.Fill(dsFaceReloj.Empleados);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            SelectedPage = tabPane1.SelectedPageIndex;
            grd_empleados.EditValue = null;
            if (SelectedPage == 1)
            {
                load_turnos();
            }
            else
            {
                load_administracion();
            }
            
        }

        private void tggTodos_Toggled(object sender, EventArgs e)
        {
            if (tggTodos.IsOn)
            {
                tipoBusqueda = 1;
                grd_empleados.Enabled = true;

            }
            else
            {
                tipoBusqueda = 0;
                grd_empleados.Enabled = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cargar_reporte();
        }

        public void Cargar_reporte()
        {
            if (dt_inicial.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar fecha inicial.");
                return;
            }
            if (dt_final.EditValue == null)
            {
                dt_final.EditValue = dp.Now();
                //CajaDialogo.Error("Debe seleccionar fecha final.");
                //return;
            }
            if (tipoBusqueda == 1)
            {
                if (grd_empleados.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar el empleado que desea revisar el reporte.");
                    return;
                }
            }
            if (Convert.ToDateTime(dt_inicial.EditValue) > Convert.ToDateTime(dt_final.EditValue))
            {
                CajaDialogo.Error("La fecha inicial no puede ser menor que la fecha final para generar el reporte.");
                return;
            }
            try
            {
                string query = @"";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd;
                if (SelectedPage == 0)
                {          //Administracion

                    if (tipoBusqueda == 0)
                    {   // Buscar Todos los empleados
                        query = @"sp_load_marcas_administracion";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                    }
                    else
                    {  // Buscar uno en especifico.
                        query = @"sp_load_marcas_administracion_filtro_empleado";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@aqf", grd_empleados.EditValue);
                    }
                }                               
                else
                {   //Turnos
                    if (tipoBusqueda == 0)
                    {   // Buscar Todos los empleados
                        query = @"sp_load_marcas_turno";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {  // Buscar uno en especifico.
                        query = @"sp_load_marcas_turno_filtro_empleado";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@aqf", grd_empleados.EditValue);
                    }
                }

                cmd.Parameters.AddWithValue("@dt_inicial", dt_inicial.EditValue);
                cmd.Parameters.AddWithValue("@dt_final", dt_final.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (SelectedPage ==0)
                {
                    dsFaceReloj.Administracion.Clear();
                    da.Fill(dsFaceReloj.Administracion);

                }
                else
                {
                    dsFaceReloj.Turnos.Clear();
                    da.Fill(dsFaceReloj.Turnos);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnexport_Click(object sender, EventArgs e)
        {
            if (SelectedPage == 0)
            {
                if (grdv_Admin.RowCount < 1)
                {
                    CajaDialogo.Error("Debe de generar el reporte primero.");
                    return;
                }
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_Admin.ExportToXlsx(dialog.FileName);
                }
            }
            else
            {
                if (grdv_Turnos.RowCount < 1)
                {
                    CajaDialogo.Error("Debe de generar el reporte primero.");
                    return;

                }
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_Turnos.ExportToXlsx(dialog.FileName);
                }

            }
        }

        private void grd_empleados_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (grd_empleados.EditValue  == null)
            {
                CajaDialogo.Error("Debe seleccionar el empleado antes de realizar una operacion de cambio o creacion de marcas.");
                return;
            }
            frm_Operaciones_Marcas frm = new frm_Operaciones_Marcas(Convert.ToString(grd_empleados.EditValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cargar_reporte();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_Admin.FocusedView;
                var row = (dsFaceReloj.AdministracionRow)gridView.GetFocusedDataRow();

                frm_Operaciones_Marcas frm = new frm_Operaciones_Marcas(row.serial, row.Code_ODOO);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Cargar_reporte();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdMoreDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //
            var gridView = (GridView)grd_Admin.FocusedView;
            var row = (dsFaceReloj.AdministracionRow)gridView.GetFocusedDataRow();

            frmDetalleMarcasFaceID frm = new frmDetalleMarcasFaceID(row.Name, row.fecha, row.Code);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dt_inicial_EditValueChanged(object sender, EventArgs e)
        {
            if (dt_inicial.EditValue != null)
            {
                Cargar_reporte();
            }
            
        }

        private void dt_final_EditValueChanged(object sender, EventArgs e)
        {
            //if (dt_inicial.EditValue != null)
            //{
            //    Cargar_reporte();
            //}
        }
    }
}