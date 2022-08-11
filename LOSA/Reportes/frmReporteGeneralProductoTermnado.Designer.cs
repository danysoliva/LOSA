
namespace LOSA.Reportes
{
    partial class frmReporteGeneralProductoTermnado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneralProductoTermnado));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grd_inventario_camaron = new DevExpress.XtraGrid.GridControl();
            this.dsReportesInventario1 = new LOSA.Reportes.dsReportesInventario();
            this.grdv_inventario_camaron = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkilogramos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grd_inventario_Tilapia = new DevExpress.XtraGrid.GridControl();
            this.grdv_inventario_Tilapia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAjuste = new DevExpress.XtraEditors.SimpleButton();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkilogramos1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_Tilapia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_Tilapia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1223, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.tabPane1);
            this.panelControl2.Location = new System.Drawing.Point(5, 70);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1323, 597);
            this.panelControl2.TabIndex = 4;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabPane1.Location = new System.Drawing.Point(2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1319, 593);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1319, 593);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Camaron";
            this.tabNavigationPage1.Controls.Add(this.grd_inventario_camaron);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1319, 547);
            // 
            // grd_inventario_camaron
            // 
            this.grd_inventario_camaron.DataMember = "inventario_kardex";
            this.grd_inventario_camaron.DataSource = this.dsReportesInventario1;
            this.grd_inventario_camaron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_inventario_camaron.Location = new System.Drawing.Point(0, 0);
            this.grd_inventario_camaron.MainView = this.grdv_inventario_camaron;
            this.grd_inventario_camaron.Name = "grd_inventario_camaron";
            this.grd_inventario_camaron.Size = new System.Drawing.Size(1319, 547);
            this.grd_inventario_camaron.TabIndex = 0;
            this.grd_inventario_camaron.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_camaron});
            // 
            // dsReportesInventario1
            // 
            this.dsReportesInventario1.DataSetName = "dsReportesInventario";
            this.dsReportesInventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_inventario_camaron
            // 
            this.grdv_inventario_camaron.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario_camaron.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario_camaron.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario_camaron.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt,
            this.colcode_sap,
            this.colProducto,
            this.collote_pt,
            this.colexistencia,
            this.colkilogramos,
            this.coltm});
            this.grdv_inventario_camaron.GridControl = this.grd_inventario_camaron;
            this.grdv_inventario_camaron.Name = "grdv_inventario_camaron";
            this.grdv_inventario_camaron.OptionsView.ShowAutoFilterRow = true;
            this.grdv_inventario_camaron.OptionsView.ShowGroupPanel = false;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Cod. SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "N Producto";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "Lote";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 2;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Unidades";
            this.colexistencia.DisplayFormat.FormatString = "{0:0.##.##} Ud";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 3;
            // 
            // colkilogramos
            // 
            this.colkilogramos.Caption = "Kilogramos";
            this.colkilogramos.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colkilogramos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkilogramos.FieldName = "kilogramos";
            this.colkilogramos.Name = "colkilogramos";
            this.colkilogramos.OptionsColumn.AllowEdit = false;
            this.colkilogramos.Visible = true;
            this.colkilogramos.VisibleIndex = 4;
            // 
            // coltm
            // 
            this.coltm.Caption = "Toneladas";
            this.coltm.DisplayFormat.FormatString = "{0:0.##.##} TM";
            this.coltm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltm.FieldName = "tm";
            this.coltm.Name = "coltm";
            this.coltm.OptionsColumn.AllowEdit = false;
            this.coltm.Visible = true;
            this.coltm.VisibleIndex = 5;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Tilapia";
            this.tabNavigationPage2.Controls.Add(this.grd_inventario_Tilapia);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabNavigationPage2.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1319, 547);
            // 
            // grd_inventario_Tilapia
            // 
            this.grd_inventario_Tilapia.DataMember = "inventario_kardex";
            this.grd_inventario_Tilapia.DataSource = this.dsReportesInventario1;
            this.grd_inventario_Tilapia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_inventario_Tilapia.Location = new System.Drawing.Point(0, 0);
            this.grd_inventario_Tilapia.MainView = this.grdv_inventario_Tilapia;
            this.grd_inventario_Tilapia.Name = "grd_inventario_Tilapia";
            this.grd_inventario_Tilapia.Size = new System.Drawing.Size(1319, 547);
            this.grd_inventario_Tilapia.TabIndex = 0;
            this.grd_inventario_Tilapia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_Tilapia});
            // 
            // grdv_inventario_Tilapia
            // 
            this.grdv_inventario_Tilapia.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_inventario_Tilapia.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_Tilapia.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario_Tilapia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colcode_sap1,
            this.colProducto1,
            this.collote_pt1,
            this.colexistencia1,
            this.colkilogramos1,
            this.coltm1});
            this.grdv_inventario_Tilapia.GridControl = this.grd_inventario_Tilapia;
            this.grdv_inventario_Tilapia.Name = "grdv_inventario_Tilapia";
            this.grdv_inventario_Tilapia.OptionsView.ShowAutoFilterRow = true;
            this.grdv_inventario_Tilapia.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1093, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 47);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdAjuste
            // 
            this.cmdAjuste.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjuste.Appearance.Options.UseFont = true;
            this.cmdAjuste.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAjuste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAjuste.ImageOptions.Image")));
            this.cmdAjuste.Location = new System.Drawing.Point(12, 8);
            this.cmdAjuste.Name = "cmdAjuste";
            this.cmdAjuste.Size = new System.Drawing.Size(172, 47);
            this.cmdAjuste.TabIndex = 6;
            this.cmdAjuste.Text = "Ajuste de Inventario";
            this.cmdAjuste.Click += new System.EventHandler(this.cmdAjuste_Click);
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // colcode_sap1
            // 
            this.colcode_sap1.Caption = "Cod. SAP";
            this.colcode_sap1.FieldName = "code_sap";
            this.colcode_sap1.Name = "colcode_sap1";
            this.colcode_sap1.Visible = true;
            this.colcode_sap1.VisibleIndex = 0;
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "N Producto";
            this.colProducto1.FieldName = "Producto";
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 1;
            // 
            // collote_pt1
            // 
            this.collote_pt1.Caption = "Lote";
            this.collote_pt1.FieldName = "lote_pt";
            this.collote_pt1.Name = "collote_pt1";
            this.collote_pt1.Visible = true;
            this.collote_pt1.VisibleIndex = 2;
            // 
            // colexistencia1
            // 
            this.colexistencia1.Caption = "Unidades";
            this.colexistencia1.FieldName = "existencia";
            this.colexistencia1.Name = "colexistencia1";
            this.colexistencia1.Visible = true;
            this.colexistencia1.VisibleIndex = 3;
            // 
            // colkilogramos1
            // 
            this.colkilogramos1.Caption = "Kilogramos";
            this.colkilogramos1.FieldName = "kilogramos";
            this.colkilogramos1.Name = "colkilogramos1";
            this.colkilogramos1.Visible = true;
            this.colkilogramos1.VisibleIndex = 4;
            // 
            // coltm1
            // 
            this.coltm1.Caption = "Toneladas";
            this.coltm1.FieldName = "tm";
            this.coltm1.Name = "coltm1";
            this.coltm1.Visible = true;
            this.coltm1.VisibleIndex = 5;
            // 
            // frmReporteGeneralProductoTermnado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 670);
            this.Controls.Add(this.cmdAjuste);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReporteGeneralProductoTermnado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General de Producto Terminado.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_Tilapia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_Tilapia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl grd_inventario_camaron;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_camaron;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl grd_inventario_Tilapia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_Tilapia;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cmdAjuste;
        private dsReportesInventario dsReportesInventario1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colkilogramos;
        private DevExpress.XtraGrid.Columns.GridColumn coltm;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia1;
        private DevExpress.XtraGrid.Columns.GridColumn colkilogramos1;
        private DevExpress.XtraGrid.Columns.GridColumn coltm1;
    }
}