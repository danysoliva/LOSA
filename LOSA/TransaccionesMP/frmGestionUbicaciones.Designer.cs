namespace LOSA.TransaccionesMP
{
    partial class frmGestionUbicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUbicaciones));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtNumIngreso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.dsTransaccionesMP1 = new LOSA.TransaccionesMP.dsTransaccionesMP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmateriaprima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsacos_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso_seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beNuevaUbicacion = new DevExpress.XtraEditors.ButtonEdit();
            this.btnUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcNuevaUbicación = new DevExpress.XtraGrid.GridControl();
            this.gvNuevaUbicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaUbicación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNuevaUbicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumIngreso
            // 
            this.txtNumIngreso.EditValue = "";
            this.txtNumIngreso.Location = new System.Drawing.Point(144, 49);
            this.txtNumIngreso.Name = "txtNumIngreso";
            this.txtNumIngreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIngreso.Properties.Appearance.Options.UseFont = true;
            this.txtNumIngreso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumIngreso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumIngreso.Size = new System.Drawing.Size(159, 32);
            this.txtNumIngreso.TabIndex = 62;
            this.txtNumIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumIngreso_KeyDown);
            this.txtNumIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumIngreso_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(125, 24);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "No. de Ingreso";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(183, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(228, 25);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Gestión de Ubicaciones";
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.DataMember = "detalle_tarimas_ingreso";
            this.grDetalle.DataSource = this.dsTransaccionesMP1;
            this.grDetalle.Location = new System.Drawing.Point(2, 86);
            this.grDetalle.MainView = this.gridView1;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.Size = new System.Drawing.Size(618, 223);
            this.grDetalle.TabIndex = 65;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsTransaccionesMP1
            // 
            this.dsTransaccionesMP1.DataSetName = "dsTransaccionesMP";
            this.dsTransaccionesMP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmateriaprima,
            this.colsacos_tarima,
            this.colpresentacion,
            this.colubicacion,
            this.collote,
            this.colproveedor,
            this.colid_ubicacion,
            this.colseleccionar,
            this.collote_seleccionar,
            this.colingreso_seleccionar});
            this.gridView1.GridControl = this.grDetalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 46;
            // 
            // colmateriaprima
            // 
            this.colmateriaprima.Caption = "Materia Prima";
            this.colmateriaprima.FieldName = "materiaprima";
            this.colmateriaprima.Name = "colmateriaprima";
            this.colmateriaprima.OptionsColumn.AllowEdit = false;
            this.colmateriaprima.Visible = true;
            this.colmateriaprima.VisibleIndex = 1;
            this.colmateriaprima.Width = 91;
            // 
            // colsacos_tarima
            // 
            this.colsacos_tarima.Caption = "C. Sacos Tarima";
            this.colsacos_tarima.FieldName = "sacos_tarima";
            this.colsacos_tarima.Name = "colsacos_tarima";
            this.colsacos_tarima.OptionsColumn.AllowEdit = false;
            this.colsacos_tarima.Visible = true;
            this.colsacos_tarima.VisibleIndex = 2;
            this.colsacos_tarima.Width = 91;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentación";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 3;
            this.colpresentacion.Width = 91;
            // 
            // colubicacion
            // 
            this.colubicacion.Caption = "Ubicación";
            this.colubicacion.FieldName = "ubicacion";
            this.colubicacion.Name = "colubicacion";
            this.colubicacion.OptionsColumn.AllowEdit = false;
            this.colubicacion.Visible = true;
            this.colubicacion.VisibleIndex = 4;
            this.colubicacion.Width = 91;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 5;
            this.collote.Width = 91;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 6;
            this.colproveedor.Width = 99;
            // 
            // colid_ubicacion
            // 
            this.colid_ubicacion.FieldName = "id_ubicacion";
            this.colid_ubicacion.Name = "colid_ubicacion";
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 8;
            // 
            // collote_seleccionar
            // 
            this.collote_seleccionar.Caption = "Por Lote";
            this.collote_seleccionar.FieldName = "lote_seleccionar";
            this.collote_seleccionar.Name = "collote_seleccionar";
            this.collote_seleccionar.Visible = true;
            this.collote_seleccionar.VisibleIndex = 7;
            // 
            // colingreso_seleccionar
            // 
            this.colingreso_seleccionar.Caption = "Por Ingreso";
            this.colingreso_seleccionar.FieldName = "ingreso_seleccionar";
            this.colingreso_seleccionar.Name = "colingreso_seleccionar";
            // 
            // beNuevaUbicacion
            // 
            this.beNuevaUbicacion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beNuevaUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.beNuevaUbicacion.EditValue = "";
            this.beNuevaUbicacion.Location = new System.Drawing.Point(144, 326);
            this.beNuevaUbicacion.Name = "beNuevaUbicacion";
            this.beNuevaUbicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beNuevaUbicacion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beNuevaUbicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beNuevaUbicacion.Properties.MaxLength = 20;
            this.beNuevaUbicacion.Properties.NullText = "Escanee o selecciona una tarima";
            this.beNuevaUbicacion.Size = new System.Drawing.Size(325, 28);
            this.beNuevaUbicacion.TabIndex = 69;
            this.beNuevaUbicacion.ToolTip = "Hola";
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Appearance.Options.UseFont = true;
            this.btnUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUbicacion.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnUbicacion.Location = new System.Drawing.Point(475, 324);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(42, 40);
            this.btnUbicacion.TabIndex = 68;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 331);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 21);
            this.labelControl2.TabIndex = 67;
            this.labelControl2.Text = "Nueva Ubicación:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gcNuevaUbicación);
            this.groupControl2.Location = new System.Drawing.Point(6, 362);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(308, 147);
            this.groupControl2.TabIndex = 66;
            this.groupControl2.Text = "Nueva Ubicación";
            // 
            // gcNuevaUbicación
            // 
            this.gcNuevaUbicación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNuevaUbicación.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.gcNuevaUbicación.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcNuevaUbicación.Location = new System.Drawing.Point(6, 25);
            this.gcNuevaUbicación.MainView = this.gvNuevaUbicacion;
            this.gcNuevaUbicación.Name = "gcNuevaUbicación";
            this.gcNuevaUbicación.Size = new System.Drawing.Size(290, 116);
            this.gcNuevaUbicación.TabIndex = 34;
            this.gcNuevaUbicación.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNuevaUbicacion});
            // 
            // gvNuevaUbicacion
            // 
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.Empty.BackColor = System.Drawing.SystemColors.Control;
            this.gvNuevaUbicacion.Appearance.Empty.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvNuevaUbicacion.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.EvenRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvNuevaUbicacion.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvNuevaUbicacion.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvNuevaUbicacion.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvNuevaUbicacion.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedCell.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvNuevaUbicacion.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNuevaUbicacion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvNuevaUbicacion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvNuevaUbicacion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvNuevaUbicacion.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvNuevaUbicacion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvNuevaUbicacion.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNuevaUbicacion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.GroupRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvNuevaUbicacion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray;
            this.gvNuevaUbicacion.Appearance.HorzLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.HorzLine.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvNuevaUbicacion.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.OddRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvNuevaUbicacion.Appearance.Preview.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.Preview.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.Preview.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvNuevaUbicacion.Appearance.Row.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.Row.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.Row.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.RowSeparator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.RowSeparator.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvNuevaUbicacion.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNuevaUbicacion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.SelectedRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNuevaUbicacion.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvNuevaUbicacion.Appearance.TopNewRow.Options.UseFont = true;
            this.gvNuevaUbicacion.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvNuevaUbicacion.Appearance.VertLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvNuevaUbicacion.Appearance.VertLine.Options.UseBackColor = true;
            this.gvNuevaUbicacion.Appearance.VertLine.Options.UseFont = true;
            this.gvNuevaUbicacion.GridControl = this.gcNuevaUbicación;
            this.gvNuevaUbicacion.Name = "gvNuevaUbicacion";
            this.gvNuevaUbicacion.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvNuevaUbicacion.OptionsBehavior.Editable = false;
            this.gvNuevaUbicacion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNuevaUbicacion.OptionsView.EnableAppearanceOddRow = true;
            this.gvNuevaUbicacion.OptionsView.ShowColumnHeaders = false;
            this.gvNuevaUbicacion.OptionsView.ShowGroupPanel = false;
            this.gvNuevaUbicacion.OptionsView.ShowIndicator = false;
            this.gvNuevaUbicacion.PaintStyleName = "Flat";
            // 
            // cmdLoad
            // 
            this.cmdLoad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.Appearance.Options.UseFont = true;
            this.cmdLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoad.ImageOptions.Image")));
            this.cmdLoad.Location = new System.Drawing.Point(309, 43);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(42, 40);
            this.cmdLoad.TabIndex = 70;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(489, 43);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 40);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGestionUbicaciones
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.beNuevaUbicacion);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grDetalle);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNumIngreso);
            this.Controls.Add(this.labelControl6);
            this.Name = "frmGestionUbicaciones";
            this.Text = "Gestión de Ubicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransaccionesMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNuevaUbicación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNuevaUbicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNumIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ButtonEdit beNuevaUbicacion;
        private DevExpress.XtraEditors.SimpleButton btnUbicacion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcNuevaUbicación;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNuevaUbicacion;
        private DevExpress.XtraEditors.SimpleButton cmdLoad;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private dsTransaccionesMP dsTransaccionesMP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmateriaprima;
        private DevExpress.XtraGrid.Columns.GridColumn colsacos_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn collote_seleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso_seleccionar;
    }
}