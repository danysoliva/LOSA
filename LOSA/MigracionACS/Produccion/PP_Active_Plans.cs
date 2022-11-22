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
    public partial class PP_Active_Plans : DevExpress.XtraEditors.XtraForm
    {
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string FormAction;

        int selectedIndex;
        int selectedStatus;

        DataOperations dp = new DataOperations();
        FMOP fmop = new FMOP();
        SqlConnection conn = new SqlConnection();

        private void Gen_RM_Requirement()
        {
            try
            {
                #region Gen Daily Information

                DataTable RMData = new DataTable();
                SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Get_Daily", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));

                cmd.Parameters["@userID"].Value = ActiveUserCode;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                RMData.Load(cmd.ExecuteReader());

                grd_rmReq.DataSource = RMData;

                #endregion

                #region Gen Total Requirement

                RMData = new DataTable();
                cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Get_Total", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));

                cmd.Parameters["@userID"].Value = ActiveUserCode;

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                RMData.Load(cmd.ExecuteReader());

                grd_reqMP_Total.DataSource = RMData;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void Ins_RM_Requirement() 
        {
            try
            {
                #region Insert Info into temporary table

                DataTable data = fmop.pp_get_plan_pos(selectedIndex);

                foreach (DataRow row in data.Rows)
                {
                    SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Ins", conn);
                    //SqlCommand cmd = new SqlCommand("PP_Plan_RM_Req_Temp_Ins_Temp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@FormulaID", SqlDbType.VarChar, 100));
                    cmd.Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.VarChar, 100));
                    cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.VarChar, 100));
                    cmd.Parameters.Add(new SqlParameter("@date_production", SqlDbType.Date));

                    cmd.Parameters["@FormulaID"].Value = row["id_formula"].ToString();
                    cmd.Parameters["@BatchNo"].Value = row["cant_paradas"].ToString();
                    cmd.Parameters["@UserID"].Value = ActiveUserCode;
                    cmd.Parameters["@date_production"].Value = row["date_prouction"];

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    cmd.ExecuteNonQuery();
                }

                Gen_RM_Requirement();

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        private void Drop_TempTables(string action)
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
                cmd.Parameters["@FormulaID"].Value = "-1";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR: {0}\nSTAKTRACE: {1}", ex.Message, ex.StackTrace));
            }
        }

        public PP_Active_Plans(string ActiveUserCode, string ActiveUserName, string FormAction, string ActiveUserType)
        {
            InitializeComponent();

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.FormAction = FormAction;
        }

        private void PP_Active_Plans_Load(object sender, EventArgs e)
        {
            try
            {
                grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Get_Active", new SqlCommand());

                conn.ConnectionString = dp.ConnectionStringCostos;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    this.Text = this.Text + " - [Database Connection Established]";
                else
                    this.Text = this.Text + " - [Error on Database Connection]";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_queue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                switch (selectedStatus) 
                {
                    case 20:
                        MessageBox.Show("El Plan de Producción ya esta en cola.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 40:
                        MessageBox.Show("El Plan de Producción esta Activo, no puede ser puesto en cola.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 10:
                        if (MessageBox.Show("¿Seguro que desea poner el registro en cola?\nEste se activara la fecha de inicio especificada en el plan", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                        {
                            SqlCommand cmd = new SqlCommand();
                            DataSet formulas = dp.ACS_GetSelectData(string.Format("SELECT [id_formula] FROM [dbo].[PP_Plan_Ordenes] WHERE [id_plan] = {0}", selectedIndex));

                            int rmi = 0;

                            foreach (DataRow row in formulas.Tables[0].Rows)
                            {
                                rmi += dp.get_inactive_rm(int.Parse(row["id_formula"].ToString()));
                            }

                            if (rmi > 0)
                            {
                                 if (MessageBox.Show(string.Format("Aparentemente este plan de producción tiene formulas con almenos {0} materias primas o núcleos inactivos\n\n¿Seguro que desea programar el plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    cmd = new SqlCommand();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                                    cmd.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                                    cmd.Parameters["@id"].Value = selectedIndex;
                                    cmd.Parameters["@st"].Value = 35;

                                    dp.ACS_Exec_SP("PP_Plan_Update_Status", cmd);

                                    grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Get_Active", new SqlCommand());
                                }
                            }
                            else
                            {
                                cmd = new SqlCommand();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                                cmd.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                                cmd.Parameters["@id"].Value = selectedIndex;
                                cmd.Parameters["@st"].Value = 35;

                                dp.ACS_Exec_SP("PP_Plan_Update_Status", cmd);

                                grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Get_Active", new SqlCommand());
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("El Estado del Registro no se reconoce, no se modifico el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedIndex = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["id"].ToString());
                selectedStatus = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["status"].ToString());
            }
            catch { }
        }

        private void btn_activate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selectedStatus == 10 || selectedStatus == 20)
                {
                    if (MessageBox.Show("¿Seguro que desea activar el Plan de Producción?\nEsto pondra las Ordendes de Producción Disponibles para su Ejecución Inmediatamente.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();

                        DataSet formulas = dp.ACS_GetSelectData(string.Format("SELECT [id_formula] FROM [dbo].[PP_Plan_Ordenes] WHERE [id_plan] = {0}", selectedIndex));

                        int rmi = 0;

                        foreach (DataRow row in formulas.Tables[0].Rows)
                        {
                            rmi += dp.get_inactive_rm(int.Parse(row["id_formula"].ToString()));
                        }

                        if (rmi > 0)
                        {
                            if (MessageBox.Show(string.Format("Aparentemente este plan de producción tiene formulas con almenos {0} materias primas o núcleos inactivos\n\n¿Seguro que desea activar el plan de producción?", rmi.ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                #region Cambia Estado de las Formulas y Nucleos relacionados al plan
                                foreach (DataRow row in formulas.Tables[0].Rows)
                                {
                                    /**Cambiamos el estado de la Formula Base**/
                                    cmd = new SqlCommand();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                                    cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

                                    cmd.Parameters["@id_formula"].Value = int.Parse(row["id_formula"].ToString());
                                    cmd.Parameters["@status"].Value = 50;

                                    dp.ACS_Exec_SP("FM_Update_Status", cmd);

                                    /**Verificamos si existen nucleos relacionados a esta Formula, de ser verdadero les cambiamos el estado tambien.**/
                                    DataSet nucleos = dp.ACS_GetSelectData(string.Format(@"SELECT [nucleo] FROM [dbo].[FML_Ingredientes_v2] WHERE [formula] = {0} AND [tipo] = 'NC'", row["id_formula"].ToString()));

                                    if (nucleos.Tables[0].Rows.Count > 0)
                                    {
                                        foreach (DataRow row2 in nucleos.Tables[0].Rows)
                                        {
                                            cmd = new SqlCommand();
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                                            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

                                            cmd.Parameters["@id_formula"].Value = int.Parse(row2["nucleo"].ToString());
                                            cmd.Parameters["@status"].Value = 50;

                                            dp.ACS_Exec_SP("FM_Update_Status", cmd);
                                        }
                                    }
                                }

                        #endregion

                                #region Cambia Estado de Plan de Produccion

                                cmd = new SqlCommand();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                                cmd.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                                cmd.Parameters["@id"].Value = selectedIndex;
                                cmd.Parameters["@st"].Value = 40;

                                dp.ACS_Exec_SP("PP_Plan_Update_Status", cmd);

                                #endregion

                                /*Actualizamos Grid de Planes de Produccion*/
                                grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Get_Active", new SqlCommand());
                            }
                        }
                        else
                        {
                            #region Cambia Estado de las Formulas y Nucleos relacionados al plan
                            foreach (DataRow row in formulas.Tables[0].Rows)
                            {
                                /**Cambiamos el estado de la Formula Base**/
                                cmd = new SqlCommand();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                                cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

                                cmd.Parameters["@id_formula"].Value = int.Parse(row["id_formula"].ToString());
                                cmd.Parameters["@status"].Value = 50;

                                dp.ACS_Exec_SP("FM_Update_Status", cmd);

                                /**Verificamos si existen nucleos relacionados a esta Formula, de ser verdadero les cambiamos el estado tambien.**/
                                DataSet nucleos = dp.ACS_GetSelectData(string.Format(@"SELECT [nucleo] FROM [dbo].[FML_Ingredientes_v2] WHERE [formula] = {0} AND [tipo] = 'NC'", row["id_formula"].ToString()));

                                if (nucleos.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row2 in nucleos.Tables[0].Rows)
                                    {
                                        cmd = new SqlCommand();
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                                        cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

                                        cmd.Parameters["@id_formula"].Value = int.Parse(row2["nucleo"].ToString());
                                        cmd.Parameters["@status"].Value = 50;

                                        dp.ACS_Exec_SP("FM_Update_Status", cmd);
                                    }
                                }
                            }

                            #endregion

                            #region Cambia Estado de Plan de Produccion

                            cmd = new SqlCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                            cmd.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                            cmd.Parameters["@id"].Value = selectedIndex;
                            cmd.Parameters["@st"].Value = 40;

                            dp.ACS_Exec_SP("PP_Plan_Update_Status", cmd);

                            #endregion

                            /*Actualizamos Grid de Planes de Produccion*/
                            grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Get_Active", new SqlCommand());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Plan de Producción ya esta activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deactivate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selectedStatus == 10 || selectedStatus == 20)
                {
                    if (MessageBox.Show("¿Seguro que desea Desactivar el Plan de Producción?\nEsto Inhabilitara las Ordenes de Producción Permanentemente.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@st", SqlDbType.Int));

                        cmd.Parameters["@id"].Value = selectedIndex;
                        cmd.Parameters["@st"].Value = 99;

                        dp.ACS_Exec_SP("PP_Plan_Update_Status", cmd);

                        grd_data.DataSource = dp.ACS_Exec_SP_Get_Data("PP_Plan_Get_Active", new SqlCommand());
                    }
                }
                else
                {
                    MessageBox.Show("El Plan de Producción ya esta activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_details_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PP_Nuevo_Plan pp = new PP_Nuevo_Plan(ActiveUserCode, ActiveUserName, "edit", ActiveUserType);
            pp.ShowDialog();
        }

        private void Get_requirements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btn_mpreqDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Ins_RM_Requirement();

                #region Save Information into excel file

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_rmReq.ExportToXlsx(dialog.FileName);
                }

                #endregion

                Drop_TempTables("Drop");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha sido posible generar el informe de requerimientos de materia prima. Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PP_Active_Plans_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        private void btn_mpReqTot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Ins_RM_Requirement();

                #region Save Information into excel file

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_reqMP_Total.ExportToXlsx(dialog.FileName);
                }

                #endregion

                Drop_TempTables("Drop");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha sido posible generar el informe de requerimientos de materia prima. Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}