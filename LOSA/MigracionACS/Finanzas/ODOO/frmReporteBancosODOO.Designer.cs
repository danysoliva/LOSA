
namespace LOSA.MigracionACS.Finanzas.ODOO
{
    partial class frmReporteBancosODOO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteBancosODOO));
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.drReportesODOO_RRHH1 = new LOSA.MigracionACS.Finanzas.ODOO.drReportesODOO_RRHH();
            this.colfecha_desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregla_salarial_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drReportesODOO_RRHH1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(369, 36);
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
            this.dtHasta.TabIndex = 86;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(369, 8);
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
            this.dtDesde.TabIndex = 85;
            // 
            // CargarDatos
            // 
            this.CargarDatos.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CargarDatos.Appearance.Options.UseBackColor = true;
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(503, 8);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 54);
            this.CargarDatos.TabIndex = 84;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(286, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 83;
            this.labelControl3.Text = "Fecha Hasta:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(286, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 82;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(3, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(254, 34);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "Deducción total por Banco";
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmdExportToExcel.Appearance.Options.UseBackColor = true;
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportToExcel.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px;
            this.cmdExportToExcel.Location = new System.Drawing.Point(646, 8);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(137, 54);
            this.cmdExportToExcel.TabIndex = 88;
            this.cmdExportToExcel.Text = "Exportar";
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_bancos";
            this.gridControl1.DataSource = this.drReportesODOO_RRHH1;
            this.gridControl1.Location = new System.Drawing.Point(3, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(791, 380);
            this.gridControl1.TabIndex = 89;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha_desde,
            this.colfecha_hasta,
            this.colregla_salarial_nombre,
            this.coltotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // drReportesODOO_RRHH1
            // 
            this.drReportesODOO_RRHH1.DataSetName = "drReportesODOO_RRHH";
            this.drReportesODOO_RRHH1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colfecha_desde
            // 
            this.colfecha_desde.DisplayFormat.FormatString = "d";
            this.colfecha_desde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_desde.FieldName = "fecha_desde";
            this.colfecha_desde.Name = "colfecha_desde";
            this.colfecha_desde.OptionsColumn.ReadOnly = true;
            this.colfecha_desde.Visible = true;
            this.colfecha_desde.VisibleIndex = 0;
            // 
            // colfecha_hasta
            // 
            this.colfecha_hasta.DisplayFormat.FormatString = "d";
            this.colfecha_hasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_hasta.FieldName = "fecha_hasta";
            this.colfecha_hasta.Name = "colfecha_hasta";
            this.colfecha_hasta.OptionsColumn.ReadOnly = true;
            this.colfecha_hasta.Visible = true;
            this.colfecha_hasta.VisibleIndex = 1;
            // 
            // colregla_salarial_nombre
            // 
            this.colregla_salarial_nombre.FieldName = "regla_salarial_nombre";
            this.colregla_salarial_nombre.Name = "colregla_salarial_nombre";
            this.colregla_salarial_nombre.OptionsColumn.ReadOnly = true;
            this.colregla_salarial_nombre.Visible = true;
            this.colregla_salarial_nombre.VisibleIndex = 2;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            // 
            // frmReporteBancosODOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Name = "frmReporteBancosODOO";
            this.ShowIcon = false;
            this.Text = "Reporte de Bancos Planillas";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drReportesODOO_RRHH1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private drReportesODOO_RRHH drReportesODOO_RRHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_desde;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hasta;
        private DevExpress.XtraGrid.Columns.GridColumn colregla_salarial_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
    }
}