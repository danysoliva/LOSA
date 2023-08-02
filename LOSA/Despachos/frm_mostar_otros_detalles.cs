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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Despachos
{
    public partial class frm_mostar_otros_detalles : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int ParId;
        public int LineNUm;
        public int DocEntry;
        public frm_mostar_otros_detalles(int DocEntry)
        {
            InitializeComponent();
            ParId = DocEntry;
            load_data_orden_de_ventas(DocEntry);
            exe_sp_get_plan();
        }

        //public void load_data_orden_de_ventas()
        //{
        //    DataOperations op = new DataOperations();
        //    SqlConnection sqlConnection = new SqlConnection(op.ConnectionStringLOSA);
        //    try
        //    {
        //        string qry = @"EXEC [dbo].[orden_venta_load_despachos]";//Query que obtiene la informacion de las Ordenes de ventas.
        //        sqlConnection.Open();
        //        SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
        //        ds_despachos.orden_venta.Clear();
        //        dataAdapter.Fill(ds_despachos.orden_venta);
        //        sqlConnection.Close();

        //    }
        //    catch (Exception ex)
        //    {

        //        CajaDialogo.Error(ex.Message);
        //    }
        //}

        public void load_data_orden_de_ventas(int pDocEntry)
        {
            DataOperations op = new DataOperations();
            SqlConnection sqlConnection = new SqlConnection(op.ConnectionStringLOSA);
            try
            {
                string qry = @"[dbo].[orden_venta_load_despachos_v2]";//Query que obtiene la informacion de las Ordenes de ventas.
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@docentry", pDocEntry);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                ds_despachos.orden_venta.Clear();
                dataAdapter.Fill(ds_despachos.orden_venta);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void exe_sp_get_plan()
        {
            string query = @"EXECUTE [dbo].[sp_cargar_detalle_orden_de_venta] 
                               @DocEntry = @DocEntryy";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@DocEntryy", SqlDbType.Int).Value = ParId;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.plan_despacho.Clear();
                da.Fill(ds_despachos.plan_despacho);
                cn.Close();         

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.plan_despachoRow)gridView.GetFocusedDataRow();
                LineNUm = row.iddetalle;
                this.DocEntry = row.DocNum;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.plan_despachoRow)gridView.GetFocusedDataRow();
                LineNUm = row.iddetalle;
                this.DocEntry = row.DocNum;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}