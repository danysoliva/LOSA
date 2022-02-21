
namespace LOSA.Calidad
{
    partial class frmSeguimientoDespachos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientoDespachos));
            this.btn_cerrar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rdEspecie = new DevExpress.XtraEditors.RadioGroup();
            this.btnGen = new DevExpress.XtraEditors.SimpleButton();
            this.dthasta = new DevExpress.XtraEditors.DateEdit();
            this.dtdesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsCalidad = new LOSA.Calidad.dsCalidad();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempresatrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colabierto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdEspecie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Appearance.Options.UseFont = true;
            this.btn_cerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.ImageOptions.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1149, 27);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(106, 99);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.btn_cerrar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1260, 127);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Parametros de reporte";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.rdEspecie);
            this.panelControl1.Controls.Add(this.btnGen);
            this.panelControl1.Controls.Add(this.dthasta);
            this.panelControl1.Controls.Add(this.dtdesde);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1141, 101);
            this.panelControl1.TabIndex = 2;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(858, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(131, 75);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(360, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 17);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Seleccion de Especie:";
            // 
            // rdEspecie
            // 
            this.rdEspecie.EditValue = 1;
            this.rdEspecie.Location = new System.Drawing.Point(360, 50);
            this.rdEspecie.Name = "rdEspecie";
            this.rdEspecie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEspecie.Properties.Appearance.Options.UseFont = true;
            this.rdEspecie.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Todas", true, 1),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tilapia", true, 2),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Camaron", true, 3)});
            this.rdEspecie.Size = new System.Drawing.Size(263, 31);
            this.rdEspecie.TabIndex = 5;
            this.rdEspecie.Tag = "1";
            this.rdEspecie.SelectedIndexChanged += new System.EventHandler(this.rdEspecie_SelectedIndexChanged);
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGen.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Appearance.Options.UseFont = true;
            this.btnGen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGen.ImageOptions.Image")));
            this.btnGen.Location = new System.Drawing.Point(995, 15);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(131, 75);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generar";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // dthasta
            // 
            this.dthasta.EditValue = null;
            this.dthasta.Location = new System.Drawing.Point(94, 61);
            this.dthasta.Name = "dthasta";
            this.dthasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dthasta.Properties.Appearance.Options.UseFont = true;
            this.dthasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dthasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dthasta.Size = new System.Drawing.Size(251, 24);
            this.dthasta.TabIndex = 3;
            this.dthasta.EditValueChanged += new System.EventHandler(this.dthasta_EditValueChanged);
            // 
            // dtdesde
            // 
            this.dtdesde.EditValue = null;
            this.dtdesde.Location = new System.Drawing.Point(94, 15);
            this.dtdesde.Name = "dtdesde";
            this.dtdesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdesde.Properties.Appearance.Options.UseFont = true;
            this.dtdesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdesde.Size = new System.Drawing.Size(251, 24);
            this.dtdesde.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha desde:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1260, 679);
            this.splitContainerControl1.SplitterPosition = 127;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.grd_data);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1260, 547);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Revision de Report";
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "despachoView";
            this.grd_data.DataSource = this.dsCalidad;
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(2, 24);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1256, 521);
            this.grd_data.TabIndex = 0;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsCalidad
            // 
            this.dsCalidad.DataSetName = "dsCalidad";
            this.dsCalidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDespacho,
            this.colfecha_creacion,
            this.colcardname,
            this.colcarcode,
            this.colvehiculo,
            this.colfurgon,
            this.colcomentarios,
            this.colempresatrans,
            this.colid_destino,
            this.colcodigo,
            this.colnombre,
            this.coldireccion1,
            this.colciudad,
            this.colpais,
            this.colabierto});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colDespacho
            // 
            this.colDespacho.Caption = "Despacho";
            this.colDespacho.FieldName = "Despacho";
            this.colDespacho.Name = "colDespacho";
            this.colDespacho.OptionsColumn.AllowEdit = false;
            this.colDespacho.Visible = true;
            this.colDespacho.VisibleIndex = 0;
            this.colDespacho.Width = 88;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha Despacho";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.AllowEdit = false;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 1;
            this.colfecha_creacion.Width = 121;
            // 
            // colcardname
            // 
            this.colcardname.Caption = "Socio";
            this.colcardname.FieldName = "cardname";
            this.colcardname.Name = "colcardname";
            this.colcardname.OptionsColumn.AllowEdit = false;
            this.colcardname.Visible = true;
            this.colcardname.VisibleIndex = 2;
            this.colcardname.Width = 184;
            // 
            // colcarcode
            // 
            this.colcarcode.FieldName = "carcode";
            this.colcarcode.Name = "colcarcode";
            this.colcarcode.OptionsColumn.AllowEdit = false;
            // 
            // colvehiculo
            // 
            this.colvehiculo.Caption = "Placa";
            this.colvehiculo.FieldName = "vehiculo";
            this.colvehiculo.Name = "colvehiculo";
            this.colvehiculo.OptionsColumn.AllowEdit = false;
            this.colvehiculo.Visible = true;
            this.colvehiculo.VisibleIndex = 3;
            this.colvehiculo.Width = 69;
            // 
            // colfurgon
            // 
            this.colfurgon.Caption = "Furgon";
            this.colfurgon.FieldName = "furgon";
            this.colfurgon.Name = "colfurgon";
            this.colfurgon.OptionsColumn.AllowEdit = false;
            this.colfurgon.Visible = true;
            this.colfurgon.VisibleIndex = 4;
            this.colfurgon.Width = 94;
            // 
            // colcomentarios
            // 
            this.colcomentarios.Caption = "Boleta Coments";
            this.colcomentarios.FieldName = "comentarios";
            this.colcomentarios.Name = "colcomentarios";
            this.colcomentarios.OptionsColumn.AllowEdit = false;
            this.colcomentarios.Visible = true;
            this.colcomentarios.VisibleIndex = 5;
            this.colcomentarios.Width = 159;
            // 
            // colempresatrans
            // 
            this.colempresatrans.Caption = "Transporte";
            this.colempresatrans.FieldName = "empresatrans";
            this.colempresatrans.Name = "colempresatrans";
            this.colempresatrans.OptionsColumn.AllowEdit = false;
            this.colempresatrans.Visible = true;
            this.colempresatrans.VisibleIndex = 6;
            this.colempresatrans.Width = 134;
            // 
            // colid_destino
            // 
            this.colid_destino.FieldName = "id_destino";
            this.colid_destino.Name = "colid_destino";
            this.colid_destino.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 7;
            this.colcodigo.Width = 72;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 8;
            this.colnombre.Width = 123;
            // 
            // coldireccion1
            // 
            this.coldireccion1.Caption = "Direccion";
            this.coldireccion1.FieldName = "direccion1";
            this.coldireccion1.Name = "coldireccion1";
            this.coldireccion1.OptionsColumn.AllowEdit = false;
            this.coldireccion1.Visible = true;
            this.coldireccion1.VisibleIndex = 9;
            this.coldireccion1.Width = 82;
            // 
            // colciudad
            // 
            this.colciudad.Caption = "Ciudad";
            this.colciudad.FieldName = "ciudad";
            this.colciudad.Name = "colciudad";
            this.colciudad.OptionsColumn.AllowEdit = false;
            this.colciudad.Visible = true;
            this.colciudad.VisibleIndex = 10;
            this.colciudad.Width = 73;
            // 
            // colpais
            // 
            this.colpais.Caption = "Pais";
            this.colpais.FieldName = "pais";
            this.colpais.Name = "colpais";
            this.colpais.OptionsColumn.AllowEdit = false;
            this.colpais.Visible = true;
            this.colpais.VisibleIndex = 11;
            this.colpais.Width = 41;
            // 
            // colabierto
            // 
            this.colabierto.FieldName = "abierto";
            this.colabierto.Name = "colabierto";
            this.colabierto.OptionsColumn.AllowEdit = false;
            // 
            // frmSeguimientoDespachos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 679);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSeguimientoDespachos";
            this.Text = "Seguimiento Despachos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdEspecie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_cerrar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.RadioGroup rdEspecie;
        private DevExpress.XtraEditors.SimpleButton btnGen;
        private DevExpress.XtraEditors.DateEdit dthasta;
        private DevExpress.XtraEditors.DateEdit dtdesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private dsCalidad dsCalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcardname;
        private DevExpress.XtraGrid.Columns.GridColumn colcarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colvehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colfurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colempresatrans;
        private DevExpress.XtraGrid.Columns.GridColumn colid_destino;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colciudad;
        private DevExpress.XtraGrid.Columns.GridColumn colpais;
        private DevExpress.XtraGrid.Columns.GridColumn colabierto;
    }
}