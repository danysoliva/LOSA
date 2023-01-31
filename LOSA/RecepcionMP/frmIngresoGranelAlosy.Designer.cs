using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.RecepcionMP
{
    partial class frmIngresoGranelAlosy
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoGranelAlosy));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.beNuevaUbicacion = new DevExpress.XtraEditors.ButtonEdit();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaVencimiento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaProduccion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMP_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoMP = new DevExpress.XtraEditors.TextEdit();
            this.btnUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditBarco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpEditUbicaciones = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceUbicaciones = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPesonetoIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpesoSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconductorin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfurgon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_boleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSNegocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Registrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGenerarIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.grdbarco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.barcosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdUbicaciones = new DevExpress.XtraEditors.GridLookUpEdit();
            this.ubicacionesgranelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chnuevoIngreso = new DevExpress.XtraEditors.CheckEdit();
            this.txtingreso = new DevExpress.XtraEditors.TextEdit();
            this.lblingresoRotulo = new DevExpress.XtraEditors.LabelControl();
            this.btningreso = new DevExpress.XtraEditors.SimpleButton();
            this.tggNuevoIngreso = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBuscarIngresoExterno = new DevExpress.XtraEditors.SimpleButton();
            this.txtIngresoExterno = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdbarco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUbicaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesgranelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chnuevoIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggNuevoIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngresoExterno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // beNuevaUbicacion
            // 
            this.beNuevaUbicacion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.beNuevaUbicacion.EditValue = "";
            this.beNuevaUbicacion.Enabled = false;
            this.beNuevaUbicacion.Location = new System.Drawing.Point(835, 257);
            this.beNuevaUbicacion.Name = "beNuevaUbicacion";
            this.beNuevaUbicacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.beNuevaUbicacion.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.beNuevaUbicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beNuevaUbicacion.Properties.MaxLength = 20;
            this.beNuevaUbicacion.Properties.NullText = "Escanee o selecciona una tarima";
            this.beNuevaUbicacion.Size = new System.Drawing.Size(102, 32);
            this.beNuevaUbicacion.TabIndex = 90;
            this.beNuevaUbicacion.ToolTip = "Hola";
            this.beNuevaUbicacion.Visible = false;
            // 
            // txtLote
            // 
            this.txtLote.EditValue = "";
            this.txtLote.Location = new System.Drawing.Point(210, 113);
            this.txtLote.Name = "txtLote";
            this.txtLote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Properties.Appearance.Options.UseFont = true;
            this.txtLote.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtLote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLote.Size = new System.Drawing.Size(410, 32);
            this.txtLote.TabIndex = 65;
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.EditValue = null;
            this.dtFechaVencimiento.Enabled = false;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(210, 183);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaVencimiento.Properties.Appearance.Options.UseFont = true;
            this.dtFechaVencimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVencimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVencimiento.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaVencimiento.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaVencimiento.Size = new System.Drawing.Size(410, 30);
            this.dtFechaVencimiento.TabIndex = 67;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(20, 189);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(200, 25);
            this.labelControl9.TabIndex = 82;
            this.labelControl9.Text = "Fecha Vencimiento_____";
            // 
            // dtFechaProduccion
            // 
            this.dtFechaProduccion.EditValue = null;
            this.dtFechaProduccion.Enabled = false;
            this.dtFechaProduccion.Location = new System.Drawing.Point(210, 149);
            this.dtFechaProduccion.Name = "dtFechaProduccion";
            this.dtFechaProduccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaProduccion.Properties.Appearance.Options.UseFont = true;
            this.dtFechaProduccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaProduccion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaProduccion.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaProduccion.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaProduccion.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaProduccion.Size = new System.Drawing.Size(410, 30);
            this.dtFechaProduccion.TabIndex = 66;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(20, 155);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(206, 25);
            this.labelControl8.TabIndex = 81;
            this.labelControl8.Text = "Fecha Producción_______";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 121);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(196, 25);
            this.labelControl6.TabIndex = 78;
            this.labelControl6.Text = "# Lote__________________";
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.EditValue = null;
            this.dtFechaIngreso.Enabled = false;
            this.dtFechaIngreso.Location = new System.Drawing.Point(210, 79);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngreso.Properties.Appearance.Options.UseFont = true;
            this.dtFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIngreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIngreso.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaIngreso.Properties.MinValue = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtFechaIngreso.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaIngreso.Size = new System.Drawing.Size(410, 30);
            this.dtFechaIngreso.TabIndex = 77;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(189, 25);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Fecha Ingreso_________";
            // 
            // txtMP_Name
            // 
            this.txtMP_Name.EditValue = "";
            this.txtMP_Name.Enabled = false;
            this.txtMP_Name.Location = new System.Drawing.Point(346, 42);
            this.txtMP_Name.Name = "txtMP_Name";
            this.txtMP_Name.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtMP_Name.Properties.Appearance.Options.UseFont = true;
            this.txtMP_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMP_Name.Size = new System.Drawing.Size(274, 32);
            this.txtMP_Name.TabIndex = 72;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(199, 25);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "Materia Prima__________";
            // 
            // txtCodigoMP
            // 
            this.txtCodigoMP.EditValue = "";
            this.txtCodigoMP.Enabled = false;
            this.txtCodigoMP.Location = new System.Drawing.Point(210, 42);
            this.txtCodigoMP.Name = "txtCodigoMP";
            this.txtCodigoMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtCodigoMP.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoMP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMP.Size = new System.Drawing.Size(130, 32);
            this.txtCodigoMP.TabIndex = 70;
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Appearance.Options.UseFont = true;
            this.btnUbicacion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUbicacion.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnUbicacion.Location = new System.Drawing.Point(943, 249);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(42, 40);
            this.btnUbicacion.TabIndex = 89;
            this.btnUbicacion.Visible = false;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(79, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(819, 31);
            this.labelControl1.TabIndex = 92;
            this.labelControl1.Text = "Registro Granel";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "granel";
            this.gridControl1.DataSource = this.dsRecepcionMPx1;
            this.gridControl1.Location = new System.Drawing.Point(3, 295);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditBarco,
            this.GridLookUpEditUbicaciones});
            this.gridControl1.Size = new System.Drawing.Size(1000, 324);
            this.gridControl1.TabIndex = 93;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcomentarios,
            this.colEmpresaTrans,
            this.colfechaEntra,
            this.colFechaFin,
            this.colshipid,
            this.colbarco,
            this.colNBoleta,
            this.colnumero_factura,
            this.colOperador,
            this.colPesoBruto,
            this.colid_ubicacion,
            this.colPesonetoIn,
            this.colitemcode,
            this.colPesoProd,
            this.colpesoSalida,
            this.colpeso_factura,
            this.colconductorin,
            this.colvehiculo,
            this.colfurgon,
            this.colTipoBoleta,
            this.colid_tipo_boleta,
            this.colSNegocio,
            this.colProducto,
            this.col_Registrar,
            this.colseleccionar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colcomentarios
            // 
            this.colcomentarios.Caption = "Comentarios";
            this.colcomentarios.FieldName = "comentarios";
            this.colcomentarios.Name = "colcomentarios";
            this.colcomentarios.OptionsColumn.AllowEdit = false;
            this.colcomentarios.Visible = true;
            this.colcomentarios.VisibleIndex = 6;
            this.colcomentarios.Width = 292;
            // 
            // colEmpresaTrans
            // 
            this.colEmpresaTrans.FieldName = "EmpresaTrans";
            this.colEmpresaTrans.Name = "colEmpresaTrans";
            this.colEmpresaTrans.OptionsColumn.AllowEdit = false;
            // 
            // colfechaEntra
            // 
            this.colfechaEntra.Caption = "Fecha Entrada";
            this.colfechaEntra.FieldName = "fechaEntra";
            this.colfechaEntra.Name = "colfechaEntra";
            this.colfechaEntra.OptionsColumn.AllowEdit = false;
            this.colfechaEntra.Visible = true;
            this.colfechaEntra.VisibleIndex = 0;
            this.colfechaEntra.Width = 119;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            // 
            // colshipid
            // 
            this.colshipid.Caption = "Barco";
            this.colshipid.ColumnEdit = this.LookUpEditBarco;
            this.colshipid.FieldName = "shipid";
            this.colshipid.Name = "colshipid";
            this.colshipid.Visible = true;
            this.colshipid.VisibleIndex = 2;
            this.colshipid.Width = 128;
            // 
            // LookUpEditBarco
            // 
            this.LookUpEditBarco.AutoHeight = false;
            this.LookUpEditBarco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditBarco.DataSource = this.bindingSource1;
            this.LookUpEditBarco.DisplayMember = "descripcion";
            this.LookUpEditBarco.Name = "LookUpEditBarco";
            this.LookUpEditBarco.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.LookUpEditBarco.ValueMember = "id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "barcos";
            this.bindingSource1.DataSource = this.dsRecepcionMPx1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coldescripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colbarco
            // 
            this.colbarco.Caption = "Barco";
            this.colbarco.FieldName = "barco";
            this.colbarco.Name = "colbarco";
            this.colbarco.OptionsColumn.AllowEdit = false;
            this.colbarco.Width = 151;
            // 
            // colNBoleta
            // 
            this.colNBoleta.FieldName = "NBoleta";
            this.colNBoleta.Name = "colNBoleta";
            this.colNBoleta.OptionsColumn.AllowEdit = false;
            this.colNBoleta.Visible = true;
            this.colNBoleta.VisibleIndex = 1;
            this.colNBoleta.Width = 73;
            // 
            // colnumero_factura
            // 
            this.colnumero_factura.FieldName = "numero_factura";
            this.colnumero_factura.Name = "colnumero_factura";
            this.colnumero_factura.OptionsColumn.AllowEdit = false;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.OptionsColumn.AllowEdit = false;
            // 
            // colPesoBruto
            // 
            this.colPesoBruto.FieldName = "PesoBruto";
            this.colPesoBruto.Name = "colPesoBruto";
            this.colPesoBruto.OptionsColumn.AllowEdit = false;
            // 
            // colid_ubicacion
            // 
            this.colid_ubicacion.Caption = "Ubicación Almacén";
            this.colid_ubicacion.ColumnEdit = this.GridLookUpEditUbicaciones;
            this.colid_ubicacion.FieldName = "id_ubicacion";
            this.colid_ubicacion.Name = "colid_ubicacion";
            this.colid_ubicacion.Visible = true;
            this.colid_ubicacion.VisibleIndex = 5;
            this.colid_ubicacion.Width = 125;
            // 
            // GridLookUpEditUbicaciones
            // 
            this.GridLookUpEditUbicaciones.AutoHeight = false;
            this.GridLookUpEditUbicaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditUbicaciones.DataSource = this.bindingSourceUbicaciones;
            this.GridLookUpEditUbicaciones.DisplayMember = "rack";
            this.GridLookUpEditUbicaciones.Name = "GridLookUpEditUbicaciones";
            this.GridLookUpEditUbicaciones.PopupView = this.gridView2;
            this.GridLookUpEditUbicaciones.ValueMember = "id";
            // 
            // bindingSourceUbicaciones
            // 
            this.bindingSourceUbicaciones.DataMember = "ubicaciones_granel";
            this.bindingSourceUbicaciones.DataSource = this.dsRecepcionMPx1;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPesonetoIn
            // 
            this.colPesonetoIn.FieldName = "PesonetoIn";
            this.colPesonetoIn.Name = "colPesonetoIn";
            this.colPesonetoIn.OptionsColumn.AllowEdit = false;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            // 
            // colPesoProd
            // 
            this.colPesoProd.FieldName = "PesoProd";
            this.colPesoProd.Name = "colPesoProd";
            this.colPesoProd.OptionsColumn.AllowEdit = false;
            this.colPesoProd.Visible = true;
            this.colPesoProd.VisibleIndex = 3;
            this.colPesoProd.Width = 105;
            // 
            // colpesoSalida
            // 
            this.colpesoSalida.FieldName = "pesoSalida";
            this.colpesoSalida.Name = "colpesoSalida";
            this.colpesoSalida.OptionsColumn.AllowEdit = false;
            // 
            // colpeso_factura
            // 
            this.colpeso_factura.FieldName = "peso_factura";
            this.colpeso_factura.Name = "colpeso_factura";
            this.colpeso_factura.OptionsColumn.AllowEdit = false;
            // 
            // colconductorin
            // 
            this.colconductorin.FieldName = "conductorin";
            this.colconductorin.Name = "colconductorin";
            this.colconductorin.OptionsColumn.AllowEdit = false;
            // 
            // colvehiculo
            // 
            this.colvehiculo.FieldName = "vehiculo";
            this.colvehiculo.Name = "colvehiculo";
            this.colvehiculo.OptionsColumn.AllowEdit = false;
            // 
            // colfurgon
            // 
            this.colfurgon.FieldName = "furgon";
            this.colfurgon.Name = "colfurgon";
            this.colfurgon.OptionsColumn.AllowEdit = false;
            // 
            // colTipoBoleta
            // 
            this.colTipoBoleta.FieldName = "TipoBoleta";
            this.colTipoBoleta.Name = "colTipoBoleta";
            this.colTipoBoleta.OptionsColumn.AllowEdit = false;
            // 
            // colid_tipo_boleta
            // 
            this.colid_tipo_boleta.FieldName = "id_tipo_boleta";
            this.colid_tipo_boleta.Name = "colid_tipo_boleta";
            this.colid_tipo_boleta.OptionsColumn.AllowEdit = false;
            // 
            // colSNegocio
            // 
            this.colSNegocio.FieldName = "SNegocio";
            this.colSNegocio.Name = "colSNegocio";
            this.colSNegocio.OptionsColumn.AllowEdit = false;
            this.colSNegocio.Visible = true;
            this.colSNegocio.VisibleIndex = 4;
            this.colSNegocio.Width = 129;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            // 
            // col_Registrar
            // 
            this.col_Registrar.Caption = "Registrar Lote";
            this.col_Registrar.Name = "col_Registrar";
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 228);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 18);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "Detalle de Boletas";
            // 
            // cmdGenerarIngreso
            // 
            this.cmdGenerarIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGenerarIngreso.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdGenerarIngreso.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerarIngreso.Appearance.Options.UseBackColor = true;
            this.cmdGenerarIngreso.Appearance.Options.UseFont = true;
            this.cmdGenerarIngreso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdGenerarIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerarIngreso.ImageOptions.Image")));
            this.cmdGenerarIngreso.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGenerarIngreso.Location = new System.Drawing.Point(626, 3);
            this.cmdGenerarIngreso.Name = "cmdGenerarIngreso";
            this.cmdGenerarIngreso.Size = new System.Drawing.Size(194, 56);
            this.cmdGenerarIngreso.TabIndex = 96;
            this.cmdGenerarIngreso.Text = "Guardar Informacion";
            this.cmdGenerarIngreso.Click += new System.EventHandler(this.cmdGenerarIngreso_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(826, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(166, 56);
            this.btnAtras.TabIndex = 95;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grdbarco
            // 
            this.grdbarco.Location = new System.Drawing.Point(210, 269);
            this.grdbarco.Name = "grdbarco";
            this.grdbarco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdbarco.Properties.DataSource = this.barcosBindingSource;
            this.grdbarco.Properties.DisplayMember = "descripcion";
            this.grdbarco.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdbarco.Properties.ValueMember = "id";
            this.grdbarco.Size = new System.Drawing.Size(130, 20);
            this.grdbarco.TabIndex = 97;
            this.grdbarco.EditValueChanged += new System.EventHandler(this.grdbarco_EditValueChanged);
            // 
            // barcosBindingSource
            // 
            this.barcosBindingSource.DataMember = "barcos";
            this.barcosBindingSource.DataSource = this.dsRecepcionMPx1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.coldescripcion1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(214, 238);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 25);
            this.labelControl4.TabIndex = 98;
            this.labelControl4.Text = "Barco";
            // 
            // grdUbicaciones
            // 
            this.grdUbicaciones.Location = new System.Drawing.Point(571, 269);
            this.grdUbicaciones.Name = "grdUbicaciones";
            this.grdUbicaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdUbicaciones.Properties.DataSource = this.ubicacionesgranelBindingSource;
            this.grdUbicaciones.Properties.DisplayMember = "rack";
            this.grdUbicaciones.Properties.PopupView = this.gridView3;
            this.grdUbicaciones.Properties.ValueMember = "id";
            this.grdUbicaciones.Size = new System.Drawing.Size(130, 20);
            this.grdUbicaciones.TabIndex = 99;
            this.grdUbicaciones.EditValueChanged += new System.EventHandler(this.grdUbicaciones_EditValueChanged);
            // 
            // ubicacionesgranelBindingSource
            // 
            this.ubicacionesgranelBindingSource.DataMember = "ubicaciones_granel";
            this.ubicacionesgranelBindingSource.DataSource = this.dsRecepcionMPx1;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colrack,
            this.colcodigo_barra});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // colrack
            // 
            this.colrack.FieldName = "rack";
            this.colrack.Name = "colrack";
            this.colrack.Visible = true;
            this.colrack.VisibleIndex = 0;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(571, 238);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 25);
            this.labelControl7.TabIndex = 100;
            this.labelControl7.Text = "Ubicacion";
            // 
            // chnuevoIngreso
            // 
            this.chnuevoIngreso.EditValue = true;
            this.chnuevoIngreso.Location = new System.Drawing.Point(650, 65);
            this.chnuevoIngreso.Name = "chnuevoIngreso";
            this.chnuevoIngreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnuevoIngreso.Properties.Appearance.Options.UseFont = true;
            this.chnuevoIngreso.Properties.Caption = "Nuevo Ingreso";
            this.chnuevoIngreso.Size = new System.Drawing.Size(229, 24);
            this.chnuevoIngreso.TabIndex = 101;
            this.chnuevoIngreso.Visible = false;
            this.chnuevoIngreso.CheckedChanged += new System.EventHandler(this.chnuevoIngreso_CheckedChanged);
            // 
            // txtingreso
            // 
            this.txtingreso.EditValue = "";
            this.txtingreso.Enabled = false;
            this.txtingreso.Location = new System.Drawing.Point(820, 124);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtingreso.Properties.Appearance.Options.UseFont = true;
            this.txtingreso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtingreso.Size = new System.Drawing.Size(121, 32);
            this.txtingreso.TabIndex = 102;
            // 
            // lblingresoRotulo
            // 
            this.lblingresoRotulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblingresoRotulo.Appearance.Options.UseFont = true;
            this.lblingresoRotulo.Location = new System.Drawing.Point(650, 132);
            this.lblingresoRotulo.Name = "lblingresoRotulo";
            this.lblingresoRotulo.Size = new System.Drawing.Size(180, 25);
            this.lblingresoRotulo.TabIndex = 103;
            this.lblingresoRotulo.Text = "# Ingreso ALOSY_____";
            // 
            // btningreso
            // 
            this.btningreso.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningreso.Appearance.Options.UseFont = true;
            this.btningreso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btningreso.Enabled = false;
            this.btningreso.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btningreso.Location = new System.Drawing.Point(947, 120);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(42, 40);
            this.btningreso.TabIndex = 104;
            this.btningreso.Visible = false;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // tggNuevoIngreso
            // 
            this.tggNuevoIngreso.EditValue = true;
            this.tggNuevoIngreso.Location = new System.Drawing.Point(820, 82);
            this.tggNuevoIngreso.Name = "tggNuevoIngreso";
            this.tggNuevoIngreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggNuevoIngreso.Properties.Appearance.Options.UseFont = true;
            this.tggNuevoIngreso.Properties.OffText = "No";
            this.tggNuevoIngreso.Properties.OnText = "Si";
            this.tggNuevoIngreso.Size = new System.Drawing.Size(147, 32);
            this.tggNuevoIngreso.TabIndex = 105;
            this.tggNuevoIngreso.Toggled += new System.EventHandler(this.tggNuevoIngreso_Toggled);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(650, 85);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(164, 25);
            this.labelControl10.TabIndex = 106;
            this.labelControl10.Text = "¿Es Ingreso Nuevo?";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(650, 188);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(172, 25);
            this.labelControl11.TabIndex = 107;
            this.labelControl11.Text = "# Ingreso Externo___";
            this.labelControl11.Visible = false;
            // 
            // cmdBuscarIngresoExterno
            // 
            this.cmdBuscarIngresoExterno.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarIngresoExterno.Appearance.Options.UseFont = true;
            this.cmdBuscarIngresoExterno.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdBuscarIngresoExterno.Enabled = false;
            this.cmdBuscarIngresoExterno.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.cmdBuscarIngresoExterno.Location = new System.Drawing.Point(947, 178);
            this.cmdBuscarIngresoExterno.Name = "cmdBuscarIngresoExterno";
            this.cmdBuscarIngresoExterno.Size = new System.Drawing.Size(42, 40);
            this.cmdBuscarIngresoExterno.TabIndex = 108;
            this.cmdBuscarIngresoExterno.Visible = false;
            this.cmdBuscarIngresoExterno.Click += new System.EventHandler(this.cmdBuscarIngresoExterno_Click);
            // 
            // txtIngresoExterno
            // 
            this.txtIngresoExterno.EditValue = "";
            this.txtIngresoExterno.Enabled = false;
            this.txtIngresoExterno.Location = new System.Drawing.Point(820, 181);
            this.txtIngresoExterno.Name = "txtIngresoExterno";
            this.txtIngresoExterno.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtIngresoExterno.Properties.Appearance.Options.UseFont = true;
            this.txtIngresoExterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIngresoExterno.Size = new System.Drawing.Size(121, 32);
            this.txtIngresoExterno.TabIndex = 109;
            this.txtIngresoExterno.Visible = false;
            // 
            // frmIngresoGranelAlosy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 621);
            this.Controls.Add(this.txtIngresoExterno);
            this.Controls.Add(this.cmdBuscarIngresoExterno);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.tggNuevoIngreso);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.lblingresoRotulo);
            this.Controls.Add(this.chnuevoIngreso);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.grdUbicaciones);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.grdbarco);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmdGenerarIngreso);
            this.Controls.Add(this.txtCodigoMP);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.beNuevaUbicacion);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.dtFechaVencimiento);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaProduccion);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMP_Name);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmIngresoGranelAlosy";
            this.Text = "Ingreso MP Granel";
            this.Load += new System.EventHandler(this.frmIngresoGranelAlosy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beNuevaUbicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVencimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaProduccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoMP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdbarco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUbicaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesgranelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chnuevoIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtingreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggNuevoIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngresoExterno.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit beNuevaUbicacion;
        private DevExpress.XtraEditors.SimpleButton btnUbicacion;
        private DevExpress.XtraEditors.TextEdit txtLote;
        private DevExpress.XtraEditors.DateEdit dtFechaVencimiento;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaProduccion;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtFechaIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMP_Name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigoMP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private LabelControl labelControl2;
        private dsRecepcionMPx dsRecepcionMPx1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaEntra;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colshipid;
        private DevExpress.XtraGrid.Columns.GridColumn colbarco;
        private DevExpress.XtraGrid.Columns.GridColumn colNBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colPesonetoIn;
        private DevExpress.XtraGrid.Columns.GridColumn colPesoProd;
        private DevExpress.XtraGrid.Columns.GridColumn colpesoSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colconductorin;
        private DevExpress.XtraGrid.Columns.GridColumn colvehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colfurgon;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoBoleta;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_boleta;
        private DevExpress.XtraGrid.Columns.GridColumn colSNegocio;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn col_Registrar;
        private SimpleButton cmdGenerarIngreso;
        private SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit LookUpEditBarco;
        private GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ubicacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditUbicaciones;
        private GridView gridView2;
        private System.Windows.Forms.BindingSource bindingSourceUbicaciones;
        private GridLookUpEdit grdbarco;
        private GridView gridLookUpEdit1View;
        private LabelControl labelControl4;
        private GridLookUpEdit grdUbicaciones;
        private GridView gridView3;
        private LabelControl labelControl7;
        private System.Windows.Forms.BindingSource ubicacionesgranelBindingSource;
        private System.Windows.Forms.BindingSource barcosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colrack;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private CheckEdit chnuevoIngreso;
        private TextEdit txtingreso;
        private LabelControl lblingresoRotulo;
        private SimpleButton btningreso;
        private ToggleSwitch tggNuevoIngreso;
        private LabelControl labelControl10;
        private LabelControl labelControl11;
        private SimpleButton cmdBuscarIngresoExterno;
        private TextEdit txtIngresoExterno;
    }
}