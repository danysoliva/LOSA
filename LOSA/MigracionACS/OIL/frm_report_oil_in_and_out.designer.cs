namespace LOSA.MigracionACS.OIL
{
    partial class frm_report_oil_in_and_out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_report_oil_in_and_out));
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsAceites = new MigracionACS.OIL.dsAceites();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrasladado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarriba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipomaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplanbatchkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrealbatchkg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colteoricobatchformula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferenciakg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalreal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombrematerial = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = new System.DateTime(((long)(0)));
            this.dtHasta.Location = new System.Drawing.Point(336, 59);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 13;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = new System.DateTime(((long)(0)));
            this.dtDesde.Location = new System.Drawing.Point(103, 59);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(257, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Fecha Hasta:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Fecha Desde:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 30);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Generar Reporte";
            // 
            // cmdExportar
            // 
            this.cmdExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.ImageOptions.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(939, 12);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(116, 39);
            this.cmdExportar.TabIndex = 16;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // CargarDatos
            // 
            this.CargarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(796, 12);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 15;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "oilmaster";
            this.grd_data.DataSource = this.dsAceites;
            this.grd_data.Location = new System.Drawing.Point(-1, 118);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1069, 620);
            this.grd_data.TabIndex = 17;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsAceites
            // 
            this.dsAceites.DataSetName = "dsAceites";
            this.dsAceites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrasladado,
            this.colarriba,
            this.colcodigomaterial,
            this.coltipomaterial,
            this.colplanbatchkg,
            this.colrealbatchkg,
            this.colteoricobatchformula,
            this.coldiferenciakg,
            this.gridColumn1,
            this.colTotalreal,
            this.colnombrematerial});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colTrasladado
            // 
            this.colTrasladado.Caption = "De Logistica a Producción";
            this.colTrasladado.FieldName = "Trasladado";
            this.colTrasladado.Name = "colTrasladado";
            this.colTrasladado.OptionsColumn.AllowEdit = false;
            this.colTrasladado.Visible = true;
            this.colTrasladado.VisibleIndex = 3;
            // 
            // colarriba
            // 
            this.colarriba.Caption = "Enviado a Post Pellet";
            this.colarriba.FieldName = "arriba";
            this.colarriba.Name = "colarriba";
            this.colarriba.OptionsColumn.AllowEdit = false;
            this.colarriba.Visible = true;
            this.colarriba.VisibleIndex = 4;
            // 
            // colcodigomaterial
            // 
            this.colcodigomaterial.Caption = "Codigo Material";
            this.colcodigomaterial.FieldName = "codigo material";
            this.colcodigomaterial.Name = "colcodigomaterial";
            this.colcodigomaterial.OptionsColumn.AllowEdit = false;
            this.colcodigomaterial.Visible = true;
            this.colcodigomaterial.VisibleIndex = 0;
            // 
            // coltipomaterial
            // 
            this.coltipomaterial.Caption = "Tipo Material";
            this.coltipomaterial.FieldName = "tipo material";
            this.coltipomaterial.Name = "coltipomaterial";
            this.coltipomaterial.OptionsColumn.AllowEdit = false;
            this.coltipomaterial.Visible = true;
            this.coltipomaterial.VisibleIndex = 2;
            // 
            // colplanbatchkg
            // 
            this.colplanbatchkg.Caption = "Plan batch Kg";
            this.colplanbatchkg.FieldName = "plan batch kg";
            this.colplanbatchkg.Name = "colplanbatchkg";
            this.colplanbatchkg.OptionsColumn.AllowEdit = false;
            // 
            // colrealbatchkg
            // 
            this.colrealbatchkg.Caption = "Consumo en Mezcla";
            this.colrealbatchkg.FieldName = "real batch kg";
            this.colrealbatchkg.Name = "colrealbatchkg";
            this.colrealbatchkg.OptionsColumn.AllowEdit = false;
            this.colrealbatchkg.Visible = true;
            this.colrealbatchkg.VisibleIndex = 5;
            // 
            // colteoricobatchformula
            // 
            this.colteoricobatchformula.Caption = "Teorico batch formula";
            this.colteoricobatchformula.FieldName = "teorico batch formula";
            this.colteoricobatchformula.Name = "colteoricobatchformula";
            this.colteoricobatchformula.OptionsColumn.AllowEdit = false;
            this.colteoricobatchformula.Visible = true;
            this.colteoricobatchformula.VisibleIndex = 7;
            // 
            // coldiferenciakg
            // 
            this.coldiferenciakg.Caption = "Diferencia Kg";
            this.coldiferenciakg.FieldName = "diferencia kg";
            this.coldiferenciakg.Name = "coldiferenciakg";
            this.coldiferenciakg.OptionsColumn.AllowEdit = false;
            this.coldiferenciakg.Visible = true;
            this.coldiferenciakg.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Diferencia %";
            this.gridColumn1.FieldName = "diferencia %";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // colTotalreal
            // 
            this.colTotalreal.Caption = "Total Real Batch";
            this.colTotalreal.FieldName = "Totalreal";
            this.colTotalreal.Name = "colTotalreal";
            this.colTotalreal.Visible = true;
            this.colTotalreal.VisibleIndex = 6;
            // 
            // colnombrematerial
            // 
            this.colnombrematerial.Caption = "Nombre MP";
            this.colnombrematerial.FieldName = "nombre material";
            this.colnombrematerial.Name = "colnombrematerial";
            this.colnombrematerial.OptionsColumn.AllowEdit = false;
            this.colnombrematerial.Visible = true;
            this.colnombrematerial.VisibleIndex = 1;
            // 
            // frm_report_oil_in_and_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 739);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_report_oil_in_and_out";
            this.Text = "Reporte de traslado de aceite comparativo";
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private dsAceites dsAceites;
        private DevExpress.XtraGrid.Columns.GridColumn colTrasladado;
        private DevExpress.XtraGrid.Columns.GridColumn colarriba;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigomaterial;
        private DevExpress.XtraGrid.Columns.GridColumn coltipomaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colplanbatchkg;
        private DevExpress.XtraGrid.Columns.GridColumn colrealbatchkg;
        private DevExpress.XtraGrid.Columns.GridColumn colteoricobatchformula;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferenciakg;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombrematerial;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalreal;
    }
}