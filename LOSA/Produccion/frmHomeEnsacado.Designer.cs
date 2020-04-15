namespace LOSA.Produccion
{
    partial class frmHomeEnsacado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeEnsacado));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsProduccion1 = new LOSA.Produccion.dsProduccion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfp_lot_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinish_product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colacs_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTarima = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarima)).BeginInit();
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
            this.btnAtras.Location = new System.Drawing.Point(453, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 66);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "home_sacos_pt";
            this.gridControl1.DataSource = this.dsProduccion1;
            this.gridControl1.Location = new System.Drawing.Point(4, 87);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnTarima});
            this.gridControl1.Size = new System.Drawing.Size(616, 432);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfp_lot_number,
            this.colfinish_product,
            this.colformula,
            this.colstatus,
            this.colacs_id,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colfp_lot_number
            // 
            this.colfp_lot_number.Caption = "Lote";
            this.colfp_lot_number.FieldName = "fp_lot_number";
            this.colfp_lot_number.Name = "colfp_lot_number";
            this.colfp_lot_number.Visible = true;
            this.colfp_lot_number.VisibleIndex = 0;
            // 
            // colfinish_product
            // 
            this.colfinish_product.Caption = "Producto";
            this.colfinish_product.FieldName = "finish_product";
            this.colfinish_product.Name = "colfinish_product";
            this.colfinish_product.Visible = true;
            this.colfinish_product.VisibleIndex = 1;
            // 
            // colformula
            // 
            this.colformula.Caption = "Formula";
            this.colformula.FieldName = "formula";
            this.colformula.Name = "colformula";
            this.colformula.Visible = true;
            this.colformula.VisibleIndex = 2;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // colacs_id
            // 
            this.colacs_id.FieldName = "acs_id";
            this.colacs_id.Name = "colacs_id";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tarimas";
            this.gridColumn1.ColumnEdit = this.btnTarima;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // btnTarima
            // 
            this.btnTarima.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.pallet_pallet_solo;
            this.btnTarima.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnTarima.Name = "btnTarima";
            this.btnTarima.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnTarima.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // frmHomeEnsacado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeEnsacado";
            this.Text = "frmHomeEnsacado";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsProduccion dsProduccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colfp_lot_number;
        private DevExpress.XtraGrid.Columns.GridColumn colfinish_product;
        private DevExpress.XtraGrid.Columns.GridColumn colformula;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colacs_id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnTarima;
    }
}