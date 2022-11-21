namespace LOSA.MigracionACS.Produccion.Reports
{
    partial class PP_Production_Orders_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Production_Orders_Detail));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_pp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo_mix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_batch_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cant_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cant_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cant_rec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_batch_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_catn_t_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_batch_MB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_catn_t_MB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fecha_ing_wincc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fecha_ult_act = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fecha_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_nc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_generate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Export = new DevExpress.XtraBars.BarSubItem();
            this.btn_excel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dt_hasta);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dt_desde);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(898, 66);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Parametros";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(251, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Fecha Considerada => Ingreso de Formula a WinCC";
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(308, 24);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_hasta.Properties.ValidateOnEnterKey = true;
            this.dt_hasta.Size = new System.Drawing.Size(199, 20);
            this.dt_hasta.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(270, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Desde:";
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(45, 24);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_desde.Size = new System.Drawing.Size(199, 20);
            this.dt_desde.TabIndex = 5;
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 113);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(898, 540);
            this.grd_data.TabIndex = 2;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_pp,
            this.col_cod_pt,
            this.col_pt,
            this.col_cod_mp,
            this.col_mp,
            this.col_tipo_mix,
            this.col_batch_T,
            this.col_cant_batch,
            this.col_cant_orden,
            this.col_cant_rec,
            this.col_batch_MA,
            this.col_catn_t_MA,
            this.col_batch_MB,
            this.col_catn_t_MB,
            this.col_estado,
            this.col_fecha_ing_wincc,
            this.col_fecha_ult_act,
            this.col_fecha_cierre,
            this.col_cod_nc,
            this.col_nc});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "catn_t_MA", this.col_catn_t_MA, "")});
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdv_data.OptionsBehavior.Editable = false;
            // 
            // col_pp
            // 
            this.col_pp.Caption = "Orden Producción";
            this.col_pp.FieldName = "pp";
            this.col_pp.Name = "col_pp";
            this.col_pp.Visible = true;
            this.col_pp.VisibleIndex = 0;
            // 
            // col_cod_pt
            // 
            this.col_cod_pt.Caption = "PT - Código";
            this.col_cod_pt.FieldName = "cod_pt";
            this.col_cod_pt.Name = "col_cod_pt";
            this.col_cod_pt.Visible = true;
            this.col_cod_pt.VisibleIndex = 1;
            // 
            // col_pt
            // 
            this.col_pt.Caption = "PT - Descripción";
            this.col_pt.FieldName = "pt";
            this.col_pt.Name = "col_pt";
            this.col_pt.Visible = true;
            this.col_pt.VisibleIndex = 2;
            // 
            // col_cod_mp
            // 
            this.col_cod_mp.Caption = "MP - Código";
            this.col_cod_mp.FieldName = "cod_mp";
            this.col_cod_mp.Name = "col_cod_mp";
            this.col_cod_mp.Visible = true;
            this.col_cod_mp.VisibleIndex = 3;
            // 
            // col_mp
            // 
            this.col_mp.Caption = "MP - Descripción";
            this.col_mp.FieldName = "mp";
            this.col_mp.Name = "col_mp";
            this.col_mp.Visible = true;
            this.col_mp.VisibleIndex = 4;
            // 
            // col_tipo_mix
            // 
            this.col_tipo_mix.Caption = "MP - Mez";
            this.col_tipo_mix.FieldName = "tipo_mix";
            this.col_tipo_mix.Name = "col_tipo_mix";
            this.col_tipo_mix.Visible = true;
            this.col_tipo_mix.VisibleIndex = 7;
            // 
            // col_batch_T
            // 
            this.col_batch_T.Caption = "Batch - Plan";
            this.col_batch_T.FieldName = "batch_T";
            this.col_batch_T.Name = "col_batch_T";
            this.col_batch_T.Visible = true;
            this.col_batch_T.VisibleIndex = 8;
            // 
            // col_cant_batch
            // 
            this.col_cant_batch.Caption = "KG - X Batch";
            this.col_cant_batch.FieldName = "cant_batch";
            this.col_cant_batch.Name = "col_cant_batch";
            this.col_cant_batch.Visible = true;
            this.col_cant_batch.VisibleIndex = 9;
            // 
            // col_cant_orden
            // 
            this.col_cant_orden.Caption = "KG - Plan";
            this.col_cant_orden.FieldName = "cant_orden";
            this.col_cant_orden.Name = "col_cant_orden";
            this.col_cant_orden.Visible = true;
            this.col_cant_orden.VisibleIndex = 10;
            // 
            // col_cant_rec
            // 
            this.col_cant_rec.Caption = "KG - Cons. Reg.";
            this.col_cant_rec.FieldName = "cant_rec";
            this.col_cant_rec.Name = "col_cant_rec";
            this.col_cant_rec.Visible = true;
            this.col_cant_rec.VisibleIndex = 11;
            // 
            // col_batch_MA
            // 
            this.col_batch_MA.Caption = "Batch - Mez 1";
            this.col_batch_MA.FieldName = "batch_MA";
            this.col_batch_MA.Name = "col_batch_MA";
            this.col_batch_MA.Visible = true;
            this.col_batch_MA.VisibleIndex = 12;
            // 
            // col_catn_t_MA
            // 
            this.col_catn_t_MA.Caption = "KG - Mez 1";
            this.col_catn_t_MA.FieldName = "catn_t_MA";
            this.col_catn_t_MA.Name = "col_catn_t_MA";
            this.col_catn_t_MA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.col_catn_t_MA.Visible = true;
            this.col_catn_t_MA.VisibleIndex = 13;
            // 
            // col_batch_MB
            // 
            this.col_batch_MB.Caption = "Batch - Mez 2";
            this.col_batch_MB.FieldName = "batch_MB";
            this.col_batch_MB.Name = "col_batch_MB";
            this.col_batch_MB.Visible = true;
            this.col_batch_MB.VisibleIndex = 14;
            // 
            // col_catn_t_MB
            // 
            this.col_catn_t_MB.Caption = "KG - Mez 2";
            this.col_catn_t_MB.FieldName = "catn_t_MB";
            this.col_catn_t_MB.Name = "col_catn_t_MB";
            this.col_catn_t_MB.Visible = true;
            this.col_catn_t_MB.VisibleIndex = 15;
            // 
            // col_estado
            // 
            this.col_estado.Caption = "Estado OP";
            this.col_estado.FieldName = "estado";
            this.col_estado.Name = "col_estado";
            this.col_estado.Visible = true;
            this.col_estado.VisibleIndex = 16;
            // 
            // col_fecha_ing_wincc
            // 
            this.col_fecha_ing_wincc.Caption = "Ingreso WinCC";
            this.col_fecha_ing_wincc.FieldName = "fecha_ing_wincc";
            this.col_fecha_ing_wincc.Name = "col_fecha_ing_wincc";
            this.col_fecha_ing_wincc.Visible = true;
            this.col_fecha_ing_wincc.VisibleIndex = 17;
            // 
            // col_fecha_ult_act
            // 
            this.col_fecha_ult_act.Caption = "Ultima Act.";
            this.col_fecha_ult_act.FieldName = "fecha_ult_act";
            this.col_fecha_ult_act.Name = "col_fecha_ult_act";
            this.col_fecha_ult_act.Visible = true;
            this.col_fecha_ult_act.VisibleIndex = 18;
            // 
            // col_fecha_cierre
            // 
            this.col_fecha_cierre.Caption = "Cierre Orden";
            this.col_fecha_cierre.FieldName = "fecha_cierre";
            this.col_fecha_cierre.Name = "col_fecha_cierre";
            this.col_fecha_cierre.Visible = true;
            this.col_fecha_cierre.VisibleIndex = 19;
            // 
            // col_cod_nc
            // 
            this.col_cod_nc.Caption = "NC - Código";
            this.col_cod_nc.FieldName = "cod_nc";
            this.col_cod_nc.Name = "col_cod_nc";
            this.col_cod_nc.Visible = true;
            this.col_cod_nc.VisibleIndex = 5;
            // 
            // col_nc
            // 
            this.col_nc.Caption = "NC - Nucleo";
            this.col_nc.FieldName = "nc";
            this.col_nc.Name = "col_nc";
            this.col_nc.Visible = true;
            this.col_nc.VisibleIndex = 6;
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
            this.btn_generate,
            this.btn_Export,
            this.btn_excel,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_generate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Export)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btn_generate
            // 
            this.btn_generate.Caption = "Generar";
            this.btn_generate.Id = 0;
            this.btn_generate.ImageOptions.Image = global::LOSA.Properties.Resources.Generate_32x32;
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_generate_ItemClick);
            // 
            // btn_Export
            // 
            this.btn_Export.Caption = "Exportar";
            this.btn_Export.Id = 2;
            this.btn_Export.ImageOptions.Image = global::LOSA.Properties.Resources.export_32x32;
            this.btn_Export.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_excel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_excel
            // 
            this.btn_excel.Caption = "Excel";
            this.btn_excel.Id = 3;
            this.btn_excel.ImageOptions.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_excel_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "PDF";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = global::LOSA.Properties.Resources.pdf_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(898, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 653);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(898, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
            // 
            // PP_Production_Orders_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 653);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PP_Production_Orders_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Producción - Detalle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PP_Production_Orders_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_generate;
        private DevExpress.XtraBars.BarSubItem btn_Export;
        private DevExpress.XtraBars.BarButtonItem btn_excel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn col_pp;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_pt;
        private DevExpress.XtraGrid.Columns.GridColumn col_pt;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_mp;
        private DevExpress.XtraGrid.Columns.GridColumn col_mp;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo_mix;
        private DevExpress.XtraGrid.Columns.GridColumn col_batch_T;
        private DevExpress.XtraGrid.Columns.GridColumn col_cant_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_cant_orden;
        private DevExpress.XtraGrid.Columns.GridColumn col_cant_rec;
        private DevExpress.XtraGrid.Columns.GridColumn col_batch_MA;
        private DevExpress.XtraGrid.Columns.GridColumn col_catn_t_MA;
        private DevExpress.XtraGrid.Columns.GridColumn col_batch_MB;
        private DevExpress.XtraGrid.Columns.GridColumn col_catn_t_MB;
        private DevExpress.XtraGrid.Columns.GridColumn col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_fecha_ing_wincc;
        private DevExpress.XtraGrid.Columns.GridColumn col_fecha_ult_act;
        private DevExpress.XtraGrid.Columns.GridColumn col_fecha_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_nc;
        private DevExpress.XtraGrid.Columns.GridColumn col_nc;
    }
}