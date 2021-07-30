using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frm_ingresos : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frm_ingresos(UserLogin User)
        {
            InitializeComponent();
            UsuarioLogeado = User;
            Load_Info();
        }
        public void Load_Info()
        {
            string query = @"EXEC dbo.ps_load_ingresos_from_tarimas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsRecepcionMPx.IngresosMP.Clear();
                da.Fill(dsRecepcionMPx.IngresosMP);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTarima frm = new frmTarima(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Load_Info();
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();

                if (row.tipo_ingreso == 1)
                {
                    frm_ingresos_lotes frmDetalle = new frm_ingresos_lotes(row.id, row.Ningreso, UsuarioLogeado);
                    if (frmDetalle.ShowDialog() == DialogResult.OK)
                    {
                        Load_Info();
                    }
                }
                else
                {
                    frm_detalle_granel frm = new frm_detalle_granel(row.Ningreso);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Load_Info();
                    }
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();
                if (row.tipo_ingreso == 1)
                {
                    string query = @"sp_obtener_id_mps_from_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    try
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_ingreso", row.id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dsRecepcionMPx.mp_lote.Clear();
                        da.Fill(dsRecepcionMPx.mp_lote);
                        cn.Close();
                        foreach (dsRecepcionMPx.mp_loteRow registro in dsRecepcionMPx.mp_lote.Rows)
                        {
                            Reportes.rptIngresoHoja report = new Reportes.rptIngresoHoja(row.id, registro.mp,1);
                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(report);
                            printReport.ShowPreview();
                        }

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {

                }    
                

            }
            catch (Exception ex)
            {

               
            }
        }

        private void frm_ingresos_Load(object sender, EventArgs e)
        {



           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();
                if (row.tipo_ingreso == 1)
                {
                    frm_edit_data frm = new frm_edit_data(row.id);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Load_Info();
                    }
                }
                else
                {
                    CajaDialogo.Error("Debe ir al modulo de granel para hacer modificaciones al registro de ingresos.");
                    return;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnccartilla_Click(object sender, EventArgs e)
        {

        }

        private void btnprinttraslado_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();
                if (row.tipo_ingreso == 1)
                {
                    string query = @"sp_obtener_id_mps_from_ingreso";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    try
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_ingreso", row.id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dsRecepcionMPx.mp_lote.Clear();
                        da.Fill(dsRecepcionMPx.mp_lote);
                        cn.Close();
                        foreach (dsRecepcionMPx.mp_loteRow registro in dsRecepcionMPx.mp_lote.Rows)
                        {
                            Reportes.rptIngresoHoja report = new Reportes.rptIngresoHoja(row.id, registro.mp, 2);
                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(report);
                            printReport.ShowPreview();
                        }

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {

                }


            }
            catch (Exception ex)
            {


            }
        }
    }
}