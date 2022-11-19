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
using LOSA.Clases;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Nuevo_Plan : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        FMOP fmop = new FMOP();
        DataSet orders;

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;

        int selectedIndex;

        int selectedFormula;

        SqlConnection conn = new SqlConnection();

        #region Developer defined Methods

        private void Initialize_DataSet() 
        {
            orders = new DataSet();
            orders.Tables.Add("OPS");

            orders.Tables["OPS"].Columns.Add("id");
            orders.Tables["OPS"].Columns.Add("code_op");
            orders.Tables["OPS"].Columns.Add("id_pt");//Done
            orders.Tables["OPS"].Columns.Add("code_pt");//Done
            orders.Tables["OPS"].Columns.Add("pt");//Done
            orders.Tables["OPS"].Columns.Add("bag_production");//Done
            orders.Tables["OPS"].Columns.Add("line_id");
            orders.Tables["OPS"].Columns.Add("id_formula");//Done
            orders.Tables["OPS"].Columns.Add("code_formula");//Done
            orders.Tables["OPS"].Columns.Add("version_formula");//Done
            orders.Tables["OPS"].Columns.Add("code_wincc");//Done
            orders.Tables["OPS"].Columns.Add("formula");//Done
            orders.Tables["OPS"].Columns.Add("kg_production");//Done
            orders.Tables["OPS"].Columns.Add("date_prouction");//Done
            orders.Tables["OPS"].Columns.Add("priority");//Done
            orders.Tables["OPS"].Columns.Add("status");//Done
            orders.Tables["OPS"].Columns.Add("cant_paradas");//Done

            orders.Tables["OPS"].Columns["id"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["code_op"].DataType = System.Type.GetType("System.String");
            orders.Tables["OPS"].Columns["id_pt"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["code_pt"].DataType = System.Type.GetType("System.String");
            orders.Tables["OPS"].Columns["pt"].DataType = System.Type.GetType("System.String");
            orders.Tables["OPS"].Columns["bag_production"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["line_id"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["id_formula"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["code_formula"].DataType = System.Type.GetType("System.String");
            orders.Tables["OPS"].Columns["version_formula"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["code_wincc"].DataType = System.Type.GetType("System.String");
            orders.Tables["OPS"].Columns["formula"].DataType = System.Type.GetType("System.String");
            orders.Tables["OPS"].Columns["kg_production"].DataType = System.Type.GetType("System.Double");
            orders.Tables["OPS"].Columns["date_prouction"].DataType = System.Type.GetType("System.DateTime");
            orders.Tables["OPS"].Columns["priority"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["status"].DataType = System.Type.GetType("System.Int32");
            orders.Tables["OPS"].Columns["cant_paradas"].DataType = System.Type.GetType("System.Int32");
        }

        private string Get_Prod_Plan_Code() 
        {
            string ProdPlan = "PR-ERROR";
            string newPP = dp.ACS_GetSelectData(@"SELECT (COUNT([id]) + 1) AS New_ID FROM [dbo].[PP_Plan_Main]").Tables[0].Rows[0][0].ToString();

            switch (newPP.Length)
            {
                case 1:
                    ProdPlan = "PR-000000" + newPP;
                    break;
                case 2:
                    ProdPlan = "PR-00000" + newPP;
                    break;
                case 3:
                    ProdPlan = "PR-0000" + newPP;
                    break;
                case 4:
                    ProdPlan = "PR-000" + newPP;
                    break;
                case 5:
                    ProdPlan = "PR-00" + newPP;
                    break;
                case 6:
                    ProdPlan = "PR-0" + newPP;
                    break;
                case 7:
                    ProdPlan = "PR-" + newPP;
                    break;
                default:
                    ProdPlan = "PR-" + newPP;
                    break;
            }

            return ProdPlan;
        }

        private string Get_Prod_Orden_Code()
        {
            string ProdPlan = "PP-ERROR";
            string newPP = dp.ACS_GetSelectData(@"SELECT ((COUNT([id]) + 1)) AS New_ID FROM [dbo].[PP_Plan_Ordenes]").Tables[0].Rows[0][0].ToString();

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

        private int Insert_Header() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@valid_from", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@valid_to", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@code"].Value = Get_Prod_Plan_Code();
                cmd.Parameters["@description"].Value = txt_Descripcion.Text.ToString();
                cmd.Parameters["@valid_from"].Value = dt_desde.EditValue;
                cmd.Parameters["@valid_to"].Value = dt_Hasta.EditValue;
                cmd.Parameters["@status"].Value = 10;
                cmd.Parameters["@created_by"].Value = ActiveUserCode;

                return dp.ACS_Exec_SP_GetID("PP_Plan_Main_Insert", cmd, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message + "\nSTAKTRACE: " + ex.StackTrace);
                return -4;
            }
        }

        private void Insert_Orders(int idPlan)
        {
            try
            {
                if (orders.Tables["OPS"].Rows.Count > 0) 
                {
                    foreach (DataRow row in orders.Tables["OPS"].Rows)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@id_plan", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@pp_code", SqlDbType.VarChar, 10));
                        cmd.Parameters.Add(new SqlParameter("@id_pt", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@form_wincc", SqlDbType.VarChar, 18));
                        cmd.Parameters.Add(new SqlParameter("@kg_production", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@bag_production", SqlDbType.Int));
                        //cmd.Parameters.Add(new SqlParameter("@lot_number", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@line_id", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@date_prouction", SqlDbType.Date));
                        cmd.Parameters.Add(new SqlParameter("@priority", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@last_mod_by", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@kg_reached", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@kg_difference", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@cant_paradas", SqlDbType.Int));

                        cmd.Parameters["@id_plan"].Value = idPlan;
                        cmd.Parameters["@pp_code"].Value = Get_Prod_Orden_Code();
                        cmd.Parameters["@id_pt"].Value = row["id_pt"];
                        cmd.Parameters["@id_formula"].Value = row["id_formula"];
                        cmd.Parameters["@form_wincc"].Value = (row["code_wincc"].ToString().Substring(0,11) + Get_Prod_Orden_Code().Substring(3, 7));
                        cmd.Parameters["@kg_production"].Value = row["kg_production"];
                        cmd.Parameters["@bag_production"].Value = row["bag_production"];
                        //cmd.Parameters["@lot_number"].Value = fmop.pp_order_get_next_lot_number();
                        cmd.Parameters["@line_id"].Value = Convert.ToInt32(row["line_id"].ToString());
                        cmd.Parameters["@date_prouction"].Value = row["date_prouction"];
                        cmd.Parameters["@priority"].Value = row["priority"];
                        cmd.Parameters["@status"].Value = 40;
                        cmd.Parameters["@created_by"].Value = int.Parse(ActiveUserCode);
                        cmd.Parameters["@last_mod_by"].Value = int.Parse(ActiveUserCode);
                        cmd.Parameters["@kg_reached"].Value = 0.00;
                        cmd.Parameters["@kg_difference"].Value = 0.00;
                        cmd.Parameters["@cant_paradas"].Value = row["cant_paradas"];

                        dp.ACS_Exec_SP("PP_Plan_Ordenes_Insert", cmd);

                        #region Validate & Change Formula Status

                        int status = fmop.local_formula_get_status(int.Parse(row["id_formula"].ToString()));

                        if (status < 50) 
                        {
                            fmop.local_formula_change_status(int.Parse(row["id_formula"].ToString()), int.Parse(ActiveUserCode), 50);

                            int nucleo = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COALESCE([nucleo], 0 ) AS nucleo FROM [dbo].[FML_Ingredientes_v2] WHERE [formula] = {0} AND [tipo] = 'NC' ", row["id_formula"])).Tables[0].Rows[0][0].ToString());

                            if (nucleo > 0) 
                            {
                                status = fmop.local_formula_get_status(nucleo);

                                if (status < 50) 
                                {
                                    fmop.local_formula_change_status(nucleo, int.Parse(ActiveUserCode), 50);
                                }
                            }
                        }

                        #endregion
                    }

                    Try_Drop_TempTables(selectedFormula.ToString(), "Drop");
                    MessageBox.Show("Plan de Producción Generado sin Problemas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void Gen_RM_Requirement() 
        {
            try
            {
                //Daily Raw Material Requirements
                DataTable RMData = new DataTable();
                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Get_Daily", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));

                cmd.Parameters["@userID"].Value = ActiveUserCode;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                RMData.Load(cmd.ExecuteReader());

                grd_rmReq.DataSource = RMData;
                
                //Total Raw Material Requirements
                RMData = new DataTable();
                cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Get_Total", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));

                cmd.Parameters["@userID"].Value = ActiveUserCode;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                RMData.Load(cmd.ExecuteReader());

                grd_reqMP_Total.DataSource = RMData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void Try_Drop_TempTables(string formula, string action) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Drop", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@Action", SqlDbType.VarChar, 10));
                cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));

                cmd.Parameters["@UserID"].Value = ActiveUserCode;
                cmd.Parameters["@Action"].Value = action;
                cmd.Parameters["@FormulaID"].Value = formula;                

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        #endregion

        public PP_Nuevo_Plan(string ActiveUserCode, string ActiveUserName, string FormAction, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();

            Try_Drop_TempTables(selectedFormula.ToString(), "Drop");

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void PP_Nuevo_Plan_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = dp.ConnectionStringCostos;
                conn.Open();
                if(conn.State == ConnectionState.Open)
                    this.Text = this.Text + " - [Database Connection Established]";
                else
                    this.Text = this.Text + " - [Error on Database Connection]";

                splitContainerControl1.SplitterPosition = splitContainerControl1.Width / 2;

                if (FormAction == "new") 
                {
                    txt_Codigo.Text = Get_Prod_Plan_Code();
                    Initialize_DataSet();
                    grd_data.DataSource = orders.Tables["OPS"];
                }
                else if (FormAction == "edit")
                {
                    grp_mainOptions.Enabled = false;

                    //GET PLAN DATA AND SET IT IN THE RIGTH PLACE.
                    grd_data.DataSource = orders.Tables["OPS"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void chk_AutoGen_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
            else 
            {
                txt_Descripcion.Enabled = true;
            }
        }

        private void dt_desde_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
        }

        private void dt_Hasta_EditValueChanged(object sender, EventArgs e)
        {
            if (chk_AutoGen.Checked == true)
            {
                txt_Descripcion.Enabled = false;
                txt_Descripcion.Text = string.Format("Programa de Produccion del {0} al {1}", dt_desde.Text, dt_Hasta.Text);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Insert_Header();
        }

        private void btn_NewOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dt_desde.EditValue != null && dt_Hasta.EditValue != null)
            {
                if ((DateTime)dt_Hasta.EditValue >= (DateTime)dt_desde.EditValue)
                {
                    if (Convert.ToDateTime(Convert.ToDateTime(dt_desde.EditValue).ToShortDateString()) >= Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()).ToShortDateString()))
                    {
                        PP_Nuevo_Orden orden = new PP_Nuevo_Orden(ActiveUserCode, ActiveUserName, "new", ActiveUserType, orders.Tables["OPS"].NewRow(), (DateTime)dt_desde.EditValue, (DateTime)dt_Hasta.EditValue, orders.Tables["OPS"].Rows.Count);
                        if (orden.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            orders.Tables["OPS"].Rows.Add(orden.GetRow());
                            dt_desde.Enabled = false;
                            dt_Hasta.Enabled = false;

                            /******************************************************************************/
                            /* *****INSERTING INTO TEMP TABLE TO CALCULATE RAW MATERIAL REQUIREMENTS***** */
                            DataRow InsertedRow = orden.GetRow();
                            SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Ins", conn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));
                            cmd.Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.VarChar, 100));
                            cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
                            cmd.Parameters.Add(new SqlParameter("@date_production", SqlDbType.Date));

                            cmd.Parameters["@FormulaID"].Value = InsertedRow["id_formula"].ToString();
                            cmd.Parameters["@BatchNo"].Value = InsertedRow["cant_paradas"].ToString();
                            cmd.Parameters["@UserID"].Value = ActiveUserCode;
                            cmd.Parameters["@date_production"].Value = InsertedRow["date_prouction"];
                            
                            if (conn.State == ConnectionState.Closed)
                                conn.Open();

                            cmd.ExecuteNonQuery();

                            Gen_RM_Requirement();
                            /******************************************************************************/
                        }
                    }
                    else 
                    {
                        MessageBox.Show("No puede crear un plan para una fecha anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Las Fechas son inconsistentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Antes debes indicar la vigencia del plan de producción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Try_Drop_TempTables(selectedFormula.ToString(), "Delete");

            Gen_RM_Requirement();

            orders.Tables["OPS"].Rows.RemoveAt(selectedIndex);
            orders.AcceptChanges();

            if (orders.Tables["OPS"].Rows.Count == 0) 
            {
                dt_Hasta.Enabled = true;
                dt_desde.Enabled = true;
            }
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedIndex = e.FocusedRowHandle;
                selectedFormula = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["id_formula"].ToString());
            }
            catch { }
            
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (orders.Tables["OPS"].Rows.Count > 0)
            {
                if (txt_Descripcion.Text != "")
                {
                    double cantKilos = 0;
                    foreach (DataRow r in orders.Tables["OPS"].Rows)
                    {
                        cantKilos += Convert.ToDouble(r["kg_production"]);
                    }

                    if (MessageBox.Show(string.Format("¿Seguro que desea crear el Plan de Producción por {0}Kg de alimento.", cantKilos), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (MessageBox.Show("¿Deseas Guardar la Informacion de Consumos antes de cerrar?", "Consumos Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                        {
                            SaveFileDialog dialog = new SaveFileDialog();
                            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                            dialog.FilterIndex = 0;

                            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                grd_rmReq.ExportToXlsx((string.Format("{0} - Diarios.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
                                grd_reqMP_Total.ExportToXlsx((string.Format("{0} - Totales.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
                            }
                        }

                        int rmi = 0;

                        foreach (DataRow row in orders.Tables["OPS"].Rows) 
                        {
                            rmi += dp.get_inactive_rm(int.Parse(row["id_formula"].ToString()));
                        }

                        if (rmi > 0)
                        {
                            if (MessageBox.Show(string.Format("Aparentemente este plan de producción tiene formulas con almenos {0} materias primas o núcleos inactivos\n\n¿Seguro que desea crear el plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Insert_Orders(Insert_Header());
                            }
                        }
                        else
                        {
                            Insert_Orders(Insert_Header());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes definir una descripción al plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El Plan de Producción debe tener al menos una orden creada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EditOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void PP_Nuevo_Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        private void splitContainerControl1_Resize(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = splitContainerControl1.Width / 2;
        }

        private void btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_rmReq.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_pdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_rmReq.ExportToPdf(dialog.FileName);
            }
        }

        private void btn_consumo_Total_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_reqMP_Total.ExportToXlsx(dialog.FileName);
            }
        }

        private void btn_pdf_total_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF File (.pdf)|*.pdf";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_reqMP_Total.ExportToPdf(dialog.FileName);
            }
        }

        private void btn_Both_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_rmReq.ExportToXlsx((string.Format("{0} - Diarios.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
                grd_reqMP_Total.ExportToXlsx((string.Format("{0} - Totales.xlsx", dialog.FileName.Substring(0, (dialog.FileName.Length - 5)))));
            }
        }
    }
}