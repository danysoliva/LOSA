namespace LOSA.MigracionACS.RRHH.Utilerias
{
    partial class frmProfileEmployees
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfileEmployees));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.dsUtilerias1 = new LOSA.MigracionACS.RRHH.Utilerias.dsUtilerias();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colupdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colupdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdUpdated = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUtilerias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdUpdated)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "employees_old";
            this.gridControl1.DataSource = this.dsUtilerias1;
            this.gridControl1.Location = new System.Drawing.Point(2, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdUpdated});
            this.gridControl1.Size = new System.Drawing.Size(1208, 294);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colbarcode,
            this.colupdate,
            this.colseleccion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "employees_new";
            this.gridControl2.DataSource = this.dsUtilerias1;
            this.gridControl2.Location = new System.Drawing.Point(2, 353);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1208, 305);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colname1,
            this.colbarcode1,
            this.colupdate1,
            this.colseleccion1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1080, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(130, 47);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdCargar.Appearance.Options.UseBackColor = true;
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.cmdCargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdCargar.Location = new System.Drawing.Point(2, 0);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(130, 47);
            this.cmdCargar.TabIndex = 12;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dsUtilerias1
            // 
            this.dsUtilerias1.DataSetName = "dsUtilerias";
            this.dsUtilerias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colbarcode
            // 
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 2;
            // 
            // colupdate
            // 
            this.colupdate.ColumnEdit = this.cmdUpdated;
            this.colupdate.FieldName = "update";
            this.colupdate.Name = "colupdate";
            this.colupdate.Visible = true;
            this.colupdate.VisibleIndex = 3;
            // 
            // colseleccion
            // 
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            this.colid1.Visible = true;
            this.colid1.VisibleIndex = 0;
            // 
            // colname1
            // 
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            // 
            // colbarcode1
            // 
            this.colbarcode1.FieldName = "barcode";
            this.colbarcode1.Name = "colbarcode1";
            this.colbarcode1.Visible = true;
            this.colbarcode1.VisibleIndex = 2;
            // 
            // colupdate1
            // 
            this.colupdate1.FieldName = "update";
            this.colupdate1.Name = "colupdate1";
            this.colupdate1.Visible = true;
            this.colupdate1.VisibleIndex = 3;
            // 
            // colseleccion1
            // 
            this.colseleccion1.FieldName = "seleccion";
            this.colseleccion1.Name = "colseleccion1";
            // 
            // cmdUpdated
            // 
            this.cmdUpdated.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdUpdated.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdUpdated.Name = "cmdUpdated";
            this.cmdUpdated.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdUpdated.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdUpdated_ButtonClick);
            // 
            // frmProfileEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 670);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmProfileEmployees";
            this.Text = "Profile Employees";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUtilerias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdUpdated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private dsUtilerias dsUtilerias1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colupdate;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colupdate1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdUpdated;
    }
}