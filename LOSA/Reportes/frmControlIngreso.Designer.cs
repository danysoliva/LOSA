
namespace LOSA.Reportes
{
    partial class frmControlIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlIngreso));
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdBodegaPlanta = new DevExpress.XtraGrid.GridControl();
            this.bodegasProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportesInventario = new LOSA.Reportes.dsReportesInventario();
            this.grdvBodegaPlanta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCantidadPorBodega = new DevExpress.XtraGrid.GridControl();
            this.grdvCantidadPorBodega = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdResumenIngreso = new DevExpress.XtraGrid.GridControl();
            this.grdvResumenIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SeleccionMp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.mpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoC = new LOSA.Calidad.dsMantenimientoC();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBodegaPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvBodegaPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCantidadPorBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCantidadPorBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumenIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvResumenIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionMp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1372, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 53);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(296, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Reporte control ingreso de Materias primas";
            // 
            // grdBodegaPlanta
            // 
            this.grdBodegaPlanta.DataSource = this.bodegasProveedorBindingSource;
            this.grdBodegaPlanta.Location = new System.Drawing.Point(6, 62);
            this.grdBodegaPlanta.MainView = this.grdvBodegaPlanta;
            this.grdBodegaPlanta.Name = "grdBodegaPlanta";
            this.grdBodegaPlanta.Size = new System.Drawing.Size(953, 215);
            this.grdBodegaPlanta.TabIndex = 2;
            this.grdBodegaPlanta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvBodegaPlanta});
            // 
            // bodegasProveedorBindingSource
            // 
            this.bodegasProveedorBindingSource.DataMember = "BodegasProveedor";
            this.bodegasProveedorBindingSource.DataSource = this.dsReportesInventario;
            // 
            // dsReportesInventario
            // 
            this.dsReportesInventario.DataSetName = "dsReportesInventario";
            this.dsReportesInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdvBodegaPlanta
            // 
            this.grdvBodegaPlanta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbodega,
            this.colproveedor,
            this.colunidades,
            this.colkg});
            this.grdvBodegaPlanta.GridControl = this.grdBodegaPlanta;
            this.grdvBodegaPlanta.Name = "grdvBodegaPlanta";
            this.grdvBodegaPlanta.OptionsView.ShowAutoFilterRow = true;
            this.grdvBodegaPlanta.OptionsView.ShowFooter = true;
            this.grdvBodegaPlanta.OptionsView.ShowGroupPanel = false;
            this.grdvBodegaPlanta.OptionsView.ShowViewCaption = true;
            this.grdvBodegaPlanta.ViewCaption = "Cantidad en bodegas planta por proveedor";
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Bodega";
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.OptionsColumn.AllowEdit = false;
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 0;
            this.colbodega.Width = 104;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 1;
            this.colproveedor.Width = 392;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "Unidades";
            this.colunidades.DisplayFormat.FormatString = "{0:0.##.##} Ud.";
            this.colunidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", "Total={0:0.##.##} Ud.")});
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 2;
            this.colunidades.Width = 217;
            // 
            // colkg
            // 
            this.colkg.Caption = "Cantidad Kg.";
            this.colkg.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colkg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkg.FieldName = "kg";
            this.colkg.Name = "colkg";
            this.colkg.OptionsColumn.AllowEdit = false;
            this.colkg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kg", "Total={0:0.##.##} Kg.")});
            this.colkg.Visible = true;
            this.colkg.VisibleIndex = 3;
            this.colkg.Width = 222;
            // 
            // grdCantidadPorBodega
            // 
            this.grdCantidadPorBodega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCantidadPorBodega.DataMember = "CantidadBodega";
            this.grdCantidadPorBodega.DataSource = this.dsReportesInventario;
            this.grdCantidadPorBodega.Location = new System.Drawing.Point(997, 63);
            this.grdCantidadPorBodega.MainView = this.grdvCantidadPorBodega;
            this.grdCantidadPorBodega.Name = "grdCantidadPorBodega";
            this.grdCantidadPorBodega.Size = new System.Drawing.Size(474, 215);
            this.grdCantidadPorBodega.TabIndex = 3;
            this.grdCantidadPorBodega.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvCantidadPorBodega});
            // 
            // grdvCantidadPorBodega
            // 
            this.grdvCantidadPorBodega.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbodega1,
            this.colUnidades1,
            this.colCantidadKg});
            this.grdvCantidadPorBodega.GridControl = this.grdCantidadPorBodega;
            this.grdvCantidadPorBodega.Name = "grdvCantidadPorBodega";
            this.grdvCantidadPorBodega.OptionsView.ShowAutoFilterRow = true;
            this.grdvCantidadPorBodega.OptionsView.ShowGroupPanel = false;
            this.grdvCantidadPorBodega.OptionsView.ShowViewCaption = true;
            this.grdvCantidadPorBodega.ViewCaption = "Cantidad por bodegas";
            // 
            // colbodega1
            // 
            this.colbodega1.Caption = "Bodega";
            this.colbodega1.FieldName = "bodega";
            this.colbodega1.Name = "colbodega1";
            this.colbodega1.OptionsColumn.AllowEdit = false;
            this.colbodega1.Visible = true;
            this.colbodega1.VisibleIndex = 0;
            // 
            // colUnidades1
            // 
            this.colUnidades1.Caption = "unidades";
            this.colUnidades1.DisplayFormat.FormatString = "{0:0.##.##} Ud.";
            this.colUnidades1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnidades1.FieldName = "Unidades";
            this.colUnidades1.Name = "colUnidades1";
            this.colUnidades1.OptionsColumn.AllowEdit = false;
            this.colUnidades1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unidades", "Total={0:0.##.##} Ud.")});
            this.colUnidades1.Visible = true;
            this.colUnidades1.VisibleIndex = 1;
            // 
            // colCantidadKg
            // 
            this.colCantidadKg.Caption = "Cantidad";
            this.colCantidadKg.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colCantidadKg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidadKg.FieldName = "CantidadKg";
            this.colCantidadKg.Name = "colCantidadKg";
            this.colCantidadKg.OptionsColumn.AllowEdit = false;
            this.colCantidadKg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CantidadKg", "Total= {0:0.##.##} Kg.")});
            this.colCantidadKg.Visible = true;
            this.colCantidadKg.VisibleIndex = 2;
            // 
            // grdResumenIngreso
            // 
            this.grdResumenIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResumenIngreso.Location = new System.Drawing.Point(6, 297);
            this.grdResumenIngreso.MainView = this.grdvResumenIngreso;
            this.grdResumenIngreso.Name = "grdResumenIngreso";
            this.grdResumenIngreso.Size = new System.Drawing.Size(1465, 463);
            this.grdResumenIngreso.TabIndex = 4;
            this.grdResumenIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvResumenIngreso});
            // 
            // grdvResumenIngreso
            // 
            this.grdvResumenIngreso.GridControl = this.grdResumenIngreso;
            this.grdvResumenIngreso.Name = "grdvResumenIngreso";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 20);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Materia Prima:";
            // 
            // SeleccionMp
            // 
            this.SeleccionMp.Location = new System.Drawing.Point(119, 30);
            this.SeleccionMp.Name = "SeleccionMp";
            this.SeleccionMp.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.SeleccionMp.Properties.Appearance.Options.UseFont = true;
            this.SeleccionMp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SeleccionMp.Properties.DataSource = this.mpBindingSource;
            this.SeleccionMp.Properties.DisplayMember = "descripcion";
            this.SeleccionMp.Properties.PopupView = this.gridLookUpEdit1View;
            this.SeleccionMp.Properties.ValueMember = "id";
            this.SeleccionMp.Size = new System.Drawing.Size(414, 26);
            this.SeleccionMp.TabIndex = 6;
            this.SeleccionMp.EditValueChanged += new System.EventHandler(this.SeleccionMp_EditValueChanged);
            // 
            // mpBindingSource
            // 
            this.mpBindingSource.DataMember = "mp";
            this.mpBindingSource.DataSource = this.dsMantenimientoC;
            // 
            // dsMantenimientoC
            // 
            this.dsMantenimientoC.DataSetName = "dsMantenimientoC";
            this.dsMantenimientoC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Materia Prima";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // frmControlIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 772);
            this.Controls.Add(this.SeleccionMp);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdResumenIngreso);
            this.Controls.Add(this.grdCantidadPorBodega);
            this.Controls.Add(this.grdBodegaPlanta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmControlIngreso";
            this.Text = "Reporte de Control de Ingreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdBodegaPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvBodegaPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCantidadPorBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCantidadPorBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumenIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvResumenIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionMp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdBodegaPlanta;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvBodegaPlanta;
        private DevExpress.XtraGrid.GridControl grdCantidadPorBodega;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvCantidadPorBodega;
        private DevExpress.XtraGrid.GridControl grdResumenIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvResumenIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit SeleccionMp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource mpBindingSource;
        private Calidad.dsMantenimientoC dsMantenimientoC;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource bodegasProveedorBindingSource;
        private dsReportesInventario dsReportesInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colkg;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadKg;
    }
}