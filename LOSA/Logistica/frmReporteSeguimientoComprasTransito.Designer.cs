
namespace LOSA.Logistica
{
    partial class frmReporteSeguimientoComprasTransito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteSeguimientoComprasTransito));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_mps = new DevExpress.XtraEditors.GridLookUpEdit();
            this.materiaprimav2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogistica21 = new LOSA.Logistica.dsLogistica2();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsLogistica2 = new LOSA.Logistica.dsLogistica2();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntryLineNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerEntradas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_entradas = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOc = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colLineNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsFiltroxMP = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblFiltroMP = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mps.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimav2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsFiltroxMP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1288, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(97, 50);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Materia Prima:  ";
            // 
            // grd_mps
            // 
            this.grd_mps.Location = new System.Drawing.Point(109, 49);
            this.grd_mps.Name = "grd_mps";
            this.grd_mps.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grd_mps.Properties.Appearance.Options.UseFont = true;
            this.grd_mps.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_mps.Properties.DataSource = this.materiaprimav2BindingSource;
            this.grd_mps.Properties.DisplayMember = "itemdescrip";
            this.grd_mps.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_mps.Properties.ValueMember = "itemcode";
            this.grd_mps.Size = new System.Drawing.Size(548, 26);
            this.grd_mps.TabIndex = 5;
            this.grd_mps.EditValueChanged += new System.EventHandler(this.grd_mps_EditValueChanged);
            // 
            // materiaprimav2BindingSource
            // 
            this.materiaprimav2BindingSource.DataMember = "Materia_prima_v2";
            this.materiaprimav2BindingSource.DataSource = this.dsLogistica21;
            // 
            // dsLogistica21
            // 
            this.dsLogistica21.DataSetName = "dsLogistica2";
            this.dsLogistica21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.colitemdescrip});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 210;
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.Caption = "Descripcion";
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 1;
            this.colitemdescrip.Width = 1412;
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "OrdenesCompraTransito";
            this.grd_data.DataSource = this.dsLogistica2;
            this.grd_data.Location = new System.Drawing.Point(0, 92);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_entradas,
            this.btnOc});
            this.grd_data.Size = new System.Drawing.Size(1389, 595);
            this.grd_data.TabIndex = 6;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsLogistica2
            // 
            this.dsLogistica2.DataSetName = "dsLogistica2";
            this.dsLogistica2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocEntry,
            this.colDocNum,
            this.colProveedor,
            this.colFechaDocumento,
            this.colArticulo,
            this.colCantidad,
            this.colPendiente,
            this.colDocEntryLineNum,
            this.colVerEntradas,
            this.coldetalle,
            this.colLineNum});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.EnableAppearanceOddRow = true;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.OptionsView.ShowViewCaption = true;
            this.grdv_data.ViewCaption = "Compras en Transito ";
            // 
            // colDocEntry
            // 
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "OC";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 184;
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.AllowEdit = false;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            this.colProveedor.Width = 184;
            // 
            // colFechaDocumento
            // 
            this.colFechaDocumento.FieldName = "FechaDocumento";
            this.colFechaDocumento.Name = "colFechaDocumento";
            this.colFechaDocumento.OptionsColumn.AllowEdit = false;
            this.colFechaDocumento.Visible = true;
            this.colFechaDocumento.VisibleIndex = 2;
            this.colFechaDocumento.Width = 184;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.OptionsColumn.AllowEdit = false;
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 3;
            this.colArticulo.Width = 184;
            // 
            // colCantidad
            // 
            this.colCantidad.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "{0:0.##.##} Kg.")});
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            this.colCantidad.Width = 184;
            // 
            // colPendiente
            // 
            this.colPendiente.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPendiente.FieldName = "Pendiente";
            this.colPendiente.Name = "colPendiente";
            this.colPendiente.OptionsColumn.AllowEdit = false;
            this.colPendiente.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pendiente", "{0:0.##.##} Kg.")});
            this.colPendiente.Visible = true;
            this.colPendiente.VisibleIndex = 5;
            this.colPendiente.Width = 211;
            // 
            // colDocEntryLineNum
            // 
            this.colDocEntryLineNum.FieldName = "DocEntryLineNum";
            this.colDocEntryLineNum.Name = "colDocEntryLineNum";
            // 
            // colVerEntradas
            // 
            this.colVerEntradas.Caption = "Ver Entradas";
            this.colVerEntradas.ColumnEdit = this.btn_entradas;
            this.colVerEntradas.Name = "colVerEntradas";
            this.colVerEntradas.Visible = true;
            this.colVerEntradas.VisibleIndex = 6;
            this.colVerEntradas.Width = 119;
            // 
            // btn_entradas
            // 
            this.btn_entradas.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.devoluciones;
            this.btn_entradas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_entradas.Name = "btn_entradas";
            this.btn_entradas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_entradas.Click += new System.EventHandler(this.btn_entradas_Click);
            // 
            // coldetalle
            // 
            this.coldetalle.Caption = "Ver detalle ";
            this.coldetalle.ColumnEdit = this.btnOc;
            this.coldetalle.Name = "coldetalle";
            this.coldetalle.Width = 121;
            // 
            // btnOc
            // 
            this.btnOc.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnOc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnOc.Name = "btnOc";
            this.btnOc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnOc.Click += new System.EventHandler(this.btnOc_Click);
            // 
            // colLineNum
            // 
            this.colLineNum.FieldName = "LineNum";
            this.colLineNum.Name = "colLineNum";
            // 
            // tsFiltroxMP
            // 
            this.tsFiltroxMP.EditValue = true;
            this.tsFiltroxMP.Location = new System.Drawing.Point(180, 7);
            this.tsFiltroxMP.Name = "tsFiltroxMP";
            this.tsFiltroxMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsFiltroxMP.Properties.Appearance.Options.UseFont = true;
            this.tsFiltroxMP.Properties.OffText = "No";
            this.tsFiltroxMP.Properties.OnText = "Si";
            this.tsFiltroxMP.Size = new System.Drawing.Size(121, 30);
            this.tsFiltroxMP.TabIndex = 7;
            this.tsFiltroxMP.Toggled += new System.EventHandler(this.tsFiltroxMP_Toggled);
            // 
            // lblFiltroMP
            // 
            this.lblFiltroMP.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFiltroMP.Appearance.Options.UseFont = true;
            this.lblFiltroMP.Location = new System.Drawing.Point(4, 12);
            this.lblFiltroMP.Name = "lblFiltroMP";
            this.lblFiltroMP.Size = new System.Drawing.Size(170, 20);
            this.lblFiltroMP.TabIndex = 8;
            this.lblFiltroMP.Text = "Filtrar por Materia Prima";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExport.Location = new System.Drawing.Point(1158, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 50);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Exportar";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmReporteSeguimientoComprasTransito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 687);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblFiltroMP);
            this.Controls.Add(this.tsFiltroxMP);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.grd_mps);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmReporteSeguimientoComprasTransito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteSeguimientoComprasTransito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_mps.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimav2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsFiltroxMP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit grd_mps;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private dsLogistica2 dsLogistica2;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntryLineNum;
        private dsLogistica2 dsLogistica21;
        private System.Windows.Forms.BindingSource materiaprimav2BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemdescrip;
        private DevExpress.XtraGrid.Columns.GridColumn colVerEntradas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_entradas;
        private DevExpress.XtraGrid.Columns.GridColumn coldetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOc;
        private DevExpress.XtraGrid.Columns.GridColumn colLineNum;
        private DevExpress.XtraEditors.ToggleSwitch tsFiltroxMP;
        private DevExpress.XtraEditors.LabelControl lblFiltroMP;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}