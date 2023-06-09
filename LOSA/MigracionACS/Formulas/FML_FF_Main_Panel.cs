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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.IO;
using LOSA.Clases;
using LOSA.MigracionACS.Formulas.Reports;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_FF_Main_Panel : DevExpress.XtraEditors.XtraForm
    {
        #region Form - Global Variables

        FMOP fmop = new FMOP();
        DataOperations dp = new DataOperations();
        DataTable formulas;

        /******Datos Usuario*******/
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;

        DataTable UserGroups;

        int selected_formula;
        int selected_status;

        int selected_rm_line;

        #endregion

        #region Constructors

        public FML_FF_Main_Panel(string ActiveUserCode, string ActiveUserName, string ActiveUserType, DataTable UserGroups)
        {
            InitializeComponent();
            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.UserGroups = UserGroups;
        }

        #endregion

        #region Developer Defined Methods

        private void load_data() 
        {
            try
            {
                int pEspecie = Convert.ToInt32(radioBtnEspecie.EditValue);
                #region Load Main
                if(chk_descontinuadas.Checked)
                    formulas = fmop.ext_formula_get_by_status(90, 95, pEspecie);
                else
                    formulas = fmop.ext_formula_get_by_status(1, 50, pEspecie);

                grd_main.DataSource = formulas;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void approve_reject_process(string action) 
        {
            try
            {
                string text, caption;

                if (action == "approve")
                {
                    text = "¿Seguro que deseas aprobar esta formula?";
                    caption = "Aprobación";
                }
                else 
                {
                    text = "¿Seguro que desear rechazar la formula?";
                    caption = "Rechazo de Formula";
                }

                if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ArrayList array = Grid_Get_Selected_Items();

                    if (array.Count > 0)
                    {
                        foreach (DataRow row2 in array)
                        {

                            int current_status = fmop.ext_formula_get_status(int.Parse(row2["id"].ToString()));
                            if (current_status >= 30 && current_status < 40)
                            {
                                string approver_type = null;
                                int count = 0;

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
                                    if (!fmop.ext_formula_exist_approve(int.Parse(row2["id"].ToString()), approver_type))
                                    {
                                        if (action == "approve")
                                        {
                                            fmop.ext_formula_approve(int.Parse(row2["id"].ToString()), int.Parse(ActiveUserCode), approver_type);
                                            fmop.ext_formula_event_entry(int.Parse(row2["id"].ToString()), int.Parse(ActiveUserCode), "APR", "Formula Aprobada.");
                                        }
                                        else if (action == "reject")
                                        {
                                            fmop.ext_formula_reject(int.Parse(row2["id"].ToString()), int.Parse(ActiveUserCode), approver_type);
                                            fmop.ext_formula_event_entry(int.Parse(row2["id"].ToString()), int.Parse(ActiveUserCode), "APR", "Formula Rechazada");
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

                        MessageBox.Show("Proceso Finalizado.", "Aprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ArrayList Grid_Get_Selected_Items()
        {
            if (grdv_main.SelectedRowsCount > 0)
            {
                ArrayList rows = new ArrayList();

                for (int i = 0; i < grdv_main.SelectedRowsCount; i++)
                {
                    if (grdv_main.GetSelectedRows()[i] >= 0)
                    {
                        rows.Add(grdv_main.GetDataRow(grdv_main.GetSelectedRows()[i]));
                    }
                }

                return rows;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Form Events

        private void FML_FF_Main_Panel_Load(object sender, EventArgs e)
        {
            try
            {
                //UserGroups = secure.Get_User_Groups("AQUAFEEDHN", txt_user.Text.ToString());
               
                foreach (DataRow row in UserGroups.Rows) 
                {
                    if (row["GroupName"].ToString() == "app_acs_fml") 
                    {
                        load_data();
                        chk_descontinuadas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_addComment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_viewDeprecated.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    if (row["GroupName"].ToString() == "app_acs_fml_loader")
                    {
                        btn_LoadFormula.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_LoadNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_Export.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_GeneralReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    if (row["GroupName"].ToString() == "app_acs_fml_planner")
                    {
                        btn_RequestApproval.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_RequestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_Habilitar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_Delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    if (row["GroupName"].ToString() == "app_acs_fml_approver_fin")
                    {
                        btn_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_Export.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    if (row["GroupName"].ToString() == "app_acs_fml_approver_prd")
                    {
                        btn_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_Export.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    if (row["GroupName"].ToString() == "app_acs_it_admin")
                    {
                        //Normal
                        load_data();
                        chk_descontinuadas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_addComment.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        btnc_viewDeprecated.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        //Loader
                        btn_LoadFormula.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_Export.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        btnc_LoadNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_GeneralReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        //Planner
                        btn_RequestApproval.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        btnc_RequestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_Habilitar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_Delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        //Approver
                        btn_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_reject.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void grdv_main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (formulas.Rows.Count > 0)
                {
                    if (e.FocusedRowHandle >= 0)
                    {
                        selected_formula = int.Parse(grdv_main.GetRowCellValue(e.FocusedRowHandle, "id").ToString());
                        selected_status = int.Parse(grdv_main.GetRowCellValue(e.FocusedRowHandle, "status").ToString());
                        grd_structure.DataSource = fmop.ext_formula_get_structure(selected_formula);
                        grd_comments.DataSource = fmop.ext_formula_get_comments(selected_formula);
                        grd_events.DataSource = fmop.ext_formula_get_events(selected_formula);
                    }
                }
            }
            catch { }
        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_LoadFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formulas.FML_Formula_Format_Import_Interface form = new Formulas.FML_Formula_Format_Import_Interface(ActiveUserCode, ActiveUserName, ActiveUserType);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                load_data();
            }
        }

        private void chk_descontinuadas_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_data();
        }

        private void btn_addComment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (selected_status <= 50)
                {
                    FML_Comment_Add form = new FML_Comment_Add("normal");
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string comment = form.Comment;
                        fmop.ext_formula_comment_entry(selected_formula, int.Parse(ActiveUserCode), comment, false);
                        grd_comments.DataSource = fmop.ext_formula_get_comments(selected_formula);
                    }
                }
                else
                {
                    MessageBox.Show("No puedes agregar comentarios a una formula ya cerrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_approve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            approve_reject_process("approve");
        }

        private void btn_reject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            approve_reject_process("reject");
        }

        private void btn_RequestApproval_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que deseas solicitar aprobación?", "Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ArrayList array = Grid_Get_Selected_Items();

                    if (array.Count > 0)
                    {
                        foreach (DataRow row in array)
                        {
                            int current_status = fmop.ext_formula_get_status(int.Parse(row["id"].ToString()));
                            if (current_status >= 1 && current_status < 30)
                            {
                                fmop.ext_formula_change_status(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), 30);
                                fmop.ext_formula_clean_approvals(int.Parse(row["id"].ToString()));
                                fmop.ext_formula_event_entry(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), "APR", "Solicitud de Aprobación Creada");
                            }
                            else
                            {
                                if (current_status >= 30 && current_status < 40)
                                    MessageBox.Show("Esta formula ya esta pendiente de aprobación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (current_status >= 40 && current_status < 80)
                                    MessageBox.Show("Esta formula ya ha sido aprobada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (current_status >= 80 && current_status < 99)
                                    MessageBox.Show("No puedes solicitar aprobación para una formula descontinuada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        MessageBox.Show("Proceso terminado.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                    //SINGLE METHOD
                    //fmop.ext_formula_change_status(selected_formula, int.Parse(ActiveUserCode), 30);
                    //fmop.ext_formula_clean_approvals(selected_formula);
                    //fmop.ext_formula_event_entry(selected_formula, int.Parse(ActiveUserCode), "APR", "Solicitud de Aprovación Creada");
                    //MessageBox.Show("Solicitud de aprovación creada.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //load_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deprecate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que deseas descontinuar esta formula?", "Descontinuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ArrayList array = Grid_Get_Selected_Items();

                    if (array.Count > 0)
                    {
                        foreach (DataRow row in array)
                        {
                            int current_status = fmop.ext_formula_get_status(int.Parse(row["id"].ToString()));
                            if (current_status >= 40 && current_status < 80)
                            {
                                fmop.ext_formula_change_status(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), 90);
                                fmop.ext_formula_event_entry(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), "END", "Formula Descontinuada Manualmente.");
                            }
                            else
                            {
                                if (current_status >= 1 && current_status < 30)
                                    MessageBox.Show("No puedes descontinuar una formula que nunca ha sido producida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (current_status >= 30 && current_status < 40)
                                    MessageBox.Show("No puedes descontinuar una formula que esta en proceso de aprobación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (current_status >= 80 && current_status < 99)
                                    MessageBox.Show("Esta formula ya esta descontinuada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        MessageBox.Show("Proceso Finalizado.", "Descontinuar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que deseas elminar esta formula?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ArrayList array = Grid_Get_Selected_Items();

                    if (array.Count > 0)
                    {
                        foreach (DataRow row in array)
                        {
                            fmop.ext_formula_change_status(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), 99);
                            fmop.ext_formula_event_entry(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), "END", "Formula Eliminada por el usuario.");
                        }
                        MessageBox.Show("Proceso Finalizado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdv_structure_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void grdv_structure_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selected_rm_line = int.Parse(grdv_structure.GetDataRow(e.FocusedRowHandle)["No"].ToString());
            }
            catch { }
        }

        private void btn_rm_line_status_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            MessageBox.Show(string.Format("{0}", dp.ACS_GetSelectData(string.Format("SELECT [sys_comment] FROM [dbo].[FML_Formulas_FF_D] WHERE [id] = {0}", selected_rm_line)).Tables[0].Rows[0][0]), "Estado Linea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnc_LoadNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_LoadFormula_ItemClick(sender, e);
        }

        private void btnc_RequestApprove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_RequestApproval_ItemClick(sender, e);
        }

        private void btnc_deprecate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_deprecate_ItemClick(sender, e);
        }

        private void btnc_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_delete_ItemClick(sender, e);
        }

        private void btnc_approve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_approve_ItemClick(sender, e);
        }

        private void btnc_reject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_reject_ItemClick(sender, e);
        }

        private void btnc_viewDeprecated_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chk_descontinuadas.Checked)
                chk_descontinuadas.Checked = false;
            else
                chk_descontinuadas.Checked = true;

            //chk_descontinuadas_CheckedChanged(sender, e);
        }

        private void grdv_main_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenuMain.ShowPopup(Cursor.Position);
            }
        }

        private void btn_Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdv_structure.ExportToXlsx(dialog.FileName);
            }
        }

        private void grdv_main_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e)
        {
            GridView View = sender as GridView;
            GridColumn column = View.GroupedColumns[e.Level];
            if (column == null) return;
            e.LevelAppearance.Combine(column.AppearanceHeader);
        }

        private void grdv_main_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                //e.Appearance.BackColor = Color.LightSalmon;
                e.Appearance.BackColor = Color.FromArgb(200, 255, 255, 204);
            }
        }

        private void btnc_GeneralReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_FF_Main_Report form = new FML_FF_Main_Report();
            form.ShowDialog();
        }

        private void btn_MasiveLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Selecciona el Folder donde se encuentran las formulas";
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        DataTable filesList = new DataTable();
                        filesList.Columns.Add("Record");
                        filesList.Columns.Add("FileName");
                        filesList.Columns.Add("FileLName");
                        filesList.Columns.Add("OnError");
                        filesList.Columns.Add("FilePath");


                        DirectoryInfo d = new DirectoryInfo(fbd.SelectedPath);
                        FileInfo[] Files = d.GetFiles("*.txt");

                        if (Files.Count() > 1)
                        {
                            int count = 0;
                            foreach (FileInfo file in Files)
                            {
                                DataRow row = filesList.NewRow();

                                row["Record"] = count;
                                row["FileName"] = file.Name;
                                row["FileLName"] = "";
                                row["OnError"] = true;
                                row["FilePath"] = file.FullName;

                                filesList.Rows.Add(row);

                                count++;
                            }

                            filesList.AcceptChanges();

                            FML_Fomula_Format_Masive_Import form = new FML_Fomula_Format_Masive_Import(ActiveUserCode, ActiveUserName, ActiveUserType, filesList, fbd.SelectedPath);
                            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                load_data();


                            //string[] files = Directory.GetFiles(fbd.SelectedPath);
                            //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                        }
                        else 
                        {
                            MessageBox.Show("No existen suficientes archivos en el folder especificado.\nArchivos encontrados: " + Files.Count().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btn_PartirArchivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("ChoppingList.exe");
            }
            catch (Exception ex)
            {
                #region Try-Catch_Mensaje-Error
                    var dialogTypeName  = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                    var dialogType      = typeof(Form).Assembly.GetType(dialogTypeName);
                    var dialog  = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());
                    dialog.Text = "Error";
                    dialogType.GetProperty("Message").SetValue(dialog, "Error: " + ex.Message, null);
                    dialogType.GetProperty("Details").SetValue(dialog, ex.StackTrace, null);
                    var result  = dialog.ShowDialog();
                #endregion                
            }
        }

        private void btnc_Habilitar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que deseas habilitar esta formula?\nEste proceso habilitara esta formula y todas sus versiones locales.", "Habilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ArrayList array = Grid_Get_Selected_Items();

                    if (array.Count > 0)
                    {
                        foreach (DataRow row in array)
                        {
                            int current_status = fmop.ext_formula_get_status(int.Parse(row["id"].ToString()));
                            if (current_status >= 80 && current_status < 99)
                            {
                                fmop.ext_formula_change_status(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), 40);
                                fmop.ext_formula_event_entry(int.Parse(row["id"].ToString()), int.Parse(ActiveUserCode), "RED", "Formula Nuevamente Habilitada.");
                            }
                            else
                            {
                                if (current_status >= 1 && current_status < 30)
                                    MessageBox.Show("No puedes habilitar una formula que nunca ha sido producida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (current_status >= 30 && current_status < 40)
                                    MessageBox.Show("No puedes habilitar una formula que esta en proceso de aprovación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else if (current_status >= 40 && current_status < 80)
                                    MessageBox.Show("No puedes habilitar una formula que ya esta habilitada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        MessageBox.Show("Proceso Finalizado.", "Descontinuar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_data();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LoadXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarXML XmL = new CargarXML();
            XmL.ActiveUserCode = this.ActiveUserCode;
            XmL.ActiveUserName = this.ActiveUserName;
            XmL.ActiveUserType = this.ActiveUserType;
            if (XmL.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                load_data();
            }
           
        }

        private void btn_RequestApproval_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            ArrayList array = Grid_Get_Selected_Items();
            foreach (DataRow row in array)
            {
                FML_FF_Edit edit = new FML_FF_Edit(Convert.ToInt32(row["id"]), ActiveUserCode);
                if (edit.ShowDialog()== DialogResult.OK)
                {
                    load_data();
                }

            }
        }

        private void btnedit_DoubleClick(object sender, EventArgs e)
        {
            ArrayList array = Grid_Get_Selected_Items();
            if (array.Count > 0 )
            {
                foreach (DataRow row in array)
                {
                    FML_FF_Edit edit = new FML_FF_Edit(Convert.ToInt32(row["id"]), ActiveUserCode);
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        load_data();
                    }
                }
            }
        }

        private void radioBtnEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }
    }
}