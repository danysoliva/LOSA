namespace LOSA.RecepcionMP
{
    partial class frmImprimirHojaIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirHojaIngreso));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateriaprima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDuplicar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDuplicar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.colUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDuplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(851, 49);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Ingresos de Materia Prima";
            this.labelControl1.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(612, 54);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(223, 58);
            this.btnAtras.TabIndex = 26;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lista_tarimas";
            this.gridControl1.DataSource = this.dsRecepcionMPx1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 121);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnPrint,
            this.cmdDuplicar,
            this.btnEditar});
            this.gridControl1.Size = new System.Drawing.Size(851, 570);
            this.gridControl1.TabIndex = 51;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_materia_prima,
            this.colmateriaprima,
            this.colid_proveedor,
            this.colproveedor,
            this.colfecha_ingreso,
            this.colnumero_transaccion,
            this.collote_materia_prima,
            this.colid_boleta,
            this.colPrint,
            this.colDuplicar,
            this.Editar,
            this.colnum,
            this.colUbicacion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colid_materia_prima
            // 
            this.colid_materia_prima.FieldName = "id_materia_prima";
            this.colid_materia_prima.Name = "colid_materia_prima";
            // 
            // colmateriaprima
            // 
            this.colmateriaprima.Caption = "Materia Prima";
            this.colmateriaprima.FieldName = "materiaprima";
            this.colmateriaprima.Name = "colmateriaprima";
            this.colmateriaprima.OptionsColumn.AllowEdit = false;
            this.colmateriaprima.Visible = true;
            this.colmateriaprima.VisibleIndex = 1;
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 2;
            this.colproveedor.Width = 72;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.DisplayFormat.FormatString = "g";
            this.colfecha_ingreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 4;
            this.colfecha_ingreso.Width = 72;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 5;
            this.colnumero_transaccion.Width = 72;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 6;
            this.collote_materia_prima.Width = 72;
            // 
            // colid_boleta
            // 
            this.colid_boleta.Caption = "# Boleta";
            this.colid_boleta.FieldName = "id_boleta";
            this.colid_boleta.Name = "colid_boleta";
            this.colid_boleta.OptionsColumn.AllowEdit = false;
            this.colid_boleta.Visible = true;
            this.colid_boleta.VisibleIndex = 7;
            this.colid_boleta.Width = 72;
            // 
            // colPrint
            // 
            this.colPrint.Caption = "Imprimir";
            this.colPrint.ColumnEdit = this.btnPrint;
            this.colPrint.Name = "colPrint";
            this.colPrint.Visible = true;
            this.colPrint.VisibleIndex = 8;
            this.colPrint.Width = 72;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnPrint_ButtonClick);
            // 
            // colDuplicar
            // 
            this.colDuplicar.Caption = "Duplicar";
            this.colDuplicar.ColumnEdit = this.cmdDuplicar;
            this.colDuplicar.Name = "colDuplicar";
            this.colDuplicar.Visible = true;
            this.colDuplicar.VisibleIndex = 9;
            this.colDuplicar.Width = 72;
            // 
            // cmdDuplicar
            // 
            this.cmdDuplicar.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.cmdDuplicar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions5, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.cmdDuplicar.Name = "cmdDuplicar";
            this.cmdDuplicar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDuplicar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDuplicar_ButtonClick);
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.btnEditar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 10;
            this.Editar.Width = 89;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions6, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditar_ButtonClick);
            // 
            // colnum
            // 
            this.colnum.Caption = "#";
            this.colnum.FieldName = "num";
            this.colnum.Name = "colnum";
            this.colnum.Visible = true;
            this.colnum.VisibleIndex = 0;
            this.colnum.Width = 53;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(628, 2);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(223, 49);
            this.cmdGuardar.TabIndex = 50;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Visible = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.EditValue = null;
            this.dtFechaHasta.Location = new System.Drawing.Point(147, 85);
            this.dtFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHasta.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHasta.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHasta.Size = new System.Drawing.Size(189, 32);
            this.dtFechaHasta.TabIndex = 53;
            this.dtFechaHasta.EditValueChanged += new System.EventHandler(this.dtFechaHasta_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 89);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(117, 25);
            this.labelControl9.TabIndex = 55;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.EditValue = null;
            this.dtFechaDesde.Location = new System.Drawing.Point(147, 50);
            this.dtFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesde.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesde.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesde.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesde.Size = new System.Drawing.Size(189, 32);
            this.dtFechaDesde.TabIndex = 52;
            this.dtFechaDesde.EditValueChanged += new System.EventHandler(this.dtFechaDesde_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 54);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(123, 25);
            this.labelControl8.TabIndex = 54;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // colUbicacion
            // 
            this.colUbicacion.Caption = "Ubicacion";
            this.colUbicacion.FieldName = "ubicacion";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.OptionsColumn.AllowEdit = false;
            this.colUbicacion.Visible = true;
            this.colUbicacion.VisibleIndex = 3;
            this.colUbicacion.Width = 110;
            // 
            // frmImprimirHojaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 689);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmImprimirHojaIngreso";
            this.Text = "frmImprimirHojaIngreso";
            this.Activated += new System.EventHandler(this.frmImprimirHojaIngreso_Activated);
            this.Load += new System.EventHandler(this.frmImprimirHojaIngreso_Load);
            this.Click += new System.EventHandler(this.frmImprimirHojaIngreso_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDuplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private dsRecepcionMPx dsRecepcionMPx1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colmateriaprima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPrint;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.DateEdit dtFechaHasta;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesde;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn colDuplicar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDuplicar;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colnum;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicacion;
    }
}