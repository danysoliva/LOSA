namespace LOSA.RecuentoInventario
{
    partial class frmRecuentoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuentoInventario));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsRecuento = new LOSA.RecuentoInventario.dsRecuento();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colELote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesoTM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloteagrupador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingresoagrupador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasParaVencer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbMateriaPrima = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.tggOperacion = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.materiaprimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(437, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
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
            this.labelControl3.Location = new System.Drawing.Point(132, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(372, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Recuento de inventario";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "tarimas";
            this.grd_data.DataSource = this.dsRecuento;
            this.grd_data.Location = new System.Drawing.Point(-1, 174);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(638, 386);
            this.grd_data.TabIndex = 33;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsRecuento
            // 
            this.dsRecuento.DataSetName = "dsRecuento";
            this.dsRecuento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colingreso,
            this.collote_materia_prima,
            this.colitemcode1,
            this.colmaterial,
            this.colcantidad,
            this.coldescripcion,
            this.colfactor,
            this.colpeso,
            this.colEIngreso,
            this.colELote,
            this.coleliminar,
            this.colpesoTM2,
            this.colloteagrupador,
            this.colingresoagrupador,
            this.colCantidadSave,
            this.colcodigo,
            this.colFechaIngreso,
            this.colDiasParaVencer});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupCount = 2;
            this.grdv_data.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", this.colcantidad, "(Cantidad Total ={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", this.colpesoTM2, "(Peso ={0:0.##.##} Kg.)")});
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grdv_data.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colingresoagrupador, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colloteagrupador, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colingreso
            // 
            this.colingreso.Caption = "Ingreso";
            this.colingreso.FieldName = "ingreso";
            this.colingreso.Name = "colingreso";
            this.colingreso.Visible = true;
            this.colingreso.VisibleIndex = 2;
            this.colingreso.Width = 68;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 3;
            this.collote_materia_prima.Width = 68;
            // 
            // colitemcode1
            // 
            this.colitemcode1.FieldName = "itemcode";
            this.colitemcode1.Name = "colitemcode1";
            this.colitemcode1.OptionsColumn.AllowEdit = false;
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "MP";
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.OptionsColumn.AllowEdit = false;
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 4;
            this.colmaterial.Width = 68;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 68;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Peso Saco";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 5;
            this.coldescripcion.Width = 68;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            // 
            // colpeso
            // 
            this.colpeso.Caption = "PesoTM";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.UnboundExpression = "[cantidad] * [factor]";
            // 
            // colEIngreso
            // 
            this.colEIngreso.Caption = "Ingreso";
            this.colEIngreso.FieldName = "EIngreso";
            this.colEIngreso.Name = "colEIngreso";
            this.colEIngreso.Visible = true;
            this.colEIngreso.VisibleIndex = 9;
            this.colEIngreso.Width = 60;
            // 
            // colELote
            // 
            this.colELote.Caption = "Lote";
            this.colELote.FieldName = "ELote";
            this.colELote.Name = "colELote";
            this.colELote.Visible = true;
            this.colELote.VisibleIndex = 10;
            this.colELote.Width = 60;
            // 
            // coleliminar
            // 
            this.coleliminar.Caption = "Operar";
            this.coleliminar.FieldName = "eliminar";
            this.coleliminar.Name = "coleliminar";
            this.coleliminar.Visible = true;
            this.coleliminar.VisibleIndex = 11;
            this.coleliminar.Width = 68;
            // 
            // colpesoTM2
            // 
            this.colpesoTM2.Caption = "PesoTm";
            this.colpesoTM2.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colpesoTM2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpesoTM2.FieldName = "colpesoTM2";
            this.colpesoTM2.Name = "colpesoTM2";
            this.colpesoTM2.OptionsColumn.AllowEdit = false;
            this.colpesoTM2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colpesoTM2", "SUM={0:0.##.##} Kg.")});
            this.colpesoTM2.UnboundExpression = "[cantidad] * [factor]";
            this.colpesoTM2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colpesoTM2.Visible = true;
            this.colpesoTM2.VisibleIndex = 7;
            this.colpesoTM2.Width = 92;
            // 
            // colloteagrupador
            // 
            this.colloteagrupador.Caption = "Lote";
            this.colloteagrupador.FieldName = "lote_agrupador";
            this.colloteagrupador.Name = "colloteagrupador";
            this.colloteagrupador.OptionsColumn.AllowEdit = false;
            this.colloteagrupador.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lote_agrupador", "SUM={0:0.##}")});
            this.colloteagrupador.Visible = true;
            this.colloteagrupador.VisibleIndex = 8;
            // 
            // colingresoagrupador
            // 
            this.colingresoagrupador.Caption = "Ingreso";
            this.colingresoagrupador.FieldName = "ingreso_agrupador";
            this.colingresoagrupador.Name = "colingresoagrupador";
            this.colingresoagrupador.OptionsColumn.AllowEdit = false;
            this.colingresoagrupador.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ingreso_agrupador", "SUM={0:0.##}")});
            this.colingresoagrupador.Visible = true;
            this.colingresoagrupador.VisibleIndex = 9;
            // 
            // colCantidadSave
            // 
            this.colCantidadSave.Caption = "gridColumn1";
            this.colCantidadSave.FieldName = "CantidadSave";
            this.colCantidadSave.Name = "colCantidadSave";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.OptionsColumn.AllowEdit = false;
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 1;
            // 
            // colDiasParaVencer
            // 
            this.colDiasParaVencer.FieldName = "DiasParaVencer";
            this.colDiasParaVencer.Name = "colDiasParaVencer";
            this.colDiasParaVencer.OptionsColumn.AllowEdit = false;
            this.colDiasParaVencer.Visible = true;
            this.colDiasParaVencer.VisibleIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 137);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 25);
            this.labelControl2.TabIndex = 96;
            this.labelControl2.Text = "Materia Prima:";
            // 
            // cbMateriaPrima
            // 
            this.cbMateriaPrima.Location = new System.Drawing.Point(141, 136);
            this.cbMateriaPrima.Name = "cbMateriaPrima";
            this.cbMateriaPrima.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbMateriaPrima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriaPrima.Properties.Appearance.Options.UseFont = true;
            this.cbMateriaPrima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMateriaPrima.Properties.DataSource = this.materiaprimaBindingSource;
            this.cbMateriaPrima.Properties.DisplayMember = "itemdescrip";
            this.cbMateriaPrima.Properties.NullText = "";
            this.cbMateriaPrima.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbMateriaPrima.Properties.PopupFormSize = new System.Drawing.Size(400, 0);
            this.cbMateriaPrima.Properties.PopupView = this.gvMateriaPrima;
            this.cbMateriaPrima.Properties.ValueMember = "itemcode";
            this.cbMateriaPrima.Size = new System.Drawing.Size(314, 32);
            this.cbMateriaPrima.TabIndex = 95;
            this.cbMateriaPrima.EditValueChanged += new System.EventHandler(this.cbMateriaPrima_EditValueChanged);
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.Row.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.colitemdescrip});
            this.gvMateriaPrima.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMateriaPrima.OptionsView.ShowAutoFilterRow = true;
            this.gvMateriaPrima.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Item Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.Caption = "Materia Prima";
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 0;
            // 
            // btnguardar
            // 
            this.btnguardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnguardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Appearance.Options.UseBackColor = true;
            this.btnguardar.Appearance.Options.UseFont = true;
            this.btnguardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnguardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.ImageOptions.Image")));
            this.btnguardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnguardar.Location = new System.Drawing.Point(6, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(199, 73);
            this.btnguardar.TabIndex = 97;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tggOperacion
            // 
            this.tggOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggOperacion.Location = new System.Drawing.Point(313, 82);
            this.tggOperacion.Name = "tggOperacion";
            this.tggOperacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.tggOperacion.Properties.Appearance.Options.UseFont = true;
            this.tggOperacion.Properties.OffText = "Salida de inventario";
            this.tggOperacion.Properties.OnText = "Reingreso de Inventario";
            this.tggOperacion.Size = new System.Drawing.Size(302, 36);
            this.tggOperacion.TabIndex = 98;
            this.tggOperacion.Toggled += new System.EventHandler(this.tggOperacion_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(210, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 25);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Operacion:";
            // 
            // materiaprimaBindingSource
            // 
            this.materiaprimaBindingSource.DataMember = "materia_prima";
            this.materiaprimaBindingSource.DataSource = this.dsRecuento;
            // 
            // frmRecuentoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tggOperacion);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbMateriaPrima);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuentoInventario";
            this.Text = "frmRecuentoInventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cbMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemdescrip;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colEIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colELote;
        private DevExpress.XtraGrid.Columns.GridColumn coleliminar;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraGrid.Columns.GridColumn colpesoTM2;
        private DevExpress.XtraGrid.Columns.GridColumn colloteagrupador;
        private DevExpress.XtraGrid.Columns.GridColumn colingresoagrupador;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadSave;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraEditors.ToggleSwitch tggOperacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsRecuento dsRecuento;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasParaVencer;
        private System.Windows.Forms.BindingSource materiaprimaBindingSource;
    }
}