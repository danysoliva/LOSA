
namespace LOSA.Trazabilidad.ReportesTRZ
{
    partial class frmTrazabilidadHaciaAdelanteByMP_Lot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrazabilidadHaciaAdelanteByMP_Lot));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesTRZ1 = new LOSA.Trazabilidad.ReportesTRZ.dsReportesTRZ();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLotePT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnClearInfo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_pais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente_aqua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLinkBoletaView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFac_promix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.lblMateriaPrimaName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesTRZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLinkBoletaView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataMember = "pt_list_trz";
            this.gridControl1.DataSource = this.dsReportesTRZ1;
            this.gridControl1.Location = new System.Drawing.Point(2, 93);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(364, 484);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesTRZ1
            // 
            this.dsReportesTRZ1.DataSetName = "dsReportesTRZ";
            this.dsReportesTRZ1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLotePT,
            this.colProducto,
            this.colcant_mp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colLotePT
            // 
            this.colLotePT.FieldName = "Lote PT";
            this.colLotePT.Name = "colLotePT";
            this.colLotePT.OptionsColumn.AllowEdit = false;
            this.colLotePT.Visible = true;
            this.colLotePT.VisibleIndex = 0;
            this.colLotePT.Width = 67;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 173;
            // 
            // colcant_mp
            // 
            this.colcant_mp.DisplayFormat.FormatString = "###,##0.00 Kg";
            this.colcant_mp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_mp.FieldName = "cant_mp";
            this.colcant_mp.Name = "colcant_mp";
            this.colcant_mp.Visible = true;
            this.colcant_mp.VisibleIndex = 2;
            this.colcant_mp.Width = 95;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.ImageOptions.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(248, 46);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(118, 41);
            this.btnGenerar.TabIndex = 42;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 21);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Lote MP";
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(76, 55);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Size = new System.Drawing.Size(166, 32);
            this.txtlote.TabIndex = 40;
            this.txtlote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlote_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(224, 1);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(704, 39);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Trazabilidad de lote Materia Prima";
            // 
            // btnClearInfo
            // 
            this.btnClearInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInfo.Appearance.Options.UseFont = true;
            this.btnClearInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearInfo.ImageOptions.Image")));
            this.btnClearInfo.Location = new System.Drawing.Point(372, 46);
            this.btnClearInfo.Name = "btnClearInfo";
            this.btnClearInfo.Size = new System.Drawing.Size(118, 41);
            this.btnClearInfo.TabIndex = 43;
            this.btnClearInfo.Text = "Borrar";
            this.btnClearInfo.Click += new System.EventHandler(this.btnClearInfo_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "detalle_destinos";
            this.gridControl2.DataSource = this.dsReportesTRZ1;
            this.gridControl2.Location = new System.Drawing.Point(372, 142);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnLinkBoletaView});
            this.gridControl2.Size = new System.Drawing.Size(760, 435);
            this.gridControl2.TabIndex = 44;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDespacho,
            this.colcliente,
            this.colKeyBoleta,
            this.colIdCliente,
            this.colNombreCliente,
            this.colcodigo_pais,
            this.colpais,
            this.coldireccion1,
            this.coldireccion2,
            this.colciudad,
            this.colcliente_aqua,
            this.colnumero_factura,
            this.colcardname,
            this.colNumID,
            this.colFac_promix});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colDespacho
            // 
            this.colDespacho.FieldName = "Despacho";
            this.colDespacho.Name = "colDespacho";
            this.colDespacho.OptionsColumn.AllowEdit = false;
            this.colDespacho.Visible = true;
            this.colDespacho.VisibleIndex = 0;
            this.colDespacho.Width = 61;
            // 
            // colcliente
            // 
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            // 
            // colKeyBoleta
            // 
            this.colKeyBoleta.Caption = "Id Boleta";
            this.colKeyBoleta.FieldName = "KeyBoleta";
            this.colKeyBoleta.Name = "colKeyBoleta";
            this.colKeyBoleta.OptionsColumn.AllowEdit = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "Id Cliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsColumn.AllowEdit = false;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "Nombre Cliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.OptionsColumn.AllowEdit = false;
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 2;
            this.colNombreCliente.Width = 110;
            // 
            // colcodigo_pais
            // 
            this.colcodigo_pais.FieldName = "codigo_pais";
            this.colcodigo_pais.Name = "colcodigo_pais";
            this.colcodigo_pais.OptionsColumn.AllowEdit = false;
            // 
            // colpais
            // 
            this.colpais.Caption = "País";
            this.colpais.FieldName = "pais";
            this.colpais.Name = "colpais";
            this.colpais.OptionsColumn.AllowEdit = false;
            this.colpais.Visible = true;
            this.colpais.VisibleIndex = 6;
            this.colpais.Width = 58;
            // 
            // coldireccion1
            // 
            this.coldireccion1.Caption = "Dirección 1";
            this.coldireccion1.FieldName = "direccion1";
            this.coldireccion1.Name = "coldireccion1";
            this.coldireccion1.OptionsColumn.AllowEdit = false;
            this.coldireccion1.Visible = true;
            this.coldireccion1.VisibleIndex = 7;
            this.coldireccion1.Width = 58;
            // 
            // coldireccion2
            // 
            this.coldireccion2.Caption = "Dirección 2";
            this.coldireccion2.FieldName = "direccion2";
            this.coldireccion2.Name = "coldireccion2";
            this.coldireccion2.OptionsColumn.AllowEdit = false;
            this.coldireccion2.Visible = true;
            this.coldireccion2.VisibleIndex = 8;
            this.coldireccion2.Width = 58;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.Name = "colciudad";
            this.colciudad.OptionsColumn.AllowEdit = false;
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 9;
            this.colciudad.Width = 73;
            // 
            // colcliente_aqua
            // 
            this.colcliente_aqua.Caption = "Cod. Cliente Aqua";
            this.colcliente_aqua.FieldName = "cliente_aqua";
            this.colcliente_aqua.Name = "colcliente_aqua";
            this.colcliente_aqua.OptionsColumn.AllowEdit = false;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.Caption = "Factura Aquafeed";
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.OptionsColumn.AllowEdit = false;
            this.colnumero_factura.Visible = true;
            this.colnumero_factura.VisibleIndex = 3;
            this.colnumero_factura.Width = 100;
            // 
            // colcardname
            // 
            this.colcardname.Caption = "Socio";
            this.colcardname.FieldName = "cardname";
            this.colcardname.Name = "colcardname";
            this.colcardname.OptionsColumn.AllowEdit = false;
            this.colcardname.Visible = true;
            this.colcardname.VisibleIndex = 4;
            this.colcardname.Width = 72;
            // 
            // colNumID
            // 
            this.colNumID.Caption = "N. Boleta";
            this.colNumID.ColumnEdit = this.btnLinkBoletaView;
            this.colNumID.FieldName = "NumID";
            this.colNumID.Name = "colNumID";
            this.colNumID.Visible = true;
            this.colNumID.VisibleIndex = 1;
            this.colNumID.Width = 52;
            // 
            // btnLinkBoletaView
            // 
            this.btnLinkBoletaView.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnLinkBoletaView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnLinkBoletaView.Name = "btnLinkBoletaView";
            this.btnLinkBoletaView.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnLinkBoletaView_ButtonClick);
            // 
            // colFac_promix
            // 
            this.colFac_promix.Caption = "Fact. PROMIX";
            this.colFac_promix.FieldName = "Fac_promix";
            this.colFac_promix.Name = "colFac_promix";
            this.colFac_promix.OptionsColumn.AllowEdit = false;
            this.colFac_promix.Visible = true;
            this.colFac_promix.VisibleIndex = 5;
            this.colFac_promix.Width = 100;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(402, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(704, 24);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Clientes que recibieron el Producto ";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(976, 1);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(156, 52);
            this.cmdHome.TabIndex = 46;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // lblMateriaPrimaName
            // 
            this.lblMateriaPrimaName.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrimaName.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblMateriaPrimaName.Appearance.Options.UseFont = true;
            this.lblMateriaPrimaName.Appearance.Options.UseForeColor = true;
            this.lblMateriaPrimaName.Location = new System.Drawing.Point(76, 19);
            this.lblMateriaPrimaName.Name = "lblMateriaPrimaName";
            this.lblMateriaPrimaName.Size = new System.Drawing.Size(61, 21);
            this.lblMateriaPrimaName.TabIndex = 47;
            this.lblMateriaPrimaName.Text = "Lote MP";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 21);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "Nombre";
            // 
            // frmTrazabilidadHaciaAdelanteByMP_Lot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 579);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblMateriaPrimaName);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.btnClearInfo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmTrazabilidadHaciaAdelanteByMP_Lot";
            this.Text = "Trazabilidad desde Lote MP";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesTRZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLinkBoletaView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnClearInfo;
        private dsReportesTRZ dsReportesTRZ1;
        private DevExpress.XtraGrid.Columns.GridColumn colLotePT;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_pais;
        private DevExpress.XtraGrid.Columns.GridColumn colpais;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion1;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion2;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente_aqua;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colcardname;
        private DevExpress.XtraGrid.Columns.GridColumn colFac_promix;
        private DevExpress.XtraGrid.Columns.GridColumn colNumID;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnLinkBoletaView;
        private DevExpress.XtraEditors.LabelControl lblMateriaPrimaName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_mp;
    }
}