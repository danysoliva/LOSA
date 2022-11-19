namespace LOSA.MigracionACS.Formulas
{
    partial class FML_NC_Structure_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_NC_Structure_View));
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_inclusion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_materialType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_mix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_exportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PrintDirect = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PrintWhere = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 88);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(471, 319);
            this.grd_data.TabIndex = 0;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_codigo,
            this.col_mp,
            this.col_inclusion,
            this.col_peso,
            this.col_materialType,
            this.col_mix});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsCustomization.AllowGroup = false;
            this.grdv_data.OptionsMenu.EnableColumnMenu = false;
            this.grdv_data.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "ID_Item";
            this.col_id.FieldName = "id_item";
            this.col_id.Name = "col_id";
            // 
            // col_codigo
            // 
            this.col_codigo.Caption = "Código";
            this.col_codigo.FieldName = "codigo";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.Visible = true;
            this.col_codigo.VisibleIndex = 0;
            this.col_codigo.Width = 78;
            // 
            // col_mp
            // 
            this.col_mp.Caption = "Materia Prima";
            this.col_mp.FieldName = "material";
            this.col_mp.Name = "col_mp";
            this.col_mp.Visible = true;
            this.col_mp.VisibleIndex = 1;
            this.col_mp.Width = 155;
            // 
            // col_inclusion
            // 
            this.col_inclusion.Caption = "% Inclusion";
            this.col_inclusion.DisplayFormat.FormatString = "p4";
            this.col_inclusion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_inclusion.FieldName = "inclusion";
            this.col_inclusion.Name = "col_inclusion";
            this.col_inclusion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "inclusion", "{0:0.0000%}")});
            this.col_inclusion.Visible = true;
            this.col_inclusion.VisibleIndex = 3;
            this.col_inclusion.Width = 85;
            // 
            // col_peso
            // 
            this.col_peso.Caption = "Peso";
            this.col_peso.DisplayFormat.FormatString = "n4";
            this.col_peso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_peso.FieldName = "peso";
            this.col_peso.Name = "col_peso";
            this.col_peso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "{0:n4}")});
            this.col_peso.Visible = true;
            this.col_peso.VisibleIndex = 2;
            this.col_peso.Width = 100;
            // 
            // col_materialType
            // 
            this.col_materialType.Caption = "Tipo Material";
            this.col_materialType.FieldName = "materialType";
            this.col_materialType.Name = "col_materialType";
            // 
            // col_mix
            // 
            this.col_mix.Caption = "Mix";
            this.col_mix.FieldName = "mix";
            this.col_mix.Name = "col_mix";
            this.col_mix.Visible = true;
            this.col_mix.VisibleIndex = 4;
            this.col_mix.Width = 35;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(471, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::LOSA.Properties.Resources.lab_main_img_banner;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 50D;
            this.pictureEdit1.Size = new System.Drawing.Size(467, 52);
            this.pictureEdit1.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_PrintDirect,
            this.btn_PrintWhere,
            this.btn_exportExcel});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(75, 212);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exportExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_PrintDirect),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_PrintWhere)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // btn_exportExcel
            // 
            this.btn_exportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_exportExcel.Caption = "Exportar";
            this.btn_exportExcel.Id = 2;
            this.btn_exportExcel.ImageUri.Uri = "SendXLS";
            this.btn_exportExcel.Name = "btn_exportExcel";
            this.btn_exportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exportExcel_ItemClick);
            // 
            // btn_PrintDirect
            // 
            this.btn_PrintDirect.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_PrintDirect.Caption = "Impresión Directa";
            this.btn_PrintDirect.Id = 0;
            this.btn_PrintDirect.ImageUri.Uri = "Print";
            this.btn_PrintDirect.Name = "btn_PrintDirect";
            this.btn_PrintDirect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PrintDirect_ItemClick);
            // 
            // btn_PrintWhere
            // 
            this.btn_PrintWhere.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_PrintWhere.Caption = "Dialogo de Impresión";
            this.btn_PrintWhere.Id = 1;
            this.btn_PrintWhere.ImageUri.Uri = "PrintDialog";
            this.btn_PrintWhere.Name = "btn_PrintWhere";
            this.btn_PrintWhere.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PrintWhere_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 56);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(471, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(471, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Size = new System.Drawing.Size(471, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 407);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(471, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
            // 
            // FML_NC_Structure_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 407);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FML_NC_Structure_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Formula";
            this.Load += new System.EventHandler(this.FML_NC_Structure_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_mp;
        private DevExpress.XtraGrid.Columns.GridColumn col_inclusion;
        private DevExpress.XtraGrid.Columns.GridColumn col_peso;
        private DevExpress.XtraGrid.Columns.GridColumn col_materialType;
        private DevExpress.XtraGrid.Columns.GridColumn col_mix;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_PrintDirect;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_PrintWhere;
        private DevExpress.XtraBars.BarButtonItem btn_exportExcel;
    }
}