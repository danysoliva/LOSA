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
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Logistica;

namespace LOSA.Reportes
{
    public partial class frmrptPlansemanal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public int Tipo_Reporte;
        int Default_value = 0;
        public int especie;
        public int id_semana;
        dsLogistica2 info = new dsLogistica2();
        public frmrptPlansemanal()
        {
            Tipo_Reporte = Default_value;
            id_semana = Default_value;
            especie = 3;
            InitializeComponent();
            Get_Planes();
        }  
        
       
       


        Plan_Semanal plan;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Get_Planes()
        {
            string query = @"sp_GET_planes_semanales_to_pick";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLogistica2.planes_semanales.Clear();
                da.Fill(dsLogistica2.planes_semanales);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }
        private void grd_semana_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                plan = new Plan_Semanal(Convert.ToInt32(grd_semana.EditValue));
                dt_inicial.EditValue = plan.Date_begin;
                dt_final.EditValue = plan.Date_end;
                id_semana = plan.Id;
                if (especie != Default_value && id_semana != Default_value && Tipo_Reporte != Default_value)
                {
                    if (!workerDev.IsBusy)
                    {
                        workerDev.RunWorkerAsync();
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }
        public void get_reporte()
        {

          

            if (especie == Default_value)
            {
                CajaDialogo.Error("Debe seleccionar una especie especifica.");
                return;
            }
            if (Tipo_Reporte == Default_value)
            {

                CajaDialogo.Error("Debe seleccionar un tipo de reporte.");
                return;
            }
            if (id_semana == Default_value)
            {

                CajaDialogo.Error("Debe seleccionar un numero de semana para continuar.");
                grd_semana.ShowPopup();
                return;

            }

           

            string query = @"SP_get_reporte_semanal_vrs_despacho_by_numero_semana";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_doc", Tipo_Reporte);
                cmd.Parameters.AddWithValue("@especie", especie);
                cmd.Parameters.AddWithValue("@id", id_semana);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsLogistica2.reporte_semanal1.Clear();
                da.Fill(dsLogistica2.reporte_semanal1);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            run_worker();
        }

        private void GroupTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Tipo_Reporte = Convert.ToInt32(GroupTipo.EditValue);
                if (especie != Default_value && id_semana != Default_value && Tipo_Reporte != Default_value)
                {
                    run_worker();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                especie = Convert.ToInt32(radioGroup2.EditValue);
                if (especie != Default_value && id_semana != Default_value && Tipo_Reporte != Default_value)
                {
                    run_worker();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void run_worker()
        {
            if (!workerDev.IsBusy)
            {
             ProgresoEstaPasandoAlgo.Visible = true;
                workerDev.RunWorkerAsync();
            }
        }

        private void workerDev_DoWork(object sender, DoWorkEventArgs e)
        {
            get_reporte();
        }

        private void workerDev_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgresoEstaPasandoAlgo.EditValue = e.ProgressPercentage;
        }

        private void workerDev_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            ProgresoEstaPasandoAlgo.Visible = false;
            ProgresoEstaPasandoAlgo.EditValue = 0;
            dsLogistica2.reporte_semanal.Clear();
            foreach (dsLogistica2.reporte_semanal1Row lleno in dsLogistica2.reporte_semanal1.Rows)
            {
                DataRow newR;
                newR = dsLogistica2.reporte_semanal.NewRow();
                newR["code_sap"] = lleno.code_sap;
                newR["Codigo"] = lleno.Codigo;
                newR["Descripcion"] = lleno.Descripcion;
                newR["Domingo_Despacho"] = lleno.Domingo_Despacho;
                newR["Domingo_Plan"] = lleno.Domingo_Plan;
                newR["Lunes_Despacho"] = lleno.Lunes_Despacho;
                newR["Lunes_Plan"] = lleno.Lunes_Plan;
                newR["Martes_Despacho"] = lleno.Martes_Despacho;
                newR["Martes_Plan"] = lleno.Martes_Plan;
                newR["Miercoles_Despacho"] = lleno.Miercoles_Despacho;
                newR["Miercoles_Plan"] = lleno.Miercoles_Plan;
                newR["Jueves_Despacho"] = lleno.Jueves_Despacho;
                newR["Jueves_Plan"] = lleno.Jueves_Plan;
                newR["Viernes_Despacho"] = lleno.Viernes_Despacho;
                newR["Viernes_Plan"] = lleno.Viernes_Plan;
                newR["Sabado_Despacho"] = lleno.Sabado_Despacho;
                newR["Sabado_Plan"] = lleno.Sabado_Plan;
                dsLogistica2.reporte_semanal.Rows.Add(newR);
            }
            dsLogistica2.reporte_semanal.AcceptChanges();
            grdv_data.BestFitColumns();

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (especie != Default_value && id_semana != Default_value && Tipo_Reporte != Default_value)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToXlsx(dialog.FileName);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (especie != Default_value && id_semana != Default_value && Tipo_Reporte != Default_value)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.pdf)|*.pdf";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToPdf(dialog.FileName);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (especie != Default_value && id_semana != Default_value && Tipo_Reporte != Default_value)
            {
                grd_data.ShowPrintPreview();
            }

        }

        private void grdv_data_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
        }

        private void grdv_data_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                if (workerDev.IsBusy)
                {
                    return;
                }
                Font SePaso = new Font("Segoe UI", 9, FontStyle.Bold);
                Font NoSehaPasado = new Font("Segoe UI", 9, FontStyle.Regular);

                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsLogistica2.reporte_semanalRow)gridView.GetDataRow(e.RowHandle);
                
                if (dsLogistica2.reporte_semanal.Rows.Count > 0 && e.RowHandle >= 0)
                {
                    if (e.Column.FieldName == "Domingo_Despacho")
                    {
                        e.Appearance.Font = row.Domingo_Despacho <= row.Domingo_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Domingo_Despacho <= row.Domingo_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);
                    }
                    if (e.Column.FieldName == "Lunes_Despacho")
                    {
                        e.Appearance.Font = row.Lunes_Despacho <= row.Lunes_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Lunes_Despacho <= row.Lunes_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);
                    }
                    if (e.Column.FieldName == "Martes_Despacho")
                    {

                        e.Appearance.Font = row.Martes_Despacho <= row.Martes_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Martes_Despacho <= row.Martes_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);
                    }
                    if (e.Column.FieldName == "Miercoles_Despacho")
                    {
                        e.Appearance.Font = row.Miercoles_Despacho <= row.Miercoles_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Miercoles_Despacho <= row.Miercoles_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);

                    }
                    if (e.Column.FieldName == "Jueves_Despacho")
                    {
                        e.Appearance.Font = row.Jueves_Despacho <= row.Jueves_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Jueves_Despacho <= row.Jueves_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);

                    }
                    if (e.Column.FieldName == "Viernes_Despacho")
                    {
                        e.Appearance.Font = row.Viernes_Despacho <= row.Viernes_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Viernes_Despacho <= row.Viernes_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);

                    }
                    if (e.Column.FieldName == "Sabado_Despacho")
                    {

                        e.Appearance.Font = row.Sabado_Despacho <= row.Sabado_Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = row.Sabado_Despacho <= row.Sabado_Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);
                    }
                    if (e.Column.Name  == "colDespacho")
                    {
                        decimal Despacho = (decimal)gridView.GetRowCellValue(e.RowHandle, "colDespacho");
                        decimal Plan = (decimal)gridView.GetRowCellValue(e.RowHandle, "ColNecesidad");
                        e.Appearance.Font = Despacho <= Plan ? NoSehaPasado : SePaso;
                        e.Appearance.ForeColor = Despacho <= Plan ? Color.FromArgb(8, 15, 43) : Color.FromArgb(186, 52, 47);
                    }
                   

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}