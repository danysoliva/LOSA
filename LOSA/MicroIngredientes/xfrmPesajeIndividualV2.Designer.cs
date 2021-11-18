
namespace LOSA.MicroIngredientes
{
    partial class xfrmPesajeIndividualV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPesajeIndividualV2));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lueBascula = new DevExpress.XtraEditors.LookUpEdit();
            this.pesajeBasculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMicros = new LOSA.MicroIngredientes.dsMicros();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.Bascula2 = new DevExpress.XtraEditors.SimpleButton();
            this.Bascula1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcPesaje = new DevExpress.XtraGrid.GridControl();
            this.newPesajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPesaje = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdPesar1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBascula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesajeBasculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPesajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPesar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lueBascula
            // 
            this.lueBascula.Location = new System.Drawing.Point(446, -1);
            this.lueBascula.Name = "lueBascula";
            this.lueBascula.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lueBascula.Properties.Appearance.Options.UseFont = true;
            this.lueBascula.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueBascula.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueBascula.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueBascula.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueBascula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBascula.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("peso", "Peso", 41, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False)});
            this.lueBascula.Properties.DataSource = this.pesajeBasculaBindingSource;
            this.lueBascula.Properties.DisplayMember = "descripcion";
            this.lueBascula.Properties.NullText = "";
            this.lueBascula.Properties.ValueMember = "id_bascula";
            this.lueBascula.Size = new System.Drawing.Size(173, 30);
            this.lueBascula.TabIndex = 8;
            this.lueBascula.Visible = false;
            // 
            // pesajeBasculaBindingSource
            // 
            this.pesajeBasculaBindingSource.DataMember = "Pesaje_Bascula";
            this.pesajeBasculaBindingSource.DataSource = this.dsMicros;
            // 
            // dsMicros
            // 
            this.dsMicros.DataSetName = "dsMicros";
            this.dsMicros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bascula";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 466);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(631, 18);
            this.progressBarControl1.TabIndex = 18;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGenerar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGenerar.ImageOptions.SvgImage")));
            this.btnGenerar.Location = new System.Drawing.Point(220, 203);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 63);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Iniciar";
            this.btnGenerar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(331, 203);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 63);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Bascula2
            // 
            this.Bascula2.Appearance.BackColor = System.Drawing.Color.White;
            this.Bascula2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Bascula2.Appearance.Options.UseBackColor = true;
            this.Bascula2.Appearance.Options.UseFont = true;
            this.Bascula2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Bascula2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bascula2.ImageOptions.Image")));
            this.Bascula2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Bascula2.Location = new System.Drawing.Point(331, 53);
            this.Bascula2.Name = "Bascula2";
            this.Bascula2.Size = new System.Drawing.Size(164, 103);
            this.Bascula2.TabIndex = 19;
            this.Bascula2.Text = "Bascula 2";
            this.Bascula2.Click += new System.EventHandler(this.Bascula2_Click);
            // 
            // Bascula1
            // 
            this.Bascula1.Appearance.BackColor = System.Drawing.Color.White;
            this.Bascula1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bascula1.Appearance.Options.UseBackColor = true;
            this.Bascula1.Appearance.Options.UseFont = true;
            this.Bascula1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Bascula1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bascula1.ImageOptions.Image")));
            this.Bascula1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Bascula1.Location = new System.Drawing.Point(131, 53);
            this.Bascula1.Name = "Bascula1";
            this.Bascula1.Size = new System.Drawing.Size(164, 103);
            this.Bascula1.TabIndex = 20;
            this.Bascula1.Text = "Bascula 1";
            this.Bascula1.Click += new System.EventHandler(this.Bascula1_Click);
            // 
            // gcPesaje
            // 
            this.gcPesaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPesaje.DataSource = this.newPesajeBindingSource;
            this.gcPesaje.Location = new System.Drawing.Point(0, 272);
            this.gcPesaje.MainView = this.gvPesaje;
            this.gcPesaje.Name = "gcPesaje";
            this.gcPesaje.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPesar1,
            this.repositoryItemButtonEdit1});
            this.gcPesaje.Size = new System.Drawing.Size(631, 200);
            this.gcPesaje.TabIndex = 21;
            this.gcPesaje.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPesaje});
            // 
            // newPesajeBindingSource
            // 
            this.newPesajeBindingSource.DataMember = "New_Pesaje";
            this.newPesajeBindingSource.DataSource = this.dsMicros;
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
            this.gridColumn2});
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
            this.colcodigo_mp.Width = 213;
            // 
            // colMP
            // 
            this.colMP.Caption = "Material";
            this.colMP.FieldName = "material";
            this.colMP.Name = "colMP";
            this.colMP.OptionsColumn.AllowEdit = false;
            this.colMP.Visible = true;
            this.colMP.VisibleIndex = 1;
            this.colMP.Width = 328;
            // 
            // colpeso_batch
            // 
            this.colpeso_batch.Caption = "Peso Por Batch";
            this.colpeso_batch.FieldName = "peso_por_batch";
            this.colpeso_batch.Name = "colpeso_batch";
            this.colpeso_batch.OptionsColumn.AllowEdit = false;
            this.colpeso_batch.Width = 171;
            // 
            // colpeso_total
            // 
            this.colpeso_total.FieldName = "Peso_Total";
            this.colpeso_total.Name = "colpeso_total";
            this.colpeso_total.OptionsColumn.AllowEdit = false;
            this.colpeso_total.Width = 116;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.FieldName = "seleccionar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 136;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Batch Plan";
            this.gridColumn2.FieldName = "batchPlan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 124;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // cmdPesar1
            // 
            this.cmdPesar1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdPesar1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPesar1.Name = "cmdPesar1";
            this.cmdPesar1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // xfrmPesajeIndividualV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 484);
            this.Controls.Add(this.gcPesaje);
            this.Controls.Add(this.Bascula1);
            this.Controls.Add(this.Bascula2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lueBascula);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmPesajeIndividualV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmSelectBascula";
            this.Load += new System.EventHandler(this.xfrmPesajeIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueBascula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesajeBasculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPesajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPesar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.LookUpEdit lueBascula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pesajeBasculaBindingSource;
        private dsMicros dsMicros;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton Bascula2;
        private DevExpress.XtraEditors.SimpleButton Bascula1;
        private DevExpress.XtraGrid.GridControl gcPesaje;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPesaje;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colMP;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_batch;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_total;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPesar1;
        private System.Windows.Forms.BindingSource newPesajeBindingSource;
    }
}