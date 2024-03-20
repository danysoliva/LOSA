using LOSA.FromAMS;

namespace AMS.Compras.ControlInv
{
    partial class frmrequisa_devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrequisa_devolucion));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsControlInv_AMS1 = new dsControlInv_AMS();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcioin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grd_repuestos = new DevExpress.XtraGrid.GridControl();
            this.grdv_repuestos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequerido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenviar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsControlInv_AMS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_repuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_repuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.btnsave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCerrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnsave)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Id = 0;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnCerrar.ItemAppearance.Normal.Font")));
            this.btnCerrar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // btnsave
            // 
            resources.ApplyResources(this.btnsave, "btnsave");
            this.btnsave.Id = 1;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnsave.ItemAppearance.Normal.Font")));
            this.btnsave.ItemAppearance.Normal.Options.UseFont = true;
            this.btnsave.Name = "btnsave";
            this.btnsave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar3, "bar3");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // grd_data
            // 
            resources.ApplyResources(this.grd_data, "grd_data");
            this.grd_data.DataSource = this.dsControlInv_AMS1;
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.MenuManager = this.barManager1;
            this.grd_data.Name = "grd_data";
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsControlInv
            // 
            this.dsControlInv_AMS1.DataSetName = "dsControlInv_AMS";
            this.dsControlInv_AMS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.FilterPanel.Font")));
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.FocusedRow.Font")));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.FooterPanel.Font")));
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.GroupFooter.Font")));
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.GroupPanel.Font")));
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.GroupRow.Font")));
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.HeaderPanel.Font")));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.Preview.Font")));
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.Row.Font")));
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = ((System.Drawing.Font)(resources.GetObject("grdv_data.Appearance.TopNewRow.Font")));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colDescripcioin,
            this.colValor});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colDescripcioin
            // 
            resources.ApplyResources(this.colDescripcioin, "colDescripcioin");
            this.colDescripcioin.FieldName = "Descripcioin";
            this.colDescripcioin.Name = "colDescripcioin";
            this.colDescripcioin.OptionsColumn.AllowEdit = false;
            this.colDescripcioin.OptionsFilter.AllowFilter = false;
            // 
            // colValor
            // 
            resources.ApplyResources(this.colValor, "colValor");
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.AllowEdit = false;
            this.colValor.OptionsFilter.AllowFilter = false;
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Name = "labelControl4";
            // 
            // grd_repuestos
            // 
            resources.ApplyResources(this.grd_repuestos, "grd_repuestos");
            this.grd_repuestos.DataSource = this.dsControlInv_AMS1;
            this.grd_repuestos.MainView = this.grdv_repuestos;
            this.grd_repuestos.MenuManager = this.barManager1;
            this.grd_repuestos.Name = "grd_repuestos";
            this.grd_repuestos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_repuestos});
            // 
            // grdv_repuestos
            // 
            this.grdv_repuestos.Appearance.FilterPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.FilterPanel.Font")));
            this.grdv_repuestos.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_repuestos.Appearance.FocusedRow.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.FocusedRow.Font")));
            this.grdv_repuestos.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_repuestos.Appearance.FooterPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.FooterPanel.Font")));
            this.grdv_repuestos.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_repuestos.Appearance.GroupFooter.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.GroupFooter.Font")));
            this.grdv_repuestos.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_repuestos.Appearance.GroupPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.GroupPanel.Font")));
            this.grdv_repuestos.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_repuestos.Appearance.GroupRow.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.GroupRow.Font")));
            this.grdv_repuestos.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_repuestos.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.HeaderPanel.Font")));
            this.grdv_repuestos.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_repuestos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdv_repuestos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdv_repuestos.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.Preview.Font")));
            this.grdv_repuestos.Appearance.Preview.Options.UseFont = true;
            this.grdv_repuestos.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.Row.Font")));
            this.grdv_repuestos.Appearance.Row.Options.UseFont = true;
            this.grdv_repuestos.Appearance.TopNewRow.Font = ((System.Drawing.Font)(resources.GetObject("grdv_repuestos.Appearance.TopNewRow.Font")));
            this.grdv_repuestos.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_repuestos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colItemCode,
            this.colDescripcion,
            this.colCantidad,
            this.colExistencia,
            this.colRequerido,
            this.colenviar,
            this.gridColumn1,
            this.gridColumn2});
            this.grdv_repuestos.GridControl = this.grd_repuestos;
            this.grdv_repuestos.Name = "grdv_repuestos";
            this.grdv_repuestos.OptionsView.ShowAutoFilterRow = true;
            this.grdv_repuestos.OptionsView.ShowGroupPanel = false;
            this.grdv_repuestos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_repuestos_CellValueChanged);
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.OptionsColumn.AllowMove = false;
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.colItemCode, "colItemCode");
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowMove = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.colDescripcion, "colDescripcion");
            // 
            // colCantidad
            // 
            resources.ApplyResources(this.colCantidad, "colCantidad");
            this.colCantidad.DisplayFormat.FormatString = "{0:N2}";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "entregado";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.OptionsColumn.AllowMove = false;
            this.colCantidad.OptionsColumn.ReadOnly = true;
            this.colCantidad.OptionsFilter.AllowFilter = false;
            // 
            // colExistencia
            // 
            resources.ApplyResources(this.colExistencia, "colExistencia");
            this.colExistencia.DisplayFormat.FormatString = "{0:N2}";
            this.colExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistencia.FieldName = "existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.OptionsColumn.AllowEdit = false;
            // 
            // colRequerido
            // 
            resources.ApplyResources(this.colRequerido, "colRequerido");
            this.colRequerido.DisplayFormat.FormatString = "{0:N2}";
            this.colRequerido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRequerido.FieldName = "requerido";
            this.colRequerido.Name = "colRequerido";
            this.colRequerido.OptionsColumn.AllowMove = false;
            this.colRequerido.OptionsColumn.ReadOnly = true;
            this.colRequerido.OptionsFilter.AllowFilter = false;
            // 
            // colenviar
            // 
            this.colenviar.FieldName = "enviar";
            this.colenviar.Name = "colenviar";
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.DisplayFormat.FormatString = "{0:N2}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "pendiente";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn2.AppearanceCell.Font")));
            this.gridColumn2.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseForeColor = true;
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "devolucion";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            // 
            // frmrequisa_devolucion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd_repuestos);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmrequisa_devolucion.IconOptions.Icon")));
            this.Name = "frmrequisa_devolucion";
            this.Load += new System.EventHandler(this.frmrequisa_devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsControlInv_AMS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_repuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_repuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private DevExpress.XtraGrid.GridControl grd_repuestos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_repuestos;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsControlInv_AMS dsControlInv_AMS1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcioin;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colRequerido;
        private DevExpress.XtraGrid.Columns.GridColumn colenviar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}