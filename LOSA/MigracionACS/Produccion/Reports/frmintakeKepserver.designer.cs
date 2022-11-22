namespace LOSA.MigracionACS.Produccion.Reports
{
    partial class frmintakeKepserver
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdCargarDatos = new System.Windows.Forms.Button();
            this.txtNumeroOrden = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdVisualizacion = new DevExpress.XtraEditors.RadioGroup();
            this.rdFiltro = new DevExpress.XtraEditors.RadioGroup();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControlLiquidos = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdExporExcelLiquidos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateHastaLiquidos = new DevExpress.XtraEditors.DateEdit();
            this.dateDesdeLiquidos = new DevExpress.XtraEditors.DateEdit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroOrden.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdVisualizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdFiltro.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLiquidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHastaLiquidos.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHastaLiquidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesdeLiquidos.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesdeLiquidos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(112, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.cmdExcel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.grDetalle);
            this.tabPage1.Controls.Add(this.cmdCargarDatos);
            this.tabPage1.Controls.Add(this.txtNumeroOrden);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rdVisualizacion);
            this.tabPage1.Controls.Add(this.rdFiltro);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(956, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consumos Reales";
            // 
            // cmdExcel
            // 
            this.cmdExcel.BackColor = System.Drawing.Color.White;
            this.cmdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.Location = new System.Drawing.Point(844, 7);
            this.cmdExcel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(108, 56);
            this.cmdExcel.TabIndex = 9;
            this.cmdExcel.Text = "Excel";
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExcel.UseVisualStyleBackColor = false;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "# de Orden Producción";
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grDetalle.Location = new System.Drawing.Point(2, 68);
            this.grDetalle.MainView = this.gridView1;
            this.grDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.Size = new System.Drawing.Size(954, 404);
            this.grDetalle.TabIndex = 7;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grDetalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmdCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarDatos.Image = global::LOSA.Properties.Resources.refresh_32x32;
            this.cmdCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCargarDatos.Location = new System.Drawing.Point(709, 7);
            this.cmdCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(131, 56);
            this.cmdCargarDatos.TabIndex = 6;
            this.cmdCargarDatos.Text = "Cargar Datos";
            this.cmdCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCargarDatos.UseVisualStyleBackColor = false;
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click_1);
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.EditValue = "";
            this.txtNumeroOrden.Location = new System.Drawing.Point(374, 39);
            this.txtNumeroOrden.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrden.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroOrden.Properties.NullText = "# Orden Producción";
            this.txtNumeroOrden.Size = new System.Drawing.Size(116, 22);
            this.txtNumeroOrden.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtHasta);
            this.groupBox1.Controls.Add(this.dtDesde);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(503, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 41);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Enabled = false;
            this.dtHasta.Location = new System.Drawing.Point(103, 16);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(94, 22);
            this.dtHasta.TabIndex = 1;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Enabled = false;
            this.dtDesde.Location = new System.Drawing.Point(4, 16);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(94, 22);
            this.dtDesde.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visualización";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // rdVisualizacion
            // 
            this.rdVisualizacion.Location = new System.Drawing.Point(170, 23);
            this.rdVisualizacion.Margin = new System.Windows.Forms.Padding(2);
            this.rdVisualizacion.Name = "rdVisualizacion";
            this.rdVisualizacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVisualizacion.Properties.Appearance.Options.UseFont = true;
            this.rdVisualizacion.Properties.Columns = 1;
            this.rdVisualizacion.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rdVisualizacion.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Detalle Agrupado por Orden"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Resumen por Materia Prima")});
            this.rdVisualizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdVisualizacion.Size = new System.Drawing.Size(193, 41);
            this.rdVisualizacion.TabIndex = 1;
            // 
            // rdFiltro
            // 
            this.rdFiltro.Location = new System.Drawing.Point(4, 23);
            this.rdFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.rdFiltro.Name = "rdFiltro";
            this.rdFiltro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFiltro.Properties.Appearance.Options.UseFont = true;
            this.rdFiltro.Properties.Appearance.Options.UseTextOptions = true;
            this.rdFiltro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rdFiltro.Properties.Columns = 1;
            this.rdFiltro.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rdFiltro.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Por Número de Orden"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Por Rango de Fechas")});
            this.rdFiltro.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            this.rdFiltro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdFiltro.Size = new System.Drawing.Size(160, 41);
            this.rdFiltro.TabIndex = 0;
            this.rdFiltro.SelectedIndexChanged += new System.EventHandler(this.rdFiltro_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.gridControlLiquidos);
            this.tabPage2.Controls.Add(this.cmdExporExcelLiquidos);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(956, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liquidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Consumos de Liquidos en Aplicadores";
            // 
            // gridControlLiquidos
            // 
            this.gridControlLiquidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlLiquidos.Location = new System.Drawing.Point(2, 74);
            this.gridControlLiquidos.MainView = this.gridView2;
            this.gridControlLiquidos.Name = "gridControlLiquidos";
            this.gridControlLiquidos.Size = new System.Drawing.Size(953, 393);
            this.gridControlLiquidos.TabIndex = 13;
            this.gridControlLiquidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlLiquidos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // cmdExporExcelLiquidos
            // 
            this.cmdExporExcelLiquidos.BackColor = System.Drawing.Color.White;
            this.cmdExporExcelLiquidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExporExcelLiquidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExporExcelLiquidos.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.cmdExporExcelLiquidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExporExcelLiquidos.Location = new System.Drawing.Point(843, 12);
            this.cmdExporExcelLiquidos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExporExcelLiquidos.Name = "cmdExporExcelLiquidos";
            this.cmdExporExcelLiquidos.Size = new System.Drawing.Size(108, 56);
            this.cmdExporExcelLiquidos.TabIndex = 12;
            this.cmdExporExcelLiquidos.Text = "Excel";
            this.cmdExporExcelLiquidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExporExcelLiquidos.UseVisualStyleBackColor = false;
            this.cmdExporExcelLiquidos.Click += new System.EventHandler(this.cmdExporExcelLiquidos_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::LOSA.Properties.Resources.refresh_32x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(708, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cargar Datos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateHastaLiquidos);
            this.groupBox2.Controls.Add(this.dateDesdeLiquidos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(502, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(201, 41);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de Fechas";
            // 
            // dateHastaLiquidos
            // 
            this.dateHastaLiquidos.EditValue = null;
            this.dateHastaLiquidos.Location = new System.Drawing.Point(103, 16);
            this.dateHastaLiquidos.Margin = new System.Windows.Forms.Padding(2);
            this.dateHastaLiquidos.Name = "dateHastaLiquidos";
            this.dateHastaLiquidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHastaLiquidos.Properties.Appearance.Options.UseFont = true;
            this.dateHastaLiquidos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHastaLiquidos.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateHastaLiquidos.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHastaLiquidos.Size = new System.Drawing.Size(94, 22);
            this.dateHastaLiquidos.TabIndex = 1;
            // 
            // dateDesdeLiquidos
            // 
            this.dateDesdeLiquidos.EditValue = null;
            this.dateDesdeLiquidos.Location = new System.Drawing.Point(4, 16);
            this.dateDesdeLiquidos.Margin = new System.Windows.Forms.Padding(2);
            this.dateDesdeLiquidos.Name = "dateDesdeLiquidos";
            this.dateDesdeLiquidos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDesdeLiquidos.Properties.Appearance.Options.UseFont = true;
            this.dateDesdeLiquidos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesdeLiquidos.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateDesdeLiquidos.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesdeLiquidos.Size = new System.Drawing.Size(94, 22);
            this.dateDesdeLiquidos.TabIndex = 0;
            // 
            // frmintakeKepserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 505);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmintakeKepserver";
            this.Text = "Intake Full Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroOrden.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdVisualizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdFiltro.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLiquidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateHastaLiquidos.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHastaLiquidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesdeLiquidos.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesdeLiquidos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdExcel;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button cmdCargarDatos;
        private DevExpress.XtraEditors.TextEdit txtNumeroOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.RadioGroup rdVisualizacion;
        private DevExpress.XtraEditors.RadioGroup rdFiltro;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControlLiquidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button cmdExporExcelLiquidos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.DateEdit dateHastaLiquidos;
        private DevExpress.XtraEditors.DateEdit dateDesdeLiquidos;
        private System.Windows.Forms.Label label4;
    }
}