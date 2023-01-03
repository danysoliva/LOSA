namespace LOSA.MigracionACS.Ttracer
{
    partial class TT_newPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TT_newPlan));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtpesoaprox = new DevExpress.XtraEditors.TextEdit();
            this.grdship = new DevExpress.XtraEditors.GridLookUpEdit();
            this.shipArribBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTtracer = new MigracionACS.Ttracer.dSTtracer();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidplan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldtini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldtfin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblship = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tggwithship = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtfin = new DevExpress.XtraEditors.DateEdit();
            this.dtinicio = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpesoaprox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdship.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipArribBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggwithship.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.Image = global::LOSA.Properties.Resources.Logo_Aquafeed;
            this.panelControl1.Appearance.Options.UseImage = true;
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(613, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOSA.Properties.Resources.LogoLimp_x32;
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(198, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Creacion de nuevo plan";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::LOSA.Properties.Resources.remove_24x24;
            this.button2.Location = new System.Drawing.Point(515, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 41);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(563, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtCodigo);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.btnguardar);
            this.panelControl2.Controls.Add(this.txtcomment);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.txtpesoaprox);
            this.panelControl2.Controls.Add(this.grdship);
            this.panelControl2.Controls.Add(this.lblship);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.tggwithship);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.dtfin);
            this.panelControl2.Controls.Add(this.dtinicio);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 50);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(613, 496);
            this.panelControl2.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(289, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(317, 30);
            this.txtCodigo.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 42);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 24);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Codigo:";
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(125, 389);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(389, 101);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcomment
            // 
            this.txtcomment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomment.Location = new System.Drawing.Point(289, 190);
            this.txtcomment.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomment.Multiline = true;
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(316, 104);
            this.txtcomment.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(9, 196);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(108, 23);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Comentario: ";
            // 
            // txtpesoaprox
            // 
            this.txtpesoaprox.Location = new System.Drawing.Point(289, 149);
            this.txtpesoaprox.Margin = new System.Windows.Forms.Padding(4);
            this.txtpesoaprox.Name = "txtpesoaprox";
            this.txtpesoaprox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesoaprox.Properties.Appearance.Options.UseFont = true;
            this.txtpesoaprox.Properties.Mask.EditMask = "f";
            this.txtpesoaprox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtpesoaprox.Size = new System.Drawing.Size(317, 30);
            this.txtpesoaprox.TabIndex = 10;
            // 
            // grdship
            // 
            this.grdship.Enabled = false;
            this.grdship.Location = new System.Drawing.Point(285, 345);
            this.grdship.Margin = new System.Windows.Forms.Padding(4);
            this.grdship.Name = "grdship";
            this.grdship.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdship.Properties.Appearance.Options.UseFont = true;
            this.grdship.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdship.Properties.DataSource = this.shipArribBindingSource;
            this.grdship.Properties.DisplayMember = "Nbarco";
            this.grdship.Properties.ValueMember = "idplan";
            this.grdship.Properties.View = this.gridLookUpEdit1View;
            this.grdship.Size = new System.Drawing.Size(317, 30);
            this.grdship.TabIndex = 9;
            this.grdship.Visible = false;
            // 
            // shipArribBindingSource
            // 
            this.shipArribBindingSource.DataMember = "shipArrib";
            this.shipArribBindingSource.DataSource = this.dSTtracer;
            // 
            // dSTtracer
            // 
            this.dSTtracer.DataSetName = "dSTtracer";
            this.dSTtracer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidplan,
            this.colNbarco,
            this.colCodigoB,
            this.coldtini,
            this.coldtfin});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colidplan
            // 
            this.colidplan.Caption = "ID";
            this.colidplan.FieldName = "idplan";
            this.colidplan.Name = "colidplan";
            this.colidplan.Visible = true;
            this.colidplan.VisibleIndex = 0;
            this.colidplan.Width = 74;
            // 
            // colNbarco
            // 
            this.colNbarco.Caption = "Nombre";
            this.colNbarco.FieldName = "Nbarco";
            this.colNbarco.Name = "colNbarco";
            this.colNbarco.Visible = true;
            this.colNbarco.VisibleIndex = 1;
            this.colNbarco.Width = 762;
            // 
            // colCodigoB
            // 
            this.colCodigoB.Caption = "Codigo B.";
            this.colCodigoB.FieldName = "CodigoB";
            this.colCodigoB.Name = "colCodigoB";
            this.colCodigoB.Visible = true;
            this.colCodigoB.VisibleIndex = 2;
            this.colCodigoB.Width = 721;
            // 
            // coldtini
            // 
            this.coldtini.FieldName = "dtini";
            this.coldtini.Name = "coldtini";
            // 
            // coldtfin
            // 
            this.coldtfin.FieldName = "dtfin";
            this.coldtfin.Name = "coldtfin";
            // 
            // lblship
            // 
            this.lblship.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblship.Appearance.Options.UseFont = true;
            this.lblship.Location = new System.Drawing.Point(8, 352);
            this.lblship.Margin = new System.Windows.Forms.Padding(4);
            this.lblship.Name = "lblship";
            this.lblship.Size = new System.Drawing.Size(54, 23);
            this.lblship.TabIndex = 8;
            this.lblship.Text = "Barco:";
            this.lblship.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 160);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(197, 23);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Peso aproximado (Kg): ";
            // 
            // tggwithship
            // 
            this.tggwithship.Location = new System.Drawing.Point(5, 302);
            this.tggwithship.Margin = new System.Windows.Forms.Padding(4);
            this.tggwithship.Name = "tggwithship";
            this.tggwithship.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggwithship.Properties.Appearance.Options.UseFont = true;
            this.tggwithship.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tggwithship.Properties.OffText = "Sin barco";
            this.tggwithship.Properties.OnText = "Con barco";
            this.tggwithship.Size = new System.Drawing.Size(599, 35);
            this.tggwithship.TabIndex = 5;
            this.tggwithship.Visible = false;
            this.tggwithship.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 80);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Fecha de Inicio:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 119);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(181, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Fecha de finalizacion:";
            // 
            // dtfin
            // 
            this.dtfin.EditValue = null;
            this.dtfin.Location = new System.Drawing.Point(289, 110);
            this.dtfin.Margin = new System.Windows.Forms.Padding(4);
            this.dtfin.Name = "dtfin";
            this.dtfin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfin.Properties.Appearance.Options.UseFont = true;
            this.dtfin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dtfin.Size = new System.Drawing.Size(317, 30);
            this.dtfin.TabIndex = 1;
            this.dtfin.EditValueChanged += new System.EventHandler(this.dtfin_EditValueChanged);
            // 
            // dtinicio
            // 
            this.dtinicio.EditValue = null;
            this.dtinicio.Location = new System.Drawing.Point(289, 71);
            this.dtinicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtinicio.Properties.Appearance.Options.UseFont = true;
            this.dtinicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtinicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtinicio.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dtinicio.Size = new System.Drawing.Size(317, 30);
            this.dtinicio.TabIndex = 0;
            this.dtinicio.EditValueChanged += new System.EventHandler(this.dtinicio_EditValueChanged);
            // 
            // TT_newPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 546);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TT_newPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo plan/barco";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpesoaprox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdship.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipArribBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTtracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggwithship.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtcomment;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtpesoaprox;
        private DevExpress.XtraEditors.GridLookUpEdit grdship;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblship;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ToggleSwitch tggwithship;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtfin;
        private DevExpress.XtraEditors.DateEdit dtinicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnguardar;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource shipArribBindingSource;
        private dSTtracer dSTtracer;
        private DevExpress.XtraGrid.Columns.GridColumn colidplan;
        private DevExpress.XtraGrid.Columns.GridColumn colNbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoB;
        private DevExpress.XtraGrid.Columns.GridColumn coldtini;
        private DevExpress.XtraGrid.Columns.GridColumn coldtfin;
    }
}