
using LOSA.TransaccionesMP.Gestion_Granel;

namespace JAGUAR_APP.TransaccionesMP.Gestion_Granel
{
    partial class frmGestionLoteGranel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionLoteGranel));
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
            this.dsGestionGranel1 = new LOSA.TransaccionesMP.Gestion_Granel.dsGestionGranel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_row = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_last_user_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_last_modification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name_created = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_last_updated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSubir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBajar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdBajar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDesactivar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDesactivar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGestionGranel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSubir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Trigo_Lotes";
            this.gridControl1.DataSource = this.dsGestionGranel1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Location = new System.Drawing.Point(6, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdSubir,
            this.cmdBajar,
            this.cmdDesactivar});
            this.gridControl1.Size = new System.Drawing.Size(1974, 802);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsGestionGranel1
            // 
            this.dsGestionGranel1.DataSetName = "dsGestionGranel";
            this.dsGestionGranel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_mp,
            this.collot,
            this.colenable,
            this.colpriority,
            this.colid_state,
            this.colid_user_created,
            this.coldate_row,
            this.colid_last_user_update,
            this.colid_type,
            this.coldate_last_modification,
            this.coluser_name_created,
            this.colstate_name,
            this.coltype_name,
            this.coluser_last_updated,
            this.colitemcode,
            this.colitemname,
            this.colLinea,
            this.colSubir,
            this.colBajar,
            this.colDesactivar});
            this.gridView1.DetailHeight = 673;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 40;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Width = 150;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.MinWidth = 40;
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.ReadOnly = true;
            this.colid_mp.Width = 150;
            // 
            // collot
            // 
            this.collot.FieldName = "lot";
            this.collot.MinWidth = 40;
            this.collot.Name = "collot";
            this.collot.OptionsColumn.ReadOnly = true;
            this.collot.Visible = true;
            this.collot.VisibleIndex = 0;
            this.collot.Width = 150;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.MinWidth = 40;
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.ReadOnly = true;
            this.colenable.Width = 150;
            // 
            // colpriority
            // 
            this.colpriority.FieldName = "priority";
            this.colpriority.MinWidth = 40;
            this.colpriority.Name = "colpriority";
            this.colpriority.OptionsColumn.ReadOnly = true;
            this.colpriority.Visible = true;
            this.colpriority.VisibleIndex = 1;
            this.colpriority.Width = 150;
            // 
            // colid_state
            // 
            this.colid_state.FieldName = "id_state";
            this.colid_state.MinWidth = 40;
            this.colid_state.Name = "colid_state";
            this.colid_state.OptionsColumn.ReadOnly = true;
            this.colid_state.Width = 150;
            // 
            // colid_user_created
            // 
            this.colid_user_created.FieldName = "id_user_created";
            this.colid_user_created.MinWidth = 40;
            this.colid_user_created.Name = "colid_user_created";
            this.colid_user_created.OptionsColumn.ReadOnly = true;
            this.colid_user_created.Width = 150;
            // 
            // coldate_row
            // 
            this.coldate_row.FieldName = "date_row";
            this.coldate_row.MinWidth = 40;
            this.coldate_row.Name = "coldate_row";
            this.coldate_row.OptionsColumn.ReadOnly = true;
            this.coldate_row.Width = 150;
            // 
            // colid_last_user_update
            // 
            this.colid_last_user_update.FieldName = "id_last_user_update";
            this.colid_last_user_update.MinWidth = 40;
            this.colid_last_user_update.Name = "colid_last_user_update";
            this.colid_last_user_update.OptionsColumn.ReadOnly = true;
            this.colid_last_user_update.Width = 150;
            // 
            // colid_type
            // 
            this.colid_type.FieldName = "id_type";
            this.colid_type.MinWidth = 40;
            this.colid_type.Name = "colid_type";
            this.colid_type.OptionsColumn.ReadOnly = true;
            this.colid_type.Width = 150;
            // 
            // coldate_last_modification
            // 
            this.coldate_last_modification.FieldName = "date_last_modification";
            this.coldate_last_modification.MinWidth = 40;
            this.coldate_last_modification.Name = "coldate_last_modification";
            this.coldate_last_modification.OptionsColumn.ReadOnly = true;
            this.coldate_last_modification.Width = 150;
            // 
            // coluser_name_created
            // 
            this.coluser_name_created.FieldName = "user_name_created";
            this.coluser_name_created.MinWidth = 40;
            this.coluser_name_created.Name = "coluser_name_created";
            this.coluser_name_created.OptionsColumn.ReadOnly = true;
            this.coluser_name_created.Width = 150;
            // 
            // colstate_name
            // 
            this.colstate_name.FieldName = "state_name";
            this.colstate_name.MinWidth = 40;
            this.colstate_name.Name = "colstate_name";
            this.colstate_name.OptionsColumn.ReadOnly = true;
            this.colstate_name.Visible = true;
            this.colstate_name.VisibleIndex = 2;
            this.colstate_name.Width = 150;
            // 
            // coltype_name
            // 
            this.coltype_name.FieldName = "type_name";
            this.coltype_name.MinWidth = 40;
            this.coltype_name.Name = "coltype_name";
            this.coltype_name.OptionsColumn.ReadOnly = true;
            this.coltype_name.Visible = true;
            this.coltype_name.VisibleIndex = 3;
            this.coltype_name.Width = 150;
            // 
            // coluser_last_updated
            // 
            this.coluser_last_updated.FieldName = "user_last_updated";
            this.coluser_last_updated.MinWidth = 40;
            this.coluser_last_updated.Name = "coluser_last_updated";
            this.coluser_last_updated.OptionsColumn.ReadOnly = true;
            this.coluser_last_updated.Visible = true;
            this.coluser_last_updated.VisibleIndex = 4;
            this.coluser_last_updated.Width = 150;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.MinWidth = 40;
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 5;
            this.colitemcode.Width = 150;
            // 
            // colitemname
            // 
            this.colitemname.FieldName = "itemname";
            this.colitemname.MinWidth = 40;
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 6;
            this.colitemname.Width = 150;
            // 
            // colLinea
            // 
            this.colLinea.FieldName = "Linea";
            this.colLinea.MinWidth = 40;
            this.colLinea.Name = "colLinea";
            this.colLinea.OptionsColumn.ReadOnly = true;
            this.colLinea.Visible = true;
            this.colLinea.VisibleIndex = 7;
            this.colLinea.Width = 150;
            // 
            // colSubir
            // 
            this.colSubir.Caption = "Subir";
            this.colSubir.ColumnEdit = this.cmdSubir;
            this.colSubir.MinWidth = 40;
            this.colSubir.Name = "colSubir";
            this.colSubir.Visible = true;
            this.colSubir.VisibleIndex = 8;
            this.colSubir.Width = 150;
            // 
            // cmdSubir
            // 
            this.cmdSubir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdSubir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdSubir.Name = "cmdSubir";
            this.cmdSubir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colBajar
            // 
            this.colBajar.Caption = "Bajar";
            this.colBajar.ColumnEdit = this.cmdBajar;
            this.colBajar.MinWidth = 40;
            this.colBajar.Name = "colBajar";
            this.colBajar.Visible = true;
            this.colBajar.VisibleIndex = 9;
            this.colBajar.Width = 150;
            // 
            // cmdBajar
            // 
            this.cmdBajar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdBajar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdBajar.Name = "cmdBajar";
            this.cmdBajar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDesactivar
            // 
            this.colDesactivar.Caption = "Desactivar";
            this.colDesactivar.ColumnEdit = this.cmdDesactivar;
            this.colDesactivar.MinWidth = 40;
            this.colDesactivar.Name = "colDesactivar";
            this.colDesactivar.Visible = true;
            this.colDesactivar.VisibleIndex = 10;
            this.colDesactivar.Width = 150;
            // 
            // cmdDesactivar
            // 
            this.cmdDesactivar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdDesactivar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDesactivar.Name = "cmdDesactivar";
            this.cmdDesactivar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDesactivar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDesactivar_ButtonClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 121);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(2002, 912);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1998, 863);
            this.xtraTabPage1.Text = "Trigo";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1998, 863);
            this.xtraTabPage2.Text = "Soya";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(1708, 65);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(290, 88);
            this.cmdCerrar.TabIndex = 2;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 45);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Gestión de Lote";
            // 
            // frmGestionLoteGranel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2012, 1037);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmGestionLoteGranel";
            this.Text = "Gestión Lote Granel";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGestionGranel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSubir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDesactivar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsGestionGranel dsGestionGranel1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn collot;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colpriority;
        private DevExpress.XtraGrid.Columns.GridColumn colid_state;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user_created;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_row;
        private DevExpress.XtraGrid.Columns.GridColumn colid_last_user_update;
        private DevExpress.XtraGrid.Columns.GridColumn colid_type;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_last_modification;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name_created;
        private DevExpress.XtraGrid.Columns.GridColumn colstate_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_name;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_last_updated;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private DevExpress.XtraGrid.Columns.GridColumn colLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colSubir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSubir;
        private DevExpress.XtraGrid.Columns.GridColumn colBajar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdBajar;
        private DevExpress.XtraGrid.Columns.GridColumn colDesactivar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDesactivar;
    }
}