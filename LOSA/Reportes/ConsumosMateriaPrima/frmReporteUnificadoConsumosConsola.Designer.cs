namespace LOSA.Reportes.ConsumosMateriaPrima
{
    partial class frmReporteUnificadoConsumosConsola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteUnificadoConsumosConsola));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDatosReportesConsumosMP1 = new LOSA.Reportes.ConsumosMateriaPrima.dsDatosReportesConsumosMP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrow_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrw_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnc_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaplicado_en_mezcla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaplicado_en_couter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaplicado_teorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_consumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.cmdActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.tggIncluirNucleos = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosReportesConsumosMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggIncluirNucleos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Resumen_unificado_consumoMP";
            this.gridControl1.DataSource = this.dsDatosReportesConsumosMP1;
            this.gridControl1.Location = new System.Drawing.Point(1, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(994, 419);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsDatosReportesConsumosMP1
            // 
            this.dsDatosReportesConsumosMP1.DataSetName = "dsDatosReportesConsumosMP";
            this.dsDatosReportesConsumosMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrow_num,
            this.colmaterial_type,
            this.colcode_sap,
            this.colrw_id,
            this.colnc_id,
            this.colmaterial_name,
            this.colaplicado_en_mezcla,
            this.colaplicado_en_couter,
            this.colaplicado_teorico,
            this.coltotal_consumo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colrow_num
            // 
            this.colrow_num.FieldName = "row_num";
            this.colrow_num.Name = "colrow_num";
            this.colrow_num.OptionsColumn.ReadOnly = true;
            this.colrow_num.Visible = true;
            this.colrow_num.VisibleIndex = 0;
            this.colrow_num.Width = 47;
            // 
            // colmaterial_type
            // 
            this.colmaterial_type.FieldName = "material_type";
            this.colmaterial_type.Name = "colmaterial_type";
            this.colmaterial_type.OptionsColumn.ReadOnly = true;
            this.colmaterial_type.Visible = true;
            this.colmaterial_type.VisibleIndex = 1;
            this.colmaterial_type.Width = 52;
            // 
            // colcode_sap
            // 
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.ReadOnly = true;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 2;
            this.colcode_sap.Width = 73;
            // 
            // colrw_id
            // 
            this.colrw_id.FieldName = "rw_id";
            this.colrw_id.Name = "colrw_id";
            this.colrw_id.OptionsColumn.ReadOnly = true;
            // 
            // colnc_id
            // 
            this.colnc_id.FieldName = "nc_id";
            this.colnc_id.Name = "colnc_id";
            this.colnc_id.OptionsColumn.ReadOnly = true;
            // 
            // colmaterial_name
            // 
            this.colmaterial_name.FieldName = "material_name";
            this.colmaterial_name.Name = "colmaterial_name";
            this.colmaterial_name.OptionsColumn.ReadOnly = true;
            this.colmaterial_name.Visible = true;
            this.colmaterial_name.VisibleIndex = 3;
            this.colmaterial_name.Width = 183;
            // 
            // colaplicado_en_mezcla
            // 
            this.colaplicado_en_mezcla.DisplayFormat.FormatString = "n2";
            this.colaplicado_en_mezcla.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colaplicado_en_mezcla.FieldName = "aplicado_en_mezcla";
            this.colaplicado_en_mezcla.Name = "colaplicado_en_mezcla";
            this.colaplicado_en_mezcla.OptionsColumn.ReadOnly = true;
            this.colaplicado_en_mezcla.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "aplicado_en_mezcla", "SUM={0:#,###,##0.00}")});
            this.colaplicado_en_mezcla.Visible = true;
            this.colaplicado_en_mezcla.VisibleIndex = 4;
            this.colaplicado_en_mezcla.Width = 102;
            // 
            // colaplicado_en_couter
            // 
            this.colaplicado_en_couter.DisplayFormat.FormatString = "n2";
            this.colaplicado_en_couter.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colaplicado_en_couter.FieldName = "aplicado_en_couter";
            this.colaplicado_en_couter.Name = "colaplicado_en_couter";
            this.colaplicado_en_couter.OptionsColumn.ReadOnly = true;
            this.colaplicado_en_couter.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "aplicado_en_couter", "SUM={0:#,###,##0.00}")});
            this.colaplicado_en_couter.Visible = true;
            this.colaplicado_en_couter.VisibleIndex = 5;
            this.colaplicado_en_couter.Width = 111;
            // 
            // colaplicado_teorico
            // 
            this.colaplicado_teorico.DisplayFormat.FormatString = "n2";
            this.colaplicado_teorico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colaplicado_teorico.FieldName = "aplicado_teorico";
            this.colaplicado_teorico.Name = "colaplicado_teorico";
            this.colaplicado_teorico.OptionsColumn.ReadOnly = true;
            this.colaplicado_teorico.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "aplicado_teorico", "SUM={0:#,###,##0.00}")});
            this.colaplicado_teorico.Visible = true;
            this.colaplicado_teorico.VisibleIndex = 6;
            this.colaplicado_teorico.Width = 109;
            // 
            // coltotal_consumo
            // 
            this.coltotal_consumo.DisplayFormat.FormatString = "n2";
            this.coltotal_consumo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_consumo.FieldName = "total_consumo";
            this.coltotal_consumo.Name = "coltotal_consumo";
            this.coltotal_consumo.OptionsColumn.ReadOnly = true;
            this.coltotal_consumo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_consumo", "SUM={0:#,###,##0.00}")});
            this.coltotal_consumo.Visible = true;
            this.coltotal_consumo.VisibleIndex = 7;
            this.coltotal_consumo.Width = 106;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(779, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(105, 41);
            this.simpleButton4.TabIndex = 113;
            this.simpleButton4.Text = "Imprimir";
            this.simpleButton4.Visible = false;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.simpleButton5.Location = new System.Drawing.Point(890, 12);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(105, 41);
            this.simpleButton5.TabIndex = 112;
            this.simpleButton5.Text = "Excel";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(59, 31);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(224)))));
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtHasta.Properties.Appearance.Options.UseBackColor = true;
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "g";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(158, 22);
            this.dtHasta.TabIndex = 111;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(59, 2);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(224)))));
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDesde.Properties.Appearance.Options.UseBackColor = true;
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "g";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(158, 22);
            this.dtDesde.TabIndex = 110;
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActualizar.Appearance.Options.UseFont = true;
            this.cmdActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdActualizar.ImageOptions.SvgImage")));
            this.cmdActualizar.Location = new System.Drawing.Point(223, 2);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(110, 51);
            this.cmdActualizar.TabIndex = 109;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(12, 34);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(30, 15);
            this.labelControl14.TabIndex = 108;
            this.labelControl14.Text = "Hasta";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(12, 5);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(32, 15);
            this.labelControl16.TabIndex = 107;
            this.labelControl16.Text = "Desde";
            // 
            // tggIncluirNucleos
            // 
            this.tggIncluirNucleos.Location = new System.Drawing.Point(651, 35);
            this.tggIncluirNucleos.Name = "tggIncluirNucleos";
            this.tggIncluirNucleos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tggIncluirNucleos.Properties.Appearance.Options.UseFont = true;
            this.tggIncluirNucleos.Properties.OffText = "No";
            this.tggIncluirNucleos.Properties.OnText = "Si";
            this.tggIncluirNucleos.Size = new System.Drawing.Size(95, 22);
            this.tggIncluirNucleos.TabIndex = 114;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(560, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 17);
            this.labelControl1.TabIndex = 115;
            this.labelControl1.Text = "Incluir Núcleos";
            // 
            // frmReporteUnificadoConsumosConsola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 480);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tggIncluirNucleos);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReporteUnificadoConsumosConsola";
            this.Text = "Reporte Unificado Consumos Consola";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosReportesConsumosMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggIncluirNucleos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsDatosReportesConsumosMP dsDatosReportesConsumosMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial_type;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colrw_id;
        private DevExpress.XtraGrid.Columns.GridColumn colnc_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial_name;
        private DevExpress.XtraGrid.Columns.GridColumn colaplicado_en_mezcla;
        private DevExpress.XtraGrid.Columns.GridColumn colaplicado_en_couter;
        private DevExpress.XtraGrid.Columns.GridColumn colaplicado_teorico;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_consumo;
        private DevExpress.XtraGrid.Columns.GridColumn colrow_num;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton cmdActualizar;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.ToggleSwitch tggIncluirNucleos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}