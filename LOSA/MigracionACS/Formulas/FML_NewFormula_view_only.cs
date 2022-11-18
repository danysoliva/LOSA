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

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_NewFormula_view_only : DevExpress.XtraEditors.XtraForm
    {
        

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
  

                parent_formula_main = fmop.ext_formula_get_main(sel_parent_formula);

               

                

                if(FormAction == "view_cost")
                    parent_formula_struct = fmop.ext_formula_get_structure_cost(sel_parent_formula);
                else
                    parent_formula_struct = fmop.ext_formula_get_structure(sel_parent_formula);
                //grd_original.DataSource = parent_formula_struct;

                
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
                

                local_formula_main = fmop.local_formula_get_main(sel_local_formula);

                //txt_Codigo.Text = local_formula_main.Rows[0]["codigo"].ToString();
                //txt_CodigoInterno.Text = local_formula_main.Rows[0]["codigo_i"].ToString();
                //txt_versionFormula.Text = local_formula_main.Rows[0]["version"].ToString();
                //txt_descripcion.Text = local_formula_main.Rows[0]["nombre"].ToString();
                //cmb_especie.EditValue = int.Parse(local_formula_main.Rows[0]["especie"].ToString());
                //dt_desde.EditValue = Convert.ToDateTime(local_formula_main.Rows[0]["available_date"].ToString());
                //dt_hasta.EditValue = Convert.ToDateTime(local_formula_main.Rows[0]["due_date"].ToString());
                //chk_cons_due_date.Checked = Convert.ToBoolean(local_formula_main.Rows[0]["cons_due_date"]);
                //txt_nc_code.Text = local_formula_main.Rows[0]["nc_code"].ToString();

                //txt_Codigo.Enabled = false;
                //txt_versionFormula.Enabled = false;
                //cmb_especie.Enabled = true;

                //txt_companyCode.Text = local_formula_main.Rows[0]["src_company_code"].ToString();
                

                

                

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
                    //row["typename"] = local["typename"];
                    //row["typeid"] = local["typeid"];

                    Items.Tables["items"].Rows.Add(row);
                    Items.Tables["items"].AcceptChanges();

                    //grdv_mp.SetRowCellValue((Items.Tables["items"].Rows.Count - 1), col_material, local["id_item"]);

                    //calculate_formula_inclusion();
                }

                

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
                

                //txt_Codigo.EditValue = int.Parse(parent_formula_main.Rows[0]["src_formula_code"].ToString());
                //txt_Codigo.Text = parent_formula_main.Rows[0]["src_formula_code"].ToString();

            
                
                //int qty = (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [tipo] = '{1}'", parent_formula_main.Rows[0]["src_formula_code"], formType)).Tables[0].Rows[0][0].ToString()));
                //if (qty <= 0)
                //{
                //    txt_versionFormula.EditValue = 0;
                //    txt_versionFormula.Text = "0";
                //}
                //else 
                //{
                //    txt_versionFormula.EditValue = (qty);
                //    txt_versionFormula.Text = (qty).ToString();
                //}
                
          

                //txt_descripcion.Text = parent_formula_main.Rows[0]["src_formula_name"].ToString();

               
                
                //if (parent_formula_main.Rows[0]["src_formula_name"].ToString().Substring(0, 2) == "AQ")
                //{
                //    cmb_especie.SelectedText = "Tilapia";
                //    cmb_especie.EditValue = 1;
                //}
                //else 
                //{
                //    cmb_especie.SelectedText = "Camarón";
                //    cmb_especie.EditValue = 2;
                //}

            

                //dt_desde.EditValue = dt_desde_source.EditValue;
                //dt_hasta.EditValue = dt_hasta_source.EditValue;

                

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
                            //row["typeid"] = material["typeid"];

                            Items.Tables["items"].Rows.Add(row);
                            Items.Tables["items"].AcceptChanges();

                            //grdv_mp.SetRowCellValue((Items.Tables["items"].Rows.Count - 1), col_material, material["id"]);

                            set_items_index();

                            calculate_formula_inclusion();
                        }
                    }
                }

                
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

                //cmb_especie.Properties.DataSource = dp.ACS_GetSelectData(query).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private bool formula_exist() 
        //{
        //    try
        //    {
        //        string query = string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [version] = {1} AND [tipo] = '{2}'", txt_Codigo.Text.ToString(), txt_versionFormula.Text.ToString(), formType);

        //        if (Convert.ToInt32(dp.ACS_GetSelectData(query).Tables[0].Rows[0][0].ToString()) > 0 && FormAction != "edit")
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return true;
        //    }
        //}

        //private int save_main()
        //{
        //    try
        //    {
        //        #region Save de Formula Main Information
        //        //*************SAVE FORMULA HEADER***********

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@codigo_i", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
        //        cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@creado", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
        //        //cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
        //        cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
        //        cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));
        //        cmd.Parameters.Add(new SqlParameter("@format_id", SqlDbType.Int));

        //        SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
        //        param.Direction = ParameterDirection.ReturnValue;

        //        cmd.Parameters["@codigo"].Value = int.Parse(txt_Codigo.Text.ToString());
        //        cmd.Parameters["@codigo_i"].Value = int.Parse(txt_CodigoInterno.Text.ToString());
        //        cmd.Parameters["@version"].Value = int.Parse(txt_versionFormula.Text.ToString());
        //        cmd.Parameters["@nombre"].Value = txt_descripcion.Text.ToString();
        //        cmd.Parameters["@especie"].Value = int.Parse(cmb_especie.EditValue.ToString());
        //        cmd.Parameters["@creado"].Value = ActiveUserCode;
        //        cmd.Parameters["@modificado"].Value = ActiveUserCode;
        //        //cmd.Parameters["@comment"].Value = txt_comment.Text.ToString();
        //        cmd.Parameters["@estado"].Value = 30;
        //        cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
        //        cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;
        //        cmd.Parameters["@format_id"].Value = sel_parent_formula;

        //        if (formType == "FB") 
        //        {
        //            sel_local_formula = dp.ACS_Exec_SP_GetID("FM_FB_Insert_Main", cmd, param);
        //        }
        //        else if (formType == "NC") 
        //        {
        //            cmd.Parameters.Add(new SqlParameter("@cons_due_date", SqlDbType.Bit));
        //            cmd.Parameters["@cons_due_date"].Value = chk_cons_due_date.EditValue;

        //            sel_local_formula = dp.ACS_Exec_SP_GetID("FM_NC_Insert_Main", cmd, param);
        //        }

        //        return sel_local_formula;

        //        //*******************************************
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return -1;
        //    }
        //}

        private void save_structure(int formula_id)
        {
            try
            {
                SqlCommand cmd;

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
                

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información de estructura de la formula (save_structure)\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private int auto_save_main(string type, string formula_name)
        //{
        //    try
        //    {
        //        #region Save de Formula Main Information
        //        //*************SAVE FORMULA HEADER***********

        //        int version = (int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT COUNT([id]) FROM [dbo].[FML_Formulas_v2] WHERE [codigo] = {0} AND [tipo] = '{1}'", parent_formula_main.Rows[0]["src_formula_code"], type)).Tables[0].Rows[0][0].ToString()));
        //        if (version <= 0)
        //        {
        //            version = 0;
        //        }

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@codigo_i", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 100));
        //        cmd.Parameters.Add(new SqlParameter("@especie", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@creado", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
        //        //cmd.Parameters.Add(new SqlParameter("@comment", SqlDbType.VarChar));
        //        cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
        //        cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));
        //        cmd.Parameters.Add(new SqlParameter("@format_id", SqlDbType.Int));

        //        SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
        //        param.Direction = ParameterDirection.ReturnValue;

        //        cmd.Parameters["@codigo"].Value = int.Parse(txt_Codigo.Text.ToString());
        //        cmd.Parameters["@codigo_i"].Value = int.Parse(txt_CodigoInterno.Text.ToString());
        //        cmd.Parameters["@version"].Value = version;
        //        cmd.Parameters["@nombre"].Value = formula_name;
        //        cmd.Parameters["@especie"].Value = int.Parse(cmb_especie.EditValue.ToString());
        //        cmd.Parameters["@creado"].Value = ActiveUserCode;
        //        cmd.Parameters["@modificado"].Value = ActiveUserCode;
        //        //cmd.Parameters["@comment"].Value = txt_comment.Text.ToString();
        //        cmd.Parameters["@estado"].Value = 30;
        //        cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
        //        cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;
        //        cmd.Parameters["@format_id"].Value = sel_parent_formula;

        //        if (type == "FB")
        //        {
        //            sel_local_formula = dp.ACS_Exec_SP_GetID("FM_FB_Insert_Main", cmd, param);
        //        }
        //        else if (type == "NC")
        //        {
        //            cmd.Parameters.Add(new SqlParameter("@cons_due_date", SqlDbType.Bit));
        //            cmd.Parameters["@cons_due_date"].Value = true;

        //            sel_local_formula = dp.ACS_Exec_SP_GetID("FM_NC_Insert_Main", cmd, param);
        //        }

        //        return sel_local_formula;

        //        //*******************************************
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return -1;
        //    }
        //}

        private void auto_save_structure(int formula_id, DataTable fml_mat)
        {
            try
            {
                SqlCommand cmd;

                
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
                    cmd.Parameters["@inclusion"].Value = Convert.ToDecimal(row["inclusion"].ToString());
                    cmd.Parameters["@peso_batch"].Value = Convert.ToDecimal(row["peso"].ToString()); ;

                    dp.ACS_Exec_SP("FM_Insert_Structure", cmd);
                }
                //*************************************************
                

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

        //private void update_main(int formula_id) 
        //{
        //    try
        //    {
        //        #region Update Formula Main Information
        //        /******************************UPDATE HEADER INFO******************************/

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
        //        cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@version", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@modificado", SqlDbType.Int));
        //        cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
        //        cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));

        //        cmd.Parameters["@id_formula"].Value = formula_id;
        //        cmd.Parameters["@nombre"].Value = txt_descripcion.Text.ToString();
        //        cmd.Parameters["@code"].Value = int.Parse(txt_Codigo.Text.ToString());
        //        cmd.Parameters["@version"].Value = int.Parse(txt_versionFormula.Text.ToString());
        //        cmd.Parameters["@modificado"].Value = int.Parse(ActiveUserCode);
        //        cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
        //        cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;

        //        dp.ACS_Exec_SP("FM_FB_Update_Header", cmd);

        //        /******************************************************************************/
        //        #endregion
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //DEPRECATED
        private void update_structure(int formula_id)
        {
            try
            {
                
                /******************************DELETE CURRENT STRUCTURE*************************/

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));

                cmd.Parameters["@id_formula"].Value = formula_id;

                dp.ACS_Exec_SP("FM_FB_Delete_Lines", cmd);

                /******************************************************************************/
                

                

                save_structure(formula_id);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            //private void validate_and_save() 
            //{
            //    try
            //    {
            //        #region If Formula is new or a copy
            //        if (FormAction == "new" || FormAction == "copy")
            //        {
            //            int id = save_main();
            //            save_structure(id);
            //            save_comments(id);
            //            fmop.local_formula_event_entry(id, int.Parse(ActiveUserCode), "INI", "Formula Creada");

            //            control_variacion(id);   // JV 2017-05-2017
            //            //if (formType == "FB") 
            //            //{
            //            //    Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);
            //            //    if (variation_index >= 0.01 || variation_index <= -0.01)
            //            //    {
            //            //        if (fmop.local_formula_get_status(sel_local_formula) != 39)
            //            //        {
            //            //            fmop.local_formula_change_status(id, int.Parse(ActiveUserCode), 39);
            //            //            fmop.local_formula_clean_approvals(id);
            //            //            fmop.local_formula_event_entry(id, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
            //            //            fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), id, sel_parent_formula);
            //            //            MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //        }
            //            //    }
            //            //}

            //            if (FormAction == "new")
            //                MessageBox.Show("Formula Creada con Éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            else
            //                MessageBox.Show("Formula Copiada con Éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //            this.Close();
            //        }
            //        #endregion

            //        #region If Formula is beeing modified
            //        else if (FormAction == "edit")
            //        {
            //            update_main(sel_local_formula);
            //            //update_structure(sel_local_formula);
            //            save_structure(sel_local_formula);
            //            save_comments(sel_local_formula);
            //            fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "MOD", "Formula Modificada");

            //            control_variacion(0);   // JV 2017-05-2017
            //            //if(formType == "FB")
            //            //{
            //            //    Double variation_index = fmop.FML_BI_get_cost_variation_index(sel_parent_formula, sel_local_formula);
            //            //    if (variation_index >= 0.01 || variation_index <= -0.01)
            //            //    {
            //            //        if (fmop.local_formula_get_status(sel_local_formula) != 39)
            //            //        {
            //            //            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 39);
            //            //            fmop.local_formula_clean_approvals(sel_local_formula);
            //            //            fmop.local_formula_event_entry(sel_local_formula, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
            //            //            fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), sel_local_formula, sel_parent_formula);
            //            //            MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //        }
            //            //    }
            //            //    else 
            //            //    {
            //            //        if (fmop.local_formula_get_status(sel_local_formula) == 39) 
            //            //        {
            //            //            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
            //            //            fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "PRD");
            //            //            fmop.local_formula_approve(sel_local_formula, int.Parse(ActiveUserCode), "FIN");
            //            //            fmop.local_formula_change_status(sel_local_formula, int.Parse(ActiveUserCode), 30);
            //            //        }
            //            //    }
            //            //}

            //            MessageBox.Show("Formula Actualizada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //            this.Close();
            //        }
            //        #endregion
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(string.Format("Error al guardar la información general de la formula\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        private void calculate_formula_inclusion() 
        {
            try
            {
                

                Double totalWeight = 0;
                foreach (DataRow row in Items.Tables[0].Rows)
                {
                    totalWeight += Convert.ToDouble(row["peso"]);
                }

                foreach (DataRow row in Items.Tables[0].Rows)
                {
                    row["inclusion"] = (Convert.ToDouble(row["peso"]) / totalWeight); 
                }

                
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
        
        //------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor Normal, no especifica tipo de formula, usado para Nueva Formula.
        /// </summary>
        /// <param name="ActiveUserCode">ID del usuario activo</param>
        /// <param name="ActiveUserName">Nombre del usuario activo</param>
        /// <param name="ActiveUserType">Tipo o Role de Usuario</param>
        /// <param name="FormAction">string describiendo la accion a realizar por el form "new" o "edit"</param>
        public FML_NewFormula_view_only(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string FormAction, string Formtype, int parent_formula)
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
        public FML_NewFormula_view_only(string ActiveUserCode, string ActiveUserName, string ActiveUserType, string FormAction, int sel_local, int sel_parent, string Formtype, DataTable UserGroups)
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
        }
        //------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------
        private void FML_NewFormula_view_only_Load(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                

                load_source_formula();

                if (formType == "NC")
                {
                    //chk_cons_due_date.Visible = true;
                    //txt_nc_code.Visible = true;
                    //lbl_nc_code.Visible = true;
                    //btn_NCBuildReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_ManualAdditionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else if(formType == "FB")
                {
                    //chk_cons_due_date.Visible = false;
                    //txt_nc_code.Visible = false;
                    //lbl_nc_code.Visible = false;
                    //btn_NCBuildReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_ManualAdditionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }

                if (FormAction == "new") 
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();

                    //dt_desde.EditValue = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));

                    //btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_removeNotNec.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_ManualAdditionReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //if (formType == "FB")
                    //    btn_AutoGenerate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    gen_local_formula();
                }
                else if (FormAction == "edit") 
                {
                    Items_Initialize_DataSet();
                    Comments_Initialize_DataSet();
                    Load_RawMaterials();
                    grd_mp.DataSource = Items.Tables[0];
                    GetEspecies();

                    //dt_desde.EditValue = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));

                    //cmb_especie.Enabled = false;
                    //cmb_especie.ReadOnly = true;
                    //txt_CodigoInterno.Enabled = false;
                    //btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

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
                    //cmb_especie.Enabled = false;
                    //cmb_especie.ReadOnly = true;
                    //btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_Aprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    //txt_CodigoInterno.Enabled = false;
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

                    //cmb_especie.Enabled = false;
                    //cmb_especie.ReadOnly = true;
                    //dt_desde.Enabled = false;
                    //txt_CodigoInterno.Enabled = false;
                    //btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_Aprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

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

                    //cmb_especie.Enabled = false;
                    //cmb_especie.ReadOnly = true;
                    //dt_desde.Enabled = false;
                    //txt_CodigoInterno.Enabled = false;
                    //btn_addcomment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_Aprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //btn_Save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    col_int_incl_cost.Visible = true;

                    comments = fmop.local_formula_get_comments(sel_local_formula);
                    events = fmop.local_formula_get_events(sel_local_formula);
                    load_local_formula();
                }
                grid_autoajustar();

                

                //grd_comments.DataSource = comments;
                //grd_events.DataSource = events;

                


                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }



        private void grdv_mp_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (formType == "NC")
                {
                    //btnc_calcPremix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //if (selected_type == "MP")
                    //{
                    //    btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //}
                    //else if (selected_type == "NC")
                    //{
                    //    btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //}
                }
                else if (formType == "FB")
                {
                    //btnc_calcPremix.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //if (selected_type == "MP")
                    //{
                    //    btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //}
                    //else if (selected_type == "NC" ) 
                    //{
                    //    btnc_premixStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    btnc_NCReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    btnc_rawMaterialInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    if (FormAction != "view")       // Agregado 2017-05-25
                    //        btnc_editNC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //}
                }

                //ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }



    }
       
}