
namespace ACS.Ttracer.Reportes
{
    partial class frmDetalleDesechos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleDesechos));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesTtrace1 = new ACS.Ttracer.Reportes.dsReportesTtrace();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_total_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesTtrace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "rpt_desechos";
            this.gridControl1.DataSource = this.dsReportesTtrace1;
            this.gridControl1.Location = new System.Drawing.Point(1, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(817, 521);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesTtrace1
            // 
            this.dsReportesTtrace1.DataSetName = "dsReportesTtrace";
            this.dsReportesTtrace1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.colitemdescrip,
            this.colnmes,
            this.colmes,
            this.colpeso_total_kg,
            this.colanio});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 73;
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.OptionsColumn.AllowEdit = false;
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 1;
            this.colitemdescrip.Width = 210;
            // 
            // colnmes
            // 
            this.colnmes.FieldName = "nmes";
            this.colnmes.Name = "colnmes";
            this.colnmes.OptionsColumn.AllowEdit = false;
            this.colnmes.Visible = true;
            this.colnmes.VisibleIndex = 2;
            this.colnmes.Width = 83;
            // 
            // colmes
            // 
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.OptionsColumn.AllowEdit = false;
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 3;
            this.colmes.Width = 141;
            // 
            // colpeso_total_kg
            // 
            this.colpeso_total_kg.FieldName = "peso_total_kg";
            this.colpeso_total_kg.Name = "colpeso_total_kg";
            this.colpeso_total_kg.OptionsColumn.AllowEdit = false;
            this.colpeso_total_kg.Visible = true;
            this.colpeso_total_kg.VisibleIndex = 5;
            this.colpeso_total_kg.Width = 151;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = new System.DateTime(((long)(0)));
            this.dtHasta.Location = new System.Drawing.Point(325, 64);
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
            this.dtDesde.EditValue = new System.DateTime(((long)(0)));
            this.dtDesde.Location = new System.Drawing.Point(92, 64);
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
            this.cmdExportar.Location = new System.Drawing.Point(602, 51);
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
            this.CargarDatos.Location = new System.Drawing.Point(459, 51);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 12;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(246, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Fecha Desde:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(163, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(494, 32);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Resumen de Salida de Desechos por categoría";
            // 
            // colanio
            // 
            this.colanio.Caption = "Year";
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.OptionsColumn.AllowEdit = false;
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 4;
            this.colanio.Width = 141;
            // 
            // frmDetalleDesechos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 621);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleDesechos";
            this.Text = "Detalle Desechos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesTtrace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dsReportesTtrace dsReportesTtrace1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemdescrip;
        private DevExpress.XtraGrid.Columns.GridColumn colnmes;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_total_kg;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
    }
}