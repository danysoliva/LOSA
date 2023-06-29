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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using ACS;
using System.Collections;
using LOSA.Clases;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Formulas_v2 : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Variables

        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string selectedType;
        int selected_local;
        int selected_parent;
        string selected_code;
        DataTable UserGroups;
        DataTable dt;
        UserLogin UsuarioLogeado;

        DataOperations dp = new DataOperations();
        FMOP fmop = new FMOP();

        #endregion

        #region Developer Defined Methods

        private void UpdateStatus(int status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));

            cmd.Parameters["@id_formula"].Value = selected_local;
            cmd.Parameters["@status"].Value = status;

            dp.ACS_Exec_SP("FM_Update_Status", cmd);

            Load_Formulas();
        }

        private void CheckGroups()
        {
            
            if (chk_ExpandGroups.Checked == true)
            {
                grdv_data.ExpandAllGroups();
                chk_ExpandGroups.Caption = "Colapsar";
            }
            else
            {
                grdv_data.CollapseAllGroups();
                chk_ExpandGroups.Caption = "Expandir";
            }
        }

        private void Load_Formulas()
        {
            if (chk_ViewDeprecated.Checked == false)
            {
                //SplashForm frmProceso = new SplashForm(30);
                try
                {
                    int pEspecie = Convert.ToInt32(radioBtnEspecie.EditValue);
                    int sum = 0;
                     dt = fmop.local_formula_get_by_status(1, 80, pEspecie);
                    dt.Columns.Add("index", typeof(int));
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + 1;
                        row["index"] = sum;
                    }
                    //frmProceso.ShowDialog();
                    grd_data.DataSource = dt;
                    //frmProceso.Close();

                }
                catch (Exception)
                {
                    //frmProceso.Close();

                }
             
            }
            else
            {
                //SplashForm frmProceso = new SplashForm(230);
                try
                {
                    int pEspecie = Convert.ToInt32(radioBtnEspecie.EditValue);
                    int sum = 0;
                    //frmProceso.ShowDialog();
                    dt = fmop.local_formula_get_by_status(1, 98, pEspecie);
                    dt.Columns.Add("index", typeof(int));
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + 1;
                        row["index"] = sum;
                    }
                    //frmProceso.ShowDialog();
                    grd_data.DataSource = dt;
                    //frmProceso.Close();
                }
                catch (Exception)
                {
                    //frmProceso.Close();

                }
            }

                

            CheckGroups();
        }

        #endregion

        #region Form Constructors

        public FML_Formulas_v2(string ActiveUserCode, string ActiveUserName, string ActiveUserType, DataTable UserGroups, UserLogin pUserLogin)
        {
            InitializeComponent();
            //Comment

            this.ActiveUserCode = ActiveUserCode;
            this.ActiveUserName = ActiveUserName;
            this.ActiveUserType = ActiveUserType;
            this.UserGroups = UserGroups;
            UsuarioLogeado = pUserLogin;
        }

        #endregion

        #region Form Events

        #region Active Events

        private void FML_Formulas_v2_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Formulas();

                //int i = Convert.ToInt32(UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo);

                switch (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo)
                {
                    case GrupoUser.GrupoUsuario.Administradores:
                        btn_new.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_newPreMix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btn_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_requestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnc_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        break;

                    case GrupoUser.GrupoUsuario.ProduccionV2:
                        int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);
                        switch (idNivel)
                        {
                            case 1://Basic View
                                
                                break;
                            case 2://Basic No Autorization
                                
                                break;
                            case 3://Medium Autorization
                                btn_new.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btn_newPreMix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btn_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                                btnc_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_requestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always; // JV Adicionado 25/05/2017
                                break;
                            case 4://Depth With Delta
                                btn_new.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btn_newPreMix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btn_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                                btnc_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_requestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always; // JV Adicionado 25/05/2017

                                //"app_acs_fml_approver_fin" || row["GroupName"].ToString() == "app_acs_fml_approver_prd"
                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                break;
                            case 5://Depth Without Delta
                                btn_new.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btn_newPreMix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btn_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                                btnc_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_requestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always; // JV Adicionado 25/05/2017

                                //"app_acs_fml_approver_fin" || row["GroupName"].ToString() == "app_acs_fml_approver_prd"
                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                break;
                            default:
                                
                                break;
                        }
                        break;

                    case GrupoUser.GrupoUsuario.Contabilidad:
                        idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);
                        switch (idNivel)
                        {
                            case 1://Basic View
                           
                                break;
                            case 2://Basic No Autorization
                               
                                break;
                            case 3://Medium Autorization
                             
                                break;
                            case 4://Depth With Delta
                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                break;
                            case 5://Depth Without Delta
                                btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                                break;
                            default:
                                
                                break;
                        }
                        break;
                    default:
                        break;
                }

                //foreach (DataRow row in UserGroups.Rows)
                //{
                   
                //    if (row["GroupName"].ToString() == "app_acs_it_admin")
                //    {
                //        //btn_new.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btn_newPreMix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btn_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                //        //btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_requestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //    }
                //    else if (row["GroupName"].ToString() == "app_acs_fml_planner")
                //    {
                //        btn_new.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btn_newPreMix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btn_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                //        btnc_delete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btnc_deprecate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btnc_edit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btnc_requestApprove.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btnc_CopySelected.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        
                //        btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always; // JV Adicionado 25/05/2017
                //        //Se coloca para Release 1
                //        //btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        //btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //    }
                //    else if (row["GroupName"].ToString() == "app_acs_fml_approver_fin" || row["GroupName"].ToString() == "app_acs_fml_approver_prd")
                //    {
                //        btnc_approve.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //        btnc_view.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //    }
                //    else
                //    {

                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_new_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            FML_FF_Select select = new FML_FF_Select();
            if (select.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int parent_formula = select.id_formula_format;
                FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "new", "FB", parent_formula);
                if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)  // Ocutlado para que refleje cambio de variacion, cuando son editado los NC
                {
                    fm.Show();
                    Load_Formulas();
                }
            }
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selected_local = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["id"].ToString());
                selected_parent = int.Parse(grdv_data.GetDataRow(e.FocusedRowHandle)["format_id"].ToString());
                selected_code = grdv_data.GetDataRow(e.FocusedRowHandle)["codigo"].ToString();

                if (grdv_data.GetDataRow(e.FocusedRowHandle)["tipo"].ToString() == "Formula Base")
                    selectedType = "FB";
                else if (grdv_data.GetDataRow(e.FocusedRowHandle)["tipo"].ToString() == "Nucleo")
                    selectedType = "NC";
            }
            catch { }
        }

        private void btn_newPreMix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_FF_Select select = new FML_FF_Select();
            if (select.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int parent_formula = select.id_formula_format;
                FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "new", "NC", parent_formula);
                fm.Show();
                Load_Formulas();
            }
        }

        private void chk_ViewDeprecated_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Formulas();
            if (chk_ViewDeprecated.Checked == false)
                chk_ViewDeprecated.Caption = "Descontinuadas(Ver)";
            else
                chk_ViewDeprecated.Caption = "Descontinuadas(Ocultar)";
        }

        private void chk_ExpandGroups_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckGroups();
        }

        private void grdv_data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int status = fmop.local_formula_get_status(selected_local);

                if (status >=90)
                {
                    btnHabilitar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    btnHabilitar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void btnc_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int status = fmop.local_formula_get_status(selected_local);

            if (status >= 1 && status < 40)
            {
                FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", selected_local, selected_parent, selectedType, UserGroups);
                //if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)   // Ocutlado para que refleje cambio de variacion, cuando son editado los NC
                //{
                    fm.Show();
                    Load_Formulas();
                //}
            }
            else
            {
                /*if (status >= 30 && status < 40)
                    MessageBox.Show("No puedes editar una formula en proceso de aprobación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else */if (status >= 40 && status < 90)
                    MessageBox.Show("No puedes editar una formula aprovada o procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 90)
                    MessageBox.Show("No puedes editar una formula descontinuada o eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnc_view_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "view", selected_local, selected_parent, selectedType, UserGroups);
            fm.Show();
            fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "EVT", "Formula Visualizada");
        }

        private void btnc_approve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int status = fmop.local_formula_get_status(selected_local);

            if (status >= 30 && status < 40)
            {
                FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "approve", selected_local, selected_parent, selectedType, UserGroups);
                if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Load_Formulas();
                }
            }
            else
            {
                if (status >= 1 && status < 30)
                    MessageBox.Show("No ha sido solicitada aprobación para esta formula", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 40 && status < 90)
                    MessageBox.Show("Esta formula ya ha sido aprobada y/o procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 90)
                    MessageBox.Show("No puedes aprobar una formula descontinuada o eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnc_requestApprove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int status = fmop.local_formula_get_status(selected_local);

            //Original: if (status >= 1 && status < 30) ==> Se cambia para evitar aprobacion de formulas locales.
            if (status >= 1 && status < 30)
            {
                if (MessageBox.Show("¿Seguro que desea solicitar aprobación de esta formula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                {
                    fmop.local_formula_change_status(selected_local, int.Parse(ActiveUserCode), 30);
                    fmop.local_formula_clean_approvals(selected_local);
                    fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "APR", "Solicitud Aprovación Creada.");
                    MessageBox.Show("Solicitud de aprobación creada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Formulas();
                }
                
            }
            else
            {
                if (status >= 30 && status < 40)
                    MessageBox.Show(" Esta formula ya esta en proceso de aprovación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 40 && status < 90)
                    MessageBox.Show("No puedes solicitar aprobación de una formula aprovada o procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 90)
                    MessageBox.Show("No puedes solicitar aprobación de una formula descontinuada o eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnc_deprecate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int status = fmop.local_formula_get_status(selected_local);

            if (status >= 40 && status < 90)
            {
                if (MessageBox.Show("¿Seguro que desea descontinuar esta formula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                {
                    fmop.local_formula_change_status(selected_local, int.Parse(ActiveUserCode), 90);
                    fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "END", "Formula Manualmente Descontinuada");
                    MessageBox.Show("Formula descontinuada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Formulas();
                }
            }
            else
            {
                if (status >= 1 && status < 30)
                    MessageBox.Show("No puedes descontinuar una formula que no ha sido aprobada o usada en proceso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 30 && status < 40)
                    MessageBox.Show("No puedes descontinuar una formula en proceso de aprovación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 90)
                    MessageBox.Show("Esta formula ya ha sido descontinuada o eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnc_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int status = fmop.local_formula_get_status(selected_local);

            if (status >= 1 && status < 40) // Antes 40
            {
                if (MessageBox.Show("¿Seguro que desea eliminar esta formula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                {
                    fmop.local_formula_change_status(selected_local, int.Parse(ActiveUserCode), 99);
                    fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "END", "Formula Manualmente Eliminada");
                    MessageBox.Show("Formula eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Formulas();
                }
            }
            else
            {    
                if (status >= 40 && status < 90)
                    MessageBox.Show("No puedes eliminar una formula aprobada o que ya ha sido procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (status >= 90)
                    MessageBox.Show("Esta formula ya ha sido descontinuada o eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdv_data_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e)
        {
            GridView View = sender as GridView;
            GridColumn column = View.GroupedColumns[e.Level];
            if (column == null) return;
            e.LevelAppearance.Combine(column.AppearanceHeader);
        }

        private void btnc_CopySelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que deseas copiar esta formula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                {
                    int currentStatus = fmop.local_formula_get_status(selected_local);

                    if (currentStatus >= 10 && currentStatus <= 80 && currentStatus != 39)
                    {
                        int inserted = fmop.local_formula_copy(selected_local, selected_code, selectedType);

                        Double variation_index = fmop.FML_BI_get_cost_variation_index(selected_parent, inserted);
                        if (variation_index >= 0.01 || variation_index <= -0.01)
                        {
                            if (fmop.local_formula_get_status(inserted) != 39)
                            {
                                fmop.local_formula_change_status(inserted, int.Parse(ActiveUserCode), 39);
                                fmop.local_formula_clean_approvals(inserted);
                                fmop.local_formula_event_entry(inserted, int.Parse(ActiveUserCode), "ERR", string.Format("Variación de Costos ({0}%)", Math.Round((variation_index * 100), 4)));
                                fmop.FML_BI_cost_variation_send_mail_alert(fmop.FML_BI_FL_FF_cost_variation_get_receivers(), inserted, selected_parent);
                                MessageBox.Show("Existe un variación significativa del costo, el detalle ha sido enviado a su correo eléctronico.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", inserted, selected_parent, selectedType, UserGroups);
                        fm.Show();
                        Load_Formulas();
                    }
                    else
                    {
                        if(currentStatus == 39)
                            MessageBox.Show("No puedes copiar una formula que presenta variación de costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No puedes copiar una formula que esta descontinuada o vencida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CopySelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnc_CopySelected_ItemClick(sender, e);
        }

        #endregion

        #region Deprecated Events

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*FML_NewFormula_v2 fm = new FML_NewFormula_v2(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", selectedID, selectedType);
            if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Load_Formulas();
            }*/

            //int parent_formula = select.id_formula_format;
            FML_NewFormula_v3 fm = new FML_NewFormula_v3(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", selected_local, selected_parent, selectedType, UserGroups);
            //if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)   // Ocutlado para que refleje cambio de variacion, cuando son editado los NC
            //{
                fm.Show();
                Load_Formulas();
            //}
        }

        private void grdv_data_DoubleClick(object sender, EventArgs e)
        {
            //FML_NewFormula_v2 fm = new FML_NewFormula_v2(ActiveUserCode, ActiveUserName, ActiveUserType, "edit", selected_local, selectedType);
            //if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    Load_Formulas();
            //}
        }

        private void btn_copy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FML_NewFormula_v2 fm = new FML_NewFormula_v2(ActiveUserCode, ActiveUserName, ActiveUserType, "copy", selected_local, selectedType);
            if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Load_Formulas();
            }
        }

        private void btn_EnableFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (int.Parse(dp.ACS_GetSelectData(string.Format("SELECT [estado] FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", selected_local)).Tables[0].Rows[0][0].ToString()) >= 30)
                {
                    MessageBox.Show("No puedes realizar cambios a un formula que ya ha sido producida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    UpdateStatus(20);

                    Load_Formulas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DisableFormula_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (int.Parse(dp.ACS_GetSelectData(string.Format("SELECT [estado] FROM [dbo].[FML_Formulas_v2] WHERE [id] = {0}", selected_local)).Tables[0].Rows[0][0].ToString()) >= 30)
                {
                    MessageBox.Show("No puedes realizar cambios a un formula que ya ha sido producida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    UpdateStatus(10);

                    Load_Formulas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCollapse_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckGroups();
        }

        private void chk_inactive_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (chk_inactive.Checked == true)
            //{
            //    Load_Formulas(-1);
            //}
            //else 
            //{
            //    Load_Formulas(20);
            //}
        }

        #endregion

        private void btn_Actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Formulas();
        }

        #endregion        

        private void btnHabilitar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de habilitar esta formula?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            //Habilitar Formula Descontinuada
            try
            {
                string sql = @"UPDATE [dbo].[FML_Formulas_v2]
                               SET [estado] = 40 --estado 40 //Aprobadas Disponibles
                                  ,[available_date] = GETDATE()--hoy
                                  ,[due_date] = DATEADD(DAY, 60, GETDATE())--fecha 60 dias despues
                             WHERE id = " + selected_local.ToString();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Load_Formulas();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCambiarEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xSeleccionLookupEdit1.ProQuery = @"SELECT [id]
                                                      ,[descripcion]
                                                FROM [dbo].[FML_Formula_Local_Estado]
                                                where [nulo] = 0 and
                                                      [show_query] = 1";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
            
            try
            {
                conn.Open();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            xSeleccionLookupEdit1.ProConnection = conn;
            xSeleccionLookupEdit1.LoadData();
            conn.Close();
            flyoutPanelEstados.ShowPopup();
        }

        private void xSeleccionLookupEdit1_OnItemSeleccionado(object sender, EventArgs e)
        {
            //Ya seleccion el estado al que va a pasar
            flyoutPanelEstados.HidePopup();

            //Update Estado de Formula
            try
            {
                string sql = @"UPDATE [dbo].[FML_Formulas_v2]
                               SET [estado] = " + xSeleccionLookupEdit1.ProIdSeleccionado.ToString() + 
                             " WHERE id = " + selected_local.ToString();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringCostos);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Load_Formulas();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btn_aprob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FMOP fmop = new FMOP();
            fmop.local_formula_change_status(selected_local, int.Parse(ActiveUserCode), 30);
            fmop.local_formula_clean_approvals(selected_local);
            fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "APR", "Solicitud Aprovación Creada.");
            
            int current_status = fmop.local_formula_get_status(selected_local);
            Double variation_index = fmop.FML_BI_get_cost_variation_index(selected_parent, selected_local);

            if ((current_status >= 30 && current_status < 39) && (variation_index <= 0.01 || variation_index >= -0.01))
            {
                fmop.local_formula_change_status(selected_local, int.Parse(ActiveUserCode), 30);
                fmop.local_formula_approve(selected_local, int.Parse(ActiveUserCode), "PRD");
                fmop.local_formula_approve(selected_local, int.Parse(ActiveUserCode), "FIN");
                fmop.local_formula_change_status(selected_local, int.Parse(ActiveUserCode), 40);
                MessageBox.Show("Formula aprobada con exito.");
                Load_Formulas();
            }
            else
            {
                if (current_status == 39)
                {
                    approve_reject_process("approve", "PRD");
                    Load_Formulas();
                }
            }
        }
        private void approve_reject_process(string action, string approver_type)
        {
            try
            {
                int current_status = fmop.local_formula_get_status(selected_local);
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
                            if (!fmop.local_formula_exist_approve(selected_local, approver_type))
                            {
                                if (action == "approve")
                                {
                                    if (MessageBox.Show("¿Seguro que deseas aprobar esta formula?", "Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_approve(selected_local, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "APR", "Formula Aprobada.");
                                        MessageBox.Show("Formula Aprobada.", "Aprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else if (action == "reject")
                                {
                                    if (MessageBox.Show("¿Seguro que desear rechazar la formula?", "Rechazo de Formula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_reject(selected_local, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "APR", "Formula Rechazada");
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
                            if (!fmop.local_formula_exist_approve(selected_local, approver_type))
                            {
                                if (action == "approve")
                                {
                                    if (MessageBox.Show("¿Seguro que deseas aprobar esta formula?", "Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_approve(selected_local, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "APR", "Formula Aprobada.");
                                        MessageBox.Show("Formula Aprobada.", "Aprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else if (action == "reject")
                                {
                                    if (MessageBox.Show("¿Seguro que desear rechazar la formula?", "Rechazo de Formula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        fmop.local_formula_reject(selected_local, int.Parse(ActiveUserCode), approver_type);
                                        fmop.local_formula_event_entry(selected_local, int.Parse(ActiveUserCode), "APR", "Formula Rechazada");
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
                        MessageBox.Show("Aún no se ha solicitado aprobación para esta formula", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                for (int i = 0; i < grdv_data.DataRowCount; i++)
                {
                    grdv_data.SetRowCellValue(i, "index", i + 1);
                }

            }
            catch (Exception)
            {

               
            }
        }

        private void grd_data_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            
        }

        private void grd_data_Click(object sender, EventArgs e)
        {
            try
            {
                int deIndex = grdv_data.GetSelectedRows()[0];
                int alIndex = grdv_data.GetSelectedRows()[0] - 1;
                if (alIndex >= 0)
                {

                }
                else
                {
                    //var de = dt.Rows[deIndex];

                    //if (alIndex <0 )
                    //{
                    //    alIndex = 0;
                        
                    //}
                    //else
                    //{
                        
                    //}
                    //var al = dt.Rows[alIndex];

                    //dt.Rows.Remove(de);
                    //dt.Rows.Remove(al);
                    //dt.Rows.InsertAt(de, alIndex);
                    //dt.Rows.InsertAt(al, deIndex);
                    //grd_data.DataSource = dt;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
           


        }

        private void radioBtnEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Formulas();
        }
    }
    }

