namespace ACS.MP
{
    partial class MP_CarcarII_Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP_CarcarII_Preview));
            this.grdColExiste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColValorUsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColValorHNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColID_MP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdConsumo_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdInv_fisico_kgs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmb_Period = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Period.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdColExiste
            // 
            this.grdColExiste.Caption = "Existe";
            this.grdColExiste.ColumnEdit = this.repositoryItemCheckEdit1;
            this.grdColExiste.FieldName = "existe";
            this.grdColExiste.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColExiste.Name = "grdColExiste";
            this.grdColExiste.OptionsColumn.AllowEdit = false;
            this.grdColExiste.OptionsColumn.ReadOnly = true;
            this.grdColExiste.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.grdColExiste.Visible = true;
            this.grdColExiste.VisibleIndex = 7;
            this.grdColExiste.Width = 40;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ReadOnly = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.Location = new System.Drawing.Point(0, 61);
            this.grdDetalle.MainView = this.gridView1;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grdDetalle.Size = new System.Drawing.Size(715, 257);
            this.grdDetalle.TabIndex = 11;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColCodigo,
            this.grdColMaterial,
            this.grdColCantidad,
            this.grdColValorUsd,
            this.grdColValorHNL,
            this.grdColExiste,
            this.grdColID_MP,
            this.grdConsumo_kg,
            this.grdInv_fisico_kgs});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.grdColExiste;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "[existe] = False";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.grdDetalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // grdColCodigo
            // 
            this.grdColCodigo.Caption = "Codigo";
            this.grdColCodigo.FieldName = "codigo";
            this.grdColCodigo.Name = "grdColCodigo";
            this.grdColCodigo.OptionsColumn.AllowEdit = false;
            this.grdColCodigo.OptionsColumn.AllowFocus = false;
            this.grdColCodigo.OptionsColumn.FixedWidth = true;
            this.grdColCodigo.OptionsColumn.ReadOnly = true;
            this.grdColCodigo.Visible = true;
            this.grdColCodigo.VisibleIndex = 0;
            this.grdColCodigo.Width = 104;
            // 
            // grdColMaterial
            // 
            this.grdColMaterial.Caption = "Material";
            this.grdColMaterial.FieldName = "material";
            this.grdColMaterial.Name = "grdColMaterial";
            this.grdColMaterial.OptionsColumn.AllowEdit = false;
            this.grdColMaterial.OptionsColumn.ReadOnly = true;
            this.grdColMaterial.Visible = true;
            this.grdColMaterial.VisibleIndex = 1;
            this.grdColMaterial.Width = 161;
            // 
            // grdColCantidad
            // 
            this.grdColCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.grdColCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdColCantidad.Caption = "Cantidad (Kg)";
            this.grdColCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdColCantidad.FieldName = "cantidad";
            this.grdColCantidad.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColCantidad.Name = "grdColCantidad";
            this.grdColCantidad.OptionsColumn.AllowEdit = false;
            this.grdColCantidad.OptionsColumn.ReadOnly = true;
            this.grdColCantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "{0:0.##} kg")});
            this.grdColCantidad.Visible = true;
            this.grdColCantidad.VisibleIndex = 2;
            this.grdColCantidad.Width = 79;
            // 
            // grdColValorUsd
            // 
            this.grdColValorUsd.AppearanceCell.Options.UseTextOptions = true;
            this.grdColValorUsd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdColValorUsd.Caption = "Valor_USD";
            this.grdColValorUsd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdColValorUsd.FieldName = "valor_usd";
            this.grdColValorUsd.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColValorUsd.Name = "grdColValorUsd";
            this.grdColValorUsd.OptionsColumn.AllowEdit = false;
            this.grdColValorUsd.OptionsColumn.ReadOnly = true;
            this.grdColValorUsd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_usd", "$ {0:0.##} ")});
            this.grdColValorUsd.Visible = true;
            this.grdColValorUsd.VisibleIndex = 3;
            this.grdColValorUsd.Width = 79;
            // 
            // grdColValorHNL
            // 
            this.grdColValorHNL.AppearanceCell.Options.UseTextOptions = true;
            this.grdColValorHNL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdColValorHNL.Caption = "Valor_HNL";
            this.grdColValorHNL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdColValorHNL.FieldName = "valor_hnl";
            this.grdColValorHNL.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdColValorHNL.Name = "grdColValorHNL";
            this.grdColValorHNL.OptionsColumn.AllowEdit = false;
            this.grdColValorHNL.OptionsColumn.ReadOnly = true;
            this.grdColValorHNL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_hnl", "L {0:0.##}")});
            this.grdColValorHNL.Visible = true;
            this.grdColValorHNL.VisibleIndex = 4;
            this.grdColValorHNL.Width = 78;
            // 
            // grdColID_MP
            // 
            this.grdColID_MP.Caption = "ID_MP";
            this.grdColID_MP.FieldName = "id_mp";
            this.grdColID_MP.Name = "grdColID_MP";
            // 
            // grdConsumo_kg
            // 
            this.grdConsumo_kg.AppearanceCell.Options.UseTextOptions = true;
            this.grdConsumo_kg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdConsumo_kg.Caption = "Consumo Kgs";
            this.grdConsumo_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdConsumo_kg.FieldName = "consumo_kgs";
            this.grdConsumo_kg.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdConsumo_kg.Name = "grdConsumo_kg";
            this.grdConsumo_kg.OptionsColumn.AllowEdit = false;
            this.grdConsumo_kg.Visible = true;
            this.grdConsumo_kg.VisibleIndex = 5;
            this.grdConsumo_kg.Width = 76;
            // 
            // grdInv_fisico_kgs
            // 
            this.grdInv_fisico_kgs.AppearanceCell.Options.UseTextOptions = true;
            this.grdInv_fisico_kgs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.grdInv_fisico_kgs.Caption = "Inv Fisico Kgs";
            this.grdInv_fisico_kgs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.grdInv_fisico_kgs.FieldName = "inv_fisico_kgs";
            this.grdInv_fisico_kgs.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.grdInv_fisico_kgs.Name = "grdInv_fisico_kgs";
            this.grdInv_fisico_kgs.OptionsColumn.AllowEdit = false;
            this.grdInv_fisico_kgs.Visible = true;
            this.grdInv_fisico_kgs.VisibleIndex = 6;
            this.grdInv_fisico_kgs.Width = 76;
            // 
            // btnProcesar
            // 
            this.btnProcesar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.ImageOptions.Image")));
            this.btnProcesar.Location = new System.Drawing.Point(459, 324);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(121, 37);
            this.btnProcesar.TabIndex = 20;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btnCancelar.Location = new System.Drawing.Point(591, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 37);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(3, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Registrar como:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LOSA.Properties.Resources.kilograms;
            this.pictureBox2.Location = new System.Drawing.Point(646, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // cmb_Period
            // 
            this.cmb_Period.Location = new System.Drawing.Point(45, 31);
            this.cmb_Period.Name = "cmb_Period";
            this.cmb_Period.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Period.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("period", "Periodo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fiscalyear", "Año Fiscal")});
            this.cmb_Period.Properties.DisplayMember = "period";
            this.cmb_Period.Properties.ValueMember = "id";
            this.cmb_Period.Size = new System.Drawing.Size(221, 20);
            this.cmb_Period.TabIndex = 30;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(4, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Periodo";
            // 
            // MP_CarcarII_Preview
            // 
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 365);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cmb_Period);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.pictureBox2);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MP_CarcarII_Preview.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MP_CarcarII_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Inventario Inicial - Previsualización (Kg)";
            this.Load += new System.EventHandler(this.MP_CarcarII_Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Period.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn grdColMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn grdColValorUsd;
        private DevExpress.XtraGrid.Columns.GridColumn grdColValorHNL;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn grdColID_MP;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColExiste;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LookUpEdit cmb_Period;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn grdConsumo_kg;
        private DevExpress.XtraGrid.Columns.GridColumn grdInv_fisico_kgs;
    }
}