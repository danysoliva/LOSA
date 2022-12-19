namespace LOSA.MigracionACS.SAR
{
    partial class SAR_Saldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_Saldo));
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnnueva = new DevExpress.XtraBars.BarButtonItem();
            this.btnedit = new DevExpress.XtraBars.BarButtonItem();
            this.btnperiodos = new DevExpress.XtraBars.BarButtonItem();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.btnexport = new DevExpress.XtraBars.BarButtonItem();
            this.barcapitulos = new DevExpress.XtraBars.BarButtonItem();
            this.btnrubrocap = new DevExpress.XtraBars.BarButtonItem();
            this.btnactualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btneditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnreporte = new DevExpress.XtraBars.BarButtonItem();
            this.grd_saldos = new DevExpress.XtraGrid.GridControl();
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_saldos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidregistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncambiomonto = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_saldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_saldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncambiomonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndetails)).BeginInit();
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
            this.btneditar,
            this.btnclose,
            this.btnreporte,
            this.btnnueva,
            this.btnedit,
            this.btnperiodos,
            this.btnexport,
            this.barcapitulos,
            this.btnrubrocap,
            this.btnactualizar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnnueva),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnedit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnperiodos),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexport),
            new DevExpress.XtraBars.LinkPersistInfo(this.barcapitulos),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnrubrocap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnactualizar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnnueva
            // 
            this.btnnueva.Caption = "Nueva exoneracion";
            this.btnnueva.Id = 3;
            this.btnnueva.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnueva.ImageOptions.Image")));
            this.btnnueva.Name = "btnnueva";
            this.btnnueva.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnnueva.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnnueva.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnueva_ItemClick);
            // 
            // btnedit
            // 
            this.btnedit.Caption = "Editar exoneracion vigente";
            this.btnedit.Id = 4;
            this.btnedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.Image")));
            this.btnedit.Name = "btnedit";
            this.btnedit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnedit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnedit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnedit_ItemClick);
            // 
            // btnperiodos
            // 
            this.btnperiodos.Caption = "Periodos de Exoneracion";
            this.btnperiodos.Id = 5;
            this.btnperiodos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnperiodos.ImageOptions.Image")));
            this.btnperiodos.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperiodos.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnperiodos.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperiodos.ItemAppearance.Normal.Options.UseFont = true;
            this.btnperiodos.Name = "btnperiodos";
            this.btnperiodos.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnperiodos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 1;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // btnexport
            // 
            this.btnexport.Caption = "Exportar Excel";
            this.btnexport.Id = 6;
            this.btnexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.ImageOptions.Image")));
            this.btnexport.Name = "btnexport";
            this.btnexport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnexport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexport_ItemClick);
            // 
            // barcapitulos
            // 
            this.barcapitulos.Caption = "Capitulos";
            this.barcapitulos.Id = 7;
            this.barcapitulos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barcapitulos.ImageOptions.Image")));
            this.barcapitulos.Name = "barcapitulos";
            this.barcapitulos.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barcapitulos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barcapitulos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barcapitulos_ItemClick);
            // 
            // btnrubrocap
            // 
            this.btnrubrocap.Caption = "Capitulo/Rubro";
            this.btnrubrocap.Id = 8;
            this.btnrubrocap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrubrocap.ImageOptions.Image")));
            this.btnrubrocap.Name = "btnrubrocap";
            this.btnrubrocap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnrubrocap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrubrocap_ItemClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Caption = "Actualizar";
            this.btnactualizar.Id = 9;
            this.btnactualizar.ImageOptions.Image = global::LOSA.Properties.Resources.reaload_32x32;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnactualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnactualizar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1282, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 496);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1282, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 456);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1282, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 456);
            // 
            // btneditar
            // 
            this.btneditar.Caption = "Configuracion";
            this.btneditar.Id = 0;
            this.btneditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.ImageOptions.Image")));
            this.btneditar.Name = "btneditar";
            this.btneditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnreporte
            // 
            this.btnreporte.Caption = "barButtonItem3";
            this.btnreporte.Id = 2;
            this.btnreporte.Name = "btnreporte";
            // 
            // grd_saldos
            // 
            this.grd_saldos.DataMember = "rubrosmana";
            this.grd_saldos.DataSource = this.dS_SAR;
            this.grd_saldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_saldos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_saldos.Location = new System.Drawing.Point(0, 40);
            this.grd_saldos.MainView = this.grdv_saldos;
            this.grd_saldos.Margin = new System.Windows.Forms.Padding(2);
            this.grd_saldos.MenuManager = this.barManager1;
            this.grd_saldos.Name = "grd_saldos";
            this.grd_saldos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btncambiomonto,
            this.btndetails});
            this.grd_saldos.Size = new System.Drawing.Size(1282, 456);
            this.grd_saldos.TabIndex = 4;
            this.grd_saldos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_saldos});
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_saldos
            // 
            this.grdv_saldos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltotal,
            this.colCode,
            this.colName,
            this.colpresupuesto,
            this.colidregistro,
            this.coldiferencia,
            this.Editar,
            this.coldetails});
            this.grdv_saldos.DetailHeight = 284;
            this.grdv_saldos.GridControl = this.grd_saldos;
            this.grdv_saldos.Name = "grdv_saldos";
            this.grdv_saldos.OptionsView.ShowAutoFilterRow = true;
            this.grdv_saldos.OptionsView.ShowFooter = true;
            this.grdv_saldos.OptionsView.ShowGroupPanel = false;
            this.grdv_saldos.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_saldos_RowStyle);
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Consumo";
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 15;
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            this.coltotal.Width = 163;
            // 
            // colCode
            // 
            this.colCode.Caption = "Código Capitulo";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 15;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 56;
            // 
            // colName
            // 
            this.colName.Caption = "Rubro";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 15;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 438;
            // 
            // colpresupuesto
            // 
            this.colpresupuesto.Caption = "Presupuesto";
            this.colpresupuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpresupuesto.FieldName = "presupuesto";
            this.colpresupuesto.MinWidth = 15;
            this.colpresupuesto.Name = "colpresupuesto";
            this.colpresupuesto.OptionsColumn.AllowEdit = false;
            this.colpresupuesto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colpresupuesto.Visible = true;
            this.colpresupuesto.VisibleIndex = 2;
            this.colpresupuesto.Width = 172;
            // 
            // colidregistro
            // 
            this.colidregistro.FieldName = "idregistro";
            this.colidregistro.MinWidth = 15;
            this.colidregistro.Name = "colidregistro";
            this.colidregistro.OptionsColumn.AllowEdit = false;
            this.colidregistro.Width = 56;
            // 
            // coldiferencia
            // 
            this.coldiferencia.Caption = "Diferencia";
            this.coldiferencia.FieldName = "diferencia";
            this.coldiferencia.MinWidth = 15;
            this.coldiferencia.Name = "coldiferencia";
            this.coldiferencia.OptionsColumn.AllowEdit = false;
            this.coldiferencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.coldiferencia.Visible = true;
            this.coldiferencia.VisibleIndex = 4;
            this.coldiferencia.Width = 201;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.btncambiomonto;
            this.Editar.MinWidth = 15;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 5;
            this.Editar.Width = 56;
            // 
            // btncambiomonto
            // 
            this.btncambiomonto.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btncambiomonto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btncambiomonto.Name = "btncambiomonto";
            this.btncambiomonto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btncambiomonto.Click += new System.EventHandler(this.btncambiomonto_Click);
            // 
            // coldetails
            // 
            this.coldetails.Caption = "Ver detalle";
            this.coldetails.ColumnEdit = this.btndetails;
            this.coldetails.MinWidth = 15;
            this.coldetails.Name = "coldetails";
            this.coldetails.Visible = true;
            this.coldetails.VisibleIndex = 6;
            this.coldetails.Width = 56;
            // 
            // btndetails
            // 
            this.btndetails.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btndetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btndetails.Name = "btndetails";
            this.btndetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // SAR_Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 519);
            this.Controls.Add(this.grd_saldos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SAR_Saldo";
            this.Text = "Consumo de Montos Exonerados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_saldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_saldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncambiomonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btneditar;
        private DevExpress.XtraBars.BarButtonItem btnnueva;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_saldos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_saldos;
        private DevExpress.XtraBars.BarButtonItem btnreporte;
        private DevExpress.XtraBars.BarButtonItem btnedit;
        private DevExpress.XtraBars.BarButtonItem btnperiodos;
        private dS_SAR dS_SAR;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colpresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colidregistro;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btncambiomonto;
        private DevExpress.XtraGrid.Columns.GridColumn coldetails;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btndetails;
        private DevExpress.XtraBars.BarButtonItem btnexport;
        private DevExpress.XtraBars.BarButtonItem barcapitulos;
        private DevExpress.XtraBars.BarButtonItem btnrubrocap;
        private DevExpress.XtraBars.BarButtonItem btnactualizar;
    }
}