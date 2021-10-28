namespace LOSA.AlmacenesExterno
{
    partial class xfrmSeleccionarOC
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSeleccionarOC));
            this.gcOC = new DevExpress.XtraGrid.GridControl();
            this.oCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlmacenesExternos = new LOSA.AlmacenesExterno.dsAlmacenesExternos();
            this.gvOC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOC
            // 
            this.gcOC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOC.DataSource = this.oCBindingSource;
            this.gcOC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcOC.Location = new System.Drawing.Point(-1, 84);
            this.gcOC.MainView = this.gvOC;
            this.gcOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcOC.Name = "gcOC";
            this.gcOC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcOC.Size = new System.Drawing.Size(962, 428);
            this.gcOC.TabIndex = 35;
            this.gcOC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOC});
            // 
            // oCBindingSource
            // 
            this.oCBindingSource.DataMember = "OC";
            this.oCBindingSource.DataSource = this.dsAlmacenesExternos;
            // 
            // dsAlmacenesExternos
            // 
            this.dsAlmacenesExternos.DataSetName = "dsAlmacenesExternos";
            this.dsAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvOC
            // 
            this.gvOC.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvOC.Appearance.FocusedRow.Options.UseFont = true;
            this.gvOC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvOC.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvOC.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvOC.Appearance.Row.Options.UseFont = true;
            this.gvOC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDocNum,
            this.colCodProv,
            this.colProveedor,
            this.gridColumn1,
            this.colComentario,
            this.gridColumn2});
            this.gvOC.DetailHeight = 284;
            this.gvOC.GridControl = this.gcOC;
            this.gvOC.Name = "gvOC";
            this.gvOC.OptionsView.ShowAutoFilterRow = true;
            this.gvOC.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "DocEntrySAP";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 21;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 142;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "N. Documento";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.MinWidth = 21;
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.AllowEdit = false;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 1;
            this.colDocNum.Width = 141;
            // 
            // colCodProv
            // 
            this.colCodProv.FieldName = "CodProv";
            this.colCodProv.MinWidth = 21;
            this.colCodProv.Name = "colCodProv";
            this.colCodProv.OptionsColumn.AllowEdit = false;
            this.colCodProv.Visible = true;
            this.colCodProv.VisibleIndex = 2;
            this.colCodProv.Width = 141;
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.MinWidth = 21;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.OptionsColumn.AllowEdit = false;
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 3;
            this.colProveedor.Width = 141;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Fecha_Documento";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 141;
            // 
            // colComentario
            // 
            this.colComentario.FieldName = "Comentario";
            this.colComentario.MinWidth = 21;
            this.colComentario.Name = "colComentario";
            this.colComentario.OptionsColumn.AllowEdit = false;
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 5;
            this.colComentario.Width = 147;
            // 
            // gridColumn2
            // 
            this.gridColumn2.ColumnEdit = this.btnSeleccionar;
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 81;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(-2, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(962, 20);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Seleccionar Orden de Compra";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(795, 19);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 37;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmSeleccionarOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 513);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcOC);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfrmSeleccionarOC";
            this.Text = "xfrmSeleccionarOC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcOC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOC;
        private System.Windows.Forms.BindingSource oCBindingSource;
        private dsAlmacenesExternos dsAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProv;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
    }
}