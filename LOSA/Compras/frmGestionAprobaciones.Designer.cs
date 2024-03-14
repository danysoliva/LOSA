namespace LOSA.Compras
{
    partial class frmGestionAprobaciones
    {

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAprobaciones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsAutorizacionesCompras1 = new LOSA.Compras.dsAutorizacionesCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ordenH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_solicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreSolicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ruta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocCur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_fila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgestion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGestionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.reposCmdVistaOrden = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGestionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposCmdVistaOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 71);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(960, 404);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(958, 377);
            this.xtraTabPage1.Text = "Pendientes";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "pendienes_aprobacion";
            this.gridControl1.DataSource = this.dsAutorizacionesCompras1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdGestionar,
            this.reposCmdVistaOrden});
            this.gridControl1.Size = new System.Drawing.Size(958, 377);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsAutorizacionesCompras1
            // 
            this.dsAutorizacionesCompras1.DataSetName = "dsAutorizacionesCompras";
            this.dsAutorizacionesCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_ordenH,
            this.colid_solicitante,
            this.colNombreSolicitante,
            this.colid_ruta,
            this.colRutaAprobacion,
            this.colfecha,
            this.colid_estado,
            this.colEstadoNombre,
            this.colenable,
            this.colDocCur,
            this.colMontoOrdenCompra,
            this.colComments,
            this.colCodigo,
            this.colProveedor,
            this.colnum_fila,
            this.colgestion,
            this.colseleccionar,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_ordenH
            // 
            this.colid_ordenH.FieldName = "id_ordenH";
            this.colid_ordenH.Name = "colid_ordenH";
            this.colid_ordenH.OptionsColumn.ReadOnly = true;
            // 
            // colid_solicitante
            // 
            this.colid_solicitante.FieldName = "id_solicitante";
            this.colid_solicitante.Name = "colid_solicitante";
            this.colid_solicitante.OptionsColumn.ReadOnly = true;
            // 
            // colNombreSolicitante
            // 
            this.colNombreSolicitante.FieldName = "NombreSolicitante";
            this.colNombreSolicitante.Name = "colNombreSolicitante";
            this.colNombreSolicitante.OptionsColumn.ReadOnly = true;
            this.colNombreSolicitante.Visible = true;
            this.colNombreSolicitante.VisibleIndex = 3;
            this.colNombreSolicitante.Width = 72;
            // 
            // colid_ruta
            // 
            this.colid_ruta.FieldName = "id_ruta";
            this.colid_ruta.Name = "colid_ruta";
            this.colid_ruta.OptionsColumn.ReadOnly = true;
            // 
            // colRutaAprobacion
            // 
            this.colRutaAprobacion.FieldName = "RutaAprobacion";
            this.colRutaAprobacion.Name = "colRutaAprobacion";
            this.colRutaAprobacion.OptionsColumn.ReadOnly = true;
            this.colRutaAprobacion.Visible = true;
            this.colRutaAprobacion.VisibleIndex = 4;
            this.colRutaAprobacion.Width = 78;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 5;
            this.colfecha.Width = 53;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.ReadOnly = true;
            // 
            // colEstadoNombre
            // 
            this.colEstadoNombre.FieldName = "EstadoNombre";
            this.colEstadoNombre.Name = "colEstadoNombre";
            this.colEstadoNombre.OptionsColumn.ReadOnly = true;
            this.colEstadoNombre.Visible = true;
            this.colEstadoNombre.VisibleIndex = 6;
            this.colEstadoNombre.Width = 88;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            // 
            // colDocCur
            // 
            this.colDocCur.FieldName = "DocCur";
            this.colDocCur.Name = "colDocCur";
            this.colDocCur.OptionsColumn.ReadOnly = true;
            this.colDocCur.Visible = true;
            this.colDocCur.VisibleIndex = 7;
            this.colDocCur.Width = 35;
            // 
            // colMontoOrdenCompra
            // 
            this.colMontoOrdenCompra.DisplayFormat.FormatString = "n2";
            this.colMontoOrdenCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoOrdenCompra.FieldName = "MontoOrdenCompra";
            this.colMontoOrdenCompra.Name = "colMontoOrdenCompra";
            this.colMontoOrdenCompra.OptionsColumn.ReadOnly = true;
            this.colMontoOrdenCompra.Visible = true;
            this.colMontoOrdenCompra.VisibleIndex = 8;
            this.colMontoOrdenCompra.Width = 78;
            // 
            // colComments
            // 
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.OptionsColumn.ReadOnly = true;
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 9;
            this.colComments.Width = 138;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 46;
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.ReadOnly = true;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 2;
            // 
            // colnum_fila
            // 
            this.colnum_fila.FieldName = "num_fila";
            this.colnum_fila.Name = "colnum_fila";
            this.colnum_fila.OptionsColumn.ReadOnly = true;
            this.colnum_fila.Visible = true;
            this.colnum_fila.VisibleIndex = 0;
            this.colnum_fila.Width = 32;
            // 
            // colgestion
            // 
            this.colgestion.ColumnEdit = this.cmdGestionar;
            this.colgestion.FieldName = "gestion";
            this.colgestion.Name = "colgestion";
            this.colgestion.Visible = true;
            this.colgestion.VisibleIndex = 10;
            this.colgestion.Width = 74;
            // 
            // cmdGestionar
            // 
            this.cmdGestionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdGestionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdGestionar.Name = "cmdGestionar";
            this.cmdGestionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdGestionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdGestionar_ButtonClick);
            // 
            // colseleccionar
            // 
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Width = 36;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(958, 377);
            this.xtraTabPage2.Text = "Historial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de aprobación de Ordenes de Compra";
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdActualizar.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdActualizar.Appearance.Options.UseBackColor = true;
            this.cmdActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdActualizar.ImageOptions.Image")));
            this.cmdActualizar.Location = new System.Drawing.Point(855, 2);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(106, 40);
            this.cmdActualizar.TabIndex = 2;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // reposCmdVistaOrden
            // 
            this.reposCmdVistaOrden.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.reposCmdVistaOrden.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposCmdVistaOrden.Name = "reposCmdVistaOrden";
            this.reposCmdVistaOrden.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposCmdVistaOrden.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposCmdVistaOrden_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Detalle";
            this.gridColumn1.ColumnEdit = this.reposCmdVistaOrden;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // frmGestionAprobaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(964, 475);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmGestionAprobaciones";
            this.Text = "Gestión de Aprobaciones";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutorizacionesCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGestionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposCmdVistaOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label label1;
        private dsAutorizacionesCompras dsAutorizacionesCompras1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ordenH;
        private DevExpress.XtraGrid.Columns.GridColumn colid_solicitante;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreSolicitante;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ruta;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCur;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_fila;
        private DevExpress.XtraGrid.Columns.GridColumn colgestion;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdGestionar;
        private DevExpress.XtraEditors.SimpleButton cmdActualizar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposCmdVistaOrden;
    }
}