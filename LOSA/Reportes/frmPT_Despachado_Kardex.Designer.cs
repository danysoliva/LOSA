
namespace LOSA.Reportes
{
    partial class frmPT_Despachado_Kardex
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPT_Despachado_Kardex));
            this.grdvDetalleDespachos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_inventario_camaron = new DevExpress.XtraGrid.GridControl();
            this.dsReportesInventario1 = new LOSA.Reportes.dsReportesInventario();
            this.grdv_inventario_camaron = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grd_inventario_Tilapia = new DevExpress.XtraGrid.GridControl();
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
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleDespachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_Tilapia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_Tilapia)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvDetalleDespachos
            // 
            this.grdvDetalleDespachos.GridControl = this.grd_inventario_camaron;
            this.grdvDetalleDespachos.Name = "grdvDetalleDespachos";
            // 
            // grd_inventario_camaron
            // 
            this.grd_inventario_camaron.DataMember = "inventario_tarimas";
            this.grd_inventario_camaron.DataSource = this.dsReportesInventario1;
            this.grd_inventario_camaron.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grdvDetalleDespachos;
            gridLevelNode1.RelationName = "Level1";
            this.grd_inventario_camaron.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd_inventario_camaron.Location = new System.Drawing.Point(0, 0);
            this.grd_inventario_camaron.MainView = this.grdv_inventario_camaron;
            this.grd_inventario_camaron.Name = "grd_inventario_camaron";
            this.grd_inventario_camaron.Size = new System.Drawing.Size(1325, 575);
            this.grd_inventario_camaron.TabIndex = 0;
            this.grd_inventario_camaron.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_camaron,
            this.grdvDetalleDespachos});
            // 
            // dsReportesInventario1
            // 
            this.dsReportesInventario1.DataSetName = "dsReportesInventario";
            this.dsReportesInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_inventario_camaron
            // 
            this.grdv_inventario_camaron.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario_camaron.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario_camaron.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario_camaron.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.collote_producto_termiado,
            this.colud_existencia,
            this.colexistencia_kg});
            this.grdv_inventario_camaron.GridControl = this.grd_inventario_camaron;
            this.grdv_inventario_camaron.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(Toneladas: SUMA={0:0.##.##} TM)")});
            this.grdv_inventario_camaron.Name = "grdv_inventario_camaron";
            this.grdv_inventario_camaron.OptionsView.ShowAutoFilterRow = true;
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabPane1.Location = new System.Drawing.Point(2, 49);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1325, 618);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1325, 618);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Camaron";
            this.tabNavigationPage1.Controls.Add(this.grd_inventario_camaron);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1325, 575);
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
            this.tabNavigationPage2.Size = new System.Drawing.Size(1325, 575);
            // 
            // grd_inventario_Tilapia
            // 
            this.grd_inventario_Tilapia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_inventario_Tilapia.DataMember = "inventario_kardex";
            this.grd_inventario_Tilapia.Location = new System.Drawing.Point(0, 0);
            this.grd_inventario_Tilapia.MainView = this.grdv_inventario_Tilapia;
            this.grd_inventario_Tilapia.Name = "grd_inventario_Tilapia";
            this.grd_inventario_Tilapia.Size = new System.Drawing.Size(1319, 550);
            this.grd_inventario_Tilapia.TabIndex = 0;
            this.grd_inventario_Tilapia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_Tilapia});
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
            this.colexistencia_unidades1.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colexistencia_unidades1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_unidades1.FieldName = "existencia_unidades";
            this.colexistencia_unidades1.Name = "colexistencia_unidades1";
            this.colexistencia_unidades1.OptionsColumn.AllowEdit = false;
            this.colexistencia_unidades1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", "SUMA={0:0.##.##} Ud")});
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
            this.colexistencia_kg1.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colexistencia_kg1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_kg1.FieldName = "existencia_kg";
            this.colexistencia_kg1.Name = "colexistencia_kg1";
            this.colexistencia_kg1.OptionsColumn.AllowEdit = false;
            this.colexistencia_kg1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", "SUMA={0:0.##.##} Kg")});
            this.colexistencia_kg1.Visible = true;
            this.colexistencia_kg1.VisibleIndex = 4;
            // 
            // colexistencia_tm1
            // 
            this.colexistencia_tm1.Caption = "Toneladas";
            this.colexistencia_tm1.DisplayFormat.FormatString = "{0:0.##.##} TM";
            this.colexistencia_tm1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_tm1.FieldName = "existencia_tm";
            this.colexistencia_tm1.Name = "colexistencia_tm1";
            this.colexistencia_tm1.OptionsColumn.AllowEdit = false;
            this.colexistencia_tm1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", "SUMA={0:0.##.##} TM")});
            this.colexistencia_tm1.Visible = true;
            this.colexistencia_tm1.VisibleIndex = 5;
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(12, 5);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 38);
            this.cmdRecargar.TabIndex = 8;
            this.cmdRecargar.Text = "Recargar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(135, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 38);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Excel";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1213, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cerrar";
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // collote_producto_termiado
            // 
            this.collote_producto_termiado.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado.Name = "collote_producto_termiado";
            this.collote_producto_termiado.Visible = true;
            this.collote_producto_termiado.VisibleIndex = 1;
            // 
            // colud_existencia
            // 
            this.colud_existencia.FieldName = "ud_existencia";
            this.colud_existencia.Name = "colud_existencia";
            this.colud_existencia.Visible = true;
            this.colud_existencia.VisibleIndex = 2;
            // 
            // colexistencia_kg
            // 
            this.colexistencia_kg.FieldName = "existencia_kg";
            this.colexistencia_kg.Name = "colexistencia_kg";
            this.colexistencia_kg.Visible = true;
            this.colexistencia_kg.VisibleIndex = 3;
            // 
            // frmPT_Despachado_Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 670);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdRecargar);
            this.Controls.Add(this.tabPane1);
            this.Name = "frmPT_Despachado_Kardex";
            this.Text = "frmPT_Despachado_Kardex";
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalleDespachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_Tilapia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_Tilapia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl grd_inventario_camaron;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_camaron;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl grd_inventario_Tilapia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_Tilapia;
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalleDespachos;
        private dsReportesInventario dsReportesInventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colud_existencia;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_kg;
    }
}