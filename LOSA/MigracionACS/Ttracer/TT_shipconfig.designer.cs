namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_shipconfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_shipconfig));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnclose = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tggclose = new DevExpress.XtraEditors.ToggleSwitch();
            this.tggenable = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtunid = new DevExpress.XtraEditors.TextEdit();
            this.btncreate = new System.Windows.Forms.Button();
            this.txtpeso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtfin = new DevExpress.XtraEditors.DateEdit();
            this.dtini = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grdshipmame = new DevExpress.XtraEditors.GridLookUpEdit();
            this.grdOpcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tggclose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdshipmame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnclose);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(968, 49);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(915, 1);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(52, 43);
            this.btnclose.TabIndex = 2;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(296, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nueva transaccion de barco";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.Logo_x32;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.tggclose);
            this.panelControl2.Controls.Add(this.tggenable);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txtunid);
            this.panelControl2.Controls.Add(this.btncreate);
            this.panelControl2.Controls.Add(this.txtpeso);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.dtfin);
            this.panelControl2.Controls.Add(this.dtini);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.grdshipmame);
            this.panelControl2.Controls.Add(this.txtcode);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 49);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(968, 479);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(36, 322);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(147, 24);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Cerrado Manual:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Enabled = false;
            this.labelControl8.Location = new System.Drawing.Point(36, 281);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(67, 24);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Estado:";
            // 
            // tggclose
            // 
            this.tggclose.Enabled = false;
            this.tggclose.Location = new System.Drawing.Point(622, 311);
            this.tggclose.Name = "tggclose";
            this.tggclose.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggclose.Properties.Appearance.Options.UseFont = true;
            this.tggclose.Properties.OffText = "Abierto";
            this.tggclose.Properties.OnText = "Cerrado";
            this.tggclose.Size = new System.Drawing.Size(333, 35);
            this.tggclose.TabIndex = 14;
            this.tggclose.Visible = false;
            // 
            // tggenable
            // 
            this.tggenable.Enabled = false;
            this.tggenable.Location = new System.Drawing.Point(622, 270);
            this.tggenable.Name = "tggenable";
            this.tggenable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggenable.Properties.Appearance.Options.UseFont = true;
            this.tggenable.Properties.OffText = "Deshabilitado";
            this.tggenable.Properties.OnText = "Habilitado";
            this.tggenable.Size = new System.Drawing.Size(333, 35);
            this.tggenable.TabIndex = 13;
            this.tggenable.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(36, 240);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(214, 24);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Vehiculos programados:";
            // 
            // txtunid
            // 
            this.txtunid.Location = new System.Drawing.Point(622, 234);
            this.txtunid.Name = "txtunid";
            this.txtunid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunid.Properties.Appearance.Options.UseFont = true;
            this.txtunid.Properties.Mask.EditMask = "n";
            this.txtunid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtunid.Size = new System.Drawing.Size(333, 30);
            this.txtunid.TabIndex = 11;
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(334, 388);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(280, 79);
            this.btncreate.TabIndex = 10;
            this.btncreate.Text = "Guardar";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(622, 194);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Properties.Appearance.Options.UseFont = true;
            this.txtpeso.Properties.Mask.EditMask = "n";
            this.txtpeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtpeso.Size = new System.Drawing.Size(333, 30);
            this.txtpeso.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(36, 200);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(233, 24);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Peso aproximado en (Kg):";
            // 
            // dtfin
            // 
            this.dtfin.EditValue = null;
            this.dtfin.Location = new System.Drawing.Point(622, 157);
            this.dtfin.Margin = new System.Windows.Forms.Padding(4);
            this.dtfin.Name = "dtfin";
            this.dtfin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfin.Properties.Appearance.Options.UseFont = true;
            this.dtfin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Size = new System.Drawing.Size(333, 30);
            this.dtfin.TabIndex = 7;
            this.dtfin.EditValueChanged += new System.EventHandler(this.dtfin_EditValueChanged);
            // 
            // dtini
            // 
            this.dtini.EditValue = null;
            this.dtini.Location = new System.Drawing.Point(622, 118);
            this.dtini.Margin = new System.Windows.Forms.Padding(4);
            this.dtini.Name = "dtini";
            this.dtini.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtini.Properties.Appearance.Options.UseFont = true;
            this.dtini.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtini.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtini.Size = new System.Drawing.Size(333, 30);
            this.dtini.TabIndex = 6;
            this.dtini.EditValueChanged += new System.EventHandler(this.dtini_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(36, 160);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(192, 24);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Fecha de finalizacion:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 121);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(241, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Fecha prevista de llegada: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 81);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(298, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Nombre del barco proximo barco:";
            // 
            // grdshipmame
            // 
            this.grdshipmame.Location = new System.Drawing.Point(411, 73);
            this.grdshipmame.Margin = new System.Windows.Forms.Padding(4);
            this.grdshipmame.Name = "grdshipmame";
            this.grdshipmame.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdshipmame.Properties.Appearance.Options.UseFont = true;
            this.grdshipmame.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdshipmame.Properties.DataSource = this.grdOpcionBindingSource;
            this.grdshipmame.Properties.DisplayMember = "descripcion";
            this.grdshipmame.Properties.ValueMember = "id";
            this.grdshipmame.Properties.View = this.gridLookUpEdit1View;
            this.grdshipmame.Size = new System.Drawing.Size(551, 30);
            this.grdshipmame.TabIndex = 2;
            // 
            // grdOpcionBindingSource
            // 
            this.grdOpcionBindingSource.DataMember = "grdOpcion";
            this.grdOpcionBindingSource.DataSource = this.dSTtracer;
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Nombre";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(803, 6);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Properties.Appearance.Options.UseFont = true;
            this.txtcode.Size = new System.Drawing.Size(159, 30);
            this.txtcode.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(720, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Codigo:";
            // 
            // TT_shipconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 528);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TT_shipconfig";
            this.Text = "TT_shipconfig";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tggclose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtunid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdshipmame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnclose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit grdshipmame;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtcode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource grdOpcionBindingSource;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.DateEdit dtfin;
        private DevExpress.XtraEditors.DateEdit dtini;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btncreate;
        private DevExpress.XtraEditors.TextEdit txtpeso;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtunid;
        private DevExpress.XtraEditors.ToggleSwitch tggenable;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ToggleSwitch tggclose;
    }
}