
namespace LOSA.Compras
{
    partial class frmListaOrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaOrdenesCompra));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabAutorizaciones = new DevExpress.XtraTab.XtraTabPage();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.btnPrintSeleccionados = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grdAutorizadas = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_TipoOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubido_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreadopor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repostPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPendientes = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_h1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_TipoOrden1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubido_sap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreadopor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabHistorica = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabAutorizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAutorizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostPrint)).BeginInit();
            this.TabPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.TabHistorica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabAutorizaciones;
            this.xtraTabControl1.Size = new System.Drawing.Size(1374, 818);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAutorizaciones,
            this.TabPendientes,
            this.TabHistorica});
            // 
            // TabAutorizaciones
            // 
            this.TabAutorizaciones.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabAutorizaciones.Appearance.Header.Options.UseFont = true;
            this.TabAutorizaciones.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabAutorizaciones.Appearance.HeaderActive.Options.UseFont = true;
            this.TabAutorizaciones.Controls.Add(this.checkBoxSelectAll);
            this.TabAutorizaciones.Controls.Add(this.btnPrintSeleccionados);
            this.TabAutorizaciones.Controls.Add(this.cmdRefreshDisponibles);
            this.TabAutorizaciones.Controls.Add(this.dtFechaHastaDisponibles);
            this.TabAutorizaciones.Controls.Add(this.labelControl9);
            this.TabAutorizaciones.Controls.Add(this.dtFechaDesdeDisponibles);
            this.TabAutorizaciones.Controls.Add(this.labelControl8);
            this.TabAutorizaciones.Controls.Add(this.grdAutorizadas);
            this.TabAutorizaciones.Name = "TabAutorizaciones";
            this.TabAutorizaciones.Size = new System.Drawing.Size(1372, 789);
            this.TabAutorizaciones.Text = "OC Autorizadas";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(991, 23);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSelectAll.TabIndex = 105;
            this.checkBoxSelectAll.Text = "Seleccionar Todas";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.Visible = false;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // btnPrintSeleccionados
            // 
            this.btnPrintSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSeleccionados.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintSeleccionados.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPrintSeleccionados.Appearance.Options.UseBackColor = true;
            this.btnPrintSeleccionados.Appearance.Options.UseFont = true;
            this.btnPrintSeleccionados.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrintSeleccionados.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrintSeleccionados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintSeleccionados.ImageOptions.SvgImage")));
            this.btnPrintSeleccionados.Location = new System.Drawing.Point(1109, 5);
            this.btnPrintSeleccionados.Name = "btnPrintSeleccionados";
            this.btnPrintSeleccionados.Size = new System.Drawing.Size(183, 39);
            this.btnPrintSeleccionados.TabIndex = 104;
            this.btnPrintSeleccionados.Text = "Imprimir Seleccionado";
            this.btnPrintSeleccionados.Visible = false;
            this.btnPrintSeleccionados.Click += new System.EventHandler(this.btnPrintSeleccionados_Click);
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(509, 5);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(106, 39);
            this.cmdRefreshDisponibles.TabIndex = 103;
            this.cmdRefreshDisponibles.Text = "Refresh";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(361, 15);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHastaDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaHastaDisponibles.TabIndex = 101;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(275, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 16);
            this.labelControl9.TabIndex = 102;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(114, 15);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesdeDisponibles.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesdeDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(142, 22);
            this.dtFechaDesdeDisponibles.TabIndex = 99;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(23, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 16);
            this.labelControl8.TabIndex = 100;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // grdAutorizadas
            // 
            this.grdAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAutorizadas.DataMember = "ordenes_autorizadas";
            this.grdAutorizadas.DataSource = this.dsCompras1;
            this.grdAutorizadas.Location = new System.Drawing.Point(3, 55);
            this.grdAutorizadas.MainView = this.gridView1;
            this.grdAutorizadas.Name = "grdAutorizadas";
            this.grdAutorizadas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repostPrint});
            this.grdAutorizadas.Size = new System.Drawing.Size(1366, 731);
            this.grdAutorizadas.TabIndex = 0;
            this.grdAutorizadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_h,
            this.colCardCode,
            this.colCardName,
            this.colDocNum,
            this.colDocDate,
            this.colU_TipoOrden,
            this.colComments,
            this.colsubido_sap,
            this.colestado_name,
            this.colid_estado,
            this.colcreadopor,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.grdAutorizadas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            this.colid_h.OptionsColumn.ReadOnly = true;
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.ReadOnly = true;
            this.colCardCode.Visible = true;
            this.colCardCode.VisibleIndex = 0;
            this.colCardCode.Width = 70;
            // 
            // colCardName
            // 
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.ReadOnly = true;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 1;
            this.colCardName.Width = 152;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "Doc Num";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 2;
            this.colDocNum.Width = 57;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "F. Contabilizacion";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.ReadOnly = true;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 3;
            this.colDocDate.Width = 102;
            // 
            // colU_TipoOrden
            // 
            this.colU_TipoOrden.Caption = "Tipo de Orden";
            this.colU_TipoOrden.FieldName = "U_TipoOrden";
            this.colU_TipoOrden.Name = "colU_TipoOrden";
            this.colU_TipoOrden.OptionsColumn.ReadOnly = true;
            this.colU_TipoOrden.Visible = true;
            this.colU_TipoOrden.VisibleIndex = 5;
            this.colU_TipoOrden.Width = 93;
            // 
            // colComments
            // 
            this.colComments.Caption = "Comentario";
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.OptionsColumn.ReadOnly = true;
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 6;
            this.colComments.Width = 309;
            // 
            // colsubido_sap
            // 
            this.colsubido_sap.Caption = "Subido a SAP";
            this.colsubido_sap.FieldName = "subido_sap";
            this.colsubido_sap.Name = "colsubido_sap";
            this.colsubido_sap.OptionsColumn.ReadOnly = true;
            this.colsubido_sap.Visible = true;
            this.colsubido_sap.VisibleIndex = 7;
            this.colsubido_sap.Width = 74;
            // 
            // colestado_name
            // 
            this.colestado_name.Caption = "Estado";
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.OptionsColumn.ReadOnly = true;
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 8;
            this.colestado_name.Width = 89;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colcreadopor
            // 
            this.colcreadopor.Caption = "Creado por:";
            this.colcreadopor.FieldName = "creadopor";
            this.colcreadopor.Name = "colcreadopor";
            this.colcreadopor.OptionsColumn.ReadOnly = true;
            this.colcreadopor.Visible = true;
            this.colcreadopor.VisibleIndex = 9;
            this.colcreadopor.Width = 89;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Moneda";
            this.gridColumn1.FieldName = "moneda";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 60;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "print_count";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Imprimir";
            this.gridColumn3.ColumnEdit = this.repostPrint;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 12;
            this.gridColumn3.Width = 69;
            // 
            // repostPrint
            // 
            this.repostPrint.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repostPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repostPrint.Name = "repostPrint";
            this.repostPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repostPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repostPrint_ButtonClick);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Seleccionar";
            this.gridColumn4.FieldName = "seleccionar";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 116;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Regist. Exonerado";
            this.gridColumn5.FieldName = "U_AquaExoneracion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 106;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Total";
            this.gridColumn6.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "DocTotal";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            this.gridColumn6.Width = 71;
            // 
            // TabPendientes
            // 
            this.TabPendientes.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TabPendientes.Appearance.Header.Options.UseFont = true;
            this.TabPendientes.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabPendientes.Appearance.HeaderActive.Options.UseFont = true;
            this.TabPendientes.Controls.Add(this.gridControl1);
            this.TabPendientes.Name = "TabPendientes";
            this.TabPendientes.PageVisible = false;
            this.TabPendientes.Size = new System.Drawing.Size(1372, 789);
            this.TabPendientes.Text = "OC Pendientes de Aprobacion";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "ordenes_pendientes";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Location = new System.Drawing.Point(3, 53);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1366, 733);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_h1,
            this.colCardCode1,
            this.colCardName1,
            this.colDocNum1,
            this.colDocDate1,
            this.colU_TipoOrden1,
            this.colComments1,
            this.colDocTotal1,
            this.colsubido_sap1,
            this.colestado_name1,
            this.colid_estado1,
            this.colcreadopor1});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // colid_h1
            // 
            this.colid_h1.FieldName = "id_h";
            this.colid_h1.Name = "colid_h1";
            this.colid_h1.Visible = true;
            this.colid_h1.VisibleIndex = 0;
            // 
            // colCardCode1
            // 
            this.colCardCode1.FieldName = "CardCode";
            this.colCardCode1.Name = "colCardCode1";
            this.colCardCode1.Visible = true;
            this.colCardCode1.VisibleIndex = 1;
            // 
            // colCardName1
            // 
            this.colCardName1.FieldName = "CardName";
            this.colCardName1.Name = "colCardName1";
            this.colCardName1.Visible = true;
            this.colCardName1.VisibleIndex = 2;
            // 
            // colDocNum1
            // 
            this.colDocNum1.FieldName = "DocNum";
            this.colDocNum1.Name = "colDocNum1";
            this.colDocNum1.Visible = true;
            this.colDocNum1.VisibleIndex = 3;
            // 
            // colDocDate1
            // 
            this.colDocDate1.FieldName = "DocDate";
            this.colDocDate1.Name = "colDocDate1";
            this.colDocDate1.Visible = true;
            this.colDocDate1.VisibleIndex = 4;
            // 
            // colU_TipoOrden1
            // 
            this.colU_TipoOrden1.FieldName = "U_TipoOrden";
            this.colU_TipoOrden1.Name = "colU_TipoOrden1";
            this.colU_TipoOrden1.Visible = true;
            this.colU_TipoOrden1.VisibleIndex = 5;
            // 
            // colComments1
            // 
            this.colComments1.FieldName = "Comments";
            this.colComments1.Name = "colComments1";
            this.colComments1.Visible = true;
            this.colComments1.VisibleIndex = 6;
            // 
            // colDocTotal1
            // 
            this.colDocTotal1.FieldName = "DocTotal";
            this.colDocTotal1.Name = "colDocTotal1";
            this.colDocTotal1.Visible = true;
            this.colDocTotal1.VisibleIndex = 7;
            // 
            // colsubido_sap1
            // 
            this.colsubido_sap1.FieldName = "subido_sap";
            this.colsubido_sap1.Name = "colsubido_sap1";
            this.colsubido_sap1.Visible = true;
            this.colsubido_sap1.VisibleIndex = 8;
            // 
            // colestado_name1
            // 
            this.colestado_name1.FieldName = "estado_name";
            this.colestado_name1.Name = "colestado_name1";
            this.colestado_name1.Visible = true;
            this.colestado_name1.VisibleIndex = 9;
            // 
            // colid_estado1
            // 
            this.colid_estado1.FieldName = "id_estado";
            this.colid_estado1.Name = "colid_estado1";
            this.colid_estado1.Visible = true;
            this.colid_estado1.VisibleIndex = 10;
            // 
            // colcreadopor1
            // 
            this.colcreadopor1.FieldName = "creadopor";
            this.colcreadopor1.Name = "colcreadopor1";
            this.colcreadopor1.Visible = true;
            this.colcreadopor1.VisibleIndex = 11;
            // 
            // TabHistorica
            // 
            this.TabHistorica.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabHistorica.Appearance.Header.Options.UseFont = true;
            this.TabHistorica.Appearance.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabHistorica.Appearance.HeaderActive.Options.UseFont = true;
            this.TabHistorica.Controls.Add(this.gridControl2);
            this.TabHistorica.Name = "TabHistorica";
            this.TabHistorica.PageVisible = false;
            this.TabHistorica.Size = new System.Drawing.Size(1372, 789);
            this.TabHistorica.Text = "Historial Ordenes de Compra";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(3, 68);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1366, 718);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // frmListaOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 818);
            this.Controls.Add(this.xtraTabControl1);
            this.IsMdiContainer = true;
            this.Name = "frmListaOrdenesCompra";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabAutorizaciones.ResumeLayout(false);
            this.TabAutorizaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAutorizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repostPrint)).EndInit();
            this.TabPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.TabHistorica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabAutorizaciones;
        private DevExpress.XtraGrid.GridControl grdAutorizadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage TabHistorica;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colU_TipoOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colsubido_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcreadopor;
        private DevExpress.XtraTab.XtraTabPage TabPendientes;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h1;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colU_TipoOrden1;
        private DevExpress.XtraGrid.Columns.GridColumn colComments1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colsubido_sap1;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado1;
        private DevExpress.XtraGrid.Columns.GridColumn colcreadopor1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repostPrint;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnPrintSeleccionados;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}