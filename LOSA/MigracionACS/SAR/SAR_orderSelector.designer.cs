namespace LOSA.MigracionACS.SAR
{
    partial class SAR_orderSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_orderSelector));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.bttnactualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnmain = new DevExpress.XtraEditors.PanelControl();
            this.grd_main = new DevExpress.XtraGrid.GridControl();
            this.oCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatadoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotaldoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnagregar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).BeginInit();
            this.pnmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).BeginInit();
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
            this.btnclose,
            this.bttnactualizar,
            this.btnagregar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose),
            new DevExpress.XtraBars.LinkPersistInfo(this.bttnactualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnagregar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 0;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // bttnactualizar
            // 
            this.bttnactualizar.Caption = "Actualizar";
            this.bttnactualizar.Id = 1;
            this.bttnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttnactualizar.ImageOptions.Image")));
            this.bttnactualizar.Name = "bttnactualizar";
            this.bttnactualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bttnactualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bttnactualizar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1879, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 700);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1879, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 650);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1879, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 650);
            // 
            // pnmain
            // 
            this.pnmain.Controls.Add(this.grd_main);
            this.pnmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmain.Location = new System.Drawing.Point(0, 50);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(1879, 650);
            this.pnmain.TabIndex = 4;
            // 
            // grd_main
            // 
            this.grd_main.DataSource = this.oCHBindingSource;
            this.grd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_main.Location = new System.Drawing.Point(2, 2);
            this.grd_main.MainView = this.grdv_main;
            this.grd_main.MenuManager = this.barManager1;
            this.grd_main.Name = "grd_main";
            this.grd_main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btneditar});
            this.grd_main.Size = new System.Drawing.Size(1875, 646);
            this.grd_main.TabIndex = 0;
            this.grd_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_main});
            // 
            // oCHBindingSource
            // 
            this.oCHBindingSource.DataMember = "OCH";
            this.oCHBindingSource.DataSource = this.dS_SAR;
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_main
            // 
            this.grdv_main.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdv_main.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.grdv_main.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_main.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdv_main.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_main.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_main.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdv_main.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_main.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grdv_main.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdv_main.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_main.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdv_main.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_main.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_main.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grdv_main.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_main.Appearance.Row.Options.UseBackColor = true;
            this.grdv_main.Appearance.Row.Options.UseFont = true;
            this.grdv_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDocEntry,
            this.colCardCode,
            this.colCardName,
            this.colmoneda,
            this.colTasa,
            this.coldatadoc,
            this.colid_tipo,
            this.colcomment,
            this.coltotaldoc,
            this.colmes,
            this.colselect});
            this.grdv_main.GridControl = this.grd_main;
            this.grdv_main.GroupCount = 1;
            this.grdv_main.Name = "grdv_main";
            this.grdv_main.OptionsView.ShowAutoFilterRow = true;
            this.grdv_main.OptionsView.ShowGroupPanel = false;
            this.grdv_main.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colmes, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colDocEntry
            // 
            this.colDocEntry.Caption = "OC ID";
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 0;
            this.colDocEntry.Width = 85;
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.AllowEdit = false;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Proveedor";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 2;
            this.colCardName.Width = 411;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.OptionsColumn.AllowEdit = false;
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 3;
            this.colmoneda.Width = 96;
            // 
            // colTasa
            // 
            this.colTasa.FieldName = "Tasa";
            this.colTasa.Name = "colTasa";
            this.colTasa.OptionsColumn.AllowEdit = false;
            // 
            // coldatadoc
            // 
            this.coldatadoc.Caption = "Fecha";
            this.coldatadoc.FieldName = "datadoc";
            this.coldatadoc.Name = "coldatadoc";
            this.coldatadoc.OptionsColumn.AllowEdit = false;
            this.coldatadoc.Visible = true;
            this.coldatadoc.VisibleIndex = 1;
            this.coldatadoc.Width = 122;
            // 
            // colid_tipo
            // 
            this.colid_tipo.FieldName = "id_tipo";
            this.colid_tipo.Name = "colid_tipo";
            this.colid_tipo.OptionsColumn.AllowEdit = false;
            // 
            // colcomment
            // 
            this.colcomment.Caption = "Comentario";
            this.colcomment.FieldName = "comment";
            this.colcomment.Name = "colcomment";
            this.colcomment.OptionsColumn.AllowEdit = false;
            this.colcomment.Visible = true;
            this.colcomment.VisibleIndex = 4;
            this.colcomment.Width = 1008;
            // 
            // coltotaldoc
            // 
            this.coltotaldoc.Caption = "Total";
            this.coltotaldoc.FieldName = "totaldoc";
            this.coltotaldoc.Name = "coltotaldoc";
            this.coltotaldoc.OptionsColumn.AllowEdit = false;
            this.coltotaldoc.Visible = true;
            this.coltotaldoc.VisibleIndex = 5;
            this.coltotaldoc.Width = 133;
            // 
            // colmes
            // 
            this.colmes.Caption = "Mes";
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.OptionsColumn.AllowEdit = false;
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 6;
            // 
            // colselect
            // 
            this.colselect.Caption = "Editar";
            this.colselect.ColumnEdit = this.btneditar;
            this.colselect.Name = "colselect";
            this.colselect.Visible = true;
            this.colselect.VisibleIndex = 6;
            // 
            // btneditar
            // 
            this.btneditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btneditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btneditar.Name = "btneditar";
            this.btneditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Caption = "Agregar Orden de compra";
            this.btnagregar.Id = 2;
            this.btnagregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.ImageOptions.Image")));
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnagregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnagregar_ItemClick);
            // 
            // SAR_orderSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 725);
            this.Controls.Add(this.pnmain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SAR_orderSelector";
            this.Text = "Seleccion de ordenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnmain)).EndInit();
            this.pnmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraBars.BarButtonItem bttnactualizar;
        private DevExpress.XtraEditors.PanelControl pnmain;
        private DevExpress.XtraGrid.GridControl grd_main;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_main;
        private System.Windows.Forms.BindingSource oCHBindingSource;
        private dS_SAR dS_SAR;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colTasa;
        private DevExpress.XtraGrid.Columns.GridColumn coldatadoc;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcomment;
        private DevExpress.XtraGrid.Columns.GridColumn coltotaldoc;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn colselect;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btneditar;
        private DevExpress.XtraBars.BarButtonItem btnagregar;
    }
}