namespace LOSA.MigracionACS.Formulas
{
    partial class FML_FF_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_FF_Select));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Select = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_main = new DevExpress.XtraGrid.GridControl();
            this.grdv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_src_formula_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lcl_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_src_formula_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lcl_loaded_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lcl_loaded_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grd_structure = new DevExpress.XtraGrid.GridControl();
            this.grdv_structure = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_structure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_structure)).BeginInit();
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
            this.barStaticItem1,
            this.barHeaderItem1,
            this.btn_Select,
            this.btn_Cancel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.ImageOptions.Image = global::LOSA.Properties.Resources.search_24x24;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Seleccionar Formula Base";
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Select, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Cancel.Caption = "Cancelar";
            this.btn_Cancel.Id = 3;
            this.btn_Cancel.ImageOptions.Image = global::LOSA.Properties.Resources.cancel2_32;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
            // 
            // btn_Select
            // 
            this.btn_Select.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Select.Caption = "Seleccionar";
            this.btn_Select.Id = 2;
            this.btn_Select.ImageOptions.Image = global::LOSA.Properties.Resources.accept2_32;
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Select_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1006, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 594);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1006, 55);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 562);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1006, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 562);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grd_main);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 32);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(472, 562);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Formulas Disponibles";
            // 
            // grd_main
            // 
            this.grd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_main.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_main.Location = new System.Drawing.Point(2, 28);
            this.grd_main.MainView = this.grdv_main;
            this.grd_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_main.MenuManager = this.barManager1;
            this.grd_main.Name = "grd_main";
            this.grd_main.Size = new System.Drawing.Size(468, 532);
            this.grd_main.TabIndex = 3;
            this.grd_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_main});
            this.grd_main.DoubleClick += new System.EventHandler(this.grd_main_DoubleClick);
            // 
            // grdv_main
            // 
            this.grdv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_src_formula_code,
            this.col_lcl_name,
            this.col_src_formula_name,
            this.col_lcl_loaded_by,
            this.col_lcl_loaded_date});
            this.grdv_main.GridControl = this.grd_main;
            this.grdv_main.Name = "grdv_main";
            this.grdv_main.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_main.OptionsBehavior.Editable = false;
            this.grdv_main.OptionsView.EnableAppearanceOddRow = true;
            this.grdv_main.OptionsView.ShowAutoFilterRow = true;
            this.grdv_main.OptionsView.ShowFooter = true;
            this.grdv_main.OptionsView.ShowGroupPanel = false;
            this.grdv_main.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_main_FocusedRowChanged);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_src_formula_code
            // 
            this.col_src_formula_code.Caption = "Código";
            this.col_src_formula_code.FieldName = "src_formula_code";
            this.col_src_formula_code.Name = "col_src_formula_code";
            this.col_src_formula_code.Visible = true;
            this.col_src_formula_code.VisibleIndex = 0;
            this.col_src_formula_code.Width = 64;
            // 
            // col_lcl_name
            // 
            this.col_lcl_name.Caption = "Formula Int.";
            this.col_lcl_name.FieldName = "lcl_name";
            this.col_lcl_name.Name = "col_lcl_name";
            this.col_lcl_name.Visible = true;
            this.col_lcl_name.VisibleIndex = 1;
            this.col_lcl_name.Width = 159;
            // 
            // col_src_formula_name
            // 
            this.col_src_formula_name.Caption = "Formula Ext.";
            this.col_src_formula_name.FieldName = "src_formula_name";
            this.col_src_formula_name.Name = "col_src_formula_name";
            this.col_src_formula_name.Width = 96;
            // 
            // col_lcl_loaded_by
            // 
            this.col_lcl_loaded_by.Caption = "Cargada por";
            this.col_lcl_loaded_by.FieldName = "lcl_loaded_by";
            this.col_lcl_loaded_by.Name = "col_lcl_loaded_by";
            this.col_lcl_loaded_by.Visible = true;
            this.col_lcl_loaded_by.VisibleIndex = 2;
            this.col_lcl_loaded_by.Width = 95;
            // 
            // col_lcl_loaded_date
            // 
            this.col_lcl_loaded_date.Caption = "Cargado el";
            this.col_lcl_loaded_date.FieldName = "lcl_loaded_date";
            this.col_lcl_loaded_date.Name = "col_lcl_loaded_date";
            this.col_lcl_loaded_date.Visible = true;
            this.col_lcl_loaded_date.VisibleIndex = 3;
            this.col_lcl_loaded_date.Width = 67;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.grd_structure);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(472, 32);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(534, 562);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Estructura";
            // 
            // grd_structure
            // 
            this.grd_structure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_structure.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_structure.Location = new System.Drawing.Point(2, 28);
            this.grd_structure.MainView = this.grdv_structure;
            this.grd_structure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_structure.MenuManager = this.barManager1;
            this.grd_structure.Name = "grd_structure";
            this.grd_structure.Size = new System.Drawing.Size(530, 532);
            this.grd_structure.TabIndex = 3;
            this.grd_structure.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_structure});
            // 
            // grdv_structure
            // 
            this.grdv_structure.GridControl = this.grd_structure;
            this.grdv_structure.Name = "grdv_structure";
            this.grdv_structure.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_structure.OptionsBehavior.Editable = false;
            this.grdv_structure.OptionsView.EnableAppearanceOddRow = true;
            this.grdv_structure.OptionsView.ShowFooter = true;
            this.grdv_structure.OptionsView.ShowGroupPanel = false;
            // 
            // FML_FF_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 649);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FML_FF_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Formula Base";
            this.Load += new System.EventHandler(this.FML_FF_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_structure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_structure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.BarButtonItem btn_Select;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grd_structure;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_structure;
        private DevExpress.XtraGrid.GridControl grd_main;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_main;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_src_formula_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_src_formula_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_lcl_loaded_by;
        private DevExpress.XtraGrid.Columns.GridColumn col_lcl_loaded_date;
        private DevExpress.XtraGrid.Columns.GridColumn col_lcl_name;

    }
}