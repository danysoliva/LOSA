
namespace LOSA.Calidad
{
    partial class frmSeguimientoAlimentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientoAlimentacion));
            this.btn_cerrar = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsCalidad = new LOSA.Calidad.dsCalidad();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarima_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.timertick = new System.Windows.Forms.Timer(this.components);
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnPrint = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_consumo = new DevExpress.XtraGrid.GridControl();
            this.grdv_consumo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnImprimirRPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnExporte = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            this.btnPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_consumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_consumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Appearance.Options.UseFont = true;
            this.btn_cerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.ImageOptions.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1169, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(106, 55);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "alimentacion";
            this.grd_data.DataSource = this.dsCalidad;
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(2, 23);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1276, 247);
            this.grd_data.TabIndex = 1;
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
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdv_data.Appearance.OddRow.Options.UseBackColor = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colfecha,
            this.colpeso,
            this.colcantidad,
            this.colcodigo,
            this.coltarima_codigo,
            this.collote});
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
            // coldescripcion
            // 
            this.coldescripcion.Caption = "MP";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            this.coldescripcion.Width = 273;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha ";
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            this.colfecha.Width = 186;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 5;
            this.colpeso.Width = 157;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Unidades";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 198;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 148;
            // 
            // coltarima_codigo
            // 
            this.coltarima_codigo.Caption = "TM";
            this.coltarima_codigo.FieldName = "tarima_codigo";
            this.coltarima_codigo.Name = "coltarima_codigo";
            this.coltarima_codigo.OptionsColumn.AllowEdit = false;
            this.coltarima_codigo.Visible = true;
            this.coltarima_codigo.VisibleIndex = 0;
            this.coltarima_codigo.Width = 87;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 2;
            this.collote.Width = 211;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(462, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(253, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Seguimiento de Alimentacion";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(172, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 55);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Seguimiento \r\ncola de lotes";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timertick
            // 
            this.timertick.Interval = 1000;
            this.timertick.Tick += new System.EventHandler(this.timertick_Tick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(12, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(138, 55);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Recargar";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 89);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btnPrint);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1280, 582);
            this.splitContainerControl1.SplitterPosition = 272;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.AppearanceCaption.Options.UseFont = true;
            this.btnPrint.Controls.Add(this.grd_data);
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(1280, 272);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Tarimas pendientes por consumir en el sistema";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grd_consumo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1280, 300);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Tarimas consumidas en el sistema";
            // 
            // grd_consumo
            // 
            this.grd_consumo.DataMember = "Consumido";
            this.grd_consumo.DataSource = this.dsCalidad;
            this.grd_consumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_consumo.Location = new System.Drawing.Point(2, 23);
            this.grd_consumo.MainView = this.grdv_consumo;
            this.grd_consumo.Name = "grd_consumo";
            this.grd_consumo.Size = new System.Drawing.Size(1276, 275);
            this.grd_consumo.TabIndex = 0;
            this.grd_consumo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_consumo});
            // 
            // grdv_consumo
            // 
            this.grdv_consumo.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_consumo.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_consumo.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_consumo.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_consumo.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_consumo.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_consumo.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_consumo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_consumo.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_consumo.Appearance.OddRow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdv_consumo.Appearance.OddRow.Options.UseBackColor = true;
            this.grdv_consumo.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.Preview.Options.UseFont = true;
            this.grdv_consumo.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.Row.Options.UseFont = true;
            this.grdv_consumo.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_consumo.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_consumo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.collote1,
            this.colfecha_entrega});
            this.grdv_consumo.GridControl = this.grd_consumo;
            this.grdv_consumo.Name = "grdv_consumo";
            this.grdv_consumo.OptionsView.ShowAutoFilterRow = true;
            this.grdv_consumo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MP";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 176;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha de Consumo";
            this.gridColumn3.DisplayFormat.FormatString = "g";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "fecha";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 171;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Peso";
            this.gridColumn4.FieldName = "peso";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 145;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Unidades";
            this.gridColumn5.FieldName = "cantidad";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 195;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Codigo";
            this.gridColumn6.FieldName = "codigo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 139;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "TM";
            this.gridColumn7.FieldName = "tarima_codigo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 82;
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote MP";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.OptionsColumn.AllowEdit = false;
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 2;
            this.collote1.Width = 201;
            // 
            // colfecha_entrega
            // 
            this.colfecha_entrega.Caption = "Fecha Entrega";
            this.colfecha_entrega.DisplayFormat.FormatString = "g";
            this.colfecha_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_entrega.FieldName = "fecha_entrega";
            this.colfecha_entrega.Name = "colfecha_entrega";
            this.colfecha_entrega.OptionsColumn.AllowEdit = false;
            this.colfecha_entrega.Visible = true;
            this.colfecha_entrega.VisibleIndex = 4;
            this.colfecha_entrega.Width = 151;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExporte);
            this.panelControl1.Controls.Add(this.btnImprimirRPT);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_cerrar);
            this.panelControl1.Controls.Add(this.btn_Refresh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1280, 91);
            this.panelControl1.TabIndex = 7;
            // 
            // btnImprimirRPT
            // 
            this.btnImprimirRPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirRPT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnImprimirRPT.Appearance.Options.UseFont = true;
            this.btnImprimirRPT.Appearance.Options.UseTextOptions = true;
            this.btnImprimirRPT.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnImprimirRPT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimirRPT.ImageOptions.SvgImage")));
            this.btnImprimirRPT.Location = new System.Drawing.Point(1035, 5);
            this.btnImprimirRPT.Name = "btnImprimirRPT";
            this.btnImprimirRPT.Size = new System.Drawing.Size(114, 55);
            this.btnImprimirRPT.TabIndex = 5;
            this.btnImprimirRPT.Text = "Imprimir Reporte";
            this.btnImprimirRPT.Click += new System.EventHandler(this.btnImprimirRPT_Click);
            // 
            // btnExporte
            // 
            this.btnExporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporte.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnExporte.Appearance.Options.UseFont = true;
            this.btnExporte.Appearance.Options.UseTextOptions = true;
            this.btnExporte.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExporte.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExporte.Location = new System.Drawing.Point(896, 5);
            this.btnExporte.Name = "btnExporte";
            this.btnExporte.Size = new System.Drawing.Size(114, 55);
            this.btnExporte.TabIndex = 6;
            this.btnExporte.Text = "Excel";
            this.btnExporte.Click += new System.EventHandler(this.btnExporte_Click);
            // 
            // frmSeguimientoAlimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 675);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSeguimientoAlimentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento de Alimentacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            this.btnPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_consumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_consumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_cerrar;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsCalidad dsCalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coltarima_codigo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Timer timertick;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl btnPrint;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grd_consumo;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_consumo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraEditors.SimpleButton btnImprimirRPT;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_entrega;
        private DevExpress.XtraEditors.SimpleButton btnExporte;
    }
}