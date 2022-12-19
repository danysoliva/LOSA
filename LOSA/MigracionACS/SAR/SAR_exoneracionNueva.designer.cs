namespace LOSA.MigracionACS.SAR
{
    partial class SAR_exoneracionNueva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAR_exoneracionNueva));
            this.pnmail = new DevExpress.XtraEditors.PanelControl();
            this.pnalert = new System.Windows.Forms.Panel();
            this.grd_plantillas = new DevExpress.XtraGrid.GridControl();
            this.dS_SAR = new MigracionACS.SAR.dS_SAR();
            this.grdv_plantillas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRubro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndescargar = new DevExpress.XtraEditors.SimpleButton();
            this.btnver = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btnload = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtanio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtfinal = new DevExpress.XtraEditors.DateEdit();
            this.dtinicial = new DevExpress.XtraEditors.DateEdit();
            this.grdv_plantilla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tgenable = new DevExpress.XtraEditors.ToggleSwitch();
            this.tgcerrado = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pnmail)).BeginInit();
            this.pnmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_plantillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_plantillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtanio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtanio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_plantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgenable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgcerrado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnmail
            // 
            this.pnmail.Controls.Add(this.tgcerrado);
            this.pnmail.Controls.Add(this.tgenable);
            this.pnmail.Controls.Add(this.pnalert);
            this.pnmail.Controls.Add(this.grd_plantillas);
            this.pnmail.Controls.Add(this.btndescargar);
            this.pnmail.Controls.Add(this.btnver);
            this.pnmail.Controls.Add(this.btnsave);
            this.pnmail.Controls.Add(this.btnload);
            this.pnmail.Controls.Add(this.labelControl4);
            this.pnmail.Controls.Add(this.dtanio);
            this.pnmail.Controls.Add(this.labelControl3);
            this.pnmail.Controls.Add(this.labelControl2);
            this.pnmail.Controls.Add(this.labelControl1);
            this.pnmail.Controls.Add(this.dtfinal);
            this.pnmail.Controls.Add(this.dtinicial);
            this.pnmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmail.Location = new System.Drawing.Point(0, 0);
            this.pnmail.Name = "pnmail";
            this.pnmail.Size = new System.Drawing.Size(585, 548);
            this.pnmail.TabIndex = 0;
            // 
            // pnalert
            // 
            this.pnalert.Location = new System.Drawing.Point(5, 516);
            this.pnalert.Name = "pnalert";
            this.pnalert.Size = new System.Drawing.Size(575, 27);
            this.pnalert.TabIndex = 13;
            // 
            // grd_plantillas
            // 
            this.grd_plantillas.DataMember = "plantilla";
            this.grd_plantillas.DataSource = this.dS_SAR;
            this.grd_plantillas.Location = new System.Drawing.Point(628, 54);
            this.grd_plantillas.MainView = this.grdv_plantillas;
            this.grd_plantillas.Name = "grd_plantillas";
            this.grd_plantillas.Size = new System.Drawing.Size(400, 200);
            this.grd_plantillas.TabIndex = 12;
            this.grd_plantillas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_plantillas});
            // 
            // dS_SAR
            // 
            this.dS_SAR.DataSetName = "dS_SAR";
            this.dS_SAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_plantillas
            // 
            this.grdv_plantillas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo1,
            this.colRubro1,
            this.colMonto1});
            this.grdv_plantillas.GridControl = this.grd_plantillas;
            this.grdv_plantillas.Name = "grdv_plantillas";
            // 
            // colCodigo1
            // 
            this.colCodigo1.FieldName = "Codigo";
            this.colCodigo1.Name = "colCodigo1";
            this.colCodigo1.Visible = true;
            this.colCodigo1.VisibleIndex = 0;
            // 
            // colRubro1
            // 
            this.colRubro1.FieldName = "Rubro";
            this.colRubro1.Name = "colRubro1";
            this.colRubro1.Visible = true;
            this.colRubro1.VisibleIndex = 1;
            // 
            // colMonto1
            // 
            this.colMonto1.FieldName = "Monto";
            this.colMonto1.Name = "colMonto1";
            this.colMonto1.Visible = true;
            this.colMonto1.VisibleIndex = 2;
            // 
            // btndescargar
            // 
            this.btndescargar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.Appearance.Options.UseFont = true;
            this.btndescargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndescargar.ImageOptions.Image")));
            this.btndescargar.Location = new System.Drawing.Point(419, 277);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(150, 49);
            this.btndescargar.TabIndex = 11;
            this.btndescargar.Text = "Plantilla";
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // btnver
            // 
            this.btnver.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnver.Appearance.Options.UseFont = true;
            this.btnver.Enabled = false;
            this.btnver.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnver.ImageOptions.Image")));
            this.btnver.Location = new System.Drawing.Point(419, 332);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(150, 49);
            this.btnver.TabIndex = 10;
            this.btnver.Text = "Ver detalle";
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // btnsave
            // 
            this.btnsave.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Appearance.Options.UseFont = true;
            this.btnsave.Enabled = false;
            this.btnsave.ImageOptions.Image = global::LOSA.Properties.Resources.excel_48x48;
            this.btnsave.Location = new System.Drawing.Point(12, 387);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(550, 126);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Cargar presupuesto";
            this.btnsave.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnload
            // 
            this.btnload.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Appearance.Options.UseFont = true;
            this.btnload.ImageOptions.Image = global::LOSA.Properties.Resources.excel_48x48;
            this.btnload.Location = new System.Drawing.Point(12, 277);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(401, 104);
            this.btnload.TabIndex = 7;
            this.btnload.Text = "Cargar presupuesto";
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 24);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Año:";
            // 
            // dtanio
            // 
            this.dtanio.EditValue = null;
            this.dtanio.Enabled = false;
            this.dtanio.Location = new System.Drawing.Point(297, 139);
            this.dtanio.Name = "dtanio";
            this.dtanio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtanio.Properties.Appearance.Options.UseFont = true;
            this.dtanio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtanio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtanio.Properties.DisplayFormat.FormatString = "yyyy";
            this.dtanio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtanio.Properties.EditFormat.FormatString = "yyyy";
            this.dtanio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtanio.Size = new System.Drawing.Size(276, 30);
            this.dtanio.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(245, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Dia final de la exoneracion:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(258, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Dia inicial de la exoneracion:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(265, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nuevo registro exonerado ";
            // 
            // dtfinal
            // 
            this.dtfinal.EditValue = null;
            this.dtfinal.Location = new System.Drawing.Point(297, 96);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfinal.Properties.Appearance.Options.UseFont = true;
            this.dtfinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfinal.Size = new System.Drawing.Size(276, 28);
            this.dtfinal.TabIndex = 1;
            // 
            // dtinicial
            // 
            this.dtinicial.EditValue = null;
            this.dtinicial.Location = new System.Drawing.Point(297, 51);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtinicial.Properties.Appearance.Options.UseFont = true;
            this.dtinicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtinicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtinicial.Size = new System.Drawing.Size(276, 30);
            this.dtinicial.TabIndex = 0;
            this.dtinicial.EditValueChanged += new System.EventHandler(this.dtinicial_EditValueChanged);
            // 
            // grdv_plantilla
            // 
            this.grdv_plantilla.Name = "grdv_plantilla";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            // 
            // colRubro
            // 
            this.colRubro.FieldName = "Rubro";
            this.colRubro.Name = "colRubro";
            this.colRubro.Visible = true;
            this.colRubro.VisibleIndex = 1;
            // 
            // colmonto
            // 
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 2;
            // 
            // tgenable
            // 
            this.tgenable.EditValue = true;
            this.tgenable.Location = new System.Drawing.Point(23, 184);
            this.tgenable.Name = "tgenable";
            this.tgenable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgenable.Properties.Appearance.Options.UseFont = true;
            this.tgenable.Properties.OffText = "Desactivado";
            this.tgenable.Properties.OnText = "Habilitado";
            this.tgenable.Size = new System.Drawing.Size(552, 35);
            this.tgenable.TabIndex = 14;
            this.tgenable.Toggled += new System.EventHandler(this.tgenable_Toggled);
            // 
            // tgcerrado
            // 
            this.tgcerrado.EditValue = true;
            this.tgcerrado.Location = new System.Drawing.Point(23, 225);
            this.tgcerrado.Name = "tgcerrado";
            this.tgcerrado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgcerrado.Properties.Appearance.Options.UseFont = true;
            this.tgcerrado.Properties.OffText = "Abierto";
            this.tgcerrado.Properties.OnText = "Cerrado";
            this.tgcerrado.Size = new System.Drawing.Size(552, 35);
            this.tgcerrado.TabIndex = 15;
            this.tgcerrado.Toggled += new System.EventHandler(this.tgcerrado_Toggled);
            // 
            // SAR_exoneracionNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 548);
            this.Controls.Add(this.pnmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SAR_exoneracionNueva";
            this.Text = "Nueva Exoneracion";
            ((System.ComponentModel.ISupportInitialize)(this.pnmail)).EndInit();
            this.pnmail.ResumeLayout(false);
            this.pnmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_plantillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_plantillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtanio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtanio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtinicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_plantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgenable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgcerrado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnmail;
        private DevExpress.XtraEditors.SimpleButton btnload;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtanio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtfinal;
        private DevExpress.XtraEditors.DateEdit dtinicial;
        private DevExpress.XtraEditors.SimpleButton btndescargar;
        private DevExpress.XtraEditors.SimpleButton btnver;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_plantilla;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.GridControl grd_plantillas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_plantillas;
        private dS_SAR dS_SAR;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colRubro1;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto1;
        private System.Windows.Forms.Panel pnalert;
        private DevExpress.XtraEditors.ToggleSwitch tgcerrado;
        private DevExpress.XtraEditors.ToggleSwitch tgenable;
    }
}