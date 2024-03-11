﻿
namespace LOSA.Compras
{
    partial class frmOrdenesCompraMain
    {

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenesCompraMain));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtExoneracion = new System.Windows.Forms.TextBox();
            this.lblExoneracion = new DevExpress.XtraEditors.LabelControl();
            this.txtTasaCambio = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barbtnCancelOrden = new DevExpress.XtraBars.BarButtonItem();
            this.txtMoneda = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TsExoOIsv = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.grdTipoOrden = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipoordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtContactoPerson = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblSucursal = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodProv = new DevExpress.XtraEditors.ButtonEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.cmdAddDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSiguiente = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuarioCreador = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.grdvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_d_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposGrdCapitulo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.capitulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExoneracion1 = new LOSA.Finanzas.dsExoneracion();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colU_AQUA_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartida_arancelaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposPartidaArancelaria = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.partidaarancelariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio_por_unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindicador_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposGrdIndicadorIVA = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.ivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposGrdBodega = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWhsCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWhsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia_base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.btnShowPopu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TsExoOIsv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdCapitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPartidaArancelaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdIndicadorIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtExoneracion);
            this.panelControl1.Controls.Add(this.lblExoneracion);
            this.panelControl1.Controls.Add(this.txtTasaCambio);
            this.panelControl1.Controls.Add(this.txtMoneda);
            this.panelControl1.Controls.Add(this.comboBoxEdit1);
            this.panelControl1.Controls.Add(this.TsExoOIsv);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.grdTipoOrden);
            this.panelControl1.Controls.Add(this.txtContactoPerson);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.lblSucursal);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.txtCodProv);
            this.panelControl1.Controls.Add(this.txtProveedor);
            this.panelControl1.Controls.Add(this.cmdAddDetalle);
            this.panelControl1.Controls.Add(this.dtFechaContabilizacion);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dtFechaRegistro);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtEstado);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtDocNum);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cmdClose);
            this.panelControl1.Controls.Add(this.cmdGuardar);
            this.panelControl1.Controls.Add(this.cmdNuevo);
            this.panelControl1.Controls.Add(this.cmdBuscar);
            this.panelControl1.Controls.Add(this.cmdSiguiente);
            this.panelControl1.Controls.Add(this.cmdAnterior);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Location = new System.Drawing.Point(4, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1483, 256);
            this.panelControl1.TabIndex = 51;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.BackColor = System.Drawing.Color.White;
            this.txtExoneracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExoneracion.Enabled = false;
            this.txtExoneracion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtExoneracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtExoneracion.Location = new System.Drawing.Point(1164, 208);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.Size = new System.Drawing.Size(189, 19);
            this.txtExoneracion.TabIndex = 85;
            // 
            // lblExoneracion
            // 
            this.lblExoneracion.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblExoneracion.Appearance.Options.UseFont = true;
            this.lblExoneracion.Location = new System.Drawing.Point(994, 208);
            this.lblExoneracion.Name = "lblExoneracion";
            this.lblExoneracion.Size = new System.Drawing.Size(249, 18);
            this.lblExoneracion.TabIndex = 84;
            this.lblExoneracion.Text = "# Exoneracion______________";
            // 
            // txtTasaCambio
            // 
            this.txtTasaCambio.Location = new System.Drawing.Point(326, 179);
            this.txtTasaCambio.MenuManager = this.barManager1;
            this.txtTasaCambio.Name = "txtTasaCambio";
            this.txtTasaCambio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTasaCambio.Properties.Appearance.Options.UseFont = true;
            this.txtTasaCambio.Size = new System.Drawing.Size(122, 24);
            this.txtTasaCambio.TabIndex = 83;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnCancelOrden});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1490, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 691);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1490, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 650);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1490, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 650);
            // 
            // barbtnCancelOrden
            // 
            this.barbtnCancelOrden.Caption = "Cancelar";
            this.barbtnCancelOrden.Id = 0;
            this.barbtnCancelOrden.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelOrden.ImageOptions.Image")));
            this.barbtnCancelOrden.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnCancelOrden.ImageOptions.LargeImage")));
            this.barbtnCancelOrden.Name = "barbtnCancelOrden";
            this.barbtnCancelOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCancelOrden_ItemClick);
            // 
            // txtMoneda
            // 
            this.txtMoneda.Enabled = false;
            this.txtMoneda.Location = new System.Drawing.Point(220, 179);
            this.txtMoneda.MenuManager = this.barManager1;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMoneda.Properties.Appearance.Options.UseFont = true;
            this.txtMoneda.Size = new System.Drawing.Size(100, 24);
            this.txtMoneda.TabIndex = 82;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(48, 179);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEdit1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEdit1.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEdit1.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Moneda local",
            "Moneda del sistema",
            "Moneda SN"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(170, 24);
            this.comboBoxEdit1.TabIndex = 81;
            // 
            // TsExoOIsv
            // 
            this.TsExoOIsv.EditValue = true;
            this.TsExoOIsv.Location = new System.Drawing.Point(1164, 176);
            this.TsExoOIsv.MenuManager = this.barManager1;
            this.TsExoOIsv.Name = "TsExoOIsv";
            this.TsExoOIsv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.TsExoOIsv.Properties.Appearance.Options.UseFont = true;
            this.TsExoOIsv.Properties.OffText = "No, con ISV";
            this.TsExoOIsv.Properties.OnText = "Si";
            this.TsExoOIsv.Size = new System.Drawing.Size(189, 23);
            this.TsExoOIsv.TabIndex = 76;
            this.TsExoOIsv.Toggled += new System.EventHandler(this.TsExoOIsv_Toggled);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(994, 178);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(260, 18);
            this.labelControl13.TabIndex = 80;
            this.labelControl13.Text = "OC Exonerada _______________";
            // 
            // grdTipoOrden
            // 
            this.grdTipoOrden.Location = new System.Drawing.Point(1164, 143);
            this.grdTipoOrden.MenuManager = this.barManager1;
            this.grdTipoOrden.Name = "grdTipoOrden";
            this.grdTipoOrden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdTipoOrden.Properties.Appearance.Options.UseFont = true;
            this.grdTipoOrden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoOrden.Properties.DataSource = this.tipoordenBindingSource;
            this.grdTipoOrden.Properties.DisplayMember = "descripcion";
            this.grdTipoOrden.Properties.NullText = "";
            this.grdTipoOrden.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdTipoOrden.Properties.ValueMember = "id";
            this.grdTipoOrden.Size = new System.Drawing.Size(189, 24);
            this.grdTipoOrden.TabIndex = 79;
            // 
            // tipoordenBindingSource
            // 
            this.tipoordenBindingSource.DataMember = "tipo_orden";
            this.tipoordenBindingSource.DataSource = this.dsCompras1;
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion,
            this.colconcat_});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // colconcat_
            // 
            this.colconcat_.Caption = "Seleccione el Tipo";
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.Visible = true;
            this.colconcat_.VisibleIndex = 0;
            // 
            // txtContactoPerson
            // 
            this.txtContactoPerson.BackColor = System.Drawing.Color.White;
            this.txtContactoPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactoPerson.Enabled = false;
            this.txtContactoPerson.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtContactoPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtContactoPerson.Location = new System.Drawing.Point(220, 150);
            this.txtContactoPerson.Name = "txtContactoPerson";
            this.txtContactoPerson.Size = new System.Drawing.Size(228, 19);
            this.txtContactoPerson.TabIndex = 78;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(47, 151);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(264, 18);
            this.labelControl12.TabIndex = 77;
            this.labelControl12.Text = "Persona de Contacto___________";
            // 
            // lblSucursal
            // 
            this.lblSucursal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSucursal.Appearance.Options.UseFont = true;
            this.lblSucursal.Location = new System.Drawing.Point(994, 148);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(285, 18);
            this.lblSucursal.TabIndex = 75;
            this.lblSucursal.Text = "Tipo de Orden__________________";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(275, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 33);
            this.btnPrint.TabIndex = 73;
            this.btnPrint.ToolTip = "Impirmir";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtCodProv
            // 
            this.txtCodProv.Location = new System.Drawing.Point(220, 86);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCodProv.Properties.Appearance.Options.UseFont = true;
            this.txtCodProv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtCodProv.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCodProv.Properties.ReadOnly = true;
            this.txtCodProv.Size = new System.Drawing.Size(228, 24);
            this.txtCodProv.TabIndex = 69;
            this.txtCodProv.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCodProv_ButtonClick);
            this.txtCodProv.Click += new System.EventHandler(this.txtCodProv_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(220, 117);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Size = new System.Drawing.Size(228, 24);
            this.txtProveedor.TabIndex = 70;
            // 
            // cmdAddDetalle
            // 
            this.cmdAddDetalle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAddDetalle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAddDetalle.ImageOptions.SvgImage")));
            this.cmdAddDetalle.Location = new System.Drawing.Point(10, 215);
            this.cmdAddDetalle.Name = "cmdAddDetalle";
            this.cmdAddDetalle.Size = new System.Drawing.Size(47, 33);
            this.cmdAddDetalle.TabIndex = 67;
            this.cmdAddDetalle.Tag = "Agregar Item o Servicio";
            this.cmdAddDetalle.ToolTip = "Guardar";
            this.cmdAddDetalle.Click += new System.EventHandler(this.cmdAddDetalle_Click);
            // 
            // dtFechaContabilizacion
            // 
            this.dtFechaContabilizacion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaContabilizacion.Location = new System.Drawing.Point(1164, 83);
            this.dtFechaContabilizacion.Name = "dtFechaContabilizacion";
            this.dtFechaContabilizacion.Size = new System.Drawing.Size(189, 26);
            this.dtFechaContabilizacion.TabIndex = 65;
            this.dtFechaContabilizacion.ValueChanged += new System.EventHandler(this.dtFechaContabilizacion_ValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(994, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(274, 18);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Fecha Contabilizacion___________";
            // 
            // dtFechaRegistro
            // 
            this.dtFechaRegistro.Enabled = false;
            this.dtFechaRegistro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRegistro.Location = new System.Drawing.Point(1164, 52);
            this.dtFechaRegistro.Name = "dtFechaRegistro";
            this.dtFechaRegistro.Size = new System.Drawing.Size(189, 26);
            this.dtFechaRegistro.TabIndex = 63;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(994, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(223, 18);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Fecha Registro___________";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtEstado.Location = new System.Drawing.Point(1164, 116);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(189, 19);
            this.txtEstado.TabIndex = 61;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(994, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(201, 18);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Estado_______________";
            // 
            // txtDocNum
            // 
            this.txtDocNum.BackColor = System.Drawing.Color.White;
            this.txtDocNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocNum.Enabled = false;
            this.txtDocNum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDocNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDocNum.Location = new System.Drawing.Point(220, 60);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(228, 19);
            this.txtDocNum.TabIndex = 57;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(48, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(177, 18);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Num Doc___________";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdClose.Location = new System.Drawing.Point(1428, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(47, 33);
            this.cmdClose.TabIndex = 52;
            this.cmdClose.ToolTip = "Cerrar Ventana";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(222, 12);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(47, 33);
            this.cmdGuardar.TabIndex = 51;
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.ImageOptions.Image")));
            this.cmdNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdNuevo.Location = new System.Drawing.Point(169, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(47, 33);
            this.cmdNuevo.TabIndex = 50;
            this.cmdNuevo.ToolTip = "Nuevo";
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdBuscar.ImageOptions.SvgImage")));
            this.cmdBuscar.Location = new System.Drawing.Point(116, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(47, 33);
            this.cmdBuscar.TabIndex = 49;
            this.cmdBuscar.ToolTip = "Buscar";
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdSiguiente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdSiguiente.ImageOptions.SvgImage")));
            this.cmdSiguiente.Location = new System.Drawing.Point(63, 12);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(47, 33);
            this.cmdSiguiente.TabIndex = 48;
            this.cmdSiguiente.ToolTip = "Siguiente";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAnterior.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAnterior.ImageOptions.SvgImage")));
            this.cmdAnterior.Location = new System.Drawing.Point(10, 12);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(47, 33);
            this.cmdAnterior.TabIndex = 47;
            this.cmdAnterior.ToolTip = "Anterior";
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(189, 18);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Proveedor___________";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 120);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(170, 18);
            this.labelControl6.TabIndex = 72;
            this.labelControl6.Text = "Nombre___________";
            // 
            // txtUsuarioCreador
            // 
            this.txtUsuarioCreador.BackColor = System.Drawing.Color.White;
            this.txtUsuarioCreador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioCreador.Enabled = false;
            this.txtUsuarioCreador.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUsuarioCreador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUsuarioCreador.Location = new System.Drawing.Point(154, 8);
            this.txtUsuarioCreador.Name = "txtUsuarioCreador";
            this.txtUsuarioCreador.Size = new System.Drawing.Size(228, 19);
            this.txtUsuarioCreador.TabIndex = 59;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 18);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Usuario___________";
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataMember = "sucursales";
            this.sucursalesBindingSource.DataSource = this.dsCompras1;
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataMember = "oc_detalle_exonerada";
            this.grDetalle.DataSource = this.dsCompras1;
            this.grDetalle.Location = new System.Drawing.Point(4, 253);
            this.grDetalle.MainView = this.grdvDetalle;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ButtonDeleteRow,
            this.reposGrdCapitulo,
            this.reposPartidaArancelaria,
            this.reposGrdIndicadorIVA,
            this.reposGrdBodega});
            this.grDetalle.Size = new System.Drawing.Size(1483, 271);
            this.grDetalle.TabIndex = 52;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDetalle});
            this.grDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grDetalle_MouseDown);
            // 
            // grdvDetalle
            // 
            this.grdvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdvDetalle.Appearance.Row.Options.UseFont = true;
            this.grdvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_d_orden,
            this.colid_h,
            this.colcapitulo,
            this.colpartida_arancelaria,
            this.colitemcode,
            this.coldescripcion_articulo,
            this.colcantidad,
            this.colprecio_por_unidad,
            this.colindicador_impuesto,
            this.colbodega,
            this.coltotal,
            this.colreferencia_base,
            this.gridColumn1});
            this.grdvDetalle.CustomizationFormBounds = new System.Drawing.Rectangle(774, 457, 260, 282);
            this.grdvDetalle.GridControl = this.grDetalle;
            this.grdvDetalle.Name = "grdvDetalle";
            this.grdvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.grdvDetalle.OptionsView.ShowFooter = true;
            this.grdvDetalle.OptionsView.ShowGroupPanel = false;
            this.grdvDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdvDetalle_CellValueChanged);
            // 
            // colid_d_orden
            // 
            this.colid_d_orden.FieldName = "id_d_orden";
            this.colid_d_orden.Name = "colid_d_orden";
            this.colid_d_orden.Visible = true;
            this.colid_d_orden.VisibleIndex = 0;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            this.colid_h.Visible = true;
            this.colid_h.VisibleIndex = 1;
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.ColumnEdit = this.reposGrdCapitulo;
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 2;
            this.colcapitulo.Width = 102;
            // 
            // reposGrdCapitulo
            // 
            this.reposGrdCapitulo.AutoHeight = false;
            this.reposGrdCapitulo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposGrdCapitulo.DataSource = this.capitulosBindingSource;
            this.reposGrdCapitulo.DisplayMember = "Code";
            this.reposGrdCapitulo.Name = "reposGrdCapitulo";
            this.reposGrdCapitulo.NullText = "";
            this.reposGrdCapitulo.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.reposGrdCapitulo.ValueMember = "Code";
            this.reposGrdCapitulo.EditValueChanged += new System.EventHandler(this.reposGrdCapitulo_EditValueChanged);
            // 
            // capitulosBindingSource
            // 
            this.capitulosBindingSource.DataMember = "capitulos";
            this.capitulosBindingSource.DataSource = this.dsExoneracion1;
            // 
            // dsExoneracion1
            // 
            this.dsExoneracion1.DataSetName = "dsExoneracion";
            this.dsExoneracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode1,
            this.colU_AQUA_Desc,
            this.colconcat_2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.Name = "colCode1";
            // 
            // colU_AQUA_Desc
            // 
            this.colU_AQUA_Desc.FieldName = "U_AQUA_Desc";
            this.colU_AQUA_Desc.Name = "colU_AQUA_Desc";
            // 
            // colconcat_2
            // 
            this.colconcat_2.FieldName = "concat_";
            this.colconcat_2.MinWidth = 60;
            this.colconcat_2.Name = "colconcat_2";
            this.colconcat_2.Visible = true;
            this.colconcat_2.VisibleIndex = 0;
            // 
            // colpartida_arancelaria
            // 
            this.colpartida_arancelaria.Caption = "Partida Arancelaria";
            this.colpartida_arancelaria.ColumnEdit = this.reposPartidaArancelaria;
            this.colpartida_arancelaria.FieldName = "partida_arancelaria";
            this.colpartida_arancelaria.Name = "colpartida_arancelaria";
            this.colpartida_arancelaria.Visible = true;
            this.colpartida_arancelaria.VisibleIndex = 3;
            this.colpartida_arancelaria.Width = 102;
            // 
            // reposPartidaArancelaria
            // 
            this.reposPartidaArancelaria.AutoHeight = false;
            this.reposPartidaArancelaria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposPartidaArancelaria.DataSource = this.partidaarancelariaBindingSource;
            this.reposPartidaArancelaria.DisplayMember = "Partida_arancelaria";
            this.reposPartidaArancelaria.Name = "reposPartidaArancelaria";
            this.reposPartidaArancelaria.NullText = "";
            this.reposPartidaArancelaria.PopupView = this.gridView1;
            this.reposPartidaArancelaria.ValueMember = "Partida_arancelaria";
            // 
            // partidaarancelariaBindingSource
            // 
            this.partidaarancelariaBindingSource.DataMember = "partida_arancelaria";
            this.partidaarancelariaBindingSource.DataSource = this.dsExoneracion1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Numero de Articulo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 4;
            this.colitemcode.Width = 102;
            // 
            // coldescripcion_articulo
            // 
            this.coldescripcion_articulo.Caption = "Descripcion de Articulo";
            this.coldescripcion_articulo.FieldName = "descripcion_articulo";
            this.coldescripcion_articulo.Name = "coldescripcion_articulo";
            this.coldescripcion_articulo.Visible = true;
            this.coldescripcion_articulo.VisibleIndex = 5;
            this.coldescripcion_articulo.Width = 102;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 102;
            // 
            // colprecio_por_unidad
            // 
            this.colprecio_por_unidad.Caption = "Precio por unidad";
            this.colprecio_por_unidad.FieldName = "precio_por_unidad";
            this.colprecio_por_unidad.Name = "colprecio_por_unidad";
            this.colprecio_por_unidad.Visible = true;
            this.colprecio_por_unidad.VisibleIndex = 7;
            this.colprecio_por_unidad.Width = 102;
            // 
            // colindicador_impuesto
            // 
            this.colindicador_impuesto.Caption = "Indicador de Impuestos";
            this.colindicador_impuesto.ColumnEdit = this.reposGrdIndicadorIVA;
            this.colindicador_impuesto.FieldName = "indicador_impuesto";
            this.colindicador_impuesto.Name = "colindicador_impuesto";
            this.colindicador_impuesto.Visible = true;
            this.colindicador_impuesto.VisibleIndex = 8;
            this.colindicador_impuesto.Width = 102;
            // 
            // reposGrdIndicadorIVA
            // 
            this.reposGrdIndicadorIVA.AutoHeight = false;
            this.reposGrdIndicadorIVA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposGrdIndicadorIVA.DataSource = this.ivaBindingSource;
            this.reposGrdIndicadorIVA.DisplayMember = "Code";
            this.reposGrdIndicadorIVA.Name = "reposGrdIndicadorIVA";
            this.reposGrdIndicadorIVA.NullText = "";
            this.reposGrdIndicadorIVA.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.reposGrdIndicadorIVA.ValueMember = "Code";
            // 
            // ivaBindingSource
            // 
            this.ivaBindingSource.DataMember = "iva";
            this.ivaBindingSource.DataSource = this.dsCompras1;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colRate});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Descripcion";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colRate
            // 
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Almacen";
            this.colbodega.ColumnEdit = this.reposGrdBodega;
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 9;
            this.colbodega.Width = 102;
            // 
            // reposGrdBodega
            // 
            this.reposGrdBodega.AutoHeight = false;
            this.reposGrdBodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposGrdBodega.DataSource = this.bodegasBindingSource;
            this.reposGrdBodega.DisplayMember = "WhsCode";
            this.reposGrdBodega.Name = "reposGrdBodega";
            this.reposGrdBodega.PopupView = this.gridView2;
            this.reposGrdBodega.ValueMember = "WhsCode";
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataMember = "bodegas";
            this.bodegasBindingSource.DataSource = this.dsCompras1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWhsCode,
            this.colWhsName,
            this.colconcat_1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colWhsCode
            // 
            this.colWhsCode.FieldName = "WhsCode";
            this.colWhsCode.Name = "colWhsCode";
            // 
            // colWhsName
            // 
            this.colWhsName.FieldName = "WhsName";
            this.colWhsName.Name = "colWhsName";
            // 
            // colconcat_1
            // 
            this.colconcat_1.Caption = "Seleccio de Bodega";
            this.colconcat_1.FieldName = "concat_";
            this.colconcat_1.Name = "colconcat_1";
            this.colconcat_1.Visible = true;
            this.colconcat_1.VisibleIndex = 0;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total (doc.)";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 10;
            this.coltotal.Width = 102;
            // 
            // colreferencia_base
            // 
            this.colreferencia_base.Caption = "Referencia Base";
            this.colreferencia_base.FieldName = "referencia_base";
            this.colreferencia_base.Name = "colreferencia_base";
            this.colreferencia_base.Visible = true;
            this.colreferencia_base.VisibleIndex = 11;
            this.colreferencia_base.Width = 107;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.ButtonDeleteRow;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            this.gridColumn1.Width = 105;
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.AutoHeight = false;
            this.ButtonDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ButtonDeleteRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonDeleteRow_ButtonClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.txtComentarios);
            this.panelControl2.Controls.Add(this.txtTotal);
            this.panelControl2.Controls.Add(this.txtImpuesto);
            this.panelControl2.Controls.Add(this.txtSubtotal);
            this.panelControl2.Controls.Add(this.btnShowPopu);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txtUsuarioCreador);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(4, 526);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1483, 180);
            this.panelControl2.TabIndex = 53;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            this.panelControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl2_MouseDown);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(154, 51);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtComentarios.Properties.Appearance.Options.UseFont = true;
            this.txtComentarios.Size = new System.Drawing.Size(448, 96);
            this.txtComentarios.TabIndex = 85;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.EditValue = "0.00";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1138, 64);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("mask", "c");
            this.txtTotal.Properties.NullText = "0.00";
            this.txtTotal.Properties.NullValuePrompt = "0.00";
            this.txtTotal.Size = new System.Drawing.Size(108, 24);
            this.txtTotal.TabIndex = 81;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImpuesto.EditValue = "0.00";
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(1138, 34);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtImpuesto.Properties.Appearance.Options.UseFont = true;
            this.txtImpuesto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtImpuesto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtImpuesto.Properties.MaskSettings.Set("mask", "c");
            this.txtImpuesto.Properties.NullText = "0.00";
            this.txtImpuesto.Size = new System.Drawing.Size(108, 24);
            this.txtImpuesto.TabIndex = 80;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubtotal.EditValue = "0.00";
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1138, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubtotal.Properties.MaskSettings.Set("mask", "c");
            this.txtSubtotal.Properties.NullText = "0.00";
            this.txtSubtotal.Size = new System.Drawing.Size(108, 24);
            this.txtSubtotal.TabIndex = 79;
            // 
            // btnShowPopu
            // 
            this.btnShowPopu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowPopu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPopu.Appearance.Options.UseFont = true;
            this.btnShowPopu.Enabled = false;
            this.btnShowPopu.Location = new System.Drawing.Point(1213, 118);
            this.btnShowPopu.Name = "btnShowPopu";
            this.btnShowPopu.Size = new System.Drawing.Size(248, 29);
            this.btnShowPopu.TabIndex = 78;
            this.btnShowPopu.Text = "Copiar de Solicitud de Compra";
            this.btnShowPopu.Click += new System.EventHandler(this.btnShowPopu_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(5, 52);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(165, 18);
            this.labelControl11.TabIndex = 77;
            this.labelControl11.Text = "Comentarios_______";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(1036, 11);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(137, 18);
            this.labelControl10.TabIndex = 84;
            this.labelControl10.Text = "SubTotal_______";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(1036, 69);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(189, 18);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "Total_______________";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(1036, 41);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(141, 18);
            this.labelControl9.TabIndex = 83;
            this.labelControl9.Text = "Impuesto_______";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnCancelOrden)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmOrdenesCompraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 711);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.grDetalle);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmOrdenesCompraMain";
            this.Text = "Ordenes de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TsExoOIsv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoordenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdCapitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExoneracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposPartidaArancelaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaarancelariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdIndicadorIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposGrdBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonDeleteRow;
        private DevExpress.XtraEditors.ButtonEdit txtCodProv;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.SimpleButton cmdAddDetalle;
        private System.Windows.Forms.DateTimePicker dtFechaContabilizacion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtFechaRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtEstado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtDocNum;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevo;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraEditors.SimpleButton cmdSiguiente;
        private DevExpress.XtraEditors.SimpleButton cmdAnterior;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtUsuarioCreador;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnShowPopu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private dsCompras dsCompras1;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtImpuesto;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit txtComentarios;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barbtnCancelOrden;
        private DevExpress.XtraEditors.LabelControl lblSucursal;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private DevExpress.XtraEditors.ToggleSwitch TsExoOIsv;
        private System.Windows.Forms.TextBox txtContactoPerson;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GridLookUpEdit grdTipoOrden;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tipoordenBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraGrid.Columns.GridColumn colid_d_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colcapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colpartida_arancelaria;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio_por_unidad;
        private DevExpress.XtraGrid.Columns.GridColumn colindicador_impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia_base;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtTasaCambio;
        private DevExpress.XtraEditors.TextEdit txtMoneda;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.TextBox txtExoneracion;
        private DevExpress.XtraEditors.LabelControl lblExoneracion;
        private Finanzas.dsExoneracion dsExoneracion1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposGrdCapitulo;
        private System.Windows.Forms.BindingSource capitulosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposPartidaArancelaria;
        private System.Windows.Forms.BindingSource partidaarancelariaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposGrdIndicadorIVA;
        private System.Windows.Forms.BindingSource ivaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposGrdBodega;
        private System.Windows.Forms.BindingSource bodegasBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colWhsCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWhsName;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colU_AQUA_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_2;
    }
}