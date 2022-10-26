
namespace LOSA.Tools
{
    partial class xfrmPopup
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPopup));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpLeidas = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpSinLeer = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsToolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTools = new LOSA.Tools.dsTools();
            this.gvSinLeer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIr = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tnpLeidas = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tpLeidas)).BeginInit();
            this.tpLeidas.SuspendLayout();
            this.tnpSinLeer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsToolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinLeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIr)).BeginInit();
            this.tnpLeidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "leida";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 460;
            // 
            // tpLeidas
            // 
            this.tpLeidas.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLeidas.AppearanceButton.Hovered.Options.UseFont = true;
            this.tpLeidas.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLeidas.AppearanceButton.Normal.Options.UseFont = true;
            this.tpLeidas.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLeidas.AppearanceButton.Pressed.Options.UseFont = true;
            this.tpLeidas.Controls.Add(this.tnpSinLeer);
            this.tpLeidas.Controls.Add(this.tnpLeidas);
            this.tpLeidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLeidas.Location = new System.Drawing.Point(0, 0);
            this.tpLeidas.Name = "tpLeidas";
            this.tpLeidas.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpSinLeer,
            this.tnpLeidas});
            this.tpLeidas.RegularSize = new System.Drawing.Size(705, 415);
            this.tpLeidas.SelectedPage = this.tnpSinLeer;
            this.tpLeidas.Size = new System.Drawing.Size(705, 415);
            this.tpLeidas.TabIndex = 0;
            this.tpLeidas.Text = "tabPane1";
            // 
            // tnpSinLeer
            // 
            this.tnpSinLeer.Caption = "Sin Leer";
            this.tnpSinLeer.Controls.Add(this.gridControl1);
            this.tnpSinLeer.Name = "tnpSinLeer";
            this.tnpSinLeer.Size = new System.Drawing.Size(705, 384);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Notificaciones";
            this.gridControl1.DataSource = this.dsToolsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvSinLeer;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIr});
            this.gridControl1.Size = new System.Drawing.Size(705, 384);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSinLeer});
            // 
            // dsToolsBindingSource
            // 
            this.dsToolsBindingSource.DataSource = this.dsTools;
            this.dsToolsBindingSource.Position = 0;
            // 
            // dsTools
            // 
            this.dsTools.DataSetName = "dsTools";
            this.dsTools.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSinLeer
            // 
            this.gvSinLeer.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSinLeer.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSinLeer.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSinLeer.Appearance.Row.Options.UseFont = true;
            this.gvSinLeer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDescripcion,
            this.gridColumn3,
            this.gridColumn4});
            gridFormatRule1.Column = this.gridColumn3;
            gridFormatRule1.ColumnApplyTo = this.colDescripcion;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "[leida] = True";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gvSinLeer.FormatRules.Add(gridFormatRule1);
            this.gvSinLeer.GridControl = this.gridControl1;
            this.gvSinLeer.Name = "gvSinLeer";
            this.gvSinLeer.OptionsView.ShowGroupPanel = false;
            this.gvSinLeer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvSinLeer_RowClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colid.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.ColumnEdit = this.btnIr;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // btnIr
            // 
            this.btnIr.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnIr.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnIr.Name = "btnIr";
            this.btnIr.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnIr.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnIr_ButtonClick);
            // 
            // tnpLeidas
            // 
            this.tnpLeidas.Caption = "Leídas";
            this.tnpLeidas.Controls.Add(this.gridControl2);
            this.tnpLeidas.Name = "tnpLeidas";
            this.tnpLeidas.Size = new System.Drawing.Size(705, 384);
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "NotificacionesLeidas";
            this.gridControl2.DataSource = this.dsToolsBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(705, 384);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gridView2.FormatRules.Add(gridFormatRule2);
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 460;
            // 
            // xfrmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 415);
            this.Controls.Add(this.tpLeidas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tpLeidas)).EndInit();
            this.tpLeidas.ResumeLayout(false);
            this.tnpSinLeer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsToolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSinLeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIr)).EndInit();
            this.tnpLeidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tpLeidas;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpSinLeer;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpLeidas;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSinLeer;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource dsToolsBindingSource;
        private dsTools dsTools;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIr;
    }
}