namespace LOSA.Produccion
{
    partial class frmCantidadMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCantidadMP));
            this.gcMateriaPrima = new DevExpress.XtraGrid.GridControl();
            this.cantidadmateriaprimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogistica = new LOSA.Logistica.dsLogistica2();
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadmateriaprimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMateriaPrima
            // 
            this.gcMateriaPrima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMateriaPrima.DataSource = this.cantidadmateriaprimaBindingSource;
            this.gcMateriaPrima.Location = new System.Drawing.Point(0, 108);
            this.gcMateriaPrima.MainView = this.gvMateriaPrima;
            this.gcMateriaPrima.Name = "gcMateriaPrima";
            this.gcMateriaPrima.Size = new System.Drawing.Size(639, 452);
            this.gcMateriaPrima.TabIndex = 0;
            this.gcMateriaPrima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMateriaPrima});
            // 
            // cantidadmateriaprimaBindingSource
            // 
            this.cantidadmateriaprimaBindingSource.DataMember = "cantidad_materia_prima";
            this.cantidadmateriaprimaBindingSource.DataSource = this.dsLogistica;
            // 
            // dsLogistica
            // 
            this.dsLogistica.DataSetName = "dsLogistica2";
            this.dsLogistica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMateriaPrima.Appearance.Row.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.colitemdescrip,
            this.coltotal,
            this.colfila,
            this.coltipo,
            this.colpeso});
            this.gvMateriaPrima.GridControl = this.gcMateriaPrima;
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsView.ShowAutoFilterRow = true;
            this.gvMateriaPrima.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.Caption = "Materia Prima";
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.OptionsColumn.AllowEdit = false;
            this.colitemdescrip.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 1;
            this.colitemdescrip.Width = 192;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total Unidades";
            this.coltotal.DisplayFormat.FormatString = "###,##0.00";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 2;
            this.coltotal.Width = 195;
            // 
            // colfila
            // 
            this.colfila.Caption = "#";
            this.colfila.FieldName = "fila";
            this.colfila.Name = "colfila";
            this.colfila.OptionsColumn.AllowEdit = false;
            this.colfila.Visible = true;
            this.colfila.VisibleIndex = 0;
            this.colfila.Width = 42;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowEdit = false;
            this.coltipo.Width = 192;
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(23, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(156, 52);
            this.cmdHome.TabIndex = 28;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Total Kg";
            this.colpeso.DisplayFormat.FormatString = "###,##0.00";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 3;
            // 
            // frmCantidadMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.gcMateriaPrima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCantidadMP";
            this.Text = "frmCantidadMP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadmateriaprimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemdescrip;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private System.Windows.Forms.BindingSource cantidadmateriaprimaBindingSource;
        private Logistica.dsLogistica2 dsLogistica;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colfila;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
    }
}