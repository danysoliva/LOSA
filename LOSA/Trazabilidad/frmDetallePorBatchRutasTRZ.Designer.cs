
namespace LOSA.Trazabilidad
{
    partial class frmDetallePorBatchRutasTRZ
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
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesTRZ1 = new LOSA.Trazabilidad.ReportesTRZ.dsReportesTRZ();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLotePT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoteMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCódigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechayHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAplicadoKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTolvaCódigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesTRZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(1179, 1);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(173, 52);
            this.cmdHome.TabIndex = 34;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_batch_ruta_4";
            this.gridControl1.DataSource = this.dsReportesTRZ1;
            this.gridControl1.Location = new System.Drawing.Point(2, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1360, 676);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesTRZ1
            // 
            this.dsReportesTRZ1.DataSetName = "dsReportesTRZ";
            this.dsReportesTRZ1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLotePT,
            this.colLoteMP,
            this.colCódigo,
            this.colMaterial,
            this.colFechayHora,
            this.colPlanKg,
            this.colAplicadoKg,
            this.colTolvaCódigo,
            this.colFuente});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colLotePT
            // 
            this.colLotePT.FieldName = "Lote PT";
            this.colLotePT.Name = "colLotePT";
            this.colLotePT.OptionsColumn.AllowEdit = false;
            this.colLotePT.Visible = true;
            this.colLotePT.VisibleIndex = 0;
            this.colLotePT.Width = 48;
            // 
            // colLoteMP
            // 
            this.colLoteMP.FieldName = "Lote MP";
            this.colLoteMP.Name = "colLoteMP";
            this.colLoteMP.OptionsColumn.AllowEdit = false;
            this.colLoteMP.Visible = true;
            this.colLoteMP.VisibleIndex = 1;
            this.colLoteMP.Width = 90;
            // 
            // colCódigo
            // 
            this.colCódigo.FieldName = "Código";
            this.colCódigo.Name = "colCódigo";
            this.colCódigo.OptionsColumn.AllowEdit = false;
            this.colCódigo.Visible = true;
            this.colCódigo.VisibleIndex = 2;
            this.colCódigo.Width = 57;
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.OptionsColumn.AllowEdit = false;
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 3;
            this.colMaterial.Width = 124;
            // 
            // colFechayHora
            // 
            this.colFechayHora.DisplayFormat.FormatString = "g";
            this.colFechayHora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechayHora.FieldName = "Fecha y Hora";
            this.colFechayHora.Name = "colFechayHora";
            this.colFechayHora.OptionsColumn.AllowEdit = false;
            this.colFechayHora.Visible = true;
            this.colFechayHora.VisibleIndex = 4;
            this.colFechayHora.Width = 113;
            // 
            // colPlanKg
            // 
            this.colPlanKg.DisplayFormat.FormatString = "n2";
            this.colPlanKg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPlanKg.FieldName = "Plan Kg";
            this.colPlanKg.Name = "colPlanKg";
            this.colPlanKg.OptionsColumn.AllowEdit = false;
            this.colPlanKg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Plan Kg", "SUMA={0:n2}")});
            this.colPlanKg.Visible = true;
            this.colPlanKg.VisibleIndex = 5;
            this.colPlanKg.Width = 90;
            // 
            // colAplicadoKg
            // 
            this.colAplicadoKg.DisplayFormat.FormatString = "n2";
            this.colAplicadoKg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAplicadoKg.FieldName = "Aplicado Kg";
            this.colAplicadoKg.Name = "colAplicadoKg";
            this.colAplicadoKg.OptionsColumn.AllowEdit = false;
            this.colAplicadoKg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Aplicado Kg", "SUMA={0:n2}")});
            this.colAplicadoKg.Visible = true;
            this.colAplicadoKg.VisibleIndex = 6;
            this.colAplicadoKg.Width = 87;
            // 
            // colTolvaCódigo
            // 
            this.colTolvaCódigo.FieldName = "Tolva Código";
            this.colTolvaCódigo.Name = "colTolvaCódigo";
            this.colTolvaCódigo.OptionsColumn.AllowEdit = false;
            this.colTolvaCódigo.Visible = true;
            this.colTolvaCódigo.VisibleIndex = 7;
            this.colTolvaCódigo.Width = 48;
            // 
            // colFuente
            // 
            this.colFuente.FieldName = "Fuente";
            this.colFuente.Name = "colFuente";
            this.colFuente.OptionsColumn.AllowEdit = false;
            this.colFuente.Visible = true;
            this.colFuente.VisibleIndex = 8;
            this.colFuente.Width = 66;
            // 
            // cmdExportToExcel
            // 
            this.cmdExportToExcel.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdExportToExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportToExcel.Appearance.Options.UseBackColor = true;
            this.cmdExportToExcel.Appearance.Options.UseFont = true;
            this.cmdExportToExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportToExcel.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.cmdExportToExcel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmdExportToExcel.Location = new System.Drawing.Point(2, 2);
            this.cmdExportToExcel.Name = "cmdExportToExcel";
            this.cmdExportToExcel.Size = new System.Drawing.Size(179, 51);
            this.cmdExportToExcel.TabIndex = 36;
            this.cmdExportToExcel.Text = "Exportar a Excel";
            this.cmdExportToExcel.Click += new System.EventHandler(this.cmdExportToExcel_Click);
            // 
            // frmDetallePorBatchRutasTRZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.cmdExportToExcel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdHome);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmDetallePorBatchRutasTRZ";
            this.Text = "Detalle de Batch";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesTRZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ReportesTRZ.dsReportesTRZ dsReportesTRZ1;
        private DevExpress.XtraGrid.Columns.GridColumn colLotePT;
        private DevExpress.XtraGrid.Columns.GridColumn colLoteMP;
        private DevExpress.XtraGrid.Columns.GridColumn colCódigo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colFechayHora;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanKg;
        private DevExpress.XtraGrid.Columns.GridColumn colAplicadoKg;
        private DevExpress.XtraGrid.Columns.GridColumn colTolvaCódigo;
        private DevExpress.XtraGrid.Columns.GridColumn colFuente;
        private DevExpress.XtraEditors.SimpleButton cmdExportToExcel;
    }
}