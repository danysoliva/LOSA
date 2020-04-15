namespace LOSA.Despachos
{
    partial class frmplanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmplanes));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_planes = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_planes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_plafinificada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldscripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colejecutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnejecutar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_orden_de_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_planes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_planes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnejecutar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(169, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(464, 49);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Planes de Despacho";
            // 
            // grd_planes
            // 
            this.grd_planes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_planes.DataMember = "planes_creados";
            this.grd_planes.DataSource = this.ds_despachos;
            this.grd_planes.Location = new System.Drawing.Point(1, 80);
            this.grd_planes.MainView = this.grdv_planes;
            this.grd_planes.Name = "grd_planes";
            this.grd_planes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnver,
            this.btnejecutar});
            this.grd_planes.Size = new System.Drawing.Size(833, 559);
            this.grd_planes.TabIndex = 38;
            this.grd_planes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_planes});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_planes
            // 
            this.grdv_planes.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_planes.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_planes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_planes.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_planes.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_planes.Appearance.Row.Options.UseFont = true;
            this.grdv_planes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNum,
            this.colid,
            this.colCardName,
            this.colCardCode,
            this.coldate_plafinificada,
            this.coldscripcion,
            this.colver,
            this.colejecutar,
            this.colid_orden_de_venta,
            this.colitemcode,
            this.colprioridad});
            this.grdv_planes.GridControl = this.grd_planes;
            this.grdv_planes.Name = "grdv_planes";
            this.grdv_planes.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_planes.OptionsView.ShowAutoFilterRow = true;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "N. SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 66;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Cod. Cliente";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Width = 196;
            // 
            // colCardCode
            // 
            this.colCardCode.Caption = "Cliente";
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.AllowEdit = false;
            this.colCardCode.Width = 133;
            // 
            // coldate_plafinificada
            // 
            this.coldate_plafinificada.Caption = "Fecha de planificacion";
            this.coldate_plafinificada.FieldName = "date_plafinificada";
            this.coldate_plafinificada.Name = "coldate_plafinificada";
            this.coldate_plafinificada.OptionsColumn.AllowEdit = false;
            this.coldate_plafinificada.Visible = true;
            this.coldate_plafinificada.VisibleIndex = 3;
            this.coldate_plafinificada.Width = 158;
            // 
            // coldscripcion
            // 
            this.coldscripcion.Caption = "Producto T.";
            this.coldscripcion.FieldName = "dscripcion";
            this.coldscripcion.Name = "coldscripcion";
            this.coldscripcion.OptionsColumn.AllowEdit = false;
            this.coldscripcion.Visible = true;
            this.coldscripcion.VisibleIndex = 1;
            this.coldscripcion.Width = 121;
            // 
            // colver
            // 
            this.colver.Caption = "Ver plan";
            this.colver.ColumnEdit = this.btnver;
            this.colver.Name = "colver";
            this.colver.Visible = true;
            this.colver.VisibleIndex = 5;
            this.colver.Width = 148;
            // 
            // btnver
            // 
            this.btnver.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnver.Name = "btnver";
            this.btnver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // colejecutar
            // 
            this.colejecutar.Caption = "Ejecutar";
            this.colejecutar.ColumnEdit = this.btnejecutar;
            this.colejecutar.Name = "colejecutar";
            this.colejecutar.Visible = true;
            this.colejecutar.VisibleIndex = 6;
            this.colejecutar.Width = 106;
            // 
            // btnejecutar
            // 
            this.btnejecutar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnejecutar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnejecutar.Click += new System.EventHandler(this.btnejecutar_Click);
            // 
            // colid_orden_de_venta
            // 
            this.colid_orden_de_venta.FieldName = "id_orden_de_venta";
            this.colid_orden_de_venta.Name = "colid_orden_de_venta";
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Cod.  PT.";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 2;
            this.colitemcode.Width = 87;
            // 
            // colprioridad
            // 
            this.colprioridad.Caption = "Prioridad";
            this.colprioridad.FieldName = "prioridad";
            this.colprioridad.Name = "colprioridad";
            this.colprioridad.Visible = true;
            this.colprioridad.VisibleIndex = 4;
            this.colprioridad.Width = 127;
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
            this.btnAtras.Location = new System.Drawing.Point(644, 4);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(180, 50);
            this.btnAtras.TabIndex = 39;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmplanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grd_planes);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmplanes";
            this.Text = "frmplanes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_planes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_planes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnejecutar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_planes;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_planes;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_plafinificada;
        private DevExpress.XtraGrid.Columns.GridColumn colver;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnver;
        private DevExpress.XtraGrid.Columns.GridColumn colejecutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnejecutar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden_de_venta;
        private DevExpress.XtraGrid.Columns.GridColumn coldscripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colprioridad;
    }
}