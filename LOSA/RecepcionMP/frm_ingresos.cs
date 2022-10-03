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

            dp = new DataOperations();
            dtFechaDesdeDisponibles.DateTime = dp.Now().AddDays(-182);

            dtFechaHastaDisponibles.DateTime = dp.Now().AddDays(1);

            Load_Info();


        }
        public void Load_Info()
        {

            if (toggleSwitchVerTodos_Disponibles.IsOn)
            {
                string query = @"EXEC dbo.ps_load_ingresos_from_tarimas_v5";
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
            else
            {
                if (dtFechaDesdeDisponibles.DateTime.Year >= 2018)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Close();
                        SqlCommand cmd = new SqlCommand("ps_load_ingresos_from_tarimas_con_filtro_fecha", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@desde", dtFechaDesdeDisponibles.DateTime);
                        cmd.Parameters.AddWithValue("@hasta", dtFechaHastaDisponibles.DateTime);
                        dsRecepcionMPx.IngresosMP.Clear();
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        adat.Fill(dsRecepcionMPx.IngresosMP);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
                else
                {
                    CajaDialogo.Error("Debe ingresar un rango de fecha valido!");
                }
            
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
            SelectorFor path = new SelectorFor(5);
            if (path.Camino == 1)
            {
                frmSpet1 frm = new frmSpet1(UsuarioLogeado);
                frm.MDI_Parent = this.MdiParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Load_Info();
                }
            }
            else
            {
                frmTarima frm = new frmTarima(UsuarioLogeado);
                frm.WindowState = FormWindowState.Maximized;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Load_Info();
                }
            }



        }

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();

                if (row.tipo_ingreso == 1 || row.tipo_ingreso == 5)
                {
                    frm_ingresos_lotes frmDetalle = new frm_ingresos_lotes(row.id, row.Ningreso, UsuarioLogeado, row.bit_fin, row.id_traslado, row.itemcode);
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
                            report.Parameters["id_ingreso"].Value = row.id;
                            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(report);
                            printReport.ShowPreview();
                        }

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
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
                    frm_edit_data frm = new frm_edit_data(row.id, row.fecha_creacion, UsuarioLogeado);
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
        public int isTraslado;   
        public void validar_tipoingreso(int Id)
        {
            string query = @"sp_get_informacion_sobre_tipo_ingreso_and_traslado";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    isTraslado = dr.GetInt32(0);
                }
                dr.Close();
                cn.Close();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnCopiarAtraslado_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_ingreso.FocusedView;
                var row = (dsRecepcionMPx.IngresosMPRow)gridview.GetFocusedDataRow();
                validar_tipoingreso(row.id);
                if (isTraslado > 0)
                {
                    CajaDialogo.Error("Ya se definio previamente este ingreso como un traslado.");
                    return;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            Load_Info();
        }

        private void toggleSwitchVerTodos_Disponibles_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitchVerTodos_Disponibles.IsOn)

                dtFechaHastaDisponibles.Enabled = dtFechaDesdeDisponibles.Enabled = false;
            else
                dtFechaHastaDisponibles.Enabled = dtFechaDesdeDisponibles.Enabled = true;
        }
    }
}