namespace LOSA.MigracionACS.RRHH.RelojFace
{
    partial class frmResumenHorasSemanales_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenHorasSemanales_));
            this.dt_final = new DevExpress.XtraEditors.DateEdit();
            this.dt_inicial = new DevExpress.XtraEditors.DateEdit();
            this.lblFechas = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsFaceReloj1 = new LOSA.MigracionACS.RRHH.RelojFace.dsFaceReloj();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colroll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnexport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFaceReloj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_final
            // 
            this.dt_final.EditValue = null;
            this.dt_final.Location = new System.Drawing.Point(117, 48);
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
            this.dt_inicial.Location = new System.Drawing.Point(117, 7);
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
            this.lblFechas.Location = new System.Drawing.Point(5, 13);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(123, 21);
            this.lblFechas.TabIndex = 14;
            this.lblFechas.Text = "Fecha Inicial_____";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 54);
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
            this.simpleButton1.Location = new System.Drawing.Point(335, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 47);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Actualizar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "resumen_horas_semanales";
            this.gridControl1.DataSource = this.dsFaceReloj1;
            this.gridControl1.Location = new System.Drawing.Point(5, 81);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(975, 454);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsFaceReloj1
            // 
            this.dsFaceReloj1.DataSetName = "dsFaceReloj";
            this.dsFaceReloj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcodigo,
            this.colnombre,
            this.colroll,
            this.colsemana,
            this.coldom,
            this.collun,
            this.colmar,
            this.colmie,
            this.coljue,
            this.colvie,
            this.colsab,
            this.coldepartamento,
            this.coltotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 47;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 230;
            // 
            // colroll
            // 
            this.colroll.FieldName = "roll";
            this.colroll.Name = "colroll";
            // 
            // colsemana
            // 
            this.colsemana.FieldName = "semana";
            this.colsemana.Name = "colsemana";
            this.colsemana.Visible = true;
            this.colsemana.VisibleIndex = 3;
            this.colsemana.Width = 50;
            // 
            // coldom
            // 
            this.coldom.FieldName = "dom";
            this.coldom.Name = "coldom";
            this.coldom.Visible = true;
            this.coldom.VisibleIndex = 4;
            this.coldom.Width = 64;
            // 
            // collun
            // 
            this.collun.FieldName = "lun";
            this.collun.Name = "collun";
            this.collun.Visible = true;
            this.collun.VisibleIndex = 5;
            this.collun.Width = 64;
            // 
            // colmar
            // 
            this.colmar.FieldName = "mar";
            this.colmar.Name = "colmar";
            this.colmar.Visible = true;
            this.colmar.VisibleIndex = 6;
            this.colmar.Width = 64;
            // 
            // colmie
            // 
            this.colmie.FieldName = "mie";
            this.colmie.Name = "colmie";
            this.colmie.Visible = true;
            this.colmie.VisibleIndex = 7;
            this.colmie.Width = 64;
            // 
            // coljue
            // 
            this.coljue.FieldName = "jue";
            this.coljue.Name = "coljue";
            this.coljue.Visible = true;
            this.coljue.VisibleIndex = 8;
            this.coljue.Width = 64;
            // 
            // colvie
            // 
            this.colvie.FieldName = "vie";
            this.colvie.Name = "colvie";
            this.colvie.Visible = true;
            this.colvie.VisibleIndex = 9;
            this.colvie.Width = 64;
            // 
            // colsab
            // 
            this.colsab.FieldName = "sab";
            this.colsab.Name = "colsab";
            this.colsab.Visible = true;
            this.colsab.VisibleIndex = 10;
            // 
            // coldepartamento
            // 
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 2;
            this.coldepartamento.Width = 78;
            // 
            // coltotal
            // 
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 11;
            this.coltotal.Width = 86;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Appearance.Options.UseFont = true;
            this.btnexport.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px1;
            this.btnexport.Location = new System.Drawing.Point(834, 28);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(146, 47);
            this.btnexport.TabIndex = 20;
            this.btnexport.Text = "Exportar a excel";
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // frmResumenHorasSemanales_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 538);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dt_final);
            this.Controls.Add(this.dt_inicial);
            this.Controls.Add(this.lblFechas);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmResumenHorasSemanales_";
            this.Text = "Resumen Horas Semanales";
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFaceReloj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dt_final;
        private DevExpress.XtraEditors.DateEdit dt_inicial;
        private DevExpress.XtraEditors.LabelControl lblFechas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsFaceReloj dsFaceReloj1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colroll;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana;
        private DevExpress.XtraGrid.Columns.GridColumn coldom;
        private DevExpress.XtraGrid.Columns.GridColumn collun;
        private DevExpress.XtraGrid.Columns.GridColumn colmar;
        private DevExpress.XtraGrid.Columns.GridColumn colmie;
        private DevExpress.XtraGrid.Columns.GridColumn coljue;
        private DevExpress.XtraGrid.Columns.GridColumn colvie;
        private DevExpress.XtraGrid.Columns.GridColumn colsab;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraEditors.SimpleButton btnexport;
    }
}