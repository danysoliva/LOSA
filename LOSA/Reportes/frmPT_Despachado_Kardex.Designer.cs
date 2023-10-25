
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.grdDetalleDespachos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_inventario_camaron = new DevExpress.XtraGrid.GridControl();
            this.dsReportesInventario1 = new LOSA.Reportes.dsReportesInventario();
            this.grdv_inventario_camaron = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cmdRecargar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_despachadas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_despachados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_despacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltransporte = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleDespachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetalleDespachos
            // 
            this.grdDetalleDespachos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote_pt,
            this.colnum_doc,
            this.colfecha_despacho,
            this.coltransporte,
            this.coldestino,
            this.colcliente,
            this.colud_despachadas,
            this.colkg_despachados});
            this.grdDetalleDespachos.GridControl = this.grd_inventario_camaron;
            this.grdDetalleDespachos.Name = "grdDetalleDespachos";
            this.grdDetalleDespachos.OptionsView.ShowFooter = true;
            this.grdDetalleDespachos.OptionsView.ShowGroupPanel = false;
            // 
            // grd_inventario_camaron
            // 
            this.grd_inventario_camaron.DataMember = "inventario_tarimas";
            this.grd_inventario_camaron.DataSource = this.dsReportesInventario1;
            this.grd_inventario_camaron.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grdDetalleDespachos;
            gridLevelNode1.RelationName = "inventario_tarimas_detalle_despacho_lote";
            this.grd_inventario_camaron.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd_inventario_camaron.Location = new System.Drawing.Point(0, 0);
            this.grd_inventario_camaron.MainView = this.grdv_inventario_camaron;
            this.grd_inventario_camaron.Name = "grd_inventario_camaron";
            this.grd_inventario_camaron.Size = new System.Drawing.Size(1325, 575);
            this.grd_inventario_camaron.TabIndex = 0;
            this.grd_inventario_camaron.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_camaron,
            this.grdDetalleDespachos});
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
            this.grdv_inventario_camaron.OptionsView.ShowFooter = true;
            this.grdv_inventario_camaron.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Code Sap";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // collote_producto_termiado
            // 
            this.collote_producto_termiado.Caption = "Lote Producto Terminado";
            this.collote_producto_termiado.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado.Name = "collote_producto_termiado";
            this.collote_producto_termiado.OptionsColumn.ReadOnly = true;
            this.collote_producto_termiado.Visible = true;
            this.collote_producto_termiado.VisibleIndex = 1;
            // 
            // colud_existencia
            // 
            this.colud_existencia.Caption = "Existencia Ud";
            this.colud_existencia.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colud_existencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colud_existencia.FieldName = "ud_existencia";
            this.colud_existencia.Name = "colud_existencia";
            this.colud_existencia.OptionsColumn.ReadOnly = true;
            this.colud_existencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_existencia", "{0:0.##} Ud")});
            this.colud_existencia.Visible = true;
            this.colud_existencia.VisibleIndex = 2;
            // 
            // colexistencia_kg
            // 
            this.colexistencia_kg.Caption = "Existencia Kg";
            this.colexistencia_kg.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colexistencia_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_kg.FieldName = "existencia_kg";
            this.colexistencia_kg.Name = "colexistencia_kg";
            this.colexistencia_kg.OptionsColumn.ReadOnly = true;
            this.colexistencia_kg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", "{0:#,###,##0.00} Kg")});
            this.colexistencia_kg.Visible = true;
            this.colexistencia_kg.VisibleIndex = 3;
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
            this.tabNavigationPage2.Controls.Add(this.gridControl1);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1325, 575);
            // 
            // cmdRecargar
            // 
            this.cmdRecargar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRecargar.Appearance.Options.UseFont = true;
            this.cmdRecargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRecargar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRecargar.ImageOptions.SvgImage")));
            this.cmdRecargar.Location = new System.Drawing.Point(12, 5);
            this.cmdRecargar.Name = "cmdRecargar";
            this.cmdRecargar.Size = new System.Drawing.Size(104, 38);
            this.cmdRecargar.TabIndex = 8;
            this.cmdRecargar.Text = "Recargar";
            this.cmdRecargar.Click += new System.EventHandler(this.cmdRecargar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(135, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 38);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote PT";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.ReadOnly = true;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 0;
            this.collote_pt.Width = 97;
            // 
            // colud_despachadas
            // 
            this.colud_despachadas.Caption = "Unidades Despachadas";
            this.colud_despachadas.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colud_despachadas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colud_despachadas.FieldName = "ud_despachadas";
            this.colud_despachadas.Name = "colud_despachadas";
            this.colud_despachadas.OptionsColumn.ReadOnly = true;
            this.colud_despachadas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_despachadas", "{0:0.##} Ud")});
            this.colud_despachadas.Visible = true;
            this.colud_despachadas.VisibleIndex = 6;
            this.colud_despachadas.Width = 126;
            // 
            // colkg_despachados
            // 
            this.colkg_despachados.Caption = "Kg Despachados";
            this.colkg_despachados.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colkg_despachados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg_despachados.FieldName = "kg_despachados";
            this.colkg_despachados.Name = "colkg_despachados";
            this.colkg_despachados.OptionsColumn.ReadOnly = true;
            this.colkg_despachados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kg_despachados", "{0:#,###,##0.00} Kg")});
            this.colkg_despachados.Visible = true;
            this.colkg_despachados.VisibleIndex = 7;
            this.colkg_despachados.Width = 137;
            // 
            // colfecha_despacho
            // 
            this.colfecha_despacho.Caption = "Fecha Despacho";
            this.colfecha_despacho.FieldName = "fecha_despacho";
            this.colfecha_despacho.Name = "colfecha_despacho";
            this.colfecha_despacho.OptionsColumn.ReadOnly = true;
            this.colfecha_despacho.Visible = true;
            this.colfecha_despacho.VisibleIndex = 1;
            this.colfecha_despacho.Width = 126;
            // 
            // colnum_doc
            // 
            this.colnum_doc.Caption = "# Orden de Carga";
            this.colnum_doc.FieldName = "num_doc";
            this.colnum_doc.Name = "colnum_doc";
            this.colnum_doc.OptionsColumn.ReadOnly = true;
            this.colnum_doc.Visible = true;
            this.colnum_doc.VisibleIndex = 2;
            this.colnum_doc.Width = 126;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.ReadOnly = true;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 5;
            this.colcliente.Width = 126;
            // 
            // coldestino
            // 
            this.coldestino.Caption = "Destino";
            this.coldestino.FieldName = "destino";
            this.coldestino.Name = "coldestino";
            this.coldestino.OptionsColumn.ReadOnly = true;
            this.coldestino.Visible = true;
            this.coldestino.VisibleIndex = 3;
            this.coldestino.Width = 126;
            // 
            // coltransporte
            // 
            this.coltransporte.Caption = "Transporte";
            this.coltransporte.FieldName = "transporte";
            this.coltransporte.Name = "coltransporte";
            this.coltransporte.OptionsColumn.ReadOnly = true;
            this.coltransporte.Visible = true;
            this.coltransporte.VisibleIndex = 4;
            this.coltransporte.Width = 126;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "inventario_tarimas";
            this.gridControl1.DataSource = this.dsReportesInventario1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.LevelTemplate = this.gridView1;
            gridLevelNode2.RelationName = "inventario_tarimas_detalle_despacho_lote";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1325, 575);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lote PT";
            this.gridColumn1.FieldName = "lote_pt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 97;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Orden de Carga";
            this.gridColumn2.FieldName = "num_doc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 126;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha Despacho";
            this.gridColumn3.FieldName = "fecha_despacho";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 126;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Transporte";
            this.gridColumn4.FieldName = "transporte";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 126;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Destino";
            this.gridColumn5.FieldName = "destino";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 126;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cliente";
            this.gridColumn6.FieldName = "cliente";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 126;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Unidades Despachadas";
            this.gridColumn7.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "ud_despachadas";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_despachadas", "{0:0.##} Ud")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 126;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Kg Despachados";
            this.gridColumn8.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "kg_despachados";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kg_despachados", "{0:#,###,##0.00} Kg")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 137;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.Preview.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView2.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(Toneladas: SUMA={0:0.##.##} TM)")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Code Sap";
            this.gridColumn9.FieldName = "itemcode";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Lote Producto Terminado";
            this.gridColumn10.FieldName = "lote_producto_termiado";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Existencia Ud";
            this.gridColumn11.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "ud_existencia";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_existencia", "{0:0.##} Ud")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Existencia Kg";
            this.gridColumn12.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "existencia_kg";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", "{0:#,###,##0.00} Kg")});
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleDespachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl grd_inventario_camaron;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_camaron;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.SimpleButton cmdRecargar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsReportesInventario dsReportesInventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colud_existencia;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_kg;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDetalleDespachos;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_despacho;
        private DevExpress.XtraGrid.Columns.GridColumn coltransporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldestino;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colud_despachadas;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_despachados;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}