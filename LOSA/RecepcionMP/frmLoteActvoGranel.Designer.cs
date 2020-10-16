namespace LOSA.RecepcionMP
{
    partial class frmLoteActvoGranel
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoteActvoGranel));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ship = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesactivar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDesactivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_user_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdEditBarco = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx2 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_create1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesactivarLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdActivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdNuevoLote = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdActivar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "lote_activo_granel";
            this.gridControl1.DataSource = this.dsRecepcionMPx1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDesactivar,
            this.cmdEditBarco,
            this.cmdEditar});
            this.gridControl1.Size = new System.Drawing.Size(787, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote,
            this.colid_ship,
            this.colbarco,
            this.colfecha,
            this.colDesactivar,
            this.colid_user_create,
            this.colEditar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            // 
            // colid_ship
            // 
            this.colid_ship.FieldName = "id_ship";
            this.colid_ship.Name = "colid_ship";
            // 
            // colbarco
            // 
            this.colbarco.Caption = "Barco";
            this.colbarco.FieldName = "barco";
            this.colbarco.Name = "colbarco";
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colDesactivar
            // 
            this.colDesactivar.Caption = "Desactivar";
            this.colDesactivar.ColumnEdit = this.cmdDesactivar;
            this.colDesactivar.Name = "colDesactivar";
            this.colDesactivar.Visible = true;
            this.colDesactivar.VisibleIndex = 3;
            // 
            // cmdDesactivar
            // 
            this.cmdDesactivar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdDesactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDesactivar.Name = "cmdDesactivar";
            this.cmdDesactivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDesactivar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDesactivar_ButtonClick);
            // 
            // colid_user_create
            // 
            this.colid_user_create.FieldName = "id_user_create";
            this.colid_user_create.Name = "colid_user_create";
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 2;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditar_ButtonClick);
            // 
            // cmdEditBarco
            // 
            this.cmdEditBarco.AutoHeight = false;
            this.cmdEditBarco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmdEditBarco.Name = "cmdEditBarco";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 33);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(793, 471);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(787, 443);
            this.xtraTabPage1.Text = "Lotes Activos";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(787, 443);
            this.xtraTabPage2.Text = "Lotes Desactivados";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "lote_activo_granel";
            this.gridControl2.DataSource = this.dsRecepcionMPx2;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdActivar});
            this.gridControl2.Size = new System.Drawing.Size(787, 443);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // dsRecepcionMPx2
            // 
            this.dsRecepcionMPx2.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.collote1,
            this.colfecha1,
            this.colid_user_create1,
            this.colDesactivarLote});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // collote1
            // 
            this.collote1.Caption = "Lote";
            this.collote1.FieldName = "lote";
            this.collote1.Name = "collote1";
            this.collote1.OptionsColumn.AllowEdit = false;
            this.collote1.Visible = true;
            this.collote1.VisibleIndex = 0;
            // 
            // colfecha1
            // 
            this.colfecha1.Caption = "Fecha";
            this.colfecha1.FieldName = "fecha";
            this.colfecha1.Name = "colfecha1";
            this.colfecha1.OptionsColumn.AllowEdit = false;
            this.colfecha1.Visible = true;
            this.colfecha1.VisibleIndex = 1;
            // 
            // colid_user_create1
            // 
            this.colid_user_create1.FieldName = "id_user_create";
            this.colid_user_create1.Name = "colid_user_create1";
            // 
            // colDesactivarLote
            // 
            this.colDesactivarLote.Caption = "Activar";
            this.colDesactivarLote.ColumnEdit = this.cmdActivar;
            this.colDesactivarLote.Name = "colDesactivarLote";
            this.colDesactivarLote.Visible = true;
            this.colDesactivarLote.VisibleIndex = 2;
            // 
            // cmdActivar
            // 
            this.cmdActivar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdActivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdActivar.Name = "cmdActivar";
            this.cmdActivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdActivar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdActivar_ButtonClick);
            // 
            // cmdNuevoLote
            // 
            this.cmdNuevoLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNuevoLote.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdNuevoLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoLote.Appearance.Options.UseBackColor = true;
            this.cmdNuevoLote.Appearance.Options.UseFont = true;
            this.cmdNuevoLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNuevoLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoLote.ImageOptions.Image")));
            this.cmdNuevoLote.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdNuevoLote.Location = new System.Drawing.Point(668, 12);
            this.cmdNuevoLote.Name = "cmdNuevoLote";
            this.cmdNuevoLote.Size = new System.Drawing.Size(125, 38);
            this.cmdNuevoLote.TabIndex = 11;
            this.cmdNuevoLote.Text = "Nuevo Lote";
            this.cmdNuevoLote.Click += new System.EventHandler(this.cmdNuevoLote_Click);
            // 
            // frmLoteActvoGranel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.cmdNuevoLote);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmLoteActvoGranel";
            this.Text = "Lote Actvo Granel";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdActivar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsRecepcionMPx dsRecepcionMPx1;
        private dsRecepcionMPx dsRecepcionMPx2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ship;
        private DevExpress.XtraGrid.Columns.GridColumn colbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn collote1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesactivar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDesactivar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditBarco;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_create;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_create1;
        private DevExpress.XtraGrid.Columns.GridColumn colDesactivarLote;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdActivar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevoLote;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
    }
}