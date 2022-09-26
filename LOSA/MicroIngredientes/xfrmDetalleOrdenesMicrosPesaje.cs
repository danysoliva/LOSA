using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Micro;
using LOSA.MicroIngredientes.Models;
using LOSA.Reportes;
using DevExpress.XtraReports.UI;
using LOSA.Utileria;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmDetalleOrdenesMicrosPesaje : DevExpress.XtraEditors.XtraForm
    {
        int id = 0;
        string codigoOrden;
        int id_orden = 0;
        string pt_name;

        public xfrmDetalleOrdenesMicrosPesaje(int _ID, string _CodigoOrden)
        {
            InitializeComponent();
            id = _ID;
            codigoOrden = _CodigoOrden;
            LoadData();
            LoadDataIndividual();
        }

        public xfrmDetalleOrdenesMicrosPesaje()
        {
            InitializeComponent();
            //id = _ID;
            //codigoOrden = _CodigoOrden;
            LoadData();
            LoadDataIndividual();
            load_turno();
            Load_reprint();
        }

            public void load_turno() 
        {
            try
            {
                string Query = @"sp_load_turnos";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMicros.turno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMicros.turno);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message) ;
            }
        }
        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsh.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev5]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.plan_microsh);
                    cnx.Close();

                }

                if (dsMicros.plan_microsh.Rows.Count>0)
                {

                   lblPT.Text = "PT: "+ dsMicros.plan_microsh.FirstOrDefault().pt_name;
                   lblBatch.Text = "Batch Real: "+ dsMicros.plan_microsh.FirstOrDefault().batch_real;
                }
                else
                {
                    lblPT.Text = "PT: #";
                    lblBatch.Text = "Batch Real: #";
                }
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void Load_reprint()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsh_report.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev2_to_reprint]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.plan_microsh_report);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDataIndividual()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.DetalleOrdenesPesajeIndividual.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interface_indiv_activa_V2]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.DetalleOrdenesPesajeIndividual);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmDetalleOrdenesMicros_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Código Orden: "+codigoOrden;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadDataIndividual();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
        }

        private void repositoryItemSpinEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan();

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    LoadData();
            //}

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDetalle_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        int ami_id=0;
        private void gvDetalle_RowClick(object sender, RowClickEventArgs e)
        {
            //Cargar el detalle
            var gridView = (GridView)gcDetalle.FocusedView;
            var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();

            ami_id = row.AMI_ID;

            if (row!=null)
            {
                id_orden = row.id_orden_encabezado;
            }

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))


                {
                    cnx.Open();
                    dsMicros.plan_microsd.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_detalle_ami_id_V2", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ami_id", SqlDbType.Int).Value = row.AMI_ID;
                    da.Fill(dsMicros.plan_microsd);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdPesar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Pesaje de Micros

        }

        private void cmdPesar1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsMicros.plan_microsdRow)gridView.GetFocusedDataRow();

            if (row.pesaje >= row.total)
            {
                CajaDialogo.Error("YA SE PESÓ ESTA MATERIA PRIMA");
                return;
            }
            //Pesar

            PesajeManualInfo pesajeManualInfo = new PesajeManualInfo();

            pesajeManualInfo.MateriaPrimaID = row.id_rm;
            pesajeManualInfo.Total = row.total;
            pesajeManualInfo.OrdenID = id_orden;
            pesajeManualInfo.CantBatch = row.cant_batch;
            pesajeManualInfo.DetallePesajeManualPlanID=row.id_orden_pesaje_manual_plan;
            pesajeManualInfo.BatchPlan = row.cant_batch;
            pesajeManualInfo.AMI_ID = ami_id;

            frmSelectLotePesaje frm = new frmSelectLotePesaje(pesajeManualInfo);
            //frm.MdiParent = this.MdiParent;

            if (frm.ShowDialog()== DialogResult.OK)
            {
                //LoadData();
                gvDetalle_RowClick(null, null);


            }
            //frm.Show();
        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string total_= View.GetRowCellDisplayText(e.RowHandle, View.Columns["total"]);
                string batch_real = View.GetRowCellDisplayText(e.RowHandle, View.Columns["batch_real"]);
                if (total_ == batch_real)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.DarkGreen);
                    //e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private void cmdPesarInd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {

                var row = (dsMicros.DetalleOrdenesPesajeIndividualRow)gvPesajeIndividual.GetDataRow(gvPesajeIndividual.FocusedRowHandle);
                PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();

                if (row != null)
                {

                    if (row.Batch_Completados==row.Batch_Plan)
                    {
                        CajaDialogo.Error("YA HA COMPLETADO ESTE PLAN");
                        return;
                    }


                    pesajeIndividual.Batch_Plan = row.Batch_Plan;
                    pesajeIndividual.CantBatchMaximo = (row.Batch_Plan - row.Batch_Completados);
                    pesajeIndividual.id_orden_pesaje_header = row.id_orden_encabezado;
                    pesajeIndividual.MateriaPrimaID = row.id_rm;
                    pesajeIndividual.MateriaPrima = row.Material;
                    pesajeIndividual.Total = row.Total;
                    pesajeIndividual.PesoPorBatch = row.Peso_por_Batch;
                    //pesajeIndividual.AMI_ID = ami_id;


                    xfrmPesajeIndividual frm = new xfrmPesajeIndividual(pesajeIndividual);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataIndividual();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvPesajeIndividual_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string CantBatch_Plan = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Batch Plan"]);
                string batch_completados = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Batch Completados"]);

                if (CantBatch_Plan == batch_completados)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.DarkGreen);
                    //e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)gcDetalle.FocusedView;
                var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();
                int Selected = row.id_orden_encabezado;
                decimal Totalreq = row.total_kg;
                decimal Selecionado = 0;
                
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsd.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_detalle_ami_id_V2", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ami_id", SqlDbType.Int).Value = row.AMI_ID;
                    da.Fill(dsMicros.plan_microsd);
                    cnx.Close();

                }

                foreach (dsMicros.plan_microsdRow detalle in dsMicros.plan_microsd.Rows)
                {
                    if (detalle.AMI_ID == row.AMI_ID)
                    {
                        Selecionado = Selecionado + detalle.pesaje;
                    }
                }
                if (Selecionado < Totalreq)
                {
                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, "Debe de seleccionar todas las materias primas.");
                    if (frm.ShowDialog() == DialogResult.Cancel )
                    {
                        return;
                    }
                   
                }

                if (row.id_turno == 0)
                {
                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, "Debe seleccionar el turno para imprimir el reporte.");
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                string query = @"sp_update_plan_asignar_turnos";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_turno", row.id_turno);
                cmd.Parameters.AddWithValue("@AMI",row.AMI_ID);
                cmd.ExecuteNonQuery();
                cn.Close();


                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.AMI_ID, row.id_orden_encabezado);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                rpt.Print();


                query = @"sp_update_close_pesaje";
                cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden_encabezado", row.id_orden_encabezado);
                cmd.Parameters.AddWithValue("@AMI", row.AMI_ID);
                cmd.ExecuteNonQuery();
                cn.Close();

                LoadData();


            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void gvDetalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gcDetalle.FocusedView;
                var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();
                foreach (dsMicros.plan_microshRow item in dsMicros.plan_microsh.Rows)
                {
                    if (row.AMI_ID == item.AMI_ID)
                    {
                        row.id_turno = Convert.ToInt32(e.Value);
                        row.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void btn_reprint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMicros.plan_microsh_reportRow)gridView.GetFocusedDataRow();
                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.AMI_ID, row.id_orden_encabezado);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                rpt.Print();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSpin_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                //var gv = (GridView)gvDetalle.FocusedView;
                var row = (dsMicros.plan_microshRow)gvDetalle.GetFocusedDataRow();

                //if (row._Cod__Estado != 70)
                //{
                //    CajaDialogo.Error("Debe Activar la orden para planificar Batch(es)!");
                //    return;
                //}



                xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan(row.id_orden_encabezado, row.order_code);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int batchDisponibles = 0;

                    batchDisponibles = row.cant_batch - row.batch_real;


                    if (frm.cantBatch <= batchDisponibles)
                    {
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("sp_acumulador_batch_real", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = row.id_orden_encabezado;
                            cmd.Parameters.AddWithValue("@batch_acumulado", SqlDbType.Int).Value = frm.cantBatch;

                            cmd.ExecuteNonQuery();
                            cnx.Close();

                            LoadData();
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("DEDE DE PESAR UNA CANTIDAD MENOR O IGUAL A LA CANTIDAD DE BATCH DISPONIBLE");
                    }


                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                var row = (dsMicros.plan_microshRow)gvDetalle.GetFocusedDataRow();
                DataOperations dp = new DataOperations();
                OrdenH_Info orderH = new OrdenH_Info();
                //int idPesajeOrden = row.id_orden_encabezado;
                //Boolean existeOrdenPesaje = false;
                Boolean ExisteConfPesajeManual;

                //if (orderH.RecuperaRegistro(idPesajeOrden))
                //{
                //    //existeOrdenPesaje = true;
                //}

                if (row==null)
                {
                    CajaDialogo.Error("DEBE SELECCIONAR LA ORDEN ACTIVA");
                    return;
                }

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_validate_OP_Conf_PesajeIndividual", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_orden", SqlDbType.Int).Value = row.id_orden_encabezado;

                    ExisteConfPesajeManual = Convert.ToBoolean(cmd.ExecuteScalar());

                    cnx.Close();
                }


                if (ExisteConfPesajeManual == false)
                {

                    xfrmAsistentePesajeV2 frm = new xfrmAsistentePesajeV2(row.order_id, row.id_orden_encabezado, row.cant_batch);

                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("YA EXISTE UNA CONFIGURACION PARA ESTA ORDEN");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            try
            {

                var row = (dsMicros.plan_microshRow)gvDetalle.GetFocusedDataRow();

                if (row!=null)
                {


                xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan(row.id_orden_encabezado, row.order_code);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int batchDisponibles = 0;

                    batchDisponibles = row.cant_batch - row.batch_real;


                    if (frm.cantBatch <= batchDisponibles)
                    {
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("sp_acumulador_batch_real", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = row.id_orden_encabezado;
                            cmd.Parameters.AddWithValue("@batch_acumulado", SqlDbType.Int).Value = frm.cantBatch;

                            cmd.ExecuteNonQuery();
                            cnx.Close();

                            LoadData();
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("DEDE DE PESAR UNA CANTIDAD MENOR O IGUAL A LA CANTIDAD DE BATCH DISPONIBLE");
                    }


                }
                }
                else
                {
                    CajaDialogo.Error("NO HAY ORDEN ACTIVA");
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}