namespace LOSA.MigracionACS.Produccion
{
    partial class PP_Operator_Panel_v2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Operator_Panel_v2));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.txt_dbMessage = new DevExpress.XtraBars.BarStaticItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.aqfLogo = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnc_SendProducction = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_CloseOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_CancelOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_CopyOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_UpdateData = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_VerifyReach = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btn_SoporteIT = new DevExpress.XtraBars.BarButtonItem();
            this.cmdVerDetalle = new DevExpress.XtraBars.BarButtonItem();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id_plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_plan_prod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pp_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_desc_prod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_form_wincc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_kg_production = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_date_prouction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_priority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_last_mod_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_last_mod_on = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_kg_reached = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_kg_difference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cant_paradas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bag_production = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_version_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lot_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_line_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_line_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_exit,
            this.barEditItem1,
            this.aqfLogo,
            this.barHeaderItem1,
            this.btnc_SendProducction,
            this.btnc_CloseOrder,
            this.btnc_CancelOrder,
            this.btnc_CopyOrder,
            this.btnc_UpdateData,
            this.btnc_VerifyReach,
            this.txt_dbMessage,
            this.barStaticItem1,
            this.btn_SoporteIT,
            this.cmdVerDetalle});
            this.barManager1.MaxItemId = 14;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.txt_dbMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exit),
            new DevExpress.XtraBars.LinkPersistInfo(this.aqfLogo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // txt_dbMessage
            // 
            this.txt_dbMessage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_dbMessage.Id = 10;
            this.txt_dbMessage.Name = "txt_dbMessage";
            // 
            // btn_exit
            // 
            this.btn_exit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_exit.Caption = "Cerrar";
            this.btn_exit.Id = 0;
            this.btn_exit.ImageOptions.Image = global::LOSA.Properties.Resources.exit_24x24;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // aqfLogo
            // 
            this.aqfLogo.Id = 2;
            this.aqfLogo.ImageOptions.Image = global::LOSA.Properties.Resources.Logo_x32;
            this.aqfLogo.Name = "aqfLogo";
            this.aqfLogo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Panel de Control - Ordenes de Producción";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(810, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 362);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 315);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 315);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemPictureEdit1;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // btnc_SendProducction
            // 
            this.btnc_SendProducction.Caption = "Enviar a Producción";
            this.btnc_SendProducction.Id = 4;
            this.btnc_SendProducction.ImageOptions.ImageUri.Uri = "Forward";
            this.btnc_SendProducction.Name = "btnc_SendProducction";
            this.btnc_SendProducction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_SendProducction_ItemClick);
            // 
            // btnc_CloseOrder
            // 
            this.btnc_CloseOrder.Caption = "Cerrar";
            this.btnc_CloseOrder.Id = 5;
            this.btnc_CloseOrder.ImageOptions.ImageUri.Uri = "Close";
            this.btnc_CloseOrder.Name = "btnc_CloseOrder";
            this.btnc_CloseOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_CloseOrder_ItemClick);
            // 
            // btnc_CancelOrder
            // 
            this.btnc_CancelOrder.Caption = "Cancelar";
            this.btnc_CancelOrder.Id = 6;
            this.btnc_CancelOrder.ImageOptions.ImageUri.Uri = "Cancel";
            this.btnc_CancelOrder.Name = "btnc_CancelOrder";
            this.btnc_CancelOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_CancelOrder_ItemClick);
            // 
            // btnc_CopyOrder
            // 
            this.btnc_CopyOrder.Caption = "Copiar";
            this.btnc_CopyOrder.Id = 7;
            this.btnc_CopyOrder.ImageOptions.ImageUri.Uri = "Copy";
            this.btnc_CopyOrder.Name = "btnc_CopyOrder";
            this.btnc_CopyOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_CopyOrder_ItemClick);
            // 
            // btnc_UpdateData
            // 
            this.btnc_UpdateData.Caption = "Actualizar";
            this.btnc_UpdateData.Id = 8;
            this.btnc_UpdateData.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnc_UpdateData.Name = "btnc_UpdateData";
            this.btnc_UpdateData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_UpdateData_ItemClick);
            // 
            // btnc_VerifyReach
            // 
            this.btnc_VerifyReach.Caption = "Verificar Alcance";
            this.btnc_VerifyReach.Id = 9;
            this.btnc_VerifyReach.ImageOptions.ImageUri.Uri = "Find";
            this.btnc_VerifyReach.Name = "btnc_VerifyReach";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btn_SoporteIT
            // 
            this.btn_SoporteIT.Caption = "Soporte IT";
            this.btn_SoporteIT.Id = 12;
            this.btn_SoporteIT.ImageOptions.Image = global::LOSA.Properties.Resources.it_services_16px;
            this.btn_SoporteIT.Name = "btn_SoporteIT";
            this.btn_SoporteIT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_SoporteIT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SoporteIT_ItemClick);
            // 
            // cmdVerDetalle
            // 
            this.cmdVerDetalle.Caption = "Ver Detalle";
            this.cmdVerDetalle.Id = 13;
            this.cmdVerDetalle.ImageOptions.Image = global::LOSA.Properties.Resources.List_details_icon16px;
            this.cmdVerDetalle.Name = "cmdVerDetalle";
            this.cmdVerDetalle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdVerDetalle_ItemClick);
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 47);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(810, 315);
            this.grd_data.TabIndex = 5;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_id_plan,
            this.col_plan_prod,
            this.col_pp_code,
            this.col_id_pt,
            this.col_cod_pt,
            this.col_desc_prod,
            this.col_id_formula,
            this.col_form_wincc,
            this.col_kg_production,
            this.col_date_prouction,
            this.col_priority,
            this.col_status,
            this.col_last_mod_by,
            this.col_last_mod_on,
            this.col_kg_reached,
            this.col_kg_difference,
            this.col_id_orden,
            this.col_cant_paradas,
            this.col_bag_production,
            this.col_code_formula,
            this.col_version_formula,
            this.col_name_formula,
            this.col_lot_number,
            this.col_line_id,
            this.col_line_name});
            this.grdv_data.DetailHeight = 284;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LightGreen;
            formatConditionRuleExpression2.Appearance.BackColor2 = System.Drawing.Color.PaleGreen;
            formatConditionRuleExpression2.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseBorderColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[status] == 50";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.grdv_data.FormatRules.Add(gridFormatRule2);
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupCount = 1;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsCustomization.AllowGroup = false;
            this.grdv_data.OptionsMenu.EnableColumnMenu = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_plan_prod, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdv_data_RowClick);
            this.grdv_data.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_data_FocusedRowChanged);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.MinWidth = 17;
            this.col_id.Name = "col_id";
            this.col_id.Width = 64;
            // 
            // col_id_plan
            // 
            this.col_id_plan.Caption = "ID Plan";
            this.col_id_plan.FieldName = "id_plan";
            this.col_id_plan.MinWidth = 17;
            this.col_id_plan.Name = "col_id_plan";
            this.col_id_plan.Width = 64;
            // 
            // col_plan_prod
            // 
            this.col_plan_prod.Caption = "Descripción";
            this.col_plan_prod.FieldName = "plan_prod";
            this.col_plan_prod.MinWidth = 17;
            this.col_plan_prod.Name = "col_plan_prod";
            this.col_plan_prod.Visible = true;
            this.col_plan_prod.VisibleIndex = 2;
            this.col_plan_prod.Width = 64;
            // 
            // col_pp_code
            // 
            this.col_pp_code.Caption = "Código OP";
            this.col_pp_code.FieldName = "pp_code";
            this.col_pp_code.MinWidth = 17;
            this.col_pp_code.Name = "col_pp_code";
            this.col_pp_code.Visible = true;
            this.col_pp_code.VisibleIndex = 0;
            this.col_pp_code.Width = 39;
            // 
            // col_id_pt
            // 
            this.col_id_pt.Caption = "ID PT";
            this.col_id_pt.FieldName = "id_pt";
            this.col_id_pt.MinWidth = 17;
            this.col_id_pt.Name = "col_id_pt";
            this.col_id_pt.Width = 64;
            // 
            // col_cod_pt
            // 
            this.col_cod_pt.Caption = "Código PT";
            this.col_cod_pt.FieldName = "cod_pt";
            this.col_cod_pt.MinWidth = 17;
            this.col_cod_pt.Name = "col_cod_pt";
            this.col_cod_pt.Visible = true;
            this.col_cod_pt.VisibleIndex = 1;
            this.col_cod_pt.Width = 39;
            // 
            // col_desc_prod
            // 
            this.col_desc_prod.Caption = "Producto Terminado";
            this.col_desc_prod.FieldName = "Descripcion";
            this.col_desc_prod.MinWidth = 17;
            this.col_desc_prod.Name = "col_desc_prod";
            this.col_desc_prod.Visible = true;
            this.col_desc_prod.VisibleIndex = 2;
            this.col_desc_prod.Width = 46;
            // 
            // col_id_formula
            // 
            this.col_id_formula.Caption = "ID Formula";
            this.col_id_formula.FieldName = "id_formula";
            this.col_id_formula.MinWidth = 17;
            this.col_id_formula.Name = "col_id_formula";
            this.col_id_formula.Width = 64;
            // 
            // col_form_wincc
            // 
            this.col_form_wincc.Caption = "Código Formula";
            this.col_form_wincc.FieldName = "form_wincc";
            this.col_form_wincc.MinWidth = 17;
            this.col_form_wincc.Name = "col_form_wincc";
            this.col_form_wincc.Width = 84;
            // 
            // col_kg_production
            // 
            this.col_kg_production.Caption = "Kg. Plan.";
            this.col_kg_production.FieldName = "kg_production";
            this.col_kg_production.MinWidth = 17;
            this.col_kg_production.Name = "col_kg_production";
            this.col_kg_production.Visible = true;
            this.col_kg_production.VisibleIndex = 4;
            this.col_kg_production.Width = 35;
            // 
            // col_date_prouction
            // 
            this.col_date_prouction.Caption = "Fecha Producción";
            this.col_date_prouction.FieldName = "date_prouction";
            this.col_date_prouction.MinWidth = 17;
            this.col_date_prouction.Name = "col_date_prouction";
            this.col_date_prouction.Visible = true;
            this.col_date_prouction.VisibleIndex = 11;
            this.col_date_prouction.Width = 69;
            // 
            // col_priority
            // 
            this.col_priority.Caption = "Prioridad";
            this.col_priority.FieldName = "priority";
            this.col_priority.MinWidth = 17;
            this.col_priority.Name = "col_priority";
            this.col_priority.Visible = true;
            this.col_priority.VisibleIndex = 12;
            this.col_priority.Width = 43;
            // 
            // col_status
            // 
            this.col_status.Caption = "Edo.";
            this.col_status.FieldName = "status";
            this.col_status.MinWidth = 17;
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 13;
            this.col_status.Width = 43;
            // 
            // col_last_mod_by
            // 
            this.col_last_mod_by.Caption = "Mod. Por";
            this.col_last_mod_by.FieldName = "last_mod_by";
            this.col_last_mod_by.MinWidth = 17;
            this.col_last_mod_by.Name = "col_last_mod_by";
            this.col_last_mod_by.Visible = true;
            this.col_last_mod_by.VisibleIndex = 14;
            this.col_last_mod_by.Width = 43;
            // 
            // col_last_mod_on
            // 
            this.col_last_mod_on.Caption = "Mod. en";
            this.col_last_mod_on.FieldName = "last_mod_on";
            this.col_last_mod_on.MinWidth = 17;
            this.col_last_mod_on.Name = "col_last_mod_on";
            this.col_last_mod_on.Visible = true;
            this.col_last_mod_on.VisibleIndex = 15;
            this.col_last_mod_on.Width = 89;
            // 
            // col_kg_reached
            // 
            this.col_kg_reached.Caption = "Kg.  Prod.";
            this.col_kg_reached.FieldName = "kg_reached";
            this.col_kg_reached.MinWidth = 17;
            this.col_kg_reached.Name = "col_kg_reached";
            this.col_kg_reached.Width = 64;
            // 
            // col_kg_difference
            // 
            this.col_kg_difference.Caption = "Kg. Dif.";
            this.col_kg_difference.FieldName = "kg_difference";
            this.col_kg_difference.MinWidth = 17;
            this.col_kg_difference.Name = "col_kg_difference";
            this.col_kg_difference.Width = 64;
            // 
            // col_id_orden
            // 
            this.col_id_orden.Caption = "ID Orden";
            this.col_id_orden.FieldName = "id_orden";
            this.col_id_orden.MinWidth = 17;
            this.col_id_orden.Name = "col_id_orden";
            this.col_id_orden.Width = 64;
            // 
            // col_cant_paradas
            // 
            this.col_cant_paradas.Caption = "Paradas";
            this.col_cant_paradas.FieldName = "cant_paradas";
            this.col_cant_paradas.MinWidth = 17;
            this.col_cant_paradas.Name = "col_cant_paradas";
            this.col_cant_paradas.Visible = true;
            this.col_cant_paradas.VisibleIndex = 6;
            this.col_cant_paradas.Width = 34;
            // 
            // col_bag_production
            // 
            this.col_bag_production.Caption = "Sacos";
            this.col_bag_production.FieldName = "bag_production";
            this.col_bag_production.MinWidth = 17;
            this.col_bag_production.Name = "col_bag_production";
            this.col_bag_production.Visible = true;
            this.col_bag_production.VisibleIndex = 5;
            this.col_bag_production.Width = 27;
            // 
            // col_code_formula
            // 
            this.col_code_formula.Caption = "Código Fml.";
            this.col_code_formula.FieldName = "code_formula";
            this.col_code_formula.MinWidth = 17;
            this.col_code_formula.Name = "col_code_formula";
            this.col_code_formula.Visible = true;
            this.col_code_formula.VisibleIndex = 7;
            this.col_code_formula.Width = 27;
            // 
            // col_version_formula
            // 
            this.col_version_formula.Caption = "Version Fml.";
            this.col_version_formula.FieldName = "version_formula";
            this.col_version_formula.MinWidth = 17;
            this.col_version_formula.Name = "col_version_formula";
            this.col_version_formula.Visible = true;
            this.col_version_formula.VisibleIndex = 8;
            this.col_version_formula.Width = 27;
            // 
            // col_name_formula
            // 
            this.col_name_formula.Caption = "Formula";
            this.col_name_formula.FieldName = "name_formula";
            this.col_name_formula.MinWidth = 17;
            this.col_name_formula.Name = "col_name_formula";
            this.col_name_formula.Visible = true;
            this.col_name_formula.VisibleIndex = 9;
            this.col_name_formula.Width = 53;
            // 
            // col_lot_number
            // 
            this.col_lot_number.Caption = "Lote";
            this.col_lot_number.FieldName = "lot_number";
            this.col_lot_number.MinWidth = 17;
            this.col_lot_number.Name = "col_lot_number";
            this.col_lot_number.Visible = true;
            this.col_lot_number.VisibleIndex = 3;
            this.col_lot_number.Width = 29;
            // 
            // col_line_id
            // 
            this.col_line_id.Caption = "ID Linea";
            this.col_line_id.FieldName = "line_id";
            this.col_line_id.MinWidth = 17;
            this.col_line_id.Name = "col_line_id";
            this.col_line_id.Width = 64;
            // 
            // col_line_name
            // 
            this.col_line_name.Caption = "Linea";
            this.col_line_name.FieldName = "line_name";
            this.col_line_name.MinWidth = 17;
            this.col_line_name.Name = "col_line_name";
            this.col_line_name.Visible = true;
            this.col_line_name.VisibleIndex = 10;
            this.col_line_name.Width = 34;
            // 
            // ContextMenu
            // 
            this.ContextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_SendProducction),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_CancelOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_CopyOrder, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_CloseOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_UpdateData, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_VerifyReach),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_SoporteIT),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdVerDetalle)});
            this.ContextMenu.Manager = this.barManager1;
            this.ContextMenu.Name = "ContextMenu";
            // 
            // PP_Operator_Panel_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 362);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PP_Operator_Panel_v2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PP_Operator_Panel_v2_FormClosing);
            this.Load += new System.EventHandler(this.PP_Operator_Panel_v2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem aqfLogo;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_id_plan;
        private DevExpress.XtraGrid.Columns.GridColumn col_plan_prod;
        private DevExpress.XtraGrid.Columns.GridColumn col_pp_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_id_pt;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_pt;
        private DevExpress.XtraGrid.Columns.GridColumn col_desc_prod;
        private DevExpress.XtraGrid.Columns.GridColumn col_id_formula;
        private DevExpress.XtraGrid.Columns.GridColumn col_form_wincc;
        private DevExpress.XtraGrid.Columns.GridColumn col_kg_production;
        private DevExpress.XtraGrid.Columns.GridColumn col_date_prouction;
        private DevExpress.XtraGrid.Columns.GridColumn col_priority;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_last_mod_by;
        private DevExpress.XtraGrid.Columns.GridColumn col_last_mod_on;
        private DevExpress.XtraGrid.Columns.GridColumn col_kg_reached;
        private DevExpress.XtraGrid.Columns.GridColumn col_kg_difference;
        private DevExpress.XtraGrid.Columns.GridColumn col_id_orden;
        private DevExpress.XtraGrid.Columns.GridColumn col_cant_paradas;
        private DevExpress.XtraBars.PopupMenu ContextMenu;
        private DevExpress.XtraBars.BarButtonItem btnc_SendProducction;
        private DevExpress.XtraBars.BarButtonItem btnc_CloseOrder;
        private DevExpress.XtraBars.BarButtonItem btnc_CancelOrder;
        private DevExpress.XtraBars.BarButtonItem btnc_CopyOrder;
        private DevExpress.XtraBars.BarButtonItem btnc_UpdateData;
        private DevExpress.XtraBars.BarButtonItem btnc_VerifyReach;
        private DevExpress.XtraGrid.Columns.GridColumn col_bag_production;
        private DevExpress.XtraGrid.Columns.GridColumn col_code_formula;
        private DevExpress.XtraGrid.Columns.GridColumn col_version_formula;
        private DevExpress.XtraGrid.Columns.GridColumn col_name_formula;
        private DevExpress.XtraGrid.Columns.GridColumn col_lot_number;
        private DevExpress.XtraGrid.Columns.GridColumn col_line_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_line_name;
        private DevExpress.XtraBars.BarStaticItem txt_dbMessage;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem btn_SoporteIT;
        private DevExpress.XtraBars.BarButtonItem cmdVerDetalle;

    }
}