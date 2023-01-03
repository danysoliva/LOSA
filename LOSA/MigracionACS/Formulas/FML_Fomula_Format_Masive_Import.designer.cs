namespace LOSA.MigracionACS.Formulas
{
    partial class FML_Fomula_Format_Masive_Import
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
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_Fomula_Format_Masive_Import));
            this.grd_Data = new DevExpress.XtraGrid.GridControl();
            this.grdv_Data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Record = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FileLName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_OnError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Verify = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Accept = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnc_Verify = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.btnc_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_ExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ContextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_AutoName = new DevExpress.XtraEditors.CheckEdit();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.btn_ViewFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_AutoName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Data
            // 
            this.grd_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Data.Location = new System.Drawing.Point(0, 95);
            this.grd_Data.MainView = this.grdv_Data;
            this.grd_Data.Name = "grd_Data";
            this.grd_Data.Size = new System.Drawing.Size(586, 505);
            this.grd_Data.TabIndex = 0;
            this.grd_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_Data});
            // 
            // grdv_Data
            // 
            this.grdv_Data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Record,
            this.col_FileName,
            this.col_FileLName,
            this.col_OnError,
            this.col_FilePath});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.Bisque;
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            formatConditionRuleValue1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "[OnError] = True";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightGreen;
            formatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.PaleGreen;
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            formatConditionRuleValue2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue2.Expression = "[OnError] = False";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.grdv_Data.FormatRules.Add(gridFormatRule1);
            this.grdv_Data.FormatRules.Add(gridFormatRule2);
            this.grdv_Data.GridControl = this.grd_Data;
            this.grdv_Data.Name = "grdv_Data";
            this.grdv_Data.OptionsCustomization.AllowGroup = false;
            this.grdv_Data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_Data.OptionsView.ShowGroupPanel = false;
            this.grdv_Data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdv_Data_RowClick);
            this.grdv_Data.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_Data_FocusedRowChanged);
            // 
            // col_Record
            // 
            this.col_Record.Caption = "Record No.";
            this.col_Record.FieldName = "Record";
            this.col_Record.Name = "col_Record";
            this.col_Record.OptionsColumn.AllowEdit = false;
            this.col_Record.OptionsColumn.AllowFocus = false;
            this.col_Record.Visible = true;
            this.col_Record.VisibleIndex = 0;
            this.col_Record.Width = 66;
            // 
            // col_FileName
            // 
            this.col_FileName.Caption = "Nombre Archivo";
            this.col_FileName.FieldName = "FileName";
            this.col_FileName.Name = "col_FileName";
            this.col_FileName.OptionsColumn.ReadOnly = true;
            this.col_FileName.Visible = true;
            this.col_FileName.VisibleIndex = 1;
            this.col_FileName.Width = 234;
            // 
            // col_FileLName
            // 
            this.col_FileLName.Caption = "Nombre Local";
            this.col_FileLName.FieldName = "FileLName";
            this.col_FileLName.Name = "col_FileLName";
            this.col_FileLName.Visible = true;
            this.col_FileLName.VisibleIndex = 2;
            this.col_FileLName.Width = 268;
            // 
            // col_OnError
            // 
            this.col_OnError.Caption = "Error";
            this.col_OnError.FieldName = "OnError";
            this.col_OnError.Name = "col_OnError";
            this.col_OnError.OptionsColumn.AllowEdit = false;
            this.col_OnError.OptionsColumn.AllowFocus = false;
            // 
            // col_FilePath
            // 
            this.col_FilePath.Caption = "Directorio";
            this.col_FilePath.FieldName = "FilePath";
            this.col_FilePath.Name = "col_FilePath";
            this.col_FilePath.OptionsColumn.AllowEdit = false;
            this.col_FilePath.OptionsColumn.AllowFocus = false;
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
            this.btn_Verify,
            this.btn_Delete,
            this.btn_Accept,
            this.btn_Cancel,
            this.btn_ExportExcel,
            this.btnc_Verify,
            this.barCheckItem1,
            this.btnc_Delete,
            this.btnc_ExportExcel,
            this.btn_ViewFile,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Verify),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Accept),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportExcel, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btn_Verify
            // 
            this.btn_Verify.Caption = "Verificar Carga";
            this.btn_Verify.Id = 0;
            this.btn_Verify.ImageUri.Uri = "SaveDialog";
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Verify_ItemClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Eliminar Linea";
            this.btn_Delete.Id = 1;
            this.btn_Delete.ImageUri.Uri = "Delete";
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Accept.Caption = "Aceptar y Cargar";
            this.btn_Accept.Id = 2;
            this.btn_Accept.ImageUri.Uri = "SaveAll";
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Accept_ItemClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Cancel.Caption = "Cancelar";
            this.btn_Cancel.Id = 3;
            this.btn_Cancel.ImageUri.Uri = "Cancel";
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.Caption = "Exportar Lista a Excel";
            this.btn_ExportExcel.Id = 4;
            this.btn_ExportExcel.ImageUri.Uri = "ExportToXLSX";
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ExportExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(586, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Size = new System.Drawing.Size(586, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 569);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(586, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 569);
            // 
            // btnc_Verify
            // 
            this.btnc_Verify.Caption = "Verificar Carga";
            this.btnc_Verify.Id = 5;
            this.btnc_Verify.ImageUri.Uri = "SaveDialog";
            this.btnc_Verify.Name = "btnc_Verify";
            this.btnc_Verify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_Verify_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // btnc_Delete
            // 
            this.btnc_Delete.Caption = "Eliminar Linea";
            this.btnc_Delete.Id = 7;
            this.btnc_Delete.ImageUri.Uri = "Delete";
            this.btnc_Delete.Name = "btnc_Delete";
            this.btnc_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_Delete_ItemClick);
            // 
            // btnc_ExportExcel
            // 
            this.btnc_ExportExcel.Caption = "Exportar Lista a Excel";
            this.btnc_ExportExcel.Id = 8;
            this.btnc_ExportExcel.ImageUri.Uri = "ExportToXLSX";
            this.btnc_ExportExcel.Name = "btnc_ExportExcel";
            this.btnc_ExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_ExportExcel_ItemClick);
            // 
            // ContextMenu
            // 
            this.ContextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ViewFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_Verify, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_ExportExcel, true)});
            this.ContextMenu.Manager = this.barManager1;
            this.ContextMenu.Name = "ContextMenu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_AutoName);
            this.panel1.Controls.Add(this.dt_hasta);
            this.panel1.Controls.Add(this.labelControl17);
            this.panel1.Controls.Add(this.labelControl18);
            this.panel1.Controls.Add(this.dt_desde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 64);
            this.panel1.TabIndex = 5;
            // 
            // chk_AutoName
            // 
            this.chk_AutoName.Location = new System.Drawing.Point(443, 30);
            this.chk_AutoName.MenuManager = this.barManager1;
            this.chk_AutoName.Name = "chk_AutoName";
            this.chk_AutoName.Properties.Caption = "Auto-Generar Nombres";
            this.chk_AutoName.Size = new System.Drawing.Size(140, 19);
            this.chk_AutoName.TabIndex = 39;
            this.chk_AutoName.CheckedChanged += new System.EventHandler(this.chk_AutoName_CheckedChanged);
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(227, 30);
            this.dt_hasta.MenuManager = this.barManager1;
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_hasta.Properties.ValidateOnEnterKey = true;
            this.dt_hasta.Size = new System.Drawing.Size(196, 20);
            this.dt_hasta.TabIndex = 38;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(227, 11);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(67, 13);
            this.labelControl17.TabIndex = 37;
            this.labelControl17.Text = "Validas hasta:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(14, 11);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(69, 13);
            this.labelControl18.TabIndex = 36;
            this.labelControl18.Text = "Validas desde:";
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(14, 30);
            this.dt_desde.MenuManager = this.barManager1;
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_desde.Size = new System.Drawing.Size(195, 20);
            this.dt_desde.TabIndex = 35;
            // 
            // btn_ViewFile
            // 
            this.btn_ViewFile.Caption = "Ver Archivo";
            this.btn_ViewFile.Id = 9;
            this.btn_ViewFile.ImageUri.Uri = "Show";
            this.btn_ViewFile.Name = "btn_ViewFile";
            this.btn_ViewFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ViewFile_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // FML_Fomula_Format_Masive_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 600);
            this.Controls.Add(this.grd_Data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FML_Fomula_Format_Masive_Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Formulas - Carga Masiva";
            this.Load += new System.EventHandler(this.FML_Fomula_Format_Masive_Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_AutoName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_Data;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Verify;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Accept;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu ContextMenu;
        private DevExpress.XtraBars.BarButtonItem btn_ExportExcel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraGrid.Columns.GridColumn col_FileName;
        private DevExpress.XtraGrid.Columns.GridColumn col_FileLName;
        private DevExpress.XtraGrid.Columns.GridColumn col_OnError;
        private DevExpress.XtraGrid.Columns.GridColumn col_FilePath;
        private DevExpress.XtraGrid.Columns.GridColumn col_Record;
        private DevExpress.XtraBars.BarButtonItem btnc_Verify;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem btnc_Delete;
        private DevExpress.XtraBars.BarButtonItem btnc_ExportExcel;
        private DevExpress.XtraEditors.CheckEdit chk_AutoName;
        private DevExpress.XtraBars.BarButtonItem btn_ViewFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}