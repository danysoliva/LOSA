namespace LOSA.RecepcionMP
{
    partial class frmMP_Granel_Selec_Lote
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMP_Granel_Selec_Lote));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpEditLoteEmbedded = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.listalotesgranelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_lote_externo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcard_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSelectLote = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bindingSourceListaLotesActivos = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSiguiente = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditLoteEmbedded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listalotesgranelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSelectLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListaLotesActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "cruce_lote_mp";
            this.gridControl1.DataSource = this.dsRecepcionMPx1;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdSelectLote,
            this.GridLookUpEditLoteEmbedded});
            this.gridControl1.Size = new System.Drawing.Size(580, 269);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.collote,
            this.colcard_name,
            this.colid_lote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Item Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.ColumnEdit = this.GridLookUpEditLoteEmbedded;
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 2;
            // 
            // GridLookUpEditLoteEmbedded
            // 
            this.GridLookUpEditLoteEmbedded.AutoHeight = false;
            this.GridLookUpEditLoteEmbedded.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditLoteEmbedded.DataSource = this.listalotesgranelBindingSource;
            this.GridLookUpEditLoteEmbedded.DisplayMember = "lote";
            this.GridLookUpEditLoteEmbedded.Name = "GridLookUpEditLoteEmbedded";
            this.GridLookUpEditLoteEmbedded.PopupFormSize = new System.Drawing.Size(500, 0);
            this.GridLookUpEditLoteEmbedded.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.GridLookUpEditLoteEmbedded.ValueMember = "id_lote_externo";
            this.GridLookUpEditLoteEmbedded.EditValueChanged += new System.EventHandler(this.GridLookUpEditLoteEmbedded_EditValueChanged);
            // 
            // listalotesgranelBindingSource
            // 
            this.listalotesgranelBindingSource.DataMember = "lista_lotes_granel";
            this.listalotesgranelBindingSource.DataSource = this.dsRecepcionMPx1;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.repositoryItemGridLookUpEdit1View.Appearance.Row.Options.UseBackColor = true;
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_lote_externo,
            this.colitemcode1,
            this.collote1,
            this.colbodega,
            this.colfactura,
            this.colcantidad_existencia});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_lote_externo
            // 
            this.colid_lote_externo.FieldName = "id_lote_externo";
            this.colid_lote_externo.Name = "colid_lote_externo";
            this.colid_lote_externo.OptionsColumn.AllowShowHide = false;
            // 
            // colitemcode1
            // 
            this.colitemcode1.Caption = "ItemCode";
            this.colitemcode1.FieldName = "itemcode";
            this.colitemcode1.Name = "colitemcode1";
            this.colitemcode1.OptionsColumn.AllowEdit = false;
            this.colitemcode1.Visible = true;
            this.colitemcode1.VisibleIndex = 0;
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.OptionsColumn.AllowEdit = false;
            this.collote1.OptionsColumn.AllowShowHide = false;
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 0;
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Bodega";
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.OptionsColumn.AllowEdit = false;
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 4;
            // 
            // colfactura
            // 
            this.colfactura.Caption = "Factura";
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.OptionsColumn.AllowEdit = false;
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 3;
            // 
            // colcantidad_existencia
            // 
            this.colcantidad_existencia.Caption = "Existencia";
            this.colcantidad_existencia.FieldName = "cantidad_existencia";
            this.colcantidad_existencia.Name = "colcantidad_existencia";
            this.colcantidad_existencia.OptionsColumn.AllowEdit = false;
            this.colcantidad_existencia.Visible = true;
            this.colcantidad_existencia.VisibleIndex = 2;
            // 
            // colcard_name
            // 
            this.colcard_name.Caption = "Materia Prima";
            this.colcard_name.FieldName = "card_name";
            this.colcard_name.Name = "colcard_name";
            this.colcard_name.OptionsColumn.AllowEdit = false;
            this.colcard_name.Visible = true;
            this.colcard_name.VisibleIndex = 1;
            // 
            // colid_lote
            // 
            this.colid_lote.FieldName = "id_lote";
            this.colid_lote.Name = "colid_lote";
            // 
            // cmdSelectLote
            // 
            this.cmdSelectLote.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.cmdSelectLote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdSelectLote.Name = "cmdSelectLote";
            this.cmdSelectLote.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdSelectLote_ButtonClick);
            // 
            // bindingSourceListaLotesActivos
            // 
            this.bindingSourceListaLotesActivos.DataMember = "lista_lotes_activos";
            this.bindingSourceListaLotesActivos.DataSource = this.dsRecepcionMPx1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(111, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(328, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Asociación de Lote a Materia Prima";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.Location = new System.Drawing.Point(477, 2);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 43);
            this.simpleButton2.TabIndex = 65;
            this.simpleButton2.Text = "Cerrar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSiguiente.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSiguiente.Appearance.Options.UseFont = true;
            this.cmdSiguiente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSiguiente.ImageOptions.Image")));
            this.cmdSiguiente.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.cmdSiguiente.Location = new System.Drawing.Point(453, 322);
            this.cmdSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(127, 43);
            this.cmdSiguiente.TabIndex = 66;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // frmMP_Granel_Selec_Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 372);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmMP_Granel_Selec_Lote";
            this.Text = "Seleccion de Lote";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditLoteEmbedded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listalotesgranelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSelectLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListaLotesActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsRecepcionMPx dsRecepcionMPx1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton cmdSiguiente;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSelectLote;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditLoteEmbedded;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSourceListaLotesActivos;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colcard_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote;
        private System.Windows.Forms.BindingSource listalotesgranelBindingSource;
        private dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote_externo;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode1;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_existencia;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
    }
}