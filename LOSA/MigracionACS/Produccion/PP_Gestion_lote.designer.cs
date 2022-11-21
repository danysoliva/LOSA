namespace LOSA.MigracionACS.Produccion
{
    partial class PP_Gestion_lote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Gestion_lote));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnReservarLote = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsLotes = new LOSA.MigracionACS.Produccion.dsLotes();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_fp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserReserv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserAsig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpp_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_reservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreservado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btncerrar,
            this.btnReservarLote,
            this.btnAgregar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btncerrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReservarLote),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAgregar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btncerrar
            // 
            this.btncerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btncerrar.Caption = "Cerrar";
            this.btncerrar.Id = 0;
            this.btncerrar.ImageOptions.Image = global::LOSA.Properties.Resources.exit_32x32;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
            // 
            // btnReservarLote
            // 
            this.btnReservarLote.Id = 1;
            this.btnReservarLote.Name = "btnReservarLote";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Caption = "Reservar Lotes";
            this.btnAgregar.Id = 2;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(937, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 642);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(937, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(937, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 602);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "gestionlotes";
            this.grd_data.DataSource = this.dsLotes;
            this.grd_data.Location = new System.Drawing.Point(0, 59);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(937, 580);
            this.grd_data.TabIndex = 4;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsLotes
            // 
            this.dsLotes.DataSetName = "dsLotes";
            this.dsLotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote_fp,
            this.colorder_id,
            this.colUserReserv,
            this.colUserAsig,
            this.colpp_code,
            this.colfecha_reservacion,
            this.colfecha_asignacion,
            this.colreservado});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_data_RowStyle);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // collote_fp
            // 
            this.collote_fp.Caption = "Lote";
            this.collote_fp.FieldName = "lote_fp";
            this.collote_fp.Name = "collote_fp";
            this.collote_fp.OptionsColumn.AllowEdit = false;
            this.collote_fp.Visible = true;
            this.collote_fp.VisibleIndex = 5;
            // 
            // colorder_id
            // 
            this.colorder_id.Caption = "N. orden";
            this.colorder_id.FieldName = "order_id";
            this.colorder_id.Name = "colorder_id";
            this.colorder_id.OptionsColumn.AllowEdit = false;
            this.colorder_id.Visible = true;
            this.colorder_id.VisibleIndex = 0;
            // 
            // colUserReserv
            // 
            this.colUserReserv.Caption = "U. Reservo el lote";
            this.colUserReserv.FieldName = "UserReserv";
            this.colUserReserv.Name = "colUserReserv";
            this.colUserReserv.OptionsColumn.AllowEdit = false;
            this.colUserReserv.Visible = true;
            this.colUserReserv.VisibleIndex = 2;
            // 
            // colUserAsig
            // 
            this.colUserAsig.Caption = "U. Agrego la orden";
            this.colUserAsig.FieldName = "UserAsig";
            this.colUserAsig.Name = "colUserAsig";
            this.colUserAsig.OptionsColumn.AllowEdit = false;
            this.colUserAsig.Visible = true;
            this.colUserAsig.VisibleIndex = 3;
            // 
            // colpp_code
            // 
            this.colpp_code.Caption = "C. Orden";
            this.colpp_code.FieldName = "pp_code";
            this.colpp_code.Name = "colpp_code";
            this.colpp_code.OptionsColumn.AllowEdit = false;
            this.colpp_code.Visible = true;
            this.colpp_code.VisibleIndex = 1;
            // 
            // colfecha_reservacion
            // 
            this.colfecha_reservacion.Caption = "F. Reservacion";
            this.colfecha_reservacion.FieldName = "fecha_reservacion";
            this.colfecha_reservacion.Name = "colfecha_reservacion";
            this.colfecha_reservacion.OptionsColumn.AllowEdit = false;
            this.colfecha_reservacion.Visible = true;
            this.colfecha_reservacion.VisibleIndex = 6;
            // 
            // colfecha_asignacion
            // 
            this.colfecha_asignacion.Caption = "F. Asignacion";
            this.colfecha_asignacion.FieldName = "fecha_asignacion";
            this.colfecha_asignacion.Name = "colfecha_asignacion";
            this.colfecha_asignacion.OptionsColumn.AllowEdit = false;
            this.colfecha_asignacion.Visible = true;
            this.colfecha_asignacion.VisibleIndex = 4;
            // 
            // colreservado
            // 
            this.colreservado.Caption = "Reservado";
            this.colreservado.FieldName = "reservado";
            this.colreservado.Name = "colreservado";
            this.colreservado.OptionsColumn.AllowEdit = false;
            this.colreservado.Visible = true;
            this.colreservado.VisibleIndex = 7;
            // 
            // PP_Gestion_lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 665);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PP_Gestion_lote";
            this.Text = "Gestion de lote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btncerrar;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraBars.BarButtonItem btnReservarLote;
        private DevExpress.XtraBars.BarButtonItem btnAgregar;
        private dsLotes dsLotes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote_fp;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_id;
        private DevExpress.XtraGrid.Columns.GridColumn colUserReserv;
        private DevExpress.XtraGrid.Columns.GridColumn colUserAsig;
        private DevExpress.XtraGrid.Columns.GridColumn colpp_code;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_reservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn colreservado;
    }
}