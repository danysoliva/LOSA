namespace LOSA.TransaccionesPT
{
    partial class frmGestiondePlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiondePlan));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSacos = new DevExpress.XtraEditors.TextEdit();
            this.txttarimas = new DevExpress.XtraEditors.TextEdit();
            this.grdproducto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdpresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCardCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechaprod = new DevExpress.XtraEditors.DateEdit();
            this.devencimiento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtpesoxtarima = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtlot_number = new DevExpress.XtraEditors.TextEdit();
            this.txtLote = new DevExpress.XtraEditors.SimpleButton();
            this.btnCrear = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.grd_turno = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPT = new LOSA.TransaccionesPT.dsPT();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtSacos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarimas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaprod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaprod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpesoxtarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlot_number.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_turno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl1.Location = new System.Drawing.Point(159, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(309, 32);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Plan de Ingreso de Producto";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Producto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(39, 202);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Presentacion:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(80, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Cliente:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 287);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(123, 21);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Sacos por Tarima:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(330, 287);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 21);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "C. de tarimas: ";
            // 
            // txtSacos
            // 
            this.txtSacos.EditValue = "1";
            this.txtSacos.Location = new System.Drawing.Point(175, 282);
            this.txtSacos.Name = "txtSacos";
            this.txtSacos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSacos.Properties.Appearance.Options.UseFont = true;
            this.txtSacos.Properties.Mask.EditMask = "n";
            this.txtSacos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSacos.Size = new System.Drawing.Size(129, 28);
            this.txtSacos.TabIndex = 6;
            this.txtSacos.EditValueChanged += new System.EventHandler(this.txtSacos_EditValueChanged);
            // 
            // txttarimas
            // 
            this.txttarimas.EditValue = "1";
            this.txttarimas.Location = new System.Drawing.Point(433, 282);
            this.txttarimas.Name = "txttarimas";
            this.txttarimas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarimas.Properties.Appearance.Options.UseFont = true;
            this.txttarimas.Properties.Mask.EditMask = "n";
            this.txttarimas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttarimas.Size = new System.Drawing.Size(129, 28);
            this.txttarimas.TabIndex = 7;
            // 
            // grdproducto
            // 
            this.grdproducto.EditValue = "";
            this.grdproducto.Location = new System.Drawing.Point(152, 108);
            this.grdproducto.Name = "grdproducto";
            this.grdproducto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdproducto.Properties.Appearance.Options.UseFont = true;
            this.grdproducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdproducto.Properties.DataSource = this.productosBindingSource;
            this.grdproducto.Properties.DisplayMember = "itemname";
            this.grdproducto.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdproducto.Properties.ValueMember = "itemcode";
            this.grdproducto.Size = new System.Drawing.Size(421, 28);
            this.grdproducto.TabIndex = 8;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemcode,
            this.colitemname});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Articulo";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            // 
            // colitemname
            // 
            this.colitemname.Caption = "Producto Terminado";
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 0;
            // 
            // grdpresentacion
            // 
            this.grdpresentacion.EditValue = "";
            this.grdpresentacion.Location = new System.Drawing.Point(152, 199);
            this.grdpresentacion.Name = "grdpresentacion";
            this.grdpresentacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdpresentacion.Properties.Appearance.Options.UseFont = true;
            this.grdpresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdpresentacion.Properties.DataSource = this.presentacionBindingSource;
            this.grdpresentacion.Properties.DisplayMember = "descripcion";
            this.grdpresentacion.Properties.PopupView = this.gridView1;
            this.grdpresentacion.Properties.ValueMember = "id";
            this.grdpresentacion.Size = new System.Drawing.Size(421, 28);
            this.grdpresentacion.TabIndex = 9;
            this.grdpresentacion.EditValueChanged += new System.EventHandler(this.grdpresentacion_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colfactor});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Presentacion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            // 
            // grdcliente
            // 
            this.grdcliente.EditValue = "";
            this.grdcliente.Location = new System.Drawing.Point(152, 152);
            this.grdcliente.Name = "grdcliente";
            this.grdcliente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcliente.Properties.Appearance.Options.UseFont = true;
            this.grdcliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdcliente.Properties.DataSource = this.clienteBindingSource;
            this.grdcliente.Properties.DisplayMember = "CardName";
            this.grdcliente.Properties.PopupView = this.gridView2;
            this.grdcliente.Properties.ValueMember = "CardCode";
            this.grdcliente.Size = new System.Drawing.Size(421, 28);
            this.grdcliente.TabIndex = 10;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCardCode,
            this.colCardName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCardCode
            // 
            this.colCardCode.FieldName = "CardCode";
            this.colCardCode.Name = "colCardCode";
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Cliente";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(26, 413);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(146, 21);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Fecha de Produccion:";
            // 
            // dtfechaprod
            // 
            this.dtfechaprod.EditValue = null;
            this.dtfechaprod.Location = new System.Drawing.Point(189, 406);
            this.dtfechaprod.Name = "dtfechaprod";
            this.dtfechaprod.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechaprod.Properties.Appearance.Options.UseFont = true;
            this.dtfechaprod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechaprod.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechaprod.Size = new System.Drawing.Size(179, 28);
            this.dtfechaprod.TabIndex = 14;
            // 
            // devencimiento
            // 
            this.devencimiento.EditValue = null;
            this.devencimiento.Location = new System.Drawing.Point(189, 456);
            this.devencimiento.Name = "devencimiento";
            this.devencimiento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devencimiento.Properties.Appearance.Options.UseFont = true;
            this.devencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devencimiento.Size = new System.Drawing.Size(179, 28);
            this.devencimiento.TabIndex = 16;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(26, 459);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(155, 21);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Fecha de Vencimiento:";
            // 
            // txtpesoxtarima
            // 
            this.txtpesoxtarima.EditValue = "1";
            this.txtpesoxtarima.Enabled = false;
            this.txtpesoxtarima.Location = new System.Drawing.Point(175, 326);
            this.txtpesoxtarima.Name = "txtpesoxtarima";
            this.txtpesoxtarima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesoxtarima.Properties.Appearance.Options.UseFont = true;
            this.txtpesoxtarima.Properties.Mask.EditMask = "n";
            this.txtpesoxtarima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtpesoxtarima.Size = new System.Drawing.Size(129, 28);
            this.txtpesoxtarima.TabIndex = 20;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(56, 329);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(113, 21);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Peso por tarima:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(31, 244);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(100, 21);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Lote Producto:";
            // 
            // txtlot_number
            // 
            this.txtlot_number.EditValue = "";
            this.txtlot_number.Enabled = false;
            this.txtlot_number.Location = new System.Drawing.Point(152, 237);
            this.txtlot_number.Name = "txtlot_number";
            this.txtlot_number.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlot_number.Properties.Appearance.Options.UseFont = true;
            this.txtlot_number.Properties.Mask.EditMask = "n";
            this.txtlot_number.Size = new System.Drawing.Size(333, 28);
            this.txtlot_number.TabIndex = 22;
            // 
            // txtLote
            // 
            this.txtLote.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Appearance.Options.UseFont = true;
            this.txtLote.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtLote.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.txtLote.Location = new System.Drawing.Point(492, 233);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(42, 40);
            this.txtLote.TabIndex = 60;
            this.txtLote.Click += new System.EventHandler(this.txtLote_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrear.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCrear.Appearance.Options.UseBackColor = true;
            this.btnCrear.Appearance.Options.UseFont = true;
            this.btnCrear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.ImageOptions.Image")));
            this.btnCrear.Location = new System.Drawing.Point(6, 5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(139, 54);
            this.btnCrear.TabIndex = 18;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSalir.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BtnSalir.Appearance.Options.UseBackColor = true;
            this.BtnSalir.Appearance.Options.UseFont = true;
            this.BtnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.ImageOptions.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(492, 6);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(139, 53);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "Regresar";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // grd_turno
            // 
            this.grd_turno.EditValue = "";
            this.grd_turno.Location = new System.Drawing.Point(152, 364);
            this.grd_turno.Name = "grd_turno";
            this.grd_turno.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_turno.Properties.Appearance.Options.UseFont = true;
            this.grd_turno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grd_turno.Properties.DataSource = this.turnoBindingSource;
            this.grd_turno.Properties.DisplayMember = "turno";
            this.grd_turno.Properties.PopupView = this.gridView3;
            this.grd_turno.Properties.ValueMember = "id";
            this.grd_turno.Size = new System.Drawing.Size(421, 28);
            this.grd_turno.TabIndex = 62;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colturno});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(87, 367);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 21);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Turno:";
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "turno";
            this.turnoBindingSource.DataSource = this.dsPT;
            // 
            // dsPT
            // 
            this.dsPT.DataSetName = "dsPT";
            this.dsPT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.dsPT;
            // 
            // presentacionBindingSource
            // 
            this.presentacionBindingSource.DataMember = "presentacion";
            this.presentacionBindingSource.DataSource = this.dsPT;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.dsPT;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colturno
            // 
            this.colturno.Caption = "Turno";
            this.colturno.FieldName = "turno";
            this.colturno.Name = "colturno";
            this.colturno.Visible = true;
            this.colturno.VisibleIndex = 0;
            // 
            // frmGestiondePlan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.grd_turno);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtlot_number);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtpesoxtarima);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.devencimiento);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtfechaprod);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.grdcliente);
            this.Controls.Add(this.grdpresentacion);
            this.Controls.Add(this.grdproducto);
            this.Controls.Add(this.txttarimas);
            this.Controls.Add(this.txtSacos);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestiondePlan";
            this.Text = "frmGestiondePlan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestiondePlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSacos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttarimas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdpresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaprod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechaprod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpesoxtarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlot_number.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_turno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSacos;
        private DevExpress.XtraEditors.TextEdit txttarimas;
        private DevExpress.XtraEditors.GridLookUpEdit grdproducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit grdpresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit grdcliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtfechaprod;
        private DevExpress.XtraEditors.DateEdit devencimiento;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton btnCrear;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private dsPT dsPT;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemname;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource presentacionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
        private DevExpress.XtraGrid.Columns.GridColumn colCardCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraEditors.TextEdit txtpesoxtarima;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtlot_number;
        private DevExpress.XtraEditors.SimpleButton txtLote;
        private DevExpress.XtraEditors.GridLookUpEdit grd_turno;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colturno;
    }
}