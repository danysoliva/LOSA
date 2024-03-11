namespace LOSA.MigracionACS.SAR
{
    partial class SAR_detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_detalle));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.grd_detalle = new DevExpress.XtraGrid.GridControl();
            this.grdv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnclose,
            this.btncerrar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btncerrar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 628);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 578);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 578);
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 0;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // grd_detalle
            // 
            this.grd_detalle.DataMember = "plantilla";
            this.grd_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_detalle.Location = new System.Drawing.Point(0, 50);
            this.grd_detalle.MainView = this.grdv_detalle;
            this.grd_detalle.MenuManager = this.barManager1;
            this.grd_detalle.Name = "grd_detalle";
            this.grd_detalle.Size = new System.Drawing.Size(800, 578);
            this.grd_detalle.TabIndex = 4;
            this.grd_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_detalle});
            // 
            // grdv_detalle
            // 
            this.grdv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colRubro,
            this.colMonto});
            this.grdv_detalle.GridControl = this.grd_detalle;
            this.grdv_detalle.Name = "grdv_detalle";
            this.grdv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.grdv_detalle.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 178;
            // 
            // colRubro
            // 
            this.colRubro.FieldName = "Rubro";
            this.colRubro.Name = "colRubro";
            this.colRubro.OptionsColumn.AllowEdit = false;
            this.colRubro.Visible = true;
            this.colRubro.VisibleIndex = 1;
            this.colRubro.Width = 301;
            // 
            // colMonto
            // 
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.OptionsColumn.AllowEdit = false;
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 2;
            this.colMonto.Width = 301;
            // 
            // btncerrar
            // 
            this.btncerrar.Caption = "barButtonItem1";
            this.btncerrar.Id = 1;
            this.btncerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.ImageOptions.Image")));
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
            this.btncerrar.ItemDoubleClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemDoubleClick);
            // 
            // SAR_detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.grd_detalle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SAR_detalle";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraGrid.GridControl grd_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraBars.BarButtonItem btncerrar;
    }
}