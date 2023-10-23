
namespace LOSA.Reportes
{
    partial class frmReporteGeneralProductoTermnado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneralProductoTermnado));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grd_inventario_Tilapia = new DevExpress.XtraGrid.GridControl();
            this.dsReportesInventario1 = new LOSA.Reportes.dsReportesInventario();
            this.grdv_inventario_Tilapia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_unidades1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_in1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_out1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_kg1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_tm1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAjuste = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_Tilapia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_Tilapia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1223, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.tabPane1);
            this.panelControl2.Location = new System.Drawing.Point(5, 70);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1323, 597);
            this.panelControl2.TabIndex = 4;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabPane1.Location = new System.Drawing.Point(2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1319, 593);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1319, 593);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Camaron";
            this.tabNavigationPage1.Controls.Add(this.gridControl1);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1319, 550);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Tilapia";
            this.tabNavigationPage2.Controls.Add(this.grd_inventario_Tilapia);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1319, 550);
            // 
            // grd_inventario_Tilapia
            // 
            this.grd_inventario_Tilapia.DataMember = "inventario_kardex";
            this.grd_inventario_Tilapia.DataSource = this.dsReportesInventario1;
            this.grd_inventario_Tilapia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_inventario_Tilapia.Location = new System.Drawing.Point(0, 0);
            this.grd_inventario_Tilapia.MainView = this.grdv_inventario_Tilapia;
            this.grd_inventario_Tilapia.Name = "grd_inventario_Tilapia";
            this.grd_inventario_Tilapia.Size = new System.Drawing.Size(1319, 550);
            this.grd_inventario_Tilapia.TabIndex = 0;
            this.grd_inventario_Tilapia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_Tilapia});
            // 
            // dsReportesInventario1
            // 
            this.dsReportesInventario1.DataSetName = "dsReportesInventario";
            this.dsReportesInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_inventario_Tilapia
            // 
            this.grdv_inventario_Tilapia.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_inventario_Tilapia.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colcode_sap1,
            this.colProducto1,
            this.collote_pt1,
            this.colcantidad_in1,
            this.colcantidad_out1,
            this.colexistencia_unidades1,
            this.colpeso_in1,
            this.colpeso_out1,
            this.colexistencia_kg1,
            this.colexistencia_tm1});
            this.grdv_inventario_Tilapia.GridControl = this.grd_inventario_Tilapia;
            this.grdv_inventario_Tilapia.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(TM Existencia: SUMA={0:0.##.##} TM)")});
            this.grdv_inventario_Tilapia.Name = "grdv_inventario_Tilapia";
            this.grdv_inventario_Tilapia.OptionsView.ShowAutoFilterRow = true;
            this.grdv_inventario_Tilapia.OptionsView.ShowFooter = true;
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // colcode_sap1
            // 
            this.colcode_sap1.Caption = "Cod. SAP";
            this.colcode_sap1.FieldName = "code_sap";
            this.colcode_sap1.Name = "colcode_sap1";
            this.colcode_sap1.OptionsColumn.AllowEdit = false;
            this.colcode_sap1.Visible = true;
            this.colcode_sap1.VisibleIndex = 0;
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "N Producto";
            this.colProducto1.FieldName = "Producto";
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.OptionsColumn.AllowEdit = false;
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 1;
            // 
            // collote_pt1
            // 
            this.collote_pt1.Caption = "# Lote";
            this.collote_pt1.FieldName = "lote_pt";
            this.collote_pt1.Name = "collote_pt1";
            this.collote_pt1.OptionsColumn.AllowEdit = false;
            this.collote_pt1.Visible = true;
            this.collote_pt1.VisibleIndex = 2;
            // 
            // colcantidad_in1
            // 
            this.colcantidad_in1.Caption = "Cantidad Entrada";
            this.colcantidad_in1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colcantidad_in1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_in1.FieldName = "cantidad_in";
            this.colcantidad_in1.Name = "colcantidad_in1";
            this.colcantidad_in1.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad_out1
            // 
            this.colcantidad_out1.Caption = "Cantidad Salida";
            this.colcantidad_out1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colcantidad_out1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_out1.FieldName = "cantidad_out";
            this.colcantidad_out1.Name = "colcantidad_out1";
            this.colcantidad_out1.OptionsColumn.AllowEdit = false;
            // 
            // colexistencia_unidades1
            // 
            this.colexistencia_unidades1.Caption = "Unidades en Existencia";
            this.colexistencia_unidades1.DisplayFormat.FormatString = "{0:#,###,##0} Ud";
            this.colexistencia_unidades1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_unidades1.FieldName = "existencia_unidades";
            this.colexistencia_unidades1.Name = "colexistencia_unidades1";
            this.colexistencia_unidades1.OptionsColumn.AllowEdit = false;
            this.colexistencia_unidades1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", "SUMA={0:#,###,##0} Ud")});
            this.colexistencia_unidades1.Visible = true;
            this.colexistencia_unidades1.VisibleIndex = 3;
            // 
            // colpeso_in1
            // 
            this.colpeso_in1.Caption = "Peso Entrada";
            this.colpeso_in1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso_in1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_in1.FieldName = "peso_in";
            this.colpeso_in1.Name = "colpeso_in1";
            this.colpeso_in1.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_out1
            // 
            this.colpeso_out1.Caption = "Peso Salida";
            this.colpeso_out1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso_out1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_out1.FieldName = "peso_out";
            this.colpeso_out1.Name = "colpeso_out1";
            this.colpeso_out1.OptionsColumn.AllowEdit = false;
            // 
            // colexistencia_kg1
            // 
            this.colexistencia_kg1.Caption = "Kilogramos";
            this.colexistencia_kg1.DisplayFormat.FormatString = "{0:#,###,##0.00} Kg";
            this.colexistencia_kg1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_kg1.FieldName = "existencia_kg";
            this.colexistencia_kg1.Name = "colexistencia_kg1";
            this.colexistencia_kg1.OptionsColumn.AllowEdit = false;
            this.colexistencia_kg1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", "SUMA={0:#,###,##0.00}  Kg")});
            this.colexistencia_kg1.Visible = true;
            this.colexistencia_kg1.VisibleIndex = 4;
            // 
            // colexistencia_tm1
            // 
            this.colexistencia_tm1.Caption = "Toneladas";
            this.colexistencia_tm1.DisplayFormat.FormatString = "{0:#,###,##0.00} TM";
            this.colexistencia_tm1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_tm1.FieldName = "existencia_tm";
            this.colexistencia_tm1.Name = "colexistencia_tm1";
            this.colexistencia_tm1.OptionsColumn.AllowEdit = false;
            this.colexistencia_tm1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", "SUMA={0:#,###,##0.00} TM")});
            this.colexistencia_tm1.Visible = true;
            this.colexistencia_tm1.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1113, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 47);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdAjuste
            // 
            this.cmdAjuste.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjuste.Appearance.Options.UseFont = true;
            this.cmdAjuste.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAjuste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAjuste.ImageOptions.Image")));
            this.cmdAjuste.Location = new System.Drawing.Point(12, 8);
            this.cmdAjuste.Name = "cmdAjuste";
            this.cmdAjuste.Size = new System.Drawing.Size(172, 47);
            this.cmdAjuste.TabIndex = 6;
            this.cmdAjuste.Text = "Ajuste de Inventario";
            this.cmdAjuste.Click += new System.EventHandler(this.cmdAjuste_Click);
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(1003, 9);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 47);
            this.cmdRecargar.TabIndex = 7;
            this.cmdRecargar.Text = "Recargar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "inventario_kardex";
            this.gridControl1.DataSource = this.dsReportesInventario1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1319, 550);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(TM Existencia: SUMA={0:0.##.##} TM)")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id_pt";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cod. SAP";
            this.gridColumn2.FieldName = "code_sap";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "N Producto";
            this.gridColumn3.FieldName = "Producto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "# Lote";
            this.gridColumn4.FieldName = "lote_pt";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cantidad Entrada";
            this.gridColumn5.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "cantidad_in";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cantidad Salida";
            this.gridColumn6.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "cantidad_out";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Unidades en Existencia";
            this.gridColumn7.DisplayFormat.FormatString = "{0:#,###,##0} Ud";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "existencia_unidades";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", "SUMA={0:#,###,##0} Ud")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Peso Entrada";
            this.gridColumn8.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "peso_in";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Peso Salida";
            this.gridColumn9.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "peso_out";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Kilogramos";
            this.gridColumn10.DisplayFormat.FormatString = "{0:#,###,##0.00} Kg";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "existencia_kg";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", "SUMA={0:#,###,##0.00}  Kg")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Toneladas";
            this.gridColumn11.DisplayFormat.FormatString = "{0:#,###,##0.00} TM";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "existencia_tm";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", "SUMA={0:#,###,##0.00} TM")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            // 
            // frmReporteGeneralProductoTermnado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 670);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.cmdAjuste);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReporteGeneralProductoTermnado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General de Producto Terminado.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_Tilapia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_Tilapia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl grd_inventario_Tilapia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_Tilapia;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdAjuste;
        private dsReportesInventario dsReportesInventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_out1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_unidades1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_in1;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_out1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_kg1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_tm1;
        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}