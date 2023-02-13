using LOSA.MigracionACS.Produccion.DashBoard;

namespace LOSA.MigracionACS.Produccion.Produccion.DashBoard
{
    partial class frmCuadroLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadroLotes));
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.lblFechaHasta = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaDesde = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDashBoard1 = new LOSA.MigracionACS.Produccion.DashBoard.dsDashBoard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfml_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfml_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_sacos_prd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashBoard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(333, 25);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 15;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(100, 25);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 14;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.ImageOptions.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(610, 12);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(116, 39);
            this.cmdExportar.TabIndex = 13;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // CargarDatos
            // 
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(467, 12);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 12;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Appearance.Options.UseFont = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(254, 30);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(73, 17);
            this.lblFechaHasta.TabIndex = 11;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Appearance.Options.UseFont = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(17, 30);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(77, 17);
            this.lblFechaDesde.TabIndex = 10;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "cuadro_de_lotes";
            this.gridControl1.DataSource = this.dsDashBoard1;
            this.gridControl1.Location = new System.Drawing.Point(3, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1013, 502);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsDashBoard1
            // 
            this.dsDashBoard1.DataSetName = "dsDashBoard";
            this.dsDashBoard1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colcodigo,
            this.coldescripcion,
            this.colidturno,
            this.colfml_code,
            this.colfml_version,
            this.collote,
            this.colorder_number,
            this.colorder_code,
            this.colcantidad_sacos_prd,
            this.colpresentacion,
            this.coltm});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.DisplayFormat.FormatString = "d";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            // 
            // colidturno
            // 
            this.colidturno.Caption = "Turno";
            this.colidturno.FieldName = "idturno";
            this.colidturno.Name = "colidturno";
            this.colidturno.Visible = true;
            this.colidturno.VisibleIndex = 3;
            // 
            // colfml_code
            // 
            this.colfml_code.Caption = "Formula";
            this.colfml_code.FieldName = "fml_code";
            this.colfml_code.Name = "colfml_code";
            this.colfml_code.Visible = true;
            this.colfml_code.VisibleIndex = 4;
            // 
            // colfml_version
            // 
            this.colfml_version.Caption = "Versión";
            this.colfml_version.FieldName = "fml_version";
            this.colfml_version.Name = "colfml_version";
            this.colfml_version.Visible = true;
            this.colfml_version.VisibleIndex = 5;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 6;
            // 
            // colorder_number
            // 
            this.colorder_number.Caption = "# Orden Prd.";
            this.colorder_number.FieldName = "order_number";
            this.colorder_number.Name = "colorder_number";
            this.colorder_number.Visible = true;
            this.colorder_number.VisibleIndex = 7;
            // 
            // colorder_code
            // 
            this.colorder_code.Caption = "Codigo Orden Prd";
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 8;
            // 
            // colcantidad_sacos_prd
            // 
            this.colcantidad_sacos_prd.Caption = "Cant. Sacos";
            this.colcantidad_sacos_prd.DisplayFormat.FormatString = "###,##0";
            this.colcantidad_sacos_prd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_sacos_prd.FieldName = "cantidad_sacos_prd";
            this.colcantidad_sacos_prd.Name = "colcantidad_sacos_prd";
            this.colcantidad_sacos_prd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_sacos_prd", "Sacos Total={0:###,##0}")});
            this.colcantidad_sacos_prd.Visible = true;
            this.colcantidad_sacos_prd.VisibleIndex = 9;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentación";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 10;
            // 
            // coltm
            // 
            this.coltm.Caption = "TM";
            this.coltm.DisplayFormat.FormatString = "###,##0.00";
            this.coltm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tm", "Total TM={0:###,##0.00}")});
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 11;
            // 
            // frmCuadroLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 561);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Name = "frmCuadroLotes";
            this.Text = "Cuadro de Lotes";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDashBoard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.LabelControl lblFechaHasta;
        private DevExpress.XtraEditors.LabelControl lblFechaDesde;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsDashBoard dsDashBoard1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidturno;
        private DevExpress.XtraGrid.Columns.GridColumn colfml_code;
        private DevExpress.XtraGrid.Columns.GridColumn colfml_version;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_number;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_code;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_sacos_prd;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
    }
}