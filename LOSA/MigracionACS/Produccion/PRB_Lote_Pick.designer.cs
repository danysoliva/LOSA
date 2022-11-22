namespace LOSA.MigracionACS.Produccion
{
    partial class PRB_Lote_Pick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRB_Lote_Pick));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnactualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnselec = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnpick = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pRB_DATA2 = new LOSA.MigracionACS.DataSetx.PRB_DATA();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfp_lot_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_number = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnpick)).BeginInit();
            this.pnpick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRB_DATA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btncerrar,
            this.btnactualizar,
            this.btnselec});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btncerrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnactualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnselec)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btncerrar
            // 
            this.btncerrar.Caption = "Cerrar";
            this.btncerrar.Id = 0;
            this.btncerrar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel2_32;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Caption = "Actualizar";
            this.btnactualizar.Id = 1;
            this.btnactualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.ImageOptions.Image")));
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnactualizar_ItemClick);
            // 
            // btnselec
            // 
            this.btnselec.Caption = "Seleccionar";
            this.btnselec.Id = 2;
            this.btnselec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnselec.ImageOptions.Image")));
            this.btnselec.Name = "btnselec";
            this.btnselec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnselec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnselec_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(565, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 574);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(565, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 534);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(565, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 534);
            // 
            // pnpick
            // 
            this.pnpick.Controls.Add(this.gridControl1);
            this.pnpick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnpick.Location = new System.Drawing.Point(0, 40);
            this.pnpick.Name = "pnpick";
            this.pnpick.Size = new System.Drawing.Size(565, 534);
            this.pnpick.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "loadlot";
            this.gridControl1.DataSource = this.pRB_DATA2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(561, 530);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pRB_DATA2
            // 
            this.pRB_DATA2.DataSetName = "PRB_DATA2";
            this.pRB_DATA2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfp_lot_number,
            this.colDescripcion,
            this.colDataColumn2,
            this.colorder_number});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colfp_lot_number
            // 
            this.colfp_lot_number.Caption = "Lote #";
            this.colfp_lot_number.FieldName = "fp_lot_number";
            this.colfp_lot_number.Name = "colfp_lot_number";
            this.colfp_lot_number.OptionsColumn.AllowEdit = false;
            this.colfp_lot_number.Visible = true;
            this.colfp_lot_number.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colDataColumn2
            // 
            this.colDataColumn2.Caption = "Codigo";
            this.colDataColumn2.FieldName = "Codigo";
            this.colDataColumn2.Name = "colDataColumn2";
            this.colDataColumn2.OptionsColumn.AllowEdit = false;
            this.colDataColumn2.Visible = true;
            this.colDataColumn2.VisibleIndex = 2;
            // 
            // colorder_number
            // 
            this.colorder_number.Caption = "# Orden";
            this.colorder_number.FieldName = "order_number";
            this.colorder_number.Name = "colorder_number";
            this.colorder_number.Visible = true;
            this.colorder_number.VisibleIndex = 3;
            // 
            // PRB_Lote_Pick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 574);
            this.Controls.Add(this.pnpick);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRB_Lote_Pick";
            this.Text = "Elige un lote..";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnpick)).EndInit();
            this.pnpick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRB_DATA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btncerrar;
        private DevExpress.XtraBars.BarButtonItem btnactualizar;
        private DevExpress.XtraBars.BarButtonItem btnselec;
        private DevExpress.XtraEditors.PanelControl pnpick;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DataSetx.PRB_DATA pRB_DATA2;
        private DevExpress.XtraGrid.Columns.GridColumn colfp_lot_number;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDataColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_number;
    }
}