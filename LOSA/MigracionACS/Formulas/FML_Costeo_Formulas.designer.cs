namespace LOSA.MigracionACS.Formulas
{
    partial class FML_Costeo_Formulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_Costeo_Formulas));
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_especie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigo_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombre_formula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombre_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costo_primo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costo_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costo_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigo_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_peso_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costo_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_costo_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_export = new DevExpress.XtraBars.BarSubItem();
            this.btn_excel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_pdf = new DevExpress.XtraBars.BarButtonItem();
            this.btn_print = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grp_parametros = new DevExpress.XtraEditors.GroupControl();
            this.btn_actualizar = new DevExpress.XtraEditors.SimpleButton();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.lbl_desde = new DevExpress.XtraEditors.LabelControl();
            this.lbl_hasta = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_parametros)).BeginInit();
            this.grp_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_data
            // 
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 107);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(732, 249);
            this.grd_data.TabIndex = 0;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_especie,
            this.col_codigo_formula,
            this.col_nombre_formula,
            this.col_nombre_pt,
            this.col_costo_primo,
            this.col_costo_produccion,
            this.col_costo_total,
            this.col_codigo_pt,
            this.col_version,
            this.col_tipo,
            this.col_peso_batch,
            this.col_costo_batch,
            this.col_costo_tm});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.GroupCount = 2;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_especie, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_codigo_formula, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_data.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_data_RowStyle);
            // 
            // col_id
            // 
            this.col_id.Caption = "id";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            this.col_id.Width = 40;
            // 
            // col_especie
            // 
            this.col_especie.Caption = "Especie";
            this.col_especie.FieldName = "especie";
            this.col_especie.Name = "col_especie";
            this.col_especie.Visible = true;
            this.col_especie.VisibleIndex = 0;
            this.col_especie.Width = 64;
            // 
            // col_codigo_formula
            // 
            this.col_codigo_formula.Caption = "Código Formula";
            this.col_codigo_formula.FieldName = "codigo_formula";
            this.col_codigo_formula.Name = "col_codigo_formula";
            this.col_codigo_formula.Visible = true;
            this.col_codigo_formula.VisibleIndex = 0;
            this.col_codigo_formula.Width = 76;
            // 
            // col_nombre_formula
            // 
            this.col_nombre_formula.Caption = "Formula";
            this.col_nombre_formula.FieldName = "nombre_formula";
            this.col_nombre_formula.Name = "col_nombre_formula";
            this.col_nombre_formula.Visible = true;
            this.col_nombre_formula.VisibleIndex = 1;
            this.col_nombre_formula.Width = 122;
            // 
            // col_nombre_pt
            // 
            this.col_nombre_pt.Caption = "Producto Terminado";
            this.col_nombre_pt.FieldName = "nombre_pt";
            this.col_nombre_pt.Name = "col_nombre_pt";
            this.col_nombre_pt.Width = 123;
            // 
            // col_costo_primo
            // 
            this.col_costo_primo.Caption = "Costo Primo";
            this.col_costo_primo.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_costo_primo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_costo_primo.FieldName = "costo_primo";
            this.col_costo_primo.Name = "col_costo_primo";
            this.col_costo_primo.Width = 96;
            // 
            // col_costo_produccion
            // 
            this.col_costo_produccion.Caption = "Costo de Producción";
            this.col_costo_produccion.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_costo_produccion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_costo_produccion.FieldName = "costo_produccion";
            this.col_costo_produccion.Name = "col_costo_produccion";
            this.col_costo_produccion.Width = 108;
            // 
            // col_costo_total
            // 
            this.col_costo_total.Caption = "Total";
            this.col_costo_total.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_costo_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_costo_total.FieldName = "costo_total";
            this.col_costo_total.Name = "col_costo_total";
            this.col_costo_total.Width = 108;
            // 
            // col_codigo_pt
            // 
            this.col_codigo_pt.Caption = "Código PT";
            this.col_codigo_pt.FieldName = "codigo_pt";
            this.col_codigo_pt.Name = "col_codigo_pt";
            this.col_codigo_pt.OptionsColumn.AllowEdit = false;
            this.col_codigo_pt.Width = 81;
            // 
            // col_version
            // 
            this.col_version.Caption = "Version";
            this.col_version.FieldName = "version";
            this.col_version.Name = "col_version";
            this.col_version.Visible = true;
            this.col_version.VisibleIndex = 0;
            // 
            // col_tipo
            // 
            this.col_tipo.Caption = "TipoFml";
            this.col_tipo.FieldName = "tipo";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.Visible = true;
            this.col_tipo.VisibleIndex = 2;
            // 
            // col_peso_batch
            // 
            this.col_peso_batch.Caption = "Peso Batch";
            this.col_peso_batch.DisplayFormat.FormatString = "Kg #,###,###,###.0000";
            this.col_peso_batch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_peso_batch.FieldName = "peso_batch";
            this.col_peso_batch.Name = "col_peso_batch";
            this.col_peso_batch.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.col_peso_batch.Visible = true;
            this.col_peso_batch.VisibleIndex = 3;
            // 
            // col_costo_batch
            // 
            this.col_costo_batch.Caption = "Costo Batch";
            this.col_costo_batch.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.col_costo_batch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_costo_batch.FieldName = "costo_batch";
            this.col_costo_batch.Name = "col_costo_batch";
            this.col_costo_batch.Visible = true;
            this.col_costo_batch.VisibleIndex = 4;
            // 
            // col_costo_tm
            // 
            this.col_costo_tm.Caption = "Costo TM";
            this.col_costo_tm.DisplayFormat.FormatString = "n4";
            this.col_costo_tm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_costo_tm.FieldName = "costo_tm";
            this.col_costo_tm.Name = "col_costo_tm";
            this.col_costo_tm.Visible = true;
            this.col_costo_tm.VisibleIndex = 5;
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
            this.btn_export,
            this.btn_print,
            this.btn_excel,
            this.btn_pdf});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_export),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_print)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_export
            // 
            this.btn_export.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_export.Caption = "Exportar";
            this.btn_export.Id = 2;
            this.btn_export.ImageOptions.Image = global::LOSA.Properties.Resources.export_32x32;
            this.btn_export.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_excel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_pdf)});
            this.btn_export.Name = "btn_export";
            this.btn_export.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btn_excel
            // 
            this.btn_excel.Caption = "Excel";
            this.btn_excel.Id = 4;
            this.btn_excel.ImageOptions.Image = global::LOSA.Properties.Resources.excel_24x24;
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_excel_ItemClick);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Caption = "PDF";
            this.btn_pdf.Id = 5;
            this.btn_pdf.ImageOptions.Image = global::LOSA.Properties.Resources.pdf_24x24;
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_pdf_ItemClick);
            // 
            // btn_print
            // 
            this.btn_print.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_print.Caption = "Imprimir";
            this.btn_print.Id = 3;
            this.btn_print.ImageOptions.Image = global::LOSA.Properties.Resources.print_32x32;
            this.btn_print.Name = "btn_print";
            this.btn_print.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_print_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(732, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 356);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(732, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 316);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(732, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 316);
            // 
            // grp_parametros
            // 
            this.grp_parametros.Controls.Add(this.btn_actualizar);
            this.grp_parametros.Controls.Add(this.dt_desde);
            this.grp_parametros.Controls.Add(this.dt_hasta);
            this.grp_parametros.Controls.Add(this.lbl_desde);
            this.grp_parametros.Controls.Add(this.lbl_hasta);
            this.grp_parametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_parametros.Location = new System.Drawing.Point(0, 40);
            this.grp_parametros.Name = "grp_parametros";
            this.grp_parametros.Size = new System.Drawing.Size(732, 67);
            this.grp_parametros.TabIndex = 1;
            this.grp_parametros.Text = "Parametros";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.ImageOptions.Image = global::LOSA.Properties.Resources.refresh_24x24;
            this.btn_actualizar.Location = new System.Drawing.Point(473, 30);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(92, 30);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Generar";
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(58, 33);
            this.dt_desde.MenuManager = this.barManager1;
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_desde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_desde.Properties.Appearance.Options.UseFont = true;
            this.dt_desde.Properties.Appearance.Options.UseForeColor = true;
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
            this.dt_desde.Size = new System.Drawing.Size(170, 22);
            this.dt_desde.TabIndex = 5;
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(286, 33);
            this.dt_hasta.MenuManager = this.barManager1;
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_hasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_hasta.Properties.Appearance.Options.UseFont = true;
            this.dt_hasta.Properties.Appearance.Options.UseForeColor = true;
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
            this.dt_hasta.Size = new System.Drawing.Size(170, 22);
            this.dt_hasta.TabIndex = 6;
            // 
            // lbl_desde
            // 
            this.lbl_desde.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_desde.Appearance.Options.UseFont = true;
            this.lbl_desde.Appearance.Options.UseForeColor = true;
            this.lbl_desde.Location = new System.Drawing.Point(12, 36);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(40, 16);
            this.lbl_desde.TabIndex = 7;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_hasta.Appearance.Options.UseFont = true;
            this.lbl_hasta.Appearance.Options.UseForeColor = true;
            this.lbl_hasta.Location = new System.Drawing.Point(240, 36);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(38, 16);
            this.lbl_hasta.TabIndex = 8;
            this.lbl_hasta.Text = "Hasta";
            // 
            // FML_Costeo_Formulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 379);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.grp_parametros);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FML_Costeo_Formulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Costo Formulas y Producto Terminado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FML_Costeo_Formulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_parametros)).EndInit();
            this.grp_parametros.ResumeLayout(false);
            this.grp_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grp_parametros;
        private DevExpress.XtraBars.BarSubItem btn_export;
        private DevExpress.XtraBars.BarButtonItem btn_excel;
        private DevExpress.XtraBars.BarButtonItem btn_pdf;
        private DevExpress.XtraBars.BarButtonItem btn_print;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_especie;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo_formula;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre_formula;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre_pt;
        private DevExpress.XtraGrid.Columns.GridColumn col_costo_primo;
        private DevExpress.XtraGrid.Columns.GridColumn col_costo_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_costo_total;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo_pt;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private DevExpress.XtraEditors.LabelControl lbl_desde;
        private DevExpress.XtraEditors.LabelControl lbl_hasta;
        private DevExpress.XtraGrid.Columns.GridColumn col_version;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn col_peso_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_costo_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_costo_tm;
    }
}