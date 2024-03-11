namespace LOSA.MigracionACS.SAR
{
    partial class SAR_DASHBOARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_DASHBOARD));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnactualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnexportar = new DevExpress.XtraBars.BarButtonItem();
            this.btngenerar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnfiltros = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtfin = new DevExpress.XtraEditors.DateEdit();
            this.dtini = new DevExpress.XtraEditors.DateEdit();
            this.pnmain = new DevExpress.XtraEditors.PanelControl();
            this.grd_report = new DevExpress.XtraGrid.GridControl();
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_report = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgCapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnfiltros)).BeginInit();
            this.pnfiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).BeginInit();
            this.pnmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.btnactualizar,
            this.btngenerar,
            this.btnexportar,
            this.btnPDF});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCerrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btngenerar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnactualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexportar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPDF)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Id = 0;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Caption = "Actualizar Informacion";
            this.btnactualizar.Id = 1;
            this.btnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.ImageOptions.Image")));
            this.btnactualizar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnactualizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnactualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnactualizar_ItemClick);
            // 
            // btnexportar
            // 
            this.btnexportar.Caption = "Exportar a excel";
            this.btnexportar.Id = 3;
            this.btnexportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.ImageOptions.Image")));
            this.btnexportar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnexportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexportar_ItemClick);
            // 
            // btngenerar
            // 
            this.btngenerar.Caption = "Generar Reporte";
            this.btngenerar.Id = 2;
            this.btngenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngenerar.ImageOptions.Image")));
            this.btngenerar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ItemAppearance.Normal.Options.UseFont = true;
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btngenerar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngenerar_ItemClick);
            // 
            // btnPDF
            // 
            this.btnPDF.Caption = "Exportar a PDF";
            this.btnPDF.Id = 4;
            this.btnPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.ImageOptions.Image")));
            this.btnPDF.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPDF_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1226, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 555);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1226, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1226, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // pnfiltros
            // 
            this.pnfiltros.Controls.Add(this.labelControl2);
            this.pnfiltros.Controls.Add(this.labelControl1);
            this.pnfiltros.Controls.Add(this.dtfin);
            this.pnfiltros.Controls.Add(this.dtini);
            this.pnfiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnfiltros.Location = new System.Drawing.Point(0, 40);
            this.pnfiltros.Margin = new System.Windows.Forms.Padding(2);
            this.pnfiltros.Name = "pnfiltros";
            this.pnfiltros.Size = new System.Drawing.Size(1226, 81);
            this.pnfiltros.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(44, 27);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Fecha inicial: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(566, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha final:";
            // 
            // dtfin
            // 
            this.dtfin.EditValue = null;
            this.dtfin.Location = new System.Drawing.Point(695, 24);
            this.dtfin.Margin = new System.Windows.Forms.Padding(2);
            this.dtfin.MenuManager = this.barManager1;
            this.dtfin.Name = "dtfin";
            this.dtfin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfin.Properties.Appearance.Options.UseFont = true;
            this.dtfin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Size = new System.Drawing.Size(305, 28);
            this.dtfin.TabIndex = 1;
            // 
            // dtini
            // 
            this.dtini.EditValue = null;
            this.dtini.Location = new System.Drawing.Point(175, 24);
            this.dtini.Margin = new System.Windows.Forms.Padding(2);
            this.dtini.MenuManager = this.barManager1;
            this.dtini.Name = "dtini";
            this.dtini.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtini.Properties.Appearance.Options.UseFont = true;
            this.dtini.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtini.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtini.Size = new System.Drawing.Size(305, 28);
            this.dtini.TabIndex = 0;
            // 
            // pnmain
            // 
            this.pnmain.Controls.Add(this.grd_report);
            this.pnmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmain.Location = new System.Drawing.Point(0, 121);
            this.pnmain.Margin = new System.Windows.Forms.Padding(2);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(1226, 434);
            this.pnmain.TabIndex = 5;
            // 
            // grd_report
            // 
            this.grd_report.DataMember = "rubro_capitulo";
            this.grd_report.DataSource = this.dS_SAR;
            this.grd_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_report.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_report.Location = new System.Drawing.Point(2, 2);
            this.grd_report.MainView = this.grdv_report;
            this.grd_report.Margin = new System.Windows.Forms.Padding(2);
            this.grd_report.MenuManager = this.barManager1;
            this.grd_report.Name = "grd_report";
            this.grd_report.Size = new System.Drawing.Size(1222, 430);
            this.grd_report.TabIndex = 0;
            this.grd_report.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_report});
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_report
            // 
            this.grdv_report.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_report.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_report.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_report.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_report.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_report.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_report.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_report.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_report.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_report.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_report.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_report.Appearance.Row.Options.UseFont = true;
            this.grdv_report.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRubro,
            this.colDesRubro,
            this.colCapitulo,
            this.colDesCapitulo,
            this.colPresupuesto,
            this.colConsumo,
            this.colDiferencia,
            this.colAgCapitulo});
            this.grdv_report.GridControl = this.grd_report;
            this.grdv_report.GroupCount = 1;
            this.grdv_report.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Presupuesto", this.colPresupuesto, "(Presupuesto: {0:0.##.##} L.)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Consumo", this.colConsumo, "(Consumo: {0:0.##.##} L.)")});
            this.grdv_report.Name = "grdv_report";
            this.grdv_report.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_report.OptionsBehavior.Editable = false;
            this.grdv_report.OptionsView.ShowAutoFilterRow = true;
            this.grdv_report.OptionsView.ShowFooter = true;
            this.grdv_report.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAgCapitulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colRubro
            // 
            this.colRubro.FieldName = "Rubro";
            this.colRubro.Name = "colRubro";
            this.colRubro.Visible = true;
            this.colRubro.VisibleIndex = 0;
            this.colRubro.Width = 96;
            // 
            // colDesRubro
            // 
            this.colDesRubro.Caption = "Rubro";
            this.colDesRubro.FieldName = "DesRubro";
            this.colDesRubro.Name = "colDesRubro";
            this.colDesRubro.Visible = true;
            this.colDesRubro.VisibleIndex = 1;
            this.colDesRubro.Width = 313;
            // 
            // colCapitulo
            // 
            this.colCapitulo.FieldName = "Capitulo";
            this.colCapitulo.Name = "colCapitulo";
            this.colCapitulo.Width = 94;
            // 
            // colDesCapitulo
            // 
            this.colDesCapitulo.Caption = "Capitulo";
            this.colDesCapitulo.FieldName = "DesCapitulo";
            this.colDesCapitulo.Name = "colDesCapitulo";
            this.colDesCapitulo.Width = 275;
            // 
            // colPresupuesto
            // 
            this.colPresupuesto.FieldName = "Presupuesto";
            this.colPresupuesto.Name = "colPresupuesto";
            this.colPresupuesto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Presupuesto", "Total={0:0.##.##} L.")});
            this.colPresupuesto.Visible = true;
            this.colPresupuesto.VisibleIndex = 2;
            this.colPresupuesto.Width = 150;
            // 
            // colConsumo
            // 
            this.colConsumo.FieldName = "Consumo";
            this.colConsumo.Name = "colConsumo";
            this.colConsumo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Consumo", "Total={0:0.##.##} L.")});
            this.colConsumo.Visible = true;
            this.colConsumo.VisibleIndex = 3;
            this.colConsumo.Width = 122;
            // 
            // colDiferencia
            // 
            this.colDiferencia.FieldName = "Diferencia";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.Visible = true;
            this.colDiferencia.VisibleIndex = 4;
            this.colDiferencia.Width = 154;
            // 
            // colAgCapitulo
            // 
            this.colAgCapitulo.Caption = "Capitulo";
            this.colAgCapitulo.FieldName = "AgCapitulo";
            this.colAgCapitulo.Name = "colAgCapitulo";
            this.colAgCapitulo.Visible = true;
            this.colAgCapitulo.VisibleIndex = 7;
            // 
            // SAR_DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 578);
            this.Controls.Add(this.pnmain);
            this.Controls.Add(this.pnfiltros);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SAR_DASHBOARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAR_DASHBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnfiltros)).EndInit();
            this.pnfiltros.ResumeLayout(false);
            this.pnfiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).EndInit();
            this.pnmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarButtonItem btnactualizar;
        private DevExpress.XtraBars.BarButtonItem btnexportar;
        private DevExpress.XtraBars.BarButtonItem btngenerar;
        private DevExpress.XtraEditors.PanelControl pnmain;
        private DevExpress.XtraGrid.GridControl grd_report;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_report;
        private DevExpress.XtraEditors.PanelControl pnfiltros;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtfin;
        private DevExpress.XtraEditors.DateEdit dtini;
        private dS_SAR dS_SAR;
        private DevExpress.XtraGrid.Columns.GridColumn colRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colDesRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colCapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumo;
        private DevExpress.XtraGrid.Columns.GridColumn colDiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colAgCapitulo;
        private DevExpress.XtraBars.BarButtonItem btnPDF;
    }
}