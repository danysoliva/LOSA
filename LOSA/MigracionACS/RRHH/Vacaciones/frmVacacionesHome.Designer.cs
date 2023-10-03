namespace LOSA.MigracionACS.RRHH.Vacaciones
{
    partial class frmVacacionesHome
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacacionesHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesVacaciones1 = new LOSA.MigracionACS.RRHH.Vacaciones.dsReportesVacaciones();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_cumplidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_tomados_stand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_odoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_pendientes_stand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerDetalles = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesVacaciones1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "resumen_vacaciones";
            this.gridControl1.DataSource = this.dsReportesVacaciones1;
            this.gridControl1.Location = new System.Drawing.Point(2, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerDetalles});
            this.gridControl1.Size = new System.Drawing.Size(852, 365);
            this.gridControl1.TabIndex = 0;
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
            this.colid,
            this.colcodigo,
            this.colname,
            this.coldias_cumplidos,
            this.coldias_tomados_stand,
            this.coldias_odoo,
            this.coldias_pendientes_stand,
            this.colDetalles});
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
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 54;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 196;
            // 
            // coldias_cumplidos
            // 
            this.coldias_cumplidos.DisplayFormat.FormatString = "n1";
            this.coldias_cumplidos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_cumplidos.FieldName = "dias_cumplidos";
            this.coldias_cumplidos.Name = "coldias_cumplidos";
            this.coldias_cumplidos.OptionsColumn.ReadOnly = true;
            this.coldias_cumplidos.Visible = true;
            this.coldias_cumplidos.VisibleIndex = 2;
            this.coldias_cumplidos.Width = 100;
            // 
            // coldias_tomados_stand
            // 
            this.coldias_tomados_stand.DisplayFormat.FormatString = "n1";
            this.coldias_tomados_stand.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_tomados_stand.FieldName = "dias_tomados_stand";
            this.coldias_tomados_stand.Name = "coldias_tomados_stand";
            this.coldias_tomados_stand.OptionsColumn.ReadOnly = true;
            this.coldias_tomados_stand.Visible = true;
            this.coldias_tomados_stand.VisibleIndex = 3;
            this.coldias_tomados_stand.Width = 85;
            // 
            // coldias_odoo
            // 
            this.coldias_odoo.DisplayFormat.FormatString = "n1";
            this.coldias_odoo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_odoo.FieldName = "dias_odoo";
            this.coldias_odoo.Name = "coldias_odoo";
            this.coldias_odoo.OptionsColumn.ReadOnly = true;
            this.coldias_odoo.Visible = true;
            this.coldias_odoo.VisibleIndex = 4;
            this.coldias_odoo.Width = 85;
            // 
            // coldias_pendientes_stand
            // 
            this.coldias_pendientes_stand.DisplayFormat.FormatString = "n1";
            this.coldias_pendientes_stand.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_pendientes_stand.FieldName = "dias_pendientes_stand";
            this.coldias_pendientes_stand.Name = "coldias_pendientes_stand";
            this.coldias_pendientes_stand.OptionsColumn.ReadOnly = true;
            this.coldias_pendientes_stand.Visible = true;
            this.coldias_pendientes_stand.VisibleIndex = 5;
            this.coldias_pendientes_stand.Width = 85;
            // 
            // colDetalles
            // 
            this.colDetalles.Caption = "Ver Detalles";
            this.colDetalles.ColumnEdit = this.cmdVerDetalles;
            this.colDetalles.Name = "colDetalles";
            this.colDetalles.Visible = true;
            this.colDetalles.VisibleIndex = 6;
            this.colDetalles.Width = 91;
            // 
            // cmdVerDetalles
            // 
            this.cmdVerDetalles.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdVerDetalles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerDetalles.Name = "cmdVerDetalles";
            this.cmdVerDetalles.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerDetalles.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerDetalles_ButtonClick);
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
            this.cmdExportar.Location = new System.Drawing.Point(628, 5);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(110, 36);
            this.cmdExportar.TabIndex = 19;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Click += new System.EventHandler(this.cmdConfirmar_Click);
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
            this.cmdCerrar.Location = new System.Drawing.Point(744, 5);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 36);
            this.cmdCerrar.TabIndex = 18;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarDatos.Appearance.Options.UseBackColor = true;
            this.cmdCargarDatos.Appearance.Options.UseFont = true;
            this.cmdCargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargarDatos.ImageOptions.Image")));
            this.cmdCargarDatos.Location = new System.Drawing.Point(2, 6);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(110, 36);
            this.cmdCargarDatos.TabIndex = 20;
            this.cmdCargarDatos.Text = "Cargar ";
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // frmVacacionesHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 414);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmVacacionesHome";
            this.Text = "Reporte de saldos de vacaciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesVacaciones1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private dsReportesVacaciones dsReportesVacaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_cumplidos;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_tomados_stand;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_odoo;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_pendientes_stand;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerDetalles;
    }
}