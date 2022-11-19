namespace LOSA.MigracionACS.Formulas
{
    partial class FML_Formulas
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_Formulas));
            this.col_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_inactivate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_activate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_copy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grd_formula = new DevExpress.XtraGrid.GridControl();
            this.grdv_formula = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_especie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fechaC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombreU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_version = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_formula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_formula)).BeginInit();
            this.SuspendLayout();
            // 
            // col_codigo
            // 
            this.col_codigo.Caption = "Código";
            this.col_codigo.FieldName = "codigo";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.Visible = true;
            this.col_codigo.VisibleIndex = 0;
            this.col_codigo.Width = 99;
            // 
            // col_estado
            // 
            this.col_estado.Caption = "Estado";
            this.col_estado.FieldName = "estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.Visible = true;
            this.col_estado.VisibleIndex = 5;
            this.col_estado.Width = 129;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_edit,
            this.btn_nuevo,
            this.btn_activate,
            this.btn_inactivate,
            this.btn_copy});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_inactivate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_activate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_copy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_nuevo)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btn_inactivate
            // 
            this.btn_inactivate.Caption = "Inactivar Formula";
            this.btn_inactivate.Glyph = global::LOSA.Properties.Resources.disable_32x32;
            this.btn_inactivate.Id = 3;
            this.btn_inactivate.Name = "btn_inactivate";
            this.btn_inactivate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_inactivate_ItemClick);
            // 
            // btn_activate
            // 
            this.btn_activate.Caption = "Activar Formula";
            this.btn_activate.Glyph = global::LOSA.Properties.Resources.activate_32x32;
            this.btn_activate.Id = 2;
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_activate_ItemClick);
            // 
            // btn_copy
            // 
            this.btn_copy.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_copy.Caption = "Copiar Formula";
            this.btn_copy.Glyph = global::LOSA.Properties.Resources.copy_32x32;
            this.btn_copy.Id = 4;
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_copy_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_edit.Caption = "Editar Formula";
            this.btn_edit.Glyph = global::LOSA.Properties.Resources.edit_32x32;
            this.btn_edit.Id = 0;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_ItemClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_nuevo.Caption = "Nueva Formula";
            this.btn_nuevo.Glyph = global::LOSA.Properties.Resources.add_32x32;
            this.btn_nuevo.Id = 1;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nuevo_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(727, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 317);
            this.barDockControlBottom.Size = new System.Drawing.Size(727, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 270);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(727, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 270);
            // 
            // grd_formula
            // 
            this.grd_formula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_formula.Location = new System.Drawing.Point(0, 47);
            this.grd_formula.MainView = this.grdv_formula;
            this.grd_formula.MenuManager = this.barManager1;
            this.grd_formula.Name = "grd_formula";
            this.grd_formula.Size = new System.Drawing.Size(727, 270);
            this.grd_formula.TabIndex = 4;
            this.grd_formula.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_formula});
            // 
            // grdv_formula
            // 
            this.grdv_formula.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_codigo,
            this.col_version,
            this.col_nombre,
            this.col_especie,
            this.col_fechaC,
            this.col_nombreU,
            this.col_estado});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.col_codigo;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[codigo] == \'(COPIA)\'";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Azure;
            styleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.col_estado;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[estado] == \'Forecast\'";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Silver;
            styleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            styleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.col_estado;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[estado] == \'Inactivo\'";
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.col_codigo;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition4.Expression = "[codigo] == \'(COPIA)\'  And [estado] == \'Forecast\'";
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.LightCyan;
            styleFormatCondition5.Appearance.BackColor2 = System.Drawing.Color.Azure;
            styleFormatCondition5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition5.Expression = "[estado] == \'Produccion\'";
            this.grdv_formula.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5});
            this.grdv_formula.GridControl = this.grd_formula;
            this.grdv_formula.GroupCount = 1;
            this.grdv_formula.Name = "grdv_formula";
            this.grdv_formula.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_formula.OptionsBehavior.Editable = false;
            this.grdv_formula.OptionsView.ShowAutoFilterRow = true;
            this.grdv_formula.OptionsView.ShowGroupPanel = false;
            this.grdv_formula.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_especie, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_formula.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_formula_FocusedRowChanged);
            this.grdv_formula.DoubleClick += new System.EventHandler(this.grdv_formula_DoubleClick);
            // 
            // col_id
            // 
            this.col_id.Caption = "id";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_nombre
            // 
            this.col_nombre.Caption = "Formula";
            this.col_nombre.FieldName = "nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.Visible = true;
            this.col_nombre.VisibleIndex = 2;
            this.col_nombre.Width = 139;
            // 
            // col_especie
            // 
            this.col_especie.Caption = "Especie";
            this.col_especie.FieldName = "Descripcion";
            this.col_especie.Name = "col_especie";
            this.col_especie.Visible = true;
            this.col_especie.VisibleIndex = 2;
            // 
            // col_fechaC
            // 
            this.col_fechaC.Caption = "Fecha Creación";
            this.col_fechaC.FieldName = "fechaC";
            this.col_fechaC.Name = "col_fechaC";
            this.col_fechaC.Visible = true;
            this.col_fechaC.VisibleIndex = 3;
            this.col_fechaC.Width = 139;
            // 
            // col_nombreU
            // 
            this.col_nombreU.Caption = "Creado Por";
            this.col_nombreU.FieldName = "nombreU";
            this.col_nombreU.Name = "col_nombreU";
            this.col_nombreU.Visible = true;
            this.col_nombreU.VisibleIndex = 4;
            this.col_nombreU.Width = 161;
            // 
            // col_version
            // 
            this.col_version.Caption = "Versión";
            this.col_version.FieldName = "version";
            this.col_version.Name = "col_version";
            this.col_version.Visible = true;
            this.col_version.VisibleIndex = 1;
            this.col_version.Width = 42;
            // 
            // FML_Formulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 340);
            this.Controls.Add(this.grd_formula);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FML_Formulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FML_Formulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_formula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_formula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_formula;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_formula;
        private DevExpress.XtraBars.BarButtonItem btn_inactivate;
        private DevExpress.XtraBars.BarButtonItem btn_activate;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn col_especie;
        private DevExpress.XtraGrid.Columns.GridColumn col_fechaC;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombreU;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraBars.BarButtonItem btn_copy;
        private DevExpress.XtraGrid.Columns.GridColumn col_version;

    }
}