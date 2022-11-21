namespace LOSA.MigracionACS.Formulas
{
    partial class FML_NewFormula_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FML_NewFormula_v2));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grp_datosFormula = new DevExpress.XtraEditors.GroupControl();
            this.cmb_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Codigo = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_versionFormula = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_comment = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_especie = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grp_MP = new DevExpress.XtraEditors.GroupControl();
            this.grd_mp = new DevExpress.XtraGrid.GridControl();
            this.grdv_mp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmp_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_material = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_inclusion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp_actual_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp_precio_primo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_agregarMP = new DevExpress.XtraEditors.GroupControl();
            this.cmb_mp = new DevExpress.XtraEditors.LookUpEdit();
            this.cmb_MPoNC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_pesomp = new DevExpress.XtraEditors.SpinEdit();
            this.lbl_peso = new DevExpress.XtraEditors.LabelControl();
            this.btn_addMP = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RemoveMP = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_datosFormula)).BeginInit();
            this.grp_datosFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_versionFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_comment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_especie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_MP)).BeginInit();
            this.grp_MP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_agregarMP)).BeginInit();
            this.grp_agregarMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MPoNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pesomp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_cancel,
            this.btn_save});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_save),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_cancel)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_save
            // 
            this.btn_save.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_save.Caption = "Guardar Cambios";
            this.btn_save.Id = 1;
            this.btn_save.ImageOptions.Image = global::LOSA.Properties.Resources.save_32x32;
            this.btn_save.Name = "btn_save";
            this.btn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_save_ItemClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_cancel.Caption = "Cancelar";
            this.btn_cancel.Id = 0;
            this.btn_cancel.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_32x32;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(855, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(855, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(855, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // grp_datosFormula
            // 
            this.grp_datosFormula.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_datosFormula.AppearanceCaption.Options.UseFont = true;
            this.grp_datosFormula.Controls.Add(this.cmb_type);
            this.grp_datosFormula.Controls.Add(this.labelControl6);
            this.grp_datosFormula.Controls.Add(this.txt_Codigo);
            this.grp_datosFormula.Controls.Add(this.labelControl5);
            this.grp_datosFormula.Controls.Add(this.txt_versionFormula);
            this.grp_datosFormula.Controls.Add(this.labelControl4);
            this.grp_datosFormula.Controls.Add(this.txt_comment);
            this.grp_datosFormula.Controls.Add(this.labelControl3);
            this.grp_datosFormula.Controls.Add(this.cmb_especie);
            this.grp_datosFormula.Controls.Add(this.labelControl2);
            this.grp_datosFormula.Controls.Add(this.txt_descripcion);
            this.grp_datosFormula.Controls.Add(this.labelControl1);
            this.grp_datosFormula.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_datosFormula.Location = new System.Drawing.Point(0, 40);
            this.grp_datosFormula.Name = "grp_datosFormula";
            this.grp_datosFormula.Size = new System.Drawing.Size(855, 117);
            this.grp_datosFormula.TabIndex = 4;
            this.grp_datosFormula.Text = "Datos de Formula";
            // 
            // cmb_type
            // 
            this.cmb_type.EditValue = " FB - Formula Base.";
            this.cmb_type.Location = new System.Drawing.Point(665, 53);
            this.cmb_type.MenuManager = this.barManager1;
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_type.Properties.Items.AddRange(new object[] {
            " FB - Formula Base.",
            "NC - Nucleo."});
            this.cmb_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_type.Size = new System.Drawing.Size(172, 20);
            this.cmb_type.TabIndex = 4;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(634, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Tipo:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Codigo.Location = new System.Drawing.Point(82, 27);
            this.txt_Codigo.MenuManager = this.barManager1;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Codigo.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txt_Codigo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Codigo.Size = new System.Drawing.Size(73, 20);
            this.txt_Codigo.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(181, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Versión:";
            // 
            // txt_versionFormula
            // 
            this.txt_versionFormula.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_versionFormula.Location = new System.Drawing.Point(226, 27);
            this.txt_versionFormula.MenuManager = this.barManager1;
            this.txt_versionFormula.Name = "txt_versionFormula";
            this.txt_versionFormula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_versionFormula.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txt_versionFormula.Size = new System.Drawing.Size(46, 20);
            this.txt_versionFormula.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Comentarios:";
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(82, 53);
            this.txt_comment.MenuManager = this.barManager1;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(502, 58);
            this.txt_comment.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(618, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Especie:";
            // 
            // cmb_especie
            // 
            this.cmb_especie.Location = new System.Drawing.Point(665, 27);
            this.cmb_especie.MenuManager = this.barManager1;
            this.cmb_especie.Name = "cmb_especie";
            this.cmb_especie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_especie.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Especie")});
            this.cmb_especie.Properties.DisplayMember = "Descripcion";
            this.cmb_especie.Properties.ValueMember = "id";
            this.cmb_especie.Size = new System.Drawing.Size(172, 20);
            this.cmb_especie.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(294, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(358, 27);
            this.txt_descripcion.MenuManager = this.barManager1;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Properties.MaxLength = 50;
            this.txt_descripcion.Size = new System.Drawing.Size(226, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Codigo:";
            // 
            // grp_MP
            // 
            this.grp_MP.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_MP.AppearanceCaption.Options.UseFont = true;
            this.grp_MP.Controls.Add(this.grd_mp);
            this.grp_MP.Controls.Add(this.grp_agregarMP);
            this.grp_MP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_MP.Location = new System.Drawing.Point(0, 157);
            this.grp_MP.Name = "grp_MP";
            this.grp_MP.Size = new System.Drawing.Size(855, 302);
            this.grp_MP.TabIndex = 7;
            this.grp_MP.Text = "Ingredientes Formula";
            // 
            // grd_mp
            // 
            this.grd_mp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_mp.Location = new System.Drawing.Point(2, 65);
            this.grd_mp.MainView = this.grdv_mp;
            this.grd_mp.MenuManager = this.barManager1;
            this.grd_mp.Name = "grd_mp";
            this.grd_mp.Size = new System.Drawing.Size(851, 235);
            this.grd_mp.TabIndex = 1;
            this.grd_mp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_mp});
            // 
            // grdv_mp
            // 
            this.grdv_mp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmp_id,
            this.col_id_item,
            this.col_codigo,
            this.col_material,
            this.col_tipo1,
            this.col_peso,
            this.col_inclusion,
            this.colmp_actual_cost,
            this.colmp_precio_primo,
            this.col_tipo2,
            this.col_tipo3});
            this.grdv_mp.GridControl = this.grd_mp;
            this.grdv_mp.GroupCount = 2;
            this.grdv_mp.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pesokg", this.col_peso, "{0:###,###,###.0000} Kg"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "parte_formula", this.col_inclusion, "{0:0.0000%}")});
            this.grdv_mp.Name = "grdv_mp";
            this.grdv_mp.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdv_mp.OptionsBehavior.Editable = false;
            this.grdv_mp.OptionsView.EnableAppearanceOddRow = true;
            this.grdv_mp.OptionsView.ShowFooter = true;
            this.grdv_mp.OptionsView.ShowGroupPanel = false;
            this.grdv_mp.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_tipo1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_tipo2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdv_mp.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdv_mp_FocusedRowChanged);
            this.grdv_mp.DoubleClick += new System.EventHandler(this.grdv_mp_DoubleClick);
            // 
            // colmp_id
            // 
            this.colmp_id.Caption = "Id";
            this.colmp_id.FieldName = "id";
            this.colmp_id.Name = "colmp_id";
            // 
            // col_id_item
            // 
            this.col_id_item.Caption = "ID Materia Prima";
            this.col_id_item.FieldName = "id_item";
            this.col_id_item.Name = "col_id_item";
            // 
            // col_codigo
            // 
            this.col_codigo.Caption = "Código";
            this.col_codigo.FieldName = "codigo";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.Visible = true;
            this.col_codigo.VisibleIndex = 0;
            this.col_codigo.Width = 62;
            // 
            // col_material
            // 
            this.col_material.Caption = "Material";
            this.col_material.FieldName = "material";
            this.col_material.Name = "col_material";
            this.col_material.Visible = true;
            this.col_material.VisibleIndex = 1;
            this.col_material.Width = 88;
            // 
            // col_tipo1
            // 
            this.col_tipo1.Caption = "Tipo";
            this.col_tipo1.FieldName = "tipo1";
            this.col_tipo1.Name = "col_tipo1";
            this.col_tipo1.Visible = true;
            this.col_tipo1.VisibleIndex = 2;
            this.col_tipo1.Width = 41;
            // 
            // col_peso
            // 
            this.col_peso.Caption = "Peso";
            this.col_peso.DisplayFormat.FormatString = "#,###,###,###.0000 Kg";
            this.col_peso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_peso.FieldName = "peso";
            this.col_peso.Name = "col_peso";
            this.col_peso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "{0:###,###,###.0000} Kg")});
            this.col_peso.Visible = true;
            this.col_peso.VisibleIndex = 2;
            this.col_peso.Width = 42;
            // 
            // col_inclusion
            // 
            this.col_inclusion.Caption = "% En Formula";
            this.col_inclusion.DisplayFormat.FormatString = "p4";
            this.col_inclusion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_inclusion.FieldName = "inclusion";
            this.col_inclusion.Name = "col_inclusion";
            this.col_inclusion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "inclusion", "{0:0.0000%}")});
            this.col_inclusion.Visible = true;
            this.col_inclusion.VisibleIndex = 3;
            this.col_inclusion.Width = 37;
            // 
            // colmp_actual_cost
            // 
            this.colmp_actual_cost.Caption = "Costo Actual";
            this.colmp_actual_cost.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.colmp_actual_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmp_actual_cost.FieldName = "actual_cost";
            this.colmp_actual_cost.Name = "colmp_actual_cost";
            this.colmp_actual_cost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "actual_cost", "$ {0:###,###,###.0000}")});
            this.colmp_actual_cost.Width = 43;
            // 
            // colmp_precio_primo
            // 
            this.colmp_precio_primo.Caption = "Precio en Formula";
            this.colmp_precio_primo.DisplayFormat.FormatString = "$ #,###,###,###.0000";
            this.colmp_precio_primo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmp_precio_primo.FieldName = "precio_primo";
            this.colmp_precio_primo.Name = "colmp_precio_primo";
            this.colmp_precio_primo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "precio_primo", "$ {0:###,###,###.0000}")});
            this.colmp_precio_primo.Width = 46;
            // 
            // col_tipo2
            // 
            this.col_tipo2.Caption = "Tipo";
            this.col_tipo2.FieldName = "tipo2";
            this.col_tipo2.Name = "col_tipo2";
            this.col_tipo2.Visible = true;
            this.col_tipo2.VisibleIndex = 3;
            // 
            // col_tipo3
            // 
            this.col_tipo3.Caption = "Tipo";
            this.col_tipo3.FieldName = "tipo3";
            this.col_tipo3.Name = "col_tipo3";
            // 
            // grp_agregarMP
            // 
            this.grp_agregarMP.Controls.Add(this.cmb_mp);
            this.grp_agregarMP.Controls.Add(this.cmb_MPoNC);
            this.grp_agregarMP.Controls.Add(this.txt_pesomp);
            this.grp_agregarMP.Controls.Add(this.lbl_peso);
            this.grp_agregarMP.Controls.Add(this.btn_addMP);
            this.grp_agregarMP.Controls.Add(this.btn_RemoveMP);
            this.grp_agregarMP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_agregarMP.Location = new System.Drawing.Point(2, 21);
            this.grp_agregarMP.Name = "grp_agregarMP";
            this.grp_agregarMP.Size = new System.Drawing.Size(851, 44);
            this.grp_agregarMP.TabIndex = 0;
            this.grp_agregarMP.Text = "Agregar Ingrediente";
            // 
            // cmb_mp
            // 
            this.cmb_mp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_mp.Location = new System.Drawing.Point(153, 20);
            this.cmb_mp.MenuManager = this.barManager1;
            this.cmb_mp.Name = "cmb_mp";
            this.cmb_mp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_mp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("material", "Material"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo2", "Tipo Short", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmb_mp.Properties.DisplayMember = "material";
            this.cmb_mp.Properties.ValueMember = "id";
            this.cmb_mp.Size = new System.Drawing.Size(469, 20);
            this.cmb_mp.TabIndex = 6;
            // 
            // cmb_MPoNC
            // 
            this.cmb_MPoNC.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmb_MPoNC.EditValue = "MP - Materias Primas";
            this.cmb_MPoNC.Location = new System.Drawing.Point(2, 20);
            this.cmb_MPoNC.MenuManager = this.barManager1;
            this.cmb_MPoNC.Name = "cmb_MPoNC";
            this.cmb_MPoNC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_MPoNC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_MPoNC.Size = new System.Drawing.Size(151, 20);
            this.cmb_MPoNC.TabIndex = 12;
            this.cmb_MPoNC.SelectedIndexChanged += new System.EventHandler(this.cmb_MPoNC_SelectedIndexChanged);
            // 
            // txt_pesomp
            // 
            this.txt_pesomp.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_pesomp.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.txt_pesomp.Location = new System.Drawing.Point(622, 20);
            this.txt_pesomp.MenuManager = this.barManager1;
            this.txt_pesomp.Name = "txt_pesomp";
            this.txt_pesomp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_pesomp.Properties.DisplayFormat.FormatString = "#,###,###.0000";
            this.txt_pesomp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txt_pesomp.Properties.MaxValue = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt_pesomp.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.txt_pesomp.Size = new System.Drawing.Size(158, 20);
            this.txt_pesomp.TabIndex = 7;
            this.txt_pesomp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pesomp_KeyDown);
            // 
            // lbl_peso
            // 
            this.lbl_peso.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Appearance.Options.UseFont = true;
            this.lbl_peso.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_peso.Location = new System.Drawing.Point(780, 20);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(21, 19);
            this.lbl_peso.TabIndex = 11;
            this.lbl_peso.Text = "Kg";
            // 
            // btn_addMP
            // 
            this.btn_addMP.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_addMP.ImageOptions.Image = global::LOSA.Properties.Resources.add_16x16;
            this.btn_addMP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_addMP.Location = new System.Drawing.Point(801, 20);
            this.btn_addMP.Name = "btn_addMP";
            this.btn_addMP.Size = new System.Drawing.Size(24, 22);
            this.btn_addMP.TabIndex = 8;
            this.btn_addMP.Tag = "Agregar Gasto";
            this.btn_addMP.Click += new System.EventHandler(this.btn_addMP_Click);
            // 
            // btn_RemoveMP
            // 
            this.btn_RemoveMP.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_RemoveMP.ImageOptions.Image = global::LOSA.Properties.Resources.remove_16x16;
            this.btn_RemoveMP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_RemoveMP.Location = new System.Drawing.Point(825, 20);
            this.btn_RemoveMP.Name = "btn_RemoveMP";
            this.btn_RemoveMP.Size = new System.Drawing.Size(24, 22);
            this.btn_RemoveMP.TabIndex = 9;
            this.btn_RemoveMP.Tag = "Agregar Gasto";
            this.btn_RemoveMP.Click += new System.EventHandler(this.btn_RemoveMP_Click);
            // 
            // FML_NewFormula_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 459);
            this.Controls.Add(this.grp_MP);
            this.Controls.Add(this.grp_datosFormula);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FML_NewFormula_v2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FML_NewFormula_v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FML_NewFormula_v2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FML_NewFormula_v2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_datosFormula)).EndInit();
            this.grp_datosFormula.ResumeLayout(false);
            this.grp_datosFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_versionFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_comment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_especie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_MP)).EndInit();
            this.grp_MP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_agregarMP)).EndInit();
            this.grp_agregarMP.ResumeLayout(false);
            this.grp_agregarMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MPoNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pesomp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grp_datosFormula;
        private DevExpress.XtraEditors.SpinEdit txt_Codigo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit txt_versionFormula;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txt_comment;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmb_especie;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_type;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl grp_MP;
        private DevExpress.XtraGrid.GridControl grd_mp;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colmp_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_id_item;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_material;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo1;
        private DevExpress.XtraGrid.Columns.GridColumn col_peso;
        private DevExpress.XtraGrid.Columns.GridColumn col_inclusion;
        private DevExpress.XtraGrid.Columns.GridColumn colmp_actual_cost;
        private DevExpress.XtraGrid.Columns.GridColumn colmp_precio_primo;
        private DevExpress.XtraEditors.GroupControl grp_agregarMP;
        private DevExpress.XtraEditors.LookUpEdit cmb_mp;
        private DevExpress.XtraEditors.SpinEdit txt_pesomp;
        private DevExpress.XtraEditors.LabelControl lbl_peso;
        private DevExpress.XtraEditors.SimpleButton btn_addMP;
        private DevExpress.XtraEditors.SimpleButton btn_RemoveMP;
        private DevExpress.XtraBars.BarButtonItem btn_cancel;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo2;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo3;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_MPoNC;
    }
}