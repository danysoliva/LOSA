
namespace LOSA.TransaccionesMP
{
    partial class frmReporteKardexGeneralVencimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteKardexGeneralVencimiento));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dsTarima = new LOSA.TransaccionesMP.dsTarima();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjustePorLote = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorkerPRD = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerResumenMP = new System.ComponentModel.BackgroundWorker();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_logmovimiento = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_ajuste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonEdit_AjusteINV = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logmovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit_AjusteINV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1252, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 56);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dsTarima
            // 
            this.dsTarima.DataSetName = "dsTarima";
            this.dsTarima.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1132, 6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(114, 56);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnAjustePorLote
            // 
            this.btnAjustePorLote.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAjustePorLote.Appearance.Options.UseFont = true;
            this.btnAjustePorLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAjustePorLote.ImageOptions.Image")));
            this.btnAjustePorLote.Location = new System.Drawing.Point(12, 6);
            this.btnAjustePorLote.Name = "btnAjustePorLote";
            this.btnAjustePorLote.Size = new System.Drawing.Size(185, 56);
            this.btnAjustePorLote.TabIndex = 3;
            this.btnAjustePorLote.Text = "Agregar Ajuste";
            this.btnAjustePorLote.Visible = false;
            this.btnAjustePorLote.Click += new System.EventHandler(this.btnAjustePorLote_Click);
            // 
            // backgroundWorkerPRD
            // 
            this.backgroundWorkerPRD.WorkerSupportsCancellation = true;
            this.backgroundWorkerPRD.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPRD_DoWork);
            // 
            // backgroundWorkerResumenMP
            // 
            this.backgroundWorkerResumenMP.WorkerSupportsCancellation = true;
            this.backgroundWorkerResumenMP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerResumenMP_DoWork);
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Resumen por lote";
            this.tabNavigationPage1.Controls.Add(this.grd_data);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1362, 646);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "informacion";
            this.grd_data.DataSource = this.dsTarima;
            this.grd_data.Location = new System.Drawing.Point(0, 0);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_logmovimiento,
            this.buttonEdit_AjusteINV});
            this.grd_data.Size = new System.Drawing.Size(1362, 646);
            this.grd_data.TabIndex = 0;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data,
            this.gridView5});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colexistencia,
            this.colnombre_comercial,
            this.colfecha_vence,
            this.colfecha_produccion,
            this.colid_mp,
            this.collote,
            this.coldias,
            this.colfecha_ingreso,
            this.colnumero_transaccion,
            this.colcproveedor,
            this.colproveedor,
            this.colcodigo1,
            this.colingreso,
            this.colsalidas,
            this.colcode_sap1,
            this.colLog,
            this.col_ajuste});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_data_RowStyle);
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia", "{0:0.##.##} Kg.")});
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 10;
            this.colexistencia.Width = 87;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Materia Prima";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            this.colnombre_comercial.Width = 172;
            // 
            // colfecha_vence
            // 
            this.colfecha_vence.Caption = "F. Vencimiento";
            this.colfecha_vence.FieldName = "fecha_vence";
            this.colfecha_vence.Name = "colfecha_vence";
            this.colfecha_vence.OptionsColumn.AllowEdit = false;
            this.colfecha_vence.Visible = true;
            this.colfecha_vence.VisibleIndex = 8;
            this.colfecha_vence.Width = 98;
            // 
            // colfecha_produccion
            // 
            this.colfecha_produccion.Caption = "F. Produccion";
            this.colfecha_produccion.FieldName = "fecha_produccion";
            this.colfecha_produccion.Name = "colfecha_produccion";
            this.colfecha_produccion.OptionsColumn.AllowEdit = false;
            this.colfecha_produccion.Visible = true;
            this.colfecha_produccion.VisibleIndex = 7;
            this.colfecha_produccion.Width = 98;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.AllowEdit = false;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 4;
            this.collote.Width = 98;
            // 
            // coldias
            // 
            this.coldias.Caption = "Días";
            this.coldias.FieldName = "dias";
            this.coldias.Name = "coldias";
            this.coldias.OptionsColumn.AllowEdit = false;
            this.coldias.Visible = true;
            this.coldias.VisibleIndex = 9;
            this.coldias.Width = 56;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "F Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 3;
            this.colfecha_ingreso.Width = 79;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "N Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 2;
            this.colnumero_transaccion.Width = 84;
            // 
            // colcproveedor
            // 
            this.colcproveedor.FieldName = "cproveedor";
            this.colcproveedor.Name = "colcproveedor";
            this.colcproveedor.OptionsColumn.AllowEdit = false;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 6;
            this.colproveedor.Width = 146;
            // 
            // colcodigo1
            // 
            this.colcodigo1.Caption = "Codigo";
            this.colcodigo1.FieldName = "codigo";
            this.colcodigo1.Name = "colcodigo1";
            this.colcodigo1.OptionsColumn.AllowEdit = false;
            this.colcodigo1.Visible = true;
            this.colcodigo1.VisibleIndex = 5;
            this.colcodigo1.Width = 54;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Entrada";
            this.colingreso.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colingreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.OptionsColumn.AllowEdit = false;
            this.colingreso.Width = 95;
            // 
            // colsalidas
            // 
            this.colsalidas.Caption = "Salida";
            this.colsalidas.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colsalidas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsalidas.FieldName = "salidas";
            this.colsalidas.Name = "colsalidas";
            this.colsalidas.OptionsColumn.AllowEdit = false;
            this.colsalidas.Width = 80;
            // 
            // colcode_sap1
            // 
            this.colcode_sap1.Caption = "Codigo SAP";
            this.colcode_sap1.FieldName = "code_sap";
            this.colcode_sap1.Name = "colcode_sap1";
            this.colcode_sap1.OptionsColumn.AllowEdit = false;
            this.colcode_sap1.Visible = true;
            this.colcode_sap1.VisibleIndex = 0;
            this.colcode_sap1.Width = 54;
            // 
            // colLog
            // 
            this.colLog.Caption = "Log de movimiento";
            this.colLog.ColumnEdit = this.btn_logmovimiento;
            this.colLog.Name = "colLog";
            this.colLog.Width = 73;
            // 
            // btn_logmovimiento
            // 
            this.btn_logmovimiento.AutoHeight = false;
            editorButtonImageOptions3.Image = global::LOSA.Properties.Resources.log_file24px;
            this.btn_logmovimiento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_logmovimiento.Name = "btn_logmovimiento";
            this.btn_logmovimiento.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_logmovimiento.Click += new System.EventHandler(this.btn_logmovimiento_Click);
            // 
            // col_ajuste
            // 
            this.col_ajuste.Caption = "Ajuste";
            this.col_ajuste.ColumnEdit = this.buttonEdit_AjusteINV;
            this.col_ajuste.Name = "col_ajuste";
            this.col_ajuste.Width = 70;
            // 
            // buttonEdit_AjusteINV
            // 
            this.buttonEdit_AjusteINV.AutoHeight = false;
            editorButtonImageOptions4.Image = global::LOSA.Properties.Resources.edit24px;
            this.buttonEdit_AjusteINV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit_AjusteINV.Name = "buttonEdit_AjusteINV";
            this.buttonEdit_AjusteINV.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.buttonEdit_AjusteINV.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit_AjusteINV_ButtonClick);
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.grd_data;
            this.gridView5.Name = "gridView5";
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPane1.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabPane1.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(4, 68);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(1362, 680);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1362, 680);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(523, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Próximos a Vencer";
            // 
            // frmReporteKardexGeneralVencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 758);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAjustePorLote);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReporteKardexGeneralVencimiento";
            this.Text = "Reporte de Proximos a Vencer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dsTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logmovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit_AjusteINV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsTarima dsTarima;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnAjustePorLote;
        public System.ComponentModel.BackgroundWorker backgroundWorkerPRD;
        public System.ComponentModel.BackgroundWorker backgroundWorkerResumenMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vence;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn coldias;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colsalidas;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap1;
        private DevExpress.XtraGrid.Columns.GridColumn colLog;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_logmovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn col_ajuste;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonEdit_AjusteINV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}