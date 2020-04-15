namespace LOSA.RecepcionMP
{
    partial class frmTarima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarima));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdBoleta = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoMP = new DevExpress.XtraEditors.TextEdit();
            this.txtMP_Name = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedorName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoProveedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumIngreso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnidades = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaProduccion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaVencimiento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEditPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourcePresentaciones = new System.Windows.Forms.BindingSource();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtPesoKg = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadTarimasTotal = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBoleta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoKg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadTarimasTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(638, 40);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Registro de Tarima #Lote";
            this.labelControl1.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(253, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 47);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(459, 45);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 47);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 24);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "# Boleta Ttrace";
            // 
            // txtIdBoleta
            // 
            this.txtIdBoleta.EditValue = "";
            this.txtIdBoleta.Location = new System.Drawing.Point(187, 119);
            this.txtIdBoleta.Name = "txtIdBoleta";
            this.txtIdBoleta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBoleta.Properties.Appearance.Options.UseFont = true;
            this.txtIdBoleta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdBoleta.Size = new System.Drawing.Size(142, 32);
            this.txtIdBoleta.TabIndex = 0;
            this.txtIdBoleta.Enter += new System.EventHandler(this.txtIdBoleta_Enter);
            this.txtIdBoleta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionCorta_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.simpleButton1.Location = new System.Drawing.Point(335, 114);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(48, 41);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 18);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Materia Prima";
            this.labelControl3.Click += new System.EventHandler(this.txtProveedorName_Click);
            // 
            // txtCodigoMP
            // 
            this.txtCodigoMP.EditValue = "";
            this.txtCodigoMP.Enabled = false;
            this.txtCodigoMP.Location = new System.Drawing.Point(187, 161);
            this.txtCodigoMP.Name = "txtCodigoMP";
            this.txtCodigoMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMP.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoMP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMP.Size = new System.Drawing.Size(142, 26);
            this.txtCodigoMP.TabIndex = 32;
            this.txtCodigoMP.Click += new System.EventHandler(this.txtProveedorName_Click);
            // 
            // txtMP_Name
            // 
            this.txtMP_Name.EditValue = "";
            this.txtMP_Name.Enabled = false;
            this.txtMP_Name.Location = new System.Drawing.Point(335, 161);
            this.txtMP_Name.Name = "txtMP_Name";
            this.txtMP_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP_Name.Properties.Appearance.Options.UseFont = true;
            this.txtMP_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMP_Name.Size = new System.Drawing.Size(291, 26);
            this.txtMP_Name.TabIndex = 34;
            this.txtMP_Name.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            this.txtMP_Name.Click += new System.EventHandler(this.txtProveedorName_Click);
            // 
            // txtProveedorName
            // 
            this.txtProveedorName.EditValue = "";
            this.txtProveedorName.Enabled = false;
            this.txtProveedorName.Location = new System.Drawing.Point(335, 193);
            this.txtProveedorName.Name = "txtProveedorName";
            this.txtProveedorName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorName.Properties.Appearance.Options.UseFont = true;
            this.txtProveedorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProveedorName.Size = new System.Drawing.Size(291, 26);
            this.txtProveedorName.TabIndex = 37;
            this.txtProveedorName.Click += new System.EventHandler(this.txtProveedorName_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 197);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 18);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Proveedor";
            this.labelControl4.Click += new System.EventHandler(this.txtProveedorName_Click);
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.EditValue = "";
            this.txtCodigoProveedor.Enabled = false;
            this.txtCodigoProveedor.Location = new System.Drawing.Point(187, 193);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoProveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProveedor.Size = new System.Drawing.Size(142, 26);
            this.txtCodigoProveedor.TabIndex = 35;
            this.txtCodigoProveedor.Click += new System.EventHandler(this.txtProveedorName_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 241);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(122, 24);
            this.labelControl5.TabIndex = 38;
            this.labelControl5.Text = "Fecha Ingreso";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.EditValue = null;
            this.dtFechaIngreso.Location = new System.Drawing.Point(187, 238);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.Properties.Appearance.Options.UseFont = true;
            this.dtFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIngreso.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaIngreso.Properties.MinValue = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtFechaIngreso.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaIngreso.Size = new System.Drawing.Size(142, 30);
            this.dtFechaIngreso.TabIndex = 39;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(345, 294);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(105, 24);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "# de Ingreso";
            // 
            // txtNumIngreso
            // 
            this.txtNumIngreso.EditValue = "";
            this.txtNumIngreso.Location = new System.Drawing.Point(456, 286);
            this.txtNumIngreso.Name = "txtNumIngreso";
            this.txtNumIngreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIngreso.Properties.Appearance.Options.UseFont = true;
            this.txtNumIngreso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumIngreso.Properties.ReadOnly = true;
            this.txtNumIngreso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumIngreso.Size = new System.Drawing.Size(170, 32);
            this.txtNumIngreso.TabIndex = 41;
            this.txtNumIngreso.Enter += new System.EventHandler(this.txtNumIngreso_Enter);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(16, 290);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 24);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = "0";
            this.txtUnidades.Location = new System.Drawing.Point(187, 286);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtUnidades.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnidades.Size = new System.Drawing.Size(142, 32);
            this.txtUnidades.TabIndex = 3;
            this.txtUnidades.TextChanged += new System.EventHandler(this.txtUnidades_TextChanged);
            this.txtUnidades.Enter += new System.EventHandler(this.txtCantidadT_Enter);
            this.txtUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadT_KeyPress);
            this.txtUnidades.Leave += new System.EventHandler(this.txtUnidades_Leave);
            // 
            // dtFechaProduccion
            // 
            this.dtFechaProduccion.EditValue = null;
            this.dtFechaProduccion.Location = new System.Drawing.Point(187, 373);
            this.dtFechaProduccion.Name = "dtFechaProduccion";
            this.dtFechaProduccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaProduccion.Properties.Appearance.Options.UseFont = true;
            this.dtFechaProduccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaProduccion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaProduccion.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaProduccion.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaProduccion.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaProduccion.Size = new System.Drawing.Size(142, 30);
            this.dtFechaProduccion.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(16, 376);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(156, 24);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Fecha Producción";
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.EditValue = null;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(187, 412);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVencimiento.Properties.Appearance.Options.UseFont = true;
            this.dtFechaVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVencimiento.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaVencimiento.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaVencimiento.Size = new System.Drawing.Size(142, 30);
            this.dtFechaVencimiento.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(16, 415);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(165, 24);
            this.labelControl9.TabIndex = 46;
            this.labelControl9.Text = "Fecha Vencimiento";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(394, 333);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 24);
            this.labelControl10.TabIndex = 49;
            this.labelControl10.Text = "# Lote ";
            // 
            // txtLote
            // 
            this.txtLote.EditValue = "";
            this.txtLote.Location = new System.Drawing.Point(456, 329);
            this.txtLote.Name = "txtLote";
            this.txtLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Properties.Appearance.Options.UseFont = true;
            this.txtLote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLote.Size = new System.Drawing.Size(170, 32);
            this.txtLote.TabIndex = 4;
            this.txtLote.Enter += new System.EventHandler(this.txtLote_Enter);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(16, 45);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(167, 47);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(335, 241);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(115, 24);
            this.labelControl11.TabIndex = 51;
            this.labelControl11.Text = "Presentación:";
            // 
            // gridLookUpEditPresentacion
            // 
            this.gridLookUpEditPresentacion.EditValue = "";
            this.gridLookUpEditPresentacion.Location = new System.Drawing.Point(456, 238);
            this.gridLookUpEditPresentacion.Name = "gridLookUpEditPresentacion";
            this.gridLookUpEditPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditPresentacion.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditPresentacion.Properties.DataSource = this.bindingSourcePresentaciones;
            this.gridLookUpEditPresentacion.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditPresentacion.Properties.ValueMember = "id";
            this.gridLookUpEditPresentacion.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEditPresentacion.Size = new System.Drawing.Size(170, 30);
            this.gridLookUpEditPresentacion.TabIndex = 2;
            this.gridLookUpEditPresentacion.EditValueChanged += new System.EventHandler(this.gridLookUpEditPresentacion_EditValueChanged);
            // 
            // bindingSourcePresentaciones
            // 
            this.bindingSourcePresentaciones.DataMember = "presentaciones";
            this.bindingSourcePresentaciones.DataSource = this.dsRecepcionMPx1;
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
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
            this.coldescripcion.Caption = "Presentaciones";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(16, 333);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 24);
            this.labelControl12.TabIndex = 53;
            this.labelControl12.Text = "Peso Kg";
            this.labelControl12.Click += new System.EventHandler(this.labelControl12_Click);
            // 
            // txtPesoKg
            // 
            this.txtPesoKg.EditValue = "0";
            this.txtPesoKg.Enabled = false;
            this.txtPesoKg.Location = new System.Drawing.Point(187, 329);
            this.txtPesoKg.Name = "txtPesoKg";
            this.txtPesoKg.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoKg.Properties.Appearance.Options.UseFont = true;
            this.txtPesoKg.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesoKg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPesoKg.Size = new System.Drawing.Size(142, 32);
            this.txtPesoKg.TabIndex = 54;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(345, 415);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(173, 24);
            this.labelControl13.TabIndex = 56;
            this.labelControl13.Text = "Cantidad de Tarimas";
            // 
            // txtCantidadTarimasTotal
            // 
            this.txtCantidadTarimasTotal.EditValue = "1";
            this.txtCantidadTarimasTotal.Location = new System.Drawing.Point(524, 411);
            this.txtCantidadTarimasTotal.Name = "txtCantidadTarimasTotal";
            this.txtCantidadTarimasTotal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTarimasTotal.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadTarimasTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadTarimasTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidadTarimasTotal.Size = new System.Drawing.Size(102, 32);
            this.txtCantidadTarimasTotal.TabIndex = 7;
            this.txtCantidadTarimasTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // frmTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtCantidadTarimasTotal);
            this.Controls.Add(this.txtPesoKg);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.gridLookUpEditPresentacion);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.dtFechaVencimiento);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaProduccion);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtNumIngreso);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtProveedorName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.txtMP_Name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCodigoMP);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtIdBoleta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTarima";
            this.Text = "frmTarima";
            this.Activated += new System.EventHandler(this.frmTarima_Activated);
            this.Load += new System.EventHandler(this.frmTarima_Load);
            this.Click += new System.EventHandler(this.frmTarima_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBoleta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoKg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadTarimasTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIdBoleta;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigoMP;
        private DevExpress.XtraEditors.TextEdit txtMP_Name;
        private DevExpress.XtraEditors.TextEdit txtProveedorName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCodigoProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtFechaIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNumIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtUnidades;
        private DevExpress.XtraEditors.DateEdit dtFechaProduccion;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtFechaVencimiento;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtLote;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private dsRecepcionMPx dsRecepcionMPx1;
        private System.Windows.Forms.BindingSource bindingSourcePresentaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtPesoKg;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtCantidadTarimasTotal;
    }
}