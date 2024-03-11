
namespace LOSA.MigracionACS.Finanzas.Inventarios
{
    partial class frmReportManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportManager));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.grdSelectReport = new DevExpress.XtraEditors.GridLookUpEdit();
            this.reportmanagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRPT1 = new LOSA.MigracionACS.Finanzas.dSRPT();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_reporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdReporte = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl_barra = new System.Windows.Forms.Panel();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportmanagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.pnl_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Reportes:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGenerar.ImageOptions.SvgImage")));
            this.btnGenerar.Location = new System.Drawing.Point(401, 1);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 39);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(706, 9);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(111, 24);
            this.dtDesde.TabIndex = 10;
            this.dtDesde.Visible = false;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(892, 9);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(113, 24);
            this.dtHasta.TabIndex = 11;
            this.dtHasta.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(660, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 17);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Desde:";
            this.labelControl1.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(850, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 17);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Hasta:";
            this.labelControl3.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(534, 1);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(114, 39);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // grdSelectReport
            // 
            this.grdSelectReport.Location = new System.Drawing.Point(104, 9);
            this.grdSelectReport.Name = "grdSelectReport";
            this.grdSelectReport.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdSelectReport.Properties.Appearance.Options.UseFont = true;
            this.grdSelectReport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdSelectReport.Properties.DataSource = this.reportmanagerBindingSource;
            this.grdSelectReport.Properties.DisplayMember = "descripcion";
            this.grdSelectReport.Properties.NullText = "";
            this.grdSelectReport.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdSelectReport.Properties.ValueMember = "id_reporte";
            this.grdSelectReport.Size = new System.Drawing.Size(291, 24);
            this.grdSelectReport.TabIndex = 15;
            this.grdSelectReport.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // reportmanagerBindingSource
            // 
            this.reportmanagerBindingSource.DataMember = "report_manager";
            this.reportmanagerBindingSource.DataSource = this.dSRPTBindingSource;
            // 
            // dSRPTBindingSource
            // 
            this.dSRPTBindingSource.DataSource = this.dSRPT1;
            this.dSRPTBindingSource.Position = 0;
            // 
            // dSRPT1
            // 
            this.dSRPT1.DataSetName = "dSRPT";
            this.dSRPT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_reporte,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_reporte
            // 
            this.colid_reporte.FieldName = "id_reporte";
            this.colid_reporte.Name = "colid_reporte";
            this.colid_reporte.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Reporte";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // grdReporte
            // 
            this.grdReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReporte.Location = new System.Drawing.Point(2, 86);
            this.grdReporte.MainView = this.grdv_data;
            this.grdReporte.Name = "grdReporte";
            this.grdReporte.Size = new System.Drawing.Size(1188, 422);
            this.grdReporte.TabIndex = 16;
            this.grdReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.GridControl = this.grdReporte;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            // 
            // pnl_barra
            // 
            this.pnl_barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_barra.Controls.Add(this.marqueeProgressBarControl1);
            this.pnl_barra.Location = new System.Drawing.Point(2, 66);
            this.pnl_barra.Name = "pnl_barra";
            this.pnl_barra.Size = new System.Drawing.Size(1188, 14);
            this.pnl_barra.TabIndex = 23;
            this.pnl_barra.Visible = false;
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(0, 0);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = 20;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(1188, 14);
            this.marqueeProgressBarControl1.TabIndex = 10;
            // 
            // frmReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 509);
            this.Controls.Add(this.pnl_barra);
            this.Controls.Add(this.grdReporte);
            this.Controls.Add(this.grdSelectReport);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.labelControl2);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmReportManager.IconOptions.Image")));
            this.Name = "frmReportManager";
            this.Text = "Report Manager SAP";
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportmanagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.pnl_barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.GridLookUpEdit grdSelectReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource reportmanagerBindingSource;
        private System.Windows.Forms.BindingSource dSRPTBindingSource;
        private dSRPT dSRPT1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_reporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.GridControl grdReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.Panel pnl_barra;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
    }
}