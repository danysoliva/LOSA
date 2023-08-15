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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.MigracionACS.Produccion.Consumos;
using DevExpress.XtraReports.UI;
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion.Consumos

{
    public partial class IntakeBatchViewerFull : DevExpress.XtraEditors.XtraForm
    {
        //FMOP fmop = new FMOP();
        DataOperations dp = new DataOperations();
        LotePT LoteActual;
        Int64 OrderIdBalanceMasa;

        enum TipoBusqueda
        {
            Ninguna  = 0,
            PorOrden = 1,
            PorLote  = 2,
            PorLista = 3
        }

        TipoBusqueda TipoBusquedaActual = TipoBusqueda.Ninguna;
        int max_id = 0;

        //private void Load_data() 
        //{
        //    try
        //    {
        //        #region Old Query

        //        string query = @"   SELECT Consumos.[id] AS 'ID'
	       //                             ,Consumos.[order_code] AS 'Orden Producción'
	       //                             ,Consumos.[product_code] AS 'Código PT'
	       //                             ,Consumos.[product_name] AS 'Producto'
	       //                             ,Consumos.[lot_number] AS 'Numero Lote'
	       //                             ,(CASE Consumos.[mix] WHEN 1 THEN 'Mix #1' ELSE 'Mix #2' END) AS 'Mix'
	       //                             ,Consumos.[bin_code] AS 'Código BIN'
	       //                             ,Consumos.[bin_name] AS 'Nombre BIN'
	       //                             ,Consumos.[material_code] AS 'Cod. Material'
	       //                             ,Consumos.[material_name] AS 'Material'
	       //                             ,(CASE Consumos.[intake_type] WHEN 'RM' THEN 'Materia Prima' WHEN 'NC' THEN 'Núcleo' WHEN 'SFP' THEN 'Pre-Mezcla' WHEN 'FP' THEN 'Producto Terminado' ELSE 'N/A' END) AS Tipo
	       //                             ,Consumos.[intake_plan] AS 'Planificado'
	       //                             ,Consumos.[intake_real] AS 'Real'
	       //                             ,Consumos.[batch_start] AS 'Registrado'
        //                        FROM
        //                        (SELECT A.[id]
        //                                --,A.[order_id]
        //                                            ,B.[order_code]
        //                                            ,C.[code] AS 'product_code'
        //                                            ,C.[long_name] AS 'product_name'
        //                                            ,B.[fp_lot_number] AS 'lot_number'
        //                                --,A.[order_mix_id]
        //                                            ,D.[mix_fullCode] AS 'order_mix_code'
        //                                --,A.[material_id]
        //                                            ,E.[code] AS 'material_code'
        //                                            ,E.[long_name] AS 'material_name'
        //                                --,A.[bin_id]
        //                                            ,F.[code] AS 'bin_code'
        //                                --,A.[bin_codes]
        //                                            ,F.[long_name] AS 'bin_name'
        //                                --,A.[lot_id]
        //                                ,A.[intake_type]
        //                                --,A.[batch_no]
        //                                ,A.[intake_plan]
        //                                ,A.[intake_real]
        //                                ,A.[mix]
        //                                --,A.[logged_user]
        //                                ,A.[batch_start]
        //                                ,A.[batch_end]
        //                            FROM [APMS].[dbo].[OP_Batch_Intake_Data_RM] A
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main] B
        //                                        ON A.[order_id] = B.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Finished_Products] C
        //                                        ON B.[fp_id] = C.[id]
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main_Mix] D
        //                                        ON A.[order_mix_id] = D.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Raw_Material] E
        //                                        ON A.[material_id] = E.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Bins] F
        //                                        ON A.[bin_id] = F.[id]
        //                        WHERE A.[intake_plan] <> 0
        //                        AND [intake_type] = 'RM'
        //                        --AND A.id > 2296

        //                        UNION ALL

        //                        SELECT A.[id]
        //                                --,A.[order_id]
        //                                            ,B.[order_code]
        //                                            ,C.[code] AS 'product_code'
        //                                            ,C.[long_name] AS 'product_name'
        //                                            ,B.[fp_lot_number] AS 'lot_number'
        //                                --,A.[order_mix_id]
        //                                            ,D.[mix_fullCode] AS 'order_mix_code'
        //                                --,A.[material_id]
        //                                            ,E.[nc_code] AS 'material_code'
        //                                            ,E.[nc_name] AS 'material_name'
        //                                --,A.[bin_id]
        //                                            ,F.[code] AS 'bin_code'
        //                                --,A.[bin_codes]
        //                                            ,F.[long_name] AS 'bin_name'
        //                                --,A.[lot_id]
        //                                ,A.[intake_type]
        //                                --,A.[batch_no]
        //                                ,A.[intake_plan]
        //                                ,A.[intake_real]
        //                                ,A.[mix]
        //                                --,A.[logged_user]
        //                                ,A.[batch_start]
        //                                ,A.[batch_end]
        //                            FROM [APMS].[dbo].[OP_Batch_Intake_Data_RM] A
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main] B
        //                                        ON A.[order_id] = B.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Finished_Products] C
        //                                        ON B.[fp_id] = C.[id]
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main_Mix] D
        //                                        ON A.[order_mix_id] = D.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_NC_Main] E
        //                                        ON A.[material_id] = E.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Bins] F
        //                                        ON A.[bin_id] = F.[id]
        //                        WHERE A.[intake_plan] <> 0
        //                        AND [intake_type] = 'NC'
        //                        --AND A.id > 2296

        //                        UNION ALL

        //                        SELECT A.[id]
        //                                --,A.[order_id]
        //                                            ,B.[order_code]
        //                                            ,C.[code] AS 'product_code'
        //                                            ,C.[long_name] AS 'product_name'
        //                                            ,B.[fp_lot_number] AS 'lot_number'
        //                                --,A.[order_mix_id]
        //                                            ,D.[mix_fullCode] AS 'order_mix_code'
        //                                --,A.[material_id]
        //                                            ,E.[fp_lot_number] AS 'material_code'
        //                                            ,E.[mix_fullCode] AS 'material_name'
        //                                --,A.[bin_id]
        //                                            ,F.[code] AS 'bin_code'
        //                                --,A.[bin_codes]
        //                                            ,F.[long_name] AS 'bin_name'
        //                                --,A.[lot_id]
        //                                ,A.[intake_type]
        //                                --,A.[batch_no]
        //                                ,A.[intake_plan]
        //                                ,A.[intake_real]
        //                                ,A.[mix]
        //                                --,A.[logged_user]
        //                                ,A.[batch_start]
        //                                ,A.[batch_end]
        //                            FROM [APMS].[dbo].[OP_Batch_Intake_Data_RM] A
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main] B
        //                                        ON A.[order_id] = B.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Finished_Products] C
        //                                        ON B.[fp_id] = C.[id]
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main_Mix] D
        //                                        ON A.[order_mix_id] = D.[id]
        //                        INNER JOIN [APMS].[dbo].[OP_Production_Orders_Main_Mix] E
        //                                        ON A.[material_id] = E.[id]
        //                        INNER JOIN [APMS].[dbo].[MD_Bins] F
        //                                        ON A.[bin_id] = F.[id]
        //                        WHERE A.[intake_plan] <> 0
        //                        AND [intake_type] = 'SFP'
        //                        --AND A.id > 2296
        //                        ) Consumos  ";

        //        if (radioGroup1.SelectedIndex == 0) 
        //        {
        //            query += @" WHERE Consumos.[order_code] = '" + txt_OrderCode2.Text + @"'
        //                        ORDER BY Consumos.[id]";
        //        }
        //        #endregion

        //        if (radioGroup1.SelectedIndex == 0) 
        //        {
        //            string orderCode = "PP-";

        //            // Amigo, este switch de abajo pudo ser así tambien: 
        //            // orderCode += txt_OrderCode.Text.Trim().PadLeft(7, '0');
        //            switch (txt_OrderCode2.Text.Length) 
        //            {
        //                case 0:
        //                    orderCode += "0000000";
        //                    break;
        //                case 1:
        //                    orderCode += "000000" + txt_OrderCode2.Text;
        //                    break;
        //                case 2:
        //                    orderCode += "00000" + txt_OrderCode2.Text;
        //                    break;
        //                case 3:
        //                    orderCode += "0000" + txt_OrderCode2.Text;
        //                    break;
        //                case 4:
        //                    orderCode += "000" + txt_OrderCode2.Text;
        //                    break;
        //                case 5:
        //                    orderCode += "00" + txt_OrderCode2.Text;
        //                    break;
        //                case 6:
        //                    orderCode += "0" + txt_OrderCode2.Text;
        //                    break;
        //                case 7:
        //                    orderCode += txt_OrderCode2.Text;
        //                    break;
        //                default:
        //                    orderCode += txt_OrderCode2.Text;
        //                    break;
        //            }


        //            SqlCommand command = new SqlCommand();
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@order_number", int.Parse(txt_OrderCode2.Text.ToString()));

        //            grd_data.DataSource = dp.APMS_Exec_SP_Get_Data("RPT_Batch_Intake_Data_OrderCode", command);   
        //        }
        //        else if (radioGroup1.SelectedIndex == 1)
        //        {
        //            SqlCommand command = new SqlCommand();
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@start_date", dt_desde.EditValue);
        //            command.Parameters.AddWithValue("@end_date", dt_hasta.EditValue);

        //            grd_data.DataSource = dp.APMS_Exec_SP_Get_Data("RPT_Batch_Intake_Data_Date", command);
        //        }
        //    }
        //    catch (Exception)
        //    { throw; }
        //}

        public IntakeBatchViewerFull(UserLogin userLogin)
        {
            InitializeComponent();



            #region Screen Selection
            if (Screen.AllScreens.Count() > 1)
            {
                switch (Screen.AllScreens.Count())
                {
                    case 2:
                        this.Location = Screen.AllScreens[1].WorkingArea.Location;
                        break;
                    case 3:
                        this.Location = Screen.AllScreens[2].WorkingArea.Location;
                        break;
                    case 4:
                        this.Location = Screen.AllScreens[3].WorkingArea.Location;
                        break;
                    case 5:
                        this.Location = Screen.AllScreens[4].WorkingArea.Location;
                        break;
                    case 6://Configuración Actual Consola
                        this.Location = Screen.AllScreens[5].WorkingArea.Location;
                        break;
                }
            }

            #endregion




        }

        public IntakeBatchViewerFull()
        {
            InitializeComponent();

            #region Screen Selection
            if (Screen.AllScreens.Count() > 1)
            {
                switch (Screen.AllScreens.Count())
                {
                    case 2:
                        this.Location = Screen.AllScreens[1].WorkingArea.Location;
                        break;
                    case 3:
                        this.Location = Screen.AllScreens[2].WorkingArea.Location;
                        break;
                    case 4:
                        this.Location = Screen.AllScreens[3].WorkingArea.Location;
                        break;
                    case 5:
                        this.Location = Screen.AllScreens[4].WorkingArea.Location;
                        break;
                    case 6://Configuración Actual Consola
                        this.Location = Screen.AllScreens[5].WorkingArea.Location;
                        break;
                }
            }

            #endregion

        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void IntakeViewer_Load(object sender, EventArgs e)
        {
            try
            {
                radioGroup1_SelectedIndexChanged(sender, e);
                max_id = int.Parse(dp.APMS_GetSelectData(@"SELECT MAX([id]) FROM [dbo].[OP_Batch_Intake_Data_RM]").Tables[0].Rows[0][0].ToString());
                txt_status.Caption = "Detenido";
                txt_status.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message);  }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Load_data();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer.Enabled = true;
            timer.Start();

            txt_status.Caption = "Iniciado";
            txt_status.Appearance.ForeColor = Color.Green;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
            txt_status.Caption = "Detenido";
            txt_status.Appearance.ForeColor = Color.Red;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IntakeViewer_Load(sender, e);
            timer_Tick(sender, e);
        }

        private void grdv_data_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e)
        {
            GridView View = sender as GridView;
            GridColumn column = View.GroupedColumns[e.Level];
            if (column == null) return;
            e.LevelAppearance.Combine(column.AppearanceHeader);
        }

        private void btn_generate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (radioGroup1.SelectedIndex == 0)
            //{
            //    barButtonItem2_ItemClick(sender, e);
            //}
            //Load_data();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (radioGroup1.SelectedIndex == 0)
            //{
            //    txt_OrderCode2.Enabled = true;
            //    panel_date.Enabled = false;
            //    btn_start.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //    btn_stop.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //}
            //else 
            //{
            //    txt_OrderCode2.Enabled = false;
            //    panel_date.Enabled = true;
            //    btn_start.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //    btn_stop.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //  (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtCodeOrder_KeyDown(object sender, KeyEventArgs e)
        {
            string pcode = "";
            if (e.KeyCode == Keys.Enter)
            {
                switch (txtCodeOrder.Text.Length)
                {
                    case 0:
                        pcode += "0000000";
                        break;
                    case 1:
                        pcode += "000000" + txtCodeOrder.Text;
                        break;
                    case 2:
                        pcode += "00000" + txtCodeOrder.Text;
                        break;
                    case 3:
                        pcode += "0000" + txtCodeOrder.Text;
                        break;
                    case 4:
                        pcode += "000" + txtCodeOrder.Text;
                        break;
                    case 5:
                        pcode += "00" + txtCodeOrder.Text;
                        break;
                    case 6:
                        pcode += "0" + txtCodeOrder.Text;
                        break;
                    case 7:
                    default:
                        pcode += txtCodeOrder.Text;
                        break;
                }
                if(pcode.Length<10)
                    pcode = "PP-" + pcode;
                txtCodeOrder.Text = pcode;
                txtLote.ReadOnly = txtCodeOrder.ReadOnly = true;
                
                //txtOrderId_APMS.Text = pcode;
                TipoBusquedaActual = TipoBusqueda.PorOrden;
                BuscarLotOrder();
            }
        }

        private void BuscarLotOrder()
        {
            int opcion = 0;
            if (!string.IsNullOrEmpty(txtLote.Text))
            {
                TipoBusquedaActual = TipoBusqueda.PorLote;
                if (LoteActual == null)
                    LoteActual = new LotePT();

                LoteActual.LotePT_Num = Convert.ToInt32(txtLote.Text);
                opcion = 1;
            }
            //else
            //{
            //    return;
            //}

            if (!string.IsNullOrEmpty(txtCodeOrder.Text))
            {
                opcion = 2;
                TipoBusquedaActual = TipoBusqueda.PorOrden;
            }

            switch(opcion)
            {
                case 1://Busqueda por Lote
                case 2://Busqueda por Lote
                    LotePT ptProducido = new LotePT();
                    if (LoteActual == null)
                        LoteActual = new LotePT();
                    if (ptProducido.RecuperarRegistro(LoteActual.LotePT_Num, txtCodeOrder.Text))
                    {
                        LoteActual = ptProducido;
                        txtPresentacion.Text = ptProducido.DescripcionPresentacion;
                        txtOrderId_APMS.Text = ptProducido.OrderId_prd.ToString();
                        txtProducto.Text = ptProducido.DescripcionProducto;
                        txtLote.Text = ptProducido.LotePT_Num.ToString();
                        if (TipoBusquedaActual == TipoBusqueda.PorLote)
                            txtCodeOrder.Text = ptProducido.OrderCodePP;
                    }

                    string sql_h = @"[dbo].[RPT_PRD_Trazabilidad_header_lote]";

                    SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);

                    try
                    {
                        cn.Open();
                        SqlCommand cmd_h = new SqlCommand(sql_h, cn);
                        cmd_h.CommandType = CommandType.StoredProcedure;
                        cmd_h.Parameters.AddWithValue("@num_lote", txtLote.Text);
                        SqlDataReader dr_h = cmd_h.ExecuteReader();

                        Int64 AcsId = 0;
                        if (dr_h.Read())
                        {
                            txtcodigo.Text = dr_h.GetString(0);
                            txtProducto.Text = dr_h.GetString(1);
                            txtformula.Text = dr_h.GetInt32(3).ToString();
                            txtversion.Text = dr_h.GetInt32(4).ToString();
                            txtCodeSAP.Text = dr_h.GetString(6);
                        }
                        dr_h.Close();
                    }
                    catch (Exception EX)
                    {
                        //CajaDialogo.Error(EX.Message);
                        MessageBox.Show("Error: "+ EX.Message);
                    }
                //    break;
                //case 2://Busqueda por Orden

                    break;
                case 0:
                default:
                    cmdListado_Click(new object(), new EventArgs());
                    break;
            }//End switch

            if(LoteActual!= null)
                LoadDetalles(LoteActual.OrderId_prd);
        }

        private void LoadDetalles(Int64 porder_id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd_h = new SqlCommand("[RPT_Batch_Intake_Data_OrderCode_intakefull]", cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@order_number", porder_id);
                dsIntakeReportsPRD1.IntakeViewTableBatch.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd_h);
                adat.Fill(dsIntakeReportsPRD1.IntakeViewTableBatch);

                cmd_h = new SqlCommand("[RPT_Batch_Intake_Data_OrderCode_intake]", cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@order_number", porder_id);
                dsIntakeReportsPRD1.IntakeViewTableBatchMP.Clear();
                adat = new SqlDataAdapter(cmd_h);
                adat.Fill(dsIntakeReportsPRD1.IntakeViewTableBatchMP);

                cn.Close();
            }
            catch (Exception EX)
            {
                //CajaDialogo.Error(EX.Message);
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            //Abrir la ventana
            frmsearchOrder frm = new frmsearchOrder();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                txtLote.Text = frm.LotePT.ToString();
                BuscarLotOrder();
            }
        }

        private void txtLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TipoBusquedaActual = TipoBusqueda.PorLote;
                txtLote.ReadOnly = txtCodeOrder.ReadOnly = true;
                if (LoteActual == null)
                    LoteActual = new LotePT();
                LoteActual.LotePT_Num = Convert.ToInt32(txtLote.Text);
                BuscarLotOrder();
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarLotOrder();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dsIntakeReportsPRD1.IntakeViewTableBatch.Clear();
            dsIntakeReportsPRD1.IntakeViewTableBatchMP.Clear();
            txtLote.ReadOnly = txtCodeOrder.ReadOnly = false;
            LoteActual = new LotePT();
            txtCodeOrder.Text =
            txtPresentacion.Text =
            txtOrderId_APMS.Text =
            txtProducto.Text =
            txtLote.Text =
            txtcodigo.Text =
            txtProducto.Text =
            txtformula.Text =
            txtversion.Text =
            txtCodeSAP.Text = "";
            txtCodeOrder.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            switch (xtraTabControl_Lines.SelectedTabPageIndex)
            {   
                case 0://Por batch
                default:
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog.FilterIndex = 0;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        gridControl1.ExportToXlsx(dialog.FileName);
                    break;
                case 1://por mp
                    SaveFileDialog dialog2 = new SaveFileDialog();
                    dialog2.Filter = "Excel File (.xlsx)|*.xlsx";
                    dialog2.FilterIndex = 0;

                    if (dialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        gridControl2.ExportToXlsx(dialog2.FileName);
                    break;
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsIntakeReportsPRD.IntakeViewTableBatchRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.id < 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(153, 255, 153);//verde
                        //e.Appearance.BackColor = Color.FromArgb(204, 153, 255);//morado
                        //e.Appearance.BackColor = Color.FromArgb(102, 178, 255);//Azul
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var gridView = (GridView)gridControl2.FocusedView;
                //var row = (dsNotas.notas_resumenRow)gridView.GetFocusedDataRow();
                var row = (dsIntakeReportsPRD.IntakeViewTableBatchMPRow)gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    if (row.id < 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(153, 255, 153);//verde
                        //e.Appearance.BackColor = Color.FromArgb(204, 153, 255);//morado
                        //e.Appearance.BackColor = Color.FromArgb(102, 178, 255);//Azul
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }

        private void cmdBuscarporFechas_Click(object sender, EventArgs e)
        {
            if(dp.ValidateStringIsNullOrEmpty(dtDesde.Text) || dp.ValidateStringIsNullOrEmpty(dtDesde.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la fecha desde y hasta!");
                dtDesde.Focus();
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd_h = new SqlCommand("[RPT_Batch_Intake_Data_OrderCode_intakefull_by_dates]", cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd_h.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsIntakeReportsPRD1.IntakeViewTableBatch_byDates.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd_h);
                adat.Fill(dsIntakeReportsPRD1.IntakeViewTableBatch_byDates);

                cn.Close();
            }
            catch (Exception EX)
            {
                //CajaDialogo.Error(EX.Message);
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl3.ExportToXlsx(dialog.FileName);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            switch (xtraTabControl_Lines.SelectedTabPageIndex)
            {
                case 0://Por batch
                default:
                    rpt_resumen_consumo_by_batch_and_MP rpt = new rpt_resumen_consumo_by_batch_and_MP(txtCodeOrder.Text,
                                                                                              txtLote.Text,
                                                                                              txtProducto.Text,
                                                                                              txtPresentacion.Text,
                                                                                              txtcodigo.Text,
                                                                                              txtformula.Text,
                                                                                              txtversion.Text,
                                                                                              txtOrderId_APMS.Text)
                    { DataSource = dsIntakeReportsPRD1, DataMember = "IntakeViewTableBatch" };
                    rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(rpt);
                    printReport.ShowPreview();
                    break;
                case 1://por mp
                    dsIntakeReportsPRD datasetMP = new dsIntakeReportsPRD();

                    foreach (dsIntakeReportsPRD.IntakeViewTableBatchMPRow row in dsIntakeReportsPRD1.IntakeViewTableBatchMP.Rows)
                    {
                        dsIntakeReportsPRD.IntakeViewTableBatchRow row1 = datasetMP.IntakeViewTableBatch.NewIntakeViewTableBatchRow();
                        row1.id = row.id;
                        row1.production_order = row.production_order;
                        row1.batch_no = row.batch_no;
                        
                        //row1.batch_left = row.batch_left;
                        try
                        {
                            row1.batch_left = row.batch_left;
                        }
                        catch { row.batch_left = 0; }

                        row1.mix = row.mix;
                        //row1.bin_code = row.bin_code;
                        try
                        {
                            row1.bin_code = row.bin_code;
                        }
                        catch { row.bin_code = ""; }

                        //row1.bin_name = row.bin_name;
                        try
                        {
                            row1.bin_name = row.bin_name;
                        }
                        catch { row.bin_name = ""; }
                        //row1.material_code = row.material_code;
                        try
                        {
                            row1.material_code = row.material_code;
                        }
                        catch { row.material_code = ""; }
                        row1.material_name = row.material_name;
                        //row1.material_type = row.material_type;
                        try
                        {
                            row1.material_type = row.material_type;
                        }
                        catch { row.material_type = ""; }
                        row1.intake_plan = row.intake_plan;
                        row1.intake_real = row.intake_real;
                        row1.intake_diff = dp.ValidateNumberDecimal(row.intake_diff);
                        row1.intake_diff_per = row.intake_diff_per;
                        //row1.record_date = row.record_date;
                        try
                        {
                            row1.record_date = row.record_date;
                        }
                        catch { 
                            //row.record_date = DateTime.UtcNow; 
                        }
                        try
                        {
                            row1.order_b = row.order_b;
                        }
                        catch { row.order_b = 0; }
                        datasetMP.IntakeViewTableBatch.AddIntakeViewTableBatchRow(row1);
                        datasetMP.AcceptChanges();
                    }
                    

                    rpt_resumen_consumo_by_batch_and_MP rpt2 = new rpt_resumen_consumo_by_batch_and_MP(txtCodeOrder.Text,
                                                                                              txtLote.Text,
                                                                                              txtProducto.Text,
                                                                                              txtPresentacion.Text,
                                                                                              txtcodigo.Text,
                                                                                              txtformula.Text,
                                                                                              txtversion.Text,
                                                                                              txtOrderId_APMS.Text)
                    { DataSource = datasetMP, DataMember = "IntakeViewTableBatch" };
                    rpt2.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport2 = new ReportPrintTool(rpt2);
                    printReport2.ShowPreview();

                    break;
               
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
             dsIntakeReportsPRD datasetMP = new dsIntakeReportsPRD();

            foreach (dsIntakeReportsPRD.IntakeViewTableBatch_byDatesRow row in dsIntakeReportsPRD1.IntakeViewTableBatch_byDates.Rows)
            {
                dsIntakeReportsPRD.IntakeViewTableBatchRow row1 = datasetMP.IntakeViewTableBatch.NewIntakeViewTableBatchRow();
                row1.id = row.id;
                row1.production_order = row.production_order;
                row1.batch_no = row.batch_no;

                //row1.batch_left = row.batch_left;
                try
                {
                    row1.batch_left = row.batch_left;
                }
                catch { row.batch_left = 0; }

                row1.mix = row.mix;
                //row1.bin_code = row.bin_code;
                try
                {
                    row1.bin_code = row.bin_code;
                }
                catch { row.bin_code = ""; }

                //row1.bin_name = row.bin_name;
                try
                {
                    row1.bin_name = row.bin_name;
                }
                catch { row.bin_name = ""; }
                //row1.material_code = row.material_code;
                try
                {
                    row1.material_code = row.material_code;
                }
                catch { row.material_code = ""; }
                row1.material_name = row.material_name;
                //row1.material_type = row.material_type;
                try
                {
                    row1.material_type = row.material_type;
                }
                catch { row.material_type = ""; }
                row1.intake_plan = row.intake_plan;
                row1.intake_real = row.intake_real;
                row1.intake_diff = dp.ValidateNumberDecimal(row.intake_diff);
                row1.intake_diff_per = row.intake_diff_per;
                //row1.record_date = row.record_date;
                try
                {
                    row1.record_date = row.record_date;
                }
                catch
                {
                    //row.record_date = DateTime.UtcNow; 
                }
                try
                {
                    row1.order_b = row.order_b;
                }
                catch { row.order_b = 0; }
                datasetMP.IntakeViewTableBatch.AddIntakeViewTableBatchRow(row1);
                datasetMP.AcceptChanges();
            }


            rpt_resumen_consumo_by_batch_and_MP rpt2 = new rpt_resumen_consumo_by_batch_and_MP(txtCodeOrder.Text,
                                                                                      txtLote.Text,
                                                                                      txtProducto.Text,
                                                                                      txtPresentacion.Text,
                                                                                      txtcodigo.Text,
                                                                                      txtformula.Text,
                                                                                      txtversion.Text,
                                                                                      txtOrderId_APMS.Text)
            { DataSource = datasetMP, DataMember = "IntakeViewTableBatch" };
            rpt2.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport2 = new ReportPrintTool(rpt2);
            printReport2.ShowPreview();
            
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                gridControl4.ExportToXlsx(dialog.FileName);
        }

        private void txtLotePtBalanceMasa_EditValueChanged(object sender, EventArgs e)
        {
            LoadHeader();
        }

        private void LoadHeader()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd_h = new SqlCommand("sp_get_header_balance_masa_prd", cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@lotept", txtLotePtBalanceMasa.EditValue);
                SqlDataReader dr = cmd_h.ExecuteReader();
                if (dr.Read())
                {
                    errorProvider1.Clear();
                    OrderIdBalanceMasa = dr.GetInt64(0);
                    txtOrderIdBalanceMasa.Text = OrderIdBalanceMasa.ToString();
                    dtDesdeBalanceMasa.EditValue = dr.GetDateTime(1);
                    dtHastaBalanceMasa.EditValue = dr.GetDateTime(2);
                    txtCantBatchBalanceMasa.Text = dr.GetInt32(3).ToString();
                    txtOrderCodePP_BalanceMasa.Text = dr.GetString(4);

                    LotePT ptProducido = new LotePT();
                    if (ptProducido.RecuperarRegistro(Convert.ToInt32(txtLotePtBalanceMasa.EditValue)))
                    {
                        //Presentacion pres1 = new Presentacion();
                        LoteActual = ptProducido;
                        txtSacosLiberados.Text = string.Format("{0:###,##0 Sacos}", ptProducido.Unidades);
                        txtTotalKgBalanceMasaPT.Text = string.Format("{0:###,##0.00 Kg}", ptProducido.TotalKg);
                    }
                    LoadDetalleLote(OrderIdBalanceMasa);
                }
                else
                {
                    errorProvider1.SetError(txtLotePtBalanceMasa, "No se encontro este lote de Producto Terminado!");
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception EX)
            {
                //CajaDialogo.Error(EX.Message);
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        private void LoadDetalleLote(Int64 pOrderId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd_h = new SqlCommand("sp_get_detalle_balance_masa_prd", cn);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@order_id", pOrderId);
                dsIntakeReportsPRD1.balance_masa_detalle.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd_h);
                adat.Fill(dsIntakeReportsPRD1.balance_masa_detalle);
                cn.Close();
            }
            catch (Exception EX)
            {
                //CajaDialogo.Error(EX.Message);
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        private void spinEditLotePT_BalanceMasa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadHeader();
            }
        }

        private void txtLotePtBalanceMasa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadHeader();
            }
        }
    }
}