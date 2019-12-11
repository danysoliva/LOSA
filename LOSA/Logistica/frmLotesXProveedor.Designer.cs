namespace LOSA.Logistica
{
    partial class frmLotesXProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotesXProveedor));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.glueProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogistica = new LOSA.Logistica.dsLogistica();
            this.gvProveedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLotes = new DevExpress.XtraGrid.GridControl();
            this.lotesXProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvLotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.cbMateriaPrima = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.materiaprimaporproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.glueProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesXProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaporproveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(36, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(144, 59);
            this.cmdHome.TabIndex = 84;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 25);
            this.labelControl1.TabIndex = 85;
            this.labelControl1.Text = "Proveedor:";
            // 
            // glueProveedor
            // 
            this.glueProveedor.Location = new System.Drawing.Point(158, 84);
            this.glueProveedor.Name = "glueProveedor";
            this.glueProveedor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.glueProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glueProveedor.Properties.Appearance.Options.UseFont = true;
            this.glueProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueProveedor.Properties.DataSource = this.proveedoresBindingSource;
            this.glueProveedor.Properties.DisplayMember = "cardname";
            this.glueProveedor.Properties.NullText = "";
            this.glueProveedor.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.glueProveedor.Properties.PopupFormSize = new System.Drawing.Size(400, 0);
            this.glueProveedor.Properties.ValueMember = "carcode";
            this.glueProveedor.Properties.View = this.gvProveedores;
            this.glueProveedor.Size = new System.Drawing.Size(314, 32);
            this.glueProveedor.TabIndex = 86;
            this.glueProveedor.EditValueChanged += new System.EventHandler(this.GlueProveedor_EditValueChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dsLogistica;
            // 
            // dsLogistica
            // 
            this.dsLogistica.DataSetName = "dsLogistica";
            this.dsLogistica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProveedores
            // 
            this.gvProveedores.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.FocusedCell.Options.UseFont = true;
            this.gvProveedores.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.FocusedRow.Options.UseFont = true;
            this.gvProveedores.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.GroupRow.Options.UseFont = true;
            this.gvProveedores.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProveedores.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvProveedores.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.Row.Options.UseFont = true;
            this.gvProveedores.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProveedores.Appearance.SelectedRow.Options.UseFont = true;
            this.gvProveedores.AutoFillColumn = this.gridColumn2;
            this.gvProveedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor,
            this.gridColumn2});
            this.gvProveedores.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvProveedores.Name = "gvProveedores";
            this.gvProveedores.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvProveedores.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Proveedores";
            this.gridColumn2.FieldName = "cardname";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 100;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "gridColumn1";
            this.colIdProveedor.FieldName = "carcode";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // gcLotes
            // 
            this.gcLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLotes.DataSource = this.lotesXProveedorBindingSource;
            this.gcLotes.Location = new System.Drawing.Point(-1, 160);
            this.gcLotes.MainView = this.gvLotes;
            this.gcLotes.Name = "gcLotes";
            this.gcLotes.Size = new System.Drawing.Size(607, 322);
            this.gcLotes.TabIndex = 87;
            this.gcLotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotes});
            // 
            // lotesXProveedorBindingSource
            // 
            this.lotesXProveedorBindingSource.DataMember = "LotesXProveedor";
            this.lotesXProveedorBindingSource.DataSource = this.dsLogistica;
            // 
            // gvLotes
            // 
            this.gvLotes.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvLotes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLotes.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvLotes.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvLotes.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvLotes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvLotes.Appearance.FocusedRow.Options.UseFont = true;
            this.gvLotes.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLotes.Appearance.FooterPanel.Options.UseFont = true;
            this.gvLotes.Appearance.GroupButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLotes.Appearance.GroupButton.Options.UseFont = true;
            this.gvLotes.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLotes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Teal;
            this.gvLotes.Appearance.GroupRow.Options.UseFont = true;
            this.gvLotes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvLotes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvLotes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLotes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvLotes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLotes.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvLotes.Appearance.Row.Options.UseFont = true;
            this.gvLotes.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvLotes.Appearance.SelectedRow.Options.UseFont = true;
            this.gvLotes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvLotes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvLotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote_materia_prima,
            this.colfecha_ingreso,
            this.colcantidad,
            this.colfecha_vencimiento,
            this.colMateriaPrima});
            this.gvLotes.GridControl = this.gcLotes;
            this.gvLotes.Name = "gvLotes";
            this.gvLotes.OptionsView.ShowFooter = true;
            this.gvLotes.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "ID Tarima";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowMove = false;
            this.colid.OptionsFilter.AllowAutoFilter = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "# Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowMove = false;
            this.collote_materia_prima.OptionsFilter.AllowFilter = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 1;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowMove = false;
            this.colfecha_ingreso.OptionsFilter.AllowFilter = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowMove = false;
            this.colcantidad.OptionsFilter.AllowFilter = false;
            this.colcantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "Total={0:#.##}")});
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowMove = false;
            this.colfecha_vencimiento.OptionsFilter.AllowFilter = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 4;
            // 
            // colMateriaPrima
            // 
            this.colMateriaPrima.Caption = "Materia Prima";
            this.colMateriaPrima.FieldName = "materia_prima";
            this.colMateriaPrima.Name = "colMateriaPrima";
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMateriaPrima
            // 
            this.cbMateriaPrima.Location = new System.Drawing.Point(158, 122);
            this.cbMateriaPrima.Name = "cbMateriaPrima";
            this.cbMateriaPrima.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbMateriaPrima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriaPrima.Properties.Appearance.Options.UseFont = true;
            this.cbMateriaPrima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMateriaPrima.Properties.DataSource = this.materiaprimaporproveedorBindingSource;
            this.cbMateriaPrima.Properties.DisplayMember = "materia_prima";
            this.cbMateriaPrima.Properties.NullText = "";
            this.cbMateriaPrima.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbMateriaPrima.Properties.PopupFormSize = new System.Drawing.Size(400, 0);
            this.cbMateriaPrima.Properties.View = this.gvMateriaPrima;
            this.cbMateriaPrima.Size = new System.Drawing.Size(314, 32);
            this.cbMateriaPrima.TabIndex = 88;
            this.cbMateriaPrima.EditValueChanged += new System.EventHandler(this.CbMateriaPrima_EditValueChanged);
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.Row.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMateriaPrima.AutoFillColumn = this.gridColumn1;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1});
            this.gvMateriaPrima.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Materia Prima";
            this.gridColumn1.FieldName = "materia_prima";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn1";
            this.gridColumn3.FieldName = "id_materia_prima";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 25);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "Materia Prima:";
            // 
            // materiaprimaporproveedorBindingSource
            // 
            this.materiaprimaporproveedorBindingSource.DataMember = "Materia_prima_por_proveedor";
            this.materiaprimaporproveedorBindingSource.DataSource = this.dsLogistica;
            // 
            // frmLotesXProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 482);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbMateriaPrima);
            this.Controls.Add(this.gcLotes);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.glueProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLotesXProveedor";
            this.Text = "frmLotesXProveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLotesXProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glueProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesXProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaporproveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsLogistica dsLogistica;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit glueProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedores;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gcLotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotes;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private System.Windows.Forms.BindingSource lotesXProveedorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colMateriaPrima;
        private DevExpress.XtraEditors.GridLookUpEdit cbMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource materiaprimaporproveedorBindingSource;
    }
}