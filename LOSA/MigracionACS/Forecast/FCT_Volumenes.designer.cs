namespace LOSA.MigracionACS.Forecast
{
    partial class FCT_Volumenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCT_Volumenes));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_export = new DevExpress.XtraBars.BarSubItem();
            this.btn_excel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pdf = new DevExpress.XtraBars.BarButtonItem();
            this.btn_print = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_message = new DevExpress.XtraEditors.LabelControl();
            this.rgrp_Todo = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_proyecciones = new DevExpress.XtraEditors.LookUpEdit();
            this.grd_volumenes = new DevExpress.XtraGrid.GridControl();
            this.grdv_volumenes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colene = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgrp_Todo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proyecciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_volumenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_volumenes)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_export,
            this.btn_excel,
            this.btn_pdf,
            this.btn_print});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_export),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_print)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // btn_export
            // 
            this.btn_export.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_export.Caption = "Exportar";
            this.btn_export.Glyph = global::LOSA.Properties.Resources.export_32x32;
            this.btn_export.Id = 0;
            this.btn_export.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_excel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_pdf)});
            this.btn_export.Name = "btn_export";
            this.btn_export.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btn_excel
            // 
            this.btn_excel.Caption = "Excel";
            this.btn_excel.Glyph = global::LOSA.Properties.Resources.excel_24x24;
            this.btn_excel.Id = 2;
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_excel_ItemClick);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Caption = "PDF";
            this.btn_pdf.Glyph = global::LOSA.Properties.Resources.pdf_24x24;
            this.btn_pdf.Id = 3;
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_pdf_ItemClick);
            // 
            // btn_print
            // 
            this.btn_print.Caption = "Imprimir";
            this.btn_print.Glyph = global::LOSA.Properties.Resources.print_32x32;
            this.btn_print.Id = 4;
            this.btn_print.Name = "btn_print";
            this.btn_print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_print_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(629, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 376);
            this.barDockControlBottom.Size = new System.Drawing.Size(629, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 329);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(629, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 329);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbl_message);
            this.groupControl1.Controls.Add(this.rgrp_Todo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmb_proyecciones);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(629, 59);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Opciones";
            // 
            // lbl_message
            // 
            this.lbl_message.Location = new System.Drawing.Point(563, 34);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 5;
            // 
            // rgrp_Todo
            // 
            this.rgrp_Todo.Enabled = false;
            this.rgrp_Todo.Location = new System.Drawing.Point(323, 29);
            this.rgrp_Todo.MenuManager = this.barManager1;
            this.rgrp_Todo.Name = "rgrp_Todo";
            this.rgrp_Todo.Properties.Columns = 2;
            this.rgrp_Todo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Según Fecha Actual")});
            this.rgrp_Todo.Size = new System.Drawing.Size(238, 22);
            this.rgrp_Todo.TabIndex = 4;
            this.rgrp_Todo.SelectedIndexChanged += new System.EventHandler(this.rgrp_Todo_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Seleccionar Proyección:";
            // 
            // cmb_proyecciones
            // 
            this.cmb_proyecciones.Location = new System.Drawing.Point(130, 30);
            this.cmb_proyecciones.MenuManager = this.barManager1;
            this.cmb_proyecciones.Name = "cmb_proyecciones";
            this.cmb_proyecciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_proyecciones.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Proyección")});
            this.cmb_proyecciones.Properties.DisplayMember = "name";
            this.cmb_proyecciones.Properties.ValueMember = "id";
            this.cmb_proyecciones.Size = new System.Drawing.Size(189, 20);
            this.cmb_proyecciones.TabIndex = 2;
            this.cmb_proyecciones.EditValueChanged += new System.EventHandler(this.cmb_proyecciones_EditValueChanged);
            // 
            // grd_volumenes
            // 
            this.grd_volumenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_volumenes.Location = new System.Drawing.Point(0, 106);
            this.grd_volumenes.MainView = this.grdv_volumenes;
            this.grd_volumenes.MenuManager = this.barManager1;
            this.grd_volumenes.Name = "grd_volumenes";
            this.grd_volumenes.Size = new System.Drawing.Size(629, 270);
            this.grd_volumenes.TabIndex = 5;
            this.grd_volumenes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_volumenes});
            // 
            // grdv_volumenes
            // 
            this.grdv_volumenes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colmaterial,
            this.coltipo,
            this.colene,
            this.colfeb,
            this.colmar,
            this.colabr,
            this.colmay,
            this.coljun,
            this.coljul,
            this.colago,
            this.colsep,
            this.coloct,
            this.colnov,
            this.coldic,
            this.coltotal});
            this.grdv_volumenes.GridControl = this.grd_volumenes;
            this.grdv_volumenes.GroupCount = 1;
            this.grdv_volumenes.Name = "grdv_volumenes";
            this.grdv_volumenes.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_volumenes.OptionsBehavior.Editable = false;
            this.grdv_volumenes.OptionsView.ShowAutoFilterRow = true;
            this.grdv_volumenes.OptionsView.ShowFooter = true;
            this.grdv_volumenes.OptionsView.ShowGroupPanel = false;
            this.grdv_volumenes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 41;
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "Materia Prima";
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 1;
            this.colmaterial.Width = 76;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo Materia Prima";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 2;
            // 
            // colene
            // 
            this.colene.Caption = "Enero";
            this.colene.DisplayFormat.FormatString = "n4";
            this.colene.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colene.FieldName = "ene";
            this.colene.Name = "colene";
            this.colene.Visible = true;
            this.colene.VisibleIndex = 2;
            this.colene.Width = 35;
            // 
            // colfeb
            // 
            this.colfeb.Caption = "Febrero";
            this.colfeb.DisplayFormat.FormatString = "n4";
            this.colfeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colfeb.FieldName = "feb";
            this.colfeb.Name = "colfeb";
            this.colfeb.Visible = true;
            this.colfeb.VisibleIndex = 3;
            this.colfeb.Width = 35;
            // 
            // colmar
            // 
            this.colmar.Caption = "Marzo";
            this.colmar.DisplayFormat.FormatString = "n4";
            this.colmar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmar.FieldName = "mar";
            this.colmar.Name = "colmar";
            this.colmar.Visible = true;
            this.colmar.VisibleIndex = 4;
            this.colmar.Width = 35;
            // 
            // colabr
            // 
            this.colabr.Caption = "Abril";
            this.colabr.DisplayFormat.FormatString = "n4";
            this.colabr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colabr.FieldName = "abr";
            this.colabr.Name = "colabr";
            this.colabr.Visible = true;
            this.colabr.VisibleIndex = 5;
            this.colabr.Width = 35;
            // 
            // colmay
            // 
            this.colmay.Caption = "Mayo";
            this.colmay.DisplayFormat.FormatString = "n4";
            this.colmay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmay.FieldName = "may";
            this.colmay.Name = "colmay";
            this.colmay.Visible = true;
            this.colmay.VisibleIndex = 6;
            this.colmay.Width = 35;
            // 
            // coljun
            // 
            this.coljun.Caption = "Junio";
            this.coljun.DisplayFormat.FormatString = "n4";
            this.coljun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coljun.FieldName = "jun";
            this.coljun.Name = "coljun";
            this.coljun.Visible = true;
            this.coljun.VisibleIndex = 7;
            this.coljun.Width = 35;
            // 
            // coljul
            // 
            this.coljul.Caption = "Julio";
            this.coljul.DisplayFormat.FormatString = "n4";
            this.coljul.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coljul.FieldName = "jul";
            this.coljul.Name = "coljul";
            this.coljul.Visible = true;
            this.coljul.VisibleIndex = 8;
            this.coljul.Width = 35;
            // 
            // colago
            // 
            this.colago.Caption = "Agosto";
            this.colago.DisplayFormat.FormatString = "n4";
            this.colago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colago.FieldName = "ago";
            this.colago.Name = "colago";
            this.colago.Visible = true;
            this.colago.VisibleIndex = 9;
            this.colago.Width = 35;
            // 
            // colsep
            // 
            this.colsep.Caption = "Septiembre";
            this.colsep.DisplayFormat.FormatString = "n4";
            this.colsep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsep.FieldName = "sep";
            this.colsep.Name = "colsep";
            this.colsep.Visible = true;
            this.colsep.VisibleIndex = 10;
            this.colsep.Width = 35;
            // 
            // coloct
            // 
            this.coloct.Caption = "Octubre";
            this.coloct.DisplayFormat.FormatString = "n4";
            this.coloct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coloct.FieldName = "oct";
            this.coloct.Name = "coloct";
            this.coloct.Visible = true;
            this.coloct.VisibleIndex = 11;
            this.coloct.Width = 35;
            // 
            // colnov
            // 
            this.colnov.Caption = "Noviembre";
            this.colnov.DisplayFormat.FormatString = "n4";
            this.colnov.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnov.FieldName = "nov";
            this.colnov.Name = "colnov";
            this.colnov.Visible = true;
            this.colnov.VisibleIndex = 12;
            this.colnov.Width = 35;
            // 
            // coldic
            // 
            this.coldic.Caption = "Diciembre";
            this.coldic.DisplayFormat.FormatString = "n4";
            this.coldic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldic.FieldName = "dic";
            this.coldic.Name = "coldic";
            this.coldic.Visible = true;
            this.coldic.VisibleIndex = 13;
            this.coldic.Width = 35;
            // 
            // coltotal
            // 
            this.coltotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltotal.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.coltotal.AppearanceCell.Options.UseFont = true;
            this.coltotal.AppearanceCell.Options.UseForeColor = true;
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "#,###,###.0000 Tn";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:n4} Tn")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 14;
            this.coltotal.Width = 42;
            // 
            // FCT_Volumenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 376);
            this.Controls.Add(this.grd_volumenes);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCT_Volumenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volumen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FCT_Volumenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgrp_Todo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proyecciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_volumenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_volumenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_volumenes;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_volumenes;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmb_proyecciones;
        private DevExpress.XtraBars.BarSubItem btn_export;
        private DevExpress.XtraBars.BarButtonItem btn_excel;
        private DevExpress.XtraBars.BarButtonItem btn_pdf;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colene;
        private DevExpress.XtraGrid.Columns.GridColumn colfeb;
        private DevExpress.XtraGrid.Columns.GridColumn colmar;
        private DevExpress.XtraGrid.Columns.GridColumn colabr;
        private DevExpress.XtraGrid.Columns.GridColumn colmay;
        private DevExpress.XtraGrid.Columns.GridColumn coljun;
        private DevExpress.XtraGrid.Columns.GridColumn coljul;
        private DevExpress.XtraGrid.Columns.GridColumn colago;
        private DevExpress.XtraGrid.Columns.GridColumn colsep;
        private DevExpress.XtraGrid.Columns.GridColumn coloct;
        private DevExpress.XtraGrid.Columns.GridColumn colnov;
        private DevExpress.XtraGrid.Columns.GridColumn coldic;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraEditors.RadioGroup rgrp_Todo;
        private DevExpress.XtraBars.BarButtonItem btn_print;
        private DevExpress.XtraEditors.LabelControl lbl_message;
    }
}