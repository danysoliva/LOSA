namespace LOSA.MigracionACS.Produccion
{
    partial class PP_Nuevo_Orden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Nuevo_Orden));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ProductionLine = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btn_cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_accept = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dt_produccion = new DevExpress.XtraEditors.DateEdit();
            this.txt_PTCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FormulaCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_OPNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sacos = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Paradas = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_prioridad = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KgProduccion = new DevExpress.XtraEditors.SpinEdit();
            this.btn_SearchFormula = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FormulaName = new DevExpress.XtraEditors.TextEdit();
            this.btn_searchPT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PTName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProductionLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PTCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FormulaCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_OPNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sacos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Paradas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prioridad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KgProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FormulaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PTName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.cmb_ProductionLine);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dt_produccion);
            this.groupControl1.Controls.Add(this.txt_PTCodigo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_FormulaCode);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_OPNumero);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(380, 134);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos Generales";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 81);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(80, 13);
            this.labelControl12.TabIndex = 9;
            this.labelControl12.Text = "Linea Producción";
            // 
            // cmb_ProductionLine
            // 
            this.cmb_ProductionLine.Location = new System.Drawing.Point(12, 100);
            this.cmb_ProductionLine.MenuManager = this.barManager1;
            this.cmb_ProductionLine.Name = "cmb_ProductionLine";
            this.cmb_ProductionLine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ProductionLine.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Linea Producción")});
            this.cmb_ProductionLine.Properties.DisplayMember = "name";
            this.cmb_ProductionLine.Properties.NullText = "[Seleccionar Linea]";
            this.cmb_ProductionLine.Properties.NullValuePrompt = "Indica la Linea";
            this.cmb_ProductionLine.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmb_ProductionLine.Properties.ValueMember = "id";
            this.cmb_ProductionLine.Size = new System.Drawing.Size(163, 20);
            this.cmb_ProductionLine.TabIndex = 8;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_cancel,
            this.btn_accept});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_accept)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Caption = "Cancelar";
            this.btn_cancel.Glyph = global::LOSA.Properties.Resources.cancel_32x32;
            this.btn_cancel.Id = 0;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_cancel_ItemClick);
            // 
            // btn_accept
            // 
            this.btn_accept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_accept.Caption = "Aceptar";
            this.btn_accept.Glyph = global::LOSA.Properties.Resources.Accept_32x32;
            this.btn_accept.Id = 1;
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_accept_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(380, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 323);
            this.barDockControlBottom.Size = new System.Drawing.Size(380, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 323);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(380, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 323);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(205, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(136, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Fecha Propuesta Producción";
            // 
            // dt_produccion
            // 
            this.dt_produccion.EditValue = null;
            this.dt_produccion.Location = new System.Drawing.Point(205, 100);
            this.dt_produccion.Name = "dt_produccion";
            this.dt_produccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_produccion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_produccion.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dt_produccion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_produccion.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dt_produccion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_produccion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_produccion.Size = new System.Drawing.Size(163, 20);
            this.dt_produccion.TabIndex = 0;
            // 
            // txt_PTCodigo
            // 
            this.txt_PTCodigo.Enabled = false;
            this.txt_PTCodigo.Location = new System.Drawing.Point(205, 47);
            this.txt_PTCodigo.Name = "txt_PTCodigo";
            this.txt_PTCodigo.Size = new System.Drawing.Size(163, 20);
            this.txt_PTCodigo.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(205, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Código Producto Terminado";
            // 
            // txt_FormulaCode
            // 
            this.txt_FormulaCode.Enabled = false;
            this.txt_FormulaCode.Location = new System.Drawing.Point(451, 47);
            this.txt_FormulaCode.Name = "txt_FormulaCode";
            this.txt_FormulaCode.Size = new System.Drawing.Size(163, 20);
            this.txt_FormulaCode.TabIndex = 3;
            this.txt_FormulaCode.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(451, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Código Formula WinCC";
            this.labelControl2.Visible = false;
            // 
            // txt_OPNumero
            // 
            this.txt_OPNumero.Enabled = false;
            this.txt_OPNumero.Location = new System.Drawing.Point(12, 47);
            this.txt_OPNumero.Name = "txt_OPNumero";
            this.txt_OPNumero.Size = new System.Drawing.Size(163, 20);
            this.txt_OPNumero.TabIndex = 1;
            this.txt_OPNumero.EditValueChanged += new System.EventHandler(this.txt_OPNumero_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Orden de Producción #";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txt_Sacos);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.txt_Paradas);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txt_prioridad);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txt_KgProduccion);
            this.groupControl2.Controls.Add(this.btn_SearchFormula);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txt_FormulaName);
            this.groupControl2.Controls.Add(this.btn_searchPT);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txt_PTName);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(380, 189);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Detalles";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(136, 132);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Sacos";
            // 
            // txt_Sacos
            // 
            this.txt_Sacos.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Sacos.Enabled = false;
            this.txt_Sacos.Location = new System.Drawing.Point(136, 151);
            this.txt_Sacos.Name = "txt_Sacos";
            this.txt_Sacos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Sacos.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Sacos.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Sacos.Size = new System.Drawing.Size(71, 20);
            this.txt_Sacos.TabIndex = 16;
            this.txt_Sacos.ToolTip = "Cantidad en Kg a producir de este producto.";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(213, 132);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Paradas";
            // 
            // txt_Paradas
            // 
            this.txt_Paradas.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Paradas.Location = new System.Drawing.Point(213, 151);
            this.txt_Paradas.Name = "txt_Paradas";
            this.txt_Paradas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Paradas.Properties.IsFloatValue = false;
            this.txt_Paradas.Properties.Mask.EditMask = "N00";
            this.txt_Paradas.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Paradas.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Paradas.Size = new System.Drawing.Size(75, 20);
            this.txt_Paradas.TabIndex = 4;
            this.txt_Paradas.ToolTip = "Prioridad de Producción, esta puede ser de 1 a 20 siento 1 la mas importante.";
            this.txt_Paradas.EditValueChanged += new System.EventHandler(this.txt_Paradas_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(294, 132);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 13;
            this.labelControl11.Text = "Prioridad";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(294, 132);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Prioridad";
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_prioridad.Location = new System.Drawing.Point(294, 151);
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_prioridad.Properties.IsFloatValue = false;
            this.txt_prioridad.Properties.Mask.EditMask = "N00";
            this.txt_prioridad.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_prioridad.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_prioridad.Size = new System.Drawing.Size(59, 20);
            this.txt_prioridad.TabIndex = 5;
            this.txt_prioridad.ToolTip = "Prioridad de Producción, esta puede ser de 1 a 20 siento 1 la mas importante.";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Kg a Producir";
            // 
            // txt_KgProduccion
            // 
            this.txt_KgProduccion.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_KgProduccion.Enabled = false;
            this.txt_KgProduccion.Location = new System.Drawing.Point(12, 151);
            this.txt_KgProduccion.Name = "txt_KgProduccion";
            this.txt_KgProduccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_KgProduccion.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_KgProduccion.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_KgProduccion.Size = new System.Drawing.Size(118, 20);
            this.txt_KgProduccion.TabIndex = 3;
            this.txt_KgProduccion.ToolTip = "Cantidad en Kg a producir de este producto.";
            // 
            // btn_SearchFormula
            // 
            this.btn_SearchFormula.Image = global::LOSA.Properties.Resources.search_16x16;
            this.btn_SearchFormula.Location = new System.Drawing.Point(329, 46);
            this.btn_SearchFormula.Name = "btn_SearchFormula";
            this.btn_SearchFormula.Size = new System.Drawing.Size(24, 23);
            this.btn_SearchFormula.TabIndex = 1;
            this.btn_SearchFormula.Click += new System.EventHandler(this.btn_SearchFormula_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 29);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Formula";
            // 
            // txt_FormulaName
            // 
            this.txt_FormulaName.Enabled = false;
            this.txt_FormulaName.Location = new System.Drawing.Point(12, 48);
            this.txt_FormulaName.Name = "txt_FormulaName";
            this.txt_FormulaName.Size = new System.Drawing.Size(311, 20);
            this.txt_FormulaName.TabIndex = 7;
            // 
            // btn_searchPT
            // 
            this.btn_searchPT.Enabled = false;
            this.btn_searchPT.Image = global::LOSA.Properties.Resources.search_16x16;
            this.btn_searchPT.Location = new System.Drawing.Point(329, 91);
            this.btn_searchPT.Name = "btn_searchPT";
            this.btn_searchPT.Size = new System.Drawing.Size(24, 23);
            this.btn_searchPT.TabIndex = 2;
            this.btn_searchPT.Click += new System.EventHandler(this.btn_searchPT_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 74);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Producto Terminado";
            // 
            // txt_PTName
            // 
            this.txt_PTName.Enabled = false;
            this.txt_PTName.Location = new System.Drawing.Point(12, 93);
            this.txt_PTName.Name = "txt_PTName";
            this.txt_PTName.Size = new System.Drawing.Size(311, 20);
            this.txt_PTName.TabIndex = 0;
            // 
            // PP_Nuevo_Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 366);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PP_Nuevo_Orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Producción - Nuevo";
            this.Load += new System.EventHandler(this.PP_Nuevo_Orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProductionLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_produccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PTCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FormulaCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_OPNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sacos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Paradas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prioridad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KgProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FormulaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PTName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_PTCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_FormulaCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_OPNumero;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dt_produccion;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit txt_prioridad;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit txt_KgProduccion;
        private DevExpress.XtraEditors.SimpleButton btn_SearchFormula;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_FormulaName;
        private DevExpress.XtraEditors.SimpleButton btn_searchPT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_PTName;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btn_cancel;
        private DevExpress.XtraBars.BarButtonItem btn_accept;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit txt_Paradas;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SpinEdit txt_Sacos;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit cmb_ProductionLine;
    }
}