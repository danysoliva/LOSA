
namespace LOSA.MigracionACS.AquaForecast
{
    partial class AFC_ConsumoReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFC_ConsumoReal));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsAquaForecastReports1 = new MigracionACS.AquaForecast.dsAquaForecastReports();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rm_acs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditAnio = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAquaForecastReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "ConsumosReal";
            this.gridControl1.DataSource = this.dsAquaForecastReports1;
            this.gridControl1.Location = new System.Drawing.Point(1, 123);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(901, 502);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsAquaForecastReports1
            // 
            this.dsAquaForecastReports1.DataSetName = "dsAquaForecastReports";
            this.dsAquaForecastReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colyear,
            this.colmonth,
            this.colid_rm_acs,
            this.colnombre_comercial,
            this.coltipo,
            this.colname_tipo,
            this.coltm,
            this.colmes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colyear
            // 
            this.colyear.FieldName = "year";
            this.colyear.Name = "colyear";
            // 
            // colmonth
            // 
            this.colmonth.FieldName = "month";
            this.colmonth.Name = "colmonth";
            // 
            // colid_rm_acs
            // 
            this.colid_rm_acs.FieldName = "id_rm_acs";
            this.colid_rm_acs.Name = "colid_rm_acs";
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nombre_comercial", "Recuento {0}")});
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 0;
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            // 
            // colname_tipo
            // 
            this.colname_tipo.FieldName = "name_tipo";
            this.colname_tipo.Name = "colname_tipo";
            this.colname_tipo.OptionsColumn.AllowEdit = false;
            this.colname_tipo.Visible = true;
            this.colname_tipo.VisibleIndex = 1;
            // 
            // coltm
            // 
            this.coltm.DisplayFormat.FormatString = "n2";
            this.coltm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.OptionsColumn.AllowEdit = false;
            this.coltm.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tm", "SUM={0:n2} TM")});
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 2;
            // 
            // colmes
            // 
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.OptionsColumn.AllowEdit = false;
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(302, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(267, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Consumos Consola por Mes";
            // 
            // spinEditAnio
            // 
            this.spinEditAnio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditAnio.Location = new System.Drawing.Point(51, 91);
            this.spinEditAnio.Name = "spinEditAnio";
            this.spinEditAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.spinEditAnio.Properties.Appearance.Options.UseFont = true;
            this.spinEditAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAnio.Properties.IsFloatValue = false;
            this.spinEditAnio.Properties.Mask.EditMask = "N00";
            this.spinEditAnio.Size = new System.Drawing.Size(100, 24);
            this.spinEditAnio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Año";
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdCargarDatos.Appearance.Options.UseFont = true;
            this.cmdCargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargarDatos.ImageOptions.Image")));
            this.cmdCargarDatos.Location = new System.Drawing.Point(171, 70);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(109, 47);
            this.cmdCargarDatos.TabIndex = 4;
            this.cmdCargarDatos.Text = "Recargar";
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px1;
            this.cmdExcel.Location = new System.Drawing.Point(791, 70);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(109, 47);
            this.cmdExcel.TabIndex = 5;
            this.cmdExcel.Text = "Exportar";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // AFC_ConsumoReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 625);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinEditAnio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "AFC_ConsumoReal";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAquaForecastReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsAquaForecastReports dsAquaForecastReports1;
        private DevExpress.XtraGrid.Columns.GridColumn colyear;
        private DevExpress.XtraGrid.Columns.GridColumn colmonth;
        private DevExpress.XtraGrid.Columns.GridColumn colid_rm_acs;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colname_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditAnio;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
    }
}