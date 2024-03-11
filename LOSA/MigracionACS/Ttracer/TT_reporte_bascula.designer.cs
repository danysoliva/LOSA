namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_reporte_bascula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_reporte_bascula));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnactualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btngenerar = new DevExpress.XtraBars.BarButtonItem();
            this.btnexcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnmain = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtfin = new DevExpress.XtraEditors.DateEdit();
            this.dtini = new DevExpress.XtraEditors.DateEdit();
            this.pn_top = new DevExpress.XtraEditors.PanelControl();
            this.grd_bascula = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new LOSA.MigracionACS.Ttracer.dSTtracer();
            this.grdv_bascula = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconductorin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesonetoIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesoSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNegocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUA_DTNA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).BeginInit();
            this.pnmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_top)).BeginInit();
            this.pn_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_bascula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_bascula)).BeginInit();
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
            this.btnactualizar,
            this.btngenerar,
            this.btnclose,
            this.btnexcel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnactualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btngenerar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Caption = "Actualizar reporte";
            this.btnactualizar.Id = 0;
            this.btnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.ImageOptions.Image")));
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnactualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnactualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnactualizar_ItemClick);
            // 
            // btngenerar
            // 
            this.btngenerar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btngenerar.Caption = "Generar reporte";
            this.btngenerar.Id = 1;
            this.btngenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.ImageOptions.Image")));
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btngenerar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngenerar_ItemClick);
            // 
            // btnexcel
            // 
            this.btnexcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnexcel.Caption = "Exportar a excel";
            this.btnexcel.Id = 3;
            this.btnexcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.ImageOptions.Image")));
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexcel_ItemClick);
            // 
            // btnclose
            // 
            this.btnclose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 2;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 591);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 591);
            // 
            // pnmain
            // 
            this.pnmain.Controls.Add(this.labelControl3);
            this.pnmain.Controls.Add(this.labelControl2);
            this.pnmain.Controls.Add(this.labelControl1);
            this.pnmain.Controls.Add(this.dtfin);
            this.pnmain.Controls.Add(this.dtini);
            this.pnmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnmain.Location = new System.Drawing.Point(0, 40);
            this.pnmain.Margin = new System.Windows.Forms.Padding(2);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(1264, 81);
            this.pnmain.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 49);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Fecha final: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 20);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha inicial: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha inicial: ";
            // 
            // dtfin
            // 
            this.dtfin.EditValue = new System.DateTime(2020, 5, 18, 9, 53, 13, 0);
            this.dtfin.Location = new System.Drawing.Point(200, 44);
            this.dtfin.Margin = new System.Windows.Forms.Padding(2);
            this.dtfin.MenuManager = this.barManager1;
            this.dtfin.Name = "dtfin";
            this.dtfin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfin.Properties.Appearance.Options.UseFont = true;
            this.dtfin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Size = new System.Drawing.Size(335, 26);
            this.dtfin.TabIndex = 1;
            // 
            // dtini
            // 
            this.dtini.EditValue = new System.DateTime(2020, 5, 18, 9, 53, 17, 0);
            this.dtini.Location = new System.Drawing.Point(200, 15);
            this.dtini.Margin = new System.Windows.Forms.Padding(2);
            this.dtini.MenuManager = this.barManager1;
            this.dtini.Name = "dtini";
            this.dtini.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtini.Properties.Appearance.Options.UseFont = true;
            this.dtini.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtini.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtini.Size = new System.Drawing.Size(335, 26);
            this.dtini.TabIndex = 0;
            // 
            // pn_top
            // 
            this.pn_top.Controls.Add(this.grd_bascula);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_top.Location = new System.Drawing.Point(0, 121);
            this.pn_top.Margin = new System.Windows.Forms.Padding(2);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1264, 510);
            this.pn_top.TabIndex = 5;
            // 
            // grd_bascula
            // 
            this.grd_bascula.DataMember = "rptbascula";
            this.grd_bascula.DataSource = this.dSTtracer;
            this.grd_bascula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_bascula.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_bascula.Location = new System.Drawing.Point(2, 2);
            this.grd_bascula.MainView = this.grdv_bascula;
            this.grd_bascula.Margin = new System.Windows.Forms.Padding(2);
            this.grd_bascula.MenuManager = this.barManager1;
            this.grd_bascula.Name = "grd_bascula";
            this.grd_bascula.Size = new System.Drawing.Size(1260, 506);
            this.grd_bascula.TabIndex = 0;
            this.grd_bascula.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_bascula});
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_bascula
            // 
            this.grdv_bascula.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcomentarios,
            this.colconductorin,
            this.colNBoleta,
            this.coldestino,
            this.colEmpresaTrans,
            this.colpeso_factura,
            this.colfurgon,
            this.colPesoBruto,
            this.colPesonetoIn,
            this.colTipoBoleta,
            this.colpesoSalida,
            this.colSNegocio,
            this.colNombreBarco,
            this.colorigen,
            this.colvehiculo,
            this.colProducto,
            this.colnumero_factura,
            this.colPFactura,
            this.colunidades,
            this.colPesoProd,
            this.colfechaEntra,
            this.colFechaFin,
            this.colOperador,
            this.colDiferencia,
            this.colDUA_DTNA});
            this.grdv_bascula.DetailHeight = 284;
            this.grdv_bascula.GridControl = this.grd_bascula;
            this.grdv_bascula.GroupCount = 1;
            this.grdv_bascula.Name = "grdv_bascula";
            this.grdv_bascula.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_bascula.OptionsBehavior.Editable = false;
            this.grdv_bascula.OptionsView.ShowAutoFilterRow = true;
            this.grdv_bascula.OptionsView.ShowFooter = true;
            this.grdv_bascula.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTipoBoleta, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colcomentarios
            // 
            this.colcomentarios.Caption = "Comentario";
            this.colcomentarios.FieldName = "comentarios";
            this.colcomentarios.MinWidth = 15;
            this.colcomentarios.Name = "colcomentarios";
            this.colcomentarios.Width = 56;
            // 
            // colconductorin
            // 
            this.colconductorin.Caption = "Piloto";
            this.colconductorin.FieldName = "conductorin";
            this.colconductorin.MinWidth = 15;
            this.colconductorin.Name = "colconductorin";
            this.colconductorin.Width = 56;
            // 
            // colNBoleta
            // 
            this.colNBoleta.Caption = "N Boleta";
            this.colNBoleta.FieldName = "NBoleta";
            this.colNBoleta.MinWidth = 15;
            this.colNBoleta.Name = "colNBoleta";
            this.colNBoleta.Visible = true;
            this.colNBoleta.VisibleIndex = 0;
            this.colNBoleta.Width = 56;
            // 
            // coldestino
            // 
            this.coldestino.Caption = "Destino";
            this.coldestino.FieldName = "destino";
            this.coldestino.Name = "coldestino";
            this.coldestino.OptionsColumn.AllowEdit = false;
            // 
            // colEmpresaTrans
            // 
            this.colEmpresaTrans.FieldName = "EmpresaTrans";
            this.colEmpresaTrans.MinWidth = 15;
            this.colEmpresaTrans.Name = "colEmpresaTrans";
            this.colEmpresaTrans.Width = 56;
            // 
            // colpeso_factura
            // 
            this.colpeso_factura.Caption = "Peso Factura";
            this.colpeso_factura.FieldName = "peso_factura";
            this.colpeso_factura.MinWidth = 15;
            this.colpeso_factura.Name = "colpeso_factura";
            this.colpeso_factura.Width = 56;
            // 
            // colfurgon
            // 
            this.colfurgon.FieldName = "furgon";
            this.colfurgon.MinWidth = 15;
            this.colfurgon.Name = "colfurgon";
            this.colfurgon.Visible = true;
            this.colfurgon.VisibleIndex = 6;
            this.colfurgon.Width = 56;
            // 
            // colPesoBruto
            // 
            this.colPesoBruto.FieldName = "PesoBruto";
            this.colPesoBruto.MinWidth = 15;
            this.colPesoBruto.Name = "colPesoBruto";
            this.colPesoBruto.Width = 56;
            // 
            // colPesonetoIn
            // 
            this.colPesonetoIn.FieldName = "PesonetoIn";
            this.colPesonetoIn.MinWidth = 15;
            this.colPesonetoIn.Name = "colPesonetoIn";
            this.colPesonetoIn.Visible = true;
            this.colPesonetoIn.VisibleIndex = 1;
            this.colPesonetoIn.Width = 56;
            // 
            // colTipoBoleta
            // 
            this.colTipoBoleta.FieldName = "TipoBoleta";
            this.colTipoBoleta.MinWidth = 15;
            this.colTipoBoleta.Name = "colTipoBoleta";
            this.colTipoBoleta.Visible = true;
            this.colTipoBoleta.VisibleIndex = 1;
            this.colTipoBoleta.Width = 56;
            // 
            // colpesoSalida
            // 
            this.colpesoSalida.FieldName = "pesoSalida";
            this.colpesoSalida.MinWidth = 15;
            this.colpesoSalida.Name = "colpesoSalida";
            this.colpesoSalida.Width = 56;
            // 
            // colSNegocio
            // 
            this.colSNegocio.Caption = "Socio de Negocio";
            this.colSNegocio.FieldName = "SNegocio";
            this.colSNegocio.MinWidth = 15;
            this.colSNegocio.Name = "colSNegocio";
            this.colSNegocio.Visible = true;
            this.colSNegocio.VisibleIndex = 2;
            this.colSNegocio.Width = 56;
            // 
            // colNombreBarco
            // 
            this.colNombreBarco.Caption = "Barco";
            this.colNombreBarco.FieldName = "NombreBarco";
            this.colNombreBarco.Name = "colNombreBarco";
            this.colNombreBarco.OptionsColumn.AllowEdit = false;
            // 
            // colorigen
            // 
            this.colorigen.Caption = "Origen";
            this.colorigen.FieldName = "origen";
            this.colorigen.Name = "colorigen";
            this.colorigen.OptionsColumn.AllowEdit = false;
            // 
            // colvehiculo
            // 
            this.colvehiculo.FieldName = "vehiculo";
            this.colvehiculo.MinWidth = 15;
            this.colvehiculo.Name = "colvehiculo";
            this.colvehiculo.Visible = true;
            this.colvehiculo.VisibleIndex = 5;
            this.colvehiculo.Width = 56;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "Producto";
            this.colProducto.MinWidth = 15;
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 3;
            this.colProducto.Width = 56;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.Caption = "N Factura";
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.MinWidth = 15;
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.Visible = true;
            this.colnumero_factura.VisibleIndex = 4;
            this.colnumero_factura.Width = 56;
            // 
            // colPFactura
            // 
            this.colPFactura.Caption = "Peso Segun Factura";
            this.colPFactura.FieldName = "PFactura";
            this.colPFactura.MinWidth = 15;
            this.colPFactura.Name = "colPFactura";
            this.colPFactura.Width = 56;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.FieldName = "unidades";
            this.colunidades.MinWidth = 15;
            this.colunidades.Name = "colunidades";
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 8;
            this.colunidades.Width = 56;
            // 
            // colPesoProd
            // 
            this.colPesoProd.Caption = "Peso producto";
            this.colPesoProd.FieldName = "PesoProd";
            this.colPesoProd.MinWidth = 15;
            this.colPesoProd.Name = "colPesoProd";
            this.colPesoProd.Visible = true;
            this.colPesoProd.VisibleIndex = 7;
            this.colPesoProd.Width = 56;
            // 
            // colfechaEntra
            // 
            this.colfechaEntra.Caption = "Fecha Entrada";
            this.colfechaEntra.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colfechaEntra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfechaEntra.FieldName = "fechaEntra";
            this.colfechaEntra.MinWidth = 15;
            this.colfechaEntra.Name = "colfechaEntra";
            this.colfechaEntra.Width = 56;
            // 
            // colFechaFin
            // 
            this.colFechaFin.Caption = "Fecha salida";
            this.colFechaFin.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colFechaFin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.MinWidth = 15;
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Width = 56;
            // 
            // colOperador
            // 
            this.colOperador.Caption = "Operador";
            this.colOperador.FieldName = "Operador";
            this.colOperador.MinWidth = 15;
            this.colOperador.Name = "colOperador";
            this.colOperador.Width = 56;
            // 
            // colDiferencia
            // 
            this.colDiferencia.Caption = "Diferencia";
            this.colDiferencia.FieldName = "Diferencia";
            this.colDiferencia.MinWidth = 15;
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.Visible = true;
            this.colDiferencia.VisibleIndex = 9;
            this.colDiferencia.Width = 56;
            // 
            // colDUA_DTNA
            // 
            this.colDUA_DTNA.FieldName = "DUA_DTNA";
            this.colDUA_DTNA.Name = "colDUA_DTNA";
            this.colDUA_DTNA.Visible = true;
            this.colDUA_DTNA.VisibleIndex = 10;
            // 
            // TT_reporte_bascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pnmain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TT_reporte_bascula";
            this.Text = "TT_reporte_bascula";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).EndInit();
            this.pnmain.ResumeLayout(false);
            this.pnmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_top)).EndInit();
            this.pn_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_bascula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_bascula)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnactualizar;
        private DevExpress.XtraBars.BarButtonItem btngenerar;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraEditors.PanelControl pnmain;
        private DevExpress.XtraEditors.PanelControl pn_top;
        private DevExpress.XtraGrid.GridControl grd_bascula;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_bascula;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtfin;
        private DevExpress.XtraEditors.DateEdit dtini;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colNBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colSNegocio;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colPFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoProd;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaEntra;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colDiferencia;
        private DevExpress.XtraBars.BarButtonItem btnexcel;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colconductorin;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colPesonetoIn;
        private DevExpress.XtraGrid.Columns.GridColumn colpesoSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colfurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colvehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn coldestino;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBarco;
        private DevExpress.XtraGrid.Columns.GridColumn colorigen;
        private DevExpress.XtraGrid.Columns.GridColumn colDUA_DTNA;
    }
}