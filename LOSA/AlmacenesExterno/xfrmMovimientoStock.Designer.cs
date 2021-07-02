namespace LOSA.AlmacenesExterno
{
    partial class xfrmMovimientoStock
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcTransferencia = new DevExpress.XtraGrid.GridControl();
            this.transferenciaStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlmacenesExternos = new LOSA.AlmacenesExterno.dsAlmacenesExternos();
            this.gvTransferencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscarProd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrom_almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luBodegaFrom = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colto_almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luBodegaTO = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colcantidad_kilos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantIngresar = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ceSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransferencia
            // 
            this.gcTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransferencia.DataSource = this.transferenciaStockBindingSource;
            this.gcTransferencia.Location = new System.Drawing.Point(-1, 208);
            this.gcTransferencia.MainView = this.gvTransferencia;
            this.gcTransferencia.Name = "gcTransferencia";
            this.gcTransferencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtCantIngresar,
            this.ceSeleccionar,
            this.btnBuscarProd,
            this.luBodegaFrom,
            this.luBodegaTO});
            this.gcTransferencia.Size = new System.Drawing.Size(1363, 476);
            this.gcTransferencia.TabIndex = 35;
            this.gcTransferencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransferencia});
            // 
            // transferenciaStockBindingSource
            // 
            this.transferenciaStockBindingSource.DataMember = "Transferencia_Stock";
            this.transferenciaStockBindingSource.DataSource = this.dsAlmacenesExternos;
            // 
            // dsAlmacenesExternos
            // 
            this.dsAlmacenesExternos.DataSetName = "dsAlmacenesExternos";
            this.dsAlmacenesExternos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTransferencia
            // 
            this.gvTransferencia.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTransferencia.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTransferencia.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransferencia.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTransferencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTransferencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTransferencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTransferencia.Appearance.Row.Options.UseFont = true;
            this.gvTransferencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodeItem,
            this.colmp,
            this.colfrom_almacen,
            this.colto_almacen,
            this.colcantidad_kilos,
            this.colunidades,
            this.gridColumn1});
            this.gvTransferencia.GridControl = this.gcTransferencia;
            this.gvTransferencia.Name = "gvTransferencia";
            this.gvTransferencia.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvTransferencia.OptionsView.ShowAutoFilterRow = true;
            this.gvTransferencia.OptionsView.ShowFooter = true;
            this.gvTransferencia.OptionsView.ShowGroupPanel = false;
            this.gvTransferencia.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvTransferencia_CellValueChanged);
            // 
            // colcodeItem
            // 
            this.colcodeItem.ColumnEdit = this.btnBuscarProd;
            this.colcodeItem.FieldName = "codeItem";
            this.colcodeItem.MinWidth = 25;
            this.colcodeItem.Name = "colcodeItem";
            this.colcodeItem.Visible = true;
            this.colcodeItem.VisibleIndex = 0;
            this.colcodeItem.Width = 94;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.trazabilidad;
            this.btnBuscarProd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnBuscarProd_ButtonClick);
            // 
            // colmp
            // 
            this.colmp.FieldName = "mp";
            this.colmp.MinWidth = 25;
            this.colmp.Name = "colmp";
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 1;
            this.colmp.Width = 94;
            // 
            // colfrom_almacen
            // 
            this.colfrom_almacen.ColumnEdit = this.luBodegaFrom;
            this.colfrom_almacen.FieldName = "from_almacen";
            this.colfrom_almacen.MinWidth = 25;
            this.colfrom_almacen.Name = "colfrom_almacen";
            this.colfrom_almacen.Visible = true;
            this.colfrom_almacen.VisibleIndex = 2;
            this.colfrom_almacen.Width = 94;
            // 
            // luBodegaFrom
            // 
            this.luBodegaFrom.AutoHeight = false;
            this.luBodegaFrom.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luBodegaFrom.DataSource = this.warehouseBindingSource;
            this.luBodegaFrom.DisplayMember = "WhsCode";
            this.luBodegaFrom.Name = "luBodegaFrom";
            this.luBodegaFrom.ValueMember = "WhsCode";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.dsAlmacenesExternos;
            // 
            // colto_almacen
            // 
            this.colto_almacen.ColumnEdit = this.luBodegaTO;
            this.colto_almacen.FieldName = "to_almacen";
            this.colto_almacen.MinWidth = 25;
            this.colto_almacen.Name = "colto_almacen";
            this.colto_almacen.Visible = true;
            this.colto_almacen.VisibleIndex = 3;
            this.colto_almacen.Width = 94;
            // 
            // luBodegaTO
            // 
            this.luBodegaTO.AutoHeight = false;
            this.luBodegaTO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luBodegaTO.DataSource = this.warehouseBindingSource;
            this.luBodegaTO.DisplayMember = "WhsCode";
            this.luBodegaTO.Name = "luBodegaTO";
            this.luBodegaTO.ValueMember = "WhsCode";
            // 
            // colcantidad_kilos
            // 
            this.colcantidad_kilos.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colcantidad_kilos.AppearanceCell.Options.UseBackColor = true;
            this.colcantidad_kilos.Caption = "Cantidad en Almacen";
            this.colcantidad_kilos.FieldName = "cantidad_kilos";
            this.colcantidad_kilos.MinWidth = 25;
            this.colcantidad_kilos.Name = "colcantidad_kilos";
            this.colcantidad_kilos.OptionsColumn.AllowEdit = false;
            this.colcantidad_kilos.Visible = true;
            this.colcantidad_kilos.VisibleIndex = 5;
            this.colcantidad_kilos.Width = 94;
            // 
            // colunidades
            // 
            this.colunidades.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colunidades.AppearanceCell.Options.UseBackColor = true;
            this.colunidades.Caption = "Unidades en Almacén";
            this.colunidades.FieldName = "unidades";
            this.colunidades.MinWidth = 25;
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 6;
            this.colunidades.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cantidad a Transferir";
            this.gridColumn1.FieldName = "cantidad_a_transferir";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 94;
            // 
            // txtCantIngresar
            // 
            this.txtCantIngresar.AutoHeight = false;
            this.txtCantIngresar.Name = "txtCantIngresar";
            // 
            // ceSeleccionar
            // 
            this.ceSeleccionar.AutoHeight = false;
            this.ceSeleccionar.Name = "ceSeleccionar";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(191, 30);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Properties.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(285, 28);
            this.txtProveedor.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Proveedor:_______";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(961, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha de documento:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(1152, 106);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(139, 28);
            this.dateEdit1.TabIndex = 41;
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
            this.btnAtras.Location = new System.Drawing.Point(1113, 15);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 43;
            this.btnAtras.Text = "Cancelar";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmMovimientoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 683);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gcTransferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xfrmMovimientoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmMovimientoStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBodegaTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTransferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantIngresar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceSeleccionar;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.BindingSource transferenciaStockBindingSource;
        private dsAlmacenesExternos dsAlmacenesExternos;
        private DevExpress.XtraGrid.Columns.GridColumn colcodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colfrom_almacen;
        private DevExpress.XtraGrid.Columns.GridColumn colto_almacen;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_kilos;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBuscarProd;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luBodegaFrom;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luBodegaTO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}