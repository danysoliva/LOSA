namespace LOSA.MigracionACS.RRHH.Vacaciones
{
    partial class frmVacacionesDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacacionesDetalles));
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesVacaciones1 = new LOSA.MigracionACS.RRHH.Vacaciones.dsReportesVacaciones();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_dias_vacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsincronizado_en_odoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_from = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumber_of_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colholiday_status_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalDias = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesVacaciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarDatos.Appearance.Options.UseBackColor = true;
            this.cmdCargarDatos.Appearance.Options.UseFont = true;
            this.cmdCargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargarDatos.ImageOptions.Image")));
            this.cmdCargarDatos.Location = new System.Drawing.Point(5, 2);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(110, 36);
            this.cmdCargarDatos.TabIndex = 23;
            this.cmdCargarDatos.Text = "Cargar ";
            // 
            // cmdExportar
            // 
            this.cmdExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseBackColor = true;
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExportar.ImageOptions.Image = global::LOSA.Properties.Resources.excel32px;
            this.cmdExportar.Location = new System.Drawing.Point(738, 2);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(110, 36);
            this.cmdExportar.TabIndex = 22;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Visible = false;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(854, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 36);
            this.cmdCerrar.TabIndex = 21;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "acumulados";
            this.gridControl1.DataSource = this.dsReportesVacaciones1;
            this.gridControl1.Location = new System.Drawing.Point(5, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 191);
            this.gridControl1.TabIndex = 24;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesVacaciones1
            // 
            this.dsReportesVacaciones1.DataSetName = "dsReportesVacaciones";
            this.dsReportesVacaciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colyear,
            this.coldays});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Dias Acumulados";
            // 
            // colyear
            // 
            this.colyear.FieldName = "year";
            this.colyear.Name = "colyear";
            this.colyear.OptionsColumn.ReadOnly = true;
            this.colyear.Visible = true;
            this.colyear.VisibleIndex = 0;
            // 
            // coldays
            // 
            this.coldays.FieldName = "days";
            this.coldays.Name = "coldays";
            this.coldays.OptionsColumn.ReadOnly = true;
            this.coldays.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "days", "SUM={0:0.##}")});
            this.coldays.Visible = true;
            this.coldays.VisibleIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "tomados_stand";
            this.gridControl2.DataSource = this.dsReportesVacaciones1;
            this.gridControl2.Location = new System.Drawing.Point(411, 44);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(553, 191);
            this.gridControl2.TabIndex = 25;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_employee,
            this.colfecha_inicio,
            this.colfecha_fin,
            this.colcant_dias_vacaciones,
            this.colobservaciones,
            this.colid_estado,
            this.colestado_name,
            this.colsincronizado_en_odoo,
            this.colenable,
            this.colcreated_date});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Dias solicitados en la WEB";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_employee
            // 
            this.colid_employee.FieldName = "id_employee";
            this.colid_employee.Name = "colid_employee";
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 0;
            this.colfecha_inicio.Width = 70;
            // 
            // colfecha_fin
            // 
            this.colfecha_fin.FieldName = "fecha_fin";
            this.colfecha_fin.Name = "colfecha_fin";
            this.colfecha_fin.Visible = true;
            this.colfecha_fin.VisibleIndex = 1;
            this.colfecha_fin.Width = 64;
            // 
            // colcant_dias_vacaciones
            // 
            this.colcant_dias_vacaciones.FieldName = "cant_dias_vacaciones";
            this.colcant_dias_vacaciones.Name = "colcant_dias_vacaciones";
            this.colcant_dias_vacaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cant_dias_vacaciones", "SUM={0:0.##}")});
            this.colcant_dias_vacaciones.Visible = true;
            this.colcant_dias_vacaciones.VisibleIndex = 2;
            this.colcant_dias_vacaciones.Width = 104;
            // 
            // colobservaciones
            // 
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 3;
            this.colobservaciones.Width = 111;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // colestado_name
            // 
            this.colestado_name.FieldName = "estado_name";
            this.colestado_name.Name = "colestado_name";
            this.colestado_name.Visible = true;
            this.colestado_name.VisibleIndex = 4;
            this.colestado_name.Width = 86;
            // 
            // colsincronizado_en_odoo
            // 
            this.colsincronizado_en_odoo.FieldName = "sincronizado_en_odoo";
            this.colsincronizado_en_odoo.Name = "colsincronizado_en_odoo";
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            // 
            // colcreated_date
            // 
            this.colcreated_date.FieldName = "created_date";
            this.colcreated_date.Name = "colcreated_date";
            this.colcreated_date.Visible = true;
            this.colcreated_date.VisibleIndex = 5;
            this.colcreated_date.Width = 93;
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "tomados_odoo";
            this.gridControl3.DataSource = this.dsReportesVacaciones1;
            this.gridControl3.Location = new System.Drawing.Point(5, 269);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(959, 239);
            this.gridControl3.TabIndex = 26;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colstate,
            this.colemployee_id,
            this.coldepartment_id,
            this.coldate_from,
            this.coldate_to,
            this.colnumber_of_days,
            this.colholiday_status_id,
            this.colfecha_creado});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowViewCaption = true;
            this.gridView3.ViewCaption = "Dias Tomados ODOO";
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colstate
            // 
            this.colstate.FieldName = "state";
            this.colstate.Name = "colstate";
            this.colstate.Visible = true;
            this.colstate.VisibleIndex = 0;
            // 
            // colemployee_id
            // 
            this.colemployee_id.FieldName = "employee_id";
            this.colemployee_id.Name = "colemployee_id";
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            // 
            // coldate_from
            // 
            this.coldate_from.FieldName = "date_from";
            this.coldate_from.Name = "coldate_from";
            this.coldate_from.Visible = true;
            this.coldate_from.VisibleIndex = 1;
            // 
            // coldate_to
            // 
            this.coldate_to.FieldName = "date_to";
            this.coldate_to.Name = "coldate_to";
            this.coldate_to.Visible = true;
            this.coldate_to.VisibleIndex = 2;
            // 
            // colnumber_of_days
            // 
            this.colnumber_of_days.FieldName = "number_of_days";
            this.colnumber_of_days.Name = "colnumber_of_days";
            this.colnumber_of_days.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "number_of_days", "SUM={0:0.##}")});
            this.colnumber_of_days.Visible = true;
            this.colnumber_of_days.VisibleIndex = 3;
            // 
            // colholiday_status_id
            // 
            this.colholiday_status_id.FieldName = "holiday_status_id";
            this.colholiday_status_id.Name = "colholiday_status_id";
            // 
            // colfecha_creado
            // 
            this.colfecha_creado.FieldName = "fecha_creado";
            this.colfecha_creado.Name = "colfecha_creado";
            this.colfecha_creado.Visible = true;
            this.colfecha_creado.VisibleIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Location = new System.Drawing.Point(121, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(149, 17);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Seleccione los materiales";
            // 
            // lblTotalDias
            // 
            this.lblTotalDias.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalDias.Appearance.Options.UseFont = true;
            this.lblTotalDias.Location = new System.Drawing.Point(583, 21);
            this.lblTotalDias.Name = "lblTotalDias";
            this.lblTotalDias.Size = new System.Drawing.Size(149, 17);
            this.lblTotalDias.TabIndex = 28;
            this.lblTotalDias.Text = "Seleccione los materiales";
            // 
            // frmVacacionesDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 510);
            this.Controls.Add(this.lblTotalDias);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdCerrar);
            this.Name = "frmVacacionesDetalles";
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesVacaciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private dsReportesVacaciones dsReportesVacaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colyear;
        private DevExpress.XtraGrid.Columns.GridColumn coldays;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_dias_vacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_name;
        private DevExpress.XtraGrid.Columns.GridColumn colsincronizado_en_odoo;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colstate;
        private DevExpress.XtraGrid.Columns.GridColumn colemployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_from;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_to;
        private DevExpress.XtraGrid.Columns.GridColumn colnumber_of_days;
        private DevExpress.XtraGrid.Columns.GridColumn colholiday_status_id;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creado;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl lblTotalDias;
    }
}