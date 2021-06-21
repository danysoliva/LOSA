namespace LOSA.AlmacenesExterno
{
    partial class xfrmRevisarOC
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmRevisarOC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            this.btnOC = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gcIngreso = new DevExpress.XtraGrid.GridControl();
            this.revisionOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlmacenesExternos = new LOSA.AlmacenesExterno.dsAlmacenesExternos();
            this.gvIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_sacos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantIngresar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtCantIngresar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtComment = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Appearance.Options.UseBackColor = true;
            this.btn.Appearance.Options.UseFont = true;
            this.btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn.Location = new System.Drawing.Point(895, 69);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(180, 58);
            this.btn.TabIndex = 31;
            this.btn.Text = "Conf. Lotes";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOC
            // 
            this.btnOC.Location = new System.Drawing.Point(173, 79);
            this.btnOC.Name = "btnOC";
            this.btnOC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOC.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnOC.Properties.ReadOnly = true;
            this.btnOC.Size = new System.Drawing.Size(316, 46);
            this.btnOC.TabIndex = 32;
            this.btnOC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnOC_ButtonClick);
            this.btnOC.EditValueChanged += new System.EventHandler(this.btnOC_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Orden Compra:";
            // 
            // gcIngreso
            // 
            this.gcIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcIngreso.DataSource = this.revisionOCBindingSource;
            this.gcIngreso.Location = new System.Drawing.Point(1, 281);
            this.gcIngreso.MainView = this.gvIngreso;
            this.gcIngreso.Name = "gcIngreso";
            this.gcIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtCantIngresar,
            this.ceSeleccionar});
            this.gcIngreso.Size = new System.Drawing.Size(1302, 414);
            this.gcIngreso.TabIndex = 34;
            this.gcIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngreso});
            // 
            // revisionOCBindingSource
            // 
            this.revisionOCBindingSource.DataMember = "RevisionOC";
            this.revisionOCBindingSource.DataSource = this.dsAlmacenesExternos;
            // 
            // dsAlmacenesExternos
            // 
            this.dsAlmacenesExternos.DataSetName = "dsAlmacenesExternos";
            this.dsAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvIngreso
            // 
            this.gvIngreso.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvIngreso.Appearance.FocusedRow.Options.UseFont = true;
            this.gvIngreso.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngreso.Appearance.FooterPanel.Options.UseFont = true;
            this.gvIngreso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngreso.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvIngreso.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvIngreso.Appearance.Row.Options.UseFont = true;
            this.gvIngreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colDescription,
            this.colkg,
            this.colU_sacos,
            this.colCantIngresar,
            this.colUnidades,
            this.colNumLine,
            this.colIDMP,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colSelect});
            this.gvIngreso.GridControl = this.gcIngreso;
            this.gvIngreso.Name = "gvIngreso";
            this.gvIngreso.OptionsView.ShowAutoFilterRow = true;
            this.gvIngreso.OptionsView.ShowFooter = true;
            this.gvIngreso.OptionsView.ShowGroupPanel = false;
            this.gvIngreso.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvIngreso_CellValueChanged);
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.MaxWidth = 144;
            this.colItemCode.MinWidth = 25;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.OptionsFilter.AllowFilter = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 144;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Descripción";
            this.colDescription.FieldName = "Dscription";
            this.colDescription.MaxWidth = 500;
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 400;
            // 
            // colkg
            // 
            this.colkg.Caption = "KG (OC)";
            this.colkg.DisplayFormat.FormatString = "{0:N2}";
            this.colkg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg.FieldName = "kg";
            this.colkg.MinWidth = 25;
            this.colkg.Name = "colkg";
            this.colkg.OptionsColumn.AllowEdit = false;
            this.colkg.OptionsFilter.AllowFilter = false;
            this.colkg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kg", "Total ={0:0.##}")});
            this.colkg.Visible = true;
            this.colkg.VisibleIndex = 2;
            this.colkg.Width = 161;
            // 
            // colU_sacos
            // 
            this.colU_sacos.FieldName = "U_sacos";
            this.colU_sacos.MinWidth = 25;
            this.colU_sacos.Name = "colU_sacos";
            this.colU_sacos.OptionsColumn.AllowEdit = false;
            this.colU_sacos.OptionsFilter.AllowFilter = false;
            this.colU_sacos.Width = 93;
            // 
            // colCantIngresar
            // 
            this.colCantIngresar.AppearanceCell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colCantIngresar.AppearanceCell.Options.UseBackColor = true;
            this.colCantIngresar.Caption = "Cantidad a Ingresar";
            this.colCantIngresar.DisplayFormat.FormatString = "{0:N2}";
            this.colCantIngresar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantIngresar.FieldName = "CantidadIngresar";
            this.colCantIngresar.MinWidth = 25;
            this.colCantIngresar.Name = "colCantIngresar";
            this.colCantIngresar.OptionsFilter.AllowFilter = false;
            this.colCantIngresar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CantidadIngresar", "Total ={0:0.##}")});
            this.colCantIngresar.Visible = true;
            this.colCantIngresar.VisibleIndex = 4;
            this.colCantIngresar.Width = 173;
            // 
            // colUnidades
            // 
            this.colUnidades.AppearanceCell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colUnidades.AppearanceCell.Options.UseBackColor = true;
            this.colUnidades.Caption = "Unidades";
            this.colUnidades.DisplayFormat.FormatString = "{0:N2}";
            this.colUnidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnidades.FieldName = "UnidadesIngresar";
            this.colUnidades.MinWidth = 25;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.OptionsFilter.AllowFilter = false;
            this.colUnidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnidadesIngresar", "Total ={0:0.##}")});
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 5;
            this.colUnidades.Width = 155;
            // 
            // colNumLine
            // 
            this.colNumLine.Caption = "Num Linea OC";
            this.colNumLine.FieldName = "LineNum";
            this.colNumLine.MinWidth = 25;
            this.colNumLine.Name = "colNumLine";
            this.colNumLine.OptionsFilter.AllowFilter = false;
            this.colNumLine.Width = 94;
            // 
            // colIDMP
            // 
            this.colIDMP.Caption = "ID MP";
            this.colIDMP.FieldName = "id_mp";
            this.colIDMP.MinWidth = 25;
            this.colIDMP.Name = "colIDMP";
            this.colIDMP.OptionsFilter.AllowFilter = false;
            this.colIDMP.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Peso (Acumulado de Ingresos)";
            this.gridColumn1.DisplayFormat.FormatString = "{0:N2}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "peso_acumulativo";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 249;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "unidades_acumulativas";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 69;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "diferencia";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 69;
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Seleccionar";
            this.colSelect.FieldName = "seleccionar";
            this.colSelect.MinWidth = 25;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 6;
            this.colSelect.Width = 126;
            // 
            // ceSeleccionar
            // 
            this.ceSeleccionar.AutoHeight = false;
            this.ceSeleccionar.Name = "ceSeleccionar";
            this.ceSeleccionar.CheckedChanged += new System.EventHandler(this.ceSeleccionar_CheckedChanged);
            // 
            // txtCantIngresar
            // 
            this.txtCantIngresar.AutoHeight = false;
            this.txtCantIngresar.Name = "txtCantIngresar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1302, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Revisión de Orden de Compra";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(204, 172);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Properties.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(285, 28);
            this.txtProveedor.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Proveedor:_______";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Fecha Documento:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(204, 208);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDate.Properties.Mask.EditMask = "g";
            this.txtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(285, 28);
            this.txtDate.TabIndex = 38;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(873, 160);
            this.txtComment.Name = "txtComment";
            this.txtComment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtComment.Properties.Appearance.Options.UseFont = true;
            this.txtComment.Properties.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(401, 96);
            this.txtComment.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(750, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Comentario:_______";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1096, 69);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 42;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmRevisarOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 694);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOC);
            this.Controls.Add(this.btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmRevisarOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmSeleccionarOC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn;
        private DevExpress.XtraEditors.ButtonEdit btnOC;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngreso;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.MemoEdit txtComment;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource revisionOCBindingSource;
        private dsAlmacenesExternos dsAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colkg;
        private DevExpress.XtraGrid.Columns.GridColumn colU_sacos;
        private DevExpress.XtraGrid.Columns.GridColumn colCantIngresar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantIngresar;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLine;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
    }
}