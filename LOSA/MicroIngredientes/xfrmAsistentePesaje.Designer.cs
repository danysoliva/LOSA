
namespace LOSA.MicroIngredientes
{
    partial class xfrmAsistentePesaje
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAsistentePesaje));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcPesaje = new DevExpress.XtraGrid.GridControl();
            this.dsMicros = new LOSA.MicroIngredientes.dsMicros();
            this.gvPesaje = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPesar1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPesar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPesaje
            // 
            this.gcPesaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPesaje.DataMember = "New_Pesaje";
            this.gcPesaje.DataSource = this.dsMicros;
            this.gcPesaje.Location = new System.Drawing.Point(1, 1);
            this.gcPesaje.MainView = this.gvPesaje;
            this.gcPesaje.Name = "gcPesaje";
            this.gcPesaje.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPesar1,
            this.repositoryItemButtonEdit1});
            this.gcPesaje.Size = new System.Drawing.Size(1106, 362);
            this.gcPesaje.TabIndex = 2;
            this.gcPesaje.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPesaje});
            // 
            // dsMicros
            // 
            this.dsMicros.DataSetName = "dsMicros";
            this.dsMicros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPesaje
            // 
            this.gvPesaje.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvPesaje.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPesaje.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvPesaje.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPesaje.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPesaje.Appearance.FooterPanel.Options.UseFont = true;
            this.gvPesaje.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPesaje.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPesaje.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent;
            this.gvPesaje.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPesaje.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(215)))));
            this.gvPesaje.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPesaje.Appearance.Row.Options.UseBackColor = true;
            this.gvPesaje.Appearance.Row.Options.UseFont = true;
            this.gvPesaje.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvPesaje.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPesaje.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_orden,
            this.colcodigo_mp,
            this.colMP,
            this.colpeso_batch,
            this.colpeso_total,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "[total] = [batch_real]";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gvPesaje.FormatRules.Add(gridFormatRule1);
            this.gvPesaje.GridControl = this.gcPesaje;
            this.gvPesaje.Name = "gvPesaje";
            this.gvPesaje.OptionsView.ShowGroupPanel = false;
            this.gvPesaje.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPesaje_CellValueChanged);
            // 
            // colid_orden
            // 
            this.colid_orden.FieldName = "id_orden";
            this.colid_orden.Name = "colid_orden";
            // 
            // colcodigo_mp
            // 
            this.colcodigo_mp.FieldName = "codigo";
            this.colcodigo_mp.Name = "colcodigo_mp";
            this.colcodigo_mp.OptionsColumn.AllowEdit = false;
            this.colcodigo_mp.Visible = true;
            this.colcodigo_mp.VisibleIndex = 0;
            this.colcodigo_mp.Width = 217;
            // 
            // colMP
            // 
            this.colMP.Caption = "Material";
            this.colMP.FieldName = "material";
            this.colMP.Name = "colMP";
            this.colMP.OptionsColumn.AllowEdit = false;
            this.colMP.Visible = true;
            this.colMP.VisibleIndex = 1;
            this.colMP.Width = 334;
            // 
            // colpeso_batch
            // 
            this.colpeso_batch.Caption = "Peso Por Batch";
            this.colpeso_batch.FieldName = "peso_por_batch";
            this.colpeso_batch.Name = "colpeso_batch";
            this.colpeso_batch.OptionsColumn.AllowEdit = false;
            this.colpeso_batch.Visible = true;
            this.colpeso_batch.VisibleIndex = 2;
            this.colpeso_batch.Width = 174;
            // 
            // colpeso_total
            // 
            this.colpeso_total.FieldName = "Peso_Total";
            this.colpeso_total.Name = "colpeso_total";
            this.colpeso_total.OptionsColumn.AllowEdit = false;
            this.colpeso_total.Visible = true;
            this.colpeso_total.VisibleIndex = 3;
            this.colpeso_total.Width = 117;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.FieldName = "seleccionar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 142;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Batch Plan";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn2.FieldName = "batchPlan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 124;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id_mp";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 104;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "id_orden";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // cmdPesar1
            // 
            this.cmdPesar1.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdPesar1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPesar1.Name = "cmdPesar1";
            this.cmdPesar1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNext.Location = new System.Drawing.Point(996, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 44);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Finalizar";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Location = new System.Drawing.Point(1, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // xfrmAsistentePesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gcPesaje);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmAsistentePesaje";
            this.Text = "Pesaje MP";
            ((System.ComponentModel.ISupportInitialize)(this.gcPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPesar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPesaje;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPesaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPesar1;
        private dsMicros dsMicros;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colMP;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_batch;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_total;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}