﻿namespace LOSA.AlmacenesExterno
{
    partial class xfrmViewLotes
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmViewLotes));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcIngreso = new DevExpress.XtraGrid.GridControl();
            this.lotesviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlmacenesExternos = new LOSA.AlmacenesExterno.dsAlmacenesExternos();
            this.gvIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVerLote = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerLote)).BeginInit();
            this.SuspendLayout();
            // 
            // gcIngreso
            // 
            this.gcIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcIngreso.DataSource = this.lotesviewBindingSource;
            this.gcIngreso.Location = new System.Drawing.Point(-3, 109);
            this.gcIngreso.MainView = this.gvIngreso;
            this.gcIngreso.Name = "gcIngreso";
            this.gcIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVerLote});
            this.gcIngreso.Size = new System.Drawing.Size(966, 623);
            this.gcIngreso.TabIndex = 37;
            this.gcIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngreso});
            // 
            // lotesviewBindingSource
            // 
            this.lotesviewBindingSource.DataMember = "Lotes_view";
            this.lotesviewBindingSource.DataSource = this.dsAlmacenesExternos;
            // 
            // dsAlmacenesExternos
            // 
            this.dsAlmacenesExternos.DataSetName = "dsAlmacenesExternos";
            this.dsAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvIngreso
            // 
            this.gvIngreso.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvIngreso.Appearance.FocusedRow.Options.UseFont = true;
            this.gvIngreso.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngreso.Appearance.FooterPanel.Options.UseFont = true;
            this.gvIngreso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngreso.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvIngreso.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvIngreso.Appearance.Row.Options.UseFont = true;
            this.gvIngreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote,
            this.colcantidad,
            this.colunidades});
            this.gvIngreso.GridControl = this.gcIngreso;
            this.gvIngreso.Name = "gvIngreso";
            this.gvIngreso.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvIngreso.OptionsView.ShowAutoFilterRow = true;
            this.gvIngreso.OptionsView.ShowFooter = true;
            this.gvIngreso.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Width = 94;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.MinWidth = 25;
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 0;
            this.collote.Width = 94;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 25;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.OptionsFilter.AllowFilter = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "Total ={0:N2}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            this.colcantidad.Width = 94;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.FieldName = "unidades";
            this.colunidades.MinWidth = 25;
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.OptionsFilter.AllowFilter = false;
            this.colunidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", "Total ={0:N2}")});
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 2;
            this.colunidades.Width = 94;
            // 
            // btnVerLote
            // 
            this.btnVerLote.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnVerLote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnVerLote.Name = "btnVerLote";
            this.btnVerLote.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(772, 29);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 38;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmViewLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 733);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmViewLotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmViewLotes";
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVerLote;
        private System.Windows.Forms.BindingSource lotesviewBindingSource;
        private dsAlmacenesExternos dsAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
    }
}