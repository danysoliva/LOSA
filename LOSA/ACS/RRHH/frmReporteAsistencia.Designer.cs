
namespace LOSA.ACS.RRHH
{
    partial class frmReporteAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteAsistencia));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRRHH_reportes1 = new LOSA.ACS.RRHH.dsRRHH_reportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturno_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_lunes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_lunes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_martes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_martes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_miercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_miercoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_jueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_jueves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_viernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_viernes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_sabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_sabado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada_domingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_domingo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dt_final = new DevExpress.XtraEditors.DateEdit();
            this.dt_inicial = new DevExpress.XtraEditors.DateEdit();
            this.lblFechas = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnexport = new DevExpress.XtraEditors.SimpleButton();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_reportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "resumen_asistencia";
            this.gridControl1.DataSource = this.dsRRHH_reportes1;
            this.gridControl1.Location = new System.Drawing.Point(2, 101);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1126, 410);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRRHH_reportes1
            // 
            this.dsRRHH_reportes1.DataSetName = "dsRRHH_reportes";
            this.dsRRHH_reportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_marca,
            this.colid_emp,
            this.colcodigo,
            this.colnombre,
            this.colturno_id,
            this.colturno_name,
            this.coldepartamento,
            this.coldesde,
            this.colhasta,
            this.colsemana,
            this.colentrada_lunes,
            this.colsalida_lunes,
            this.colentrada_martes,
            this.colsalida_martes,
            this.colentrada_miercoles,
            this.colsalida_miercoles,
            this.colentrada_jueves,
            this.colsalida_jueves,
            this.colentrada_viernes,
            this.colsalida_viernes,
            this.colentrada_sabado,
            this.colsalida_sabado,
            this.colentrada_domingo,
            this.colsalida_domingo,
            this.colStartOfWeek,
            this.colEndOfWeek});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid_marca
            // 
            this.colid_marca.FieldName = "id_marca";
            this.colid_marca.Name = "colid_marca";
            this.colid_marca.OptionsColumn.AllowEdit = false;
            // 
            // colid_emp
            // 
            this.colid_emp.FieldName = "id_emp";
            this.colid_emp.Name = "colid_emp";
            this.colid_emp.OptionsColumn.AllowEdit = false;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 35;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 131;
            // 
            // colturno_id
            // 
            this.colturno_id.FieldName = "turno_id";
            this.colturno_id.Name = "colturno_id";
            this.colturno_id.OptionsColumn.AllowEdit = false;
            // 
            // colturno_name
            // 
            this.colturno_name.FieldName = "turno_name";
            this.colturno_name.Name = "colturno_name";
            this.colturno_name.OptionsColumn.AllowEdit = false;
            this.colturno_name.Width = 42;
            // 
            // coldesde
            // 
            this.coldesde.DisplayFormat.FormatString = "d";
            this.coldesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldesde.FieldName = "desde";
            this.coldesde.Name = "coldesde";
            this.coldesde.OptionsColumn.AllowEdit = false;
            this.coldesde.Width = 64;
            // 
            // colhasta
            // 
            this.colhasta.DisplayFormat.FormatString = "d";
            this.colhasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhasta.FieldName = "hasta";
            this.colhasta.Name = "colhasta";
            this.colhasta.OptionsColumn.AllowEdit = false;
            this.colhasta.Width = 58;
            // 
            // colsemana
            // 
            this.colsemana.FieldName = "semana";
            this.colsemana.Name = "colsemana";
            this.colsemana.OptionsColumn.AllowEdit = false;
            this.colsemana.Width = 26;
            // 
            // colentrada_lunes
            // 
            this.colentrada_lunes.DisplayFormat.FormatString = "g";
            this.colentrada_lunes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_lunes.FieldName = "entrada_lunes";
            this.colentrada_lunes.Name = "colentrada_lunes";
            this.colentrada_lunes.OptionsColumn.AllowEdit = false;
            this.colentrada_lunes.Visible = true;
            this.colentrada_lunes.VisibleIndex = 5;
            this.colentrada_lunes.Width = 52;
            // 
            // colsalida_lunes
            // 
            this.colsalida_lunes.DisplayFormat.FormatString = "g";
            this.colsalida_lunes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_lunes.FieldName = "salida_lunes";
            this.colsalida_lunes.Name = "colsalida_lunes";
            this.colsalida_lunes.OptionsColumn.AllowEdit = false;
            this.colsalida_lunes.Visible = true;
            this.colsalida_lunes.VisibleIndex = 6;
            this.colsalida_lunes.Width = 47;
            // 
            // colentrada_martes
            // 
            this.colentrada_martes.DisplayFormat.FormatString = "g";
            this.colentrada_martes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_martes.FieldName = "entrada_martes";
            this.colentrada_martes.Name = "colentrada_martes";
            this.colentrada_martes.OptionsColumn.AllowEdit = false;
            this.colentrada_martes.Visible = true;
            this.colentrada_martes.VisibleIndex = 7;
            this.colentrada_martes.Width = 49;
            // 
            // colsalida_martes
            // 
            this.colsalida_martes.DisplayFormat.FormatString = "g";
            this.colsalida_martes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_martes.FieldName = "salida_martes";
            this.colsalida_martes.Name = "colsalida_martes";
            this.colsalida_martes.OptionsColumn.AllowEdit = false;
            this.colsalida_martes.Visible = true;
            this.colsalida_martes.VisibleIndex = 8;
            this.colsalida_martes.Width = 47;
            // 
            // colentrada_miercoles
            // 
            this.colentrada_miercoles.DisplayFormat.FormatString = "g";
            this.colentrada_miercoles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_miercoles.FieldName = "entrada_miercoles";
            this.colentrada_miercoles.Name = "colentrada_miercoles";
            this.colentrada_miercoles.OptionsColumn.AllowEdit = false;
            this.colentrada_miercoles.Visible = true;
            this.colentrada_miercoles.VisibleIndex = 9;
            this.colentrada_miercoles.Width = 46;
            // 
            // colsalida_miercoles
            // 
            this.colsalida_miercoles.DisplayFormat.FormatString = "g";
            this.colsalida_miercoles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_miercoles.FieldName = "salida_miercoles";
            this.colsalida_miercoles.Name = "colsalida_miercoles";
            this.colsalida_miercoles.OptionsColumn.AllowEdit = false;
            this.colsalida_miercoles.Visible = true;
            this.colsalida_miercoles.VisibleIndex = 10;
            this.colsalida_miercoles.Width = 58;
            // 
            // colentrada_jueves
            // 
            this.colentrada_jueves.DisplayFormat.FormatString = "g";
            this.colentrada_jueves.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_jueves.FieldName = "entrada_jueves";
            this.colentrada_jueves.Name = "colentrada_jueves";
            this.colentrada_jueves.OptionsColumn.AllowEdit = false;
            this.colentrada_jueves.Visible = true;
            this.colentrada_jueves.VisibleIndex = 11;
            this.colentrada_jueves.Width = 56;
            // 
            // colsalida_jueves
            // 
            this.colsalida_jueves.DisplayFormat.FormatString = "g";
            this.colsalida_jueves.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_jueves.FieldName = "salida_jueves";
            this.colsalida_jueves.Name = "colsalida_jueves";
            this.colsalida_jueves.OptionsColumn.AllowEdit = false;
            this.colsalida_jueves.Visible = true;
            this.colsalida_jueves.VisibleIndex = 12;
            this.colsalida_jueves.Width = 59;
            // 
            // colentrada_viernes
            // 
            this.colentrada_viernes.DisplayFormat.FormatString = "g";
            this.colentrada_viernes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_viernes.FieldName = "entrada_viernes";
            this.colentrada_viernes.Name = "colentrada_viernes";
            this.colentrada_viernes.OptionsColumn.AllowEdit = false;
            this.colentrada_viernes.Visible = true;
            this.colentrada_viernes.VisibleIndex = 13;
            this.colentrada_viernes.Width = 56;
            // 
            // colsalida_viernes
            // 
            this.colsalida_viernes.DisplayFormat.FormatString = "g";
            this.colsalida_viernes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_viernes.FieldName = "salida_viernes";
            this.colsalida_viernes.Name = "colsalida_viernes";
            this.colsalida_viernes.OptionsColumn.AllowEdit = false;
            this.colsalida_viernes.Visible = true;
            this.colsalida_viernes.VisibleIndex = 14;
            this.colsalida_viernes.Width = 49;
            // 
            // colentrada_sabado
            // 
            this.colentrada_sabado.DisplayFormat.FormatString = "g";
            this.colentrada_sabado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_sabado.FieldName = "entrada_sabado";
            this.colentrada_sabado.Name = "colentrada_sabado";
            this.colentrada_sabado.OptionsColumn.AllowEdit = false;
            this.colentrada_sabado.Visible = true;
            this.colentrada_sabado.VisibleIndex = 15;
            this.colentrada_sabado.Width = 46;
            // 
            // colsalida_sabado
            // 
            this.colsalida_sabado.DisplayFormat.FormatString = "g";
            this.colsalida_sabado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_sabado.FieldName = "salida_sabado";
            this.colsalida_sabado.Name = "colsalida_sabado";
            this.colsalida_sabado.OptionsColumn.AllowEdit = false;
            this.colsalida_sabado.Visible = true;
            this.colsalida_sabado.VisibleIndex = 16;
            this.colsalida_sabado.Width = 50;
            // 
            // colentrada_domingo
            // 
            this.colentrada_domingo.DisplayFormat.FormatString = "g";
            this.colentrada_domingo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colentrada_domingo.FieldName = "entrada_domingo";
            this.colentrada_domingo.Name = "colentrada_domingo";
            this.colentrada_domingo.OptionsColumn.AllowEdit = false;
            this.colentrada_domingo.Visible = true;
            this.colentrada_domingo.VisibleIndex = 17;
            this.colentrada_domingo.Width = 55;
            // 
            // colsalida_domingo
            // 
            this.colsalida_domingo.DisplayFormat.FormatString = "g";
            this.colsalida_domingo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsalida_domingo.FieldName = "salida_domingo";
            this.colsalida_domingo.Name = "colsalida_domingo";
            this.colsalida_domingo.OptionsColumn.AllowEdit = false;
            this.colsalida_domingo.Visible = true;
            this.colsalida_domingo.VisibleIndex = 18;
            this.colsalida_domingo.Width = 82;
            // 
            // dt_final
            // 
            this.dt_final.EditValue = null;
            this.dt_final.Location = new System.Drawing.Point(119, 47);
            this.dt_final.Name = "dt_final";
            this.dt_final.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_final.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_final.Properties.Appearance.Options.UseFont = true;
            this.dt_final.Properties.Appearance.Options.UseForeColor = true;
            this.dt_final.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_final.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_final.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_final.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_final.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_final.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_final.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_final.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_final.Size = new System.Drawing.Size(212, 26);
            this.dt_final.TabIndex = 18;
            // 
            // dt_inicial
            // 
            this.dt_inicial.EditValue = null;
            this.dt_inicial.Location = new System.Drawing.Point(119, 19);
            this.dt_inicial.Name = "dt_inicial";
            this.dt_inicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_inicial.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_inicial.Properties.Appearance.Options.UseFont = true;
            this.dt_inicial.Properties.Appearance.Options.UseForeColor = true;
            this.dt_inicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_inicial.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_inicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_inicial.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_inicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_inicial.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_inicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_inicial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_inicial.Size = new System.Drawing.Size(212, 26);
            this.dt_inicial.TabIndex = 17;
            // 
            // lblFechas
            // 
            this.lblFechas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechas.Appearance.Options.UseFont = true;
            this.lblFechas.Location = new System.Drawing.Point(7, 20);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(123, 21);
            this.lblFechas.TabIndex = 14;
            this.lblFechas.Text = "Fecha Inicial_____";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 21);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Fecha Final_____";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(346, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 47);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Generar reporte";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnexport
            // 
            this.btnexport.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Appearance.Options.UseFont = true;
            this.btnexport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.ImageOptions.Image")));
            this.btnexport.Location = new System.Drawing.Point(495, 26);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(146, 47);
            this.btnexport.TabIndex = 19;
            this.btnexport.Text = "Exportar a excel";
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 2;
            this.coldepartamento.Width = 68;
            // 
            // colStartOfWeek
            // 
            this.colStartOfWeek.FieldName = "StartOfWeek";
            this.colStartOfWeek.Name = "colStartOfWeek";
            this.colStartOfWeek.OptionsColumn.AllowEdit = false;
            this.colStartOfWeek.Visible = true;
            this.colStartOfWeek.VisibleIndex = 3;
            // 
            // colEndOfWeek
            // 
            this.colEndOfWeek.FieldName = "EndOfWeek";
            this.colEndOfWeek.Name = "colEndOfWeek";
            this.colEndOfWeek.OptionsColumn.AllowEdit = false;
            this.colEndOfWeek.Visible = true;
            this.colEndOfWeek.VisibleIndex = 4;
            // 
            // frmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 514);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dt_final);
            this.Controls.Add(this.dt_inicial);
            this.Controls.Add(this.lblFechas);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmReporteAsistencia";
            this.Text = "Resumen Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRRHH_reportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsRRHH_reportes dsRRHH_reportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_marca;
        private DevExpress.XtraGrid.Columns.GridColumn colid_emp;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_id;
        private DevExpress.XtraGrid.Columns.GridColumn colturno_name;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_lunes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_lunes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_martes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_martes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_miercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_miercoles;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_jueves;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_jueves;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_viernes;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_viernes;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_sabado;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_sabado;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada_domingo;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_domingo;
        private DevExpress.XtraGrid.Columns.GridColumn coldesde;
        private DevExpress.XtraGrid.Columns.GridColumn colhasta;
        private DevExpress.XtraEditors.DateEdit dt_final;
        private DevExpress.XtraEditors.DateEdit dt_inicial;
        private DevExpress.XtraEditors.LabelControl lblFechas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnexport;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colStartOfWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colEndOfWeek;
    }
}