namespace LOSA.Calidad
{
    partial class frmcalidad
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions8 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalidad));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grd_ingreso = new DevExpress.XtraGrid.GridControl();
            this.grdv_ingreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarimas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnprint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(121, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(563, 39);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Ingresos";
            // 
            // grd_ingreso
            // 
            this.grd_ingreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ingreso.DataMember = "IngresosMP";
            this.grd_ingreso.DataSource = this.dsRecepcionMPx;
            this.grd_ingreso.Location = new System.Drawing.Point(-1, 99);
            this.grd_ingreso.MainView = this.grdv_ingreso;
            this.grd_ingreso.Name = "grd_ingreso";
            this.grd_ingreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnver,
            this.btnprint});
            this.grd_ingreso.Size = new System.Drawing.Size(831, 542);
            this.grd_ingreso.TabIndex = 33;
            this.grd_ingreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ingreso});
            // 
            // grdv_ingreso
            // 
            this.grdv_ingreso.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ingreso.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_ingreso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_ingreso.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_ingreso.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ingreso.Appearance.Row.Options.UseFont = true;
            this.grdv_ingreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNingreso,
            this.colitemcode,
            this.colItemName,
            this.colid_proveedor,
            this.colCardName,
            this.coltarimas,
            this.colid,
            this.colprint});
            this.grdv_ingreso.GridControl = this.grd_ingreso;
            this.grdv_ingreso.Name = "grdv_ingreso";
            this.grdv_ingreso.OptionsView.ShowAutoFilterRow = true;
            this.grdv_ingreso.OptionsView.ShowGroupPanel = false;
            // 
            // colNingreso
            // 
            this.colNingreso.Caption = "Ingreso";
            this.colNingreso.FieldName = "Ningreso";
            this.colNingreso.Name = "colNingreso";
            this.colNingreso.OptionsColumn.AllowEdit = false;
            this.colNingreso.Visible = true;
            this.colNingreso.VisibleIndex = 0;
            this.colNingreso.Width = 74;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo MP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            this.colitemcode.Width = 102;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "MP";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 125;
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.Caption = "Codigo Prove.";
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            this.colid_proveedor.OptionsColumn.AllowEdit = false;
            this.colid_proveedor.Visible = true;
            this.colid_proveedor.VisibleIndex = 3;
            this.colid_proveedor.Width = 116;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Proveedor";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 4;
            this.colCardName.Width = 167;
            // 
            // coltarimas
            // 
            this.coltarimas.Caption = "Ver Detalle";
            this.coltarimas.ColumnEdit = this.btnver;
            this.coltarimas.Name = "coltarimas";
            this.coltarimas.Visible = true;
            this.coltarimas.VisibleIndex = 5;
            this.coltarimas.Width = 127;
            // 
            // btnver
            // 
            this.btnver.AutoHeight = false;
            editorButtonImageOptions7.Image = global::LOSA.Properties.Resources.tap;
            this.btnver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions7, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnver.Name = "btnver";
            this.btnver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colprint
            // 
            this.colprint.Caption = "Imprimir Hoja de Ingreso";
            this.colprint.ColumnEdit = this.btnprint;
            this.colprint.Name = "colprint";
            this.colprint.Width = 99;
            // 
            // btnprint
            // 
            this.btnprint.AutoHeight = false;
            editorButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions8.Image")));
            this.btnprint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions8, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject29, serializableAppearanceObject30, serializableAppearanceObject31, serializableAppearanceObject32, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnprint.Name = "btnprint";
            this.btnprint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(627, 4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 34;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmcalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 641);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.grd_ingreso);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcalidad";
            this.Text = "frmcalidad";
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grd_ingreso;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colNingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn coltarimas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnver;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colprint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnprint;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
    }
}