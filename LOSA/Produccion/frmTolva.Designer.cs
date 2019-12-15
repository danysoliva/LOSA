namespace LOSA.Produccion
{
    partial class frmTolva
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTolva));
            this.gcTolva = new DevExpress.XtraGrid.GridControl();
            this.tolvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProduccion = new LOSA.Produccion.dsProduccion();
            this.gvTolva = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcTolva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTolva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTolva
            // 
            this.gcTolva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTolva.DataSource = this.tolvaBindingSource;
            this.gcTolva.Location = new System.Drawing.Point(-1, 87);
            this.gcTolva.MainView = this.gvTolva;
            this.gcTolva.Name = "gcTolva";
            this.gcTolva.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcTolva.Size = new System.Drawing.Size(624, 434);
            this.gcTolva.TabIndex = 0;
            this.gcTolva.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTolva});
            // 
            // tolvaBindingSource
            // 
            this.tolvaBindingSource.DataMember = "Tolva";
            this.tolvaBindingSource.DataSource = this.dsProduccion;
            // 
            // dsProduccion
            // 
            this.dsProduccion.DataSetName = "dsProduccion";
            this.dsProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTolva
            // 
            this.gvTolva.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTolva.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTolva.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTolva.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTolva.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvTolva.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTolva.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTolva.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTolva.Appearance.Row.Options.UseFont = true;
            this.gvTolva.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTolva.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTolva.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTolva.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTolva.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.collong_name,
            this.colSeleccionar});
            this.gvTolva.GridControl = this.gcTolva;
            this.gvTolva.Name = "gvTolva";
            this.gvTolva.OptionsView.ShowGroupPanel = false;
            this.gvTolva.DoubleClick += new System.EventHandler(this.GvTolva_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.AllowEdit = false;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            // 
            // collong_name
            // 
            this.collong_name.FieldName = "long_name";
            this.collong_name.Name = "collong_name";
            this.collong_name.OptionsColumn.AllowEdit = false;
            this.collong_name.Visible = true;
            this.collong_name.VisibleIndex = 1;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "#";
            this.colSeleccionar.ColumnEdit = this.btnSeleccionar;
            this.colSeleccionar.MaxWidth = 60;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 2;
            this.colSeleccionar.Width = 60;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions2.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnSeleccionar_ButtonClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(27, 21);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 47);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // frmTolva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcTolva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTolva";
            this.Text = "frmTolva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcTolva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTolva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTolva;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTolva;
        private System.Windows.Forms.BindingSource tolvaBindingSource;
        private dsProduccion dsProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn collong_name;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
    }
}