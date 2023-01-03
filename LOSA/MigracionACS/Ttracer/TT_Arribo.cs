using System;
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
using DevExpress.XtraReports.UI;
using ACS.Ttracer.Reportes;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_Arribo : Form
    {
        int IdSelected = 0;

        DataOperations dp = new DataOperations();
        string usercode;
        public TT_Arribo(string usercode)
        {
            InitializeComponent();
            this.usercode = usercode;
            load_dataselectwhitouPlan();
           // Load_data();
        }
        string query;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void Load_data()
        {
            string query = @"Select T1.id as IDArribH
                                    ,T1.codigo as codigo
                                    ,T1.date_inicio as Fecha
                                    ,coalesce(T1.shipid, 0) shipid
                                    ,Case when T1.withship = 1 then 
						                (Select	TOP 1
							                t3.descripcion
								                from TS_ship_h t2 JOIN M_ship T3
									                on T2.shipid = T3.id and T2.id = T1.shipid)
	                                    else 'Sin Baco' end as [Shipname]
	                                    from DC_workplan_h T1";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.arribload.Clear();
                da.Fill(dSTtracer.arribload);
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnnuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TT_Nuevo nuevo = new TT_Nuevo(usercode);
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                load_dataselectwhitouPlan();
            }
            else
            {
                if (nuevo.DialogResult == DialogResult.Yes)
                {
                    IdSelected = nuevo.IdGenerado;
                    Load_data();
                    barEditItem1.EditValue = IdSelected;
                    btnorden.Enabled = true;
                    Btnload.Enabled = true;
                    int idload = 0;
                    DateTime fechaini = DateTime.Now.Date;
                    idload = IdSelected;

                    TT_LoadOrder plan = new TT_LoadOrder(IdSelected, usercode, 1, fechaini);
                    if (plan.ShowDialog() == DialogResult.OK)
                    {
                        load_dataselect();
                    }
                }
            }
            //TT_newPlan plan = new TT_newPlan(usercode);
            //if (plan.ShowDialog() == DialogResult.OK)
            //{
            //    IdSelected = plan.IdGenerado;
            //    Load_data();
            //    barEditItem1.EditValue = IdSelected;
            //    btnorden.Enabled = true;
            //    Btnload.Enabled = true;

            //}
        }
        public void load_plan(int IdSlected)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TT_shipmant ship = new TT_shipmant(usercode);
            if (ship.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            btnorden.Enabled = true;
            Btnload.Enabled = true;
            IdSelected = Convert.ToInt32(barEditItem1.EditValue);
            load_dataselect();


        }

        private void btnorden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idload = 0;
            DateTime fechaini = DateTime.Now.Date;
            idload = IdSelected;

            TT_LoadOrder plan = new TT_LoadOrder(idload, usercode, 1, fechaini);
            if (plan.ShowDialog() == DialogResult.OK)
            {
                load_dataselect();
            }
        }
        public void load_dataselect()
        {
            string Query = @"EXEC [dbo].[Load_arrib_d] @id =" + IdSelected;
            try
            {
                DataOperations dpp = new DataOperations();
                SqlConnection cn = new SqlConnection(dpp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                dSTtracer.panelarribo.Clear();
                daa.Fill(dSTtracer.panelarribo);
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void load_dataselectwhitouPlan()
        {
            string Query = @"EXEC [dbo].[Load_arrib_d] @id =" + 0;
            try
            {
                DataOperations dpp = new DataOperations();
                SqlConnection cn = new SqlConnection(dpp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                dSTtracer.panelarribo.Clear();
                daa.Fill(dSTtracer.panelarribo);
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Btnload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idload = 0;
            foreach (DataRow row in dSTtracer.arribload.Rows)
            {
                if (Convert.ToInt32(row["IDArribH"]) == Convert.ToInt32(barEditItem1.EditValue))
                {
                    idload = Convert.ToInt32(row["shipid"]);
                }

            }
            TT_LoadDship shi = new TT_LoadDship(idload, IdSelected );
            if (shi.ShowDialog() == DialogResult.OK)
            {

                load_dataselect();
            }
        }

        private void grdv_arribo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string Estado = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Estatus"]);
                    decimal diferencia = Convert.ToDecimal(Estado);
                    switch (Estado)
                    {
                        case "10":
                            e.Appearance.BackColor = Color.FromArgb(169, 148, 129);
                            break;
                        case "20":
                            e.Appearance.BackColor = Color.FromArgb(255, 223, 102);
                            break;
                        case "30":
                            e.Appearance.BackColor = Color.FromArgb(158, 219, 149);
                            break;
                        case "40":
                            e.Appearance.BackColor = Color.FromArgb(59, 125, 164);
                            break;
                        case "50":
                            e.Appearance.BackColor = Color.FromArgb(255, 223, 102);
                            break;
                        case "70":
                            e.Appearance.BackColor = Color.FromArgb(158, 158, 158);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            var gridview = (GridView)grd_arribo.FocusedView;
            var row = (dSTtracer.panelarriboRow)gridview.GetFocusedDataRow();
            int IDArribDetalle = row.id;
            
            TT_Arribo_Asociar tt = new TT_Arribo_Asociar(IDArribDetalle,row.codigoGen, row.ItemCode, row.ItemName, row.CardName, row.CardCode, row.fechadearrib, row.Cantidad, row.enable,row.Estatus,row.Comentario
                ,row.idvehi, row.granel ,row.type, row.Idunidad);
            if (tt.ShowDialog() == DialogResult.OK)
            {
                load_dataselect();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            var gridview = (GridView)grd_arribo.FocusedView;
            var row = (dSTtracer.panelarriboRow)gridview.GetFocusedDataRow();
            if (row.Estatus >= 40)
            {
                MessageBox.Show("El proceso de este arribo esta muy avanzado para cancelarlo. Cambie el estado antes para hacerlo.");
                return;
            }
            else
            {
                if (MessageBox.Show("Seguro que quieres cancelar la planificacion de este arribo?", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string Query;
                    Query = @"UPDATE [dbo].[DC_workplan_d]
                            SET 
                                [enable] = 1
                                , [status] = 70
    
                            WHERE id = " + row.id;
                    dp.ACS_DoSmallDBOperationBas(Query);
                    load_dataselect();
                }
                else
                {
                    return;
                }
            }
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TT_SeleccionarPlan plan = new TT_SeleccionarPlan();
            if (plan.ShowDialog() == DialogResult.OK)
            {
                IdSelected = plan.IdSelected;
            btnorden.Enabled = true;
            Btnload.Enabled = true;
            load_dataselect();
            }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var gridview = (GridView)grd_arribo.FocusedView;
            var row = (dSTtracer.panelarriboRow)gridview.GetFocusedDataRow();
            if (row.Estatus == 30)
            {
                int Isprinted = 0;
                query = @"SELECT  [printed]
                          FROM [dbo].[DC_workplan_d]
                          WHERE id = @read";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.Parameters.Add("@read", SqlDbType.Int).Value = row.id;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr[0].ToString() == "True")
                        {
                            Isprinted = 1;
                        }
                        else
                        {
                            Isprinted = 0;
                        }
                    }
                    else
                    {
                        Isprinted = 0;
                    }
                    dr.Close();
                    cn.Close();
                }
                catch (Exception ex )
                {

                    CajaDialogo.Error("Error en validar si ya fue impreso.");
                    return;
                }
               
                TTR_Arribo_Doc dac = new TTR_Arribo_Doc(row.id);
                dac.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(dac);
                printReport.ShowPreview();
                if (Isprinted == 1)
                {
                    //nada

                }
                else
                {//actualizar print
                    try
                    {
                        cn.Open();
                        query = @"UPDATE [dbo].[DC_workplan_d]
                                   SET 
                                     [printed] = 1
                                 WHERE id= @id";
                        SqlCommand Comando = new SqlCommand(query, cn);
                        Comando.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        Comando.ExecuteNonQuery();
                        cn.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error("Error en la actualizacion de data. " + ex.Message);
                    }



                }
            }
            else
            {
                MessageBox.Show("Para imprimir la hoja del arribo debe configurar primero un vehiculo de entrada.");
            }

        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_dataselectwhitouPlan();
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TT_addetails nuevo = new TT_addetails();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                load_dataselectwhitouPlan();

            }
        }

        private void grd_arribo_Click(object sender, EventArgs e)
        {

        }

        private void btnproductoterminado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TT_addpt pt = new TT_addpt(usercode);
            if (pt.ShowDialog() == DialogResult.OK)
            {
                load_dataselectwhitouPlan();
            }
        }
        //query = @"exec CPS_Seleccion_Order";
        //    DataOperations dp = new DataOperations();
        //grd_odoo_oc.DataSource = dp.SAP_GetSelectData(query).Tables[0];


    }
}
