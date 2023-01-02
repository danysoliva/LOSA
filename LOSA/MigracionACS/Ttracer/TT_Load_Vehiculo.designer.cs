namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_Load_Vehiculo
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_Load_Vehiculo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grd_vehi = new DevExpress.XtraGrid.GridControl();
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.grdv_vehi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidvehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnseleccion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colposibleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSeleccionar = new DevExpress.XtraBars.BarButtonItem();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.btnrecargar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_vehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_vehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grd_vehi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 387);
            this.panelControl1.TabIndex = 0;
            // 
            // grd_vehi
            // 
            this.grd_vehi.DataMember = "seleccionvehi";
            this.grd_vehi.DataSource = this.dSTtracer;
            this.grd_vehi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_vehi.Location = new System.Drawing.Point(2, 2);
            this.grd_vehi.MainView = this.grdv_vehi;
            this.grd_vehi.MenuManager = this.barManager1;
            this.grd_vehi.Name = "grd_vehi";
            this.grd_vehi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnseleccion});
            this.grd_vehi.Size = new System.Drawing.Size(796, 383);
            this.grd_vehi.TabIndex = 0;
            this.grd_vehi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_vehi});
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_vehi
            // 
            this.grdv_vehi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colidvehiculo,
            this.colFurgon,
            this.colplaca,
            this.colenable,
            this.colseleccionar,
            this.colposibleId});
            this.grdv_vehi.GridControl = this.grd_vehi;
            this.grdv_vehi.Name = "grdv_vehi";
            this.grdv_vehi.OptionsView.ShowAutoFilterRow = true;
            this.grdv_vehi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdv_vehi_RowClick);
            this.grdv_vehi.DoubleClick += new System.EventHandler(this.grdv_vehi_DoubleClick);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colidvehiculo
            // 
            this.colidvehiculo.Caption = "ID Vehiculo";
            this.colidvehiculo.FieldName = "idvehiculo";
            this.colidvehiculo.Name = "colidvehiculo";
            this.colidvehiculo.OptionsColumn.AllowEdit = false;
            this.colidvehiculo.Visible = true;
            this.colidvehiculo.VisibleIndex = 1;
            // 
            // colFurgon
            // 
            this.colFurgon.FieldName = "Furgon";
            this.colFurgon.Name = "colFurgon";
            this.colFurgon.OptionsColumn.AllowEdit = false;
            this.colFurgon.Visible = true;
            this.colFurgon.VisibleIndex = 2;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "Placa";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.AllowEdit = false;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 3;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.ColumnEdit = this.btnseleccion;
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 4;
            // 
            // btnseleccion
            // 
            this.btnseleccion.AutoHeight = false;
            editorButtonImageOptions4.Image = global::LOSA.Properties.Resources.Accept_24x24;
            this.btnseleccion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // colposibleId
            // 
            this.colposibleId.FieldName = "posibleId";
            this.colposibleId.Name = "colposibleId";
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
            this.btnSeleccionar,
            this.btnclose,
            this.btnrecargar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeleccionar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnrecargar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Caption = "Seleccionar";
            this.btnSeleccionar.Id = 0;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeleccionar_ItemClick);
            // 
            // btnclose
            // 
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 1;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Name = "btnclose";
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // btnrecargar
            // 
            this.btnrecargar.Caption = "Recargar";
            this.btnrecargar.Id = 2;
            this.btnrecargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrecargar.ImageOptions.Image")));
            this.btnrecargar.Name = "btnrecargar";
            this.btnrecargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrecargar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 387);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 387);
            // 
            // TT_Load_Vehiculo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "TT_Load_Vehiculo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Buscar Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_vehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_vehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSeleccionar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraBars.BarButtonItem btnrecargar;
        private DevExpress.XtraGrid.GridControl grd_vehi;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_vehi;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colidvehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colFurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnseleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colposibleId;
    }
}