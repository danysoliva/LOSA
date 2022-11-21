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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.MigracionACS.ACS.Formulas;
using LOSA.MigracionACS.MP;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_NewFormula_v3 : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Variables

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;
        int sel_local_formula;
        int sel_parent_formula;
        string selected_type;
        int selected_line_id;
        string selected_mat_code;
        Double selected_wheight;
        DataTable UserGroups;

        string formType;

        int selectedLine;
        int FormStatus;
        int selectedIndex;
        bool sel_nc_use;

        DataOperations dp = new DataOperations();
        FMOP fmop = new FMOP();

        DataSet Items;
        DataTable comments;
        DataTable events;

        DataTable parent_formula_main;
        DataTable parent_formula_struct;

        DataTable local_formula_main;
        DataTable local_formula_struct;

        DataTable material_list;

        DataRowView row_material;
        #endregion

        #region Developer Defined Methods
        //------------------------------------------------------------------------------------------------------
        private void Items_Initialize_DataSet()
      {
            Items = new DataSet();

            Items.Tables.Add("items");
            Items.Tables["items"].Columns.Add("id");
            Items.Tables["items"].Columns.Add("id_item");
            Items.Tables["items"].Columns.Add("codigo");
            Items.Tables["items"].Columns.Add("material");
            Items.Tables["items"].Columns.Add("peso");
            Items.Tables["items"].Columns.Add("inclusion");
            Items.Tables["items"].Columns.Add("materialType");
            Items.Tables["items"].Columns.Add("mix");
            Items.Tables["items"].Columns.Add("index");
            Items.Tables["items"].Columns.Add("nc_use");
            Items.Tables["items"].Columns.Add("incl_cost");
            Items.Tables["items"].Columns.Add("sap_code");
            //Items.Tables["items"].Columns.Add("typeid");
            //Items.Tables["items"].Columns.Add("typename");
            //Items.Tables["items"].Columns.Add("tipo1");
            //Items.Tables["items"].Columns.Add("tipo2");
            //Items.Tables["items"].Columns.Add("tipo3");

            Items.Tables["items"].Columns["id"].DataType = System.Type.GetType("System.Int32");
            Items.Tables["items"].Columns["id_item"].DataType = System.Type.GetType("System.Int32");
            Items.Tables["items"].Columns["codigo"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["material"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["peso"].DataType = System.Type.GetType("System.Double");
            Items.Tables["items"].Columns["inclusion"].DataType = System.Type.GetType("System.Double");
            Items.Tables["items"].Columns["materialType"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["mix"].DataType = System.Type.GetType("System.String");
            Items.Tables["items"].Columns["index"].DataType = System.Type.GetType("System.Int32");
            Items.Tables["items"].Columns["nc_use"].DataType = System.Type.GetType("System.Byte");
            Items.Tables["items"].Columns["incl_cost"].DataType = System.Type.GetType("System.Double");
            Items.Tables["items"].Columns["sap_code"].DataType = System.Type.GetType("System.String");
            //Items.Tables["items"].Columns["typeid"].DataType = System.Type.GetType("System.Int32");
            //Items.Tables["items"].Columns["typename"].DataType = System.Type.GetType("System.String");
            //Items.Tables["items"].Columns["tipo1"].DataType = System.Type.GetType("System.String");
            //Items.Tables["items"].Columns["tipo2"].DataType = System.Type.GetType("System.String");
            //Items.Tables["items"].Columns["tipo3"].DataType = System.Type.GetType("System.String");
        }

        public void add_item_to_grid(int id, int id_item, string codigo, string material, double peso, string materialType, string mix, bool nc_use)
        {
            DataRow row = Items.Tables["items"].NewRow();

            row["id"] = id;
            row["id_item"] = id_item;
            row["codigo"] = codigo;
            row["material"] = material;
            row["peso"] = peso;
            row["materialType"] = materialType;
            row["mix"] = mix;
            row["nc_use"] = nc_use;
            row["incl_cost"] = 0;
         

            Items.Tables["items"].Rows.Add(row);

            Items.AcceptChanges();

            calculate_formula_inclusion();
            set_items_index();
        }

        private void Comments_Initialize_DataSet()
        {
            comments = new DataTable();

            comments.Columns.Add("comment_on");
            comments.Columns.Add("nombre");
            comments.Columns.Add("comment");
            comments.Columns.Add("is_reject");
            comments.Columns.Add("is_new");

            comments.Columns["comment_on"].DataType = System.Type.GetType("System.DateTime");
            comments.Columns["nombre"].DataType = System.Type.GetType("System.String");
            comments.Columns["comment"].DataType = System.Type.GetType("System.String");
            comments.Columns["is_reject"].DataType = System.Type.GetType("System.Boolean");
            comments.Columns["is_new"].DataType = System.Type.GetType("System.Boolean");
        }

        private void load_source_formula() 
        {
            try
            {
                #region Load Main

                parent_formula_main = fmop.ext_formula_get_main(sel_parent_formula);

                txt_companyCode.Text = parent_formula_main.Rows[0]["src_company_code"].ToString();
                txt_companyName.Text = parent_formula_main.Rows[0]["src_company_name"].ToString();
                txt_plantCode.Text = parent_formula_main.Rows[0]["src_plant_code"].ToString();
                txt_mixType.Text = parent_formula_main.Rows[0]["src_mix_type"].ToString();
                txt_mixRefCodes.Text = parent_formula_main.Rows[0]["src_mix_ref_code"].ToString();
                txt_serverName.Text = parent_formula_main.Rows[0]["src_server_name"].ToString();
                txt_createdDate.Text = parent_formula_main.Rows[0]["src_created_date"].ToString();
                txt_createdTime.Text = parent_formula_main.Rows[0]["src_created_time"].ToString();
                txt_printedDate.Text = parent_formula_main.Rows[0]["src_printed_date"].ToString();
                txt_printedTime.Text = parent_formula_main.Rows[0]["src_printed_time"].ToString();
                txt_printedBy.Text = parent_formula_main.Rows[0]["src_printed_by"].ToString();
                txt_formulaCode.Text = parent_formula_main.Rows[0]["src_formula_code"].ToString();
                txt_formulaName.Text = parent_formula_main.Rows[0]["src_formula_name"].ToString();
                txt_formulaTonnes.Text = parent_formula_main.Rows[0]["src_formula_tonnes"].ToString();
                txt_batchSize.Text = parent_formula_main.Rows[0]["src_batch_size_kg"].ToString();
                txt_lastUpdatedDate.Text = parent_formula_main.Rows[0]["src_last_updated"].ToString();

                txt_loaded_by.Text = parent_formula_main.Rows[0]["lcl_loaded_by"].ToString();
                txt_loaded_date.Text = parent_formula_main.Rows[0]["lcl_loaded_date"].ToString();
                txt_modified_by.Text = parent_formula_main.Rows[0]["lcl_last_mod_by"].ToString();
                txt_modified_date.Text = parent_formula_main.Rows[0]["lcl_last_mod_date"].ToString();

                dt_desde_source.EditValue = Convert.ToDateTime(parent_formula_main.Rows[0]["available_date"].ToString());
                dt_hasta_source.EditValue = Convert.ToDateTime(parent_formula_main.Rows[0]["due_date"].ToString());

                txt_aprove_fin.Text = parent_formula_main.Rows[0]["aprove_fin_user"].ToString();
                txt_aprove_fin_date.Text = parent_formula_main.Rows[0]["aprove_fin_date"].ToString();
                txt_aprove_prod.Text = parent_formula_main.Rows[0]["aprove_prod_user"].ToString();
                txt_aprove_prod_date.Text = parent_formula_main.Rows[0]["aprove_prod_date"].ToString();

                #endregion

                grd_parentComments.DataSource = fmop.ext_formula_get_comments(sel_parent_formula);

                #region Load Structure

                if(FormAction == "view_cost")
                    parent_formula_struct = fmop.ext_formula_get_structure_cost(sel_parent_formula);
                else
                    parent_formula_struct = fmop.ext_formula_get_structure(sel_parent_formula);
                grd_original.DataSource = parent_formula_struct;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_local_formula() 
        {
            try
            {
                #region Load Main

                local_formula_main = fmop.local_formula_get_main(sel_local_formula);

                txt_Codigo.Text = local_formula_main.Rows[0]["codigo"].ToString();
                txt_CodigoInterno.Text = local_formula_main.Rows[0]["codigo_i"].ToString();
                txt_versionFormula.Text = local_formula_main.Rows[0]["version"].ToString();
                txt_descripcion.Text = local_formula_main.Rows[0]["nombre"].ToString();
                cmb_especie.EditValue = int.Parse(local_formula_main.Rows[0]["especie"].ToString());
                dt_desde.EditValue = Convert.ToDateTime(local_formula_main.Rows[0]["available_date"].ToString());
                //dt_desde.EditValue = DateTime.Now;
                dt_hasta.EditValue = Convert.ToDateTime(local_formula_main.Rows[0]["due_date"].ToString());
                chk_cons_due_date.Checked = Convert.ToBoolean(local_formula_main.Rows[0]["cons_due_date"]);
                txt_nc_code.Text = local_formula_main.Rows[0]["nc_code"].ToString();

                txt_Codigo.Enabled = false;
                txt_versionFormula.Enabled = false;
                cmb_especie.Enabled = true;

                //txt_companyCode.Text = local_formula_main.Rows[0]["src_company_code"].ToString();
                

                #endregion

                #region Load Structure

                local_formula_struct = fmop.local_formula_get_structure(sel_local_formula);

                foreach (DataRow local in local_formula_struct.Rows)
                {
                    DataRow row = Items.Tables["items"].NewRow();

                    row["id"] = local["id"];
                    row["id_item"] = local["id_item"];
                    row["codigo"] = local["codigo"];
                    row["material"] = local["material"];
                    row["peso"] = local["peso"];
                    row["inclusion"] = local["inclusion"];
                    row["materialType"] = local["materialType"];
                    row["mix"] = local["mix"];
                    row["nc_use"] = local["nc_use"];
                    row["incl_cost"] = local["incl_cost"];
                    row["sap_code"] = local["sap_code"];
                    
                    //row["typename"] = local["typename"];
                    //row["typeid"] = local["typeid"];

                    Items.Tables["items"].Rows.Add(row);
                    Items.Tables["items"].AcceptChanges();

                    //grdv_mp.SetRowCellValue((Items.Tables["items"].Rows.Count - 1), col_material, local["id_item"]);

                    //calculate_formula_inclusion();
                }

                #endregion

                set_items_index();

                grd_mp.DataSource = Items.Tables["items"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_RawMaterials() 
        {
            try
            {
                if(formType == "FB")
                    material_list = dp.ACS_Exec_SP_Get_Data("FM_Get_Material_List_FB", new SqlCommand());
                else if(formType == "NC")
                    material_list = dp.ACS_Exec_SP_Get_Data("FM_Get_Material_List_NC", new SqlCommand());

                //cmb_RawMaterial_deprecated.DataSource = material_list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gen_local_formula() 
        {
            try
            {
                #region Sugest Formula Code

                txt_Codigo.EditValue = int.Parse(parent_formula_main.Rows[0]["src_formula_code"].ToString());
                txt_Codigo.Text = parent_formula_main.Rows[0]["src_formula_code"].ToString();

                #endregion

                #region Sugest Formula Version
                
                int qty = (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [tipo] = '{1}'", parent_formula_main.Rows[0]["src_formula_code"], formType)).Tables[0].Rows[0][0].ToString()));
                if (qty <= 0)
                {
                    txt_versionFormula.EditValue = 0;
                    txt_versionFormula.Text = "0";
                }
                else 
                {
                    txt_versionFormula.EditValue = (qty);
                    txt_versionFormula.Text = (qty).ToString();
                }
                
                #endregion

                #region Sugest Description

                txt_descripcion.Text = parent_formula_main.Rows[0]["src_formula_name"].ToString();

                #endregion

                #region Sugest Specie
                
                if (parent_formula_main.Rows[0]["src_formula_name"].ToString().Substring(0, 2) == "AQ")
                {
                    cmb_especie.SelectedText = "Tilapia";
                    cmb_especie.EditValue = 1;
                }
                else 
                {
                    cmb_especie.SelectedText = "Camarón";
                    cmb_especie.EditValue = 2;
                }

                #endregion

                dt_desde.EditValue = dt_desde_source.EditValue;
                //dt_desde.EditValue = DateTime.Now;
                dt_hasta.EditValue = dt_hasta_source.EditValue;

                #region Sugest Structure

                foreach (DataRow parent in parent_formula_struct.Rows) 
                {
                    foreach (DataRow material in material_list.Rows) 
                    {
                        if (parent[1].ToString().Trim() == material["code"].ToString().Trim()) 
                        {
                            DataRow row = Items.Tables["items"].NewRow();

                            row["id"] = -1;
                            row["id_item"] = material["id"];
                            row["codigo"] = material["code"];
                            row["material"] = material["name"];
                            row["peso"] = parent["Kg x Batch"];
                            row["inclusion"] = 0;
                            row["materialType"] = material["type"];
                            row["mix"] = material["mix"];
                            row["nc_use"] = material["nc_use"];
                            row["sap_code"] = material["sap_code"];
                            //row["typeid"] = material["typeid"];

                            Items.Tables["items"].Rows.Add(row);
                            Items.Tables["items"].AcceptChanges();

                            //grdv_mp.SetRowCellValue((Items.Tables["items"].Rows.Count - 1), col_material, material["id"]);

                            set_items_index();

                            calculate_formula_inclusion();
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_items_index() 
        {
            if (Items.Tables["items"].Rows.Count > 0) 
            {
                foreach (DataRow row1 in Items.Tables["items"].Rows) 
                {
                    row1["index"] = row1.Table.Rows.IndexOf(row1);
                }
            }
        }

        private void GetEspecies()
        {
            try
            {
                string query = @"SELECT [id]
                                       ,[Descripcion]
                                   FROM [Conf_Especies]";

                cmb_especie.Properties.DataSource = dp.ACS_GetSelectData(query).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool formula_exist() 
        {
            try
            {
                string query = string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [version] = {1} AND [tipo] = '{2}'", txt_Codigo.Text.ToString(), txt_versionFormula.Text.ToString(), formType);

                if (Convert.ToInt32(dp.ACS_GetSelectData(query).Tables[0].Rows[0][0].ToString()) > 0 && FormAction != "edit")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private int save_main()
        {
            try
            {
                #region Save de Formula Main Information
                //*************SAVE FORMULA HEADER***********

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@codigo_i", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@creado", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@format_id", SqlDbType.Int));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@codigo"].Value = int.Parse(txt_Codigo.Text.ToString());
                cmd.Parameters["@codigo_i"].Value = int.Parse(txt_CodigoInterno.Text.ToString());
                cmd.Parameters["@version"].Value = int.Parse(txt_versionFormula.Text.ToString());
                cmd.Parameters["@nombre"].Value = txt_descripcion.Text.ToString();
                cmd.Parameters["@especie"].Value = int.Parse(cmb_especie.EditValue.ToString());
                cmd.Parameters["@creado"].Value = ActiveUserCode;
                cmd.Parameters["@modificado"].Value = ActiveUserCode;
                //cmd.Parameters["@comment"].Value = txt_comment.Text.ToString();
                cmd.Parameters["@estado"].Value = 30;
                cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
                cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;
                cmd.Parameters["@format_id"].Value = sel_parent_formula;

                if (formType == "FB") 
                {
                    sel_local_formula = dp.ACS_Exec_SP_GetID("FM_FB_Insert_Main", cmd, param);
                }
                else if (formType == "NC") 
                {
                    cmd.Parameters.Add(new SqlParameter("@cons_due_date", SqlDbType.Bit));
                    cmd.Parameters["@cons_due_date"].Value = chk_cons_due_date.EditValue;

                    sel_local_formula = dp.ACS_Exec_SP_GetID("FM_NC_Insert_Main", cmd, param);
                }

                return sel_local_formula;

                //*******************************************
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void save_structure(int formula_id)
        {
            try
            {
                SqlCommand cmd;

                #region Delete Formula Lines if Already Exist
                //*************DELETE FORMULA LINES****************

                if (FormAction == "edit")
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

                    cmd.Parameters["@id_formula"].Value = formula_id;

                    dp.ACS_Exec_SP("FM_Formula_Delete_Lines", cmd);
                }

                //*************************************************
                #endregion

                #region Insert Formula Structure
                //*************INSERT FORMULA STRUCTURE****************

                foreach (DataRow row in Items.Tables[0].Rows)
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@type", SqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@item", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@inclusion", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@peso_batch", SqlDbType.Decimal));

                    cmd.Parameters["@type"].Value = row["materialType"].ToString();
                    cmd.Parameters["@item"].Value = int.Parse(row["id_item"].ToString());
                    cmd.Parameters["@formula"].Value = formula_id;
                    cmd.Parameters["@inclusion"].Value = Convert.ToDecimal(row["inclusion"].ToString());
                    cmd.Parameters["@peso_batch"].Value = Convert.ToDecimal(row["peso"].ToString()); ;

                    dp.ACS_Exec_SP("FM_Insert_Structure", cmd);
                }
                //*************************************************
                #endregion

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información de estructura de la formula (save_structure)\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int auto_save_main(string type, string formula_name)
        {
            try
            {
                #region Save de Formula Main Information
                //*************SAVE FORMULA HEADER***********

                int version = (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [tipo] = '{1}'", parent_formula_main.Rows[0]["src_formula_code"], type)).Tables[0].Rows[0][0].ToString()));
                if (version <= 0)
                {
                    version = 0;
                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@codigo_i", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@creado", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
                //cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@format_id", SqlDbType.Int));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@codigo"].Value = int.Parse(txt_Codigo.Text.ToString());
                cmd.Parameters["@codigo_i"].Value = int.Parse(txt_CodigoInterno.Text.ToString());
                cmd.Parameters["@version"].Value = version;
                cmd.Parameters["@nombre"].Value = formula_name;
                cmd.Parameters["@especie"].Value = int.Parse(cmb_especie.EditValue.ToString());
                cmd.Parameters["@creado"].Value = ActiveUserCode;
                cmd.Parameters["@modificado"].Value = ActiveUserCode;
                //cmd.Parameters["@comment"].Value = txt_comment.Text.ToString();
                cmd.Parameters["@estado"].Value = 30;
                cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
                cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;
                cmd.Parameters["@format_id"].Value = sel_parent_formula;

                if (type == "FB")
                {
                    sel_local_formula = dp.ACS_Exec_SP_GetID("FM_FB_Insert_Main", cmd, param);
                }
                else if (type == "NC")
                {
                    cmd.Parameters.Add(new SqlParameter("@cons_due_date", SqlDbType.Bit));
                    cmd.Parameters["@cons_due_date"].Value = true;

                    sel_local_formula = dp.ACS_Exec_SP_GetID("FM_NC_Insert_Main", cmd, param);
                }

                return sel_local_formula;

                //*******************************************
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void auto_save_structure(int formula_id, DataTable fml_mat)
        {
            try
            {
                SqlCommand cmd;

                #region Insert Formula Structure
                //*************INSERT FORMULA STRUCTURE****************

                foreach (DataRow row in fml_mat.Rows)
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@type", SqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new SqlParameter("@formula", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@item", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@inclusion", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@peso_batch", SqlDbType.Decimal));

                    cmd.Parameters["@type"].Value = row["materialType"].ToString();
                    cmd.Parameters["@item"].Value = int.Parse(row["id_item"].ToString());
                    cmd.Parameters["@formula"].Value = formula_id;
                    double de = Double.Parse(row["inclusion"].ToString());
                    decimal valor = (decimal)de;
                    cmd.Parameters["@inclusion"].Value = valor.ToString();
                    cmd.Parameters["@peso_batch"].Value = Convert.ToDecimal(row["peso"].ToString()); ;

                    dp.ACS_Exec_SP("FM_Insert_Structure", cmd);
                }
                //*************************************************
                #endregion

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información de estructura de la formula. (auto_save_structure) \nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_comments(int formula_id) 
        {
            try
            {
                if (comments.Rows.Count > 0) 
                {
                    foreach (DataRow row in comments.Rows) 
                    {
                        if ((Boolean)row["is_new"]) 
                        {
                            fmop.local_formula_comment_entry(formula_id, int.Parse(ActiveUserCode), row["comment"].ToString(), false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar los comentarios.\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_main(int formula_id) 
        {
            try
            {
                #region Update Formula Main Information
                /******************************UPDATE HEADER INFO******************************/

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));

                cmd.Parameters["@id_formula"].Value = formula_id;
                cmd.Parameters["@nombre"].Value = txt_descripcion.Text.ToString();
                cmd.Parameters["@code"].Value = int.Parse(txt_Codigo.Text.ToString());
                cmd.Parameters["@version"].Value = int.Parse(txt_versionFormula.Text.ToString());
                cmd.Parameters["@modificado"].Value = int.Parse(ActiveUserCode);
                cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
                cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;

                dp.ACS_Exec_SP("FM_FB_Update_Header", cmd);

                /******************************************************************************/
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DEPRECATED
        private void update_structure(int formula_id)
        {
            try
            {
                #region Delete Current Structure
                /******************************DELETE CURRENT STRUCTURE*************************/

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

                cmd.Parameters["@id_formula"].Value = formula_id;

                dp.ACS_Exec_SP("FM_FB_Delete_Lines", cmd);

                /******************************************************************************/
                #endregion

                #region Save New Lines

                save_structure(formula_id);

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validate_and_save() 
        {
            try
            {
                #region If Formula is new or a copy
                if (FormAction == "new" || FormAction == "copy")
                {
                    int id = save_main();
                    save_structure(id);
                    save_comments(id);
                    fmop.local_formula_event_entry(id, int.Parse(ActiveUserCode), "INI", "Formula Creada");

                    control_variacion(id);   // JV 2017-05-2017
                    //if (formType == "FB") 
                    //{
                    //    Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);
                    //    if (variation_index >= 0.01 || variation_index <= -0.01)
                    //    {
                    //        if (fmop.local_formula_get_status(sel_local_formula) != 39)
                    //        {
                    //            fmop.local_formula_change_status(id, int.Parse(ActiveUserCode), 39);
                    //            fmop.local_formula_clean_approvals(id);
                    //            fmop.local_formula_event_entry(id, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
                    //            fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), id, sel_parent_formula);
                    //            MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        }
                    //    }
                    //}

                    if (FormAction == "new")
                        MessageBox.Show("Formula Creada con Éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Formula Copiada con Éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                #endregion

                #region If Formula is beeing modified
                else if (FormAction == "edit")
                {
                    update_main(sel_local_formula);
                    //update_structure(sel_local_formula);
                    save_structure(sel_local_formula);
                    save_comments(sel_local_formula);
                    fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "MOD", "Formula Modificada");

                    control_variacion(0);   // JV 2017-05-2017
                    //if(formType == "FB")
                    //{
                    //    Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);
                    //    if (variation_index >= 0.01 || variation_index <= -0.01)
                    //    {
                    //        if (fmop.local_formula_get_status(sel_local_formula) != 39)
                    //        {
                    //            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 39);
                    //            fmop.local_formula_clean_approvals(sel_local_formula);
                    //            fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
                    //            fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), sel_local_formula, sel_parent_formula);
                    //            MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        }
                    //    }
                    //    else 
                    //    {
                    //        if (fmop.local_formula_get_status(sel_local_formula) == 39) 
                    //        {
                    //            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
                    //            fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "PRD");
                    //            fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "FIN");
                    //            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
                    //        }
                    //    }
                    //}

                    MessageBox.Show("Formula Actualizada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculate_formula_inclusion() 
        {
            try
            {
                #region Calculate Formula Inclusion

                Double totalWeight = 0;
                foreach (DataRow row in Items.Tables[0].Rows)
                {
                    totalWeight += Convert.ToDouble(row["peso"]);
                }

                foreach (DataRow row in Items.Tables[0].Rows)
                {
                    row["inclusion"] = (Convert.ToDouble(row["peso"]) / totalWeight); 
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void approve_reject_process(string action, string approver_type)
        {
            try
            {
                int current_status = fmop.local_formula_get_status(sel_local_formula);
                if (current_status >= 30 && current_status < 40)
                {
                    int count = 0;

                    if (current_status == 39)
                    {
                        approver_type = null;

                        foreach (DataRow row in UserGroups.Rows)
                        {
                            if (row["GroupName"].ToString().Trim() == "app_acs_fml_approver_fin")
                            {
                                approver_type = "FIN";
                                count++;
                            }
                            else if (row["GroupName"].ToString().Trim() == "app_acs_fml_approver_prd")
                            {
                                approver_type = "PRD";
                                count++;
                            }
                        }

                        if (count == 1)
                        {
                            if (!fmop.local_formula_exist_approve(sel_local_formula, approver_type))
                            {
                                if (action == "approve")
                                {
                                    if (MessageBox.Show("¿Seguro que deseas aprobar esta formula?", "Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "APR", "Formula Aprobada.");
                                        MessageBox.Show("Formula Aprobada.", "Aprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else if (action == "reject")
                                {
                                    if (MessageBox.Show("¿Seguro que desear rechazar la formula?", "Rechazo de Formula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_reject(sel_local_formula, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "APR", "Formula Rechazada");
                                        MessageBox.Show("Formula rechazada y puesta en revisión.", "Rechazo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                if (approver_type == "FIN")
                                    MessageBox.Show("Esta formula ya tiene aprobación Financiera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (approver_type == "PRD")
                                    MessageBox.Show("Esta formula ya tiene aprobación Productiva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Parece que existen problemas con tus permisos de aprobador. Contacta al departamento de sistemas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (count < 1)
                        {
                            if (action == "approve")
                                MessageBox.Show("No tienes permiso para aprobar una formula.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (action == "reject")
                                MessageBox.Show("No tienes permiso para rechazar una formula.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        //SE COMENTA PARA RELEASE 1
                        //approver_type = null;
                        //count = 0;//VALOR DEFAULT ES 0, SE CAMBIA A 1 PARA RELASE 1

                        //SE COMENTA PARA RELEASE 1
                        //foreach (DataRow row in UserGroups.Rows)
                        //{
                        //    if (row["GroupName"].ToString().Trim() == "app_acs_fml_approver_fin")
                        //    {
                        //        approver_type = "FIN";
                        //        count++;
                        //    }
                        //    else if (row["GroupName"].ToString().Trim() == "app_acs_fml_approver_prd")
                        //    {
                        //        approver_type = "PRD";
                        //        count++;
                        //    }
                        //}

                        count = 1;

                        if (count == 1)
                        {
                            if (!fmop.local_formula_exist_approve(sel_local_formula, approver_type))
                            {
                                if (action == "approve")
                                {
                                    if (MessageBox.Show("¿Seguro que deseas aprobar esta formula?", "Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "APR", "Formula Aprobada.");
                                        MessageBox.Show("Formula Aprobada.", "Aprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else if (action == "reject")
                                {
                                    if (MessageBox.Show("¿Seguro que desear rechazar la formula?", "Rechazo de Formula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_reject(sel_local_formula, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "APR", "Formula Rechazada");
                                        MessageBox.Show("Formula rechazada y puesta en revisión.", "Rechazo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                if (approver_type == "FIN")
                                    MessageBox.Show("Esta formula ya tiene aprobación Financiera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (approver_type == "PRD")
                                    MessageBox.Show("Esta formula ya tiene aprobación Productiva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Parece que existen problemas con tus permisos de aprobador. Contacta al departamento de sistemas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (count < 1)
                        {
                            if (action == "approve")
                                MessageBox.Show("No tienes permiso para aprobar una formula.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (action == "reject")
                                MessageBox.Show("No tienes permiso para rechazar una formula.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }                    
                }
                else
                {
                    if (current_status >= 1 && current_status < 20)
                        MessageBox.Show("Aún no se ha solicitado aprobación para esta formula.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (current_status >= 20 && current_status < 30)
                        MessageBox.Show("No puedes aprobar o rechazar una formula que esta pendiente de revisión.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (current_status >= 40 && current_status < 80)
                    {
                        if (action == "approve")
                            MessageBox.Show("Esta formula ya ha sido aprobada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (action == "reject")
                            MessageBox.Show("No puedes rechazar una formula ya aprobada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (current_status >= 80 && current_status < 99)
                        MessageBox.Show("No puedes aprobar ó rechazar una formula descontinuada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grid_autoajustar()
        {
            grdv_mp.OptionsView.ColumnAutoWidth = false;
            grdv_mp.BestFitColumns();
            GridViewInfo viewInfo = grdv_mp.GetViewInfo() as GridViewInfo;
            if (viewInfo.ViewRects.ColumnTotalWidth < viewInfo.ViewRects.ColumnPanelWidth)
                grdv_mp.OptionsView.ColumnAutoWidth = true;
        }

        //------------------------------------------------------------------------------------------------------
        #endregion

        #region Form Constructors
        //------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor Normal, no especifica tipo de formula, usado para Nueva Formula.
        /// </summary>
        /// <param name="ActiveUserCode">ID del usuario activo</param>
        /// <param name="ActiveUserName">Nombre del usuario activo</param>
        /// <param name="ActiveUserType">Tipo o Role de Usuario</param>
        /// <param name="FormAction">string describiendo la accion a realizar por el form "new" o "edit"</param>
        public FML_NewFormula_v3(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string FormAction, string Formtype, int parent_formula)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
            this.formType = Formtype;
            this.sel_parent_formula = parent_formula;
           
        }

        /// <summary>
        /// Constructor para especificar el tipo de formula, Usado especificamente para editar y visualizar formulas ya creadas
        /// </summary>
        /// <param name="ActiveUserCode">ID del usuario activo</param>
        /// <param name="ActiveUserName">Nombre del usuario activo</param>
        /// <param name="ActiveUserType">Tipo o Role de Usuario</param>
        /// <param name="FormAction">string describiendo la accion a realizar por el form "new" o "edit"</param>
        /// <param name="selIdFormula">ID de la formula a Editar</param>
        /// <param name="Formtype"> Tipo de Formula a Editar </param>
        public FML_NewFormula_v3(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string FormAction, int sel_local, int sel_parent, string Formtype, DataTable UserGroups)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
            this.sel_local_formula = sel_local;
            this.sel_parent_formula = sel_parent;
            this.formType = Formtype;
            this.UserGroups = UserGroups;
            navigationPane1.TabIndex = 4;
        }
        //------------------------------------------------------------------------------------------------------
        #endregion

        #region Form Events
        //------------------------------------------------------------------------------------------------------
        private void FML_NewFormula_v3_Load(object sender, EventArgs e)
        {
            try
            {
                
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                #region Complete Load Process

                load_source_formula();

                if (formType == "NC")
                {
                    chk_cons_due_date.Visible = true;
                    txt_nc_code.Visible = true;
                    lbl_nc_code.Visible = true;
                    btn_NCBuildReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_ManualAdditionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else if(formType == "FB")
                {
                    chk_cons_due_date.Visible = false;
                    txt_nc_code.Visible = false;
                    lbl_nc_code.Visible = false;
                    btn_NCBuildReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_ManualAdditionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }

                if (FormAction == "new") 
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();

                    //dt_desde.EditValue = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));
                    dt_desde.EditValue = DateTime.Now;

                    btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_removeNotNec.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_ManualAdditionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    if (formType == "FB")
                        btn_AutoGenerate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    gen_local_formula();

                    Gen_Cod_interno_automatico();
                }
                else if (FormAction == "edit") 
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();

                    dt_desde.EditValue = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));

                    cmb_especie.Enabled = false;
                    cmb_especie.ReadOnly = true;
                    txt_CodigoInterno.Enabled = false;
                    btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    comments = fmop.local_formula_get_comments(sel_local_formula);
                    events = fmop.local_formula_get_events(sel_local_formula);
                    load_local_formula();
                }
                else if (FormAction == "copy")
                {
                    Comments_Initialize_DataSet();
                }
                else if (FormAction == "approve")
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();
                    cmb_especie.Enabled = false;
                    cmb_especie.ReadOnly = true;
                    btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Aprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    txt_CodigoInterno.Enabled = false;
                    comments = fmop.local_formula_get_comments(sel_local_formula);
                    events = fmop.local_formula_get_events(sel_local_formula);
                    load_local_formula();
                }
                else if (FormAction == "view") 
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();

                    cmb_especie.Enabled = false;
                    cmb_especie.ReadOnly = true;
                    dt_desde.Enabled = false;
                    txt_CodigoInterno.Enabled = false;
                    btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_Aprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    comments = fmop.local_formula_get_comments(sel_local_formula);
                    events = fmop.local_formula_get_events(sel_local_formula);
                    load_local_formula();
                }
                else if (FormAction == "view_cost")
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();

                    cmb_especie.Enabled = false;
                    cmb_especie.ReadOnly = true;
                    dt_desde.Enabled = false;
                    txt_CodigoInterno.Enabled = false;
                    btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_Aprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    col_int_incl_cost.Visible = true;

                    comments = fmop.local_formula_get_comments(sel_local_formula);
                    events = fmop.local_formula_get_events(sel_local_formula);
                    load_local_formula();
                }
                grid_autoajustar();

                #region General Actions

                grd_comments.DataSource = comments;
                grd_events.DataSource = events;

                #endregion

                #endregion

                SplashScreenManager.CloseForm();

                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                string query = "select cast(GETDATE() as date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                dt_desde.EditValue = Convert.ToDateTime(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }

        private void Gen_Cod_interno_automatico()
        {
            try
            {
                //txt_CodigoInterno
                //txt_Codigo
                if (txt_Codigo.Text.Length >= 3)
                {
                    txt_CodigoInterno.Text = txt_Codigo.Text.Substring(txt_Codigo.Text.Length - 3, 3);
                }
            }
            catch (Exception ec)
            {

            }
        }

        private void cmb_RawMaterial_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                row_material = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;

                MessageBox.Show("row_material: " + row_material);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdv_mp_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                /////*METODO ORIGINAL*/
                //////------------------------------------------------------------------------------
                ////int lin = (grdv_mp.GetVisibleIndex(grdv_mp.FocusedRowHandle));

                ////if (lin > 0) 
                ////{
                ////    if (lin == Items.Tables[0].Rows.Count)
                ////        lin = lin - 1;
                ////}
                ////else
                ////    lin = 0;

                ////Items.Tables[0].AcceptChanges();

                ////Items.Tables[0].Rows[lin]["id_item"] = row_material["id"];
                ////Items.Tables[0].Rows[lin]["codigo"] = row_material["code"];
                ////Items.Tables[0].Rows[lin]["materialType"] = row_material["type"];
                ////Items.Tables[0].Rows[lin]["mix"] = row_material["mix"];

                ///*NUEVO METODO*/
                ////------------------------------------------------------------------------------
                //int lin = (grdv_mp.GetVisibleIndex(grdv_mp.FocusedRowHandle));

                //if (lin > 0)
                //{
                //    if (lin == Items.Tables[0].Rows.Count)
                //        lin = lin - 1;
                //}
                //else
                //    lin = 0;

                //if (lin == -1)
                //{
                //    Items.Tables[0].Rows[lin]["id_item"]                = row_material["id"];
                //    Items.Tables[0].Rows[lin]["codigo"]                 = row_material["code"];
                //    Items.Tables[0].Rows[lin]["materialType"]           = row_material["type"];
                //    Items.Tables[0].Rows[lin]["mix"]                    = row_material["mix"];
                //}
                //else 
                //{
                //    Items.Tables[0].Rows[selectedIndex]["id_item"]      = row_material["id"];
                //    Items.Tables[0].Rows[selectedIndex]["codigo"]       = row_material["code"];
                //    Items.Tables[0].Rows[selectedIndex]["materialType"] = row_material["type"];
                //    Items.Tables[0].Rows[selectedIndex]["mix"]          = row_material["mix"];
                //}

                //Items.Tables[0].AcceptChanges();

                #region Calculate Formula Inclusion

                set_items_index();

                calculate_formula_inclusion();

                #endregion
                //------------------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                if(ex.HResult != -2147467261)
                    MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grd_mp_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as DevExpress.XtraGrid.GridControl;
                var view = grid.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (e.KeyData == Keys.Delete)
                {
                    view.DeleteSelectedRows();
                    e.Handled = true;
                    Items.Tables[0].AcceptChanges();
                    
                    set_items_index();

                    calculate_formula_inclusion();
                    btn_AutoGenerate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!formula_exist())
                {
                    if (cmb_especie.EditValue != null)
                    {
                        if (txt_descripcion.Text != "")
                        {
                            DateTime current_date = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()).ToShortDateString());
                            DateTime available_date = Convert.ToDateTime(dt_desde.EditValue);
                            DateTime due_date = Convert.ToDateTime(dt_hasta.EditValue);
                            if (available_date.Date >= current_date.Date)
                            {
                                if (available_date < due_date)
                                {
                                    if (Items.Tables[0].Rows.Count > 0)
                                    {
                                        Double peso = 0;
                                        foreach (DataRow row in Items.Tables[0].Rows)
                                        {
                                            if (formType == "FB")
                                                peso += Convert.ToDouble(row["peso"]);
                                            else
                                                peso += Convert.ToDouble(row["inclusion"]);
                                        }

                                        peso = Math.Round(peso, 2);

                                        if (peso >= 2500 && formType == "FB")
                                        {
                                            validate_and_save();
                                        }
                                        else if ((peso >= 0.99 && peso <= 1.01) && formType == "NC")
                                        {
                                            validate_and_save();
                                        }
                                        else
                                        {
                                            if (formType == "FB")
                                            {
                                                if (MessageBox.Show("El peso de la formula es menor al peso de una parada estandar (2500 kg.).\n¿Deseas guardar la formula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                                {
                                                    validate_and_save();
                                                }
                                            }
                                            else if (formType == "NC")
                                            {
                                                MessageBox.Show("La información del Nucleo o Pre-Mezcla, debe completar el 100% de inclusion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No puedes guardar una formula sin ingredientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La fecha de vencimiento debe ser mayor a la fecha disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La fecha disponible no puede ser una fecha anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debes especificar una descripción para la formula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La especie de la formula debe ser especificada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("El codigo de formula especificado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // control_variacion(0);   // JV 2017-05-2017   // naaa no era necesario esto..

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_addcomment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FML_Comment_Add form = new FML_Comment_Add("normal");
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                {
                    DataRow row = comments.NewRow();
                    row["comment_on"] = DateTime.Now;
                    row["nombre"] = ActiveUserName;
                    row["comment"] = form.Comment;
                    row["is_reject"] = false;
                    row["is_new"] = true;

                    comments.Rows.Add(row);
                    comments.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Aprove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int current_status = fmop.local_formula_get_status(sel_local_formula);
            Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);

            if ((current_status >= 30 && current_status < 39) && (variation_index <= 0.01 || variation_index >= -0.01))
            {
                fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
                fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "PRD");
                fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "FIN");
                fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 40);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else 
            {
                if(current_status == 39)
                    approve_reject_process("approve", "PRD");
            }

            //METODO DE APROBACION PARA RELASE 1
            //approve_reject_process("approve", "FIN");
        }

        private void btn_reject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int current_status = fmop.local_formula_get_status(sel_local_formula);
            Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);

            if ((current_status >= 30 && current_status < 39) && (variation_index <= 0.01 || variation_index >= -0.01))
            {
                fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
                fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "PRD");
                fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "FIN");
                fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 40);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                if (current_status == 39)
                    approve_reject_process("reject", "PRD");
            }

            //METODO DE RECHAZO PARA RELASE 1
            //approve_reject_process("reject", "FIN");
        }

        private void grdv_mp_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (formType == "NC")
                {
                    btnc_calcPremix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    if (selected_type == "MP")
                    {
                        btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
                    else if (selected_type == "NC")
                    {
                        btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                }
                else if (formType == "FB")
                {
                    btnc_calcPremix.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    if (selected_type == "MP")
                    {
                        btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
                    else if (selected_type == "NC" ) 
                    {
                        btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        if (FormAction != "view")       // Agregado 2017-05-25
                            btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                }

                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void grdv_mp_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selected_type = grdv_mp.GetDataRow(e.FocusedRowHandle)["materialType"].ToString();
                selected_line_id = int.Parse(grdv_mp.GetDataRow(e.FocusedRowHandle)["id_item"].ToString());
                selectedIndex = int.Parse(grdv_mp.GetDataRow(e.FocusedRowHandle)["index"].ToString());
                selected_wheight = Convert.ToDouble(grdv_mp.GetDataRow(e.FocusedRowHandle)["peso"].ToString());
                selected_mat_code = grdv_mp.GetDataRow(e.FocusedRowHandle)["codigo"].ToString();
                sel_nc_use = Convert.ToBoolean(grdv_mp.GetDataRow(e.FocusedRowHandle)["nc_use"].ToString());
            }
            catch { }
        }

        private void btnc_calcPremix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Double total_kg = 0;
                if (Items.Tables["items"].Rows.Count > 1)
                {
                    foreach (DataRow row in Items.Tables["items"].Rows) 
                    {
                        total_kg += Convert.ToDouble(row["peso"].ToString());
                    }

                    if (total_kg >= 1)
                    {
                        //foreach (DataRow row in Items.Tables["items"].Rows)
                        //{
                        //    row["peso"] = ((Convert.ToDouble(row["peso"].ToString()) / total_kg) * 100);
                        //}

                        calculate_formula_inclusion();
                    }
                    else
                    {
                        MessageBox.Show("El peso debe ser mayor a 0.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                    MessageBox.Show("Hay muy pocos ingredientes para realizar esta acción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_premixStructure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_NC_Structure_View form = new FML_NC_Structure_View(selected_line_id, selected_wheight);
            form.ShowDialog();
        }

        private void grdv_mp_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            grdv_mp.RefreshEditor(true);
            calculate_formula_inclusion();
        }

        private void grdv_mp_ColumnPositionChanged(object sender, EventArgs e)
        {
            grdv_mp.RefreshEditor(true);
        }

        private void btn_AddMaterial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_Material_Selector form = new FML_Material_Selector(material_list);
            form.ShowDialog();
        }

        private void btnc_editNC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int status;
                int real_id;

                if (selected_line_id > 0)
                {
                    status = fmop.local_formula_get_status(selected_line_id);
                    real_id = selected_line_id;
                }
                else 
                {
                    real_id = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT [id] FROM [dbo].[FML_Formulas_v2] WHERE [nc_code] = '{0}''", selected_mat_code)).Tables[0].Rows[0][0].ToString());
                    status = fmop.local_formula_get_status(real_id);   
                }

                if (status >= 1 && status < 40)
                {
                    FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", real_id, sel_parent_formula, selected_type, UserGroups);
                    fm.ShowDialog();
                }
                else
                {
                    if (status >= 40 && status < 50)
                        MessageBox.Show("Aparentemente este nucleo aprobado y listo para usar, no puede ser editado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (status >= 50 && status < 90)
                        MessageBox.Show("Aparentemente este nucleo ya ha sido procesado, no puede ser editado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (status >= 90)
                        MessageBox.Show("No puedes editar un nucleo descontinuado o eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AutoGenerate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashForm frmProceso = new SplashForm(50);
            try
            {
                if (grdv_mp.RowCount <= 0) return;

                //SplashScreenManager.ShowForm(typeof(WaitForm1));
                frmProceso.ShowDialog();

                if (!formula_exist())
                {
                    if (cmb_especie.EditValue != null)
                    {
                        if (txt_descripcion.Text != "")
                        {
                            DateTime current_date = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()).ToShortDateString());
                            DateTime available_date = Convert.ToDateTime(dt_desde.EditValue);
                            DateTime due_date = Convert.ToDateTime(dt_hasta.EditValue);
                            if (available_date.Date >= current_date.Date)
                            {
                                if (available_date < due_date)
                                {
                                    if (Items.Tables[0].Rows.Count > 0)
                                    {
                                        #region Formula auto-Generate

                                        #region Separate Materials

                                        DataTable FB = Items.Tables[0].Copy();
                                        DataTable NC = Items.Tables[0].Copy();

                                        foreach (DataRow row in FB.Rows) 
                                        {
                                            if (Convert.ToBoolean(row["nc_use"]) == true) 
                                            {
                                                row.Delete();
                                                //FB.AcceptChanges();
                                            }
                                        }
                                        FB.AcceptChanges();

                                        foreach (DataRow row in NC.Rows)
                                        {
                                            if (Convert.ToBoolean(row["nc_use"]) == false)
                                            {
                                                row.Delete();
                                                //NC.AcceptChanges();
                                            }
                                        }
                                        NC.AcceptChanges();

                                        #endregion

                                        #region Save NC

                                        #region Re-Calculate NC Inclusion Factor

                                        Double totalWeight_NC = 0;
                                        foreach (DataRow row in NC.Rows)
                                        {
                                            totalWeight_NC += Convert.ToDouble(row["peso"]);
                                        }

                                        foreach (DataRow row in NC.Rows)
                                        {
                                            row["inclusion"] = (Convert.ToDouble(row["peso"]) / totalWeight_NC) ;
                                        }
                                        #endregion

                                        int inserted_nc = auto_save_main("NC", ("Núcleo - " + txt_descripcion.Text));
                                        auto_save_structure(inserted_nc, NC);
                                        fmop.local_formula_event_entry(inserted_nc, int.Parse(ActiveUserCode), "INI", "Formula Creada (Auto-Generada)");

                                        #endregion

                                        #region Save FB

                                        #region Add NC to Structure

                                        DataRow fbrow = FB.NewRow();

                                        fbrow["id"] = -1;
                                        fbrow["id_item"] = inserted_nc;
                                        fbrow["codigo"] = "";
                                        fbrow["material"] = ("NC - " + txt_descripcion.Text);
                                        fbrow["peso"] = totalWeight_NC;
                                        fbrow["materialType"] = "NC";
                                        fbrow["mix"] = "A";
                                        fbrow["nc_use"] = false;

                                        FB.Rows.Add(fbrow);

                                        FB.AcceptChanges();

                                        #endregion

                                        #region Re-Calculate FB Inclusion Factor

                                        Double totalWeight_FB = 0;
                                        foreach (DataRow row in FB.Rows)
                                        {
                                            totalWeight_FB += Convert.ToDouble(row["peso"]);
                                        }

                                        foreach (DataRow row in FB.Rows)
                                        {
                                            row["inclusion"] = (Convert.ToDouble(row["peso"]) / totalWeight_FB);
                                        }
                                        #endregion

                                        int inserted_fb = auto_save_main("FB", txt_descripcion.Text);
                                        auto_save_structure(inserted_fb, FB);
                                        fmop.local_formula_event_entry(inserted_fb, int.Parse(ActiveUserCode), "INI", "Formula Creada (Auto-Generada)");

                                        #endregion

                                        MessageBox.Show("Se ha generado con éxito la Formula Base y Núcleo.", "Operación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        FML_NewFormula_v3_Load(sender, new EventArgs());
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        //this.Close();

                                        #endregion
                                    }
                                    else
                                    {
                                        MessageBox.Show("No puedes guardar una formula sin ingredientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La fecha de vencimiento debe ser mayor a la fecha disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La fecha disponible no puede ser una fecha anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debes especificar una descripción para la formula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La especie de la formula debe ser especificada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("El codigo de formula especificado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                //SplashScreenManager.CloseForm();
                frmProceso.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SplashScreenManager.CloseForm();
                frmProceso.Close();
            }
        }

        private void btn_removeNotNec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                btn_AutoGenerate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                SplashScreenManager.ShowForm(typeof(WaitForm1));
                if (formType == "FB") 
                {
                    foreach (DataRow row in Items.Tables[0].Rows)
                    {
                        if (Convert.ToBoolean(row["nc_use"]) == true)
                        {
                            row.Delete();
                            //Items.AcceptChanges();
                        }
                    }
                    Items.AcceptChanges();
                }
                else if (formType == "NC") 
                {
                    foreach (DataRow row in Items.Tables[0].Rows)
                    {
                        if (Convert.ToBoolean(row["nc_use"]) == false)
                        {
                            row.Delete();
                            //Items.AcceptChanges();
                        }
                    }
                    Items.AcceptChanges();
                }

                set_items_index();
                calculate_formula_inclusion();

                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }

        private void btnc_NCReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                fmop.local_formula_gen_NC_Build_Report(selected_line_id, selected_wheight, true);
                fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "RPT", (string.Format("Reporte de Nucleo Creado Referencia:[ {0} ]", selected_line_id)));
                fmop.local_formula_event_entry(selected_line_id, int.Parse(ActiveUserCode), "RPT", "Reporte de Nucleo Creado");
            }
            catch (Exception) { throw; }
        }

        private void btn_NCBuildReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in Items.Tables[0].Rows) 
                {
                    selected_wheight += Convert.ToDouble(row["peso"].ToString());
                }

                fmop.local_formula_gen_NC_Build_Report(sel_local_formula, selected_wheight, true);
                fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "RPT", "Reporte de Nucleo Creado");
            }
            catch (Exception) { throw; }
        }

        private void btn_ManualAdditionReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                foreach (DataRow row in Items.Tables[0].Rows)
                {
                    selected_wheight += Convert.ToDouble(row["peso"].ToString());
                }

                fmop.local_formula_gen_Manual_RM_Report(sel_local_formula, true, txt_Codigo.Text, txt_CodigoInterno.Text, txt_versionFormula.Text);
                fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "RPT", "Reporte de Adiciones Manuales Creado");
            }
            catch (Exception) { throw; }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //SecOps sec = new SecOps();
                //sec.SendEmailAlert_SingleContact_GD("david.riega@aquafeedhn.com", 0, "Mensaje de Prueba del ACS", "", true);
                //MessageBox.Show("OK!");
                DataTable mails = new DataTable();
                mails.Columns.Add("address");
                DataRow row = mails.NewRow();
                row["address"] = "david.riega@aquafeedhn.com";
                mails.Rows.Add(row);
                //row = mails.NewRow();
                //row["address"] = "hector.suazo@aquafeedhn.com";
                //mails.Rows.Add(row);
                //row = mails.NewRow();
                //row["address"] = "jorge.piedrahita@aquafeedhn.com";
                //mails.Rows.Add(row);
                //row = mails.NewRow();
                //row["address"] = "jesus.valdiviezo@aquafeedhn.com";
                //mails.Rows.Add(row);
                mails.AcceptChanges();
                fmop.FML_BI_cost_variation_send_mail_alert(mails, sel_local_formula, sel_parent_formula);
                MessageBox.Show("OK!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------
        #endregion


        void control_variacion(int id) {
            #region FormAction == "new" || FormAction == "copy"
            if (FormAction == "new" || FormAction == "copy")
            {
                if (formType == "FB")
                {
                    Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);
                    if (variation_index >= 0.01 || variation_index <= -0.01)
                    {
                        if (fmop.local_formula_get_status(sel_local_formula) != 39)
                        {
                            fmop.local_formula_change_status(id, int.Parse(ActiveUserCode), 39);
                            fmop.local_formula_clean_approvals(id);
                            fmop.local_formula_event_entry(id, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
                            fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), id, sel_parent_formula);
                            MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            #endregion

            #region FormAction == "edit"
            if (FormAction == "edit") {
                if (formType == "FB")
                {
                    Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);
                    if (variation_index >= 0.01 || variation_index <= -0.01)
                    {
                        if (fmop.local_formula_get_status(sel_local_formula) != 39)
                        {
                            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 39);
                            fmop.local_formula_clean_approvals(sel_local_formula);
                            fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
                            fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), sel_local_formula, sel_parent_formula);
                            MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (fmop.local_formula_get_status(sel_local_formula) == 39)
                        {
                            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
                            fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "PRD");
                            fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "FIN");
                            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
                        }
                    }
                }
            }
            #endregion

        }

        private void cmdPrintComplete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RPTS.PRD.RPT_FB_Manual_RM_Complete report = new RPTS.PRD.RPT_FB_Manual_RM_Complete(sel_local_formula, 
                                                                                       this.txt_Codigo.Text,
                                                                                       this.txt_CodigoInterno.Text,
                                                                                       this.txt_versionFormula.Text,
                                                                                       this.txt_descripcion.Text,
                                                                                       this.cmb_especie.Text);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void cmdDetalleFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            RPTS.PRD.RPT_PRD_Formula_Local report = new RPTS.PRD.RPT_PRD_Formula_Local(sel_local_formula, 
                                                                                       this.txt_Codigo.Text,
                                                                                       this.txt_CodigoInterno.Text,
                                                                                       this.txt_versionFormula.Text,
                                                                                       this.txt_descripcion.Text,
                                                                                       this.cmb_especie.Text,
                                                                                       "");
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_original.ExportToXlsx(dialog.FileName);
            }
        }
    }
}