
namespace LOSA.MigracionACS.SAR
{
    partial class frm_select_pv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_select_pv));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "proveedores";
            this.grd_data.DataSource = this.dS_SAR;
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 0);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.grd_data.Size = new System.Drawing.Size(686, 547);
            this.grd_data.TabIndex = 2;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_data.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdv_data.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_data.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.grdv_data.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.SelectedRow.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grdv_data.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcarcode,
            this.colcardname,
            this.seleccionar});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsCustomization.AllowFilter = false;
            this.grdv_data.OptionsFilter.AllowFilterEditor = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.DoubleClick += new System.EventHandler(this.grdv_data_DoubleClick);
            // 
            // colcarcode
            // 
            this.colcarcode.Caption = "Codigo";
            this.colcarcode.FieldName = "carcode";
            this.colcarcode.Name = "colcarcode";
            this.colcarcode.OptionsColumn.AllowEdit = false;
            // 
            // colcardname
            // 
            this.colcardname.Caption = "Proveedor";
            this.colcardname.FieldName = "cardname";
            this.colcardname.Name = "colcardname";
            this.colcardname.OptionsColumn.AllowEdit = false;
            this.colcardname.Visible = true;
            this.colcardname.VisibleIndex = 0;
            this.colcardname.Width = 464;
            // 
            // seleccionar
            // 
            this.seleccionar.Caption = "Seleccionar";
            this.seleccionar.ColumnEdit = this.btnSeleccionar;
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Visible = true;
            this.seleccionar.VisibleIndex = 1;
            this.seleccionar.Width = 140;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frm_select_pv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 547);
            this.Controls.Add(this.grd_data);
            this.Name = "frm_select_pv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_select_pv";
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colcarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcardname;
        private DevExpress.XtraGrid.Columns.GridColumn seleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private dS_SAR dS_SAR;
    }
}