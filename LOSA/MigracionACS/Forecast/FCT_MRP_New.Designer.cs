namespace ACS.Forecast
{
    partial class FCT_MRP_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCT_MRP_New));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Accept = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grp_Nombre = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grd_disponibles = new DevExpress.XtraGrid.GridControl();
            this.grdv_disponibles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grd_seleccionadas = new DevExpress.XtraGrid.GridControl();
            this.grdv_seleccionadas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ids = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_usuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Nombre)).BeginInit();
            this.grp_Nombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_seleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seleccionadas)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Accept,
            this.btn_Cancel});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Accept),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Cancel)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btn_Accept
            // 
            this.btn_Accept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Accept.Caption = "Aceptar";
            this.btn_Accept.Id = 0;
            this.btn_Accept.ImageOptions.Image = global::LOSA.Properties.Resources.Accept_32x32;
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Accept_ItemClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Cancel.Caption = "Cancelar";
            this.btn_Cancel.Id = 1;
            this.btn_Cancel.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(498, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 504);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(498, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 457);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(498, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 457);
            // 
            // grp_Nombre
            // 
            this.grp_Nombre.Controls.Add(this.comboBox1);
            this.grp_Nombre.Controls.Add(this.labelControl1);
            this.grp_Nombre.Controls.Add(this.txt_name);
            this.grp_Nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Nombre.Location = new System.Drawing.Point(0, 47);
            this.grp_Nombre.Name = "grp_Nombre";
            this.grp_Nombre.Size = new System.Drawing.Size(498, 78);
            this.grp_Nombre.TabIndex = 4;
            this.grp_Nombre.Text = "Descripción del MRP";
            this.grp_Nombre.Paint += new System.Windows.Forms.PaintEventHandler(this.grp_Nombre_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBox1.Location = new System.Drawing.Point(102, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl1.Location = new System.Drawing.Point(13, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Año de aplicación";
            // 
            // txt_name
            // 
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_name.Location = new System.Drawing.Point(2, 20);
            this.txt_name.MenuManager = this.barManager1;
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Properties.MaxLength = 80;
            this.txt_name.Size = new System.Drawing.Size(494, 22);
            this.txt_name.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grd_disponibles);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 125);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(498, 205);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Proyecciones Activas";
            // 
            // grd_disponibles
            // 
            this.grd_disponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_disponibles.Location = new System.Drawing.Point(2, 20);
            this.grd_disponibles.MainView = this.grdv_disponibles;
            this.grd_disponibles.MenuManager = this.barManager1;
            this.grd_disponibles.Name = "grd_disponibles";
            this.grd_disponibles.Size = new System.Drawing.Size(494, 183);
            this.grd_disponibles.TabIndex = 0;
            this.grd_disponibles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_disponibles});
            // 
            // grdv_disponibles
            // 
            this.grdv_disponibles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_codigo,
            this.col_nombre,
            this.col_usuario});
            this.grdv_disponibles.GridControl = this.grd_disponibles;
            this.grdv_disponibles.Name = "grdv_disponibles";
            this.grdv_disponibles.OptionsBehavior.Editable = false;
            this.grdv_disponibles.OptionsCustomization.AllowGroup = false;
            this.grdv_disponibles.OptionsView.ShowAutoFilterRow = true;
            this.grdv_disponibles.OptionsView.ShowGroupPanel = false;
            this.grdv_disponibles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_disponibles_FocusedRowChanged);
            this.grdv_disponibles.DoubleClick += new System.EventHandler(this.grdv_disponibles_DoubleClick);
            // 
            // col_id
            // 
            this.col_id.Caption = "Id";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_codigo
            // 
            this.col_codigo.Caption = "Código";
            this.col_codigo.FieldName = "codigo";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.OptionsColumn.AllowEdit = false;
            this.col_codigo.Visible = true;
            this.col_codigo.VisibleIndex = 0;
            this.col_codigo.Width = 79;
            // 
            // col_nombre
            // 
            this.col_nombre.Caption = "Proyección";
            this.col_nombre.FieldName = "nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.Visible = true;
            this.col_nombre.VisibleIndex = 1;
            this.col_nombre.Width = 240;
            // 
            // col_usuario
            // 
            this.col_usuario.Caption = "Creada Por";
            this.col_usuario.FieldName = "usuario";
            this.col_usuario.Name = "col_usuario";
            this.col_usuario.Visible = true;
            this.col_usuario.VisibleIndex = 2;
            this.col_usuario.Width = 159;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grd_seleccionadas);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 330);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(498, 174);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Proyecciones Seleccionadas";
            // 
            // grd_seleccionadas
            // 
            this.grd_seleccionadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_seleccionadas.Location = new System.Drawing.Point(2, 20);
            this.grd_seleccionadas.MainView = this.grdv_seleccionadas;
            this.grd_seleccionadas.MenuManager = this.barManager1;
            this.grd_seleccionadas.Name = "grd_seleccionadas";
            this.grd_seleccionadas.Size = new System.Drawing.Size(494, 152);
            this.grd_seleccionadas.TabIndex = 0;
            this.grd_seleccionadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_seleccionadas});
            // 
            // grdv_seleccionadas
            // 
            this.grdv_seleccionadas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ids,
            this.col_codigos,
            this.col_nombres,
            this.col_usuarios});
            this.grdv_seleccionadas.GridControl = this.grd_seleccionadas;
            this.grdv_seleccionadas.Name = "grdv_seleccionadas";
            this.grdv_seleccionadas.OptionsBehavior.Editable = false;
            this.grdv_seleccionadas.OptionsCustomization.AllowGroup = false;
            this.grdv_seleccionadas.OptionsView.ShowAutoFilterRow = true;
            this.grdv_seleccionadas.OptionsView.ShowGroupPanel = false;
            this.grdv_seleccionadas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_seleccionadas_FocusedRowChanged);
            // 
            // col_ids
            // 
            this.col_ids.Caption = "id";
            this.col_ids.FieldName = "id";
            this.col_ids.Name = "col_ids";
            // 
            // col_codigos
            // 
            this.col_codigos.Caption = "Código";
            this.col_codigos.FieldName = "codigo";
            this.col_codigos.Name = "col_codigos";
            this.col_codigos.OptionsColumn.AllowEdit = false;
            this.col_codigos.Visible = true;
            this.col_codigos.VisibleIndex = 0;
            this.col_codigos.Width = 81;
            // 
            // col_nombres
            // 
            this.col_nombres.Caption = "Proyección";
            this.col_nombres.FieldName = "nombre";
            this.col_nombres.Name = "col_nombres";
            this.col_nombres.Visible = true;
            this.col_nombres.VisibleIndex = 1;
            this.col_nombres.Width = 240;
            // 
            // col_usuarios
            // 
            this.col_usuarios.Caption = "Creada Por";
            this.col_usuarios.FieldName = "usuario";
            this.col_usuarios.Name = "col_usuarios";
            this.col_usuarios.Visible = true;
            this.col_usuarios.VisibleIndex = 2;
            this.col_usuarios.Width = 157;
            // 
            // FCT_MRP_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 504);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grp_Nombre);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCT_MRP_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo MRP";
            this.Load += new System.EventHandler(this.FCT_MRP_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Nombre)).EndInit();
            this.grp_Nombre.ResumeLayout(false);
            this.grp_Nombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_seleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seleccionadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Accept;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grd_seleccionadas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_seleccionadas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grd_disponibles;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_disponibles;
        private DevExpress.XtraEditors.GroupControl grp_Nombre;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn col_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_ids;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombres;
        private DevExpress.XtraGrid.Columns.GridColumn col_usuarios;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigos;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}