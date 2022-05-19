
namespace LOSA.Produccion
{
    partial class frmrptMpEntregadaaProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrptMpEntregadaaProduccion));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.dthasta = new DevExpress.XtraEditors.DateEdit();
            this.dtdesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsProduccion = new LOSA.Produccion.dsProduccion();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_entregada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_unidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.ImageOptions.Image")));
            this.cmdHome.Location = new System.Drawing.Point(1141, 6);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(145, 42);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // dthasta
            // 
            this.dthasta.EditValue = null;
            this.dthasta.Location = new System.Drawing.Point(89, 41);
            this.dthasta.Name = "dthasta";
            this.dthasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dthasta.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dthasta.Properties.Appearance.Options.UseFont = true;
            this.dthasta.Properties.Appearance.Options.UseForeColor = true;
            this.dthasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dthasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dthasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dthasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dthasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dthasta.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dthasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dthasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dthasta.Size = new System.Drawing.Size(273, 22);
            this.dthasta.TabIndex = 11;
            // 
            // dtdesde
            // 
            this.dtdesde.EditValue = null;
            this.dtdesde.Location = new System.Drawing.Point(89, 12);
            this.dtdesde.Name = "dtdesde";
            this.dtdesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdesde.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dtdesde.Properties.Appearance.Options.UseFont = true;
            this.dtdesde.Properties.Appearance.Options.UseForeColor = true;
            this.dtdesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtdesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtdesde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtdesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtdesde.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dtdesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtdesde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtdesde.Size = new System.Drawing.Size(273, 22);
            this.dtdesde.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Fecha desde:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.ImageOptions.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(380, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(167, 51);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "reporteP";
            this.grd_data.DataSource = this.dsProduccion;
            this.grd_data.Location = new System.Drawing.Point(1, 69);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(1286, 660);
            this.grd_data.TabIndex = 13;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsProduccion
            // 
            this.dsProduccion.DataSetName = "dsProduccion";
            this.dsProduccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbarcode,
            this.colcodigo,
            this.colcode_sap,
            this.colnombre_comercial,
            this.colcantidad_entregada,
            this.colcantidad_unidades,
            this.colfecha,
            this.colcodigo_barra,
            this.colDocEntry});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Requisa";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 0;
            this.colbarcode.Width = 140;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "C. Produccion";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.AllowEdit = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 140;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "C. Sap";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 2;
            this.colcode_sap.Width = 140;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.Caption = "MP";
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 3;
            this.colnombre_comercial.Width = 140;
            // 
            // colcantidad_entregada
            // 
            this.colcantidad_entregada.Caption = "Cantidad Entregada Kg";
            this.colcantidad_entregada.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.colcantidad_entregada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_entregada.FieldName = "cantidad_entregada";
            this.colcantidad_entregada.Name = "colcantidad_entregada";
            this.colcantidad_entregada.OptionsColumn.AllowEdit = false;
            this.colcantidad_entregada.Visible = true;
            this.colcantidad_entregada.VisibleIndex = 7;
            this.colcantidad_entregada.Width = 170;
            // 
            // colcantidad_unidades
            // 
            this.colcantidad_unidades.Caption = "Cantidad Unidades";
            this.colcantidad_unidades.DisplayFormat.FormatString = "{0:0.##.##} Ud.";
            this.colcantidad_unidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcantidad_unidades.FieldName = "cantidad_unidades";
            this.colcantidad_unidades.Name = "colcantidad_unidades";
            this.colcantidad_unidades.OptionsColumn.AllowEdit = false;
            this.colcantidad_unidades.Visible = true;
            this.colcantidad_unidades.VisibleIndex = 8;
            this.colcantidad_unidades.Width = 158;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha Entrega";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 4;
            this.colfecha.Width = 123;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Tarima";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 6;
            this.colcodigo_barra.Width = 123;
            // 
            // colDocEntry
            // 
            this.colDocEntry.Caption = "SAP orden";
            this.colDocEntry.FieldName = "DocEntry";
            this.colDocEntry.Name = "colDocEntry";
            this.colDocEntry.OptionsColumn.AllowEdit = false;
            this.colDocEntry.Visible = true;
            this.colDocEntry.VisibleIndex = 5;
            this.colDocEntry.Width = 134;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(553, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(167, 51);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Exportar Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmrptMpEntregadaaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 726);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dthasta);
            this.Controls.Add(this.dtdesde);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmrptMpEntregadaaProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmrptMpEntregadaaProduccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dthasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.DateEdit dthasta;
        private DevExpress.XtraEditors.DateEdit dtdesde;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraGrid.GridControl grd_data;
        private dsProduccion dsProduccion;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_entregada;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_unidades;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntry;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}