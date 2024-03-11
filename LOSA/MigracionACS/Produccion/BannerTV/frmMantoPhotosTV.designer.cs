
namespace LOSA.MigracionACS.Produccion.BannerTV
{
    partial class frmMantoPhotosTV
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantoPhotosTV));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsBanner1 = new LOSA.MigracionACS.Produccion.BannerTV.dsBanner();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_adjunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_user_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_update = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditarl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colVer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerImg = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colinterval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "bannerhome";
            this.gridControl1.DataSource = this.dsBanner1;
            this.gridControl1.Location = new System.Drawing.Point(1, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEdit,
            this.cmdVerImg});
            this.gridControl1.Size = new System.Drawing.Size(766, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsBanner1
            // 
            this.dsBanner1.DataSetName = "dsBanner";
            this.dsBanner1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcaption,
            this.colid_tab,
            this.colid_adjunto,
            this.colvisible,
            this.colenable,
            this.coldate_,
            this.collast_user_update,
            this.collast_update,
            this.colEditarl,
            this.colVer,
            this.colinterval});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_tab, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcaption
            // 
            this.colcaption.Caption = "Descripción";
            this.colcaption.FieldName = "caption";
            this.colcaption.Name = "colcaption";
            this.colcaption.OptionsColumn.AllowEdit = false;
            this.colcaption.Visible = true;
            this.colcaption.VisibleIndex = 0;
            this.colcaption.Width = 363;
            // 
            // colid_tab
            // 
            this.colid_tab.Caption = "Tab Index";
            this.colid_tab.FieldName = "id_tab";
            this.colid_tab.Name = "colid_tab";
            this.colid_tab.OptionsColumn.AllowEdit = false;
            this.colid_tab.Visible = true;
            this.colid_tab.VisibleIndex = 1;
            this.colid_tab.Width = 74;
            // 
            // colid_adjunto
            // 
            this.colid_adjunto.FieldName = "id_adjunto";
            this.colid_adjunto.Name = "colid_adjunto";
            // 
            // colvisible
            // 
            this.colvisible.Caption = "Visible";
            this.colvisible.FieldName = "visible";
            this.colvisible.Name = "colvisible";
            this.colvisible.OptionsColumn.AllowEdit = false;
            this.colvisible.Visible = true;
            this.colvisible.VisibleIndex = 2;
            this.colvisible.Width = 72;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // coldate_
            // 
            this.coldate_.FieldName = "date_";
            this.coldate_.Name = "coldate_";
            // 
            // collast_user_update
            // 
            this.collast_user_update.FieldName = "last_user_update";
            this.collast_user_update.Name = "collast_user_update";
            // 
            // collast_update
            // 
            this.collast_update.FieldName = "last_update";
            this.collast_update.Name = "collast_update";
            // 
            // colEditarl
            // 
            this.colEditarl.Caption = "Edit";
            this.colEditarl.ColumnEdit = this.cmdEdit;
            this.colEditarl.Name = "colEditarl";
            this.colEditarl.Visible = true;
            this.colEditarl.VisibleIndex = 4;
            this.colEditarl.Width = 80;
            // 
            // cmdEdit
            // 
            this.cmdEdit.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmdEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEdit_ButtonClick);
            // 
            // colVer
            // 
            this.colVer.Caption = "Ver Imagen";
            this.colVer.ColumnEdit = this.cmdVerImg;
            this.colVer.Name = "colVer";
            this.colVer.Visible = true;
            this.colVer.VisibleIndex = 5;
            this.colVer.Width = 87;
            // 
            // cmdVerImg
            // 
            this.cmdVerImg.AutoHeight = false;
            editorButtonImageOptions4.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions4.SvgImage")));
            this.cmdVerImg.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerImg.Name = "cmdVerImg";
            this.cmdVerImg.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerImg.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerImg_ButtonClick);
            // 
            // colinterval
            // 
            this.colinterval.Caption = "Segundos Visible";
            this.colinterval.DisplayFormat.FormatString = "##0";
            this.colinterval.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colinterval.FieldName = "interval";
            this.colinterval.Name = "colinterval";
            this.colinterval.Visible = true;
            this.colinterval.VisibleIndex = 3;
            this.colinterval.Width = 72;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(238, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(233, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Configuración Carrousel TV";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMantoPhotosTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 469);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantoPhotosTV";
            this.Text = "Setting TV";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsBanner dsBanner1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcaption;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tab;
        private DevExpress.XtraGrid.Columns.GridColumn colid_adjunto;
        private DevExpress.XtraGrid.Columns.GridColumn colvisible;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_;
        private DevExpress.XtraGrid.Columns.GridColumn collast_user_update;
        private DevExpress.XtraGrid.Columns.GridColumn collast_update;
        private DevExpress.XtraGrid.Columns.GridColumn colEditarl;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colVer;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colinterval;
    }
}