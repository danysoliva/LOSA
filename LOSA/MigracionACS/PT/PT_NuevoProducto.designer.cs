namespace LOSA.MigracionACS.PT
{
    partial class PT_NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PT_NuevoProducto));
            this.grp_Info = new DevExpress.XtraEditors.GroupControl();
            this.grp_detalleGastos = new DevExpress.XtraEditors.GroupControl();
            this.btn_removeGasto = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddGasto = new DevExpress.XtraEditors.SimpleButton();
            this.grd_gastos = new DevExpress.XtraGrid.GridControl();
            this.grdv_gastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Especies = new DevExpress.XtraEditors.LookUpEdit();
            this.grp_detalleProd = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PesoSaco = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TamPellet = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grasa = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Proteina = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Descripcion = new DevExpress.XtraEditors.TextEdit();
            this.txt_serie = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Codigo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GuardarCambios = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Info)).BeginInit();
            this.grp_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_detalleGastos)).BeginInit();
            this.grp_detalleGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Especies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_detalleProd)).BeginInit();
            this.grp_detalleProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PesoSaco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TamPellet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Proteina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Info
            // 
            this.grp_Info.Controls.Add(this.grp_detalleGastos);
            this.grp_Info.Controls.Add(this.labelControl4);
            this.grp_Info.Controls.Add(this.cmb_Especies);
            this.grp_Info.Controls.Add(this.grp_detalleProd);
            this.grp_Info.Controls.Add(this.labelControl3);
            this.grp_Info.Controls.Add(this.txt_Descripcion);
            this.grp_Info.Controls.Add(this.txt_serie);
            this.grp_Info.Controls.Add(this.labelControl2);
            this.grp_Info.Controls.Add(this.labelControl1);
            this.grp_Info.Controls.Add(this.txt_Codigo);
            this.grp_Info.Location = new System.Drawing.Point(10, 42);
            this.grp_Info.Name = "grp_Info";
            this.grp_Info.Size = new System.Drawing.Size(507, 500);
            this.grp_Info.TabIndex = 0;
            this.grp_Info.Text = "Información del Producto";
            // 
            // grp_detalleGastos
            // 
            this.grp_detalleGastos.Controls.Add(this.btn_removeGasto);
            this.grp_detalleGastos.Controls.Add(this.btn_AddGasto);
            this.grp_detalleGastos.Controls.Add(this.grd_gastos);
            this.grp_detalleGastos.Location = new System.Drawing.Point(5, 194);
            this.grp_detalleGastos.Name = "grp_detalleGastos";
            this.grp_detalleGastos.Size = new System.Drawing.Size(497, 301);
            this.grp_detalleGastos.TabIndex = 9;
            this.grp_detalleGastos.Text = "Detalle de Gastos Relacionados ";
            // 
            // btn_removeGasto
            // 
            this.btn_removeGasto.Image = global::LOSA.Properties.Resources.remove_16x16;
            this.btn_removeGasto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_removeGasto.Location = new System.Drawing.Point(442, 22);
            this.btn_removeGasto.Name = "btn_removeGasto";
            this.btn_removeGasto.Size = new System.Drawing.Size(22, 21);
            this.btn_removeGasto.TabIndex = 9;
            this.btn_removeGasto.Tag = "Agregar Gasto";
            this.btn_removeGasto.Click += new System.EventHandler(this.btn_removeGasto_Click);
            // 
            // btn_AddGasto
            // 
            this.btn_AddGasto.Image = global::LOSA.Properties.Resources.add_16x16;
            this.btn_AddGasto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_AddGasto.Location = new System.Drawing.Point(469, 22);
            this.btn_AddGasto.Name = "btn_AddGasto";
            this.btn_AddGasto.Size = new System.Drawing.Size(22, 21);
            this.btn_AddGasto.TabIndex = 8;
            this.btn_AddGasto.Tag = "Agregar Gasto";
            this.btn_AddGasto.Click += new System.EventHandler(this.btn_AddGasto_Click);
            // 
            // grd_gastos
            // 
            this.grd_gastos.Location = new System.Drawing.Point(2, 45);
            this.grd_gastos.MainView = this.grdv_gastos;
            this.grd_gastos.Name = "grd_gastos";
            this.grd_gastos.Size = new System.Drawing.Size(493, 254);
            this.grd_gastos.TabIndex = 0;
            this.grd_gastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_gastos});
            // 
            // grdv_gastos
            // 
            this.grdv_gastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_Gasto,
            this.col_Costo,
            this.col_Grupo});
            this.grdv_gastos.GridControl = this.grd_gastos;
            this.grdv_gastos.GroupCount = 1;
            this.grdv_gastos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo", this.col_Costo, "")});
            this.grdv_gastos.Name = "grdv_gastos";
            this.grdv_gastos.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_gastos.OptionsBehavior.Editable = false;
            this.grdv_gastos.OptionsView.ShowGroupPanel = false;
            this.grdv_gastos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_Grupo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_gastos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_gastos_FocusedRowChanged);
            // 
            // col_id
            // 
            this.col_id.Caption = "id";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_Gasto
            // 
            this.col_Gasto.Caption = "Costo";
            this.col_Gasto.FieldName = "Gasto";
            this.col_Gasto.FieldNameSortGroup = "Grupo";
            this.col_Gasto.Name = "col_Gasto";
            this.col_Gasto.Visible = true;
            this.col_Gasto.VisibleIndex = 0;
            this.col_Gasto.Width = 302;
            // 
            // col_Costo
            // 
            this.col_Costo.Caption = "Valor Costo";
            this.col_Costo.DisplayFormat.FormatString = "$ #,###,###.0000";
            this.col_Costo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_Costo.FieldName = "costo";
            this.col_Costo.Name = "col_Costo";
            this.col_Costo.Visible = true;
            this.col_Costo.VisibleIndex = 1;
            this.col_Costo.Width = 173;
            // 
            // col_Grupo
            // 
            this.col_Grupo.Caption = "Grupo Costo";
            this.col_Grupo.FieldName = "Grupo";
            this.col_Grupo.Name = "col_Grupo";
            this.col_Grupo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo", "$ #,###,###,###.0000")});
            this.col_Grupo.Visible = true;
            this.col_Grupo.VisibleIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(311, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Especie:";
            // 
            // cmb_Especies
            // 
            this.cmb_Especies.Location = new System.Drawing.Point(357, 29);
            this.cmb_Especies.Name = "cmb_Especies";
            this.cmb_Especies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Especies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Especie")});
            this.cmb_Especies.Properties.DisplayMember = "Descripcion";
            this.cmb_Especies.Properties.ValueMember = "id";
            this.cmb_Especies.Size = new System.Drawing.Size(145, 20);
            this.cmb_Especies.TabIndex = 2;
            // 
            // grp_detalleProd
            // 
            this.grp_detalleProd.Controls.Add(this.labelControl11);
            this.grp_detalleProd.Controls.Add(this.txt_PesoSaco);
            this.grp_detalleProd.Controls.Add(this.labelControl12);
            this.grp_detalleProd.Controls.Add(this.labelControl9);
            this.grp_detalleProd.Controls.Add(this.txt_TamPellet);
            this.grp_detalleProd.Controls.Add(this.labelControl10);
            this.grp_detalleProd.Controls.Add(this.labelControl8);
            this.grp_detalleProd.Controls.Add(this.labelControl7);
            this.grp_detalleProd.Controls.Add(this.txt_Grasa);
            this.grp_detalleProd.Controls.Add(this.labelControl6);
            this.grp_detalleProd.Controls.Add(this.txt_Proteina);
            this.grp_detalleProd.Controls.Add(this.labelControl5);
            this.grp_detalleProd.Location = new System.Drawing.Point(5, 83);
            this.grp_detalleProd.Name = "grp_detalleProd";
            this.grp_detalleProd.Size = new System.Drawing.Size(497, 105);
            this.grp_detalleProd.TabIndex = 6;
            this.grp_detalleProd.Text = "Detalles Producto";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(136, 68);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(11, 13);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "kg";
            // 
            // txt_PesoSaco
            // 
            this.txt_PesoSaco.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_PesoSaco.Location = new System.Drawing.Point(65, 65);
            this.txt_PesoSaco.Name = "txt_PesoSaco";
            this.txt_PesoSaco.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_PesoSaco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_PesoSaco.Properties.NullValuePrompt = "Campo Requerido";
            this.txt_PesoSaco.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_PesoSaco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PesoSaco.Size = new System.Drawing.Size(70, 20);
            this.txt_PesoSaco.TabIndex = 7;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(6, 68);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(53, 13);
            this.labelControl12.TabIndex = 19;
            this.labelControl12.Text = "Peso Saco:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(470, 37);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(16, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "mm";
            // 
            // txt_TamPellet
            // 
            this.txt_TamPellet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_TamPellet.Location = new System.Drawing.Point(390, 34);
            this.txt_TamPellet.Name = "txt_TamPellet";
            this.txt_TamPellet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TamPellet.Properties.NullValuePrompt = "Campo Requerido";
            this.txt_TamPellet.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_TamPellet.Size = new System.Drawing.Size(79, 20);
            this.txt_TamPellet.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(313, 37);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Tamaño Pellet:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(284, 37);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(11, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "%";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(136, 37);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(11, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "%";
            // 
            // txt_Grasa
            // 
            this.txt_Grasa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Grasa.Location = new System.Drawing.Point(204, 34);
            this.txt_Grasa.Name = "txt_Grasa";
            this.txt_Grasa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Grasa.Properties.NullValuePrompt = "Campo Requerido";
            this.txt_Grasa.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_Grasa.Size = new System.Drawing.Size(79, 20);
            this.txt_Grasa.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(166, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Grasa:";
            // 
            // txt_Proteina
            // 
            this.txt_Proteina.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Proteina.Location = new System.Drawing.Point(65, 34);
            this.txt_Proteina.Name = "txt_Proteina";
            this.txt_Proteina.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_Proteina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Proteina.Properties.NullValuePrompt = "Campo Requerido";
            this.txt_Proteina.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_Proteina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Proteina.Size = new System.Drawing.Size(70, 20);
            this.txt_Proteina.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 37);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Proteína:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Descripción:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(69, 55);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Properties.MaxLength = 50;
            this.txt_Descripcion.Size = new System.Drawing.Size(433, 20);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // txt_serie
            // 
            this.txt_serie.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_serie.Location = new System.Drawing.Point(239, 29);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_serie.Properties.NullValuePrompt = "Campo Requerido";
            this.txt_serie.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_serie.Size = new System.Drawing.Size(56, 20);
            this.txt_serie.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(209, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Serie:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(70, 29);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Codigo.Properties.MaxLength = 15;
            this.txt_Codigo.Size = new System.Drawing.Size(123, 20);
            this.txt_Codigo.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Guardar,
            this.btn_GuardarCambios,
            this.btn_Cancelar});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Guardar, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_GuardarCambios),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Cancelar)});
            this.bar1.Offset = 486;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.Text = "Tools";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Caption = "Guardar";
            this.btn_Guardar.Glyph = global::LOSA.Properties.Resources.save_32x32;
            this.btn_Guardar.Id = 0;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_Guardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Guardar_ItemClick);
            // 
            // btn_GuardarCambios
            // 
            this.btn_GuardarCambios.Caption = "Guardar Cambios";
            this.btn_GuardarCambios.Glyph = global::LOSA.Properties.Resources.saveChanges_32x32;
            this.btn_GuardarCambios.Id = 1;
            this.btn_GuardarCambios.Name = "btn_GuardarCambios";
            this.btn_GuardarCambios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_GuardarCambios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GuardarCambios_ItemClick);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Caption = "Cancelar";
            this.btn_Cancelar.Glyph = global::LOSA.Properties.Resources.cancel_32x32;
            this.btn_Cancelar.Id = 2;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancelar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(527, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Size = new System.Drawing.Size(527, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 504);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(527, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 504);
            // 
            // PT_NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 551);
            this.Controls.Add(this.grp_Info);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PT_NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PT_NuevoProducto_FormClosing);
            this.Load += new System.EventHandler(this.PT_NuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Info)).EndInit();
            this.grp_Info.ResumeLayout(false);
            this.grp_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_detalleGastos)).EndInit();
            this.grp_detalleGastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Especies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_detalleProd)).EndInit();
            this.grp_detalleProd.ResumeLayout(false);
            this.grp_detalleProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PesoSaco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TamPellet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Proteina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grp_Info;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmb_Especies;
        private DevExpress.XtraEditors.GroupControl grp_detalleProd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Descripcion;
        private DevExpress.XtraEditors.SpinEdit txt_serie;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Codigo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit txt_TamPellet;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit txt_Grasa;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit txt_Proteina;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SpinEdit txt_PesoSaco;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.GroupControl grp_detalleGastos;
        private DevExpress.XtraGrid.GridControl grd_gastos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_gastos;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Guardar;
        private DevExpress.XtraBars.BarButtonItem btn_GuardarCambios;
        private DevExpress.XtraBars.BarButtonItem btn_Cancelar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btn_AddGasto;
        private DevExpress.XtraEditors.SimpleButton btn_removeGasto;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_Gasto;
        private DevExpress.XtraGrid.Columns.GridColumn col_Costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Grupo;
    }
}