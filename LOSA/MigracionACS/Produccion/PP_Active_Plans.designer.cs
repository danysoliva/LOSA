namespace LOSA.MigracionACS.Produccion
{
    partial class PP_Active_Plans
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Active_Plans));
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txt_header = new DevExpress.XtraBars.BarHeaderItem();
            this.btn_queue = new DevExpress.XtraBars.BarButtonItem();
            this.btn_activate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_deactivate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_details = new DevExpress.XtraBars.BarButtonItem();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.grp_requirements = new DevExpress.XtraBars.BarSubItem();
            this.btn_mpreqDay = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mpReqTot = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.Get_requirements = new DevExpress.XtraBars.BarButtonItem();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valid_from = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valid_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_created_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_created_on = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_kg_real = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_kg_reached = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_kg_difference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_rmReq = new DevExpress.XtraGrid.GridControl();
            this.grdv_rmReq = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_material = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_mix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_avg_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_total_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_total_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_plan_prod_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_reqMP_Total = new DevExpress.XtraGrid.GridControl();
            this.grdv_reqMP_Total = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_rmReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_rmReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reqMP_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_reqMP_Total)).BeginInit();
            this.SuspendLayout();
            // 
            // col_status
            // 
            this.col_status.Caption = "Edo";
            this.col_status.FieldName = "status";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 4;
            // 
            // col_estado
            // 
            this.col_estado.Caption = "Estado MP";
            this.col_estado.FieldName = "estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.Visible = true;
            this.col_estado.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Estado MP";
            this.gridColumn8.FieldName = "estado";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
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
            this.btn_activate,
            this.btn_deactivate,
            this.btn_queue,
            this.btn_close,
            this.btn_details,
            this.barToggleSwitchItem1,
            this.Get_requirements,
            this.grp_requirements,
            this.btn_mpreqDay,
            this.btn_mpReqTot,
            this.barStaticItem1,
            this.txt_header});
            this.barManager1.MaxItemId = 12;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.txt_header),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_queue, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_activate, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_deactivate, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_details, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_close, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.grp_requirements, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Glyph = global::LOSA.Properties.Resources.Logo_x32;
            this.barStaticItem1.Id = 10;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txt_header
            // 
            this.txt_header.Caption = "Planes de Producción";
            this.txt_header.Id = 11;
            this.txt_header.Name = "txt_header";
            // 
            // btn_queue
            // 
            this.btn_queue.Caption = "Poner En Cola";
            this.btn_queue.Glyph = global::LOSA.Properties.Resources.pp_queue_plan_32;
            this.btn_queue.Id = 2;
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_queue_ItemClick);
            // 
            // btn_activate
            // 
            this.btn_activate.Caption = "Activar Plan";
            this.btn_activate.Glyph = global::LOSA.Properties.Resources.pp_active_plan_32;
            this.btn_activate.Id = 0;
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_activate_ItemClick);
            // 
            // btn_deactivate
            // 
            this.btn_deactivate.Caption = "Desactivar/Cancelar Plan";
            this.btn_deactivate.Glyph = global::LOSA.Properties.Resources.pp_cancel_plan_32;
            this.btn_deactivate.Id = 1;
            this.btn_deactivate.Name = "btn_deactivate";
            this.btn_deactivate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_deactivate_ItemClick);
            // 
            // btn_details
            // 
            this.btn_details.Caption = "Ver Detalles";
            this.btn_details.Glyph = global::LOSA.Properties.Resources.Details_32x32;
            this.btn_details.Id = 4;
            this.btn_details.Name = "btn_details";
            this.btn_details.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_details.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_details_ItemClick);
            // 
            // btn_close
            // 
            this.btn_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_close.Caption = "Cerrar";
            this.btn_close.Glyph = global::LOSA.Properties.Resources.exit_24x24;
            this.btn_close.Id = 3;
            this.btn_close.Name = "btn_close";
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
            // 
            // grp_requirements
            // 
            this.grp_requirements.Caption = "Requerimientos Materia Prima";
            this.grp_requirements.Glyph = global::LOSA.Properties.Resources.RawMaterial_32x32;
            this.grp_requirements.Id = 7;
            this.grp_requirements.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_mpreqDay),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_mpReqTot)});
            this.grp_requirements.Name = "grp_requirements";
            this.grp_requirements.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btn_mpreqDay
            // 
            this.btn_mpreqDay.Caption = "Diarios";
            this.btn_mpreqDay.Glyph = global::LOSA.Properties.Resources.calendar_day_24x24;
            this.btn_mpreqDay.Id = 8;
            this.btn_mpreqDay.Name = "btn_mpreqDay";
            this.btn_mpreqDay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mpreqDay_ItemClick);
            // 
            // btn_mpReqTot
            // 
            this.btn_mpReqTot.Caption = "Totales";
            this.btn_mpReqTot.Glyph = global::LOSA.Properties.Resources.calendar_month_24x24;
            this.btn_mpReqTot.Id = 9;
            this.btn_mpReqTot.Name = "btn_mpReqTot";
            this.btn_mpReqTot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mpReqTot_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(965, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 398);
            this.barDockControlBottom.Size = new System.Drawing.Size(965, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 351);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(965, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 351);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "Ver Activos";
            this.barToggleSwitchItem1.Id = 5;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // Get_requirements
            // 
            this.Get_requirements.Caption = "Requerimientos de Materia Prima";
            this.Get_requirements.Glyph = global::LOSA.Properties.Resources.RawMaterial_32x32;
            this.Get_requirements.Id = 6;
            this.Get_requirements.Name = "Get_requirements";
            this.Get_requirements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Get_requirements_ItemClick);
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 47);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(965, 351);
            this.grd_data.TabIndex = 4;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_code,
            this.col_description,
            this.col_valid_from,
            this.col_valid_to,
            this.col_status,
            this.col_created_by,
            this.col_created_on,
            this.col_kg_real,
            this.col_kg_reached,
            this.col_kg_difference});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.col_status;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.LightGreen;
            formatConditionRuleExpression1.Appearance.BackColor2 = System.Drawing.Color.PaleGreen;
            formatConditionRuleExpression1.Appearance.BorderColor = System.Drawing.Color.SeaGreen;
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            formatConditionRuleExpression1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseBorderColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[status] == 40";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule1.Tag = "Orden de Producción Activa";
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LightCyan;
            formatConditionRuleExpression2.Appearance.BackColor2 = System.Drawing.Color.Azure;
            formatConditionRuleExpression2.Appearance.BorderColor = System.Drawing.Color.CadetBlue;
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            formatConditionRuleExpression2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseBorderColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[status] == 35";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule2.Tag = "Orden de Producción en Cola";
            this.grdv_data.FormatRules.Add(gridFormatRule1);
            this.grdv_data.FormatRules.Add(gridFormatRule2);
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsCustomization.AllowGroup = false;
            this.grdv_data.OptionsMenu.EnableColumnMenu = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_data_FocusedRowChanged);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_code
            // 
            this.col_code.Caption = "Código";
            this.col_code.FieldName = "code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 0;
            // 
            // col_description
            // 
            this.col_description.Caption = "Descripción";
            this.col_description.FieldName = "description";
            this.col_description.Name = "col_description";
            this.col_description.Visible = true;
            this.col_description.VisibleIndex = 1;
            // 
            // col_valid_from
            // 
            this.col_valid_from.Caption = "Valido Desde";
            this.col_valid_from.DisplayFormat.FormatString = "d";
            this.col_valid_from.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_valid_from.FieldName = "valid_from";
            this.col_valid_from.Name = "col_valid_from";
            this.col_valid_from.Visible = true;
            this.col_valid_from.VisibleIndex = 2;
            // 
            // col_valid_to
            // 
            this.col_valid_to.Caption = "Valido Hasta";
            this.col_valid_to.DisplayFormat.FormatString = "d";
            this.col_valid_to.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_valid_to.FieldName = "valid_to";
            this.col_valid_to.Name = "col_valid_to";
            this.col_valid_to.Visible = true;
            this.col_valid_to.VisibleIndex = 3;
            // 
            // col_created_by
            // 
            this.col_created_by.Caption = "Creado Por";
            this.col_created_by.FieldName = "created_by";
            this.col_created_by.Name = "col_created_by";
            this.col_created_by.Visible = true;
            this.col_created_by.VisibleIndex = 5;
            // 
            // col_created_on
            // 
            this.col_created_on.Caption = "Creado";
            this.col_created_on.DisplayFormat.FormatString = "d";
            this.col_created_on.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_created_on.FieldName = "created_on";
            this.col_created_on.Name = "col_created_on";
            this.col_created_on.Visible = true;
            this.col_created_on.VisibleIndex = 6;
            // 
            // col_kg_real
            // 
            this.col_kg_real.Caption = "Prod. Teorico";
            this.col_kg_real.DisplayFormat.FormatString = "n2";
            this.col_kg_real.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_kg_real.FieldName = "kg_real";
            this.col_kg_real.Name = "col_kg_real";
            this.col_kg_real.Visible = true;
            this.col_kg_real.VisibleIndex = 7;
            // 
            // col_kg_reached
            // 
            this.col_kg_reached.Caption = "Prod. Real";
            this.col_kg_reached.DisplayFormat.FormatString = "n2";
            this.col_kg_reached.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_kg_reached.FieldName = "kg_reached";
            this.col_kg_reached.Name = "col_kg_reached";
            this.col_kg_reached.Visible = true;
            this.col_kg_reached.VisibleIndex = 8;
            // 
            // col_kg_difference
            // 
            this.col_kg_difference.Caption = "Diferencia";
            this.col_kg_difference.DisplayFormat.FormatString = "n2";
            this.col_kg_difference.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_kg_difference.FieldName = "kg_difference";
            this.col_kg_difference.Name = "col_kg_difference";
            this.col_kg_difference.Visible = true;
            this.col_kg_difference.VisibleIndex = 9;
            // 
            // grd_rmReq
            // 
            this.grd_rmReq.Location = new System.Drawing.Point(402, 264);
            this.grd_rmReq.MainView = this.grdv_rmReq;
            this.grd_rmReq.MenuManager = this.barManager1;
            this.grd_rmReq.Name = "grd_rmReq";
            this.grd_rmReq.Size = new System.Drawing.Size(535, 59);
            this.grd_rmReq.TabIndex = 9;
            this.grd_rmReq.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_rmReq});
            this.grd_rmReq.Visible = false;
            // 
            // grdv_rmReq
            // 
            this.grdv_rmReq.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.col_material,
            this.col_mix,
            this.col_avg_kg,
            this.col_total_batch,
            this.col_total_kg,
            this.col_estado,
            this.col_plan_prod_date});
            this.grdv_rmReq.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = this.col_estado;
            gridFormatRule4.ColumnApplyTo = this.col_estado;
            gridFormatRule4.Name = "Format0";
            formatConditionRuleExpression4.Appearance.BackColor = System.Drawing.Color.Coral;
            formatConditionRuleExpression4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression4.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression4.Expression = "[estado] = \'i\'";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            this.grdv_rmReq.FormatRules.Add(gridFormatRule4);
            this.grdv_rmReq.GridControl = this.grd_rmReq;
            this.grdv_rmReq.GroupCount = 1;
            this.grdv_rmReq.Name = "grdv_rmReq";
            this.grdv_rmReq.OptionsBehavior.Editable = false;
            this.grdv_rmReq.OptionsCustomization.AllowGroup = false;
            this.grdv_rmReq.OptionsMenu.EnableColumnMenu = false;
            this.grdv_rmReq.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdv_rmReq.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grdv_rmReq.OptionsView.ShowAutoFilterRow = true;
            this.grdv_rmReq.OptionsView.ShowFooter = true;
            this.grdv_rmReq.OptionsView.ShowGroupPanel = false;
            this.grdv_rmReq.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_plan_prod_date, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // col_material
            // 
            this.col_material.Caption = "Materia Prima";
            this.col_material.FieldName = "material";
            this.col_material.Name = "col_material";
            this.col_material.Visible = true;
            this.col_material.VisibleIndex = 1;
            // 
            // col_mix
            // 
            this.col_mix.Caption = "Mix";
            this.col_mix.FieldName = "mix";
            this.col_mix.Name = "col_mix";
            this.col_mix.Visible = true;
            this.col_mix.VisibleIndex = 2;
            // 
            // col_avg_kg
            // 
            this.col_avg_kg.Caption = "Prom x Batch (Kg)";
            this.col_avg_kg.DisplayFormat.FormatString = "n4";
            this.col_avg_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_avg_kg.FieldName = "avg_kg";
            this.col_avg_kg.Name = "col_avg_kg";
            this.col_avg_kg.Visible = true;
            this.col_avg_kg.VisibleIndex = 3;
            // 
            // col_total_batch
            // 
            this.col_total_batch.Caption = "Total Batch";
            this.col_total_batch.DisplayFormat.FormatString = "n0";
            this.col_total_batch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_total_batch.FieldName = "total_batch";
            this.col_total_batch.Name = "col_total_batch";
            this.col_total_batch.Visible = true;
            this.col_total_batch.VisibleIndex = 4;
            // 
            // col_total_kg
            // 
            this.col_total_kg.Caption = "Total Requerido";
            this.col_total_kg.DisplayFormat.FormatString = "n4";
            this.col_total_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_total_kg.FieldName = "total_kg";
            this.col_total_kg.Name = "col_total_kg";
            this.col_total_kg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_kg", "{0:n4}")});
            this.col_total_kg.Visible = true;
            this.col_total_kg.VisibleIndex = 5;
            // 
            // col_plan_prod_date
            // 
            this.col_plan_prod_date.Caption = "Requerimientos de Materia Prima Para";
            this.col_plan_prod_date.FieldName = "plan_prod_date";
            this.col_plan_prod_date.Name = "col_plan_prod_date";
            this.col_plan_prod_date.Visible = true;
            this.col_plan_prod_date.VisibleIndex = 7;
            // 
            // grd_reqMP_Total
            // 
            this.grd_reqMP_Total.Location = new System.Drawing.Point(402, 329);
            this.grd_reqMP_Total.MainView = this.grdv_reqMP_Total;
            this.grd_reqMP_Total.MenuManager = this.barManager1;
            this.grd_reqMP_Total.Name = "grd_reqMP_Total";
            this.grd_reqMP_Total.Size = new System.Drawing.Size(535, 57);
            this.grd_reqMP_Total.TabIndex = 10;
            this.grd_reqMP_Total.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_reqMP_Total});
            this.grd_reqMP_Total.Visible = false;
            // 
            // grdv_reqMP_Total
            // 
            this.grdv_reqMP_Total.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.grdv_reqMP_Total.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.gridColumn8;
            gridFormatRule3.ColumnApplyTo = this.gridColumn8;
            gridFormatRule3.Name = "Format0";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.Coral;
            formatConditionRuleExpression3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "[estado] = \'i\'";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.grdv_reqMP_Total.FormatRules.Add(gridFormatRule3);
            this.grdv_reqMP_Total.GridControl = this.grd_reqMP_Total;
            this.grdv_reqMP_Total.Name = "grdv_reqMP_Total";
            this.grdv_reqMP_Total.OptionsBehavior.Editable = false;
            this.grdv_reqMP_Total.OptionsCustomization.AllowGroup = false;
            this.grdv_reqMP_Total.OptionsMenu.EnableColumnMenu = false;
            this.grdv_reqMP_Total.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdv_reqMP_Total.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grdv_reqMP_Total.OptionsView.ShowAutoFilterRow = true;
            this.grdv_reqMP_Total.OptionsView.ShowFooter = true;
            this.grdv_reqMP_Total.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Código";
            this.gridColumn2.FieldName = "code";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Materia Prima";
            this.gridColumn3.FieldName = "material";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mix";
            this.gridColumn4.FieldName = "mix";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Prom x Batch (Kg)";
            this.gridColumn5.DisplayFormat.FormatString = "n4";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "avg_kg";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Total Batch";
            this.gridColumn6.DisplayFormat.FormatString = "n0";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "total_batch";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Total Requerido";
            this.gridColumn7.DisplayFormat.FormatString = "n4";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "total_kg";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_kg", "{0:n4}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // PP_Active_Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 398);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.grd_reqMP_Total);
            this.Controls.Add(this.grd_rmReq);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PP_Active_Plans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes de Producción - Propuestos & Activos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PP_Active_Plans_FormClosing);
            this.Load += new System.EventHandler(this.PP_Active_Plans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_rmReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_rmReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reqMP_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_reqMP_Total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_description;
        private DevExpress.XtraGrid.Columns.GridColumn col_valid_from;
        private DevExpress.XtraGrid.Columns.GridColumn col_valid_to;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_created_by;
        private DevExpress.XtraGrid.Columns.GridColumn col_created_on;
        private DevExpress.XtraGrid.Columns.GridColumn col_kg_real;
        private DevExpress.XtraGrid.Columns.GridColumn col_kg_reached;
        private DevExpress.XtraGrid.Columns.GridColumn col_kg_difference;
        private DevExpress.XtraBars.BarButtonItem btn_activate;
        private DevExpress.XtraBars.BarButtonItem btn_deactivate;
        private DevExpress.XtraBars.BarButtonItem btn_queue;
        private DevExpress.XtraBars.BarButtonItem btn_close;
        private DevExpress.XtraBars.BarButtonItem btn_details;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem Get_requirements;
        private DevExpress.XtraBars.BarSubItem grp_requirements;
        private DevExpress.XtraBars.BarButtonItem btn_mpreqDay;
        private DevExpress.XtraBars.BarButtonItem btn_mpReqTot;
        private DevExpress.XtraGrid.GridControl grd_rmReq;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_rmReq;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn col_material;
        private DevExpress.XtraGrid.Columns.GridColumn col_mix;
        private DevExpress.XtraGrid.Columns.GridColumn col_avg_kg;
        private DevExpress.XtraGrid.Columns.GridColumn col_total_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_total_kg;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_plan_prod_date;
        private DevExpress.XtraGrid.GridControl grd_reqMP_Total;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_reqMP_Total;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem txt_header;
    }
}