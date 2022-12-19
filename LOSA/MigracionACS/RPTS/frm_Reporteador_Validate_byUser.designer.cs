namespace LOSA.MigracionACS.RPTS
{
    partial class frm_Reporteador_Validate_byUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reporteador_Validate_byUser));
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabCtasXCobrarEmp = new System.Windows.Forms.TabPage();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingCuentas = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes21 = new MigracionACS.DataSetx.dsReportes2();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.lbl_desde = new DevExpress.XtraEditors.LabelControl();
            this.lbl_hasta = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.tabReportes.SuspendLayout();
            this.tabCtasXCobrarEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReportes
            // 
            this.tabReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabReportes.Controls.Add(this.tabCtasXCobrarEmp);
            this.tabReportes.Location = new System.Drawing.Point(0, 0);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(918, 113);
            this.tabReportes.TabIndex = 0;
            // 
            // tabCtasXCobrarEmp
            // 
            this.tabCtasXCobrarEmp.Controls.Add(this.cmdCargarDatos);
            this.tabCtasXCobrarEmp.Controls.Add(this.gridLookUpEdit1);
            this.tabCtasXCobrarEmp.Controls.Add(this.labelControl2);
            this.tabCtasXCobrarEmp.Controls.Add(this.labelControl1);
            this.tabCtasXCobrarEmp.Controls.Add(this.dt_desde);
            this.tabCtasXCobrarEmp.Controls.Add(this.dt_hasta);
            this.tabCtasXCobrarEmp.Controls.Add(this.lbl_desde);
            this.tabCtasXCobrarEmp.Controls.Add(this.lbl_hasta);
            this.tabCtasXCobrarEmp.Location = new System.Drawing.Point(4, 22);
            this.tabCtasXCobrarEmp.Name = "tabCtasXCobrarEmp";
            this.tabCtasXCobrarEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabCtasXCobrarEmp.Size = new System.Drawing.Size(910, 87);
            this.tabCtasXCobrarEmp.TabIndex = 0;
            this.tabCtasXCobrarEmp.Text = "Ctas x Cobrar Emp";
            this.tabCtasXCobrarEmp.UseVisualStyleBackColor = true;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(293, 28);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.bindingCuentas;
            this.gridLookUpEdit1.Properties.DisplayMember = "descripcion";
            this.gridLookUpEdit1.Properties.ValueMember = "id_cuenta";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(188, 22);
            this.gridLookUpEdit1.TabIndex = 11;
            // 
            // bindingCuentas
            // 
            this.bindingCuentas.DataMember = "filtro_cuentas";
            this.bindingCuentas.DataSource = this.dsReportes21;
            // 
            // dsReportes21
            // 
            this.dsReportes21.DataSetName = "dsReportes2";
            this.dsReportes21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cuenta,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_cuenta
            // 
            this.colid_cuenta.FieldName = "id_cuenta";
            this.colid_cuenta.Name = "colid_cuenta";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Location = new System.Drawing.Point(293, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Elija la cuenta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Location = new System.Drawing.Point(18, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Elija el rango de Fechas:";
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(64, 29);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_desde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_desde.Properties.Appearance.Options.UseFont = true;
            this.dt_desde.Properties.Appearance.Options.UseForeColor = true;
            this.dt_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_desde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_desde.Size = new System.Drawing.Size(170, 22);
            this.dt_desde.TabIndex = 5;
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(64, 55);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_hasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_hasta.Properties.Appearance.Options.UseFont = true;
            this.dt_hasta.Properties.Appearance.Options.UseForeColor = true;
            this.dt_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_hasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_hasta.Size = new System.Drawing.Size(170, 22);
            this.dt_hasta.TabIndex = 6;
            // 
            // lbl_desde
            // 
            this.lbl_desde.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_desde.Location = new System.Drawing.Point(18, 32);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(40, 16);
            this.lbl_desde.TabIndex = 7;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_hasta.Location = new System.Drawing.Point(18, 58);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(38, 16);
            this.lbl_hasta.TabIndex = 8;
            this.lbl_hasta.Text = "Hasta";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(4, 160);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(910, 381);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdCargarDatos.Appearance.Options.UseFont = true;
            this.cmdCargarDatos.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargarDatos.Image")));
            this.cmdCargarDatos.Location = new System.Drawing.Point(487, 28);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(148, 46);
            this.cmdCargarDatos.TabIndex = 12;
            this.cmdCargarDatos.Text = "Cargar Datos";
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // cmdExportExcel
            // 
            this.cmdExportExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdExportExcel.Appearance.Options.UseFont = true;
            this.cmdExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportExcel.Image")));
            this.cmdExportExcel.Location = new System.Drawing.Point(4, 112);
            this.cmdExportExcel.Name = "cmdExportExcel";
            this.cmdExportExcel.Size = new System.Drawing.Size(148, 46);
            this.cmdExportExcel.TabIndex = 13;
            this.cmdExportExcel.Text = "Exportar a Excel";
            this.cmdExportExcel.Click += new System.EventHandler(this.cmdExportExcel_Click);
            // 
            // frm_Reporteador_Validate_byUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 543);
            this.Controls.Add(this.cmdExportExcel);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tabReportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Reporteador_Validate_byUser";
            this.Text = "Reporteador 2.0";
            this.tabReportes.ResumeLayout(false);
            this.tabCtasXCobrarEmp.ResumeLayout(false);
            this.tabCtasXCobrarEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabCtasXCobrarEmp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private DevExpress.XtraEditors.LabelControl lbl_desde;
        private DevExpress.XtraEditors.LabelControl lbl_hasta;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bindingCuentas;
        private DataSetx.dsReportes2 dsReportes21;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton cmdExportExcel;
    }
}