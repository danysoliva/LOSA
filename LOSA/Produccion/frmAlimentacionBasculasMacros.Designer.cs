
namespace LOSA.Produccion
{
    partial class frmAlimentacionBasculasMacros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlimentacionBasculasMacros));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsProductos1 = new LOSA.MigracionACS.DataSetx.DSProductos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotePT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_final = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_producto_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_teorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantsacos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcelExport = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "alimentacion_macros";
            this.gridControl1.DataSource = this.dsProductos1;
            this.gridControl1.Location = new System.Drawing.Point(3, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1496, 468);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsProductos1
            // 
            this.dsProductos1.DataSetName = "DSProductos";
            this.dsProductos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTurno,
            this.colfecha_inicio,
            this.colDataColumn3,
            this.colbascula,
            this.colnombre_comercial,
            this.collote_materia_prima,
            this.colLotePT,
            this.colpeso_inicial,
            this.colpeso_final,
            this.colpeso_producto_bascula,
            this.colpeso_teorico,
            this.coldiferencia,
            this.colcantsacos,
            this.colpresentacion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colTurno
            // 
            this.colTurno.Caption = "Turno";
            this.colTurno.FieldName = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.OptionsColumn.AllowEdit = false;
            this.colTurno.OptionsColumn.ReadOnly = true;
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 0;
            this.colTurno.Width = 71;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "F. Inicio Pesaje";
            this.colfecha_inicio.DisplayFormat.FormatString = "g";
            this.colfecha_inicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.AllowEdit = false;
            this.colfecha_inicio.OptionsColumn.ReadOnly = true;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 1;
            this.colfecha_inicio.Width = 125;
            // 
            // colDataColumn3
            // 
            this.colDataColumn3.Caption = "F. Final Pesaje";
            this.colDataColumn3.DisplayFormat.FormatString = "g";
            this.colDataColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataColumn3.FieldName = "fecha_final";
            this.colDataColumn3.Name = "colDataColumn3";
            this.colDataColumn3.OptionsColumn.AllowEdit = false;
            this.colDataColumn3.OptionsColumn.ReadOnly = true;
            this.colDataColumn3.Visible = true;
            this.colDataColumn3.VisibleIndex = 2;
            this.colDataColumn3.Width = 114;
            // 
            // colbascula
            // 
            this.colbascula.Caption = "Bascula";
            this.colbascula.FieldName = "bascula";
            this.colbascula.Name = "colbascula";
            this.colbascula.OptionsColumn.AllowEdit = false;
            this.colbascula.OptionsColumn.ReadOnly = true;
            this.colbascula.Visible = true;
            this.colbascula.VisibleIndex = 3;
            this.colbascula.Width = 54;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "Materia Prima";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.ReadOnly = true;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 5;
            this.colnombre_comercial.Width = 97;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote Materia Prima";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.OptionsColumn.ReadOnly = true;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 6;
            this.collote_materia_prima.Width = 127;
            // 
            // colLotePT
            // 
            this.colLotePT.Caption = "Lote PT";
            this.colLotePT.FieldName = "LotePT";
            this.colLotePT.Name = "colLotePT";
            this.colLotePT.OptionsColumn.AllowEdit = false;
            this.colLotePT.OptionsColumn.ReadOnly = true;
            this.colLotePT.Visible = true;
            this.colLotePT.VisibleIndex = 7;
            this.colLotePT.Width = 71;
            // 
            // colpeso_inicial
            // 
            this.colpeso_inicial.Caption = "Pesaje Inicial";
            this.colpeso_inicial.DisplayFormat.FormatString = "{0:##,###,##0.##} Kg";
            this.colpeso_inicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_inicial.FieldName = "peso_inicial";
            this.colpeso_inicial.Name = "colpeso_inicial";
            this.colpeso_inicial.OptionsColumn.AllowEdit = false;
            this.colpeso_inicial.OptionsColumn.ReadOnly = true;
            this.colpeso_inicial.Visible = true;
            this.colpeso_inicial.VisibleIndex = 8;
            this.colpeso_inicial.Width = 80;
            // 
            // colpeso_final
            // 
            this.colpeso_final.Caption = "Pesaje Final";
            this.colpeso_final.DisplayFormat.FormatString = "{0:##,###,##0.##} Kg";
            this.colpeso_final.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_final.FieldName = "peso_final";
            this.colpeso_final.Name = "colpeso_final";
            this.colpeso_final.OptionsColumn.AllowEdit = false;
            this.colpeso_final.OptionsColumn.ReadOnly = true;
            this.colpeso_final.Visible = true;
            this.colpeso_final.VisibleIndex = 9;
            this.colpeso_final.Width = 84;
            // 
            // colpeso_producto_bascula
            // 
            this.colpeso_producto_bascula.Caption = "Peso Neto Bascula";
            this.colpeso_producto_bascula.DisplayFormat.FormatString = "{0:##,###,##0.##} Kg";
            this.colpeso_producto_bascula.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_producto_bascula.FieldName = "peso_producto_bascula";
            this.colpeso_producto_bascula.Name = "colpeso_producto_bascula";
            this.colpeso_producto_bascula.OptionsColumn.AllowEdit = false;
            this.colpeso_producto_bascula.OptionsColumn.ReadOnly = true;
            this.colpeso_producto_bascula.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso_producto_bascula", "{0:##,###,##0.##} Kg")});
            this.colpeso_producto_bascula.Visible = true;
            this.colpeso_producto_bascula.VisibleIndex = 10;
            this.colpeso_producto_bascula.Width = 130;
            // 
            // colpeso_teorico
            // 
            this.colpeso_teorico.Caption = "Peso Neto Teorico";
            this.colpeso_teorico.DisplayFormat.FormatString = "{0:##,###,##0.##} Kg";
            this.colpeso_teorico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_teorico.FieldName = "peso_teorico";
            this.colpeso_teorico.Name = "colpeso_teorico";
            this.colpeso_teorico.OptionsColumn.AllowEdit = false;
            this.colpeso_teorico.OptionsColumn.ReadOnly = true;
            this.colpeso_teorico.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso_teorico", "{0:##,###,##0.##} Kg")});
            this.colpeso_teorico.Visible = true;
            this.colpeso_teorico.VisibleIndex = 11;
            this.colpeso_teorico.Width = 130;
            // 
            // coldiferencia
            // 
            this.coldiferencia.Caption = "Diferencia";
            this.coldiferencia.DisplayFormat.FormatString = "{0:##,###,##0.##} Kg";
            this.coldiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldiferencia.FieldName = "diferencia";
            this.coldiferencia.Name = "coldiferencia";
            this.coldiferencia.OptionsColumn.AllowEdit = false;
            this.coldiferencia.OptionsColumn.ReadOnly = true;
            this.coldiferencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "diferencia", "{0:##,###,##0.##} Kg")});
            this.coldiferencia.Visible = true;
            this.coldiferencia.VisibleIndex = 12;
            this.coldiferencia.Width = 72;
            // 
            // colcantsacos
            // 
            this.colcantsacos.Caption = "Cant. Sacos";
            this.colcantsacos.DisplayFormat.FormatString = "n1";
            this.colcantsacos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantsacos.FieldName = "cantsacos";
            this.colcantsacos.Name = "colcantsacos";
            this.colcantsacos.OptionsColumn.AllowEdit = false;
            this.colcantsacos.OptionsColumn.ReadOnly = true;
            this.colcantsacos.Visible = true;
            this.colcantsacos.VisibleIndex = 13;
            this.colcantsacos.Width = 108;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion Saco";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.OptionsColumn.ReadOnly = true;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 14;
            this.colpresentacion.Width = 89;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Peso Saco Promedio";
            this.gridColumn1.DisplayFormat.FormatString = "n2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "peso_saco_promedio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 15;
            this.gridColumn1.Width = 119;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Codigo MP";
            this.gridColumn2.FieldName = "itemcode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "% Desviacion";
            this.gridColumn3.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "diffporcentaje";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdGuardar.ImageOptions.SvgImage")));
            this.cmdGuardar.Location = new System.Drawing.Point(284, 25);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(126, 40);
            this.cmdGuardar.TabIndex = 36;
            this.cmdGuardar.Text = "Actualizar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(1363, 25);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(126, 40);
            this.cmdHome.TabIndex = 37;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.btnExcelExport.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelExport.Appearance.Options.UseBackColor = true;
            this.btnExcelExport.Appearance.Options.UseFont = true;
            this.btnExcelExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExcelExport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExcelExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcelExport.ImageOptions.SvgImage")));
            this.btnExcelExport.Location = new System.Drawing.Point(436, 25);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(126, 40);
            this.btnExcelExport.TabIndex = 38;
            this.btnExcelExport.Text = "Exportar";
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(121, 44);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHastaDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(142, 24);
            this.dtFechaHastaDisponibles.TabIndex = 101;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 47);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(88, 18);
            this.labelControl9.TabIndex = 102;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(121, 12);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesdeDisponibles.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesdeDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(142, 24);
            this.dtFechaDesdeDisponibles.TabIndex = 99;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 18);
            this.labelControl8.TabIndex = 100;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // frmAlimentacionBasculasMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 545);
            this.Controls.Add(this.dtFechaHastaDisponibles);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesdeDisponibles);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAlimentacionBasculasMacros";
            this.Text = "frmAlimentacionBasculasMacros";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MigracionACS.DataSetx.DSProductos dsProductos1;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colbascula;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colLotePT;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_inicial;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_final;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_producto_bascula;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_teorico;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colcantsacos;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDataColumn3;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton btnExcelExport;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}