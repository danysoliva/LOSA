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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicionElectricaKWH));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.colkg_producidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_sub_maquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubMaquinaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_maquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaquinaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKwh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lblTmProducidas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKgProducidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje_kg1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_sub_maquinas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubMaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_maquina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collectura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timerInstantaneos = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(3, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPrintReport});
            this.gridControl1.Size = new System.Drawing.Size(978, 163);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.cmdPrint,
            this.colkg_producidos});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
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
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdPrintReport.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrintReport.Name = "cmdPrintReport";
            this.cmdPrintReport.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colkg_producidos
            // 
            this.colkg_producidos.DisplayFormat.FormatString = "n2";
            this.colkg_producidos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg_producidos.FieldName = "kg_producidos";
            this.colkg_producidos.Name = "colkg_producidos";
            this.colkg_producidos.OptionsColumn.AllowEdit = false;
            this.colkg_producidos.Visible = true;
            this.colkg_producidos.VisibleIndex = 6;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "detalle_consumos_kwh";
            this.gridControl2.DataSource = this.dsMedicionElectrica1;
            this.gridControl2.Location = new System.Drawing.Point(3, 174);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(978, 250);
            this.gridControl2.TabIndex = 39;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_sub_maquina,
            this.colSubMaquinaName,
            this.colid_maquina,
            this.colMaquinaName,
            this.colPLC,
            this.colKwh,
            this.colPorcentaje,
            this.colPorcentaje_kg});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            this.gridView2.Click += new System.EventHandler(this.gridView2_Click);
            // 
            // colid_sub_maquina
            // 
            this.colid_sub_maquina.FieldName = "id_sub_maquina";
            this.colid_sub_maquina.Name = "colid_sub_maquina";
            this.colid_sub_maquina.OptionsColumn.AllowEdit = false;
            // 
            // colSubMaquinaName
            // 
            this.colSubMaquinaName.FieldName = "SubMaquinaName";
            this.colSubMaquinaName.Name = "colSubMaquinaName";
            this.colSubMaquinaName.OptionsColumn.AllowEdit = false;
            this.colSubMaquinaName.OptionsColumn.ReadOnly = true;
            this.colSubMaquinaName.Visible = true;
            this.colSubMaquinaName.VisibleIndex = 1;
            // 
            // colid_maquina
            // 
            this.colid_maquina.FieldName = "id_maquina";
            this.colid_maquina.Name = "colid_maquina";
            this.colid_maquina.OptionsColumn.AllowEdit = false;
            // 
            // colMaquinaName
            // 
            this.colMaquinaName.FieldName = "MaquinaName";
            this.colMaquinaName.Name = "colMaquinaName";
            this.colMaquinaName.OptionsColumn.AllowEdit = false;
            this.colMaquinaName.OptionsColumn.ReadOnly = true;
            this.colMaquinaName.Visible = true;
            this.colMaquinaName.VisibleIndex = 0;
            // 
            // colPLC
            // 
            this.colPLC.FieldName = "PLC";
            this.colPLC.Name = "colPLC";
            this.colPLC.OptionsColumn.AllowEdit = false;
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
            this.colKwh.OptionsColumn.AllowEdit = false;
            this.colKwh.OptionsColumn.ReadOnly = true;
            this.colKwh.Visible = true;
            this.colKwh.VisibleIndex = 3;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.DisplayFormat.FormatString = "n1";
            this.colPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorcentaje.FieldName = "Porcentaje";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.OptionsColumn.AllowEdit = false;
            this.colPorcentaje.Visible = true;
            this.colPorcentaje.VisibleIndex = 4;
            // 
            // colPorcentaje_kg
            // 
            this.colPorcentaje_kg.DisplayFormat.FormatString = "n2";
            this.colPorcentaje_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorcentaje_kg.FieldName = "Porcentaje_kg";
            this.colPorcentaje_kg.Name = "colPorcentaje_kg";
            this.colPorcentaje_kg.OptionsColumn.AllowEdit = false;
            this.colPorcentaje_kg.Visible = true;
            this.colPorcentaje_kg.VisibleIndex = 5;
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 78);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(986, 452);
            this.xtraTabControl1.TabIndex = 41;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.gridControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(984, 427);
            this.xtraTabPage1.Text = "Resumen por Turno";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.lblTmProducidas);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.lblKgProducidos);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.gridControl3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(984, 427);
            this.xtraTabPage2.Text = "Resumen Acumulado";
            // 
            // lblTmProducidas
            // 
            this.lblTmProducidas.AutoSize = true;
            this.lblTmProducidas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmProducidas.Location = new System.Drawing.Point(127, 30);
            this.lblTmProducidas.Name = "lblTmProducidas";
            this.lblTmProducidas.Size = new System.Drawing.Size(66, 20);
            this.lblTmProducidas.TabIndex = 44;
            this.lblTmProducidas.Text = "0.00 Tm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tm Producidas: ";
            // 
            // lblKgProducidos
            // 
            this.lblKgProducidos.AutoSize = true;
            this.lblKgProducidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgProducidos.Location = new System.Drawing.Point(127, 10);
            this.lblKgProducidos.Name = "lblKgProducidos";
            this.lblKgProducidos.Size = new System.Drawing.Size(63, 20);
            this.lblKgProducidos.TabIndex = 42;
            this.lblKgProducidos.Text = "0.00 Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kg Producidos: ";
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "detalle_consumos_kwhAcumulado";
            this.gridControl3.DataSource = this.dsMedicionElectrica1;
            this.gridControl3.Location = new System.Drawing.Point(3, 58);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(978, 366);
            this.gridControl3.TabIndex = 40;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControl3.Click += new System.EventHandler(this.gridControl3_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colPorcentaje1,
            this.colPorcentaje_kg1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.Click += new System.EventHandler(this.gridView3_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id_sub_maquina";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "SubMaquinaName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id_maquina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "MaquinaName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "PLC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.DisplayFormat.FormatString = "n2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Kwh";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // colPorcentaje1
            // 
            this.colPorcentaje1.DisplayFormat.FormatString = "n1";
            this.colPorcentaje1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorcentaje1.FieldName = "Porcentaje";
            this.colPorcentaje1.Name = "colPorcentaje1";
            this.colPorcentaje1.OptionsColumn.AllowEdit = false;
            this.colPorcentaje1.Visible = true;
            this.colPorcentaje1.VisibleIndex = 4;
            // 
            // colPorcentaje_kg1
            // 
            this.colPorcentaje_kg1.DisplayFormat.FormatString = "n2";
            this.colPorcentaje_kg1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPorcentaje_kg1.FieldName = "Porcentaje_kg";
            this.colPorcentaje_kg1.Name = "colPorcentaje_kg1";
            this.colPorcentaje_kg1.OptionsColumn.AllowEdit = false;
            this.colPorcentaje_kg1.Visible = true;
            this.colPorcentaje_kg1.VisibleIndex = 5;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(984, 427);
            this.xtraTabPage3.Text = "Lectura en vivo";
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.DataMember = "instanteos_lectura";
            this.gridControl4.DataSource = this.dsMedicionElectrica1;
            this.gridControl4.Location = new System.Drawing.Point(3, 3);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(978, 424);
            this.gridControl4.TabIndex = 0;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_sub_maquinas,
            this.colSubMaquina,
            this.colid_maquina1,
            this.colMaquina,
            this.collectura,
            this.collast_update,
            this.colPLC1});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView4_RowClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_sub_maquinas
            // 
            this.colid_sub_maquinas.FieldName = "id_sub_maquinas";
            this.colid_sub_maquinas.Name = "colid_sub_maquinas";
            this.colid_sub_maquinas.OptionsColumn.AllowEdit = false;
            // 
            // colSubMaquina
            // 
            this.colSubMaquina.FieldName = "SubMaquina";
            this.colSubMaquina.Name = "colSubMaquina";
            this.colSubMaquina.OptionsColumn.AllowEdit = false;
            this.colSubMaquina.Visible = true;
            this.colSubMaquina.VisibleIndex = 0;
            // 
            // colid_maquina1
            // 
            this.colid_maquina1.FieldName = "id_maquina";
            this.colid_maquina1.Name = "colid_maquina1";
            this.colid_maquina1.OptionsColumn.AllowEdit = false;
            // 
            // colMaquina
            // 
            this.colMaquina.FieldName = "Maquina";
            this.colMaquina.Name = "colMaquina";
            this.colMaquina.OptionsColumn.AllowEdit = false;
            // 
            // collectura
            // 
            this.collectura.DisplayFormat.FormatString = "n2";
            this.collectura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.collectura.FieldName = "lectura";
            this.collectura.Name = "collectura";
            this.collectura.OptionsColumn.AllowEdit = false;
            this.collectura.Visible = true;
            this.collectura.VisibleIndex = 1;
            // 
            // collast_update
            // 
            this.collast_update.DisplayFormat.FormatString = "g";
            this.collast_update.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.collast_update.FieldName = "last_update";
            this.collast_update.Name = "collast_update";
            this.collast_update.OptionsColumn.AllowEdit = false;
            this.collast_update.Visible = true;
            this.collast_update.VisibleIndex = 2;
            // 
            // colPLC1
            // 
            this.colPLC1.FieldName = "PLC";
            this.colPLC1.Name = "colPLC1";
            this.colPLC1.OptionsColumn.AllowEdit = false;
            this.colPLC1.Visible = true;
            this.colPLC1.VisibleIndex = 3;
            // 
            // timerInstantaneos
            // 
            this.timerInstantaneos.Interval = 600000;
            this.timerInstantaneos.Tick += new System.EventHandler(this.timerInstantaneos_Tick);
            // 
            // frmMedicionElectricaKWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 531);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton1);
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
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
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje1;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_producidos;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje_kg1;
        private System.Windows.Forms.Label lblKgProducidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTmProducidas;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_sub_maquinas;
        private DevExpress.XtraGrid.Columns.GridColumn colSubMaquina;
        private DevExpress.XtraGrid.Columns.GridColumn colid_maquina1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaquina;
        private DevExpress.XtraGrid.Columns.GridColumn collectura;
        private DevExpress.XtraGrid.Columns.GridColumn collast_update;
        private DevExpress.XtraGrid.Columns.GridColumn colPLC1;
        private System.Windows.Forms.Timer timerInstantaneos;
    }
}