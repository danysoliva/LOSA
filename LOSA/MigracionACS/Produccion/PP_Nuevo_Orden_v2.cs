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
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Nuevo_Orden_v2 : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
                                                     

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;
        int FormulaId;
        string FormulaCode;
        string FormulaName;
        string PT_codigo;
        int PT_id;
        string PT_Name;
        int id_gestion_lote;
        int lote_fp;
        Globals.Especies vEspecieActual;

        public event EventHandler OnFinalizarPresionado;

        Double pesoBatch = 1;
        int bag_weight = 1;

        DataRow row;

        DateTime desde;
        DateTime hasta;

        int dsCount;

        public DataRow GetRow()
        {
            return row;
        }
      
        public void load_presentacion()
        {
            string query = @"sp_load_pt_bags";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion1.bags.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion1.bags);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_unidades_por_tarima()
        {
            string query = @"sp_load_unidades_por_tarima";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion1.unidades_tarima.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion1.unidades_tarima);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public PP_Nuevo_Orden_v2(string ActiveUserCode,
                                    string ActiveUserName,
                                    string FormAction,
                                    string ActiveUserType,
                                    DataRow row,
                                    DateTime desde,
                                    DateTime hasta,
                                    int cantDataSetRow,
                                    Globals.Especies pEspecie)
        {
            InitializeComponent();  

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
            this.row = row;
            this.desde = desde;
            this.hasta = hasta;
            this.dsCount = cantDataSetRow;
            this.vEspecieActual = pEspecie;

            if (pEspecie == Globals.Especies.Camaron)
                lblEspecie.Text = "Camarón";
            else
                lblEspecie.Text = "Tilapia";

            CargarFormulasEspecie();
            CargarProductoTerminadoEspecie();
        }


        void CargarProductoTerminadoEspecie()
        {
            try
            {
                string sql = @"sp_pp_nuevo_orden_cargar_producto_por_especie";

                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_especie", (int)vEspecieActual);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.producto_terminado.Clear();
                adat.Fill(dsProduccion1.producto_terminado);
                Conn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarFormulasEspecie()
        {
            try
            {
                string sql = @"sp_pp_nuevo_orden_cargar_formulas_especie";

                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_especie", (int)vEspecieActual);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.formulas.Clear();
                adat.Fill(dsProduccion1.formulas);
                Conn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_FormulaName_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = txt_FormulaName.Text;
        }

        private void txt_PTName_TextChanged(object sender, EventArgs e)
        {
            gridView2.FindFilterText = txt_PTName.Text;
        }
        static string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"123456789", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
        private string Get_Prod_Orden_Code()
        {
            string ProdPlan = "PP-ERROR";
            string newPP = dp.ACS_GetSelectData(string.Format(@"SELECT ((COUNT([id]) + 1) + {0}) AS New_ID FROM [dbo].[PP_Plan_Ordenes]", dsCount)).Tables[0].Rows[0][0].ToString();

            switch (newPP.Length)
            {
                case 1:
                    ProdPlan = "PP-000000" + newPP;
                    break;
                case 2:
                    ProdPlan = "PP-00000" + newPP;
                    break;
                case 3:
                    ProdPlan = "PP-0000" + newPP;
                    break;
                case 4:
                    ProdPlan = "PP-000" + newPP;
                    break;
                case 5:
                    ProdPlan = "PP-00" + newPP;
                    break;
                case 6:
                    ProdPlan = "PP-0" + newPP;
                    break;
                case 7:
                    ProdPlan = "PP-" + newPP;
                    break;
                default:
                    ProdPlan = "PP-" + newPP;
                    break;
            }

            return ProdPlan;
        }
        private string Get_Formula_Wincc_Code(string formulaID)
        {
            try
            {
                DataSet datos = dp.ACS_GetSelectData(@"   SELECT A.[codigo]
	                                                            ,B.[shortCode]
	                                                            ,A.[version]
                                                            FROM [dbo].[FML_Formulas_v2] A
                                                      INNER JOIN [dbo].[Conf_Especies] B
	                                                        ON A.[especie] = B.[id]
                                                            WHERE A.[id] = " + row["id_formula"].ToString() + "");
                string GenWinccCode = "";

                if (datos.Tables[0].Rows[0]["shortCode"].ToString().Length == 2)
                {
                    GenWinccCode += (datos.Tables[0].Rows[0]["shortCode"].ToString() + "-");
                }
                else
                {
                    GenWinccCode += (string.Format("E{0}-", datos.Tables[0].Rows[0]["shortCode"]));
                }

                switch (datos.Tables[0].Rows[0]["codigo"].ToString().Length)
                {
                    case 1:
                        GenWinccCode += (string.Format("000{0}-", datos.Tables[0].Rows[0]["codigo"]));
                        break;
                    case 2:
                        GenWinccCode += (string.Format("00{0}-", datos.Tables[0].Rows[0]["codigo"]));
                        break;
                    case 3:
                        GenWinccCode += (string.Format("0{0}-", datos.Tables[0].Rows[0]["codigo"]));
                        break;
                    case 4:
                        GenWinccCode += (datos.Tables[0].Rows[0]["codigo"].ToString() + "-");
                        break;
                    default:
                        GenWinccCode += (datos.Tables[0].Rows[0]["codigo"].ToString().Substring(0, 4) + "-");
                        break;
                }

                if (datos.Tables[0].Rows[0]["version"].ToString().Length == 2)
                {
                    GenWinccCode += (datos.Tables[0].Rows[0]["version"].ToString() + "-");
                }
                else
                {
                    GenWinccCode += (string.Format("0{0}-", datos.Tables[0].Rows[0]["version"]));
                }

                GenWinccCode += Get_Prod_Orden_Code().Substring(3, 7);

                return GenWinccCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var gridView = (GridView)grFormula.FocusedView;
            var row = (dsProduccion.formulasRow)gridView.GetFocusedDataRow();
            if (vEspecieActual == Globals.Especies.Camaron)
            {
                string text = CleanInput(row.descripcion);
                if (text.Length >= 8)
                    text = text.Substring(0, 8);

                txt_PTName.Text = text;
            }

            row.seleccionado = true;
            FormulaCode = row.codigo;
            FormulaName = row.descripcion;
            FormulaId = row.id;
            this.row["id_formula"] = row.id;
            this.row["code_formula"] = row.codigo;
            this.row["formula"] = row.descripcion;
            this.row["version_formula"] = row.version;
            this.row["code_wincc"] = Get_Formula_Wincc_Code(row.id.ToString());
            //this.row["version_formula"]
            foreach (dsProduccion.formulasRow dtRow in dsProduccion1.formulas.Rows)
            {
                if (dtRow.id != row.id)
                    dtRow.seleccionado = false;
            }
            dsProduccion1.AcceptChanges();
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            //Producto Terminado
            var gridView = (GridView)grProductoTerminado.FocusedView;
            var row = (dsProduccion.producto_terminadoRow)gridView.GetFocusedDataRow();

            row.seleccionado = true;
            PT_id = row.id;
            PT_codigo = row.codigo;
            PT_Name = row.descripcion;
            this.row["id_pt"] = row.id;
            this.row["code_pt"] = row.codigo;
            this.row["pt"] = row.descripcion;
            txt_PTCodigo.Text = row.codigo;

            foreach (dsProduccion.producto_terminadoRow dtRow in dsProduccion1.producto_terminado.Rows)
            {
                if (dtRow.id != row.id)
                    dtRow.seleccionado = false;
            }
            dsProduccion1.AcceptChanges();
        }

        private void btn_accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grd_presentacion.EditValue == null)
            {
                CajaDialogo.Error("Debe especificar la presentacion de la programacion de orden de produccion.");
                grd_presentacion.ShowPopup();
                return;
            }
            if (grd_udtm.EditValue == null)
            {
                CajaDialogo.Error("Debe especificar la cantidad de sacos que se asignan por la tarima.");
                grd_udtm.ShowPopup();
                return;
            }
            if (tgg_reservarlote.IsOn)
            {
                if (txtloteselec.Text == "")
                {
                    CajaDialogo.Error("Tiene seleccionada la casilla de lote reservado para esta orden, debe especificar el lote que se usara primero.");
                    return;
                }
            }
            int und = Convert.ToInt32(grd_udtm.EditValue);
            int unidades = 0;
            foreach (dsProduccion.unidades_tarimaRow row3 in dsProduccion1.unidades_tarima.Rows)
            {
                if (und == row3.id)
                {
                    unidades = row3.unidades;
                }

            }
            if (txt_OPNumero.Text != "")
            {
                //if (txt_FormulaCode.Text != "")
                if (FormulaName != "")
                {
                    //if (txt_PTCodigo.Text != "" && txt_PTName.Text != "")
                    if (!string.IsNullOrEmpty(PT_codigo) && !string.IsNullOrEmpty(PT_Name))
                    {
                        //if (cmb_ProductionLine.EditValue != null) 
                        if (lst_linea.SelectedValue != null)
                        {
                            //if (dt_produccion.EditValue != null)
                            //{
                            //if ((DateTime)dt_produccion.EditValue >= desde && (DateTime)dt_produccion.EditValue <= hasta)
                            //{
                            //if (MessageBox.Show(string.Format("¿Seguro que desea crear la Orden de Producción por {0}Kg.", txt_KgProduccion.Text), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                //int rmi = dp.get_inactive_rm(int.Parse(row["id_formula"].ToString()));
                                int rmi = dp.get_inactive_rm(FormulaId);

                                if (rmi > 0)
                                {
                                    if (MessageBox.Show(string.Format("Aparentemente esta formula tiene {0} materias primas o núcleos inactivos\n\n¿Seguro que desea incluirlo dentro del plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        row["code_op"] = txt_OPNumero.Text.ToString();
                                        row["kg_production"] = Convert.ToDouble(txt_KgProduccion.Text.ToString());
                                        row["cant_paradas"] = Convert.ToInt32(txt_Paradas.Text.ToString());
                                        row["date_prouction"] = DateTime.Now;
                                        row["priority"] = Convert.ToInt32(txt_prioridad.Text.ToString());
                                        row["status"] = 10;
                                        //row["line_id"] = cmb_ProductionLine.EditValue;
                                        row["line_id"] = lst_linea.SelectedValue;
                                        row["cant_tarimas"] = Convert.ToInt32(txtcant_tm.Text);
                                        row["presentacion"] = Convert.ToInt32(grd_presentacion.EditValue != null ? Convert.ToInt32(grd_presentacion.EditValue) : 0);
                                        row["ud_tarimas"] = Convert.ToInt32(unidades);
                                        if (tgg_reservarlote.IsOn)
                                        {
                                            row["lote_fp"] = Convert.ToInt32(txtloteselec.Text);
                                            row["id_gestion"] = id_gestion_lote;
                                        }
                                        else
                                        {
                                            row["lote_fp"] = 0;
                                            row["id_gestion"] = 0;
                                        }
                                        //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        //this.Close();
                                        OnFinalizarPresionado.Invoke(row, e);
                                    }
                                }
                                else
                                {
                                    row["code_op"] = txt_OPNumero.Text.ToString();
                                    row["kg_production"] = Convert.ToDouble(txt_KgProduccion.Text.ToString());
                                    row["cant_paradas"] = Convert.ToInt32(txt_Paradas.Text.ToString());
                                    row["date_prouction"] = DateTime.Now;
                                    row["priority"] = Convert.ToInt32(txt_prioridad.Text.ToString());
                                    row["status"] = 10;
                                    //row["line_id"] = cmb_ProductionLine.EditValue;
                                    row["line_id"] = lst_linea.SelectedValue;
                                    row["cant_tarimas"] = Convert.ToInt32(txtcant_tm.Text);
                                    row["presentacion"] = Convert.ToDouble(grd_presentacion.EditValue != null ? Convert.ToDouble(grd_presentacion.EditValue) : 0);
                                    row["ud_tarimas"] = Convert.ToInt32(unidades);
                                    if (tgg_reservarlote.IsOn)
                                    {
                                        row["lote_fp"] = Convert.ToInt32(txtloteselec.Text);
                                        row["id_gestion"] = id_gestion_lote;
                                    }
                                    else
                                    {
                                        row["lote_fp"] = 0;
                                        row["id_gestion"] = 0;
                                    }
                                    //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                    //this.Close();
                                    OnFinalizarPresionado.Invoke(row, e);
                                }
                            }
                            //}
                            //else
                            //{
                            //    MessageBox.Show("La fecha de la Orden de Producción esta fuera del rango del plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Debe informar la fecha de Producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Debe informar la linea de Producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto Terminado debe ser informado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La formula debe ser informada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El Numero de Orden de Producción no se genero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void PP_Nuevo_Orden_v2_Load(object sender, EventArgs e)
        {
            try
            {
                bag_weight = 1;
                txt_OPNumero.Text = Get_Prod_Orden_Code();
                //cmb_ProductionLine.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT [id], [name] FROM [dbo].[PP_Production_Lines] WHERE [status] >= 40 AND [status] < 80").Tables[0];
                //                cmb_ProductionLine.Properties.DataSource = 
                //                                    dp.ACS_GetSelectData(@"SELECT pp.[id],
                //                                                                  [name] 
                //                                                           FROM [dbo].[PP_Production_Lines] pp join
                //                                                                [dbo].[Conf_Especies] ee on 
                //                                                                pp.id_especie = ee.id 
                //                                                           WHERE [status] >= 40 AND [status] < 80 and
                //	                                                             ee.id = " + (int)vEspecieActual).Tables[0];
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                //                string sql = @"SELECT pp.[id],
                //                                     [name] 
                //                               FROM [dbo].[PP_Production_Lines] pp join
                //                                    [dbo].[Conf_Especies] ee on 
                //                                    pp.id_especie = ee.id 
                //                               WHERE [status] >= 40 AND [status] < 80 and
                //                	                 ee.id = " + (int)vEspecieActual;
                string sql = @"SELECT pp.[id],
                                                     [name] 
                                               FROM [dbo].[PP_Production_Lines] pp join
                                                    [dbo].[Conf_Especies] ee on 
                                                    pp.id_especie = ee.id 
                                               WHERE [status] >= 40 AND [status] < 80";
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsProduccion1.lineas_produccion.Clear();
                adat.Fill(dsProduccion1.lineas_produccion);
                //lst_linea.DataSource = dsProduccion1.lineas_produccion;

                if (vEspecieActual == Globals.Especies.Camaron)
                    //cmb_ProductionLine.EditValue = 1;
                    lst_linea.SelectedValue = 1;
                else
                    lst_linea.SelectedValue = 3;

                Conn.Close();
                load_presentacion();
                load_unidades_por_tarima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Paradas.Value = (int)txt_Paradas.Value * 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_KgProduccion.Value = (int)txt_KgProduccion.Value * 1000;
        }

        private void txt_Paradas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double bagzise =1;
                foreach (dsProduccion.bagsRow row3 in dsProduccion1.bags.Rows)
                {
                    if (grd_presentacion.EditValue == null)
                    {
                        break; 
                    }
                    if (Convert.ToInt32(grd_presentacion.EditValue) == row3.id)
                    {
                        bagzise = row3.net;
                    }
                }

                txt_KgProduccion.Text = (int.Parse(txt_Paradas.Text.ToString()) * 2500).ToString();
                Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bagzise).ToString()), 0);
                txt_Sacos.Text = sacos.ToString();
                row["bag_production"] = Convert.ToInt32(sacos);
                if (grd_udtm.EditValue != null)
                {
                    int und = Convert.ToInt32(grd_udtm.EditValue);
                    int unidades = 0;
                    foreach (dsProduccion.unidades_tarimaRow row in dsProduccion1.unidades_tarima.Rows)
                    {
                        if (und == row.id)
                        {
                            unidades = row.unidades;
                        }

                    }

                    decimal tarimas = Convert.ToDecimal(sacos) / Convert.ToDecimal(unidades);
                    int cambio = Convert.ToInt32(tarimas);
                    if (cambio < tarimas)
                    {
                        cambio = cambio + 1;
                    }

                    txtcant_tm.Text = cambio.ToString();
                }

            }
            catch { }
        }

        private void grd_presentacion_EditValueChanged(object sender, EventArgs e)
        {
            if (grd_presentacion.EditValue != null)
            {
                try
                {
                    double bagzise = 1;
                    foreach (dsProduccion.bagsRow row3 in dsProduccion1.bags.Rows)
                    {
                        if (grd_presentacion.EditValue == null)
                        {
                            break;
                        }
                        if (Convert.ToInt32(grd_presentacion.EditValue) == row3.id)
                        {
                            bagzise = row3.net;
                        }
                    }
                    Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bagzise).ToString()), 0);
                    txt_Sacos.Text = sacos.ToString();//Convert.ToInt32(Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()),0)).ToString();
                    row["bag_production"] = Convert.ToInt32(sacos);
                    if (grd_udtm.EditValue != null)
                    {
                        int und = Convert.ToInt32(grd_udtm.EditValue);
                        int unidades = 0;
                        foreach (dsProduccion.unidades_tarimaRow row in dsProduccion1.unidades_tarima.Rows)
                        {
                            if (und == row.id)
                            {
                                unidades = row.unidades;
                            }

                        }
                        decimal tarimas = Convert.ToDecimal(sacos) / Convert.ToDecimal(unidades);
                        int cambio = Convert.ToInt32(tarimas);
                        if (cambio < tarimas)
                        {
                            cambio = cambio + 1;
                        }

                        txtcant_tm.Text = cambio.ToString();
                    }

                    


                }
                catch (Exception ex)
                {


                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void grd_udtm_EditValueChanged(object sender, EventArgs e)
        {
            double bagzise = 1;
            foreach (dsProduccion.bagsRow row in dsProduccion1.bags.Rows)
            {
                if (grd_presentacion.EditValue == null)
                {
                    break;
                }
                if (Convert.ToInt32(grd_presentacion.EditValue) == row.id)
                {
                    bagzise = row.net;
                }     
              
            }
            Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bagzise).ToString()), 0);
            if (grd_presentacion.EditValue != null)
            {
                txtcant_tm.Text = Math.Round((Double.Parse(txt_KgProduccion.Text.ToString()) / Convert.ToInt32(sacos)), 0).ToString();
            }
            if (grd_udtm.EditValue != null)
            {
                int und = Convert.ToInt32(grd_udtm.EditValue);
                int unidades = 0;
                foreach (dsProduccion.unidades_tarimaRow row3 in dsProduccion1.unidades_tarima.Rows)
                {
                    if (und == row3.id)
                    {
                        unidades = row3.unidades;
                    }

                }
                decimal tarimas = Convert.ToDecimal(sacos) / Convert.ToDecimal(unidades);
                int cambio = Convert.ToInt32(tarimas);
                if (cambio < tarimas)
                {
                    cambio = cambio + 1;
                }

                txtcant_tm.Text = cambio.ToString();
            }
        }

        private void tgg_reservarlote_Toggled(object sender, EventArgs e)
        {
            if (tgg_reservarlote.IsOn)
            {
                btnBuscarLote.Enabled = true;
            }
            else
            {
                btnBuscarLote.Enabled = false;
            }
        }

        private void btnBuscarLote_Click(object sender, EventArgs e)
        {
            PP_seleccionLote frm = new PP_seleccionLote();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                id_gestion_lote = frm.id;
                lote_fp = frm.lote;
                txtloteselec.Text = lote_fp.ToString();
            }
        }
    }
}