
namespace LOSA.MigracionACS.Produccion.ForecastPRD
{
    partial class frmFCT_produccion
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFCT_produccion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dsFCT_PRD1 = new LOSA.MigracionACS.Produccion.ForecastPRD.dsFCT_PRD();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodesap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodeodoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxAnio = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroupEspecie = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCumplimientoTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsFCT_PRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupEspecie.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dsFCT_PRD1
            // 
            this.dsFCT_PRD1.DataSetName = "dsFCT_PRD";
            this.dsFCT_PRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "fct_prd";
            this.gridControl1.DataSource = this.dsFCT_PRD1;
            this.gridControl1.Location = new System.Drawing.Point(1, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDelete});
            this.gridControl1.Size = new System.Drawing.Size(796, 501);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodesap,
            this.colcodeodoo,
            this.colname,
            this.colidpt,
            this.coltm,
            this.colprod,
            this.colpercent,
            this.colDelete});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowCsvFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowTxtFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.PlainText;
            this.gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colcodesap
            // 
            this.colcodesap.Caption = "Item Code";
            this.colcodesap.FieldName = "codesap";
            this.colcodesap.Name = "colcodesap";
            this.colcodesap.Visible = true;
            this.colcodesap.VisibleIndex = 0;
            this.colcodesap.Width = 68;
            // 
            // colcodeodoo
            // 
            this.colcodeodoo.Caption = "Code";
            this.colcodeodoo.FieldName = "codeodoo";
            this.colcodeodoo.Name = "colcodeodoo";
            this.colcodeodoo.Visible = true;
            this.colcodeodoo.VisibleIndex = 1;
            this.colcodeodoo.Width = 91;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 228;
            // 
            // colidpt
            // 
            this.colidpt.FieldName = "idpt";
            this.colidpt.Name = "colidpt";
            // 
            // coltm
            // 
            this.coltm.Caption = "Planeado TM";
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tm", "SUM={0:n2}")});
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 3;
            this.coltm.Width = 76;
            // 
            // colprod
            // 
            this.colprod.Caption = "Producido TM";
            this.colprod.DisplayFormat.FormatString = "n2";
            this.colprod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprod.FieldName = "prod";
            this.colprod.Name = "colprod";
            this.colprod.OptionsColumn.AllowEdit = false;
            this.colprod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "prod", "SUM={0:n2}")});
            this.colprod.Visible = true;
            this.colprod.VisibleIndex = 4;
            // 
            // colpercent
            // 
            this.colpercent.Caption = "Cumplimiento %";
            this.colpercent.DisplayFormat.FormatString = "n1";
            this.colpercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpercent.FieldName = "percent";
            this.colpercent.Name = "colpercent";
            this.colpercent.OptionsColumn.AllowEdit = false;
            this.colpercent.Visible = true;
            this.colpercent.VisibleIndex = 5;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.ColumnEdit = this.cmdDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 6;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDelete_ButtonClick);
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplicar.ImageOptions.Image")));
            this.cmdAplicar.Location = new System.Drawing.Point(1, 22);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(114, 49);
            this.cmdAplicar.TabIndex = 3;
            this.cmdAplicar.Text = "Agregar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(542, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Año";
            // 
            // comboBoxAnio
            // 
            this.comboBoxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnio.FormattingEnabled = true;
            this.comboBoxAnio.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.comboBoxAnio.Location = new System.Drawing.Point(542, 50);
            this.comboBoxAnio.Name = "comboBoxAnio";
            this.comboBoxAnio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnio.TabIndex = 10;
            this.comboBoxAnio.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(387, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Mes";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBoxMes.Location = new System.Drawing.Point(387, 50);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMes.TabIndex = 8;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.Location = new System.Drawing.Point(683, 22);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(114, 49);
            this.cmdCargar.TabIndex = 7;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // radioGroupEspecie
            // 
            this.radioGroupEspecie.EditValue = 1;
            this.radioGroupEspecie.Location = new System.Drawing.Point(246, 3);
            this.radioGroupEspecie.Name = "radioGroupEspecie";
            this.radioGroupEspecie.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupEspecie.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupEspecie.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroupEspecie.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tilapia"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Camarón"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Todos")});
            this.radioGroupEspecie.Size = new System.Drawing.Size(126, 68);
            this.radioGroupEspecie.TabIndex = 12;
            this.radioGroupEspecie.SelectedIndexChanged += new System.EventHandler(this.radioGroupEspecie_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Location = new System.Drawing.Point(13, 554);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Porcentaje Total Cumplimiento:";
            // 
            // lblCumplimientoTotal
            // 
            this.lblCumplimientoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCumplimientoTotal.Location = new System.Drawing.Point(168, 555);
            this.lblCumplimientoTotal.Name = "lblCumplimientoTotal";
            this.lblCumplimientoTotal.Size = new System.Drawing.Size(27, 13);
            this.lblCumplimientoTotal.TabIndex = 14;
            this.lblCumplimientoTotal.Text = "0.0%";
            // 
            // frmFCT_produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 580);
            this.Controls.Add(this.lblCumplimientoTotal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.radioGroupEspecie);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboBoxAnio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmFCT_produccion";
            this.Text = "FCT Producción";
            ((System.ComponentModel.ISupportInitialize)(this.dsFCT_PRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupEspecie.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsFCT_PRD dsFCT_PRD1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodesap;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeodoo;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colidpt;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox comboBoxAnio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private DevExpress.XtraGrid.Columns.GridColumn colprod;
        private DevExpress.XtraGrid.Columns.GridColumn colpercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDelete;
        private DevExpress.XtraEditors.RadioGroup radioGroupEspecie;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCumplimientoTotal;
    }
}