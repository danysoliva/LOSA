using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace LOSA.RecepcionMP
{
    partial class frmMP_Granel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMP_Granel));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcMP = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvMP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshipid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEditBarco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bindingSourceBarcos = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBoleta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPesoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.cmdPasarAlosy = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLoteActivo = new DevExpress.XtraEditors.SimpleButton();
            this.checkBoxSeleccionarTodas = new System.Windows.Forms.CheckBox();
            this.cmdGenerarIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.colid_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSourceUbicaciones = new System.Windows.Forms.BindingSource(this.components);
            this.GridLookUpEditUbicaciones = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBarcos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPasarAlosy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtras.Location = new System.Drawing.Point(996, 7);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(166, 56);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gcMP
            // 
            this.gcMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMP.DataMember = "granel";
            this.gcMP.DataSource = this.dsRecepcionMPx1;
            this.gcMP.Location = new System.Drawing.Point(0, 111);
            this.gcMP.MainView = this.gvMP;
            this.gcMP.Name = "gcMP";
            this.gcMP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdPasarAlosy,
            this.checkSeleccionar,
            this.gridLookUpEditBarco,
            this.GridLookUpEditUbicaciones});
            this.gcMP.Size = new System.Drawing.Size(1167, 541);
            this.gcMP.TabIndex = 7;
            this.gcMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMP});
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMP
            // 
            this.gvMP.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMP.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMP.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvMP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMP.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.Row.Options.UseFont = true;
            this.gvMP.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMP.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMP.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colid_ubicacion,
            this.colPesoBruto,
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
            this.gvMP.GridControl = this.gcMP;
            this.gvMP.Name = "gvMP";
            this.gvMP.OptionsCustomization.AllowFilter = false;
            this.gvMP.OptionsFilter.AllowFilterEditor = false;
            this.gvMP.OptionsView.ShowAutoFilterRow = true;
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
            this.colshipid.ColumnEdit = this.gridLookUpEditBarco;
            this.colshipid.FieldName = "shipid";
            this.colshipid.Name = "colshipid";
            this.colshipid.Visible = true;
            this.colshipid.VisibleIndex = 7;
            // 
            // gridLookUpEditBarco
            // 
            this.gridLookUpEditBarco.AutoHeight = false;
            this.gridLookUpEditBarco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditBarco.DataSource = this.bindingSourceBarcos;
            this.gridLookUpEditBarco.DisplayMember = "descripcion";
            this.gridLookUpEditBarco.Name = "gridLookUpEditBarco";
            this.gridLookUpEditBarco.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.gridLookUpEditBarco.ValueMember = "id";
            // 
            // bindingSourceBarcos
            // 
            this.bindingSourceBarcos.DataMember = "barcos";
            this.bindingSourceBarcos.DataSource = this.dsRecepcionMPx1;
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
            this.coldescripcion.Caption = "Seleccione el Barco";
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
            // 
            // colNBoleta
            // 
            this.colNBoleta.FieldName = "NBoleta";
            this.colNBoleta.Name = "colNBoleta";
            this.colNBoleta.OptionsColumn.AllowEdit = false;
            this.colNBoleta.Visible = true;
            this.colNBoleta.VisibleIndex = 1;
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
            this.colPesoProd.VisibleIndex = 2;
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
            this.colTipoBoleta.Visible = true;
            this.colTipoBoleta.VisibleIndex = 3;
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
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 5;
            // 
            // col_Registrar
            // 
            this.col_Registrar.Caption = "Registrar Lote";
            this.col_Registrar.ColumnEdit = this.cmdPasarAlosy;
            this.col_Registrar.Name = "col_Registrar";
            // 
            // cmdPasarAlosy
            // 
            this.cmdPasarAlosy.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdPasarAlosy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdPasarAlosy.Name = "cmdPasarAlosy";
            this.cmdPasarAlosy.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdPasarAlosy.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdPasarAlosy_ButtonClick);
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 9;
            // 
            // checkSeleccionar
            // 
            this.checkSeleccionar.AutoHeight = false;
            this.checkSeleccionar.Name = "checkSeleccionar";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recepción de Materia Prima Granel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLoteActivo
            // 
            this.cmdLoteActivo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdLoteActivo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoteActivo.Appearance.Options.UseBackColor = true;
            this.cmdLoteActivo.Appearance.Options.UseFont = true;
            this.cmdLoteActivo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLoteActivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoteActivo.ImageOptions.Image")));
            this.cmdLoteActivo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdLoteActivo.Location = new System.Drawing.Point(12, 7);
            this.cmdLoteActivo.Name = "cmdLoteActivo";
            this.cmdLoteActivo.Size = new System.Drawing.Size(166, 56);
            this.cmdLoteActivo.TabIndex = 10;
            this.cmdLoteActivo.Text = "Conf. Lote Activo";
            this.cmdLoteActivo.Click += new System.EventHandler(this.cmdLoteActivo_Click);
            // 
            // checkBoxSeleccionarTodas
            // 
            this.checkBoxSeleccionarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSeleccionarTodas.AutoSize = true;
            this.checkBoxSeleccionarTodas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSeleccionarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSeleccionarTodas.Location = new System.Drawing.Point(963, 81);
            this.checkBoxSeleccionarTodas.Name = "checkBoxSeleccionarTodas";
            this.checkBoxSeleccionarTodas.Size = new System.Drawing.Size(159, 24);
            this.checkBoxSeleccionarTodas.TabIndex = 11;
            this.checkBoxSeleccionarTodas.Text = "Seleccionar Todas";
            this.checkBoxSeleccionarTodas.UseVisualStyleBackColor = true;
            this.checkBoxSeleccionarTodas.CheckedChanged += new System.EventHandler(this.checkBoxSeleccionarTodas_CheckedChanged);
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
            this.cmdGenerarIngreso.Location = new System.Drawing.Point(824, 7);
            this.cmdGenerarIngreso.Name = "cmdGenerarIngreso";
            this.cmdGenerarIngreso.Size = new System.Drawing.Size(166, 56);
            this.cmdGenerarIngreso.TabIndex = 12;
            this.cmdGenerarIngreso.Text = "Generar Ingreso";
            this.cmdGenerarIngreso.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colid_ubicacion
            // 
            this.colid_ubicacion.Caption = "Ubicación Almacén";
            this.colid_ubicacion.ColumnEdit = this.GridLookUpEditUbicaciones;
            this.colid_ubicacion.FieldName = "id_ubicacion";
            this.colid_ubicacion.Name = "colid_ubicacion";
            this.colid_ubicacion.Visible = true;
            this.colid_ubicacion.VisibleIndex = 8;
            // 
            // bindingSourceUbicaciones
            // 
            this.bindingSourceUbicaciones.DataMember = "ubicaciones_granel";
            this.bindingSourceUbicaciones.DataSource = this.dsRecepcionMPx1;
            // 
            // GridLookUpEditUbicaciones
            // 
            this.GridLookUpEditUbicaciones.AutoHeight = false;
            this.GridLookUpEditUbicaciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditUbicaciones.DataSource = this.bindingSourceUbicaciones;
            this.GridLookUpEditUbicaciones.DisplayMember = "rack";
            this.GridLookUpEditUbicaciones.Name = "GridLookUpEditUbicaciones";
            this.GridLookUpEditUbicaciones.PopupView = this.gridView1;
            this.GridLookUpEditUbicaciones.ValueMember = "id";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colrack,
            this.colcodigo_barra});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colrack
            // 
            this.colrack.Caption = "Seleccione la Ubicación";
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
            // frmMP_Granel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 657);
            this.Controls.Add(this.cmdGenerarIngreso);
            this.Controls.Add(this.checkBoxSeleccionarTodas);
            this.Controls.Add(this.cmdLoteActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcMP);
            this.Name = "frmMP_Granel";
            this.Text = "Recepción MP Granel";
            ((System.ComponentModel.ISupportInitialize)(this.gcMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBarcos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPasarAlosy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.GridControl gcMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMP;
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
        private DevExpress.XtraGrid.Columns.GridColumn col_Registrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdPasarAlosy;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdLoteActivo;
        private System.Windows.Forms.CheckBox checkBoxSeleccionarTodas;
        private RepositoryItemCheckEdit checkSeleccionar;
        private GridColumn colseleccionar;
        private DevExpress.XtraEditors.SimpleButton cmdGenerarIngreso;
        private RepositoryItemGridLookUpEdit gridLookUpEditBarco;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSourceBarcos;
        private GridColumn colid1;
        private GridColumn coldescripcion;
        private GridColumn colid_ubicacion;
        private System.Windows.Forms.BindingSource bindingSourceUbicaciones;
        private RepositoryItemGridLookUpEdit GridLookUpEditUbicaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GridColumn colid2;
        private GridColumn colrack;
        private GridColumn colcodigo_barra;
    }
}