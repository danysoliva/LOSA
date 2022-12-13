
namespace LOSA.MigracionACS.RRHH.Reportes
{
    partial class frmResumenNominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenNominas));
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesRRHH1 = new MigracionACS.RRHH.Reportes.dsReportesRRHH();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpayslip_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_from = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrency_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpayslip_run_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_payslip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalary_rule_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalary_rule_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesRRHH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(324, 58);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 21;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(91, 58);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 20;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.ImageOptions.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(601, 45);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(116, 39);
            this.cmdExportar.TabIndex = 19;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // CargarDatos
            // 
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(458, 45);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 18;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(245, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Fecha Desde:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(170, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(282, 30);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Resumen de Nóminas Activas";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "resumen_nominas";
            this.gridControl1.DataSource = this.dsReportesRRHH1;
            this.gridControl1.Location = new System.Drawing.Point(8, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1031, 502);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesRRHH1
            // 
            this.dsReportesRRHH1.DataSetName = "dsReportesRRHH";
            this.dsReportesRRHH1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colpayslip_id,
            this.coldate_from,
            this.coldate_to,
            this.colemployee_id,
            this.colname,
            this.colcurrency_id,
            this.colmoneda,
            this.colpayslip_run_id,
            this.colname_payslip,
            this.colstate,
            this.colsalary_rule_id,
            this.colsalary_rule_name,
            this.coltotal,
            this.coldepartment_id,
            this.coldepto});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colpayslip_id
            // 
            this.colpayslip_id.FieldName = "payslip_id";
            this.colpayslip_id.Name = "colpayslip_id";
            this.colpayslip_id.OptionsColumn.AllowEdit = false;
            // 
            // coldate_from
            // 
            this.coldate_from.Caption = "Desde";
            this.coldate_from.FieldName = "date_from";
            this.coldate_from.Name = "coldate_from";
            this.coldate_from.OptionsColumn.AllowEdit = false;
            this.coldate_from.Visible = true;
            this.coldate_from.VisibleIndex = 4;
            // 
            // coldate_to
            // 
            this.coldate_to.Caption = "Hasta";
            this.coldate_to.FieldName = "date_to";
            this.coldate_to.Name = "coldate_to";
            this.coldate_to.OptionsColumn.AllowEdit = false;
            this.coldate_to.Visible = true;
            this.coldate_to.VisibleIndex = 5;
            // 
            // colemployee_id
            // 
            this.colemployee_id.FieldName = "employee_id";
            this.colemployee_id.Name = "colemployee_id";
            this.colemployee_id.OptionsColumn.AllowEdit = false;
            // 
            // colname
            // 
            this.colname.Caption = "Empleado";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            // 
            // colcurrency_id
            // 
            this.colcurrency_id.FieldName = "currency_id";
            this.colcurrency_id.Name = "colcurrency_id";
            this.colcurrency_id.OptionsColumn.AllowEdit = false;
            // 
            // colmoneda
            // 
            this.colmoneda.Caption = "Moneda";
            this.colmoneda.DisplayFormat.FormatString = "###,##0.00";
            this.colmoneda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmoneda.FieldName = "moneda";
            this.colmoneda.Name = "colmoneda";
            this.colmoneda.OptionsColumn.AllowEdit = false;
            this.colmoneda.Visible = true;
            this.colmoneda.VisibleIndex = 6;
            // 
            // colpayslip_run_id
            // 
            this.colpayslip_run_id.FieldName = "payslip_run_id";
            this.colpayslip_run_id.Name = "colpayslip_run_id";
            this.colpayslip_run_id.OptionsColumn.AllowEdit = false;
            // 
            // colname_payslip
            // 
            this.colname_payslip.Caption = "Nómina";
            this.colname_payslip.FieldName = "name_payslip";
            this.colname_payslip.Name = "colname_payslip";
            this.colname_payslip.OptionsColumn.AllowEdit = false;
            this.colname_payslip.Visible = true;
            this.colname_payslip.VisibleIndex = 3;
            // 
            // colstate
            // 
            this.colstate.Caption = "Estado";
            this.colstate.FieldName = "state";
            this.colstate.Name = "colstate";
            this.colstate.OptionsColumn.AllowEdit = false;
            this.colstate.Visible = true;
            this.colstate.VisibleIndex = 7;
            // 
            // colsalary_rule_id
            // 
            this.colsalary_rule_id.FieldName = "salary_rule_id";
            this.colsalary_rule_id.Name = "colsalary_rule_id";
            this.colsalary_rule_id.OptionsColumn.AllowEdit = false;
            // 
            // colsalary_rule_name
            // 
            this.colsalary_rule_name.Caption = "Regla Salarial";
            this.colsalary_rule_name.FieldName = "salary_rule_name";
            this.colsalary_rule_name.Name = "colsalary_rule_name";
            this.colsalary_rule_name.OptionsColumn.AllowEdit = false;
            this.colsalary_rule_name.Visible = true;
            this.colsalary_rule_name.VisibleIndex = 8;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 9;
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            this.coldepartment_id.OptionsColumn.AllowEdit = false;
            // 
            // coldepto
            // 
            this.coldepto.Caption = "Departamento";
            this.coldepto.FieldName = "depto";
            this.coldepto.Name = "coldepto";
            this.coldepto.OptionsColumn.AllowEdit = false;
            this.coldepto.Visible = true;
            this.coldepto.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // frmResumenNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 596);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmResumenNominas";
            this.Text = "Resumen Nominas";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesRRHH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsReportesRRHH dsReportesRRHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colpayslip_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_from;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_to;
        private DevExpress.XtraGrid.Columns.GridColumn colemployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrency_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colpayslip_run_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname_payslip;
        private DevExpress.XtraGrid.Columns.GridColumn colstate;
        private DevExpress.XtraGrid.Columns.GridColumn colsalary_rule_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsalary_rule_name;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
    }
}