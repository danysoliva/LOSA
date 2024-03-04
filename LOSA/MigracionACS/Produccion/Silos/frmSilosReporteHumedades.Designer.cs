namespace LOSA.MigracionACS.Produccion.Silos
{
    partial class frmSilosReporteHumedades
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSilosReporteHumedades));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsTemperatura1 = new LOSA.MigracionACS.Produccion.TemperaturaMaquinas.dsTemperatura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_acs_turno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhorario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_turno_horario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_i = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_f = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhumedad_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhumedad_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemperatura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "turnos";
            this.gridControl1.DataSource = this.dsTemperatura1;
            this.gridControl1.Location = new System.Drawing.Point(2, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPrint});
            this.gridControl1.Size = new System.Drawing.Size(1232, 220);
            this.gridControl1.TabIndex = 42;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsTemperatura1
            // 
            this.dsTemperatura1.DataSetName = "dsTemperatura";
            this.dsTemperatura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colPrint});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colid_acs_turno
            // 
            this.colid_acs_turno.FieldName = "id_acs_turno";
            this.colid_acs_turno.Name = "colid_acs_turno";
            this.colid_acs_turno.OptionsColumn.AllowEdit = false;
            this.colid_acs_turno.OptionsColumn.ReadOnly = true;
            // 
            // colorder_id
            // 
            this.colorder_id.FieldName = "order_id";
            this.colorder_id.Name = "colorder_id";
            this.colorder_id.OptionsColumn.AllowEdit = false;
            this.colorder_id.OptionsColumn.ReadOnly = true;
            // 
            // colorder_code
            // 
            this.colorder_code.Caption = "Orden Producción";
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.OptionsColumn.AllowEdit = false;
            this.colorder_code.OptionsColumn.ReadOnly = true;
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 0;
            // 
            // colLote
            // 
            this.colLote.FieldName = "Lote";
            this.colLote.Name = "colLote";
            this.colLote.OptionsColumn.AllowEdit = false;
            this.colLote.OptionsColumn.ReadOnly = true;
            this.colLote.Visible = true;
            this.colLote.VisibleIndex = 1;
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.OptionsColumn.AllowEdit = false;
            this.colturno.OptionsColumn.ReadOnly = true;
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 3;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colhorario
            // 
            this.colhorario.Caption = "Horario";
            this.colhorario.FieldName = "horario";
            this.colhorario.Name = "colhorario";
            this.colhorario.OptionsColumn.AllowEdit = false;
            this.colhorario.OptionsColumn.ReadOnly = true;
            this.colhorario.Visible = true;
            this.colhorario.VisibleIndex = 4;
            // 
            // colid_turno_horario
            // 
            this.colid_turno_horario.FieldName = "id_turno_horario";
            this.colid_turno_horario.Name = "colid_turno_horario";
            this.colid_turno_horario.OptionsColumn.AllowEdit = false;
            this.colid_turno_horario.OptionsColumn.ReadOnly = true;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "Imprimir";
            this.colPrint.ColumnEdit = this.cmdPrint;
            this.colPrint.Name = "colPrint";
            this.colPrint.OptionsColumn.AllowEdit = false;
            this.colPrint.OptionsColumn.ReadOnly = true;
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 5;
            // 
            // cmdPrint
            // 
            this.cmdPrint.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Fecha Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(125, 29);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(208, 20);
            this.dtHasta.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fecha Desde:";
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(125, 3);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(208, 20);
            this.dtDesde.TabIndex = 38;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFiltrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Appearance.Options.UseBackColor = true;
            this.btnFiltrar.Appearance.Options.UseFont = true;
            this.btnFiltrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnFiltrar.Location = new System.Drawing.Point(339, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(115, 48);
            this.btnFiltrar.TabIndex = 37;
            this.btnFiltrar.Text = "Cargar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(488, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Reporte de Pellet #2";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "detalle_silos";
            this.gridControl2.DataSource = this.dsTemperatura1;
            this.gridControl2.Location = new System.Drawing.Point(2, 291);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1232, 389);
            this.gridControl2.TabIndex = 44;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_equipo,
            this.collong_name,
            this.coltm_i,
            this.coltm_f,
            this.coldif,
            this.colhumedad_1,
            this.colhumedad_2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colid_equipo
            // 
            this.colid_equipo.FieldName = "id_equipo";
            this.colid_equipo.Name = "colid_equipo";
            // 
            // collong_name
            // 
            this.collong_name.FieldName = "long_name";
            this.collong_name.Name = "collong_name";
            this.collong_name.Visible = true;
            this.collong_name.VisibleIndex = 0;
            // 
            // coltm_i
            // 
            this.coltm_i.DisplayFormat.FormatString = "n2";
            this.coltm_i.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltm_i.FieldName = "tm_i";
            this.coltm_i.Name = "coltm_i";
            this.coltm_i.Visible = true;
            this.coltm_i.VisibleIndex = 1;
            // 
            // coltm_f
            // 
            this.coltm_f.DisplayFormat.FormatString = "n2";
            this.coltm_f.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltm_f.FieldName = "tm_f";
            this.coltm_f.Name = "coltm_f";
            this.coltm_f.Visible = true;
            this.coltm_f.VisibleIndex = 2;
            // 
            // coldif
            // 
            this.coldif.DisplayFormat.FormatString = "n2";
            this.coldif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldif.FieldName = "dif";
            this.coldif.Name = "coldif";
            this.coldif.Visible = true;
            this.coldif.VisibleIndex = 3;
            // 
            // colhumedad_1
            // 
            this.colhumedad_1.DisplayFormat.FormatString = "n2";
            this.colhumedad_1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhumedad_1.FieldName = "humedad_1";
            this.colhumedad_1.Name = "colhumedad_1";
            this.colhumedad_1.Visible = true;
            this.colhumedad_1.VisibleIndex = 4;
            // 
            // colhumedad_2
            // 
            this.colhumedad_2.DisplayFormat.FormatString = "n2";
            this.colhumedad_2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colhumedad_2.FieldName = "humedad_2";
            this.colhumedad_2.Name = "colhumedad_2";
            this.colhumedad_2.Visible = true;
            this.colhumedad_2.VisibleIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px1;
            this.simpleButton1.Location = new System.Drawing.Point(946, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 48);
            this.simpleButton1.TabIndex = 45;
            this.simpleButton1.Text = "Exportar a Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(1093, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(141, 48);
            this.simpleButton2.TabIndex = 46;
            this.simpleButton2.Text = "Cerrar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmSilosReporteHumedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 681);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "frmSilosReporteHumedades";
            this.Text = "Reporte Silos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemperatura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPrint;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private System.Windows.Forms.Label label7;
        private TemperaturaMaquinas.dsTemperatura dsTemperatura1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_equipo;
        private DevExpress.XtraGrid.Columns.GridColumn collong_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_i;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_f;
        private DevExpress.XtraGrid.Columns.GridColumn coldif;
        private DevExpress.XtraGrid.Columns.GridColumn colhumedad_1;
        private DevExpress.XtraGrid.Columns.GridColumn colhumedad_2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}