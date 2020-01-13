namespace LOSA.RecepcionMP
{
    partial class frmTarimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarimas));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcTarima = new DevExpress.XtraGrid.GridControl();
            this.detalleTarimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcionMP = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreTarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_materia_prima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTarimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(199, 71);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // gcTarima
            // 
            this.gcTarima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTarima.DataSource = this.detalleTarimaBindingSource;
            this.gcTarima.Location = new System.Drawing.Point(0, 101);
            this.gcTarima.MainView = this.gvTarimas;
            this.gcTarima.Name = "gcTarima";
            this.gcTarima.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcTarima.Size = new System.Drawing.Size(606, 342);
            this.gcTarima.TabIndex = 6;
            this.gcTarima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarimas});
            // 
            // detalleTarimaBindingSource
            // 
            this.detalleTarimaBindingSource.DataMember = "DetalleTarima";
            this.detalleTarimaBindingSource.DataSource = this.dsRecepcionMP;
            // 
            // dsRecepcionMP
            // 
            this.dsRecepcionMP.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTarimas
            // 
            this.gvTarimas.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTarimas.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTarimas.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvTarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTarimas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvTarimas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTarimas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.Row.Options.UseFont = true;
            this.gvTarimas.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvTarimas.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTarimas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTarimas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnombreTarima,
            this.colFechaIngreso,
            this.colnombreProveedor,
            this.colnumero_transaccion,
            this.collote_materia_prima,
            this.coltipo_tarima,
            this.colid_boleta,
            this.colPresentacion,
            this.colSeleccionar});
            this.gvTarimas.GridControl = this.gcTarima;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsCustomization.AllowFilter = false;
            this.gvTarimas.OptionsView.ShowAutoFilterRow = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.RowHeight = 20;
            this.gvTarimas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvTarimas_KeyDown);
            this.gvTarimas.DoubleClick += new System.EventHandler(this.GvTarimas_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colnombreTarima
            // 
            this.colnombreTarima.Caption = "Nombre Tarima";
            this.colnombreTarima.FieldName = "nombreTarima";
            this.colnombreTarima.Name = "colnombreTarima";
            this.colnombreTarima.OptionsColumn.AllowEdit = false;
            this.colnombreTarima.Width = 93;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "fecha_ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.OptionsColumn.AllowEdit = false;
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 0;
            this.colFechaIngreso.Width = 68;
            // 
            // colnombreProveedor
            // 
            this.colnombreProveedor.Caption = "Proveedor";
            this.colnombreProveedor.FieldName = "nombreProveedor";
            this.colnombreProveedor.Name = "colnombreProveedor";
            this.colnombreProveedor.OptionsColumn.AllowEdit = false;
            this.colnombreProveedor.Visible = true;
            this.colnombreProveedor.VisibleIndex = 1;
            this.colnombreProveedor.Width = 84;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Transacción";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 2;
            this.colnumero_transaccion.Width = 84;
            // 
            // collote_materia_prima
            // 
            this.collote_materia_prima.Caption = "Lote MP";
            this.collote_materia_prima.FieldName = "lote_materia_prima";
            this.collote_materia_prima.Name = "collote_materia_prima";
            this.collote_materia_prima.OptionsColumn.AllowEdit = false;
            this.collote_materia_prima.Visible = true;
            this.collote_materia_prima.VisibleIndex = 3;
            this.collote_materia_prima.Width = 84;
            // 
            // coltipo_tarima
            // 
            this.coltipo_tarima.Caption = "Tipo Tarima";
            this.coltipo_tarima.FieldName = "tipo_tarima";
            this.coltipo_tarima.Name = "coltipo_tarima";
            this.coltipo_tarima.OptionsColumn.AllowEdit = false;
            this.coltipo_tarima.Visible = true;
            this.coltipo_tarima.VisibleIndex = 5;
            this.coltipo_tarima.Width = 84;
            // 
            // colid_boleta
            // 
            this.colid_boleta.Caption = "Id Boleta";
            this.colid_boleta.FieldName = "id_boleta";
            this.colid_boleta.Name = "colid_boleta";
            this.colid_boleta.OptionsColumn.AllowEdit = false;
            this.colid_boleta.Visible = true;
            this.colid_boleta.VisibleIndex = 6;
            this.colid_boleta.Width = 78;
            // 
            // colPresentacion
            // 
            this.colPresentacion.FieldName = "presentacion";
            this.colPresentacion.Name = "colPresentacion";
            this.colPresentacion.OptionsColumn.AllowEdit = false;
            this.colPresentacion.Visible = true;
            this.colPresentacion.VisibleIndex = 4;
            this.colPresentacion.Width = 68;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "#";
            this.colSeleccionar.ColumnEdit = this.btnSeleccionar;
            this.colSeleccionar.FieldName = "seleccionar";
            this.colSeleccionar.MaxWidth = 50;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 7;
            this.colSeleccionar.Width = 38;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnSeleccionar_ButtonClick);
            // 
            // frmTarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 482);
            this.Controls.Add(this.gcTarima);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTarimas";
            this.Text = "frmTarimas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTarimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcTarima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private System.Windows.Forms.BindingSource detalleTarimaBindingSource;
        private dsRecepcionMPx dsRecepcionMP;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote_materia_prima;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colid_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
    }
}