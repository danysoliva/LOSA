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
using LOSA.Clases;
using System.Data.Linq;
using LOSA.Reportes;
using System.Threading;
using System.Data.OleDb;
using Huellas;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Logistica
{
    public partial class frmPlanSemanal : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int TabActive;
        int Default_Value = 0;
        string file_name;
        UserLogin UsuarioLogeado;
        Plan_Semanal plan;

        public frmPlanSemanal(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            TabActive = Default_Value;
            Get_Planes();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            try
            {
                TabActive = tabPane1.SelectedPageIndex;
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_nuevaSemanaPlan frm = new frm_nuevaSemanaPlan(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Get_Planes();
                plan = new Plan_Semanal(frm.Id_created);
                grd_semana.EditValue = frm.Id_created;
                dt_inicial.EditValue = plan.Date_begin;
                dt_final.EditValue = plan.Date_end;
                load_plan_produccion();
                load_despachos();
            }
        }

        private void grd_semana_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                plan = new Plan_Semanal(Convert.ToInt32(grd_semana.EditValue));

                dt_inicial.EditValue = plan.Date_begin;
                dt_final.EditValue = plan.Date_end;
                load_despachos();
                load_plan_produccion();

            }
            catch (Exception ex)
            {

            }
        }

        public void load_despachos()
        {
            string Query = @"sp_get_plan_semanal_detalle";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", 0);
                cmd.Parameters.AddWithValue("@id_h", plan.Id);
                dsLogistica2.despacho.Clear(); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLogistica2.despacho);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_plan_produccion()
        {
            string Query = @"sp_get_plan_semanal_detalle";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", 1);
                cmd.Parameters.AddWithValue("@id_h", plan.Id);
                dsLogistica2.Plan_Produccion.Clear(); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsLogistica2.Plan_Produccion);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_semana_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
         
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!plan.Cargado)
                {
                    CajaDialogo.Error("Debe de seleccionar o cargar un plan para poder agregar un articulo.");
                    return;
                }
            }
            catch (Exception)
            {

                CajaDialogo.Error("Debe de seleccionar o cargar un plan para poder agregar un articulo.");
                return;
            }
            frm_getfinish frm = new frm_getfinish();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (plan.SetNewProductInWeek(TabActive, frm.Id_producto))
                {
                    if (TabActive == 0)
                    {
                        load_despachos();
                    }
                    else
                    {
                        load_plan_produccion();
                    }
                }
            }
        }

        private void btnDescargarPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabActive == 0)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog.FilterIndex = 0;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        grd_data.ExportToXlsx(dialog.FileName);
                    }
                }
                else
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog.FilterIndex = 0;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        grdv_plan_produccion.ExportToXlsx(dialog.FileName);
                    }
                }

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!plan.Cargado)
                {
                    CajaDialogo.Error("Debe de seleccionar o cargar un plan para poder agregar un articulo.");
                    return;
                }
            }
            catch (Exception)
            {

                CajaDialogo.Error("Debe de seleccionar o cargar un plan para poder agregar un articulo.");
                return;
            }

            try
            {
                file_name = string.Empty;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel File(.xlsx)| *.xlsx";
                //dialog.InitialDirectory = @"C:\";
                dialog.Title = "Seleccione el archivo importado anteriormente";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    file_name = @dialog.FileName.ToString();
                    string Connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file_name + "; Extended Properties=\"Excel 12.0 Xml; HDR = YES\"";
                    OleDbConnection con = new OleDbConnection(Connection);
                    OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from [Sheet$]", con);
                    //dSMP1.LoadExcel.Clear();

                    SplashForm frmProceso = new SplashForm();
                    try
                    {
                        if (TabActive == 0 )
                        {   // 
                            dsLogistica2.despacho.Clear();
                            myCommand.Fill(dsLogistica2.despacho);
                        }
                        else
                        {
                            dsLogistica2.Plan_Produccion.Clear();
                            myCommand.Fill(dsLogistica2.Plan_Produccion);
                        }
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                    int TiempoP = 450;
                    frmProceso.ShowDialog();
                    Thread.Sleep(TiempoP);
                    frmProceso.Close();


                }


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            if (TabActive == 0)
            {             // Si es la tab seleccionada 

            }
            else
            {

            }

        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                int id_pt = 0;
                  
                foreach (dsLogistica2.despachoRow date  in dsLogistica2.despacho.Rows)
                {  //Guardar 

                    if (date.id_pt == 0)
                    {
                        string query = @"sp_get_id_pt_by_itemcode";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", date.codigo);
                        id_pt = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();
                    }

                    //Data

                    string SQl = @"sp_set_pt_in_plan";
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand comd = new SqlCommand(SQl, con);
                    comd.CommandType = CommandType.StoredProcedure;

                    comd.Parameters.AddWithValue("@id_plan", plan.Id);
                    comd.Parameters.AddWithValue("@id_pt", date.id_pt == 0 ? id_pt : date.id_pt );
                    try
                    { comd.Parameters.AddWithValue("@domingo", date.domingo);
                    }
                    catch ( Exception ex)
                    {   comd.Parameters.AddWithValue("@domingo", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@lunes", date.lunes);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@lunes", 0);
                    }
                    try
                    {

                        comd.Parameters.AddWithValue("@martes", date.martes);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@martes", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@miercoles", date.miercoles);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@miercoles", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@jueves", date.jueves);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@jueves", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@viernes", date.viernes);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@viernes", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@sabado", date.sabado);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@sabado", 0);
                    }
                    comd.Parameters.AddWithValue("@tipo", 0);
                    comd.ExecuteNonQuery();

                    con.Close();

                }

                foreach (dsLogistica2.Plan_ProduccionRow row in dsLogistica2.Plan_Produccion.Rows)
                {   // plan 
                    if (row.id_pt == 0)
                    {
                        string query = @"sp_get_id_pt_by_itemcode";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@itemcode", row.codigo);
                        id_pt = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.Close();
                    }

                    //Data

                    string SQl = @"sp_set_pt_in_plan";
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand comd = new SqlCommand(SQl, con);
                    comd.CommandType = CommandType.StoredProcedure;
                    comd.Parameters.AddWithValue("@id_plan", plan.Id);
                    comd.Parameters.AddWithValue("@id_pt", row.id_pt == 0 ? id_pt : row.id_pt);
                    try
                    {
                        comd.Parameters.AddWithValue("@domingo", row.domingo);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@domingo", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@lunes", row.lunes);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@lunes", 0);
                    }
                    try
                    {

                        comd.Parameters.AddWithValue("@martes", row.martes);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@martes", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@miercoles", row.miercoles);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@miercoles", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@jueves", row.jueves);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@jueves", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@viernes", row.viernes);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@viernes", 0);
                    }
                    try
                    {
                        comd.Parameters.AddWithValue("@sabado", row.sabado);
                    }
                    catch (Exception ex)
                    {
                        comd.Parameters.AddWithValue("@sabado", 0);
                    }
                    comd.Parameters.AddWithValue("@tipo", 1);
                    comd.ExecuteNonQuery();

                    con.Close();

                }

                CajaDialogo.Information("Cambios han sido guardados satisfactoriamente.");

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsLogistica2.despachoRow)gridView.GetFocusedDataRow();

                string query = @"st_delete_producto_plan";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", plan.Id);
                cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                cmd.Parameters.AddWithValue("@tipo",0);
                cmd.ExecuteNonQuery();

                grdv_data.DeleteRow(grdv_data.FocusedRowHandle);

                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message); ;
            }
        }

        private void btnEliminarProduccion_Click(object sender, EventArgs e)
        {

            try
            {
                var gridView = (GridView)grd_plan_produccion.FocusedView;
                var row = (dsLogistica2.Plan_ProduccionRow)gridView.GetFocusedDataRow();

                string query = @"st_delete_producto_plan";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", plan.Id);
                cmd.Parameters.AddWithValue("@id_pt", row.id_pt);
                cmd.Parameters.AddWithValue("@tipo", 1);
                cmd.ExecuteNonQuery();

                grdv_plan_produccion.DeleteRow(grdv_data.FocusedRowHandle);

                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message); ;
            }
        }
    }
}