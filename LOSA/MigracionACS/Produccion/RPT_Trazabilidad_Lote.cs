using ACS.Classes;
using LOSA.MigracionACS.Produccion.DataSet_;
using DevExpress.XtraReports.UI;
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
using LOSA.MigracionACS.RPTS.PRD;

namespace ACS.Produccion
{
    public partial class RPT_Trazabilidad_Lote : Form
    {
        public RPT_Trazabilidad_Lote()
        {
            InitializeComponent();
            TipoBusquedaActual = TipoBusqueda.Lote;
            tabFiltros.TabPages.Clear();
            tabFiltros.TabPages.Add(tabLote);
        }
        int ID_Formula;

        public enum TipoBusqueda
        {
            Lote = 0,
            OP = 1,
            Fechas = 2
        }

        TipoBusqueda TipoBusquedaActual = TipoBusqueda.Lote;
        private void cmdBusquedaLote_Click(object sender, EventArgs e)
        {
            cmdBusquedaLote.Appearance.BackColor = Color.SteelBlue;
            cmdBusquedaOP.Appearance.BackColor = Color.White;
            cmdBusquedaRangoFechas.Appearance.BackColor = Color.White;
            TipoBusquedaActual = TipoBusqueda.Lote;
            tabFiltros.TabPages.Clear();
            tabFiltros.TabPages.Add(tabLote);
        }

        private void cmdBusquedaOP_Click(object sender, EventArgs e)
        {
            cmdBusquedaLote.Appearance.BackColor = Color.White;
            cmdBusquedaOP.Appearance.BackColor = Color.SteelBlue;
            cmdBusquedaRangoFechas.Appearance.BackColor = Color.White;
            TipoBusquedaActual = TipoBusqueda.OP;
            tabFiltros.TabPages.Clear();
            tabFiltros.TabPages.Add(tabOP);
        }

        private void cmdBusquedaRangoFechas_Click(object sender, EventArgs e)
        {
            cmdBusquedaLote.Appearance.BackColor = Color.White;
            cmdBusquedaOP.Appearance.BackColor = Color.White;
            cmdBusquedaRangoFechas.Appearance.BackColor = Color.SteelBlue;
            TipoBusquedaActual = TipoBusqueda.Fechas;
            tabFiltros.TabPages.Clear();
            tabFiltros.TabPages.Add(tabRango);
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroLote.Text = "";
            txtNumeroLote.Focus();
        }

        private void txtNumeroLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringAPMS);
                Conn.Open();

                SqlConnection Conn2 = new SqlConnection(dp.ConnectionStringCostos);
                Conn2.Open();
                
                //string sql = @" EXEC [dbo].[RPT_trasabilidad_lote_produccion] @id_lote = " + txtNumeroLote.Text;
                string sql_h = "EXEC [dbo].[RPT_PRD_Trazabilidad_header_lote] @num_lote = " + txtNumeroLote.Text;
                SqlCommand cmd_h = new SqlCommand(sql_h, Conn);
                SqlDataReader dr_h = cmd_h.ExecuteReader();

                Int64 AcsId = 0;
                if (dr_h.Read())
                {
                    txtProductoTerminado.Text = dr_h.GetString(0);
                    txtNombreProductoTerminado.Text = dr_h.GetString(1);
                    txtNumeroOrden.Text = dr_h.GetString(2);
                    txtFormula.Text = dr_h.GetInt32(3).ToString();
                    txtVersion.Text = dr_h.GetInt32(4).ToString();
                    AcsId = dr_h.GetInt64(5);
                }
                dr_h.Close();


                int lote_x = 0;
                string sql_lote = @"SELECT [fp_lot_number]
                                    FROM [dbo].[OP_Production_Orders_Main]
                                    where order_code = '" + txtNumeroOrden.Text + "'";
                SqlCommand cmd = new SqlCommand(sql_lote, Conn);
                lote_x = Convert.ToInt32(cmd.ExecuteScalar());


                //string sql_d = @" EXEC [dbo].[RPT_PRD_detalle_trasabilidad_by_OP] @Numero_Orden = '" + txtNumeroOrden.Text + "'"; //Esta en ACS
                string sql_d = "";
                if (toggleSwitchOrigenData.IsOn)
                {
                    sql_d = @" EXEC [dbo].[RPT_PRD_Detalle_Consumos_Lote_kepserver] @lote = " + lote_x.ToString();//
                }
                else
                {
                    sql_d = @" EXEC [dbo].[RPT_PRD_Detalle_Consumos_Lote] @lote = " + lote_x.ToString();//
                }
                

                SqlDataAdapter adapter = new SqlDataAdapter(sql_d, Conn);
                dsReportesPRD1.detallito.Clear();
                adapter.Fill(dsReportesPRD1.detallito);


                //string sqlf = @"select top 1 real_batch
                //                  from
                //                  (
						          //  SELECT  cC.acs_id as acs_order_id, ('RM-'+ Cast(bB.rm_acs_id as varchar)) material_id_type, 
								        //    Count((aA.batch_no)) real_batch ,SUM(aA.intake_real) real_kg	-- antes habia un distinct.. no se ocupa, y estan malos los datos de batch_no
								        //    ,sum(aA.intake_real) as 'plan_kg'
						          //  FROM    
								        //    [dbo].[OP_Batch_Intake_Data_RM] aA
								        //    LEFT JOIN [dbo].[MD_Raw_Material] bB ON aA.material_id= bB.id AND aA.intake_type= 'RM'
								        //    LEFT JOIN [dbo].[OP_Production_Orders_Main] cC on aA.order_id= cC.id
						          //  WHERE   aA.intake_type= 'RM'
								        //    --AND aA.[batch_start] >= @fecha_desde AND aA.[batch_start]<= @fecha_hasta
						          //  group by cC.acs_id, ('RM-'+ Cast(bB.rm_acs_id as varchar))--,aA.intake_real
						          //  ) K  where k.acs_order_id = "+ AcsId.ToString() +
						          //  " order by k.real_batch desc";
                //SqlCommand cmd_f = new SqlCommand(sqlf, Conn);
                //SqlDataReader dr_f = cmd_f.ExecuteReader();
                //int r_total_batch_teorico_forzado = 0;
                //if (dr_f.Read())
                //{
                //    r_total_batch_teorico_forzado = dr_f.GetInt32(0);
                //}

                //foreach (dsTrazabilidad.detallitoRow row in dsTrazabilidad1.detallito.Rows)
                //{
                //    //if (row.tipe_meter == "T")
                //    //if (row.r_n_batch < r_total_batch_teorico_forzado)
                //    //{
                //    //    //if (row.r_kg_total == 0)
                //    //    {
                //    //        row.r_n_batch = r_total_batch_teorico_forzado;
                //    //        row.r_kg_batch = row.p_kg_batch;
                //    //        row.r_kg_total = r_total_batch_teorico_forzado * row.p_kg_batch;
                //    //    }
                //    //}
                //    //else
                //    {
                //        if (row.tipe_meter == "T")
                //        {
                //            row.r_n_batch = r_total_batch_teorico_forzado;
                //            row.r_kg_batch = row.p_kg_batch;
                //            row.r_kg_total = r_total_batch_teorico_forzado * row.p_kg_batch;
                //        }
                //    }
                //}

                Conn.Close();
                Conn2.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdCargarDatos_Click(sender, new EventArgs());
            }
        }

        private void RPT_Trazabilidad_Lote_Load(object sender, EventArgs e)
        {
            txtNumeroLote.Focus();
        }

        private void RPT_Trazabilidad_Lote_Activated(object sender, EventArgs e)
        {
            txtNumeroLote.Focus();
        }

        private void cmdBorrarOP_Click(object sender, EventArgs e)
        {
            txtNumOP.Text = "";
            txtNumOP.Focus();
        }

        private void cmdActualizarOP_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumOP.Text = txtNumOP.Text.ToUpper();
                DataOperations dp = new DataOperations();

                SqlConnection Conn = new SqlConnection(dp.ConnectionStringAPMS);
                Conn.Open();

                SqlConnection Conn2 = new SqlConnection(dp.ConnectionStringCostos);
                Conn2.Open();

                //string sql = @" EXEC [dbo].[RPT_trasabilidad_lote_produccion] @id_lote = " + txtNumeroLote.Text;
                string sql_h = "EXEC [dbo].[RPT_PRD_Trazabilidad_header_op] @num_op = '" + txtNumOP.Text + "'";
                SqlCommand cmd_h = new SqlCommand(sql_h, Conn);
                SqlDataReader dr_h = cmd_h.ExecuteReader();

                Int64 AcsId = 0;
                if (dr_h.Read())
                {
                    txtOP_CodProd_terminado.Text = dr_h.GetString(0);
                    txtOP_Prod_terminado_descripcion.Text = dr_h.GetString(1);
                    //txtNumeroOrden.Text = dr_h.GetString(2);
                    txtOP_FormulaCode.Text = dr_h.GetInt32(3).ToString();
                    txtOP_formula_version.Text = dr_h.GetInt32(4).ToString();
                    AcsId = dr_h.GetInt64(5);
                    txtOP_num_Lote.Text = dr_h.GetInt64(6).ToString();
                }
                dr_h.Close();



                string sql_d = @" EXEC [dbo].[RPT_PRD_detalle_trasabilidad_by_OP] @Numero_Orden = '" + txtNumOP.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql_d, Conn2);
                dsReportesPRD1.detallito.Clear();
                adapter.Fill(dsReportesPRD1.detallito);


                string sqlf = @"select top 1 real_batch
                                  from
                                  (
						            SELECT  cC.acs_id as acs_order_id, ('RM-'+ Cast(bB.rm_acs_id as varchar)) material_id_type, 
								            Count((aA.batch_no)) real_batch ,SUM(aA.intake_real) real_kg	-- antes habia un distinct.. no se ocupa, y estan malos los datos de batch_no
								            ,sum(aA.intake_real) as 'plan_kg'
						            FROM    
								            [dbo].[OP_Batch_Intake_Data_RM] aA
								            LEFT JOIN [dbo].[MD_Raw_Material] bB ON aA.material_id= bB.id AND aA.intake_type= 'RM'
								            LEFT JOIN [dbo].[OP_Production_Orders_Main] cC on aA.order_id= cC.id
						            WHERE   aA.intake_type= 'RM'
								            --AND aA.[batch_start] >= @fecha_desde AND aA.[batch_start]<= @fecha_hasta
						            group by cC.acs_id, ('RM-'+ Cast(bB.rm_acs_id as varchar))--,aA.intake_real
						            ) K  where k.acs_order_id = " + AcsId.ToString() +
                                    " order by k.real_batch desc";
                SqlCommand cmd_f = new SqlCommand(sqlf, Conn);
                SqlDataReader dr_f = cmd_f.ExecuteReader();
                int r_total_batch_teorico_forzado = 0;
                if (dr_f.Read())
                {
                    r_total_batch_teorico_forzado = dr_f.GetInt32(0);
                }

                foreach (dsTrazabilidad.detallitoRow row in dsReportesPRD1.detallito.Rows)
                {
                    //if (row.tipe_meter == "T")
                    //if (row.r_n_batch < r_total_batch_teorico_forzado)
                    //{
                    //    //if (row.r_kg_total == 0)
                    //    {
                    //        row.r_n_batch = r_total_batch_teorico_forzado;
                    //        row.r_kg_batch = row.p_kg_batch;
                    //        row.r_kg_total = r_total_batch_teorico_forzado * row.p_kg_batch;
                    //    }
                    //}
                    //else
                    {
                        if (row.tipe_meter == "T")
                        {
                            row.r_n_batch = r_total_batch_teorico_forzado;
                            row.r_kg_batch = row.p_kg_batch;
                            row.r_kg_total = r_total_batch_teorico_forzado * row.p_kg_batch;
                        }
                    }
                }

                Conn.Close();
                Conn2.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumOP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdActualizarOP_Click(new object(), new EventArgs());
        }

        private void txtNumOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtNumOP.Text = txtNumOP.Text.ToUpper();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            string especie = "N/D";
            string nombreFormula = "";
            string codigoI = "";
            string version = "";
            string CodigoFormulaG = "";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                string sql = @"SELECT [id_formula],
                                       ff.nombre,
	                                   cast(ff.codigo_i as varchar),
	                                   cast(ff.version as varchar),
	                                   cast(ff.codigo as varchar),
                                        (select cc.Descripcion
	                                            from Conf_Especies cc 
		                                        where cc.id = ff.especie)                                
                                  FROM [dbo].[PP_Plan_Ordenes] pp join 
                                       ACS.dbo.FML_Formulas_v2 ff on
	                                   pp.id_formula = ff.id
                                  where pp_code = '" + txtNumeroOrden.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID_Formula = dr.GetInt32(0);
                    nombreFormula = dr.GetString(1);
                    codigoI = dr.GetString(2);
                    version = dr.GetString(3);
                    CodigoFormulaG = dr.GetString(4);
                    especie = dr.GetString(5);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
            RPT_PRD_Formula_Local report = new RPT_PRD_Formula_Local(ID_Formula,
                                                                                        CodigoFormulaG,
                                                                                       codigoI,
                                                                                       version,
                                                                                       nombreFormula,
                                                                                       especie,
                                                                                       txtNumeroLote.Text);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }



      












        private void cmdImprimirByOP_Click(object sender, EventArgs e)
        {
            string especie = "N/D";
            string nombreFormula = "";
            string codigoI = "";
            string version = "";
            string CodigoFormulaG = "";
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                string sql = @"SELECT [id_formula],
                                       ff.nombre,
	                                   cast(ff.codigo_i as varchar),
	                                   cast(ff.version as varchar),
	                                   cast(ff.codigo as varchar),
                                        (select cc.Descripcion
	                                            from Conf_Especies cc 
		                                        where cc.id = ff.especie)                                
                                  FROM [dbo].[PP_Plan_Ordenes] pp join 
                                       ACS.dbo.FML_Formulas_v2 ff on
	                                   pp.id_formula = ff.id
                                  where pp_code = '" + txtNumOP.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID_Formula = dr.GetInt32(0);
                    nombreFormula = dr.GetString(1);
                    codigoI = dr.GetString(2);
                    version = dr.GetString(3);
                    CodigoFormulaG = dr.GetString(4);
                    especie = dr.GetString(5);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            RPT_PRD_Formula_Local report = new RPT_PRD_Formula_Local(ID_Formula,
                                                                                        CodigoFormulaG,
                                                                                       codigoI,
                                                                                       version,
                                                                                       nombreFormula,
                                                                                       especie,
                                                                                       txtNumeroLote.Text);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grDetalle.ExportToXlsx(dialog.FileName);
            }
        }
    }
}
