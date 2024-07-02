
namespace LOSA.Presupuesto
{
    partial class frmRptSaldosPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptSaldosPresupuestos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdPresipuesto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.presupuestoActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto1 = new LOSA.Presupuesto.dsPresupuesto();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.btnCargarInfo = new DevExpress.XtraEditors.SimpleButton();
            this.grdConsumo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_d_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto_presupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.item = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.xtraTabControl1item = new DevExpress.XtraLayout.TabbedControlGroup();
            this.xtraTabPage2item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.TabConsumoSaldositem = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grdPresipuestoitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.grdConsumoitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCargarInfoitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresipuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout)).BeginInit();
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoVerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabPage2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabConsumoSaldositem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresipuestoitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumoitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarInfoitem)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPresipuesto
            // 
            this.grdPresipuesto.Location = new System.Drawing.Point(100, 47);
            this.grdPresipuesto.Name = "grdPresipuesto";
            this.grdPresipuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdPresipuesto.Properties.Appearance.Options.UseFont = true;
            this.grdPresipuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdPresipuesto.Properties.DataSource = this.presupuestoActivoBindingSource;
            this.grdPresipuesto.Properties.DisplayMember = "descripcion";
            this.grdPresipuesto.Properties.NullText = "";
            this.grdPresipuesto.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdPresipuesto.Properties.ValueMember = "id";
            this.grdPresipuesto.Size = new System.Drawing.Size(392, 26);
            this.grdPresipuesto.StyleController = this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout;
            this.grdPresipuesto.TabIndex = 1;
            // 
            // presupuestoActivoBindingSource
            // 
            this.presupuestoActivoBindingSource.DataMember = "PresupuestoActivo";
            this.presupuestoActivoBindingSource.DataSource = this.dsPresupuesto1;
            // 
            // dsPresupuesto1
            // 
            this.dsPresupuesto1.DataSetName = "dsPresupuesto";
            this.dsPresupuesto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colanio});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colanio
            // 
            this.colanio.Caption = "Año";
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 1;
            // 
            // frmRptSaldosPresupuestoslayoutControl1ConvertedLayout
            // 
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Controls.Add(this.grdPresipuesto);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Controls.Add(this.btnCargarInfo);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Controls.Add(this.grdConsumo);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Controls.Add(this.gridControl2);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Controls.Add(this.btnExport);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.item,
            this.xtraTabPage2item});
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Name = "frmRptSaldosPresupuestoslayoutControl1ConvertedLayout";
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1603, 359, 883, 400);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.Size = new System.Drawing.Size(1461, 822);
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.TabIndex = 1;
            // 
            // btnCargarInfo
            // 
            this.btnCargarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarInfo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarInfo.Appearance.Options.UseFont = true;
            this.btnCargarInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarInfo.ImageOptions.Image")));
            this.btnCargarInfo.Location = new System.Drawing.Point(496, 47);
            this.btnCargarInfo.Name = "btnCargarInfo";
            this.btnCargarInfo.Size = new System.Drawing.Size(468, 36);
            this.btnCargarInfo.StyleController = this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout;
            this.btnCargarInfo.TabIndex = 101;
            this.btnCargarInfo.Text = "Cargar";
            this.btnCargarInfo.Click += new System.EventHandler(this.btnCargarInfo_Click);
            // 
            // grdConsumo
            // 
            this.grdConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsumo.DataMember = "rpt_consumo_saldos";
            this.grdConsumo.DataSource = this.dsPresupuesto1;
            this.grdConsumo.Location = new System.Drawing.Point(24, 87);
            this.grdConsumo.MainView = this.gridView1;
            this.grdConsumo.Name = "grdConsumo";
            this.grdConsumo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoVerDetalle});
            this.grdConsumo.Size = new System.Drawing.Size(1413, 711);
            this.grdConsumo.TabIndex = 0;
            this.grdConsumo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_d_linea,
            this.coldepartamento,
            this.colconcepto_presupuesto,
            this.colmonto_origen,
            this.colexistencia,
            this.colconsumo,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdConsumo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid_d_linea
            // 
            this.colid_d_linea.Caption = "Codigo";
            this.colid_d_linea.FieldName = "id_d_linea";
            this.colid_d_linea.Name = "colid_d_linea";
            this.colid_d_linea.OptionsColumn.AllowEdit = false;
            this.colid_d_linea.Visible = true;
            this.colid_d_linea.VisibleIndex = 0;
            this.colid_d_linea.Width = 64;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 1;
            this.coldepartamento.Width = 210;
            // 
            // colconcepto_presupuesto
            // 
            this.colconcepto_presupuesto.Caption = "Concepto";
            this.colconcepto_presupuesto.FieldName = "concepto_presupuesto";
            this.colconcepto_presupuesto.Name = "colconcepto_presupuesto";
            this.colconcepto_presupuesto.OptionsColumn.AllowEdit = false;
            this.colconcepto_presupuesto.Visible = true;
            this.colconcepto_presupuesto.VisibleIndex = 2;
            this.colconcepto_presupuesto.Width = 313;
            // 
            // colmonto_origen
            // 
            this.colmonto_origen.Caption = "Monto Inicial";
            this.colmonto_origen.DisplayFormat.FormatString = "$ {0:#,###,##0.00}";
            this.colmonto_origen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_origen.FieldName = "monto_origen";
            this.colmonto_origen.Name = "colmonto_origen";
            this.colmonto_origen.OptionsColumn.AllowEdit = false;
            this.colmonto_origen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto_origen", "$ {0:#,###,##0.00}")});
            this.colmonto_origen.Visible = true;
            this.colmonto_origen.VisibleIndex = 3;
            this.colmonto_origen.Width = 208;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia ";
            this.colexistencia.DisplayFormat.FormatString = "$ {0:#,###,##0.00}";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia", "$ {0:#,###,##0.00}")});
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 4;
            this.colexistencia.Width = 208;
            // 
            // colconsumo
            // 
            this.colconsumo.Caption = "Consumido";
            this.colconsumo.DisplayFormat.FormatString = "$ {0:#,###,##0.00}";
            this.colconsumo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colconsumo.FieldName = "consumo";
            this.colconsumo.Name = "colconsumo";
            this.colconsumo.OptionsColumn.AllowEdit = false;
            this.colconsumo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "consumo", "SUM=$ {0:#,###,##0.00}")});
            this.colconsumo.Visible = true;
            this.colconsumo.VisibleIndex = 5;
            this.colconsumo.Width = 208;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Detalle";
            this.gridColumn1.ColumnEdit = this.repoVerDetalle;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 217;
            // 
            // repoVerDetalle
            // 
            this.repoVerDetalle.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repoVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoVerDetalle.Name = "repoVerDetalle";
            this.repoVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoVerDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoVerDetalle_ButtonClick);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(24, 47);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1413, 751);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(968, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(469, 36);
            this.btnExport.StyleController = this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout;
            this.btnExport.TabIndex = 102;
            this.btnExport.Text = "Exportar";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // item
            // 
            this.item.Enabled = false;
            this.item.Location = new System.Drawing.Point(0, 0);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(1441, 24);
            this.item.TextSize = new System.Drawing.Size(0, 0);
            this.item.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.xtraTabControl1item});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1461, 822);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // xtraTabControl1item
            // 
            this.xtraTabControl1item.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1item.Name = "xtraTabControl1item";
            this.xtraTabControl1item.SelectedTabPage = this.TabConsumoSaldositem;
            this.xtraTabControl1item.Size = new System.Drawing.Size(1441, 802);
            this.xtraTabControl1item.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.TabConsumoSaldositem});
            // 
            // xtraTabPage2item
            // 
            this.xtraTabPage2item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.gridControl2item});
            this.xtraTabPage2item.Location = new System.Drawing.Point(0, 0);
            this.xtraTabPage2item.Name = "xtraTabPage2item";
            this.xtraTabPage2item.Size = new System.Drawing.Size(1417, 755);
            this.xtraTabPage2item.Text = "Reporte por Mes";
            // 
            // gridControl2item
            // 
            this.gridControl2item.Control = this.gridControl2;
            this.gridControl2item.Location = new System.Drawing.Point(0, 0);
            this.gridControl2item.Name = "gridControl2item";
            this.gridControl2item.Size = new System.Drawing.Size(1417, 755);
            this.gridControl2item.TextSize = new System.Drawing.Size(0, 0);
            this.gridControl2item.TextVisible = false;
            // 
            // TabConsumoSaldositem
            // 
            this.TabConsumoSaldositem.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.grdPresipuestoitem,
            this.grdConsumoitem,
            this.layoutControlItem1,
            this.btnCargarInfoitem});
            this.TabConsumoSaldositem.Location = new System.Drawing.Point(0, 0);
            this.TabConsumoSaldositem.Name = "TabConsumoSaldositem";
            this.TabConsumoSaldositem.Size = new System.Drawing.Size(1417, 755);
            this.TabConsumoSaldositem.Text = "Presupuesto - Consumo de Saldos";
            // 
            // grdPresipuestoitem
            // 
            this.grdPresipuestoitem.Control = this.grdPresipuesto;
            this.grdPresipuestoitem.Location = new System.Drawing.Point(0, 0);
            this.grdPresipuestoitem.Name = "grdPresipuestoitem";
            this.grdPresipuestoitem.Size = new System.Drawing.Size(472, 40);
            this.grdPresipuestoitem.Text = "Presupuesto:";
            this.grdPresipuestoitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.grdPresipuestoitem.TextSize = new System.Drawing.Size(64, 13);
            // 
            // grdConsumoitem
            // 
            this.grdConsumoitem.Control = this.grdConsumo;
            this.grdConsumoitem.Location = new System.Drawing.Point(0, 40);
            this.grdConsumoitem.Name = "grdConsumoitem";
            this.grdConsumoitem.Size = new System.Drawing.Size(1417, 715);
            this.grdConsumoitem.TextSize = new System.Drawing.Size(0, 0);
            this.grdConsumoitem.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnExport;
            this.layoutControlItem1.Location = new System.Drawing.Point(944, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(473, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnCargarInfoitem
            // 
            this.btnCargarInfoitem.Control = this.btnCargarInfo;
            this.btnCargarInfoitem.Location = new System.Drawing.Point(472, 0);
            this.btnCargarInfoitem.Name = "btnCargarInfoitem";
            this.btnCargarInfoitem.Size = new System.Drawing.Size(472, 40);
            this.btnCargarInfoitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnCargarInfoitem.TextVisible = false;
            // 
            // frmRptSaldosPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 822);
            this.Controls.Add(this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout);
            this.Name = "frmRptSaldosPresupuestos";
            ((System.ComponentModel.ISupportInitialize)(this.grdPresipuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout)).EndInit();
            this.frmRptSaldosPresupuestoslayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoVerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabPage2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabConsumoSaldositem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresipuestoitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumoitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarInfoitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grdConsumo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit grdPresipuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private dsPresupuesto dsPresupuesto1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_d_linea;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto_presupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colconsumo;
        private System.Windows.Forms.BindingSource presupuestoActivoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoVerDetalle;
        private DevExpress.XtraEditors.SimpleButton btnCargarInfo;
        private DevExpress.XtraLayout.LayoutControl frmRptSaldosPresupuestoslayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.TabbedControlGroup xtraTabControl1item;
        private DevExpress.XtraLayout.LayoutControlGroup xtraTabPage2item;
        private DevExpress.XtraLayout.LayoutControlItem gridControl2item;
        private DevExpress.XtraLayout.LayoutControlItem item;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraLayout.LayoutControlGroup TabConsumoSaldositem;
        private DevExpress.XtraLayout.LayoutControlItem grdPresipuestoitem;
        private DevExpress.XtraLayout.LayoutControlItem grdConsumoitem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem btnCargarInfoitem;
    }
}