
namespace LOSA.ACS.RRHH.Informes
{
    partial class frmHomePrintVoucherPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePrintVoucherPlanilla));
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceHeader = new System.Windows.Forms.BindingSource(this.components);
            this.dsNominasVoucher1 = new LOSA.ACS.RRHH.Informes.dsNominasVoucher();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdPrintALL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNominasVoucher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(174, 58);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.bindingSourceHeader;
            this.gridLookUpEdit1.Properties.DisplayMember = "Titulo";
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ValueMember = "id";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(563, 46);
            this.gridLookUpEdit1.TabIndex = 0;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // bindingSourceHeader
            // 
            this.bindingSourceHeader.DataMember = "header_planilla";
            this.bindingSourceHeader.DataSource = this.dsNominasVoucher1;
            // 
            // dsNominasVoucher1
            // 
            this.dsNominasVoucher1.DataSetName = "dsNominasVoucher";
            this.dsNominasVoucher1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colEmpresa,
            this.colFecha,
            this.colTitulo,
            this.colfecha_desde,
            this.colfecha_hasta,
            this.colenable});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colTitulo
            // 
            this.colTitulo.FieldName = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.Visible = true;
            this.colTitulo.VisibleIndex = 0;
            // 
            // colfecha_desde
            // 
            this.colfecha_desde.FieldName = "fecha_desde";
            this.colfecha_desde.Name = "colfecha_desde";
            // 
            // colfecha_hasta
            // 
            this.colfecha_hasta.FieldName = "fecha_hasta";
            this.colfecha_hasta.Name = "colfecha_hasta";
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nómina:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 119);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1671, 953);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // cmdPrintALL
            // 
            this.cmdPrintALL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintALL.ImageOptions.Image")));
            this.cmdPrintALL.Location = new System.Drawing.Point(1427, 26);
            this.cmdPrintALL.Name = "cmdPrintALL";
            this.cmdPrintALL.Size = new System.Drawing.Size(246, 79);
            this.cmdPrintALL.TabIndex = 3;
            this.cmdPrintALL.Text = "Imprimir Todos";
            this.cmdPrintALL.Click += new System.EventHandler(this.cmdPrintALL_Click);
            // 
            // frmHomePrintVoucherPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 1084);
            this.Controls.Add(this.cmdPrintALL);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Name = "frmHomePrintVoucherPlanilla";
            this.Text = "Home Print Vouchers";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNominasVoucher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsNominasVoucher dsNominasVoucher1;
        private System.Windows.Forms.BindingSource bindingSourceHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_desde;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hasta;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdPrintALL;
    }
}