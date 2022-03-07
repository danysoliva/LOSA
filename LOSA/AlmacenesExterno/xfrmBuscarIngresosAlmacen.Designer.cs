﻿namespace LOSA.AlmacenesExterno
{
    partial class xfrmBuscarIngresosAlmacen
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcIngreso = new DevExpress.XtraGrid.GridControl();
            this.dsSalidasAlmacenesExternos = new LOSA.AlmacenesExterno.dsSalidasAlmacenesExternos();
            this.gvIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntrySAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantIngresar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // gcIngreso
            // 
            this.gcIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcIngreso.DataMember = "Ingresos_almacenes_externos_existentes";
            this.gcIngreso.DataSource = this.dsSalidasAlmacenesExternos;
            this.gcIngreso.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcIngreso.Location = new System.Drawing.Point(0, 80);
            this.gcIngreso.MainView = this.gvIngreso;
            this.gcIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcIngreso.Name = "gcIngreso";
            this.gcIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtCantIngresar,
            this.btnSeleccionar});
            this.gcIngreso.Size = new System.Drawing.Size(1119, 526);
            this.gcIngreso.TabIndex = 37;
            this.gcIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngreso});
            // 
            // dsSalidasAlmacenesExternos
            // 
            this.dsSalidasAlmacenesExternos.DataSetName = "dsSalidasAlmacenesExternos";
            this.dsSalidasAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colcardcode,
            this.colCardName,
            this.colfecha_ingreso,
            this.colDocEntrySAP,
            this.colpeso,
            this.colunidades,
            this.colSeleccionar,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvIngreso.DetailHeight = 284;
            this.gvIngreso.GridControl = this.gcIngreso;
            this.gvIngreso.Name = "gvIngreso";
            this.gvIngreso.OptionsView.ShowAutoFilterRow = true;
            this.gvIngreso.OptionsView.ShowFooter = true;
            this.gvIngreso.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "#Ingeso";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 21;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsFilter.AllowFilter = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 81;
            // 
            // colcardcode
            // 
            this.colcardcode.Caption = "Proveedor";
            this.colcardcode.FieldName = "cardcode";
            this.colcardcode.MinWidth = 21;
            this.colcardcode.Name = "colcardcode";
            this.colcardcode.OptionsColumn.AllowEdit = false;
            this.colcardcode.OptionsFilter.AllowFilter = false;
            this.colcardcode.Visible = true;
            this.colcardcode.VisibleIndex = 3;
            this.colcardcode.Width = 81;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Proveedor";
            this.colCardName.FieldName = "CardName";
            this.colCardName.MinWidth = 21;
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.OptionsFilter.AllowFilter = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 4;
            this.colCardName.Width = 81;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.MinWidth = 21;
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.OptionsFilter.AllowFilter = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 5;
            this.colfecha_ingreso.Width = 81;
            // 
            // colDocEntrySAP
            // 
            this.colDocEntrySAP.FieldName = "DocEntrySAP";
            this.colDocEntrySAP.MinWidth = 21;
            this.colDocEntrySAP.Name = "colDocEntrySAP";
            this.colDocEntrySAP.OptionsColumn.AllowEdit = false;
            this.colDocEntrySAP.OptionsFilter.AllowFilter = false;
            this.colDocEntrySAP.Visible = true;
            this.colDocEntrySAP.VisibleIndex = 6;
            this.colDocEntrySAP.Width = 81;
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Peso";
            this.colpeso.FieldName = "peso";
            this.colpeso.MinWidth = 21;
            this.colpeso.Name = "colpeso";
            this.colpeso.OptionsColumn.AllowEdit = false;
            this.colpeso.OptionsFilter.AllowFilter = false;
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 7;
            this.colpeso.Width = 81;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.FieldName = "unidades";
            this.colunidades.MinWidth = 21;
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.OptionsFilter.AllowFilter = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 8;
            this.colunidades.Width = 81;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "Seleccionar";
            this.colSeleccionar.ColumnEdit = this.btnSeleccionar;
            this.colSeleccionar.MinWidth = 21;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.OptionsFilter.AllowFilter = false;
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 10;
            this.colSeleccionar.Width = 81;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Item Code";
            this.gridColumn1.FieldName = "itemcode";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MP";
            this.gridColumn2.FieldName = "itemName";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Bodega";
            this.gridColumn3.FieldName = "bodega";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 64;
            // 
            // txtCantIngresar
            // 
            this.txtCantIngresar.AutoHeight = false;
            this.txtCantIngresar.Name = "txtCantIngresar";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(947, 20);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 44;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmBuscarIngresosAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 602);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfrmBuscarIngresosAlmacen";
            this.Text = "xfrmBuscarIngresosAlmacen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalidasAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantIngresar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private dsSalidasAlmacenesExternos dsSalidasAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcardcode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntrySAP;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}