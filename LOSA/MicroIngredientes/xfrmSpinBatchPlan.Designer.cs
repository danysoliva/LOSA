namespace LOSA.MicroIngredientes
{
    partial class xfrmSpinBatchPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSpinBatchPlan));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.seBatch = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCheck = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUp = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDown = new DevExpress.XtraEditors.SimpleButton();
            this.gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.dsMicros1 = new LOSA.MicroIngredientes.dsMicros();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoporBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBatchCompletados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dsMicro1 = new LOSA.Micro.dsMicro();
            this.cmdSum10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.cmdClose.Location = new System.Drawing.Point(454, 437);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(74, 50);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // seBatch
            // 
            this.seBatch.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seBatch.Location = new System.Drawing.Point(439, 62);
            this.seBatch.Name = "seBatch";
            this.seBatch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seBatch.Properties.Appearance.Options.UseFont = true;
            this.seBatch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seBatch.Properties.IsFloatValue = false;
            this.seBatch.Properties.Mask.EditMask = "N00";
            this.seBatch.Properties.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.seBatch.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seBatch.Size = new System.Drawing.Size(171, 30);
            this.seBatch.TabIndex = 1;
            this.seBatch.EditValueChanged += new System.EventHandler(this.seBatch_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(213, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cantidad de Batch a pesar:";
            // 
            // cmdCheck
            // 
            this.cmdCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCheck.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCheck.ImageOptions.Image = global::LOSA.Properties.Resources.Done_icon;
            this.cmdCheck.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.cmdCheck.Location = new System.Drawing.Point(359, 437);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(74, 50);
            this.cmdCheck.TabIndex = 3;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUp.ImageOptions.Image")));
            this.cmdUp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdUp.Location = new System.Drawing.Point(439, 12);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(75, 44);
            this.cmdUp.TabIndex = 4;
            this.cmdUp.Text = "simpleButton1";
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDown.ImageOptions.Image")));
            this.cmdDown.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdDown.Location = new System.Drawing.Point(439, 98);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(75, 44);
            this.cmdDown.TabIndex = 5;
            this.cmdDown.Text = "simpleButton2";
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // gcDetalle
            // 
            this.gcDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDetalle.DataMember = "DetalleOrdenesMicro";
            this.gcDetalle.DataSource = this.dsMicros1;
            this.gcDetalle.Location = new System.Drawing.Point(12, 148);
            this.gcDetalle.MainView = this.gvDetalle;
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemButtonEdit1});
            this.gcDetalle.Size = new System.Drawing.Size(864, 283);
            this.gcDetalle.TabIndex = 6;
            this.gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // dsMicros1
            // 
            this.dsMicros1.DataSetName = "dsMicros";
            this.dsMicros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDetalle
            // 
            this.gvDetalle.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalle.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDetalle.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetalle.Appearance.Row.Options.UseFont = true;
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterial,
            this.colPesoporBatch,
            this.colBatchPlan,
            this.colTotal,
            this.colBatchCompletados});
            this.gvDetalle.GridControl = this.gcDetalle;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsView.ShowFooter = true;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // colMaterial
            // 
            this.colMaterial.Caption = "Material";
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.OptionsColumn.AllowEdit = false;
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 0;
            // 
            // colPesoporBatch
            // 
            this.colPesoporBatch.DisplayFormat.FormatString = "###.00";
            this.colPesoporBatch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPesoporBatch.FieldName = "Peso por Batch";
            this.colPesoporBatch.Name = "colPesoporBatch";
            this.colPesoporBatch.OptionsColumn.AllowEdit = false;
            this.colPesoporBatch.Visible = true;
            this.colPesoporBatch.VisibleIndex = 1;
            // 
            // colBatchPlan
            // 
            this.colBatchPlan.Caption = "Batch a Pesar";
            this.colBatchPlan.FieldName = "Batch Plan";
            this.colBatchPlan.Name = "colBatchPlan";
            this.colBatchPlan.OptionsColumn.AllowEdit = false;
            this.colBatchPlan.Visible = true;
            this.colBatchPlan.VisibleIndex = 2;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "#,###.00";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:0.00}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            // 
            // colBatchCompletados
            // 
            this.colBatchCompletados.FieldName = "Batch Completados";
            this.colBatchCompletados.Name = "colBatchCompletados";
            this.colBatchCompletados.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Appearance.Image = global::LOSA.Properties.Resources.exchange;
            this.repositoryItemButtonEdit1.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.exchange;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // dsMicro1
            // 
            this.dsMicro1.DataSetName = "dsMicro";
            this.dsMicro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdSum10
            // 
            this.cmdSum10.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSum10.Appearance.Options.UseFont = true;
            this.cmdSum10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSum10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSum10.Location = new System.Drawing.Point(535, 12);
            this.cmdSum10.Name = "cmdSum10";
            this.cmdSum10.Size = new System.Drawing.Size(75, 44);
            this.cmdSum10.TabIndex = 7;
            this.cmdSum10.Text = "+10";
            this.cmdSum10.Click += new System.EventHandler(this.cmdSum10_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(535, 98);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 44);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "-10";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xfrmSpinBatchPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 499);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdSum10);
            this.Controls.Add(this.gcDetalle);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdUp);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.seBatch);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmSpinBatchPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmSpinBatchPlan";
            ((System.ComponentModel.ISupportInitialize)(this.seBatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SpinEdit seBatch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdCheck;
        private DevExpress.XtraEditors.SimpleButton cmdUp;
        private DevExpress.XtraEditors.SimpleButton cmdDown;
        private DevExpress.XtraGrid.GridControl gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private Micro.dsMicro dsMicro1;
        private dsMicros dsMicros1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoporBatch;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colBatchCompletados;
        private DevExpress.XtraEditors.SimpleButton cmdSum10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}