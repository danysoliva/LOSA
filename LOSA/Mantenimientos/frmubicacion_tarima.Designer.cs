namespace LOSA.Mantenimientos
{
    partial class frmubicacion_tarima
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmubicacion_tarima));
            this.gcBodegas = new DevExpress.XtraGrid.GridControl();
            this.lOSAubicaciontarimaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new LOSA.Mantenimientos.dsMantenimiento();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescripcion = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvBodegas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOSAubicaciontarimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.lOSA_ubicacion_tarimaTableAdapter = new LOSA.Mantenimientos.dsMantenimientoTableAdapters.LOSA_ubicacion_tarimaTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicaciontarimaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicaciontarimaBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcBodegas
            // 
            this.gcBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBodegas.DataSource = this.lOSAubicaciontarimaBindingSource1;
            this.gcBodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gcBodegas.Location = new System.Drawing.Point(-1, 165);
            this.gcBodegas.MainView = this.gridView1;
            this.gcBodegas.Name = "gcBodegas";
            this.gcBodegas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.repositoryItemCheckEdit1,
            this.txtDescripcion});
            this.gcBodegas.Size = new System.Drawing.Size(647, 674);
            this.gcBodegas.TabIndex = 37;
            this.gcBodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gvBodegas});
            // 
            // lOSAubicaciontarimaBindingSource1
            // 
            this.lOSAubicaciontarimaBindingSource1.DataMember = "LOSA_ubicacion_tarima";
            this.lOSAubicaciontarimaBindingSource1.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "dsMantenimiento";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1156, 390, 210, 228);
            this.gridView1.GridControl = this.gcBodegas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tarima";
            this.gridColumn2.ColumnEdit = this.txtDescripcion;
            this.gridColumn2.FieldName = "pasillo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 176;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ubicacion";
            this.gridColumn3.FieldName = "descripcion_corta";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 120;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Enable";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn4.FieldName = "enable";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 74;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Editar";
            this.gridColumn5.ColumnEdit = this.btnEditar;
            this.gridColumn5.FieldName = "editar";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 64;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.edit;
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Estado";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 83;
            // 
            // gvBodegas
            // 
            this.gvBodegas.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvBodegas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedRow.Options.UseFont = true;
            this.gvBodegas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvBodegas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBodegas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvBodegas.Appearance.Row.Options.UseFont = true;
            this.gvBodegas.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvBodegas.Appearance.SelectedRow.Options.UseFont = true;
            this.gvBodegas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvBodegas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.coldescripcion_corta,
            this.colenable,
            this.coleditar});
            this.gvBodegas.GridControl = this.gcBodegas;
            this.gvBodegas.Name = "gvBodegas";
            this.gvBodegas.OptionsView.RowAutoHeight = true;
            this.gvBodegas.OptionsView.ShowAutoFilterRow = true;
            this.gvBodegas.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Código";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Width = 113;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.ColumnEdit = this.txtDescripcion;
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 250;
            // 
            // coldescripcion_corta
            // 
            this.coldescripcion_corta.Caption = "Descripción Corta";
            this.coldescripcion_corta.FieldName = "descripcion_corta";
            this.coldescripcion_corta.Name = "coldescripcion_corta";
            this.coldescripcion_corta.OptionsColumn.AllowEdit = false;
            this.coldescripcion_corta.Visible = true;
            this.coldescripcion_corta.VisibleIndex = 1;
            this.coldescripcion_corta.Width = 167;
            // 
            // colenable
            // 
            this.colenable.Caption = "Enable";
            this.colenable.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 2;
            this.colenable.Width = 67;
            // 
            // coleditar
            // 
            this.coleditar.Caption = "Editar";
            this.coleditar.ColumnEdit = this.btnEditar;
            this.coleditar.FieldName = "editar";
            this.coleditar.Name = "coleditar";
            this.coleditar.Visible = true;
            this.coleditar.VisibleIndex = 3;
            this.coleditar.Width = 53;
            // 
            // lOSAubicaciontarimaBindingSource
            // 
            this.lOSAubicaciontarimaBindingSource.DataMember = "LOSA_ubicacion_tarima";
            this.lOSAubicaciontarimaBindingSource.DataSource = this.dsMantenimiento;
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(18, 88);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(199, 71);
            this.btnAtras.TabIndex = 36;
            this.btnAtras.Text = "Atras";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(148, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(324, 30);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Mantenimiento Ubicacion tarima";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(430, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 71);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            // 
            // lOSA_ubicacion_tarimaTableAdapter
            // 
            this.lOSA_ubicacion_tarimaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(649, 25);
            this.fillByToolStrip.TabIndex = 39;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // frmubicacion_tarima
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gcBodegas);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmubicacion_tarima";
            this.Size = new System.Drawing.Size(649, 613);
            ((System.ComponentModel.ISupportInitialize)(this.gcBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicaciontarimaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOSAubicaciontarimaBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBodegas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_corta;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.BindingSource lOSAubicaciontarimaBindingSource;
        private dsMantenimiento dsMantenimiento;
        private dsMantenimientoTableAdapters.LOSA_ubicacion_tarimaTableAdapter lOSA_ubicacion_tarimaTableAdapter;
        private System.Windows.Forms.BindingSource lOSAubicaciontarimaBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
