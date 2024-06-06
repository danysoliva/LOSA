namespace ACS.MP
{
    partial class MP_UltimoCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP_UltimoCosto));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_ActualizarCostProm = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.txt_Mes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.txt_Anio = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.txt_tasaCambio = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btn_NewList = new DevExpress.XtraBars.BarButtonItem();
            this.btnt_save = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar_progress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.txt_status = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.grd_Costos = new DevExpress.XtraGrid.GridControl();
            this.grdv_Costos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_idMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_material = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cant_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valor_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costoxtm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cant_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costoxkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_loadPlantilla = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Costos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_Costos)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnt_save,
            this.txt_tasaCambio,
            this.txt_Anio,
            this.txt_Mes,
            this.bar_progress,
            this.txt_status,
            this.barButtonItem2,
            this.btn_NewList,
            this.btn_ActualizarCostProm,
            this.btn_ExportExcel,
            this.barButtonItem1,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 22;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemSpinEdit4,
            this.repositoryItemProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ActualizarCostProm),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txt_Mes, "", false, true, true, 69),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txt_Anio, "", false, true, true, 74),
            new DevExpress.XtraBars.LinkPersistInfo(this.txt_tasaCambio),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_NewList),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnt_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_ActualizarCostProm
            // 
            this.btn_ActualizarCostProm.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_ActualizarCostProm.Caption = "Actualizar Costo Promedio";
            this.btn_ActualizarCostProm.Id = 17;
            this.btn_ActualizarCostProm.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ActualizarCostProm.ImageOptions.SvgImage")));
            this.btn_ActualizarCostProm.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ActualizarCostProm.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_ActualizarCostProm.Name = "btn_ActualizarCostProm";
            this.btn_ActualizarCostProm.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ActualizarCostProm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ActualizarCostProm_ItemClick);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_ExportExcel.Caption = "Exportar Excel";
            this.btn_ExportExcel.Id = 18;
            this.btn_ExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportExcel.ImageOptions.Image")));
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ExportExcel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Importar Excel";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // txt_Mes
            // 
            this.txt_Mes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_Mes.Caption = "Mes";
            this.txt_Mes.Edit = this.repositoryItemSpinEdit4;
            this.txt_Mes.EditWidth = 68;
            this.txt_Mes.Id = 10;
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.txt_Mes.EditValueChanged += new System.EventHandler(this.txt_Mes_EditValueChanged);
            // 
            // repositoryItemSpinEdit4
            // 
            this.repositoryItemSpinEdit4.AutoHeight = false;
            this.repositoryItemSpinEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit4.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.repositoryItemSpinEdit4.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit4.Name = "repositoryItemSpinEdit4";
            // 
            // txt_Anio
            // 
            this.txt_Anio.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_Anio.Caption = "Año";
            this.txt_Anio.Edit = this.repositoryItemSpinEdit3;
            this.txt_Anio.EditWidth = 70;
            this.txt_Anio.Id = 9;
            this.txt_Anio.Name = "txt_Anio";
            this.txt_Anio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.txt_Anio.EditValueChanged += new System.EventHandler(this.txt_Anio_EditValueChanged);
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.MaxValue = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.MinValue = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // txt_tasaCambio
            // 
            this.txt_tasaCambio.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txt_tasaCambio.Caption = "Tasa de Cambio";
            this.txt_tasaCambio.Edit = this.repositoryItemSpinEdit1;
            this.txt_tasaCambio.EditWidth = 72;
            this.txt_tasaCambio.Id = 2;
            this.txt_tasaCambio.Name = "txt_tasaCambio";
            this.txt_tasaCambio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.txt_tasaCambio.EditValueChanged += new System.EventHandler(this.txt_tasaCambio_EditValueChanged);
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // btn_NewList
            // 
            this.btn_NewList.Caption = "Generar Nueva Lista";
            this.btn_NewList.Id = 16;
            this.btn_NewList.ImageOptions.Image = global::LOSA.Properties.Resources.Generate_32x32;
            this.btn_NewList.Name = "btn_NewList";
            this.btn_NewList.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_NewList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NewList_ItemClick);
            // 
            // btnt_save
            // 
            this.btnt_save.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnt_save.Caption = "Guardar Información";
            this.btnt_save.Id = 1;
            this.btnt_save.ImageOptions.Image = global::LOSA.Properties.Resources.save_32x32;
            this.btnt_save.Name = "btnt_save";
            this.btnt_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnt_save_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_progress),
            new DevExpress.XtraBars.LinkPersistInfo(this.txt_status)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar_progress
            // 
            this.bar_progress.AutoFillWidth = true;
            this.bar_progress.Edit = this.repositoryItemProgressBar1;
            this.bar_progress.EditWidth = 553;
            this.bar_progress.Id = 11;
            this.bar_progress.Name = "bar_progress";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // txt_status
            // 
            this.txt_status.Caption = "...";
            this.txt_status.Id = 13;
            this.txt_status.Name = "txt_status";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(782, 80);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(782, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 80);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 324);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(782, 80);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 324);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "id";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.MinValue = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // grd_Costos
            // 
            this.grd_Costos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Costos.Location = new System.Drawing.Point(0, 80);
            this.grd_Costos.MainView = this.grdv_Costos;
            this.grd_Costos.MenuManager = this.barManager1;
            this.grd_Costos.Name = "grd_Costos";
            this.grd_Costos.Size = new System.Drawing.Size(782, 324);
            this.grd_Costos.TabIndex = 4;
            this.grd_Costos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_Costos});
            // 
            // grdv_Costos
            // 
            this.grdv_Costos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_idMP,
            this.col_codigo,
            this.col_material,
            this.col_cant_tm,
            this.col_valor_tm,
            this.col_costoxtm,
            this.col_cant_kg,
            this.col_costoxkg,
            this.colcode_sap});
            this.grdv_Costos.DetailHeight = 284;
            this.grdv_Costos.GridControl = this.grd_Costos;
            this.grdv_Costos.Name = "grdv_Costos";
            this.grdv_Costos.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_Costos.OptionsView.ShowAutoFilterRow = true;
            this.grdv_Costos.OptionsView.ShowGroupPanel = false;
            this.grdv_Costos.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_Costos_RowStyle);
            this.grdv_Costos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_Costos_CellValueChanged);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.MinWidth = 17;
            this.col_id.Name = "col_id";
            this.col_id.OptionsColumn.AllowEdit = false;
            this.col_id.OptionsColumn.ReadOnly = true;
            this.col_id.Visible = true;
            this.col_id.VisibleIndex = 0;
            this.col_id.Width = 64;
            // 
            // col_idMP
            // 
            this.col_idMP.Caption = "ID";
            this.col_idMP.FieldName = "idMP";
            this.col_idMP.MinWidth = 17;
            this.col_idMP.Name = "col_idMP";
            this.col_idMP.OptionsColumn.AllowEdit = false;
            this.col_idMP.OptionsColumn.ReadOnly = true;
            this.col_idMP.Width = 33;
            // 
            // col_codigo
            // 
            this.col_codigo.Caption = "Codigo";
            this.col_codigo.FieldName = "codigo";
            this.col_codigo.MinWidth = 17;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.OptionsColumn.AllowEdit = false;
            this.col_codigo.OptionsColumn.AllowFocus = false;
            this.col_codigo.Visible = true;
            this.col_codigo.VisibleIndex = 1;
            this.col_codigo.Width = 157;
            // 
            // col_material
            // 
            this.col_material.Caption = "Nombre Materia Prima";
            this.col_material.FieldName = "material";
            this.col_material.MinWidth = 17;
            this.col_material.Name = "col_material";
            this.col_material.OptionsColumn.AllowEdit = false;
            this.col_material.OptionsColumn.AllowFocus = false;
            this.col_material.Visible = true;
            this.col_material.VisibleIndex = 3;
            this.col_material.Width = 314;
            // 
            // col_cant_tm
            // 
            this.col_cant_tm.Caption = "Toneladas Metricas";
            this.col_cant_tm.DisplayFormat.FormatString = "#,###,###.0000 TM";
            this.col_cant_tm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_cant_tm.FieldName = "cant_tm";
            this.col_cant_tm.MinWidth = 17;
            this.col_cant_tm.Name = "col_cant_tm";
            this.col_cant_tm.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_cant_tm.Width = 65;
            // 
            // col_valor_tm
            // 
            this.col_valor_tm.Caption = "Costo Promedio";
            this.col_valor_tm.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_valor_tm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_valor_tm.FieldName = "valor_tm";
            this.col_valor_tm.MinWidth = 17;
            this.col_valor_tm.Name = "col_valor_tm";
            this.col_valor_tm.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_valor_tm.Visible = true;
            this.col_valor_tm.VisibleIndex = 4;
            this.col_valor_tm.Width = 113;
            // 
            // col_costoxtm
            // 
            this.col_costoxtm.Caption = "Costo X TM";
            this.col_costoxtm.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_costoxtm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_costoxtm.FieldName = "costoxtm";
            this.col_costoxtm.MinWidth = 17;
            this.col_costoxtm.Name = "col_costoxtm";
            this.col_costoxtm.OptionsColumn.AllowEdit = false;
            this.col_costoxtm.OptionsColumn.AllowFocus = false;
            this.col_costoxtm.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_costoxtm.Width = 65;
            // 
            // col_cant_kg
            // 
            this.col_cant_kg.Caption = "Kilogramos";
            this.col_cant_kg.DisplayFormat.FormatString = "#,###,###.0000 Kg";
            this.col_cant_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_cant_kg.FieldName = "cant_kg";
            this.col_cant_kg.MinWidth = 17;
            this.col_cant_kg.Name = "col_cant_kg";
            this.col_cant_kg.OptionsColumn.AllowEdit = false;
            this.col_cant_kg.OptionsColumn.AllowFocus = false;
            this.col_cant_kg.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_cant_kg.Width = 65;
            // 
            // col_costoxkg
            // 
            this.col_costoxkg.Caption = "Costo X Kg";
            this.col_costoxkg.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_costoxkg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_costoxkg.FieldName = "costoxkg";
            this.col_costoxkg.MinWidth = 17;
            this.col_costoxkg.Name = "col_costoxkg";
            this.col_costoxkg.OptionsColumn.AllowEdit = false;
            this.col_costoxkg.OptionsColumn.AllowFocus = false;
            this.col_costoxkg.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_costoxkg.Width = 73;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.MinWidth = 17;
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.OptionsColumn.ReadOnly = true;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 2;
            this.colcode_sap.Width = 99;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 4";
            // 
            // btn_loadPlantilla
            // 
            this.btn_loadPlantilla.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btn_loadPlantilla.Caption = "Generar Nueva Lista de Precios";
            this.btn_loadPlantilla.Id = 0;
            this.btn_loadPlantilla.ImageOptions.Image = global::LOSA.Properties.Resources.Generate_32x32;
            this.btn_loadPlantilla.Name = "btn_loadPlantilla";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Atras";
            this.btnClose.Id = 21;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // MP_UltimoCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 426);
            this.Controls.Add(this.grd_Costos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MP_UltimoCosto.IconOptions.Icon")));
            this.Name = "MP_UltimoCosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimo Costo Calculado";
            this.Load += new System.EventHandler(this.MP_UltimoCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Costos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_Costos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_Costos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_Costos;
        private DevExpress.XtraBars.BarButtonItem btnt_save;
        private DevExpress.XtraBars.BarEditItem txt_tasaCambio;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraBars.BarEditItem txt_Mes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit4;
        private DevExpress.XtraBars.BarEditItem txt_Anio;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraBars.BarEditItem bar_progress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarStaticItem txt_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_idMP;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_material;
        private DevExpress.XtraGrid.Columns.GridColumn col_cant_tm;
        private DevExpress.XtraGrid.Columns.GridColumn col_valor_tm;
        private DevExpress.XtraGrid.Columns.GridColumn col_costoxtm;
        private DevExpress.XtraGrid.Columns.GridColumn col_cant_kg;
        private DevExpress.XtraGrid.Columns.GridColumn col_costoxkg;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_loadPlantilla;
        private DevExpress.XtraBars.BarButtonItem btn_NewList;
        private DevExpress.XtraBars.BarButtonItem btn_ActualizarCostProm;
        private DevExpress.XtraBars.BarButtonItem btn_ExportExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnClose;
    }
}