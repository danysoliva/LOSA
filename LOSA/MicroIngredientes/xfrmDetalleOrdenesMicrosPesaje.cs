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
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev2]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.plan_microsh);
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

            if (row.total == row.batch_real)
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
                if (Selecionado != Totalreq)
                {
                    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, "Debe de seleccionar todas las materias primas.");
                    if (frm.ShowDialog() == DialogResult.Cancel)
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


                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.AMI_ID);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                rpt.Print();

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
    }
}