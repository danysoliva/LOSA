using LOSA.FromAMS;

namespace AMS.Compras.ControlInv
{
    partial class frmOP_req
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP_req));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.btncerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnguardar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtsolicitud = new DevExpress.XtraEditors.DateEdit();
            this.txtcodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtsolicitanteManual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grd_usuarios = new DevExpress.XtraEditors.GridLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsControlInv_AMS1 = new LOSA.FromAMS.dsControlInv_AMS();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtcomentario = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chManual = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblenable = new DevExpress.XtraEditors.LabelControl();
            this.tggenable = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colborrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_eliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregarItem = new DevExpress.XtraEditors.SimpleButton();
            this.tggcontratista = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardarPoder = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrarPoder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsolicitanteManual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_usuarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsControlInv_AMS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chManual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggcontratista.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btncerrar,
            this.btnguardar});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // btncerrar
            // 
            this.btncerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btncerrar.Caption = "Cerrar";
            this.btncerrar.Id = 0;
            this.btncerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.ImageOptions.Image")));
            this.btncerrar.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ItemAppearance.Normal.Options.UseFont = true;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btncerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncerrar_ItemClick);
            // 
            // btnguardar
            // 
            this.btnguardar.Caption = "Guardar";
            this.btnguardar.Id = 1;
            this.btnguardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.ImageOptions.Image")));
            this.btnguardar.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnguardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnguardar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1325, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 672);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1325, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 672);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1325, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 672);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1325, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Operaciones de Requisas";
            // 
            // dtsolicitud
            // 
            this.dtsolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtsolicitud.EditValue = null;
            this.dtsolicitud.Location = new System.Drawing.Point(923, 110);
            this.dtsolicitud.MenuManager = this.barManager1;
            this.dtsolicitud.Name = "dtsolicitud";
            this.dtsolicitud.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsolicitud.Properties.Appearance.Options.UseFont = true;
            this.dtsolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtsolicitud.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtsolicitud.Size = new System.Drawing.Size(292, 28);
            this.dtsolicitud.TabIndex = 5;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(144, 105);
            this.txtcodigo.MenuManager = this.barManager1;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Properties.Appearance.Options.UseFont = true;
            this.txtcodigo.Size = new System.Drawing.Size(265, 28);
            this.txtcodigo.TabIndex = 6;
            // 
            // txtsolicitanteManual
            // 
            this.txtsolicitanteManual.Location = new System.Drawing.Point(144, 175);
            this.txtsolicitanteManual.MenuManager = this.barManager1;
            this.txtsolicitanteManual.Name = "txtsolicitanteManual";
            this.txtsolicitanteManual.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolicitanteManual.Properties.Appearance.Options.UseFont = true;
            this.txtsolicitanteManual.Properties.MaxLength = 150;
            this.txtsolicitanteManual.Size = new System.Drawing.Size(404, 28);
            this.txtsolicitanteManual.TabIndex = 7;
            this.txtsolicitanteManual.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(76, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 21);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Codigo:";
            // 
            // grd_usuarios
            // 
            this.grd_usuarios.Location = new System.Drawing.Point(144, 175);
            this.grd_usuarios.MenuManager = this.barManager1;
            this.grd_usuarios.Name = "grd_usuarios";
            this.grd_usuarios.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_usuarios.Properties.Appearance.Options.UseFont = true;
            this.grd_usuarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_usuarios.Properties.DataSource = this.usuarioBindingSource;
            this.grd_usuarios.Properties.DisplayMember = "user";
            this.grd_usuarios.Properties.PopupView = this.gridLookUpEdit1View;
            this.grd_usuarios.Properties.ValueMember = "id";
            this.grd_usuarios.Size = new System.Drawing.Size(404, 28);
            this.grd_usuarios.TabIndex = 9;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dsControlInv_AMS1;
            // 
            // dsControlInv_AMS1
            // 
            this.dsControlInv_AMS1.DataSetName = "dsControlInv_AMS";
            this.dsControlInv_AMS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.Empty.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.FilterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.FooterPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.Preview.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.TopNewRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coluser});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coluser
            // 
            this.coluser.Caption = "Usuario";
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 0;
            // 
            // txtcomentario
            // 
            this.txtcomentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtcomentario.Location = new System.Drawing.Point(116, 583);
            this.txtcomentario.MenuManager = this.barManager1;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomentario.Properties.Appearance.Options.UseFont = true;
            this.txtcomentario.Properties.MaxLength = 200;
            this.txtcomentario.Size = new System.Drawing.Size(1209, 80);
            this.txtcomentario.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 21);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Solicitante:";
            // 
            // chManual
            // 
            this.chManual.Location = new System.Drawing.Point(570, 176);
            this.chManual.MenuManager = this.barManager1;
            this.chManual.Name = "chManual";
            this.chManual.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chManual.Properties.Appearance.Options.UseFont = true;
            this.chManual.Properties.Caption = "No esta en la lista?";
            this.chManual.Size = new System.Drawing.Size(217, 25);
            this.chManual.TabIndex = 12;
            this.chManual.CheckedChanged += new System.EventHandler(this.chManual_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(825, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 21);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "F. Solicitud:";
            // 
            // lblenable
            // 
            this.lblenable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblenable.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenable.Appearance.Options.UseFont = true;
            this.lblenable.Location = new System.Drawing.Point(825, 150);
            this.lblenable.Name = "lblenable";
            this.lblenable.Size = new System.Drawing.Size(74, 21);
            this.lblenable.TabIndex = 14;
            this.lblenable.Text = "Habilitado:";
            this.lblenable.Visible = false;
            // 
            // tggenable
            // 
            this.tggenable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggenable.Location = new System.Drawing.Point(923, 145);
            this.tggenable.MenuManager = this.barManager1;
            this.tggenable.Name = "tggenable";
            this.tggenable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggenable.Properties.Appearance.Options.UseFont = true;
            this.tggenable.Properties.OffText = "No";
            this.tggenable.Properties.OnText = "Si";
            this.tggenable.Size = new System.Drawing.Size(241, 26);
            this.tggenable.TabIndex = 15;
            this.tggenable.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 583);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 21);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Comentario:";
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "req_detalle";
            this.grd_data.DataSource = this.dsControlInv_AMS1;
            this.grd_data.Location = new System.Drawing.Point(2, 270);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_eliminar});
            this.grd_data.Size = new System.Drawing.Size(1323, 287);
            this.grd_data.TabIndex = 17;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            this.grd_data.Click += new System.EventHandler(this.grd_data_Click);
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colitemcode,
            this.colitemname,
            this.colcantidad,
            this.colactivo,
            this.colborrar,
            this.colexistencia});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdv_data_RowStyle);
            this.grdv_data.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grdv_data_ShowingEditor);
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Item Code";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.OptionsFilter.AllowFilter = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // colitemname
            // 
            this.colitemname.Caption = "Articulo";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MaxWidth = 129;
            this.colcantidad.MinWidth = 129;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsFilter.AllowFilter = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "Total={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 129;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "activo", "Total={0:0.##}")});
            // 
            // colborrar
            // 
            this.colborrar.Caption = "Borrar";
            this.colborrar.ColumnEdit = this.btn_eliminar;
            this.colborrar.MaxWidth = 129;
            this.colborrar.MinWidth = 129;
            this.colborrar.Name = "colborrar";
            this.colborrar.OptionsFilter.AllowFilter = false;
            this.colborrar.Visible = true;
            this.colborrar.VisibleIndex = 4;
            this.colborrar.Width = 129;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btn_eliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.DisplayFormat.FormatString = "{0:N2}";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.MaxWidth = 129;
            this.colexistencia.MinWidth = 129;
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.OptionsFilter.AllowFilter = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 2;
            this.colexistencia.Width = 129;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Appearance.Options.UseFont = true;
            this.btnAgregarItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregarItem.ImageOptions.SvgImage")));
            this.btnAgregarItem.Location = new System.Drawing.Point(2, 224);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(187, 40);
            this.btnAgregarItem.TabIndex = 22;
            this.btnAgregarItem.Text = "Agregar Repuestos";
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // tggcontratista
            // 
            this.tggcontratista.Location = new System.Drawing.Point(144, 136);
            this.tggcontratista.MenuManager = this.barManager1;
            this.tggcontratista.Name = "tggcontratista";
            this.tggcontratista.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggcontratista.Properties.Appearance.Options.UseFont = true;
            this.tggcontratista.Properties.OffText = "No";
            this.tggcontratista.Properties.OnText = "Si";
            this.tggcontratista.Size = new System.Drawing.Size(241, 26);
            this.tggcontratista.TabIndex = 27;
            this.tggcontratista.Toggled += new System.EventHandler(this.tggcontratista_Toggled);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(50, 141);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 21);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Contratista:";
            // 
            // cmdGuardarPoder
            // 
            this.cmdGuardarPoder.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarPoder.Appearance.Options.UseFont = true;
            this.cmdGuardarPoder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.cmdGuardarPoder.Location = new System.Drawing.Point(2, 12);
            this.cmdGuardarPoder.Name = "cmdGuardarPoder";
            this.cmdGuardarPoder.Size = new System.Drawing.Size(187, 40);
            this.cmdGuardarPoder.TabIndex = 33;
            this.cmdGuardarPoder.Text = "Guardar";
            this.cmdGuardarPoder.Click += new System.EventHandler(this.cmdGuardarPoder_Click);
            // 
            // cmdCerrarPoder
            // 
            this.cmdCerrarPoder.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrarPoder.Appearance.Options.UseFont = true;
            this.cmdCerrarPoder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.cmdCerrarPoder.Location = new System.Drawing.Point(1138, 12);
            this.cmdCerrarPoder.Name = "cmdCerrarPoder";
            this.cmdCerrarPoder.Size = new System.Drawing.Size(187, 40);
            this.cmdCerrarPoder.TabIndex = 34;
            this.cmdCerrarPoder.Text = "Cerrar";
            this.cmdCerrarPoder.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmOP_req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 692);
            this.Controls.Add(this.cmdCerrarPoder);
            this.Controls.Add(this.cmdGuardarPoder);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tggcontratista);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tggenable);
            this.Controls.Add(this.lblenable);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chManual);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtsolicitanteManual);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.dtsolicitud);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_usuarios);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmOP_req.IconOptions.Icon")));
            this.Name = "frmOP_req";
            this.Text = "Requisas";
            this.Load += new System.EventHandler(this.frmOP_req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsolicitanteManual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_usuarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsControlInv_AMS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chManual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggcontratista.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btncerrar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtsolicitud;
        private DevExpress.XtraEditors.TextEdit txtcodigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtsolicitanteManual;
        private DevExpress.XtraEditors.GridLookUpEdit grd_usuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.MemoEdit txtcomentario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chManual;
        private DevExpress.XtraEditors.LabelControl lblenable;
        private DevExpress.XtraEditors.ToggleSwitch tggenable;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private dsControlInv_AMS dsControlInv_AMS1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
        private DevExpress.XtraEditors.SimpleButton btnAgregarItem;
        private DevExpress.XtraBars.BarButtonItem btnguardar;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colborrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_eliminar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ToggleSwitch tggcontratista;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarPoder;
        private DevExpress.XtraEditors.SimpleButton cmdCerrarPoder;
    }
}