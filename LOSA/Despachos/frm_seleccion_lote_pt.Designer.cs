
namespace LOSA.Despachos
{
    partial class frm_seleccion_lote_pt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_seleccion_lote_pt));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocentry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinenum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookpresentaciones = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.presentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.coldscripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grd_existencia = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_existencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote_producto_termiado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grv_requerido = new DevExpress.XtraGrid.GridControl();
            this.grdv_requerido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collote_producto_termiado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvencimiento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colselected1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrestante1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.chautoseleccion = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookpresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_existencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_existencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_requerido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_requerido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chautoseleccion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Appearance.Options.UseFont = true;
            this.btn_guardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.ImageOptions.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(12, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(196, 58);
            this.btn_guardar.TabIndex = 56;
            this.btn_guardar.Text = "Crear despacho";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_close.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_close.Appearance.Options.UseFont = true;
            this.Btn_close.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.Btn_close.Location = new System.Drawing.Point(804, 12);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(187, 58);
            this.Btn_close.TabIndex = 57;
            this.Btn_close.Text = "Volver";
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.Location = new System.Drawing.Point(11, 126);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookpresentaciones});
            this.grd_data.Size = new System.Drawing.Size(979, 169);
            this.grd_data.TabIndex = 58;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colitemcode,
            this.colpeso,
            this.coldocentry,
            this.collinenum,
            this.colunidades,
            this.colid_presentacion,
            this.coldscripcion});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_data_FocusedRowChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso Kg.";
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 3;
            // 
            // coldocentry
            // 
            this.coldocentry.FieldName = "docentry";
            this.coldocentry.Name = "coldocentry";
            this.coldocentry.OptionsColumn.AllowEdit = false;
            // 
            // collinenum
            // 
            this.collinenum.FieldName = "linenum";
            this.collinenum.Name = "collinenum";
            this.collinenum.OptionsColumn.AllowEdit = false;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 4;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.Caption = "Presentacion";
            this.colid_presentacion.ColumnEdit = this.lookpresentaciones;
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            this.colid_presentacion.OptionsColumn.AllowEdit = false;
            this.colid_presentacion.Visible = true;
            this.colid_presentacion.VisibleIndex = 2;
            // 
            // lookpresentaciones
            // 
            this.lookpresentaciones.AutoHeight = false;
            this.lookpresentaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookpresentaciones.DataSource = this.presentacionesBindingSource;
            this.lookpresentaciones.DisplayMember = "descripcion";
            this.lookpresentaciones.KeyMember = "id";
            this.lookpresentaciones.Name = "lookpresentaciones";
            this.lookpresentaciones.ValueMember = "id";
            // 
            // presentacionesBindingSource
            // 
            this.presentacionesBindingSource.DataMember = "presentaciones";
            this.presentacionesBindingSource.DataSource = this.dsRecepcionMPx;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coldscripcion
            // 
            this.coldscripcion.Caption = "Producto";
            this.coldscripcion.FieldName = "dscripcion";
            this.coldscripcion.Name = "coldscripcion";
            this.coldscripcion.OptionsColumn.AllowEdit = false;
            this.coldscripcion.Visible = true;
            this.coldscripcion.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Productos Configurados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Existencia";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Requeridos";
            // 
            // grd_existencia
            // 
            this.grd_existencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grd_existencia.DataMember = "existencia_seleccion";
            this.grd_existencia.DataSource = this.ds_despachos;
            this.grd_existencia.Location = new System.Drawing.Point(3, 339);
            this.grd_existencia.MainView = this.grdv_existencia;
            this.grd_existencia.Name = "grd_existencia";
            this.grd_existencia.Size = new System.Drawing.Size(567, 332);
            this.grd_existencia.TabIndex = 62;
            this.grd_existencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_existencia});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_existencia
            // 
            this.grdv_existencia.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.Empty.Options.UseFont = true;
            this.grdv_existencia.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_existencia.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_existencia.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_existencia.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_existencia.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_existencia.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_existencia.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_existencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_existencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_existencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.Row.Options.UseFont = true;
            this.grdv_existencia.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_existencia.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_existencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote_producto_termiado,
            this.colvencimiento,
            this.colCantidad,
            this.colseleccionada,
            this.colselected,
            this.colitemcode1,
            this.colrestante});
            this.grdv_existencia.GridControl = this.grd_existencia;
            this.grdv_existencia.Name = "grdv_existencia";
            this.grdv_existencia.OptionsView.ShowAutoFilterRow = true;
            this.grdv_existencia.OptionsView.ShowGroupPanel = false;
            this.grdv_existencia.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grdv_existencia_ShowingEditor);
            this.grdv_existencia.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_existencia_CellValueChanging);
            // 
            // collote_producto_termiado
            // 
            this.collote_producto_termiado.Caption = "Lote";
            this.collote_producto_termiado.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado.Name = "collote_producto_termiado";
            this.collote_producto_termiado.OptionsColumn.AllowEdit = false;
            this.collote_producto_termiado.Visible = true;
            this.collote_producto_termiado.VisibleIndex = 0;
            // 
            // colvencimiento
            // 
            this.colvencimiento.Caption = "F. Vencimiento";
            this.colvencimiento.FieldName = "vencimiento";
            this.colvencimiento.Name = "colvencimiento";
            this.colvencimiento.OptionsColumn.AllowEdit = false;
            this.colvencimiento.Visible = true;
            this.colvencimiento.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Existencia";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            // 
            // colseleccionada
            // 
            this.colseleccionada.Caption = "Ud. Seleccionadas";
            this.colseleccionada.FieldName = "seleccionada";
            this.colseleccionada.Name = "colseleccionada";
            this.colseleccionada.Visible = true;
            this.colseleccionada.VisibleIndex = 3;
            // 
            // colselected
            // 
            this.colselected.Caption = "Selecionar";
            this.colselected.FieldName = "selected";
            this.colselected.Name = "colselected";
            this.colselected.Visible = true;
            this.colselected.VisibleIndex = 5;
            // 
            // colitemcode1
            // 
            this.colitemcode1.FieldName = "itemcode";
            this.colitemcode1.Name = "colitemcode1";
            this.colitemcode1.OptionsColumn.AllowEdit = false;
            // 
            // colrestante
            // 
            this.colrestante.Caption = "Restante";
            this.colrestante.FieldName = "restante";
            this.colrestante.Name = "colrestante";
            this.colrestante.OptionsColumn.AllowEdit = false;
            this.colrestante.Visible = true;
            this.colrestante.VisibleIndex = 4;
            // 
            // grv_requerido
            // 
            this.grv_requerido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_requerido.DataMember = "lotes_selected";
            this.grv_requerido.DataSource = this.ds_despachos;
            gridLevelNode1.RelationName = "Level1";
            this.grv_requerido.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grv_requerido.Location = new System.Drawing.Point(720, 339);
            this.grv_requerido.MainView = this.grdv_requerido;
            this.grv_requerido.Name = "grv_requerido";
            this.grv_requerido.Size = new System.Drawing.Size(275, 340);
            this.grv_requerido.TabIndex = 63;
            this.grv_requerido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_requerido});
            // 
            // grdv_requerido
            // 
            this.grdv_requerido.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.Empty.Options.UseFont = true;
            this.grdv_requerido.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_requerido.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_requerido.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_requerido.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_requerido.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_requerido.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_requerido.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_requerido.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_requerido.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_requerido.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.Row.Options.UseFont = true;
            this.grdv_requerido.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_requerido.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_requerido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collote_producto_termiado1,
            this.colvencimiento1,
            this.colCantidad1,
            this.colseleccionada1,
            this.colselected1,
            this.colitemcode2,
            this.colrestante1});
            this.grdv_requerido.GridControl = this.grv_requerido;
            this.grdv_requerido.Name = "grdv_requerido";
            this.grdv_requerido.OptionsView.ShowAutoFilterRow = true;
            this.grdv_requerido.OptionsView.ShowGroupPanel = false;
            this.grdv_requerido.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_requerido_CellValueChanging);
            // 
            // collote_producto_termiado1
            // 
            this.collote_producto_termiado1.Caption = "Lote";
            this.collote_producto_termiado1.FieldName = "lote_producto_termiado";
            this.collote_producto_termiado1.Name = "collote_producto_termiado1";
            this.collote_producto_termiado1.OptionsColumn.AllowEdit = false;
            this.collote_producto_termiado1.Visible = true;
            this.collote_producto_termiado1.VisibleIndex = 0;
            // 
            // colvencimiento1
            // 
            this.colvencimiento1.Caption = "F. Vencimiento";
            this.colvencimiento1.FieldName = "vencimiento";
            this.colvencimiento1.Name = "colvencimiento1";
            this.colvencimiento1.OptionsColumn.AllowEdit = false;
            this.colvencimiento1.Visible = true;
            this.colvencimiento1.VisibleIndex = 1;
            // 
            // colCantidad1
            // 
            this.colCantidad1.FieldName = "Cantidad";
            this.colCantidad1.Name = "colCantidad1";
            // 
            // colseleccionada1
            // 
            this.colseleccionada1.Caption = "Ud. Seleccionadas";
            this.colseleccionada1.FieldName = "seleccionada";
            this.colseleccionada1.Name = "colseleccionada1";
            this.colseleccionada1.OptionsColumn.AllowEdit = false;
            this.colseleccionada1.Visible = true;
            this.colseleccionada1.VisibleIndex = 2;
            // 
            // colselected1
            // 
            this.colselected1.Caption = "Seleccionar";
            this.colselected1.FieldName = "selected";
            this.colselected1.Name = "colselected1";
            this.colselected1.Visible = true;
            this.colselected1.VisibleIndex = 3;
            // 
            // colitemcode2
            // 
            this.colitemcode2.Caption = "Seleccioando";
            this.colitemcode2.FieldName = "itemcode";
            this.colitemcode2.Name = "colitemcode2";
            // 
            // colrestante1
            // 
            this.colrestante1.FieldName = "restante";
            this.colrestante1.Name = "colrestante1";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSeleccionar.Location = new System.Drawing.Point(589, 429);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 51);
            this.btnSeleccionar.TabIndex = 64;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.ImageOptions.Image")));
            this.btnQuitar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnQuitar.Location = new System.Drawing.Point(589, 516);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(105, 51);
            this.btnQuitar.TabIndex = 65;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // chautoseleccion
            // 
            this.chautoseleccion.Location = new System.Drawing.Point(412, 311);
            this.chautoseleccion.Name = "chautoseleccion";
            this.chautoseleccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chautoseleccion.Properties.Appearance.Options.UseFont = true;
            this.chautoseleccion.Properties.Caption = "Auto seleccionar";
            this.chautoseleccion.Size = new System.Drawing.Size(158, 25);
            this.chautoseleccion.TabIndex = 66;
            this.chautoseleccion.CheckedChanged += new System.EventHandler(this.chautoseleccion_CheckedChanged);
            // 
            // frm_seleccion_lote_pt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 683);
            this.Controls.Add(this.chautoseleccion);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.grv_requerido);
            this.Controls.Add(this.grd_existencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_seleccion_lote_pt";
            this.Text = "frm_seleccion_lote_pt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_seleccion_lote_pt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookpresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_existencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_existencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_requerido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_requerido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chautoseleccion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.SimpleButton Btn_close;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl grd_existencia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_existencia;
        private DevExpress.XtraGrid.GridControl grv_requerido;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_requerido;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionar;
        private DevExpress.XtraEditors.SimpleButton btnQuitar;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn coldocentry;
        private DevExpress.XtraGrid.Columns.GridColumn collinenum;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldscripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookpresentaciones;
        private System.Windows.Forms.BindingSource presentacionesBindingSource;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado;
        private DevExpress.XtraGrid.Columns.GridColumn colvencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionada;
        private DevExpress.XtraGrid.Columns.GridColumn colselected;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colrestante;
        private DevExpress.XtraEditors.CheckEdit chautoseleccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_producto_termiado1;
        private DevExpress.XtraGrid.Columns.GridColumn colvencimiento1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionada1;
        private DevExpress.XtraGrid.Columns.GridColumn colselected1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode2;
        private DevExpress.XtraGrid.Columns.GridColumn colrestante1;
    }
}