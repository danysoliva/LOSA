using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.RecepcionMP;
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

namespace LOSA.Logistica
{
    public partial class xfrmIngresosMP_Reproceso : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;
        DataOperations dp = new DataOperations();
        public xfrmIngresosMP_Reproceso(UserLogin pUser)
        {
            InitializeComponent();

            usuarioLogueado = pUser;

            Load_Info();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           xfrmMP_Reproceso frm = new xfrmMP_Reproceso(usuarioLogueado);
            frm.WindowState = FormWindowState.Maximized;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Load_Info();
            }
        }

        public void Load_Info()
        {
            string query = @"[dbo].[ps_load_ingresos_from_tarimas_MP_Reproceso]";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                dsRecepcionMPx.IngresosMP.Clear();
                da.Fill(dsRecepcionMPx.IngresosMP);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            }
        }

        private void btnver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();

                if (row.tipo_ingreso == 1)
                {
                    frm_ingresos_lotes frmDetalle = new frm_ingresos_lotes(row.id, row.Ningreso, usuarioLogueado,false,0 );
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

        private void btnprint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                            Reportes.rptIngresoHoja report = new Reportes.rptIngresoHoja(row.id, registro.mp);
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

        private void btnprinttraslado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();
                if (row.tipo_ingreso == 2)
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
                            Reportes.rptIngresoHoja report = new Reportes.rptIngresoHoja(row.id, registro.mp);
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

        private void xfrmIngresosMP_Reproceso_Load(object sender, EventArgs e)
        {

        }
    }
}