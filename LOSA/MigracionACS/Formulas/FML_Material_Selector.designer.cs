namespace LOSA.MigracionACS.ACS.Formulas
{
    partial class FML_Material_Selector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_Material_Selector));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_addClose = new DevExpress.XtraBars.BarButtonItem();
            this.btn_add = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnc_add = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_addClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnc_NCStructure = new DevExpress.XtraBars.BarButtonItem();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_mix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.col_nc_use = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenu)).BeginInit();
            this.SuspendLayout();
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
            this.btn_add,
            this.btn_addClose,
            this.btn_close,
            this.barStaticItem1,
            this.barHeaderItem1,
            this.btnc_add,
            this.btnc_addClose,
            this.btnc_NCStructure});
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_close),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btn_close
            // 
            this.btn_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_close.Caption = "Salir";
            this.btn_close.Glyph = global::LOSA.Properties.Resources.exit_32x32;
            this.btn_close.Id = 2;
            this.btn_close.Name = "btn_close";
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Glyph = global::LOSA.Properties.Resources.search_32x32;
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Selección de Materiales";
            this.barHeaderItem1.Id = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_addClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_add)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btn_addClose
            // 
            this.btn_addClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_addClose.Caption = "Agregar y Cerrar";
            this.btn_addClose.Glyph = global::LOSA.Properties.Resources.accept2_32;
            this.btn_addClose.Id = 1;
            this.btn_addClose.Name = "btn_addClose";
            this.btn_addClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addClose_ItemClick);
            // 
            // btn_add
            // 
            this.btn_add.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_add.Caption = "Agregar";
            this.btn_add.Glyph = global::LOSA.Properties.Resources.add_32x32;
            this.btn_add.Id = 0;
            this.btn_add.Name = "btn_add";
            this.btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_add_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(483, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Size = new System.Drawing.Size(483, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 360);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(483, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 360);
            // 
            // btnc_add
            // 
            this.btnc_add.Caption = "Agregar";
            this.btnc_add.Id = 5;
            this.btnc_add.ImageUri.Uri = "Add";
            this.btnc_add.Name = "btnc_add";
            this.btnc_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_add_ItemClick);
            // 
            // btnc_addClose
            // 
            this.btnc_addClose.Caption = "Agregar y Cerrar";
            this.btnc_addClose.Id = 6;
            this.btnc_addClose.ImageUri.Uri = "Apply";
            this.btnc_addClose.Name = "btnc_addClose";
            this.btnc_addClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_addClose_ItemClick);
            // 
            // btnc_NCStructure
            // 
            this.btnc_NCStructure.Caption = "Estructura Núcleo";
            this.btnc_NCStructure.Id = 7;
            this.btnc_NCStructure.ImageUri.Uri = "ListBullets";
            this.btnc_NCStructure.Name = "btnc_NCStructure";
            this.btnc_NCStructure.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnc_NCStructure_ItemClick);
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 47);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(483, 360);
            this.grd_data.TabIndex = 4;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_code,
            this.col_name,
            this.col_mix,
            this.col_type,
            this.col_nc_use});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdv_data_RowClick);
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
            this.col_code.Width = 96;
            // 
            // col_name
            // 
            this.col_name.Caption = "Material";
            this.col_name.FieldName = "name";
            this.col_name.Name = "col_name";
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 1;
            this.col_name.Width = 313;
            // 
            // col_mix
            // 
            this.col_mix.Caption = "Mix";
            this.col_mix.FieldName = "mix";
            this.col_mix.Name = "col_mix";
            this.col_mix.Visible = true;
            this.col_mix.VisibleIndex = 2;
            this.col_mix.Width = 56;
            // 
            // col_type
            // 
            this.col_type.Caption = "Tipo";
            this.col_type.FieldName = "type";
            this.col_type.Name = "col_type";
            // 
            // ContextMenu
            // 
            this.ContextMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_addClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnc_NCStructure)});
            this.ContextMenu.Manager = this.barManager1;
            this.ContextMenu.Name = "ContextMenu";
            // 
            // col_nc_use
            // 
            this.col_nc_use.Caption = "Es NC";
            this.col_nc_use.FieldName = "nc_use";
            this.col_nc_use.Name = "col_nc_use";
            // 
            // FML_Material_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FML_Material_Selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Materiales";
            this.Load += new System.EventHandler(this.FML_Material_Selector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_close;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btn_addClose;
        private DevExpress.XtraBars.BarButtonItem btn_add;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_mix;
        private DevExpress.XtraGrid.Columns.GridColumn col_type;
        private DevExpress.XtraBars.PopupMenu ContextMenu;
        private DevExpress.XtraBars.BarButtonItem btnc_add;
        private DevExpress.XtraBars.BarButtonItem btnc_addClose;
        private DevExpress.XtraBars.BarButtonItem btnc_NCStructure;
        private DevExpress.XtraGrid.Columns.GridColumn col_nc_use;
    }
}