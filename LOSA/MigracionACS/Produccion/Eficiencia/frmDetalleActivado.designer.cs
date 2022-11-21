
namespace LOSA.MigracionACS.Produccion.Eficiencia

{
    partial class frmDetalleActivado
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleActivado));
            this.grdv_detalleTm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidtm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_prb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_detalle = new DevExpress.XtraGrid.GridControl();
            this.dsLotePick = new LOSA.MigracionACS.Produccion.Eficiencia.dsLotePick();
            this.grdv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatefinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtlote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tggPendientes = new DevExpress.XtraEditors.ToggleSwitch();
            this.btncerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalleTm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotePick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggPendientes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdv_detalleTm
            // 
            this.grdv_detalleTm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidtm,
            this.colproducto1,
            this.collote1,
            this.colcantidad2,
            this.colpeso1,
            this.colcodigo_barra1,
            this.colid_prb});
            this.grdv_detalleTm.GridControl = this.grd_detalle;
            this.grdv_detalleTm.Name = "grdv_detalleTm";
            this.grdv_detalleTm.OptionsView.ShowAutoFilterRow = true;
            this.grdv_detalleTm.OptionsView.ShowFooter = true;
            this.grdv_detalleTm.OptionsView.ShowGroupPanel = false;
            // 
            // colidtm
            // 
            this.colidtm.FieldName = "idtm";
            this.colidtm.Name = "colidtm";
            this.colidtm.OptionsColumn.AllowEdit = false;
            // 
            // colproducto1
            // 
            this.colproducto1.Caption = "Producto";
            this.colproducto1.FieldName = "producto";
            this.colproducto1.Name = "colproducto1";
            this.colproducto1.OptionsColumn.AllowEdit = false;
            this.colproducto1.Visible = true;
            this.colproducto1.VisibleIndex = 2;
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.OptionsColumn.AllowEdit = false;
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 3;
            // 
            // colcantidad2
            // 
            this.colcantidad2.Caption = "Ud.";
            this.colcantidad2.FieldName = "cantidad";
            this.colcantidad2.Name = "colcantidad2";
            this.colcantidad2.OptionsColumn.AllowEdit = false;
            this.colcantidad2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad2.Visible = true;
            this.colcantidad2.VisibleIndex = 5;
            // 
            // colpeso1
            // 
            this.colpeso1.Caption = "Peso Kg";
            this.colpeso1.FieldName = "peso";
            this.colpeso1.Name = "colpeso1";
            this.colpeso1.OptionsColumn.AllowEdit = false;
            this.colpeso1.Visible = true;
            this.colpeso1.VisibleIndex = 4;
            // 
            // colcodigo_barra1
            // 
            this.colcodigo_barra1.Caption = "Codigo Barra";
            this.colcodigo_barra1.FieldName = "codigo_barra";
            this.colcodigo_barra1.Name = "colcodigo_barra1";
            this.colcodigo_barra1.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra1.Visible = true;
            this.colcodigo_barra1.VisibleIndex = 1;
            // 
            // colid_prb
            // 
            this.colid_prb.FieldName = "id_prb";
            this.colid_prb.Name = "colid_prb";
            this.colid_prb.OptionsColumn.AllowEdit = false;
            this.colid_prb.Visible = true;
            this.colid_prb.VisibleIndex = 0;
            // 
            // grd_detalle
            // 
            this.grd_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_detalle.DataMember = "prblote";
            this.grd_detalle.DataSource = this.dsLotePick;
            gridLevelNode1.LevelTemplate = this.grdv_detalleTm;
            gridLevelNode1.RelationName = "prblote_tarimas_prb";
            this.grd_detalle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd_detalle.Location = new System.Drawing.Point(3, 439);
            this.grd_detalle.MainView = this.grdv_detalle;
            this.grd_detalle.Name = "grd_detalle";
            this.grd_detalle.Size = new System.Drawing.Size(1210, 263);
            this.grd_detalle.TabIndex = 82;
            this.grd_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_detalle,
            this.grdv_detalleTm});
            // 
            // dsLotePick
            // 
            this.dsLotePick.DataSetName = "dsLotePick";
            this.dsLotePick.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_detalle
            // 
            this.grdv_detalle.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_detalle.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_detalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_detalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_detalle.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.Preview.Options.UseFont = true;
            this.grdv_detalle.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.Row.Options.UseFont = true;
            this.grdv_detalle.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_detalle.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colusuario,
            this.colturno,
            this.coldateInicio,
            this.coldatefinal,
            this.colcantidad1});
            this.grdv_detalle.GridControl = this.grd_detalle;
            this.grdv_detalle.Name = "grdv_detalle";
            this.grdv_detalle.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grdv_detalle.OptionsDetail.EnableDetailToolTip = true;
            this.grdv_detalle.OptionsView.EnableAppearanceEvenRow = true;
            this.grdv_detalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdv_detalle.OptionsView.RowAutoHeight = true;
            this.grdv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.grdv_detalle.OptionsView.ShowChildrenInGroupPanel = true;
            this.grdv_detalle.OptionsView.ShowFooter = true;
            this.grdv_detalle.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.OptionsColumn.AllowEdit = false;
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 1;
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.OptionsColumn.AllowEdit = false;
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 2;
            // 
            // coldateInicio
            // 
            this.coldateInicio.Caption = "F Inicio";
            this.coldateInicio.FieldName = "dateInicio";
            this.coldateInicio.Name = "coldateInicio";
            this.coldateInicio.OptionsColumn.AllowEdit = false;
            this.coldateInicio.Visible = true;
            this.coldateInicio.VisibleIndex = 3;
            // 
            // coldatefinal
            // 
            this.coldatefinal.Caption = "F Final";
            this.coldatefinal.FieldName = "datefinal";
            this.coldatefinal.Name = "coldatefinal";
            this.coldatefinal.OptionsColumn.AllowEdit = false;
            this.coldatefinal.Visible = true;
            this.coldatefinal.VisibleIndex = 4;
            // 
            // colcantidad1
            // 
            this.colcantidad1.Caption = "Ud. Total";
            this.colcantidad1.FieldName = "cantidad";
            this.colcantidad1.Name = "colcantidad1";
            this.colcantidad1.OptionsColumn.AllowEdit = false;
            this.colcantidad1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad1.Visible = true;
            this.colcantidad1.VisibleIndex = 5;
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "tm_activas";
            this.grd_data.DataSource = this.dsLotePick;
            this.grd_data.Location = new System.Drawing.Point(-1, 125);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1214, 270);
            this.grd_data.TabIndex = 76;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
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
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo_barra,
            this.collote,
            this.colproducto,
            this.colcantidad,
            this.colpeso});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Codigo Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 0;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "SUM={0:0.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "SUM={0:0.##}")});
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 21);
            this.labelControl1.TabIndex = 77;
            this.labelControl1.Text = "Lote:___";
            // 
            // txtlote
            // 
            this.txtlote.Enabled = false;
            this.txtlote.Location = new System.Drawing.Point(62, 7);
            this.txtlote.Name = "txtlote";
            this.txtlote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtlote.Properties.Appearance.Options.UseFont = true;
            this.txtlote.Size = new System.Drawing.Size(100, 28);
            this.txtlote.TabIndex = 78;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(207, 21);
            this.labelControl2.TabIndex = 79;
            this.labelControl2.Text = "Detalle de la tarimas de lote:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 412);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(359, 21);
            this.labelControl3.TabIndex = 81;
            this.labelControl3.Text = "Detalle de uso de lote en registro de produccion:";
            // 
            // tggPendientes
            // 
            this.tggPendientes.Location = new System.Drawing.Point(878, 83);
            this.tggPendientes.Name = "tggPendientes";
            this.tggPendientes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggPendientes.Properties.Appearance.Options.UseFont = true;
            this.tggPendientes.Properties.OffText = "Solo Activadas";
            this.tggPendientes.Properties.OnText = "Pendientes";
            this.tggPendientes.Size = new System.Drawing.Size(322, 36);
            this.tggPendientes.TabIndex = 83;
            this.tggPendientes.Toggled += new System.EventHandler(this.tggPendientes_Toggled);
            // 
            // btncerrar
            // 
            this.btncerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Appearance.Options.UseFont = true;
            this.btncerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.ImageOptions.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1097, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(110, 53);
            this.btncerrar.TabIndex = 84;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(981, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(110, 53);
            this.btnExcel.TabIndex = 85;
            this.btnExcel.Text = "Exportar";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmDetalleActivado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 701);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.tggPendientes);
            this.Controls.Add(this.grd_detalle);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_data);
            this.Name = "frmDetalleActivado";
            this.Text = "Detalle de lote";
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalleTm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLotePick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggPendientes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtlote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_detalle;
        private dsLotePick dsLotePick;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraEditors.ToggleSwitch tggPendientes;
        private DevExpress.XtraEditors.SimpleButton btncerrar;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_detalleTm;
        private DevExpress.XtraGrid.Columns.GridColumn colidtm;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto1;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad2;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_prb;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
        private DevExpress.XtraGrid.Columns.GridColumn coldateInicio;
        private DevExpress.XtraGrid.Columns.GridColumn coldatefinal;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad1;
    }
}