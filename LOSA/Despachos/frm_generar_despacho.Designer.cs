namespace LOSA.Despachos
{
    partial class frm_generar_despacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_generar_despacho));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnatras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKg_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_presentaciones = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.presentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.btn_clear = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtboleta = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtunidades = new DevExpress.XtraEditors.TextEdit();
            this.txtKg = new DevExpress.XtraEditors.TextEdit();
            this.txtconductor = new DevExpress.XtraEditors.TextEdit();
            this.txtvehiculo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grd_destino = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clientedespachoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumDespacho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.grd_conf_filas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.destinosempaquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldestino_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSacosTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestiba_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.destinosempaquesptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductos = new LOSA.TransaccionesPT.dsProductos();
            this.txtInfoConFilas = new System.Windows.Forms.TextBox();
            this.txtNameForIT_Support = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_presentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboleta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtconductor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvehiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_destino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientedespachoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDespacho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_conf_filas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosempaquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosempaquesptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameForIT_Support.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnatras
            // 
            this.btnatras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnatras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnatras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Appearance.Options.UseBackColor = true;
            this.btnatras.Appearance.Options.UseFont = true;
            this.btnatras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnatras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnatras.ImageOptions.Image")));
            this.btnatras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnatras.Location = new System.Drawing.Point(605, 31);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(109, 52);
            this.btnatras.TabIndex = 47;
            this.btnatras.Text = "Atras";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(204, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(398, 40);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Planificacion de Despacho";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 341);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 21);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Productos:";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "detalle_despachosComplete";
            this.grd_data.DataSource = this.ds_despachos;
            this.grd_data.Location = new System.Drawing.Point(3, 367);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.grd_presentaciones,
            this.btn_clear});
            this.grd_data.Size = new System.Drawing.Size(727, 341);
            this.grd_data.TabIndex = 50;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRowNum,
            this.colid,
            this.collot,
            this.colid_pt,
            this.colcantidad,
            this.colpresentacion,
            this.colid_presentacion,
            this.colid_detalle,
            this.colitemcode,
            this.colKg_linea,
            this.coltm_linea,
            this.colDocEntry,
            this.colitemname});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.LevelIndent = 0;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.PreviewIndent = 0;
            this.grdv_data.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanged);
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colRowNum
            // 
            this.colRowNum.FieldName = "RowNum";
            this.colRowNum.Name = "colRowNum";
            this.colRowNum.OptionsColumn.AllowEdit = false;
            this.colRowNum.Visible = true;
            this.colRowNum.VisibleIndex = 0;
            this.colRowNum.Width = 78;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // collot
            // 
            this.collot.FieldName = "lot";
            this.collot.Name = "collot";
            this.collot.OptionsColumn.AllowEdit = false;
            this.collot.Visible = true;
            this.collot.VisibleIndex = 4;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            this.colid_pt.OptionsColumn.AllowEdit = false;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUMA={0:#.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 5;
            // 
            // colpresentacion
            // 
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 6;
            this.colpresentacion.Width = 131;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.AllowEdit = false;
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            this.colid_detalle.OptionsColumn.AllowEdit = false;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 2;
            this.colitemcode.Width = 78;
            // 
            // colKg_linea
            // 
            this.colKg_linea.FieldName = "Kg_linea";
            this.colKg_linea.Name = "colKg_linea";
            this.colKg_linea.OptionsColumn.AllowEdit = false;
            this.colKg_linea.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kg_linea", "SUMA={0:#.##}")});
            this.colKg_linea.Visible = true;
            this.colKg_linea.VisibleIndex = 7;
            this.colKg_linea.Width = 61;
            // 
            // coltm_linea
            // 
            this.coltm_linea.FieldName = "tm_linea";
            this.coltm_linea.Name = "coltm_linea";
            this.coltm_linea.OptionsColumn.AllowEdit = false;
            this.coltm_linea.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tm_linea", "SUMA={0:#.##}")});
            this.coltm_linea.Visible = true;
            this.coltm_linea.VisibleIndex = 8;
            this.coltm_linea.Width = 60;
            // 
            // colDocEntry
            // 
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 1;
            this.colDocEntry.Width = 68;
            // 
            // colitemname
            // 
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.AllowEdit = false;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 3;
            this.colitemname.Width = 83;
            // 
            // grd_presentaciones
            // 
            this.grd_presentaciones.AutoHeight = false;
            this.grd_presentaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_presentaciones.DataSource = this.presentacionesBindingSource;
            this.grd_presentaciones.DisplayMember = "descripcion";
            this.grd_presentaciones.Name = "grd_presentaciones";
            this.grd_presentaciones.ValueMember = "id";
            // 
            // presentacionesBindingSource
            // 
            this.presentacionesBindingSource.DataMember = "presentaciones";
            this.presentacionesBindingSource.DataSource = this.dsRecepcionMPx;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btn_clear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.BackgroundImage = global::LOSA.Properties.Resources.pallet32px1;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.pallet32px1;
            this.btnAgregar.Location = new System.Drawing.Point(595, 256);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 46);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 162);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 21);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "Unidades:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(25, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 21);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Boleta de Bascula:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(25, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 21);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "Peso Kg:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Appearance.Options.UseFont = true;
            this.btn_guardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.ImageOptions.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(12, 31);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(187, 52);
            this.btn_guardar.TabIndex = 55;
            this.btn_guardar.Text = "Seleccion de lote";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txtboleta
            // 
            this.txtboleta.Enabled = false;
            this.txtboleta.Location = new System.Drawing.Point(163, 129);
            this.txtboleta.Name = "txtboleta";
            this.txtboleta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtboleta.Properties.Appearance.Options.UseFont = true;
            this.txtboleta.Size = new System.Drawing.Size(420, 28);
            this.txtboleta.TabIndex = 56;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.BackgroundImage = global::LOSA.Properties.Resources.pallet32px1;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.simpleButton1.Location = new System.Drawing.Point(595, 119);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 46);
            this.simpleButton1.TabIndex = 57;
            this.simpleButton1.Text = "Boleta";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtunidades
            // 
            this.txtunidades.EditValue = "0";
            this.txtunidades.Enabled = false;
            this.txtunidades.Location = new System.Drawing.Point(100, 163);
            this.txtunidades.Name = "txtunidades";
            this.txtunidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtunidades.Properties.Appearance.Options.UseFont = true;
            this.txtunidades.Properties.Mask.EditMask = "d";
            this.txtunidades.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtunidades.Size = new System.Drawing.Size(125, 28);
            this.txtunidades.TabIndex = 58;
            // 
            // txtKg
            // 
            this.txtKg.EditValue = "0";
            this.txtKg.Enabled = false;
            this.txtKg.Location = new System.Drawing.Point(100, 197);
            this.txtKg.Name = "txtKg";
            this.txtKg.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtKg.Properties.Appearance.Options.UseFont = true;
            this.txtKg.Properties.Mask.EditMask = "n";
            this.txtKg.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKg.Size = new System.Drawing.Size(125, 28);
            this.txtKg.TabIndex = 59;
            // 
            // txtconductor
            // 
            this.txtconductor.EditValue = "";
            this.txtconductor.Enabled = false;
            this.txtconductor.Location = new System.Drawing.Point(329, 197);
            this.txtconductor.Name = "txtconductor";
            this.txtconductor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtconductor.Properties.Appearance.Options.UseFont = true;
            this.txtconductor.Properties.Mask.EditMask = "n";
            this.txtconductor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtconductor.Size = new System.Drawing.Size(254, 28);
            this.txtconductor.TabIndex = 63;
            // 
            // txtvehiculo
            // 
            this.txtvehiculo.EditValue = "";
            this.txtvehiculo.Enabled = false;
            this.txtvehiculo.Location = new System.Drawing.Point(329, 163);
            this.txtvehiculo.Name = "txtvehiculo";
            this.txtvehiculo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtvehiculo.Properties.Appearance.Options.UseFont = true;
            this.txtvehiculo.Properties.Mask.EditMask = "d";
            this.txtvehiculo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtvehiculo.Size = new System.Drawing.Size(254, 28);
            this.txtvehiculo.TabIndex = 62;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(241, 200);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 21);
            this.labelControl6.TabIndex = 61;
            this.labelControl6.Text = "Conductor:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(241, 166);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 21);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Vehiculo:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(25, 241);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 21);
            this.labelControl8.TabIndex = 64;
            this.labelControl8.Text = "Cliente Promix:";
            // 
            // grd_destino
            // 
            this.grd_destino.Enabled = false;
            this.grd_destino.Location = new System.Drawing.Point(141, 238);
            this.grd_destino.Name = "grd_destino";
            this.grd_destino.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grd_destino.Properties.Appearance.Options.UseFont = true;
            this.grd_destino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_destino.Properties.DataSource = this.clientedespachoBindingSource;
            this.grd_destino.Properties.DisplayMember = "nombre";
            this.grd_destino.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_destino.Properties.ValueMember = "id";
            this.grd_destino.Size = new System.Drawing.Size(442, 28);
            this.grd_destino.TabIndex = 65;
            // 
            // clientedespachoBindingSource
            // 
            this.clientedespachoBindingSource.DataMember = "cliente_despacho";
            this.clientedespachoBindingSource.DataSource = this.ds_despachos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridLookUpEdit1View.Appearance.GroupFooter.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridLookUpEdit1View.Appearance.GroupPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colcodigo,
            this.colnombre,
            this.coldireccion1,
            this.colciudad,
            this.colpais});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.LevelIndent = 0;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.PreviewIndent = 0;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Cliente";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // coldireccion1
            // 
            this.coldireccion1.FieldName = "direccion1";
            this.coldireccion1.Name = "coldireccion1";
            this.coldireccion1.OptionsColumn.AllowEdit = false;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.Name = "colciudad";
            this.colciudad.OptionsColumn.AllowEdit = false;
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 2;
            // 
            // colpais
            // 
            this.colpais.Caption = "País";
            this.colpais.FieldName = "pais";
            this.colpais.Name = "colpais";
            this.colpais.OptionsColumn.AllowEdit = false;
            this.colpais.Visible = true;
            this.colpais.VisibleIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(25, 98);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 21);
            this.labelControl9.TabIndex = 66;
            this.labelControl9.Text = "# Despacho:";
            // 
            // txtNumDespacho
            // 
            this.txtNumDespacho.Enabled = false;
            this.txtNumDespacho.Location = new System.Drawing.Point(163, 95);
            this.txtNumDespacho.Name = "txtNumDespacho";
            this.txtNumDespacho.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNumDespacho.Properties.Appearance.Options.UseFont = true;
            this.txtNumDespacho.Size = new System.Drawing.Size(160, 28);
            this.txtNumDespacho.TabIndex = 67;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(25, 281);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(165, 21);
            this.labelControl10.TabIndex = 68;
            this.labelControl10.Text = "Configuracion de Filas:";
            // 
            // grd_conf_filas
            // 
            this.grd_conf_filas.EditValue = "";
            this.grd_conf_filas.Location = new System.Drawing.Point(196, 276);
            this.grd_conf_filas.Name = "grd_conf_filas";
            this.grd_conf_filas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grd_conf_filas.Properties.Appearance.Options.UseFont = true;
            this.grd_conf_filas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_conf_filas.Properties.DataSource = this.destinosempaquesBindingSource;
            this.grd_conf_filas.Properties.DisplayMember = "Destino";
            this.grd_conf_filas.Properties.PopupView = this.gridView1;
            this.grd_conf_filas.Properties.ValueMember = "id";
            this.grd_conf_filas.Size = new System.Drawing.Size(387, 28);
            this.grd_conf_filas.TabIndex = 69;
            this.grd_conf_filas.EditValueChanged += new System.EventHandler(this.grd_conf_filas_EditValueChanged);
            // 
            // destinosempaquesBindingSource
            // 
            this.destinosempaquesBindingSource.DataMember = "destinos_empaques";
            this.destinosempaquesBindingSource.DataSource = this.ds_despachos;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldestino_id,
            this.colSacosTotal,
            this.colTipo,
            this.colDestino,
            this.colPresentacion1,
            this.colestiba_id,
            this.colid_presentacion1,
            this.colid2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            // 
            // coldestino_id
            // 
            this.coldestino_id.FieldName = "destino_id";
            this.coldestino_id.Name = "coldestino_id";
            // 
            // colSacosTotal
            // 
            this.colSacosTotal.Caption = "Sacos Totales";
            this.colSacosTotal.FieldName = "SacosTotal";
            this.colSacosTotal.Name = "colSacosTotal";
            this.colSacosTotal.OptionsColumn.AllowEdit = false;
            this.colSacosTotal.Visible = true;
            this.colSacosTotal.VisibleIndex = 0;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo Estiba";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            // 
            // colDestino
            // 
            this.colDestino.Caption = "Destino";
            this.colDestino.FieldName = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.OptionsColumn.AllowEdit = false;
            this.colDestino.Visible = true;
            this.colDestino.VisibleIndex = 1;
            // 
            // colPresentacion1
            // 
            this.colPresentacion1.Caption = "Presentacion";
            this.colPresentacion1.FieldName = "Presentacion";
            this.colPresentacion1.Name = "colPresentacion1";
            this.colPresentacion1.OptionsColumn.AllowEdit = false;
            // 
            // colestiba_id
            // 
            this.colestiba_id.FieldName = "estiba_id";
            this.colestiba_id.Name = "colestiba_id";
            // 
            // colid_presentacion1
            // 
            this.colid_presentacion1.FieldName = "id_presentacion";
            this.colid_presentacion1.Name = "colid_presentacion1";
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // destinosempaquesptBindingSource
            // 
            this.destinosempaquesptBindingSource.DataMember = "destinos_empaques_pt";
            this.destinosempaquesptBindingSource.DataSource = this.dsProductos;
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "dsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInfoConFilas
            // 
            this.txtInfoConFilas.Enabled = false;
            this.txtInfoConFilas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtInfoConFilas.Location = new System.Drawing.Point(64, 310);
            this.txtInfoConFilas.Name = "txtInfoConFilas";
            this.txtInfoConFilas.Size = new System.Drawing.Size(494, 29);
            this.txtInfoConFilas.TabIndex = 70;
            // 
            // txtNameForIT_Support
            // 
            this.txtNameForIT_Support.EditValue = "frm_generar_despacho";
            this.txtNameForIT_Support.Location = new System.Drawing.Point(12, 1);
            this.txtNameForIT_Support.Name = "txtNameForIT_Support";
            this.txtNameForIT_Support.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameForIT_Support.Properties.Appearance.Options.UseFont = true;
            this.txtNameForIT_Support.Size = new System.Drawing.Size(199, 24);
            this.txtNameForIT_Support.TabIndex = 71;
            this.txtNameForIT_Support.Visible = false;
            // 
            // frm_generar_despacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 618);
            this.Controls.Add(this.txtNameForIT_Support);
            this.Controls.Add(this.txtInfoConFilas);
            this.Controls.Add(this.grd_conf_filas);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtNumDespacho);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.grd_destino);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtconductor);
            this.Controls.Add(this.txtvehiculo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtunidades);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtboleta);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btn_guardar);
            this.Name = "frm_generar_despacho";
            this.Text = "Generar Despacho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_presentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboleta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtconductor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvehiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_destino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientedespachoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDespacho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_conf_filas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosempaquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosempaquesptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameForIT_Support.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnatras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.TextEdit txtboleta;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtunidades;
        private DevExpress.XtraEditors.TextEdit txtKg;
        private ds_despachos ds_despachos;
        private DevExpress.XtraEditors.TextEdit txtconductor;
        private DevExpress.XtraEditors.TextEdit txtvehiculo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit grd_presentaciones;
        private System.Windows.Forms.BindingSource presentacionesBindingSource;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_clear;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GridLookUpEdit grd_destino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource clientedespachoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn colpais;
        private DevExpress.XtraGrid.Columns.GridColumn colRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collot;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colKg_linea;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNumDespacho;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GridLookUpEdit grd_conf_filas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource destinosempaquesptBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldestino_id;
        private DevExpress.XtraGrid.Columns.GridColumn colSacosTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colestiba_id;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion1;
        private System.Windows.Forms.TextBox txtInfoConFilas;
        private TransaccionesPT.dsProductos dsProductos;
        private System.Windows.Forms.BindingSource destinosempaquesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraEditors.TextEdit txtNameForIT_Support;
    }
}