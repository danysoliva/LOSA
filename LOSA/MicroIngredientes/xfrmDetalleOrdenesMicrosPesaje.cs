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

        private void gvDetalle_RowClick(object sender, RowClickEventArgs e)
        {
            //Cargar el detalle
            var gridView = (GridView)gcDetalle.FocusedView;
            var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();

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

            frmSelectLotePesaje frm = new frmSelectLotePesaje(row.id_rm, row.total,id_orden,row.cant_batch, row.set_point,row.id_orden_pesaje_manual_plan);
            //frm.MdiParent = this.MdiParent;

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadData();
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

                    pesajeIndividual.Batch_Plan = row.Batch_Plan;
                    pesajeIndividual.CantBatchMaximo = (row.Batch_Plan - row.Batch_Completados);
                    pesajeIndividual.id_orden_pesaje_header = row.id_orden_encabezado;
                    pesajeIndividual.MateriaPrimaID = row.id_rm;
                    pesajeIndividual.Total = row.Total;
                    pesajeIndividual.PesoPorBatch = row.Peso_por_Batch;


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


       
    }
}