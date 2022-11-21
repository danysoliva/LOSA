namespace LOSA.MigracionACS.Produccion.Reports
{
    partial class frmSacosPorLote
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
            this.components = new System.ComponentModel.Container();
            this.cmdExcel = new System.Windows.Forms.Button();
            this.cmdCargarDatos = new System.Windows.Forms.Button();
            this.groupBoxFechas = new System.Windows.Forms.GroupBox();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLookUpEditListadoReportes = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportesPRD1 = new LOSA.MigracionACS.Produccion.DataSet_.dsReportesPRD();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstored_procedure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNumOrdenMix = new System.Windows.Forms.GroupBox();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.groupBoxFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditListadoReportes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesPRD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBoxNumOrdenMix.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExcel
            // 
            this.cmdExcel.BackColor = System.Drawing.Color.White;
            this.cmdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.Location = new System.Drawing.Point(802, 5);
            this.cmdExcel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(104, 55);
            this.cmdExcel.TabIndex = 17;
            this.cmdExcel.Text = "Excel";
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExcel.UseVisualStyleBackColor = false;
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmdCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarDatos.Image = global::LOSA.Properties.Resources.refresh_32x32;
            this.cmdCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCargarDatos.Location = new System.Drawing.Point(664, 5);
            this.cmdCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(131, 56);
            this.cmdCargarDatos.TabIndex = 15;
            this.cmdCargarDatos.Text = "Cargar Datos";
            this.cmdCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCargarDatos.UseVisualStyleBackColor = false;
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // groupBoxFechas
            // 
            this.groupBoxFechas.Controls.Add(this.dtHasta);
            this.groupBoxFechas.Controls.Add(this.dtDesde);
            this.groupBoxFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechas.Location = new System.Drawing.Point(426, 21);
            this.groupBoxFechas.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFechas.Name = "groupBoxFechas";
            this.groupBoxFechas.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFechas.Size = new System.Drawing.Size(235, 41);
            this.groupBoxFechas.TabIndex = 14;
            this.groupBoxFechas.TabStop = false;
            this.groupBoxFechas.Text = "Rango de Fechas";
            this.groupBoxFechas.Visible = false;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(120, 15);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(113, 22);
            this.dtHasta.TabIndex = 1;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(5, 15);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(113, 22);
            this.dtDesde.TabIndex = 0;
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grDetalle.Location = new System.Drawing.Point(3, 66);
            this.grDetalle.MainView = this.gridView1;
            this.grDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.Size = new System.Drawing.Size(903, 506);
            this.grDetalle.TabIndex = 13;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grDetalle;
            this.gridView1.Name = "gridView1";
            // 
            // gridLookUpEditListadoReportes
            // 
            this.gridLookUpEditListadoReportes.EditValue = "Seleccione el reporte";
            this.gridLookUpEditListadoReportes.Location = new System.Drawing.Point(9, 37);
            this.gridLookUpEditListadoReportes.Name = "gridLookUpEditListadoReportes";
            this.gridLookUpEditListadoReportes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditListadoReportes.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditListadoReportes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditListadoReportes.Properties.DataSource = this.bindingSource1;
            this.gridLookUpEditListadoReportes.Properties.DisplayMember = "descripcion";
            this.gridLookUpEditListadoReportes.Properties.ValueMember = "id";
            this.gridLookUpEditListadoReportes.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEditListadoReportes.Size = new System.Drawing.Size(268, 20);
            this.gridLookUpEditListadoReportes.TabIndex = 18;
            this.gridLookUpEditListadoReportes.EditValueChanged += new System.EventHandler(this.gridLookUpEditListadoReportes_EditValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "listado_reportes";
            this.bindingSource1.DataSource = this.dsReportesPRD1;
            // 
            // dsReportesPRD1
            // 
            this.dsReportesPRD1.DataSetName = "dsReportesPRD";
            this.dsReportesPRD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colstored_procedure});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colstored_procedure
            // 
            this.colstored_procedure.FieldName = "stored_procedure";
            this.colstored_procedure.Name = "colstored_procedure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reporte";
            // 
            // groupBoxNumOrdenMix
            // 
            this.groupBoxNumOrdenMix.Controls.Add(this.txtNumeroOrden);
            this.groupBoxNumOrdenMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNumOrdenMix.Location = new System.Drawing.Point(289, 21);
            this.groupBoxNumOrdenMix.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNumOrdenMix.Name = "groupBoxNumOrdenMix";
            this.groupBoxNumOrdenMix.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNumOrdenMix.Size = new System.Drawing.Size(134, 41);
            this.groupBoxNumOrdenMix.TabIndex = 20;
            this.groupBoxNumOrdenMix.TabStop = false;
            this.groupBoxNumOrdenMix.Text = "Numero Orden";
            this.groupBoxNumOrdenMix.Visible = false;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrden.Location = new System.Drawing.Point(6, 15);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(123, 21);
            this.txtNumeroOrden.TabIndex = 0;
            this.txtNumeroOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroOrden_KeyPress);
            // 
            // frmSacosPorLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 575);
            this.Controls.Add(this.groupBoxNumOrdenMix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridLookUpEditListadoReportes);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.groupBoxFechas);
            this.Controls.Add(this.grDetalle);
            this.Name = "frmSacosPorLote";
            this.Text = "Sacos Por Lote";
            this.groupBoxFechas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditListadoReportes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesPRD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBoxNumOrdenMix.ResumeLayout(false);
            this.groupBoxNumOrdenMix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExcel;
        private System.Windows.Forms.Button cmdCargarDatos;
        private System.Windows.Forms.GroupBox groupBoxFechas;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditListadoReportes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DataSet_.dsReportesPRD dsReportesPRD1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colstored_procedure;
        private System.Windows.Forms.GroupBox groupBoxNumOrdenMix;
        private System.Windows.Forms.TextBox txtNumeroOrden;
    }
}