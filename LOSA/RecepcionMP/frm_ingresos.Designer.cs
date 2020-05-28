namespace LOSA.RecepcionMP
{
    partial class frm_ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ingresos));
            this.grd_ingreso = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.grdv_ingreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarimas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_ingreso
            // 
            this.grd_ingreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ingreso.DataMember = "IngresosMP";
            this.grd_ingreso.DataSource = this.dsRecepcionMPx;
            this.grd_ingreso.Location = new System.Drawing.Point(1, 86);
            this.grd_ingreso.MainView = this.grdv_ingreso;
            this.grd_ingreso.Name = "grd_ingreso";
            this.grd_ingreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnver});
            this.grd_ingreso.Size = new System.Drawing.Size(828, 556);
            this.grd_ingreso.TabIndex = 0;
            this.grd_ingreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ingreso});
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colid});
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
            this.colNingreso.Width = 71;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo MP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            this.colitemcode.Width = 97;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "MP";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 119;
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.Caption = "Codigo Prove.";
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            this.colid_proveedor.OptionsColumn.AllowEdit = false;
            this.colid_proveedor.Visible = true;
            this.colid_proveedor.VisibleIndex = 3;
            this.colid_proveedor.Width = 111;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Proveedor";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 4;
            this.colCardName.Width = 159;
            // 
            // coltarimas
            // 
            this.coltarimas.Caption = "Ver Detalle";
            this.coltarimas.ColumnEdit = this.btnver;
            this.coltarimas.Name = "coltarimas";
            this.coltarimas.Visible = true;
            this.coltarimas.VisibleIndex = 5;
            this.coltarimas.Width = 137;
            // 
            // btnver
            // 
            this.btnver.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnver.Name = "btnver";
            this.btnver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(645, 8);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(8, 8);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 58);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar Ingreso";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(269, 22);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(272, 44);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Ingresos de MP";
            // 
            // frm_ingresos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(829, 641);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grd_ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ingresos";
            this.Text = "frm_ingresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_ingreso;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ingreso;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn colNingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn coltarimas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnver;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
    }
}