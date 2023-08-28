
namespace LOSA.Calidad.Parametros
{
    partial class frmAdjuntos_PT
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjuntos_PT));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_adjuntos = new DevExpress.XtraGrid.GridControl();
            this.grdv_adjuntos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbit_subido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpath_load = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdjuntar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdjuntarDocumento = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colabrir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAbrirAdjunto = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid_conf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfile_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Desadjuntar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDesligar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dsTRZ_Reports1 = new LOSA.Calidad.dsTRZ_Reports();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grd_adjuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_adjuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntarDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrirAdjunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesligar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRZ_Reports1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_adjuntos
            // 
            this.grd_adjuntos.DataMember = "adjuntos_pt";
            this.grd_adjuntos.DataSource = this.dsTRZ_Reports1;
            this.grd_adjuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_adjuntos.Location = new System.Drawing.Point(0, 0);
            this.grd_adjuntos.MainView = this.grdv_adjuntos;
            this.grd_adjuntos.Name = "grd_adjuntos";
            this.grd_adjuntos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAdjuntarDocumento,
            this.btnAbrirAdjunto,
            this.btnDesligar});
            this.grd_adjuntos.Size = new System.Drawing.Size(779, 543);
            this.grd_adjuntos.TabIndex = 39;
            this.grd_adjuntos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_adjuntos});
            // 
            // grdv_adjuntos
            // 
            this.grdv_adjuntos.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_adjuntos.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_adjuntos.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_adjuntos.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_adjuntos.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_adjuntos.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_adjuntos.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_adjuntos.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_adjuntos.Appearance.Preview.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_adjuntos.Appearance.Row.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_adjuntos.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_adjuntos.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_adjuntos.Appearance.ViewCaption.Options.UseFont = true;
            this.grdv_adjuntos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdjunto,
            this.colpath,
            this.colbit_subido,
            this.colpath_load,
            this.colid_registro,
            this.colAdjuntar,
            this.colabrir,
            this.colid_conf,
            this.colfile_name,
            this.Desadjuntar});
            this.grdv_adjuntos.GridControl = this.grd_adjuntos;
            this.grdv_adjuntos.LevelIndent = 0;
            this.grdv_adjuntos.Name = "grdv_adjuntos";
            this.grdv_adjuntos.OptionsEditForm.PopupEditFormWidth = 400;
            this.grdv_adjuntos.OptionsView.ShowAutoFilterRow = true;
            this.grdv_adjuntos.OptionsView.ShowGroupPanel = false;
            this.grdv_adjuntos.OptionsView.ShowViewCaption = true;
            this.grdv_adjuntos.PreviewIndent = 0;
            this.grdv_adjuntos.ViewCaption = "Documentos Adjuntos";
            // 
            // colAdjunto
            // 
            this.colAdjunto.Caption = "Documento";
            this.colAdjunto.FieldName = "Adjunto";
            this.colAdjunto.Name = "colAdjunto";
            this.colAdjunto.OptionsColumn.AllowEdit = false;
            this.colAdjunto.Visible = true;
            this.colAdjunto.VisibleIndex = 0;
            this.colAdjunto.Width = 408;
            // 
            // colpath
            // 
            this.colpath.FieldName = "path";
            this.colpath.Name = "colpath";
            this.colpath.OptionsColumn.AllowEdit = false;
            // 
            // colbit_subido
            // 
            this.colbit_subido.Caption = "Cargado";
            this.colbit_subido.FieldName = "bit_subido";
            this.colbit_subido.Name = "colbit_subido";
            this.colbit_subido.OptionsColumn.AllowEdit = false;
            this.colbit_subido.Width = 116;
            // 
            // colpath_load
            // 
            this.colpath_load.FieldName = "path_load";
            this.colpath_load.Name = "colpath_load";
            this.colpath_load.OptionsColumn.AllowEdit = false;
            // 
            // colid_registro
            // 
            this.colid_registro.FieldName = "id_registro";
            this.colid_registro.Name = "colid_registro";
            this.colid_registro.OptionsColumn.AllowEdit = false;
            // 
            // colAdjuntar
            // 
            this.colAdjuntar.Caption = "Adjuntar";
            this.colAdjuntar.ColumnEdit = this.btnAdjuntarDocumento;
            this.colAdjuntar.Name = "colAdjuntar";
            this.colAdjuntar.Visible = true;
            this.colAdjuntar.VisibleIndex = 2;
            this.colAdjuntar.Width = 122;
            // 
            // btnAdjuntarDocumento
            // 
            this.btnAdjuntarDocumento.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnAdjuntarDocumento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento";
            this.btnAdjuntarDocumento.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAdjuntarDocumento.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAdjuntarDocumento_ButtonClick);
            // 
            // colabrir
            // 
            this.colabrir.Caption = "Abrir";
            this.colabrir.ColumnEdit = this.btnAbrirAdjunto;
            this.colabrir.Name = "colabrir";
            this.colabrir.Visible = true;
            this.colabrir.VisibleIndex = 1;
            this.colabrir.Width = 122;
            // 
            // btnAbrirAdjunto
            // 
            this.btnAbrirAdjunto.AutoHeight = false;
            editorButtonImageOptions5.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions5.SvgImage")));
            this.btnAbrirAdjunto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAbrirAdjunto.Name = "btnAbrirAdjunto";
            this.btnAbrirAdjunto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colid_conf
            // 
            this.colid_conf.FieldName = "id_conf";
            this.colid_conf.Name = "colid_conf";
            // 
            // colfile_name
            // 
            this.colfile_name.FieldName = "file_name";
            this.colfile_name.Name = "colfile_name";
            // 
            // Desadjuntar
            // 
            this.Desadjuntar.Caption = "Desadjuntar";
            this.Desadjuntar.ColumnEdit = this.btnDesligar;
            this.Desadjuntar.Name = "Desadjuntar";
            this.Desadjuntar.Visible = true;
            this.Desadjuntar.VisibleIndex = 3;
            this.Desadjuntar.Width = 102;
            // 
            // btnDesligar
            // 
            this.btnDesligar.AutoHeight = false;
            editorButtonImageOptions6.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions6.SvgImage")));
            this.btnDesligar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // dsTRZ_Reports1
            // 
            this.dsTRZ_Reports1.DataSetName = "dsTRZ_Reports";
            this.dsTRZ_Reports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAdjuntos_PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 543);
            this.Controls.Add(this.grd_adjuntos);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmAdjuntos_PT";
            ((System.ComponentModel.ISupportInitialize)(this.grd_adjuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_adjuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntarDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrirAdjunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDesligar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRZ_Reports1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_adjuntos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_adjuntos;
        private DevExpress.XtraGrid.Columns.GridColumn colAdjunto;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAbrirAdjunto;
        private DevExpress.XtraGrid.Columns.GridColumn colpath;
        private DevExpress.XtraGrid.Columns.GridColumn colbit_subido;
        private DevExpress.XtraGrid.Columns.GridColumn colpath_load;
        private DevExpress.XtraGrid.Columns.GridColumn colid_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colAdjuntar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAdjuntarDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colabrir;
        private DevExpress.XtraGrid.Columns.GridColumn colid_conf;
        private DevExpress.XtraGrid.Columns.GridColumn colfile_name;
        private DevExpress.XtraGrid.Columns.GridColumn Desadjuntar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDesligar;
        private dsTRZ_Reports dsTRZ_Reports1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}