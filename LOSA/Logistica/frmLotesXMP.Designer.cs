namespace LOSA.Logistica
{
    partial class frmLotesXMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotesXMP));
            this.gcLotes = new DevExpress.XtraGrid.GridControl();
            this.lotesXProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogistica = new LOSA.Logistica.dsLogistica();
            this.gvLotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidMateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbMateriaPrima = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.materiaprimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesXProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLotes
            // 
            this.gcLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLotes.DataSource = this.lotesXProveedorBindingSource;
            this.gcLotes.Location = new System.Drawing.Point(0, 130);
            this.gcLotes.MainView = this.gvLotes;
            this.gcLotes.Name = "gcLotes";
            this.gcLotes.Size = new System.Drawing.Size(607, 351);
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
            this.gvLotes.OptionsView.ShowFooter = true;
            this.gvLotes.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "ID Tarima";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
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
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
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
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
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
            this.colcantidad.OptionsColumn.AllowEdit = false;
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
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
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
            // colidMateriaPrima
            // 
            this.colidMateriaPrima.Caption = "ID Materia Prima";
            this.colidMateriaPrima.FieldName = "itemcode";
            this.colidMateriaPrima.Name = "colidMateriaPrima";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 25);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "Materia Prima:";
            // 
            // cbMateriaPrima
            // 
            this.cbMateriaPrima.Location = new System.Drawing.Point(152, 92);
            this.cbMateriaPrima.Name = "cbMateriaPrima";
            this.cbMateriaPrima.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbMateriaPrima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriaPrima.Properties.Appearance.Options.UseFont = true;
            this.cbMateriaPrima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMateriaPrima.Properties.DataSource = this.materiaprimaBindingSource;
            this.cbMateriaPrima.Properties.DisplayMember = "itemdescrip";
            this.cbMateriaPrima.Properties.NullText = "";
            this.cbMateriaPrima.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbMateriaPrima.Properties.PopupFormSize = new System.Drawing.Size(400, 0);
            this.cbMateriaPrima.Properties.ValueMember = "itemcode";
            this.cbMateriaPrima.Properties.View = this.gvMateriaPrima;
            this.cbMateriaPrima.Size = new System.Drawing.Size(314, 32);
            this.cbMateriaPrima.TabIndex = 93;
            this.cbMateriaPrima.EditValueChanged += new System.EventHandler(this.cbMateriaPrima_EditValueChanged);
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gvMateriaPrima.OptionsView.ShowAutoFilterRow = true;
            this.gvMateriaPrima.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Materia Prima";
            this.gridColumn1.FieldName = "itemdescrip";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn1";
            this.gridColumn3.FieldName = "itemcode";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // cmdHome
            // 
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(30, 11);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(144, 59);
            this.cmdHome.TabIndex = 90;
            this.cmdHome.Text = "Home";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // materiaprimaBindingSource
            // 
            this.materiaprimaBindingSource.DataMember = "Materia_prima";
            this.materiaprimaBindingSource.DataSource = this.dsLogistica;
            // 
            // frmLotesXMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 482);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbMateriaPrima);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.gcLotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLotesXMP";
            this.Text = "frmLotesXMP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLotesXMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotesXProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMateriaPrima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaprimaBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cbMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private RecepcionMP.dsRecepcionMPx dsRecepcionMPx;
        private dsLogistica dsLogistica;
        private System.Windows.Forms.BindingSource lotesXProveedorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidMateriaPrima;
        private System.Windows.Forms.BindingSource materiaprimaBindingSource;
    }
}