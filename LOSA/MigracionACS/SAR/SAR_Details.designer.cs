namespace LOSA.MigracionACS.SAR
{
    partial class SAR_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_Details));
            this.pnmail = new DevExpress.XtraEditors.PanelControl();
            this.grd_detalle = new DevExpress.XtraGrid.GridControl();
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDscription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colocExo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoCapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnexcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnmail)).BeginInit();
            this.pnmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnmail
            // 
            this.pnmail.Controls.Add(this.grd_detalle);
            this.pnmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmail.Location = new System.Drawing.Point(0, 50);
            this.pnmail.Name = "pnmail";
            this.pnmail.Size = new System.Drawing.Size(1807, 823);
            this.pnmail.TabIndex = 0;
            // 
            // grd_detalle
            // 
            this.grd_detalle.DataMember = "detalle";
            this.grd_detalle.DataSource = this.dS_SAR;
            this.grd_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_detalle.Location = new System.Drawing.Point(2, 2);
            this.grd_detalle.MainView = this.grdv_detalle;
            this.grd_detalle.MenuManager = this.barManager1;
            this.grd_detalle.Name = "grd_detalle";
            this.grd_detalle.Size = new System.Drawing.Size(1803, 819);
            this.grd_detalle.TabIndex = 0;
            this.grd_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_detalle});
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_detalle
            // 
            this.grdv_detalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_detalle.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.Row.Options.UseFont = true;
            this.grdv_detalle.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_detalle.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNum,
            this.colLineTotal,
            this.colCardCode,
            this.colCardName,
            this.colDscription,
            this.colItemCode,
            this.colDocDate,
            this.colocExo,
            this.colcapitulo,
            this.colCodigoCapitulo,
            this.colNRubro,
            this.colRubro});
            this.grdv_detalle.GridControl = this.grd_detalle;
            this.grdv_detalle.Name = "grdv_detalle";
            this.grdv_detalle.OptionsBehavior.Editable = false;
            this.grdv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.grdv_detalle.OptionsView.ShowFooter = true;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "Numero de OC de SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 110;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Caption = "Total";
            this.colLineTotal.FieldName = "LineTotal";
            this.colLineTotal.Name = "colLineTotal";
            this.colLineTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LineTotal", "SUMA={0:#.##}")});
            this.colLineTotal.Visible = true;
            this.colLineTotal.VisibleIndex = 9;
            this.colLineTotal.Width = 173;
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Proveedor";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 2;
            this.colCardName.Width = 305;
            // 
            // colDscription
            // 
            this.colDscription.Caption = "Articulo";
            this.colDscription.FieldName = "Dscription";
            this.colDscription.Name = "colDscription";
            this.colDscription.Visible = true;
            this.colDscription.VisibleIndex = 3;
            this.colDscription.Width = 284;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Fecha ";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 8;
            this.colDocDate.Width = 113;
            // 
            // colocExo
            // 
            this.colocExo.Caption = "OC Exoneracion";
            this.colocExo.FieldName = "ocExo";
            this.colocExo.Name = "colocExo";
            this.colocExo.Visible = true;
            this.colocExo.VisibleIndex = 1;
            this.colocExo.Width = 145;
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 7;
            this.colcapitulo.Width = 203;
            // 
            // colCodigoCapitulo
            // 
            this.colCodigoCapitulo.Caption = "Cod. Capitulo";
            this.colCodigoCapitulo.FieldName = "CodigoCapitulo";
            this.colCodigoCapitulo.Name = "colCodigoCapitulo";
            this.colCodigoCapitulo.Visible = true;
            this.colCodigoCapitulo.VisibleIndex = 6;
            this.colCodigoCapitulo.Width = 87;
            // 
            // colNRubro
            // 
            this.colNRubro.Caption = "Cod. Rubro";
            this.colNRubro.FieldName = "NRubro";
            this.colNRubro.Name = "colNRubro";
            this.colNRubro.Visible = true;
            this.colNRubro.VisibleIndex = 4;
            this.colNRubro.Width = 62;
            // 
            // colRubro
            // 
            this.colRubro.FieldName = "Rubro";
            this.colRubro.Name = "colRubro";
            this.colRubro.Visible = true;
            this.colRubro.VisibleIndex = 5;
            this.colRubro.Width = 301;
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
            this.btncerrar,
            this.btnexcel});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btncerrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexcel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btncerrar
            // 
            this.btncerrar.Caption = "Cerrar";
            this.btncerrar.Id = 0;
            this.btncerrar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
            // 
            // btnexcel
            // 
            this.btnexcel.Caption = "Exportar a excel";
            this.btnexcel.Id = 1;
            this.btnexcel.ImageOptions.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1807, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 873);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1807, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 823);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1807, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 823);
            // 
            // SAR_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 873);
            this.Controls.Add(this.pnmail);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SAR_Details";
            this.Text = "Detalle de orden de compra...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnmail)).EndInit();
            this.pnmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnmail;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btncerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grd_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_detalle;
        private dS_SAR dS_SAR;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDscription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraBars.BarButtonItem btnexcel;
        private DevExpress.XtraGrid.Columns.GridColumn colocExo;
        private DevExpress.XtraGrid.Columns.GridColumn colcapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoCapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colRubro;
    }
}