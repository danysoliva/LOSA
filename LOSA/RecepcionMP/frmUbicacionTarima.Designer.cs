namespace LOSA.RecepcionMP
{
    partial class frmUbicacionTarima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUbicacionTarima));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcUbicacion = new DevExpress.XtraGrid.GridControl();
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvUbicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpasillo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaltura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprofundidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
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
            this.labelControl3.Location = new System.Drawing.Point(217, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(407, 21);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Ubicación Tarima";
            // 
            // gcUbicacion
            // 
            this.gcUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUbicacion.DataSource = this.ubicacionesBindingSource;
            this.gcUbicacion.Location = new System.Drawing.Point(0, 89);
            this.gcUbicacion.MainView = this.gvUbicacion;
            this.gcUbicacion.Name = "gcUbicacion";
            this.gcUbicacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcUbicacion.Size = new System.Drawing.Size(622, 432);
            this.gcUbicacion.TabIndex = 14;
            this.gcUbicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUbicacion});
            // 
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.dsRecepcionMPx;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvUbicacion
            // 
            this.gvUbicacion.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvUbicacion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvUbicacion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvUbicacion.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvUbicacion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.FocusedRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvUbicacion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUbicacion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvUbicacion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvUbicacion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvUbicacion.Appearance.Row.Options.UseFont = true;
            this.gvUbicacion.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvUbicacion.Appearance.SelectedRow.Options.UseFont = true;
            this.gvUbicacion.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvUbicacion.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvUbicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colpasillo,
            this.colrack,
            this.colaltura,
            this.colprofundidad,
            this.colenable,
            this.colSeleccionar});
            this.gvUbicacion.GridControl = this.gcUbicacion;
            this.gvUbicacion.Name = "gvUbicacion";
            this.gvUbicacion.OptionsCustomization.AllowFilter = false;
            this.gvUbicacion.OptionsView.ShowAutoFilterRow = true;
            this.gvUbicacion.OptionsView.ShowGroupPanel = false;
            this.gvUbicacion.DoubleClick += new System.EventHandler(this.GvUbicacion_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colpasillo
            // 
            this.colpasillo.FieldName = "pasillo";
            this.colpasillo.Name = "colpasillo";
            this.colpasillo.OptionsColumn.AllowEdit = false;
            this.colpasillo.Visible = true;
            this.colpasillo.VisibleIndex = 0;
            // 
            // colrack
            // 
            this.colrack.FieldName = "rack";
            this.colrack.Name = "colrack";
            this.colrack.OptionsColumn.AllowEdit = false;
            this.colrack.Visible = true;
            this.colrack.VisibleIndex = 1;
            // 
            // colaltura
            // 
            this.colaltura.FieldName = "altura";
            this.colaltura.Name = "colaltura";
            this.colaltura.OptionsColumn.AllowEdit = false;
            this.colaltura.Visible = true;
            this.colaltura.VisibleIndex = 2;
            // 
            // colprofundidad
            // 
            this.colprofundidad.FieldName = "profundidad";
            this.colprofundidad.Name = "colprofundidad";
            this.colprofundidad.OptionsColumn.AllowEdit = false;
            this.colprofundidad.Visible = true;
            this.colprofundidad.VisibleIndex = 3;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "#";
            this.colSeleccionar.ColumnEdit = this.btnSeleccionar;
            this.colSeleccionar.FieldName = "seleccionar";
            this.colSeleccionar.MaxWidth = 50;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 4;
            this.colSeleccionar.Width = 50;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // frmUbicacionTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.gcUbicacion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUbicacionTarima";
            this.Text = "frmUbicacionTarima";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcUbicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUbicacion;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colpasillo;
        private DevExpress.XtraGrid.Columns.GridColumn colrack;
        private DevExpress.XtraGrid.Columns.GridColumn colaltura;
        private DevExpress.XtraGrid.Columns.GridColumn colprofundidad;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
    }
}