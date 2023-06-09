
namespace LOSA.ACS.RRHH.Informes
{
    partial class frmHomePlanillaCatorceavo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePlanillaCatorceavo));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsInformesRRHH1 = new LOSA.ACS.RRHH.Informes.dsInformesRRHH();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagoDecimoCuarto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrasDeduccionesCoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrasDeduccionesBancos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmoneda_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdPrintButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdPrintAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformesRRHH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintButton)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "catorceavo";
            this.gridControl1.DataSource = this.dsInformesRRHH1;
            this.gridControl1.Location = new System.Drawing.Point(12, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPrintButton});
            this.gridControl1.Size = new System.Drawing.Size(1337, 878);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsInformesRRHH1
            // 
            this.dsInformesRRHH1.DataSetName = "dsInformesRRHH";
            this.dsInformesRRHH1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colPuesto,
            this.colDepartamento,
            this.colFechaIngreso,
            this.colPagoDecimoCuarto,
            this.colOtrasDeduccionesCoop,
            this.colOtrasDeduccionesBancos,
            this.colTotalPagar,
            this.colid_moneda,
            this.colmoneda_name,
            this.colPrint});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.MinWidth = 40;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.ReadOnly = true;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 150;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 40;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 150;
            // 
            // colPuesto
            // 
            this.colPuesto.FieldName = "Puesto";
            this.colPuesto.MinWidth = 40;
            this.colPuesto.Name = "colPuesto";
            this.colPuesto.OptionsColumn.ReadOnly = true;
            this.colPuesto.Visible = true;
            this.colPuesto.VisibleIndex = 2;
            this.colPuesto.Width = 150;
            // 
            // colDepartamento
            // 
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.MinWidth = 40;
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.OptionsColumn.ReadOnly = true;
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 3;
            this.colDepartamento.Width = 150;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.MinWidth = 40;
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.OptionsColumn.ReadOnly = true;
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 4;
            this.colFechaIngreso.Width = 150;
            // 
            // colPagoDecimoCuarto
            // 
            this.colPagoDecimoCuarto.FieldName = "PagoDecimoCuarto";
            this.colPagoDecimoCuarto.MinWidth = 40;
            this.colPagoDecimoCuarto.Name = "colPagoDecimoCuarto";
            this.colPagoDecimoCuarto.OptionsColumn.ReadOnly = true;
            this.colPagoDecimoCuarto.Visible = true;
            this.colPagoDecimoCuarto.VisibleIndex = 5;
            this.colPagoDecimoCuarto.Width = 150;
            // 
            // colOtrasDeduccionesCoop
            // 
            this.colOtrasDeduccionesCoop.FieldName = "OtrasDeduccionesCoop";
            this.colOtrasDeduccionesCoop.MinWidth = 40;
            this.colOtrasDeduccionesCoop.Name = "colOtrasDeduccionesCoop";
            this.colOtrasDeduccionesCoop.OptionsColumn.ReadOnly = true;
            this.colOtrasDeduccionesCoop.Visible = true;
            this.colOtrasDeduccionesCoop.VisibleIndex = 6;
            this.colOtrasDeduccionesCoop.Width = 150;
            // 
            // colOtrasDeduccionesBancos
            // 
            this.colOtrasDeduccionesBancos.FieldName = "OtrasDeduccionesBancos";
            this.colOtrasDeduccionesBancos.MinWidth = 40;
            this.colOtrasDeduccionesBancos.Name = "colOtrasDeduccionesBancos";
            this.colOtrasDeduccionesBancos.OptionsColumn.ReadOnly = true;
            this.colOtrasDeduccionesBancos.Visible = true;
            this.colOtrasDeduccionesBancos.VisibleIndex = 7;
            this.colOtrasDeduccionesBancos.Width = 150;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.FieldName = "TotalPagar";
            this.colTotalPagar.MinWidth = 40;
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.OptionsColumn.ReadOnly = true;
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 8;
            this.colTotalPagar.Width = 150;
            // 
            // colid_moneda
            // 
            this.colid_moneda.FieldName = "id_moneda";
            this.colid_moneda.MinWidth = 40;
            this.colid_moneda.Name = "colid_moneda";
            this.colid_moneda.OptionsColumn.ReadOnly = true;
            this.colid_moneda.Width = 150;
            // 
            // colmoneda_name
            // 
            this.colmoneda_name.FieldName = "moneda_name";
            this.colmoneda_name.MinWidth = 40;
            this.colmoneda_name.Name = "colmoneda_name";
            this.colmoneda_name.OptionsColumn.ReadOnly = true;
            this.colmoneda_name.Visible = true;
            this.colmoneda_name.VisibleIndex = 9;
            this.colmoneda_name.Width = 150;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "Print";
            this.colPrint.ColumnEdit = this.cmdPrintButton;
            this.colPrint.MinWidth = 40;
            this.colPrint.Name = "colPrint";
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 10;
            this.colPrint.Width = 150;
            // 
            // cmdPrintButton
            // 
            this.cmdPrintButton.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.cmdPrintButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPrintButton.Name = "cmdPrintButton";
            this.cmdPrintButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdPrintButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdPrintButton_ButtonClick);
            // 
            // cmdPrintAll
            // 
            this.cmdPrintAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrintAll.ImageOptions.Image")));
            this.cmdPrintAll.Location = new System.Drawing.Point(12, 12);
            this.cmdPrintAll.Name = "cmdPrintAll";
            this.cmdPrintAll.Size = new System.Drawing.Size(273, 76);
            this.cmdPrintAll.TabIndex = 1;
            this.cmdPrintAll.Text = "Imprimir Todos";
            this.cmdPrintAll.Click += new System.EventHandler(this.cmdPrintAll_Click);
            // 
            // frmHomePlanillaCatorceavo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 984);
            this.Controls.Add(this.cmdPrintAll);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmHomePlanillaCatorceavo";
            this.Text = "Home Planilla Catorceavo";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformesRRHH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPrintButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsInformesRRHH dsInformesRRHH1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colPagoDecimoCuarto;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrasDeduccionesCoop;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrasDeduccionesBancos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colid_moneda;
        private DevExpress.XtraGrid.Columns.GridColumn colmoneda_name;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPrintButton;
        private DevExpress.XtraEditors.SimpleButton cmdPrintAll;
    }
}