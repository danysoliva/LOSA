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

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Nuevo_Orden : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;

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

        public PP_Nuevo_Orden(string ActiveUserCode, string ActiveUserName, string FormAction, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
        }

        public PP_Nuevo_Orden(string ActiveUserCode, string ActiveUserName, string FormAction, string ActiveUserType, DataRow row, DateTime desde, DateTime hasta, int cantDataSetRow)
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
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_OPNumero.Text != "")
            {
                if (txt_FormulaCode.Text != "")
                {
                    if (txt_PTCodigo.Text != "" && txt_PTName.Text != "")
                    {
                        if (cmb_ProductionLine.EditValue != null) 
                        {
                            if (dt_produccion.EditValue != null)
                            {
                                if ((DateTime)dt_produccion.EditValue >= desde && (DateTime)dt_produccion.EditValue <= hasta)
                                {
                                    if (MessageBox.Show(string.Format("¿Seguro que desea crear la Orden de Producción por {0}Kg.", txt_KgProduccion.Text), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        int rmi = dp.get_inactive_rm(int.Parse(row["id_formula"].ToString()));

                                        if (rmi > 0)
                                        {
                                            if (MessageBox.Show(string.Format("Aparentemente esta formula tiene {0} materias primas o núcleos inactivos\n\n¿Seguro que desea incluirlo dentro del plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                            {
                                                row["code_op"] = txt_OPNumero.Text.ToString();
                                                row["kg_production"] = Convert.ToDouble(txt_KgProduccion.Text.ToString());
                                                row["cant_paradas"] = Convert.ToInt32(txt_Paradas.Text.ToString());
                                                row["date_prouction"] = dt_produccion.EditValue;
                                                row["priority"] = Convert.ToInt32(txt_prioridad.Text.ToString());
                                                row["status"] = 10;
                                                row["line_id"] = cmb_ProductionLine.EditValue;
                                                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            row["code_op"] = txt_OPNumero.Text.ToString();
                                            row["kg_production"] = Convert.ToDouble(txt_KgProduccion.Text.ToString());
                                            row["cant_paradas"] = Convert.ToInt32(txt_Paradas.Text.ToString());
                                            row["date_prouction"] = dt_produccion.EditValue;
                                            row["priority"] = Convert.ToInt32(txt_prioridad.Text.ToString());
                                            row["status"] = 10;
                                            row["line_id"] = cmb_ProductionLine.EditValue;
                                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                            this.Close();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La fecha de la Orden de Producción esta fuera del rango del plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe informar la fecha de Producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void PP_Nuevo_Orden_Load(object sender, EventArgs e)
        {
            try
            {
                bag_weight = 1;
                txt_OPNumero.Text = Get_Prod_Orden_Code();
                cmb_ProductionLine.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT [id], [name] FROM [dbo].[PP_Production_Lines] WHERE [status] >= 40 AND [status] < 80").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void btn_searchPT_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @" SELECT A.[id]
                                        ,A.[Codigo] AS col1
                                        ,A.[Descripcion] AS col2
                                        ,B.[Descripcion] AS grupo
                                    FROM [dbo].[PT_Productos] A
                              INNER JOIN [dbo].[Conf_Especies] B
	                                ON A.[especie] = B.[id]
                                 WHERE A.[Estado] = 'a'
                                   AND A.[especie] = " + dp.ACS_GetSelectData(string.Format(@"SELECT [especie] FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", row["id_formula"])).Tables[0].Rows[0][0].ToString() + @"
                                 ORDER BY [Codigo]";

                Item_Selecction sel = new Item_Selecction();
                sel.col1Header = "Codigo";
                sel.col2Header = "Descripción";
                sel.FormHeader = "Selección Producto Terminado";
                sel.action = "prod";
                sel.Query = query;

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    row["id_pt"] = sel.SVid;
                    row["code_pt"] = sel.SVCol1;
                    row["pt"] = sel.SVCol2;
                    bag_weight = Convert.ToInt32(Math.Round(Convert.ToDouble(dp.ACS_GetSelectData(string.Format("SELECT [PesoSaco] FROM [dbo].[PT_Productos] WHERE [id] = {0}", row["id_pt"])).Tables[0].Rows[0][0].ToString())));

                    txt_PTName.Text = row["pt"].ToString();
                    txt_PTCodigo.Text = row["code_pt"].ToString();

                    try
                    {
                        txt_Sacos.Text = Convert.ToInt32(Math.Round(Convert.ToDecimal((int.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()))).ToString();
                        row["bag_production"] = Convert.ToInt32(Math.Round(Convert.ToDecimal((int.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString())));
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SearchFormula_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @" SELECT A.[id]
                                        ,CONCAT(A.[codigo],'.',A.[version]) AS col1
                                        ,A.[nombre] AS col2
                                        ,B.[Descripcion] AS grupo
                                    FROM [dbo].[FML_Formulas_v2] A
                                    INNER JOIN [dbo].[Conf_Especies] B
	                                ON A.[especie] = B.[id]
                                    WHERE [estado] >= 40 AND [estado] <= 70
                                      AND [tipo] = 'FB'
                                      AND SYSDATETIME() >= [available_date] 
	                                  AND SYSDATETIME() < [due_date] ";

                Item_Selecction sel = new Item_Selecction();
                sel.col1Header = "Codigo";
                sel.col2Header = "Descripción";
                sel.FormHeader = "Selección de Formulas";
                sel.action = "prod";
                sel.Query = query;

                if (sel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    row["id_formula"] = sel.SVid;
                    row["code_formula"] = sel.SVCol1;
                    row["formula"] = sel.SVCol2;
                    row["code_wincc"] = Get_Formula_Wincc_Code(row["id_formula"].ToString());
                    row["version_formula"] = dp.ACS_GetSelectData(string.Format(@"SELECT [version] FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", row["id_formula"])).Tables[0].Rows[0][0].ToString();
                    
                    txt_FormulaName.Text = row["formula"].ToString();
                    txt_FormulaCode.Text = row["code_wincc"].ToString();

                    btn_searchPT.Enabled = true;
                    txt_PTName.Text = "";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@formula_id", SqlDbType.Int));

                    cmd.Parameters["@formula_id"].Value = int.Parse(row["id_formula"].ToString());

                    pesoBatch = Convert.ToDouble(dp.ACS_Exec_SP_Get_Data("FM_Get_Formula_Weight", cmd).Rows[0]["peso"].ToString());

                    txt_KgProduccion.Text = (int.Parse(txt_Paradas.Text.ToString()) * pesoBatch).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_searchPT.Enabled = false;
            }
        }

        private void txt_OPNumero_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_Paradas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_KgProduccion.Text = (int.Parse(txt_Paradas.Text.ToString()) * pesoBatch).ToString();
                Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()), 0);
                txt_Sacos.Text = sacos.ToString();//Convert.ToInt32(Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()),0)).ToString();
                row["bag_production"] = Convert.ToInt32(sacos); //Convert.ToInt32(Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()), 0));
            }
            catch { }
        }
    }
}