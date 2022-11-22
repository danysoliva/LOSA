
namespace LOSA.MigracionACS.Produccion.Consumos
{
    partial class frmsearchOrder
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colline_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfp_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsIntakeReportsPRD1 = new LOSA.MigracionACS.Produccion.Consumos.dsIntakeReportsPRD();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntakeReportsPRD1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "busqueda";
            this.gridControl1.DataSource = this.dsIntakeReportsPRD1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(772, 358);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId,
            this.colOrderNumber,
            this.colOrderCode,
            this.colline_id,
            this.colLine,
            this.colLot,
            this.colfp_id,
            this.colProduct,
            this.colFormula,
            this.colVersion,
            this.colPlanBatch,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colOrderId
            // 
            this.colOrderId.FieldName = "Order Id";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.OptionsColumn.AllowEdit = false;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.FieldName = "Order Number";
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.OptionsColumn.AllowEdit = false;
            this.colOrderNumber.Visible = true;
            this.colOrderNumber.VisibleIndex = 0;
            this.colOrderNumber.Width = 83;
            // 
            // colOrderCode
            // 
            this.colOrderCode.FieldName = "Order Code";
            this.colOrderCode.Name = "colOrderCode";
            this.colOrderCode.OptionsColumn.AllowEdit = false;
            this.colOrderCode.Visible = true;
            this.colOrderCode.VisibleIndex = 1;
            this.colOrderCode.Width = 89;
            // 
            // colline_id
            // 
            this.colline_id.FieldName = "line_id";
            this.colline_id.Name = "colline_id";
            this.colline_id.OptionsColumn.AllowEdit = false;
            // 
            // colLine
            // 
            this.colLine.FieldName = "Line";
            this.colLine.Name = "colLine";
            this.colLine.OptionsColumn.AllowEdit = false;
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 2;
            this.colLine.Width = 61;
            // 
            // colLot
            // 
            this.colLot.FieldName = "Lot";
            this.colLot.Name = "colLot";
            this.colLot.OptionsColumn.AllowEdit = false;
            this.colLot.Visible = true;
            this.colLot.VisibleIndex = 3;
            this.colLot.Width = 61;
            // 
            // colfp_id
            // 
            this.colfp_id.FieldName = "fp_id";
            this.colfp_id.Name = "colfp_id";
            this.colfp_id.OptionsColumn.AllowEdit = false;
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.OptionsColumn.AllowEdit = false;
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 4;
            this.colProduct.Width = 111;
            // 
            // colFormula
            // 
            this.colFormula.FieldName = "Formula";
            this.colFormula.Name = "colFormula";
            this.colFormula.OptionsColumn.AllowEdit = false;
            this.colFormula.Visible = true;
            this.colFormula.VisibleIndex = 5;
            this.colFormula.Width = 83;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.OptionsColumn.AllowEdit = false;
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 6;
            this.colVersion.Width = 53;
            // 
            // colPlanBatch
            // 
            this.colPlanBatch.FieldName = "Plan Batch";
            this.colPlanBatch.Name = "colPlanBatch";
            this.colPlanBatch.OptionsColumn.AllowEdit = false;
            this.colPlanBatch.Visible = true;
            this.colPlanBatch.VisibleIndex = 7;
            this.colPlanBatch.Width = 96;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 8;
            this.colStatus.Width = 117;
            // 
            // dsIntakeReportsPRD1
            // 
            this.dsIntakeReportsPRD1.DataSetName = "dsIntakeReportsPRD";
            this.dsIntakeReportsPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmsearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 358);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmsearchOrder";
            this.Text = "Seleccione una Orden";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntakeReportsPRD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //private dsIntakeView dsIntakeView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn colline_id;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colLot;
        private DevExpress.XtraGrid.Columns.GridColumn colfp_id;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanBatch;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private LOSA.MigracionACS.Produccion.Consumos.dsIntakeReportsPRD dsIntakeReportsPRD1;
    }
}