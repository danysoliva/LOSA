namespace LOSA.Mantenimientos
{
    partial class frmTipoPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPresentacion));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.tiposPresentacionesDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new LOSA.Mantenimientos.dsMantenimiento();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcTiposPresentaciones = new DevExpress.XtraGrid.GridControl();
            this.gvTiposPresentaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPresentacionesDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposPresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposPresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // tiposPresentacionesDataTableBindingSource
            // 
            this.tiposPresentacionesDataTableBindingSource.DataMember = "TiposPresentacionesDataTable";
            this.tiposPresentacionesDataTableBindingSource.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "LOSADataSet";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(427, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 71);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(199, 71);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gcTiposPresentaciones
            // 
            this.gcTiposPresentaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTiposPresentaciones.DataSource = this.tiposPresentacionesDataTableBindingSource;
            this.gcTiposPresentaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gcTiposPresentaciones.Location = new System.Drawing.Point(-1, 89);
            this.gcTiposPresentaciones.MainView = this.gvTiposPresentaciones;
            this.gcTiposPresentaciones.Name = "gcTiposPresentaciones";
            this.gcTiposPresentaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.repositoryItemCheckEdit1});
            this.gcTiposPresentaciones.Size = new System.Drawing.Size(638, 471);
            this.gcTiposPresentaciones.TabIndex = 32;
            this.gcTiposPresentaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTiposPresentaciones});
            // 
            // gvTiposPresentaciones
            // 
            this.gvTiposPresentaciones.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.gvTiposPresentaciones.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvTiposPresentaciones.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.gvTiposPresentaciones.Appearance.Row.Options.UseFont = true;
            this.gvTiposPresentaciones.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.gvTiposPresentaciones.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTiposPresentaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colenable,
            this.coleditar});
            this.gvTiposPresentaciones.GridControl = this.gcTiposPresentaciones;
            this.gvTiposPresentaciones.Name = "gvTiposPresentaciones";
            this.gvTiposPresentaciones.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Código";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 113;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 250;
            // 
            // colenable
            // 
            this.colenable.Caption = "Enable";
            this.colenable.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.OptionsColumn.ReadOnly = true;
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 2;
            this.colenable.Width = 67;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.edit;
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmTipoPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.gcTiposPresentaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoPresentacion";
            this.Text = "frmTipoPresentacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tiposPresentacionesDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTiposPresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTiposPresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tiposPresentacionesDataTableBindingSource;
        private dsMantenimiento dsMantenimiento;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcTiposPresentaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTiposPresentaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
    }
}