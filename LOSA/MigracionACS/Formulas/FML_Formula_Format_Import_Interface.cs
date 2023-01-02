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
using System.IO;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Formula_Format_Import_Interface : DevExpress.XtraEditors.XtraForm
    {
        #region Form - Global Variables

        DataOperations dp = new DataOperations();
        DataSet materials = new DataSet();
        DataTable Files = new DataTable();
        int ErrorsOcurred = 0;
        string comment = "";
        string currentFileName = "";

        /******Datos Usuario*******/
        public string ActiveUserCode;
        public string ActiveUserName;
        public string ActiveUserType;

        bool isMasive = false;
        string filePath; 
        string fileName; 
        string fileLName;
        DateTime from_date;
        DateTime to_date;

        #endregion

        #region Constructors

        public FML_Formula_Format_Import_Interface(string ActiveUserCode, string ActiveUserName, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
        }


        public FML_Formula_Format_Import_Interface(string ActiveUserCode, string ActiveUserName, string ActiveUserType, bool isMasive,string filePath, string fileName, string fileLName, DateTime from, DateTime to)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;

            this.isMasive = isMasive;
            this.filePath = filePath;
            this.fileName = fileName;
            this.fileLName = fileLName;
            this.from_date = from;
            this.to_date = to;
        }

        #endregion

        #region Developer Defined Methods

        private DataSet gen_empty_detail() 
        {
            try
            {
                return dp.ACS_GetSelectData(@"SELECT [id]
                                                    ,[source_mat_code]
                                                    ,[source_mat_name]
                                                    ,[source_mat_group]
                                                    ,[source_mat_bin]
                                                    ,[source_inc_per]
                                                    ,[source_inc_per_cum]
                                                    ,[source_inc_kg]
                                                    ,[source_inc_kg_cum]
                                                    ,[source_mkt_rep_cost]
                                                    ,[local_rm]
                                                    ,[local_rm_match]
                                                FROM [dbo].[FML_Formulas_FF_D]
                                                WHERE [id] = 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorsOcurred++;
                return null;
            }
        }

        private DataSet Get_Default_Columns_Specs()
        {
            DataSet datos = new DataSet();
            datos.Tables.Add("ColumnData");
            datos.Tables["ColumnData"].Columns.Add("Column");
            datos.Tables["ColumnData"].Columns.Add("Order");
            datos.Tables["ColumnData"].Columns.Add("Visible");
            datos.Tables["ColumnData"].Columns.Add("Start");
            datos.Tables["ColumnData"].Columns.Add("Length");
            datos.Tables["ColumnData"].Columns.Add("Type");

            datos.Tables["ColumnData"].Columns["Column"].DataType = Type.GetType("System.String");
            datos.Tables["ColumnData"].Columns["Order"].DataType = Type.GetType("System.Int32");
            datos.Tables["ColumnData"].Columns["Visible"].DataType = Type.GetType("System.Boolean");
            datos.Tables["ColumnData"].Columns["Start"].DataType = Type.GetType("System.Int32");
            datos.Tables["ColumnData"].Columns["Length"].DataType = Type.GetType("System.Int32");
            datos.Tables["ColumnData"].Columns["Type"].DataType = Type.GetType("System.String");


            //***************************source_mat_code*****************************//
            DataRow row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_mat_code";
            row["Order"] = 1;
            row["Visible"] = true;
            row["Start"] = 0;
            row["Length"] = 10;
            row["Type"] = "String";

            datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_mat_name*****************************//
            row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_mat_name";
            row["Order"] = 2;
            row["Visible"] = true;
            row["Start"] = 11;
            row["Length"] = 27;
            row["Type"] = "String";

            datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_mat_group*****************************//
            //row = datos.Tables["ColumnData"].NewRow();

            //row["Column"] = "source_mat_group";
            //row["Order"] = 3;
            //row["Visible"] = true;
            //row["Start"] = 39;
            //row["Length"] = 10;
            //row["Type"] = "String";

            //datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_mat_bin*****************************//
            row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_mat_bin";
            row["Order"] = 4;
            row["Visible"] = true;
            row["Start"] = 39;//49;
            row["Length"] = 10;//11;
            row["Type"] = "String";

            datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_inc_per*****************************//
            row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_inc_per";
            row["Order"] = 5;
            row["Visible"] = true;
            row["Start"] = 50;//61;
            row["Length"] = 10;
            row["Type"] = "Double";

            datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_inc_per_cum*****************************//
            row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_inc_per_cum";
            row["Order"] = 6;
            row["Visible"] = true;
            row["Start"] = 61;//71;
            row["Length"] = 10;
            row["Type"] = "Double";

            datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_inc_kg*****************************//
            row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_inc_kg";
            row["Order"] = 7;
            row["Visible"] = true;
            row["Start"] = 72;//83;
            row["Length"] = 10;
            row["Type"] = "Double";

            datos.Tables["ColumnData"].Rows.Add(row);


            //***************************source_inc_kg_cum*****************************//
            row = datos.Tables["ColumnData"].NewRow();

            row["Column"] = "source_inc_kg_cum";
            row["Order"] = 8;
            row["Visible"] = true;
            row["Start"] = 83;//94;
            row["Length"] = 8;//8;
            row["Type"] = "Double";

            datos.AcceptChanges();

            datos.Tables["ColumnData"].Rows.Add(row);

            return datos;
        }

        private void clean_form() 
        {
            txt_companyCode.Text = "";
            txt_companyName.Text = "";
            txt_plantCode.Text = "";
            txt_mixType.Text = "";
            txt_mixRefCodes.Text = "";
            txt_serverName.Text = "";
            txt_createdDate.Text = "";
            txt_createdTime.Text = "";
            txt_printedDate.Text = "";
            txt_printedTime.Text = "";
            txt_printedBy.Text = "";
            txt_formulaCode.Text = "";
            txt_formulaName.Text = "";
            txt_formulaTonnes.Text = "";
            txt_batchSize.Text = "";
            txt_lastUpdatedDate.Text = "";
            materials = new DataSet();
        }

        private void read_format_file(StreamReader reader, DataSet FieldOrders) 
        {
            //BinaryReader red = new BinaryReader(File.Open(dialog.FileName,FileMode.Open), Encoding.GetEncoding(1252));
            string lineText = string.Empty;
            int lineCount = 1;
            materials = gen_empty_detail();

            while ((lineText = reader.ReadLine()) != null)
            {
                byte[] stringBytes = Encoding.Default.GetBytes(lineText);
                lineText = Encoding.ASCII.GetString(stringBytes);

                if (lineCount <= 14)
                {
                    switch (lineCount)
                    {
                        case 2://Source Company Name & Code
                            txt_companyName.Text = lineText.Substring(50, 21).Trim();
                            txt_companyCode.Text = lineText.Substring(70, 8).Replace('(', ' ').Replace(')', ' ').Trim();
                            lineCount++;
                            break;
                        case 4://Source Server Name, Month & Year, Date & Time Creation
                            txt_mixType.Text = lineText.Substring(1, 22).Trim();
                            txt_serverName.Text = lineText.Substring(31, 22).Trim();
                            txt_createdTime.Text = lineText.Substring(105, 8).Trim();
                            txt_createdDate.Text = lineText.Substring(113, 10).Trim();
                            lineCount++;
                            break;
                        case 5://Source Formula Code & Version, Plant Code, User who created
                            txt_mixRefCodes.Text = lineText.Substring(1, 22).Trim();
                            txt_plantCode.Text = lineText.Substring(43, 15).Replace("Plant=", " ").Trim();
                            txt_printedBy.Text = lineText.Substring(58, 18).Trim();
                            lineCount++;
                            break;
                        case 8:// Source Formula Code & Name Printed Date & Time
                            txt_formulaCode.Text = lineText.Substring(5, 15).Trim();
                            txt_formulaName.Text = lineText.Substring(18, 39).Trim();
                            txt_printedDate.Text = lineText.Substring(73, 10).Trim();
                            txt_printedTime.Text = lineText.Substring(84, 9).Trim();
                            lineCount++;
                            break;
                        case 9://Last updated Date
                            txt_lastUpdatedDate.Text = lineText.Substring(84, 9).Trim();
                            lineCount++;
                            break;
                        case 10://Old Reference & Batch Size
                            txt_batchSize.Text = lineText.Substring(81, 10).Trim();
                            lineCount++;
                            break;
                        case 11://New Reference & Formula Tonnes
                            txt_formulaTonnes.Text = lineText.Substring(81, 7).Trim();
                            lineCount++;
                            break;
                        default:
                            lineCount++;
                            break;
                    }
                }
                else
                {
                    if (lineText.Substring(54, 5).Trim() != "Total" && lineText.Substring(0, 10).Trim() != "" && lineText.Substring(65, 1).Trim() != "-")
                    {
                        DataRow row = materials.Tables[0].NewRow();

                        foreach (DataRow r in FieldOrders.Tables[0].Rows) 
                        {
                            row["id"] = -1;
                            if (r["Type"].ToString() == "String")
                                row[r["Column"].ToString()] = lineText.Substring(int.Parse(r["Start"].ToString()), int.Parse(r["Length"].ToString())).Trim();
                            else if (r["Type"].ToString() == "Double")
                                row[r["Column"].ToString()] = Double.Parse(lineText.Substring(int.Parse(r["Start"].ToString()), int.Parse(r["Length"].ToString())).Trim());
                        }

                        //row["id"] = -1;
                        //row["source_mat_code"] = lineText.Substring(0, 10).Trim();
                        //row["source_mat_name"] = lineText.Substring(11, 27).Trim();
                        //row["source_mat_group"] = lineText.Substring(39, 10).Trim();
                        //row["source_mat_bin"] = lineText.Substring(49, 11).Trim();
                        //row["source_inc_per"] = Double.Parse(lineText.Substring(61, 10).Trim());
                        //row["source_inc_per_cum"] = Double.Parse(lineText.Substring(71, 10).Trim());
                        //row["source_inc_kg"] = Double.Parse(lineText.Substring(83, 10).Trim());
                        //row["source_inc_kg_cum"] = Double.Parse(lineText.Substring(94, 8).Trim());

                        materials.Tables[0].Rows.Add(row);

                        lineCount++;
                    }
                    else
                    {
                        lineCount++;
                    }
                }
            }

            gen_owner();
            reader.Close();
            grd_Data.DataSource = materials.Tables[0];
        }

        private void gen_owner() 
        {
            if (txt_formulaName.Text.Contains("AQF"))
            {
                rgrp_FormulaOwner.SelectedIndex = 1;
            }
            else 
            {
                rgrp_FormulaOwner.SelectedIndex = 0;
            }
        }

        private void read_format_file_masive(StreamReader reader, DataSet FieldOrders, int line_count)
        {
            //BinaryReader red = new BinaryReader(File.Open(dialog.FileName,FileMode.Open), Encoding.GetEncoding(1252));
            string lineText = string.Empty;
            int lineCount = 1;
            //int lineCount = line_count;
            materials = gen_empty_detail();

            //int h1 = (2 + line_count);
            //int h2 = (4 + line_count);
            //int h3 = (5 + line_count);
            //int h4 = (8 + line_count);
            //int h5 = (9 + line_count);
            //int h6 = (10 + line_count);
            //int h7 = (11 + line_count);

            int h1 = (1 + line_count);
            int h2 = (3 + line_count);
            int h3 = (4 + line_count);
            int h4 = (7 + line_count);
            int h5 = (8 + line_count);
            int h6 = (9 + line_count);
            int h7 = (10 + line_count);

            while ((lineText = reader.ReadLine()) != null)
            {
                if (lineCount > line_count)
                {
                    byte[] stringBytes = Encoding.Default.GetBytes(lineText);
                    lineText = Encoding.ASCII.GetString(stringBytes);

                    if (lineCount <= (13 + line_count))
                    {
                        if (lineCount == h1)
                        {
                            //Source Company Name & Code
                            txt_companyName.Text = lineText.Substring(50, 21).Trim();
                            txt_companyCode.Text = lineText.Substring(70, 8).Replace('(', ' ').Replace(')', ' ').Trim();
                            lineCount++;
                        }
                        else if (lineCount == h2)
                        {
                            //Source Server Name, Month & Year, Date & Time Creation
                            txt_mixType.Text = lineText.Substring(1, 22).Trim();
                            txt_serverName.Text = lineText.Substring(31, 22).Trim();
                            txt_createdTime.Text = lineText.Substring(105, 8).Trim();
                            txt_createdDate.Text = lineText.Substring(113, 10).Trim();
                            lineCount++;
                        }
                        else if (lineCount == h3)
                        {
                            //Source Formula Code & Version, Plant Code, User who created
                            txt_mixRefCodes.Text = lineText.Substring(1, 22).Trim();
                            txt_plantCode.Text = lineText.Substring(43, 15).Replace("Plant=", " ").Trim();
                            txt_printedBy.Text = lineText.Substring(58, 18).Trim();
                            lineCount++;
                        }
                        else if (lineCount == h4)
                        {
                            // Source Formula Code & Name Printed Date & Time
                            txt_formulaCode.Text = lineText.Substring(8, 15).Trim();
                            txt_formulaName.Text = lineText.Substring(24, 33).Trim();
                            txt_printedDate.Text = lineText.Substring(73, 10).Trim();
                            txt_printedTime.Text = lineText.Substring(84, 9).Trim();
                            lineCount++;
                        }
                        else if (lineCount == h5)
                        {
                            //Last updated Date
                            txt_lastUpdatedDate.Text = lineText.Substring(84, 9).Trim();
                            lineCount++;
                        }
                        else if (lineCount == h6)
                        {
                            //Old Reference & Batch Size
                            txt_batchSize.Text = lineText.Substring(81, 10).Trim();
                            lineCount++;
                        }
                        else if (lineCount == h7)
                        {
                            //New Reference & Formula Tonnes
                            txt_formulaTonnes.Text = lineText.Substring(81, 7).Trim();
                            lineCount++;
                        }
                        else
                        {
                            lineCount++;
                        }
                    }
                    else
                    {
                        if (lineText.Substring(54, 5).Trim() != "Total" && lineText.Substring(0, 10).Trim() != "" && lineText.Substring(65, 1).Trim() != "-")
                        {
                            DataRow row = materials.Tables[0].NewRow();

                            foreach (DataRow r in FieldOrders.Tables[0].Rows)
                            {
                                row["id"] = -1;
                                if (r["Type"].ToString() == "String")
                                    row[r["Column"].ToString()] = lineText.Substring(int.Parse(r["Start"].ToString()), int.Parse(r["Length"].ToString())).Trim();
                                else if (r["Type"].ToString() == "Double")
                                    row[r["Column"].ToString()] = Double.Parse(lineText.Substring(int.Parse(r["Start"].ToString()), int.Parse(r["Length"].ToString())).Trim());
                            }

                            //row["id"] = -1;
                            //row["source_mat_code"] = lineText.Substring(0, 10).Trim();
                            //row["source_mat_name"] = lineText.Substring(11, 27).Trim();
                            //row["source_mat_group"] = lineText.Substring(39, 10).Trim();
                            //row["source_mat_bin"] = lineText.Substring(49, 11).Trim();
                            //row["source_inc_per"] = Double.Parse(lineText.Substring(61, 10).Trim());
                            //row["source_inc_per_cum"] = Double.Parse(lineText.Substring(71, 10).Trim());
                            //row["source_inc_kg"] = Double.Parse(lineText.Substring(83, 10).Trim());
                            //row["source_inc_kg_cum"] = Double.Parse(lineText.Substring(94, 8).Trim());

                            materials.Tables[0].Rows.Add(row);

                            lineCount++;
                        }
                        else
                        {
                            if (lineText.Substring(54, 5).Trim() == "Total")
                            {
                                grd_Data.DataSource = materials.Tables[0];
                                read_format_file_masive(reader, FieldOrders, (lineCount + 5));
                                lineCount++;
                            }
                            else
                            {
                                lineCount++;
                            }
                        }
                    }
                }
                else 
                {
                    lineCount++;
                }
            }

            gen_owner();
            grd_Data.DataSource = materials.Tables[0];
        }

        private Int32 save_formula_header() 
        {
            try
            {
                Int32 InsertedID = 0;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@src_company_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_company_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_plant_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_mix_type", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_mix_ref_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_server_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_created_date", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@src_created_time", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@src_printed_date", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@src_printed_time", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@src_printed_by", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_formula_code", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_formula_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_formula_tonnes", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@src_batch_size_kg", SqlDbType.Decimal));
                cmd.Parameters.Add(new SqlParameter("@src_last_updated", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@lcl_name", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@lcl_loaded_by", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@lcl_last_mod_by", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@copy_number", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@approve_prod", SqlDbType.Bit));
                cmd.Parameters.Add(new SqlParameter("@aprove_fin", SqlDbType.Bit));
                cmd.Parameters.Add(new SqlParameter("@available_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@lcl_owner", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@id_tipo_saco", SqlDbType.Int));

                SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                param.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters["@src_company_code"].Value = txt_companyCode.Text.ToString();
                cmd.Parameters["@src_company_name"].Value = txt_companyName.Text.ToString();
                cmd.Parameters["@src_plant_code"].Value = txt_plantCode.Text.ToString();
                cmd.Parameters["@src_mix_type"].Value = txt_mixType.Text.ToString();
                cmd.Parameters["@src_mix_ref_code"].Value = txt_mixRefCodes.Text.ToString();
                cmd.Parameters["@src_server_name"].Value = txt_serverName.Text.ToString();
                cmd.Parameters["@src_created_date"].Value = Convert.ToDateTime(txt_createdDate.Text.ToString());
                cmd.Parameters["@src_created_time"].Value = Convert.ToDateTime(txt_createdTime.Text.ToString());
                cmd.Parameters["@src_printed_date"].Value = Convert.ToDateTime(txt_printedDate.Text.ToString());
                cmd.Parameters["@src_printed_time"].Value = Convert.ToDateTime(txt_printedTime.Text.ToString());
                cmd.Parameters["@src_printed_by"].Value = txt_printedBy.Text.ToString();
                cmd.Parameters["@src_formula_code"].Value = txt_formulaCode.Text.ToString();
                cmd.Parameters["@src_formula_name"].Value = txt_formulaName.Text.ToString();
                cmd.Parameters["@src_formula_tonnes"].Value = txt_formulaTonnes.Text.ToString();
                cmd.Parameters["@src_batch_size_kg"].Value = Convert.ToDouble(txt_batchSize.Text.ToString());
                cmd.Parameters["@src_last_updated"].Value = Convert.ToDateTime(txt_lastUpdatedDate.Text.ToString());
                cmd.Parameters["@lcl_name"].Value = txt_InternName.Text.ToString();
                cmd.Parameters["@lcl_loaded_by"].Value = ActiveUserCode;
                cmd.Parameters["@lcl_last_mod_by"].Value = ActiveUserCode;
                cmd.Parameters["@status"].Value = 10;
                cmd.Parameters["@copy_number"].Value = 0;
                cmd.Parameters["@approve_prod"].Value = DBNull.Value;
                cmd.Parameters["@aprove_fin"].Value = DBNull.Value;
                cmd.Parameters["@available_date"].Value = dt_desde.EditValue;
                cmd.Parameters["@due_date"].Value = dt_hasta.EditValue;
                cmd.Parameters["@lcl_owner"].Value = rgrp_FormulaOwner.SelectedIndex;
                cmd.Parameters["@id_tipo_saco"].Value = lookUpEdit1.EditValue;

                InsertedID = dp.ACS_Exec_SP_GetID("FM_FF_Insert_Main_v2", cmd, param);

                FMOP fmop = new FMOP();
                fmop.ext_formula_event_entry(InsertedID, int.Parse(ActiveUserCode),"INI","Formula Cargada al Sistema");

                return InsertedID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void save_formula_detail(Int32 header_id) 
        {
            try
            {
                if (header_id > 0) 
                {
                    foreach (DataRow row in materials.Tables[0].Rows) 
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id_h", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_code", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_name", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_group", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_mat_bin", SqlDbType.VarChar));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_per", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_per_cum", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_kg", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_inc_kg_cum", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@source_mkt_rep_cost", SqlDbType.Decimal));
                        cmd.Parameters.Add(new SqlParameter("@local_rm", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@local_rm_match", SqlDbType.Bit));
                        cmd.Parameters.Add(new SqlParameter("@sys_comment", SqlDbType.VarChar));

                        cmd.Parameters["@id_h"].Value = header_id;
                        cmd.Parameters["@source_mat_code"].Value = row["source_mat_code"].ToString();
                        cmd.Parameters["@source_mat_name"].Value = row["source_mat_name"].ToString();
                        cmd.Parameters["@source_mat_group"].Value = row["source_mat_group"].ToString();
                        cmd.Parameters["@source_mat_bin"].Value = row["source_mat_bin"].ToString();
                        cmd.Parameters["@source_inc_per"].Value = Convert.ToDouble(row["source_inc_per"].ToString());
                        cmd.Parameters["@source_inc_per_cum"].Value = Convert.ToDouble(row["source_inc_per_cum"].ToString());
                        cmd.Parameters["@source_inc_kg"].Value = Convert.ToDouble(row["source_inc_kg"].ToString());
                        cmd.Parameters["@source_inc_kg_cum"].Value = Convert.ToDouble(row["source_inc_kg_cum"].ToString());
                        cmd.Parameters["@source_mkt_rep_cost"].Value = 0;//Convert.ToDouble(row["source_mkt_rep_cost"].ToString());

                        DataSet temp = dp.ACS_GetSelectData(string.Format("SELECT [id] ,[estado] FROM [dbo].[MP_MateriasPrimas] WHERE [codigo] = '{0}'", row["source_mat_code"]));

                        if (temp.Tables[0].Rows.Count <= 0) 
                        {
                            cmd.Parameters["@local_rm"].Value = DBNull.Value;
                            cmd.Parameters["@local_rm_match"].Value = 0;
                            cmd.Parameters["@sys_comment"].Value = "El codigo de materia prima no existe.";
                        }
                        else if (temp.Tables[0].Rows.Count == 1)
                        {
                            if (temp.Tables[0].Rows[0][1].ToString() == "a") 
                            {
                                cmd.Parameters["@local_rm"].Value = int.Parse(temp.Tables[0].Rows[0][0].ToString());
                                cmd.Parameters["@local_rm_match"].Value = 1;
                                cmd.Parameters["@sys_comment"].Value = "Ok";
                            }
                            else if (temp.Tables[0].Rows[0][1].ToString() == "i")
                            {
                                cmd.Parameters["@local_rm"].Value = int.Parse(temp.Tables[0].Rows[0][0].ToString());
                                cmd.Parameters["@local_rm_match"].Value = 0;
                                cmd.Parameters["@sys_comment"].Value = "La materia prima localmente esta inactiva.";
                            }
                        }
                        else if (temp.Tables[0].Rows.Count > 1)
                        {
                            cmd.Parameters["@local_rm"].Value = DBNull.Value;
                            cmd.Parameters["@local_rm_match"].Value = 0;
                            cmd.Parameters["@sys_comment"].Value = "Este codigo de materia prima esta repetido en la base de datos.";
                        }

                        dp.ACS_Exec_SP("FM_FF_Insert_Detail", cmd);
                    }

                    if (!isMasive)
                        MessageBox.Show("Formula Guardada Exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        File.Move(filePath, filePath.Replace(fileName, (fileLName + " - Loaded.txt")));
                        //File.Move(filePath, (filePath.Replace(".txt", " - Loaded.txt").ToString()));
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// For Masive file load only
        /// </summary>
        private void load_file() 
        {
            try
            {
                currentFileName = filePath;
                StreamReader reader = File.OpenText(currentFileName);

                read_format_file(reader, Get_Default_Columns_Specs());
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233086) //Index Length Out of Bounds Errors
                {
                    clean_form();
                    StreamReader reader = File.OpenText(currentFileName);
                    FML_Format_Import_Custom_Error form = new FML_Format_Import_Custom_Error(reader, Get_Default_Columns_Specs());
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        DataSet FieldConf = form.datos;
                        reader = File.OpenText(currentFileName);
                        read_format_file(reader, FieldConf);
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorsOcurred++;
                }
            }
        }

        #endregion

        #region Form Events

        private void FML_Formula_Format_Import_Interface_Load(object sender, EventArgs e)
        {
            try
            {
                if (isMasive)
                {
                    txt_InternName.Text = fileLName;
                    dt_desde.EditValue = from_date;
                    dt_hasta.EditValue = to_date;
                    load_file();

                    btn_Accept.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Options.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_save.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_Cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else 
                {
                    btn_Accept.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_Options.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_save.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btn_Cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;                
                }

                CargarTiposSacos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Options_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog() { Filter = "Format Text File (.txt)|*.txt", FilterIndex = 0 };

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentFileName = dialog.FileName;
                    StreamReader reader = File.OpenText(currentFileName);

                    read_format_file(reader, Get_Default_Columns_Specs());
                    //read_format_file_masive(reader, Get_Default_Columns_Specs(), 1);
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233086) //Index Length Out of Bounds Errors
                {
                    clean_form();
                    StreamReader reader = File.OpenText(currentFileName);
                    FML_Format_Import_Custom_Error form = new FML_Format_Import_Custom_Error(reader, Get_Default_Columns_Specs());
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                    {
                        DataSet FieldConf = form.datos;
                        reader = File.OpenText(currentFileName);
                        read_format_file(reader, FieldConf);
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorsOcurred++;
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SecOps sec = new SecOps();
                sec.SendEmailAlert_SingleContact_GD("david.riega@aquafeedhn.com", 0, "Mensaje de Prueba del ACS", "El ACS ha generado un mensaje de correo electronico de prueba. Bazzinga!!!", false);
                MessageBox.Show("OK!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DateTime current_date = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));
                DateTime available_date = Convert.ToDateTime(dt_desde.EditValue);
                DateTime due_date = Convert.ToDateTime(dt_hasta.EditValue);
                if (Convert.ToDateTime(available_date.ToShortDateString()) >= Convert.ToDateTime(current_date.ToShortDateString()))
                {
                    if (Convert.ToDateTime(available_date.ToShortDateString()) < Convert.ToDateTime(due_date.ToShortDateString()))
                    {
                        if (lookUpEdit1.EditValue == null)
                        {
                            MessageBox.Show("Debe seleccionar el envase sugerido para el Producto Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            lookUpEdit1.Focus();
                        }
                        else
                        {
                            save_formula_detail(save_formula_header());
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
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_savencopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_Accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DateTime current_date = Convert.ToDateTime(Convert.ToDateTime(dp.ACS_GetSelectData(@"SELECT SYSDATETIME()").Tables[0].Rows[0][0].ToString()));
                DateTime available_date = Convert.ToDateTime(dt_desde.EditValue);
                DateTime due_date = Convert.ToDateTime(dt_hasta.EditValue);
                if (Convert.ToDateTime(available_date.ToShortDateString()) >= Convert.ToDateTime(current_date.ToShortDateString()))
                {
                    if (Convert.ToDateTime(available_date.ToShortDateString()) < Convert.ToDateTime(due_date.ToShortDateString()))
                    {
                        save_formula_detail(save_formula_header());
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
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar la información\nDetalle del Error: {0}\n\nStack Trace: {1}", ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            File.Move(filePath, filePath.Replace(fileName, (fileLName + " - Aborted.txt")));
            //File.Move(filePath, (filePath.Replace(".txt", " - Aborted.txt").ToString()));
            this.Close();
        }

        #endregion


        #region Functions
        private void CargarTiposSacos()
        {
            try
            {
                string sql = @"SELECT	id, descripcion
                                FROM [dbo].FCT_Tipo_Saco ss
                                where ss.nulo <> 1";

                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
                dsFormulacion1.tipos_sacos.Clear();
                adapter.Fill(dsFormulacion1.tipos_sacos);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void txt_formulaName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string par = "";
                if (txt_formulaName.Text.Length >= 7)
                    par = txt_formulaName.Text.Substring(0, 7);
                else
                    par = txt_formulaName.Text;

                string sql = @"SELECT top 1 id
                               FROM [dbo].FCT_Tipo_Saco ss
                               where ss.nulo <> 1 and
                                     ss.descripcion like '%" + par + "%'";

                DataOperations dp = new DataOperations();
                SqlConnection Conn = new SqlConnection(dp.ConnectionStringCostos);
                Conn.Open();

                SqlCommand cmd = new SqlCommand(sql, Conn);
                int val = Convert.ToInt32(cmd.ExecuteScalar());
                lookUpEdit1.EditValue = val;
            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}