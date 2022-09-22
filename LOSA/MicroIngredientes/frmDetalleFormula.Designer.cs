
namespace LOSA.MicroIngredientes
{
    partial class frmDetalleFormula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleFormula));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMicros1 = new LOSA.MicroIngredientes.dsMicros();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_paradas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdSelecionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSelecionar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.cmdClose.Location = new System.Drawing.Point(790, 7);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 39);
            this.cmdClose.TabIndex = 11;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_formula";
            this.gridControl1.DataSource = this.dsMicros1;
            this.gridControl1.Location = new System.Drawing.Point(2, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdSelecionar});
            this.gridControl1.Size = new System.Drawing.Size(863, 495);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMicros1
            // 
            this.dsMicros1.DataSetName = "dsMicros";
            this.dsMicros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmp,
            this.colcode_sap,
            this.colnombre_comercial,
            this.colpeso_batch,
            this.coltotal,
            this.colcant_paradas,
            this.col_seleccionar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colmp
            // 
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.OptionsColumn.AllowShowHide = false;
            // 
            // colcode_sap
            // 
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.OptionsColumn.AllowShowHide = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 0;
            this.colcode_sap.Width = 69;
            // 
            // colnombre_comercial
            // 
            this.colnombre_comercial.FieldName = "nombre_comercial";
            this.colnombre_comercial.Name = "colnombre_comercial";
            this.colnombre_comercial.OptionsColumn.AllowEdit = false;
            this.colnombre_comercial.OptionsColumn.AllowShowHide = false;
            this.colnombre_comercial.Visible = true;
            this.colnombre_comercial.VisibleIndex = 1;
            this.colnombre_comercial.Width = 155;
            // 
            // colpeso_batch
            // 
            this.colpeso_batch.DisplayFormat.FormatString = "n2";
            this.colpeso_batch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso_batch.FieldName = "peso_batch";
            this.colpeso_batch.Name = "colpeso_batch";
            this.colpeso_batch.OptionsColumn.AllowEdit = false;
            this.colpeso_batch.OptionsColumn.AllowShowHide = false;
            this.colpeso_batch.Visible = true;
            this.colpeso_batch.VisibleIndex = 2;
            this.colpeso_batch.Width = 92;
            // 
            // coltotal
            // 
            this.coltotal.DisplayFormat.FormatString = "n2";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.OptionsColumn.AllowShowHide = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 4;
            this.coltotal.Width = 106;
            // 
            // colcant_paradas
            // 
            this.colcant_paradas.FieldName = "cant_paradas";
            this.colcant_paradas.Name = "colcant_paradas";
            this.colcant_paradas.OptionsColumn.AllowEdit = false;
            this.colcant_paradas.Visible = true;
            this.colcant_paradas.VisibleIndex = 3;
            this.colcant_paradas.Width = 62;
            // 
            // col_seleccionar
            // 
            this.col_seleccionar.Caption = "Seleccionar";
            this.col_seleccionar.ColumnEdit = this.cmdSelecionar;
            this.col_seleccionar.Name = "col_seleccionar";
            this.col_seleccionar.OptionsColumn.AllowShowHide = false;
            this.col_seleccionar.Visible = true;
            this.col_seleccionar.VisibleIndex = 5;
            this.col_seleccionar.Width = 115;
            // 
            // cmdSelecionar
            // 
            this.cmdSelecionar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdSelecionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdSelecionar.Name = "cmdSelecionar";
            this.cmdSelecionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdSelecionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdSelecionar_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listado de Materiales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lote:";
            // 
            // lblLote
            // 
            this.lblLote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(381, 33);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(80, 21);
            this.lblLote.TabIndex = 15;
            this.lblLote.Text = "00000";
            // 
            // frmDetalleFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 552);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdClose);
            this.Name = "frmDetalleFormula";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMicros1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSelecionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private dsMicros dsMicros1;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_batch;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_paradas;
        private DevExpress.XtraGrid.Columns.GridColumn col_seleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdSelecionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLote;
    }
}