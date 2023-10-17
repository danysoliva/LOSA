namespace LOSA.MigracionACS.Produccion.MedicionElectrica
{
    partial class frmMedicionElectricaKWH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicionElectricaKWH));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label9 = new System.Windows.Forms.Label();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMedicionElectrica1 = new LOSA.MigracionACS.Produccion.MedicionElectrica.dsMedicionElectrica();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_acs_turno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_turno_horario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrintReport = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_sub_maquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubMaquinaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_maquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaquinaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKwh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicionElectrica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(115, 51);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(208, 20);
            this.dtHasta.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Reporte de KWH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha Desde:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(115, 25);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(208, 20);
            this.dtDesde.TabIndex = 33;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFiltrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Appearance.Options.UseBackColor = true;
            this.btnFiltrar.Appearance.Options.UseFont = true;
            this.btnFiltrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFiltrar.Location = new System.Drawing.Point(329, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 48);
            this.btnFiltrar.TabIndex = 32;
            this.btnFiltrar.Text = "Cargar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "turnos";
            this.gridControl1.DataSource = this.dsMedicionElectrica1;
            this.gridControl1.Location = new System.Drawing.Point(1, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPrintReport});
            this.gridControl1.Size = new System.Drawing.Size(988, 163);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMedicionElectrica1
            // 
            this.dsMedicionElectrica1.DataSetName = "dsMedicionElectrica";
            this.dsMedicionElectrica1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_acs_turno,
            this.colorder_id,
            this.colorder_code,
            this.colLote,
            this.colturno,
            this.colfecha,
            this.colhorario,
            this.colid_turno_horario,
            this.cmdPrint});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colid_acs_turno
            // 
            this.colid_acs_turno.FieldName = "id_acs_turno";
            this.colid_acs_turno.Name = "colid_acs_turno";
            this.colid_acs_turno.OptionsColumn.AllowEdit = false;
            // 
            // colorder_id
            // 
            this.colorder_id.FieldName = "order_id";
            this.colorder_id.Name = "colorder_id";
            this.colorder_id.OptionsColumn.AllowEdit = false;
            // 
            // colorder_code
            // 
            this.colorder_code.Caption = "Orden Producción";
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.OptionsColumn.AllowEdit = false;
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 0;
            this.colorder_code.Width = 182;
            // 
            // colLote
            // 
            this.colLote.FieldName = "Lote";
            this.colLote.Name = "colLote";
            this.colLote.OptionsColumn.AllowEdit = false;
            this.colLote.Visible = true;
            this.colLote.VisibleIndex = 1;
            this.colLote.Width = 182;
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.OptionsColumn.AllowEdit = false;
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 3;
            this.colturno.Width = 182;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 182;
            // 
            // colhorario
            // 
            this.colhorario.Caption = "Horario";
            this.colhorario.FieldName = "horario";
            this.colhorario.Name = "colhorario";
            this.colhorario.OptionsColumn.AllowEdit = false;
            this.colhorario.Visible = true;
            this.colhorario.VisibleIndex = 4;
            this.colhorario.Width = 257;
            // 
            // colid_turno_horario
            // 
            this.colid_turno_horario.FieldName = "id_turno_horario";
            this.colid_turno_horario.Name = "colid_turno_horario";
            this.colid_turno_horario.OptionsColumn.AllowEdit = false;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Caption = "Imprimir";
            this.cmdPrint.ColumnEdit = this.cmdPrintReport;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Visible = true;
            this.cmdPrint.VisibleIndex = 5;
            this.cmdPrint.Width = 112;
            // 
            // cmdPrintReport
            // 
            this.cmdPrintReport.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdPrintReport.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrintReport.Name = "cmdPrintReport";
            this.cmdPrintReport.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "detalle_consumos_kwh";
            this.gridControl2.DataSource = this.dsMedicionElectrica1;
            this.gridControl2.Location = new System.Drawing.Point(2, 247);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(988, 283);
            this.gridControl2.TabIndex = 39;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_sub_maquina,
            this.colSubMaquinaName,
            this.colid_maquina,
            this.colMaquinaName,
            this.colPLC,
            this.colKwh});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colid_sub_maquina
            // 
            this.colid_sub_maquina.FieldName = "id_sub_maquina";
            this.colid_sub_maquina.Name = "colid_sub_maquina";
            // 
            // colSubMaquinaName
            // 
            this.colSubMaquinaName.FieldName = "SubMaquinaName";
            this.colSubMaquinaName.Name = "colSubMaquinaName";
            this.colSubMaquinaName.OptionsColumn.ReadOnly = true;
            this.colSubMaquinaName.Visible = true;
            this.colSubMaquinaName.VisibleIndex = 1;
            // 
            // colid_maquina
            // 
            this.colid_maquina.FieldName = "id_maquina";
            this.colid_maquina.Name = "colid_maquina";
            // 
            // colMaquinaName
            // 
            this.colMaquinaName.FieldName = "MaquinaName";
            this.colMaquinaName.Name = "colMaquinaName";
            this.colMaquinaName.OptionsColumn.ReadOnly = true;
            this.colMaquinaName.Visible = true;
            this.colMaquinaName.VisibleIndex = 0;
            // 
            // colPLC
            // 
            this.colPLC.FieldName = "PLC";
            this.colPLC.Name = "colPLC";
            this.colPLC.OptionsColumn.ReadOnly = true;
            this.colPLC.Visible = true;
            this.colPLC.VisibleIndex = 2;
            // 
            // colKwh
            // 
            this.colKwh.DisplayFormat.FormatString = "n2";
            this.colKwh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKwh.FieldName = "Kwh";
            this.colKwh.Name = "colKwh";
            this.colKwh.OptionsColumn.ReadOnly = true;
            this.colKwh.Visible = true;
            this.colKwh.VisibleIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.simpleButton1.Location = new System.Drawing.Point(865, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(124, 48);
            this.simpleButton1.TabIndex = 40;
            this.simpleButton1.Text = "Exportar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmMedicionElectricaKWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 531);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "frmMedicionElectricaKWH";
            this.Text = "Medicion Electrica KWH";
            this.Load += new System.EventHandler(this.frmMedicionElectricaKWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicionElectrica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_acs_turno;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_id;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_code;
        private DevExpress.XtraGrid.Columns.GridColumn colLote;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colhorario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_turno_horario;
        private DevExpress.XtraGrid.Columns.GridColumn cmdPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPrintReport;
        private dsMedicionElectrica dsMedicionElectrica1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_sub_maquina;
        private DevExpress.XtraGrid.Columns.GridColumn colSubMaquinaName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_maquina;
        private DevExpress.XtraGrid.Columns.GridColumn colMaquinaName;
        private DevExpress.XtraGrid.Columns.GridColumn colPLC;
        private DevExpress.XtraGrid.Columns.GridColumn colKwh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}