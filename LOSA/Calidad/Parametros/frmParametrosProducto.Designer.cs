﻿
namespace LOSA.Calidad.Parametros
{
    partial class frmParametrosProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrosProducto));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtproducto = new DevExpress.XtraEditors.TextEdit();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsParametros = new LOSA.Calidad.Parametros.dsParametros();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_parametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(621, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 52);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Producto:";
            // 
            // txtproducto
            // 
            this.txtproducto.Enabled = false;
            this.txtproducto.Location = new System.Drawing.Point(106, 24);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtproducto.Properties.Appearance.Options.UseFont = true;
            this.txtproducto.Size = new System.Drawing.Size(444, 26);
            this.txtproducto.TabIndex = 3;
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "parametroProducto";
            this.grd_data.DataSource = this.dsParametros;
            this.grd_data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_data.Location = new System.Drawing.Point(3, 128);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEliminar});
            this.grd_data.Size = new System.Drawing.Size(740, 568);
            this.grd_data.TabIndex = 4;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "dsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_parametro,
            this.colparametro,
            this.colmin,
            this.colmaximo,
            this.colid_grupo,
            this.colEliminar,
            this.colid});
            this.grdv_data.DetailHeight = 284;
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid_parametro
            // 
            this.colid_parametro.FieldName = "id_parametro";
            this.colid_parametro.MinWidth = 21;
            this.colid_parametro.Name = "colid_parametro";
            this.colid_parametro.Width = 81;
            // 
            // colparametro
            // 
            this.colparametro.Caption = "Parametro";
            this.colparametro.FieldName = "parametro";
            this.colparametro.MinWidth = 21;
            this.colparametro.Name = "colparametro";
            this.colparametro.OptionsColumn.AllowEdit = false;
            this.colparametro.Visible = true;
            this.colparametro.VisibleIndex = 0;
            this.colparametro.Width = 144;
            // 
            // colmin
            // 
            this.colmin.Caption = "Minimo";
            this.colmin.FieldName = "min";
            this.colmin.MinWidth = 21;
            this.colmin.Name = "colmin";
            this.colmin.OptionsColumn.AllowEdit = false;
            this.colmin.Visible = true;
            this.colmin.VisibleIndex = 1;
            this.colmin.Width = 144;
            // 
            // colmaximo
            // 
            this.colmaximo.Caption = "Maximo";
            this.colmaximo.FieldName = "maximo";
            this.colmaximo.MinWidth = 21;
            this.colmaximo.Name = "colmaximo";
            this.colmaximo.OptionsColumn.AllowEdit = false;
            this.colmaximo.Visible = true;
            this.colmaximo.VisibleIndex = 2;
            this.colmaximo.Width = 144;
            // 
            // colid_grupo
            // 
            this.colid_grupo.Caption = "Tipo de Dato";
            this.colid_grupo.FieldName = "id_grupo";
            this.colid_grupo.MinWidth = 21;
            this.colid_grupo.Name = "colid_grupo";
            this.colid_grupo.OptionsColumn.AllowEdit = false;
            this.colid_grupo.Visible = true;
            this.colid_grupo.VisibleIndex = 3;
            this.colid_grupo.Width = 208;
            // 
            // colEliminar
            // 
            this.colEliminar.Caption = "Eliminar";
            this.colEliminar.ColumnEdit = this.btnEliminar;
            this.colEliminar.MinWidth = 21;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Visible = true;
            this.colEliminar.VisibleIndex = 4;
            this.colEliminar.Width = 82;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(555, 80);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 41);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Nuevo Parametro";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // frmParametrosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 695);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmParametrosProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de Parametros";
            ((System.ComponentModel.ISupportInitialize)(this.txtproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtproducto;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dsParametros dsParametros;
        private DevExpress.XtraGrid.Columns.GridColumn colid_parametro;
        private DevExpress.XtraGrid.Columns.GridColumn colparametro;
        private DevExpress.XtraGrid.Columns.GridColumn colmin;
        private DevExpress.XtraGrid.Columns.GridColumn colmaximo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
    }
}