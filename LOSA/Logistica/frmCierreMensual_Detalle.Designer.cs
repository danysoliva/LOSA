
namespace LOSA.Logistica
{
    partial class frmCierreMensual_Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreMensual_Detalle));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grd_data_d = new DevExpress.XtraGrid.GridControl();
            this.dsCierreMes1 = new LOSA.Logistica.dsCierreMes();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateria_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_lote_alosy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_header = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_conteo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_aprox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_fisica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryVerDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEjecutarContabilizacion = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVerDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_data_d
            // 
            this.grd_data_d.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data_d.DataMember = "recuentos_d";
            this.grd_data_d.DataSource = this.dsCierreMes1;
            this.grd_data_d.Location = new System.Drawing.Point(4, 67);
            this.grd_data_d.MainView = this.grdv_data;
            this.grd_data_d.Name = "grd_data_d";
            this.grd_data_d.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryVerDetalle});
            this.grd_data_d.Size = new System.Drawing.Size(1187, 623);
            this.grd_data_d.TabIndex = 4;
            this.grd_data_d.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsCierreMes1
            // 
            this.dsCierreMes1.DataSetName = "dsCierreMes";
            this.dsCierreMes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_mp,
            this.colcode_sap,
            this.colmateria_prima,
            this.colid_bodega,
            this.colbodega,
            this.collote,
            this.colid_lote_alosy,
            this.colid_header,
            this.colpeso,
            this.colFecha_conteo,
            this.coldiferencia_peso,
            this.colexistencia_aprox,
            this.colexistencia_fisica});
            this.grdv_data.GridControl = this.grd_data_d;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsBehavior.Editable = false;
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            // 
            // colmateria_prima
            // 
            this.colmateria_prima.Caption = "Materia Prima";
            this.colmateria_prima.FieldName = "materia_prima";
            this.colmateria_prima.Name = "colmateria_prima";
            this.colmateria_prima.Visible = true;
            this.colmateria_prima.VisibleIndex = 1;
            // 
            // colid_bodega
            // 
            this.colid_bodega.FieldName = "id_bodega";
            this.colid_bodega.Name = "colid_bodega";
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Bodega";
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 2;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.Visible = true;
            this.collote.VisibleIndex = 3;
            // 
            // colid_lote_alosy
            // 
            this.colid_lote_alosy.FieldName = "id_lote_alosy";
            this.colid_lote_alosy.Name = "colid_lote_alosy";
            // 
            // colid_header
            // 
            this.colid_header.FieldName = "id_header";
            this.colid_header.Name = "colid_header";
            // 
            // colpeso
            // 
            this.colpeso.Caption = "Nueva Cantidad";
            this.colpeso.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 4;
            // 
            // colFecha_conteo
            // 
            this.colFecha_conteo.FieldName = "Fecha_conteo";
            this.colFecha_conteo.Name = "colFecha_conteo";
            // 
            // coldiferencia_peso
            // 
            this.coldiferencia_peso.Caption = "Diferencia";
            this.coldiferencia_peso.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.coldiferencia_peso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldiferencia_peso.FieldName = "diferencia_peso";
            this.coldiferencia_peso.Name = "coldiferencia_peso";
            this.coldiferencia_peso.Visible = true;
            this.coldiferencia_peso.VisibleIndex = 5;
            // 
            // colexistencia_aprox
            // 
            this.colexistencia_aprox.Caption = "Existencia Anterior";
            this.colexistencia_aprox.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colexistencia_aprox.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_aprox.FieldName = "existencia_aprox";
            this.colexistencia_aprox.Name = "colexistencia_aprox";
            this.colexistencia_aprox.Visible = true;
            this.colexistencia_aprox.VisibleIndex = 6;
            // 
            // colexistencia_fisica
            // 
            this.colexistencia_fisica.Caption = "Toma Fisica";
            this.colexistencia_fisica.DisplayFormat.FormatString = "{0:0.##.##} Kg";
            this.colexistencia_fisica.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_fisica.FieldName = "existencia_fisica";
            this.colexistencia_fisica.Name = "colexistencia_fisica";
            this.colexistencia_fisica.Visible = true;
            this.colexistencia_fisica.VisibleIndex = 7;
            // 
            // repositoryVerDetalle
            // 
            this.repositoryVerDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryVerDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryVerDetalle.Name = "repositoryVerDetalle";
            this.repositoryVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.Location = new System.Drawing.Point(1099, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 47);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Cerrar";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(145, 1);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(111, 47);
            this.cmdExcel.TabIndex = 8;
            this.cmdExcel.Text = "Exportar";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmdEjecutarContabilizacion
            // 
            this.cmdEjecutarContabilizacion.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEjecutarContabilizacion.Appearance.Options.UseFont = true;
            this.cmdEjecutarContabilizacion.ImageOptions.Image = global::LOSA.Properties.Resources.production;
            this.cmdEjecutarContabilizacion.Location = new System.Drawing.Point(12, 2);
            this.cmdEjecutarContabilizacion.Name = "cmdEjecutarContabilizacion";
            this.cmdEjecutarContabilizacion.Size = new System.Drawing.Size(111, 47);
            this.cmdEjecutarContabilizacion.TabIndex = 9;
            this.cmdEjecutarContabilizacion.Text = "Exportar";
            // 
            // frmCierreMensual_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 693);
            this.Controls.Add(this.cmdEjecutarContabilizacion);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.grd_data_d);
            this.Controls.Add(this.btn_close);
            this.Name = "frmCierreMensual_Detalle";
            this.Text = "Detalle de Cierre";
            ((System.ComponentModel.ISupportInitialize)(this.grd_data_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCierreMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVerDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_data_d;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryVerDetalle;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private dsCierreMes dsCierreMes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colmateria_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_lote_alosy;
        private DevExpress.XtraGrid.Columns.GridColumn colid_header;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_conteo;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraGrid.Columns.GridColumn coldiferencia_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_aprox;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_fisica;
        private DevExpress.XtraEditors.SimpleButton cmdEjecutarContabilizacion;
    }
}