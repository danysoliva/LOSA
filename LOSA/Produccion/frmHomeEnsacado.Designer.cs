﻿namespace LOSA.Produccion
{
    partial class frmHomeEnsacado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeEnsacado));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcTolva = new DevExpress.XtraGrid.GridControl();
            this.dsProduccion1 = new LOSA.Produccion.dsProduccion();
            this.gvTolva = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfp_lot_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinish_product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTarimas = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colacs_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTolva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTolva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtras.Location = new System.Drawing.Point(4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 66);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // gcTolva
            // 
            this.gcTolva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTolva.DataMember = "home_sacos_pt";
            this.gcTolva.DataSource = this.dsProduccion1;
            this.gcTolva.Location = new System.Drawing.Point(1, 76);
            this.gcTolva.MainView = this.gvTolva;
            this.gcTolva.Name = "gcTolva";
            this.gcTolva.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.btnTarimas});
            this.gcTolva.Size = new System.Drawing.Size(620, 443);
            this.gcTolva.TabIndex = 12;
            this.gcTolva.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTolva});
            // 
            // dsProduccion1
            // 
            this.dsProduccion1.DataSetName = "dsProduccion";
            this.dsProduccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTolva
            // 
            this.gvTolva.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTolva.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTolva.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTolva.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTolva.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTolva.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTolva.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTolva.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTolva.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTolva.Appearance.Row.Options.UseFont = true;
            this.gvTolva.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTolva.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTolva.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTolva.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTolva.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfp_lot_number,
            this.colfinish_product,
            this.colformula,
            this.colstatus,
            this.gridColumn1,
            this.colacs_id});
            this.gvTolva.GridControl = this.gcTolva;
            this.gvTolva.Name = "gvTolva";
            this.gvTolva.OptionsView.ShowGroupPanel = false;
            // 
            // colfp_lot_number
            // 
            this.colfp_lot_number.Caption = "Lote";
            this.colfp_lot_number.FieldName = "fp_lot_number";
            this.colfp_lot_number.Name = "colfp_lot_number";
            this.colfp_lot_number.OptionsColumn.AllowEdit = false;
            this.colfp_lot_number.Visible = true;
            this.colfp_lot_number.VisibleIndex = 0;
            // 
            // colfinish_product
            // 
            this.colfinish_product.Caption = "Producto";
            this.colfinish_product.FieldName = "finish_product";
            this.colfinish_product.Name = "colfinish_product";
            this.colfinish_product.OptionsColumn.AllowEdit = false;
            this.colfinish_product.Visible = true;
            this.colfinish_product.VisibleIndex = 1;
            // 
            // colformula
            // 
            this.colformula.Caption = "Formula";
            this.colformula.FieldName = "formula";
            this.colformula.Name = "colformula";
            this.colformula.OptionsColumn.AllowEdit = false;
            this.colformula.Visible = true;
            this.colformula.VisibleIndex = 2;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tarimas";
            this.gridColumn1.ColumnEdit = this.btnTarimas;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // btnTarimas
            // 
            this.btnTarimas.AutoHeight = false;
            //editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.pallet_pallet_solo;
            this.btnTarimas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnTarimas.Name = "btnTarimas";
            this.btnTarimas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnTarimas.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnTarimas_ButtonClick);
            // 
            // colacs_id
            // 
            this.colacs_id.FieldName = "acs_id";
            this.colacs_id.Name = "colacs_id";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = global::LOSA.Properties.Resources.tap;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmHomeEnsacado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.gcTolva);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeEnsacado";
            this.Text = "frmHomeEnsacado";
            ((System.ComponentModel.ISupportInitialize)(this.gcTolva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTolva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcTolva;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTolva;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private dsProduccion dsProduccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colfp_lot_number;
        private DevExpress.XtraGrid.Columns.GridColumn colfinish_product;
        private DevExpress.XtraGrid.Columns.GridColumn colformula;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnTarimas;
        private DevExpress.XtraGrid.Columns.GridColumn colacs_id;
    }
}