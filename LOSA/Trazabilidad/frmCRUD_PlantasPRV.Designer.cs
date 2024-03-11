
namespace LOSA.Trazabilidad
{
    partial class frmCRUD_PlantasPRV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_PlantasPRV));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_planta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_gmo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bsTiposGMO = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaprobado_asc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gleAprobadoASC = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bsAprobacionASC = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.cmdAgregarMP = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTiposGMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAprobadoASC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAprobacionASC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(134, -6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Datos de la Planta";
            this.labelControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre de la Planta";
            this.labelControl2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(247, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(134, 81);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion.Size = new System.Drawing.Size(247, 24);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Dirección";
            this.labelControl3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Comentario";
            this.labelControl4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(64, 265);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(142, 51);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            this.cmdGuardar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(212, 265);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(142, 51);
            this.cmdHome.TabIndex = 5;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            this.cmdHome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(134, 21);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Size = new System.Drawing.Size(247, 24);
            this.txtProveedor.TabIndex = 0;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 17);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Proveedor";
            this.labelControl5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(134, 111);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(247, 148);
            this.txtComentario.TabIndex = 3;
            this.txtComentario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComentario_KeyDown);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(387, 21);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(487, 295);
            this.xtraTabControl1.TabIndex = 18;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(485, 270);
            this.xtraTabPage1.Text = "Materia(s) Prima(s)";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "planta_detalle_mp";
            this.gridControl1.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEliminar,
            this.repositoryItemGridLookUpEdit1,
            this.gleAprobadoASC});
            this.gridControl1.Size = new System.Drawing.Size(485, 270);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_planta,
            this.colid_mp,
            this.colitemcode,
            this.coldescripcion,
            this.coltipo_gmo_id,
            this.coleliminar,
            this.colid1,
            this.colfecha,
            this.colusuario_name,
            this.colaprobado_asc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid_planta
            // 
            this.colid_planta.FieldName = "id_planta";
            this.colid_planta.Name = "colid_planta";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 64;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 152;
            // 
            // coltipo_gmo_id
            // 
            this.coltipo_gmo_id.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.coltipo_gmo_id.FieldName = "tipo_gmo_id";
            this.coltipo_gmo_id.Name = "coltipo_gmo_id";
            this.coltipo_gmo_id.Visible = true;
            this.coltipo_gmo_id.VisibleIndex = 2;
            this.coltipo_gmo_id.Width = 102;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.bsTiposGMO;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "descripcion";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";
            // 
            // bsTiposGMO
            // 
            this.bsTiposGMO.DataMember = "tipos_gmo";
            this.bsTiposGMO.DataSource = this.dsMantoTrazabilidad1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.OptionsColumn.ReadOnly = true;
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // coleliminar
            // 
            this.coleliminar.ColumnEdit = this.cmdEliminar;
            this.coleliminar.FieldName = "eliminar";
            this.coleliminar.Name = "coleliminar";
            this.coleliminar.Visible = true;
            this.coleliminar.VisibleIndex = 4;
            this.coleliminar.Width = 40;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEliminar_ButtonClick);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            // 
            // colusuario_name
            // 
            this.colusuario_name.FieldName = "usuario_name";
            this.colusuario_name.Name = "colusuario_name";
            // 
            // colaprobado_asc
            // 
            this.colaprobado_asc.ColumnEdit = this.gleAprobadoASC;
            this.colaprobado_asc.FieldName = "aprobado_asc";
            this.colaprobado_asc.Name = "colaprobado_asc";
            this.colaprobado_asc.Visible = true;
            this.colaprobado_asc.VisibleIndex = 3;
            this.colaprobado_asc.Width = 71;
            // 
            // gleAprobadoASC
            // 
            this.gleAprobadoASC.AutoHeight = false;
            this.gleAprobadoASC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleAprobadoASC.DataSource = this.bsAprobacionASC;
            this.gleAprobadoASC.DisplayMember = "descripcion";
            this.gleAprobadoASC.Name = "gleAprobadoASC";
            this.gleAprobadoASC.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.gleAprobadoASC.ValueMember = "id";
            // 
            // bsAprobacionASC
            // 
            this.bsAprobacionASC.DataMember = "aprobacion_asc";
            this.bsAprobacionASC.DataSource = this.dsMantoTrazabilidad1;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion2});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.OptionsColumn.ReadOnly = true;
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(485, 276);
            this.xtraTabPage2.Text = "Adjunto(s)";
            // 
            // cmdAgregarMP
            // 
            this.cmdAgregarMP.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdAgregarMP.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cmdAgregarMP.Appearance.Options.UseBackColor = true;
            this.cmdAgregarMP.Appearance.Options.UseFont = true;
            this.cmdAgregarMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAgregarMP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAgregarMP.ImageOptions.SvgImage")));
            this.cmdAgregarMP.Location = new System.Drawing.Point(779, 5);
            this.cmdAgregarMP.Name = "cmdAgregarMP";
            this.cmdAgregarMP.Size = new System.Drawing.Size(95, 36);
            this.cmdAgregarMP.TabIndex = 5;
            this.cmdAgregarMP.Text = "Agregar";
            this.cmdAgregarMP.Click += new System.EventHandler(this.cmdAgregarMP_Click);
            // 
            // frmCRUD_PlantasPRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 327);
            this.Controls.Add(this.cmdAgregarMP);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCRUD_PlantasPRV";
            this.Text = "Plantas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCRUD_PlantasPRV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTiposGMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAprobadoASC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAprobacionASC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtComentario;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdAgregarMP;
        private dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_planta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_gmo_id;
        private DevExpress.XtraGrid.Columns.GridColumn coleliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private System.Windows.Forms.BindingSource bsTiposGMO;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_name;
        private DevExpress.XtraGrid.Columns.GridColumn colaprobado_asc;
        private System.Windows.Forms.BindingSource bsAprobacionASC;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gleAprobadoASC;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
    }
}