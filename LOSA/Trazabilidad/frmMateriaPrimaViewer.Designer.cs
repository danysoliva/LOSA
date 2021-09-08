namespace LOSA.Logistica
{
    partial class frmMateriaPrimaViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaPrimaViewer));
            this.gcLotes = new DevExpress.XtraGrid.GridControl();
            this.lotesXProveedorBindingSource = new System.Windows.Forms.BindingSource();
            this.dsLogistica = new LOSA.Logistica.dsLogistica2();
            this.gvLotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidMateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.materiaprimaBindingSource = new System.Windows.Forms.BindingSource();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.rowid = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmaterial = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNombre_Comercial = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTipo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTipo_F = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTipo_R = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCodigo_SAP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowFecha_Creación = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCreado_por = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTipo_Alimentación = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesXProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLotes
            // 
            this.gcLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLotes.DataSource = this.lotesXProveedorBindingSource;
            this.gcLotes.Location = new System.Drawing.Point(0, 289);
            this.gcLotes.MainView = this.gvLotes;
            this.gcLotes.Name = "gcLotes";
            this.gcLotes.Size = new System.Drawing.Size(760, 313);
            this.gcLotes.TabIndex = 88;
            this.gcLotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLotes});
            // 
            // lotesXProveedorBindingSource
            // 
            this.lotesXProveedorBindingSource.DataMember = "LotesXProveedor";
            this.lotesXProveedorBindingSource.DataSource = this.dsLogistica;
            // 
            // dsLogistica
            // 
            this.dsLogistica.DataSetName = "dsLogistica";
            this.dsLogistica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colMateriaPrima,
            this.colidMateriaPrima});
            this.gvLotes.GridControl = this.gcLotes;
            this.gvLotes.Name = "gvLotes";
            this.gvLotes.OptionsView.ShowAutoFilterRow = true;
            this.gvLotes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gvLotes.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.Caption = "ID Tarima";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowMove = false;
            this.colid.OptionsFilter.AllowAutoFilter = false;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "# Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowMove = false;
            this.collote_materia_prima.OptionsFilter.AllowFilter = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 0;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowMove = false;
            this.colfecha_ingreso.OptionsFilter.AllowFilter = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 1;
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
            this.colcantidad.VisibleIndex = 2;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowMove = false;
            this.colfecha_vencimiento.OptionsFilter.AllowFilter = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 3;
            // 
            // colMateriaPrima
            // 
            this.colMateriaPrima.Caption = "Materia Prima";
            this.colMateriaPrima.FieldName = "materia_prima";
            this.colMateriaPrima.Name = "colMateriaPrima";
            // 
            // colidMateriaPrima
            // 
            this.colidMateriaPrima.Caption = "ID Materia Prima";
            this.colidMateriaPrima.FieldName = "itemcode";
            this.colidMateriaPrima.Name = "colidMateriaPrima";
            // 
            // materiaprimaBindingSource
            // 
            this.materiaprimaBindingSource.DataMember = "Materia_prima_v2";
            this.materiaprimaBindingSource.DataSource = this.dsLogistica;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(603, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(144, 41);
            this.cmdHome.TabIndex = 90;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // vGridControl1
            // 
            this.vGridControl1.Appearance.RowHeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGridControl1.Appearance.RowHeaderPanel.Options.UseFont = true;
            this.vGridControl1.BandsInterval = 4;
            this.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.vGridControl1.DataMember = "view_mp";
            this.vGridControl1.DataSource = this.dsMantoTrazabilidad1;
            this.vGridControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGridControl1.Location = new System.Drawing.Point(4, 59);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 293;
            this.vGridControl1.RowHeaderWidth = 200;
            this.vGridControl1.RowHeaderWidthChangeStep = 4;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowid,
            this.rowcodigo,
            this.rowmaterial,
            this.rowNombre_Comercial,
            this.rowTipo,
            this.rowTipo_F,
            this.rowTipo_R,
            this.rowCodigo_SAP,
            this.rowFecha_Creación,
            this.rowCreado_por,
            this.rowTipo_Alimentación});
            this.vGridControl1.Size = new System.Drawing.Size(748, 224);
            this.vGridControl1.TabIndex = 91;
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowid
            // 
            this.rowid.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowid.Appearance.Options.UseFont = true;
            this.rowid.Name = "rowid";
            this.rowid.Properties.Caption = "id";
            this.rowid.Properties.FieldName = "id";
            this.rowid.Visible = false;
            // 
            // rowcodigo
            // 
            this.rowcodigo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowcodigo.Appearance.Options.UseFont = true;
            this.rowcodigo.Name = "rowcodigo";
            this.rowcodigo.Properties.Caption = "Código";
            this.rowcodigo.Properties.FieldName = "codigo";
            // 
            // rowmaterial
            // 
            this.rowmaterial.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowmaterial.Appearance.Options.UseFont = true;
            this.rowmaterial.Name = "rowmaterial";
            this.rowmaterial.Properties.Caption = "Nombre";
            this.rowmaterial.Properties.FieldName = "material";
            // 
            // rowNombre_Comercial
            // 
            this.rowNombre_Comercial.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowNombre_Comercial.Appearance.Options.UseFont = true;
            this.rowNombre_Comercial.Name = "rowNombre_Comercial";
            this.rowNombre_Comercial.Properties.Caption = "Nombre Comercial";
            this.rowNombre_Comercial.Properties.FieldName = "Nombre Comercial";
            // 
            // rowTipo
            // 
            this.rowTipo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowTipo.Appearance.Options.UseFont = true;
            this.rowTipo.Name = "rowTipo";
            this.rowTipo.Properties.Caption = "Tipo";
            this.rowTipo.Properties.FieldName = "Tipo";
            // 
            // rowTipo_F
            // 
            this.rowTipo_F.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowTipo_F.Appearance.Options.UseFont = true;
            this.rowTipo_F.Height = 20;
            this.rowTipo_F.Name = "rowTipo_F";
            this.rowTipo_F.Properties.Caption = "Tipo F";
            this.rowTipo_F.Properties.FieldName = "Tipo F";
            // 
            // rowTipo_R
            // 
            this.rowTipo_R.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowTipo_R.Appearance.Options.UseFont = true;
            this.rowTipo_R.Name = "rowTipo_R";
            this.rowTipo_R.Properties.Caption = "Tipo R";
            this.rowTipo_R.Properties.FieldName = "Tipo R";
            // 
            // rowCodigo_SAP
            // 
            this.rowCodigo_SAP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowCodigo_SAP.Appearance.Options.UseFont = true;
            this.rowCodigo_SAP.Name = "rowCodigo_SAP";
            this.rowCodigo_SAP.Properties.Caption = "Codigo SAP";
            this.rowCodigo_SAP.Properties.FieldName = "Codigo SAP";
            // 
            // rowFecha_Creación
            // 
            this.rowFecha_Creación.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowFecha_Creación.Appearance.Options.UseFont = true;
            this.rowFecha_Creación.Name = "rowFecha_Creación";
            this.rowFecha_Creación.Properties.Caption = "Fecha Creación";
            this.rowFecha_Creación.Properties.FieldName = "Fecha Creación";
            // 
            // rowCreado_por
            // 
            this.rowCreado_por.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowCreado_por.Appearance.Options.UseFont = true;
            this.rowCreado_por.Name = "rowCreado_por";
            this.rowCreado_por.Properties.Caption = "Creado por";
            this.rowCreado_por.Properties.FieldName = "Creado por";
            // 
            // rowTipo_Alimentación
            // 
            this.rowTipo_Alimentación.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rowTipo_Alimentación.Appearance.Options.UseFont = true;
            this.rowTipo_Alimentación.Name = "rowTipo_Alimentación";
            this.rowTipo_Alimentación.Properties.Caption = "Tipo Alimentación";
            this.rowTipo_Alimentación.Properties.FieldName = "Tipo Alimentación";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 21);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "Detalle Materia Prima";
            // 
            // frmMateriaPrimaViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 603);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.gcLotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMateriaPrimaViewer";
            this.Text = "+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLotesXMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesXProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLotes;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colMateriaPrima;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private dsLogistica2 dsLogistica;
        private System.Windows.Forms.BindingSource lotesXProveedorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidMateriaPrima;
        private System.Windows.Forms.BindingSource materiaprimaBindingSource;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Trazabilidad.dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcodigo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmaterial;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNombre_Comercial;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTipo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTipo_F;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTipo_R;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCodigo_SAP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowFecha_Creación;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCreado_por;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTipo_Alimentación;
    }
}