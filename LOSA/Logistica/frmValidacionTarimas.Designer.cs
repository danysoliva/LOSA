
namespace LOSA.Logistica
{
    partial class frmValidacionTarimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidacionTarimas));
            this.txtTarima = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelNotificacion = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.grdPresentacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.presentacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogistica21 = new LOSA.Logistica.dsLogistica2();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLoteMP = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tsEditarTarima = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnidades = new DevExpress.XtraEditors.SpinEdit();
            this.vGridDatosTarima = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowid = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_materia_prima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcodigo_barra = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowitemcode = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowmp = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_proveedor = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowproveedor = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowfecha_ingreso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rownumero_transaccion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowfecha_vencimiento = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowfecha_produccion_materia_prima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowlote_materia_prima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_presentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpresentacion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_usuario = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_boleta = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowcantidad = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowpeso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_estado_calidad = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_ingreso = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowid_estado_tarima = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowdescripcion = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowfactor_activo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.timerLimpiarMensaje = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).BeginInit();
            this.panelNotificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsEditarTarima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridDatosTarima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTarima
            // 
            this.txtTarima.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtTarima.EditValue = "";
            this.txtTarima.Location = new System.Drawing.Point(237, 12);
            this.txtTarima.Name = "txtTarima";
            this.txtTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarima.Properties.Appearance.Options.UseFont = true;
            this.txtTarima.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtTarima.Properties.MaxLength = 20;
            this.txtTarima.Properties.NullText = "Escanee o selecciona una tarima";
            this.txtTarima.Size = new System.Drawing.Size(259, 44);
            this.txtTarima.TabIndex = 110;
            this.txtTarima.ToolTip = "Hola";
            this.txtTarima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTarima_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(122, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 37);
            this.labelControl2.TabIndex = 111;
            this.labelControl2.Text = "Tarima:";
            // 
            // panelNotificacion
            // 
            this.panelNotificacion.BackColor = System.Drawing.Color.White;
            this.panelNotificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificacion.Controls.Add(this.lblMensaje);
            this.panelNotificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotificacion.Location = new System.Drawing.Point(0, 770);
            this.panelNotificacion.Name = "panelNotificacion";
            this.panelNotificacion.Size = new System.Drawing.Size(673, 71);
            this.panelNotificacion.TabIndex = 112;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 5);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(665, 59);
            this.lblMensaje.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(277, 517);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPeso.Properties.Appearance.Options.UseFont = true;
            this.txtPeso.Size = new System.Drawing.Size(150, 30);
            this.txtPeso.TabIndex = 114;
            // 
            // grdPresentacion
            // 
            this.grdPresentacion.Enabled = false;
            this.grdPresentacion.Location = new System.Drawing.Point(278, 426);
            this.grdPresentacion.Name = "grdPresentacion";
            this.grdPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.grdPresentacion.Properties.Appearance.Options.UseFont = true;
            this.grdPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdPresentacion.Properties.DataSource = this.presentacionesBindingSource;
            this.grdPresentacion.Properties.DisplayMember = "descripcion";
            this.grdPresentacion.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdPresentacion.Properties.ValueMember = "id";
            this.grdPresentacion.Size = new System.Drawing.Size(233, 30);
            this.grdPresentacion.TabIndex = 116;
            this.grdPresentacion.EditValueChanged += new System.EventHandler(this.grdPresentacion_EditValueChanged);
            // 
            // presentacionesBindingSource
            // 
            this.presentacionesBindingSource.DataMember = "presentaciones";
            this.presentacionesBindingSource.DataSource = this.dsLogistica21;
            // 
            // dsLogistica21
            // 
            this.dsLogistica21.DataSetName = "dsLogistica2";
            this.dsLogistica21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colfactor});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Presentacion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colfactor
            // 
            this.colfactor.FieldName = "factor";
            this.colfactor.Name = "colfactor";
            // 
            // txtLoteMP
            // 
            this.txtLoteMP.Enabled = false;
            this.txtLoteMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtLoteMP.Location = new System.Drawing.Point(277, 384);
            this.txtLoteMP.Name = "txtLoteMP";
            this.txtLoteMP.Size = new System.Drawing.Size(234, 29);
            this.txtLoteMP.TabIndex = 117;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(187, 472);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 24);
            this.labelControl1.TabIndex = 118;
            this.labelControl1.Text = "Unidades:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(224, 523);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 24);
            this.labelControl3.TabIndex = 119;
            this.labelControl3.Text = "Peso:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(196, 389);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 24);
            this.labelControl4.TabIndex = 120;
            this.labelControl4.Text = "Lote MP:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(157, 432);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 24);
            this.labelControl5.TabIndex = 121;
            this.labelControl5.Text = "Presentacion:";
            // 
            // tsEditarTarima
            // 
            this.tsEditarTarima.Enabled = false;
            this.tsEditarTarima.Location = new System.Drawing.Point(293, 336);
            this.tsEditarTarima.Name = "tsEditarTarima";
            this.tsEditarTarima.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tsEditarTarima.Properties.Appearance.Options.UseFont = true;
            this.tsEditarTarima.Properties.OffText = "No";
            this.tsEditarTarima.Properties.OnText = "Si";
            this.tsEditarTarima.Size = new System.Drawing.Size(153, 32);
            this.tsEditarTarima.TabIndex = 122;
            this.tsEditarTarima.Toggled += new System.EventHandler(this.tsEditarTarima_Toggled);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(234, 340);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 24);
            this.labelControl6.TabIndex = 123;
            this.labelControl6.Text = "Editar ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseBackColor = true;
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(268, 577);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 48);
            this.btnGuardar.TabIndex = 124;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(268, 654);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(160, 48);
            this.cmdClose.TabIndex = 125;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClear.ImageOptions.SvgImage")));
            this.btnClear.Location = new System.Drawing.Point(516, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 44);
            this.btnClear.TabIndex = 126;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUnidades.Location = new System.Drawing.Point(278, 469);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtUnidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnidades.Size = new System.Drawing.Size(150, 30);
            this.txtUnidades.TabIndex = 127;
            this.txtUnidades.TextChanged += new System.EventHandler(this.txtUnidades_TextChanged);
            // 
            // vGridDatosTarima
            // 
            this.vGridDatosTarima.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridDatosTarima.CustomizationFormBounds = new System.Drawing.Rectangle(1493, 461, 210, 254);
            this.vGridDatosTarima.DataMember = "validacion_tarimas";
            this.vGridDatosTarima.DataSource = this.dsLogistica21;
            this.vGridDatosTarima.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGridDatosTarima.Location = new System.Drawing.Point(8, 62);
            this.vGridDatosTarima.Name = "vGridDatosTarima";
            this.vGridDatosTarima.OptionsBehavior.Editable = false;
            this.vGridDatosTarima.RecordWidth = 250;
            this.vGridDatosTarima.RowHeaderWidth = 250;
            this.vGridDatosTarima.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowid,
            this.rowid_materia_prima,
            this.rowcodigo_barra,
            this.rowitemcode,
            this.rowmp,
            this.rowid_proveedor,
            this.rowproveedor,
            this.rowfecha_ingreso,
            this.rownumero_transaccion,
            this.rowfecha_vencimiento,
            this.rowfecha_produccion_materia_prima,
            this.rowlote_materia_prima,
            this.rowid_presentacion,
            this.rowpresentacion,
            this.rowid_usuario,
            this.rowid_boleta,
            this.rowcantidad,
            this.rowpeso,
            this.rowid_estado_calidad,
            this.rowid_ingreso,
            this.rowid_estado_tarima,
            this.rowdescripcion,
            this.rowfactor_activo});
            this.vGridDatosTarima.Size = new System.Drawing.Size(661, 246);
            this.vGridDatosTarima.TabIndex = 113;
            // 
            // rowid
            // 
            this.rowid.Name = "rowid";
            this.rowid.Properties.Caption = "id";
            this.rowid.Properties.FieldName = "id";
            this.rowid.Visible = false;
            // 
            // rowid_materia_prima
            // 
            this.rowid_materia_prima.Name = "rowid_materia_prima";
            this.rowid_materia_prima.Properties.Caption = "id_materia_prima";
            this.rowid_materia_prima.Properties.FieldName = "id_materia_prima";
            this.rowid_materia_prima.Visible = false;
            // 
            // rowcodigo_barra
            // 
            this.rowcodigo_barra.Name = "rowcodigo_barra";
            this.rowcodigo_barra.Properties.Caption = "Codigo de Barra";
            this.rowcodigo_barra.Properties.FieldName = "codigo_barra";
            // 
            // rowitemcode
            // 
            this.rowitemcode.Height = 16;
            this.rowitemcode.Name = "rowitemcode";
            this.rowitemcode.Properties.Caption = "Item Code";
            this.rowitemcode.Properties.FieldName = "itemcode";
            // 
            // rowmp
            // 
            this.rowmp.Height = 16;
            this.rowmp.Name = "rowmp";
            this.rowmp.Properties.Caption = "Materia Prima";
            this.rowmp.Properties.FieldName = "mp";
            // 
            // rowid_proveedor
            // 
            this.rowid_proveedor.Name = "rowid_proveedor";
            this.rowid_proveedor.Properties.Caption = "id_proveedor";
            this.rowid_proveedor.Properties.FieldName = "id_proveedor";
            this.rowid_proveedor.Visible = false;
            // 
            // rowproveedor
            // 
            this.rowproveedor.Name = "rowproveedor";
            this.rowproveedor.Properties.Caption = "Proveedor";
            this.rowproveedor.Properties.FieldName = "proveedor";
            // 
            // rowfecha_ingreso
            // 
            this.rowfecha_ingreso.Name = "rowfecha_ingreso";
            this.rowfecha_ingreso.Properties.Caption = "Fecha Ingreso";
            this.rowfecha_ingreso.Properties.FieldName = "fecha_ingreso";
            // 
            // rownumero_transaccion
            // 
            this.rownumero_transaccion.Name = "rownumero_transaccion";
            this.rownumero_transaccion.Properties.Caption = "Num. Ingreso";
            this.rownumero_transaccion.Properties.FieldName = "numero_transaccion";
            // 
            // rowfecha_vencimiento
            // 
            this.rowfecha_vencimiento.Height = 16;
            this.rowfecha_vencimiento.Name = "rowfecha_vencimiento";
            this.rowfecha_vencimiento.Properties.Caption = "F. Vencimiento";
            this.rowfecha_vencimiento.Properties.FieldName = "fecha_vencimiento";
            // 
            // rowfecha_produccion_materia_prima
            // 
            this.rowfecha_produccion_materia_prima.Name = "rowfecha_produccion_materia_prima";
            this.rowfecha_produccion_materia_prima.Properties.Caption = "F. Produccion ";
            this.rowfecha_produccion_materia_prima.Properties.FieldName = "fecha_produccion_materia_prima";
            // 
            // rowlote_materia_prima
            // 
            this.rowlote_materia_prima.Height = 16;
            this.rowlote_materia_prima.Name = "rowlote_materia_prima";
            this.rowlote_materia_prima.Properties.Caption = "Lote";
            this.rowlote_materia_prima.Properties.FieldName = "lote_materia_prima";
            // 
            // rowid_presentacion
            // 
            this.rowid_presentacion.Name = "rowid_presentacion";
            this.rowid_presentacion.Properties.Caption = "id_presentacion";
            this.rowid_presentacion.Properties.FieldName = "id_presentacion";
            this.rowid_presentacion.Visible = false;
            // 
            // rowpresentacion
            // 
            this.rowpresentacion.Height = 16;
            this.rowpresentacion.Name = "rowpresentacion";
            this.rowpresentacion.Properties.Caption = "Presentacion";
            this.rowpresentacion.Properties.FieldName = "presentacion";
            // 
            // rowid_usuario
            // 
            this.rowid_usuario.Name = "rowid_usuario";
            this.rowid_usuario.Properties.Caption = "id_usuario";
            this.rowid_usuario.Properties.FieldName = "id_usuario";
            this.rowid_usuario.Visible = false;
            // 
            // rowid_boleta
            // 
            this.rowid_boleta.Name = "rowid_boleta";
            this.rowid_boleta.Properties.Caption = "id_boleta";
            this.rowid_boleta.Properties.FieldName = "id_boleta";
            this.rowid_boleta.Visible = false;
            // 
            // rowcantidad
            // 
            this.rowcantidad.Name = "rowcantidad";
            this.rowcantidad.Properties.Caption = "Unidades Existentes";
            this.rowcantidad.Properties.FieldName = "cantidad";
            // 
            // rowpeso
            // 
            this.rowpeso.Name = "rowpeso";
            this.rowpeso.Properties.Caption = "Peso Tarima Existente";
            this.rowpeso.Properties.FieldName = "peso";
            // 
            // rowid_estado_calidad
            // 
            this.rowid_estado_calidad.Name = "rowid_estado_calidad";
            this.rowid_estado_calidad.Properties.Caption = "id_estado_calidad";
            this.rowid_estado_calidad.Properties.FieldName = "id_estado_calidad";
            this.rowid_estado_calidad.Visible = false;
            // 
            // rowid_ingreso
            // 
            this.rowid_ingreso.Name = "rowid_ingreso";
            this.rowid_ingreso.Properties.Caption = "id_ingreso";
            this.rowid_ingreso.Properties.FieldName = "id_ingreso";
            this.rowid_ingreso.Visible = false;
            // 
            // rowid_estado_tarima
            // 
            this.rowid_estado_tarima.Name = "rowid_estado_tarima";
            this.rowid_estado_tarima.Properties.Caption = "id_estado_tarima";
            this.rowid_estado_tarima.Properties.FieldName = "id_estado_tarima";
            this.rowid_estado_tarima.Visible = false;
            // 
            // rowdescripcion
            // 
            this.rowdescripcion.Name = "rowdescripcion";
            this.rowdescripcion.Properties.Caption = "Estado";
            this.rowdescripcion.Properties.FieldName = "descripcion";
            // 
            // rowfactor_activo
            // 
            this.rowfactor_activo.Name = "rowfactor_activo";
            this.rowfactor_activo.Properties.AllowEdit = false;
            this.rowfactor_activo.Properties.Caption = "factor_activo";
            this.rowfactor_activo.Properties.FieldName = "factor_activo";
            this.rowfactor_activo.Visible = false;
            // 
            // timerLimpiarMensaje
            // 
            this.timerLimpiarMensaje.Interval = 2000;
            this.timerLimpiarMensaje.Tick += new System.EventHandler(this.timerLimpiarMensaje_Tick);
            // 
            // frmValidacionTarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 841);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tsEditarTarima);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLoteMP);
            this.Controls.Add(this.grdPresentacion);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.vGridDatosTarima);
            this.Controls.Add(this.panelNotificacion);
            this.Controls.Add(this.txtTarima);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmValidacionTarimas";
            this.Text = "Validacion de Tarimas";
            ((System.ComponentModel.ISupportInitialize)(this.txtTarima.Properties)).EndInit();
            this.panelNotificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogistica21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsEditarTarima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridDatosTarima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit txtTarima;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panelNotificacion;
        private System.Windows.Forms.Label lblMensaje;
        private DevExpress.XtraVerticalGrid.VGridControl vGridDatosTarima;
        private dsLogistica2 dsLogistica21;
        private DevExpress.XtraEditors.TextEdit txtPeso;
        private DevExpress.XtraEditors.GridLookUpEdit grdPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.TextBox txtLoteMP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ToggleSwitch tsEditarTarima;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SpinEdit txtUnidades;
        private System.Windows.Forms.BindingSource presentacionesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colfactor;
        private System.Windows.Forms.Timer timerLimpiarMensaje;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_materia_prima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcodigo_barra;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowitemcode;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowmp;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_proveedor;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowproveedor;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowfecha_ingreso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rownumero_transaccion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowfecha_vencimiento;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowfecha_produccion_materia_prima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowlote_materia_prima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_presentacion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpresentacion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_usuario;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_boleta;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowcantidad;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowpeso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_estado_calidad;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_ingreso;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowid_estado_tarima;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowdescripcion;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowfactor_activo;
    }
}