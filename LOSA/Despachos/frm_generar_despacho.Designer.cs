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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnatras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.detalledespachosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldscripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocentry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinenum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_presentaciones = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.presentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.colKill = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalledespachosBindingSource)).BeginInit();
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
            this.btnatras.Location = new System.Drawing.Point(608, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(109, 44);
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
            this.labelControl2.Location = new System.Drawing.Point(12, 252);
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
            this.grd_data.DataSource = this.detalledespachosBindingSource;
            this.grd_data.Location = new System.Drawing.Point(3, 279);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.grd_presentaciones,
            this.btn_clear});
            this.grd_data.Size = new System.Drawing.Size(727, 280);
            this.grd_data.TabIndex = 50;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // detalledespachosBindingSource
            // 
            this.detalledespachosBindingSource.DataMember = "detalle_despachos";
            this.detalledespachosBindingSource.DataSource = this.ds_despachos;
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
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldscripcion,
            this.colitemcode,
            this.colpeso,
            this.coldocentry,
            this.collinenum,
            this.colunidades,
            this.colid_presentacion,
            this.colKill});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldscripcion
            // 
            this.coldscripcion.Caption = "Producto";
            this.coldscripcion.FieldName = "dscripcion";
            this.coldscripcion.Name = "coldscripcion";
            this.coldscripcion.OptionsColumn.AllowEdit = false;
            this.coldscripcion.Visible = true;
            this.coldscripcion.VisibleIndex = 1;
            this.coldscripcion.Width = 118;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 118;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Kg";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 2;
            this.colpeso.Width = 118;
            // 
            // coldocentry
            // 
            this.coldocentry.FieldName = "docentry";
            this.coldocentry.Name = "coldocentry";
            // 
            // collinenum
            // 
            this.collinenum.FieldName = "linenum";
            this.collinenum.Name = "collinenum";
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Ud.";
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 3;
            this.colunidades.Width = 118;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.Caption = "Presentacion";
            this.colid_presentacion.ColumnEdit = this.grd_presentaciones;
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.Visible = true;
            this.colid_presentacion.VisibleIndex = 4;
            this.colid_presentacion.Width = 158;
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
            // colKill
            // 
            this.colKill.Caption = "Borrar";
            this.colKill.ColumnEdit = this.btn_clear;
            this.colKill.Name = "colKill";
            this.colKill.Visible = true;
            this.colKill.VisibleIndex = 5;
            this.colKill.Width = 79;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btn_clear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.btnAgregar.Location = new System.Drawing.Point(598, 227);
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
            this.labelControl3.Location = new System.Drawing.Point(25, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 21);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "Unidades:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(28, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 21);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Boleta de Bascula:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(25, 196);
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
            this.btn_guardar.Location = new System.Drawing.Point(12, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(187, 71);
            this.btn_guardar.TabIndex = 55;
            this.btn_guardar.Text = "Crear despacho";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txtboleta
            // 
            this.txtboleta.Enabled = false;
            this.txtboleta.Location = new System.Drawing.Point(166, 100);
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
            this.simpleButton1.Location = new System.Drawing.Point(598, 90);
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
            this.txtunidades.Location = new System.Drawing.Point(103, 145);
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
            this.txtKg.Location = new System.Drawing.Point(103, 193);
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
            this.txtconductor.Location = new System.Drawing.Point(332, 193);
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
            this.txtvehiculo.Location = new System.Drawing.Point(332, 145);
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
            this.labelControl6.Location = new System.Drawing.Point(244, 196);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 21);
            this.labelControl6.TabIndex = 61;
            this.labelControl6.Text = "Conductor:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(244, 148);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 21);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Vehiculo:";
            // 
            // frm_generar_despacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 560);
            this.Controls.Add(this.txtconductor);
            this.Controls.Add(this.txtvehiculo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtunidades);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtboleta);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnatras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_generar_despacho";
            this.Text = "frm_generar_despacho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalledespachosBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource detalledespachosBindingSource;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn coldocentry;
        private DevExpress.XtraGrid.Columns.GridColumn collinenum;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldscripcion;
        private DevExpress.XtraEditors.TextEdit txtconductor;
        private DevExpress.XtraEditors.TextEdit txtvehiculo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit grd_presentaciones;
        private System.Windows.Forms.BindingSource presentacionesBindingSource;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn colKill;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_clear;
    }
}