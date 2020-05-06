namespace LOSA.Despachos
{
    partial class frmdespachos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdespachos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_despachos = new DevExpress.XtraGrid.GridControl();
            this.ds_despachos = new LOSA.Despachos.ds_despachos();
            this.grdv_despachos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_numero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_despachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtras.Location = new System.Drawing.Point(658, 13);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(180, 50);
            this.btnAtras.TabIndex = 34;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(201, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(364, 41);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Planificacion de despacho";
            // 
            // grd_despachos
            // 
            this.grd_despachos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_despachos.DataMember = "orden_venta";
            this.grd_despachos.DataSource = this.ds_despachos;
            this.grd_despachos.Location = new System.Drawing.Point(-2, 105);
            this.grd_despachos.MainView = this.grdv_despachos;
            this.grd_despachos.Name = "grd_despachos";
            this.grd_despachos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_ver});
            this.grd_despachos.Size = new System.Drawing.Size(853, 587);
            this.grd_despachos.TabIndex = 36;
            this.grd_despachos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_despachos});
            // 
            // ds_despachos
            // 
            this.ds_despachos.DataSetName = "ds_despachos";
            this.ds_despachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_despachos
            // 
            this.grdv_despachos.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_despachos.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_despachos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_despachos.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_despachos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_despachos.Appearance.Row.Options.UseFont = true;
            this.grdv_despachos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDocEntry,
            this.colDocNum,
            this.colCardName,
            this.colCardCode,
            this.coloc_numero,
            this.colDocDate,
            this.colComentario,
            this.Colseleccionar});
            this.grdv_despachos.GridControl = this.grd_despachos;
            this.grdv_despachos.Name = "grdv_despachos";
            this.grdv_despachos.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colDocEntry
            // 
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            // 
            // colDocNum
            // 
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 101;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Cliente";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 1;
            this.colCardName.Width = 165;
            // 
            // colCardCode
            // 
            this.colCardCode.Caption = "Cod. Cliente";
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            this.colCardCode.OptionsColumn.AllowEdit = false;
            this.colCardCode.Visible = true;
            this.colCardCode.VisibleIndex = 2;
            this.colCardCode.Width = 121;
            // 
            // coloc_numero
            // 
            this.coloc_numero.Caption = "orden de venta cliente";
            this.coloc_numero.FieldName = "oc_numero";
            this.coloc_numero.Name = "coloc_numero";
            this.coloc_numero.OptionsColumn.AllowEdit = false;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Fecha de documento";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.AllowEdit = false;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 3;
            this.colDocDate.Width = 204;
            // 
            // colComentario
            // 
            this.colComentario.Caption = "Comentario";
            this.colComentario.FieldName = "Comentario";
            this.colComentario.Name = "colComentario";
            this.colComentario.OptionsColumn.AllowEdit = false;
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 4;
            this.colComentario.Width = 170;
            // 
            // Colseleccionar
            // 
            this.Colseleccionar.Caption = "Ver";
            this.Colseleccionar.ColumnEdit = this.btn_ver;
            this.Colseleccionar.CustomizationCaption = "Seleccionar";
            this.Colseleccionar.Name = "Colseleccionar";
            this.Colseleccionar.Visible = true;
            this.Colseleccionar.VisibleIndex = 5;
            this.Colseleccionar.Width = 72;
            // 
            // btn_ver
            // 
            this.btn_ver.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btn_ver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // frmdespachos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.grd_despachos);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdespachos";
            this.Text = "frmdespachos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_despachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grd_despachos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_despachos;
        private ds_despachos ds_despachos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_numero;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.Columns.GridColumn Colseleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_ver;
    }
}